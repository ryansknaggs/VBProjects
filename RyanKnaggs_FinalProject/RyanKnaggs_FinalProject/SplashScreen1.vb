Public NotInheritable Class SplashScreen1
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'create two progress bars
        'create two progress bars
        Dim ProgressBar1 As ProgressBar
        Dim ProgressBar2 As ProgressBar
        ProgressBar1 = New ProgressBar()
        ProgressBar2 = New ProgressBar()
        'set position
        ProgressBar1.Location = New Point(10, 10)
        ProgressBar2.Location = New Point(10, 50)
        'set values
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 200
        ProgressBar1.Value = 130
        ProgressBar2.Minimum = 0
        ProgressBar2.Maximum = 100
        ProgressBar2.Value = 40

        'add the progress bar to the form
        Me.Controls.Add(ProgressBar1)
        Me.Controls.Add(ProgressBar2)
        ProgressBar1.Show()
        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspoint.com"
        Me.ProgressBar1.Show()
    End Sub
End Class
