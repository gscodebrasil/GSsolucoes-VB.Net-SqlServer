Public Class Form1

    Private Clcifer As New Cifer

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        TextBox1.Text = Clcifer.Criptar(TextBox2.Text, Clcifer.senha)
    End Sub
End Class
