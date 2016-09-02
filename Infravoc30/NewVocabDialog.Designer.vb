<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewVocabDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.VocabNameLabel = New System.Windows.Forms.Label()
        Me.VocabNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddToVocabListCheckBox = New System.Windows.Forms.CheckBox()
        Me.SetAsBaseVocabCheckBox = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 87)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 4
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 5
        Me.Cancel_Button.Text = "Mégse"
        '
        'VocabNameLabel
        '
        Me.VocabNameLabel.AutoSize = True
        Me.VocabNameLabel.Location = New System.Drawing.Point(10, 15)
        Me.VocabNameLabel.Name = "VocabNameLabel"
        Me.VocabNameLabel.Size = New System.Drawing.Size(88, 13)
        Me.VocabNameLabel.TabIndex = 0
        Me.VocabNameLabel.Text = "Szószedet neve:"
        '
        'VocabNameTextBox
        '
        Me.VocabNameTextBox.Location = New System.Drawing.Point(99, 12)
        Me.VocabNameTextBox.Name = "VocabNameTextBox"
        Me.VocabNameTextBox.Size = New System.Drawing.Size(321, 22)
        Me.VocabNameTextBox.TabIndex = 1
        '
        'AddToVocabListCheckBox
        '
        Me.AddToVocabListCheckBox.AutoSize = True
        Me.AddToVocabListCheckBox.Location = New System.Drawing.Point(167, 49)
        Me.AddToVocabListCheckBox.Name = "AddToVocabListCheckBox"
        Me.AddToVocabListCheckBox.Size = New System.Drawing.Size(142, 17)
        Me.AddToVocabListCheckBox.TabIndex = 3
        Me.AddToVocabListCheckBox.Text = "&Felvétel a szótárlistába"
        Me.AddToVocabListCheckBox.UseVisualStyleBackColor = True
        '
        'SetAsBaseVocabCheckBox
        '
        Me.SetAsBaseVocabCheckBox.AutoSize = True
        Me.SetAsBaseVocabCheckBox.Location = New System.Drawing.Point(13, 49)
        Me.SetAsBaseVocabCheckBox.Name = "SetAsBaseVocabCheckBox"
        Me.SetAsBaseVocabCheckBox.Size = New System.Drawing.Size(148, 17)
        Me.SetAsBaseVocabCheckBox.TabIndex = 2
        Me.SetAsBaseVocabCheckBox.Text = "&Beállítás alapszótárként"
        Me.SetAsBaseVocabCheckBox.UseVisualStyleBackColor = True
        '
        'NewVocabDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 128)
        Me.Controls.Add(Me.SetAsBaseVocabCheckBox)
        Me.Controls.Add(Me.AddToVocabListCheckBox)
        Me.Controls.Add(Me.VocabNameTextBox)
        Me.Controls.Add(Me.VocabNameLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewVocabDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Új szószedet"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents VocabNameLabel As System.Windows.Forms.Label
    Friend WithEvents VocabNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddToVocabListCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SetAsBaseVocabCheckBox As System.Windows.Forms.CheckBox

End Class
