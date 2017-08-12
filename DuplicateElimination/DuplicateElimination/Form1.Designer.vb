<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DuplicateElimination
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Submit = New System.Windows.Forms.Button()
        Me.numberBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uniqueValuesListBox = New System.Windows.Forms.ListBox()
        Me.numbersEnteredListBox = New System.Windows.Forms.ListBox()
        Me.display = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(152, 24)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(69, 27)
        Me.Submit.TabIndex = 0
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'numberBox
        '
        Me.numberBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberBox.Location = New System.Drawing.Point(4, 27)
        Me.numberBox.Name = "numberBox"
        Me.numberBox.Size = New System.Drawing.Size(142, 23)
        Me.numberBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Number (1 - 20)"
        '
        'uniqueValuesListBox
        '
        Me.uniqueValuesListBox.FormattingEnabled = True
        Me.uniqueValuesListBox.ItemHeight = 15
        Me.uniqueValuesListBox.Location = New System.Drawing.Point(5, 80)
        Me.uniqueValuesListBox.Name = "uniqueValuesListBox"
        Me.uniqueValuesListBox.Size = New System.Drawing.Size(141, 184)
        Me.uniqueValuesListBox.TabIndex = 3
        '
        'numbersEnteredListBox
        '
        Me.numbersEnteredListBox.FormattingEnabled = True
        Me.numbersEnteredListBox.ItemHeight = 15
        Me.numbersEnteredListBox.Location = New System.Drawing.Point(152, 80)
        Me.numbersEnteredListBox.Name = "numbersEnteredListBox"
        Me.numbersEnteredListBox.Size = New System.Drawing.Size(141, 184)
        Me.numbersEnteredListBox.TabIndex = 5
        '
        'display
        '
        Me.display.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display.Location = New System.Drawing.Point(224, 24)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(69, 27)
        Me.display.TabIndex = 6
        Me.display.Text = "Display"
        Me.display.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Unique Numbers"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Numbers Entered:"
        '
        'DuplicateElimination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 274)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.display)
        Me.Controls.Add(Me.numbersEnteredListBox)
        Me.Controls.Add(Me.uniqueValuesListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numberBox)
        Me.Controls.Add(Me.Submit)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DuplicateElimination"
        Me.Text = "Duplicate Elimination"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Submit As Button
    Friend WithEvents numberBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents uniqueValuesListBox As ListBox
    Friend WithEvents numbersEnteredListBox As ListBox
    Friend WithEvents display As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
