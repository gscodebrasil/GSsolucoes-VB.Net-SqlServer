Public Class FrmCarregar

    Private Sub TimerFrmUsers_Tick(sender As Object, e As EventArgs) Handles TimerFrmUsers.Tick
        TimerFrmUsers.Stop()
        FrmPrincipal.FormShow(New FrmUsers)
    End Sub

    Private Sub TimerArquivos_Tick(sender As Object, e As EventArgs) Handles TimerArquivos.Tick
        TimerArquivos.Stop()
        FrmPrincipal.FormShow(New FrmArquivos)
    End Sub

    Private Sub TimerBackup_Tick(sender As Object, e As EventArgs) Handles TimerBackup.Tick
        TimerBackup.Stop()
        FrmPrincipal.FormShow(New FrmBackup)
    End Sub

    Private Sub TimerCadastros_Phonebook_Tick(sender As Object, e As EventArgs) Handles TimerCadastros_Phonebook.Tick
        TimerCadastros_Phonebook.Stop()
        FrmPrincipal.FormShow(New FrmCadastros_Phonebook)
    End Sub
End Class