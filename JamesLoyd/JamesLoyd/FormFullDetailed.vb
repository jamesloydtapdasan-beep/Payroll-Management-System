Imports System.IO
Imports MySql.Data.MySqlClient
Imports BCrypt.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices


Public Class FormFullDetailed



    Private originalHashedPassword As String
    Public Event EmployeeUpdated As EventHandler

    Private previousForm As Form


    Private departmentPositions As New Dictionary(Of String, Dictionary(Of String, Decimal)) From {
    {"HR", New Dictionary(Of String, Decimal) From {
        {"HR Manager", 40000D},
        {"Recruiter", 28000D},
        {"HR Assistant", 24000D},
        {"Training Specialist", 30000D},
        {"Compensation Analyst", 32000D}
    }},
    {"IT", New Dictionary(Of String, Decimal) From {
        {"Programmer", 35000D},
        {"IT Support", 27000D},
        {"System Analyst", 38000D},
        {"Software Engineer", 42000D},
        {"Network Administrator", 36000D},
        {"Database Administrator", 39000D}
    }},
    {"Finance", New Dictionary(Of String, Decimal) From {
        {"Accountant", 34000D},
        {"Finance Manager", 45000D},
        {"Payroll Clerk", 26000D},
        {"Budget Analyst", 37000D},
        {"Auditor", 40000D},
        {"Bookkeeper", 25000D}
    }},
    {"Admin", New Dictionary(Of String, Decimal) From {
        {"Admin Officer", 28000D},
        {"Executive Assistant", 32000D},
        {"Office Clerk", 22000D},
        {"Data Encoder", 23000D},
        {"Receptionist", 21000D}
    }},
    {"Marketing", New Dictionary(Of String, Decimal) From {
        {"Marketing Manager", 43000D},
        {"SEO Specialist", 32000D},
        {"Content Creator", 30000D},
        {"Social Media Manager", 31000D},
        {"Market Research Analyst", 34000D}
    }},
    {"Sales", New Dictionary(Of String, Decimal) From {
        {"Sales Executive", 33000D},
        {"Sales Manager", 44000D},
        {"Account Executive", 35000D},
        {"Customer Service Rep", 25000D},
        {"Lead Generator", 26000D}
    }},
    {"Operations", New Dictionary(Of String, Decimal) From {
        {"Operations Manager", 45000D},
        {"Inventory Coordinator", 28000D},
        {"Logistics Officer", 33000D},
        {"Warehouse Supervisor", 31000D},
        {"Production Worker", 24000D}
    }},
    {"Legal", New Dictionary(Of String, Decimal) From {
        {"Legal Officer", 42000D},
        {"Compliance Officer", 40000D},
        {"Paralegal", 35000D},
        {"Contract Analyst", 38000D}
    }},
    {"Engineering", New Dictionary(Of String, Decimal) From {
        {"Mechanical Engineer", 46000D},
        {"Electrical Engineer", 47000D},
        {"Project Engineer", 44000D},
        {"CAD Operator", 32000D},
        {"Site Supervisor", 39000D}
    }},
    {"Maintenance", New Dictionary(Of String, Decimal) From {
        {"Maintenance Supervisor", 30000D},
        {"Janitor", 18000D},
        {"Electrician", 25000D},
        {"Plumber", 24000D},
        {"Facilities Technician", 26000D}
}}
}

    ' ✅ Single constructor with optional parameter for flexibility
    Public Sub New(Optional prevForm As Form = Nothing)
        InitializeComponent()
        previousForm = prevForm
    End Sub

    ' ✅ Back button logic to return to previous form
    Private Sub btnGoback_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Close()
        If previousForm IsNot Nothing Then
            previousForm.Show()
        End If
    End Sub

    Public Sub SetEmployeeID(ByVal empID As String)
        txtEmployeeID1.Text = empID
        txtEmployeeID1.ReadOnly = True
    End Sub

    ' Initialize components and any other form setup
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Property Mode As String
    Public Property EmployeeID As String

    ' Auto-generate Employee ID
    Private Function GenerateEmployeeID() As String
        Dim nextID As Integer
        Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=payrolldb;")
            conn.Open() ' Open connection before executing any query
            Dim cmd As New MySqlCommand("SELECT MAX(employee_id) FROM employees", conn)
            Dim result = cmd.ExecuteScalar()

            If IsDBNull(result) Then
                nextID = 1
            Else
                nextID = Convert.ToInt32(result) + 1
            End If
        End Using
        Return nextID.ToString()
    End Function

    ' Save employee data including txtDoB and txtDoH values without needing functions
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Validation: Ensure required fields are filled
            If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse String.IsNullOrWhiteSpace(txtLastname.Text) OrElse
           String.IsNullOrWhiteSpace(txtAge.Text) OrElse String.IsNullOrWhiteSpace(txtAdd2.Text) OrElse
           String.IsNullOrWhiteSpace(txtUser.Text) Then
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Auto-generate Employee ID if in Add Mode
            If String.IsNullOrWhiteSpace(txtEmployeeID.Text) Then
                txtEmployeeID.Text = GenerateEmployeeID()
            End If

            If String.IsNullOrWhiteSpace(txtPass.Text) Then
                MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' First and Last Name must contain only letters
            If Not System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text, "^[a-zA-Z]+$") Then
                MessageBox.Show("First name must contain only alphabetic characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not System.Text.RegularExpressions.Regex.IsMatch(txtLastname.Text, "^[a-zA-Z]+$") Then
                MessageBox.Show("Last name must contain only alphabetic characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If



            ' Age validation: must be between 18 and 60
            Dim ageValue As Integer
            If Not Integer.TryParse(txtAge.Text, ageValue) Then
                MessageBox.Show("Age must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If ageValue < 18 Then
                MessageBox.Show("Employee is underage (below 18). Cannot proceed.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf ageValue > 60 Then
                MessageBox.Show("Employee is above 60. Senior citizens are not allowed in this system.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Validate Gender
            Dim allowedGenders As String() = {"m", "f", "prefer not to say"}
            If Not allowedGenders.Contains(txtGender.Text.Trim().ToLower()) Then
                MessageBox.Show("Invalid gender. Allowed values: M, F, or Prefer not to say.",
                    "Invalid Gender", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If



            ' Validate Civil Status
            Dim allowedStatus As String() = {"single", "married", "widow", "widower", "divorced", "separated"}
            If Not allowedStatus.Contains(txtStat.Text.Trim().ToLower()) Then
                MessageBox.Show("Invalid civil status. Allowed values: Single, Married, Widow, Widower, Divorced, Separated.",
                    "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If



            ' Mobile number must be exactly 11 digits and only numbers
            If Not Regex.IsMatch(txtMobile2.Text.Trim(), "^\d{11}$") Then
                MessageBox.Show("Mobile number must be exactly 11 digits with numbers only.", "Invalid Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Validate Mother's Name (letters and spaces only)
            If Not Regex.IsMatch(txtMother.Text.Trim(), "^[A-Za-z\s]+$") Then
                MessageBox.Show("Mother's name must contain only letters.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Validate Father's Name (letters and spaces only)
            If Not Regex.IsMatch(txtFather.Text.Trim(), "^[A-Za-z\s]+$") Then
                MessageBox.Show("Father's name must contain only letters.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If




            ' Validate Employment Type
            Dim validEmpTypes As String() = {"Part-Time", "Full-Time", "Contract"}
            If Not validEmpTypes.Contains(txtEmploType.Text.Trim(), StringComparer.OrdinalIgnoreCase) Then
                MessageBox.Show("Employment type must be either Part-Time, Full-Time, or Contract.", "Invalid Employment Type", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            ' Validate Zip Code (must be numeric and between 4 to 9 digits)
            If Not Regex.IsMatch(txtZip2.Text.Trim(), "^\d{4,9}$") Then
                MessageBox.Show("Zip code must be numeric and contain between 4 to 9 digits.", "Invalid Zip Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            ' Validate Occupation 1 (must contain only letters and spaces)
            If Not Regex.IsMatch(txtOcc1.Text.Trim(), "^[A-Za-z\s]+$") Then
                MessageBox.Show("Mother's Occupation must contain only letters.", "Invalid Occupation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Validate Occupation 2 (must contain only letters and spaces)
            If Not Regex.IsMatch(txtOcc2.Text.Trim(), "^[A-Za-z\s]+$") Then
                MessageBox.Show("Father's Occupation must contain only letters.", "Invalid Occupation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If








            ' Open connection to MySQL (WAMP)
            Using conn As New MySqlConnection("server=localhost; user id=root; password=; database=payrolldb")
                conn.Open()

                ' Check if the username already exists (for new employees)
                Dim checkQuery As String = "SELECT COUNT(*) FROM employees WHERE username=@user"
                Dim checkCmd As New MySqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@user", txtUser.Text)
                Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If exists > 0 AndAlso Mode <> "Update" Then
                    MessageBox.Show("Username already exists. Please choose a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If



                ' Save Image and Path
                Dim imagePath As String = String.Empty
                If txtPicBox.Image IsNot Nothing Then
                    Dim folderPath As String = "Images/EmployeePics"
                    If Not IO.Directory.Exists(folderPath) Then
                        IO.Directory.CreateDirectory(folderPath)
                    End If
                    Dim fileName As String = folderPath & "\" & txtEmployeeID.Text & ".jpg"
                    txtPicBox.Image.Save(fileName, Imaging.ImageFormat.Jpeg)
                    imagePath = fileName
                End If



                ' Hash Password
                Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(txtPass.Text)
                MessageBox.Show("Hashed password: " & hashedPassword) ' TEMPORARY – remove this after testing

                ' Query to INSERT or UPDATE employee data
                Dim query As String
                If Mode = "Update" Then
                    query = "UPDATE employees SET first_name=@fname, last_name=@lname, age=@age, address=@addr, gender=@gender, " &
                    "city=@city, date_of_birth=@dob, civil_status=@stat, mobile=@mobile, zip_code=@zip, " &
                    "mother_name=@mother, mother_occupation=@occ1, father_name=@father, father_occupation=@occ2, " &
                    "salary=@sal, position=@pos, date_hired=@doh, username=@user, password=@pass, " &
                    "image_path=@imagePath, role=@role, employee_type=@emptype, department=@dept WHERE employee_id=@id"
                Else
                    query = "INSERT INTO employees (employee_id, first_name, last_name, age, address, gender, city, date_of_birth, civil_status, " &
                    "mobile, zip_code, mother_name, mother_occupation, father_name, father_occupation, salary, position, " &
                    "date_hired, username, password, image_path, role, employee_type, department) " &
                    "VALUES (@id, @fname, @lname, @age, @addr, @gender, @city, @dob, @stat, @mobile, @zip, " &
                    "@mother, @occ1, @father, @occ2, @sal, @pos, @doh, @user, @pass, @imagePath, @role, @emptype, @dept)"
                End If

                ' Prepare command with parameters
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", txtEmployeeID.Text)
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@lname", txtLastname.Text)
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text))
                cmd.Parameters.AddWithValue("@addr", txtAdd2.Text)
                cmd.Parameters.AddWithValue("@gender", txtGender.Text)
                cmd.Parameters.AddWithValue("@city", txtCity.Text)
                cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(txtDoB.Text)) ' Date of Birth
                cmd.Parameters.AddWithValue("@stat", txtStat.Text)
                cmd.Parameters.AddWithValue("@mobile", txtMobile2.Text)
                cmd.Parameters.AddWithValue("@zip", txtZip2.Text)
                cmd.Parameters.AddWithValue("@mother", txtMother.Text)
                cmd.Parameters.AddWithValue("@occ1", txtOcc1.Text)
                cmd.Parameters.AddWithValue("@father", txtFather.Text)
                cmd.Parameters.AddWithValue("@occ2", txtOcc2.Text)
                cmd.Parameters.AddWithValue("@sal", Convert.ToDecimal(txtSal.Text))
                cmd.Parameters.AddWithValue("@pos", cmbPos.Text)
                cmd.Parameters.AddWithValue("@doh", Convert.ToDateTime(txtDoH.Text)) ' Date of Hiring
                cmd.Parameters.AddWithValue("@user", txtUser.Text) ' Username
                cmd.Parameters.AddWithValue("@pass", hashedPassword)
                cmd.Parameters.AddWithValue("@imagePath", imagePath)
                cmd.Parameters.AddWithValue("@role", txtRole.Text)
                cmd.Parameters.AddWithValue("@emptype", txtEmploType.Text)
                cmd.Parameters.AddWithValue("@dept", cmbDepartment.Text) ' 🌟 Department field added here

                ' Execute the query
                cmd.ExecuteNonQuery()

                Dim msg As String = If(Mode = "Update", "Employee updated successfully!", "Employee added successfully!")
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to save employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' OpenFileDialog for selecting an image
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Load the image into memory to avoid file locking issues
                Using tempImage As Image = Image.FromFile(openFileDialog.FileName)
                    ' Clone the image so it is no longer tied to the file on disk
                    txtPicBox.Image = New Bitmap(tempImage)
                End Using
            Catch ex As Exception
                MessageBox.Show("Failed to load image: " & ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    ' Ensure it's in the same form as FormFullDetailed_Load
    ' Form Load Event


    ' Method to Load Employee Data
    ' Method to Load Employee Data
    ' Method to Load Employee Data
    Private Sub FormFullDetailed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartment.Items.Clear()
        cmbDepartment.Items.AddRange(departmentPositions.Keys.ToArray())


        If Mode = "Add" Then
            btnSave.Enabled = True
            btnUpdateEmployee.Enabled = False
        ElseIf Mode = "Update" Then
            txtEmployeeID1.Text = EmployeeID
            btnSave.Enabled = False
            btnUpdateEmployee.Enabled = True

            ' Load employee details
            Try
                Using conn As New MySqlConnection("server=localhost; user id=root; password=; database=payrolldb")
                    conn.Open()

                    Dim query As String = "SELECT * FROM employees WHERE employee_id = @employeeID"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@employeeID", EmployeeID)

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                ' ✅ Populate fields
                                txtUser.Text = reader("username").ToString()
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
                                txtRole.Text = reader("role").ToString()
                                cmbDepartment_SelectedIndexChanged(Nothing, Nothing)
                                txtEmploType.Text = reader("employee_type").ToString()
                                cmbDepartment.Text = reader("department").ToString()

                                If cmbDepartment.SelectedIndex = -1 OrElse cmbPos.SelectedIndex = -1 Then
                                    MessageBox.Show("Please select both a department and a valid position.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Return
                                End If


                                ' ✅ Safe Date Parsing
                                If Not IsDBNull(reader("date_of_birth")) Then
                                    txtDoB.Value = Convert.ToDateTime(reader("date_of_birth"))
                                End If
                                If Not IsDBNull(reader("date_hired")) Then
                                    txtDoH.Value = Convert.ToDateTime(reader("date_hired"))
                                End If

                                ' 🔐 Store hashed password for later validation
                                originalHashedPassword = reader("password").ToString()

                                ' 🖼 Safely load image without locking the file
                                If Not IsDBNull(reader("image_path")) Then
                                    Dim imgPath As String = reader("image_path").ToString()
                                    If File.Exists(imgPath) Then
                                        Using fs As New FileStream(imgPath, FileMode.Open, FileAccess.Read)
                                            Dim img = Image.FromStream(fs)
                                            txtPicBox.Image = New Bitmap(img) ' Clone the image to break file lock
                                        End Using
                                    End If
                                End If

                            Else
                                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading employee data: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


        Sibebar.AutoScroll = True
        Sibebar.VerticalScroll.Visible = True
        Sibebar.HorizontalScroll.Enabled = False
        Sibebar.WrapContents = False


        Sibebar.Controls.Clear()
        For i As Integer = 1 To 100
            Dim btn As New Button()
            btn.Text = "Option " & i
            btn.Width = Sibebar.Width - 30
            btn.Height = 100
            btn.Top = (i - 1) * 45
            btn.Left = 5
            Sibebar.Controls.Add(btn)
        Next


    End Sub










    ' Check if all textboxes are filled before allowing update
    Private Function AreAllFieldsFilled() As Boolean
        ' Check if any required field is empty
        If String.IsNullOrEmpty(txtFirstName.Text) OrElse
           String.IsNullOrEmpty(txtLastname.Text) OrElse
           String.IsNullOrEmpty(txtAge.Text) OrElse
           String.IsNullOrEmpty(txtAdd2.Text) OrElse
           String.IsNullOrEmpty(txtGender.Text) OrElse
           String.IsNullOrEmpty(txtCity.Text) OrElse
           String.IsNullOrEmpty(txtDoB.Text) OrElse
           String.IsNullOrEmpty(txtStat.Text) OrElse
           String.IsNullOrEmpty(txtMobile2.Text) OrElse
           String.IsNullOrEmpty(txtZip2.Text) OrElse
           String.IsNullOrEmpty(txtMother.Text) OrElse
           String.IsNullOrEmpty(txtOcc1.Text) OrElse
           String.IsNullOrEmpty(txtFather.Text) OrElse
           String.IsNullOrEmpty(txtOcc2.Text) OrElse
           String.IsNullOrEmpty(txtSal.Text) OrElse
           String.IsNullOrEmpty(cmbPos.Text) OrElse
           String.IsNullOrEmpty(txtDoH.Text) OrElse
           String.IsNullOrEmpty(txtUser.Text) OrElse
           String.IsNullOrEmpty(txtRole.Text) OrElse
           String.IsNullOrEmpty(cmbDepartment.Text) OrElse
           String.IsNullOrEmpty(txtEmploType.Text) Then

            Return False ' Return False if any required field is empty
        End If

        Return True ' All fields are filled
    End Function

    ' Update Employee Data when the Update button is clicked




    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        Dim selectedDept As String = cmbDepartment.Text

        If departmentPositions.ContainsKey(selectedDept) Then
            cmbPos.Items.Clear()
            For Each position In departmentPositions(selectedDept).Keys
                cmbPos.Items.Add(position)
            Next
            If cmbPos.Items.Count > 0 Then cmbPos.SelectedIndex = 0
        End If
    End Sub


    Private Sub cmbPos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPos.SelectedIndexChanged
        Dim selectedDept As String = cmbDepartment.Text
        Dim selectedPos As String = cmbPos.Text

        If departmentPositions.ContainsKey(selectedDept) Then
            Dim posDict = departmentPositions(selectedDept)
            If posDict.ContainsKey(selectedPos) Then
                txtSal.Text = posDict(selectedPos).ToString("N2") ' format: 35,000.00
            Else
                txtSal.Text = ""
            End If
        Else
            txtSal.Text = ""
        End If
    End Sub





    ' Back Button functionality


    ' Update Account Button functionality




    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        If AreAllFieldsFilled() Then
            Try
                Using conn As New MySqlConnection("server=localhost; user id=root; password=; database=payrolldb")
                    conn.Open()

                    ' ✅ Fetch the original hashed password from DB before updating
                    Dim originalHashedPassword As String = ""
                    Dim passwordQuery As String = "SELECT password FROM employees WHERE employee_id = @employeeID"
                    Using cmdFetch As New MySqlCommand(passwordQuery, conn)
                        cmdFetch.Parameters.AddWithValue("@employeeID", EmployeeID)
                        Using reader As MySqlDataReader = cmdFetch.ExecuteReader()
                            If reader.Read() Then
                                originalHashedPassword = reader("password").ToString()
                            End If
                        End Using
                    End Using

                    ' ✅ UPDATED QUERY - includes image_path
                    Dim query As String = "UPDATE employees SET 
                    first_name=@firstName, last_name=@lastName, age=@age, address=@address, gender=@gender, 
                    city=@city, date_of_birth=@dob, civil_status=@stat, mobile=@mobile, zip_code=@zip,
                    mother_name=@mother, mother_occupation=@motherOcc, father_name=@father, father_occupation=@fatherOcc,
                    salary=@salary, position=@position, department=@department, date_hired=@dateHired, 
                    username=@username, password=@password, role=@role, employee_type=@employeeType,
                    image_path=@imagePath
                    WHERE employee_id=@employeeID"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text)
                        cmd.Parameters.AddWithValue("@lastName", txtLastname.Text)
                        cmd.Parameters.AddWithValue("@age", txtAge.Text)
                        cmd.Parameters.AddWithValue("@address", txtAdd2.Text)
                        cmd.Parameters.AddWithValue("@gender", txtGender.Text)
                        cmd.Parameters.AddWithValue("@city", txtCity.Text)

                        ' ✅ Safe Date of Birth parsing
                        Dim dobParsed As DateTime
                        If DateTime.TryParse(txtDoB.Text, dobParsed) Then
                            cmd.Parameters.AddWithValue("@dob", dobParsed)
                        Else
                            MessageBox.Show("Invalid Date of Birth format.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If

                        cmd.Parameters.AddWithValue("@stat", txtStat.Text)
                        cmd.Parameters.AddWithValue("@mobile", txtMobile2.Text)
                        cmd.Parameters.AddWithValue("@zip", txtZip2.Text)
                        cmd.Parameters.AddWithValue("@mother", txtMother.Text)
                        cmd.Parameters.AddWithValue("@motherOcc", txtOcc1.Text)
                        cmd.Parameters.AddWithValue("@father", txtFather.Text)
                        cmd.Parameters.AddWithValue("@fatherOcc", txtOcc2.Text)

                        cmd.Parameters.AddWithValue("@position", cmbPos.Text)
                        cmd.Parameters.AddWithValue("@department", cmbDepartment.Text)


                        ' ✅ Salary validation: Ensure it's numeric and positive
                        Dim salaryParsed As Decimal
                        If Decimal.TryParse(txtSal.Text, salaryParsed) AndAlso salaryParsed >= 0 Then
                            cmd.Parameters.AddWithValue("@salary", salaryParsed)
                        Else
                            MessageBox.Show("Invalid salary. Please enter a valid positive number.", "Salary Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If


                        ' ✅ IMAGE SAVE + GDI+ WORKAROUND
                        Dim imagePath As String = ""
                        If txtPicBox.Image IsNot Nothing Then
                            Dim folderPath As String = "Images/EmployeePics"
                            If Not IO.Directory.Exists(folderPath) Then
                                IO.Directory.CreateDirectory(folderPath)
                            End If

                            imagePath = Path.Combine(folderPath, txtEmployeeID.Text & ".jpg")

                            ' 🔓 GDI+ fix: clone image before saving to avoid file lock
                            Using bmp As New Bitmap(txtPicBox.Image)
                                bmp.Save(imagePath, Imaging.ImageFormat.Jpeg)
                            End Using
                        End If
                        cmd.Parameters.AddWithValue("@imagePath", imagePath)

                        ' ✅ Parse Date Hired safely
                        Dim hiredParsed As DateTime
                        If DateTime.TryParse(txtDoH.Text, hiredParsed) Then
                            cmd.Parameters.AddWithValue("@dateHired", hiredParsed)
                        Else
                            MessageBox.Show("Invalid Date Hired format.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If

                        cmd.Parameters.AddWithValue("@username", txtUser.Text)

                        ' 🔐 Password logic: hash only if changed
                        Dim currentPasswordInput As String = txtPass.Text.Trim()
                        Dim passwordToSave As String = originalHashedPassword

                        If Not String.IsNullOrEmpty(currentPasswordInput) Then
                            If String.IsNullOrEmpty(originalHashedPassword) Then
                                passwordToSave = BCrypt.Net.BCrypt.HashPassword(currentPasswordInput)
                            ElseIf Not BCrypt.Net.BCrypt.Verify(currentPasswordInput, originalHashedPassword) Then
                                passwordToSave = BCrypt.Net.BCrypt.HashPassword(currentPasswordInput)
                            Else
                                passwordToSave = originalHashedPassword
                            End If
                        End If

                        If String.IsNullOrEmpty(passwordToSave) Then
                            MessageBox.Show("Password could not be saved. It is blank or invalid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If

                        cmd.Parameters.AddWithValue("@password", passwordToSave)
                        cmd.Parameters.AddWithValue("@role", txtRole.Text)
                        cmd.Parameters.AddWithValue("@employeeType", txtEmploType.Text)
                        cmd.Parameters.AddWithValue("@employeeID", EmployeeID)

                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Failed to update employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please fill in all the required fields before updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub btnSelfie_Click(sender As Object, e As EventArgs) Handles btnSelfie.Click
        Dim camForm As New frmCameraSelfie(Me)
        camForm.ShowDialog()
    End Sub

    ' 👇 This method will be called by frmCameraSelfie when a selfie is captured
    Public Sub SetCapturedImage(img As Image)
        txtPicBox.Image = img
    End Sub


    Public Sub ReceiveCapturedImage(capturedImage As Bitmap)
        ' Make sure you have a PictureBox named picEmployeePhoto or change accordingly
        txtPicBox.Image = capturedImage
    End Sub


End Class