<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFullDetailed
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtEmploType = New TextBox()
        Label18 = New Label()
        txtFirstName = New TextBox()
        Label17 = New Label()
        Label16 = New Label()
        txtMobile2 = New TextBox()
        txtPicBox = New PictureBox()
        txtMother = New TextBox()
        Label15 = New Label()
        Label14 = New Label()
        Label9 = New Label()
        txtSal = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        txtAdd2 = New TextBox()
        Label6 = New Label()
        txtLastname = New TextBox()
        txtAge = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label10 = New Label()
        txtCity = New TextBox()
        txtZip2 = New TextBox()
        btnBrowse = New Button()
        Label13 = New Label()
        txtOcc1 = New TextBox()
        Label19 = New Label()
        Label20 = New Label()
        txtFather = New TextBox()
        txtOcc2 = New TextBox()
        txtStat = New TextBox()
        Label21 = New Label()
        txtGender = New TextBox()
        Label22 = New Label()
        Label23 = New Label()
        txtRole = New TextBox()
        btnSave = New Button()
        btnGoBack = New Button()
        btnUpdateEmployee = New Button()
        txtEmployeeID = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        Label24 = New Label()
        Label25 = New Label()
        txtEmployeeID1 = New TextBox()
        txtDoB = New DateTimePicker()
        txtDoH = New DateTimePicker()
        Label26 = New Label()
        cmbDepartment = New ComboBox()
        cmbPos = New ComboBox()
        PictureBox1 = New PictureBox()
        Sibebar = New FlowLayoutPanel()
        btnSelfie = New Button()
        CType(txtPicBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtEmploType
        ' 
        txtEmploType.BorderStyle = BorderStyle.FixedSingle
        txtEmploType.Location = New Point(176, 459)
        txtEmploType.Margin = New Padding(3, 2, 3, 2)
        txtEmploType.Name = "txtEmploType"
        txtEmploType.Size = New Size(204, 23)
        txtEmploType.TabIndex = 71
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(43, 456)
        Label18.Name = "Label18"
        Label18.Size = New Size(129, 17)
        Label18.TabIndex = 70
        Label18.Text = "Employment Type :"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BorderStyle = BorderStyle.FixedSingle
        txtFirstName.Location = New Point(169, 141)
        txtFirstName.Margin = New Padding(3, 2, 3, 2)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(276, 23)
        txtFirstName.TabIndex = 69
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(74, 119)
        Label17.Name = "Label17"
        Label17.Size = New Size(96, 17)
        Label17.TabIndex = 68
        Label17.Text = "Employee ID :"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(71, 486)
        Label16.Name = "Label16"
        Label16.Size = New Size(106, 17)
        Label16.TabIndex = 66
        Label16.Text = "Date of Hired : "
        ' 
        ' txtMobile2
        ' 
        txtMobile2.BorderStyle = BorderStyle.FixedSingle
        txtMobile2.Location = New Point(178, 349)
        txtMobile2.Margin = New Padding(3, 2, 3, 2)
        txtMobile2.Name = "txtMobile2"
        txtMobile2.Size = New Size(202, 23)
        txtMobile2.TabIndex = 65
        ' 
        ' txtPicBox
        ' 
        txtPicBox.BorderStyle = BorderStyle.FixedSingle
        txtPicBox.Image = My.Resources.Resources._9187604
        txtPicBox.Location = New Point(586, 141)
        txtPicBox.Name = "txtPicBox"
        txtPicBox.Size = New Size(140, 127)
        txtPicBox.SizeMode = PictureBoxSizeMode.StretchImage
        txtPicBox.TabIndex = 64
        txtPicBox.TabStop = False
        ' 
        ' txtMother
        ' 
        txtMother.BorderStyle = BorderStyle.FixedSingle
        txtMother.Location = New Point(178, 377)
        txtMother.Margin = New Padding(3, 2, 3, 2)
        txtMother.Name = "txtMother"
        txtMother.Size = New Size(204, 23)
        txtMother.TabIndex = 63
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(61, 381)
        Label15.Name = "Label15"
        Label15.Size = New Size(117, 17)
        Label15.TabIndex = 62
        Label15.Text = "Mother's Name : "
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(74, 351)
        Label14.Name = "Label14"
        Label14.Size = New Size(108, 17)
        Label14.TabIndex = 61
        Label14.Text = "Mobile Phone : "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(479, 351)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 17)
        Label9.TabIndex = 58
        Label9.Text = "ZIP code : "
        ' 
        ' txtSal
        ' 
        txtSal.BorderStyle = BorderStyle.FixedSingle
        txtSal.Location = New Point(177, 433)
        txtSal.Margin = New Padding(3, 2, 3, 2)
        txtSal.Name = "txtSal"
        txtSal.ReadOnly = True
        txtSal.Size = New Size(205, 23)
        txtSal.TabIndex = 57
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(123, 197)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 17)
        Label8.TabIndex = 56
        Label8.Text = "Age :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(123, 273)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 17)
        Label7.TabIndex = 54
        Label7.Text = "City :"
        ' 
        ' txtAdd2
        ' 
        txtAdd2.BorderStyle = BorderStyle.FixedSingle
        txtAdd2.Location = New Point(168, 219)
        txtAdd2.Margin = New Padding(3, 2, 3, 2)
        txtAdd2.Name = "txtAdd2"
        txtAdd2.Size = New Size(276, 23)
        txtAdd2.TabIndex = 53
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(102, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 17)
        Label6.TabIndex = 52
        Label6.Text = "Address : "
        ' 
        ' txtLastname
        ' 
        txtLastname.BorderStyle = BorderStyle.FixedSingle
        txtLastname.Location = New Point(167, 167)
        txtLastname.Margin = New Padding(3, 2, 3, 2)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(276, 23)
        txtLastname.TabIndex = 50
        ' 
        ' txtAge
        ' 
        txtAge.BorderStyle = BorderStyle.FixedSingle
        txtAge.Location = New Point(168, 194)
        txtAge.Margin = New Padding(3, 2, 3, 2)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(276, 23)
        txtAge.TabIndex = 49
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(119, 431)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 17)
        Label3.TabIndex = 45
        Label3.Text = "Salary : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(486, 451)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 17)
        Label2.TabIndex = 44
        Label2.Text = "Position : "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(83, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 17)
        Label1.TabIndex = 43
        Label1.Text = "First Name :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(79, 170)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 17)
        Label5.TabIndex = 73
        Label5.Text = "Last Name :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(72, 298)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 17)
        Label10.TabIndex = 76
        Label10.Text = "Date of Birth : "
        ' 
        ' txtCity
        ' 
        txtCity.BorderStyle = BorderStyle.FixedSingle
        txtCity.Location = New Point(168, 270)
        txtCity.Margin = New Padding(3, 2, 3, 2)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(274, 23)
        txtCity.TabIndex = 78
        ' 
        ' txtZip2
        ' 
        txtZip2.BorderStyle = BorderStyle.FixedSingle
        txtZip2.Location = New Point(568, 346)
        txtZip2.Margin = New Padding(3, 2, 3, 2)
        txtZip2.Name = "txtZip2"
        txtZip2.Size = New Size(212, 23)
        txtZip2.TabIndex = 79
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = SystemColors.ButtonHighlight
        btnBrowse.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnBrowse.BackgroundImageLayout = ImageLayout.Stretch
        btnBrowse.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(486, 283)
        btnBrowse.Margin = New Padding(3, 2, 3, 2)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(158, 40)
        btnBrowse.TabIndex = 83
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(464, 375)
        Label13.Name = "Label13"
        Label13.Size = New Size(98, 17)
        Label13.TabIndex = 84
        Label13.Text = "Occupation : "
        ' 
        ' txtOcc1
        ' 
        txtOcc1.BorderStyle = BorderStyle.FixedSingle
        txtOcc1.Location = New Point(568, 372)
        txtOcc1.Margin = New Padding(3, 2, 3, 2)
        txtOcc1.Name = "txtOcc1"
        txtOcc1.Size = New Size(212, 23)
        txtOcc1.TabIndex = 85
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(65, 407)
        Label19.Name = "Label19"
        Label19.Size = New Size(116, 17)
        Label19.TabIndex = 86
        Label19.Text = "Father's Name :  "
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(464, 404)
        Label20.Name = "Label20"
        Label20.Size = New Size(98, 17)
        Label20.TabIndex = 87
        Label20.Text = "Occupation : "
        ' 
        ' txtFather
        ' 
        txtFather.BorderStyle = BorderStyle.FixedSingle
        txtFather.Location = New Point(177, 406)
        txtFather.Margin = New Padding(3, 2, 3, 2)
        txtFather.Name = "txtFather"
        txtFather.Size = New Size(205, 23)
        txtFather.TabIndex = 88
        ' 
        ' txtOcc2
        ' 
        txtOcc2.BorderStyle = BorderStyle.FixedSingle
        txtOcc2.Location = New Point(568, 398)
        txtOcc2.Margin = New Padding(3, 2, 3, 2)
        txtOcc2.Name = "txtOcc2"
        txtOcc2.Size = New Size(212, 23)
        txtOcc2.TabIndex = 89
        ' 
        ' txtStat
        ' 
        txtStat.BorderStyle = BorderStyle.FixedSingle
        txtStat.Location = New Point(168, 322)
        txtStat.Margin = New Padding(3, 2, 3, 2)
        txtStat.Name = "txtStat"
        txtStat.Size = New Size(276, 23)
        txtStat.TabIndex = 90
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(106, 324)
        Label21.Name = "Label21"
        Label21.Size = New Size(58, 17)
        Label21.TabIndex = 91
        Label21.Text = "Status : "
        ' 
        ' txtGender
        ' 
        txtGender.BorderStyle = BorderStyle.FixedSingle
        txtGender.Location = New Point(168, 245)
        txtGender.Margin = New Padding(3, 2, 3, 2)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(274, 23)
        txtGender.TabIndex = 92
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(95, 247)
        Label22.Name = "Label22"
        Label22.Size = New Size(68, 17)
        Label22.TabIndex = 93
        Label22.Text = "Gender : "
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(505, 476)
        Label23.Name = "Label23"
        Label23.Size = New Size(48, 17)
        Label23.TabIndex = 94
        Label23.Text = "Role : "
        ' 
        ' txtRole
        ' 
        txtRole.BorderStyle = BorderStyle.FixedSingle
        txtRole.Location = New Point(568, 473)
        txtRole.Margin = New Padding(3, 2, 3, 2)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(212, 23)
        txtRole.TabIndex = 95
        ' 
        ' btnSave
        ' 
        btnSave.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnSave.BackgroundImageLayout = ImageLayout.Stretch
        btnSave.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(537, 508)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(140, 40)
        btnSave.TabIndex = 96
        btnSave.Text = "Add Employee"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnGoBack
        ' 
        btnGoBack.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnGoBack.BackgroundImageLayout = ImageLayout.Stretch
        btnGoBack.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGoBack.Location = New Point(685, 508)
        btnGoBack.Margin = New Padding(3, 2, 3, 2)
        btnGoBack.Name = "btnGoBack"
        btnGoBack.Size = New Size(88, 40)
        btnGoBack.TabIndex = 97
        btnGoBack.Text = "Go Back"
        btnGoBack.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateEmployee
        ' 
        btnUpdateEmployee.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnUpdateEmployee.BackgroundImageLayout = ImageLayout.Stretch
        btnUpdateEmployee.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateEmployee.Location = New Point(388, 508)
        btnUpdateEmployee.Margin = New Padding(3, 2, 3, 2)
        btnUpdateEmployee.Name = "btnUpdateEmployee"
        btnUpdateEmployee.Size = New Size(144, 39)
        btnUpdateEmployee.TabIndex = 98
        btnUpdateEmployee.Text = "Save Update"
        btnUpdateEmployee.UseVisualStyleBackColor = True
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.AutoSize = True
        txtEmployeeID.Location = New Point(169, 122)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(0, 15)
        txtEmployeeID.TabIndex = 99
        ' 
        ' txtUser
        ' 
        txtUser.BorderStyle = BorderStyle.FixedSingle
        txtUser.Location = New Point(176, 513)
        txtUser.Margin = New Padding(3, 2, 3, 2)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(202, 23)
        txtUser.TabIndex = 100
        ' 
        ' txtPass
        ' 
        txtPass.BorderStyle = BorderStyle.FixedSingle
        txtPass.Location = New Point(176, 541)
        txtPass.Margin = New Padding(3, 2, 3, 2)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(202, 23)
        txtPass.TabIndex = 101
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(85, 512)
        Label24.Name = "Label24"
        Label24.Size = New Size(87, 17)
        Label24.TabIndex = 102
        Label24.Text = " Username : "
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(92, 541)
        Label25.Name = "Label25"
        Label25.Size = New Size(77, 17)
        Label25.TabIndex = 103
        Label25.Text = "Password :"
        ' 
        ' txtEmployeeID1
        ' 
        txtEmployeeID1.BorderStyle = BorderStyle.FixedSingle
        txtEmployeeID1.Location = New Point(171, 115)
        txtEmployeeID1.Margin = New Padding(3, 2, 3, 2)
        txtEmployeeID1.Name = "txtEmployeeID1"
        txtEmployeeID1.ReadOnly = True
        txtEmployeeID1.Size = New Size(88, 23)
        txtEmployeeID1.TabIndex = 106
        ' 
        ' txtDoB
        ' 
        txtDoB.Location = New Point(168, 295)
        txtDoB.Margin = New Padding(3, 2, 3, 2)
        txtDoB.Name = "txtDoB"
        txtDoB.Size = New Size(274, 23)
        txtDoB.TabIndex = 107
        ' 
        ' txtDoH
        ' 
        txtDoH.Location = New Point(176, 487)
        txtDoH.Margin = New Padding(3, 2, 3, 2)
        txtDoH.Name = "txtDoH"
        txtDoH.Size = New Size(205, 23)
        txtDoH.TabIndex = 108
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(463, 429)
        Label26.Name = "Label26"
        Label26.Size = New Size(99, 17)
        Label26.TabIndex = 110
        Label26.Text = "Department : "
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Location = New Point(568, 422)
        cmbDepartment.Margin = New Padding(3, 2, 3, 2)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(212, 23)
        cmbDepartment.TabIndex = 111
        ' 
        ' cmbPos
        ' 
        cmbPos.FormattingEnabled = True
        cmbPos.Location = New Point(566, 447)
        cmbPos.Margin = New Padding(3, 2, 3, 2)
        cmbPos.Name = "cmbPos"
        cmbPos.Size = New Size(214, 23)
        cmbPos.TabIndex = 112
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._9005205
        PictureBox1.Location = New Point(494, 288)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(31, 28)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 113
        PictureBox1.TabStop = False
        ' 
        ' Sibebar
        ' 
        Sibebar.BackColor = Color.DimGray
        Sibebar.Location = New Point(822, 0)
        Sibebar.Margin = New Padding(3, 2, 3, 2)
        Sibebar.Name = "Sibebar"
        Sibebar.Size = New Size(25, 629)
        Sibebar.TabIndex = 114
        ' 
        ' btnSelfie
        ' 
        btnSelfie.BackColor = SystemColors.ButtonHighlight
        btnSelfie.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnSelfie.BackgroundImageLayout = ImageLayout.Stretch
        btnSelfie.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelfie.Location = New Point(648, 283)
        btnSelfie.Margin = New Padding(3, 2, 3, 2)
        btnSelfie.Name = "btnSelfie"
        btnSelfie.Size = New Size(158, 40)
        btnSelfie.TabIndex = 115
        btnSelfie.Text = "Selfie"
        btnSelfie.UseVisualStyleBackColor = False
        ' 
        ' FormFullDetailed
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackgroundImage = My.Resources.Resources.Youtube_Vlog_Traveling_Youtube_Tumbnail__19_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(859, 622)
        Controls.Add(btnSelfie)
        Controls.Add(Sibebar)
        Controls.Add(PictureBox1)
        Controls.Add(cmbPos)
        Controls.Add(cmbDepartment)
        Controls.Add(Label26)
        Controls.Add(txtDoH)
        Controls.Add(txtDoB)
        Controls.Add(txtEmployeeID1)
        Controls.Add(Label25)
        Controls.Add(Label24)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(txtEmployeeID)
        Controls.Add(btnUpdateEmployee)
        Controls.Add(btnGoBack)
        Controls.Add(btnSave)
        Controls.Add(txtRole)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(txtGender)
        Controls.Add(Label21)
        Controls.Add(txtStat)
        Controls.Add(txtOcc2)
        Controls.Add(txtFather)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(txtOcc1)
        Controls.Add(Label13)
        Controls.Add(btnBrowse)
        Controls.Add(txtZip2)
        Controls.Add(txtCity)
        Controls.Add(Label10)
        Controls.Add(Label5)
        Controls.Add(txtEmploType)
        Controls.Add(Label18)
        Controls.Add(txtFirstName)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(txtMobile2)
        Controls.Add(txtPicBox)
        Controls.Add(txtMother)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label9)
        Controls.Add(txtSal)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtAdd2)
        Controls.Add(Label6)
        Controls.Add(txtLastname)
        Controls.Add(txtAge)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "FormFullDetailed"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormFullDetailed"
        CType(txtPicBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtEmploType As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtMobile2 As TextBox
    Friend WithEvents txtPicBox As PictureBox
    Friend WithEvents txtMother As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAdd2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBack1 As Button
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnUpdateAccount As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtZip2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtOcc1 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtFather As TextBox
    Friend WithEvents txtOcc2 As TextBox
    Friend WithEvents txtStat As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtRole As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnGoBack As Button
    Friend WithEvents btnUpdateEmployee As Button
    Friend WithEvents txtEmployeeID As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtEmployeeID1 As TextBox
    Friend WithEvents dtpDoB As DateTimePicker
    Friend WithEvents dtpDoH As DateTimePicker
    Friend WithEvents txtDoB As DateTimePicker
    Friend WithEvents txtDoH As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents cmbPos As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Sibebar As FlowLayoutPanel
    Friend WithEvents btnSelfie As Button
End Class
