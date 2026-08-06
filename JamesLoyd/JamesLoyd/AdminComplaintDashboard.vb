Imports MySql.Data.MySqlClient

Public Class AdminComplaintDashboard

    Private ReadOnly conn As New MySqlConnection(
        "server=localhost;userid=root;password=;database=payrolldb;"
    )

    ' =========================
    ' FORM LOAD
    ' =========================
    Private Sub AdminComplaintDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComplaints()
        LoadComplaintStats()
    End Sub

    ' =========================
    ' LOAD COMPLAINTS (OPTIONAL SEARCH)
    ' =========================
    Private Sub LoadComplaints(Optional searchText As String = "")
        Try
            Dim sql As String =
                "SELECT 
                    c.complaint_id AS 'ID',
                    e.employee_id AS 'Employee ID',
                    CONCAT(e.first_name, ' ', e.last_name) AS 'Employee Name',
                    c.subject AS 'Subject',
                    c.description AS 'Description',
                    c.type AS 'Type',
                    c.status AS 'Status',
                    c.filed_at AS 'Filed At'
                 FROM complaints c
                 INNER JOIN employees e ON c.employee_id = e.employee_id"

            If searchText <> "" Then
                sql &= " WHERE e.employee_id LIKE @search 
                          OR e.first_name LIKE @search 
                          OR e.last_name LIKE @search"
            End If

            sql &= " ORDER BY c.filed_at DESC"

            Using cmd As New MySqlCommand(sql, conn)
                If searchText <> "" Then
                    cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                End If

                Dim dt As New DataTable()
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                dgvAdminComplaints.DataSource = dt
                dgvAdminComplaints.ReadOnly = True
                dgvAdminComplaints.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgvAdminComplaints.AutoResizeColumns()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading complaints: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' SEARCH BUTTON
    ' =========================
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearchEmployee.Text.Trim() = "" Then
            MessageBox.Show("Enter an Employee ID or Name to search.")
            Exit Sub
        End If

        LoadComplaints(txtSearchEmployee.Text.Trim())
    End Sub

    ' =========================
    ' LOAD STATS (LABELS)
    ' =========================
    Private Sub LoadComplaintStats()
        Try
            conn.Open()

            Dim total As Integer
            Dim pending As Integer
            Dim resolved As Integer

            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM complaints", conn)
                total = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            Using cmd As New MySqlCommand(
                "SELECT COUNT(*) FROM complaints WHERE status='Pending'", conn)
                pending = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            Using cmd As New MySqlCommand(
                "SELECT COUNT(*) FROM complaints WHERE status='Resolved'", conn)
                resolved = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            lblTotalComplaints.Text = $"Total Complaints: {total}"
            lblComplaintStats.Text = $"Pending: {pending} | Resolved: {resolved}"

        Catch ex As Exception
            MessageBox.Show("Error loading stats: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' =========================
    ' VIEW DETAILS
    ' =========================
    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        If dgvAdminComplaints.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a complaint.")
            Exit Sub
        End If

        Dim frm As New ReviewComplaintForm()
        frm.ComplaintID =
            Convert.ToInt32(dgvAdminComplaints.SelectedRows(0).Cells("ID").Value)
        frm.ShowDialog()

        LoadComplaints()
        LoadComplaintStats()
    End Sub

    ' =========================
    ' ADD REMARK
    ' =========================
    Private Sub btnAddAdminRemark_Click(sender As Object, e As EventArgs) Handles btnAddAdminRemark.Click
        If dgvAdminComplaints.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a complaint.")
            Exit Sub
        End If

        Dim row = dgvAdminComplaints.SelectedRows(0)

        Dim frm As New AddRemarkForm()
        frm.ComplaintID = Convert.ToInt32(row.Cells("ID").Value)
        frm.EmployeeName = row.Cells("Employee Name").Value.ToString()
        frm.ShowDialog()

        LoadComplaints()
        LoadComplaintStats()
    End Sub

    ' =========================
    ' UPDATE STATUS
    ' =========================
    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        If dgvAdminComplaints.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a complaint.")
            Exit Sub
        End If

        Dim frm As New UpdateStatusForm()
        frm.ComplaintID =
            Convert.ToInt32(dgvAdminComplaints.SelectedRows(0).Cells("ID").Value)
        frm.ShowDialog()

        LoadComplaints()
        LoadComplaintStats()
    End Sub

    ' =========================
    ' REFRESH = SHOW ALL
    ' =========================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearchEmployee.Clear()
        LoadComplaints()
        LoadComplaintStats()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        Admin.Show()
    End Sub

End Class
