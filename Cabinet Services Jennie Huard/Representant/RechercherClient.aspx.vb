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
        Session("resultat") = resultat
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
            Cellule = New TableCell()
            rangee.Cells.Add(Cellule)
            tableResultat.Rows.Add(rangee)

        Next
        lblPos.Visible = True
        txtNoClient.Visible = True
        btnContacter.Visible = True
        btnGerer.Visible = True
    End Sub

    Protected Sub btnContacter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnContacter.Click
        Dim NoClient As Integer
        NoClient = Val(txtNoClient.Text)

        Session("SelClient") = CType(Session.Item("resultat"), ArrayList).Item(NoClient - 1)

        Dim Selection As New CClient
        Selection = CType(Session.Item("SelClient"), CClient)

        Response.Redirect("~/Representant/ContacterClient.aspx")
    End Sub

End Class
