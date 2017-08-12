Imports System.IO
Public Class Form1
    Dim frequency(4) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox.Items.Add("1")
        ComboBox.Items.Add("2")
        ComboBox.Items.Add("3")
        ComboBox.Items.Add("4")
        ComboBox.Items.Add("5")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim combo As Integer = ComboBox.SelectedItem.ToString
        ListBox.Items.Clear()
        If combo = 1 Then
            frequency(0) += 1
        ElseIf combo = 2 Then
            frequency(1) += 1
        ElseIf combo = 3 Then
            frequency(2) += 1
        ElseIf combo = 4 Then
            frequency(3) += 1
        ElseIf combo = 5 Then
            frequency(4) += 1
        ElseIf combo = 6 Then
            frequency(5) += 1
        End If
        ListBox.Items.Add("1:   " & frequency(0).ToString)
        ListBox.Items.Add("2:   " & frequency(1).ToString)
        ListBox.Items.Add("3:   " & frequency(2).ToString)
        ListBox.Items.Add("4:   " & frequency(3).ToString)
        ListBox.Items.Add("5:   " & frequency(4).ToString)
    End Sub

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
                For j As Integer = 0 To frequency.Length - 1
                    sw.WriteLine(frequency(j))
                Next
            Else
                sw = File.AppendText(fileName)
            End If
            sw.Close()
        Catch ex As IOException
            MsgBox("Error writing to log file.")
        End Try
    End Sub
End Class
