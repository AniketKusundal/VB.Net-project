Imports System.Data.OleDb
Public Class Form3

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form6.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        'Dim cn As New OleDb.OleDbConnection
        'Dim cn As New OleDb.OleDbCommand
        'Dim SqlQry As String
        'cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dell\Desktop\Database\cafemanegment1.accdb"
        'Dim E-mail, Password as String 
        'Password = TextBox2.Text

        'Try
        '    cn.Open()

        '    SqlQry = " INSERT INTO loagin (e-mail,password) VALUSE(@a,@b)"
        '    cmd.Connection = cn
        '    cmd.CommandText = SqlQry
        '    cmd.Parameters.AddWithValue("@a", e - mail)
        '    cmd.Parameters.AddWithValue("@b", password)

        '    cmd.ExecuteNonQuery()

        '    MsgBox("WELCOME")
        '    TextBox1.Text = " "
        '    TextBox2.Text = " "
        'Catch ex As Exception

        'End Try




        'Form4.Show()
        cn.Open()
        Dim rs As String
        rs = " select  * from singin where e_mail = '" & TextBox1.Text & "'"
        Dim cmd As New OleDbCommand(rs, cn)
        Dim rd As OleDbDataReader
        rd = cmd.ExecuteReader

        If rd.Read() Then
            If TextBox2.Text = rd(6) Then
                MsgBox(" Welcome")

            Else
                MsgBox("Invalid Password ")
                TextBox2.Text = ""
                TextBox2.Focus()

            End If
        Else
            MsgBox("Invalid Username")
            TextBox2.Text = ""
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
        cn.Close()
        Form6.Show()
    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class