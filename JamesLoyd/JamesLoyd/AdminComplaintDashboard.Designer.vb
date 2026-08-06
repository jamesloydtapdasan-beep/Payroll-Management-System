<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminComplaintDashboard
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
        cmbStatus = New ComboBox()
        cmbType = New ComboBox()
        dtpFrom = New DateTimePicker()
        dtpTo = New DateTimePicker()
        btnApplyFilter = New Button()
        btnRefresh = New Button()
        txtSearchEmployee = New TextBox()
        dgvAdminComplaints = New DataGridView()
        btnViewDetails = New Button()
        btnAddAdminRemark = New Button()
        btnClose = New Button()
        btnUpdateStatus = New Button()
        Label1 = New Label()
        lblTotalComplaints = New Label()
        lblComplaintStats = New Label()
        Label4 = New Label()
        btnSearch = New Button()
        Label2 = New Label()
        CType(dgvAdminComplaints, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(179, 82)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(121, 27)
        cmbStatus.TabIndex = 0
        ' 
        ' cmbType
        ' 
        cmbType.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        cmbType.FormattingEnabled = True
        cmbType.Location = New Point(179, 111)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(121, 27)
        cmbType.TabIndex = 1
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpFrom.Location = New Point(333, 95)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(128, 27)
        dtpFrom.TabIndex = 2
        ' 
        ' dtpTo
        ' 
        dtpTo.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpTo.Location = New Point(477, 95)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(141, 27)
        dtpTo.TabIndex = 3
        ' 
        ' btnApplyFilter
        ' 
        btnApplyFilter.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnApplyFilter.Location = New Point(305, 177)
        btnApplyFilter.Name = "btnApplyFilter"
        btnApplyFilter.Size = New Size(88, 34)
        btnApplyFilter.TabIndex = 4
        btnApplyFilter.Text = "Apply Filter"
        btnApplyFilter.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnRefresh.Location = New Point(427, 177)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(88, 34)
        btnRefresh.TabIndex = 5
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' txtSearchEmployee
        ' 
        txtSearchEmployee.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        txtSearchEmployee.Location = New Point(179, 38)
        txtSearchEmployee.Name = "txtSearchEmployee"
        txtSearchEmployee.Size = New Size(118, 27)
        txtSearchEmployee.TabIndex = 6
        ' 
        ' dgvAdminComplaints
        ' 
        dgvAdminComplaints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAdminComplaints.Location = New Point(112, 236)
        dgvAdminComplaints.Name = "dgvAdminComplaints"
        dgvAdminComplaints.Size = New Size(588, 150)
        dgvAdminComplaints.TabIndex = 7
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnViewDetails.Location = New Point(135, 416)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.Size = New Size(89, 45)
        btnViewDetails.TabIndex = 8
        btnViewDetails.Text = "View"
        btnViewDetails.UseVisualStyleBackColor = True
        ' 
        ' btnAddAdminRemark
        ' 
        btnAddAdminRemark.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnAddAdminRemark.Location = New Point(245, 417)
        btnAddAdminRemark.Name = "btnAddAdminRemark"
        btnAddAdminRemark.Size = New Size(133, 45)
        btnAddAdminRemark.TabIndex = 9
        btnAddAdminRemark.Text = "Add Remarks"
        btnAddAdminRemark.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnClose.Location = New Point(590, 418)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(89, 45)
        btnClose.TabIndex = 11
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateStatus
        ' 
        btnUpdateStatus.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnUpdateStatus.Location = New Point(412, 418)
        btnUpdateStatus.Name = "btnUpdateStatus"
        btnUpdateStatus.Size = New Size(157, 45)
        btnUpdateStatus.TabIndex = 10
        btnUpdateStatus.Text = "Update Status"
        btnUpdateStatus.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(112, 510)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 16)
        Label1.TabIndex = 12
        Label1.Text = "Total Complaints :"
        ' 
        ' lblTotalComplaints
        ' 
        lblTotalComplaints.AutoSize = True
        lblTotalComplaints.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        lblTotalComplaints.Location = New Point(245, 510)
        lblTotalComplaints.Name = "lblTotalComplaints"
        lblTotalComplaints.Size = New Size(12, 16)
        lblTotalComplaints.TabIndex = 13
        lblTotalComplaints.Text = "-"
        ' 
        ' lblComplaintStats
        ' 
        lblComplaintStats.AutoSize = True
        lblComplaintStats.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        lblComplaintStats.Location = New Point(566, 510)
        lblComplaintStats.Name = "lblComplaintStats"
        lblComplaintStats.Size = New Size(12, 16)
        lblComplaintStats.TabIndex = 15
        lblComplaintStats.Text = "-"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(439, 510)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 16)
        Label4.TabIndex = 14
        Label4.Text = "Complaint Stat : "
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnSearch.Location = New Point(303, 39)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(99, 23)
        btnSearch.TabIndex = 16
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(135, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 20)
        Label2.TabIndex = 17
        Label2.Text = "Employee name :"
        ' 
        ' AdminComplaintDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1281736074_612x612
        ClientSize = New Size(800, 608)
        Controls.Add(Label2)
        Controls.Add(btnSearch)
        Controls.Add(lblComplaintStats)
        Controls.Add(Label4)
        Controls.Add(lblTotalComplaints)
        Controls.Add(Label1)
        Controls.Add(btnClose)
        Controls.Add(btnUpdateStatus)
        Controls.Add(btnAddAdminRemark)
        Controls.Add(btnViewDetails)
        Controls.Add(dgvAdminComplaints)
        Controls.Add(txtSearchEmployee)
        Controls.Add(btnRefresh)
        Controls.Add(btnApplyFilter)
        Controls.Add(dtpTo)
        Controls.Add(dtpFrom)
        Controls.Add(cmbType)
        Controls.Add(cmbStatus)
        Name = "AdminComplaintDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminComplaintDashboard"
        CType(dgvAdminComplaints, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents btnApplyFilter As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearchEmployee As TextBox
    Friend WithEvents dgvAdminComplaints As DataGridView
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents btnAddAdminRemark As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnUpdateStatus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalComplaints As Label
    Friend WithEvents lblComplaintStats As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
End Class
