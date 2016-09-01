Imports System.Windows.Forms

Public Class ChooseVocab

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        On Error GoTo 5

        '        FileOpen(20, TextBox1.Text + ".voc", OpenMode.Output)
        '       FileClose(20)
        MainScreen.filenam.Text = ListBox1.Items(ListBox1.SelectedIndex)
        MainScreen.megnyitas()
        'If CheckBox2.Checked = True Then
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
        Exit Sub
5:      MsgBox("Rossz név.", MsgBoxStyle.Exclamation)



    
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub Dialog3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        Dim szo$
        FileOpen(54, "voclist.dat", OpenMode.Input)
        Do Until EOF(54)
            Input(54, szo$)
            ListBox1.Items.Add(szo$)
        Loop
        FileClose(54)
        ListBox1.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mely
        mely = OpenFileDialog1.ShowDialog
        If mely = vbOK Then

            On Error GoTo 5

            '        FileOpen(20, TextBox1.Text + ".voc", OpenMode.Output)
            '       FileClose(20)
            MainScreen.filenam.Text = OpenFileDialog1.FileName
            MainScreen.megnyitas()
            'If CheckBox2.Checked = True Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()


        End If
        Exit Sub
5:      MsgBox("Rossz név.", MsgBoxStyle.Exclamation)
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
    End Sub
End Class
