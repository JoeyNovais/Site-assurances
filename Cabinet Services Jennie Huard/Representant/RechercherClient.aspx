<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="RechercheClient.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.RechercheClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Recherche d'un client:
    </h2>
    <br />
    Entrez un ou plusieur informations du client.
    <table>
        <tr>
            <td>nom:</td>
            <td><asp:TextBox ID="txtNom" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>prenom:</td>
            <td><asp:TextBox ID="txtPrenom" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Ville</td>
            <td><asp:TextBox ID="txtVille" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Type de client:</td>
            <td>
                <asp:DropDownList ID="ddTypeClient" runat="server">
                    <asp:ListItem Value="D">--choisir catégorie--</asp:ListItem>
                    <asp:ListItem Value="P">Personnel</asp:ListItem>
                    <asp:ListItem Value="C">Corporatif</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
    </table>
     <br />
    
    <asp:Button ID="btnRechcercheClient" runat="server" Text="Rechercher" 
        Width="140px" />
    <br />
    
    <asp:Table ID="tableResultat" runat="server" BorderColor="Black" BorderStyle="Solid" 
        BorderWidth="1px" GridLines="Both" Width="66%">
        <asp:TableRow ID="TableRow1" runat="server">
            <asp:TableCell ID="TableCell1" runat="server" Enabled="False">Nom</asp:TableCell>
            <asp:TableCell ID="TableCell2" runat="server" Enabled="False">Prénom</asp:TableCell>
            <asp:TableCell ID="TableCell3" runat="server" Enabled="False">Adresse e-mail</asp:TableCell>
        </asp:TableRow>
    </asp:Table>


</asp:Content>
