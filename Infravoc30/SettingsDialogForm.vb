Imports System.Windows.Forms

Public Class SettingsDialogForm
    Sub beallitas_mentes()
        Dim bejeloles, e
        ' Close(10)
        FileOpen(10, "options.dat", OpenMode.Output)
        PrintLine(10, TextBox1.Text)
        '  Form1.filenam.Text = TextBox1.Text
        bejeloles = CheckBox1.Checked
        PrintLine(10, bejeloles)
        MainForm.ToolStrip.Visible = bejeloles
        bejeloles = CheckBox2.Checked
        PrintLine(10, bejeloles)
        MainForm.ToolStrip.Visible = bejeloles
        FileClose(10)
        FileOpen(10, "voclist.dat", OpenMode.Output)
        For e = 0 To ListBox1.Items.Count - 1
            PrintLine(10, ListBox1.Items(e))
        Next
        FileClose(10)
        MainForm.ToolStrip.Visible = CheckBox1.Checked
        MainForm.StatusStrip.Visible = CheckBox2.Checked

    End Sub
    Private Sub OK_Button_Click() Handles OK_Button.Click
        beallitas_mentes()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ke
        OpenFileDialog1.FileName = TextBox1.Text
        ke = OpenFileDialog1.ShowDialog()
        If ke = vbOK Then TextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ol
        ol = FontDialog1.ShowDialog()
        If ol = vbOK Then

            '1:          TextBox2.Text = FontDialog1.Font.Name
            '           NumericUpDown1.Value = FontDialog1.Font.Size
            '          CheckBox3.Checked = FontDialog1.Font.Bold
            '         CheckBox4.Checked = FontDialog1.Font.Italic
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim oda
        '       OpenFileDialog1.FileName = ListBox1.Items(ListBox1.SelectedIndex)
        oda = OpenFileDialog1.ShowDialog()

        If oda = vbOK Then ListBox1.Items.Add(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        '        OpenFileDialog1.FileName = ListBox1.Items(ListBox1.SelectedIndex)

        ModifyEntryDialogForm.ind.Text = ListBox1.SelectedIndex
        ModifyEntryDialogForm.TextBox1.Text = ListBox1.Items(ListBox1.SelectedIndex)
        ModifyEntryDialogForm.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ol
        ol = ColorDialog1.ShowDialog()
        ' If ol = vbOK Then PictureBox1.BackColor = ColorDialog1.Color

    End Sub

  

    Private Sub ListBox1_SelectedIndexChanged() Handles ListBox1.SelectedIndexChanged

        If ListBox1.SelectedIndex < 0 Then Button6.Enabled = False Else Button6.Enabled = True
        If ListBox1.SelectedIndex < 0 Then Button7.Enabled = False Else Button7.Enabled = True

    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo 67
        Dim bej1, bej2
        FileOpen(36, "options.dat", OpenMode.Input)
        Input(36, TextBox1.Text)
        Input(36, bej1)
        Input(36, bej2)
        FileClose(36)
        If bej1 = True Then CheckBox1.Checked = True Else CheckBox1.Checked = False
        If bej2 = True Then CheckBox2.Checked = True Else CheckBox2.Checked = False

        ListBox1_SelectedIndexChanged()
        Exit Sub
67:     MsgBox("Nem sikerült betölteni a beállításokat.", MsgBoxStyle.Critical)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Add(TextBox1.Text)
        ListBox1.Focus()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
       
    End Sub
End Class
