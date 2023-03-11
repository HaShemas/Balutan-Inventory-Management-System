Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Signers

Public Class Create_Prod
    Dim dataSet As DataSet
    Dim mysqlAdapter As MySqlDataAdapter
    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim pname, cat, intype, stats, des, sku As String
        Dim sprice, cost As Double
        Dim usid As Integer
        des = txtdes.Text
        sku = txtsku.Text
        cost = txtcost.Text
        pname = txtpname.Text
        sprice = txtsprice.Text
        cat = cmbcat.SelectedItem
        intype = cmbintype.SelectedItem
        stats = cmbstat.SelectedItem
        usid = txtusID.Text
        Insert_Data(pname, des, sku, sprice, cost, cat, intype, stats, usid)

        Product.Show()
        Me.Hide()
        txtdes.Clear()
        txtsku.Clear()
        txtcost.Clear()
        txtpname.Clear()
        txtsprice.Clear()
        cmbcat.SelectedIndex = -1
        cmbintype.SelectedIndex = -1
        cmbstat.SelectedIndex = -1
        Product.dgvRecords.AllowUserToAddRows = False
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Product.Show()
        Me.Close()
    End Sub

    Private Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        Dim pname, cat, intype, stats, sku, des As String
        Dim sprice, cost As Double
        Dim pid As Integer
        des = txtdes.Text
        sku = txtsku.Text
        cost = txtcost.Text
        pid = txtpID.Text
        pname = txtpname.Text
        sprice = txtsprice.Text
        cat = cmbcat.SelectedItem
        intype = cmbintype.SelectedItem
        stats = cmbstat.SelectedItem

        Update_Data(pname, des, sku, sprice, cost, cat, intype, stats, pid)
        Product.Show()
        Me.Close()
        Product.dgvRecords.AllowUserToAddRows = False
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class