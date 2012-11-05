<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GererCompteClient.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.GererCompteClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <h2>Modifier les données du compte:</h2>
        <br />
        <asp:PlaceHolder ID="phModAss" runat="server">
        <asp:Table ID="TableModAssurance" runat="server" BorderStyle="Double" 
            CellPadding="1" CellSpacing="0" GridLines="Both">
        </asp:Table>
    </asp:PlaceHolder>
        <br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="#CC0000"></asp:Label>
        <br />
        <br />
            <asp:Button ID="btn_ModifierAss" runat="server" Text="Modifier les assurances et placements" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRetour" runat="server" Text="Retour" Width="115px" />
&nbsp;&nbsp;
        <br />
</asp:Content>
