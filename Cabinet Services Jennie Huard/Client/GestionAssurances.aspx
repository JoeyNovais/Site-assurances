<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GestionAssurances.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.GestionAssurances" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        GESTION D&#39;ASSURANCES ET PLACEMENTS</h1>
    <p>
        <asp:Label ID="lblAssurance" runat="server" Font-Size="Large" 
            Text="Mes assurances et placements :"></asp:Label>
    </p>
    <p>
        <asp:Table ID="TableAssurance" runat="server" BorderStyle="Double" 
            CellPadding="1" CellSpacing="0" GridLines="Both">
            <asp:TableRow BorderStyle="Solid">
                <asp:TableCell ID="Categorie" Width="250px">
                    Catégorie
                </asp:TableCell >
                <asp:TableCell ID = "Compagnie" Width="250px">
                    Compagnie
                </asp:TableCell>
                <asp:TableCell ID = "Nom" Width="400px">
                    Nom spécifique
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </p> 
</asp:Content>

