<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ContacterClient.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.ContacterClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
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
        <asp:TextBox ID="tb_Texte" runat="server" Height="114px" 
            style="margin-left: 14px" Width="791px" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
        <asp:Button ID="btn_Envoyer" runat="server" Text="Envoyer" />

</asp:Content>
