Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SpanishToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpanishToolStripMenuItem.Click
        Me.Label1.Text = "Hola Mundo!"
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglishToolStripMenuItem.Click
        Me.Label1.Text = "Hello world ..."
    End Sub


    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Me.Label1.ForeColor = Color.White
        Me.Label1.BackColor = Color.Blue
    End Sub

    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.Click
        Me.Label1.ForeColor = Color.White
        Me.Label1.BackColor = Color.Black
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        Me.Label1.ForeColor = Color.Black
        Me.Label1.BackColor = Color.Red
    End Sub

    Private Sub FrenchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrenchToolStripMenuItem.Click
        Me.Label1.Text = "Bonjour Monde."
    End Sub

End Class
