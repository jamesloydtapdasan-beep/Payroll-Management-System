<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserComplaintForm
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
        btnBack = New Button()
        txtSubject = New TextBox()
        txtDescription = New TextBox()
        cmbType = New ComboBox()
        btnSubmit = New Button()
        lblStatus = New Label()
        Label2 = New Label()
        btnViewHistory = New Button()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnBack.Location = New Point(215, 206)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 39)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' txtSubject
        ' 
        txtSubject.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtSubject.Location = New Point(133, 49)
        txtSubject.Name = "txtSubject"
        txtSubject.Size = New Size(121, 27)
        txtSubject.TabIndex = 1
        ' 
        ' txtDescription
        ' 
        txtDescription.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtDescription.Location = New Point(179, 89)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ScrollBars = ScrollBars.Vertical
        txtDescription.Size = New Size(188, 77)
        txtDescription.TabIndex = 2
        ' 
        ' cmbType
        ' 
        cmbType.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        cmbType.FormattingEnabled = True
        cmbType.Location = New Point(272, 49)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(121, 27)
        cmbType.TabIndex = 3
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnSubmit.Location = New Point(102, 206)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(75, 39)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblStatus.Location = New Point(174, 23)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(16, 19)
        lblStatus.TabIndex = 5
        lblStatus.Text = "-"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 10F, FontStyle.Bold)
        Label2.Location = New Point(117, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 17)
        Label2.TabIndex = 6
        Label2.Text = "Status :"
        ' 
        ' btnViewHistory
        ' 
        btnViewHistory.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnViewHistory.Location = New Point(319, 206)
        btnViewHistory.Name = "btnViewHistory"
        btnViewHistory.Size = New Size(119, 39)
        btnViewHistory.TabIndex = 7
        btnViewHistory.Text = "Complain History"
        btnViewHistory.UseVisualStyleBackColor = True
        ' 
        ' UserComplaintForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1281736074_612x612
        ClientSize = New Size(545, 309)
        Controls.Add(btnViewHistory)
        Controls.Add(Label2)
        Controls.Add(lblStatus)
        Controls.Add(btnSubmit)
        Controls.Add(cmbType)
        Controls.Add(txtDescription)
        Controls.Add(txtSubject)
        Controls.Add(btnBack)
        Name = "UserComplaintForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserComplaintForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CurrentUserID As Label
    Friend WithEvents btnViewHistory As Button
End Class
