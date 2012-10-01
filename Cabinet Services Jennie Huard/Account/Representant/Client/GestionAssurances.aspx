<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GestionAssurances.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.GestionAssurances" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Gérer ses assurances :</h2>
    <ul>
        <li><asp:LinkButton ID="LinkButton1" runat="server">Changer d&#39;assurance</asp:LinkButton></li>
        <li><asp:LinkButton ID="LinkButton2" runat="server">Souscrire une nouvelle assurance</asp:LinkButton></li> 
        <li><asp:LinkButton ID="LinkButton3" runat="server">Résilier une assurance</asp:LinkButton></li>       
    </ul>
</asp:Content>
