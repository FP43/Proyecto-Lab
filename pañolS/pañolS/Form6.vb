Public Class Form6
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
        If CheckBox1.Checked = True Then
            TextBox3.UseSystemPasswordChar = False
        Else
            TextBox3.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox4.Text = "" Then
            Msg3.Show()

        Else

            If TextBox2.Text = TextBox3.Text Then
                My.Settings.Usuario = TextBox1.Text
                My.Settings.Save()
                My.Settings.Reload()

                My.Settings.Email = TextBox4.Text
                My.Settings.Save()
                My.Settings.Reload()

                My.Settings.Clave = TextBox3.Text
                My.Settings.Save()
                My.Settings.Reload()

                Msg4.Show()



            Else
                Msg5.Show()


            End If
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Parent = PictureBox1
        Label5.BackColor = Color.Transparent
        Label6.Parent = PictureBox1
        Label6.BackColor = Color.Transparent
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class