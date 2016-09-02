Imports System.Windows.Forms

Public Class ChooseVocabDialog

    Const vocListFile As String = "voclist.dat"
    Public chosenFileName As String

    Private Sub LoadVocabs()
        VocabListBox.Items.Clear()
        Dim actualVocabName As String = ""
        FileOpen(1, vocListFile, OpenMode.Input)
        Do Until EOF(1)
            Input(1, actualVocabName)
            VocabListBox.Items.Add(actualVocabName)
        Loop
        FileClose(1)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ChooseVocabDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVocabs()
    End Sub

    Private Sub FromFileButton_Click(sender As Object, e As EventArgs) Handles FromFileButton.Click
        FromFileRadioButton.Checked = True
        If OpenFileDialog.ShowDialog = vbOK Then
            chosenFileName = OpenFileDialog.FileName
            FilenameLabel.Text = chosenFileName
        End If
    End Sub

    Private Sub VocabListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VocabListBox.SelectedIndexChanged
        FromListRadioButton.Checked = True
        chosenFileName = VocabListBox.SelectedItem.ToString()
        FilenameLabel.Text = chosenFileName
    End Sub

    Private Sub VocabListBox_DoubleClick(sender As Object, e As EventArgs) Handles VocabListBox.DoubleClick
        OK_Button_Click(sender, e)
    End Sub
End Class
