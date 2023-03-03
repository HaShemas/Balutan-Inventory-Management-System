Public Class Form1
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim user, pass As String
        user = txtuser.Text
        pass = txtpass.Text
        txtpass.UseSystemPasswordChar = True
        Login(user, pass)
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Createlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Createlink.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub
End Class
