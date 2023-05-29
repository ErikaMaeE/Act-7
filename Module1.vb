Imports MySql.Data.MySqlClient

Module Module1
    Public myconn As New MySqlConnection
    Public myConnectionString As String
    Public strSQL As String
    Public conn As MySqlConnection = New MySqlConnection
    Public sql As String
    Public dr As MySqlDataReader
    Public ds As New DataSet
    Public cmd As MySqlCommand = New MySqlCommand


    Public Sub Connect_to_DB()
        myConnectionString = "server=localhost;uid=root;pwd=ErikaMae_0817;database=record_db"
        Try
            myconn.ConnectionString = myConnectionString
            myconn.Open()

        Catch ex As MySqlException
            Select Case ex.Number
                Case 0
                    MsgBox("Cannot Connect to Server")
                Case 1045
                    MsgBox("Invalid Username or password!")
            End Select

        End Try
    End Sub

    Public Sub Disconnect_to_DB()
        myconn.Close()
        myconn.Dispose()
    End Sub
    Public Sub connect()


        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        conn.Open()
        dr = cmd.ExecuteReader
    End Sub



End Module


