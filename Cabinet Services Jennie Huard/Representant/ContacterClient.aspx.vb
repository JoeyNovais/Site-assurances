﻿Public Class ContacterClient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim idPro As String = Request.QueryString("idPro")
        'MsgBox(idPro)
    End Sub

End Class