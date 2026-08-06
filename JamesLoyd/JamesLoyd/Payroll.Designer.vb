<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayroll))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        btnSavePayroll = New Button()
        btnBack = New Button()
        txtEmploID1 = New TextBox()
        txtFullName1 = New TextBox()
        Label9 = New Label()
        txtDepartment1 = New TextBox()
        txtPosition1 = New TextBox()
        Label10 = New Label()
        btnSearch2 = New Button()
        txtDays = New TextBox()
        Label12 = New Label()
        txtHours = New TextBox()
        Label13 = New Label()
        txtOvertime = New TextBox()
        Label14 = New Label()
        txtBasicPay = New TextBox()
        txtOTPay = New TextBox()
        txtGrossPay = New TextBox()
        Label15 = New Label()
        labelsss = New Label()
        Label17 = New Label()
        labelducu = New Label()
        labelpag = New Label()
        txtSSS = New TextBox()
        txtPhilHealth = New TextBox()
        txtPagIbig = New TextBox()
        txtTotalAbsent = New TextBox()
        txtTotalDeductions = New TextBox()
        Label16 = New Label()
        Label18 = New Label()
        txtPayNet = New TextBox()
        Label19 = New Label()
        txtMonthlySalary = New TextBox()
        Label20 = New Label()
        cmbMonth = New ComboBox()
        cmbYear = New ComboBox()
        Label11 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        btnApprove = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(38, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 17)
        Label1.TabIndex = 0
        Label1.Text = "Select Employee :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(70, 368)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 17)
        Label2.TabIndex = 1
        Label2.Text = "Gross Pay :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(59, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 17)
        Label3.TabIndex = 2
        Label3.Text = "Department :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(417, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(217, 23)
        Label4.TabIndex = 3
        Label4.Text = "TIME WORKED SECTION"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(51, 342)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 17)
        Label5.TabIndex = 4
        Label5.Text = "Overtime Pay :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(74, 317)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 17)
        Label6.TabIndex = 5
        Label6.Text = "Basic Pay :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(70, 289)
        Label7.Name = "Label7"
        Label7.Size = New Size(187, 23)
        Label7.TabIndex = 6
        Label7.Text = "EARNINGS SECTION"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(59, 95)
        Label8.Name = "Label8"
        Label8.Size = New Size(236, 23)
        Label8.TabIndex = 7
        Label8.Text = "EMPLOYEE INFO SECTION"
        ' 
        ' btnSavePayroll
        ' 
        btnSavePayroll.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnSavePayroll.BackgroundImageLayout = ImageLayout.Stretch
        btnSavePayroll.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSavePayroll.Location = New Point(730, 172)
        btnSavePayroll.Margin = New Padding(3, 2, 3, 2)
        btnSavePayroll.Name = "btnSavePayroll"
        btnSavePayroll.Size = New Size(177, 40)
        btnSavePayroll.TabIndex = 8
        btnSavePayroll.Text = "Save Payroll "
        btnSavePayroll.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnBack.BackgroundImageLayout = ImageLayout.Stretch
        btnBack.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(730, 217)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(177, 42)
        btnBack.TabIndex = 13
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' txtEmploID1
        ' 
        txtEmploID1.BorderStyle = BorderStyle.FixedSingle
        txtEmploID1.Location = New Point(160, 122)
        txtEmploID1.Margin = New Padding(3, 2, 3, 2)
        txtEmploID1.Name = "txtEmploID1"
        txtEmploID1.Size = New Size(127, 23)
        txtEmploID1.TabIndex = 14
        ' 
        ' txtFullName1
        ' 
        txtFullName1.BorderStyle = BorderStyle.FixedSingle
        txtFullName1.Location = New Point(160, 147)
        txtFullName1.Margin = New Padding(3, 2, 3, 2)
        txtFullName1.Name = "txtFullName1"
        txtFullName1.ReadOnly = True
        txtFullName1.Size = New Size(159, 23)
        txtFullName1.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(66, 150)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 17)
        Label9.TabIndex = 16
        Label9.Text = "Full Name :" & vbCrLf
        ' 
        ' txtDepartment1
        ' 
        txtDepartment1.BorderStyle = BorderStyle.FixedSingle
        txtDepartment1.Location = New Point(160, 172)
        txtDepartment1.Margin = New Padding(3, 2, 3, 2)
        txtDepartment1.Name = "txtDepartment1"
        txtDepartment1.ReadOnly = True
        txtDepartment1.Size = New Size(159, 23)
        txtDepartment1.TabIndex = 17
        ' 
        ' txtPosition1
        ' 
        txtPosition1.BorderStyle = BorderStyle.FixedSingle
        txtPosition1.Location = New Point(160, 198)
        txtPosition1.Margin = New Padding(3, 2, 3, 2)
        txtPosition1.Name = "txtPosition1"
        txtPosition1.ReadOnly = True
        txtPosition1.Size = New Size(159, 23)
        txtPosition1.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(81, 199)
        Label10.Name = "Label10"
        Label10.Size = New Size(66, 17)
        Label10.TabIndex = 19
        Label10.Text = "Position :"
        ' 
        ' btnSearch2
        ' 
        btnSearch2.BackgroundImage = CType(resources.GetObject("btnSearch2.BackgroundImage"), Image)
        btnSearch2.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch2.Location = New Point(292, 119)
        btnSearch2.Margin = New Padding(3, 2, 3, 2)
        btnSearch2.Name = "btnSearch2"
        btnSearch2.Size = New Size(26, 24)
        btnSearch2.TabIndex = 22
        btnSearch2.UseVisualStyleBackColor = True
        ' 
        ' txtDays
        ' 
        txtDays.BorderStyle = BorderStyle.FixedSingle
        txtDays.Location = New Point(504, 138)
        txtDays.Margin = New Padding(3, 2, 3, 2)
        txtDays.Name = "txtDays"
        txtDays.ReadOnly = True
        txtDays.Size = New Size(160, 23)
        txtDays.TabIndex = 23
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(360, 142)
        Label12.Name = "Label12"
        Label12.Size = New Size(139, 17)
        Label12.TabIndex = 24
        Label12.Text = " Total Days Worked :"
        ' 
        ' txtHours
        ' 
        txtHours.BorderStyle = BorderStyle.FixedSingle
        txtHours.Location = New Point(504, 163)
        txtHours.Margin = New Padding(3, 2, 3, 2)
        txtHours.Name = "txtHours"
        txtHours.ReadOnly = True
        txtHours.Size = New Size(160, 23)
        txtHours.TabIndex = 25
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(358, 164)
        Label13.Name = "Label13"
        Label13.Size = New Size(140, 17)
        Label13.TabIndex = 26
        Label13.Text = "Total Hours Worked :"
        ' 
        ' txtOvertime
        ' 
        txtOvertime.BorderStyle = BorderStyle.FixedSingle
        txtOvertime.Location = New Point(504, 189)
        txtOvertime.Margin = New Padding(3, 2, 3, 2)
        txtOvertime.Name = "txtOvertime"
        txtOvertime.ReadOnly = True
        txtOvertime.Size = New Size(160, 23)
        txtOvertime.TabIndex = 27
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(381, 190)
        Label14.Name = "Label14"
        Label14.Size = New Size(111, 17)
        Label14.TabIndex = 28
        Label14.Text = "Total Overtime :"
        ' 
        ' txtBasicPay
        ' 
        txtBasicPay.BorderStyle = BorderStyle.FixedSingle
        txtBasicPay.Location = New Point(160, 317)
        txtBasicPay.Margin = New Padding(3, 2, 3, 2)
        txtBasicPay.Name = "txtBasicPay"
        txtBasicPay.ReadOnly = True
        txtBasicPay.Size = New Size(159, 23)
        txtBasicPay.TabIndex = 29
        ' 
        ' txtOTPay
        ' 
        txtOTPay.BorderStyle = BorderStyle.FixedSingle
        txtOTPay.Location = New Point(160, 343)
        txtOTPay.Margin = New Padding(3, 2, 3, 2)
        txtOTPay.Name = "txtOTPay"
        txtOTPay.ReadOnly = True
        txtOTPay.Size = New Size(159, 23)
        txtOTPay.TabIndex = 30
        ' 
        ' txtGrossPay
        ' 
        txtGrossPay.BorderStyle = BorderStyle.FixedSingle
        txtGrossPay.Location = New Point(160, 368)
        txtGrossPay.Margin = New Padding(3, 2, 3, 2)
        txtGrossPay.Name = "txtGrossPay"
        txtGrossPay.ReadOnly = True
        txtGrossPay.Size = New Size(159, 23)
        txtGrossPay.TabIndex = 31
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(410, 294)
        Label15.Name = "Label15"
        Label15.Size = New Size(80, 17)
        Label15.TabIndex = 32
        Label15.Text = "PhilHealth :"
        ' 
        ' labelsss
        ' 
        labelsss.AutoSize = True
        labelsss.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelsss.Location = New Point(449, 269)
        labelsss.Name = "labelsss"
        labelsss.Size = New Size(34, 17)
        labelsss.TabIndex = 33
        labelsss.Text = "SSS :"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(401, 346)
        Label17.Name = "Label17"
        Label17.Size = New Size(95, 17)
        Label17.TabIndex = 34
        Label17.Text = "Total Absent :"
        ' 
        ' labelducu
        ' 
        labelducu.AutoSize = True
        labelducu.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelducu.Location = New Point(374, 374)
        labelducu.Name = "labelducu"
        labelducu.Size = New Size(128, 17)
        labelducu.TabIndex = 35
        labelducu.Text = "Total Deductions  :"
        ' 
        ' labelpag
        ' 
        labelpag.AutoSize = True
        labelpag.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelpag.Location = New Point(418, 321)
        labelpag.Name = "labelpag"
        labelpag.Size = New Size(70, 17)
        labelpag.TabIndex = 36
        labelpag.Text = "Pag-Ibig :"
        ' 
        ' txtSSS
        ' 
        txtSSS.BorderStyle = BorderStyle.FixedSingle
        txtSSS.Location = New Point(496, 266)
        txtSSS.Margin = New Padding(3, 2, 3, 2)
        txtSSS.Name = "txtSSS"
        txtSSS.ReadOnly = True
        txtSSS.Size = New Size(160, 23)
        txtSSS.TabIndex = 37
        ' 
        ' txtPhilHealth
        ' 
        txtPhilHealth.BorderStyle = BorderStyle.FixedSingle
        txtPhilHealth.Location = New Point(496, 290)
        txtPhilHealth.Margin = New Padding(3, 2, 3, 2)
        txtPhilHealth.Name = "txtPhilHealth"
        txtPhilHealth.ReadOnly = True
        txtPhilHealth.Size = New Size(160, 23)
        txtPhilHealth.TabIndex = 38
        ' 
        ' txtPagIbig
        ' 
        txtPagIbig.BorderStyle = BorderStyle.FixedSingle
        txtPagIbig.Location = New Point(496, 318)
        txtPagIbig.Margin = New Padding(3, 2, 3, 2)
        txtPagIbig.Name = "txtPagIbig"
        txtPagIbig.ReadOnly = True
        txtPagIbig.Size = New Size(160, 23)
        txtPagIbig.TabIndex = 39
        ' 
        ' txtTotalAbsent
        ' 
        txtTotalAbsent.BorderStyle = BorderStyle.FixedSingle
        txtTotalAbsent.Location = New Point(496, 343)
        txtTotalAbsent.Margin = New Padding(3, 2, 3, 2)
        txtTotalAbsent.Name = "txtTotalAbsent"
        txtTotalAbsent.ReadOnly = True
        txtTotalAbsent.Size = New Size(160, 23)
        txtTotalAbsent.TabIndex = 40
        ' 
        ' txtTotalDeductions
        ' 
        txtTotalDeductions.BorderStyle = BorderStyle.FixedSingle
        txtTotalDeductions.Location = New Point(496, 372)
        txtTotalDeductions.Margin = New Padding(3, 2, 3, 2)
        txtTotalDeductions.Name = "txtTotalDeductions"
        txtTotalDeductions.ReadOnly = True
        txtTotalDeductions.Size = New Size(160, 23)
        txtTotalDeductions.TabIndex = 41
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(407, 239)
        Label16.Name = "Label16"
        Label16.Size = New Size(210, 23)
        Label16.TabIndex = 42
        Label16.Text = "DEDUCTIONS SECTION"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(686, 145)
        Label18.Name = "Label18"
        Label18.Size = New Size(66, 17)
        Label18.TabIndex = 43
        Label18.Text = "Net Pay :"
        ' 
        ' txtPayNet
        ' 
        txtPayNet.BorderStyle = BorderStyle.FixedSingle
        txtPayNet.Location = New Point(750, 141)
        txtPayNet.Margin = New Padding(3, 2, 3, 2)
        txtPayNet.Name = "txtPayNet"
        txtPayNet.ReadOnly = True
        txtPayNet.Size = New Size(149, 23)
        txtPayNet.TabIndex = 44
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(739, 116)
        Label19.Name = "Label19"
        Label19.Size = New Size(102, 23)
        Label19.TabIndex = 45
        Label19.Text = "FINAL PAY"
        ' 
        ' txtMonthlySalary
        ' 
        txtMonthlySalary.BorderStyle = BorderStyle.FixedSingle
        txtMonthlySalary.Location = New Point(160, 223)
        txtMonthlySalary.Margin = New Padding(3, 2, 3, 2)
        txtMonthlySalary.Name = "txtMonthlySalary"
        txtMonthlySalary.ReadOnly = True
        txtMonthlySalary.Size = New Size(159, 23)
        txtMonthlySalary.TabIndex = 46
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(92, 225)
        Label20.Name = "Label20"
        Label20.Size = New Size(53, 17)
        Label20.TabIndex = 47
        Label20.Text = "Salary :"
        ' 
        ' cmbMonth
        ' 
        cmbMonth.FormattingEnabled = True
        cmbMonth.Items.AddRange(New Object() {"1st - 15th", "16th - End of Month"})
        cmbMonth.Location = New Point(733, 366)
        cmbMonth.Margin = New Padding(3, 2, 3, 2)
        cmbMonth.Name = "cmbMonth"
        cmbMonth.Size = New Size(174, 23)
        cmbMonth.TabIndex = 54
        ' 
        ' cmbYear
        ' 
        cmbYear.FormattingEnabled = True
        cmbYear.Items.AddRange(New Object() {"1st - 15th", "16th - End of Month"})
        cmbYear.Location = New Point(733, 396)
        cmbYear.Margin = New Padding(3, 2, 3, 2)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(174, 23)
        cmbYear.TabIndex = 56
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(716, 340)
        Label11.Name = "Label11"
        Label11.Size = New Size(138, 23)
        Label11.TabIndex = 57
        Label11.Text = "DATE SECTION"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(675, 371)
        Label21.Name = "Label21"
        Label21.Size = New Size(57, 17)
        Label21.TabIndex = 58
        Label21.Text = "Month :"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(683, 399)
        Label22.Name = "Label22"
        Label22.Size = New Size(48, 17)
        Label22.TabIndex = 59
        Label22.Text = "Year  :"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(739, 177)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(31, 28)
        Button1.TabIndex = 60
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(739, 225)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(31, 28)
        Button2.TabIndex = 61
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnApprove
        ' 
        btnApprove.BackgroundImage = My.Resources.Resources.istockphoto_1281736074_612x6125
        btnApprove.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnApprove.Location = New Point(730, 269)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(177, 42)
        btnApprove.TabIndex = 62
        btnApprove.Text = "Approve"
        btnApprove.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Location = New Point(739, 276)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(31, 28)
        Button3.TabIndex = 63
        Button3.UseVisualStyleBackColor = True
        ' 
        ' frmPayroll
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(954, 456)
        Controls.Add(Button3)
        Controls.Add(btnApprove)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label11)
        Controls.Add(cmbYear)
        Controls.Add(cmbMonth)
        Controls.Add(Label20)
        Controls.Add(txtMonthlySalary)
        Controls.Add(Label19)
        Controls.Add(txtPayNet)
        Controls.Add(Label18)
        Controls.Add(Label16)
        Controls.Add(txtTotalDeductions)
        Controls.Add(txtTotalAbsent)
        Controls.Add(txtPagIbig)
        Controls.Add(txtPhilHealth)
        Controls.Add(txtSSS)
        Controls.Add(labelpag)
        Controls.Add(labelducu)
        Controls.Add(Label17)
        Controls.Add(labelsss)
        Controls.Add(Label15)
        Controls.Add(txtGrossPay)
        Controls.Add(txtOTPay)
        Controls.Add(txtBasicPay)
        Controls.Add(Label14)
        Controls.Add(txtOvertime)
        Controls.Add(Label13)
        Controls.Add(txtHours)
        Controls.Add(Label12)
        Controls.Add(txtDays)
        Controls.Add(btnSearch2)
        Controls.Add(Label10)
        Controls.Add(txtPosition1)
        Controls.Add(txtDepartment1)
        Controls.Add(Label9)
        Controls.Add(txtFullName1)
        Controls.Add(txtEmploID1)
        Controls.Add(btnBack)
        Controls.Add(btnSavePayroll)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmPayroll"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payroll"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSavePayroll As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtEmploID1 As TextBox
    Friend WithEvents txtFullName1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDepartment1 As TextBox
    Friend WithEvents txtPosition1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSearch2 As Button
    Friend WithEvents txtDays As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtOvertime As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBasicPay As TextBox
    Friend WithEvents txtOTPay As TextBox
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents labelsss As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents labelducu As Label
    Friend WithEvents labelpag As Label
    Friend WithEvents txtSSS As TextBox
    Friend WithEvents txtPhilHealth As TextBox
    Friend WithEvents txtPagIbig As TextBox
    Friend WithEvents txtTotalAbsent As TextBox
    Friend WithEvents txtTotalDeductions As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPayNet As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtMonthlySalary As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents Button3 As Button
End Class
