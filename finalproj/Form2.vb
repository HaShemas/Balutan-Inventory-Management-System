Public Class Form2
    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim fname, lname, user, pass As String
        Dim type As Integer
        fname = txtfname.Text
        lname = txtlname.Text
        user = txtuser.Text
        pass = txtpass.Text
        type = cmbtype.SelectedItem

        Insert_Data(fname, lname, user, pass, type)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub cmbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtype.SelectedIndexChanged
        Dim type As Integer
        type = cmbtype.SelectedItem

        If type = 1 Then
            txtType.Text = "Admin"
        ElseIf type = 2 Then
            txtType.Text = "Warehouse User"
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class