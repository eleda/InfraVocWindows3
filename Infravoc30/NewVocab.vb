Imports System.Windows.Forms

Public Class NewVocab

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        On Error GoTo 5

        FileOpen(20, TextBox1.Text + ".voc", OpenMode.Output)
        FileClose(20)
        MainScreen.filenam.Text = TextBox1.Text + ".voc"
        MainScreen.megnyitas()
        'If CheckBox2.Checked = True Then
        If CheckBox1.Checked Then
            ChooseVocab.ListBox1.Items.Add(TextBox1.Text + ".voc")
            Settings.ListBox1.Items.Add(TextBox1.Text + ".voc")
            MainScreen.szolistament_dialog3bol()
        End If
        If CheckBox2.Checked = True Then
            Settings.TextBox1.Text = TextBox1.Text + ".voc"
            Settings.beallitas_mentes()
        End If


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
        Exit Sub
5:      MsgBox("Rossz név.", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged() Handles TextBox1.TextChanged

        If TextBox1.Text = "" Then OK_Button.Enabled = False Else OK_Button.Enabled = True

    End Sub

    Private Sub Dialog4_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1_TextChanged()
        Label1.Focus()
        TextBox1.Focus()

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub
End Class
