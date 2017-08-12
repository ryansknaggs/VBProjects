<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceApp
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
        Me.partBox = New System.Windows.Forms.TextBox()
        Me.dBox = New System.Windows.Forms.TextBox()
        Me.priceBox = New System.Windows.Forms.TextBox()
        Me.qBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button = New System.Windows.Forms.Button()
        Me.listBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'partBox
        '
        Me.partBox.Location = New System.Drawing.Point(12, 22)
        Me.partBox.Name = "partBox"
        Me.partBox.Size = New System.Drawing.Size(100, 20)
        Me.partBox.TabIndex = 0
        '
        'dBox
        '
        Me.dBox.Location = New System.Drawing.Point(118, 22)
        Me.dBox.Name = "dBox"
        Me.dBox.Size = New System.Drawing.Size(100, 20)
        Me.dBox.TabIndex = 1
        '
        'priceBox
        '
        Me.priceBox.Location = New System.Drawing.Point(224, 22)
        Me.priceBox.Name = "priceBox"
        Me.priceBox.Size = New System.Drawing.Size(100, 20)
        Me.priceBox.TabIndex = 2
        '
        'qBox
        '
        Me.qBox.Location = New System.Drawing.Point(329, 22)
        Me.qBox.Name = "qBox"
        Me.qBox.Size = New System.Drawing.Size(100, 20)
        Me.qBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Part number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(327, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Quanity:"
        '
        'Button
        '
        Me.Button.Location = New System.Drawing.Point(11, 48)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(418, 23)
        Me.Button.TabIndex = 8
        Me.Button.Text = "Display Invoice Amount"
        Me.Button.UseVisualStyleBackColor = True
        '
        'listBox
        '
        Me.listBox.FormattingEnabled = True
        Me.listBox.Location = New System.Drawing.Point(11, 77)
        Me.listBox.Name = "listBox"
        Me.listBox.Size = New System.Drawing.Size(418, 95)
        Me.listBox.TabIndex = 9
        '
        'InvoiceApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 183)
        Me.Controls.Add(Me.listBox)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.qBox)
        Me.Controls.Add(Me.priceBox)
        Me.Controls.Add(Me.dBox)
        Me.Controls.Add(Me.partBox)
        Me.Name = "InvoiceApp"
        Me.Text = "Invoice App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents partBox As TextBox
    Friend WithEvents dBox As TextBox
    Friend WithEvents priceBox As TextBox
    Friend WithEvents qBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button As Button
    Friend WithEvents listBox As ListBox
End Class
