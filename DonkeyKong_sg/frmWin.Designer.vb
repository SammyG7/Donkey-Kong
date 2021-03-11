<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWin
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
        Me.WinButton = New System.Windows.Forms.Button()
        Me.exit2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WinButton
        '
        Me.WinButton.Location = New System.Drawing.Point(12, 306)
        Me.WinButton.Name = "WinButton"
        Me.WinButton.Size = New System.Drawing.Size(313, 238)
        Me.WinButton.TabIndex = 0
        Me.WinButton.Text = "Play Again?"
        Me.WinButton.UseVisualStyleBackColor = True
        '
        'exit2
        '
        Me.exit2.Location = New System.Drawing.Point(351, 437)
        Me.exit2.Name = "exit2"
        Me.exit2.Size = New System.Drawing.Size(135, 107)
        Me.exit2.TabIndex = 1
        Me.exit2.Text = "exit"
        Me.exit2.UseVisualStyleBackColor = True
        '
        'frmWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.WIN2
        Me.ClientSize = New System.Drawing.Size(498, 571)
        Me.Controls.Add(Me.exit2)
        Me.Controls.Add(Me.WinButton)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmWin"
        Me.Text = "frmWin"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WinButton As System.Windows.Forms.Button
    Friend WithEvents exit2 As System.Windows.Forms.Button
End Class
