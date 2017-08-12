Imports System.IO
Public Class Form1
    Dim ar() As String
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grade As String = TextBox1.Text
        ReDim Preserve ar(i)
        ar(i) = grade
        i += 1
        End Sub

        Private Sub SaveToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
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
                For j As Integer = 0 To ar.Length - 1
                    sw.WriteLine(ar(j))
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
