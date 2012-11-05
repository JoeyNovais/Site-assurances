<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="RechercherClient.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.RechercherClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script src = "../Scripts/jquery-1.4.1.js" type="text/javascript"></script>
        <script type="text/javascript">
            $(document).ready(function () {

                $(".ctlContact").click(function () {
                    var Id = $(this).attr('id');
                    Id = Id.substring(19, (Id.Length));
                    window.location.href = "../Representant/ContacterClient.aspx?idPro=" + Id;
                    return false;
                });
                $(".ctlGerer").click(function () {
                    var Id = $(this).attr('id');
                    Id = Id.substring(20, (Id.Length));
                    window.location.href = "../Representant/GererCompteClient.aspx?idPro=" + Id;
                    return false;
                });
            });
        </script>
     
    
    
    
    <h2>
        Recherche d'un client:
    </h2>
    <br />
    Entrez une ou plusieur informations du client.
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
        BorderWidth="1px" GridLines="Both" Width="90%">
        <asp:TableRow ID="ColoneHaut" runat="server">
            <asp:TableCell runat="server" Width="20%">Nom</asp:TableCell>
            <asp:TableCell runat="server" Width="15%">Prénom</asp:TableCell>
            <asp:TableCell runat="server" width="15%">Ville</asp:TableCell>
            <asp:TableCell runat="server" width="30%">Adresse e-mail</asp:TableCell>
            <asp:TableCell runat="server" Width="20%">Action</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />
    
</asp:Content>
