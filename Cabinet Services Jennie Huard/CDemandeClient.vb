Imports MySql.Data.MySqlClient
Imports System.Data.OleDb

Public Class CDemandeClient : Inherits CDemande
    Private m_NoDemClient As Integer

    'Constructeur
    Public Sub New(ByVal NoDem As String)
        m_NoDemClient = NoDem
        ConnStr = "server=localhost;User Id=client;Password=admin123;Persist Security Info=True;database=assurance"
        'Requête pour sélectionner la demande
        Dim Requete As String = "Select * from demandegest where No_DemGest =" + NoDem

        Try
            Dim connexion As New MySqlConnection(ConnStr)
            Dim cmd As New MySqlCommand(Requete, connexion)
            connexion.Open()

            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read()
                m_NomClient = reader.GetString(1)
                Nom = reader.GetString(2)
                Prenom = reader.GetString(3)
                DateNaiss = reader.GetDateTime(4)
                Type = reader.GetString(5)
                Tel = reader.GetString(6)
                CodePostal = reader.GetString(7)
                StatutMarital = reader.GetChar(8)
                Ville = reader.GetString(9)
                Adresse = reader.GetString(10)
                Pays = reader.GetString(11)
                Statut = reader.GetString(12)
                Texte = reader.GetString(13)
                DateDem = reader.GetDateTime(14)

            End While
            reader.Close()
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Fonction pour modifier le Statut 
    Public Function ModifierStatut() As Boolean

        'Requête pour sélectionner la demande
        Dim Requete As String = "UPDATE DemandeGest SET DemGest_Statut = 'Traitee' WHERE No_DemGest = " + m_NoDemClient.ToString + ";"

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
    'repondre a demande

    'Suprimmer Demande
    Public Function Supprimer() As Boolean

        'Requête pour sélectionner la demande
        Dim Requete As String = "DELETE from demandegest WHERE No_DemGest= " + m_NoDemClient.ToString + ";"

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

    'Effectuer Changement
    Public Function ModifierClient() As Boolean
        Dim Requete As String
        Requete = String.Format("UPDATE Client SET cli_Nom = '{0}', cli_Prenom = '{1}', cli_DateNaiss = '{2}', cli_Type = '{3}', cli_Telephone = '{4}', cli_CodePostal = '{5}', cli_StatutMarital = '{6}', cli_Ville = '{7}', cli_Adresse = '{8}', cli_Pays = '{9}' WHERE NomClient = '{10}'",
                                Nom, Prenom, DateNaiss, Type, Tel, CodePostal, StatutMarital, Ville, Adresse, Pays, m_NomClient)

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

    Public Sub New(ByVal client As CClient, ByVal tb_Body As String)
        Dim connection As OleDbConnection = New OleDbConnection(ConnStr)
        connection.Open()
        Dim command As OleDbCommand = New OleDbCommand("INSERT INTO demandegest (DemGest_motPasse,NomClient,DemGest_Nom,DemGest_Prenom,DemGest_DateNaiss,DemGest_TypeClient,DemGest_Telephone,DemGest_CodePostal,DemGest_StatutMarital,DemGest_Ville,DemGest_Adresse,DemGest_Pays,DemGest_Texte) values ('" +
                                                       client.MotPasse + "','" +
                                                       client.NomClient + "','" +
                                                       client.Nom + "','" +
                                                       client.Prenom + "','" +
                                                       client.DateNaiss + "','" +
                                                       client.Type + "','" +
                                                       client.Telephone + "','" +
                                                       client.CodePostal + "','" +
                                                       client.StatutMarital + "','" +
                                                       client.Ville + "','" +
                                                       client.Adresse + "','" +
                                                       client.Pays + "'," + Chr(34) +
                                                       tb_Body + Chr(34) + ")", connection)
        Try
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erreur lors de l'envoi de votre message :" +ex.Message)
        End Try
        connection.Close()
    End Sub
End Class
