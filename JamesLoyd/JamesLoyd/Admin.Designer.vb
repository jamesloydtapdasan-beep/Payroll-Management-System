<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        btnManageAccounts = New Button()
        btnPayroll = New Button()
        btnAttendance = New Button()
        btnPayslip = New Button()
        btnLogout = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        btnComplaint = New Button()
        PictureBox6 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnManageAccounts
        ' 
        btnManageAccounts.AccessibleDescription = ""
        btnManageAccounts.BackgroundImage = CType(resources.GetObject("btnManageAccounts.BackgroundImage"), Image)
        btnManageAccounts.BackgroundImageLayout = ImageLayout.Stretch
        btnManageAccounts.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageAccounts.Location = New Point(85, 139)
        btnManageAccounts.Margin = New Padding(3, 2, 3, 2)
        btnManageAccounts.Name = "btnManageAccounts"
        btnManageAccounts.Size = New Size(222, 65)
        btnManageAccounts.TabIndex = 1
        btnManageAccounts.Text = "Manage Employees"
        btnManageAccounts.TextAlign = ContentAlignment.MiddleRight
        btnManageAccounts.UseVisualStyleBackColor = True
        ' 
        ' btnPayroll
        ' 
        btnPayroll.BackgroundImage = CType(resources.GetObject("btnPayroll.BackgroundImage"), Image)
        btnPayroll.BackgroundImageLayout = ImageLayout.Stretch
        btnPayroll.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPayroll.Location = New Point(85, 214)
        btnPayroll.Margin = New Padding(3, 2, 3, 2)
        btnPayroll.Name = "btnPayroll"
        btnPayroll.Size = New Size(222, 62)
        btnPayroll.TabIndex = 2
        btnPayroll.Text = "PayRoll"
        btnPayroll.UseVisualStyleBackColor = True
        ' 
        ' btnAttendance
        ' 
        btnAttendance.BackgroundImage = CType(resources.GetObject("btnAttendance.BackgroundImage"), Image)
        btnAttendance.BackgroundImageLayout = ImageLayout.Stretch
        btnAttendance.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAttendance.ForeColor = SystemColors.ControlText
        btnAttendance.ImageAlign = ContentAlignment.MiddleRight
        btnAttendance.Location = New Point(379, 139)
        btnAttendance.Margin = New Padding(3, 2, 3, 2)
        btnAttendance.Name = "btnAttendance"
        btnAttendance.Size = New Size(220, 65)
        btnAttendance.TabIndex = 4
        btnAttendance.Text = "View Attendance"
        btnAttendance.TextAlign = ContentAlignment.MiddleRight
        btnAttendance.UseVisualStyleBackColor = False
        ' 
        ' btnPayslip
        ' 
        btnPayslip.BackgroundImage = CType(resources.GetObject("btnPayslip.BackgroundImage"), Image)
        btnPayslip.BackgroundImageLayout = ImageLayout.Stretch
        btnPayslip.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPayslip.Location = New Point(379, 214)
        btnPayslip.Margin = New Padding(3, 2, 3, 2)
        btnPayslip.Name = "btnPayslip"
        btnPayslip.Size = New Size(220, 62)
        btnPayslip.TabIndex = 5
        btnPayslip.Text = "PaySlip"
        btnPayslip.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x612
        btnLogout.BackgroundImageLayout = ImageLayout.Stretch
        btnLogout.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(85, 288)
        btnLogout.Margin = New Padding(3, 2, 3, 2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(222, 58)
        btnLogout.TabIndex = 7
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.images_removebg_preview2
        PictureBox1.Location = New Point(105, 146)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(395, 146)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(35, 48)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(105, 220)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(35, 48)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(395, 220)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(35, 48)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(105, 298)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(35, 48)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 12
        PictureBox5.TabStop = False
        ' 
        ' btnComplaint
        ' 
        btnComplaint.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x612
        btnComplaint.BackgroundImageLayout = ImageLayout.Stretch
        btnComplaint.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnComplaint.Location = New Point(379, 287)
        btnComplaint.Margin = New Padding(3, 2, 3, 2)
        btnComplaint.Name = "btnComplaint"
        btnComplaint.Size = New Size(220, 58)
        btnComplaint.TabIndex = 13
        btnComplaint.Text = "Complaint"
        btnComplaint.UseVisualStyleBackColor = True
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.images_removebg_preview2
        PictureBox6.Location = New Point(395, 292)
        PictureBox6.Margin = New Padding(3, 2, 3, 2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(35, 48)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 14
        PictureBox6.TabStop = False
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(705, 430)
        Controls.Add(PictureBox6)
        Controls.Add(btnComplaint)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(btnLogout)
        Controls.Add(btnPayslip)
        Controls.Add(btnAttendance)
        Controls.Add(btnPayroll)
        Controls.Add(btnManageAccounts)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnPayroll As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAttendance As Button
    Friend WithEvents btnPayslip As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnManageAccounts As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnComplaint As Button
    Friend WithEvents PictureBox6 As PictureBox
End Class
