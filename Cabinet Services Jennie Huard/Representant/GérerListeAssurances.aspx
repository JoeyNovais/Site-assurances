<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="GérerListeAssurances.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.GérerListeAssurances" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Gestion de la liste des assurances:</h2>
    <asp:Button ID="btn_Save" runat="server" Text="Enregistrer les modifications" />
    <br />
    <asp:Table ID="tbl_Assurances" runat="server">
        <asp:TableRow ID="TableRow1" runat="server" TableSection="TableHeader">
            <asp:TableCell ID="Nom" runat="server">Nom</asp:TableCell>
            <asp:TableCell ID="Lien" runat="server">Lien</asp:TableCell>
            <asp:TableCell ID="Image" runat="server">Image actuelle</asp:TableCell>
            <asp:TableCell ID="RemplacementImage" runat="server">Image de remplacement</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <h3>Ajouter une assurance à la liste:</h3>
    <asp:Label ID="Label1" runat="server" Text="Nom :"></asp:Label>
    <asp:TextBox ID="tb_Nom"
        runat="server"></asp:TextBox>
    <br />
        <asp:Label ID="Label2" runat="server" Text="Lien :"></asp:Label>
    <asp:TextBox ID="tb_Lien"
        runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Image :"></asp:Label>
            <asp:FileUpload ID="fu_Image" runat="server" />
    <br />
    <asp:Button ID="btn_Ajout" runat="server" Text="Ajouter" />
</asp:Content>
