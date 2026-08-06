<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffComplaintForm
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
        cmbTypeFilter = New ComboBox()
        cmbStatusFilter = New ComboBox()
        dtpFrom = New DateTimePicker()
        dtpTo = New DateTimePicker()
        btnApplyFilters = New Button()
        dgvComplaints = New DataGridView()
        btnReview = New Button()
        btnAddRemark = New Button()
        btnUpdateStatus = New Button()
        btnForwardAdmin = New Button()
        btnRefresh = New Button()
        btnBack = New Button()
        CType(dgvComplaints, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbTypeFilter
        ' 
        cmbTypeFilter.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        cmbTypeFilter.FormattingEnabled = True
        cmbTypeFilter.Location = New Point(413, 32)
        cmbTypeFilter.Name = "cmbTypeFilter"
        cmbTypeFilter.Size = New Size(121, 27)
        cmbTypeFilter.TabIndex = 0
        ' 
        ' cmbStatusFilter
        ' 
        cmbStatusFilter.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        cmbStatusFilter.FormattingEnabled = True
        cmbStatusFilter.Location = New Point(286, 32)
        cmbStatusFilter.Name = "cmbStatusFilter"
        cmbStatusFilter.Size = New Size(121, 27)
        cmbStatusFilter.TabIndex = 1
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpFrom.Location = New Point(204, 71)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(200, 27)
        dtpFrom.TabIndex = 2
        ' 
        ' dtpTo
        ' 
        dtpTo.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        dtpTo.Location = New Point(413, 71)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(200, 27)
        dtpTo.TabIndex = 3
        ' 
        ' btnApplyFilters
        ' 
        btnApplyFilters.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnApplyFilters.Location = New Point(349, 112)
        btnApplyFilters.Name = "btnApplyFilters"
        btnApplyFilters.Size = New Size(121, 34)
        btnApplyFilters.TabIndex = 5
        btnApplyFilters.Text = "Apply Filters"
        btnApplyFilters.UseVisualStyleBackColor = True
        ' 
        ' dgvComplaints
        ' 
        dgvComplaints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvComplaints.Location = New Point(80, 164)
        dgvComplaints.Name = "dgvComplaints"
        dgvComplaints.Size = New Size(639, 150)
        dgvComplaints.TabIndex = 6
        ' 
        ' btnReview
        ' 
        btnReview.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnReview.Location = New Point(220, 345)
        btnReview.Name = "btnReview"
        btnReview.Size = New Size(92, 32)
        btnReview.TabIndex = 7
        btnReview.Text = "Review"
        btnReview.UseVisualStyleBackColor = True
        ' 
        ' btnAddRemark
        ' 
        btnAddRemark.AccessibleRole = AccessibleRole.ScrollBar
        btnAddRemark.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnAddRemark.Location = New Point(332, 345)
        btnAddRemark.Name = "btnAddRemark"
        btnAddRemark.Size = New Size(135, 32)
        btnAddRemark.TabIndex = 8
        btnAddRemark.Text = "Add Remarks"
        btnAddRemark.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateStatus
        ' 
        btnUpdateStatus.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnUpdateStatus.Location = New Point(482, 345)
        btnUpdateStatus.Name = "btnUpdateStatus"
        btnUpdateStatus.Size = New Size(131, 32)
        btnUpdateStatus.TabIndex = 9
        btnUpdateStatus.Text = "Update Status"
        btnUpdateStatus.UseVisualStyleBackColor = True
        ' 
        ' btnForwardAdmin
        ' 
        btnForwardAdmin.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnForwardAdmin.Location = New Point(230, 393)
        btnForwardAdmin.Name = "btnForwardAdmin"
        btnForwardAdmin.Size = New Size(117, 32)
        btnForwardAdmin.TabIndex = 10
        btnForwardAdmin.Text = "Forward to Admin"
        btnForwardAdmin.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnRefresh.Location = New Point(373, 393)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(85, 32)
        btnRefresh.TabIndex = 11
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnBack.Location = New Point(484, 393)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(83, 32)
        btnBack.TabIndex = 12
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' StaffComplaintForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1281736074_612x6125
        ClientSize = New Size(800, 484)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(btnForwardAdmin)
        Controls.Add(btnUpdateStatus)
        Controls.Add(btnAddRemark)
        Controls.Add(btnReview)
        Controls.Add(dgvComplaints)
        Controls.Add(btnApplyFilters)
        Controls.Add(dtpTo)
        Controls.Add(dtpFrom)
        Controls.Add(cmbStatusFilter)
        Controls.Add(cmbTypeFilter)
        Name = "StaffComplaintForm"
        Text = "StaffComplaintForm"
        CType(dgvComplaints, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbTypeFilter As ComboBox
    Friend WithEvents cmbStatusFilter As ComboBox
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents btnApplyFilters As Button
    Friend WithEvents dgvComplaints As DataGridView
    Friend WithEvents btnReview As Button
    Friend WithEvents btnAddRemark As Button
    Friend WithEvents btnUpdateStatus As Button
    Friend WithEvents btnForwardAdmin As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
End Class
