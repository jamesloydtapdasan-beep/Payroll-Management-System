Imports MySql.Data.MySqlClient

Public Class AddRemarkForm

    Public Property ComplaintID As Integer
    Public Property EmployeeID As Integer
    Public Property EmployeeName As String

    ' =========================
    ' FORM LOAD
    ' =========================
    Private Sub AddRemarkForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblComplaintID.Text = ComplaintID.ToString()
        lblEmployeeName.Text = EmployeeName

        LoadExistingRemarks()
    End Sub

    ' =========================
    ' LOAD EXISTING REMARKS
    ' =========================
    Private Sub LoadExistingRemarks()
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=payrolldb;")
                conn.Open()
                Dim sql As String = "SELECT reviewed_at, remarks, reviewed_by_role 
                                     FROM complaint_reviews 
                                     WHERE complaint_id=@compID 
                                     ORDER BY reviewed_at DESC"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@compID", ComplaintID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        txtRemarksLog.Clear()
                        While reader.Read()
                            txtRemarksLog.AppendText($"[{reader("reviewed_at")}] ({reader("reviewed_by_role")}) {reader("remarks")}" & Environment.NewLine)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading remarks: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================
    ' ADD NEW REMARK
    ' =========================
    Private Sub btnAddRemark_Click(sender As Object, e As EventArgs) Handles btnAddRemark.Click
        If txtNewRemark.Text.Trim() = "" Then
            MessageBox.Show("Please enter a remark before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=payrolldb;")
                conn.Open()
                Dim sql As String = "INSERT INTO complaint_reviews (complaint_id, remarks, reviewed_by_role, reviewed_at) 
                                     VALUES (@compID, @remark, 'HR', NOW())"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@compID", ComplaintID)
                    cmd.Parameters.AddWithValue("@remark", txtNewRemark.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Remark added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtNewRemark.Clear()
            LoadExistingRemarks()
        Catch ex As Exception
            MessageBox.Show("Error adding remark: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================
    ' CLOSE FORM
    ' =========================
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        StaffComplaintForm.Show()

    End Sub


End Class
