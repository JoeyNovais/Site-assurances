Imports MySql.Data.MySqlClient
Public Class RechercherClient
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRechcercheClient_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRechcercheClient.Click
        Dim Rep As New CRepresentant("admin", "admin123")
        Dim resultat As New ArrayList


        'Recherche du (des) client
        resultat = Rep.RechercherClient(txtNom.Text, txtPrenom.Text, txtVille.Text, ddTypeClient.SelectedValue.ToString())
        'Affichage des résultats
        'For Each Client As CClient In resultat
        '    Dim rangee As New TableRow
        '    Dim Cellule As New TableCell()      'initialiser une cellule pour le nom
        '    Cellule.Text = Client.Nom()
        '    rangee.Cells.Add(Cellule)           'Ajout de la cellule dans la rangée
        '    Cellule = New TableCell()
        '    Cellule.Text = Client.Prenom()
        '    rangee.Cells.Add(Cellule)           'Cellule pour le Prenom
        '    Cellule = New TableCell()
        '    Cellule.Text = Client.Courriel()
        '    rangee.Cells.Add(Cellule)

        'Cellule = New TableCell()
        'Dim btnCon As New Button
        'btnCon.ID = "btnCont" + Client.NomProfil()
        'btnCon.Text = "Contacter"
        'btnCon.CssClass = "ctlContact"
        'Cellule.Controls.Add(btnCon)
        'Dim btn As New Button
        'btn.ID = "btnGerer" + Client.NomProfil()
        'btn.Text = "Gerer Client"
        'btn.CssClass = "ctlGerer"
        'Cellule.Controls.Add(btn)
        'rangee.Cells.Add(Cellule)
        'tableResultat.Rows.Add(rangee)
        'Next
        Dim i As Integer

        'MsgBox("Assurance = " & res.ToString)

        While i < resultat.Count - 1

            Dim Ligne As New TableRow
            'MsgBox("" + reader.GetString(0) + " " + reader.GetString(1))

            Dim Cellule As New TableCell
            Cellule.Text = resultat.Item(i)
            Ligne.Cells.Add(Cellule)

            Cellule = New TableCell
            Cellule.Text = resultat.Item(i + 1)
            Ligne.Cells.Add(Cellule)

            Cellule = New TableCell
            Cellule.Text = resultat.Item(i + 2)
            Ligne.Cells.Add(Cellule)

            Cellule = New TableCell
            Cellule.Text = resultat.Item(i + 3)
            Ligne.Cells.Add(Cellule)

            Cellule = New TableCell
            Dim btnCon As New Button
            btnCon.ID = "btnCont" + resultat.Item(i + 4)
            btnCon.Text = "Contacter"
            btnCon.CssClass = "ctlContact"
            Cellule.Controls.Add(btnCon)
            Dim btn As New Button
            btn.ID = "btnGerer" + resultat.Item(i + 4)
            btn.Text = "Gerer Client"
            btn.CssClass = "ctlGerer"
            Cellule.Controls.Add(btn)
            Ligne.Cells.Add(Cellule)

            tableResultat.Rows.Add(Ligne)


            i = i + 5

        End While
    End Sub


End Class
