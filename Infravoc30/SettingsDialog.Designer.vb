<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsDialog
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.StartupOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.VocListOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.VocabListTabPage = New System.Windows.Forms.TabPage()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ModifyButton = New System.Windows.Forms.Button()
        Me.NewItemButton = New System.Windows.Forms.Button()
        Me.VocListBox = New System.Windows.Forms.ListBox()
        Me.BaseTabPage = New System.Windows.Forms.TabPage()
        Me.StatusBarCheckBox = New System.Windows.Forms.CheckBox()
        Me.ToolbarCheckBox = New System.Windows.Forms.CheckBox()
        Me.AddToVocabListButton = New System.Windows.Forms.Button()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.StartupOpenTextBox = New System.Windows.Forms.TextBox()
        Me.StartupOpenLabel = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel.SuspendLayout()
        Me.VocabListTabPage.SuspendLayout()
        Me.BaseTabPage.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(283, 280)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 1
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 1
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 2
        Me.Cancel_Button.Text = " Mégse"
        '
        'StartupOpenFileDialog
        '
        Me.StartupOpenFileDialog.DefaultExt = "*.voc"
        Me.StartupOpenFileDialog.Filter = """Infra Vocabulary 3x fájlok|*.voc|Régi Infra Vocabulary fájlok|words.txt|Minden f" &
    "ájl|*.*"""
        '
        'VocListOpenFileDialog
        '
        Me.VocListOpenFileDialog.DefaultExt = "*.voc"
        Me.VocListOpenFileDialog.Filter = """Infra Vocabulary 3x fájlok|*.voc|Régi Infra Vocabulary fájlok|words.txt|Minden f" &
    "ájl|*.*"""
        '
        'VocabListTabPage
        '
        Me.VocabListTabPage.Controls.Add(Me.DeleteButton)
        Me.VocabListTabPage.Controls.Add(Me.ModifyButton)
        Me.VocabListTabPage.Controls.Add(Me.NewItemButton)
        Me.VocabListTabPage.Controls.Add(Me.VocListBox)
        Me.VocabListTabPage.Location = New System.Drawing.Point(4, 22)
        Me.VocabListTabPage.Name = "VocabListTabPage"
        Me.VocabListTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.VocabListTabPage.Size = New System.Drawing.Size(408, 231)
        Me.VocabListTabPage.TabIndex = 2
        Me.VocabListTabPage.Text = "Szótárlista"
        Me.VocabListTabPage.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(289, 197)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(100, 24)
        Me.DeleteButton.TabIndex = 3
        Me.DeleteButton.Text = "&Törlés"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ModifyButton
        '
        Me.ModifyButton.Location = New System.Drawing.Point(156, 197)
        Me.ModifyButton.Name = "ModifyButton"
        Me.ModifyButton.Size = New System.Drawing.Size(111, 24)
        Me.ModifyButton.TabIndex = 2
        Me.ModifyButton.Text = "&Módosítás..."
        Me.ModifyButton.UseVisualStyleBackColor = True
        '
        'NewItemButton
        '
        Me.NewItemButton.Location = New System.Drawing.Point(18, 197)
        Me.NewItemButton.Name = "NewItemButton"
        Me.NewItemButton.Size = New System.Drawing.Size(119, 24)
        Me.NewItemButton.TabIndex = 1
        Me.NewItemButton.Text = "&Új elem..."
        Me.NewItemButton.UseVisualStyleBackColor = True
        '
        'VocListBox
        '
        Me.VocListBox.FormattingEnabled = True
        Me.VocListBox.Location = New System.Drawing.Point(16, 13)
        Me.VocListBox.Name = "VocListBox"
        Me.VocListBox.Size = New System.Drawing.Size(373, 173)
        Me.VocListBox.TabIndex = 0
        '
        'BaseTabPage
        '
        Me.BaseTabPage.Controls.Add(Me.StatusBarCheckBox)
        Me.BaseTabPage.Controls.Add(Me.ToolbarCheckBox)
        Me.BaseTabPage.Controls.Add(Me.AddToVocabListButton)
        Me.BaseTabPage.Controls.Add(Me.BrowseButton)
        Me.BaseTabPage.Controls.Add(Me.StartupOpenTextBox)
        Me.BaseTabPage.Controls.Add(Me.StartupOpenLabel)
        Me.BaseTabPage.Location = New System.Drawing.Point(4, 22)
        Me.BaseTabPage.Name = "BaseTabPage"
        Me.BaseTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.BaseTabPage.Size = New System.Drawing.Size(408, 231)
        Me.BaseTabPage.TabIndex = 0
        Me.BaseTabPage.Text = "Alap"
        Me.BaseTabPage.UseVisualStyleBackColor = True
        '
        'StatusBarCheckBox
        '
        Me.StatusBarCheckBox.AutoSize = True
        Me.StatusBarCheckBox.Location = New System.Drawing.Point(20, 146)
        Me.StatusBarCheckBox.Name = "StatusBarCheckBox"
        Me.StatusBarCheckBox.Size = New System.Drawing.Size(79, 17)
        Me.StatusBarCheckBox.TabIndex = 5
        Me.StatusBarCheckBox.Text = "&Állapotsor"
        Me.StatusBarCheckBox.UseVisualStyleBackColor = True
        '
        'ToolbarCheckBox
        '
        Me.ToolbarCheckBox.AutoSize = True
        Me.ToolbarCheckBox.Location = New System.Drawing.Point(20, 123)
        Me.ToolbarCheckBox.Name = "ToolbarCheckBox"
        Me.ToolbarCheckBox.Size = New System.Drawing.Size(74, 17)
        Me.ToolbarCheckBox.TabIndex = 4
        Me.ToolbarCheckBox.Text = "&Eszköztár"
        Me.ToolbarCheckBox.UseVisualStyleBackColor = True
        '
        'AddToVocabListButton
        '
        Me.AddToVocabListButton.Location = New System.Drawing.Point(20, 81)
        Me.AddToVocabListButton.Name = "AddToVocabListButton"
        Me.AddToVocabListButton.Size = New System.Drawing.Size(151, 24)
        Me.AddToVocabListButton.TabIndex = 3
        Me.AddToVocabListButton.Text = "&Felvétel a szótárlista közé"
        Me.AddToVocabListButton.UseVisualStyleBackColor = True
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(310, 47)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(85, 24)
        Me.BrowseButton.TabIndex = 2
        Me.BrowseButton.Text = "Tallózás..."
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'StartupOpenTextBox
        '
        Me.StartupOpenTextBox.Location = New System.Drawing.Point(21, 47)
        Me.StartupOpenTextBox.Name = "StartupOpenTextBox"
        Me.StartupOpenTextBox.Size = New System.Drawing.Size(278, 22)
        Me.StartupOpenTextBox.TabIndex = 1
        '
        'StartupOpenLabel
        '
        Me.StartupOpenLabel.AutoSize = True
        Me.StartupOpenLabel.Location = New System.Drawing.Point(17, 24)
        Me.StartupOpenLabel.Name = "StartupOpenLabel"
        Me.StartupOpenLabel.Size = New System.Drawing.Size(222, 13)
        Me.StartupOpenLabel.TabIndex = 0
        Me.StartupOpenLabel.Text = "Indításkor az alábbi szótárfájl megnyitása:"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.BaseTabPage)
        Me.TabControl.Controls.Add(Me.VocabListTabPage)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(416, 257)
        Me.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl.TabIndex = 0
        '
        'SettingsDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(441, 316)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Beállítások"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.VocabListTabPage.ResumeLayout(False)
        Me.BaseTabPage.ResumeLayout(False)
        Me.BaseTabPage.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents StartupOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents VocListOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents VocabListTabPage As System.Windows.Forms.TabPage
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents ModifyButton As System.Windows.Forms.Button
    Friend WithEvents NewItemButton As System.Windows.Forms.Button
    Friend WithEvents VocListBox As System.Windows.Forms.ListBox
    Friend WithEvents BaseTabPage As System.Windows.Forms.TabPage
    Friend WithEvents StatusBarCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ToolbarCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AddToVocabListButton As System.Windows.Forms.Button
    Friend WithEvents BrowseButton As System.Windows.Forms.Button
    Friend WithEvents StartupOpenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartupOpenLabel As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip

End Class
