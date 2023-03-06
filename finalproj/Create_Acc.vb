Imports Google.Protobuf.Reflection.FieldOptions.Types

Public Class Create_Acc
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
        Login.Show()
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
        Manage_User.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        Dim fname, lname, user, pass, type As String
        Dim t, uid As Integer
        uid = txtUID.Text
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
        'If cmbtype.Text = 1 Then
        '    cmbtype.Text = "Admin"
        'ElseIf cmbtype.Text = 2 Then
        '    cmbtype.Text = "Warehouse Manager"
        'End If
        type = cmbtype.Text
        Update_User(user, pass, fname, lname, t, uid)
        Manage_User.Show()
        txtfname.Clear()
        txtlname.Clear()
        txtpass.Clear()
        txtuser.Clear()
        cmbtype.SelectedIndex = -1
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub
End Class