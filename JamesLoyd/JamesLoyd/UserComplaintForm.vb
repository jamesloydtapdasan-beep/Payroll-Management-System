Imports MySql.Data.MySqlClient

Public Class UserComplaintForm

    ' Receive the employee ID from EmployeePanel
    Public Property LoggedInEmployeeID As Integer

    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=payrolldb;")

    Private Sub UserComplaintForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize complaint type combo box
        cmbType.Items.Clear()
        cmbType.Items.AddRange({"Work", "Payroll", "Harassment", "Attendance", "Other"})
        cmbType.SelectedIndex = 0
    End Sub

    '===========================
    ' SUBMIT NEW COMPLAINT
    '===========================
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' Validation
        If txtSubject.Text.Trim() = "" Then
            MessageBox.Show("Please enter a subject.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtDescription.Text.Trim() = "" Then
            MessageBox.Show("Please enter a description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Insert into DB (table: complaints)
        Try
            conn.Open()
            Dim insertSql As String = "INSERT INTO complaints (employee_id, subject, description, type, status, filed_at) " &
                                      "VALUES (@employee_id, @subject, @description, @type, 'Pending', NOW())"

            Using cmd As New MySqlCommand(insertSql, conn)
                cmd.Parameters.AddWithValue("@employee_id", LoggedInEmployeeID)
                cmd.Parameters.AddWithValue("@subject", txtSubject.Text.Trim())
                cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim())
                cmd.Parameters.AddWithValue("@type", cmbType.SelectedItem.ToString())
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Your complaint has been filed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear inputs for next complaint
            txtSubject.Clear()
            txtDescription.Clear()
            cmbType.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error submitting complaint: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

    End Sub

    '===========================
    ' VIEW COMPLAINT HISTORY
    '===========================
    Private Sub btnViewHistory_Click(sender As Object, e As EventArgs) Handles btnViewHistory.Click
        Try
            Dim historyForm As New UserComplaintHistoryForm()
            historyForm.LoggedInEmployeeID = Me.LoggedInEmployeeID
            historyForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error opening complaint history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '===========================
    ' BACK BUTTON
    '===========================
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class
