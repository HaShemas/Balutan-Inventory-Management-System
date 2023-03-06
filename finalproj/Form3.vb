Imports Org.BouncyCastle.Asn1.Cms

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQL_Open_Connection()
        lbluser.Text = Form1.txtuser.Text
        txtdate.Text = Date.Now.ToString("MMM/dd/yyyy")
        txtTime.Text = DateTime.Now.ToLongTimeString()
        Dispay_User()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Form1.Show()
        Me.Close()
        MessageBox.Show("Logged Out Successfully!")
    End Sub

    Private Sub btnproduct_Click(sender As Object, e As EventArgs) Handles btnproduct.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub btnmacc_Click(sender As Object, e As EventArgs) Handles btnmacc.Click

    End Sub
End Class