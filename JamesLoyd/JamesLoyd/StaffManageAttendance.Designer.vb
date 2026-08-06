<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffManageAttendance
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
        btnSearch = New Button()
        txtSearchID = New TextBox()
        dgvAttendanceLog = New DataGridView()
        lblTotalHours = New Label()
        lblTotHours = New Label()
        lblUndertime = New Label()
        lblAbsentDays = New Label()
        lblLastWorked = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        CType(dgvAttendanceLog, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnSearch.Location = New Point(391, 33)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(84, 38)
        btnSearch.TabIndex = 0
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearchID
        ' 
        txtSearchID.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        txtSearchID.Location = New Point(215, 42)
        txtSearchID.Name = "txtSearchID"
        txtSearchID.Size = New Size(155, 25)
        txtSearchID.TabIndex = 1
        ' 
        ' dgvAttendanceLog
        ' 
        dgvAttendanceLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendanceLog.Location = New Point(91, 85)
        dgvAttendanceLog.Name = "dgvAttendanceLog"
        dgvAttendanceLog.Size = New Size(587, 150)
        dgvAttendanceLog.TabIndex = 2
        ' 
        ' lblTotalHours
        ' 
        lblTotalHours.AutoSize = True
        lblTotalHours.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        lblTotalHours.Location = New Point(191, 236)
        lblTotalHours.Name = "lblTotalHours"
        lblTotalHours.Size = New Size(0, 18)
        lblTotalHours.TabIndex = 3
        ' 
        ' lblTotHours
        ' 
        lblTotHours.AutoSize = True
        lblTotHours.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        lblTotHours.Location = New Point(257, 264)
        lblTotHours.Name = "lblTotHours"
        lblTotHours.Size = New Size(14, 18)
        lblTotHours.TabIndex = 4
        lblTotHours.Text = "-"
        ' 
        ' lblUndertime
        ' 
        lblUndertime.AutoSize = True
        lblUndertime.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        lblUndertime.Location = New Point(259, 296)
        lblUndertime.Name = "lblUndertime"
        lblUndertime.Size = New Size(14, 18)
        lblUndertime.TabIndex = 6
        lblUndertime.Text = "-"
        ' 
        ' lblAbsentDays
        ' 
        lblAbsentDays.AutoSize = True
        lblAbsentDays.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        lblAbsentDays.Location = New Point(520, 263)
        lblAbsentDays.Name = "lblAbsentDays"
        lblAbsentDays.Size = New Size(14, 18)
        lblAbsentDays.TabIndex = 7
        lblAbsentDays.Text = "-"
        ' 
        ' lblLastWorked
        ' 
        lblLastWorked.AutoSize = True
        lblLastWorked.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        lblLastWorked.Location = New Point(521, 293)
        lblLastWorked.Name = "lblLastWorked"
        lblLastWorked.Size = New Size(14, 18)
        lblLastWorked.TabIndex = 8
        lblLastWorked.Text = "-"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label1.Location = New Point(153, 263)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 18)
        Label1.TabIndex = 9
        Label1.Text = "Total Hours : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label2.Location = New Point(408, 293)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 18)
        Label2.TabIndex = 12
        Label2.Text = "Last Worked : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label3.Location = New Point(448, 263)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 18)
        Label3.TabIndex = 11
        Label3.Text = "Absent :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        Label4.Location = New Point(157, 293)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 18)
        Label4.TabIndex = 10
        Label4.Text = "Undertime : "
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Button1.Location = New Point(492, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(84, 38)
        Button1.TabIndex = 13
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' StaffManageAttendance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6124
        ClientSize = New Size(738, 373)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(lblLastWorked)
        Controls.Add(lblAbsentDays)
        Controls.Add(lblUndertime)
        Controls.Add(lblTotHours)
        Controls.Add(lblTotalHours)
        Controls.Add(dgvAttendanceLog)
        Controls.Add(txtSearchID)
        Controls.Add(btnSearch)
        Name = "StaffManageAttendance"
        Text = "StaffManageAttendance"
        CType(dgvAttendanceLog, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchID As TextBox
    Friend WithEvents dgvAttendanceLog As DataGridView
    Friend WithEvents lblTotalHours As Label
    Friend WithEvents lblTotHours As Label
    Friend WithEvents lblUndertime As Label
    Friend WithEvents lblAbsentDays As Label
    Friend WithEvents lblLastWorked As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
