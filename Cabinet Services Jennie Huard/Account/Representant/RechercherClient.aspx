<%@ Page Title="Rechercher une client" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="RechercherClient.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Recherche d'un client:
    </h2>
    <asp:TextBox runat="server"></asp:TextBox>
    <br />
    <asp:Table ID="Table1" runat="server" BorderColor="Black" BorderStyle="Solid" 
        BorderWidth="1px" GridLines="Both" Width="66%">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" Enabled="False">Nom</asp:TableCell>
            <asp:TableCell runat="server" Enabled="False">Prénom</asp:TableCell>
            <asp:TableCell runat="server" Enabled="False">Adresse e-mail</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
