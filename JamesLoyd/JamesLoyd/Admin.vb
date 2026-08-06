Public Class Admin
    ' Manage Accounts button click event
    Private Sub btnManageAccounts_Click(sender As Object, e As EventArgs) Handles btnManageAccounts.Click
        ' Open the AccountManagementForm
        Dim manageForm As New ManageAccount()
        manageForm.Show()
    End Sub

    ' Attendance button click event
    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        ' Open the EmployeeAttendanceForm
        Dim attendanceForm As New frmAttendance()
        attendanceForm.Show()
    End Sub

    ' Payroll button click event
    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        ' Open the PayrollManagementForm
        Dim payrollForm As New frmPayroll()
        payrollForm.Show()
    End Sub

    ' Payslip button click event
    Private Sub btnPayslip_Click(sender As Object, e As EventArgs) Handles btnPayslip.Click
        ' Open the PayslipGeneratorForm
        Dim payslipForm As New frmpPayslip()
        payslipForm.Show()
    End Sub

    ' Backup Database button click event
    Private Sub btnBackupDB_Click(sender As Object, e As EventArgs)
        ' Call the BackupDatabase method
        BackupDatabase()
    End Sub

    ' Logout button click event
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Log out the admin and show the login form
        Me.Hide()
        Form1.Show()
    End Sub

    ' Function to backup the database
    Private Sub BackupDatabase()
        Try
            ' Example of MySQL backup command using mysqldump
            Dim processInfo As New ProcessStartInfo("mysqldump", "-u yourusername -p yourpassword yourdatabase > backupfile.sql")
            processInfo.WindowStyle = ProcessWindowStyle.Hidden
            Process.Start(processInfo)
            MessageBox.Show("Database backup completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error during backup: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnComplaint_Click(sender As Object, e As EventArgs) Handles btnComplaint.Click
        Me.Hide()
        AdminComplaintDashboard.Show()
    End Sub


End Class
