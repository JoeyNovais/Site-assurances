<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ModifierDonneesPersos.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.ModifierDonneesPersos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
Informations relatives à votre compte
<br />
<table>
    <tr>
        <td>Nom:</td>
        <td><asp:TextBox ID="txtNom" runat="server" Text="VotreNom" /></td>
    </tr>
    <tr>
        <td>Prenom:</td>
        <td><asp:TextBox ID="txtPrenom" runat="server" Text="VotrePrenom" /></td>
    </tr>  
    <tr>
        <td>Date de naissance:</td>
        <td><asp:TextBox ID="txtDateNaiss" runat="server" Text="VotreNom" /></td>
    </tr>
    <tr>
        <td>Satut:</td>
        <td>
            <asp:DropDownList ID="ddStatut" runat="server">
                <asp:ListItem>Individuel</asp:ListItem>
                <asp:ListItem>Corporatif</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>Adresse:</td>
        <td><asp:TextBox ID="txtAdresse" runat="server" Text="VotreAdresse" /></td>
    </tr>
    <tr>
        <td>Code Postal:</td>
        <td><asp:TextBox ID="txtCodePostal" runat="server" Text="VotreCodePostal" /></td>
    </tr>
    <tr>
        <td>Ville:</td>
        <td><asp:TextBox ID="txtVille" runat="server" Text="VotreVille" /></td>
    </tr>
    <tr>
        <td>Pays:</td>
        <td><asp:TextBox ID="txtPays" runat="server" Text="VotrePays" /></td>
    </tr>
    <tr>
        <td>Téléphone:</td>
        <td><asp:TextBox ID="txtTel" runat="server" Text="VotreTéléphone" /></td>
    </tr>
</table>
<br />


    <asp:CheckBox ID="cbConfirmer" runat="server" 
        Text="Je confirme que les information présente sont nettement satisfesante" />
    <br />
    <asp:Button ID="btnModifier" runat="server" 
        Text="Modifier les information du profil" />


</asp:Content>
