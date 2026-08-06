<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpPayslip
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
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        btnGenerate = New Button()
        btnDL = New Button()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        btnBack3 = New Button()
        Label11 = New Label()
        txtPeriodEnd = New TextBox()
        txtBasicPay = New TextBox()
        txtOTPay = New TextBox()
        txtAbsences = New TextBox()
        txtSSS = New TextBox()
        txtPagIbig = New TextBox()
        Label5 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        txtPhilHealth = New TextBox()
        txtGrossPay = New TextBox()
        txtNetPay = New TextBox()
        txtDateGenerated = New TextBox()
        dtgv = New DataGridView()
        txtPayrollID = New TextBox()
        txtFullName = New TextBox()
        Label7 = New Label()
        txtPeriodS = New TextBox()
        CType(dtgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(65, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 17)
        Label1.TabIndex = 0
        Label1.Text = "Employee ID :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(70, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 17)
        Label2.TabIndex = 1
        Label2.Text = "Period Start :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(62, 241)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 17)
        Label3.TabIndex = 2
        Label3.Text = "Total Absent :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(83, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 17)
        Label4.TabIndex = 3
        Label4.Text = "Basic Pay :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(442, 115)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 17)
        Label6.TabIndex = 5
        Label6.Text = "Net Pay :"
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6125
        btnGenerate.BackgroundImageLayout = ImageLayout.Stretch
        btnGenerate.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGenerate.Location = New Point(496, 307)
        btnGenerate.Margin = New Padding(3, 2, 3, 2)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(135, 32)
        btnGenerate.TabIndex = 7
        btnGenerate.Text = " Generate PayRoll"
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' btnDL
        ' 
        btnDL.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6126
        btnDL.BackgroundImageLayout = ImageLayout.Stretch
        btnDL.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDL.Location = New Point(636, 307)
        btnDL.Margin = New Padding(3, 2, 3, 2)
        btnDL.Name = "btnDL"
        btnDL.Size = New Size(151, 32)
        btnDL.TabIndex = 9
        btnDL.Text = "DownLoad PaySlip"
        btnDL.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(431, 89)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 17)
        Label8.TabIndex = 12
        Label8.Text = "Gross Pay :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(47, 213)
        Label9.Name = "Label9"
        Label9.Size = New Size(111, 17)
        Label9.TabIndex = 13
        Label9.Text = "Total Overtime :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(387, 145)
        Label10.Name = "Label10"
        Label10.Size = New Size(122, 17)
        Label10.TabIndex = 14
        Label10.Text = "Date Generated :"
        ' 
        ' btnBack3
        ' 
        btnBack3.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6124
        btnBack3.BackgroundImageLayout = ImageLayout.Stretch
        btnBack3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack3.Location = New Point(393, 306)
        btnBack3.Name = "btnBack3"
        btnBack3.Size = New Size(93, 32)
        btnBack3.TabIndex = 17
        btnBack3.Text = "Back"
        btnBack3.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(73, 162)
        Label11.Name = "Label11"
        Label11.Size = New Size(85, 17)
        Label11.TabIndex = 20
        Label11.Text = "Period End :"
        ' 
        ' txtPeriodEnd
        ' 
        txtPeriodEnd.BorderStyle = BorderStyle.FixedSingle
        txtPeriodEnd.Location = New Point(171, 160)
        txtPeriodEnd.Margin = New Padding(3, 2, 3, 2)
        txtPeriodEnd.Name = "txtPeriodEnd"
        txtPeriodEnd.ReadOnly = True
        txtPeriodEnd.Size = New Size(175, 23)
        txtPeriodEnd.TabIndex = 21
        txtPeriodEnd.Text = " "
        ' 
        ' txtBasicPay
        ' 
        txtBasicPay.BorderStyle = BorderStyle.FixedSingle
        txtBasicPay.Location = New Point(171, 186)
        txtBasicPay.Margin = New Padding(3, 2, 3, 2)
        txtBasicPay.Name = "txtBasicPay"
        txtBasicPay.ReadOnly = True
        txtBasicPay.Size = New Size(175, 23)
        txtBasicPay.TabIndex = 22
        ' 
        ' txtOTPay
        ' 
        txtOTPay.BorderStyle = BorderStyle.FixedSingle
        txtOTPay.Location = New Point(171, 211)
        txtOTPay.Margin = New Padding(3, 2, 3, 2)
        txtOTPay.Name = "txtOTPay"
        txtOTPay.ReadOnly = True
        txtOTPay.Size = New Size(175, 23)
        txtOTPay.TabIndex = 23
        ' 
        ' txtAbsences
        ' 
        txtAbsences.BorderStyle = BorderStyle.FixedSingle
        txtAbsences.Location = New Point(170, 239)
        txtAbsences.Margin = New Padding(3, 2, 3, 2)
        txtAbsences.Name = "txtAbsences"
        txtAbsences.ReadOnly = True
        txtAbsences.Size = New Size(176, 23)
        txtAbsences.TabIndex = 24
        ' 
        ' txtSSS
        ' 
        txtSSS.BorderStyle = BorderStyle.FixedSingle
        txtSSS.Location = New Point(171, 267)
        txtSSS.Margin = New Padding(3, 2, 3, 2)
        txtSSS.Name = "txtSSS"
        txtSSS.ReadOnly = True
        txtSSS.Size = New Size(175, 23)
        txtSSS.TabIndex = 25
        ' 
        ' txtPagIbig
        ' 
        txtPagIbig.BorderStyle = BorderStyle.FixedSingle
        txtPagIbig.Location = New Point(170, 292)
        txtPagIbig.Margin = New Padding(3, 2, 3, 2)
        txtPagIbig.Name = "txtPagIbig"
        txtPagIbig.ReadOnly = True
        txtPagIbig.Size = New Size(176, 23)
        txtPagIbig.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(47, 266)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 17)
        Label5.TabIndex = 4
        Label5.Text = "SSS Deductions :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(11, 293)
        Label12.Name = "Label12"
        Label12.Size = New Size(147, 17)
        Label12.TabIndex = 27
        Label12.Text = "Pag-Ibig Deductions :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(6, 322)
        Label13.Name = "Label13"
        Label13.Size = New Size(153, 17)
        Label13.TabIndex = 28
        Label13.Text = "PhilHealthDeductions :"
        ' 
        ' txtPhilHealth
        ' 
        txtPhilHealth.BorderStyle = BorderStyle.FixedSingle
        txtPhilHealth.Location = New Point(171, 320)
        txtPhilHealth.Margin = New Padding(3, 2, 3, 2)
        txtPhilHealth.Name = "txtPhilHealth"
        txtPhilHealth.ReadOnly = True
        txtPhilHealth.Size = New Size(175, 23)
        txtPhilHealth.TabIndex = 29
        ' 
        ' txtGrossPay
        ' 
        txtGrossPay.BorderStyle = BorderStyle.FixedSingle
        txtGrossPay.Location = New Point(515, 86)
        txtGrossPay.Margin = New Padding(3, 2, 3, 2)
        txtGrossPay.Name = "txtGrossPay"
        txtGrossPay.ReadOnly = True
        txtGrossPay.Size = New Size(203, 23)
        txtGrossPay.TabIndex = 30
        ' 
        ' txtNetPay
        ' 
        txtNetPay.BorderStyle = BorderStyle.FixedSingle
        txtNetPay.Location = New Point(515, 114)
        txtNetPay.Margin = New Padding(3, 2, 3, 2)
        txtNetPay.Name = "txtNetPay"
        txtNetPay.ReadOnly = True
        txtNetPay.Size = New Size(203, 23)
        txtNetPay.TabIndex = 31
        ' 
        ' txtDateGenerated
        ' 
        txtDateGenerated.BorderStyle = BorderStyle.FixedSingle
        txtDateGenerated.Location = New Point(515, 142)
        txtDateGenerated.Margin = New Padding(3, 2, 3, 2)
        txtDateGenerated.Name = "txtDateGenerated"
        txtDateGenerated.ReadOnly = True
        txtDateGenerated.Size = New Size(205, 23)
        txtDateGenerated.TabIndex = 32
        ' 
        ' dtgv
        ' 
        dtgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgv.Location = New Point(431, 178)
        dtgv.Margin = New Padding(3, 2, 3, 2)
        dtgv.Name = "dtgv"
        dtgv.Size = New Size(327, 118)
        dtgv.TabIndex = 33
        ' 
        ' txtPayrollID
        ' 
        txtPayrollID.BorderStyle = BorderStyle.FixedSingle
        txtPayrollID.Location = New Point(170, 86)
        txtPayrollID.Margin = New Padding(3, 2, 3, 2)
        txtPayrollID.Name = "txtPayrollID"
        txtPayrollID.Size = New Size(176, 23)
        txtPayrollID.TabIndex = 15
        ' 
        ' txtFullName
        ' 
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Location = New Point(170, 110)
        txtFullName.Margin = New Padding(3, 2, 3, 2)
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(176, 23)
        txtFullName.TabIndex = 34
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(81, 113)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 17)
        Label7.TabIndex = 35
        Label7.Text = "Full Name :"
        ' 
        ' txtPeriodS
        ' 
        txtPeriodS.BorderStyle = BorderStyle.FixedSingle
        txtPeriodS.Location = New Point(170, 136)
        txtPeriodS.Margin = New Padding(3, 2, 3, 2)
        txtPeriodS.Name = "txtPeriodS"
        txtPeriodS.ReadOnly = True
        txtPeriodS.Size = New Size(176, 23)
        txtPeriodS.TabIndex = 36
        ' 
        ' frmpPayslip
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Youtube_Vlog_Traveling_Youtube_Tumbnail__13_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(822, 409)
        Controls.Add(txtPeriodS)
        Controls.Add(Label7)
        Controls.Add(txtFullName)
        Controls.Add(dtgv)
        Controls.Add(txtDateGenerated)
        Controls.Add(txtNetPay)
        Controls.Add(txtGrossPay)
        Controls.Add(txtPhilHealth)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(txtPagIbig)
        Controls.Add(txtSSS)
        Controls.Add(txtAbsences)
        Controls.Add(txtOTPay)
        Controls.Add(txtBasicPay)
        Controls.Add(txtPeriodEnd)
        Controls.Add(Label11)
        Controls.Add(btnBack3)
        Controls.Add(txtPayrollID)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(btnDL)
        Controls.Add(btnGenerate)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmpPayslip"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payslip"
        CType(dtgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnDL As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnBack3 As Button
    Public Property txtPeriodStart As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPeriodEnd As TextBox
    Friend WithEvents txtBasicPay As TextBox
    Friend WithEvents txtOTPay As TextBox
    Friend WithEvents txtAbsences As TextBox
    Friend WithEvents txtSSS As TextBox
    Friend WithEvents txtPagIbig As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPhilHealth As TextBox
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents txtNetPay As TextBox
    Friend WithEvents txtDateGenerated As TextBox
    Friend WithEvents dtgv As DataGridView
    Friend WithEvents txtPayrollID As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPeriodS As TextBox
End Class
