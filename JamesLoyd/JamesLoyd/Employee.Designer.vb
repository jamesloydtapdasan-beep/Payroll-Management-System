<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageAccount))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnAdd = New Button()
        btnUpdateAccount = New Button()
        btnDel = New Button()
        txtFullName = New TextBox()
        btnBack1 = New Button()
        picEmployee = New PictureBox()
        Label17 = New Label()
        txtEmployeeID = New TextBox()
        Label18 = New Label()
        Label5 = New Label()
        txtEmploType = New TextBox()
        txtSal = New TextBox()
        txtPos = New TextBox()
        btnSearch = New Button()
        Label6 = New Label()
        txtRole = New TextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        txtExcel = New TextBox()
        Label4 = New Label()
        btnU = New Button()
        btnB = New Button()
        btnAll = New Button()
        PictureBox5 = New PictureBox()
        CType(picEmployee, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(240, 184)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 17)
        Label1.TabIndex = 0
        Label1.Text = "Full Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(495, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 17)
        Label2.TabIndex = 1
        Label2.Text = "Position : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(240, 328)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 17)
        Label3.TabIndex = 2
        Label3.Text = "Salary : "
        ' 
        ' btnAdd
        ' 
        btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), Image)
        btnAdd.BackgroundImageLayout = ImageLayout.Stretch
        btnAdd.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = SystemColors.ActiveCaptionText
        btnAdd.Location = New Point(2, 126)
        btnAdd.Margin = New Padding(3, 2, 3, 2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(182, 45)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add a Employee"
        btnAdd.TextAlign = ContentAlignment.MiddleRight
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateAccount
        ' 
        btnUpdateAccount.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6121
        btnUpdateAccount.BackgroundImageLayout = ImageLayout.Stretch
        btnUpdateAccount.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateAccount.Location = New Point(2, 184)
        btnUpdateAccount.Margin = New Padding(3, 2, 3, 2)
        btnUpdateAccount.Name = "btnUpdateAccount"
        btnUpdateAccount.Size = New Size(182, 45)
        btnUpdateAccount.TabIndex = 4
        btnUpdateAccount.Text = "Edit "
        btnUpdateAccount.UseVisualStyleBackColor = True
        ' 
        ' btnDel
        ' 
        btnDel.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6122
        btnDel.BackgroundImageLayout = ImageLayout.Stretch
        btnDel.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDel.Location = New Point(2, 244)
        btnDel.Margin = New Padding(3, 2, 3, 2)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(182, 45)
        btnDel.TabIndex = 5
        btnDel.Text = "Delete"
        btnDel.UseVisualStyleBackColor = True
        ' 
        ' txtFullName
        ' 
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Location = New Point(239, 202)
        txtFullName.Margin = New Padding(3, 2, 3, 2)
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(251, 23)
        txtFullName.TabIndex = 9
        ' 
        ' btnBack1
        ' 
        btnBack1.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6123
        btnBack1.BackgroundImageLayout = ImageLayout.Stretch
        btnBack1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack1.Location = New Point(2, 304)
        btnBack1.Name = "btnBack1"
        btnBack1.Size = New Size(182, 45)
        btnBack1.TabIndex = 12
        btnBack1.Text = "Back"
        btnBack1.UseVisualStyleBackColor = True
        ' 
        ' picEmployee
        ' 
        picEmployee.BorderStyle = BorderStyle.FixedSingle
        picEmployee.Location = New Point(701, 116)
        picEmployee.Name = "picEmployee"
        picEmployee.Size = New Size(158, 143)
        picEmployee.TabIndex = 34
        picEmployee.TabStop = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(239, 141)
        Label17.Name = "Label17"
        Label17.Size = New Size(96, 17)
        Label17.TabIndex = 38
        Label17.Text = "Employee ID :"
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.BorderStyle = BorderStyle.FixedSingle
        txtEmployeeID.Location = New Point(239, 159)
        txtEmployeeID.Margin = New Padding(3, 2, 3, 2)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(394, 23)
        txtEmployeeID.TabIndex = 39
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(243, 279)
        Label18.Name = "Label18"
        Label18.Size = New Size(129, 17)
        Label18.TabIndex = 40
        Label18.Text = "Employment Type :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(239, 65)
        Label5.Name = "Label5"
        Label5.Size = New Size(246, 18)
        Label5.TabIndex = 42
        Label5.Text = "Search an Employee through ID :"
        ' 
        ' txtEmploType
        ' 
        txtEmploType.BorderStyle = BorderStyle.FixedSingle
        txtEmploType.Location = New Point(240, 303)
        txtEmploType.Margin = New Padding(3, 2, 3, 2)
        txtEmploType.Name = "txtEmploType"
        txtEmploType.ReadOnly = True
        txtEmploType.Size = New Size(432, 23)
        txtEmploType.TabIndex = 43
        ' 
        ' txtSal
        ' 
        txtSal.BorderStyle = BorderStyle.FixedSingle
        txtSal.Location = New Point(239, 350)
        txtSal.Margin = New Padding(3, 2, 3, 2)
        txtSal.Name = "txtSal"
        txtSal.ReadOnly = True
        txtSal.Size = New Size(434, 23)
        txtSal.TabIndex = 44
        ' 
        ' txtPos
        ' 
        txtPos.BorderStyle = BorderStyle.FixedSingle
        txtPos.Location = New Point(495, 202)
        txtPos.Margin = New Padding(3, 2, 3, 2)
        txtPos.Name = "txtPos"
        txtPos.ReadOnly = True
        txtPos.Size = New Size(178, 23)
        txtPos.TabIndex = 45
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), Image)
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.Location = New Point(639, 152)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(35, 32)
        btnSearch.TabIndex = 46
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(240, 230)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 17)
        Label6.TabIndex = 47
        Label6.Text = "Role : "
        ' 
        ' txtRole
        ' 
        txtRole.BorderStyle = BorderStyle.FixedSingle
        txtRole.Location = New Point(240, 249)
        txtRole.Margin = New Padding(3, 2, 3, 2)
        txtRole.Name = "txtRole"
        txtRole.ReadOnly = True
        txtRole.Size = New Size(432, 23)
        txtRole.TabIndex = 48
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._476844
        PictureBox1.Location = New Point(10, 137)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(28, 25)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 49
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(10, 193)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(28, 25)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 50
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(10, 253)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(28, 25)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 51
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(10, 314)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(28, 25)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 52
        PictureBox4.TabStop = False
        ' 
        ' txtExcel
        ' 
        txtExcel.BorderStyle = BorderStyle.FixedSingle
        txtExcel.Location = New Point(239, 111)
        txtExcel.Margin = New Padding(3, 2, 3, 2)
        txtExcel.Name = "txtExcel"
        txtExcel.ReadOnly = True
        txtExcel.Size = New Size(362, 23)
        txtExcel.TabIndex = 53
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(239, 90)
        Label4.Name = "Label4"
        Label4.Size = New Size(164, 17)
        Label4.TabIndex = 54
        Label4.Text = "Bulk Import Employees : "
        ' 
        ' btnU
        ' 
        btnU.BackgroundImage = My.Resources.Resources._10099883
        btnU.BackgroundImageLayout = ImageLayout.Stretch
        btnU.Location = New Point(646, 107)
        btnU.Name = "btnU"
        btnU.Size = New Size(35, 32)
        btnU.TabIndex = 55
        btnU.Text = "U"
        btnU.UseVisualStyleBackColor = True
        ' 
        ' btnB
        ' 
        btnB.BackgroundImage = My.Resources.Resources._5720952
        btnB.BackgroundImageLayout = ImageLayout.Stretch
        btnB.Location = New Point(609, 107)
        btnB.Name = "btnB"
        btnB.Size = New Size(35, 32)
        btnB.TabIndex = 56
        btnB.UseVisualStyleBackColor = True
        ' 
        ' btnAll
        ' 
        btnAll.BackgroundImage = CType(resources.GetObject("btnAll.BackgroundImage"), Image)
        btnAll.BackgroundImageLayout = ImageLayout.Stretch
        btnAll.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAll.ForeColor = SystemColors.ActiveCaptionText
        btnAll.Location = New Point(2, 65)
        btnAll.Margin = New Padding(3, 2, 3, 2)
        btnAll.Name = "btnAll"
        btnAll.Size = New Size(182, 45)
        btnAll.TabIndex = 57
        btnAll.Text = "ALL Employee"
        btnAll.TextAlign = ContentAlignment.MiddleRight
        btnAll.UseVisualStyleBackColor = True
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(10, 78)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(28, 25)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 58
        PictureBox5.TabStop = False
        ' 
        ' ManageAccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(940, 410)
        Controls.Add(PictureBox5)
        Controls.Add(btnAll)
        Controls.Add(btnB)
        Controls.Add(btnU)
        Controls.Add(Label4)
        Controls.Add(txtExcel)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(txtRole)
        Controls.Add(Label6)
        Controls.Add(btnSearch)
        Controls.Add(txtPos)
        Controls.Add(txtSal)
        Controls.Add(txtEmploType)
        Controls.Add(Label5)
        Controls.Add(Label18)
        Controls.Add(txtEmployeeID)
        Controls.Add(Label17)
        Controls.Add(picEmployee)
        Controls.Add(btnBack1)
        Controls.Add(txtFullName)
        Controls.Add(btnDel)
        Controls.Add(btnUpdateAccount)
        Controls.Add(btnAdd)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "ManageAccount"
        StartPosition = FormStartPosition.CenterScreen
        Text = "89="
        CType(picEmployee, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdateAccount As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents txtSal As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents btnBack1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents picEmployee As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtEmploType As TextBox
    Friend WithEvents txtPos As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtDoH As TextBox
    Friend WithEvents btnUpdateEmployee As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRole As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtExcel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnU As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnAll As Button
    Friend WithEvents PictureBox5 As PictureBox
End Class
