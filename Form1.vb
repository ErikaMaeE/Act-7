Imports System.Windows

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Server=localhost;User id=root;port=3306;password='ErikaMae_0817';Database=record_db;"


    End Sub
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        sql = "SELECT * FROM user WHERE username = '" & UserTxt.Text & "'AND password = '" & PassTxt.Text & "'"
        connect()


        If dr.Read Then
            MsgBox("Welcome " & UserTxt.Text, vbInformation)
            Form2.Show()
        Else
            MsgBox("Invalid username or password!", vbExclamation)
        End If


        conn.Close()
    End Sub
End Class