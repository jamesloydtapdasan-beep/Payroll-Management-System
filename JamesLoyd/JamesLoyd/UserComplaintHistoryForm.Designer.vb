<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserComplaintHistoryForm
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
        dgvUserComplaints = New DataGridView()
        btnRefresh = New Button()
        btnBack = New Button()
        CType(dgvUserComplaints, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvUserComplaints
        ' 
        dgvUserComplaints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUserComplaints.Location = New Point(50, 50)
        dgvUserComplaints.Name = "dgvUserComplaints"
        dgvUserComplaints.Size = New Size(714, 192)
        dgvUserComplaints.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnRefresh.Location = New Point(263, 288)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(98, 46)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnBack.Location = New Point(428, 287)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(98, 46)
        btnBack.TabIndex = 2
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' UserComplaintHistoryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1281736074_612x612
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(dgvUserComplaints)
        Name = "UserComplaintHistoryForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserComplaintHistoryForm"
        CType(dgvUserComplaints, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvUserComplaints As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
End Class
