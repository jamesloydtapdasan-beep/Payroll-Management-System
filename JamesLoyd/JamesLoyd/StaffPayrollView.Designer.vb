<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffPayrollView
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
        Label1 = New Label()
        Label2 = New Label()
        cmbEmployees = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        cmbMonth = New ComboBox()
        cmbYear = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        txtFullName1 = New TextBox()
        txtPosition1 = New TextBox()
        txtHours = New TextBox()
        txtDepartment1 = New TextBox()
        txtMonthlySalary = New TextBox()
        txtBasicPay = New TextBox()
        txtDays = New TextBox()
        txtOTPay = New TextBox()
        txtTotalAbsent = New TextBox()
        txtOvertime = New TextBox()
        txtPagIbig = New TextBox()
        txtPhilHealth = New TextBox()
        txtTotalDeductions = New TextBox()
        txtSSS = New TextBox()
        txtGrossPay = New TextBox()
        txtPayNet = New TextBox()
        dgvAttendance = New DataGridView()
        btnSearch2 = New Button()
        btnBack = New Button()
        Label21 = New Label()
        btnSendToAdmin = New Button()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label1.Location = New Point(347, 33)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 19)
        Label1.TabIndex = 0
        Label1.Text = """Payroll Dashboard"""
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(140, 83)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 17)
        Label2.TabIndex = 1
        Label2.Text = "Select Employee :"
        ' 
        ' cmbEmployees
        ' 
        cmbEmployees.FormattingEnabled = True
        cmbEmployees.Location = New Point(273, 79)
        cmbEmployees.Margin = New Padding(4, 3, 4, 3)
        cmbEmployees.Name = "cmbEmployees"
        cmbEmployees.Size = New Size(137, 24)
        cmbEmployees.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(196, 111)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 17)
        Label3.TabIndex = 4
        Label3.Text = "Month :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(28, 183)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 17)
        Label4.TabIndex = 5
        Label4.Text = "Fullname :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(28, 220)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 17)
        Label5.TabIndex = 6
        Label5.Text = "Position :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(443, 112)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 17)
        Label6.TabIndex = 7
        Label6.Text = "Year : "
        ' 
        ' cmbMonth
        ' 
        cmbMonth.FormattingEnabled = True
        cmbMonth.Location = New Point(273, 108)
        cmbMonth.Margin = New Padding(4, 3, 4, 3)
        cmbMonth.Name = "cmbMonth"
        cmbMonth.Size = New Size(137, 24)
        cmbMonth.TabIndex = 8
        ' 
        ' cmbYear
        ' 
        cmbYear.FormattingEnabled = True
        cmbYear.Location = New Point(492, 108)
        cmbYear.Margin = New Padding(4, 3, 4, 3)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(137, 24)
        cmbYear.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(8, 259)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 17)
        Label7.TabIndex = 10
        Label7.Text = "Department : "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(41, 293)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 17)
        Label8.TabIndex = 11
        Label8.Text = "Salary :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(8, 327)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 17)
        Label9.TabIndex = 12
        Label9.Text = "Total Hours :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(321, 329)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(62, 17)
        Label10.TabIndex = 17
        Label10.Text = "OT Pay: "
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(308, 296)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(80, 17)
        Label11.TabIndex = 16
        Label11.Text = "Basic Pay :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(284, 255)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(104, 17)
        Label12.TabIndex = 15
        Label12.Text = "Worked Days :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(264, 220)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(134, 17)
        Label13.TabIndex = 14
        Label13.Text = "Total Absent Days :"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(272, 183)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(124, 17)
        Label14.TabIndex = 13
        Label14.Text = "Overtime Hours : "
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(571, 329)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(132, 17)
        Label15.TabIndex = 22
        Label15.Text = "Total Deductions : "
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(619, 299)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(80, 17)
        Label16.TabIndex = 21
        Label16.Text = "Pag-IBIG : "
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(599, 261)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(90, 17)
        Label17.TabIndex = 20
        Label17.Text = "Phil-Health :"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(644, 223)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(41, 17)
        Label18.TabIndex = 19
        Label18.Text = "SSS : "
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(607, 188)
        Label19.Margin = New Padding(4, 0, 4, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(81, 17)
        Label19.TabIndex = 18
        Label19.Text = "Gross Pay: "
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(615, 376)
        Label20.Margin = New Padding(4, 0, 4, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(71, 17)
        Label20.TabIndex = 23
        Label20.Text = "Net Pay : "
        ' 
        ' txtFullName1
        ' 
        txtFullName1.Location = New Point(99, 179)
        txtFullName1.Margin = New Padding(4, 3, 4, 3)
        txtFullName1.Name = "txtFullName1"
        txtFullName1.Size = New Size(137, 24)
        txtFullName1.TabIndex = 24
        ' 
        ' txtPosition1
        ' 
        txtPosition1.Location = New Point(99, 220)
        txtPosition1.Margin = New Padding(4, 3, 4, 3)
        txtPosition1.Name = "txtPosition1"
        txtPosition1.Size = New Size(137, 24)
        txtPosition1.TabIndex = 25
        ' 
        ' txtHours
        ' 
        txtHours.Location = New Point(99, 323)
        txtHours.Margin = New Padding(4, 3, 4, 3)
        txtHours.Name = "txtHours"
        txtHours.Size = New Size(137, 24)
        txtHours.TabIndex = 26
        ' 
        ' txtDepartment1
        ' 
        txtDepartment1.Location = New Point(99, 255)
        txtDepartment1.Margin = New Padding(4, 3, 4, 3)
        txtDepartment1.Name = "txtDepartment1"
        txtDepartment1.Size = New Size(137, 24)
        txtDepartment1.TabIndex = 26
        ' 
        ' txtMonthlySalary
        ' 
        txtMonthlySalary.Location = New Point(97, 291)
        txtMonthlySalary.Margin = New Padding(4, 3, 4, 3)
        txtMonthlySalary.Name = "txtMonthlySalary"
        txtMonthlySalary.Size = New Size(137, 24)
        txtMonthlySalary.TabIndex = 27
        ' 
        ' txtBasicPay
        ' 
        txtBasicPay.Location = New Point(400, 293)
        txtBasicPay.Margin = New Padding(4, 3, 4, 3)
        txtBasicPay.Name = "txtBasicPay"
        txtBasicPay.Size = New Size(137, 24)
        txtBasicPay.TabIndex = 32
        ' 
        ' txtDays
        ' 
        txtDays.Location = New Point(401, 259)
        txtDays.Margin = New Padding(4, 3, 4, 3)
        txtDays.Name = "txtDays"
        txtDays.Size = New Size(137, 24)
        txtDays.TabIndex = 30
        ' 
        ' txtOTPay
        ' 
        txtOTPay.Location = New Point(401, 327)
        txtOTPay.Margin = New Padding(4, 3, 4, 3)
        txtOTPay.Name = "txtOTPay"
        txtOTPay.Size = New Size(137, 24)
        txtOTPay.TabIndex = 31
        ' 
        ' txtTotalAbsent
        ' 
        txtTotalAbsent.Location = New Point(401, 223)
        txtTotalAbsent.Margin = New Padding(4, 3, 4, 3)
        txtTotalAbsent.Name = "txtTotalAbsent"
        txtTotalAbsent.Size = New Size(137, 24)
        txtTotalAbsent.TabIndex = 29
        ' 
        ' txtOvertime
        ' 
        txtOvertime.Location = New Point(401, 183)
        txtOvertime.Margin = New Padding(4, 3, 4, 3)
        txtOvertime.Name = "txtOvertime"
        txtOvertime.Size = New Size(137, 24)
        txtOvertime.TabIndex = 28
        ' 
        ' txtPagIbig
        ' 
        txtPagIbig.Location = New Point(696, 293)
        txtPagIbig.Margin = New Padding(4, 3, 4, 3)
        txtPagIbig.Name = "txtPagIbig"
        txtPagIbig.Size = New Size(137, 24)
        txtPagIbig.TabIndex = 37
        ' 
        ' txtPhilHealth
        ' 
        txtPhilHealth.Location = New Point(697, 259)
        txtPhilHealth.Margin = New Padding(4, 3, 4, 3)
        txtPhilHealth.Name = "txtPhilHealth"
        txtPhilHealth.Size = New Size(137, 24)
        txtPhilHealth.TabIndex = 35
        ' 
        ' txtTotalDeductions
        ' 
        txtTotalDeductions.Location = New Point(697, 327)
        txtTotalDeductions.Margin = New Padding(4, 3, 4, 3)
        txtTotalDeductions.Name = "txtTotalDeductions"
        txtTotalDeductions.Size = New Size(137, 24)
        txtTotalDeductions.TabIndex = 36
        ' 
        ' txtSSS
        ' 
        txtSSS.Location = New Point(697, 223)
        txtSSS.Margin = New Padding(4, 3, 4, 3)
        txtSSS.Name = "txtSSS"
        txtSSS.Size = New Size(137, 24)
        txtSSS.TabIndex = 34
        ' 
        ' txtGrossPay
        ' 
        txtGrossPay.Location = New Point(697, 183)
        txtGrossPay.Margin = New Padding(4, 3, 4, 3)
        txtGrossPay.Name = "txtGrossPay"
        txtGrossPay.Size = New Size(137, 24)
        txtGrossPay.TabIndex = 33
        ' 
        ' txtPayNet
        ' 
        txtPayNet.Location = New Point(697, 368)
        txtPayNet.Margin = New Padding(4, 3, 4, 3)
        txtPayNet.Name = "txtPayNet"
        txtPayNet.Size = New Size(137, 24)
        txtPayNet.TabIndex = 38
        ' 
        ' dgvAttendance
        ' 
        dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendance.Location = New Point(76, 420)
        dgvAttendance.Margin = New Padding(4, 3, 4, 3)
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.Size = New Size(672, 131)
        dgvAttendance.TabIndex = 39
        ' 
        ' btnSearch2
        ' 
        btnSearch2.Location = New Point(180, 581)
        btnSearch2.Margin = New Padding(4, 3, 4, 3)
        btnSearch2.Name = "btnSearch2"
        btnSearch2.Size = New Size(140, 24)
        btnSearch2.TabIndex = 40
        btnSearch2.Text = "Prepare Payroll "
        btnSearch2.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        btnBack.Location = New Point(531, 581)
        btnBack.Margin = New Padding(4, 3, 4, 3)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(85, 24)
        btnBack.TabIndex = 42
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(76, 397)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(177, 17)
        Label21.TabIndex = 43
        Label21.Text = "This month attendance  : "
        ' 
        ' btnSendToAdmin
        ' 
        btnSendToAdmin.Location = New Point(347, 581)
        btnSendToAdmin.Margin = New Padding(4, 3, 4, 3)
        btnSendToAdmin.Name = "btnSendToAdmin"
        btnSendToAdmin.Size = New Size(140, 24)
        btnSendToAdmin.TabIndex = 44
        btnSendToAdmin.Text = "Send to Admin"
        btnSendToAdmin.UseVisualStyleBackColor = True
        ' 
        ' StaffPayrollView
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6127
        ClientSize = New Size(859, 631)
        Controls.Add(btnSendToAdmin)
        Controls.Add(Label21)
        Controls.Add(btnBack)
        Controls.Add(btnSearch2)
        Controls.Add(dgvAttendance)
        Controls.Add(txtPayNet)
        Controls.Add(txtPagIbig)
        Controls.Add(txtPhilHealth)
        Controls.Add(txtTotalDeductions)
        Controls.Add(txtSSS)
        Controls.Add(txtGrossPay)
        Controls.Add(txtBasicPay)
        Controls.Add(txtDays)
        Controls.Add(txtOTPay)
        Controls.Add(txtTotalAbsent)
        Controls.Add(txtOvertime)
        Controls.Add(txtMonthlySalary)
        Controls.Add(txtDepartment1)
        Controls.Add(txtHours)
        Controls.Add(txtPosition1)
        Controls.Add(txtFullName1)
        Controls.Add(Label20)
        Controls.Add(Label15)
        Controls.Add(Label16)
        Controls.Add(Label17)
        Controls.Add(Label18)
        Controls.Add(Label19)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(cmbYear)
        Controls.Add(cmbMonth)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(cmbEmployees)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        Margin = New Padding(4, 3, 4, 3)
        Name = "StaffPayrollView"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "StaffPayrollView"
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbEmployees As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtFullName1 As TextBox
    Friend WithEvents txtPosition1 As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtDepartment1 As TextBox
    Friend WithEvents txtMonthlySalary As TextBox
    Friend WithEvents txtBasicPay As TextBox
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtOTPay As TextBox
    Friend WithEvents txtTotalAbsent As TextBox
    Friend WithEvents txtOvertime As TextBox
    Friend WithEvents txtPagIbig As TextBox
    Friend WithEvents txtPhilHealth As TextBox
    Friend WithEvents txtTotalDeductions As TextBox
    Friend WithEvents txtSSS As TextBox
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents txtPayNet As TextBox
    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents btnSearch2 As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents btnSendToAdmin As Button


End Class
