<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="MesAssurances.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.MesAssurances" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    Mes assurances:
    <table>
        <tr>
            <th>type Assurance</th>
            <th></th>
            <th>Vos Assurances</th>
        </tr>
        <tr>
            <td>Vie</td>
            <td><img src="/Image/desjardin.png" alt="logo desjardin"/> </td>
            <td>Desjardins and stuff</td>
        </tr>
        <tr>
            <td>Automobile</td>
            <td><img src="/Image/caa.jpg" /></td>
            <td>CAA Québec and stuff</td>
        </tr>
    </table>
    <asp:Button ID="btn_rdv" runat="server" Text="Demander un rendez-vous" 
        PostBackUrl="~/Client/DemandeRdv.aspx" />  
    <asp:Button ID="btn_gestionAssurance" runat="server" 
        Text="Demander à changer d'assurance(s)" 
        PostBackUrl="~/Client/GestionAssurances.aspx" />
</asp:Content>
