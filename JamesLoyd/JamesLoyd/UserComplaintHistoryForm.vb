Imports MySql.Data.MySqlClient

Public Class UserComplaintHistoryForm

    ' Receive the employee ID from UserComplaintForm
    Public LoggedInEmployeeID As Integer

    Private Sub UserComplaintHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserComplaints()
    End Sub

    ' =========================
    ' Load complaints into DataGridView
    ' =========================
    Private Sub LoadUserComplaints()
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=payrolldb")
                conn.Open()

                ' Query to get user complaints only
                Dim sql As String = "
                    SELECT 
                        complaint_id AS 'ID',
                        subject AS 'Subject',
                        description AS 'Description',
                        type AS 'Type',
                        status AS 'Status',
                        filed_at AS 'Filed At'
                    FROM complaints
                    WHERE employee_id=@empID
                    ORDER BY filed_at DESC
                "

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvUserComplaints.DataSource = dt

                    ' Optional: Make the grid look better
                    dgvUserComplaints.AutoResizeColumns()
                    dgvUserComplaints.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    dgvUserComplaints.ReadOnly = True
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading your complaints: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================
    ' Refresh button
    ' =========================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadUserComplaints()
    End Sub

    ' =========================
    ' Back button
    ' =========================
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

End Class
