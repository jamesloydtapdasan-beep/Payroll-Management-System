Imports MySql.Data.MySqlClient

Public Class frmAttendance

    Private connString As String = "server=localhost;userid=root;password=;database=payrolldb"

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeComboBox()
    End Sub

    ' =========================
    ' LOAD EMPLOYEES
    ' =========================
    Private Sub LoadEmployeeComboBox()
        Try
            Using con As New MySqlConnection(connString)
                con.Open()
                Dim query As String = "SELECT employee_id, CONCAT(first_name, ' ', last_name) AS full_name FROM employees ORDER BY first_name"
                Using cmd As New MySqlCommand(query, con)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbEmployeeSelect.Items.Clear()
                        While reader.Read()
                            cmbEmployeeSelect.Items.Add(New With {
                                .Text = reader("full_name").ToString(),
                                .Value = reader("employee_id")
                            })
                        End While
                    End Using
                End Using
            End Using

            cmbEmployeeSelect.DisplayMember = "Text"
            cmbEmployeeSelect.ValueMember = "Value"
        Catch ex As Exception
            MessageBox.Show("Error loading employees: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' SEARCH BUTTON
    ' =========================
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cmbEmployeeSelect.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an employee.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim empID As Integer = cmbEmployeeSelect.SelectedItem.Value
        LoadEmployeeInfo(empID)
        LoadAttendanceSummary(empID)
        LoadAttendanceLog(empID)
    End Sub

    ' =========================
    ' EMPLOYEE INFO
    ' =========================
    Private Sub LoadEmployeeInfo(empID As Integer)
        Try
            Using con As New MySqlConnection(connString)
                con.Open()
                Dim sql As String = "SELECT CONCAT(first_name, ' ', last_name) AS full_name FROM employees WHERE employee_id=@id"
                Using cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@id", empID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtFullName.Text = reader("full_name").ToString()
                        Else
                            txtFullName.Text = "N/A"
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching employee info: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' ATTENDANCE SUMMARY
    ' =========================
    Private Sub LoadAttendanceSummary(empID As Integer)
        Try
            Using con As New MySqlConnection(connString)
                con.Open()
                Dim sql As String = "
                    SELECT 
                        COUNT(DISTINCT date) AS total_days,
                        MAX(date) AS last_date,
                        SUM(TIMESTAMPDIFF(SECOND, time_in, time_out))/3600 AS total_hours
                    FROM time_logs
                    WHERE employee_id=@id
                "
                Using cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@id", empID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtDaysWorked.Text = reader("total_days").ToString() & " days"
                            txtLastDate.Text = If(IsDBNull(reader("last_date")), "-", reader("last_date").ToString())
                            txtTotalHours.Text = If(IsDBNull(reader("total_hours")), "0 hrs", Math.Round(Convert.ToDouble(reader("total_hours")), 2).ToString() & " hrs")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching attendance summary: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' ATTENDANCE LOG
    ' =========================
    Private Sub LoadAttendanceLog(empID As Integer)
        Try
            Using con As New MySqlConnection(connString)
                con.Open()
                Dim sql As String = "
                    SELECT 
                        date,
                        time_in,
                        time_out,
                        shift_type
                    FROM time_logs
                    WHERE employee_id=@id
                    ORDER BY date DESC, shift_type
                "
                Using cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@id", empID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvAttendanceLogBook.Rows.Clear()
                        ' Ensure columns exist
                        If dgvAttendanceLogBook.Columns.Count = 0 Then
                            dgvAttendanceLogBook.Columns.Add("colDate", "Date")
                            dgvAttendanceLogBook.Columns.Add("colShift", "Shift")
                            dgvAttendanceLogBook.Columns.Add("colTimeIn", "Time In")
                            dgvAttendanceLogBook.Columns.Add("colTimeOut", "Time Out")
                        End If

                        While reader.Read()
                            dgvAttendanceLogBook.Rows.Add(
                                reader("date").ToString(),
                                reader("shift_type").ToString(),
                                If(IsDBNull(reader("time_in")), "-", reader("time_in").ToString()),
                                If(IsDBNull(reader("time_out")), "-", reader("time_out").ToString())
                            )
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching attendance log: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' BACK BUTTON
    ' =========================
    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        Admin.Show()
        Me.Hide()
    End Sub

End Class
