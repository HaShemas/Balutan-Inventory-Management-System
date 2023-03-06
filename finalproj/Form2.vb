Public Class Form2
    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim fname, lname, user, pass, type As String
        Dim t As Integer
        fname = txtfname.Text
        lname = txtlname.Text
        user = txtuser.Text
        pass = txtpass.Text
        type = cmbtype.SelectedItem
        If type = "Admin" Then
            type = 1
            t = type
        ElseIf type = "Warehouse User" Then
            type = 2
            t = type
        End If
        Insert_User(fname, lname, user, pass, t)
        Form1.Show()
        txtfname.Clear()
        txtlname.Clear()
        txtpass.Clear()
        txtuser.Clear()
        cmbtype.SelectedIndex = -1
        Me.Hide()
    End Sub

    'Private Sub cmbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtype.SelectedIndexChanged
    '    Dim type As String
    '    type = cmbtype.SelectedItem

    '    If type = "Admin" Then
    '        cmbtype.SelectedItem = 1
    '    ElseIf type = "Warehouse User" Then
    '        cmbtype.SelectedItem = 2
    '    End If
    'End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class