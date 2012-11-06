Imports System.Net.Mail
Public Class CreerCompte1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub btnEnvoyer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEnvoyer.Click
        Dim DemandeIns As New CDemandeIns()
        Dim DateNaiss = New Date
        Dim CodePostal As String
        Dim Telephone As String = "("
        Dim Identifiant As String = txtNomClient.Text
        Dim Verif As String = ""
        Dim i As Integer
        lblDate.Text = ""
        lblMessage.Text = ""
        lblMotPasse1.Text = ""
        lblMotPasse2.Text = ""
        lblNomClient.Text = ""

        If txtMotPasse1.Text.Length < 6 Then
            lblMotPasse1.Text = "Le mot de passe doit contenir au minimum 6 caractères."
        Else
            If Not txtMotPasse1.Text = txtMotPasse2.Text Then
                lblMotPasse2.Text = "Les mots de passes doivent être identiques."
            End If
        End If

        Try
            DateNaiss = Convert.ToDateTime(String.Format("{0}-{1}-{2}", Convert.ToInt32(txtAnnee.Text), Convert.ToInt32(txtMois.Text), Convert.ToInt32(txtJour.Text)))
        Catch ex As Exception
            lblDate.Text = "La date entrée est invalide."
        End Try

        While i < txtTelephone.Text.Length
            If txtTelephone.Text(i) >= Chr(48) And txtTelephone.Text <= Chr(57) Then
                Telephone = Telephone & txtTelephone.Text(i)
                If Telephone.Length = 4 Then
                    Telephone = Telephone & ")"
                End If
                If Telephone.Length = 8 Then
                    Telephone = Telephone & "-"
                End If

            End If
            i = i + 1
        End While
        txtTelephone.Text = Telephone
        CodePostal = txtCodePostal.Text.ToUpper
        txtCodePostal.Text = CodePostal
        If Identifiant.Length < 6 Then
            lblNomClient.Text = "Le nom d'identifiant entré doit contenir au minimum 6 caractères."
        Else
            Verif = DemandeIns.Verifier(Identifiant)
            If Not Verif = "" Then
                lblNomClient.Text = Verif
            End If
        End If

        If lblDate.Text = "" And lblMotPasse1.Text = "" And lblMotPasse2.Text = "" And lblNomClient.Text = "" Then
            Verif = DemandeIns.CreerDemandeIns(Identifiant, txtMotPasse1.Text, txtCourriel.Text, txtNom.Text, txtPrenom.Text, DateNaiss, ddTypeClient.SelectedValue, Telephone, CodePostal, ddStatutMarital.SelectedValue, txtVille.Text, txtAdresse.Text, txtPays.Text, txtMessage.Text)

            If Verif = "Vous avez été inscrit avec succès" Then
                lblMessage.ForeColor = Drawing.ColorTranslator.FromHtml("#00CC00")
                Try
                    Dim Email As MailMessage = New MailMessage()
                    Email.To.Add(txtCourriel.Text)
                    Email.CC.Add("noreply.servicesfinanciersjh@gmail.com")
                    Email.From = New MailAddress("noreply.servicesfinanciersjh@gmail.com")
                    Email.Subject = "Inscription sur le site du Cabinet de Services Financiers Jennie Huard Inc."

                    Email.Body = "Vous êtes maintenant inscrit sur le site de Jennie Huard Inc. <br /><br /> Votre nom d'Identifiant : " & Identifiant & "<br /><br /> Votre mot de passe : " & txtMotPasse1.Text & "<br /><br />"

                    Email.IsBodyHtml = True
                    Dim Etampe As SmtpClient = New SmtpClient()
                    Etampe.Port = 587
                    Etampe.Host = "smtp.gmail.com"
                    Etampe.Credentials = New System.Net.NetworkCredential("noreply.servicesfinanciersjh@gmail.com", "qwer1234!")
                    Etampe.EnableSsl = True
                    Etampe.Send(Email)
                    Verif = Verif & " et un courriel vous a été envoyé!"
                Catch
                    lblMessage.ForeColor = Drawing.ColorTranslator.FromHtml("#FF6600")
                    Verif = Verif & ", mais l'envoi de courriel sur votre adresse a échoué."
                End Try
            Else
                lblMessage.ForeColor = Drawing.ColorTranslator.FromHtml("#CC0000")
            End If

            lblMessage.Text = Verif
        End If


    End Sub
End Class