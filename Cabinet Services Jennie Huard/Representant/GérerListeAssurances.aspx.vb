Imports System.Data.OleDb

Public Class GérerListeAssurances
    Inherits System.Web.UI.Page
    Private representant As CRepresentant
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        representant = New CRepresentant("admin", "admin123")
        representant.Compagnies(tbl_Assurances)
    End Sub

    Protected Sub btn_Ajout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Ajout.Click
        Dim Nom As String = "'" + tb_Nom.Text + "'"
        Dim Lien As String = If(tb_Lien.Text = "", "DEFAULT", "'" + tb_Lien.Text + "'")
        Dim Image As FileUpload = fu_Image
        Dim NomImage As String = If(Image.HasFile = False, "DEFAULT", "'Image/" + Image.FileName + "'")
        If Image.HasFile Then
            Try
                Image.SaveAs(System.AppDomain.CurrentDomain.BaseDirectory() & "Image\" + Image.FileName)
            Catch ex As Exception
                MsgBox("Erreur lors du transfert de l'image !")
            End Try
        End If
        representant.AjoutCompagnie(Nom, Lien, NomImage)
        Response.Redirect("/Representant/GérerListeAssurances.aspx")
    End Sub

    Protected Sub btn_Save_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Save.Click
        representant.Save(tbl_Assurances)
        MsgBox("Modifications enregistrées!")
        Response.Redirect("/Representant/GérerListeAssurances.aspx")
    End Sub

End Class