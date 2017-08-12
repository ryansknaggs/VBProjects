Imports System.IO
Public Class WordGenerator
    Dim letters(,) As String = {{" ", " ", " "},
 {" ", " ", " "}, {"A", "B", "C"}, {"D", "E", "F"},
 {"G", "H", "I"}, {"J", "K", "L"}, {"M", "N", "O"},
 {"P", "R", "S"}, {"T", "U", "V"}, {"W", "X", "Y"}}

    Dim keys() As Integer = New Integer(6) {}
    Dim phoneNumber As Integer
    Dim number, display As String

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim result As DialogResult
        Dim fileName As String
        Using fileChooser As New SaveFileDialog()
            result = fileChooser.ShowDialog()
            fileName = fileChooser.FileName
        End Using
        Dim sw As StreamWriter
        Try
            If (Not File.Exists(fileName)) Then
                sw = File.CreateText(fileName)
                For j As Integer = 0 To keys.Length - 1
                    sw.WriteLine(display)
                Next
            Else
                sw = File.AppendText(fileName)
            End If
            sw.Close()
        Catch ex As IOException
            MsgBox("Error writing to log file.")
        End Try
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        number = phoneNum.Text
        phoneNumber = Convert.ToInt32(number)
        For i As Integer = 6 To 0 Step -1
            keys(i) = phoneNumber Mod 10
            phoneNumber \= 10
        Next
        For l1 = 0 To 2
            For l2 = 0 To 2
                For l3 = 0 To 2
                    For l4 = 0 To 2
                        For l5 = 0 To 2
                            For l6 = 0 To 2
                                For l7 = 0 To 2
                                    display &= String.Format("{0, -10}", letters(keys(0), l1) &
                                            letters(keys(1), l2) & letters(keys(2), l3) &
                                            letters(keys(3), l4) & letters(keys(4), l5) &
                                            letters(keys(5), l6) & letters(keys(6), l7))
                                Next l7
                            Next l6
                        Next l5
                    Next l4
                Next l3
            Next l2
        Next l1
        resultBox.AppendText(display)
    End Sub
End Class
