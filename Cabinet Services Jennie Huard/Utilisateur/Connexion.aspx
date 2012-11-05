<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Connexion.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.Connexion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Se connecter</h2>
    <p>
        <asp:HyperLink ID="hlInscrire" runat="server" 
            NavigateUrl="~/Utilisateur/CreerCompte.aspx">Vous n&#39;êtes pas inscrit?</asp:HyperLink>
    </p>
</asp:Content>
