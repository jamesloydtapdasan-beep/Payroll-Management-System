Imports MySql.Data.MySqlClient

Public Class StaffEmployeeManage

    Private Sub StaffEmployeeManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeIDsForTextBox() ' load autocomplete IDs
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim addForm As New StaffAddEmployee()
        addForm.Mode = "Add"
        addForm.ShowDialog()
    End Sub

    ' Extract Employee ID from "ID - Name"
    Private Function GetEmployeeIDFromTextbox() As String
        Dim fullText As String = txtSearchID.Text.Trim()
        If fullText.Contains("-") Then
            Return fullText.Split("-"c)(0).Trim()
        End If
        Return fullText
    End Function

    Private Function EmployeeExists(empID As String) As Boolean
        Try
            Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=payrolldb;")
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM employees WHERE employee_id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", empID)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error checking employee: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub LoadEmployeeIDsForTextBox()
        Try
            Dim coll As New AutoCompleteStringCollection()
            Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=payrolldb;")
                conn.Open()
                Dim query As String = "SELECT employee_id, first_name, last_name FROM employees"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim displayText As String = reader("employee_id").ToString() & " - " & reader("first_name").ToString() & " " & reader("last_name").ToString()
                            coll.Add(displayText)
                        End While
                    End Using
                End Using
            End Using

            txtSearchID.AutoCompleteCustomSource = coll
            txtSearchID.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txtSearchID.AutoCompleteSource = AutoCompleteSource.CustomSource
        Catch ex As Exception
            MsgBox("Error loading employee IDs: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim empID As String = GetEmployeeIDFromTextbox()

        If empID = "" Then
            MsgBox("Please enter an Employee ID.")
            Return
        End If

        If EmployeeExists(empID) Then
            Dim editForm As New StaffAddEmployee()
            editForm.Mode = "Edit"
            editForm.EmployeeID = empID
            editForm.ShowDialog()
        Else
            MsgBox("Employee ID not found.")
        End If
    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        Dim empID = GetEmployeeIDFromTextbox

        If empID = "" Then
            MsgBox("Please enter or select an Employee ID to update.")
            Return
        End If

        If Not EmployeeExists(empID) Then
            MsgBox("Employee ID not found.")
            Return
        End If

        Dim editForm As New StaffAddEmployee
        editForm.Mode = "Edit"
        editForm.EmployeeID = empID
        editForm.ShowDialog
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        StaffDashboard.Show()
    End Sub
End Class
