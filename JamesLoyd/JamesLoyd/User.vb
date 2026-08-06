Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class EmployeePanel
    ' Database connection
    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=payrolldb;")
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader

    ' These are set during login
    Public LoggedInUsername As String
    Public LoggedInEmployeeID As Integer
    Public EmployeePaySlipInstance As New EmployeePaySlip()

    Public Property EmployeeID As String


    Private Sub EmployeePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeDetails()
        ' Load total hours, overtime, and last payslip when the form loads
        LoadEmployeeAttendance()
    End Sub

    Private Sub LoadEmployeeDetails()
        Try
            conn.Open()
            Dim sql As String = "SELECT * FROM employees WHERE username=@user"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", LoggedInUsername)
            reader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Store employee ID for later use
                LoggedInEmployeeID = Convert.ToInt32(reader("employee_id"))

                txtFullName.Text = reader("first_name").ToString() & " " & reader("last_name").ToString()
                txtPosition.Text = reader("position").ToString()
                txtEmployeeID.Text = LoggedInEmployeeID.ToString()
                txtLastLogin.Text = DateTime.Now.ToString("MMMM d, yyyy h:mm tt", CultureInfo.InvariantCulture)
            End If


            reader.Close()
        Catch ex As Exception
            MsgBox("Error loading employee details: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Load total hours worked, overtime hours, and last payslip
    Private Sub LoadEmployeeAttendance()
        Try
            ' Total hours
            Dim totalMinutes As Double = GetTotalMinutesWorked()
            Dim totalHours As Integer = Math.Floor(totalMinutes / 60)
            Dim remainingMinutes As Integer = Math.Floor(totalMinutes Mod 60)
            txtTotalH.Text = $"{totalHours}h {remainingMinutes}m"

            ' Overtime
            Dim overtimeHours As Double = GetOvertimeHours()
            txtOver.Text = Math.Round(overtimeHours, 2).ToString() & "h"

            ' Last Payslip
            GetLastPayslip()

        Catch ex As Exception
            MessageBox.Show("Error loading attendance data: " & ex.Message)
        End Try
    End Sub



    ' Get total minutes worked for the employee
    Private Function GetTotalMinutesWorked() As Double
        Dim totalMinutes As Double = 0
        Try
            conn.Open()
            Dim sql As String = "SELECT time_in, time_out FROM time_logs WHERE employee_id = @empID AND time_out IS NOT NULL"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
            reader = cmd.ExecuteReader()

            While reader.Read()
                Dim timeIn As DateTime = Convert.ToDateTime(reader("time_in"))
                Dim timeOut As DateTime = Convert.ToDateTime(reader("time_out"))
                totalMinutes += (timeOut - timeIn).TotalMinutes
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error fetching total minutes worked: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return totalMinutes
    End Function

    ' Get overtime hours for the employee (worked hours over 8 hours per day)
    Private Function GetOvertimeHours() As Double
        Dim overtimeHours As Double = 0
        Try
            conn.Open()
            Dim sql As String = "SELECT time_in, time_out FROM time_logs WHERE employee_id = @empID AND time_out IS NOT NULL"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
            reader = cmd.ExecuteReader()

            While reader.Read()
                Dim timeIn As DateTime = Convert.ToDateTime(reader("time_in"))
                Dim timeOut As DateTime = Convert.ToDateTime(reader("time_out"))
                Dim workedHours = (timeOut - timeIn).TotalHours

                ' If worked more than 8 hours, add overtime
                If workedHours > 8 Then
                    overtimeHours += (workedHours - 8)
                End If
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error fetching overtime hours: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return overtimeHours
    End Function

    ' Get the most recent payslip
    Private Sub GetLastPayslip()
        Try
            conn.Open()
            Dim sql As String = "SELECT basic_pay FROM payroll WHERE employee_id = @empID ORDER BY date_generated DESC LIMIT 1"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
            reader = cmd.ExecuteReader()

            If reader.Read() Then
                txtLastPayslipSalary.Text = "₱" & Convert.ToDecimal(reader("basic_pay")).ToString("N2")
            Else
                txtLastPayslipSalary.Text = "N/A"
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving last salary: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub HandleTimeIn(now As DateTime)
        Dim empID = Integer.Parse(txtEmployeeID.Text)
        Dim today = now.Date
        Dim shiftType As String = If(now.Hour < 13, "Morning", "Afternoon")

        Try
            conn.Open()
            Dim logsSql = "SELECT * FROM time_logs WHERE employee_id=@empID AND date=@date ORDER BY id"
            cmd = New MySqlCommand(logsSql, conn)
            cmd.Parameters.AddWithValue("@empID", empID)
            cmd.Parameters.AddWithValue("@date", today)
            reader = cmd.ExecuteReader()

            Dim logCount = 0
            Dim lastWasTimeIn = False

            While reader.Read
                logCount += 1
                If Not IsDBNull(reader("time_in")) AndAlso IsDBNull(reader("time_out")) Then
                    lastWasTimeIn = True
                ElseIf Not IsDBNull(reader("time_out")) Then
                    lastWasTimeIn = False
                End If
            End While
            reader.Close()

            If logCount >= 4 Then
                MessageBox.Show("Maximum of 4 logs reached for today.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                conn.Close()
                Return
            End If

            If lastWasTimeIn Then
                MessageBox.Show("You must time out before you can time in again.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                conn.Close()
                Return
            End If

            Dim insertSql = "INSERT INTO time_logs (employee_id, date, shift_type, time_in) VALUES (@empID, @date, @shiftType, @timeIn)"
            cmd = New MySqlCommand(insertSql, conn)
            cmd.Parameters.AddWithValue("@empID", empID)
            cmd.Parameters.AddWithValue("@date", today)
            cmd.Parameters.AddWithValue("@shiftType", shiftType)
            cmd.Parameters.AddWithValue("@timeIn", now)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Time in recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("Error: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HandleTimeOut()
        Dim empID As Integer = Integer.Parse(txtEmployeeID.Text)
        Dim today As Date = Date.Today

        Try
            conn.Open()
            Dim sql = "SELECT * FROM time_logs WHERE employee_id=@empID AND date=@date AND time_out IS NULL ORDER BY id DESC LIMIT 1"
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@empID", empID)
            cmd.Parameters.AddWithValue("@date", today)
            reader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim logID As Integer = reader("id")
                conn.Close()

                conn.Open()
                Dim updateSql = "UPDATE time_logs SET time_out=@timeOut WHERE id=@logID"
                cmd = New MySqlCommand(updateSql, conn)
                cmd.Parameters.AddWithValue("@timeOut", DateTime.Now)
                cmd.Parameters.AddWithValue("@logID", logID)
                cmd.ExecuteNonQuery()
                conn.Close()

                MessageBox.Show("Time out recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                conn.Close()
                MessageBox.Show("No active time-in found. You must time in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            conn.Close()
            MessageBox.Show("Error: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button event for Time In
    Private Sub btnTimeIn_Click(sender As Object, e As EventArgs) Handles btnTimeIn.Click
        Dim currentTime As DateTime = DateTime.Now
        Dim currentHour As Integer = currentTime.Hour

        ' Morning is from 00:00 to 11:59 (0 to 11 in 24hr format)
        If currentHour >= 0 AndAlso currentHour < 12 Then
            Dim con As New MySqlConnection("server=localhost;userid=root;password=;database=payrolldb")
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM time_logs WHERE employee_id = @empID AND date = CURDATE() AND shift_type = 'Morning'", con)
            Dim insertCmd As New MySqlCommand("INSERT INTO time_logs (employee_id, time_in, date, shift_type) VALUES (@empID, NOW(), CURDATE(), 'Morning')", con)

            Dim empID As Integer = Convert.ToInt32(txtEmployeeID.Text)
            checkCmd.Parameters.AddWithValue("@empID", empID)
            insertCmd.Parameters.AddWithValue("@empID", empID)

            Try
                con.Open()

                ' Check if a Morning Time-In already exists for today
                Dim alreadyTimedIn As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If alreadyTimedIn > 0 Then
                    MessageBox.Show("⚠️ You've already timed in for the Morning shift today.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' Proceed with logging
                insertCmd.ExecuteNonQuery()
                MessageBox.Show("✅ Morning Time-In recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("❌ Error logging time-in: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("⏰ You can only Time-In for Morning between 12:00 AM and 11:59 AM. Use the Afternoon button instead.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub btnTimeOut_Click(sender As Object, e As EventArgs) Handles btnTimeOut.Click
        Dim con As New MySqlConnection("server=localhost;userid=root;password=;database=payrolldb")
        Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM time_logs WHERE employee_id = @empID AND date = CURDATE() AND shift_type = 'Morning' AND time_out IS NULL", con)
        Dim updateCmd As New MySqlCommand("UPDATE time_logs SET time_out = NOW() WHERE employee_id = @empID AND date = CURDATE() AND shift_type = 'Morning' AND time_out IS NULL", con)

        Dim empID As Integer = Convert.ToInt32(txtEmployeeID.Text)
        checkCmd.Parameters.AddWithValue("@empID", empID)
        updateCmd.Parameters.AddWithValue("@empID", empID)

        Try
            con.Open()

            ' Check if there’s a Morning Time-In without a Time-Out
            Dim canTimeOut As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If canTimeOut = 0 Then
                MessageBox.Show("⚠️ You haven't timed in for the Morning shift yet, or you've already timed out.", "Invalid Time-Out", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Proceed with Time-Out
            Dim rowsAffected = updateCmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("✅ Morning Time-Out recorded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("⚠️ No matching Morning Time-In found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("❌ Error logging time-out: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub btnTimeIn1_Click(sender As Object, e As EventArgs) Handles btnTimeIn1.Click
        ' Get current time
        Dim currentTime As DateTime = DateTime.Now

        ' Check if it's before 1:00 PM
        If currentTime.Hour < 13 Then
            MessageBox.Show("Afternoon Time-In is only allowed starting at 1:00 PM.")
            Exit Sub
        End If

        ' Proceed with logging if it's 1:00 PM or later
        Dim con As New MySqlConnection("server=localhost;userid=root;password=;database=payrolldb")
        Dim cmd As New MySqlCommand("INSERT INTO time_logs (employee_id, time_in, date, shift_type) VALUES (@empID, NOW(), CURDATE(), 'Afternoon')", con)

        cmd.Parameters.AddWithValue("@empID", Convert.ToInt32(txtEmployeeID.Text))

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Afternoon Time-In recorded!")
        Catch ex As Exception
            MessageBox.Show("Error logging time-in: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub




    Private Sub btnTimeOut1_Click(sender As Object, e As EventArgs) Handles btnTimeOut1.Click
        Dim con As New MySqlConnection("server=localhost;userid=root;password=;database=payrolldb")
        Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM time_logs WHERE employee_id = @empID AND date = CURDATE() AND shift_type = 'Afternoon' AND time_out IS NULL", con)
        Dim updateCmd As New MySqlCommand("UPDATE time_logs SET time_out = NOW() WHERE employee_id = @empID AND date = CURDATE() AND shift_type = 'Afternoon' AND time_out IS NULL", con)

        Dim empID As Integer = Convert.ToInt32(txtEmployeeID.Text)
        checkCmd.Parameters.AddWithValue("@empID", empID)
        updateCmd.Parameters.AddWithValue("@empID", empID)

        Try
            con.Open()

            ' Check if Time-In exists without a Time-Out
            Dim recordExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
            If recordExists = 0 Then
                MessageBox.Show("You must Time-In for the afternoon shift before you can Time-Out.")
                Exit Sub
            End If

            ' Proceed with Time-Out
            Dim rowsAffected = updateCmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Afternoon Time-Out recorded!")
            Else
                MessageBox.Show("Something went wrong during Time-Out.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error logging time-out: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub







    Private Sub btnBack5_Click_1(sender As Object, e As EventArgs) Handles btnBack5.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewPayslip_Click(sender As Object, e As EventArgs) Handles btnViewPayslip.Click
        Dim payslipForm As New EmployeePaySlip

        payslipForm.LoggedInEmployeeID = LoggedInEmployeeID
        payslipForm.EmployeePanelRef = Me ' 👈 PASS THE EXISTING PANEL
        payslipForm.Show
        payslipForm.ViewLatestPayslip
        Hide
    End Sub



    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs) Handles btnViewAttendance.Click
        Dim attendanceForm As New AttendanceForm()
        attendanceForm.LoggedInEmployeeID = Me.LoggedInEmployeeID  ' 👈 Pass the actual logged-in employee's ID
        attendanceForm.EmployeePanelRef = Me                        ' 👈 For returning back smoothly
        attendanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Dim payslipForm As New EmployeePaySlip()

        payslipForm.LoggedInEmployeeID = Me.LoggedInEmployeeID
        payslipForm.EmployeePanelRef = Me ' 👈 PASS THE EXISTING PANEL
        payslipForm.Show()
        payslipForm.ViewLatestPayslip()
        Me.Hide()
    End Sub


    Private Sub btnViewPayslipHistory_Click(sender As Object, e As EventArgs) Handles btnViewPayslipHistory.Click
        frmPayslipHistory.employeeID = txtEmployeeID.Text ' Or however you're tracking the current employee
        frmPayslipHistory.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim complaintForm As New UserComplaintForm()
        complaintForm.LoggedInEmployeeID = Me.LoggedInEmployeeID  ' <-- pass existing property
        complaintForm.ShowDialog()
    End Sub
End Class
