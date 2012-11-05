
Public Class GererCompteClient
    Inherits System.Web.UI.Page
    Private m_resCom As ArrayList
    Private m_Rep As CRepresentant
    Private m_idPro As String
    Private m_Client As CClient

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        EnTeteTab()
        AfficherTableau()
        Ajouter()
    End Sub

    Private Sub EnTeteTab()
        Dim LigneDebut As New TableRow
        Dim CelluleDebut As New TableCell
        CelluleDebut.Text = "Catégorie"
        CelluleDebut.Width = 250

        LigneDebut.Cells.Add(CelluleDebut)

        CelluleDebut = New TableCell

        CelluleDebut.Text = "Compagnie"
        CelluleDebut.Width = 250

        LigneDebut.Cells.Add(CelluleDebut)


        CelluleDebut = New TableCell

        CelluleDebut.Text = "Nom spécifique"
        CelluleDebut.Width = 300

        LigneDebut.Cells.Add(CelluleDebut)

        CelluleDebut = New TableCell

        CelluleDebut.Text = "Action"
        CelluleDebut.Width = 100

        LigneDebut.Cells.Add(CelluleDebut)

        LigneDebut.BorderStyle = BorderStyle.Solid
        TableModAssurance.Rows.Add(LigneDebut)
    End Sub


    Private Sub AfficherTableau()
        m_Rep = New CRepresentant("admin", "admin123")
        m_idPro = Request.QueryString("idPro")

        m_Client = New CClient(m_idPro)
        Dim resAss As ArrayList = m_Client.AssuranceClient()
        m_resCom = m_Rep.NomsCompagnie()
        Dim i As Integer = 0

        While i < resAss.Count - 1

            Dim Ligne As New TableRow

            Dim Cellule As New TableCell
            Dim txtCellule As New TextBox
            txtCellule.Text = resAss.Item(i)
            txtCellule.ID = "txtBoxCat" & resAss.Item(i + 5)
            txtCellule.Width = 230
            txtCellule.MaxLength = 50
            Cellule.Controls.Add(txtCellule)
            Ligne.Cells.Add(Cellule)

            Cellule = New TableCell
            Dim listeCompagnie As New DropDownList
            Dim j As Integer = 0

            While j < m_resCom.Count
                listeCompagnie.Items.Add(m_resCom.Item(j))
                If m_resCom.Item(j) = resAss.Item(i + 3) Then
                    listeCompagnie.SelectedIndex = j
                End If
                j = j + 1
            End While

            listeCompagnie.ID = "listBoxCom" & resAss.Item(i + 5)
            listeCompagnie.Width = 245
            Cellule.Controls.Add(listeCompagnie)
            Ligne.Cells.Add(Cellule)

            Cellule = New TableCell
            txtCellule = New TextBox
            txtCellule.Text = resAss.Item(i + 4)
            txtCellule.ID = "txtBoxSerNom" & resAss.Item(i + 5)
            txtCellule.Width = 280
            txtCellule.MaxLength = 100
            Cellule.Controls.Add(txtCellule)
            Ligne.Cells.Add(Cellule)

            Cellule = New TableCell
            Dim boutonSupp As New Button
            boutonSupp.Text = "Supprimer"
            boutonSupp.ID = "btnSupp" & resAss.Item(i + 5)
            AddHandler boutonSupp.Click, AddressOf btn_Supprimer
            boutonSupp.Width = 100
            Cellule.Controls.Add(boutonSupp)
            Ligne.Cells.Add(Cellule)

            TableModAssurance.Rows.Add(Ligne)

            i = i + 6

        End While
    End Sub


    Private Sub Ajouter()
        Dim LigneFin As New TableRow
        Dim CelluleFin As New TableCell
        Dim txtCelluleFin As New TextBox

        txtCelluleFin.ID = "txtBoxCatAjout"
        txtCelluleFin.MaxLength = 50
        txtCelluleFin.Width = 230

        CelluleFin.Controls.Add(txtCelluleFin)

        LigneFin.Cells.Add(CelluleFin)

        CelluleFin = New TableCell
        Dim listeCompagnieFin As New DropDownList
        Dim jFin As Integer = 0

        While jFin < m_resCom.Count
            listeCompagnieFin.Items.Add(m_resCom.Item(jFin))
            jFin = jFin + 1
        End While
        listeCompagnieFin.SelectedIndex = 0
        listeCompagnieFin.ID = "listBoxComAjout"
        listeCompagnieFin.Width = 245
        CelluleFin.Controls.Add(listeCompagnieFin)

        LigneFin.Cells.Add(CelluleFin)


        CelluleFin = New TableCell
        txtCelluleFin = New TextBox
        txtCelluleFin.ID = "txtBoxSerNomAjout"
        txtCelluleFin.MaxLength = 100
        txtCelluleFin.Width = 280
        CelluleFin.Controls.Add(txtCelluleFin)
        LigneFin.Cells.Add(CelluleFin)

        TableModAssurance.Rows.Add(LigneFin)
        CelluleFin = New TableCell
        Dim boutonAjout As New Button
        boutonAjout.Text = "Ajouter"
        boutonAjout.ID = "btnAjout"
        boutonAjout.Width = 100
        boutonAjout.OnClientClick = "btn_Ajout"
        AddHandler boutonAjout.Click, AddressOf btn_Ajout
        CelluleFin.Controls.Add(boutonAjout)
        LigneFin.Cells.Add(CelluleFin)

        TableModAssurance.Rows.Add(LigneFin)
    End Sub

    Private Sub btn_Ajout(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim boutonParent As Button = sender
        Dim PlaceH As Control = Page.Controls(0).FindControl("MainContent")
        Dim txtCat As TextBox = CType(PlaceH.FindControl("txtBoxCatAjout"), TextBox)
        Dim listComp As DropDownList = CType(PlaceH.FindControl("listBoxComAjout"), DropDownList)
        Dim txtSerNom As TextBox = CType(PlaceH.FindControl("txtBoxSerNomAjout"), TextBox)
        Dim Mess As String = ""
        TableModAssurance.Controls.Clear()
        If txtCat.Text = "" Or txtSerNom.Text = "" Then
            lblMessage.ForeColor = Drawing.ColorTranslator.FromHtml("#CC0000")
            Mess = "* Veuillez remplir tous les champs avant d'ajouter un élément."
        Else
            Mess = m_Rep.AjouterAssurance(listComp.SelectedValue, m_idPro, txtSerNom.Text, txtCat.Text)
            If Mess = "Votre élément a été ajouté avec succès." Then
                lblMessage.ForeColor = Drawing.ColorTranslator.FromHtml("#00CC00")

            Else
                lblMessage.ForeColor = Drawing.ColorTranslator.FromHtml("#CC0000")
            End If

        End If
        Page_Load(sender, e)
        lblMessage.Text = Mess

    End Sub

    Private Sub btn_Supprimer(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim boutonParent As Button = sender
        Dim Mess As String = ""
        Dim NoService As String = boutonParent.ID.Remove(0, 7)
        TableModAssurance.Controls.Clear()
        Mess = m_Rep.SupprimerAssurance(NoService)
        If Mess = "Votre élément a été supprimé avec succès." Then
            lblMessage.ForeColor = Drawing.ColorTranslator.FromHtml("#FF6600")
        Else
            lblMessage.ForeColor = Drawing.ColorTranslator.FromHtml("#CC0000")
        End If
        Page_Load(sender, e)
        lblMessage.Text = Mess

    End Sub



    Protected Sub btn_ModifierAss_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_ModifierAss.Click
        Dim Champs As New ArrayList


        lblMessage.Text = ""
        For Each Ligne As TableRow In TableModAssurance.Rows
            For Each Cellule As TableCell In Ligne.Cells
                For Each Editer In Cellule.Controls
                    If TypeOf Editer Is TextBox Then
                        Dim Texte As TextBox = Editer
                        If Not Editer.ID = "txtBoxCatAjout" And Not Editer.ID = "txtBoxSerNomAjout" Then
                            If Texte.Text = "" Then
                                lblMessage.Text = "* Veuillez remplir tous les champs des éléments modifiés."
                            Else
                                If Texte.ID.Contains("txtBoxCat") Then
                                    Champs.Add(Texte.ID.Remove(0, 9))
                                End If

                                Champs.Add(Texte.Text)
                            End If
                        End If
                    Else
                        If TypeOf Editer Is DropDownList Then
                            Dim Liste As DropDownList = Editer
                            If Not Liste.ID = "listBoxComAjout" Then
                                Champs.Add(Liste.SelectedValue)
                            End If
                        End If
                    End If
                Next Editer
            Next Cellule
        Next Ligne

        If lblMessage.Text = "" Then
            Dim i As Integer = 0
            Dim Mess As String
            Do
                Mess = m_Rep.ModifierAssurance(Champs.Item(i), Champs.Item(i + 2), m_idPro, Champs.Item(i + 3), Champs.Item(i + 1))
                i = i + 4
            Loop While i < Champs.Count And Mess = "Les éléments ont étés mis à jour avec succès."

            If Mess = "Les éléments ont étés mis à jour avec succès." Then
                lblMessage.ForeColor = Drawing.ColorTranslator.FromHtml("#00CC00")
            Else
                lblMessage.ForeColor = Drawing.ColorTranslator.FromHtml("#CC0000")
            End If
            TableModAssurance.Controls.Clear()
            Page_Load(sender, e)
            lblMessage.Text = Mess
        Else
            lblMessage.ForeColor = Drawing.ColorTranslator.FromHtml("#CC0000")
        End If

    End Sub

    Protected Sub btnRetour_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRetour.Click
        Response.Redirect("~/Representant/RechercherClient.aspx")
    End Sub
End Class