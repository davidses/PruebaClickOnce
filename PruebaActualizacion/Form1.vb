Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tssVersion.Text = "Ver. " & My.Application.Deployment.CurrentVersion.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class
