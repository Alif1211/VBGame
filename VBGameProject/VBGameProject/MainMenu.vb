Public Class MainMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Level1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        LoadLevel.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        AboutGame.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label1.Text = "Visual Basic Game"
            Button1.Text = "New Game"
            Button2.Text = "Load Game"
            Button3.Text = "About"
            Button4.Text = "Exit"
            CheckBox1.Text = "Non-debug Mode"
        Else
            Label1.Text = "Label1"
            Button1.Text = "Button1"
            Button2.Text = "Button2"
            Button3.Text = "Button3"
            Button4.Text = "Button4"
            CheckBox1.Text = "Button5"
        End If
    End Sub
End Class
