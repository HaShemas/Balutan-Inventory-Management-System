Imports System.Drawing.Imaging

Public Class Manage_User
    Private Sub Manage_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQL_Open_Connection()
        Display_AllUsers()
    End Sub

    Private Sub btnCreateacc_Click(sender As Object, e As EventArgs) Handles btnCreateacc.Click
        Create_Acc.btnupd.Visible = False
        Create_Acc.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdateacc_Click(sender As Object, e As EventArgs) Handles btnUpdateacc.Click
        Create_Acc.btncreate.Visible = False
        Create_Acc.txtuser.ReadOnly = True
        Create_Acc.Show()
        Me.Close()
    End Sub

    Private Sub dgvRecords4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords4.CellClick
        Dim rowIndex As Integer
        rowIndex = dgvRecords4.CurrentRow.Index
        Create_Acc.txtUID.Text = dgvRecords4.Rows(rowIndex).Cells(0).Value
        Create_Acc.txtuser.Text = dgvRecords4.Rows(rowIndex).Cells(1).Value
        Create_Acc.txtpass.Text = dgvRecords4.Rows(rowIndex).Cells(2).Value
        Create_Acc.txtfname.Text = dgvRecords4.Rows(rowIndex).Cells(3).Value
        Create_Acc.txtlname.Text = dgvRecords4.Rows(rowIndex).Cells(4).Value
        Create_Acc.cmbtype.Text = dgvRecords4.Rows(rowIndex).Cells(5).Value


    End Sub

    Private Sub btnDelacc_Click(sender As Object, e As EventArgs) Handles btnDelacc.Click
        Dim uid As Integer
        uid = Create_Acc.txtUID.Text
        Delete_User(uid)
    End Sub

    Private Sub btnbk_Click(sender As Object, e As EventArgs) Handles btnbk.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim id As Integer
        id = txtsID.Text
        Search_User(id)
    End Sub
End Class