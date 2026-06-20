Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Form2
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=system.accdb")


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO admin ([email], [username], [password]) VALUES (?, ?, ?)", conn)
            cmd.Parameters.AddWithValue("?", su_email.Text)
            cmd.Parameters.AddWithValue("?", su_username.Text)
            cmd.Parameters.AddWithValue("?", su_password.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Account created successfully!")
            Me.Hide()
            Form1.Show()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Hide()
        Form1.Show()
    End Sub


    Private Sub Linklabel2_Click(sender As Object, e As EventArgs) Handles Linklabel2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub su_password_TextChanged(sender As Object, e As EventArgs) Handles su_password.TextChanged

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

    End Sub
End Class
