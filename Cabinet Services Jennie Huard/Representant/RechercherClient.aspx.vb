Imports MySql.Data.MySqlClient
Public Class RechercheClient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRechcercheClient_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRechcercheClient.Click

        Dim Prenom As String = txtPrenom.Text
        Dim Ville As String = txtVille.Text
        Dim Type As Char = ddTypeClient.SelectedValue()
        Dim nbrParam As Integer = 0

        Dim Requete As String = "Select nom, prenom from client where "
        'Construction du query
        If (txtNom.Text <> "") Then
            'Le champs nom est utilisé
            Requete += "nom LIKE '" + txtNom.Text + "'"
            nbrParam += 1
        End If
        If (txtPrenom.Text <> "") Then
            'Ajout d'une condition à la requête
            If (nbrParam > 0) Then
                Requete += " and Prenom LIKE '" + txtPrenom.Text + "'"
            Else
                Requete += "Prenom LIKE '" + txtPrenom.Text + "'"
                nbrParam += 1
            End If

        End If
        If (txtVille.Text <> "") Then
            If (nbrParam > 0) Then
                Requete += " and Ville LIKE '" + txtVille.Text + "'"
            Else
                Requete += "Ville LIKE '" + txtVille.Text + "'"
            End If
        End If
        If (ddTypeClient.SelectedValue.ToString <> "D") Then
            If (nbrParam > 0) Then
                Requete += " and TypeClient LIKE '" + ddTypeClient.SelectedValue.ToString + "'"
            Else
                Requete += "TypeClient LIKE '" + ddTypeClient.SelectedValue.ToString + "'"
            End If
        End If


        RechercheClient(Requete)
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
            Dim i As Integer
            While reader.Read()
                Dim rangee As New TableRow
                'MsgBox("" + reader.GetString(0) + " " + reader.GetString(1))
                For i = 0 To 1
                    Dim Cellule As New TableCell() 'initialiser une cellule pour chaques entrées
                    Cellule.Text = reader.GetString(i)
                    rangee.Cells.Add(Cellule)
                Next i
                tableResultat.Rows.Add(rangee)

            End While

            reader.Close()
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class