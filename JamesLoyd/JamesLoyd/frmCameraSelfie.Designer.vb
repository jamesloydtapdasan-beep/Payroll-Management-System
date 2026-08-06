<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCameraSelfie
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
        picPreview = New PictureBox()
        btnCapture = New Button()
        btnClose = New Button()
        CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picPreview
        ' 
        picPreview.BorderStyle = BorderStyle.FixedSingle
        picPreview.Location = New Point(160, 35)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(379, 189)
        picPreview.TabIndex = 0
        picPreview.TabStop = False
        ' 
        ' btnCapture
        ' 
        btnCapture.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6121
        btnCapture.BackgroundImageLayout = ImageLayout.Stretch
        btnCapture.Font = New Font("Century Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnCapture.Location = New Point(189, 259)
        btnCapture.Name = "btnCapture"
        btnCapture.Size = New Size(142, 53)
        btnCapture.TabIndex = 2
        btnCapture.Text = "Capture"
        btnCapture.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x612
        btnClose.BackgroundImageLayout = ImageLayout.Stretch
        btnClose.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(365, 259)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(136, 53)
        btnClose.TabIndex = 3
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmCameraSelfie
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(674, 343)
        Controls.Add(btnClose)
        Controls.Add(btnCapture)
        Controls.Add(picPreview)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmCameraSelfie"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmCameraSelfie"
        CType(picPreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents picPreview As PictureBox
    Friend WithEvents btnCapture As Button
    Friend WithEvents btnClose As Button
End Class
