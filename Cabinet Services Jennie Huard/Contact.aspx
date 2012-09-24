<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Contact.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
          <tr>
            <td>Prénom:</td>
            <td><asp:TextBox ID="txtPrenom" runat="server"></asp:TextBox></td>
          </tr>
          <tr>
            <td>Nom:</td>
            <td><asp:TextBox ID="txtNom" runat="server"></asp:TextBox></td>
          </tr>
          <tr>
            <td>Adresse:</td>
            <td><asp:TextBox ID="txtAdresse" runat="server"></asp:TextBox></td>
          </tr>
    </table>
    
    <br />
    Mon Message est liée à:<br />
    <asp:DropDownList ID="ddMess" runat="server">
        <asp:ListItem>--Choisissez un sujet--</asp:ListItem>
        <asp:ListItem>Créer un compte</asp:ListItem>
        <asp:ListItem>Modifier un compte déja existant</asp:ListItem>
        <asp:ListItem>Modifier ses assurances</asp:ListItem>
        <asp:ListItem>Gérer mes assurances</asp:ListItem>
        <asp:ListItem>Autres</asp:ListItem>
    </asp:DropDownList>
    <br />
    Veuillez composer votre message
    <br />
    <asp:TextBox ID="txtMessage" runat="server" Height="156px" Width="481px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnEnvoyer" runat="server" Text="Envoyer le message" 
        Width="139px" />
    <br />
</asp:Content>
