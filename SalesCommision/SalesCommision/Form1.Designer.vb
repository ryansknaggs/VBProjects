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
        Me.calcButton = New System.Windows.Forms.Button()
        Me.itemsSoldBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.perCentLabel = New System.Windows.Forms.Label()
        Me.precentage = New System.Windows.Forms.Label()
        Me.earningsLabel = New System.Windows.Forms.Label()
        Me.grossLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(137, 26)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(88, 26)
        Me.calcButton.TabIndex = 0
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'itemsSoldBox
        '
        Me.itemsSoldBox.Location = New System.Drawing.Point(14, 28)
        Me.itemsSoldBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.itemsSoldBox.Name = "itemsSoldBox"
        Me.itemsSoldBox.Size = New System.Drawing.Size(116, 23)
        Me.itemsSoldBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Items Sold:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Gross Sales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sales Earnings:"
        '
        'perCentLabel
        '
        Me.perCentLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.perCentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.perCentLabel.Location = New System.Drawing.Point(14, 154)
        Me.perCentLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.perCentLabel.Name = "perCentLabel"
        Me.perCentLabel.Size = New System.Drawing.Size(116, 24)
        Me.perCentLabel.TabIndex = 8
        '
        'precentage
        '
        Me.precentage.AutoSize = True
        Me.precentage.Location = New System.Drawing.Point(10, 140)
        Me.precentage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.precentage.Name = "precentage"
        Me.precentage.Size = New System.Drawing.Size(69, 15)
        Me.precentage.TabIndex = 7
        Me.precentage.Text = "Percentage:"
        '
        'earningsLabel
        '
        Me.earningsLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.earningsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.earningsLabel.Location = New System.Drawing.Point(14, 116)
        Me.earningsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.earningsLabel.Name = "earningsLabel"
        Me.earningsLabel.Size = New System.Drawing.Size(116, 24)
        Me.earningsLabel.TabIndex = 9
        '
        'grossLabel
        '
        Me.grossLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grossLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grossLabel.Location = New System.Drawing.Point(14, 73)
        Me.grossLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.grossLabel.Name = "grossLabel"
        Me.grossLabel.Size = New System.Drawing.Size(116, 24)
        Me.grossLabel.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(231, 188)
        Me.Controls.Add(Me.grossLabel)
        Me.Controls.Add(Me.earningsLabel)
        Me.Controls.Add(Me.perCentLabel)
        Me.Controls.Add(Me.precentage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.itemsSoldBox)
        Me.Controls.Add(Me.calcButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(247, 227)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(247, 227)
        Me.Name = "Form1"
        Me.Text = "Commision"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calcButton As Button
    Friend WithEvents itemsSoldBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents perCentLabel As Label
    Friend WithEvents precentage As Label
    Friend WithEvents earningsLabel As Label
    Friend WithEvents grossLabel As Label
End Class
