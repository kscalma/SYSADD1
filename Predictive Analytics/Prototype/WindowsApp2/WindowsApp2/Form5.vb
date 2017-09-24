Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMcr5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCpr5.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblDate1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblReportname5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnInspect5.Click
        My.Forms.Form6.Text = Now.ToString
        My.Forms.Form6.Show()
    End Sub

    Private Sub btnHome5_Click(sender As Object, e As EventArgs) Handles btnHome5.Click
        My.Forms.Form4.Text = Now.ToString
        My.Forms.Form4.Show()
    End Sub
End Class