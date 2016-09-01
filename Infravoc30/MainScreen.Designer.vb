<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FájlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÚjSzótárToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SzótárKiválasztásaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MentésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrissítésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.KisméretToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SzószedetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÚjSzóToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripSeparator()
        Me.atnevToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TörlésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖsszesTörléseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeresésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeállításokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlapbeállításokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SúgóToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProgramNévjegyeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Kismenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MódosításToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TörlésToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÚjElemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeresésToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ado = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.a_infok = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Akijelzo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Atithossza = New System.Windows.Forms.ToolStripStatusLabel()
        Me.filenam = New System.Windows.Forms.TextBox()
        Me.elem = New System.Windows.Forms.TextBox()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.eszkoz_filemam0 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.e_mentes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.gomb_ujszo = New System.Windows.Forms.ToolStripButton()
        Me.gomb_atnev = New System.Windows.Forms.ToolStripButton()
        Me.gomb_torol = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.gomb_info = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.Kismenu.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FájlToolStripMenuItem, Me.SzószedetToolStripMenuItem, Me.BeállításokToolStripMenuItem, Me.SúgóToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(530, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FájlToolStripMenuItem
        '
        Me.FájlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÚjSzótárToolStripMenuItem, Me.SzótárKiválasztásaToolStripMenuItem, Me.ToolStripSeparator5, Me.MentésToolStripMenuItem, Me.FrissítésToolStripMenuItem, Me.ToolStripSeparator6, Me.KisméretToolStripMenuItem, Me.ExitToolItem})
        Me.FájlToolStripMenuItem.Name = "FájlToolStripMenuItem"
        Me.FájlToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FájlToolStripMenuItem.Text = "Fájl"
        '
        'ÚjSzótárToolStripMenuItem
        '
        Me.ÚjSzótárToolStripMenuItem.Name = "ÚjSzótárToolStripMenuItem"
        Me.ÚjSzótárToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ÚjSzótárToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ÚjSzótárToolStripMenuItem.Text = "Új szótár..."
        '
        'SzótárKiválasztásaToolStripMenuItem
        '
        Me.SzótárKiválasztásaToolStripMenuItem.Name = "SzótárKiválasztásaToolStripMenuItem"
        Me.SzótárKiválasztásaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.SzótárKiválasztásaToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.SzótárKiválasztásaToolStripMenuItem.Text = "Szótár kiválasztása..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(217, 6)
        '
        'MentésToolStripMenuItem
        '
        Me.MentésToolStripMenuItem.Name = "MentésToolStripMenuItem"
        Me.MentésToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.MentésToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.MentésToolStripMenuItem.Text = "Mentés"
        '
        'FrissítésToolStripMenuItem
        '
        Me.FrissítésToolStripMenuItem.Name = "FrissítésToolStripMenuItem"
        Me.FrissítésToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.FrissítésToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.FrissítésToolStripMenuItem.Text = "Frissítés"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(217, 6)
        '
        'KisméretToolStripMenuItem
        '
        Me.KisméretToolStripMenuItem.Name = "KisméretToolStripMenuItem"
        Me.KisméretToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.KisméretToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.KisméretToolStripMenuItem.Text = "Kisméret"
        '
        'ExitToolItem
        '
        Me.ExitToolItem.Name = "ExitToolItem"
        Me.ExitToolItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolItem.Size = New System.Drawing.Size(220, 22)
        Me.ExitToolItem.Text = "Kilépés"
        '
        'SzószedetToolStripMenuItem
        '
        Me.SzószedetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÚjSzóToolStripMenuItem, Me.ToolStripTextBox1, Me.atnevToolStripMenuItem, Me.TörlésToolStripMenuItem, Me.ÖsszesTörléseToolStripMenuItem, Me.ToolStripSeparator7, Me.KeresésToolStripMenuItem})
        Me.SzószedetToolStripMenuItem.Name = "SzószedetToolStripMenuItem"
        Me.SzószedetToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.SzószedetToolStripMenuItem.Text = "Szószedet"
        '
        'ÚjSzóToolStripMenuItem
        '
        Me.ÚjSzóToolStripMenuItem.Name = "ÚjSzóToolStripMenuItem"
        Me.ÚjSzóToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.ÚjSzóToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ÚjSzóToolStripMenuItem.Text = "Új szó..."
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(209, 6)
        '
        'atnevToolStripMenuItem
        '
        Me.atnevToolStripMenuItem.Name = "atnevToolStripMenuItem"
        Me.atnevToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.atnevToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.atnevToolStripMenuItem.Text = "Átnevezés..."
        '
        'TörlésToolStripMenuItem
        '
        Me.TörlésToolStripMenuItem.Name = "TörlésToolStripMenuItem"
        Me.TörlésToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.TörlésToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.TörlésToolStripMenuItem.Text = "Törlés"
        '
        'ÖsszesTörléseToolStripMenuItem
        '
        Me.ÖsszesTörléseToolStripMenuItem.Name = "ÖsszesTörléseToolStripMenuItem"
        Me.ÖsszesTörléseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.ÖsszesTörléseToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ÖsszesTörléseToolStripMenuItem.Text = "Összes törlése..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(209, 6)
        '
        'KeresésToolStripMenuItem
        '
        Me.KeresésToolStripMenuItem.Name = "KeresésToolStripMenuItem"
        Me.KeresésToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.KeresésToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.KeresésToolStripMenuItem.Text = "Keresés..."
        '
        'BeállításokToolStripMenuItem
        '
        Me.BeállításokToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlapbeállításokToolStripMenuItem})
        Me.BeállításokToolStripMenuItem.Name = "BeállításokToolStripMenuItem"
        Me.BeállításokToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BeállításokToolStripMenuItem.Text = "Beállítások"
        '
        'AlapbeállításokToolStripMenuItem
        '
        Me.AlapbeállításokToolStripMenuItem.Name = "AlapbeállításokToolStripMenuItem"
        Me.AlapbeállításokToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AlapbeállításokToolStripMenuItem.Text = "Alapbeállítások..."
        '
        'SúgóToolStripMenuItem
        '
        Me.SúgóToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AProgramNévjegyeToolStripMenuItem})
        Me.SúgóToolStripMenuItem.Name = "SúgóToolStripMenuItem"
        Me.SúgóToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.SúgóToolStripMenuItem.Text = "Súgó"
        '
        'AProgramNévjegyeToolStripMenuItem
        '
        Me.AProgramNévjegyeToolStripMenuItem.Name = "AProgramNévjegyeToolStripMenuItem"
        Me.AProgramNévjegyeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AProgramNévjegyeToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AProgramNévjegyeToolStripMenuItem.Text = "A program névjegye..."
        '
        'Kismenu
        '
        Me.Kismenu.BackColor = System.Drawing.Color.Beige
        Me.Kismenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Kismenu.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Kismenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MódosításToolStripMenuItem, Me.TörlésToolStripMenuItem1, Me.ÚjElemToolStripMenuItem, Me.KeresésToolStripMenuItem1})
        Me.Kismenu.Name = "Kismenu"
        Me.Kismenu.ShowImageMargin = False
        Me.Kismenu.Size = New System.Drawing.Size(113, 92)
        '
        'MódosításToolStripMenuItem
        '
        Me.MódosításToolStripMenuItem.Name = "MódosításToolStripMenuItem"
        Me.MódosításToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.MódosításToolStripMenuItem.Text = "Módosítás..."
        '
        'TörlésToolStripMenuItem1
        '
        Me.TörlésToolStripMenuItem1.Name = "TörlésToolStripMenuItem1"
        Me.TörlésToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.TörlésToolStripMenuItem1.Text = "Törlés"
        '
        'ÚjElemToolStripMenuItem
        '
        Me.ÚjElemToolStripMenuItem.Name = "ÚjElemToolStripMenuItem"
        Me.ÚjElemToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ÚjElemToolStripMenuItem.Text = "Új elem"
        '
        'KeresésToolStripMenuItem1
        '
        Me.KeresésToolStripMenuItem1.Name = "KeresésToolStripMenuItem1"
        Me.KeresésToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.KeresésToolStripMenuItem1.Text = "Keresés..."
        '
        'ado
        '
        Me.ado.Location = New System.Drawing.Point(355, 436)
        Me.ado.Name = "ado"
        Me.ado.Size = New System.Drawing.Size(69, 20)
        Me.ado.TabIndex = 4
        Me.ado.TabStop = False
        Me.ado.Text = "0"
        Me.ado.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Infra Vocabulary"
        Me.NotifyIcon1.BalloonTipTitle = "Voc"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Vocabulary"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OKToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(91, 26)
        '
        'OKToolStripMenuItem
        '
        Me.OKToolStripMenuItem.Name = "OKToolStripMenuItem"
        Me.OKToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.OKToolStripMenuItem.Text = "OK"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ado)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.filenam)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.elem)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.List1)
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
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer1.TopToolStripPanel.Cursor = System.Windows.Forms.Cursors.Default
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.a_infok, Me.Akijelzo, Me.Atithossza})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(530, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'a_infok
        '
        Me.a_infok.AutoSize = False
        Me.a_infok.BackColor = System.Drawing.Color.Transparent
        Me.a_infok.Name = "a_infok"
        Me.a_infok.Size = New System.Drawing.Size(375, 17)
        Me.a_infok.Spring = True
        Me.a_infok.Text = "Kész"
        Me.a_infok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Akijelzo
        '
        Me.Akijelzo.AutoSize = False
        Me.Akijelzo.BackColor = System.Drawing.Color.Transparent
        Me.Akijelzo.MergeIndex = 0
        Me.Akijelzo.Name = "Akijelzo"
        Me.Akijelzo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.Akijelzo.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Akijelzo.Size = New System.Drawing.Size(70, 17)
        '
        'Atithossza
        '
        Me.Atithossza.AutoSize = False
        Me.Atithossza.BackColor = System.Drawing.Color.Transparent
        Me.Atithossza.Name = "Atithossza"
        Me.Atithossza.Size = New System.Drawing.Size(70, 17)
        '
        'filenam
        '
        Me.filenam.Location = New System.Drawing.Point(134, 80)
        Me.filenam.Name = "filenam"
        Me.filenam.Size = New System.Drawing.Size(205, 20)
        Me.filenam.TabIndex = 9
        Me.filenam.TabStop = False
        Me.filenam.Visible = False
        '
        'elem
        '
        Me.elem.Location = New System.Drawing.Point(117, 162)
        Me.elem.Name = "elem"
        Me.elem.Size = New System.Drawing.Size(222, 20)
        Me.elem.TabIndex = 8
        Me.elem.TabStop = False
        Me.elem.Visible = False
        '
        'List1
        '
        Me.List1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.List1.ContextMenuStrip = Me.Kismenu
        Me.List1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.List1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.List1.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.List1.FormattingEnabled = True
        Me.List1.IntegralHeight = False
        Me.List1.ItemHeight = 24
        Me.List1.Location = New System.Drawing.Point(0, 0)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(530, 495)
        Me.List1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.eszkoz_filemam0, Me.ToolStripSeparator4, Me.ToolStripButton3, Me.ToolStripButton2, Me.e_mentes, Me.ToolStripSeparator2, Me.gomb_ujszo, Me.gomb_atnev, Me.gomb_torol, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.gomb_info})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(345, 31)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'eszkoz_filemam0
        '
        Me.eszkoz_filemam0.AutoSize = False
        Me.eszkoz_filemam0.Name = "eszkoz_filemam0"
        Me.eszkoz_filemam0.Size = New System.Drawing.Size(100, 28)
        Me.eszkoz_filemam0.Text = "Megnyitott fájl"
        Me.eszkoz_filemam0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eszkoz_filemam0.ToolTipText = "Megnyitott fájl neve"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton3.ToolTipText = "Új szószedet"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton2.ToolTipText = "Szótár megnyitása"
        '
        'e_mentes
        '
        Me.e_mentes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.e_mentes.Image = CType(resources.GetObject("e_mentes.Image"), System.Drawing.Image)
        Me.e_mentes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.e_mentes.Name = "e_mentes"
        Me.e_mentes.Size = New System.Drawing.Size(28, 28)
        Me.e_mentes.Text = "Mentés"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'gomb_ujszo
        '
        Me.gomb_ujszo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.gomb_ujszo.Image = CType(resources.GetObject("gomb_ujszo.Image"), System.Drawing.Image)
        Me.gomb_ujszo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.gomb_ujszo.Name = "gomb_ujszo"
        Me.gomb_ujszo.Size = New System.Drawing.Size(28, 28)
        Me.gomb_ujszo.Text = "ToolStripButton1"
        Me.gomb_ujszo.ToolTipText = "Új szó"
        '
        'gomb_atnev
        '
        Me.gomb_atnev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.gomb_atnev.Image = CType(resources.GetObject("gomb_atnev.Image"), System.Drawing.Image)
        Me.gomb_atnev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.gomb_atnev.Name = "gomb_atnev"
        Me.gomb_atnev.Size = New System.Drawing.Size(28, 28)
        Me.gomb_atnev.Text = "ToolStripButton2"
        Me.gomb_atnev.ToolTipText = "Szó módosítása"
        '
        'gomb_torol
        '
        Me.gomb_torol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.gomb_torol.Image = CType(resources.GetObject("gomb_torol.Image"), System.Drawing.Image)
        Me.gomb_torol.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.gomb_torol.Name = "gomb_torol"
        Me.gomb_torol.Size = New System.Drawing.Size(28, 28)
        Me.gomb_torol.Text = "ToolStripButton3"
        Me.gomb_torol.ToolTipText = "Szó törlése"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Keresés"
        '
        'gomb_info
        '
        Me.gomb_info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.gomb_info.Image = CType(resources.GetObject("gomb_info.Image"), System.Drawing.Image)
        Me.gomb_info.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.gomb_info.Name = "gomb_info"
        Me.gomb_info.Size = New System.Drawing.Size(28, 28)
        Me.gomb_info.Text = "ToolStripButton4"
        Me.gomb_info.ToolTipText = "Információk"
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(530, 572)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(40, 70)
        Me.Name = "MainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vocabulary"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Kismenu.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FájlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SzószedetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SúgóToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ado As System.Windows.Forms.TextBox
    Friend WithEvents AProgramNévjegyeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÚjSzóToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents atnevToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TörlésToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖsszesTörléseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeresésToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MentésToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrissítésToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KisméretToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeállításokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlapbeállításokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SzótárKiválasztásaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Kismenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MódosításToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÚjElemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TörlésToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeresésToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Akijelzo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Atithossza As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents filenam As System.Windows.Forms.TextBox
    Friend WithEvents elem As System.Windows.Forms.TextBox
    Friend WithEvents List1 As System.Windows.Forms.ListBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents eszkoz_filemam0 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gomb_ujszo As System.Windows.Forms.ToolStripButton
    Friend WithEvents gomb_atnev As System.Windows.Forms.ToolStripButton
    Friend WithEvents gomb_torol As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents gomb_info As System.Windows.Forms.ToolStripButton
    Friend WithEvents ÚjSzótárToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents e_mentes As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents a_infok As System.Windows.Forms.ToolStripStatusLabel

End Class
