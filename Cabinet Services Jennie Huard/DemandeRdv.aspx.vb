Imports System.Net.Mail
Public Class DemandeRdv
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_Envoyer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Envoyer.Click
        Dim mail As MailMessage = New MailMessage()
        mail.To.Add("noreply.servicesfinanciersjh@gmail.com")
        mail.CC.Add(tb_monAdresse.Text)
        mail.From = New MailAddress("noreply.servicesfinanciersjh@gmail.com")
        mail.Subject = tb_objet.Text

        mail.Body = tb_text.Text + "<br />Répondre au client : " + tb_monAdresse.Text

        mail.IsBodyHtml = True
        Dim smtp As SmtpClient = New SmtpClient()
        smtp.Port = 587
        smtp.Host = "smtp.gmail.com"
        smtp.Credentials = New System.Net.NetworkCredential("noreply.servicesfinanciersjh@gmail.com", "qwer1234!")
        smtp.EnableSsl = True
        smtp.Send(mail)
        MsgBox("Votre message à bien été envoyé !")
    End Sub
End Class