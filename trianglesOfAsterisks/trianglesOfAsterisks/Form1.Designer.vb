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
        Me.txtBoxOutPut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtBoxOutPut
        '
        Me.txtBoxOutPut.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxOutPut.Location = New System.Drawing.Point(12, 12)
        Me.txtBoxOutPut.Multiline = True
        Me.txtBoxOutPut.Name = "txtBoxOutPut"
        Me.txtBoxOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBoxOutPut.Size = New System.Drawing.Size(270, 237)
        Me.txtBoxOutPut.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 261)
        Me.Controls.Add(Me.txtBoxOutPut)
        Me.Name = "Form1"
        Me.Text = "Triangles of Asterisks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBoxOutPut As TextBox
End Class
