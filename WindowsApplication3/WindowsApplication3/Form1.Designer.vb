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
        Me.resultListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.analyzeResultsButton = New System.Windows.Forms.Button()
        Me.analysisResultsLabel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.resultTextBox = New System.Windows.Forms.TextBox()
        Me.submitResultsButton = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'resultListBox
        '
        Me.resultListBox.FormattingEnabled = True
        Me.resultListBox.Location = New System.Drawing.Point(12, 30)
        Me.resultListBox.Name = "resultListBox"
        Me.resultListBox.Size = New System.Drawing.Size(57, 225)
        Me.resultListBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Resuts"
        '
        'analyzeResultsButton
        '
        Me.analyzeResultsButton.Location = New System.Drawing.Point(76, 95)
        Me.analyzeResultsButton.Name = "analyzeResultsButton"
        Me.analyzeResultsButton.Size = New System.Drawing.Size(185, 23)
        Me.analyzeResultsButton.TabIndex = 2
        Me.analyzeResultsButton.Text = "Analyze Results"
        Me.analyzeResultsButton.UseVisualStyleBackColor = True
        '
        'analysisResultsLabel
        '
        Me.analysisResultsLabel.Location = New System.Drawing.Point(74, 160)
        Me.analysisResultsLabel.Multiline = True
        Me.analysisResultsLabel.Name = "analysisResultsLabel"
        Me.analysisResultsLabel.Size = New System.Drawing.Size(185, 68)
        Me.analysisResultsLabel.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter P for pass or F for fail:"
        '
        'resultTextBox
        '
        Me.resultTextBox.Location = New System.Drawing.Point(216, 40)
        Me.resultTextBox.Name = "resultTextBox"
        Me.resultTextBox.Size = New System.Drawing.Size(44, 20)
        Me.resultTextBox.TabIndex = 6
        '
        'submitResultsButton
        '
        Me.submitResultsButton.Location = New System.Drawing.Point(75, 66)
        Me.submitResultsButton.Name = "submitResultsButton"
        Me.submitResultsButton.Size = New System.Drawing.Size(185, 23)
        Me.submitResultsButton.TabIndex = 7
        Me.submitResultsButton.Text = "Submit Results"
        Me.submitResultsButton.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(74, 234)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(185, 23)
        Me.clear.TabIndex = 8
        Me.clear.Text = "Clear Results"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Analysis"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.submitResultsButton)
        Me.Controls.Add(Me.resultTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.analysisResultsLabel)
        Me.Controls.Add(Me.analyzeResultsButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.resultListBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents resultListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents analyzeResultsButton As Button
    Friend WithEvents analysisResultsLabel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents resultTextBox As TextBox
    Friend WithEvents submitResultsButton As Button
    Friend WithEvents clear As Button
    Friend WithEvents Label3 As Label
End Class
