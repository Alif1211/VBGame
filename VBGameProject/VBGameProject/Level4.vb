Public Class Level4

    Private Sub FixedSingleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FixedSingleToolStripMenuItem.Click
        Me.Hide()
        GameOver.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Visible = True
        Label3.Visible = True
        Label4.Visible = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Level5.Show()
    End Sub
End Class