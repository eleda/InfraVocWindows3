Imports System.Windows.Forms

Public Class RewriteDialog

    Private Sub OK_Button_Click() Handles OK_Button.Click

        If word.Text.Contains("=") Or meaning.Text.Contains("=") Then
            MsgBox("A szó vagy a jelentés elválaszó egyenlőségjelet tartalmaz.")
            word.Focus()
        ElseIf word.text.Length = 0 Then
            MsgBox("A szó mező üres.")
            word.Focus()
        ElseIf meaning.text.Length = 0 Then
            MsgBox("A jelentés mező üres.")
            meaning.Focus()
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RewriteDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
