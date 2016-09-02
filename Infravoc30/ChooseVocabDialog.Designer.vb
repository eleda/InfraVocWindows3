<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseVocabDialog
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
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.VocabListBox = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FromFileButton = New System.Windows.Forms.Button()
        Me.FromListRadioButton = New System.Windows.Forms.RadioButton()
        Me.FromFileRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilenameLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(157, 313)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 1
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(194, 29)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(15, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 2
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(112, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 3
        Me.Cancel_Button.Text = "Mégse"
        '
        'VocabListBox
        '
        Me.VocabListBox.FormattingEnabled = True
        Me.VocabListBox.Location = New System.Drawing.Point(16, 36)
        Me.VocabListBox.Name = "VocabListBox"
        Me.VocabListBox.Size = New System.Drawing.Size(335, 212)
        Me.VocabListBox.TabIndex = 1
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = """words.txt""|""*.voc"""
        '
        'FromFileButton
        '
        Me.FromFileButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FromFileButton.Location = New System.Drawing.Point(270, 254)
        Me.FromFileButton.Name = "FromFileButton"
        Me.FromFileButton.Size = New System.Drawing.Size(80, 23)
        Me.FromFileButton.TabIndex = 4
        Me.FromFileButton.Text = "Fájl..."
        Me.FromFileButton.UseVisualStyleBackColor = True
        '
        'FromListRadioButton
        '
        Me.FromListRadioButton.AutoSize = True
        Me.FromListRadioButton.Checked = True
        Me.FromListRadioButton.Location = New System.Drawing.Point(16, 13)
        Me.FromListRadioButton.Name = "FromListRadioButton"
        Me.FromListRadioButton.Size = New System.Drawing.Size(61, 17)
        Me.FromListRadioButton.TabIndex = 2
        Me.FromListRadioButton.TabStop = True
        Me.FromListRadioButton.Text = "Listából"
        Me.FromListRadioButton.UseVisualStyleBackColor = True
        '
        'FromFileRadioButton
        '
        Me.FromFileRadioButton.AutoSize = True
        Me.FromFileRadioButton.Location = New System.Drawing.Point(16, 255)
        Me.FromFileRadioButton.Name = "FromFileRadioButton"
        Me.FromFileRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.FromFileRadioButton.TabIndex = 3
        Me.FromFileRadioButton.Text = "Fájlból"
        Me.FromFileRadioButton.UseVisualStyleBackColor = True
        '
        'FilenameLabel
        '
        Me.FilenameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FilenameLabel.Location = New System.Drawing.Point(95, 257)
        Me.FilenameLabel.Name = "FilenameLabel"
        Me.FilenameLabel.Size = New System.Drawing.Size(169, 20)
        Me.FilenameLabel.TabIndex = 5
        Me.FilenameLabel.Text = "(válasszon egyet)"
        '
        'ChooseVocabDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(363, 354)
        Me.Controls.Add(Me.FilenameLabel)
        Me.Controls.Add(Me.FromFileRadioButton)
        Me.Controls.Add(Me.FromListRadioButton)
        Me.Controls.Add(Me.FromFileButton)
        Me.Controls.Add(Me.VocabListBox)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChooseVocabDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Szószedet választása"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents VocabListBox As ListBox
    Friend WithEvents FromFileButton As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents FromListRadioButton As RadioButton
    Friend WithEvents FromFileRadioButton As RadioButton
    Friend WithEvents FilenameLabel As Label
End Class
