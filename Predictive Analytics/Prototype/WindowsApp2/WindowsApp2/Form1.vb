Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_3(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_4(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnHomeLogin_Click(sender As Object, e As EventArgs) Handles btnHomeLogin.Click
        My.Forms.Form2.Text = Now.ToString
        My.Forms.Form2.Show()
    End Sub

    Private Sub btnSignHome_Click(sender As Object, e As EventArgs) Handles btnSignHome.Click
        My.Forms.Form3.Text = Now.ToString
        My.Forms.Form3.Show()
    End Sub
End Class
