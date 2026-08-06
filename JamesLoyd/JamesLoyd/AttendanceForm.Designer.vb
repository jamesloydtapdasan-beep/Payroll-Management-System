<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceForm
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
        dgvAttendance = New DataGridView()
        btnBackButton = New Button()
        PictureBox1 = New PictureBox()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvAttendance
        ' 
        dgvAttendance.BackgroundColor = SystemColors.Control
        dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendance.GridColor = Color.White
        dgvAttendance.Location = New Point(31, 18)
        dgvAttendance.Margin = New Padding(3, 2, 3, 2)
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.Size = New Size(604, 171)
        dgvAttendance.TabIndex = 0
        ' 
        ' btnBackButton
        ' 
        btnBackButton.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnBackButton.BackgroundImageLayout = ImageLayout.Stretch
        btnBackButton.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackButton.Location = New Point(255, 220)
        btnBackButton.Margin = New Padding(3, 2, 3, 2)
        btnBackButton.Name = "btnBackButton"
        btnBackButton.Size = New Size(145, 38)
        btnBackButton.TabIndex = 3
        btnBackButton.Text = "Back"
        btnBackButton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1053210
        PictureBox1.Location = New Point(255, 227)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(26, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' AttendanceForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Youtube_Vlog_Traveling_Youtube_Tumbnail__16_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(685, 305)
        Controls.Add(PictureBox1)
        Controls.Add(btnBackButton)
        Controls.Add(dgvAttendance)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "AttendanceForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AttendanceForm"
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents btnRefreshAttendance As Button
    Friend WithEvents btnBackButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
