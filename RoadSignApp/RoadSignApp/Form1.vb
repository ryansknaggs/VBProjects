Public Class Form1
    Dim randomObject As New Random()
    Dim nextFlag As Integer = randomObject.Next(0, 11)
    Dim signs() As String = {"no entry", "road narrows", "no bikes", "no left",
      "no walking", "no uturn", "road reduction", "stop", "stop ahead", "traffic light", "road curvs", "yield"}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim input As String = ComboBox.SelectedItem.ToString
        If input = signs(nextFlag).ToString Then
            answerLabel.Text = "YOU ARE CORRECT"
            nextFlag = ImageFunction(randomObject.Next(0, 11))
        Else answerLabel.Text = "TRY AGIAN"
        End If
    End Sub

    Function ImageFunction(ByVal nextS As Integer)
        Dim pictureResource = My.Resources.ResourceManager.GetObject(signs(nextS))
        PictureBox1.Image = CType(pictureResource, Image)
        Return nextS
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pictureResource = My.Resources.ResourceManager.GetObject(signs(nextFlag))
        PictureBox1.Image = CType(pictureResource, Image)
        ComboBox.Items.Add("no entry")
        ComboBox.Items.Add("road narrows")
        ComboBox.Items.Add("no bikes")
        ComboBox.Items.Add("no left")
        ComboBox.Items.Add("no walking")
        ComboBox.Items.Add("no uturn")
        ComboBox.Items.Add("road reduction")
        ComboBox.Items.Add("stop")
        ComboBox.Items.Add("stop ahead")
        ComboBox.Items.Add("traffic light")
        ComboBox.Items.Add("road curvs")
        ComboBox.Items.Add("yield")
    End Sub
End Class
