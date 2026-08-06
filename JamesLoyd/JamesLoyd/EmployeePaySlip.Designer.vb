<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeePaySlip
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
        txtPeriodS = New TextBox()
        Label7 = New Label()
        txtFullName = New TextBox()
        txtDateGenerated = New TextBox()
        txtNetPay = New TextBox()
        txtPhilHealth = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        txtPagIbig = New TextBox()
        txtSSS = New TextBox()
        txtAbsences = New TextBox()
        txtOTPay = New TextBox()
        txtBasicPay = New TextBox()
        txtPeriodEnd = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtPayrollID = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        btnDL = New Button()
        Label8 = New Label()
        txtGrossPay = New TextBox()
        SuspendLayout()
        ' 
        ' txtPeriodS
        ' 
        txtPeriodS.BorderStyle = BorderStyle.FixedSingle
        txtPeriodS.Location = New Point(190, 149)
        txtPeriodS.Margin = New Padding(3, 2, 3, 2)
        txtPeriodS.Name = "txtPeriodS"
        txtPeriodS.ReadOnly = True
        txtPeriodS.Size = New Size(209, 23)
        txtPeriodS.TabIndex = 59
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(98, 126)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 17)
        Label7.TabIndex = 58
        Label7.Text = "Full Name :"
        ' 
        ' txtFullName
        ' 
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Location = New Point(190, 123)
        txtFullName.Margin = New Padding(3, 2, 3, 2)
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(209, 23)
        txtFullName.TabIndex = 57
        ' 
        ' txtDateGenerated
        ' 
        txtDateGenerated.BorderStyle = BorderStyle.FixedSingle
        txtDateGenerated.Location = New Point(542, 162)
        txtDateGenerated.Margin = New Padding(3, 2, 3, 2)
        txtDateGenerated.Name = "txtDateGenerated"
        txtDateGenerated.ReadOnly = True
        txtDateGenerated.Size = New Size(183, 23)
        txtDateGenerated.TabIndex = 55
        ' 
        ' txtNetPay
        ' 
        txtNetPay.BorderStyle = BorderStyle.FixedSingle
        txtNetPay.Location = New Point(541, 134)
        txtNetPay.Margin = New Padding(3, 2, 3, 2)
        txtNetPay.Name = "txtNetPay"
        txtNetPay.ReadOnly = True
        txtNetPay.Size = New Size(183, 23)
        txtNetPay.TabIndex = 54
        ' 
        ' txtPhilHealth
        ' 
        txtPhilHealth.BorderStyle = BorderStyle.FixedSingle
        txtPhilHealth.Location = New Point(191, 333)
        txtPhilHealth.Margin = New Padding(3, 2, 3, 2)
        txtPhilHealth.Name = "txtPhilHealth"
        txtPhilHealth.ReadOnly = True
        txtPhilHealth.Size = New Size(208, 23)
        txtPhilHealth.TabIndex = 53
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(31, 336)
        Label13.Name = "Label13"
        Label13.Size = New Size(153, 17)
        Label13.TabIndex = 52
        Label13.Text = "PhilHealthDeductions :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(37, 310)
        Label12.Name = "Label12"
        Label12.Size = New Size(147, 17)
        Label12.TabIndex = 51
        Label12.Text = "Pag-Ibig Deductions :"
        ' 
        ' txtPagIbig
        ' 
        txtPagIbig.BorderStyle = BorderStyle.FixedSingle
        txtPagIbig.Location = New Point(190, 306)
        txtPagIbig.Margin = New Padding(3, 2, 3, 2)
        txtPagIbig.Name = "txtPagIbig"
        txtPagIbig.ReadOnly = True
        txtPagIbig.Size = New Size(209, 23)
        txtPagIbig.TabIndex = 50
        ' 
        ' txtSSS
        ' 
        txtSSS.BorderStyle = BorderStyle.FixedSingle
        txtSSS.Location = New Point(191, 280)
        txtSSS.Margin = New Padding(3, 2, 3, 2)
        txtSSS.Name = "txtSSS"
        txtSSS.ReadOnly = True
        txtSSS.Size = New Size(208, 23)
        txtSSS.TabIndex = 49
        ' 
        ' txtAbsences
        ' 
        txtAbsences.BorderStyle = BorderStyle.FixedSingle
        txtAbsences.Location = New Point(190, 252)
        txtAbsences.Margin = New Padding(3, 2, 3, 2)
        txtAbsences.Name = "txtAbsences"
        txtAbsences.ReadOnly = True
        txtAbsences.Size = New Size(209, 23)
        txtAbsences.TabIndex = 48
        ' 
        ' txtOTPay
        ' 
        txtOTPay.BorderStyle = BorderStyle.FixedSingle
        txtOTPay.Location = New Point(191, 224)
        txtOTPay.Margin = New Padding(3, 2, 3, 2)
        txtOTPay.Name = "txtOTPay"
        txtOTPay.ReadOnly = True
        txtOTPay.Size = New Size(208, 23)
        txtOTPay.TabIndex = 47
        ' 
        ' txtBasicPay
        ' 
        txtBasicPay.BorderStyle = BorderStyle.FixedSingle
        txtBasicPay.Location = New Point(191, 199)
        txtBasicPay.Margin = New Padding(3, 2, 3, 2)
        txtBasicPay.Name = "txtBasicPay"
        txtBasicPay.ReadOnly = True
        txtBasicPay.Size = New Size(208, 23)
        txtBasicPay.TabIndex = 46
        ' 
        ' txtPeriodEnd
        ' 
        txtPeriodEnd.BorderStyle = BorderStyle.FixedSingle
        txtPeriodEnd.Location = New Point(191, 174)
        txtPeriodEnd.Margin = New Padding(3, 2, 3, 2)
        txtPeriodEnd.Name = "txtPeriodEnd"
        txtPeriodEnd.ReadOnly = True
        txtPeriodEnd.Size = New Size(208, 23)
        txtPeriodEnd.TabIndex = 45
        txtPeriodEnd.Text = " "
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(95, 179)
        Label11.Name = "Label11"
        Label11.Size = New Size(85, 17)
        Label11.TabIndex = 44
        Label11.Text = "Period End :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(415, 165)
        Label10.Name = "Label10"
        Label10.Size = New Size(122, 17)
        Label10.TabIndex = 43
        Label10.Text = "Date Generated :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(71, 227)
        Label9.Name = "Label9"
        Label9.Size = New Size(111, 17)
        Label9.TabIndex = 42
        Label9.Text = "Total Overtime :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(470, 137)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 17)
        Label6.TabIndex = 41
        Label6.Text = "Net Pay :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(71, 284)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 17)
        Label5.TabIndex = 40
        Label5.Text = "SSS Deductions :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(106, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 17)
        Label4.TabIndex = 39
        Label4.Text = "Basic Pay :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(87, 254)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 17)
        Label3.TabIndex = 38
        Label3.Text = "Total Absent :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(87, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 17)
        Label2.TabIndex = 37
        Label2.Text = "Period Start :"
        ' 
        ' txtPayrollID
        ' 
        txtPayrollID.BorderStyle = BorderStyle.FixedSingle
        txtPayrollID.Location = New Point(190, 98)
        txtPayrollID.Margin = New Padding(3, 2, 3, 2)
        txtPayrollID.Name = "txtPayrollID"
        txtPayrollID.Size = New Size(209, 23)
        txtPayrollID.TabIndex = 61
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(82, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 17)
        Label1.TabIndex = 60
        Label1.Text = "Employee ID :"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.GradientActiveCaption
        Button1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(573, 199)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 42)
        Button1.TabIndex = 62
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnDL
        ' 
        btnDL.BackColor = SystemColors.GradientActiveCaption
        btnDL.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDL.Location = New Point(430, 199)
        btnDL.Margin = New Padding(3, 2, 3, 2)
        btnDL.Name = "btnDL"
        btnDL.Size = New Size(137, 41)
        btnDL.TabIndex = 63
        btnDL.Text = "DownLoad Payslip"
        btnDL.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(457, 110)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 17)
        Label8.TabIndex = 65
        Label8.Text = "Gross Pay :"
        ' 
        ' txtGrossPay
        ' 
        txtGrossPay.BorderStyle = BorderStyle.FixedSingle
        txtGrossPay.Location = New Point(542, 106)
        txtGrossPay.Margin = New Padding(3, 2, 3, 2)
        txtGrossPay.Name = "txtGrossPay"
        txtGrossPay.ReadOnly = True
        txtGrossPay.Size = New Size(183, 23)
        txtGrossPay.TabIndex = 66
        ' 
        ' EmployeePaySlip
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Youtube_Vlog_Traveling_Youtube_Tumbnail__14_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(813, 396)
        Controls.Add(txtGrossPay)
        Controls.Add(Label8)
        Controls.Add(btnDL)
        Controls.Add(Button1)
        Controls.Add(txtPayrollID)
        Controls.Add(Label1)
        Controls.Add(txtPeriodS)
        Controls.Add(Label7)
        Controls.Add(txtFullName)
        Controls.Add(txtDateGenerated)
        Controls.Add(txtNetPay)
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
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "EmployeePaySlip"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EmployeePaySlip"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPeriodS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtDateGenerated As TextBox
    Friend WithEvents txtNetPay As TextBox
    Friend WithEvents txtPhilHealth As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPagIbig As TextBox
    Friend WithEvents txtSSS As TextBox
    Friend WithEvents txtAbsences As TextBox
    Friend WithEvents txtOTPay As TextBox
    Friend WithEvents txtBasicPay As TextBox
    Friend WithEvents txtPeriodEnd As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPayrollID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDL As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtGrossPay As TextBox
End Class
