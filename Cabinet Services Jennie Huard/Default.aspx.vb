Imports MySql.Data.MySqlClient
Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TestConnection()
        Recherche()
    End Sub

    Public Sub TestConnection()
        Try
            Dim connStr As String = "Database=dompe;" & _
                    "Data Source=10.128.214.253;" & _
                    "User Id=math;Password=admin123"
            Dim connection As New MySqlConnection(connStr)
            connection.Open()
            connection.Close()
            MsgBox("Connection is okay.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Recherche()
        Try
            Dim connStr As String = "Database=dompe;" & _
                        "Data Source=10.128.214.253;" & _
                        "User Id=math;Password=admin123"
            Dim query As String = "Select * from client"
            Dim connection As New MySqlConnection(connStr)
            Dim cmd As New MySqlCommand(query, connection)
            connection.Open()

            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()

            While reader.Read()
                MsgBox("" + reader.GetString(0) + " " + reader.GetString(1))
            End While

            reader.Close()
            connection.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
End Class