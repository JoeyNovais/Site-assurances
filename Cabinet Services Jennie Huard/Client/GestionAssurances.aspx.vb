Imports System.Net.Mail
Imports System.Data.OleDb

Public Class GestionAssurances
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Client As CClient = New CClient("Novais", "Joey", "novaisjoey@gmail.com")
        'MsgBox("Connexion=" & res.ToString)
        Dim res As ArrayList = Client.AssuranceClient()
        Dim i As Integer

        'MsgBox("Assurance = " & res.ToString)
        While i < res.Count - 4

            Dim Ligne As New TableRow
            'MsgBox("" + reader.GetString(0) + " " + reader.GetString(1))

            Dim Cellule As New TableCell
            Cellule.Text = res.Item(i)
            Ligne.Cells.Add(Cellule)

            Cellule = New TableCell
            Cellule.Text = "<a href=" & Chr(34) & res.Item(i + 2) & Chr(34) & " target=" & Chr(34) & "_blank" & Chr(34) & " ><img src=" & Chr(34) & res.Item(i + 1) & Chr(34) & " width='60px' height='40px' alt=" & Chr(34) & res.Item(i + 3) & Chr(34) & " /></a><a href=" & Chr(34) & res.Item(i + 2) & Chr(34) & " target=" & Chr(34) & "_blank" & Chr(34) & " >" & res.Item(i + 3) & "</a>"
            Ligne.Cells.Add(Cellule)

            Cellule = New TableCell
            Cellule.Text = res.Item(i + 4)
            Ligne.Cells.Add(Cellule)

            TableAssurance.Rows.Add(Ligne)
            i = i + 5
        End While
    End Sub

    Protected Sub btn_Envoi_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Envoi.Click
        Dim client As CClient = New CClient("Axel", "admin123")
        Dim demandeClient As CDemandeClient = New CDemandeClient(client, tb_Body.Text)
        Dim mail As MailMessage = New MailMessage()
        mail.To.Add("noreply.servicesfinanciersjh@gmail.com")
        mail.CC.Add(client.Courriel)
        mail.From = New MailAddress("noreply.servicesfinanciersjh@gmail.com")
        mail.Subject = "Demande de changement d'assurance de " + client.Nom + client.Prenom

        mail.Body = tb_Body.Text +
        "<br />Client : " + client.Nom + " " + client.Prenom + " " + client.DateNaiss + " " + client.StatutMarital + " " + client.Type +
        "<br />Adresse : " + client.Adresse + " " + client.Ville + " " + client.CodePostal + " " + client.Pays +
        "<br />Coordonnées : " + client.Telephone + " " + client.Courriel

        mail.IsBodyHtml = True
        Dim smtp As SmtpClient = New SmtpClient()
        smtp.Host = "smtp.gmail.com"
        smtp.Credentials = New System.Net.NetworkCredential("noreply.servicesfinanciersjh@gmail.com", "qwer1234!")
        smtp.EnableSsl = True
        smtp.Send(mail)
    End Sub
End Class