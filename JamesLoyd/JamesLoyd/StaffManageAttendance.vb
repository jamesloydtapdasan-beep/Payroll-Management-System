Imports MySql.Data.MySqlClient

Public Class StaffManageAttendance

    Private Sub StaffManageAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupGrid()
    End Sub

    '===========================
    ' 1. Setup Columns Once
    '===========================
    Private Sub SetupGrid()
        With dgvAttendanceLog
            .Columns.Clear()
            .Rows.Clear()

            .Columns.Add("date", "Date")
            .Columns.Add("timein", "Time In")
            .Columns.Add("timeout", "Time Out")

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    '===========================
    ' 2. Search Button
    '===========================
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim empID = txtSearchID.Text.Trim

        If empID = "" Then
            MessageBox.Show("Please enter Employee ID.")
            Exit Sub
        End If

        LoadAttendance(empID)
        LoadAttendanceSummary(empID) ' Summary function
    End Sub

    '===========================
    ' 3. Load Attendance Logs
    '===========================
    Private Sub LoadAttendance(employeeID As String)
        Try
            Dim query As String =
                "SELECT date, time_in, time_out FROM time_logs WHERE employee_id = @id ORDER BY date DESC"

            Using con As New MySqlConnection("server=localhost;user id=root;password=;database=payrolldb")
                con.Open()

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", employeeID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        dgvAttendanceLog.Rows.Clear() ' VERY IMPORTANT

                        If reader.HasRows = False Then
                            MessageBox.Show("No attendance logs found for this employee.")
                            Exit Sub
                        End If

                        While reader.Read()
                            dgvAttendanceLog.Rows.Add(
                                reader("date").ToString(),
                                reader("time_in").ToString(),
                                reader("time_out").ToString()
                            )
                        End While

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading log: " & ex.Message)
        End Try
    End Sub

    '===========================
    ' 4. Load Attendance Summary
    '===========================
    Private Sub LoadAttendanceSummary(employeeID As String)
        Try
            ' Compute total hours, absent days (time_in null), undertime (less than 8h), last worked date
            Dim query As String =
                "SELECT 
                    COUNT(*) AS total_days,
                    SUM(TIMESTAMPDIFF(MINUTE, time_in, time_out)/60) AS total_hours,
                    SUM(CASE WHEN time_in IS NULL THEN 1 ELSE 0 END) AS absent_days,
                    SUM(CASE WHEN TIMESTAMPDIFF(MINUTE, time_in, time_out)/60 < 8 THEN 8 - TIMESTAMPDIFF(MINUTE, time_in, time_out)/60 ELSE 0 END) AS undertime,
                    MAX(date) AS last_worked
                 FROM time_logs
                 WHERE employee_id=@id;"

            Using con As New MySqlConnection("server=localhost;user id=root;password=;database=payrolldb")
                con.Open()

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", employeeID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lblTotHours.Text = If(IsDBNull(reader("total_hours")), "0 hrs", reader("total_hours").ToString() & " hrs")
                            lblAbsentDays.Text = If(IsDBNull(reader("absent_days")), "0", reader("absent_days").ToString())
                            lblUndertime.Text = If(IsDBNull(reader("undertime")), "0 hrs", reader("undertime").ToString() & " hrs")
                            lblLastWorked.Text = If(IsDBNull(reader("last_worked")), "-", Convert.ToDateTime(reader("last_worked")).ToString("MM/dd/yyyy"))
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading attendance summary: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        StaffDashboard.Show()
    End Sub
End Class
