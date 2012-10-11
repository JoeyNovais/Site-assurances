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

    Public Sub New()

    End Sub

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
    Public Sub New(ByVal Nom, ByVal Prenom, ByVal Courriel)
        m_cli_Nom = Nom
        m_cli_Prenom = Prenom
        m_cli_Courriel = Courriel
    End Sub
    Public Property NomProfil() As String
        Get
            Return m_cli_Profil
        End Get
        Set(ByVal value As String)
            m_cli_Profil = value
        End Set
    End Property
    'Propriété pour le Nom
    Public Property Nom() As String
        Get
            Return m_cli_Nom
        End Get
        Set(ByVal value As String)
            m_cli_Nom = value
        End Set
    End Property

    'Propriété pour le Prenom
    Public Property Prenom() As String
        Get
            Return m_cli_Prenom
        End Get
        Set(ByVal value As String)
            m_cli_Prenom = value
        End Set
    End Property

    'Propriété pour le Courriel
    Public Property Courriel() As String
        Get
            Return m_cli_Courriel
        End Get
        Set(ByVal value As String)
            m_cli_Courriel = value
        End Set
    End Property
End Class
