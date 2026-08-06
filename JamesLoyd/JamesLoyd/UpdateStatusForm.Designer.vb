<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStatusForm
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
        lblSubject = New Label()
        lblComplaintID = New Label()
        cmbStatus = New ComboBox()
        btnUpdateStatus = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label1.Location = New Point(66, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 19)
        Label1.TabIndex = 0
        Label1.Text = "Complaint ID :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label2.Location = New Point(275, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 19)
        Label2.TabIndex = 1
        Label2.Text = "Subject : "
        ' 
        ' lblSubject
        ' 
        lblSubject.AutoSize = True
        lblSubject.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblSubject.Location = New Point(359, 31)
        lblSubject.Name = "lblSubject"
        lblSubject.Size = New Size(16, 19)
        lblSubject.TabIndex = 3
        lblSubject.Text = "-"
        ' 
        ' lblComplaintID
        ' 
        lblComplaintID.AutoSize = True
        lblComplaintID.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblComplaintID.Location = New Point(190, 31)
        lblComplaintID.Name = "lblComplaintID"
        lblComplaintID.Size = New Size(16, 19)
        lblComplaintID.TabIndex = 2
        lblComplaintID.Text = "-"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(183, 86)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(121, 27)
        cmbStatus.TabIndex = 4
        ' 
        ' btnUpdateStatus
        ' 
        btnUpdateStatus.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnUpdateStatus.Location = New Point(124, 145)
        btnUpdateStatus.Name = "btnUpdateStatus"
        btnUpdateStatus.Size = New Size(83, 38)
        btnUpdateStatus.TabIndex = 5
        btnUpdateStatus.Text = "Update"
        btnUpdateStatus.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnClose.Location = New Point(288, 150)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 33)
        btnClose.TabIndex = 6
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' UpdateStatusForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1281736074_612x612
        ClientSize = New Size(483, 219)
        Controls.Add(btnClose)
        Controls.Add(btnUpdateStatus)
        Controls.Add(cmbStatus)
        Controls.Add(lblSubject)
        Controls.Add(lblComplaintID)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "UpdateStatusForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UpdateStatusForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblComplaintID As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnUpdateStatus As Button
    Friend WithEvents btnClose As Button
End Class
