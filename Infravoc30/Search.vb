Imports System.Diagnostics
Imports System.Windows.Forms

Public Class SearchWindow

    Private Sub Explorer1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ResultListView_SelectedIndexChanged()
        SearchTitleLabel.Focus()
        ResultListView.Clear()
        FindText.Clear()
    End Sub

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
        If FindText.Text = "" Then MsgBox("Nem írt be szöveget.", MsgBoxStyle.Information) : Exit Sub
        EditToolStripButton.Enabled = True
        GoToolStripButton.Enabled = True
        ResultListView.Clear()
        Dim go, k
        Dim eda, e, keresszov$, o
        o = 0
        eda = MainScreen.List1.SelectedIndex

        For e = 0 To MainScreen.List1.Items.Count - 1
            If SearchEverywhereCheckBox.Checked = True Then
                For k = 1 To Len(MainScreen.List1.Items(e)) - Len(FindText.Text)
                    keresszov$ = LCase$(Mid$(MainScreen.List1.Items(e), k, Len(FindText.Text)))
                    If keresszov$ = LCase$(FindText.Text) Then
                        ResultListView.Items.Add(MainScreen.List1.Items(e), 3)
                        ResultListView.Items(o).Name = e
                        o = o + 1
                        GoTo bbb
                    End If
                Next k

            Else
                keresszov$ = LCase$(Mid$(MainScreen.List1.Items(e), 1, Len(FindText.Text)))
                If keresszov$ = LCase$(FindText.Text) Then
                    ResultListView.Items.Add(MainScreen.List1.Items(e), 3)
                    ResultListView.Items(o).Name = e
                    o = o + 1
                End If
            End If
bbb:
        Next e

        If ResultListView.Items.Count <> 0 Then
            For go = 0 To ResultListView.Items.Count
            Next go
        End If

        MainScreen.List1.SelectedIndex = eda
        If ResultListView.Items.Count = 0 Then
            MsgBox("Nem található!", vbInformation)
            FindText.Focus()
            EditToolStripButton.Enabled = False
            GoToolStripButton.Enabled = False
            Exit Sub
        End If
        ResultListView.Focus()
    End Sub

    Private Sub GoButton_Click() Handles GoToolStripButton.Click
        If ResultListView.SelectedItems.Count > 0 Then
            MainScreen.List1.SelectedIndex = ResultListView.SelectedItems(0).Name
            Close()
            MainScreen.Activate()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripButton.Click
        SearchButton_Click()
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click
        If ResultListView.SelectedItems.Count > 0 Then
            MainScreen.List1.SelectedIndex = ResultListView.SelectedItems(0).Name
            Close()
            MainScreen.atnevez()
            MainScreen.Activate()
        End If
    End Sub

    Private Sub command2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles command2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GoButton_Click()
    End Sub
End Class
