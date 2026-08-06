Imports MySql.Data.MySqlClient
Imports BCrypt.Net
Imports System.IO

Public Class StaffAddEmployee
    Public Property Mode As String
    Public Property EmployeeID As String
    Private originalHashedPassword As String
    Private Const FixedSalary As Decimal = 15000

    Private Sub StaffAddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fixed salary and role
        txtSal.ReadOnly = True
        txtSal.Text = FixedSalary.ToString("F2")
        txtRole.ReadOnly = True
        txtRole.Text = "Employee"

        ' Employee ID and date hired
        txtEmployeeID.ReadOnly = True
        txtDoH.Enabled = True
        txtDoB.Enabled = True

        ' Enable buttons
        If Mode = "Add" Then
            btnSave.Enabled = True
            btnUpdateEmployee.Enabled = False
            cmbDepartment.Enabled = True
            cmbPos.Enabled = True
        Else
            btnSave.Enabled = False
            btnUpdateEmployee.Enabled = True
            LoadEmployeeData()
            cmbDepartment.Enabled = True
            cmbPos.Enabled = True
        End If
    End Sub

    Private Sub LoadEmployeeData()
        Try
            Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=payrolldb;")
                conn.Open()
                Dim query As String = "SELECT * FROM employees WHERE employee_id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", EmployeeID)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtEmployeeID.Text = reader("employee_id").ToString()
                            txtFirstName.Text = reader("first_name").ToString()
                            txtLastname.Text = reader("last_name").ToString()
                            txtAge.Text = reader("age").ToString()
                            txtAdd2.Text = reader("address").ToString()
                            txtGender.Text = reader("gender").ToString()
                            txtCity.Text = reader("city").ToString()
                            txtStat.Text = reader("civil_status").ToString()
                            txtMobile2.Text = reader("mobile").ToString()
                            txtZip2.Text = reader("zip_code").ToString()
                            txtMother.Text = reader("mother_name").ToString()
                            txtOcc1.Text = reader("mother_occupation").ToString()
                            txtFather.Text = reader("father_name").ToString()
                            txtOcc2.Text = reader("father_occupation").ToString()
                            cmbPos.Text = reader("position").ToString()
                            cmbDepartment.Text = reader("department").ToString()
                            txtUser.Text = reader("username").ToString()
                            txtEmploType.Text = reader("employee_type").ToString()
                            originalHashedPassword = reader("password").ToString()

                            ' Safe date conversion
                            If reader("date_of_birth") IsNot DBNull.Value AndAlso reader("date_of_birth").ToString() <> "0000-00-00" Then
                                txtDoB.Text = Convert.ToDateTime(reader("date_of_birth")).ToString("yyyy-MM-dd")
                            Else
                                txtDoB.Text = ""
                            End If
                            If reader("date_hired") IsNot DBNull.Value AndAlso reader("date_hired").ToString() <> "0000-00-00" Then
                                txtDoH.Text = Convert.ToDateTime(reader("date_hired")).ToString("yyyy-MM-dd")
                            Else
                                txtDoH.Text = ""
                            End If

                            ' Load image
                            If reader("image_path") IsNot DBNull.Value Then
                                Dim imgPath = reader("image_path").ToString()
                                If File.Exists(imgPath) Then
                                    txtPicBox.Image = Image.FromFile(imgPath)
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error loading employee: " & ex.Message)
        End Try
    End Sub

    '=============================
    ' ADD EMPLOYEE
    '=============================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=payrolldb;")
                conn.Open()

                ' Check username unique
                Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM employees WHERE username=@user", conn)
                    checkCmd.Parameters.AddWithValue("@user", txtUser.Text)
                    Dim exists = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If exists > 0 Then
                        MsgBox("Username already exists!")
                        Return
                    End If
                End Using

                Dim hashedPass = If(txtPass.Text <> "", BCrypt.Net.BCrypt.HashPassword(txtPass.Text), "")
                Dim newImagePath = SaveImage()

                Dim query As String =
                    "INSERT INTO employees 
                     (first_name, last_name, age, address, gender, city, date_of_birth, civil_status,
                      mobile, zip_code, mother_name, mother_occupation, father_name, father_occupation,
                      salary, position, department, date_hired, username, password, image_path,
                      account_type, employee_type, role)
                      VALUES
                     (@fname,@lname,@age,@addr,@gender,@city,@dob,@stat,
                      @mobile,@zip,@mother,@occ1,@father,@occ2,
                      @sal,@pos,@dept,@doh,@user,@pass,@image,
                      @acct,@emptype,@role)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@lname", txtLastname.Text)
                    cmd.Parameters.AddWithValue("@age", txtAge.Text)
                    cmd.Parameters.AddWithValue("@addr", txtAdd2.Text)
                    cmd.Parameters.AddWithValue("@gender", txtGender.Text)
                    cmd.Parameters.AddWithValue("@city", txtCity.Text)
                    cmd.Parameters.AddWithValue("@dob", txtDoB.Text)
                    cmd.Parameters.AddWithValue("@stat", txtStat.Text)
                    cmd.Parameters.AddWithValue("@mobile", txtMobile2.Text)
                    cmd.Parameters.AddWithValue("@zip", txtZip2.Text)
                    cmd.Parameters.AddWithValue("@mother", txtMother.Text)
                    cmd.Parameters.AddWithValue("@occ1", txtOcc1.Text)
                    cmd.Parameters.AddWithValue("@father", txtFather.Text)
                    cmd.Parameters.AddWithValue("@occ2", txtOcc2.Text)
                    cmd.Parameters.AddWithValue("@sal", FixedSalary)
                    cmd.Parameters.AddWithValue("@pos", cmbPos.Text)
                    cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text)
                    cmd.Parameters.AddWithValue("@doh", DateTime.Now)
                    cmd.Parameters.AddWithValue("@user", txtUser.Text)
                    cmd.Parameters.AddWithValue("@pass", hashedPass)
                    cmd.Parameters.AddWithValue("@image", newImagePath)
                    cmd.Parameters.AddWithValue("@acct", "Staff")
                    cmd.Parameters.AddWithValue("@emptype", txtEmploType.Text)
                    cmd.Parameters.AddWithValue("@role", "Employee")

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Employee added successfully!")
        Catch ex As Exception
            MsgBox("Error adding employee: " & ex.Message)
        End Try
    End Sub

    '=============================
    ' UPDATE EMPLOYEE
    '=============================
    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        Try
            Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=payrolldb;")
                conn.Open()

                ' Check username unique but ignore current employee
                Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM employees WHERE username=@user AND employee_id<>@id", conn)
                    checkCmd.Parameters.AddWithValue("@user", txtUser.Text)
                    checkCmd.Parameters.AddWithValue("@id", EmployeeID)
                    Dim exists = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If exists > 0 Then
                        MsgBox("Username already exists for another employee!")
                        Return
                    End If
                End Using

                Dim finalPassword = If(txtPass.Text <> "", BCrypt.Net.BCrypt.HashPassword(txtPass.Text), originalHashedPassword)
                Dim imgPath = SaveImage()

                Dim query As String =
                    "UPDATE employees SET
                     first_name=@fname,last_name=@lname,age=@age,address=@addr,gender=@gender,
                     city=@city,date_of_birth=@dob,civil_status=@stat,mobile=@mobile,
                     zip_code=@zip,mother_name=@mother,mother_occupation=@occ1,
                     father_name=@father,father_occupation=@occ2,
                     username=@user,password=@pass,employee_type=@emptype,image_path=@image,
                     salary=@sal,position=@pos,department=@dept,role=@role
                     WHERE employee_id=@id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fname", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@lname", txtLastname.Text)
                    cmd.Parameters.AddWithValue("@age", txtAge.Text)
                    cmd.Parameters.AddWithValue("@addr", txtAdd2.Text)
                    cmd.Parameters.AddWithValue("@gender", txtGender.Text)
                    cmd.Parameters.AddWithValue("@city", txtCity.Text)
                    cmd.Parameters.AddWithValue("@dob", txtDoB.Text)
                    cmd.Parameters.AddWithValue("@stat", txtStat.Text)
                    cmd.Parameters.AddWithValue("@mobile", txtMobile2.Text)
                    cmd.Parameters.AddWithValue("@zip", txtZip2.Text)
                    cmd.Parameters.AddWithValue("@mother", txtMother.Text)
                    cmd.Parameters.AddWithValue("@occ1", txtOcc1.Text)
                    cmd.Parameters.AddWithValue("@father", txtFather.Text)
                    cmd.Parameters.AddWithValue("@occ2", txtOcc2.Text)
                    cmd.Parameters.AddWithValue("@user", txtUser.Text)
                    cmd.Parameters.AddWithValue("@pass", finalPassword)
                    cmd.Parameters.AddWithValue("@emptype", txtEmploType.Text)
                    cmd.Parameters.AddWithValue("@image", imgPath)
                    cmd.Parameters.AddWithValue("@sal", FixedSalary)
                    cmd.Parameters.AddWithValue("@pos", cmbPos.Text)
                    cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text)
                    cmd.Parameters.AddWithValue("@role", "Employee")
                    cmd.Parameters.AddWithValue("@id", EmployeeID)

                    Dim rows = cmd.ExecuteNonQuery()
                    If rows = 0 Then
                        MsgBox("Update failed: employee not found!")
                    Else
                        MsgBox("Employee updated successfully!")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error updating employee: " & ex.Message)
        End Try
    End Sub

    '=============================
    ' SAVE IMAGE
    '=============================
    Private Function SaveImage() As String
        If txtPicBox.Image Is Nothing Then Return ""
        Dim folder As String = Application.StartupPath & "\employee_images\"
        If Not Directory.Exists(folder) Then Directory.CreateDirectory(folder)
        Dim imgPath As String = folder & "emp_" & Now.Ticks.ToString() & ".jpg"
        txtPicBox.Image.Save(imgPath, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return imgPath
    End Function


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            ofd.Title = "Select Employee Photo"
            If ofd.ShowDialog() = DialogResult.OK Then
                txtPicBox.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub
    Private Sub btnSelfie_Click(sender As Object, e As EventArgs) Handles btnSelfie.Click
        Dim selfieForm As New Selfie()
        selfieForm.ShowDialog()  ' Wait until SelfieForm closes

        ' Set captured image to txtPicBox if available
        If selfieForm.CapturedImage IsNot Nothing Then
            txtPicBox.Image = selfieForm.CapturedImage
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub
End Class
