﻿
Imports MySql.Data.MySqlClient

Module Module2
    Dim mysqlAdapter As MySqlDataAdapter

    Dim dataSet As DataSet
    Dim command As MySqlCommand

    Dim table As New DataTable()




    Public Sub Insert_Data(ByVal pname As String, ByVal des As String, ByVal sku As String, ByVal sprice As Double, ByVal cost As Double, ByVal cat As String, ByVal intype As String, ByVal stats As String, ByVal usid As Integer)

        Try

            MySQL_Open_Connection()

            dataSet = New DataSet

            mysqlAdapter = New MySqlDataAdapter("INSERT INTO product_tbl VALUES (null,'" & pname & "', '" & des & "', '" & sku & "', " & sprice & ", " & cost & ", '" & cat & "', '" & intype & "', '" & stats & "', " & usid & " )", mysqlConn)



            mysqlAdapter.Fill(dataSet, "product_tbl")

            MessageBox.Show("Inserted")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub Update_Data(ByVal pname As String, ByVal des As String, ByVal sku As String, ByVal sprice As Double, ByVal cost As Double, ByVal cat As String, ByVal intype As String, ByVal stats As String, ByVal usid As Integer)

        Try

            MySQL_Open_Connection()

            dataSet = New DataSet

            mysqlAdapter = New MySqlDataAdapter("UPDATE product_tbl SET pname='" & pname & "',des='" & des & "',des='" & sku & "', price=" & sprice & ",cost=" & cost & ", category='" & cat & "', type='" & intype & "', status='" & stats & "' WHERE product_id=" & usid & "", mysqlConn)

            mysqlAdapter.Fill(dataSet, "product_tbl")

            MessageBox.Show("Updated")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub Delete_Data(ByVal id As Integer)

        Try

            MySQL_Open_Connection()

            dataSet = New DataSet

            mysqlAdapter = New MySqlDataAdapter("UPDATE product_tbl SET status = 'Inactive' WHERE product_id=" & id & "", mysqlConn)

            mysqlAdapter.Fill(dataSet, "product_tbl")

            MessageBox.Show("Deleted")
            Display_Data()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub Display_Data()

        Try
            ''Login(user, pass)
            'MySQL_Open_Connection()

            dataSet = New DataSet

            ''mysqlAdapter = New MySqlDataAdapter("SELECT * FROM `product_tbl` WHERE status = 'Active'", mysqlConn)

            ''mysqlAdapter = New MySqlDataAdapter("SELECT product_tbl.product_id,product_tbl.pname,product_tbl.price,product_tbl.category,product_tbl.type,product_tbl.status, product_tbl.user_id FROM product_tbl INNER JOIN user_tbl ON user_tbl.user_id = product_tbl.user_id WHERE user_tbl.username='" & user & "' AND user_tbl.password='" & pass & "' AND status='Active'", mysqlConn)

            'mysqlAdapter.Fill(dataSet, "product_tbl")

            '' MessageBox.Show("Inserted")


            'Form4.dgvRecords.DataSource = dataSet.Tables(0)
            Dim username, password As String
            username = Form1.txtuser.Text
            password = Form1.txtpass.Text
            command = New MySqlCommand("SELECT product_tbl.product_id,product_tbl.pname,product_tbl.des,product_tbl.sku,product_tbl.price,product_tbl.cost,product_tbl.category,product_tbl.type,product_tbl.status,product_tbl.user_id FROM product_tbl INNER JOIN
            user_tbl ON product_tbl.user_id = user_tbl.user_id WHERE user_tbl.user_id = product_tbl.user_id AND user_tbl.username=@username AND 
            user_tbl.password=@password AND status='Active'", mysqlConn)

            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)
            mysqlAdapter = New MySqlDataAdapter(command)
            mysqlAdapter.Fill(dataSet, "product_tbl")

            Form4.dgvRecords.DataSource = dataSet.Tables(0)
            ' Display the results in the form


            ' Close the database connection and cleanup resources
            mysqlAdapter.Dispose()
            command.Dispose()
            MySQL_Close_Connection()
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub Display_Search(ByVal id As Integer)

        Try

            MySQL_Open_Connection()

            dataSet = New DataSet

            mysqlAdapter = New MySqlDataAdapter("SELECT * FROM `product_tbl` WHERE product_id =" & id & "", mysqlConn)

            mysqlAdapter.Fill(dataSet, "product_tbl")

            ' MessageBox.Show("Inserted")

            Form4.dgvRecords.DataSource = dataSet.Tables(0)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub Display_All()
        Try

            MySQL_Open_Connection()

            dataSet = New DataSet

            mysqlAdapter = New MySqlDataAdapter("SELECT product_tbl.*,user_tbl.username FROM `product_tbl` INNER JOIN user_tbl ON product_tbl.user_id = user_tbl.user_id ", mysqlConn)

            mysqlAdapter.Fill(dataSet, "product_tbl")

            ' MessageBox.Show("Inserted")

            Form6.dgvRecords2.DataSource = dataSet.Tables(0)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Sub Display_Cat(ByVal cat As String)
        Try

            MySQL_Open_Connection()

            dataSet = New DataSet

            mysqlAdapter = New MySqlDataAdapter("SELECT ``pname,`cost`,`price` FROM `product_tbl` WHERE category='" & cat & "'", mysqlConn)

            mysqlAdapter.Fill(dataSet, "product_tbl")

            ' MessageBox.Show("Inserted")

            Form7.dgvRecords3.DataSource = dataSet.Tables(0)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Module