Imports System.Windows.Forms

Public Class ModifyEntry
    Dim index As Integer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Settings.ListBox1.Items(ind.Text) = TextBox1.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog3.FileName = TextBox1.Text
        Dim di
        di = OpenFileDialog3.ShowDialog()
        If di = vbOK Then TextBox1.Text = OpenFileDialog3.FileName

    End Sub

    Public Sub SetIndex(ByVal index As Integer)
        Me.index = index
    End Sub

    Public Function GetIndex() As Integer
        Return Me.index
    End Function

End Class
