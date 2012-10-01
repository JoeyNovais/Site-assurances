<%@ Page Title="Page d'accueil" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="GererCompteClient.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Modifier les données du compte:</h2>
    <br />
    <asp:Label ID="lbl_nom" runat="server" Text="Nom :"></asp:Label>
    <asp:TextBox ID="tb_NomUtil" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_prenom" runat="server" Text="Prénom :"></asp:Label>
    <asp:TextBox ID="tb_Prenom" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_DateNaissance" runat="server" Text="Date de naissance :"></asp:Label>
    <asp:TextBox ID="tb_DateNaissance" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_TypeClient" runat="server" Text="Type de client :"></asp:Label>
    <asp:RadioButton ID="rb_Corporatif" runat="server" Text="Corporatif" />
    <asp:RadioButton ID="rb_Personnel" runat="server" Text="Personnel" />
    <asp:RadioButton ID="rb_TravailleurAutonome" runat="server" 
        Text="Travailleur autonome" />
    <br />
    <asp:Label ID="lbl_CodePostal" runat="server" Text="Code postal :"></asp:Label>
    <asp:TextBox ID="tb_CodePostal" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_Ville" runat="server" Text="Ville :"></asp:Label>
    <asp:TextBox ID="tb_Ville" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_Adresse" runat="server" Text="Adresse :"></asp:Label>
    <asp:TextBox ID="tb_Adresse" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_Pays" runat="server" Text="Pays :"></asp:Label>
    <asp:TextBox ID="tb_Pays" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_NumTel" runat="server" Text="Numéro de téléphone :"></asp:Label>
    <asp:TextBox ID="tb_NumTel" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_Courriel" runat="server" Text="Adresse courriel :"></asp:Label>
    <asp:TextBox ID="tb_Courriel" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_StatutMarital" runat="server" Text="Statut marital :"></asp:Label>
    <asp:RadioButton ID="rb_Celibataire" runat="server" Text="Célibataire" />
    <asp:RadioButton ID="rb_Marie" runat="server" Text="Marié(e)" />
    <asp:RadioButton ID="rb_Veuf" runat="server" Text="Veuf/Veuve" />
    <asp:RadioButton ID="rb_EnCouple" runat="server" Text="En couple" />
    <br />
    <br />
    <asp:Button ID="btn_ModifierCompte" runat="server" Text="Modifier le compte" />
</asp:Content>
