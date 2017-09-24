Public Class Form3
    Private Sub btnLogin3_Click(sender As Object, e As EventArgs) Handles btnLogin3.Click
        My.Forms.Form2.Text = Now.ToString
        My.Forms.Form2.Show()
    End Sub

    Private Sub btnEnter3_Click(sender As Object, e As EventArgs) Handles btnEnter3.Click
        My.Forms.Form1.Text = Now.ToString
        My.Forms.Form1.Show()

    End Sub
End Class