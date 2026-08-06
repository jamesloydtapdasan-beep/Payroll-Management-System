<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffEmployeeManage
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
        btnSave = New Button()
        btnUpdateEmployee = New Button()
        btnSearch = New Button()
        txtSearchID = New TextBox()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnSave.Location = New Point(32, 43)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(93, 48)
        btnSave.TabIndex = 0
        btnSave.Text = "Add"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateEmployee
        ' 
        btnUpdateEmployee.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnUpdateEmployee.Location = New Point(32, 97)
        btnUpdateEmployee.Name = "btnUpdateEmployee"
        btnUpdateEmployee.Size = New Size(93, 48)
        btnUpdateEmployee.TabIndex = 1
        btnUpdateEmployee.Text = "Edit"
        btnUpdateEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnSearch.Location = New Point(336, 35)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(89, 41)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearchID
        ' 
        txtSearchID.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtSearchID.Location = New Point(190, 43)
        txtSearchID.Name = "txtSearchID"
        txtSearchID.Size = New Size(127, 27)
        txtSearchID.TabIndex = 4
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnClose.Location = New Point(32, 151)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(93, 48)
        btnClose.TabIndex = 5
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' StaffEmployeeManage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1390592131_612x6123
        ClientSize = New Size(475, 246)
        Controls.Add(btnClose)
        Controls.Add(txtSearchID)
        Controls.Add(btnSearch)
        Controls.Add(btnUpdateEmployee)
        Controls.Add(btnSave)
        Name = "StaffEmployeeManage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StaffEmployeeManage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdateEmployee As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchID As TextBox
    Friend WithEvents btnClose As Button
End Class
