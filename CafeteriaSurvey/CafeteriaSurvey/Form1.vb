Public Class CafeteriaSurvey
    Dim frequency() As String = {"", "", "", "", "", "", "", "", "", ""}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox.Items.Add("1")
        ComboBox.Items.Add("2")
        ComboBox.Items.Add("3")
        ComboBox.Items.Add("4")
        ComboBox.Items.Add("5")
        ComboBox.Items.Add("6")
        ComboBox.Items.Add("7")
        ComboBox.Items.Add("8")
        ComboBox.Items.Add("9")
        ComboBox.Items.Add("10")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim combo As Integer = ComboBox.SelectedItem.ToString
        lBox.Items.Clear()
        If combo = 1 Then
            frequency(0) &= "*"
        ElseIf combo = 2 Then
            frequency(1) &= "*"
        ElseIf combo = 3 Then
            frequency(2) &= "*"
        ElseIf combo = 4 Then
            frequency(3) &= "*"
        ElseIf combo = 5 Then
            frequency(4) &= "*"
        ElseIf combo = 6 Then
            frequency(5) &= "*"
        ElseIf combo = 7 Then
            frequency(6) &= "*"
        ElseIf combo = 8 Then
            frequency(7) &= "*"
        ElseIf combo = 9 Then
            frequency(8) &= "*"
        Else frequency(9) &= "*"
        End If
        lBox.Items.Add("Awful: " & frequency(0).ToString)
        lBox.Items.Add("2: " & frequency(1).ToString)
        lBox.Items.Add("3: " & frequency(2).ToString)
        lBox.Items.Add("4: " & frequency(3).ToString)
        lBox.Items.Add("5: " & frequency(4).ToString)
        lBox.Items.Add("6: " & frequency(5).ToString)
        lBox.Items.Add("7: " & frequency(6).ToString)
        lBox.Items.Add("8: " & frequency(7).ToString)
        lBox.Items.Add("9: " & frequency(8).ToString)
        lBox.Items.Add("Exellent: " & frequency(9))
    End Sub
End Class
