Imports System.Diagnostics
Imports System.Windows.Forms

Public Class SearchDialog

    Private Sub LoadListView()
        Dim lvItem As ListViewItem
        ResultListView.Items.Clear()

        lvItem = ResultListView.Items.Add("ListViewItem1")
        lvItem.ImageKey = "Graph1"
        lvItem.SubItems.AddRange(New String() {"Column2", "Column3"})

        lvItem = ResultListView.Items.Add("ListViewItem2")
        lvItem.ImageKey = "Graph2"
        lvItem.SubItems.AddRange(New String() {"Column2", "Column3"})

        lvItem = ResultListView.Items.Add("ListViewItem3")
        lvItem.ImageKey = "Graph3"
        lvItem.SubItems.AddRange(New String() {"Column2", "Column3"})
    End Sub

    Private Sub SetUpListViewColumns()
        SetView(View.SmallIcon)
        SetView(View.Details)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Close this form
        Me.Close()
    End Sub

    Private Sub SetView(ByVal View As System.Windows.Forms.View)
        Dim MenuItemToCheck As ToolStripMenuItem = Nothing
        Select Case View
            Case View.LargeIcon
                MenuItemToCheck = LargeIconsToolStripMenuItem
            Case View.List
                MenuItemToCheck = ListToolStripMenuItem
            Case View.SmallIcon
                MenuItemToCheck = SmallIconsToolStripMenuItem
            Case View.Tile
                MenuItemToCheck = TileToolStripMenuItem
            Case Else
                Debug.Fail("Unexpected View")
                View = View.Details
        End Select

        For Each MenuItem As ToolStripMenuItem In ListViewToolStripButton.DropDownItems
            If MenuItem Is MenuItemToCheck Then
                MenuItem.Checked = True
            Else
                MenuItem.Checked = False
            End If
        Next

        ResultListView.View = View
    End Sub

    Private Sub ListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListToolStripMenuItem.Click
        SetView(View.List)
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetView(View.Details)
    End Sub

    Private Sub LargeIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LargeIconsToolStripMenuItem.Click
        SetView(View.LargeIcon)
    End Sub

    Private Sub SmallIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallIconsToolStripMenuItem.Click
        SetView(View.SmallIcon)
    End Sub

    Private Sub TileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileToolStripMenuItem.Click
        SetView(View.Tile)
    End Sub

    Private Sub List1_DoubleClick() Handles ResultListView.DoubleClick
        GoButton_Click()
    End Sub

    Private Sub ResultListView_SelectedIndexChanged() Handles ResultListView.SelectedIndexChanged
        If ResultListView.SelectedItems.Count > 0 Then
            EditToolStripButton.Enabled = True
            GoToolStripButton.Enabled = True
            ToolStripStatusLabel.Text = ResultListView.SelectedItems(0).Text & "; listából a " & ResultListView.SelectedItems(0).Name + 1 & "."
        Else
            EditToolStripButton.Enabled = False
            GoToolStripButton.Enabled = False
        End If
    End Sub

    Private Sub SearchButton_Click() Handles SearchButton.Click
        Dim textPart As String, findFor As String = FindText.Text.Trim
        If findFor = "" Then
            MsgBox("Nem írt be szöveget.", MsgBoxStyle.Information)
            Exit Sub
        ElseIf findFor.Contains("=") Then
            MsgBox("Érvénytelen kifejezés.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim currentIndex As Integer = MainForm.WordsListBox.SelectedIndex
        Dim resultCount As Integer = 0
        Dim searchEveryWhere As Boolean = SearchEverywhereCheckBox.Checked
        EditToolStripButton.Enabled = True
        GoToolStripButton.Enabled = True
        ResultListView.Clear()
        For i = 0 To MainForm.WordsListBox.Items.Count - 1
            If searchEveryWhere Then
                For j = 1 To Len(MainForm.WordsListBox.Items(i)) - Len(findFor)
                    textPart = LCase(Mid(MainForm.WordsListBox.Items(i), j, Len(findFor)))
                    If textPart = LCase(findFor) Then
                        ResultListView.Items.Add(MainForm.WordsListBox.Items(i), 3)
                        ResultListView.Items(resultCount).Name = i
                        resultCount += 1
                    End If
                Next
            Else
                textPart = LCase(Mid(MainForm.WordsListBox.Items(i), 1, Len(findFor)))
                If textPart = LCase(findFor) Then
                    ResultListView.Items.Add(MainForm.WordsListBox.Items(i), 3)
                    ResultListView.Items(resultCount).Name = i
                    resultCount += 1
                End If
            End If
        Next
        MainForm.WordsListBox.SelectedIndex = currentIndex
        If ResultListView.Items.Count = 0 Then
            MsgBox("Nem található!", vbInformation)
            FindText.Focus()
            EditToolStripButton.Enabled = False
            GoToolStripButton.Enabled = False
        Else
            ResultListView.Focus()
        End If
    End Sub

    Private Sub GoButton_Click() Handles GoToolStripButton.Click
        If ResultListView.SelectedItems.Count > 0 Then
            MainForm.WordsListBox.SelectedIndex = ResultListView.SelectedItems(0).Name
            Close()
            MainForm.Activate()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripButton.Click
        SearchButton_Click()
    End Sub

    Private Sub command2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles command2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GoButton_Click()
    End Sub

    Private Sub SearchWindow_Load(sender As Object, e As EventArgs)
        ResultListView_SelectedIndexChanged()
        ResultListView.Clear()
        FindText.Clear()
        SearchTitleLabel.Focus()
    End Sub
End Class
