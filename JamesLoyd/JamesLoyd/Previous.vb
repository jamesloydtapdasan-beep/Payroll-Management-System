Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class frmPayslipHistory

    ' Property to receive EmployeeID from EmployeePanel
    Public Property EmployeeID As String

    ' DB connection string
    Private connString As String = "server=localhost;user id=root;password=;database=payrolldb;"

    ' =========================
    ' FORM LOAD
    ' =========================
    Private Sub frmPayslipHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(EmployeeID) Then
            MessageBox.Show("No Employee ID provided for payslip history.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        End If

        LoadPayslipHistory(EmployeeID)
    End Sub

    ' =========================
    ' LOAD PAYSLIP HISTORY
    ' =========================
    Private Sub LoadPayslipHistory(empID As String)
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Dim query As String = "
                    SELECT payroll_id AS 'Payroll ID',
                           period_start AS 'Period Start',
                           period_end AS 'Period End',
                           gross_pay AS 'Gross Pay',
                           net_pay AS 'Net Pay',
                           date_generated AS 'Date Generated'
                    FROM payroll
                    WHERE employee_id = @EmployeeID
                    ORDER BY date_generated DESC
                "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EmployeeID", empID)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)

                        dgvPayslipHistory.DataSource = dt

                        ' Setup DataGridView formatting
                        With dgvPayslipHistory
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .AllowUserToResizeRows = False
                            .AllowUserToResizeColumns = False
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersVisible = False
                            .MultiSelect = False
                            .DefaultCellStyle.WrapMode = DataGridViewTriState.True

                            ' Hide Payroll ID column
                            If .Columns.Contains("Payroll ID") Then
                                .Columns("Payroll ID").Visible = False
                            End If

                            ' Format currency columns
                            If .Columns.Contains("Gross Pay") Then
                                .Columns("Gross Pay").DefaultCellStyle.Format = "C2"
                                .Columns("Gross Pay").DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-PH")
                            End If
                            If .Columns.Contains("Net Pay") Then
                                .Columns("Net Pay").DefaultCellStyle.Format = "C2"
                                .Columns("Net Pay").DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-PH")
                            End If

                            .Refresh()
                        End With
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading payslip history: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================
    ' BACK BUTTON
    ' =========================
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ' Show EmployeePanel again
        If Application.OpenForms.OfType(Of EmployeePanel)().Any() Then
            Application.OpenForms.OfType(Of EmployeePanel)().First().Show()
        End If
    End Sub

End Class
