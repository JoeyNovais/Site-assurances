Imports MySql.Data.MySqlClient
Public Class CRepresentant

    Private m_NomRep As String
    Private m_MotPasseRep As String
    Private m_CourrielRep As String
    Private ConnStr As String

    Public Sub New(ByVal Nom, ByVal MDP, ByVal Courriel)
        m_NomRep = Nom
        m_MotPasseRep = MDP
        m_CourrielRep = Courriel
        'String de Connection à la bd
        ConnStr = "Database=projet;" & _
                    "Data Source=192.168.2.13;" & _
                    "User Id=axel;Password=admin123"

    End Sub
    Public Property Nom() As String
        Get
            Return m_NomRep
        End Get
        Set(ByVal value As String)
            m_NomRep = value
        End Set
    End Property

    Public Property MotPasse() As String
        Get
            Return m_MotPasseRep
        End Get
        Set(ByVal value As String)
            m_MotPasseRep = value
        End Set
    End Property

    
    'Fonction de recherche de client

    Public Function RechercherClient(ByVal NomClient As String, ByVal PrenomClient As String, ByVal Ville As String, ByVal TypeClient As Char) As ArrayList

        Dim Result As New ArrayList
        Dim nbrParam As Integer = 0

        Dim Requete As String = "Select * from client where "
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



        Try

            Dim connexion As New MySqlConnection(ConnStr)
            Dim cmd As New MySqlCommand(Requete, connexion)
            connexion.Open()

            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read()
                Dim Client As New CClient(reader.GetString(3), reader.GetString(4), reader.GetString(2))
                'Ajout du client à la liste de client
                Result.Add(Client)

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

    'Fonction de Recherche des demandes de Clients exécution au premier load de la page
    Public Function RechercheDemandeClient() As ArrayList
        Dim Resultat As New ArrayList
        Dim Requete As String
        Requete = "Select * from "
        Return Resultat
    End Function
    'Fonction de recherche des demandes clients selon le nom et prenom du client retourne la demande


    'Fonction de recherche des demandes d'inscription va être affiché en mm temps que recherche demande client

End Class

