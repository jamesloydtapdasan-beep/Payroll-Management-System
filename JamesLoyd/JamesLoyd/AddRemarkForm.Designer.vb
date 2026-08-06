<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRemarkForm
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
        Label1 = New Label()
        lblComplaintID = New Label()
        lblEmployeeName = New Label()
        Label4 = New Label()
        txtNewRemark = New TextBox()
        btnAddRemark = New Button()
        btnClose = New Button()
        txtRemarksLog = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label1.Location = New Point(80, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 19)
        Label1.TabIndex = 0
        Label1.Text = "Complaint ID :"
        ' 
        ' lblComplaintID
        ' 
        lblComplaintID.AutoSize = True
        lblComplaintID.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblComplaintID.Location = New Point(204, 38)
        lblComplaintID.Name = "lblComplaintID"
        lblComplaintID.Size = New Size(16, 19)
        lblComplaintID.TabIndex = 1
        lblComplaintID.Text = "-"
        ' 
        ' lblEmployeeName
        ' 
        lblEmployeeName.AutoSize = True
        lblEmployeeName.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblEmployeeName.Location = New Point(427, 38)
        lblEmployeeName.Name = "lblEmployeeName"
        lblEmployeeName.Size = New Size(16, 19)
        lblEmployeeName.TabIndex = 3
        lblEmployeeName.Text = "-"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label4.Location = New Point(273, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 19)
        Label4.TabIndex = 2
        Label4.Text = "Employee Name :"
        ' 
        ' txtNewRemark
        ' 
        txtNewRemark.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtNewRemark.Location = New Point(98, 95)
        txtNewRemark.Name = "txtNewRemark"
        txtNewRemark.Size = New Size(146, 27)
        txtNewRemark.TabIndex = 4
        ' 
        ' btnAddRemark
        ' 
        btnAddRemark.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnAddRemark.Location = New Point(158, 165)
        btnAddRemark.Name = "btnAddRemark"
        btnAddRemark.Size = New Size(81, 42)
        btnAddRemark.TabIndex = 5
        btnAddRemark.Text = "Save"
        btnAddRemark.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnClose.Location = New Point(284, 165)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(81, 42)
        btnClose.TabIndex = 6
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' txtRemarksLog
        ' 
        txtRemarksLog.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtRemarksLog.Location = New Point(275, 95)
        txtRemarksLog.Name = "txtRemarksLog"
        txtRemarksLog.Size = New Size(146, 27)
        txtRemarksLog.TabIndex = 7
        ' 
        ' AddRemarkForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1281736074_612x6126
        ClientSize = New Size(534, 280)
        Controls.Add(txtRemarksLog)
        Controls.Add(btnClose)
        Controls.Add(btnAddRemark)
        Controls.Add(txtNewRemark)
        Controls.Add(lblEmployeeName)
        Controls.Add(Label4)
        Controls.Add(lblComplaintID)
        Controls.Add(Label1)
        Name = "AddRemarkForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddRemarkForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblComplaintID As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNewRemark As TextBox
    Friend WithEvents btnAddRemark As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtRemarksLog As TextBox
End Class
