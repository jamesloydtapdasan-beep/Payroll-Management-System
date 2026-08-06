Imports MySql.Data.MySqlClient

Public Class All
    Dim connectionString As String = "server=localhost;userid=root;password=;database=payrolldb"

    Private Sub All_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeList()
    End Sub
    Private Sub LoadEmployeeList()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT employee_id, first_name, last_name, age, address, gender, city, date_of_birth, civil_status, mobile, zip_code, mother_name, mother_occupation, father_name, father_occupation, salary, position, department, date_hired, username, account_type, employee_type, role FROM employees"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dtgvEmployees.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading employee list: " & ex.Message)
        End Try
    End Sub


    Private Sub RefreshEmployeeGrid()
        dtgvEmployees.DataSource = Nothing
        dtgvEmployees.Rows.Clear()
        dtgvEmployees.Refresh()
        LoadEmployeeList()
    End Sub






    Private Sub btnBa_Click(sender As Object, e As EventArgs) Handles btnBa.Click
        Me.Hide()
        ManageAccount.Show()
    End Sub

End Class
