Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfmname.Text = Form1.txtuser.Text
        txtdate.Text = Date.Now.ToString("MMM/dd/yyyy")
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnproduct_Click(sender As Object, e As EventArgs) Handles btnproduct.Click
        Form4.Show()
        Me.Close()
    End Sub
End Class