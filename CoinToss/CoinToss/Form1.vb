Public Class CoinToss
    Dim randomObject As New Random()
    Dim headscount As Integer
    Dim tailscount As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tossButton.Click
        DisplayCoin(flipCoin())
    End Sub

    Function flipCoin() As Boolean
        Dim flip As Integer
        flip = randomObject.Next(0, 2)
        If flip = 0 Then
            tailscount += 1
            tailL.Text = CStr(tailscount)
            Return True
        Else
            headscount += 1
            headsL.Text = CStr(headscount)
            Return False
        End If
    End Function

    Sub DisplayCoin(ByRef intCoinFace As Boolean)
        Dim coin As String
        If intCoinFace = True Then
            coin = "tails"
        Else coin = "heads"
        End If
        Dim pictureResource = My.Resources.ResourceManager.GetObject(
            String.Format(coin, intCoinFace))
        coinPictureBox.Image = CType(pictureResource, Image)
    End Sub
End Class
