Public Class Form7
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim cat As String
        cat = cmbCat.SelectedItem
        Display_Cat(cat)
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQL_Open_Connection()

    End Sub

    Private Sub btnbk_Click(sender As Object, e As EventArgs) Handles btnbk.Click
        Form6.Show()
        Me.Close()
    End Sub
End Class