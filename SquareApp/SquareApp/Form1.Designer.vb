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
        Me.Submit = New System.Windows.Forms.Button()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(139, 27)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(138, 27)
        Me.Submit.TabIndex = 0
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 15
        Me.ListBox.Location = New System.Drawing.Point(15, 70)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(261, 214)
        Me.ListBox.TabIndex = 1
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(15, 29)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(116, 23)
        Me.TextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Side"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 294)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.Submit)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Square App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Submit As Button
    Friend WithEvents ListBox As ListBox
    Friend WithEvents TextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
