Public Class Level6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckPoint1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Level1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class