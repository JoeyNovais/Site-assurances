<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="DemandeRdv.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.DemandeRdv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Mon adresse mail : "></asp:Label>
    <asp:TextBox ID="tb_monAdresse" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfv_adresseMail" runat="server" 
        ControlToValidate="tb_monAdresse" ErrorMessage="Ce champ est requis"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="REV_adresseMail" runat="server" 
        ControlToValidate="tb_monAdresse" 
        ErrorMessage="Ce n'est pas une adresse mail valide" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Mot de passe : "></asp:Label>
    <asp:TextBox ID="tb_mdp" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Objet de la demande : "></asp:Label>
    <asp:TextBox ID="tb_objet" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="tb_text" runat="server" Height="165px" TextMode="MultiLine" 
        Width="666px">Je souhaite obtenir un rendez-vous afin de : </asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btn_Envoyer" runat="server" Text="Envoyer" />
</asp:Content>
