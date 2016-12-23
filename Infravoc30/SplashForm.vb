Public NotInheritable Class SplashForm

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Dim da$




    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'ApplicationTitle.Text = My.Application.Info.Title.ToString
            Version.Text = My.Application.Info.Version.ToString
            'Copyright.Text = My.Application.Info.Copyright.ToString

            VocabularyHelper.ControlSettings()


            MainForm.Activate()
            MainForm.Focus()


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            End
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork

    End Sub


End Class
