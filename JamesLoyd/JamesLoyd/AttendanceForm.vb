Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class AttendanceForm

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=payrolldb;")
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader

    ' This will be set by EmployeePanel before showing the form
    Public LoggedInEmployeeID As Integer

    ' Reference to allow navigating back
    Public EmployeePanelRef As EmployeePanel

    Private Sub AttendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAttendance()
    End Sub

    Private Sub LoadAttendance()
        Try
            conn.Open()
            Dim sql As String = "
            SELECT 
                date,
                MAX(CASE WHEN shift_type = 'Morning' THEN time_in END) AS morning_in,
                MAX(CASE WHEN shift_type = 'Morning' THEN time_out END) AS morning_out,
                MAX(CASE WHEN shift_type = 'Afternoon' THEN time_in END) AS afternoon_in,
                MAX(CASE WHEN shift_type = 'Afternoon' THEN time_out END) AS afternoon_out
            FROM time_logs
            WHERE employee_id = @empID
            GROUP BY date
            ORDER BY date DESC"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
            reader = cmd.ExecuteReader()

            ' Set up columns once
            If dgvAttendance.Columns.Count = 0 Then
                dgvAttendance.Columns.Add("colDate", "Date")
                dgvAttendance.Columns.Add("colMorningIn", "Morning In")
                dgvAttendance.Columns.Add("colMorningOut", "Morning Out")
                dgvAttendance.Columns.Add("colAfternoonIn", "Afternoon In")
                dgvAttendance.Columns.Add("colAfternoonOut", "Afternoon Out")
            End If

            ' Make the DataGridView auto-fill
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvAttendance.Rows.Clear()

            While reader.Read()
                Dim dateStr As String = Convert.ToDateTime(reader("date")).ToString("MMMM dd, yyyy", CultureInfo.InvariantCulture)
                Dim mIn As String = If(IsDBNull(reader("morning_in")), "-", Convert.ToDateTime(reader("morning_in")).ToString("hh:mm tt"))
                Dim mOut As String = If(IsDBNull(reader("morning_out")), "-", Convert.ToDateTime(reader("morning_out")).ToString("hh:mm tt"))
                Dim aIn As String = If(IsDBNull(reader("afternoon_in")), "-", Convert.ToDateTime(reader("afternoon_in")).ToString("hh:mm tt"))
                Dim aOut As String = If(IsDBNull(reader("afternoon_out")), "-", Convert.ToDateTime(reader("afternoon_out")).ToString("hh:mm tt"))

                dgvAttendance.Rows.Add(dateStr, mIn, mOut, aIn, aOut)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading attendance: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBackButton.Click
        Me.Hide()
        If EmployeePanelRef IsNot Nothing Then
            EmployeePanelRef.Show()
        Else
            MessageBox.Show("⚠️ EmployeePanel reference lost.")
        End If
    End Sub


End Class
