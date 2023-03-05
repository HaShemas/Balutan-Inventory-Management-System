

Public Class Form4

    Public Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Form5.Show()
        Me.Close()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Form5.Show()
        Me.Close()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySQL_Open_Connection()
        Display_Data()

    End Sub

    Private Sub dgvRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellClick
        Dim rowIndex As Integer
        rowIndex = dgvRecords.CurrentRow.Index
        Form5.txtpID.Text = dgvRecords.Rows(rowIndex).Cells(0).Value
        Form5.txtpname.Text = dgvRecords.Rows(rowIndex).Cells(1).Value
        Form5.txtsprice.Text = dgvRecords.Rows(rowIndex).Cells(2).Value
        Form5.cmbcat.SelectedItem = dgvRecords.Rows(rowIndex).Cells(3).Value
        Form5.cmbintype.SelectedItem = dgvRecords.Rows(rowIndex).Cells(4).Value
        Form5.cmbstat.SelectedItem = dgvRecords.Rows(rowIndex).Cells(5).Value
        Form5.txtusID.Text = dgvRecords.Rows(rowIndex).Cells(6).Value

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer

        id = Form5.txtpID.Text
        Delete_Data(id)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim id As Integer
        id = txtsID.Text
        Display_Search(id)
    End Sub
End Class