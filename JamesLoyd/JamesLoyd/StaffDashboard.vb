Public Class StaffDashboard
    Private Sub EmployeeButton_Click(sender As Object, e As EventArgs) Handles EmployeeButton.Click
        ' Create an instance of the StaffManageEmployee form
        Dim staffForm As New StaffEmployeeManage()

        ' Optional: pass the current form as previous form so you can go back
        ' Dim staffForm As New StaffManageEmployee(Me)

        ' Show the new form
        staffForm.Show()

        ' Optional: hide the current form if you don’t want both open
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StaffManageAttendance.Show()
        Me.Hide()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StaffPayrollView.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        StaffComplaintForm.Show()
    End Sub


End Class