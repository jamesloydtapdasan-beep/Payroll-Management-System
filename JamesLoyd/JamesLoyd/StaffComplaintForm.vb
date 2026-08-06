Imports MySql.Data.MySqlClient

Public Class StaffComplaintForm

    ' MySQL connection
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=payrolldb;")

    Private Sub StaffComplaintForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize filters
        cmbStatusFilter.Items.Clear()
        cmbStatusFilter.Items.AddRange({"All", "Pending", "In Progress", "Resolved"})
        cmbStatusFilter.SelectedIndex = 0

        cmbTypeFilter.Items.Clear()
        cmbTypeFilter.Items.AddRange({"All", "Work", "Payroll", "Harassment", "Attendance", "Other"})
        cmbTypeFilter.SelectedIndex = 0

        dtpFrom.Value = DateTime.Today.AddMonths(-1)
        dtpTo.Value = DateTime.Today

        LoadComplaints()
    End Sub

    ' ==============================
    ' LOAD COMPLAINTS INTO DATAGRIDVIEW
    ' ==============================
    Private Sub LoadComplaints()
        Try
            conn.Open()
            Dim sql As String = "SELECT c.complaint_id AS 'ID',
       e.employee_id AS 'EmployeeID',
       e.first_name AS 'First Name',
       e.last_name AS 'Last Name',
       c.subject AS 'Subject', 
       c.description AS 'Description', 
       c.type AS 'Type', 
       c.status AS 'Status', 
       c.filed_at AS 'Filed At'
FROM complaints c 
INNER JOIN employees e ON c.employee_id = e.employee_id

                                 WHERE 1=1"

            ' Filters
            If cmbStatusFilter.SelectedItem.ToString() <> "All" Then
                sql &= " AND c.status=@status"
            End If

            If cmbTypeFilter.SelectedItem.ToString() <> "All" Then
                sql &= " AND c.type=@type"
            End If

            sql &= " AND c.filed_at BETWEEN @fromDate AND @toDate"



            sql &= " ORDER BY c.filed_at DESC"

            Using cmd As New MySqlCommand(sql, conn)
                ' Parameters
                If cmbStatusFilter.SelectedItem.ToString() <> "All" Then
                    cmd.Parameters.AddWithValue("@status", cmbStatusFilter.SelectedItem.ToString())
                End If

                If cmbTypeFilter.SelectedItem.ToString() <> "All" Then
                    cmd.Parameters.AddWithValue("@type", cmbTypeFilter.SelectedItem.ToString())
                End If

                cmd.Parameters.AddWithValue("@fromDate", dtpFrom.Value.Date)
                cmd.Parameters.AddWithValue("@toDate", dtpTo.Value.Date.AddDays(1).AddSeconds(-1)) ' End of day


                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                dgvComplaints.DataSource = dt
                dgvComplaints.AutoResizeColumns()
                dgvComplaints.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgvComplaints.ReadOnly = True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading complaints: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' ==============================
    ' APPLY FILTER BUTTON
    ' ==============================
    Private Sub btnApplyFilters_Click(sender As Object, e As EventArgs) Handles btnApplyFilters.Click
        LoadComplaints()
    End Sub

    ' ==============================
    ' REFRESH BUTTON
    ' ==============================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadComplaints()
    End Sub

    ' ==============================
    ' REVIEW SELECTED COMPLAINT
    ' ==============================
    Private Sub btnReview_Click(sender As Object, e As EventArgs) Handles btnReview.Click
        If dgvComplaints.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a complaint to review.")
            Return
        End If

        Dim selectedID As Integer = Convert.ToInt32(dgvComplaints.SelectedRows(0).Cells("ID").Value)
        Dim reviewForm As New ReviewComplaintForm()
        reviewForm.ComplaintID = selectedID
        reviewForm.ShowDialog()

        ' Refresh after review
        LoadComplaints()
    End Sub

    ' ==============================
    ' ADD REMARK TO SELECTED COMPLAINT
    ' ==============================
    Private Sub btnAddRemark_Click(sender As Object, e As EventArgs) Handles btnAddRemark.Click
        If dgvComplaints.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a complaint to add a remark.")
            Return
        End If

        ' Get complaint ID, employee ID, and employee name from the selected row
        Dim selectedID As Integer = Convert.ToInt32(dgvComplaints.SelectedRows(0).Cells("ID").Value)
        Dim employeeID As Integer = Convert.ToInt32(dgvComplaints.SelectedRows(0).Cells("EmployeeID").Value)
        Dim employeeName As String = dgvComplaints.SelectedRows(0).Cells("First Name").Value.ToString() & " " &
                                 dgvComplaints.SelectedRows(0).Cells("Last Name").Value.ToString()

        ' Open AddRemarkForm and pass values
        Dim remarkForm As New AddRemarkForm()
        remarkForm.ComplaintID = selectedID
        remarkForm.EmployeeID = employeeID
        remarkForm.EmployeeName = employeeName

        ' Set the labels in AddRemarkForm
        remarkForm.lblComplaintID.Text = selectedID.ToString()
        remarkForm.lblEmployeeName.Text = employeeName

        remarkForm.ShowDialog()

        LoadComplaints()
    End Sub



    ' ==============================
    ' UPDATE STATUS BUTTON
    ' ==============================
    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        If dgvComplaints.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a complaint to update.")
            Return
        End If

        Dim selectedID As Integer = Convert.ToInt32(dgvComplaints.SelectedRows(0).Cells("ID").Value)
        Dim statusForm As New UpdateStatusForm()
        statusForm.ComplaintID = selectedID
        statusForm.ShowDialog()

        LoadComplaints()
    End Sub

    ' ==============================
    ' FORWARD TO ADMIN BUTTON
    ' ==============================
    Private Sub btnForwardAdmin_Click(sender As Object, e As EventArgs) Handles btnForwardAdmin.Click
        If dgvComplaints.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a complaint to forward.")
            Return
        End If

        Dim selectedID As Integer = Convert.ToInt32(dgvComplaints.SelectedRows(0).Cells("ID").Value)

        Try
            conn.Open()
            Dim sql As String = "UPDATE complaints SET status='Forwarded to Admin' WHERE complaint_id=@id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", selectedID)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Complaint forwarded to Admin successfully!")
        Catch ex As Exception
            MessageBox.Show("Error forwarding complaint: " & ex.Message)
        Finally
            conn.Close()
        End Try

        LoadComplaints()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        StaffDashboard.Show()
    End Sub


End Class
