Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=test"

        Try
            conn.Open()
            'MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING      CONNECTION TO MySQL DATABASE")
            Dim query = "SELECT * FROM student"

            ' Create a MySqlCommand object with the query and connection
            Dim command As New MySqlCommand(query, conn)

            ' Execute the query and get a MySqlDataReader
            Dim reader = command.ExecuteReader

            ' Iterate through the rows and retrieve data
            While reader.Read
                ' Example: Retrieve data from columns "column1" and "column2"
                Dim column1Value = reader.GetInt32("id")
                Dim column2Value = reader.GetString("name")

                ' Do something with the retrieved data, such as displaying it
                MessageBox.Show($"Column1: {column1Value}, Column2: {column2Value}")
            End While

            ' Close the reader
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub InsertData()
        ' Connection string to your MySQL database
        Dim connectionString As String = "server=localhost;userid=root;password='';database='test'"

        ' Create a MySqlConnection object
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the connection
            connection.Open()

            ' SQL INSERT statement
            Dim query As String = "INSERT INTO student (id, name) VALUES (@value1, @value2)"

            ' Create a MySqlCommand object with the query and connection
            Dim command As New MySqlCommand(query, connection)

            ' Add parameters to the command (assuming column1 and column2 are string and integer, respectively)
            command.Parameters.AddWithValue("@value1", txtId.Text)
            command.Parameters.AddWithValue("@value2", txtName.Text)

            ' Execute the INSERT statement
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            ' Check if the insertion was successful
            If rowsAffected > 0 Then
                MessageBox.Show("Data inserted successfully!")
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InsertData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        addStaff.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddGradings.Show()
    End Sub
End Class
