Public Class Form1
    Dim randomGuess As Integer
    Dim prng As New Random
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.AcceptButton = guessButton
        guessButton.Enabled = False
    End Sub

    Private Sub newGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newGame.Click
        randomGuess = prng.Next(1001)
        guessBox.Text = ("")
        guessBox.Select()
        newGame.Enabled = False
        guessButton.Enabled = True
    End Sub


    Private Sub guessButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guessButton.Click

        Dim userGuess As Integer
        If Integer.TryParse(guessBox.Text, userGuess) Then
            resultLabel.Text = "Not even close!"
            Me.BackColor = Color.WhiteSmoke
            guessBox.SelectAll()
        End If

        If userGuess >= randomGuess - 200 And userGuess <= randomGuess + 200 Then
            Me.BackColor = Color.DarkBlue
            resultLabel.Text = "Really Cold!"
        End If

        If userGuess >= randomGuess - 150 And userGuess <= randomGuess + 150 Then
            resultLabel.Text = "Still Dang Cold!"
            Me.BackColor = Color.Blue
        End If

        If userGuess >= randomGuess - 100 And userGuess <= randomGuess + 100 Then
            resultLabel.Text = "Cool!"
            Me.BackColor = Color.RoyalBlue
        End If

        If userGuess >= randomGuess - 75 And userGuess <= randomGuess + 75 Then
            resultLabel.Text = "Warming Up!"
            Me.BackColor = Color.LightBlue
        End If

        If userGuess >= randomGuess - 50 And userGuess <= randomGuess + 50 Then
            resultLabel.Text = "Warming!"
            Me.BackColor = Color.LightSteelBlue
        End If
        If userGuess >= randomGuess - 25 And userGuess <= randomGuess + 25 Then
            resultLabel.Text = "Warming Up!"
            Me.BackColor = Color.DarkSalmon
        End If

        If userGuess >= randomGuess - 15 And userGuess <= randomGuess + 15 Then
            resultLabel.Text = "Seeing Red!"
            Me.BackColor = Color.LightCoral
        End If

        If userGuess >= randomGuess - 10 And userGuess <= randomGuess + 10 Then
            resultLabel.Text = "Getting Hot!"
            Me.BackColor = Color.IndianRed
        End If

        If userGuess >= randomGuess - 5 And userGuess <= randomGuess + 5 Then
            resultLabel.Text = "Smoking Hot!"
            Me.BackColor = Color.Red
        End If

        If userGuess = randomGuess Then
            resultLabel.Text = "You guessed my Number!"
            guessButton.Enabled = False
            Me.BackColor = Color.Green
            MsgBox("You Guessed My Number!", vbExclamation)
            newGame.Enabled = True
            guessButton.Enabled = False
        End If
        If userGuess > 1000 Or userGuess < 0 Then
            Me.BackColor = Color.WhiteSmoke
        End If
    End Sub
End Class
