Imports MySql.Data.MySqlClient

Public MustInherit Class CDemande

    Protected m_NomClient As String
    Private m_Nom As String
    Private m_Prenom As String
    Private m_DateNaiss As Date
    Private m_Type As Char
    Private m_Telephone As String
    Private m_CodePostal As String
    Private m_StatutMarital As Char
    Private m_Ville As String
    Private m_Adresse As String
    Private m_Pays As String
    Private m_Statut As String
    Private m_Texte As String
    Private m_Date As Date

    Protected ConnStr As String = "Data Source=" & System.AppDomain.CurrentDomain.BaseDirectory() & "Database\Assurances.accdb; Provider=Microsoft.ACE.OLEDB.12.0; Persist Security Info=False;"
    Protected Requete As String

    'Propriété
    Public ReadOnly Property NomUtil()
        Get
            Return m_NomClient
        End Get
    End Property

    Public Property Nom()
        Get
            Return m_Nom
        End Get
        Set(ByVal value)
            m_Nom = value
        End Set
    End Property

    Public Property Prenom()
        Get
            Return m_Prenom
        End Get
        Set(ByVal value)
            m_Prenom = value
        End Set
    End Property

    Public Property DateNaiss()
        Get
            Return m_DateNaiss
        End Get
        Set(ByVal value)
            m_DateNaiss = value
        End Set
    End Property

    Public Property Type()
        Get
            Return m_Type
        End Get
        Set(ByVal value)
            m_Type = value
        End Set
    End Property

    Public Property Tel()
        Get
            Return m_Telephone
        End Get
        Set(ByVal value)
            m_Telephone = value
        End Set
    End Property

    Public Property CodePostal()
        Get
            Return m_CodePostal
        End Get
        Set(ByVal value)
            m_CodePostal = value
        End Set
    End Property

    Public Property StatutMarital()
        Get
            Return m_StatutMarital
        End Get
        Set(ByVal value)
            m_StatutMarital = value
        End Set
    End Property

    Public Property Ville()
        Get
            Return m_Ville
        End Get
        Set(ByVal value)
            m_Ville = value
        End Set
    End Property

    Public Property Adresse()
        Get
            Return m_Adresse
        End Get
        Set(ByVal value)
            m_Adresse = value
        End Set
    End Property

    Public Property Pays()
        Get
            Return m_Pays
        End Get
        Set(ByVal value)
            m_Pays = value
        End Set
    End Property

    Public Property Statut()
        Get
            Return m_Statut
        End Get
        Set(ByVal value)
            m_Statut = value
        End Set
    End Property

    Public Property Texte()
        Get
            Return m_Texte
        End Get
        Set(ByVal value)
            m_Texte = value
        End Set
    End Property

    Public Property DateDem()
        Get
            Return m_Date
        End Get
        Set(ByVal value)
            m_Date = value
        End Set
    End Property

End Class
