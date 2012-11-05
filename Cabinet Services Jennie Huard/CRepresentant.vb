Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class CRepresentant

    Private m_NomRep As String
    Private m_MotPasseRep As String
    Private m_CourrielRep As String
    Private ConnStr As String
    Public Sub New(ByVal Nom, ByVal MDP)
        m_NomRep = Nom
        m_MotPasseRep = MDP
        m_CourrielRep = ""

        Dim Chemin As String = System.AppDomain.CurrentDomain.BaseDirectory()
        'String de Connection à la bd
        ConnStr = "Data Source=" & Chemin & "Database\Assurances.accdb; Provider=Microsoft.ACE.OLEDB.12.0; Persist Security Info=False;"

    End Sub

    
    'Fonction de recherche de client

    Public Function RechercherClient(ByVal NomClient As String, ByVal PrenomClient As String, ByVal Ville As String, ByVal TypeClient As Char) As ArrayList

        Dim Result As New ArrayList
        Dim nbrParam As Integer = 0

        Dim Requete As String = "Select cli_Nom, cli_Prenom, cli_Ville, cli_Courriel, nomClient from client where "
        'Analyse des paramètres de recherche

        'Construction du query
        If (NomClient <> "") Then
            'Le champs nom est utilisé
            Requete += "cli_Nom LIKE '%" + NomClient + "%'"
            nbrParam += 1
        End If
        If (PrenomClient <> "") Then
            'Ajout d'une condition à la requête
            If (nbrParam > 0) Then
                Requete += " and cli_Prenom LIKE '%" + PrenomClient + "%'"
            Else
                Requete += "cli_Prenom LIKE '%" + PrenomClient + "%'"
                nbrParam += 1
            End If

        End If
        If (Ville <> "") Then
            If (nbrParam > 0) Then
                Requete += " and cli_Ville LIKE '%" + Ville + "%'"
            Else
                Requete += "cli_Ville LIKE '%" + Ville + "%'"
                nbrParam += 1
            End If
        End If
        If (TypeClient <> "D") Then
            If (nbrParam > 0) Then
                Requete += " and cli_Type LIKE '%" + TypeClient + "%'"
            Else
                Requete += "cli_Type LIKE '%" + TypeClient + "%'"
            End If
        End If

        Requete += " order by cli_Nom"

        Try

            Dim connexion As New OleDbConnection(ConnStr)
            Dim cmd As New OleDbCommand(Requete, connexion)
            connexion.Open()

            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader()
            While reader.Read()
                'Ajout du client à la liste de client
                Result.Add(reader.GetString(0))
                Result.Add(reader.GetString(1))
                Result.Add(reader.GetString(2))
                Result.Add(reader.GetString(3))
                Result.Add(reader.GetString(4))

            End While
            'Retour de la liste de clients
            Return Result
            reader.Close()
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Result
        End Try

    End Function

    Public Function NomsCompagnie() As ArrayList
        Dim Requete As String = "SELECT Com_Nom FROM Compagnie order by Com_Nom"
        Dim TableauCom As New ArrayList
        Try
            Dim connexion As New OleDbConnection(ConnStr)
            Dim cmd As New OleDbCommand(Requete, connexion)
            connexion.Open()

            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader()
            While reader.Read()
                TableauCom.Add(reader.GetString(0))
            End While
            reader.Close()
            connexion.Close()
            'MsgBox(TableauAss.Item(0) & TableauAss.Item(1) & TableauAss.Item(2) & TableauAss.Item(3) & TableauAss.Item(4))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If (TableauCom.Count = 0) Then
            MsgBox("Vous n'êtes pas connecté.")
        End If
        Return TableauCom
    End Function

    Public Sub Compagnies(ByVal tableau As Table)
        Dim connection As OleDbConnection = New OleDbConnection(ConnStr)
        connection.Open()
        Dim command As OleDbCommand = New OleDbCommand("SELECT * FROM compagnie", connection)
        Dim reader As OleDbDataReader = command.ExecuteReader
        While reader.Read
            Dim row As New TableRow()
            Dim cell1 As New TableCell()
            Dim tb_NomCom As TextBox = New TextBox()
            tb_NomCom.ID = reader.Item("Com_Nom")
            tb_NomCom.Text = reader.Item("Com_Nom")
            cell1.Controls.Add(tb_NomCom)
            Dim cell2 As New TableCell()
            Dim tb_LienCom As TextBox = New TextBox()
            tb_LienCom.ID = "Lien" + reader.Item("Com_Nom")
            tb_LienCom.Text = reader.Item("Com_LienUrl")
            cell2.Controls.Add(tb_LienCom)
            Dim cell3 As New TableCell()
            Dim tb_Image As Image = New Image()
            tb_Image.ID = "Image" + reader.Item("Com_Nom")
            tb_Image.ImageUrl = "/" + reader.Item("Com_Image")
            cell3.Controls.Add(tb_Image)
            Dim cell4 As New TableCell()
            Dim fu_img As FileUpload = New FileUpload()
            fu_img.ID = "img" + reader.Item("Com_Nom")
            cell4.Controls.Add(fu_img)
            Dim cell5 As New TableCell()
            Dim btn_Delete As Button = New Button()
            btn_Delete.Text = "Supprimer"
            btn_Delete.ID = "Delete" + reader.Item("Com_Nom")
            btn_Delete.OnClientClick = "Delete"
            cell5.Controls.Add(btn_Delete)
            AddHandler btn_Delete.Click, AddressOf Delete
            row.Cells.Add(cell1)
            row.Cells.Add(cell2)
            row.Cells.Add(cell3)
            row.Cells.Add(cell4)
            row.Cells.Add(cell5)
            tableau.Rows.Add(row)
        End While
        connection.Close()
    End Sub

    Protected Sub Delete(ByVal sender As Object, ByVal e As EventArgs)
        Dim clickedBtn As Button = CType(sender, Button)
        Dim Nom As String = clickedBtn.ID.Remove(0, 6)
        Dim connection As OleDbConnection = New OleDbConnection(ConnStr)
        connection.Open()
        Try
            Dim command As OleDbCommand = New OleDbCommand("DELETE FROM compagnie WHERE Com_Nom = '" + Nom + "'", connection)
            command.ExecuteNonQuery()
        Catch
            MsgBox("Une erreur est survenue lors de la suppression ! Veuillez réessayer.")
        End Try
        connection.Close()
    End Sub

    Public Sub AjoutCompagnie(ByVal Nom As String, ByVal Lien As String, ByVal NomImage As String)
        Dim connection As OleDbConnection = New OleDbConnection(ConnStr)
        connection.Open()
        Dim requete As String
        If Lien = "DEFAULT" And NomImage = "DEFAULT" Then
            requete = "INSERT INTO compagnie (Com_Nom) values (" + Nom + ")"
        ElseIf Lien = "DEFAULT" And NomImage <> "DEFAULT" Then
            requete = "INSERT INTO compagnie (Com_Nom,Com_Image) values (" + Nom + "," + NomImage + ")"
        ElseIf Lien <> "DEFAULT" And NomImage = "DEFAULT" Then
            requete = "INSERT INTO compagnie (Com_Nom,Com_LienUrl) values (" + Nom + "," + Lien + ")"
        Else
            requete = "INSERT INTO compagnie (Com_Nom,Com_LienUrl,Com_Image) values (" + Nom + "," + Lien + "," + NomImage + ")"
        End If

        Try
            Dim command As OleDbCommand = New OleDbCommand(requete, connection)
            command.ExecuteNonQuery()
        Catch
            MsgBox("Le nom de cette compagnie existe déjà !!")
        End Try
        connection.Close()
    End Sub

    Public Sub Save(ByVal tableau As Table)
        Dim connection As OleDbConnection = New OleDbConnection(ConnStr)
        connection.Open()
        Dim i As Integer
        For i = 1 To tableau.Rows.Count - 1
            Dim Nom As TextBox = tableau.Rows(i).Cells(0).Controls(0)
            Dim Lien As TextBox = tableau.Rows(i).Cells(1).Controls(0)
            Dim Image As FileUpload = tableau.Rows(i).Cells(3).Controls(0)
            Dim command As OleDbCommand = New OleDbCommand()
            If (Image.HasFile) Then
                Try
                    Image.SaveAs(System.AppDomain.CurrentDomain.BaseDirectory() & "Image\" + Image.FileName)
                    command = New OleDbCommand("UPDATE compagnie set Com_Nom = '" + Nom.Text + "', Com_LienUrl = '" + Lien.Text + "', Com_Image = 'Image/" + Image.FileName + "' where Com_Nom = '" + Nom.ID + "'", connection)
                Catch ex As Exception
                    MsgBox("Erreur lors du transfert de l'image !")
                End Try
            Else
                command = New OleDbCommand("UPDATE compagnie set Com_Nom = '" + Nom.Text + "', Com_LienUrl = '" + Lien.Text + "' where Com_Nom = '" + Nom.ID + "'", connection)
            End If
            Try
                command.ExecuteNonQuery()
            Catch
                MsgBox("Une erreur est survenue lors de l'enregistrement des modifications ! Veuillez réessayer.")
            End Try
        Next
        connection.Close()
    End Sub

    'Fonction de Recherche des demandes de Clients exécution au premier load de la page
    Public Function RechercheDemandeClient() As ArrayList
        Dim Resultat As New ArrayList
        Dim Requete As String
        Requete = "Select * from "
        Return Resultat
    End Function
    'Fonction de recherche des demandes clients selon le nom et prenom du client retourne la demande


    'Fonction de recherche des demandes d'inscription va être affiché en mm temps que recherche demande client

    Public Function AjouterAssurance(ByVal Com_Nom As String, ByVal NomClient As String, ByVal Ser_Nom As String, ByVal Ser_Categorie As String)
        Dim Requete As String = "INSERT INTO Service (Com_Nom,NomClient,Ser_Nom,Ser_Categorie) VALUES(" & Chr(34) & Com_Nom & Chr(34) & "," & Chr(34) & NomClient & Chr(34) & "," & Chr(34) & Ser_Nom & Chr(34) & "," & Chr(34) & Ser_Categorie & Chr(34) & ")"
        Dim Message As String = ""
        Try
            Dim connexion As New OleDbConnection(ConnStr)
            Dim cmd As New OleDbCommand(Requete, connexion)
            connexion.Open()

            cmd.ExecuteNonQuery()
            connexion.Close()
            Return "Votre élément a été ajouté avec succès."
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function SupprimerAssurance(ByVal NoService As String) As String
        Dim Requete As String = "delete from Service where No_Ser = " & NoService
        Dim Message As String = ""
        Try
            Dim connexion As New OleDbConnection(ConnStr)
            Dim cmd As New OleDbCommand(Requete, connexion)
            connexion.Open()

            cmd.ExecuteNonQuery()
            connexion.Close()
            Return "Votre élément a été supprimé avec succès."
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function ModifierAssurance(ByVal NoService As String, ByVal Com_Nom As String, ByVal NomClient As String, ByVal Ser_Nom As String, ByVal Ser_Categorie As String) As String
        Dim Requete As String = "update service set Com_Nom = " & Chr(34) & Com_Nom & Chr(34) & ", NomClient = " & Chr(34) & NomClient & Chr(34) & ", Ser_Nom =" & Chr(34) & Ser_Nom & Chr(34) & ", Ser_Categorie = " & Chr(34) & Ser_Categorie & Chr(34) & " where No_Ser = " & NoService

        Dim Message As String = ""
        Try
            Dim connexion As New OleDbConnection(ConnStr)
            Dim cmd As New OleDbCommand(Requete, connexion)
            connexion.Open()

            cmd.ExecuteNonQuery()
            connexion.Close()
            Return "Les éléments ont étés mis à jour avec succès."
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Class

