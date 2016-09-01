<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewVocabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChooseVocabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VocabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VocabSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VocabSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditContextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteContextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewItemContextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchContextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CounterTextBox = New System.Windows.Forms.TextBox()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.OkContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.InfoToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.WordDisplayToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.WordLengthToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FileNameHiddenTextBox = New System.Windows.Forms.TextBox()
        Me.WordItemHiddenTextBox = New System.Windows.Forms.TextBox()
        Me.WordsListBox = New System.Windows.Forms.ListBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FilenameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewVocabToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenVocabToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveVocabToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewWordToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EditWordToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteWordToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AboutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip.SuspendLayout()
        Me.ContextMenuStrip.SuspendLayout()
        Me.OkContextMenuStrip.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.MenuBar
        Me.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.VocabToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(530, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewVocabToolStripMenuItem, Me.ChooseVocabToolStripMenuItem, Me.ToolStripSeparator5, Me.SaveToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator6, Me.MinimizeToolStripMenuItem, Me.ExitToolItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "Fájl"
        '
        'NewVocabToolStripMenuItem
        '
        Me.NewVocabToolStripMenuItem.Name = "NewVocabToolStripMenuItem"
        Me.NewVocabToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewVocabToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.NewVocabToolStripMenuItem.Text = "Új szótár..."
        '
        'ChooseVocabToolStripMenuItem
        '
        Me.ChooseVocabToolStripMenuItem.Name = "ChooseVocabToolStripMenuItem"
        Me.ChooseVocabToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ChooseVocabToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ChooseVocabToolStripMenuItem.Text = "Szótár kiválasztása..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(217, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.SaveToolStripMenuItem.Text = "Mentés"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.RefreshToolStripMenuItem.Text = "Frissítés"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(217, 6)
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.MinimizeToolStripMenuItem.Text = "Kisméret"
        '
        'ExitToolItem
        '
        Me.ExitToolItem.Name = "ExitToolItem"
        Me.ExitToolItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolItem.Size = New System.Drawing.Size(220, 22)
        Me.ExitToolItem.Text = "Kilépés"
        '
        'VocabToolStripMenuItem
        '
        Me.VocabToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWordToolStripMenuItem, Me.VocabSeparator1, Me.RenameToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.DeleteAllToolStripMenuItem, Me.VocabSeparator2, Me.SearchToolStripMenuItem})
        Me.VocabToolStripMenuItem.Name = "VocabToolStripMenuItem"
        Me.VocabToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.VocabToolStripMenuItem.Text = "Szószedet"
        '
        'NewWordToolStripMenuItem
        '
        Me.NewWordToolStripMenuItem.Name = "NewWordToolStripMenuItem"
        Me.NewWordToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.NewWordToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.NewWordToolStripMenuItem.Text = "Új szó..."
        '
        'VocabSeparator1
        '
        Me.VocabSeparator1.Name = "VocabSeparator1"
        Me.VocabSeparator1.Size = New System.Drawing.Size(209, 6)
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.RenameToolStripMenuItem.Text = "Átnevezés..."
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DeleteToolStripMenuItem.Text = "Törlés"
        '
        'DeleteAllToolStripMenuItem
        '
        Me.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem"
        Me.DeleteAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.DeleteAllToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DeleteAllToolStripMenuItem.Text = "Összes törlése..."
        '
        'VocabSeparator2
        '
        Me.VocabSeparator2.Name = "VocabSeparator2"
        Me.VocabSeparator2.Size = New System.Drawing.Size(209, 6)
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SearchToolStripMenuItem.Text = "Keresés..."
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicSettingsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.SettingsToolStripMenuItem.Text = "Beállítások"
        '
        'BasicSettingsToolStripMenuItem
        '
        Me.BasicSettingsToolStripMenuItem.Name = "BasicSettingsToolStripMenuItem"
        Me.BasicSettingsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BasicSettingsToolStripMenuItem.Text = "Alapbeállítások..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.HelpToolStripMenuItem.Text = "Súgó"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AboutToolStripMenuItem.Text = "A program névjegye..."
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.BackColor = System.Drawing.Color.Beige
        Me.ContextMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContextMenuStrip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditContextToolStripMenuItem, Me.DeleteContextToolStripMenuItem, Me.NewItemContextToolStripMenuItem, Me.SearchContextToolStripMenuItem})
        Me.ContextMenuStrip.Name = "Kismenu"
        Me.ContextMenuStrip.ShowImageMargin = False
        Me.ContextMenuStrip.Size = New System.Drawing.Size(113, 92)
        '
        'EditContextToolStripMenuItem
        '
        Me.EditContextToolStripMenuItem.Name = "EditContextToolStripMenuItem"
        Me.EditContextToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.EditContextToolStripMenuItem.Text = "Módosítás..."
        '
        'DeleteContextToolStripMenuItem
        '
        Me.DeleteContextToolStripMenuItem.Name = "DeleteContextToolStripMenuItem"
        Me.DeleteContextToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DeleteContextToolStripMenuItem.Text = "Törlés"
        '
        'NewItemContextToolStripMenuItem
        '
        Me.NewItemContextToolStripMenuItem.Name = "NewItemContextToolStripMenuItem"
        Me.NewItemContextToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.NewItemContextToolStripMenuItem.Text = "Új elem"
        '
        'SearchContextToolStripMenuItem
        '
        Me.SearchContextToolStripMenuItem.Name = "SearchContextToolStripMenuItem"
        Me.SearchContextToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.SearchContextToolStripMenuItem.Text = "Keresés..."
        '
        'CounterTextBox
        '
        Me.CounterTextBox.Location = New System.Drawing.Point(355, 436)
        Me.CounterTextBox.Name = "CounterTextBox"
        Me.CounterTextBox.Size = New System.Drawing.Size(69, 20)
        Me.CounterTextBox.TabIndex = 4
        Me.CounterTextBox.TabStop = False
        Me.CounterTextBox.Text = "0"
        Me.CounterTextBox.Visible = False
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon.BalloonTipText = "Infra Vocabulary"
        Me.NotifyIcon.BalloonTipTitle = "Voc"
        Me.NotifyIcon.ContextMenuStrip = Me.OkContextMenuStrip
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "Vocabulary"
        '
        'OkContextMenuStrip
        '
        Me.OkContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OkToolStripMenuItem})
        Me.OkContextMenuStrip.Name = "ContextMenuStrip1"
        Me.OkContextMenuStrip.Size = New System.Drawing.Size(91, 26)
        '
        'OkToolStripMenuItem
        '
        Me.OkToolStripMenuItem.Name = "OkToolStripMenuItem"
        Me.OkToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.OkToolStripMenuItem.Text = "OK"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.CounterTextBox)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.FileNameHiddenTextBox)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.WordItemHiddenTextBox)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.WordsListBox)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(530, 495)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(530, 548)
        Me.ToolStripContainer1.TabIndex = 7
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ToolStripContainer1.TopToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        Me.ToolStripContainer1.TopToolStripPanel.Cursor = System.Windows.Forms.Cursors.Default
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StatusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripStatusLabel, Me.WordDisplayToolStripStatusLabel, Me.WordLengthToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(530, 22)
        Me.StatusStrip.TabIndex = 4
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'InfoToolStripStatusLabel
        '
        Me.InfoToolStripStatusLabel.AutoSize = False
        Me.InfoToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.InfoToolStripStatusLabel.Name = "InfoToolStripStatusLabel"
        Me.InfoToolStripStatusLabel.Size = New System.Drawing.Size(375, 17)
        Me.InfoToolStripStatusLabel.Spring = True
        Me.InfoToolStripStatusLabel.Text = "Kész"
        Me.InfoToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WordDisplayToolStripStatusLabel
        '
        Me.WordDisplayToolStripStatusLabel.AutoSize = False
        Me.WordDisplayToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.WordDisplayToolStripStatusLabel.MergeIndex = 0
        Me.WordDisplayToolStripStatusLabel.Name = "WordDisplayToolStripStatusLabel"
        Me.WordDisplayToolStripStatusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.WordDisplayToolStripStatusLabel.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.WordDisplayToolStripStatusLabel.Size = New System.Drawing.Size(70, 17)
        '
        'WordLengthToolStripStatusLabel
        '
        Me.WordLengthToolStripStatusLabel.AutoSize = False
        Me.WordLengthToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.WordLengthToolStripStatusLabel.Name = "WordLengthToolStripStatusLabel"
        Me.WordLengthToolStripStatusLabel.Size = New System.Drawing.Size(70, 17)
        '
        'FileNameHiddenTextBox
        '
        Me.FileNameHiddenTextBox.Location = New System.Drawing.Point(134, 80)
        Me.FileNameHiddenTextBox.Name = "FileNameHiddenTextBox"
        Me.FileNameHiddenTextBox.Size = New System.Drawing.Size(205, 20)
        Me.FileNameHiddenTextBox.TabIndex = 9
        Me.FileNameHiddenTextBox.TabStop = False
        Me.FileNameHiddenTextBox.Visible = False
        '
        'WordItemHiddenTextBox
        '
        Me.WordItemHiddenTextBox.Location = New System.Drawing.Point(117, 162)
        Me.WordItemHiddenTextBox.Name = "WordItemHiddenTextBox"
        Me.WordItemHiddenTextBox.Size = New System.Drawing.Size(222, 20)
        Me.WordItemHiddenTextBox.TabIndex = 8
        Me.WordItemHiddenTextBox.TabStop = False
        Me.WordItemHiddenTextBox.Visible = False
        '
        'WordsListBox
        '
        Me.WordsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WordsListBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.WordsListBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WordsListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WordsListBox.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.WordsListBox.FormattingEnabled = True
        Me.WordsListBox.IntegralHeight = False
        Me.WordsListBox.ItemHeight = 24
        Me.WordsListBox.Location = New System.Drawing.Point(0, 0)
        Me.WordsListBox.Name = "WordsListBox"
        Me.WordsListBox.Size = New System.Drawing.Size(530, 495)
        Me.WordsListBox.TabIndex = 0
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilenameToolStripLabel, Me.ToolStripSeparator4, Me.NewVocabToolStripButton, Me.OpenVocabToolStripButton, Me.SaveVocabToolStripButton, Me.ToolStripSeparator2, Me.NewWordToolStripButton, Me.EditWordToolStripButton, Me.DeleteWordToolStripButton, Me.ToolStripSeparator1, Me.SearchToolStripButton, Me.AboutToolStripButton})
        Me.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(345, 31)
        Me.ToolStrip.TabIndex = 2
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'FilenameToolStripLabel
        '
        Me.FilenameToolStripLabel.AutoSize = False
        Me.FilenameToolStripLabel.Name = "FilenameToolStripLabel"
        Me.FilenameToolStripLabel.Size = New System.Drawing.Size(100, 28)
        Me.FilenameToolStripLabel.Text = "Megnyitott fájl"
        Me.FilenameToolStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FilenameToolStripLabel.ToolTipText = "Megnyitott fájl neve"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'NewVocabToolStripButton
        '
        Me.NewVocabToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewVocabToolStripButton.Image = CType(resources.GetObject("NewVocabToolStripButton.Image"), System.Drawing.Image)
        Me.NewVocabToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewVocabToolStripButton.Name = "NewVocabToolStripButton"
        Me.NewVocabToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.NewVocabToolStripButton.ToolTipText = "Új szószedet"
        '
        'OpenVocabToolStripButton
        '
        Me.OpenVocabToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenVocabToolStripButton.Image = CType(resources.GetObject("OpenVocabToolStripButton.Image"), System.Drawing.Image)
        Me.OpenVocabToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenVocabToolStripButton.Name = "OpenVocabToolStripButton"
        Me.OpenVocabToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.OpenVocabToolStripButton.ToolTipText = "Szótár megnyitása"
        '
        'SaveVocabToolStripButton
        '
        Me.SaveVocabToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveVocabToolStripButton.Image = CType(resources.GetObject("SaveVocabToolStripButton.Image"), System.Drawing.Image)
        Me.SaveVocabToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveVocabToolStripButton.Name = "SaveVocabToolStripButton"
        Me.SaveVocabToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.SaveVocabToolStripButton.Text = "Mentés"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'NewWordToolStripButton
        '
        Me.NewWordToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewWordToolStripButton.Image = CType(resources.GetObject("NewWordToolStripButton.Image"), System.Drawing.Image)
        Me.NewWordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewWordToolStripButton.Name = "NewWordToolStripButton"
        Me.NewWordToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.NewWordToolStripButton.Text = "ToolStripButton1"
        Me.NewWordToolStripButton.ToolTipText = "Új szó"
        '
        'EditWordToolStripButton
        '
        Me.EditWordToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditWordToolStripButton.Image = CType(resources.GetObject("EditWordToolStripButton.Image"), System.Drawing.Image)
        Me.EditWordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditWordToolStripButton.Name = "EditWordToolStripButton"
        Me.EditWordToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.EditWordToolStripButton.Text = "ToolStripButton2"
        Me.EditWordToolStripButton.ToolTipText = "Szó módosítása"
        '
        'DeleteWordToolStripButton
        '
        Me.DeleteWordToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteWordToolStripButton.Image = CType(resources.GetObject("DeleteWordToolStripButton.Image"), System.Drawing.Image)
        Me.DeleteWordToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteWordToolStripButton.Name = "DeleteWordToolStripButton"
        Me.DeleteWordToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.DeleteWordToolStripButton.Text = "ToolStripButton3"
        Me.DeleteWordToolStripButton.ToolTipText = "Szó törlése"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SearchToolStripButton.Image = CType(resources.GetObject("SearchToolStripButton.Image"), System.Drawing.Image)
        Me.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.SearchToolStripButton.Text = "ToolStripButton1"
        Me.SearchToolStripButton.ToolTipText = "Keresés"
        '
        'AboutToolStripButton
        '
        Me.AboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AboutToolStripButton.Image = CType(resources.GetObject("AboutToolStripButton.Image"), System.Drawing.Image)
        Me.AboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AboutToolStripButton.Name = "AboutToolStripButton"
        Me.AboutToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.AboutToolStripButton.Text = "ToolStripButton4"
        Me.AboutToolStripButton.ToolTipText = "Információk"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(530, 572)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(40, 70)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vocabulary"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.OkContextMenuStrip.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VocabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CounterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VocabSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RenameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents OkContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasicSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChooseVocabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditContextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewItemContextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteContextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchContextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents WordDisplayToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents WordLengthToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FileNameHiddenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WordItemHiddenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WordsListBox As System.Windows.Forms.ListBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FilenameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewWordToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditWordToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteWordToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AboutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewVocabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenVocabToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewVocabToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveVocabToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VocabSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InfoToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel

End Class
