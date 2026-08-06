Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class EmployeePaySlip

    ' Make sure these match your textbox names on the form
    ' txtEmployeeID, txtEmployeeName, txtDateGenerated, txtBasicPay, txtOTPay, txtGrossPay, txtNetPay

    Public LoggedInEmployeeID As Integer ' <-- You should set this on login
    Public Property EmployeePanelRef As EmployeePanel

    Public Sub ViewLatestPayslip()
        Try
            OpenConnection()

            ' Fetch employee full name
            Dim cmd As New MySqlCommand("SELECT first_name, last_name FROM employees WHERE employee_id = @empID", conn)
            cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
            Dim reader = cmd.ExecuteReader()
            If reader.Read() Then
                txtPayrollID.Text = LoggedInEmployeeID.ToString()
                txtFullName.Text = reader("first_name") & " " & reader("last_name")
            End If
            reader.Close()

            ' Fetch latest payroll
            cmd = New MySqlCommand("SELECT * FROM payroll WHERE employee_id = @empID ORDER BY date_generated DESC LIMIT 1", conn)
            cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
            reader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Load payroll fields
                Dim periodStart As Date = Convert.ToDateTime(reader("period_start"))
                Dim periodEnd As Date = Convert.ToDateTime(reader("period_end"))
                Dim basicPay As Decimal = Convert.ToDecimal(reader("basic_pay"))
                Dim otPay As Decimal = Convert.ToDecimal(reader("overtime_pay"))
                Dim netPay As Decimal = Convert.ToDecimal(reader("net_pay"))

                txtDateGenerated.Text = Convert.ToDateTime(reader("date_generated")).ToString("MMMM dd, yyyy")
                txtBasicPay.Text = "₱" & basicPay.ToString("N2")
                txtOTPay.Text = "₱" & otPay.ToString("N2")
                txtNetPay.Text = "₱" & netPay.ToString("N2")
                txtPeriodS.Text = periodStart.ToString("MMMM dd, yyyy")
                txtPeriodEnd.Text = periodEnd.ToString("MMMM dd, yyyy")

                reader.Close() ' Close before new query

                ' Calculate working days in period (Mon–Fri only)
                Dim totalWorkingDays As Integer = 0
                Dim currentDate As Date = periodStart
                While currentDate <= periodEnd
                    If currentDate.DayOfWeek >= DayOfWeek.Monday AndAlso currentDate.DayOfWeek <= DayOfWeek.Friday Then
                        totalWorkingDays += 1
                    End If
                    currentDate = currentDate.AddDays(1)
                End While

                ' Count actual present days
                cmd = New MySqlCommand("SELECT COUNT(DISTINCT date) FROM time_logs WHERE employee_id = @empID AND date BETWEEN @start AND @end", conn)
                cmd.Parameters.AddWithValue("@empID", LoggedInEmployeeID)
                cmd.Parameters.AddWithValue("@start", periodStart)
                cmd.Parameters.AddWithValue("@end", periodEnd)
                Dim presentDays As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                Dim absentDays As Integer = totalWorkingDays - presentDays
                If absentDays < 0 Then absentDays = 0

                ' Static deduction values
                Dim sss = 500D
                Dim phil = 350D
                Dim pagibig = 200D

                Dim gross = basicPay + otPay
                Dim totalGovDeductions = sss + phil + pagibig
                Dim absenceDeduction = gross - netPay - totalGovDeductions
                If absenceDeduction < 0 Then absenceDeduction = 0

                ' Set textboxes
                txtGrossPay.Text = "₱" & gross.ToString("N2")
                txtSSS.Text = "₱" & sss.ToString("N2")
                txtPhilHealth.Text = "₱" & phil.ToString("N2")
                txtPagIbig.Text = "₱" & pagibig.ToString("N2")
                txtAbsences.Text = absentDays.ToString() & " day(s)" ' ✔ CORRECT DISPLAY
            Else
                MessageBox.Show("No payslip found.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EmployeePanelRef.Show()
        Me.Hide()
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
