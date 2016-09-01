<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchWindow
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

    Friend WithEvents ToolStripContainer As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ListViewToolStripButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LargeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmallIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents ResultListView As System.Windows.Forms.ListView
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ListViewSmallImageList As System.Windows.Forms.ImageList

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchWindow))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SearchEverywhereCheckBox = New System.Windows.Forms.CheckBox()
        Me.FindText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchTitleLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.command2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ResultListView = New System.Windows.Forms.ListView()
        Me.ListViewSmallImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ListViewToolStripButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.ContentPanel.SuspendLayout()
        Me.ToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer
        '
        '
        'ToolStripContainer.BottomToolStripPanel
        '
        Me.ToolStripContainer.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
        '
        'ToolStripContainer.ContentPanel
        '
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.SplitContainer)
        Me.ToolStripContainer.ContentPanel.Size = New System.Drawing.Size(600, 444)
        Me.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer.Name = "ToolStripContainer"
        Me.ToolStripContainer.Size = New System.Drawing.Size(600, 494)
        Me.ToolStripContainer.TabIndex = 7
        Me.ToolStripContainer.Text = "ToolStripContainer1"
        '
        'ToolStripContainer.TopToolStripPanel
        '
        Me.ToolStripContainer.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripContainer.TopToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.ToolStrip)
        Me.ToolStripContainer.TopToolStripPanel.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        '
        'StatusStrip
        '
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(600, 22)
        Me.StatusStrip.TabIndex = 6
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.AutoSize = False
        Me.ToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(585, 17)
        Me.ToolStripStatusLabel.Spring = True
        Me.ToolStripStatusLabel.Text = "Kész."
        Me.ToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.SplitContainer.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.ResultListView)
        Me.SplitContainer.Size = New System.Drawing.Size(600, 444)
        Me.SplitContainer.SplitterDistance = 215
        Me.SplitContainer.TabIndex = 0
        Me.SplitContainer.TabStop = False
        Me.SplitContainer.Text = "SplitContainer1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SearchEverywhereCheckBox, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.FindText, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SearchTitleLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SearchButton, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.command2, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(215, 444)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'SearchEverywhereCheckBox
        '
        Me.SearchEverywhereCheckBox.AutoSize = True
        Me.SearchEverywhereCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.SearchEverywhereCheckBox.Checked = True
        Me.SearchEverywhereCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SearchEverywhereCheckBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.SearchEverywhereCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SearchEverywhereCheckBox.Location = New System.Drawing.Point(9, 313)
        Me.SearchEverywhereCheckBox.Margin = New System.Windows.Forms.Padding(9)
        Me.SearchEverywhereCheckBox.Name = "SearchEverywhereCheckBox"
        Me.SearchEverywhereCheckBox.Size = New System.Drawing.Size(119, 17)
        Me.SearchEverywhereCheckBox.TabIndex = 3
        Me.SearchEverywhereCheckBox.Text = "Keresés &mindenütt"
        Me.SearchEverywhereCheckBox.UseVisualStyleBackColor = False
        '
        'FindText
        '
        Me.FindText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindText.Location = New System.Drawing.Point(9, 79)
        Me.FindText.Margin = New System.Windows.Forms.Padding(9)
        Me.FindText.Name = "FindText"
        Me.FindText.Size = New System.Drawing.Size(197, 22)
        Me.FindText.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(9, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 9, 9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Keresendő &szöveg:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'SearchTitleLabel
        '
        Me.SearchTitleLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SearchTitleLabel.AutoSize = True
        Me.SearchTitleLabel.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.SearchTitleLabel.Location = New System.Drawing.Point(9, 9)
        Me.SearchTitleLabel.Margin = New System.Windows.Forms.Padding(9, 9, 9, 0)
        Me.SearchTitleLabel.Name = "SearchTitleLabel"
        Me.SearchTitleLabel.Size = New System.Drawing.Size(90, 31)
        Me.SearchTitleLabel.TabIndex = 0
        Me.SearchTitleLabel.Text = "Keresés"
        '
        'SearchButton
        '
        Me.SearchButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchButton.BackColor = System.Drawing.SystemColors.Control
        Me.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SearchButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(113, 344)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(5)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(97, 25)
        Me.SearchButton.TabIndex = 4
        Me.SearchButton.Text = "&Keresés"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'command2
        '
        Me.command2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.command2.BackColor = System.Drawing.SystemColors.Control
        Me.command2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.command2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.command2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.command2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.command2.Location = New System.Drawing.Point(113, 414)
        Me.command2.Margin = New System.Windows.Forms.Padding(5)
        Me.command2.Name = "command2"
        Me.command2.Size = New System.Drawing.Size(97, 25)
        Me.command2.TabIndex = 6
        Me.command2.Text = "Mé&gse"
        Me.command2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.Location = New System.Drawing.Point(113, 379)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 25)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&Ugrás"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ResultListView
        '
        Me.ResultListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ResultListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultListView.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ResultListView.LargeImageList = Me.ListViewSmallImageList
        Me.ResultListView.Location = New System.Drawing.Point(0, 0)
        Me.ResultListView.Name = "ResultListView"
        Me.ResultListView.Size = New System.Drawing.Size(381, 444)
        Me.ResultListView.SmallImageList = Me.ListViewSmallImageList
        Me.ResultListView.StateImageList = Me.ListViewSmallImageList
        Me.ResultListView.TabIndex = 7
        Me.ResultListView.UseCompatibleStateImageBehavior = False
        Me.ResultListView.View = System.Windows.Forms.View.List
        '
        'ListViewSmallImageList
        '
        Me.ListViewSmallImageList.ImageStream = CType(resources.GetObject("ListViewSmallImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListViewSmallImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ListViewSmallImageList.Images.SetKeyName(0, "Graph1")
        Me.ListViewSmallImageList.Images.SetKeyName(1, "Graph2")
        Me.ListViewSmallImageList.Images.SetKeyName(2, "Graph3")
        Me.ListViewSmallImageList.Images.SetKeyName(3, "equal.ico")
        '
        'ToolStrip
        '
        Me.ToolStrip.AllowItemReorder = True
        Me.ToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ToolStrip.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripButton, Me.ListViewToolStripButton, Me.ToolStripSeparator1, Me.GoToolStripButton, Me.EditToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(352, 28)
        Me.ToolStrip.TabIndex = 0
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(106, 25)
        Me.SearchToolStripButton.Text = "Keresés most"
        Me.SearchToolStripButton.ToolTipText = "Keresés"
        '
        'ListViewToolStripButton
        '
        Me.ListViewToolStripButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem, Me.LargeIconsToolStripMenuItem, Me.SmallIconsToolStripMenuItem, Me.TileToolStripMenuItem})
        Me.ListViewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.ListViewToolStripButton.Name = "ListViewToolStripButton"
        Me.ListViewToolStripButton.Size = New System.Drawing.Size(79, 25)
        Me.ListViewToolStripButton.Text = "&Nézetek"
        Me.ListViewToolStripButton.ToolTipText = "Nézetek"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Checked = True
        Me.ListToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.ListToolStripMenuItem.Text = "Lista"
        '
        'LargeIconsToolStripMenuItem
        '
        Me.LargeIconsToolStripMenuItem.Name = "LargeIconsToolStripMenuItem"
        Me.LargeIconsToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.LargeIconsToolStripMenuItem.Text = "Nagy ikonok"
        '
        'SmallIconsToolStripMenuItem
        '
        Me.SmallIconsToolStripMenuItem.Name = "SmallIconsToolStripMenuItem"
        Me.SmallIconsToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.SmallIconsToolStripMenuItem.Text = "Kicsi ikonok"
        '
        'TileToolStripMenuItem
        '
        Me.TileToolStripMenuItem.Name = "TileToolStripMenuItem"
        Me.TileToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.TileToolStripMenuItem.Text = "Elrendezés"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'GoToolStripButton
        '
        Me.GoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoToolStripButton.Name = "GoToolStripButton"
        Me.GoToolStripButton.Size = New System.Drawing.Size(55, 25)
        Me.GoToolStripButton.Text = "&Ugrás"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(94, 25)
        Me.EditToolStripButton.Text = "&Szerkesztés"
        '
        'SearchWindow
        '
        Me.AcceptButton = Me.SearchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.command2
        Me.ClientSize = New System.Drawing.Size(600, 494)
        Me.Controls.Add(Me.ToolStripContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(200, 250)
        Me.Name = "SearchWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Keresés"
        Me.ToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ResumeLayout(False)
        Me.ToolStripContainer.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SearchEverywhereCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FindText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents command2 As System.Windows.Forms.Button
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchTitleLabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
