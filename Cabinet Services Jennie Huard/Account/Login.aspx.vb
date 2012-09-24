Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString("ReturnUrl"))
    End Sub

    Sub lala()
        If (Page.IsValid) Then
            Response.Redirect("/Account/Client/MonProfil.aspx")
        End If
    End Sub

End Class