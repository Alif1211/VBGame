Public Class CheckPoint1
    Dim hundred As Integer = 100

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Label3.Text = "" & hundred & ""
            hundred = hundred - 1
            If hundred = 0 Then
                Me.Hide()
                Level7.Show()
                Timer1.Stop()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckPoint1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class