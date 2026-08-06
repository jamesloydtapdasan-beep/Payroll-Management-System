<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffDashboard
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
        EmployeeButton = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' EmployeeButton
        ' 
        EmployeeButton.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        EmployeeButton.Location = New Point(134, 40)
        EmployeeButton.Name = "EmployeeButton"
        EmployeeButton.Size = New Size(170, 65)
        EmployeeButton.TabIndex = 0
        EmployeeButton.Text = "Employee"
        EmployeeButton.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Button2.Location = New Point(319, 40)
        Button2.Name = "Button2"
        Button2.Size = New Size(170, 65)
        Button2.TabIndex = 1
        Button2.Text = "Attendance"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Button3.Location = New Point(102, 119)
        Button3.Name = "Button3"
        Button3.Size = New Size(170, 65)
        Button3.TabIndex = 2
        Button3.Text = "Payroll Preparation"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Button4.Location = New Point(352, 119)
        Button4.Name = "Button4"
        Button4.RightToLeft = RightToLeft.No
        Button4.Size = New Size(200, 65)
        Button4.TabIndex = 3
        Button4.Text = "Compliance & Reporting"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Button5.Location = New Point(226, 200)
        Button5.Name = "Button5"
        Button5.Size = New Size(170, 65)
        Button5.TabIndex = 4
        Button5.Text = "Logout"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' StaffDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Ivory
        BackgroundImage = My.Resources.Resources.istockphoto_1281736074_612x612
        ClientSize = New Size(707, 348)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(EmployeeButton)
        Name = "StaffDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StaffDashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents EmployeeButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
