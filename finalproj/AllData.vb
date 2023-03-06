Public Class AllData
    Private Sub btnmanage_Click(sender As Object, e As EventArgs) Handles btnmanage.Click
        Product.Show()
        Me.Close()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQL_Open_Connection()
        Display_All()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.txtuser.Clear()
        Login.txtpass.Clear()
        Login.Show()
        Me.Close()
        MessageBox.Show("Logged Out Successfully!")

    End Sub

    Private Sub btnrep_Click(sender As Object, e As EventArgs) Handles btnrep.Click
        Report.Show()
        Me.Hide()
    End Sub
End Class