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

End Class