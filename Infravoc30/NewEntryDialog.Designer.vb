<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEntryDialog
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.LeftLabel = New System.Windows.Forms.Label()
        Me.RightLabel = New System.Windows.Forms.Label()
        Me.LeftTextBox = New System.Windows.Forms.TextBox()
        Me.RightTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(262, 117)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(87, 24)
        Me.OK_Button.TabIndex = 4
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(355, 117)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(85, 24)
        Me.Cancel_Button.TabIndex = 5
        Me.Cancel_Button.Text = "Mégse"
        '
        'LeftLabel
        '
        Me.LeftLabel.AutoSize = True
        Me.LeftLabel.Location = New System.Drawing.Point(7, 30)
        Me.LeftLabel.Name = "LeftLabel"
        Me.LeftLabel.Size = New System.Drawing.Size(28, 13)
        Me.LeftLabel.TabIndex = 0
        Me.LeftLabel.Text = "&Szó:"
        '
        'RightLabel
        '
        Me.RightLabel.AutoSize = True
        Me.RightLabel.Location = New System.Drawing.Point(7, 71)
        Me.RightLabel.Name = "RightLabel"
        Me.RightLabel.Size = New System.Drawing.Size(51, 13)
        Me.RightLabel.TabIndex = 2
        Me.RightLabel.Text = "&Jelentés:"
        '
        'LeftTextBox
        '
        Me.LeftTextBox.Location = New System.Drawing.Point(74, 27)
        Me.LeftTextBox.Name = "LeftTextBox"
        Me.LeftTextBox.Size = New System.Drawing.Size(366, 22)
        Me.LeftTextBox.TabIndex = 1
        '
        'RightTextBox
        '
        Me.RightTextBox.Location = New System.Drawing.Point(74, 68)
        Me.RightTextBox.Name = "RightTextBox"
        Me.RightTextBox.Size = New System.Drawing.Size(367, 22)
        Me.RightTextBox.TabIndex = 3
        '
        'NewEntryDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(453, 161)
        Me.Controls.Add(Me.RightTextBox)
        Me.Controls.Add(Me.LeftTextBox)
        Me.Controls.Add(Me.RightLabel)
        Me.Controls.Add(Me.LeftLabel)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewEntryDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Új szó"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents LeftLabel As System.Windows.Forms.Label
    Friend WithEvents RightLabel As System.Windows.Forms.Label
    Friend WithEvents LeftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RightTextBox As System.Windows.Forms.TextBox

End Class
