Imports MySql.Data.MySqlClient
Imports System.Data.OleDb

Public Class CDemandeIns : Inherits CDemande

    Private m_DemIns_MDP As String
    Private m_DemIns_Courriel As String

    'Propriété
    Public Sub New(ByVal NomUtil As String)


        ConnStr = "server=localhost;User Id=client;Password=admin123;Persist Security Info=True;database=assurance"
        'Requête pour sélectionner la demande
        Dim Requete As String = "Select * from DemandeIns where NomClient = '" + NomUtil + "';"
        m_NomClient = NomUtil
        Try
            Dim connexion As New MySqlConnection(ConnStr)
            Dim cmd As New MySqlCommand(Requete, connexion)
            connexion.Open()

            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read()
                m_DemIns_MDP = reader.GetString(1)
                m_DemIns_Courriel = reader.GetString(2)
                Nom = reader.GetString(3)
                Prenom = reader.GetString(4)
                DateNaiss = reader.GetDateTime(5)
                Type = reader.GetString(6)
                Tel = reader.GetString(7)
                CodePostal = reader.GetString(8)
                StatutMarital = reader.GetChar(9)
                Ville = reader.GetString(10)
                Adresse = reader.GetString(11)
                Pays = reader.GetString(12)
                Statut = reader.GetString(13)
                Texte = reader.GetString(14)

            End While
            reader.Close()
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub New()

    End Sub

    'Fonction pour modifier le Statut 
    Public Function ModifierStatut() As Boolean

        ConnStr = "server=localhost;User Id=client;Password=admin123;Persist Security Info=True;database=assurance"
        'Requête pour sélectionner la demande
        Dim Requete As String = "UPDATE DemandeIns SET DemIns_Statut = 'Traitee' WHERE NomClient = '" + m_NomClient + "';"

        Try
            Dim connexion As New MySqlConnection(ConnStr)
            Dim cmd As New MySqlCommand(Requete, connexion)
            connexion.Open()

            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Function Supprimer() As Boolean

        ConnStr = "server=localhost;User Id=client;Password=admin123;Persist Security Info=True;database=assurance"
        'Requête pour sélectionner la demande
        Dim Requete As String = "DELETE from demandeIns WHERE NomClient= '" + m_NomClient + "';"

        Try
            Dim connexion As New MySqlConnection(ConnStr)
            Dim cmd As New MySqlCommand(Requete, connexion)
            connexion.Open()

            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Function Verifier(ByVal NomClient As String) As String
        Dim Requete As String = "select demandeIns.NomClient, Representant.NomRep, Client.NomClient from demandeIns, Client, Representant WHERE demandeIns.NomClient= " & Chr(34) & NomClient & Chr(34) & " or Representant.NomRep = " & Chr(34) & NomClient & Chr(34) & " or Client.NomClient =" & Chr(34) & NomClient & Chr(34)
        Dim connexion As OleDbConnection
        Dim cmd As OleDbCommand
        Dim reader As OleDbDataReader
        Try
            connexion = New OleDbConnection(ConnStr)
            cmd = New OleDbCommand(Requete, connexion)

            Dim Verif As String = ""
            connexion.Open()

            reader = cmd.ExecuteReader()

            While reader.Read
                Verif = reader.GetString(0)
            End While

            If Verif.Length = 0 Then
                Return ""
            Else
                Return "Le nom d'identifiant est déjà utilisé."
            End If

        Catch ex As Exception

            Return ex.Message
        End Try
        reader.Close()
        connexion.Close()
    End Function

    Public Function CreerDemandeIns(ByVal NomClient As String, ByVal MotPasse As String, ByVal Courriel As String, ByVal Nom As String, ByVal Prenom As String, ByVal DateNaiss As Date, ByVal TypeClient As Char, ByVal Telephone As String, ByVal CodePostal As String, ByVal StatutMarital As Char, ByVal Ville As String, ByVal Adresse As String, ByVal Pays As String, ByVal Texte As String) As String
        Dim Requete As String = "insert into demandeIns (NomClient, DemIns_MotPasse, DemIns_Courriel, DemIns_Nom, DemIns_Prenom, DemIns_DateNaiss, DemIns_TypeClient, DemIns_Telephone, DemIns_CodePostal, DemIns_StatutMarital, DemIns_Ville, DemIns_Adresse, DemIns_Pays, DemIns_Texte) VALUES (" & Chr(34) & NomClient & Chr(34) & ", " & Chr(34) & MotPasse & Chr(34) & "," & Chr(34) & Courriel & Chr(34) & "," & Chr(34) & Nom & Chr(34) & "," & Chr(34) & Prenom & Chr(34) & "," & Chr(34) & DateNaiss.ToString & Chr(34) & "," & Chr(34) & TypeClient & Chr(34) & "," & Chr(34) & Telephone & Chr(34) & "," & Chr(34) & CodePostal & Chr(34) & "," & Chr(34) & StatutMarital & Chr(34) & "," & Chr(34) & Ville & Chr(34) & "," & Chr(34) & Adresse & Chr(34) & "," & Chr(34) & Pays & Chr(34) & "," & Chr(34) & Texte & Chr(34) & ")"
        Dim connexion As OleDbConnection
        Dim cmd As OleDbCommand
        Try
            connexion = New OleDbConnection(ConnStr)
            cmd = New OleDbCommand(Requete, connexion)

            Dim Verif As String = ""
            connexion.Open()

            cmd.ExecuteNonQuery()
            Return "Vous avez été inscrit avec succès"
        Catch ex As Exception
            Return ex.Message
        End Try
        connexion.Close()
    End Function

End Class
