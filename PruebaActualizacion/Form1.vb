Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tssVersion.Text = "Version: " & My.Application.Info.Version.ToString
    End Sub
End Class
