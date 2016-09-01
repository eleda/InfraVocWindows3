Imports System.Windows.Forms

Public Class AboutDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub OK_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleLbl.Text = My.Application.Info.Title.ToString
        VerLbl.Text = "Verziószám: " + My.Application.Info.Version.ToString
        YearLbl.Text = My.Application.Info.Copyright.ToString

    End Sub

End Class
