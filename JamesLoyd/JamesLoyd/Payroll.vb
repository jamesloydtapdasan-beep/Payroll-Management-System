Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class frmPayRoll
    Private conn As New MySqlConnection("server=localhost;user id=root;password=;database=payrolldb")
    Private fixedSalary As Decimal
    Private totalOTPay As Decimal
    Private totalDeductions As Decimal
    Private totalAbsentDays As Integer

    Private Sub frmPayRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMonth.Items.Clear()
        For i As Integer = 1 To 12
            cmbMonth.Items.Add(New DateTime(2000, i, 1).ToString("MMMM"))
        Next

        cmbYear.Items.Clear()
        For y As Integer = DateTime.Now.Year To DateTime.Now.Year - 10 Step -1
            cmbYear.Items.Add(y.ToString())
        Next

        cmbMonth.SelectedItem = DateTime.Now.ToString("MMMM")
        cmbYear.SelectedItem = DateTime.Now.Year.ToString()
    End Sub

    Private Function GetSelectedStartDate() As Date
        Dim selectedMonth As Integer = DateTime.ParseExact(cmbMonth.SelectedItem.ToString(), "MMMM", Nothing).Month
        Dim selectedYear As Integer = Integer.Parse(cmbYear.SelectedItem.ToString())
        Return New Date(selectedYear, selectedMonth, 1)
    End Function

    Private Function GetSelectedEndDate() As Date
        Return GetSelectedStartDate().AddMonths(1).AddDays(-1)
    End Function

    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        Dim empID = txtEmploID1.Text.Trim()

        ' Reset Fields
        txtOTPay.Text = "₱0.00"
        txtBasicPay.Text = "₱0.00"
        txtGrossPay.Text = "₱0.00"
        txtSSS.Text = "₱0.00"
        txtPhilHealth.Text = "₱0.00"
        txtPagIbig.Text = "₱0.00"
        txtTotalDeductions.Text = "₱0.00"
        txtPayNet.Text = "₱0.00"
        txtHours.Text = "0.00 hrs"
        txtOvertime.Text = "0.00 hrs"
        txtTotalAbsent.Text = "0"
        txtDays.Text = "0"
        txtMonthlySalary.Text = ""

        If empID = "" Then
            MessageBox.Show("Please enter an Employee ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cmbMonth.SelectedItem Is Nothing OrElse cmbYear.SelectedItem Is Nothing Then
            MessageBox.Show("Please select both Month and Year.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim startDate = GetSelectedStartDate()
        Dim endDate = GetSelectedEndDate()

        Try
            conn.Open()

            ' --- Employee Info ---
            Dim empCmd As New MySqlCommand("SELECT first_name, last_name, position, department, salary, date_hired FROM employees WHERE employee_id = @id", conn)

            empCmd.Parameters.AddWithValue("@id", empID)
            Dim empReader = empCmd.ExecuteReader()

            Dim hireDate As Date

            If empReader.Read() Then
                txtFullName1.Text = empReader("first_name").ToString & " " & empReader("last_name").ToString
                txtPosition1.Text = empReader("position").ToString
                txtDepartment1.Text = empReader("department").ToString
                Dim rawSalary As Object = empReader("salary")
                If IsDBNull(rawSalary) Then
                    fixedSalary = 0D
                Else
                    fixedSalary = Decimal.Parse(rawSalary.ToString())
                End If

                txtMonthlySalary.Text = "₱" & fixedSalary.ToString("N2")
                hireDate = If(IsDBNull(empReader("date_hired")), Date.Today, Convert.ToDateTime(empReader("date_hired")))
            Else
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                empReader.Close()
                Exit Sub
            End If
            empReader.Close()

            ' --- Time Logs ---
            Dim dailyLog As New Dictionary(Of Date, Decimal)
            Dim totalRegularHours As Decimal = 0
            Dim totalOvertimeHours As Decimal = 0
            Dim workedDates As New HashSet(Of Date)

            Dim timeCmd As New MySqlCommand("SELECT time_in, time_out, date FROM time_logs WHERE employee_id = @id AND date BETWEEN @start AND @end", conn)
            timeCmd.Parameters.AddWithValue("@id", empID)
            timeCmd.Parameters.AddWithValue("@start", startDate)
            timeCmd.Parameters.AddWithValue("@end", endDate)
            Dim reader = timeCmd.ExecuteReader()

            While reader.Read()
                If Not IsDBNull(reader("time_in")) AndAlso Not IsDBNull(reader("time_out")) Then
                    Dim dateKey As Date = Convert.ToDateTime(reader("date")).Date
                    Dim timeIn As DateTime = Convert.ToDateTime(reader("time_in"))
                    Dim timeOut As DateTime = Convert.ToDateTime(reader("time_out"))
                    Dim hoursWorked As Decimal = Convert.ToDecimal((timeOut - timeIn).TotalHours)

                    If Not dailyLog.ContainsKey(dateKey) Then
                        dailyLog(dateKey) = 0
                    End If
                    dailyLog(dateKey) += hoursWorked
                End If
            End While
            reader.Close()

            ' --- Hours Classification ---
            For Each kvp In dailyLog
                Dim hours = kvp.Value
                workedDates.Add(kvp.Key)

                If hours > 8 Then
                    totalRegularHours += 8
                    totalOvertimeHours += hours - 8
                Else
                    totalRegularHours += hours
                End If
            Next

            ' --- Working Days (Excludes Weekends) ---
            Dim effectiveStartDate As Date = If(hireDate > New Date(startDate.Year, startDate.Month, 1),
                                        hireDate,
                                        New Date(startDate.Year, startDate.Month, 1))

            Dim totalWorkingDays As Integer = 0
            Dim datePtr As Date = effectiveStartDate



            While datePtr <= endDate
                If datePtr.DayOfWeek <> DayOfWeek.Saturday AndAlso datePtr.DayOfWeek <> DayOfWeek.Sunday Then
                    Debug.WriteLine("Counting: " & datePtr.ToShortDateString())
                End If
                datePtr = datePtr.AddDays(1)
            End While



            ' --- Absences ---
            totalAbsentDays = totalWorkingDays - workedDates.Count
            If totalAbsentDays < 0 Then totalAbsentDays = 0

            ' --- Display ---
            txtTotalAbsent.Text = totalAbsentDays.ToString()
            txtDays.Text = workedDates.Count.ToString()
            txtHours.Text = totalRegularHours.ToString("N2") & " hrs"
            txtOvertime.Text = totalOvertimeHours.ToString("N2") & " hrs"





            ' --- Pay Calculation ---
            totalOTPay = totalOvertimeHours * (fixedSalary / (22D * 8D) * 1.25D)
            Dim grossPay = fixedSalary + totalOTPay
            txtOTPay.Text = "₱" & totalOTPay.ToString("N2")
            txtBasicPay.Text = "₱" & fixedSalary.ToString("N2")
            txtGrossPay.Text = "₱" & grossPay.ToString("N2")

            ' --- Deductions ---
            Dim sss = 500D, philHealth = 350D, pagIbig = 200D
            Dim absentDeduction = totalAbsentDays * (fixedSalary / 22D)

            txtSSS.Text = "₱" & sss.ToString("N2")
            txtPhilHealth.Text = "₱" & philHealth.ToString("N2")
            txtPagIbig.Text = "₱" & pagIbig.ToString("N2")

            totalDeductions = sss + philHealth + pagIbig + absentDeduction
            txtTotalDeductions.Text = "₱" & totalDeductions.ToString("N2")

            ' --- Net Pay ---
            Dim netPay = grossPay - totalDeductions
            txtPayNet.Text = "₱" & netPay.ToString("N2")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub




    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub btnSavePayroll_Click(sender As Object, e As EventArgs) Handles btnSavePayroll.Click
        If txtEmploID1.Text.Trim() = "" Then
            MessageBox.Show("No employee selected. Search for an employee first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtPayNet.Text = "₱0.00" Then
            MessageBox.Show("No payroll computed. Please run a search first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()

            Dim insertCmd As New MySqlCommand("INSERT INTO payroll 
            (employee_id, period_start, period_end, basic_pay, overtime_pay, absences, sss, philhealth, pagibig, gross_pay, net_pay) 
            VALUES 
            (@employee_id, @period_start, @period_end, @basic_pay, @overtime_pay, @absences, @sss, @philhealth, @pagibig, @gross_pay, @net_pay)", conn)

            insertCmd.Parameters.AddWithValue("@employee_id", txtEmploID1.Text.Trim())
            insertCmd.Parameters.AddWithValue("@period_start", GetSelectedStartDate())
            insertCmd.Parameters.AddWithValue("@period_end", GetSelectedEndDate())
            insertCmd.Parameters.AddWithValue("@basic_pay", fixedSalary)
            insertCmd.Parameters.AddWithValue("@overtime_pay", totalOTPay)
            insertCmd.Parameters.AddWithValue("@absences", totalAbsentDays)
            insertCmd.Parameters.AddWithValue("@sss", 500D)
            insertCmd.Parameters.AddWithValue("@philhealth", 350D)
            insertCmd.Parameters.AddWithValue("@pagibig", 200D)

            Dim grossPay = fixedSalary + totalOTPay
            Dim absentDeduction = totalAbsentDays * (fixedSalary / 22D)
            Dim totalDeduction = 500D + 350D + 200D + absentDeduction
            Dim netPay = grossPay - totalDeduction

            insertCmd.Parameters.AddWithValue("@gross_pay", grossPay)
            insertCmd.Parameters.AddWithValue("@net_pay", netPay)

            Dim result = insertCmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Payroll successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Payroll save failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        frmAdminApprove.Show()
        Me.Hide()
    End Sub
End Class
