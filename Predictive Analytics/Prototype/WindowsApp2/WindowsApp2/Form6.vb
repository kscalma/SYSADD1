Public Class Form6
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Forms.Form5.Text = Now.ToString
        My.Forms.Form5.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblPercentage1_6_Click(sender As Object, e As EventArgs) Handles lblPercentage1_6.Click

    End Sub

    Private Sub lblConcern1_6_Click(sender As Object, e As EventArgs) Handles lblConcern1_6.Click
        My.Forms.Form7.Text = Now.ToString
        My.Forms.Form7.Show()
    End Sub

    Private Sub lblConcern2_6_Click(sender As Object, e As EventArgs) Handles lblConcern2_6.Click
        My.Forms.Form9.Text = Now.ToString
        My.Forms.Form9.Show()
    End Sub

    Private Sub btnHome5_Click(sender As Object, e As EventArgs) Handles btnHome5.Click
        My.Forms.Form4.Text = Now.ToString
        My.Forms.Form4.Show()
    End Sub
End Class