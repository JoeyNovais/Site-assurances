Public Class CClient
    'Ébauche classe Client

    Private m_cli_Profil As String
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

    Private ConnStr As String

    Public Sub New(ByVal Profil, ByVal MDP, ByVal Courriel, ByVal Nom, ByVal Prenom, ByVal DateNaiss, ByVal Type, ByVal Telephone, ByVal CodePost, ByVal StatutM, ByVal Ville, ByVal Adresse, ByVal Pays)
        m_cli_Profil = Profil
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
End Class
