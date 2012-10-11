<%@ Page Title="Page d'accueil" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="ConsulterDemandes.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>&nbsp;</h2>
    <h2>Les demandes :</h2>
    <br />
    <asp:Table ID="tbl_Demandes" runat="server" BorderColor="Black" 
        BorderStyle="Solid" BorderWidth="1px" GridLines="Both" Width="786px">
        <asp:TableRow runat="server" BorderColor="Black" BorderStyle="Solid" 
            BorderWidth="1px">
            <asp:TableCell runat="server">De</asp:TableCell>
            <asp:TableCell runat="server">Type de demande</asp:TableCell>
            <asp:TableCell runat="server">Statut</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
