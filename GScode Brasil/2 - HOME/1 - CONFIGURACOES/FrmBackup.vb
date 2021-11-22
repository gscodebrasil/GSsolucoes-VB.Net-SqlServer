Public Class FrmBackup

#Region "Ref. de Classe"

    Private ReadOnly ClBackup As New Backup
    Private ReadOnly ClServerSFTP As New ServerSFTP

#End Region

#Region "Sub/Function"

    Public Sub ContarLinha_Dgv()
        Select Case DgvBackup.Rows.Count

            Case 0
                DgvBackup.ColumnHeadersVisible = False
                LblPaginacao.Visible = False

            Case 1
                LblPaginacao.Visible = True
                LblPaginacao.Text = $"{DgvBackup.Rows.Count} Registro"

            Case Else
                LblPaginacao.Visible = True
                LblPaginacao.Text = $"{DgvBackup.Rows.Count} Registros"

        End Select
    End Sub

    Private Sub SelecionarLinha_Dgv(e As DataGridViewCellEventArgs)
        Dim count As Integer

        If DgvBackup.Rows.Count() > 0 Then
            If DgvBackup.Columns(e.ColumnIndex).Index = 0 Then
                For i As Integer = 0 To DgvBackup.Rows.Count() - 1
                    If DgvBackup.Rows(i).Cells(0).Value Then
                        count += 1
                    End If
                Next

                Select Case count
                    Case 0
                        LblSelectRegister.Visible = False
                        PanelSelect.Visible = False

                    Case 1
                        LblSelectRegister.Text = $"{count} Registro selecionado"
                        LblSelectRegister.Visible = True

                        LblSelect.Text = $"Arquivos selecionados ({count})"
                        PanelSelect.BringToFront()
                        SelectTransition.ShowSync(PanelSelect)
                        BtnRestoreBkp.Enabled = True

                    Case Else
                        LblSelectRegister.Text = $"{count} Registros selecionados"
                        LblSelectRegister.Visible = True

                        LblSelect.Text = $"Arquivos selecionados ({count})"
                        PanelSelect.BringToFront()
                        SelectTransition.ShowSync(PanelSelect)
                        BtnRestoreBkp.Enabled = False

                End Select
            End If
        End If
    End Sub

#End Region

#Region "Inicial"

    Private Sub BtnSystemBkp_Click(sender As Object, e As EventArgs) Handles BtnSystemBkp.Click
        LblAguarde.Text = $"<b>Aguarde um momento, estamos processando sua solicitação...</b>"
        ProgressAguarde.Value = 0
        TabControlBackup.SelectTab(3)
        TimerSystemBkp.Start()
    End Sub

    Private Sub BtnSystemRestore_Click(sender As Object, e As EventArgs) Handles BtnSystemRestore.Click
        LblAguarde.Text = $"<b>Aguarde um momento, estamos processando sua solicitação...</b><br>
                            <font color=DimGray>Após a finalização o sistema será reiniciado para aplicar as configurações.</font>"
        ProgressAguarde.Value = 0
        TabControlBackup.SelectTab(3)
        TimerSystemRestore.Start()
    End Sub

    Private Sub BtnDatabaseBkp_Click(sender As Object, e As EventArgs) Handles BtnDatabaseBkp.Click
        LblAguarde.Text = $"<b>Aguarde um momento, estamos processando sua solicitação...</b>"
        ProgressAguarde.Value = 0
        TabControlBackup.SelectTab(3)
        TimerDatabaseBkp.Start()
    End Sub

    Private Sub BtnListarBkp_Click(sender As Object, e As EventArgs) Handles BtnListarBkp.Click
        TabControlBackup.SelectTab(1)
        ClServerSFTP.FileList(DgvBackup)
        ContarLinha_Dgv()
    End Sub

    Private Sub BtnDatabaseConfig_Click(sender As Object, e As EventArgs) Handles BtnDatabaseConfig.Click
        LblBDAviso.Text = $"<b><font color='maroon'>Caminho padrão do banco de dados local</font></b><br>
                            <b>Servidor:</b> 192.168.2.225 - <b>Porta:</b> 1433<br>
                            <b>Banco:</b> gscode<br>
                            <b>Usuário:</b> sa - <b>Senha:</b> ysQLa5ihU1gRA4cRtUuyCnOJZXm5UFE5LRn7UhkkTbI="
        TxtServidor.Text = My.Settings.Database_Servidor
        TxtPorta.Text = My.Settings.Database_Porta
        TxtBanco.Text = My.Settings.Database_Banco
        TxtUsuario.Text = My.Settings.Database_Usuario
        TxtSenha.Text = My.Settings.Database_Senha

        TabControlBackup.SelectTab(2)
    End Sub

    Private Sub TimerSystemBkp_Tick(sender As Object, e As EventArgs) Handles TimerSystemBkp.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 30
                ClServerSFTP.FazerBackup_Sistema(FrmPrincipal.LblEmailLeft.Text, TabControlBackup, TimerDatabaseBkp)

            Case 100
                TimerSystemBkp.Stop()
                TabControlBackup.SelectTab(0)

        End Select
    End Sub

    Private Sub TimerSystemRestore_Tick(sender As Object, e As EventArgs) Handles TimerSystemRestore.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 30
                ClServerSFTP.RestaurarBackup_Sistema(TabControlBackup, TimerSystemRestore)

            Case 100
                Application.Restart()

        End Select
    End Sub

    Private Sub TimerDatabaseBkp_Tick(sender As Object, e As EventArgs) Handles TimerDatabaseBkp.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 30
                ClBackup.Arquivo = $"BkpFull_{FrmPrincipal.LblEmailLeft.Text}.bak"
                ClBackup.FazerBackup_BancoDados(sender)

            Case 100
                TimerDatabaseBkp.Stop()
                TabControlBackup.SelectTab(0)

        End Select
    End Sub

#End Region

#Region "Lista"

    Private Sub BtnUploadBkp_Click(sender As Object, e As EventArgs) Handles BtnUploadBkp.Click
        ClServerSFTP.CarregarBackup(DgvBackup, Ofd, TabControlBackup)
        ContarLinha_Dgv()
    End Sub

    Private Sub BtnVoltarMenu_Click(sender As Object, e As EventArgs) Handles BtnVoltarMenu.Click
        DgvBackup.Rows.Clear()
        TabControlBackup.SelectTab(0)
    End Sub

    Private Sub DgvBackup_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DgvBackup.CurrentCellDirtyStateChanged
        If DgvBackup.IsCurrentCellDirty Then
            DgvBackup.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub DgvBackup_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBackup.CellValueChanged
        SelecionarLinha_Dgv(e)
    End Sub

    Private Sub BtnDownloadBkp_Click(sender As Object, e As EventArgs) Handles BtnDownloadBkp.Click
        PanelSelect.Visible = False
        ClServerSFTP.FileDownload(DgvBackup, Fbd, LblAguarde.Text, ProgressAguarde, TabControlBackup, TimerDatabaseDownload)
    End Sub

    Private Sub BtnRestoreBkp_Click(sender As Object, e As EventArgs) Handles BtnRestoreBkp.Click
        LblAguarde.Text = $"<b>Aguarde um momento, estamos processando sua solicitação...</b><br>
                            <font color=DimGray>Após a finalização o sistema será reiniciado para aplicar as configurações.</font>"
        ProgressAguarde.Value = 0
        TabControlBackup.SelectTab(3)
        TimerDatabaseRestore.Start()
    End Sub

    Private Sub BtnSelectApagar_Click(sender As Object, e As EventArgs) Handles BtnSelectApagar.Click
        ClServerSFTP.FileDelete(DgvBackup, PanelSelect)
        ContarLinha_Dgv()
    End Sub

    Private Sub BtnSelectFechar_Click(sender As Object, e As EventArgs) Handles BtnSelectFechar.Click
        PanelSelect.Visible = False
    End Sub

    Private Sub PanelPaginacao_Resize(sender As Object, e As EventArgs) Handles PanelPaginacao.Resize
        Dim x = (PanelPaginacao.Size.Width - LblPaginacao.Width) / 2
        Dim y = (PanelPaginacao.Size.Height - LblPaginacao.Height) / 2

        LblPaginacao.Location = New Point(x, y)
    End Sub

    Private Sub TimerDatabaseDownload_Tick(sender As Object, e As EventArgs) Handles TimerDatabaseDownload.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 100
                PanelSelect.Visible = False
                TimerDatabaseDownload.Stop()
                TabControlBackup.SelectTab(1)
                LblSelectRegister.Visible = False
                DgvBackup.Rows.Clear()
                ClServerSFTP.FileList(DgvBackup)

        End Select
    End Sub

    Private Sub TimerDatabaseRestore_Tick(sender As Object, e As EventArgs) Handles TimerDatabaseRestore.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 30
                For Each row As DataGridViewRow In DgvBackup.Rows()
                    If row.Cells(0).Value Then
                        ClBackup.Arquivo = row.Cells(1).Value
                        ClBackup.FazerBackup_BancoDados(sender)
                    End If
                Next

            Case 100
                Application.Restart()

        End Select
    End Sub

#End Region

#Region "Configuracoes Banco de Dados"

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        ClServerSFTP.Connect()
    End Sub

    Private Sub BtnDefault_Click(sender As Object, e As EventArgs) Handles BtnDefault.Click
        LblAguarde.Text = $"<b>Aguarde um momento, estamos processando sua solicitação...</b><br>
                            <font color=DimGray>Após a finalização o sistema será reiniciado para aplicar as configurações.</font>"
        ProgressAguarde.Value = 0
        TabControlBackup.SelectTab(3)
        TimerSystemRestore.Start()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TabControlBackup.SelectTab(0)
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        LblAguarde.Text = $"<b>Aguarde um momento, estamos processando sua solicitação...</b><br>
                            <font color=DimGray>Após a finalização o sistema será reiniciado para aplicar as configurações.</font>"
        ProgressAguarde.Value = 0
        TabControlBackup.SelectTab(3)
        TimerDatabaseConfig.Start()

    End Sub

    Private Sub TxtServidor_TextChanged(sender As Object, e As EventArgs) Handles TxtServidor.TextChanged
        Select Case TxtServidor.Text.Length

            Case > 0
                LblServidor.Visible = True

            Case <= 0
                LblServidor.Visible = False

        End Select
    End Sub

    Private Sub TxtPorta_TextChanged(sender As Object, e As EventArgs) Handles TxtPorta.TextChanged
        Select Case TxtPorta.Text.Length

            Case > 0
                LblPorta.Visible = True

            Case <= 0
                LblPorta.Visible = False

        End Select
    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged
        Select Case TxtUsuario.Text.Length

            Case > 0
                LblUsuario.Visible = True

            Case <= 0
                LblUsuario.Visible = False

        End Select
    End Sub

    Private Sub TxtSenha_TextChanged(sender As Object, e As EventArgs) Handles TxtSenha.TextChanged
        Select Case TxtSenha.Text.Length

            Case > 0
                LblSenha.Visible = True

            Case <= 0
                LblSenha.Visible = False

        End Select
    End Sub

    Private Sub TxtBanco_TextChanged(sender As Object, e As EventArgs) Handles TxtBanco.TextChanged
        Select Case TxtBanco.Text.Length

            Case > 0
                LblBanco.Visible = True

            Case <= 0
                LblBanco.Visible = False

        End Select
    End Sub

    Private Sub TimerDatabaseConfig_Tick(sender As Object, e As EventArgs) Handles TimerDatabaseConfig.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 30
                TxtServidor.Text = My.Settings.Database_Servidor
                TxtPorta.Text = My.Settings.Database_Porta
                TxtBanco.Text = My.Settings.Database_Banco
                TxtUsuario.Text = My.Settings.Database_Usuario
                TxtSenha.Text = My.Settings.Database_Senha
                My.Settings.Save()

            Case 100
                TimerDatabaseConfig.Stop()
                Application.Restart()

        End Select
    End Sub

    Private Sub TimerDatabaseDefault_Tick(sender As Object, e As EventArgs) Handles TimerDatabaseDefault.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 30
                My.Settings.Reset()

            Case 100
                Application.Restart()

        End Select
    End Sub

#End Region

    Private Sub FrmBackup_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TabControlBackup.TabMenuVisible = False
        TabControlBackup.Visible = True
    End Sub

End Class