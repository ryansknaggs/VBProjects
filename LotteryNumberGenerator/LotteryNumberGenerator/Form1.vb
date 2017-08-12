Imports System.Text

Public Class Form1
    Private Sub threeNumLotto_Click(sender As Object, e As EventArgs) Handles threeNumLotto.Click
        randomGenerator(3)
    End Sub

    Private Sub fourNumLotto_Click(sender As Object, e As EventArgs) Handles fourNumLotto.Click
        randomGenerator(4)
    End Sub

    Private Sub fiveNumLotto_Click(sender As Object, e As EventArgs) Handles fiveNumLotto.Click
        randomGenerator(5)
    End Sub

    Private Sub fiveNumPLoto_Click(sender As Object, e As EventArgs) Handles fiveNumPLoto.Click
        randomGenerator(6)
    End Sub

    Private Sub randomGenerator(lotoValue)
        Dim n1, n2, n3, n4, n5, n5p As Integer
        If lotoValue = 3 Then
            Dim v1 As Integer = T1.Text
            Dim v2 As Integer = T2.Text
            Dim v3 As Integer = T3.Text
            n1 = Int(Rnd() * 9) + 1
            n2 = Int(Rnd() * 9) + 1
            n3 = Int(Rnd() * 9) + 1
            threeNumTotal.Text = n1 & " " & n2 & " " & n3
            If v1 = n1 And v2 = n2 And v3 = n3 Then
                l3Win.Text = "WINNER!"
            End If
        ElseIf lotoValue = 4 Then
            Dim v1 As Integer = F1.Text
            Dim v2 As Integer = F2.Text
            Dim v3 As Integer = F3.Text
            Dim v4 As Integer = F4.Text
            n1 = Int(Rnd() * 9) + 1
            n2 = Int(Rnd() * 9) + 1
            n3 = Int(Rnd() * 9) + 1
            n4 = Int(Rnd() * 9) + 1
            fourNumTotal.Text = n1 & " " & n2 & " " & n3 & " " & n4
            If v1 = n1 And v2 = n2 And v3 = n3 And v4 = n4 Then
                l4Win.Text = "WINNER!"
            End If
        ElseIf lotoValue = 5 Then
            Dim v1 As Integer = FV1.Text
            Dim v2 As Integer = FV2.Text
            Dim v3 As Integer = FV3.Text
            Dim v4 As Integer = FV4.Text
            Dim v5 As Integer = FV5.Text
            n1 = Int(Rnd() * 39) + 1
            n2 = Int(Rnd() * 39) + 1
            n3 = Int(Rnd() * 39) + 1
            n4 = Int(Rnd() * 39) + 1
            n5 = Int(Rnd() * 39) + 1
            fiveNumTotal.Text = n1 & " " & n2 & " " & n3 & " " & n4 & " " & n5
            If v1 = n1 And v2 = n2 And v3 = n3 And v4 = n4 And v5 = n5 Then
                l5Win.Text = "WINNER!"
            End If
        ElseIf lotoValue = 6 Then
            Dim v1 As Integer = FVP1.Text
            Dim v2 As Integer = FVP2.Text
            Dim v3 As Integer = FVP3.Text
            Dim v4 As Integer = FVP4.Text
            Dim v5 As Integer = FVP5.Text
            Dim v6 As Integer = FVP6.Text
            n1 = Int(Rnd() * 49) + 1
            n2 = Int(Rnd() * 49) + 1
            n3 = Int(Rnd() * 49) + 1
            n4 = Int(Rnd() * 49) + 1
            n5 = Int(Rnd() * 49) + 1
            n5p = Int(Rnd() * 42) + 1
            fiveNumPTotal.Text = n1 & " " & n2 & " " & n3 & " " & n4 & " " & n5 & " + " & n5p
            If v1 = n1 And v2 = n2 And v3 = n3 And v4 = n4 And v5 = n5 And v6 = n5p Then
                l5PWin.Text = "WINNER!"
            End If
        End If
    End Sub
End Class
