Public Class FrmArquivos

#Region "Sub/Function"

    Private Sub CarregarPastas()

        TxtServidor.Text = My.Settings.SFTP_Servidor
        TxtPorta.Text = My.Settings.SFTP_Porta
        TxtUsuario.Text = My.Settings.SFTP_Usuario
        TxtSenha.Text = My.Settings.SFTP_Senha
        TxtChaveSSH.Text = My.Settings.SFTP_ChaveSSH
        TxtDirBkpBD.Text = My.Settings.SFTP_BackupDatabase
        TxtDirBkpSistema.Text = My.Settings.SFTP_BackupSistema
        LblDirImagemUser.Text = My.Settings.SFTP_ImagemUsuario

        TxtClientes.Text = My.Settings.SFTP_PhonebookClientes
        TxtColaborador.Text = My.Settings.SFTP_PhonebookColaborador
        TxtFornecedor.Text = My.Settings.SFTP_PhonebookFornecedor
        TxtParceiro.Text = My.Settings.SFTP_PhonebookParceiro

        TxtOSExterna.Text = My.Settings.SFTP_HelpdeskOSExterno
        TxtOSRemoto.Text = My.Settings.SFTP_HelpdeskOSRemoto

        TxtDiretorioEstoque.Text = My.Settings.SFTP_Estoque

        TxtNFe.Text = My.Settings.SFTP_Financeiro_Nfe
        TxtNFSe.Text = My.Settings.SFTP_Financeiro_NFSe

        TxtPhonebook.Text = My.Settings.SFTP_Dashboard_Phonebook
        TxtHelpdesk.Text = My.Settings.SFTP_Dashboard_Helpdesk
        TxtEstoque.Text = My.Settings.SFTP_Dashboard_Estoque
        TxtFinanceiro.Text = My.Settings.SFTP_Dashboard_Financeiro

        LblInfoServidor.Text = $"<b><font color=Black>As pasta de cada módulo estão localizadas em um Servidor SFTP local: <font color=Blue>{TxtServidor.Text}</font></b><br>
                                Em haja necessidade de manipular um arquivo diretamente no local, contate o suporte."

    End Sub

    Private Sub Editar_Servidor()

        My.Settings.SFTP_Servidor = TxtServidor.Text
        My.Settings.SFTP_Porta = TxtPorta.Text
        My.Settings.SFTP_Usuario = TxtUsuario.Text
        My.Settings.SFTP_Senha = TxtSenha.Text
        My.Settings.SFTP_ChaveSSH = TxtChaveSSH.Text
        My.Settings.SFTP_BackupDatabase = TxtDirBkpBD.Text
        My.Settings.SFTP_BackupSistema = TxtDirBkpSistema.Text
        My.Settings.SFTP_ImagemUsuario = LblDirImagemUser.Text
        My.Settings.Save()
        CarregarPastas()

    End Sub

    Private Sub Editar_Phonebook()

        My.Settings.SFTP_PhonebookClientes = TxtClientes.Text
        My.Settings.SFTP_PhonebookColaborador = TxtColaborador.Text
        My.Settings.SFTP_PhonebookFornecedor = TxtFornecedor.Text
        My.Settings.SFTP_PhonebookParceiro = TxtParceiro.Text
        My.Settings.Save()
        CarregarPastas()

    End Sub

    Private Sub Editar_Helpdesk()

        My.Settings.SFTP_HelpdeskOSExterno = TxtOSExterna.Text
        My.Settings.SFTP_HelpdeskOSRemoto = TxtOSRemoto.Text
        My.Settings.Save()
        CarregarPastas()

    End Sub

    Private Sub Editar_Estoque()

        My.Settings.SFTP_Estoque = TxtDiretorioEstoque.Text
        My.Settings.Save()
        CarregarPastas()

    End Sub

    Private Sub Editar_Financeiro()

        My.Settings.SFTP_Financeiro_Nfe = TxtNFe.Text
        My.Settings.SFTP_Financeiro_NFSe = TxtNFSe.Text
        My.Settings.Save()
        CarregarPastas()

    End Sub

    Private Sub Editar_Dashboard()

        My.Settings.SFTP_Dashboard_Phonebook = TxtPhonebook.Text
        My.Settings.SFTP_Dashboard_Helpdesk = TxtHelpdesk.Text
        My.Settings.SFTP_Dashboard_Estoque = TxtEstoque.Text
        My.Settings.SFTP_Dashboard_Financeiro = TxtFinanceiro.Text
        My.Settings.Save()
        CarregarPastas()

    End Sub

#End Region


#Region "GSHome"

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        TabControlServidorSFTP.SelectTab(1)
    End Sub

    Private Sub BtnCencelarGSHome_Click(sender As Object, e As EventArgs) Handles BtnCencelarGSHome.Click
        TabControlServidorSFTP.SelectTab(0)
    End Sub

    Private Sub BtnSalvarGSHome_Click(sender As Object, e As EventArgs) Handles BtnSalvarGSHome.Click
        Editar_Servidor()
        TabControlServidorSFTP.SelectTab(0)
    End Sub

#End Region

#Region "Phonebook"

    Private Sub BtnPhonebook_Click(sender As Object, e As EventArgs) Handles BtnPhonebook.Click
        TabControlServidorSFTP.SelectTab(2)
    End Sub

    Private Sub BtnCancelarPhonebook_Click(sender As Object, e As EventArgs) Handles BtnCancelarPhonebook.Click
        TabControlServidorSFTP.SelectTab(0)
    End Sub

    Private Sub BtnSalvarPhonebook_Click(sender As Object, e As EventArgs) Handles BtnSalvarPhonebook.Click
        Editar_Phonebook()
        TabControlServidorSFTP.SelectTab(0)
    End Sub

#End Region

#Region "Helpdesk"

    Private Sub btnHelpdesk_Click(sender As Object, e As EventArgs) Handles btnHelpdesk.Click
        TabControlServidorSFTP.SelectTab(3)
    End Sub

    Private Sub BtnCancelarHelpdesk_Click(sender As Object, e As EventArgs) Handles BtnCancelarHelpdesk.Click
        TabControlServidorSFTP.SelectTab(0)
    End Sub

    Private Sub BtnSalvarHelpdesk_Click(sender As Object, e As EventArgs) Handles BtnSalvarHelpdesk.Click
        Editar_Estoque()
        TabControlServidorSFTP.SelectTab(0)
    End Sub

#End Region

#Region "Estoque"

    Private Sub btnEstoque_Click(sender As Object, e As EventArgs) Handles btnEstoque.Click
        TabControlServidorSFTP.SelectTab(4)
    End Sub

    Private Sub BtnCancelarEstoque_Click(sender As Object, e As EventArgs) Handles BtnCancelarEstoque.Click
        TabControlServidorSFTP.SelectTab(0)
    End Sub

    Private Sub TxtSalvarEstoque_Click(sender As Object, e As EventArgs) Handles TxtSalvarEstoque.Click
        Editar_Estoque()
        TabControlServidorSFTP.SelectTab(0)
    End Sub

#End Region

#Region "Financeiro"

    Private Sub btnFinanceiro_Click(sender As Object, e As EventArgs) Handles btnFinanceiro.Click
        TabControlServidorSFTP.SelectTab(5)
    End Sub

    Private Sub BtnCancelarFinanceiro_Click(sender As Object, e As EventArgs) Handles BtnCancelarFinanceiro.Click
        TabControlServidorSFTP.SelectTab(0)
    End Sub

    Private Sub BtnSalvarFinanceiro_Click(sender As Object, e As EventArgs) Handles BtnSalvarFinanceiro.Click
        Editar_Financeiro()
        TabControlServidorSFTP.SelectTab(0)
    End Sub

#End Region

#Region "Dashboard"

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        TabControlServidorSFTP.SelectTab(6)
    End Sub

    Private Sub BtnCancelarDashboard_Click(sender As Object, e As EventArgs) Handles BtnCancelarDashboard.Click
        TabControlServidorSFTP.SelectTab(0)
    End Sub

    Private Sub BtnSalvarDashboard_Click(sender As Object, e As EventArgs) Handles BtnSalvarDashboard.Click
        Editar_Dashboard()
        TabControlServidorSFTP.SelectTab(0)
    End Sub

#End Region

    Private Sub FrmArquivos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TabControlServidorSFTP.TabMenuVisible = False
        TabControlServidorSFTP.Visible = True
        CarregarPastas()
    End Sub
End Class