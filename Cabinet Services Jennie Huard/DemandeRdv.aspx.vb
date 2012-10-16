Imports System.Net.Mail
Public Class DemandeRdv
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_Envoyer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Envoyer.Click
        Dim mail As MailMessage = New MailMessage()
        mail.To.Add("novaisjoey@gmail.com")
        mail.From = New MailAddress(tb_monAdresse.Text)
        mail.Subject = tb_objet.Text

        mail.Body = tb_text.Text

        mail.IsBodyHtml = True
        Dim smtp As SmtpClient = New SmtpClient()
        smtp.Host = "smtp.gmail.com"
        smtp.Credentials = New System.Net.NetworkCredential(tb_monAdresse.Text, tb_mdp.Text)
        smtp.EnableSsl = True
        smtp.Send(mail)
    End Sub
End Class