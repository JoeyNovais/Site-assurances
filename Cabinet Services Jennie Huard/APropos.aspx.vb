Imports MySql.Data.MySqlClient
Public Class Apropos
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TestConnection()
    End Sub

    Public Sub TestConnection()
        Try
            Dim connStr As String = "Database=dompe;" & _
                    "Data Source=192.168.2.36;" & _
                    "User Id=math;Password=admin123"
            Dim connection As New MySqlConnection(connStr)
            connection.Open()
            connection.Close()
            MsgBox("Connection is okay.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class