<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsDialogForm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Tab_alap = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tabse = New System.Windows.Forms.TabControl()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Tab_alap.SuspendLayout()
        Me.Tabse.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(283, 280)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.voc"
        Me.OpenFileDialog1.Filter = """Infra Vocabulary 3x fájlok|*.voc|Régi Infra Vocabulary fájlok|words.txt|Minden f" &
    "ájl|*.*"""
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.DefaultExt = "*.voc"
        Me.OpenFileDialog3.Filter = """Infra Vocabulary 3x fájlok|*.voc|Régi Infra Vocabulary fájlok|words.txt|Minden f" &
    "ájl|*.*"""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(408, 231)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Szótárlista"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(289, 197)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 24)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "&Töröl"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(156, 197)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(111, 24)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "&Módosít..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(18, 197)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 24)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "&Új elem..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(16, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(373, 173)
        Me.ListBox1.TabIndex = 0
        '
        'Tab_alap
        '
        Me.Tab_alap.Controls.Add(Me.CheckBox2)
        Me.Tab_alap.Controls.Add(Me.CheckBox1)
        Me.Tab_alap.Controls.Add(Me.Button2)
        Me.Tab_alap.Controls.Add(Me.Label3)
        Me.Tab_alap.Controls.Add(Me.Button1)
        Me.Tab_alap.Controls.Add(Me.TextBox1)
        Me.Tab_alap.Controls.Add(Me.Label1)
        Me.Tab_alap.Location = New System.Drawing.Point(4, 22)
        Me.Tab_alap.Name = "Tab_alap"
        Me.Tab_alap.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_alap.Size = New System.Drawing.Size(408, 231)
        Me.Tab_alap.TabIndex = 0
        Me.Tab_alap.Text = "Alap"
        Me.Tab_alap.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(20, 146)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(79, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "&Állapotsor"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(20, 123)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "&Eszköztár"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Felvétel a szótárlista közé"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(302, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Tallóz..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(278, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Indításkor az alábbi szótárfájl megnyitása:"
        '
        'Tabse
        '
        Me.Tabse.Controls.Add(Me.Tab_alap)
        Me.Tabse.Controls.Add(Me.TabPage1)
        Me.Tabse.Location = New System.Drawing.Point(12, 12)
        Me.Tabse.Name = "Tabse"
        Me.Tabse.SelectedIndex = 0
        Me.Tabse.Size = New System.Drawing.Size(416, 257)
        Me.Tabse.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.Tabse.TabIndex = 0
        '
        'Settings
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(441, 316)
        Me.Controls.Add(Me.Tabse)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Beállítások"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Tab_alap.ResumeLayout(False)
        Me.Tab_alap.PerformLayout()
        Me.Tabse.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents OpenFileDialog3 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Tab_alap As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tabse As System.Windows.Forms.TabControl
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
