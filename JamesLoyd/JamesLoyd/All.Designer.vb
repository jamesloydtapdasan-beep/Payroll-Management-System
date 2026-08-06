<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class All
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
        dtgvEmployees = New DataGridView()
        btnBa = New Button()
        PictureBox1 = New PictureBox()
        CType(dtgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtgvEmployees
        ' 
        dtgvEmployees.BackgroundColor = SystemColors.Control
        dtgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgvEmployees.GridColor = SystemColors.Info
        dtgvEmployees.Location = New Point(61, 41)
        dtgvEmployees.Name = "dtgvEmployees"
        dtgvEmployees.Size = New Size(689, 237)
        dtgvEmployees.TabIndex = 0
        ' 
        ' btnBa
        ' 
        btnBa.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBa.Location = New Point(325, 322)
        btnBa.Name = "btnBa"
        btnBa.Size = New Size(163, 49)
        btnBa.TabIndex = 1
        btnBa.Text = "BACK"
        btnBa.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1053210
        PictureBox1.Location = New Point(342, 331)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 30)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' All
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6126
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(btnBa)
        Controls.Add(dtgvEmployees)
        FormBorderStyle = FormBorderStyle.None
        Name = "All"
        StartPosition = FormStartPosition.CenterScreen
        Text = "All"
        CType(dtgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dtgvEmployees As DataGridView
    Friend WithEvents btnBa As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
