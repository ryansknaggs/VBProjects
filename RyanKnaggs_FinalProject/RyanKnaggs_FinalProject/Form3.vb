Public Class Form3
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        If ProgressBar1.Value >= 100 Then
            'set the value to minimum value which is equal to zero
            ProgressBar1.Value = 100

            'Timer1.Enabled = False
            Me.Visible = False
        Else
            'increment the value of progress bar by 1
            ProgressBar1.Value = ProgressBar1.Value + 1
            'display the current percent of the progress.
            Me.Label1.Text = ProgressBar1.Value & "% Completing..."
        End If
    End Sub
End Class