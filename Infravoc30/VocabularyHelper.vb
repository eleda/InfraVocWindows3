Module VocabularyHelper

    Dim optionsFile As String = "options.dat"
    Dim voclistFile As String = "voclist.dat"
    Dim defaultVocFile As String = "default.voc"

    Public Function GetOptionsFilename()
        Return optionsFile
    End Function

    Public Function GetVocListFilename()
        Return optionsFile
    End Function

    Public Sub ControlSettings()
        If (Not My.Computer.FileSystem.FileExists(optionsFile)) Then
            Try
                FileOpen(20, optionsFile, OpenMode.Output)
                WriteLine(20, defaultVocFile)
                WriteLine(20, True)
                WriteLine(20, True)
                FileClose(20)
            Catch ex As Exception
                Throw New Exception(voclistFile + " fájlt nem lehetett létrehozni.")
            End Try
        End If
        If (Not My.Computer.FileSystem.FileExists(voclistFile)) Then
            Try
                FileOpen(20, voclistFile, OpenMode.Output)
                WriteLine(20, defaultVocFile)
                FileClose(20)
            Catch ex As Exception
                Throw New Exception(voclistFile + " fájlt nem lehetett létrehozni.")
            End Try
        End If
    End Sub
End Module
