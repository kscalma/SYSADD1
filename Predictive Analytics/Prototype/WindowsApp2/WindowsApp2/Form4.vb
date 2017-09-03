Public Class Form4
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblWelcome4.Click

    End Sub

    Private Sub btnMcr4_Click(sender As Object, e As EventArgs) Handles btnMcr4.Click
        My.Forms.Form5.Text = Now.ToString
        My.Forms.Form5.Show()
    End Sub
End Class