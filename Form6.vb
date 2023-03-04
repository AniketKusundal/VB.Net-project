Imports System.Data.OleDb
Public Class Form6

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        cn.Open()
        Try

       
        Dim rs As String
        rs = " insert into singin values ('" & TextBox1.Text & "','" & TextBox5.Text & "','" & TextBox2.Text & "'," & TextBox6.Text & ",'" & TextBox3.Text & "'," & TextBox7.Text & ",'" & TextBox4.Text & "','" & TextBox8.Text & "')"
        Dim cmd As New OleDbCommand(rs, cn)

        cmd.ExecuteNonQuery()

        MsgBox("ACCOUNT CREATED SUCCESSFULLY")
            cn.Close()
        Catch ex As Exception
            MsgBox("REQUIED FILEDS ARE EMPTY")

        End Try

        Form4.Show()
    End Sub
End Class