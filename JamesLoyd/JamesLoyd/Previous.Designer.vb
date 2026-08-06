<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayslipHistory
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
        dgvPayslipHistory = New DataGridView()
        btnBack = New Button()
        CType(dgvPayslipHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvPayslipHistory
        ' 
        dgvPayslipHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPayslipHistory.Location = New Point(67, 27)
        dgvPayslipHistory.Margin = New Padding(3, 2, 3, 2)
        dgvPayslipHistory.Name = "dgvPayslipHistory"
        dgvPayslipHistory.Size = New Size(488, 182)
        dgvPayslipHistory.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnBack.BackgroundImageLayout = ImageLayout.Stretch
        btnBack.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(242, 237)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(158, 36)
        btnBack.TabIndex = 12
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmPayslipHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(677, 403)
        Controls.Add(btnBack)
        Controls.Add(dgvPayslipHistory)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmPayslipHistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Previous"
        CType(dgvPayslipHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvPayslipHistory As DataGridView
    Friend WithEvents btnBack As Button


End Class
