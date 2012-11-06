Imports System.Net.Mail
Imports System.Data.OleDb

Public Class GestionAssurances
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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