<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.newGame = New System.Windows.Forms.Button()
        Me.guessButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.guessBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'newGame
        '
        Me.newGame.Location = New System.Drawing.Point(164, 30)
        Me.newGame.Name = "newGame"
        Me.newGame.Size = New System.Drawing.Size(87, 27)
        Me.newGame.TabIndex = 0
        Me.newGame.Text = "New Game"
        Me.newGame.UseVisualStyleBackColor = True
        '
        'guessButton
        '
        Me.guessButton.Location = New System.Drawing.Point(164, 71)
        Me.guessButton.Name = "guessButton"
        Me.guessButton.Size = New System.Drawing.Size(87, 27)
        Me.guessButton.TabIndex = 1
        Me.guessButton.Text = "Guess"
        Me.guessButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Guess (1-1000)"
        '
        'resultLabel
        '
        Me.resultLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultLabel.Location = New System.Drawing.Point(17, 69)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(142, 29)
        Me.resultLabel.TabIndex = 3
        '
        'guessBox
        '
        Me.guessBox.Location = New System.Drawing.Point(17, 30)
        Me.guessBox.Name = "guessBox"
        Me.guessBox.Size = New System.Drawing.Size(141, 27)
        Me.guessBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Result Label:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(265, 107)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.guessBox)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.guessButton)
        Me.Controls.Add(Me.newGame)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Guess Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents newGame As Button
    Friend WithEvents guessButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents resultLabel As Label
    Friend WithEvents guessBox As TextBox
    Friend WithEvents Label2 As Label
End Class
