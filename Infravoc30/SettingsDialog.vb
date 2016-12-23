Imports System.Windows.Forms


Public Class SettingsDialog
    'Const OPTIONS_FILE As String = "options.dat"
    Const VOCLIST_FILE As String = "voclist.dat"

    Sub SaveSettings()
        ' My.Settings.IsToolbarOn = ToolbarCheckBox.Checked
        ' My.Settings.IsStatusbarOn = StatusBarCheckBox.Checked
        My.Settings.StartupFile = StartupOpenTextBox.Text

        Try
            FileOpen(1, VOCLIST_FILE, OpenMode.Output)
            For i = 0 To VocListBox.Items.Count - 1
                PrintLine(1, VocListBox.Items(i))
            Next
            FileClose(1)
        Catch ex As Exception
            MsgBox("Mentési hiba." + vbNewLine + ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub LoadSettings()
        Try
            ' alap - elso lap
            ' ToolbarCheckBox.Checked = My.Settings.IsToolbarOn
            ' StatusBarCheckBox.Checked = My.Settings.IsStatusbarOn
            StartupOpenTextBox.Text = My.Settings.StartupFile

            ListBox1_SelectedIndexChanged()
            Exit Sub
            ' szotarlista - masodik lap
            '
        Catch ex As Exception
            MsgBox("Nem sikerült betölteni a beállításokat." + vbNewLine + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub OK_Button_Click() Handles OK_Button.Click
        SaveSettings()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged() Handles VocListBox.SelectedIndexChanged
        If VocListBox.SelectedIndex < 0 Then ModifyButton.Enabled = False Else ModifyButton.Enabled = True
        If VocListBox.SelectedIndex < 0 Then DeleteButton.Enabled = False Else DeleteButton.Enabled = True
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim modifyEntryDlg = New ModifyEntryDialog()
        modifyEntryDlg.EntryTextBox.Text = VocListBox.Items(VocListBox.SelectedIndex)
        If modifyEntryDlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            VocListBox.Items(VocListBox.SelectedIndex) = modifyEntryDlg.EntryTextBox.Text
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        VocListBox.Items.RemoveAt(VocListBox.SelectedIndex)
    End Sub

    Private Sub NewItemButton_Click(sender As Object, e As EventArgs) Handles NewItemButton.Click
        If StartupOpenFileDialog.ShowDialog() = vbOK Then VocListBox.Items.Add(StartupOpenFileDialog.FileName)
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        StartupOpenFileDialog.FileName = StartupOpenTextBox.Text
        If StartupOpenFileDialog.ShowDialog() = vbOK Then StartupOpenTextBox.Text = StartupOpenFileDialog.FileName
    End Sub

    Private Sub AddToVocabListButton_Click(sender As Object, e As EventArgs) Handles AddToVocabListButton.Click
        VocListBox.Items.Add(StartupOpenTextBox.Text)
        VocListBox.Focus()
    End Sub

    Private Sub SettingsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub
End Class
