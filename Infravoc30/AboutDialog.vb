Imports System.Windows.Forms

Public Class AboutDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub OK_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TitleLbl.Text = My.Application.Info.Title.ToString
        VerLbl.Text = "Verziószám: " + My.Application.Info.Version.ToString
        YearLbl.Text = My.Application.Info.Copyright.ToString

    End Sub

    Private Sub LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("http://www.freeimages.com/photo/pink-note-1507506")
    End Sub

    Private Sub AboutDialog_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Space Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub AboutDialog_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class
