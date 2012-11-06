<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GestionAssurances.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.GestionAssurances" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Demande de changement d'assurance:</h2>
    <br />
    <asp:TextBox ID="tb_Body" runat="server" Height="146px" TextMode="MultiLine" 
        Width="649px">Je souhaite obtenir un rendez-vous afin de :</asp:TextBox>

    <br />
    <br />
    <asp:Button ID="btn_Envoi" runat="server" Text="Envoyer" />
</asp:Content>

