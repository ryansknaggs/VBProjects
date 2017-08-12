Public Class Form1

    Private Sub squareButton_Click(sender As Object, e As EventArgs) Handles squareButton.Click
        twoDTextBox.Clear()
        Dim square As New Square(squareXSide.Text, squareYSide.Text)
        twoDTextBox.Text = square.ToString
    End Sub

    Private Sub circleButton_Click(sender As Object, e As EventArgs) Handles circleButton.Click
        twoDTextBox.Clear()
        Dim circle As New Circle(circleRadius.Text)
        twoDTextBox.Text = circle.ToString
    End Sub

    Private Sub cubeButton_Click(sender As Object, e As EventArgs) Handles cubeButton.Click
        threeDTextBox.Clear()
        Dim cube As New Cube(cubeXSide.Text, cubeYSide.Text, cubeZSide.Text)
        threeDTextBox.Text = (cube.ToString)
    End Sub

    Private Sub shpereButton_Click(sender As Object, e As EventArgs) Handles shpereButton.Click
        threeDTextBox.Clear()
        Dim sphere As New Sphere(shpereRadius.Text)
        threeDTextBox.Text = (sphere.ToString)
    End Sub
End Class
