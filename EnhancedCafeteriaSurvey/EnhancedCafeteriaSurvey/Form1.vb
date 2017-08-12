Public Class CafeteriaServey
    Dim values(3, 1) As Integer
    Private Sub CafeteriaServey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox.Items.Add("Appels")
        ComboBox.Items.Add("Pizza")
        ComboBox.Items.Add("Tacos")
        ComboBox.Items.Add("Fish")
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit.Click
        Dim index As Integer = ComboBox.SelectedIndex
        If RadioButton1.Checked Then
            values(index, 0) += 1
        ElseIf RadioButton2.Checked Then
            values(index, 1) += 1
        End If
        ListBox.BeginUpdate()
        ListBox.Items.Clear()
        ListBox.Items.Add("Food" & ControlChars.Tab & ControlChars.Tab & "Like" _
                                 & ControlChars.Tab & ControlChars.Tab & "Dislike")
        For count As Integer = 0 To ComboBox.Items.Count - 1
            ListBox.Items.Add(ComboBox.Items(count).ToString &
            ControlChars.Tab &
            ControlChars.Tab & values(count, 0) &
            ControlChars.Tab & ControlChars.Tab &
            values(count, 1))
        Next count
        ListBox.EndUpdate()
    End Sub
End Class
