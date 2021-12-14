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

    Private Sub TimerPhonebook_Tick(sender As Object, e As EventArgs) Handles TimerPhonebook.Tick
        TimerPhonebook.Stop()
        FrmPrincipal.FormShow(New FrmCadastros_Phonebook)
    End Sub

    Private Sub TimerHelpdesk_Tick(sender As Object, e As EventArgs) Handles TimerHelpdesk.Tick
        TimerHelpdesk.Stop()
        FrmPrincipal.FormShow(New FrmCadastros_Helpdesk)
    End Sub
End Class