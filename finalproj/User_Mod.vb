Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx

Module User_Mod


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

            MessageBox.Show("Created Successfully!")

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



End Module


