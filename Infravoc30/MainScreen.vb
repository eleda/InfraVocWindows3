Public Class MainScreen

    Private Sub AProgramNévjegyeToolStripMenuItem_Click() Handles AProgramNévjegyeToolStripMenuItem.Click
        AboutDialog.ShowDialog()
    End Sub

    Private Sub ÚjSzóToolStripMenuItem_Click() Handles ÚjSzóToolStripMenuItem.Click
        NewEntry.ShowDialog()
    End Sub

    Private Sub List1_Click() Handles List1.Click
        Form1_Activated()
    End Sub

    Private Sub List1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

        Call atnevToolStripMenuItem_Click()
    End Sub


    Private Sub OToolStripMenuItem_Click()


    End Sub

    Private Sub gomb_atnev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub TörlésToolStripMenuItem_Click() Handles TörlésToolStripMenuItem.Click
        Dim torole
        If List1.SelectedIndex = -1 Then GoTo 7
        torole = MsgBox("Tényleg törli az elemet?", vbQuestion + vbYesNo)
        If torole = vbYes Then
            'on error GoTo 7
            List1.Items.RemoveAt(List1.SelectedIndex)
            'Form1.List1.RemoveItem(Form1.List1.ListIndex)
            ado.Text = 1
        End If

        Exit Sub
7:      MsgBox("Nem jelölt ki elemet.", vbExclamation)




    End Sub

    Private Sub Form1_Activated()

        If List1.SelectedIndex = -1 Then
            'Toolbar2.Buttons.Item(3).Enabled = False
            ' Toolbar2.Buttons.Item(2).Enabled = False
            'StatusBar1.Panels.Item(1).Text = "Kész."
            gomb_atnev.Enabled = False
            gomb_torol.Enabled = False
            'ainfok.text = "Kész."
        Else
            'Toolbar2.Buttons.Item(3).Enabled = True
            'Toolbar2.Buttons.Item(2).Enabled = True

            gomb_atnev.Enabled = True
            gomb_torol.Enabled = True

        End If

    End Sub

    Private Sub Form1_Activated1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        List1_SelectedIndexChanged_1()

    End Sub

    Private Sub Form1_FormClosing() Handles Me.FormClosing

        Dim a
        If ado.Text = 1 Then
            a = MsgBox("Kívánja menteni '" & filenam.Text & "' szószedetet?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If a = vbYes Then
                MentésToolStripMenuItem_Click()
                End
                Exit Sub
            End If
            If a = vbNo Then
                End
            End If
        End If
    End Sub





    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Text = My.Application.Info.Title.ToString

        ' Dim fila$
        'Form1_Activated()


        List1_Click()

        'FileOpen(20, "options.dat", OpenMode.Input)
        'Input(20, fila$)
        'FileClose(20)
        'MsgBox(fila$)
        'End
        beallitas()


        FrissítésToolStripMenuItem_Click()
    End Sub

    Private Sub SzószedetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SzószedetToolStripMenuItem.Click

    End Sub



    Private Sub gomb_ujszo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub ÖsszesTörléseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖsszesTörléseToolStripMenuItem.Click
        Dim torole
        'elda = MsgBox("Tényleg az összes elemet törli?",MsgBoxStyle.YesNo+MsgBoxStyle.Question, "Infra Vocabulary 3.0"
        'If elda=vbYes = then 

        torole = MsgBox("Valóban törli az összes elemet?", vbQuestion + vbYesNo)
        If torole = vbYes Then
            On Error GoTo 7
            List1.Items.Clear()
            ado.Text = 1
        End If
        Exit Sub
7:      MsgBox("Hiba!", vbExclamation)


    End Sub

    Private Sub KeresésToolStripMenuItem_Click() Handles KeresésToolStripMenuItem.Click

        SearchWindow.ShowDialog()
        SearchWindow.SearchTitleLabel.Focus()

    End Sub

    Private Sub MentésToolStripMenuItem_Click() Handles MentésToolStripMenuItem.Click
        FileClose(1)
        FileOpen(1, filenam.Text, OpenMode.Output)
        For e = 0 To List1.Items.Count - 1
            PrintLine(1, List1.Items(e))
        Next e
        FileClose(1)
        ado.Text = 0
        FrissítésToolStripMenuItem_Click()

    End Sub

    Public Sub New()


        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub OKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKToolStripMenuItem.Click
        NotifyIcon1.Visible() = False
    End Sub

    Private Sub KisméretToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KisméretToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal Else Me.WindowState = FormWindowState.Minimized
    End Sub
    Sub megnyitas()
        FrissítésToolStripMenuItem_Click()
    End Sub

    Private Sub FrissítésToolStripMenuItem_Click() Handles FrissítésToolStripMenuItem.Click

        '       On Error GoTo 5
        '4:
        '       Form1.List1.Clear()
        'Open "words.txt" For Input As #1
        '       Do Until EOF(1)
        'Input #1, elem$
        '          Form1.List1.AddItem(elem$)
        '       Loop
        'Close #1
        '       Exit Sub
        '5:
        'Open "words.txt" For Output As #1
        'Close #1
        '       GoTo 4
        '        Form1.ado.Text = 0


        Dim elem$
        On Error GoTo 5
4:
        ' MsgBox(filenam.Text)
        List1.Items.Clear()
        FileOpen(1, filenam.Text, OpenMode.Input)
        Do Until EOF(1)
            Input(1, elem$)
            'MsgBox(elem$)
            List1.Items.Add(elem$)
        Loop
        FileClose(1)
        Exit Sub
5:
        NotifyIcon1.ShowBalloonTip(73000, "Infra vocabulary", "Először használja az Infra Vocabulary programot", ToolTipIcon.Info)
        FileClose()
        FileOpen(1, filenam.Text, OpenMode.Output)
        FileClose(1)
        GoTo 4
        ado.Text = 0
    End Sub



    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub filenam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        eszkoz_filemam0.Text = filenam.Text
    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)


    End Sub

    'Private Sub MentésToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MentésToolStripMenuItem.Click

    'End Sub

    Private Sub gomb_torol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub AlapbeállításokToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlapbeállításokToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub


    Sub beallitas()

        Dim StarUpFile As String, isToolBarOn, isStatusBarOn As Boolean
        Dim oneFile As String

        StarUpFile = ""
        isToolBarOn = isStatusBarOn = True
        oneFile = ""

        Try

            FileOpen(10, VocabularyHelper.GetOptionsFilename(), OpenMode.Input)

            Input(10, StarUpFile)
            Input(10, isToolBarOn)
            Input(10, isStatusBarOn)

            filenam.Text = StarUpFile '<<< 1. BEINDÍTÁSKORI FÁJL
            Settings.TextBox1.Text = StarUpFile

            If isToolBarOn Then ToolStrip1.Visible = True Else ToolStrip1.Visible = False ' <<< LÁTSZIK-E AZ ESZKÖZTÁR?
            If isToolBarOn Then Settings.CheckBox1.Checked = True Else ToolStrip1.Visible = False

            If isStatusBarOn = True Then StatusStrip1.Visible = True Else StatusStrip1.Visible = False '<<< LÁTSZIK-E AZ ÁLLAPOTSOR?
            If isStatusBarOn = True Then Settings.CheckBox2.Checked = True Else Settings.CheckBox2.Checked = False

        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
            MsgBox("A beállításokat nem lehetett betölteni, mert OPTIONS.DAT nem található vagy sérült.", MsgBoxStyle.Critical)
            End

        Finally
            FileClose(10)
        End Try


        Try
            FileOpen(10, "voclist.dat", OpenMode.Input)
            Do Until EOF(10)
                Input(10, oneFile)
                Settings.ListBox1.Items.Clear()
                ChooseVocab.ListBox1.Items.Clear()
                ChooseVocab.ListBox1.Items.Add(oneFile)
                Settings.ListBox1.Items.Add(oneFile)
            Loop

        Catch ex As Exception
            MsgBox("VOCLIST.DAT nem található vagy megsérült.", MsgBoxStyle.Critical)
            End
        Finally

            FileClose(10)
        End Try


    End Sub

    Private Sub SzótárKiválasztásaToolStripMenuItem_Click() Handles SzótárKiválasztásaToolStripMenuItem.Click
        MentésToolStripMenuItem_Click()
        FrissítésToolStripMenuItem_Click()
        'MentésToolStripMenuItem_Click()

        ChooseVocab.ShowDialog()
    End Sub

    Private Sub MódosításToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MódosításToolStripMenuItem.Click
        atnevToolStripMenuItem_Click()
    End Sub

    Private Sub ÚjElemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÚjElemToolStripMenuItem.Click
        ÚjSzóToolStripMenuItem_Click()

    End Sub

    Private Sub TörlésToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TörlésToolStripMenuItem1.Click
        TörlésToolStripMenuItem_Click()

    End Sub

    Private Sub KeresésToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeresésToolStripMenuItem1.Click
        KeresésToolStripMenuItem_Click()


    End Sub

    Private Sub List1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles List1.Click

    End Sub
    Sub atnevez()
        atnevToolStripMenuItem_Click()
    End Sub



    Private Sub atnevToolStripMenuItem_Click() Handles atnevToolStripMenuItem.Click
        On Error GoTo 20
        If List1.SelectedItems.Count > 0 Then
            Rewrite.szo.Text = List1.SelectedItem.ToString
            Rewrite.ShowDialog()
            Exit Sub
        End If
20:     'MsgBox("Nincsen kijelölt elem.", MsgBoxStyle.Exclamation, "Infra Vocabulary")
        Exit Sub
    End Sub



    Private Sub gomb_atnev_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gomb_atnev.Click
        Call atnevToolStripMenuItem_Click()

    End Sub

    Private Sub gomb_ujszo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gomb_ujszo.Click
        ÚjSzóToolStripMenuItem_Click()
    End Sub

    Private Sub gomb_torol_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gomb_torol.Click
        TörlésToolStripMenuItem_Click()
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        KeresésToolStripMenuItem_Click()

    End Sub

    Private Sub gomb_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gomb_info.Click
        AProgramNévjegyeToolStripMenuItem_Click()

    End Sub

    Private Sub List1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles List1.DoubleClick
        atnevToolStripMenuItem_Click()
    End Sub

    Private Sub List1_SelectedIndexChanged_1() Handles List1.SelectedIndexChanged

        Form1_Activated()
        '        StatusBar1.Panels.Item(1).Text = List1.Text
        '       StatusBar1.Panels.Item(3).Text = List1.ListIndex + 1 & "/" & List1.ListCount
        '      StatusBar1.Panels.Item(4).Text = "Szó hossza: " & Len(List1.Text)
        On Error GoTo 5
        ' Ainfok.Text = List1.SelectedItem.ToString
        If List1.SelectedItems.Count > 0 Then
            a_infok.Text = List1.Items(List1.SelectedIndex)
            Akijelzo.Text = List1.SelectedIndex + "1" & "/" & List1.Items.Count
            Atithossza.Text = "Hossz: " & Len(List1.Items(List1.SelectedIndex))
        End If

5:
    End Sub

    Private Sub filenam_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filenam.TextChanged
        If ado.Text = 1 Then
            eszkoz_filemam0.Text = filenam.Text + "*"
        Else
            eszkoz_filemam0.Text = filenam.Text
        End If
        'eszkoz_filemam0.Text = filenam.Text
    End Sub

    Private Sub ÚjSzótárToolStripMenuItem_Click() Handles ÚjSzótárToolStripMenuItem.Click
        MentésToolStripMenuItem_Click()
        FrissítésToolStripMenuItem_Click()
        NewVocab.ShowDialog()

    End Sub


    Sub szolistament_dialog3bol()
        FileOpen(10, "voclist.dat", OpenMode.Output)
        For e = 0 To ChooseVocab.ListBox1.Items.Count - 1
            PrintLine(10, ChooseVocab.ListBox1.Items(e))
        Next
        FileClose(10)

    End Sub

    Private Sub ado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ado.TextChanged
        If ado.Text = 1 Then eszkoz_filemam0.Text = filenam.Text + "*"
        If ado.Text = 0 Then eszkoz_filemam0.Text = filenam.Text

    End Sub

    Private Sub MentésToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MentésToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        SzótárKiválasztásaToolStripMenuItem_Click()
    End Sub

    Private Sub KilépésToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub e_mentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e_mentes.Click
        MentésToolStripMenuItem_Click()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        ÚjSzótárToolStripMenuItem_Click()

    End Sub

    Private Sub ExitToolItem_Click(sender As Object, e As EventArgs) Handles ExitToolItem.Click
        Form1_FormClosing()
        End
    End Sub

End Class
