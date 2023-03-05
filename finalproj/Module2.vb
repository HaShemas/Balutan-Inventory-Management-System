
'Imports MySql.Data.MySqlClient

'Module Module2
'    Dim mysqlAdapter As MySqlDataAdapter

'    Dim dataSet As DataSet


'    Public mysqlConn As New MySqlConnection("Server=localhost;

'                       Port=3306;

'                       Database=balutan;

'                       user=root;")



'    Public Sub MySQL_Open_Connection()

'        Try

'            If mysqlConn.State = ConnectionState.Closed Then

'                mysqlConn.Open()

'                MessageBox.Show("Connected")

'            End If

'        Catch ex As MySqlException

'            MessageBox.Show("Error: " & ex.Message)


'        End Try

'    End Sub


'    Public Sub MySQL_Close_Connection()

'        Try

'            If mysqlConn.State = ConnectionState.Open Then

'                mysqlConn.Close()

'            End If

'        Catch ex As MySqlException

'            MessageBox.Show("Error: " & ex.Message)


'        End Try

'    End Sub

'    'Public Sub Insert_Data(ByVal fname As String, ByVal lname As String, ByVal user As String, ByVal pass As String, ByVal cbtype As Integer)

'    '    Try

'    '        MySQL_Open_Connection()

'    '        dataSet = New DataSet

'    '        mysqlAdapter = New MySqlDataAdapter("INSERT INTO user_tbl VALUES (null,'" & fname & "', '" & lname & "', '" & user & "', '" & pass & "', " & cbtype & ")", mysqlConn)

'    '        mysqlAdapter.Fill(dataSet, "user_tbl")

'    '        MessageBox.Show("Inserted")

'    '    Catch ex As Exception

'    '        MessageBox.Show(ex.Message)

'    '    End Try

'    'End Sub
'End Module
