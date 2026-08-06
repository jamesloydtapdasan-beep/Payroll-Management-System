<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Selfie
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
        btnCapture = New Button()
        btnBack = New Button()
        PicBox = New PictureBox()
        CType(PicBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCapture
        ' 
        btnCapture.Location = New Point(238, 265)
        btnCapture.Margin = New Padding(4, 4, 4, 4)
        btnCapture.Name = "btnCapture"
        btnCapture.Size = New Size(96, 41)
        btnCapture.TabIndex = 0
        btnCapture.Text = "Capture"
        btnCapture.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(432, 265)
        btnBack.Margin = New Padding(4, 4, 4, 4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(96, 41)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' PicBox
        ' 
        PicBox.Location = New Point(184, 15)
        PicBox.Margin = New Padding(4, 4, 4, 4)
        PicBox.Name = "PicBox"
        PicBox.Size = New Size(384, 196)
        PicBox.TabIndex = 2
        PicBox.TabStop = False
        ' 
        ' Selfie
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1281736074_612x6123
        ClientSize = New Size(708, 348)
        Controls.Add(PicBox)
        Controls.Add(btnBack)
        Controls.Add(btnCapture)
        Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 4, 4, 4)
        Name = "Selfie"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Selfie"
        CType(PicBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCapture As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents PicBox As PictureBox
End Class
