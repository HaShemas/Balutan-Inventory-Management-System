﻿Imports MySql.Data.MySqlClient

Public Class Form5
    Dim dataSet As DataSet
    Dim mysqlAdapter As MySqlDataAdapter
    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim pname, cat, intype, stats As String
        Dim sprice As Double
        Dim usid As Integer
        pname = txtpname.Text
        sprice = txtsprice.Text
        cat = cmbcat.SelectedItem
        intype = cmbintype.SelectedItem
        stats = cmbstat.SelectedItem
        usid = txtusID.Text
        Insert_Data(pname, sprice, cat, intype, stats, usid)

        Form4.Show()
        Me.Close()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        Dim pname, cat, intype, stats As String
        Dim sprice As Double
        Dim pid As Integer

        pid = txtpID.Text
        pname = txtpname.Text
        sprice = txtsprice.Text
        cat = cmbcat.SelectedItem
        intype = cmbintype.SelectedItem
        stats = cmbstat.SelectedItem

        Update_Data(pname, sprice, cat, intype, stats, pid)
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class