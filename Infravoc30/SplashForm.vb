Public NotInheritable Class SplashForm

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Dim da$




    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        Try

            ApplicationTitle.Text = My.Application.Info.Title.ToString
            Version.Text = My.Application.Info.Version.ToString
            Copyright.Text = My.Application.Info.Copyright.ToString

            VocabularyHelper.ControlSettings()

            MainForm.Activate()
            MainForm.Focus()
            MainForm.Focus()
            MainForm.Focus()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            End
        End Try

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'FrissítésToolStripMenuItem_Click()
        'List1_Click()



    End Sub

    Private Sub ApplicationTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationTitle.Click

    End Sub

    Private Sub Infrvocabularyelindult_Paint(sender As Object, e As PaintEventArgs) Handles Infrvocabularyelindult.Paint

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
