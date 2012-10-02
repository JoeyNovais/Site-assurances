Imports MySql.Data.MySqlClient
Public Class RechercherClient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRechcercheClient_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRechcercheClient.Click
        Dim Rep As New CRepresentant("test", "test123", "test@hotmail.com")
        Dim Str As String = Rep.RechercherClient(txtNom.Text, txtPrenom.Text, txtVille.Text, ddTypeClient.SelectedValue.ToString())

       
    End Sub
    Public Sub RechercheClient(ByVal query As String)
        Try
            Dim ConnString As String
            ConnString = CType(Session.Item("connStr"), String)

            Dim connection As New MySqlConnection(ConnString)
            Dim cmd As New MySqlCommand(query, connection)
            connection.Open()

            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read()
                Dim rangee As New TableRow
                'MsgBox("" + reader.GetString(0) + " " + reader.GetString(1))

                Dim Cellule As New TableCell()      'initialiser une cellule pour le nom
                Cellule.Text = reader.GetString(0)
                rangee.Cells.Add(Cellule)           'Ajout de la cellule dans la rangée
                Cellule = New TableCell()
                Cellule.Text = reader.GetString(1)
                rangee.Cells.Add(Cellule)           'Cellule pour le Prenom
                Cellule = New TableCell()
                Cellule.Text = "<a href=" & Chr(34) & "./ContacterClient.aspx" & Chr(34) & " onclick= " & Chr(34) & "Test" & Chr(34) &
                " runat=" & Chr(34) & "server" & Chr(34) & ">" + reader.GetString(2) + "</a>" 'Cellule pour l'adresse courriel 'Cellule pour l'adresse courriel
                rangee.Cells.Add(Cellule)
                tableResultat.Rows.Add(rangee)

            End While

            reader.Close()
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub Test()
        Dim i As Integer
        i = 4
        '"<a href=" & Chr(34) & "./ContacterClient.aspx" & Chr(34) & " onclick= " & Chr(34) & "Test" & Chr(34) &
        '" runat=" & Chr(34) & "server" & Chr(34) & ">" + reader.GetString(2) + "</a>" 'Cellule pour l'adresse courriel
    End Sub
End Class
