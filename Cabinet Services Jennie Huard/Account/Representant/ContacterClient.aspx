<%@ Page Title="Page d'accueil" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="ContacterClient.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Contacter un client:</h2>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Adresse courriel :"></asp:Label>
    <asp:TextBox ID="tb_AdresseCourriel" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Objet :"></asp:Label>
    <asp:TextBox ID="tb_Objet" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Height="114px" 
        style="margin-left: 14px" Width="791px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btn_Envoyer" runat="server" Text="Envoyer" />
</asp:Content>
