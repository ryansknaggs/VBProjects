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
        Me.cButton = New System.Windows.Forms.Button()
        Me.celBox = New System.Windows.Forms.TextBox()
        Me.fahBox = New System.Windows.Forms.TextBox()
        Me.fButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.celLabel = New System.Windows.Forms.Label()
        Me.fahLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Celsius Converter:"
        '
        'cButton
        '
        Me.cButton.Location = New System.Drawing.Point(262, 26)
        Me.cButton.Name = "cButton"
        Me.cButton.Size = New System.Drawing.Size(75, 23)
        Me.cButton.TabIndex = 1
        Me.cButton.Text = "Convert"
        Me.cButton.UseVisualStyleBackColor = True
        '
        'celBox
        '
        Me.celBox.Location = New System.Drawing.Point(12, 27)
        Me.celBox.Name = "celBox"
        Me.celBox.Size = New System.Drawing.Size(112, 23)
        Me.celBox.TabIndex = 2
        '
        'fahBox
        '
        Me.fahBox.Location = New System.Drawing.Point(12, 71)
        Me.fahBox.Name = "fahBox"
        Me.fahBox.Size = New System.Drawing.Size(112, 23)
        Me.fahBox.TabIndex = 5
        '
        'fButton
        '
        Me.fButton.Location = New System.Drawing.Point(262, 70)
        Me.fButton.Name = "fButton"
        Me.fButton.Size = New System.Drawing.Size(75, 23)
        Me.fButton.TabIndex = 4
        Me.fButton.Text = "Convert"
        Me.fButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fahrenhit Converter:"
        '
        'celLabel
        '
        Me.celLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.celLabel.ForeColor = System.Drawing.Color.Black
        Me.celLabel.Location = New System.Drawing.Point(130, 26)
        Me.celLabel.Name = "celLabel"
        Me.celLabel.Size = New System.Drawing.Size(120, 23)
        Me.celLabel.TabIndex = 6
        '
        'fahLabel
        '
        Me.fahLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fahLabel.ForeColor = System.Drawing.Color.Black
        Me.fahLabel.Location = New System.Drawing.Point(130, 70)
        Me.fahLabel.Name = "fahLabel"
        Me.fahLabel.Size = New System.Drawing.Size(120, 23)
        Me.fahLabel.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(127, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fahrenhit Conversion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(127, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Celsius Conversion:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 109)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fahLabel)
        Me.Controls.Add(Me.celLabel)
        Me.Controls.Add(Me.fahBox)
        Me.Controls.Add(Me.fButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.celBox)
        Me.Controls.Add(Me.cButton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Temp Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cButton As Button
    Friend WithEvents celBox As TextBox
    Friend WithEvents fahBox As TextBox
    Friend WithEvents fButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents celLabel As Label
    Friend WithEvents fahLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
