Imports MySql.Data.MySqlClient

Module Module1


    Dim mysqlAdapter As MySqlDataAdapter

    Dim dataSet As DataSet
    Dim command As MySqlCommand

    Dim table As New DataTable()



    Public mysqlConn As New MySqlConnection("Server=localhost;

                       Port=3306;

                       Database=balutan;

                       user=root;")




    Public Sub MySQL_Open_Connection()

        Try

            If mysqlConn.State = ConnectionState.Closed Then

                mysqlConn.Open()

                MessageBox.Show("Connected")

            End If

        Catch ex As MySqlException

            MessageBox.Show("Error: " & ex.Message)


        End Try

    End Sub




    Public Sub MySQL_Close_Connection()

        Try

            If mysqlConn.State = ConnectionState.Open Then

                mysqlConn.Close()

            End If

        Catch ex As MySqlException

            MessageBox.Show("Error: " & ex.Message)


        End Try

    End Sub

    Public Sub Login(ByVal user As String, ByVal pass As String)

        Try

            MySQL_Open_Connection()

            Dim table As New DataTable()

            mysqlAdapter = New MySqlDataAdapter("SELECT  `username`, `password` FROM user_tbl WHERE username='" & user & "' AND password='" & pass & "'", mysqlConn)

            'mysqlAdapter2 = New MySqlDataAdapter("SELECT user_tbl.user_id, product_tbl.product_id,product_tbl.pname,product_tbl.price,product_tbl.category,product_tbl.type,product_tbl.status,product_tbl.user_id FROM user_tbl INNER JOIN product_tbl ON user_tbl.user_id = product_tbl.user_id WHERE user_tbl.username='" & user & "' AND status='Active'", mysqlConn)
            'mysqlAdapter2.Fill(dataSet, "user_table")
            mysqlAdapter.Fill(table)

            If table.Rows.Count = 0 Then
                MessageBox.Show("Invalid username or password!")
            Else
                MessageBox.Show("Logged In Successfully!")
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub Insert_User(ByVal fname As String, ByVal lname As String, ByVal user As String, ByVal pass As String, ByVal cbtype As Integer)

        Try

            MySQL_Open_Connection()

            dataSet = New DataSet

            mysqlAdapter = New MySqlDataAdapter("INSERT INTO user_tbl VALUES (null,'" & fname & "', '" & lname & "', '" & user & "', '" & pass & "', " & cbtype & ")", mysqlConn)

            mysqlAdapter.Fill(dataSet, "user_tbl")

            MessageBox.Show("Inserted")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub Insert_Data(ByVal pname As String, ByVal sprice As Double, ByVal cat As String, ByVal intype As String, ByVal stats As String, ByVal usid As String)

        Try

            MySQL_Open_Connection()

            dataSet = New DataSet

            mysqlAdapter = New MySqlDataAdapter("INSERT INTO product_tbl VALUES (null,'" & pname & "', " & sprice & ", '" & cat & "', '" & intype & "', '" & stats & "', '" & usid & "' )", mysqlConn)
            Dim rowIndex As Integer


            mysqlAdapter.Fill(dataSet, "product_tbl")

            MessageBox.Show("Inserted")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub Update_Data(ByVal pname As String, ByVal sprice As Double, ByVal cat As String, ByVal intype As String, ByVal stats As String, ByVal pid As Integer)

        Try

            MySQL_Open_Connection()

            dataSet = New DataSet

            mysqlAdapter = New MySqlDataAdapter("UPDATE product_tbl SET pname='" & pname & "', price=" & sprice & ", category='" & cat & "', type='" & intype & "', status='" & stats & "' WHERE product_id=" & pid & "", mysqlConn)

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

            'dataSet = New DataSet

            ''mysqlAdapter = New MySqlDataAdapter("SELECT * FROM `product_tbl` WHERE status = 'Active'", mysqlConn)

            ''mysqlAdapter = New MySqlDataAdapter("SELECT product_tbl.product_id,product_tbl.pname,product_tbl.price,product_tbl.category,product_tbl.type,product_tbl.status, product_tbl.user_id FROM product_tbl INNER JOIN user_tbl ON user_tbl.user_id = product_tbl.user_id WHERE user_tbl.username='" & user & "' AND user_tbl.password='" & pass & "' AND status='Active'", mysqlConn)

            'mysqlAdapter.Fill(dataSet, "product_tbl")

            '' MessageBox.Show("Inserted")


            'Form4.dgvRecords.DataSource = dataSet.Tables(0)
            Dim username, password As String
            username = Form1.txtuser.Text
            password = Form1.txtpass.Text
            command = New MySqlCommand("SELECT product_tbl.product_id,product_tbl.pname,product_tbl.price,
            product_tbl.category,product_tbl.type,product_tbl.status, product_tbl.user_id FROM product_tbl INNER JOIN
            user_tbl ON product_tbl.user_id = user_tbl.user_id WHERE user_tbl.username=@username AND 
            user_tbl.password=@password AND status='Active'", mysqlConn)

            command.Parameters.AddWithValue("@username", username) ' Replace with actual username
            command.Parameters.AddWithValue("@password", password) ' Replace with actual password
            mysqlAdapter = New MySqlDataAdapter(command)
            mysqlAdapter.Fill(table)

            Form4.dgvRecords.DataSource = table
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
End Module


