<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="MonProfil.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.MonProfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h1>Bienvenue sur votre profil !</h1>
<ul>
    <li><asp:HyperLink id="hlMesAssurances" NavigateUrl="MesAssurances.aspx" Text="Voir mes assurances" runat="server"/></li>
    <li><asp:HyperLink id="hlGestionAss" NavigateUrl="GestionAssurances.aspx" Text="Gérer mes assurances" runat="server"/></li>
    <li><asp:HyperLink id="hlModInfo" NavigateUrl="ModifierDonneesPersos.aspx" Text="Modifier mes données personnelles" runat="server"/></li>
</ul>
</asp:Content>
