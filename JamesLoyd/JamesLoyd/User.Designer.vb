<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeePanel
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
        lblEmpID = New Label()
        btnTimeIn = New Button()
        btnViewAttendance = New Button()
        lblWelcome = New Label()
        btnBack5 = New Button()
        lblLastLogIn = New Label()
        btnViewPayslip = New Button()
        btnTimeOut = New Button()
        btnRefresh = New Button()
        lblTotalHours = New Label()
        lblLastPayslip = New Label()
        lblOvertimeHours = New Label()
        lblRole = New Label()
        txtOver = New TextBox()
        txtTotalH = New TextBox()
        txtLastLogin = New TextBox()
        txtPosition = New TextBox()
        txtEmployeeID = New TextBox()
        txtFullName = New TextBox()
        txtLastPayslipSalary = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnTimeIn1 = New Button()
        btnTimeOut1 = New Button()
        btnViewPayslipHistory = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' lblEmpID
        ' 
        lblEmpID.AutoSize = True
        lblEmpID.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmpID.Location = New Point(16, 138)
        lblEmpID.Name = "lblEmpID"
        lblEmpID.Size = New Size(113, 20)
        lblEmpID.TabIndex = 0
        lblEmpID.Text = "Employee ID : "
        ' 
        ' btnTimeIn
        ' 
        btnTimeIn.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6128
        btnTimeIn.BackgroundImageLayout = ImageLayout.Stretch
        btnTimeIn.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTimeIn.Location = New Point(96, 227)
        btnTimeIn.Margin = New Padding(3, 2, 3, 2)
        btnTimeIn.Name = "btnTimeIn"
        btnTimeIn.Size = New Size(109, 34)
        btnTimeIn.TabIndex = 3
        btnTimeIn.Text = "IN"
        btnTimeIn.UseVisualStyleBackColor = True
        ' 
        ' btnViewAttendance
        ' 
        btnViewAttendance.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnViewAttendance.BackgroundImageLayout = ImageLayout.Stretch
        btnViewAttendance.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewAttendance.Location = New Point(532, 229)
        btnViewAttendance.Margin = New Padding(3, 2, 3, 2)
        btnViewAttendance.Name = "btnViewAttendance"
        btnViewAttendance.Size = New Size(109, 32)
        btnViewAttendance.TabIndex = 4
        btnViewAttendance.Text = "Attendance"
        btnViewAttendance.UseVisualStyleBackColor = True
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New Point(37, 112)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(92, 20)
        lblWelcome.TabIndex = 5
        lblWelcome.Text = "Welcome : "
        ' 
        ' btnBack5
        ' 
        btnBack5.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnBack5.BackgroundImageLayout = ImageLayout.Stretch
        btnBack5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack5.Location = New Point(472, 413)
        btnBack5.Name = "btnBack5"
        btnBack5.Size = New Size(107, 32)
        btnBack5.TabIndex = 7
        btnBack5.Text = "Log_Out"
        btnBack5.UseVisualStyleBackColor = True
        ' 
        ' lblLastLogIn
        ' 
        lblLastLogIn.AutoSize = True
        lblLastLogIn.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLastLogIn.Location = New Point(363, 143)
        lblLastLogIn.Name = "lblLastLogIn"
        lblLastLogIn.Size = New Size(103, 20)
        lblLastLogIn.TabIndex = 9
        lblLastLogIn.Text = "Last Log-In  : "
        ' 
        ' btnViewPayslip
        ' 
        btnViewPayslip.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnViewPayslip.BackgroundImageLayout = ImageLayout.Stretch
        btnViewPayslip.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewPayslip.Location = New Point(410, 299)
        btnViewPayslip.Margin = New Padding(3, 2, 3, 2)
        btnViewPayslip.Name = "btnViewPayslip"
        btnViewPayslip.Size = New Size(109, 32)
        btnViewPayslip.TabIndex = 11
        btnViewPayslip.Text = "View PaySlip"
        btnViewPayslip.UseVisualStyleBackColor = True
        ' 
        ' btnTimeOut
        ' 
        btnTimeOut.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6129
        btnTimeOut.BackgroundImageLayout = ImageLayout.Stretch
        btnTimeOut.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTimeOut.Location = New Point(229, 227)
        btnTimeOut.Margin = New Padding(3, 2, 3, 2)
        btnTimeOut.Name = "btnTimeOut"
        btnTimeOut.Size = New Size(107, 34)
        btnTimeOut.TabIndex = 12
        btnTimeOut.Text = "OUT"
        btnTimeOut.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnRefresh.BackgroundImageLayout = ImageLayout.Stretch
        btnRefresh.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.Location = New Point(410, 228)
        btnRefresh.Margin = New Padding(3, 2, 3, 2)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(107, 32)
        btnRefresh.TabIndex = 13
        btnRefresh.Text = " Refresh Panel"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' lblTotalHours
        ' 
        lblTotalHours.AutoSize = True
        lblTotalHours.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalHours.ForeColor = SystemColors.ControlText
        lblTotalHours.Location = New Point(70, 386)
        lblTotalHours.Name = "lblTotalHours"
        lblTotalHours.Size = New Size(140, 17)
        lblTotalHours.TabIndex = 14
        lblTotalHours.Text = "Total Hours Worked :"
        ' 
        ' lblLastPayslip
        ' 
        lblLastPayslip.AutoSize = True
        lblLastPayslip.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLastPayslip.ForeColor = SystemColors.ControlText
        lblLastPayslip.Location = New Point(123, 440)
        lblLastPayslip.Name = "lblLastPayslip"
        lblLastPayslip.Size = New Size(89, 17)
        lblLastPayslip.TabIndex = 15
        lblLastPayslip.Text = "Last PaySlip :"
        ' 
        ' lblOvertimeHours
        ' 
        lblOvertimeHours.AutoSize = True
        lblOvertimeHours.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOvertimeHours.ForeColor = SystemColors.ControlText
        lblOvertimeHours.Location = New Point(100, 414)
        lblOvertimeHours.Name = "lblOvertimeHours"
        lblOvertimeHours.Size = New Size(111, 17)
        lblOvertimeHours.TabIndex = 16
        lblOvertimeHours.Text = "Total Overtime :"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRole.Location = New Point(390, 115)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(76, 20)
        lblRole.TabIndex = 17
        lblRole.Text = "Position : "
        ' 
        ' txtOver
        ' 
        txtOver.BorderStyle = BorderStyle.FixedSingle
        txtOver.Location = New Point(217, 413)
        txtOver.Margin = New Padding(3, 2, 3, 2)
        txtOver.Name = "txtOver"
        txtOver.ReadOnly = True
        txtOver.Size = New Size(184, 23)
        txtOver.TabIndex = 18
        ' 
        ' txtTotalH
        ' 
        txtTotalH.BorderStyle = BorderStyle.FixedSingle
        txtTotalH.Location = New Point(217, 383)
        txtTotalH.Margin = New Padding(3, 2, 3, 2)
        txtTotalH.Name = "txtTotalH"
        txtTotalH.ReadOnly = True
        txtTotalH.Size = New Size(184, 23)
        txtTotalH.TabIndex = 19
        ' 
        ' txtLastLogin
        ' 
        txtLastLogin.BorderStyle = BorderStyle.FixedSingle
        txtLastLogin.Location = New Point(472, 143)
        txtLastLogin.Margin = New Padding(3, 2, 3, 2)
        txtLastLogin.Name = "txtLastLogin"
        txtLastLogin.ReadOnly = True
        txtLastLogin.Size = New Size(206, 23)
        txtLastLogin.TabIndex = 20
        ' 
        ' txtPosition
        ' 
        txtPosition.BorderStyle = BorderStyle.FixedSingle
        txtPosition.Location = New Point(472, 112)
        txtPosition.Margin = New Padding(3, 2, 3, 2)
        txtPosition.Name = "txtPosition"
        txtPosition.ReadOnly = True
        txtPosition.Size = New Size(206, 23)
        txtPosition.TabIndex = 21
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.BorderStyle = BorderStyle.FixedSingle
        txtEmployeeID.Location = New Point(134, 140)
        txtEmployeeID.Margin = New Padding(3, 2, 3, 2)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.ReadOnly = True
        txtEmployeeID.Size = New Size(207, 23)
        txtEmployeeID.TabIndex = 22
        ' 
        ' txtFullName
        ' 
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Location = New Point(134, 112)
        txtFullName.Margin = New Padding(3, 2, 3, 2)
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(207, 23)
        txtFullName.TabIndex = 23
        ' 
        ' txtLastPayslipSalary
        ' 
        txtLastPayslipSalary.BorderStyle = BorderStyle.FixedSingle
        txtLastPayslipSalary.Location = New Point(217, 441)
        txtLastPayslipSalary.Margin = New Padding(3, 2, 3, 2)
        txtLastPayslipSalary.Name = "txtLastPayslipSalary"
        txtLastPayslipSalary.ReadOnly = True
        txtLastPayslipSalary.Size = New Size(184, 23)
        txtLastPayslipSalary.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(100, 206)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 25
        Label1.Text = "Morning  : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(98, 282)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 20)
        Label2.TabIndex = 26
        Label2.Text = "Afternoon  : "
        ' 
        ' btnTimeIn1
        ' 
        btnTimeIn1.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6128
        btnTimeIn1.BackgroundImageLayout = ImageLayout.Stretch
        btnTimeIn1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTimeIn1.Location = New Point(96, 302)
        btnTimeIn1.Margin = New Padding(3, 2, 3, 2)
        btnTimeIn1.Name = "btnTimeIn1"
        btnTimeIn1.Size = New Size(109, 34)
        btnTimeIn1.TabIndex = 27
        btnTimeIn1.Text = "IN"
        btnTimeIn1.UseVisualStyleBackColor = True
        ' 
        ' btnTimeOut1
        ' 
        btnTimeOut1.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6129
        btnTimeOut1.BackgroundImageLayout = ImageLayout.Stretch
        btnTimeOut1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTimeOut1.Location = New Point(229, 302)
        btnTimeOut1.Margin = New Padding(3, 2, 3, 2)
        btnTimeOut1.Name = "btnTimeOut1"
        btnTimeOut1.Size = New Size(107, 34)
        btnTimeOut1.TabIndex = 28
        btnTimeOut1.Text = "OUT"
        btnTimeOut1.UseVisualStyleBackColor = True
        ' 
        ' btnViewPayslipHistory
        ' 
        btnViewPayslipHistory.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnViewPayslipHistory.BackgroundImageLayout = ImageLayout.Stretch
        btnViewPayslipHistory.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewPayslipHistory.Location = New Point(532, 299)
        btnViewPayslipHistory.Margin = New Padding(3, 2, 3, 2)
        btnViewPayslipHistory.Name = "btnViewPayslipHistory"
        btnViewPayslipHistory.Size = New Size(132, 32)
        btnViewPayslipHistory.TabIndex = 29
        btnViewPayslipHistory.Text = " PaySlip History" & vbCrLf
        btnViewPayslipHistory.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(566, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 15)
        Label3.TabIndex = 30
        Label3.Text = "Submit a complain?"
        ' 
        ' EmployeePanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Youtube_Vlog_Traveling_Youtube_Tumbnail__15_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(713, 497)
        Controls.Add(Label3)
        Controls.Add(btnViewPayslipHistory)
        Controls.Add(btnTimeOut1)
        Controls.Add(btnTimeIn1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtLastPayslipSalary)
        Controls.Add(txtFullName)
        Controls.Add(txtEmployeeID)
        Controls.Add(txtPosition)
        Controls.Add(txtLastLogin)
        Controls.Add(txtTotalH)
        Controls.Add(txtOver)
        Controls.Add(lblRole)
        Controls.Add(lblOvertimeHours)
        Controls.Add(lblLastPayslip)
        Controls.Add(lblTotalHours)
        Controls.Add(btnRefresh)
        Controls.Add(btnTimeOut)
        Controls.Add(btnViewPayslip)
        Controls.Add(lblLastLogIn)
        Controls.Add(btnBack5)
        Controls.Add(lblWelcome)
        Controls.Add(btnViewAttendance)
        Controls.Add(btnTimeIn)
        Controls.Add(lblEmpID)
        DoubleBuffered = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "EmployeePanel"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EmployeePanel"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblEmpID As Label
    Friend WithEvents btnTimeIn As Button
    Friend WithEvents btnViewAttendance As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnBack5 As Button
    Friend WithEvents lblLastLogIn As Label
    Friend WithEvents btnViewPayslip As Button
    Friend WithEvents btnTimeOut As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblTotalHours As Label
    Friend WithEvents lblLastPayslip As Label
    Friend WithEvents lblOvertimeHours As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents txtOver As TextBox
    Friend WithEvents txtTotalH As TextBox
    Friend WithEvents txtLastLogin As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtLastPayslipSalary As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTimeIn1 As Button
    Friend WithEvents btnTimeOut1 As Button
    Friend WithEvents btnViewPayslipHistory As Button
    Friend WithEvents Label3 As Label
End Class
