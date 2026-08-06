Imports MySql.Data.MySqlClient

Module modConnection
    Public conn As New MySqlConnection("server=localhost; user id=root; password=; database=payrolldb")

    Public Sub OpenConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Module
