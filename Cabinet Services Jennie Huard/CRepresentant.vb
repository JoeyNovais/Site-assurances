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

    Public Property Courriel() As String
        Get
            Return m_CourrielRep
        End Get
        Set(ByVal value As String)
            m_CourrielRep = value
        End Set
    End Property

    Public Function RechercherClient(ByVal NomClient As String, ByVal PrenomClient As String, ByVal Ville As String, ByVal TypeClient As Char)
        'Dim TResultRech As
        Dim nbrParam As Integer = 0

        ConnStr = "Database=projet;" & _
                    "Data Source=10.40.7.22;" & _
                    "User Id=axel;Password=admin123"

        Dim Requete As String = "Select cli.nom, cli.prenom,util.Courriel from client cli join utilisateur util on cli.NoClient = util.NoClient where "
        'Analyse des paramètres de recherche

        'Construction du query
        If (NomClient <> "") Then
            'Le champs nom est utilisé
            Requete += "nom LIKE '%" + NomClient + "%'"
            nbrParam += 1
        End If
        If (PrenomClient <> "") Then
            'Ajout d'une condition à la requête
            If (nbrParam > 0) Then
                Requete += " and Prenom LIKE '%" + PrenomClient + "%'"
            Else
                Requete += "Prenom LIKE '%" + PrenomClient + "%'"
                nbrParam += 1
            End If

        End If
        If (Ville <> "") Then
            If (nbrParam > 0) Then
                Requete += " and Ville LIKE '%" + Ville + "%'"
            Else
                Requete += "Ville LIKE '%" + Ville + "%'"
                nbrParam += 1
            End If
        End If
        If (TypeClient <> "D") Then
            If (nbrParam > 0) Then
                Requete += " and TypeClient LIKE '%" + TypeClient + "%'"
            Else
                Requete += "TypeClient LIKE '%" + TypeClient + "%'"
            End If
        End If



        Try

            Dim connexion As New MySqlConnection(ConnStr)
            Dim cmd As New MySqlCommand(Requete, connexion)
            connexion.Open()

            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read()


            End While
            Return reader.GetString(1)
            reader.Close()
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return "testfail"
    End Function
End Class
