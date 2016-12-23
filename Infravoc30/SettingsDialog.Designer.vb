<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsDialog))
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
        Me.AddToVocabListButton = New System.Windows.Forms.Button()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.StartupOpenTextBox = New System.Windows.Forms.TextBox()
        Me.StartupOpenLabel = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
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
        Me.TableLayoutPanel.Location = New System.Drawing.Point(366, 345)
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
        Me.VocabListTabPage.ImageIndex = 1
        Me.VocabListTabPage.Location = New System.Drawing.Point(4, 34)
        Me.VocabListTabPage.Name = "VocabListTabPage"
        Me.VocabListTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.VocabListTabPage.Size = New System.Drawing.Size(492, 289)
        Me.VocabListTabPage.TabIndex = 2
        Me.VocabListTabPage.Text = "Szótárlista"
        Me.VocabListTabPage.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(328, 253)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(100, 24)
        Me.DeleteButton.TabIndex = 3
        Me.DeleteButton.Text = "&Törlés"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ModifyButton
        '
        Me.ModifyButton.Location = New System.Drawing.Point(195, 253)
        Me.ModifyButton.Name = "ModifyButton"
        Me.ModifyButton.Size = New System.Drawing.Size(111, 24)
        Me.ModifyButton.TabIndex = 2
        Me.ModifyButton.Text = "&Módosítás..."
        Me.ModifyButton.UseVisualStyleBackColor = True
        '
        'NewItemButton
        '
        Me.NewItemButton.Location = New System.Drawing.Point(57, 253)
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
        Me.VocListBox.Size = New System.Drawing.Size(455, 225)
        Me.VocListBox.TabIndex = 0
        '
        'BaseTabPage
        '
        Me.BaseTabPage.Controls.Add(Me.AddToVocabListButton)
        Me.BaseTabPage.Controls.Add(Me.BrowseButton)
        Me.BaseTabPage.Controls.Add(Me.StartupOpenTextBox)
        Me.BaseTabPage.Controls.Add(Me.StartupOpenLabel)
        Me.BaseTabPage.ImageIndex = 0
        Me.BaseTabPage.Location = New System.Drawing.Point(4, 34)
        Me.BaseTabPage.Name = "BaseTabPage"
        Me.BaseTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.BaseTabPage.Size = New System.Drawing.Size(492, 289)
        Me.BaseTabPage.TabIndex = 0
        Me.BaseTabPage.Text = "Alap"
        Me.BaseTabPage.UseVisualStyleBackColor = True
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
        Me.BrowseButton.Location = New System.Drawing.Point(391, 47)
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
        Me.StartupOpenTextBox.Size = New System.Drawing.Size(364, 22)
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
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl.Controls.Add(Me.BaseTabPage)
        Me.TabControl.Controls.Add(Me.VocabListTabPage)
        Me.TabControl.HotTrack = True
        Me.TabControl.ImageList = Me.ImageList
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.ShowToolTips = True
        Me.TabControl.Size = New System.Drawing.Size(500, 327)
        Me.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl.TabIndex = 0
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "settings.png")
        Me.ImageList.Images.SetKeyName(1, "list.png")
        '
        'SettingsDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(524, 381)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents AddToVocabListButton As System.Windows.Forms.Button
    Friend WithEvents BrowseButton As System.Windows.Forms.Button
    Friend WithEvents StartupOpenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartupOpenLabel As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList As ImageList
End Class
