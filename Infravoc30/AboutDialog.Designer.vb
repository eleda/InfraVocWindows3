<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AboutDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutDialog))
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.VerLbl = New System.Windows.Forms.Label()
        Me.YearLbl = New System.Windows.Forms.Label()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLbl
        '
        Me.TitleLbl.BackColor = System.Drawing.Color.Transparent
        Me.TitleLbl.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TitleLbl.Location = New System.Drawing.Point(95, 20)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(233, 72)
        Me.TitleLbl.TabIndex = 0
        Me.TitleLbl.Text = "<title>"
        '
        'VerLbl
        '
        Me.VerLbl.AutoSize = True
        Me.VerLbl.BackColor = System.Drawing.Color.Transparent
        Me.VerLbl.Location = New System.Drawing.Point(95, 92)
        Me.VerLbl.Name = "VerLbl"
        Me.VerLbl.Size = New System.Drawing.Size(71, 23)
        Me.VerLbl.TabIndex = 1
        Me.VerLbl.Text = "<version>"
        '
        'YearLbl
        '
        Me.YearLbl.AutoSize = True
        Me.YearLbl.BackColor = System.Drawing.Color.Transparent
        Me.YearLbl.Location = New System.Drawing.Point(95, 128)
        Me.YearLbl.Name = "YearLbl"
        Me.YearLbl.Size = New System.Drawing.Size(86, 23)
        Me.YearLbl.TabIndex = 2
        Me.YearLbl.Text = "<copyright>"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.OK_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OK_Button.ForeColor = System.Drawing.Color.White
        Me.OK_Button.Location = New System.Drawing.Point(231, 197)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(97, 39)
        Me.OK_Button.TabIndex = 4
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.InfraVocabularyWindows.My.Resources.Resources.InfraVocIcon3
        Me.PictureBox1.Location = New System.Drawing.Point(14, 20)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'AboutDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.OK_Button
        Me.ClientSize = New System.Drawing.Size(342, 256)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.YearLbl)
        Me.Controls.Add(Me.VerLbl)
        Me.Controls.Add(Me.TitleLbl)
        Me.Controls.Add(Me.OK_Button)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents TitleLbl As System.Windows.Forms.Label
    Friend WithEvents VerLbl As System.Windows.Forms.Label
    Friend WithEvents YearLbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
