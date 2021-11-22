Imports System.Console
Imports System.Text.RegularExpressions
Imports System.Threading
Imports Guna.UI2.WinForms

Public Class FrmUserConfig


    Private NewThead As Thread

    Private Sub bpInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bpInfo.SelectedIndexChanged

    End Sub

    Private ReadOnly clValidaData As New ValidaData
    Private ReadOnly clValidaCep As New ValidaCep
    Private ReadOnly clUser As New UserInfo
    Private ReadOnly clCifer As New Cifer
    Private ReadOnly clEmail As New Email
    Private ReadOnly clRGB As New RGBColors

    Private StrWhats As String
    Private StrEmail As String
    Private StrTermo As String
    Private StrColorWhats As String
    Private StrColorEmail As String
    Private chkWhats As Integer
    Private chkEmail As Integer
    Private chkTermos As Integer
    Private redefinir As Integer

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        bpInfo.SetPage(1)
    End Sub

    Private Sub Editar()
        If chkPerfilWhats.Checked = True Then
            chkWhats = 1
        Else
            chkWhats = 0
        End If
        If chkPerfilEmail.Checked = True Then
            chkEmail = 1
        Else
            chkEmail = 0
        End If
        If chkPerfilTermos.Checked = True Then
            chkTermos = 1
        Else
            chkTermos = 0
        End If

        clUser.email = FrmPrincipal.LblEmailLeft.Text
        clUser.name = txtNome.Text
        clUser.nascimento = txtNascimento.Text
        clUser.genero = cbGenero.Text
        clUser.cell = txtCell.Text
        clUser.cep = txtCep.Text
        clUser.endereco = txtEndereco.Text
        clUser.comp = txtComplemento.Text
        clUser.cidade = txtCidade.Text
        clUser.uf = txtUF.Text
        'clUser.notwhats = chkWhats
        'clUser.notemail = chkEmail
        'clUser.acepttermos = chkTermos
        'clUser.empresa = txtEmpresa.Text
        'clUser.depart = txtDepart.Text
        'clUser.funcao = txtFuncao.Text
        'clUser.tellempresa = txtTel.Text
        'clUser.ramal = txtRamal.Text
        'clUser.permconfig = 1
        'clUser.permphonebook = 0
        'clUser.permhelpdesk = 0
        'clUser.permestoque = 0
        'clUser.permfinanceiro = 0
        'clUser.permdashboard = 0
        clUser.Edita()
    End Sub



    Public Sub limparCampos()
        chkWhats = Nothing
        chkEmail = Nothing
        chkTermos = Nothing
        StrColorWhats = Nothing
        StrColorEmail = Nothing
        StrWhats = Nothing
        StrEmail = Nothing
        StrTermo = Nothing

        lblChaveKey.Text = Nothing
        lblUserInfo.Text = Nothing
        txtNome.Clear()
        txtNascimento.Clear()
        cbGenero.SelectedIndex = -1
        txtCell.Clear()
        txtCep.Clear()
        txtEndereco.Clear()
        txtComplemento.Clear()
        txtCidade.Clear()
        txtUF.Clear()
        chkPerfilWhats.Checked = False
        chkPerfilEmail.Checked = False
        chkPerfilTermos.Checked = False
    End Sub

    Private Sub limparClUser()
        clUser.StrPass = Nothing
        clUser.StrEmail = Nothing
        clUser.StrNome = Nothing
        clUser.StrFoto = Nothing
        clUser.StrNascimento = Nothing
        clUser.StrGenero = Nothing
        clUser.StrCell = Nothing
        clUser.StrCep = Nothing
        clUser.StrEndereco = Nothing
        clUser.StrComp = Nothing
        clUser.StrCidade = Nothing
        clUser.StrUF = Nothing
        clUser.StrEmpresa = Nothing
        clUser.StrDepart = Nothing
        clUser.StrFuncao = Nothing
        clUser.StrTell = Nothing
        clUser.StrRamal = Nothing
        clUser.ChkNotwhats = Nothing
        clUser.ChkNotemail = Nothing
        clUser.ChkAcepttermos = Nothing
        clUser.TokenKey = Nothing
        clUser.valida = Nothing
    End Sub

    Private Sub limparClEmail()
        clEmail.toEmail = Nothing
    End Sub

    Public Sub BuscarInfo()

        clUser.email = FrmPrincipal.LblEmailLeft.Text
        clUser.Busca()

        If clUser.not_whats = True Then
            StrWhats = "Ativado"
            StrColorWhats = "Green"
            'chkPerfilWhats.Checked = True
            pbWhats.Visible = False
        Else
            StrWhats = "Desativado"
            StrColorWhats = "Red"
            'chkPerfilWhats.Checked = False
            pbWhats.Visible = True
        End If
        If clUser.not_email = True Then
            StrEmail = "Ativado"
            StrColorEmail = "Green"
            'chkPerfilEmail.Checked = True
            pbEmail.Visible = False
        Else
            StrEmail = "Desativado"
            StrColorEmail = "Red"
            'chkPerfilEmail.Checked = False
            pbEmail.Visible = True
        End If
        If clUser.acept_termos = True Then
            'chkPerfilTermos.Checked = True
            pbTermos.Visible = False
        Else
            'chkPerfilTermos.Checked = False
            pbTermos.Visible = True
        End If

        lblChaveKey.Text = clUser.token

        lblUserInfo.Text = $"<b>Informações  Pessoais</b><br><br>
                            {clUser.id_interno}<br>
                            <b>Nome:</b> {clUser.name}<br>
                            <b>E-mail:</b> {clUser.email}<br>
                            <b>Data de Nascimento:</b> {clUser.nascimento}<br>
                            <b>Gênero:</b> {clUser.genero}<br>
                            <b>Celular:</b> {clUser.cell}<br>
                            <b>Endereço:</b> {clUser.endereco} {clUser.comp}, {clUser.cidade}, {clUser.uf}, {clUser.cep}<br>
                            <b>Notificações via Whatsapp:</b><font color='{StrColorWhats}'> {StrWhats}</font>
                            <b>Email:</b><font color='{StrColorEmail}'> {StrEmail}</font><br><br><br>
                            <b>Informações Profissionais</b><br>
                            <b>Empresa:</b> {clUser.empresa}<br>
                            <b>Departamento:</b> {clUser.depart}<br>
                            <b>Função:</b> {clUser.funcao}<br>
                            <b>Telefone:</b> {clUser.tell_empresa}<br>
                            <b>Ramal:</b> {clUser.ramal}"

    End Sub

    Private Function ValidaEmail(ByVal strCheck As String) As Boolean
        Return Regex.IsMatch(strCheck, "^([0-9a-z]([-\.\w]*[0-9a-z])*@([0-9a-z][-\w]*[0-9a-z]\.)+[a-z]{2,9})$")
    End Function

    Private Sub FrmUserConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarInfo()
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs)
        Clipboard.SetDataObject(lblChaveKey.Text, True)
    End Sub

    Private Sub chkPerfilWhats_CheckedChanged(sender As Object, e As EventArgs)
        If chkPerfilWhats.Checked = False Then
            pbWhats.Visible = True
        Else
            pbWhats.Visible = False
        End If
    End Sub

    Private Sub chkPerfilEmail_CheckedChanged(sender As Object, e As EventArgs)
        If chkPerfilEmail.Checked = False Then
            pbEmail.Visible = True
        Else
            pbEmail.Visible = False
        End If
    End Sub

    Private Sub chkPerfilTermos_CheckedChanged(sender As Object, e As EventArgs)
        If chkPerfilTermos.Checked = False Then
            pbTermos.Visible = True
        Else
            pbTermos.Visible = False
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Editar()
        If clUser.valida = True Then
            limparCampos()
            limparClUser()
            Me.Close()
            MessageBox.Show("Cadastro alterado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        FrmPrincipal.TabControlMenu.Visible = False
        FrmPrincipal.BtnPanelDeslizanteTop.Visible = False
        ProgressAguarde.Value = 0
        LblLoading.Text = $"<b>Estamos processando sua solicitação...</b><br><br>
                            <font color='DimGray'>Após a finalização, o sistema será reiniciado, para ter acesso novamente será necessário efetuar um novo cadastro.</font>"

        bpInfo.SetPage(4)
        TimerExcluir.Start()
    End Sub

    Private Sub BtnEditEmail_Click(sender As Object, e As EventArgs) Handles BtnEditEmail.Click
        RdfEmail()
        bpInfo.SetPage(2)
        TxtNewEmail.Focus()
    End Sub

    Private Sub btnEditSenha_Click(sender As Object, e As EventArgs)
        bpInfo.SetPage(3)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        limparCampos()
        limparClUser()
        Me.Close()
    End Sub

    Private Sub btnRdfCancel_Click(sender As Object, e As EventArgs)
        limparCampos()
        limparClUser()
        limparClEmail()
        Me.Close()
    End Sub

    Private Sub btnRdfSenhaCancel_Click(sender As Object, e As EventArgs) Handles BtnSenhaCancel.Click

    End Sub

    Private Sub FrmUserConfig_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        limparCampos()
        limparClUser()
    End Sub

    Private Sub LimpaRdfEmail()
        TxtNewEmail.Clear()
        TxtSenha.Clear()
    End Sub

    Private Sub RdfEmail()
        LimpaRdfEmail()
        BtnEmailEnviar.Text = "ENVIAR"
        LblNewEmail.Text = "E-mail"
        LblEmailInf.Text = "Por favor insira o novo e-mail no campo correspondente.<br>
            Para alterar seu e-mail é necessário uma validação.<br>
            Vamos enviar um código no e-mail informado.<br>
            Ao finalizar a substituição vamos enviar seu token no endereço de e-mail novo."
        TxtNewEmail.PlaceholderText = "Digite o novo E-mail..."
        TxtSenha.Visible = True
        redefinir = 0
    End Sub

    Private Sub RdfValidar()
        LimpaRdfEmail()
        BtnEmailEnviar.Text = "VALIDAR"
        LblNewEmail.Text = "Código"
        LblEmailInf.Text = "Enviamos o código no endereço de e-mail informado.
            Para prosseguir com a substituição é necessário validar seu novo email. Insira o código no campo correspondente."
        TxtNewEmail.PlaceholderText = "Informe o código..."
        TxtSenha.Visible = False
        redefinir = 1
    End Sub

    Private Sub BuscarSenha()
        clUser.email = clUser.email
        clUser.BuscarSenha()
    End Sub

    'Private Sub AlterarSenha()
    '    clUser.email = FrmGSSolucoesHome.lblEmailPfLeft.Text
    '    clUser.pass = clCifer.Criptar(TxtNewSenha.Text, clCifer.senha)
    '    clUser.passretry = clCifer.Criptar(TxtRetrySenha.Text, clCifer.senha)
    '    clUser.UpdateSenha()
    'End Sub

    'Private Sub btnRdfSenha_Click(sender As Object, e As EventArgs) Handles btnRdfSenha.Click
    '    BuscarSenha()
    '    If clUser.valida = True Then
    '        If clUser.StrPass = clCifer.Criptar(TxtOldSenha.Text, clCifer.senha) Then
    '            clUser.valida = False
    '            AlterarSenha()
    '            MessageBox.Show($"Senha alterada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else
    '            lblSenha2.Visible = True
    '        End If
    '    End If
    'End Sub

    Private Sub txtRdfEmail_TextChanged(sender As Object, e As EventArgs)
        If redefinir = 0 Then
            If TxtNewEmail.Text.Length > 0 And ValidaEmail(TxtNewEmail.Text) = False Then
                TxtNewEmail.IconRight = imgRdf.Images(0)
                LblNewEmail.Visible = True
            ElseIf TxtNewEmail.Text.Length > 0 And ValidaEmail(TxtNewEmail.Text) = True Then
                TxtNewEmail.IconRight = Nothing
                TxtNewEmail.Visible = True
            ElseIf TxtNewEmail.Text.Length <= 0 Then
                TxtNewEmail.IconRight = Nothing
                LblNewEmail.Visible = False
            End If
        Else
            If TxtNewEmail.Text.Length > 0 Then
                LblNewEmail.Visible = True
            Else
                LblNewEmail.Visible = False
            End If
        End If
    End Sub

    Private Sub txtSenha_TextChanged(sender As Object, e As EventArgs)
        If TxtSenha.Text.Length > 0 Then
            LblSenha.Visible = True
        Else
            LblSenha.Visible = False
        End If
    End Sub

    Private Sub txtSenha_GotFocus(sender As Object, e As EventArgs)
        If CapsLock Then
            LblEmailCapsLook.Visible = True
        End If
    End Sub

    Private Sub txtSenha_LostFocus(sender As Object, e As EventArgs)
        LblEmailCapsLook.Visible = False
    End Sub

    Private Sub txtSenha_KeyDown(sender As Object, e As KeyEventArgs)
        If CapsLock Then
            LblEmailCapsLook.Visible = True
        Else
            LblEmailCapsLook.Visible = False
        End If
    End Sub

    Private Sub txtSenha_KeyPress(sender As Object, e As KeyPressEventArgs)
        If TxtSenha.Text.Length > 0 Then
            If e.KeyChar = Convert.ToChar(13) Then
                BtnEmailEnviar.PerformClick()
            End If
        End If
    End Sub

    Private Sub txtSenha_IconRightClick(sender As Object, e As EventArgs)
        If TxtSenha.UseSystemPasswordChar = True Then
            TxtSenha.UseSystemPasswordChar = False
            TxtSenha.IconRight = imgRdf.Images(2)
        Else
            TxtSenha.UseSystemPasswordChar = True
            TxtSenha.IconRight = imgRdf.Images(3)
        End If
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub btnCopy_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCopy_Click_2(sender As Object, e As EventArgs) Handles BtnCopy.Click

    End Sub

    Private Sub EditPerfil()

        txtNome.Text = clUser.name
        txtNascimento.Text = clUser.nascimento
        cbGenero.Text = clUser.genero
        txtCell.Text = clUser.cell
        txtEndereco.Text = clUser.endereco
        txtComplemento.Text = clUser.comp
        txtCidade.Text = clUser.cidade
        txtUF.Text = clUser.uf
        txtCep.Text = clUser.cep
        txtEmpresa.Text = clUser.empresa
        txtDepart.Text = clUser.depart
        txtFuncao.Text = clUser.funcao
        txtTel.Text = clUser.tell_empresa
        txtRamal.Text = clUser.ramal
        chkPerfilWhats.Checked = clUser.not_whats
        chkPerfilEmail.Checked = clUser.not_whats
        chkPerfilTermos.Checked = clUser.not_whats
        clUser.valida = False
        bpInfo.SetPage(1)

    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditPerfil()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub TimerExcluir_Tick(sender As Object, e As EventArgs) Handles TimerExcluir.Tick

        ProgressAguarde.Increment(1)

        Select Case ProgressAguarde.Value

            Case 80
                clUser.Delete()

            Case 100
                TimerExcluir.Stop()
                Application.Restart()

        End Select

    End Sub

    Private Sub BtnEmailEnviar_Click(sender As Object, e As EventArgs) Handles BtnEmailEnviar.Click

        If TxtNewEmail.Text.Length > 0 Then
            If ValidaEmail(TxtNewEmail.Text) = False Then
                LblEmailIncorreto.Text = "E-mail invalido"
                LblEmailIncorreto.Visible = True
                LblEmailSenhaIncorreta.Visible = False
                Exit Sub
            End If
        End If

        If TxtNewEmail.Text.Length <= 0 Then
            If TxtSenha.Text.Length > 0 Then
                LblEmailSenhaIncorreta.Text = "Campo obrigatório!"
                LblEmailSenhaIncorreta.Visible = True
                LblEmailIncorreto.Visible = False
                Exit Sub
            End If
        End If

        If TxtSenha.Text.Length <= 0 Then
            If TxtNewEmail.Text.Length > 0 Then
                LblEmailSenhaIncorreta.Text = "Campo obrigatório!"
                LblEmailSenhaIncorreta.Visible = True
                LblEmailIncorreto.Visible = False
                Exit Sub
            End If
        End If


        If TxtSenha.Text.Length <= 0 Then
            If TxtNewEmail.Text.Length <= 0 Then
                LblEmailIncorreto.Text = "Campo obrigatório!"
                LblEmailIncorreto.Visible = True
                LblEmailSenhaIncorreta.Text = "Campo obrigatório!"
                LblEmailSenhaIncorreta.Visible = True
                Exit Sub
            End If
        End If


        If TxtSenha.Text.Length > 0 Then
            If TxtNewEmail.Text.Length > 0 Then
                If ValidaEmail(TxtNewEmail.Text) = False Then

                    clUser.email = TxtNewEmail.Text
                    clUser.VE_FUConfig()

                    If clUser.valida = False Then
                        If clCifer.Criptar(TxtSenha.Text, clCifer.senha) = clUser.pass Then
                            LblEmailIncorreto.Visible = False
                            LblEmailSenhaIncorreta.Visible = False

                            TimerRdfEmail.Enabled = True
                            clEmail.toEmail = TxtNewEmail.Text
                            NewThead = New Thread(AddressOf clEmail.AlterarEmail) With {.IsBackground = True}
                            NewThead.Start()
                            bpInfo.SetPage(5)

                        Else

                            LblEmailSenhaIncorreta.Text = "Senha incorreta"
                            LblEmailSenhaIncorreta.Visible = True
                            LblEmailIncorreto.Visible = False
                            Exit Sub
                        End If

                    Else
                        LblEmailIncorreto.Text = "E-mail já cadastrado"
                        LblEmailIncorreto.Visible = True
                        LblEmailSenhaIncorreta.Visible = False
                        Exit Sub
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click

        If TxtValidar.Text.Length <= 0 Then
            LblCodigoIncorreto.Text = "Campo obrigatório!"
            LblCodigoIncorreto.Visible = True
            Exit Sub
        End If

        If TxtValidar.Text.Length > 0 Then
            If TxtValidar.Text = clEmail.Pass Then
                LblCodigoIncorreto.Visible = False

                ProgressAguarde.Value = 0
                LblLoading.Text = $"<b>Estamos processando sua solicitação...</b><br><br>
                                  <font color='DimGray'>Após a finalização, o sistema será reiniciado, entre com seu novo endereço de e-mail.</font>"

                bpInfo.SetPage(4)
                TimerRdfEmail.Start()

            End If

        Else

            LblCodigoIncorreto.Text = "Código inválido!"
            LblCodigoIncorreto.Visible = True

        End If
    End Sub

    Private Sub TimerRdfEmail_Tick(sender As Object, e As EventArgs) Handles TimerRdfEmail.Tick
        ProgressAguarde.Increment(1)

        Select Case ProgressAguarde.Value

            Case 80
                clUser.EditarEmail()

            Case 100
                TimerRdfEmail.Stop()
                Application.Restart()

        End Select
    End Sub
End Class