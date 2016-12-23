Module VocabularyHelper

    Dim voclistFile As String = "voclist.dat"
    Dim defaultVocFile As String = "default.voc"

    Public Sub ControlSettings()
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

    Public Function isBrokenWord(word As String)
        If Not word.Contains("=") Then
            Return True
        End If
        Return False
    End Function

End Module
