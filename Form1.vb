Imports System.Data.OleDb

Public Class Form1
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=system.accdb")

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM admin WHERE email = ? AND password = ?", conn)
            cmd.Parameters.AddWithValue("?", txt_email.Text)
            cmd.Parameters.AddWithValue("?", txt_password.Text)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                main_form.currentUserEmail = reader("email").ToString()

                main_form.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Private Sub LabelLinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub
End Class
