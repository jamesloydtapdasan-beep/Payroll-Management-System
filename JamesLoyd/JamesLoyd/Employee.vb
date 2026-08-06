Imports MySql.Data.MySqlClient
Imports System.IO
Imports ExcelDataReader
Imports System.Security.Cryptography
Imports System.Text
Imports BCrypt.Net

Public Class ManageAccount
    Inherits System.Windows.Forms.Form

    

    Private connectionString As String = "server=localhost; user id=root; password=; database=payrolldb"



    Private Sub ManageAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Reposition existing controls
        txtExcel.Location = New Point(235, 140)
        btnB.Location = New Point(txtExcel.Right + 10, 130)
        btnU.Location = New Point(btnB.Right + 15, 130)

        ' Optional: Only add if not already added in the designer visually
        If Not Me.Controls.Contains(txtExcel) Then Me.Controls.Add(txtExcel)
        If Not Me.Controls.Contains(btnB) Then Me.Controls.Add(btnB)
        If Not Me.Controls.Contains(btnU) Then Me.Controls.Add(btnU)

        ' Hook up click events
        AddHandler btnB.Click, AddressOf BtnBrowse_Click
        AddHandler btnU.Click, AddressOf BtnUploadExcel_Click
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs)
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Excel Files|*.xls;*.xlsx"
        openFileDialog.Title = "Select an Excel File"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            txtExcel.Text = openFileDialog.FileName
        End If
    End Sub

    Private Sub BtnUploadExcel_Click(sender As Object, e As EventArgs)
        Dim filePath As String = txtExcel.Text
        If String.IsNullOrWhiteSpace(filePath) OrElse Not IO.File.Exists(filePath) Then
            MessageBox.Show("Please select a valid Excel file before uploading.", "Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Your Excel import logic goes here
        MessageBox.Show("Excel file ready for import: " & filePath, "Upload Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub



    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        Try
            Dim excelPath As String = txtExcel.Text.Trim()

            If Not File.Exists(excelPath) Then
                MessageBox.Show("File does not exist. Please check the path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Using stream = File.Open(excelPath, FileMode.Open, FileAccess.Read)
                Dim reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                Dim result = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {.UseHeaderRow = True}
            })

                Dim table = result.Tables(0)
                Using con As New MySqlConnection("server=localhost;userid=root;password=;database=payrolldb")
                    con.Open()

                    For Each row As DataRow In table.Rows
                        Dim cmd As New MySqlCommand("INSERT INTO employees (
                        first_name, last_name, age, address, gender, city, date_of_birth,
                        civil_status, mobile, zip_code, mother_name, mother_occupation,
                        father_name, father_occupation, salary, position, department, 
                        date_hired, username, password, image_path, account_type, 
                        employee_type, role
                    ) VALUES (
                        @fname, @lname, @age, @addr, @gender, @city, @dob,
                        @civil, @mobile, @zip, @mom, @momOcc,
                        @dad, @dadOcc, @sal, @pos, @dept,
                        @doh, @user, @pass, @imgPath, @acctType,
                        @empType, @role)", con)

                        cmd.Parameters.AddWithValue("@fname", row("FirstName"))
                        cmd.Parameters.AddWithValue("@lname", row("LastName"))
                        cmd.Parameters.AddWithValue("@age", row("Age"))
                        cmd.Parameters.AddWithValue("@addr", row("Address"))
                        cmd.Parameters.AddWithValue("@gender", row("Gender"))
                        cmd.Parameters.AddWithValue("@city", row("City"))
                        cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(row("DateOfBirth")))
                        cmd.Parameters.AddWithValue("@civil", row("CivilStatus"))
                        cmd.Parameters.AddWithValue("@mobile", row("Mobile"))
                        cmd.Parameters.AddWithValue("@zip", row("ZipCode"))
                        cmd.Parameters.AddWithValue("@mom", row("MotherName"))
                        cmd.Parameters.AddWithValue("@momOcc", row("MotherOccupation"))
                        cmd.Parameters.AddWithValue("@dad", row("FatherName"))
                        cmd.Parameters.AddWithValue("@dadOcc", row("FatherOccupation"))
                        cmd.Parameters.AddWithValue("@sal", row("Salary"))
                        cmd.Parameters.AddWithValue("@pos", row("Position"))
                        cmd.Parameters.AddWithValue("@dept", row("Department"))
                        cmd.Parameters.AddWithValue("@doh", Convert.ToDateTime(row("DateHired")))
                        cmd.Parameters.AddWithValue("@user", row("Username"))

                        ' 🔐 Hash the plain password using BCrypt
                        Dim plainPassword As String = row("Password").ToString()
                        Dim hashedPassword As String = HashPassword(plainPassword)
                        cmd.Parameters.AddWithValue("@pass", hashedPassword)

                        cmd.Parameters.AddWithValue("@imgPath", row("ImagePath"))
                        cmd.Parameters.AddWithValue("@acctType", row("AccountType"))
                        cmd.Parameters.AddWithValue("@empType", row("EmployeeType"))
                        cmd.Parameters.AddWithValue("@role", row("Role"))

                        cmd.ExecuteNonQuery()
                    Next

                    con.Close()
                End Using

                reader.Close()
                MessageBox.Show("Employees imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error occurred while importing employees: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub





    ' ✅ HashPassword using BCrypt
    Private Function HashPassword(password As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(password)
    End Function










    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim form As New FormFullDetailed
        form.Mode = "Add"
        form.Show
    End Sub

    Private Sub btnUpdateAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateAccount.Click
        If String.IsNullOrWhiteSpace(txtEmployeeID.Text) Then
            MessageBox.Show("Please enter a valid Employee ID to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM employees WHERE employee_id = @employeeID", conn)
            cmd.Parameters.AddWithValue("@employeeID", txtEmployeeID.Text)
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If result = 0 Then
                MessageBox.Show("Employee ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End Using




        Dim updateForm As New FormFullDetailed()
        updateForm.EmployeeID = txtEmployeeID.Text
        updateForm.Mode = "Update"
        AddHandler updateForm.EmployeeUpdated, AddressOf RefreshEmployeeDetails
        updateForm.ShowDialog()
    End Sub

    Private Sub RefreshEmployeeDetails()
        btnSearch_Click(Nothing, Nothing)
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If String.IsNullOrWhiteSpace(txtEmployeeID.Text) Then
            MessageBox.Show("Please enter an Employee ID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Dim query As String = "DELETE FROM employees WHERE employee_id = @id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", txtEmployeeID.Text)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ClearFields()
                        Else
                            MessageBox.Show("No employee found with that ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrWhiteSpace(txtEmployeeID.Text) Then
            MessageBox.Show("Please enter an Employee ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open
                Dim query = "SELECT employee_id, first_name, last_name, position, salary * 1000 AS salary, date_hired, employee_type, role, image_path " &
                                  "FROM employees WHERE employee_id = @EmployeeID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim)

                    Using reader = cmd.ExecuteReader
                        If reader.Read Then
                            txtFullName.Text = reader("first_name").ToString & " " & reader("last_name").ToString
                            txtPos.Text = reader("position").ToString
                            txtRole.Text = reader("role").ToString
                            txtSal.Text = reader("salary").ToString
                            txtEmploType.Text = reader("employee_type").ToString

                            ' ✅ Load image from file path (no file lock)
                            Dim imagePath = reader("image_path").ToString

                            If Not String.IsNullOrEmpty(imagePath) AndAlso File.Exists(imagePath) Then
                                Try
                                    Using fs As New FileStream(imagePath, FileMode.Open, FileAccess.Read)
                                        Dim tempImage = Image.FromStream(fs)
                                        picEmployee.Image = New Bitmap(tempImage) ' Clone to avoid file lock
                                    End Using
                                    picEmployee.SizeMode = PictureBoxSizeMode.StretchImage
                                Catch ex As Exception
                                    MessageBox.Show("Failed to load employee image: " & ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    picEmployee.Image = Nothing
                                End Try
                            Else
                                picEmployee.Image = Nothing
                            End If


                        Else
                            MessageBox.Show("Employee not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ClearFields
                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to search employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        txtEmployeeID.Clear()
        txtFullName.Clear()
        txtPos.Clear()
        txtRole.Clear()
        txtSal.Clear()
        txtEmploType.Clear()
        picEmployee.Image = Nothing
    End Sub



    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        Me.Close()
        Admin.Show()
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Me.Close()
        All.Show()
    End Sub




End Class
