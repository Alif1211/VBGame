Public Class Level5
    Dim increasement As Integer

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        ProgressBar1.Visible = True
        Button2.Enabled = False
        Label1.Text = "Installing VisualBasicOS"
        Label2.Text = "You are installing VisualBasicOS now"
        Label5.Text = "Installing..."
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            ProgressBar1.Value = ProgressBar1.Value + 1
            If ProgressBar1.Value = ProgressBar1.Maximum Then
                ProgressBar1.Visible = False
                Label1.Text = "Finish VisualBasicOS"
                Label2.Visible = False
                Label3.Text = "You have finished the VisualBasicOS Setup"
                Label4.Text = "Press Finish button to close"
                Label5.Visible = False
                Label6.Visible = False
                Button2.Visible = False
                Button3.Visible = True
                Timer1.Stop()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Level6.Show()
    End Sub
End Class