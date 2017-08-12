Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim f As Integer = TextBox1.Text
        Dim iOldFirstDigit As Integer = CInt(f.ToString.Substring(0, 1))
        Dim iOldSecondDigit As Integer = CInt(f.ToString.Substring(1, 1))
        Dim iOldThirdDigit As Integer = CInt(f.ToString.Substring(2, 1))
        Dim iOldFourthDigit As Integer = CInt(f.ToString.Substring(3, 1))

        Dim iNewFirstDigit As Integer = (iOldThirdDigit + 7) Mod 10
        Dim iNewSecondDigit As Integer = (iOldFourthDigit + 7) Mod 10
        Dim iNewThirdDigit As Integer = (iOldFirstDigit + 7) Mod 10
        Dim iNewFourthDigit As Integer = (iOldSecondDigit + 7) Mod 1
        TextBox2.Text = "Encrypted number is: " & iNewFirstDigit & iNewSecondDigit & iNewThirdDigit & iNewFourthDigit

    End Sub
End Class
