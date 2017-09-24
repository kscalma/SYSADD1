Public Class Form2
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSign2_Click(sender As Object, e As EventArgs) Handles btnSign2.Click
        My.Forms.Form3.Text = Now.ToString
        My.Forms.Form3.Show()
    End Sub

    Private Sub txtUN2_TextChanged(sender As Object, e As EventArgs) Handles txtUN2.TextChanged

    End Sub

    Private Sub btnEnter2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEnter2.Click
        If txtUN2.Text = "davvid" And txtPass2.Text = "davvid" Then
            Form4.Show()

        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid")

        End If

    End Sub
End Class