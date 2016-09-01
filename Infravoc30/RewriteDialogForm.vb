Imports System.Windows.Forms

Public Class RewriteDialog

    Private Sub OK_Button_Click() Handles OK_Button.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RewriteDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Focus()
    End Sub
End Class
