<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReviewComplaintForm
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
        btnClose = New Button()
        Label1 = New Label()
        txtSubject = New TextBox()
        lblEmployeeName = New Label()
        txtDescription = New TextBox()
        txtType = New TextBox()
        txtStatus = New TextBox()
        txtFiledAt = New TextBox()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnClose.Location = New Point(248, 164)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(82, 31)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label1.Location = New Point(99, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 19)
        Label1.TabIndex = 1
        Label1.Text = "Employee Name :"
        ' 
        ' txtSubject
        ' 
        txtSubject.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtSubject.Location = New Point(172, 69)
        txtSubject.Name = "txtSubject"
        txtSubject.Size = New Size(100, 27)
        txtSubject.TabIndex = 2
        ' 
        ' lblEmployeeName
        ' 
        lblEmployeeName.AutoSize = True
        lblEmployeeName.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblEmployeeName.Location = New Point(253, 24)
        lblEmployeeName.Name = "lblEmployeeName"
        lblEmployeeName.Size = New Size(16, 19)
        lblEmployeeName.TabIndex = 3
        lblEmployeeName.Text = "-"
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtDescription.Location = New Point(172, 107)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(100, 27)
        txtDescription.TabIndex = 4
        ' 
        ' txtType
        ' 
        txtType.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtType.Location = New Point(302, 69)
        txtType.Name = "txtType"
        txtType.Size = New Size(100, 27)
        txtType.TabIndex = 5
        ' 
        ' txtStatus
        ' 
        txtStatus.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtStatus.Location = New Point(302, 107)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(100, 27)
        txtStatus.TabIndex = 6
        ' 
        ' txtFiledAt
        ' 
        txtFiledAt.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtFiledAt.Location = New Point(435, 69)
        txtFiledAt.Name = "txtFiledAt"
        txtFiledAt.Size = New Size(100, 27)
        txtFiledAt.TabIndex = 7
        ' 
        ' ReviewComplaintForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1281736074_612x6126
        ClientSize = New Size(638, 259)
        Controls.Add(txtFiledAt)
        Controls.Add(txtStatus)
        Controls.Add(txtType)
        Controls.Add(txtDescription)
        Controls.Add(lblEmployeeName)
        Controls.Add(txtSubject)
        Controls.Add(Label1)
        Controls.Add(btnClose)
        Name = "ReviewComplaintForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReviewComplaintForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtFiledAt As TextBox
End Class
