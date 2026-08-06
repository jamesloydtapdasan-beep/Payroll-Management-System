Imports MySql.Data.MySqlClient

Public Class ReviewComplaintForm

    ' Properties to receive data from StaffDashboard
    Public ComplaintID As Integer

    ' DB connection
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=payrolldb;")

    Private Sub ReviewComplaintForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComplaintDetails()
    End Sub

    Private Sub LoadComplaintDetails()
        Try
            conn.Open()
            Dim sql As String = "SELECT c.complaint_id, c.employee_id, CONCAT(e.first_name, ' ', e.last_name) AS employee_name, " &
                                "c.subject, c.description, c.type, c.status, c.filed_at " &
                                "FROM complaints c " &
                                "JOIN employees e ON c.employee_id = e.employee_id " &
                                "WHERE c.complaint_id = @compID LIMIT 1"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@compID", ComplaintID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        lblEmployeeName.Text = reader("employee_name").ToString()
                        txtSubject.Text = reader("subject").ToString()
                        txtDescription.Text = reader("description").ToString()
                        txtType.Text = reader("type").ToString()
                        txtStatus.Text = reader("status").ToString()
                        txtFiledAt.Text = Convert.ToDateTime(reader("filed_at")).ToString("MMMM d, yyyy h:mm tt")
                    Else
                        MessageBox.Show("Complaint not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading complaint: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        StaffComplaintForm.Show()
    End Sub

End Class
