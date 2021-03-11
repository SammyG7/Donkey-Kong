<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtiltle
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
        Me.Start = New System.Windows.Forms.Button()
        Me.Keys = New System.Windows.Forms.Button()
        Me.DKTitle = New System.Windows.Forms.PictureBox()
        Me.Title1 = New System.Windows.Forms.PictureBox()
        CType(Me.DKTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Title1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(222, 210)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(345, 106)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Start Game"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Keys
        '
        Me.Keys.Location = New System.Drawing.Point(223, 357)
        Me.Keys.Name = "Keys"
        Me.Keys.Size = New System.Drawing.Size(344, 102)
        Me.Keys.TabIndex = 2
        Me.Keys.Text = "Controls"
        Me.Keys.UseVisualStyleBackColor = True
        '
        'DKTitle
        '
        Me.DKTitle.Image = Global.WindowsApplication1.My.Resources.Resources.BobbSmiling
        Me.DKTitle.Location = New System.Drawing.Point(27, 80)
        Me.DKTitle.Name = "DKTitle"
        Me.DKTitle.Size = New System.Drawing.Size(180, 252)
        Me.DKTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DKTitle.TabIndex = 3
        Me.DKTitle.TabStop = False
        '
        'Title1
        '
        Me.Title1.Image = Global.WindowsApplication1.My.Resources.Resources.DK1
        Me.Title1.Location = New System.Drawing.Point(173, 12)
        Me.Title1.Name = "Title1"
        Me.Title1.Size = New System.Drawing.Size(446, 129)
        Me.Title1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Title1.TabIndex = 0
        Me.Title1.TabStop = False
        '
        'frmtiltle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(794, 552)
        Me.Controls.Add(Me.Keys)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Title1)
        Me.Controls.Add(Me.DKTitle)
        Me.Name = "frmtiltle"
        Me.Text = "frmtiltle"
        CType(Me.DKTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Title1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Title1 As System.Windows.Forms.PictureBox
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Keys As System.Windows.Forms.Button
    Friend WithEvents DKTitle As System.Windows.Forms.PictureBox
End Class
