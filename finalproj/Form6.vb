Public Class Form6
    Private Sub btnmanage_Click(sender As Object, e As EventArgs) Handles btnmanage.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQL_Open_Connection()
        Display_All()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.txtuser.Clear()
        Form1.txtpass.Clear()
        Form1.Show()
        Me.Close()
        MessageBox.Show("Logged Out Successfully!")

    End Sub

    Private Sub btnrep_Click(sender As Object, e As EventArgs) Handles btnrep.Click
        Form7.Show()
        Me.Hide()
    End Sub
End Class