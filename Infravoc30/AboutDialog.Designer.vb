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
        Me.VerLbl = New System.Windows.Forms.Label()
        Me.YearLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'VerLbl
        '
        Me.VerLbl.AutoSize = True
        Me.VerLbl.BackColor = System.Drawing.Color.Transparent
        Me.VerLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.VerLbl.Location = New System.Drawing.Point(47, 289)
        Me.VerLbl.Name = "VerLbl"
        Me.VerLbl.Size = New System.Drawing.Size(83, 21)
        Me.VerLbl.TabIndex = 1
        Me.VerLbl.Text = "<version>"
        '
        'YearLbl
        '
        Me.YearLbl.AutoSize = True
        Me.YearLbl.BackColor = System.Drawing.Color.Transparent
        Me.YearLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.YearLbl.Location = New System.Drawing.Point(270, 289)
        Me.YearLbl.Name = "YearLbl"
        Me.YearLbl.Size = New System.Drawing.Size(98, 21)
        Me.YearLbl.TabIndex = 2
        Me.YearLbl.Text = "<copyright>"
        '
        'AboutDialog
        '
        Me.AccessibleDescription = "Bezárásához nyomjon entert."
        Me.AccessibleName = "Névjegy ablak."
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.InfraVocabularyWindows.My.Resources.Resources.infrravoc_splash1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(506, 334)
        Me.Controls.Add(Me.YearLbl)
        Me.Controls.Add(Me.VerLbl)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VerLbl As System.Windows.Forms.Label
    Friend WithEvents YearLbl As System.Windows.Forms.Label
End Class
