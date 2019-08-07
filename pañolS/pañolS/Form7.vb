Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label6.Parent = PictureBox1
        Label6.BackColor = Color.Transparent
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "1304" Then
            Form6.Show()
            Hide()
        Else
            Msg2.Show()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class