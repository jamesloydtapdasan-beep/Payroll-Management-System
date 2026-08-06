<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminApprove
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
        dgvPendingPayrolls = New DataGridView()
        btnSaveChanges = New Button()
        btnApprove = New Button()
        btnBack = New Button()
        CType(dgvPendingPayrolls, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvPendingPayrolls
        ' 
        dgvPendingPayrolls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPendingPayrolls.Location = New Point(54, 39)
        dgvPendingPayrolls.Name = "dgvPendingPayrolls"
        dgvPendingPayrolls.Size = New Size(711, 217)
        dgvPendingPayrolls.TabIndex = 0
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnSaveChanges.Location = New Point(203, 313)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(141, 49)
        btnSaveChanges.TabIndex = 1
        btnSaveChanges.Text = "Save Changes"
        btnSaveChanges.UseVisualStyleBackColor = True
        ' 
        ' btnApprove
        ' 
        btnApprove.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnApprove.Location = New Point(435, 313)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(95, 49)
        btnApprove.TabIndex = 2
        btnApprove.Text = "Approve"
        btnApprove.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnBack.Location = New Point(353, 366)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(79, 40)
        btnBack.TabIndex = 3
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmAdminApprove
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6125
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnApprove)
        Controls.Add(btnSaveChanges)
        Controls.Add(dgvPendingPayrolls)
        Name = "frmAdminApprove"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAdminApprove"
        CType(dgvPendingPayrolls, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvPendingPayrolls As DataGridView
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnBack As Button
End Class
