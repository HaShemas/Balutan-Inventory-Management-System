Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx

Module Module1


    Dim mysqlAdapter As MySqlDataAdapter

    Dim dataSet As DataSet
    Dim command As MySqlCommand

    Dim table As New DataTable()



    Public mysqlConn As New MySqlConnection("Server=localhost;

                       Port=3306;

                       Database=balutan2;

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
            'Dim query As String = "SELECT  `username`, `password` FROM user_tbl WHERE username=@username AND password=@password"
            'Dim cmd As New MySqlCommand(query, mysqlConn)
            'cmd.Parameters.AddWithValue("@username", user)
            'cmd.Parameters.AddWithValue("@password", pass)

            'Dim reader As MySqlDataReader = cmd.ExecuteReader()
            'If reader.HasRows AndAlso reader.Read() Then
            '    ' The query returned at least one row, so the user's account exists
            '    MessageBox.Show("Login successful!")
            '    Form3.Show()
            '    Form1.Hide()
            '    ' Proceed with authenticating the user
            'Else
            '    ' The query did not return any rows, so the user's account does not exist
            '    MessageBox.Show("Invalid username or password.")
            'End If
            Dim table As New DataTable()

            mysqlAdapter = New MySqlDataAdapter("SELECT  `username`, `password` FROM user_tbl WHERE username='" & user & "' AND password='" & pass & "'", mysqlConn)

            'mysqlAdapter2 = New MySqlDataAdapter("SELECT user_tbl.user_id, product_tbl.product_id,product_tbl.pname,product_tbl.price,product_tbl.category,product_tbl.type,product_tbl.status,product_tbl.user_id FROM user_tbl INNER JOIN product_tbl ON user_tbl.user_id = product_tbl.user_id WHERE user_tbl.username='" & user & "' AND status='Active'", mysqlConn)
            'mysqlAdapter2.Fill(dataSet, "user_table")
            mysqlAdapter.Fill(table)

            If table.Rows.Count = 0 Then
                MessageBox.Show("Invalid username or password!")
                Form1.txtuser.Clear()
                Form1.txtpass.Clear()
            Else
                MessageBox.Show("Logged In Successfully!")
                Form3.Show()
                Form1.Hide()
            End If
            'reader.Close()
            MySQL_Close_Connection()
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub Insert_User(ByVal fname As String, ByVal lname As String, ByVal user As String, ByVal pass As String, ByVal cbtype As Integer)

        Try

            MySQL_Open_Connection()

            dataSet = New DataSet

            mysqlAdapter = New MySqlDataAdapter("INSERT INTO user_tbl VALUES (null,'" & user & "', '" & pass & "', '" & fname & "', '" & lname & "', " & cbtype & ")", mysqlConn)

            mysqlAdapter.Fill(dataSet, "user_tbl")

            MessageBox.Show("Inserted")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
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
    Public Sub Dispay_User()
        Dim username As String
        username = Form1.txtuser.Text
        Dim query As String = "SELECT `user_id`,`username`,`fname`,`lname` FROM `user_tbl` WHERE username='" & username & "'"
        Dim command As New MySqlCommand(query, mysqlConn)
        Dim reader As MySqlDataReader = command.ExecuteReader()

        ' If the query returns data, assign it to the label control
        If reader.HasRows AndAlso reader.Read() Then
            Dim userId As Integer = reader.GetInt32(0)
            Form5.txtusID.Text = userId.ToString()
            'Form3.lblID.Text = Form5.txtusID.Text
            Form3.lblID.Text = reader.GetInt16("user_id")
            Form3.lbluser.Text = reader.GetString("username")
            Form3.lblfname.Text = reader.GetString("fname")
            Form3.lbllname.Text = reader.GetString("lname")

        End If

        ' Close the connection and dispose of any resources used
        reader.Close()
        command.Dispose()
        MySQL_Close_Connection()
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


