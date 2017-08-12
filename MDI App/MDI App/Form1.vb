Public Class Form1
    Dim child As Form2
    Dim sizeF As Double = 10.8
    Dim fonts As String
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        child = New Form2()
        child.Text = "Text Box"
        child.MdiParent = Me ' set parent
        child.Show() ' display child
    End Sub

    ' set Cascade layout
    Private Sub cascadeToolStripMenuItem_Click(
       ByVal sender As System.Object, ByVal e As System.EventArgs) _
       Handles cascadeToolStripMenuItem.Click

        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub ' cascadeToolStripMenuItem_Click

    ' set TileHorizontal layout
    Private Sub tileHorizontalToolStripMenuItem_Click(
       ByVal sender As System.Object, ByVal e As System.EventArgs) _
       Handles tileHorizontalToolStripMenuItem.Click

        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub ' tileHorizontalToolStripMenuItem_Click

    ' set TileVertical layout
    Private Sub tileVerticalToolStripMenuItem_Click(
       ByVal sender As System.Object, ByVal e As System.EventArgs) _
       Handles tileVerticalToolStripMenuItem.Click

        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub ' tileVerticalToolStripMenuItem_Click


    Private Sub TimesNewRomanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimesNewRomanToolStripMenuItem.Click
        For Each Ctl As Control In Me.ActiveMdiChild.Controls
            If Ctl.Name = "TextBox1" Then
                Ctl.Font = New Font("TimesNewRoman", sizeF)
                fonts = "TimesNewRoman"
            End If
        Next
    End Sub

    Private Sub GeorgiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeorgiaToolStripMenuItem.Click
        For Each Ctl As Control In Me.ActiveMdiChild.Controls
            If Ctl.Name = "TextBox1" Then
                Ctl.Font = New Font("Georgia", sizeF)
                fonts = "Georgia"
            End If
        Next
    End Sub

    Private Sub CenturyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CenturyToolStripMenuItem.Click
        For Each Ctl As Control In Me.ActiveMdiChild.Controls
            If Ctl.Name = "TextBox1" Then
                Ctl.Font = New Font("Century", sizeF)
                fonts = "Century"
            End If
        Next
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        For Each Ctl As Control In Me.ActiveMdiChild.Controls
            If Ctl.Name = "TextBox1" Then
                sizeF = 8
                Ctl.Font = New Font(fonts, sizeF)
            End If
        Next
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        For Each Ctl As Control In Me.ActiveMdiChild.Controls
            If Ctl.Name = "TextBox1" Then
                sizeF = 12
                Ctl.Font = New Font(fonts, sizeF)
            End If
        Next
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click

        For Each Ctl As Control In Me.ActiveMdiChild.Controls
            If Ctl.Name = "TextBox1" Then
                sizeF = 14
                Ctl.Font = New Font(fonts, sizeF)
            End If
        Next
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        For Each Ctl As Control In Me.ActiveMdiChild.Controls
            If Ctl.Name = "TextBox1" Then
                Ctl.ForeColor = Color.Red

            End If
        Next
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        For Each Ctl As Control In Me.ActiveMdiChild.Controls
            If Ctl.Name = "TextBox1" Then
                Ctl.ForeColor = Color.Green

            End If
        Next
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        For Each Ctl As Control In Me.ActiveMdiChild.Controls
            If Ctl.Name = "TextBox1" Then
                Ctl.ForeColor = Color.Blue

            End If
        Next
    End Sub

    Private Sub BlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem.Click
        For Each Ctl As Control In Me.ActiveMdiChild.Controls
            If Ctl.Name = "TextBox1" Then
                Ctl.ForeColor = Color.Black

            End If
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CloseChildToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseChildToolStripMenuItem.Click
        Me.ActiveMdiChild.Close()
    End Sub
End Class
