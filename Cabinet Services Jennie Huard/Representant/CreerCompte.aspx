<%@ Page Title="Page d'accueil" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="CreerCompte.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Création de compte:</h2>
    <br />
    <asp:Label ID="lbl_NewNom" runat="server" Text="Nom :"></asp:Label>
    <asp:TextBox ID="tb_NewNomUtil" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_NewPrenom" runat="server" Text="Prénom :"></asp:Label>
    <asp:TextBox ID="tb_NewPrenom" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_NewDateNaissance" runat="server" Text="Date de naissance :"></asp:Label>
    <asp:TextBox ID="tb_NewDateNaissance" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_NewTypeClient" runat="server" Text="Type de client :"></asp:Label>
    <asp:RadioButton ID="rb_NewCorporatif" runat="server" Text="Corporatif" />
    <asp:RadioButton ID="rb_NewPersonnel" runat="server" Text="Personnel" />
    <asp:RadioButton ID="rb_NewTravailleurAutonome" runat="server" 
        Text="Travailleur autonome" />
    <br />
    <asp:Label ID="lbl_NewCodePostal" runat="server" Text="Code postal :"></asp:Label>
    <asp:TextBox ID="tb_NewCodePostal" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_NewVille" runat="server" Text="Ville :"></asp:Label>
    <asp:TextBox ID="tb_NewVille" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_NewAdresse" runat="server" Text="Adresse :"></asp:Label>
    <asp:TextBox ID="tb_NewAdresse" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_NewPays" runat="server" Text="Pays :"></asp:Label>
    <asp:TextBox ID="tb_NewPays" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_NewNumTel" runat="server" Text="Numéro de téléphone :"></asp:Label>
    <asp:TextBox ID="tb_NewNumTel" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_NewCourriel" runat="server" Text="Adresse courriel :"></asp:Label>
    <asp:TextBox ID="tb_NewCourriel" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_NewStatutMarital" runat="server" Text="Statut marital :"></asp:Label>
    <asp:RadioButton ID="rb_NewCelibataire" runat="server" Text="Célibataire" />
    <asp:RadioButton ID="rb_NewMarie" runat="server" Text="Marié(e)" />
    <asp:RadioButton ID="rb_NewVeuf" runat="server" Text="Veuf/Veuve" />
    <asp:RadioButton ID="rb_NewEnCouple" runat="server" Text="En couple" />
    <br />
    <br />
    <asp:Button ID="btn_CreerCompte" runat="server" Text="Créer le compte" />
</asp:Content>
