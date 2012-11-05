Imports System.Data.OleDb
Public Class CClient
    'Ébauche classe Client


    'Connexion à un account de merde en attendant
    'String de Connection à la bd
    Private ConnStr As String = "Data Source=" & System.AppDomain.CurrentDomain.BaseDirectory() & "Database\Assurances.accdb; Provider=Microsoft.ACE.OLEDB.12.0; Persist Security Info=False;"


    Private m_NomClient As String
    Private m_cli_MotPasse As String
    Private m_cli_Courriel As String
    Private m_cli_Nom As String
    Private m_cli_Prenom As String
    Private m_cli_DateNaiss As Date
    Private m_cli_Type As Char
    Private m_cli_Telephone As String
    Private m_cli_CodePostal As String
    Private m_cli_StatutMarital As Char
    Private m_cli_Ville As String
    Private m_cli_Adresse As String
    Private m_cli_Pays As String

    Public Sub New(ByVal NomClient As String, ByVal MDP As String)
        Dim Requete As String = "select cli_Courriel, cli_Nom, cli_Prenom, cli_DateNaiss, cli_Type, cli_Telephone, cli_CodePostal, cli_StatutMarital, cli_Ville, cli_Adresse, cli_Pays from client where NomClient =" & Chr(34) & NomClient & Chr(34) & " and cli_MotPasse =" & Chr(34) & MDP & Chr(34)
        Try

            Dim connexion As New OleDbConnection(ConnStr)
            Dim cmd As New OleDbCommand(Requete, connexion)

            connexion.Open()

            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader()
            While reader.Read()
                m_cli_Courriel = reader.GetString(0)
                m_cli_Nom = reader.GetString(1)
                m_cli_Prenom = reader.GetString(2)
                m_cli_DateNaiss = reader.GetDateTime(3).ToString
                m_cli_Type = reader.GetString(4)
                m_cli_Telephone = reader.GetString(5)
                m_cli_CodePostal = reader.GetString(6)
                m_cli_StatutMarital = reader.GetString(7)
                m_cli_Ville = reader.GetString(8)
                m_cli_Adresse = reader.GetString(9)
                m_cli_Pays = reader.GetString(10)
            End While
            reader.Close()
            connexion.Close()
            'MsgBox(NomClient & m_cli_MotPasse & m_cli_Courriel & m_cli_Nom & m_cli_Prenom & m_cli_DateNaiss.ToString & m_cli_Type & m_cli_Telephone & m_cli_CodePostal & m_cli_StatutMarital & m_cli_Ville & m_cli_Adresse & m_cli_Pays)
            If Not (m_cli_Nom = "") Then
                m_NomClient = NomClient
                m_cli_MotPasse = MDP
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub New(ByVal NomClient As String, ByVal MDP As String, ByVal Courriel As String, ByVal Nom As String, ByVal Prenom As String, ByVal DateNaiss As Date, ByVal Type As Char, ByVal Telephone As String, ByVal CodePost As String, ByVal StatutM As Char, ByVal Ville As String, ByVal Adresse As String, ByVal Pays As String)
        m_NomClient = NomClient
        m_cli_MotPasse = MDP
        m_cli_Courriel = Courriel
        m_cli_Nom = Nom
        m_cli_Prenom = Prenom
        m_cli_DateNaiss = DateNaiss
        m_cli_Type = Type
        m_cli_Telephone = Telephone
        m_cli_CodePostal = CodePost
        m_cli_StatutMarital = StatutM
        m_cli_Ville = Ville
        m_cli_Adresse = Adresse
        m_cli_Pays = Pays
    End Sub

    Public Sub New(ByVal NomClient As String)

        Dim Requete As String = "select cli_Courriel, cli_Nom, cli_Prenom, cli_DateNaiss, cli_Type, cli_Telephone, cli_CodePostal, cli_StatutMarital, cli_Ville, cli_Adresse, cli_Pays from client where NomClient =" & Chr(34) & NomClient & Chr(34)
        Try

            Dim connexion As New OleDbConnection(ConnStr)
            Dim cmd As New OleDbCommand(Requete, connexion)

            connexion.Open()

            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader()
            While reader.Read()
                m_cli_Courriel = reader.GetString(0)
                m_cli_Nom = reader.GetString(1)
                m_cli_Prenom = reader.GetString(2)
                m_cli_DateNaiss = reader.GetDateTime(3)
                m_cli_Type = reader.GetString(4)
                m_cli_Telephone = reader.GetString(5)
                m_cli_CodePostal = reader.GetString(6)
                m_cli_StatutMarital = reader.GetString(7)
                m_cli_Ville = reader.GetString(8)
                m_cli_Adresse = reader.GetString(9)
                m_cli_Pays = reader.GetString(10)
            End While
            reader.Close()
            connexion.Close()
            'MsgBox(NomClient & m_cli_MotPasse & m_cli_Courriel & m_cli_Nom & m_cli_Prenom & m_cli_DateNaiss.ToString & m_cli_Type & m_cli_Telephone & m_cli_CodePostal & m_cli_StatutMarital & m_cli_Ville & m_cli_Adresse & m_cli_Pays)
            If Not (m_cli_Nom = "") Then
                m_NomClient = NomClient
                m_cli_MotPasse = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ReadOnly Property NomClient() As String

        Get
            Return m_NomClient


        End Get
    End Property
    ReadOnly Property MotPasse() As String

        Get
            Return m_cli_MotPasse


        End Get
    End Property


    ReadOnly Property Courriel() As String

        Get
            Return m_cli_Courriel


        End Get
    End Property


    ReadOnly Property Nom() As String

        Get
            Return m_cli_Nom


        End Get
    End Property


    ReadOnly Property Prenom() As String

        Get
            Return m_cli_Prenom

        End Get
    End Property

    ReadOnly Property DateNaiss() As Date

        Get
            Return m_cli_DateNaiss

        End Get
    End Property

    ReadOnly Property Type() As Char

        Get
            Return m_cli_Type

        End Get
    End Property

    ReadOnly Property Telephone() As String

        Get
            Return m_cli_Telephone

        End Get
    End Property

    ReadOnly Property CodePostal() As String

        Get
            Return m_cli_CodePostal

        End Get
    End Property

    ReadOnly Property StatutMarital() As Char
        Get
            Return m_cli_StatutMarital

        End Get
    End Property

    ReadOnly Property Ville() As String

        Get
            Return m_cli_Ville

        End Get
    End Property

    ReadOnly Property Adresse() As String

        Get
            Return m_cli_Adresse

        End Get
    End Property

    ReadOnly Property Pays() As String

        Get
            Return m_cli_Pays

        End Get
    End Property

    

    Public Function AssuranceClient()
        Dim Requete As String = "SELECT Service.Ser_Categorie, Compagnie.Com_Image, Compagnie.Com_LienUrl, Compagnie.Com_Nom, Service.Ser_Nom, Service.No_Ser FROM Service INNER JOIN Compagnie ON Service.Com_Nom=Compagnie.Com_Nom where Service.NomClient='" & m_NomClient & "' order by Service.No_ser"
        Dim TableauAss As New ArrayList
        Try
            Dim connexion As New OleDbConnection(ConnStr)
            Dim cmd As New OleDbCommand(Requete, connexion)
            connexion.Open()
            Dim reader As OleDbDataReader
            reader = cmd.ExecuteReader()
            While reader.Read()
                TableauAss.Add(reader.GetString(0))
                TableauAss.Add(reader.GetString(1))
                TableauAss.Add(reader.GetString(2))
                TableauAss.Add(reader.GetString(3))
                TableauAss.Add(reader.GetString(4))
                TableauAss.Add(reader.GetInt32(5).ToString)
            End While
            reader.Close()
            connexion.Close()
            'MsgBox(TableauAss.Item(0) & TableauAss.Item(1) & TableauAss.Item(2) & TableauAss.Item(3) & TableauAss.Item(4))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If (TableauAss.Count = 0) Then
            MsgBox("Vous n'êtes pas connecté.")
        End If
        Return TableauAss
    End Function

End Class
