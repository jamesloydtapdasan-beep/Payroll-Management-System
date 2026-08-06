<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffAddEmployee
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
        txtFirstName = New TextBox()
        txtLastname = New TextBox()
        txtPass = New TextBox()
        txtUser = New TextBox()
        txtEmploType = New TextBox()
        txtAge = New TextBox()
        txtGender = New TextBox()
        txtAdd2 = New TextBox()
        txtZip2 = New TextBox()
        txtCity = New TextBox()
        cmbDepartment = New ComboBox()
        cmbPos = New TextBox()
        btnSave = New Button()
        btnUpdateEmployee = New Button()
        btnSelfie = New Button()
        btnBrowse = New Button()
        txtPicBox = New PictureBox()
        txtRole = New TextBox()
        txtSal = New TextBox()
        label = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        txtDoB = New TextBox()
        txtStat = New TextBox()
        Label1 = New Label()
        Label16 = New Label()
        txtMobile2 = New TextBox()
        Label17 = New Label()
        txtMother = New TextBox()
        txtFather = New TextBox()
        txtOcc1 = New TextBox()
        txtOcc2 = New TextBox()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        txtEmployeeID = New TextBox()
        Label23 = New Label()
        txtDoH = New TextBox()
        btnBack = New Button()
        CType(txtPicBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(150, 68)
        txtFirstName.Margin = New Padding(4, 4, 4, 4)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(127, 25)
        txtFirstName.TabIndex = 0
        ' 
        ' txtLastname
        ' 
        txtLastname.Location = New Point(150, 103)
        txtLastname.Margin = New Padding(4, 4, 4, 4)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(127, 25)
        txtLastname.TabIndex = 1
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(150, 189)
        txtPass.Margin = New Padding(4, 4, 4, 4)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(127, 25)
        txtPass.TabIndex = 2
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(150, 144)
        txtUser.Margin = New Padding(4, 4, 4, 4)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(127, 25)
        txtUser.TabIndex = 2
        ' 
        ' txtEmploType
        ' 
        txtEmploType.Location = New Point(150, 237)
        txtEmploType.Margin = New Padding(4, 4, 4, 4)
        txtEmploType.Name = "txtEmploType"
        txtEmploType.Size = New Size(127, 25)
        txtEmploType.TabIndex = 3
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(403, 80)
        txtAge.Margin = New Padding(4, 4, 4, 4)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(127, 25)
        txtAge.TabIndex = 4
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(403, 115)
        txtGender.Margin = New Padding(4, 4, 4, 4)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(127, 25)
        txtGender.TabIndex = 5
        ' 
        ' txtAdd2
        ' 
        txtAdd2.Location = New Point(403, 149)
        txtAdd2.Margin = New Padding(4, 4, 4, 4)
        txtAdd2.Name = "txtAdd2"
        txtAdd2.Size = New Size(127, 25)
        txtAdd2.TabIndex = 6
        ' 
        ' txtZip2
        ' 
        txtZip2.Location = New Point(403, 248)
        txtZip2.Margin = New Padding(4, 4, 4, 4)
        txtZip2.Name = "txtZip2"
        txtZip2.Size = New Size(127, 25)
        txtZip2.TabIndex = 7
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(403, 200)
        txtCity.Margin = New Padding(4, 4, 4, 4)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(127, 25)
        txtCity.TabIndex = 7
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Location = New Point(417, 332)
        cmbDepartment.Margin = New Padding(4, 4, 4, 4)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(154, 24)
        cmbDepartment.TabIndex = 8
        ' 
        ' cmbPos
        ' 
        cmbPos.Location = New Point(417, 413)
        cmbPos.Margin = New Padding(4, 4, 4, 4)
        cmbPos.Name = "cmbPos"
        cmbPos.Size = New Size(127, 25)
        cmbPos.TabIndex = 9
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(530, 471)
        btnSave.Margin = New Padding(4, 4, 4, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(108, 43)
        btnSave.TabIndex = 10
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateEmployee
        ' 
        btnUpdateEmployee.Location = New Point(695, 471)
        btnUpdateEmployee.Margin = New Padding(4, 4, 4, 4)
        btnUpdateEmployee.Name = "btnUpdateEmployee"
        btnUpdateEmployee.Size = New Size(159, 43)
        btnUpdateEmployee.TabIndex = 11
        btnUpdateEmployee.Text = "Update Employee"
        btnUpdateEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnSelfie
        ' 
        btnSelfie.Location = New Point(917, 244)
        btnSelfie.Margin = New Padding(4, 4, 4, 4)
        btnSelfie.Name = "btnSelfie"
        btnSelfie.Size = New Size(96, 39)
        btnSelfie.TabIndex = 12
        btnSelfie.Text = "Selfie"
        btnSelfie.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(796, 244)
        btnBrowse.Margin = New Padding(4, 4, 4, 4)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(96, 39)
        btnBrowse.TabIndex = 12
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' txtPicBox
        ' 
        txtPicBox.Location = New Point(830, 60)
        txtPicBox.Margin = New Padding(4, 4, 4, 4)
        txtPicBox.Name = "txtPicBox"
        txtPicBox.Size = New Size(163, 148)
        txtPicBox.TabIndex = 13
        txtPicBox.TabStop = False
        ' 
        ' txtRole
        ' 
        txtRole.Location = New Point(645, 76)
        txtRole.Margin = New Padding(4, 4, 4, 4)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(127, 25)
        txtRole.TabIndex = 14
        ' 
        ' txtSal
        ' 
        txtSal.Location = New Point(645, 125)
        txtSal.Margin = New Padding(4, 4, 4, 4)
        txtSal.Name = "txtSal"
        txtSal.Size = New Size(127, 25)
        txtSal.TabIndex = 15
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Location = New Point(51, 72)
        label.Margin = New Padding(4, 0, 4, 0)
        label.Name = "label"
        label.Size = New Size(77, 18)
        label.TabIndex = 16
        label.Text = "Firstname"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 107)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 18)
        Label2.TabIndex = 17
        Label2.Text = "Lastname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 148)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 18)
        Label3.TabIndex = 18
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(329, 113)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 18)
        Label4.TabIndex = 19
        Label4.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(53, 198)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 18)
        Label5.TabIndex = 19
        Label5.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(341, 76)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 18)
        Label6.TabIndex = 20
        Label6.Text = "Age"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(18, 244)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(122, 18)
        Label7.TabIndex = 20
        Label7.Text = "Employee Type"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(329, 152)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 18)
        Label8.TabIndex = 21
        Label8.Text = "Address"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(348, 202)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(37, 18)
        Label9.TabIndex = 22
        Label9.Text = "City"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(355, 255)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(30, 18)
        Label10.TabIndex = 23
        Label10.Text = "Zip"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(572, 82)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(41, 18)
        Label11.TabIndex = 24
        Label11.Text = "Role"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(572, 118)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(54, 18)
        Label12.TabIndex = 25
        Label12.Text = "Salary"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(319, 334)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(95, 18)
        Label13.TabIndex = 26
        Label13.Text = "Department"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(348, 420)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(63, 18)
        Label14.TabIndex = 27
        Label14.Text = "Position"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(891, 211)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(57, 18)
        Label15.TabIndex = 28
        Label15.Text = "PicBox"
        ' 
        ' txtDoB
        ' 
        txtDoB.Location = New Point(150, 284)
        txtDoB.Margin = New Padding(4, 4, 4, 4)
        txtDoB.Name = "txtDoB"
        txtDoB.Size = New Size(127, 25)
        txtDoB.TabIndex = 29
        ' 
        ' txtStat
        ' 
        txtStat.Location = New Point(150, 332)
        txtStat.Margin = New Padding(4, 4, 4, 4)
        txtStat.Name = "txtStat"
        txtStat.Size = New Size(127, 25)
        txtStat.TabIndex = 30
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(80, 287)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 18)
        Label1.TabIndex = 31
        Label1.Text = "DOB"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(80, 340)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(49, 18)
        Label16.TabIndex = 32
        Label16.Text = "Status"
        ' 
        ' txtMobile2
        ' 
        txtMobile2.Location = New Point(150, 383)
        txtMobile2.Margin = New Padding(4, 4, 4, 4)
        txtMobile2.Name = "txtMobile2"
        txtMobile2.Size = New Size(127, 25)
        txtMobile2.TabIndex = 33
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(18, 392)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(123, 18)
        Label17.TabIndex = 34
        Label17.Text = "Mobile Number"
        ' 
        ' txtMother
        ' 
        txtMother.Location = New Point(150, 445)
        txtMother.Margin = New Padding(4, 4, 4, 4)
        txtMother.Name = "txtMother"
        txtMother.Size = New Size(127, 25)
        txtMother.TabIndex = 35
        ' 
        ' txtFather
        ' 
        txtFather.Location = New Point(150, 480)
        txtFather.Margin = New Padding(4, 4, 4, 4)
        txtFather.Name = "txtFather"
        txtFather.Size = New Size(127, 25)
        txtFather.TabIndex = 36
        ' 
        ' txtOcc1
        ' 
        txtOcc1.Location = New Point(150, 514)
        txtOcc1.Margin = New Padding(4, 4, 4, 4)
        txtOcc1.Name = "txtOcc1"
        txtOcc1.Size = New Size(127, 25)
        txtOcc1.TabIndex = 37
        ' 
        ' txtOcc2
        ' 
        txtOcc2.Location = New Point(150, 549)
        txtOcc2.Margin = New Padding(4, 4, 4, 4)
        txtOcc2.Name = "txtOcc2"
        txtOcc2.Size = New Size(127, 25)
        txtOcc2.TabIndex = 38
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(80, 487)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(53, 18)
        Label18.TabIndex = 39
        Label18.Text = "Father"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(80, 452)
        Label19.Margin = New Padding(4, 0, 4, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(60, 18)
        Label19.TabIndex = 40
        Label19.Text = "Mother"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(41, 549)
        Label20.Margin = New Padding(4, 0, 4, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(97, 18)
        Label20.TabIndex = 41
        Label20.Text = "Occupation"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(41, 514)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(97, 18)
        Label21.TabIndex = 42
        Label21.Text = "Occupation"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(352, 369)
        Label22.Margin = New Padding(4, 0, 4, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(42, 18)
        Label22.TabIndex = 44
        Label22.Text = "DOH"
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(150, 33)
        txtEmployeeID.Margin = New Padding(4, 4, 4, 4)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(127, 25)
        txtEmployeeID.TabIndex = 45
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(36, 37)
        Label23.Margin = New Padding(4, 0, 4, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(98, 18)
        Label23.TabIndex = 46
        Label23.Text = "EmployeeID"
        ' 
        ' txtDoH
        ' 
        txtDoH.Location = New Point(417, 366)
        txtDoH.Margin = New Padding(4, 4, 4, 4)
        txtDoH.Name = "txtDoH"
        txtDoH.Size = New Size(127, 25)
        txtDoH.TabIndex = 47
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(611, 529)
        btnBack.Margin = New Padding(4, 4, 4, 4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(108, 43)
        btnBack.TabIndex = 48
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' StaffAddEmployee
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Youtube_Vlog_Traveling_Youtube_Tumbnail__16_
        ClientSize = New Size(1029, 702)
        Controls.Add(btnBack)
        Controls.Add(txtDoH)
        Controls.Add(Label23)
        Controls.Add(txtEmployeeID)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(txtOcc2)
        Controls.Add(txtOcc1)
        Controls.Add(txtFather)
        Controls.Add(txtMother)
        Controls.Add(Label17)
        Controls.Add(txtMobile2)
        Controls.Add(Label16)
        Controls.Add(Label1)
        Controls.Add(txtStat)
        Controls.Add(txtDoB)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(label)
        Controls.Add(txtSal)
        Controls.Add(txtRole)
        Controls.Add(txtPicBox)
        Controls.Add(btnBrowse)
        Controls.Add(btnSelfie)
        Controls.Add(btnUpdateEmployee)
        Controls.Add(btnSave)
        Controls.Add(cmbPos)
        Controls.Add(cmbDepartment)
        Controls.Add(txtCity)
        Controls.Add(txtZip2)
        Controls.Add(txtAdd2)
        Controls.Add(txtGender)
        Controls.Add(txtAge)
        Controls.Add(txtEmploType)
        Controls.Add(txtUser)
        Controls.Add(txtPass)
        Controls.Add(txtLastname)
        Controls.Add(txtFirstName)
        Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Margin = New Padding(4, 4, 4, 4)
        Name = "StaffAddEmployee"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StaffAddEmployee"
        CType(txtPicBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtEmploType As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtAdd2 As TextBox
    Friend WithEvents txtZip2 As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents cmbPos As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdateEmployee As Button
    Friend WithEvents btnSelfie As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtPicBox As PictureBox
    Friend WithEvents txtRole As TextBox
    Friend WithEvents txtSal As TextBox
    Friend WithEvents label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDoB As TextBox
    Friend WithEvents txtStat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtMobile2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtMother As TextBox
    Friend WithEvents txtFather As TextBox
    Friend WithEvents txtOcc1 As TextBox
    Friend WithEvents txtOcc2 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtDoH As TextBox
    Friend WithEvents btnBack As Button
End Class
