Imports Org.BouncyCastle.Asn1.Cms

Public Class Main
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQL_Open_Connection()
        lbluser.Text = Login.txtuser.Text
        txtdate.Text = Date.Now.ToString("MMM/dd/yyyy")
        txtTime.Text = DateTime.Now.ToLongTimeString()
        Dispay_User()
        If lblutype.Text = 1 Then
            btnmacc.Visible = True
            lblutype.Text = "Admin"
        ElseIf lblutype.Text = 2 Then
            btnmacc.Visible = False
            lblutype.Text = "Warehouse User"
        End If
        'If lbluser.Text = "Admin" Then
        '    btnmacc.Visible = True
        'ElseIf lbluser.Text = "Warehouse User" Then
        '    btnmacc.Visible = False
        'End If
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Login.txtuser.Clear()
        Login.txtpass.Clear()
        Login.Show()
        Me.Close()
        MessageBox.Show("Logged Out Successfully!")
    End Sub

    Private Sub btnproduct_Click(sender As Object, e As EventArgs) Handles btnproduct.Click
        AllData.Show()
        'AllData.dgvRecords2.ReadOnly = True
        'AllData.Show()
        AllData.dgvRecords2.AllowUserToAddRows = False
        Me.Close()
    End Sub

    Private Sub btnmacc_Click(sender As Object, e As EventArgs) Handles btnmacc.Click
        Manage_User.Show()
        Me.Close()
    End Sub
End Class