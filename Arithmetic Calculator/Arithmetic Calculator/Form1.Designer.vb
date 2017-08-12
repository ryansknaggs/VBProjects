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
        Me.operandListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.enterOperandTextBox = New System.Windows.Forms.TextBox()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.multiplyButton = New System.Windows.Forms.Button()
        Me.resultLabel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'operandListBox
        '
        Me.operandListBox.FormattingEnabled = True
        Me.operandListBox.Location = New System.Drawing.Point(12, 33)
        Me.operandListBox.Name = "operandListBox"
        Me.operandListBox.Size = New System.Drawing.Size(110, 199)
        Me.operandListBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Operands:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter operands:"
        '
        'enterOperandTextBox
        '
        Me.enterOperandTextBox.Location = New System.Drawing.Point(147, 33)
        Me.enterOperandTextBox.Name = "enterOperandTextBox"
        Me.enterOperandTextBox.Size = New System.Drawing.Size(100, 20)
        Me.enterOperandTextBox.TabIndex = 3
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(147, 59)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(100, 23)
        Me.enterButton.TabIndex = 4
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(147, 122)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(100, 23)
        Me.addButton.TabIndex = 5
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.Location = New System.Drawing.Point(147, 151)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(100, 23)
        Me.multiplyButton.TabIndex = 6
        Me.multiplyButton.Text = "Multiply"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'resultLabel
        '
        Me.resultLabel.Location = New System.Drawing.Point(147, 212)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(100, 20)
        Me.resultLabel.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Calculation result:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 244)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.multiplyButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.enterOperandTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.operandListBox)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents operandListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents enterOperandTextBox As TextBox
    Friend WithEvents enterButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents multiplyButton As Button
    Friend WithEvents resultLabel As TextBox
    Friend WithEvents Label3 As Label
End Class
