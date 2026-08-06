Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmAdminApprove

    Private ReadOnly connStr As String =
        "server=localhost;userid=root;password=;database=payrolldb"

    '========================
    ' Form Load
    '========================
    Private Sub frmAdminApprove_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPendingPayrolls()
    End Sub

    '========================
    ' Load Pending Payrolls
    '========================
    Private Sub LoadPendingPayrolls()

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                Dim query As String =
                    "SELECT * FROM prepared_payroll WHERE status='Pending'"

                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvPendingPayrolls.DataSource = dt
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading payrolls: " & ex.Message)
            End Try
        End Using

    End Sub

    '========================
    ' Save Changes
    '========================
    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                For Each row As DataGridViewRow In dgvPendingPayrolls.Rows
                    If row.IsNewRow Then Continue For

                    Using cmd As New MySqlCommand("
                        UPDATE prepared_payroll SET
                            basic_pay=@basic,
                            overtime_pay=@ot,
                            absences=@abs,
                            sss=@sss,
                            philhealth=@phil,
                            pagibig=@pagibig,
                            gross_pay=@gross,
                            net_pay=@net
                        WHERE prepared_id=@id", conn)

                        cmd.Parameters.AddWithValue("@basic", row.Cells("basic_pay").Value)
                        cmd.Parameters.AddWithValue("@ot", row.Cells("overtime_pay").Value)
                        cmd.Parameters.AddWithValue("@abs", row.Cells("absences").Value)
                        cmd.Parameters.AddWithValue("@sss", row.Cells("sss").Value)
                        cmd.Parameters.AddWithValue("@phil", row.Cells("philhealth").Value)
                        cmd.Parameters.AddWithValue("@pagibig", row.Cells("pagibig").Value)
                        cmd.Parameters.AddWithValue("@gross", row.Cells("gross_pay").Value)
                        cmd.Parameters.AddWithValue("@net", row.Cells("net_pay").Value)
                        cmd.Parameters.AddWithValue("@id", row.Cells("prepared_id").Value)

                        cmd.ExecuteNonQuery()
                    End Using
                Next

                MessageBox.Show("Changes saved successfully!")
                LoadPendingPayrolls()

            Catch ex As Exception
                MessageBox.Show("Error saving changes: " & ex.Message)
            End Try
        End Using

    End Sub

    '========================
    ' Approve Payroll
    '========================
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

        If dgvPendingPayrolls.SelectedRows.Count = 0 Then
            MessageBox.Show("Select at least one payroll to approve.")
            Exit Sub
        End If

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                For Each row As DataGridViewRow In dgvPendingPayrolls.SelectedRows

                    ' Insert into final payroll
                    Using cmdInsert As New MySqlCommand("
                        INSERT INTO payroll
                        (employee_id, period_start, period_end,
                         basic_pay, overtime_pay, absences,
                         sss, philhealth, pagibig,
                         gross_pay, net_pay)
                        SELECT employee_id, period_start, period_end,
                               basic_pay, overtime_pay, absences,
                               sss, philhealth, pagibig,
                               gross_pay, net_pay
                        FROM prepared_payroll
                        WHERE prepared_id=@id", conn)

                        cmdInsert.Parameters.AddWithValue("@id", row.Cells("prepared_id").Value)
                        cmdInsert.ExecuteNonQuery()
                    End Using

                    ' Update status
                    Using cmdUpdate As New MySqlCommand(
                        "UPDATE prepared_payroll SET status='Approved' WHERE prepared_id=@id", conn)

                        cmdUpdate.Parameters.AddWithValue("@id", row.Cells("prepared_id").Value)
                        cmdUpdate.ExecuteNonQuery()
                    End Using

                Next

                MessageBox.Show("Payroll approved and moved to final payroll!")
                LoadPendingPayrolls()

            Catch ex As Exception
                MessageBox.Show("Error approving payrolls: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmPayroll.Show()
    End Sub
End Class
