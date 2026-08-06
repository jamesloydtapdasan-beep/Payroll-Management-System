Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmpPayslip



    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Try
            If String.IsNullOrWhiteSpace(txtPayrollID.Text) Then
                MessageBox.Show("Please enter an Employee ID to generate payslip.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            OpenConnection()

            ' 1. Load latest payroll record for the employee
            Dim query As String = "
            SELECT p.*, e.first_name, e.last_name 
            FROM payroll p 
            INNER JOIN employees e ON p.employee_id = e.employee_id 
            WHERE p.employee_id = @EmployeeID 
            ORDER BY p.date_generated DESC 
            LIMIT 1"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EmployeeID", txtPayrollID.Text.Trim())
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtPayrollID.Text = reader("employee_id").ToString()
                        txtPeriodS.Text = Convert.ToDateTime(reader("period_start")).ToShortDateString()
                        txtPeriodEnd.Text = Convert.ToDateTime(reader("period_end")).ToShortDateString()
                        txtBasicPay.Text = reader("basic_pay").ToString()
                        txtOTPay.Text = reader("overtime_pay").ToString()
                        txtAbsences.Text = reader("absences").ToString()
                        txtSSS.Text = reader("sss").ToString()
                        txtPhilHealth.Text = reader("philhealth").ToString()
                        txtPagIbig.Text = reader("pagibig").ToString()
                        txtGrossPay.Text = reader("gross_pay").ToString()
                        txtNetPay.Text = reader("net_pay").ToString()
                        txtDateGenerated.Text = Convert.ToDateTime(reader("date_generated")).ToString("f")

                        ' Optional: Display full name if textbox exists
                        If txtFullName IsNot Nothing Then
                            txtFullName.Text = reader("first_name").ToString() & " " & reader("last_name").ToString()
                        End If
                    Else
                        MessageBox.Show("No payroll record found for this employee.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

            ' 2. Load payroll history into DataGridView
            Dim historyQuery As String = "
            SELECT payroll_id, period_start, period_end, gross_pay, net_pay, date_generated 
            FROM payroll 
            WHERE employee_id = @EmployeeID 
            ORDER BY date_generated DESC"

            Using historyCmd As New MySqlCommand(historyQuery, conn)
                historyCmd.Parameters.AddWithValue("@EmployeeID", txtPayrollID.Text.Trim())
                Using adapter As New MySqlDataAdapter(historyCmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dtgv.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error while generating payslip: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub


    Private Sub btnDL_Click_1(sender As Object, e As EventArgs) Handles btnDL.Click
        Try
            ' File Save Dialog Setup
            Dim sfd As New SaveFileDialog()
            sfd.Title = "Download Payslip"
            sfd.Filter = "Text Files (*.txt)|*.txt"
            sfd.FileName = $"Payslip_{txtPayrollID.Text}_{DateTime.Now:yyyyMMdd_HHmmss}.txt"

            If sfd.ShowDialog() = DialogResult.OK Then
                Using writer As New StreamWriter(sfd.FileName)
                    writer.WriteLine("========= EMPLOYEE PAYSLIP =========")
                    writer.WriteLine("Date Generated : " & txtDateGenerated.Text)
                    writer.WriteLine("------------------------------------")
                    writer.WriteLine("Employee ID    : " & txtPayrollID.Text)
                    writer.WriteLine("Full Name      : " & txtFullName.Text)
                    writer.WriteLine("Pay Period     : " & txtPeriodS.Text & " to " & txtPeriodEnd.Text)
                    writer.WriteLine()
                    writer.WriteLine("Basic Pay      : PHP " & txtBasicPay.Text)
                    writer.WriteLine("Overtime Pay   : PHP " & txtOTPay.Text)
                    writer.WriteLine("Absences       : " & txtAbsences.Text & " day(s)")
                    writer.WriteLine()
                    writer.WriteLine("DEDUCTIONS")
                    writer.WriteLine(" - SSS         : PHP " & txtSSS.Text)
                    writer.WriteLine(" - PhilHealth  : PHP " & txtPhilHealth.Text)
                    writer.WriteLine(" - Pag-IBIG    : PHP " & txtPagIbig.Text)
                    writer.WriteLine()
                    writer.WriteLine("Gross Pay      : PHP " & txtGrossPay.Text)
                    writer.WriteLine("Net Pay        : PHP " & txtNetPay.Text)
                    writer.WriteLine("====================================")
                End Using

                MessageBox.Show("Payslip downloaded successfully!", "Payslip Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error exporting payslip: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class