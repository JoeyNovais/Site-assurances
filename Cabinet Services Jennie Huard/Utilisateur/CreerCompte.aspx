<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="CreerCompte.aspx.vb" Inherits="Cabinet_Services_Jennie_Huard.CreerCompte1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            height: 33px;
        }
        .style2
        {
            height: 5px;
        }
        .style3
        {
            width: 692px;
        }
        .style4
        {
            height: 5px;
            width: 692px;
        }
        .style5
        {
            height: 33px;
            width: 692px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>Formulaire de demande d'inscription</h2>
<br />
<br />
<table style="width: 899px">
        <tr>
            <td>Identifiant :<asp:RequiredFieldValidator ID="rfvNomClient" runat="server" 
                    ControlToValidate="txtNomClient" ErrorMessage="* Entrez un identifiant." 
                    ForeColor="Red"> *</asp:RequiredFieldValidator>
            </td>
            <td class="style3"><asp:TextBox ID="txtNomClient" runat="server" MaxLength="50" ></asp:TextBox>
                <asp:Label ID="lblNomClient" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Mot de passe :<asp:RequiredFieldValidator ID="rfvMotPasse1" runat="server" 
                    ControlToValidate="txtMotPasse1" ErrorMessage="* Entrez un mot de passe." 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td class="style3"><asp:TextBox ID="txtMotPasse1" runat="server" MaxLength="50" TextMode="Password"></asp:TextBox>
                <asp:Label ID="lblMotPasse1" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Confirmer le mot de passe :<asp:RequiredFieldValidator ID="rfvMotPasse2" runat="server" 
                    ControlToValidate="txtMotPasse2" 
                    ErrorMessage="* Veuillez confirmer votre mot de passe." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td class="style3"><asp:TextBox ID="txtMotPasse2" runat="server" MaxLength="50" TextMode="Password"></asp:TextBox>
                <asp:Label ID="lblMotPasse2" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">Courriel :<asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtCourriel" 
                    ErrorMessage="* Entrez votre adresse courriel." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td class="style4"><asp:TextBox ID="txtCourriel" runat="server" MaxLength="100" ></asp:TextBox>
             &nbsp;&nbsp;&nbsp;
    <asp:RegularExpressionValidator ID="revCourriel" runat="server" 
        ControlToValidate="txtCourriel" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ForeColor="Red">L&#39;adresse courriel n&#39;est pas valide.</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Nom :<asp:RequiredFieldValidator ID="rfvNom" runat="server" 
                    ControlToValidate="txtNom" ErrorMessage="* Entrez un nom." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td class="style3"><asp:TextBox ID="txtNom" runat="server" MaxLength="100" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Prénom :<asp:RequiredFieldValidator ID="rfvPrenom" runat="server" 
                    ControlToValidate="txtPrenom" ErrorMessage="* Entrez un prénom." 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td class="style3"><asp:TextBox ID="txtPrenom" runat="server" MaxLength="50" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">Date de naissance :</td>
            <td class="style5">Année : 
                <asp:RequiredFieldValidator ID="rfvAnnee" runat="server" 
                    ControlToValidate="txtAnnee" ErrorMessage="* Entrez une année." ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="txtAnnee" runat="server" MaxLength="4" Width="50px">AAAA</asp:TextBox> &nbsp;<asp:RangeValidator 
                    ID="rvAnnee" runat="server" ErrorMessage="* L'année n'est pas valide" 
                    ForeColor="Red" MinimumValue="1900" ControlToValidate="txtAnnee" 
                    MaximumValue="9999" Type="Integer">*</asp:RangeValidator>
                Mois :
                <asp:RequiredFieldValidator ID="rfvMois" runat="server" 
                    ControlToValidate="txtMois" ErrorMessage="* Entrez un Mois." ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="txtMois" runat="server" MaxLength="2" Width="25px">MM</asp:TextBox>&nbsp;<asp:RangeValidator 
                    ID="rvMois" runat="server" ErrorMessage="* Le mois doit être compris entre 1 et 12" 
                    ForeColor="Red" MinimumValue="1" ControlToValidate="txtMois" 
                    MaximumValue="12" Type="Integer">*</asp:RangeValidator>
                Jour : 
                <asp:RequiredFieldValidator ID="rfvJour" runat="server" 
                    ControlToValidate="txtJour" ErrorMessage="* Entrez un jour." ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="txtJour" runat="server" MaxLength="2" Width="25px">JJ</asp:TextBox>
            &nbsp;<asp:RangeValidator 
                    ID="rvJour" runat="server" ErrorMessage="* Le jour entré doit être compris entre 1 et 31" 
                    ForeColor="Red" MinimumValue="1" ControlToValidate="txtJour" 
                    MaximumValue="31" Type="Integer">*</asp:RangeValidator>
                &nbsp;<asp:Label ID="lblDate" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Type :</td>
            <td class="style3">
                <asp:DropDownList ID="ddTypeClient" runat="server">
                    <asp:ListItem Value="P">Personnel</asp:ListItem>
                    <asp:ListItem Value="C">Corporatif</asp:ListItem>
                    <asp:ListItem Value="A">Travail autonome</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
          <tr>
            <td>Statut Marital :</td>
            <td class="style3">
                <asp:DropDownList ID="ddStatutMarital" runat="server">
                    <asp:ListItem Value="C">Célibataire</asp:ListItem>
                    <asp:ListItem Value="M">Marié</asp:ListItem>
                    <asp:ListItem Value="D">Divorcé</asp:ListItem>
                    <asp:ListItem Value="E">Conjoint</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
         <tr>
            <td>Téléphone :<asp:RequiredFieldValidator ID="rfvTelephone" runat="server" 
                    ControlToValidate="txtTelephone" ErrorMessage="* Entrez un Téléphone." 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
             </td>
            <td class="style3"><asp:TextBox ID="txtTelephone" runat="server" MaxLength="13" >(888)888-8888</asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:RegularExpressionValidator ID="revTelephone" runat="server" 
        ControlToValidate="txtTelephone" 
        ValidationExpression="[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" 
                    ForeColor="Red">Le numéro de téléphone n&#39;est pas valide.</asp:RegularExpressionValidator>
             </td>
        </tr>
         <tr>
            <td>Adresse :<asp:RequiredFieldValidator ID="rfvAdresse" runat="server" 
                    ControlToValidate="txtAdresse" ErrorMessage="* Entrez une adresse." 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
             </td>
            <td class="style3"><asp:TextBox ID="txtAdresse" runat="server" MaxLength="120" ></asp:TextBox>
             </td>
        </tr>
        <tr>
            <td>Code Postal :<asp:RequiredFieldValidator ID="rfvCodePostal" runat="server" 
                    ControlToValidate="txtCodePostal" ErrorMessage="* Entrez un code postal." 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td class="style3"><asp:TextBox ID="txtCodePostal" runat="server" MaxLength="6" >A1A1A1</asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="revCodePostal" runat="server" 
                    ControlToValidate="txtCodePostal" ForeColor="Red"
                    ValidationExpression="^(\d{5}-\d{4}|\d{5}|\d{9})$|^([a-zA-Z]\d[a-zA-Z]( )?\d[a-zA-Z]\d)$">Le code postal n&#39;est pas valide.</asp:RegularExpressionValidator>
            </td>
        </tr>
         <tr>
            <td>Ville :<asp:RequiredFieldValidator ID="rfvVille" runat="server" 
                    ControlToValidate="txtVille" ErrorMessage="* Entrez une ville." 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
             </td>
            <td class="style3"><asp:TextBox ID="txtVille" runat="server" MaxLength="40" ></asp:TextBox>
             </td>
        </tr>
        <tr>
            <td class="style1">Pays :<asp:RequiredFieldValidator ID="rfvPays" runat="server" 
                    ControlToValidate="txtPays" ErrorMessage="* Entrez un pays." 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td class="style5"><asp:TextBox ID="txtPays" runat="server" MaxLength="20" ></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:ValidationSummary ID="vsErreurs" runat="server" ForeColor="Red" 
        HeaderText="Certaines erreurs sont survenues :" DisplayMode="List" 
        Width="896px" />
    <br />
    Précisions : 
    <br />
    <br />
    <asp:TextBox ID="txtMessage" runat="server" Height="200px" MaxLength="4000" 
        TextMode="MultiLine" Width="500px" CssClass="Message" Text="Entrez votre message ici."></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnEnvoyer" runat="server" Text="Envoyer la demande." />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

