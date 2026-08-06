Imports BCrypt.Net
Imports MySql.Data.MySqlClient

Public Class Form1

    ' Shared instances
    Public Shared EmployeePanelInstance As New EmployeePanel()
    Public Shared EmployeePaySlipInstance As New EmployeePaySlip()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial state of floating labels
        lblUsernameFloating.Visible = True
        lblPassword.Visible = True

        ' Hide password by default
        txtPassword.UseSystemPasswordChar = True
    End Sub

    '===========================
    ' LOGIN BUTTON
    '===========================
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' Simple validation
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter both username and password.", "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=payrolldb")
            conn.Open()

            If CheckLogin("users", username, password, conn) Then Exit Sub
            If CheckLogin("employees", username, password, conn) Then Exit Sub

            MessageBox.Show("Username not found.", "Access Denied",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Using

    End Sub

    '===========================
    ' LOGIN CHECK FUNCTION
    '===========================
    Private Function CheckLogin(table As String, username As String, password As String, conn As MySqlConnection) As Boolean
        Dim query As String = $"SELECT username, password, role FROM {table} WHERE username=@user LIMIT 1"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", username)
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim dbPass As String = dr("password").ToString()
                    Dim role As String = dr("role").ToString().ToLower()
                    dr.Close()

                    Dim loginSuccess As Boolean = If(dbPass.StartsWith("$2"), BCrypt.Net.BCrypt.Verify(password, dbPass), dbPass = password)

                    If loginSuccess Then
                        Select Case role
                            Case "admin" : Admin.Show()
                            Case "staff" : StaffDashboard.Show()
                            Case "employee"
                                Dim empPanel As New EmployeePanel()
                                empPanel.LoggedInUsername = username
                                empPanel.Show()
                            Case Else
                                MessageBox.Show("Unknown role detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return True
                        End Select

                        Me.Hide()
                        Return True
                    Else
                        MessageBox.Show("Invalid password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    End If
                End If
            End Using
        End Using
        Return False
    End Function

    '===========================
    ' CANCEL BUTTON
    '===========================
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    '===========================
    ' SHOW/HIDE PASSWORD
    '===========================
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    '===========================
    ' FLOATING LABEL EFFECT
    '===========================

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        lblUsernameFloating.Visible = txtUsername.Text = ""
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        lblPassword.Visible = txtPassword.Text = ""
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        lblUsernameFloating.ForeColor = Color.Blue
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        lblUsernameFloating.ForeColor = Color.Gray
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        lblPassword.ForeColor = Color.Blue
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        lblPassword.ForeColor = Color.Gray
    End Sub

End Class
