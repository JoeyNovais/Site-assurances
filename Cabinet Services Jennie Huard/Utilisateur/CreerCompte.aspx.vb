Public Class CreerCompte1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub btnEnvoyer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEnvoyer.Click
        Dim DateNaiss = New Date
        Dim CodePostal As String
        Dim Telephone As String = "("
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

    End Sub
End Class