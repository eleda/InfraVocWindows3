Imports System.Windows.Forms

Public Class Rewrite

    Private Sub OK_Button_Click() Handles OK_Button.Click
        Dim indet

        indet = MainScreen.List1.SelectedIndex
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'MsgBox(indet)
        'Form1.List1.Items.RemoveAt(Form1.List1.SelectedIndex)
        MainScreen.List1.Items(indet) = szo.Text
        'Form1.List1.Items.Insert(indet, )
        MainScreen.List1.SelectedItem = indet

        'Form1.List1.SelectedIndex = indet.Text
        'Form1.List1.List(Form1.List1.ListIndex) = szo.Text
        'Print #5, "Átnevezés: " & Form1.List1.Text & ", " & szo.Text
        MainScreen.ado.Text = 1

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'On Error GoTo 20
        szo.Text = MainScreen.List1.SelectedItem.ToString
        Label1.Focus()
        Exit Sub
        '20:     MsgBox("Nincsen kijelölt elem.", MsgBoxStyle.Exclamation, "Infra Vocabulary")
        'Exit Sub
        'Label1.Focus()

    End Sub
End Class
