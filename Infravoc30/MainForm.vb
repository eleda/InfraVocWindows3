Public Class MainForm

    Dim vocabChanged As Boolean = False
    Dim currentFileName As String = ""

    Private Sub NewEntry()
        NewEntryDialog.ShowDialog()
    End Sub

    Private Sub List1_Click() Handles WordsListBox.Click
        Form1_Activated()
    End Sub

    Private Sub DeleteSelectedWord()
        If WordsListBox.SelectedIndex = -1 Then
            MsgBox("Nem jelölt ki elemet.", vbExclamation)
            Exit Sub
        End If

        Dim torole = MsgBox("Tényleg törli az elemet?", vbQuestion + vbYesNo)
        If torole = vbYes Then
            Try
                WordsListBox.Items.RemoveAt(WordsListBox.SelectedIndex)
                vocabChanged = True
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Form1_Activated()
        If WordsListBox.SelectedIndex = -1 Then
            EditWordToolStripButton.Enabled = False
            DeleteWordToolStripButton.Enabled = False
        Else
            EditWordToolStripButton.Enabled = True
            DeleteWordToolStripButton.Enabled = True
        End If
    End Sub

    Private Sub Form1_Activated1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        List1_SelectedIndexChanged_1()
    End Sub

    Private Sub Form1_FormClosing() Handles Me.FormClosing
        If vocabChanged Then
            Dim a = MsgBox("Kívánja menteni '" & currentFileName & "' szószedetet?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If a = vbYes Then
                SaveVocabulary()
                End
                Exit Sub
            End If
            If a = vbNo Then
                End
            End If
        End If
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    Private Sub DeleteAllWords()
        Dim torole = MsgBox("Valóban törli az összes elemet?", vbQuestion + vbYesNo)
        If torole = vbYes Then
            Try
                WordsListBox.Items.Clear()
                vocabChanged = True
            Catch ex As Exception
                MsgBox("Hiba!" + vbNewLine + ex.Message, vbExclamation)
            End Try
        End If
    End Sub

    Private Sub OKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkToolStripMenuItem.Click
        NotifyIcon.Visible() = False
    End Sub

    Sub megnyitas()
        RefreshVocabulary()
    End Sub

    Private Sub filenam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FilenameToolStripLabel.Text = currentFileName
    End Sub

    Private Sub ShowSettingsDialog()
        Dim settingsDlg = New SettingsDialog
        If settingsDlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' Save settings
        End If
    End Sub

    Sub LoadSettings()
        Dim StarUpFile As String = "", isToolBarOn, isStatusBarOn As Boolean
        Dim oneFile As String = ""

        isToolBarOn = isStatusBarOn = True

        Try

            ' Load Options File
            FileOpen(10, VocabularyHelper.GetOptionsFilename(), OpenMode.Input)
            Input(10, StarUpFile)
            Input(10, isToolBarOn)
            Input(10, isStatusBarOn)
            currentFileName = StarUpFile
            SettingsDialog.TextBox1.Text = StarUpFile
            If isToolBarOn Then ToolStrip.Visible = True Else ToolStrip.Visible = False
            If isToolBarOn Then SettingsDialog.CheckBox1.Checked = True Else ToolStrip.Visible = False
            If isStatusBarOn = True Then StatusStrip.Visible = True Else StatusStrip.Visible = False
            If isStatusBarOn = True Then SettingsDialog.CheckBox2.Checked = True Else SettingsDialog.CheckBox2.Checked = False
            FileClose(10)

            ' Load Voclist File
            FileOpen(10, "voclist.dat", OpenMode.Input)
            Do Until EOF(10)
                Input(10, oneFile)
                SettingsDialog.ListBox1.Items.Clear()
                ChooseVocabDialog.VocabListBox.Items.Clear()
                ChooseVocabDialog.VocabListBox.Items.Add(oneFile)
                SettingsDialog.ListBox1.Items.Add(oneFile)
            Loop

        Catch ex As Exception
            MsgBox("A beállításokat nem lehetett betölteni, mert OPTIONS.DAT nem található vagy sérült." + vbNewLine + ex.Message, MsgBoxStyle.Critical)
            'End
        Finally
            FileClose(10)
        End Try
    End Sub

    Private Sub ShowAboutDialog()
        AboutDialog.ShowDialog()
    End Sub

    Private Sub gomb_atnev_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowRewriteDialog()
    End Sub

    Private Sub ShowRewriteDialog()
        Dim rewriteDialog = New RewriteDialog
        rewriteDialog.szo.Text = Me.WordsListBox.SelectedItem.ToString
        If (rewriteDialog.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Dim wordString As String = rewriteDialog.szo.Text
            Dim index = Me.WordsListBox.SelectedIndex
            Me.WordsListBox.Items(index) = wordString
            Me.WordsListBox.SelectedItem = index
            vocabChanged = True
        End If
    End Sub

    Private Sub ShowNewEntryDialog()
        Dim newEntryDialog = New NewEntryDialog
        If newEntryDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.WordsListBox.Items.Add(newEntryDialog.LeftTextBox.Text & "=" & newEntryDialog.RightTextBox.Text)
            vocabChanged = True
        End If
    End Sub

    Private Sub gomb_torol_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteWordToolStripButton.Click
        DeleteSelectedWord()
    End Sub
    Private Sub ShowSearchDialog()
        Dim searchDialog = New SearchDialog
        searchDialog.Show()
    End Sub

    Private Sub List1_SelectedIndexChanged_1() Handles WordsListBox.SelectedIndexChanged
        Form1_Activated()
        Try
            If WordsListBox.SelectedItems.Count > 0 Then
                InfoToolStripStatusLabel.Text = WordsListBox.Items(WordsListBox.SelectedIndex)
                WordDisplayToolStripStatusLabel.Text = WordsListBox.SelectedIndex + "1" & "/" & WordsListBox.Items.Count
                WordLengthToolStripStatusLabel.Text = "Hossz: " & Len(WordsListBox.Items(WordsListBox.SelectedIndex))
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub UpdateTitle()
        If vocabChanged Then
            FilenameToolStripLabel.Text = currentFileName + "*"
        Else
            FilenameToolStripLabel.Text = currentFileName
        End If
    End Sub

    Private Sub ÚjSzótárToolStripMenuItem_Click() Handles NewVocabToolStripMenuItem.Click
    End Sub

    Sub SaveWordList()
        FileOpen(10, "voclist.dat", OpenMode.Output)
        For e = 0 To ChooseVocabDialog.VocabListBox.Items.Count - 1
            PrintLine(10, ChooseVocabDialog.VocabListBox.Items(e))
        Next
        FileClose(10)
    End Sub

    Private Sub NewVocabulary()
        Dim newVocabularyDialog = New NewVocabDialog
        SaveVocabulary()
        RefreshVocabulary()
        If newVocabularyDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim newVocabFileName As String = newVocabularyDialog.VocabNameTextBox.Text + ".voc"
            Dim setBaseVocab As Boolean = newVocabularyDialog.AddToVocabListCheckBox.Checked
            Dim addToVocabList As Boolean = newVocabularyDialog.SetAsBaseVocabCheckBox.Checked
            Try
                FileOpen(20, newVocabFileName, OpenMode.Output)
                FileClose(20)
                currentFileName = newVocabFileName
                megnyitas()
                If setBaseVocab Then
                    ChooseVocabDialog.VocabListBox.Items.Add(newVocabFileName)
                    SettingsDialog.ListBox1.Items.Add(newVocabFileName)
                    SaveWordList()
                End If
                If addToVocabList Then
                    SettingsDialog.TextBox1.Text = newVocabFileName
                    SettingsDialog.SaveSettings()
                End If
            Catch ex As Exception
                MsgBox("Rossz név.", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub SaveVocabulary()
        FileClose(1)
        FileOpen(1, currentFileName, OpenMode.Output)
        For e = 0 To WordsListBox.Items.Count - 1
            PrintLine(1, WordsListBox.Items(e))
        Next e
        FileClose(1)
        vocabChanged = False
        RefreshVocabulary()
    End Sub

    Private Sub RefreshVocabulary()
        Dim currentLine As String = ""
        Try
            WordsListBox.Items.Clear()
            FileOpen(1, currentFileName, OpenMode.Input)
            Do Until EOF(1)
                Input(1, currentLine)
                'MsgBox(elem$)
                WordsListBox.Items.Add(currentLine)
            Loop
            FileClose(1)
        Catch ex As Exception
            NotifyIcon.ShowBalloonTip(73000, "Infra vocabulary", "Először használja az Infra Vocabulary programot", ToolTipIcon.Info)
            FileClose()
            FileOpen(1, currentFileName, OpenMode.Output)
            FileClose(1)
        End Try
        vocabChanged = False
    End Sub

    Private Sub EditWordToolStripButton_Click(sender As Object, e As EventArgs) Handles EditWordToolStripButton.Click
        ShowRewriteDialog()
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        ShowRewriteDialog()
    End Sub

    Private Sub NewWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWordToolStripMenuItem.Click
        ShowNewEntryDialog()
    End Sub

    Private Sub NewWordToolStripButton_Click(sender As Object, e As EventArgs) Handles NewWordToolStripButton.Click
        ShowNewEntryDialog()
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        ShowSearchDialog()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        ShowSearchDialog()
    End Sub

    Private Sub WordsListBox_DoubleClick(sender As Object, e As EventArgs) Handles WordsListBox.DoubleClick
        ShowRewriteDialog()
    End Sub

    Private Sub EditContextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditContextToolStripMenuItem.Click
        ShowRewriteDialog()
    End Sub

    Private Sub DeleteContextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteContextToolStripMenuItem.Click
        DeleteSelectedWord()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteSelectedWord()
    End Sub

    Private Sub AboutToolStripButton_Click(sender As Object, e As EventArgs) Handles AboutToolStripButton.Click
        ShowAboutDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ShowAboutDialog()
    End Sub

    Private Sub NewVocabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewVocabToolStripMenuItem.Click
        NewVocabulary()
    End Sub

    Private Sub ChooseVocabulary()
        SaveVocabulary()
        RefreshVocabulary()
        Dim chooseVocabDlg = New ChooseVocabDialog
        If chooseVocabDlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                currentFileName = chooseVocabDlg.chosenFileName
                megnyitas()
            Catch ex As Exception
                MsgBox("Rossz név.", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub ChooseVocabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChooseVocabToolStripMenuItem.Click
        ChooseVocabulary()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveVocabulary()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        RefreshVocabulary()
    End Sub

    Private Sub Minimize()
        If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal Else Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ExitProgram()
        Form1_FormClosing()
        End
    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        Minimize()
    End Sub

    Private Sub ExitToolItem_Click(sender As Object, e As EventArgs) Handles ExitToolItem.Click
        ExitProgram()
    End Sub

    Private Sub DeleteAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAllToolStripMenuItem.Click
        DeleteAllWords()
    End Sub

    Private Sub BasicSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BasicSettingsToolStripMenuItem.Click
        ShowSettingsDialog()
    End Sub

    Private Sub NewItemContextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewItemContextToolStripMenuItem.Click
        ShowNewEntryDialog()
    End Sub

    Private Sub SearchContextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchContextToolStripMenuItem.Click
        ShowSearchDialog()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.Title.ToString
        List1_Click()
        LoadSettings()
        RefreshVocabulary()
    End Sub

    Private Sub OpenVocabToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenVocabToolStripButton.Click
        ChooseVocabulary()
    End Sub

    Private Sub ÚjSzótárToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewVocabToolStripMenuItem.Click

    End Sub
End Class