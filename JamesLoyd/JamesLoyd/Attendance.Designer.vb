<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAttendance))
        Label1 = New Label()
        Label3 = New Label()
        txtDaysWorked = New TextBox()
        cmbEmployeeSelect = New ComboBox()
        dgvAttendanceLogBook = New DataGridView()
        btnBack2 = New Button()
        btnSearch = New Button()
        Label2 = New Label()
        txtTotalHours = New TextBox()
        txtLastDate = New TextBox()
        Label5 = New Label()
        txtFullName = New TextBox()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(dgvAttendanceLogBook, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(217, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 17)
        Label1.TabIndex = 0
        Label1.Text = "Employee ID :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(183, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 17)
        Label3.TabIndex = 2
        Label3.Text = "Total Days Worked :" & vbCrLf
        ' 
        ' txtDaysWorked
        ' 
        txtDaysWorked.BorderStyle = BorderStyle.FixedSingle
        txtDaysWorked.Location = New Point(325, 135)
        txtDaysWorked.Margin = New Padding(3, 2, 3, 2)
        txtDaysWorked.Name = "txtDaysWorked"
        txtDaysWorked.ReadOnly = True
        txtDaysWorked.Size = New Size(185, 23)
        txtDaysWorked.TabIndex = 5
        ' 
        ' cmbEmployeeSelect
        ' 
        cmbEmployeeSelect.FormattingEnabled = True
        cmbEmployeeSelect.Location = New Point(325, 77)
        cmbEmployeeSelect.Margin = New Padding(3, 2, 3, 2)
        cmbEmployeeSelect.Name = "cmbEmployeeSelect"
        cmbEmployeeSelect.Size = New Size(185, 23)
        cmbEmployeeSelect.TabIndex = 10
        ' 
        ' dgvAttendanceLogBook
        ' 
        dgvAttendanceLogBook.BackgroundColor = SystemColors.Control
        dgvAttendanceLogBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendanceLogBook.Location = New Point(24, 260)
        dgvAttendanceLogBook.Margin = New Padding(3, 2, 3, 2)
        dgvAttendanceLogBook.Name = "dgvAttendanceLogBook"
        dgvAttendanceLogBook.RowHeadersWidth = 51
        dgvAttendanceLogBook.Size = New Size(627, 105)
        dgvAttendanceLogBook.TabIndex = 12
        ' 
        ' btnBack2
        ' 
        btnBack2.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnBack2.BackgroundImageLayout = ImageLayout.Stretch
        btnBack2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack2.Location = New Point(163, 221)
        btnBack2.Name = "btnBack2"
        btnBack2.Size = New Size(136, 36)
        btnBack2.TabIndex = 13
        btnBack2.Text = "Back"
        btnBack2.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x61210
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(307, 222)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(136, 34)
        btnSearch.TabIndex = 15
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(177, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 17)
        Label2.TabIndex = 16
        Label2.Text = "Total Hours Worked :" & vbCrLf
        ' 
        ' txtTotalHours
        ' 
        txtTotalHours.BorderStyle = BorderStyle.FixedSingle
        txtTotalHours.Location = New Point(325, 160)
        txtTotalHours.Margin = New Padding(3, 2, 3, 2)
        txtTotalHours.Name = "txtTotalHours"
        txtTotalHours.ReadOnly = True
        txtTotalHours.Size = New Size(185, 23)
        txtTotalHours.TabIndex = 17
        ' 
        ' txtLastDate
        ' 
        txtLastDate.BorderStyle = BorderStyle.FixedSingle
        txtLastDate.Location = New Point(325, 188)
        txtLastDate.Margin = New Padding(3, 2, 3, 2)
        txtLastDate.Name = "txtLastDate"
        txtLastDate.ReadOnly = True
        txtLastDate.Size = New Size(185, 23)
        txtLastDate.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(159, 189)
        Label5.Name = "Label5"
        Label5.Size = New Size(162, 17)
        Label5.TabIndex = 19
        Label5.Text = "Last Attendance Date : "
        ' 
        ' txtFullName
        ' 
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Location = New Point(325, 105)
        txtFullName.Margin = New Padding(3, 2, 3, 2)
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(185, 23)
        txtFullName.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(230, 108)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 17)
        Label6.TabIndex = 21
        Label6.Text = "Full Name :"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._10532101
        PictureBox1.Location = New Point(172, 228)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(26, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(318, 228)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(26, 24)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 23
        PictureBox2.TabStop = False
        ' 
        ' frmAttendance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Youtube_Vlog_Traveling_Youtube_Tumbnail__18_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(700, 374)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label6)
        Controls.Add(txtFullName)
        Controls.Add(Label5)
        Controls.Add(txtLastDate)
        Controls.Add(txtTotalHours)
        Controls.Add(Label2)
        Controls.Add(btnSearch)
        Controls.Add(btnBack2)
        Controls.Add(dgvAttendanceLogBook)
        Controls.Add(cmbEmployeeSelect)
        Controls.Add(txtDaysWorked)
        Controls.Add(Label3)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmAttendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Attendance"
        CType(dgvAttendanceLogBook, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDaysWorked As TextBox
    Friend WithEvents cmbEmployeeSelect As ComboBox
    Friend WithEvents dgvAttendanceLogBook As DataGridView
    Friend WithEvents btnBack2 As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalHours As TextBox
    Friend WithEvents txtLastDate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
