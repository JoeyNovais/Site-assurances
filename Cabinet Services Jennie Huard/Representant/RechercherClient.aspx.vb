Imports MySql.Data.MySqlClient
Public Class RechercherClient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRechcercheClient_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRechcercheClient.Click
        Dim Rep As New CRepresentant("test", "test123", "test@hotmail.com")
        Dim resultat As New ArrayList
        'Recherche du (des) client
        resultat = Rep.RechercherClient(txtNom.Text, txtPrenom.Text, txtVille.Text, ddTypeClient.SelectedValue.ToString())

        'Affichage des résultats
        For Each Client As CClient In resultat
            Dim rangee As New TableRow
            Dim Cellule As New TableCell()      'initialiser une cellule pour le nom
            Cellule.Text = Client.Nom()
            rangee.Cells.Add(Cellule)           'Ajout de la cellule dans la rangée
            Cellule = New TableCell()
            Cellule.Text = Client.Prenom()
            rangee.Cells.Add(Cellule)           'Cellule pour le Prenom
            Cellule = New TableCell()
            Cellule.Text = Client.Courriel()
            rangee.Cells.Add(Cellule)
            tableResultat.Rows.Add(rangee)
        Next


    End Sub
    Public Sub Test()
        Dim i As Integer
        i = 4
        '"<a href=" & Chr(34) & "./ContacterClient.aspx" & Chr(34) & " onclick= " & Chr(34) & "Test" & Chr(34) &
        '" runat=" & Chr(34) & "server" & Chr(34) & ">" + reader.GetString(2) + "</a>" 'Cellule pour l'adresse courriel

    End Sub
End Class
