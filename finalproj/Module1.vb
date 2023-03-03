Imports MySql.Data.MySqlClient

Module Module1


    Dim mysqlAdapter As MySqlDataAdapter

    Dim dataSet As DataSet




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
End Module


