Imports MySql.Data.MySqlClient

Public Class AddGradings
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub InsertData()
        ' Connection string to your MySQL database
        Dim connectionString As String = "server=localhost;userid=root;password='';database='awissawellaDB'"

        ' Create a MySqlConnection object
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the connection
            connection.Open()

            ' SQL INSERT statement
            Dim query As String = "INSERT INTO tea_grading (gradeName) VALUES (@gradeName)"

            ' Create a MySqlCommand object with the query and connection
            Dim command As New MySqlCommand(query, connection)

            ' Add parameters to the command (assuming column1 and column2 are string and integer, respectively)
            command.Parameters.AddWithValue("@gradeName", txtGName.Text)

            ' Execute the INSERT statement
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            ' Check if the insertion was successful
            If rowsAffected > 0 Then
                ' MessageBox.Show("Data inserted successfully!")
            Else
                MessageBox.Show("Data insertion failed!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally

            ' Close the connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub FetchGradingsData()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=awissawellaDB"

        Try
            conn.Open()
            'MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING      CONNECTION TO MySQL DATABASE")
            Dim query = "SELECT * FROM tea_grading"

            ' Create a MySqlCommand object with the query and connection
            Dim command As New MySqlCommand(query, conn)

            ' Execute the query and get a MySqlDataReader
            Dim dataTable As New DataTable()

            ' Execute the SELECT statement and fill the DataTable with the results
            Dim dataAdapter As New MySqlDataAdapter(command)
            dataAdapter.Fill(dataTable)

            ' Bind the DataTable to the DataGridView
            gradingsDataGrid.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InsertData()
        ClearAll()
        FetchGradingsData()
    End Sub

    Private Sub AddGradings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchGradingsData()
    End Sub
    Private Sub ClearAll()
        txtGName.Text = ""
    End Sub
End Class