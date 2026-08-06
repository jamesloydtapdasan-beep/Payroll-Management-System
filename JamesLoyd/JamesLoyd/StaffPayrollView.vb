Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class StaffPayrollView

    Private conn As New MySqlConnection("server=localhost;user id=root;password=;database=payrolldb")

    Private fixedSalary As Decimal
    Private totalOTPay As Decimal
    Private totalDeductions As Decimal
    Private totalAbsentDays As Integer

    '========================
    ' Form Load
    '========================
    Private Sub StaffPayrollView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetupAttendanceGrid()

        ' Populate Month
        cmbMonth.Items.Clear()
        For i As Integer = 1 To 12
            cmbMonth.Items.Add(New DateTime(2000, i, 1).ToString("MMMM"))
        Next

        ' Populate Year
        cmbYear.Items.Clear()
        For y As Integer = DateTime.Now.Year To DateTime.Now.Year - 10 Step -1
            cmbYear.Items.Add(y.ToString())
        Next

        cmbMonth.SelectedItem = DateTime.Now.ToString("MMMM")
        cmbYear.SelectedItem = DateTime.Now.Year.ToString()

        ' Load Employees
        Dim dt As New DataTable()
        Try
            conn.Open()
            Using cmd As New MySqlCommand("
                SELECT employee_id,
                       CONCAT(first_name, ' ', last_name) AS full_name
                FROM employees", conn)

                Dim adp As New MySqlDataAdapter(cmd)
                adp.Fill(dt)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employees: " & ex.Message)
        Finally
            conn.Close()
        End Try

        cmbEmployees.DataSource = dt
        cmbEmployees.DisplayMember = "full_name"
        cmbEmployees.ValueMember = "employee_id"
        cmbEmployees.SelectedIndex = -1

    End Sub

    '========================
    ' DataGridView Setup
    '========================
    Private Sub SetupAttendanceGrid()
        With dgvAttendance
            .AutoGenerateColumns = False
            .Columns.Clear()

            .Columns.Add("colDate", "Date")
            .Columns.Add("colRegular", "Regular Hours")
            .Columns.Add("colTotal", "Total Hours")
            .Columns.Add("colRendered", "Hours Rendered")
            .Columns.Add("colOT", "Overtime Hours")

            .Columns("colDate").Width = 100
            .Columns("colRegular").Width = 120
            .Columns("colTotal").Width = 120
            .Columns("colRendered").Width = 130
            .Columns("colOT").Width = 120
        End With
    End Sub

    '========================
    ' Date Helpers
    '========================
    Private Function GetSelectedStartDate() As Date
        Dim m As Integer = DateTime.ParseExact(cmbMonth.SelectedItem.ToString(), "MMMM", Nothing).Month
        Dim y As Integer = Integer.Parse(cmbYear.SelectedItem.ToString())
        Return New Date(y, m, 1)
    End Function

    Private Function GetSelectedEndDate() As Date
        Return GetSelectedStartDate().AddMonths(1).AddDays(-1)
    End Function

    '========================
    ' Prepare Payroll
    '========================
    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click

        If cmbEmployees.SelectedItem Is Nothing Then
            MessageBox.Show("Select an employee first.")
            Exit Sub
        End If

        Dim empID As String =
            DirectCast(cmbEmployees.SelectedItem, DataRowView)("employee_id").ToString()

        dgvAttendance.Rows.Clear()

        Dim startDate = GetSelectedStartDate()
        Dim endDate = GetSelectedEndDate()

        Try
            conn.Open()

            '================ EMPLOYEE INFO =================
            Dim empCmd As New MySqlCommand("
                SELECT first_name, last_name, position, department, salary
                FROM employees
                WHERE employee_id = @id", conn)

            empCmd.Parameters.AddWithValue("@id", empID)

            Using r = empCmd.ExecuteReader()
                If r.Read() Then
                    txtFullName1.Text = r("first_name") & " " & r("last_name")
                    txtPosition1.Text = r("position").ToString()
                    txtDepartment1.Text = r("department").ToString()

                    fixedSalary = Convert.ToDecimal(r("salary"))
                    txtMonthlySalary.Text = "₱" & fixedSalary.ToString("N2")
                End If
            End Using

            '================ TIME LOGS =================
            Dim dailyLog As New Dictionary(Of Date, Decimal)
            Dim workedDates As New HashSet(Of Date)

            Dim timeCmd As New MySqlCommand("
                SELECT date, time_in, time_out
                FROM time_logs
                WHERE employee_id = @id
                AND date BETWEEN @s AND @e", conn)

            timeCmd.Parameters.AddWithValue("@id", empID)
            timeCmd.Parameters.AddWithValue("@s", startDate)
            timeCmd.Parameters.AddWithValue("@e", endDate)

            Using r = timeCmd.ExecuteReader()
                While r.Read()
                    If Not IsDBNull(r("time_in")) AndAlso Not IsDBNull(r("time_out")) Then
                        Dim d = Convert.ToDateTime(r("date")).Date
                        Dim h = (Convert.ToDateTime(r("time_out")) -
                                 Convert.ToDateTime(r("time_in"))).TotalHours

                        If Not dailyLog.ContainsKey(d) Then dailyLog(d) = 0
                        dailyLog(d) += CDec(h)
                    End If
                End While
            End Using

            '================ HOURS =================
            Dim totalReg As Decimal = 0
            Dim totalOT As Decimal = 0

            For Each kvp In dailyLog
                workedDates.Add(kvp.Key)
                If kvp.Value > 8 Then
                    totalReg += 8
                    totalOT += kvp.Value - 8
                Else
                    totalReg += kvp.Value
                End If
            Next

            '================ ABSENCES =================
            Dim workingDays As Integer = 22
            totalAbsentDays = workingDays - workedDates.Count
            If totalAbsentDays < 0 Then totalAbsentDays = 0

            txtDays.Text = workedDates.Count.ToString()
            txtTotalAbsent.Text = totalAbsentDays.ToString()
            txtHours.Text = totalReg.ToString("N2") & " hrs"
            txtOvertime.Text = totalOT.ToString("N2") & " hrs"

            '================ PAY =================
            totalOTPay = totalOT * (fixedSalary / (22D * 8D) * 1.25D)
            Dim grossPay = fixedSalary + totalOTPay

            txtBasicPay.Text = "₱" & fixedSalary.ToString("N2")
            txtOTPay.Text = "₱" & totalOTPay.ToString("N2")
            txtGrossPay.Text = "₱" & grossPay.ToString("N2")

            Dim sss = 500D, phil = 350D, pag = 200D
            Dim absentDeduction = totalAbsentDays * (fixedSalary / 22D)
            totalDeductions = sss + phil + pag + absentDeduction

            txtSSS.Text = "₱" & sss.ToString("N2")
            txtPhilHealth.Text = "₱" & phil.ToString("N2")
            txtPagIbig.Text = "₱" & pag.ToString("N2")
            txtTotalDeductions.Text = "₱" & totalDeductions.ToString("N2")

            txtPayNet.Text = "₱" & (grossPay - totalDeductions).ToString("N2")

            '================ GRID FILL =================
            For Each kvp In dailyLog
                Dim ot = Math.Max(0, kvp.Value - 8)
                dgvAttendance.Rows.Add(
                    kvp.Key.ToShortDateString(),
                    Math.Min(8, kvp.Value),
                    kvp.Value,
                    kvp.Value,
                    ot
                )
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    '========================
    ' Send to Admin
    '========================
    Private Sub btnSendToAdmin_Click(sender As Object, e As EventArgs) Handles btnSendToAdmin.Click

        If cmbEmployees.SelectedItem Is Nothing Then Exit Sub

        Dim empID =
            DirectCast(cmbEmployees.SelectedItem, DataRowView)("employee_id").ToString()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("
                INSERT INTO prepared_payroll
                (employee_id, period_start, period_end,
                 basic_pay, overtime_pay, absences,
                 sss, philhealth, pagibig,
                 gross_pay, net_pay, status)
                VALUES
                (@eid,@ps,@pe,@bp,@otp,@abs,@sss,@ph,@pg,@gp,@np,'Pending')", conn)

            cmd.Parameters.AddWithValue("@eid", empID)
            cmd.Parameters.AddWithValue("@ps", GetSelectedStartDate())
            cmd.Parameters.AddWithValue("@pe", GetSelectedEndDate())
            cmd.Parameters.AddWithValue("@bp", fixedSalary)
            cmd.Parameters.AddWithValue("@otp", totalOTPay)
            cmd.Parameters.AddWithValue("@abs", totalAbsentDays)
            cmd.Parameters.AddWithValue("@sss", 500D)
            cmd.Parameters.AddWithValue("@ph", 350D)
            cmd.Parameters.AddWithValue("@pg", 200D)
            cmd.Parameters.AddWithValue("@gp", fixedSalary + totalOTPay)
            cmd.Parameters.AddWithValue("@np", (fixedSalary + totalOTPay) - totalDeductions)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Payroll sent to Admin.")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        StaffDashboard.Show()
    End Sub

End Class
