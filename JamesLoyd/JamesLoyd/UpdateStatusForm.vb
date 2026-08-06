Imports MySql.Data.MySqlClient

Public Class UpdateStatusForm

    ' Properties to receive complaint info
    Public ComplaintID As Integer
    Public ComplaintSubject As String

    Private Sub UpdateStatusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set labels
        lblComplaintID.Text = ComplaintID.ToString()
        lblSubject.Text = ComplaintSubject

        ' Populate status combo box
        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange({"Pending", "In Progress", "Resolved", "Forwarded to Admin"})
        cmbStatus.SelectedIndex = 0

        ' Optionally load current status
        LoadCurrentStatus()
    End Sub

    Private Sub LoadCurrentStatus()
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=payrolldb;")
                conn.Open()
                Dim sql As String = "SELECT status FROM complaints WHERE complaint_id=@compID"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@compID", ComplaintID)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then cmbStatus.SelectedItem = result.ToString()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading current status: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=payrolldb;")
                conn.Open()
                Dim sql As String = "UPDATE complaints SET status=@status WHERE complaint_id=@compID"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@compID", ComplaintID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error updating status: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        StaffComplaintForm.Show()
    End Sub

End Class
