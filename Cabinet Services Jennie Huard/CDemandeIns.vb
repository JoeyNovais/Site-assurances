Imports MySql.Data.MySqlClient

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
End Class
