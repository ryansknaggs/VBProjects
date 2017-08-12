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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.currentPop = New System.Windows.Forms.TextBox()
        Me.growthRate = New System.Windows.Forms.TextBox()
        Me.calculate = New System.Windows.Forms.Button()
        Me.resultBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter current population:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter percentage growth rate:"
        '
        'currentPop
        '
        Me.currentPop.Location = New System.Drawing.Point(189, 10)
        Me.currentPop.Name = "currentPop"
        Me.currentPop.Size = New System.Drawing.Size(128, 23)
        Me.currentPop.TabIndex = 2
        '
        'growthRate
        '
        Me.growthRate.Location = New System.Drawing.Point(189, 42)
        Me.growthRate.Name = "growthRate"
        Me.growthRate.Size = New System.Drawing.Size(128, 23)
        Me.growthRate.TabIndex = 3
        '
        'calculate
        '
        Me.calculate.Location = New System.Drawing.Point(189, 72)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(128, 27)
        Me.calculate.TabIndex = 4
        Me.calculate.Text = "Display Growth"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'resultBox
        '
        Me.resultBox.FormattingEnabled = True
        Me.resultBox.ItemHeight = 15
        Me.resultBox.Location = New System.Drawing.Point(14, 105)
        Me.resultBox.Name = "resultBox"
        Me.resultBox.Size = New System.Drawing.Size(303, 184)
        Me.resultBox.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 301)
        Me.Controls.Add(Me.resultBox)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.growthRate)
        Me.Controls.Add(Me.currentPop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "World Population Growth "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents currentPop As TextBox
    Friend WithEvents growthRate As TextBox
    Friend WithEvents calculate As Button
    Friend WithEvents resultBox As ListBox
End Class
