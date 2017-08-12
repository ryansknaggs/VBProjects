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
        Me.squareXSide = New System.Windows.Forms.TextBox()
        Me.squareYSide = New System.Windows.Forms.TextBox()
        Me.cubeXSide = New System.Windows.Forms.TextBox()
        Me.cubeYSide = New System.Windows.Forms.TextBox()
        Me.cubeZSide = New System.Windows.Forms.TextBox()
        Me.circleRadius = New System.Windows.Forms.TextBox()
        Me.shpereRadius = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.squareButton = New System.Windows.Forms.Button()
        Me.circleButton = New System.Windows.Forms.Button()
        Me.shpereButton = New System.Windows.Forms.Button()
        Me.cubeButton = New System.Windows.Forms.Button()
        Me.twoDTextBox = New System.Windows.Forms.TextBox()
        Me.threeDTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'squareXSide
        '
        Me.squareXSide.Location = New System.Drawing.Point(122, 39)
        Me.squareXSide.Name = "squareXSide"
        Me.squareXSide.Size = New System.Drawing.Size(116, 23)
        Me.squareXSide.TabIndex = 0
        '
        'squareYSide
        '
        Me.squareYSide.Location = New System.Drawing.Point(122, 69)
        Me.squareYSide.Name = "squareYSide"
        Me.squareYSide.Size = New System.Drawing.Size(116, 23)
        Me.squareYSide.TabIndex = 1
        '
        'cubeXSide
        '
        Me.cubeXSide.Location = New System.Drawing.Point(124, 196)
        Me.cubeXSide.Name = "cubeXSide"
        Me.cubeXSide.Size = New System.Drawing.Size(116, 23)
        Me.cubeXSide.TabIndex = 2
        '
        'cubeYSide
        '
        Me.cubeYSide.Location = New System.Drawing.Point(124, 226)
        Me.cubeYSide.Name = "cubeYSide"
        Me.cubeYSide.Size = New System.Drawing.Size(116, 23)
        Me.cubeYSide.TabIndex = 3
        '
        'cubeZSide
        '
        Me.cubeZSide.Location = New System.Drawing.Point(124, 256)
        Me.cubeZSide.Name = "cubeZSide"
        Me.cubeZSide.Size = New System.Drawing.Size(116, 23)
        Me.cubeZSide.TabIndex = 4
        '
        'circleRadius
        '
        Me.circleRadius.Location = New System.Drawing.Point(124, 126)
        Me.circleRadius.Name = "circleRadius"
        Me.circleRadius.Size = New System.Drawing.Size(116, 23)
        Me.circleRadius.TabIndex = 5
        '
        'shpereRadius
        '
        Me.shpereRadius.Location = New System.Drawing.Point(124, 298)
        Me.shpereRadius.Name = "shpereRadius"
        Me.shpereRadius.Size = New System.Drawing.Size(116, 23)
        Me.shpereRadius.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Square:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cube:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Circle:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sphere:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Three-Dimensional Shapes:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Two-Dimensional Shapes:"
        '
        'squareButton
        '
        Me.squareButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.squareButton.Location = New System.Drawing.Point(677, 39)
        Me.squareButton.Name = "squareButton"
        Me.squareButton.Size = New System.Drawing.Size(122, 27)
        Me.squareButton.TabIndex = 15
        Me.squareButton.Text = "Calculate Square"
        Me.squareButton.UseVisualStyleBackColor = True
        '
        'circleButton
        '
        Me.circleButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.circleButton.Location = New System.Drawing.Point(677, 120)
        Me.circleButton.Name = "circleButton"
        Me.circleButton.Size = New System.Drawing.Size(122, 27)
        Me.circleButton.TabIndex = 16
        Me.circleButton.Text = "Calculate Circle"
        Me.circleButton.UseVisualStyleBackColor = True
        '
        'shpereButton
        '
        Me.shpereButton.Location = New System.Drawing.Point(677, 292)
        Me.shpereButton.Name = "shpereButton"
        Me.shpereButton.Size = New System.Drawing.Size(122, 27)
        Me.shpereButton.TabIndex = 18
        Me.shpereButton.Text = "Calculate Sphere"
        Me.shpereButton.UseVisualStyleBackColor = True
        '
        'cubeButton
        '
        Me.cubeButton.Location = New System.Drawing.Point(677, 211)
        Me.cubeButton.Name = "cubeButton"
        Me.cubeButton.Size = New System.Drawing.Size(122, 27)
        Me.cubeButton.TabIndex = 17
        Me.cubeButton.Text = "Calculate Cube"
        Me.cubeButton.UseVisualStyleBackColor = True
        '
        'twoDTextBox
        '
        Me.twoDTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twoDTextBox.Location = New System.Drawing.Point(258, 39)
        Me.twoDTextBox.Multiline = True
        Me.twoDTextBox.Name = "twoDTextBox"
        Me.twoDTextBox.Size = New System.Drawing.Size(398, 109)
        Me.twoDTextBox.TabIndex = 19
        '
        'threeDTextBox
        '
        Me.threeDTextBox.Location = New System.Drawing.Point(258, 196)
        Me.threeDTextBox.Multiline = True
        Me.threeDTextBox.Name = "threeDTextBox"
        Me.threeDTextBox.Size = New System.Drawing.Size(398, 124)
        Me.threeDTextBox.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 338)
        Me.Controls.Add(Me.threeDTextBox)
        Me.Controls.Add(Me.twoDTextBox)
        Me.Controls.Add(Me.shpereButton)
        Me.Controls.Add(Me.cubeButton)
        Me.Controls.Add(Me.circleButton)
        Me.Controls.Add(Me.squareButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.shpereRadius)
        Me.Controls.Add(Me.circleRadius)
        Me.Controls.Add(Me.cubeZSide)
        Me.Controls.Add(Me.cubeYSide)
        Me.Controls.Add(Me.cubeXSide)
        Me.Controls.Add(Me.squareYSide)
        Me.Controls.Add(Me.squareXSide)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Shape Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents squareXSide As TextBox
    Friend WithEvents squareYSide As TextBox
    Friend WithEvents cubeXSide As TextBox
    Friend WithEvents cubeYSide As TextBox
    Friend WithEvents cubeZSide As TextBox
    Friend WithEvents circleRadius As TextBox
    Friend WithEvents shpereRadius As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents squareButton As Button
    Friend WithEvents circleButton As Button
    Friend WithEvents shpereButton As Button
    Friend WithEvents cubeButton As Button
    Friend WithEvents twoDTextBox As TextBox
    Friend WithEvents threeDTextBox As TextBox
End Class
