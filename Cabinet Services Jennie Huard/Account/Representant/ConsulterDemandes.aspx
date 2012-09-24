<%@ Page Title="Page d'accueil" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="ConsulterDemandes.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Bienvenue sur le site du cabinet de services financiers Jennie Huard 
    </h2>
    <p>
        Vous n'êtes pas encore client? <asp:HyperLink runat="server" NavigateUrl="~/Contact.aspx">Envoyer une demande de création de compte</asp:HyperLink>
    </p>
</asp:Content>
