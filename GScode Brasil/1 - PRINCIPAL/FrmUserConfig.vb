Imports System.Console
Imports System.Text.RegularExpressions
Imports System.Threading
Imports Guna.UI2.WinForms

Public Class FrmUserConfig


    Private NewThead As Thread

    Private ReadOnly clValidaData As New ValidaData
    Private ReadOnly clValidaCep As New ValidaCep
    Private ReadOnly clUser As New UserInfo
    Private ReadOnly clCifer As New Cifer
    Private ReadOnly clEmail As New Email
    Private ReadOnly clRGB As New RGBColors
    Private ReadOnly ClServerSFTP As New ServerSFTP

    Private StrWhats As String
    Private StrEmail As String
    Private StrTermo As String
    Private StrColorWhats As String
    Private StrColorEmail As String
    Private chkWhats As Boolean
    Private chkEmail As Boolean
    Private chkTermos As Boolean
    Private redefinir As Integer

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditPerfil()
    End Sub

    Private Sub Editar()
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
        clUser.not_whats = chkPerfilWhats.Checked
        clUser.not_email = chkPerfilEmail.Checked
        clUser.acept_termos = chkPerfilTermos.Checked
        clUser.empresa = txtEmpresa.Text
        clUser.depart = txtDepart.Text
        clUser.funcao = txtFuncao.Text
        clUser.tell_empresa = txtTel.Text
        clUser.ramal = txtRamal.Text
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
        clEmail.ToEmail = Nothing
    End Sub

    Public Sub BuscarInfo()

        clUser.email = FrmPrincipal.LblEmailLeft.Text
        clUser.Busca()

        If clUser.not_whats = True Then
            StrWhats = "Ativado"
            StrColorWhats = "Green"
            pbWhats.Visible = False
        Else
            StrWhats = "Desativado"
            StrColorWhats = "Red"
            pbWhats.Visible = True
        End If
        If clUser.not_email = True Then
            StrEmail = "Ativado"
            StrColorEmail = "Green"
            pbEmail.Visible = False
        Else
            StrEmail = "Desativado"
            StrColorEmail = "Red"
            pbEmail.Visible = True
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

    Private Function CodigoInterno() As String
        Dim senha = ""
        Dim Rand = New Random
        Dim Caracteres = "0123456789"
        Dim NumeroMaximo = Caracteres.Length
        Dim Numero As Integer

        For i = 0 To 4
            Numero = Rand.Next(NumeroMaximo)
            senha = $"{senha}{Caracteres(Numero)}"
        Next

        Return senha
    End Function

    Private Function ValidaEmail(ByVal strCheck As String) As Boolean
        Return Regex.IsMatch(strCheck, "^([0-9a-z]([-\.\w]*[0-9a-z])*@([0-9a-z][-\w]*[0-9a-z]\.)+[a-z]{2,9})$")
    End Function

    Private Function Valida_Perfil() As Boolean

        If txtNome.Text.Length <= 0 Then
            txtNome.IconRight = imgRdf.Images(0)
            Valida_Perfil = True
        End If

        If chkPerfilTermos.Checked = False Then
            pbTermos.Visible = True
            Valida_Perfil = True
        End If

        Return Valida_Perfil
    End Function

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        Clipboard.SetDataObject(lblChaveKey.Text, True)
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If Valida_Perfil() = False Then
            If txtCep.Text.Length = 0 OrElse ValidaCEP(txtCep.Text) = True Then
                If txtNascimento.Text.Length = 0 OrElse ValidaData(txtNascimento.Text) = True Then
                    ProgressAguarde.Value = 0
                    LblLoading.Text = $"<b>Aguarde um momento, estamos processando sua solicitação...</b><br><br>"
                    TabControl_UserConfig.SelectTab(5)
                    TimerEditar.Start()
                End If
            End If
        End If
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        ProgressAguarde.Value = 0
        LblLoading.Text = $"<b>Aguarde um momento, estamos processando sua solicitação...</b><br><br>
                            <font color='DimGray'>Após a finalização, o sistema será reiniciado, para ter acesso novamente será necessário efetuar um novo cadastro.</font>"

        TabControl_UserConfig.SelectTab(5)
        TimerExcluir.Start()
    End Sub

    Private Sub BtnEditEmail_Click(sender As Object, e As EventArgs) Handles BtnEditEmail.Click
        RdfEmail()
        TabControl_UserConfig.SelectTab(2)
    End Sub

    Private Sub btnEditSenha_Click(sender As Object, e As EventArgs) Handles btnEditSenha.Click
        TabControl_UserConfig.SelectTab(3)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        TabControl_UserConfig.SelectTab(0)
    End Sub

    Private Sub BtnSenhaCancel_Click(sender As Object, e As EventArgs) Handles BtnSenhaCancel.Click
        TxtOldSenha.Clear()
        TxtNewSenha.Clear()
        TxtRetrySenha.Clear()
        LblOldSenhaIncorreta.Visible = False
        TabControl_UserConfig.SelectTab(0)
    End Sub

    Private Sub RdfEmail()
        TxtNewEmail.Clear()
        TxtSenha.Clear()
        LblEmailInf.Text = "Por favor insira o novo e-mail no campo correspondente.<br>
            Para alterar seu e-mail é necessário uma validação.<br>
            Vamos enviar um código no e-mail informado.<br>
            Ao finalizar a substituição vamos enviar seu token no endereço de e-mail novo."
    End Sub

    Private Sub TxtNewEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtNewEmail.TextChanged
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

    Private Sub TxtSenha_TextChanged(sender As Object, e As EventArgs) Handles TxtSenha.TextChanged
        If TxtSenha.Text.Length > 0 Then
            LblSenha.Visible = True
        Else
            LblSenha.Visible = False
            LblEmailSenhaIncorreta.Visible = False
        End If
    End Sub

    Private Sub txtSenha_GotFocus(sender As Object, e As EventArgs) Handles TxtSenha.GotFocus
        If CapsLock Then
            LblEmailCapsLook.Visible = True
        End If
    End Sub

    Private Sub txtSenha_LostFocus(sender As Object, e As EventArgs) Handles TxtSenha.LostFocus
        LblEmailCapsLook.Visible = False
    End Sub

    Private Sub txtSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSenha.KeyDown
        If CapsLock Then
            LblEmailCapsLook.Visible = True
        Else
            LblEmailCapsLook.Visible = False
        End If
    End Sub

    Private Sub txtSenha_IconRightClick(sender As Object, e As EventArgs) Handles TxtSenha.IconRightClick
        If TxtSenha.UseSystemPasswordChar = True Then
            TxtSenha.UseSystemPasswordChar = False
            TxtSenha.IconRight = imgRdf.Images(2)
        Else
            TxtSenha.UseSystemPasswordChar = True
            TxtSenha.IconRight = imgRdf.Images(3)
        End If
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
        chkPerfilEmail.Checked = clUser.not_email
        chkPerfilTermos.Checked = clUser.acept_termos
        clUser.valida = False

        If clUser.not_whats = True Then
            pbWhats.Visible = False
        Else
            pbWhats.Visible = True
        End If
        If clUser.not_email = True Then
            pbEmail.Visible = False
        Else
            pbEmail.Visible = True
        End If
        If clUser.acept_termos = True Then
            pbTermos.Visible = False
        Else
            pbTermos.Visible = True
        End If

        TabControl_UserConfig.SelectTab(1)

    End Sub

    Private Sub TimerEditar_Tick(sender As Object, e As EventArgs) Handles TimerEditar.Tick

        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 80
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
                clUser.not_whats = chkPerfilWhats.Checked
                clUser.not_email = chkPerfilEmail.Checked
                clUser.acept_termos = chkPerfilTermos.Checked
                clUser.empresa = txtEmpresa.Text
                clUser.depart = txtDepart.Text
                clUser.funcao = txtFuncao.Text
                clUser.tell_empresa = txtTel.Text
                clUser.ramal = txtRamal.Text
                clUser.Edita()

                If clUser.valida = True Then
                    FrmPrincipal.LblNameLeft.Text = txtNome.Text
                End If

            Case 100
                TimerEditar.Stop()
                MessageBox.Show("As informações foram atualizadas com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FrmPrincipal.ActiveFormClose()

        End Select
    End Sub

    Private Sub TimerExcluir_Tick(sender As Object, e As EventArgs) Handles TimerExcluir.Tick

        ProgressAguarde.Increment(5)

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
                If ValidaEmail(TxtNewEmail.Text) Then
                    clUser.valida = False

                    clUser.email = TxtNewEmail.Text
                    clUser.VE_FUConfig()

                    If clUser.valida = False Then
                        If clCifer.Criptar(TxtSenha.Text, clCifer.senha) = clUser.pass Then
                            LblEmailIncorreto.Visible = False
                            LblEmailSenhaIncorreta.Visible = False

                            clEmail.ToEmail = TxtNewEmail.Text
                            clEmail.CodRdf_Email = CodigoInterno()
                            NewThead = New Thread(AddressOf clEmail.AlterarEmail) With {.IsBackground = True}
                            NewThead.Start()
                            TabControl_UserConfig.SelectTab(4)

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

        If TxtValidar.Text = clEmail.CodRdf_Email Then
            LblCodigoIncorreto.Visible = False

            ProgressAguarde.Value = 0
            LblLoading.Text = $"<b>Aguarde um momento, estamos processando sua solicitação...</b><br><br>
                                  <font color='DimGray'>Após a finalização, o sistema será reiniciado, entre com seu novo endereço de e-mail.</font>"

            TabControl_UserConfig.SelectTab(5)
            TimerRdfEmail.Start()

        Else

            LblCodigoIncorreto.Text = "Código inválido!"
            LblCodigoIncorreto.Visible = True

        End If
    End Sub

    Private Sub TimerRdfEmail_Tick(sender As Object, e As EventArgs) Handles TimerRdfEmail.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 80
                clUser.EditarEmail()

            Case 100
                TimerRdfEmail.Stop()
                Application.Restart()

        End Select
    End Sub

    Private Sub BtnEmailCancel_Click(sender As Object, e As EventArgs) Handles BtnEmailCancel.Click
        TxtNewEmail.Clear()
        TxtSenha.Clear()
        LblEmailIncorreto.Visible = False
        LblEmailSenhaIncorreta.Visible = False
        TabControl_UserConfig.SelectTab(0)
    End Sub

    Private Sub BtnSenhaSalvar_Click(sender As Object, e As EventArgs) Handles BtnSenhaSalvar.Click
        If TxtNewSenha.Text.Length > 0 Then
            If TxtNewSenha.Text = TxtRetrySenha.Text Then
                ProgressAguarde.Value = 0
                LblLoading.Text = $"<b>Aguarde um momento, estamos processando sua solicitação...</b><br><br>
                                  <font color='DimGray'>Após a finalização, o sistema será reiniciado, entre com sua nova senha.</font>"

                TabControl_UserConfig.SelectTab(5)
                TimerEditar_Senha.Start()
            End If
        End If
    End Sub

    Private Sub BtnValidarCancelar_Click(sender As Object, e As EventArgs) Handles BtnValidarCancelar.Click
        TxtNewEmail.Clear()
        TxtSenha.Clear()
        TxtValidar.Clear()
        LblCodigoIncorreto.Visible = False
        LblEmailIncorreto.Visible = False
        LblEmailSenhaIncorreta.Visible = False
        TabControl_UserConfig.SelectTab(0)
    End Sub

    Private Sub BtnSendEmail_Login_Click(sender As Object, e As EventArgs) Handles BtnSendEmail_Login.Click
        ProgressAguarde.Value = 0
        LblLoading.Text = $"<b>Aguarde um momento, estamos processando sua solicitação...</b><br><br>"

        TabControl_UserConfig.SelectTab(5)
        TimerEnviar_Login.Start()
    End Sub

    Private Sub TimerEnviar_Login_Tick(sender As Object, e As EventArgs) Handles TimerEnviar_Login.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 80
                clUser.email = FrmPrincipal.LblEmailLeft.Text
                clUser.ValidarEmailRdf()

                If clUser.valida = True Then
                    clUser.valida = False

                    clEmail.ToEmail = FrmPrincipal.LblEmailLeft.Text
                    clEmail.YourSenha = clCifer.Decriptar(clUser.pass, clCifer.senha)
                    clEmail.Token = clUser.token
                    clEmail.EnviaCredenciais()
                End If

            Case 100
                TimerRdfEmail.Stop()
                TabControl_UserConfig.SelectTab(0)

        End Select
    End Sub

    Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged
        Select Case txtNome.Text.Length

            Case > 0
                LblNome.Visible = True
                txtNome.IconRight = Nothing

            Case Else
                LblNome.Visible = False

                If txtNome.IconRight IsNot Nothing Then
                    txtNome.IconRight = Nothing
                End If

        End Select
    End Sub

    Private Sub txtNascimento_TextChanged(sender As Object, e As EventArgs) Handles txtNascimento.TextChanged
        clValidaData.MaskData(sender)
    End Sub

    Private Sub txtCell_TextChanged(sender As Object, e As EventArgs) Handles txtCell.TextChanged
        If txtCell.Text.Length > 0 Then
            LblCelular.Visible = True
        Else
            LblCelular.Visible = False
            txtCell.IconRight = Nothing
        End If
    End Sub

    Private Sub txtCep_TextChanged(sender As Object, e As EventArgs) Handles txtCep.TextChanged
        clValidaCep.MaskCep(sender)
        If txtCep.Text.Length > 0 Then
            LblCep.Visible = True
        Else
            LblCep.Visible = False
            txtCep.IconRight = Nothing
        End If
    End Sub

    Private Sub txtEndereco_TextChanged(sender As Object, e As EventArgs) Handles txtEndereco.TextChanged
        If txtEndereco.Text.Length > 0 Then
            LblEndereço.Visible = True
        Else
            LblEndereço.Visible = False
        End If
    End Sub

    Private Sub txtComplemento_TextChanged(sender As Object, e As EventArgs) Handles txtComplemento.TextChanged
        If txtComplemento.Text.Length > 0 Then
            LblComplemento.Visible = True
        Else
            LblComplemento.Visible = False
        End If
    End Sub

    Private Sub txtCidade_TextChanged(sender As Object, e As EventArgs) Handles txtCidade.TextChanged
        If txtCidade.Text.Length > 0 Then
            LblCidade.Visible = True
        Else
            LblCidade.Visible = False
        End If
    End Sub

    Private Sub txtUF_TextChanged(sender As Object, e As EventArgs) Handles txtUF.TextChanged
        If txtUF.Text.Length > 0 Then
            LblUF.Visible = True
        Else
            LblUF.Visible = False
        End If
    End Sub

    Private Sub txtEmpresa_TextChanged(sender As Object, e As EventArgs) Handles txtEmpresa.TextChanged
        If txtEmpresa.Text.Length > 0 Then
            LblEmpresa.Visible = True
        Else
            LblEmpresa.Visible = False
        End If
    End Sub

    Private Sub txtDepart_TextChanged(sender As Object, e As EventArgs) Handles txtDepart.TextChanged
        If txtDepart.Text.Length > 0 Then
            LblDepartamento.Visible = True
        Else
            LblDepartamento.Visible = False
        End If
    End Sub

    Private Sub txtFuncao_TextChanged(sender As Object, e As EventArgs) Handles txtFuncao.TextChanged
        If txtFuncao.Text.Length > 0 Then
            LblFuncao.Visible = True
        Else
            LblFuncao.Visible = False
        End If
    End Sub

    Private Sub txtTel_TextChanged(sender As Object, e As EventArgs) Handles txtTel.TextChanged
        If txtTel.Text.Length > 0 Then
            LblTelefone.Visible = True
        Else
            LblTelefone.Visible = False
            txtTel.IconRight = Nothing
        End If
    End Sub

    Private Sub txtRamal_TextChanged(sender As Object, e As EventArgs) Handles txtRamal.TextChanged
        If txtRamal.Text.Length > 0 Then
            LblRamal.Visible = True
        Else
            LblRamal.Visible = False
        End If
    End Sub

    Private Sub chkPerfilWhats_Click(sender As Object, e As EventArgs) Handles chkPerfilWhats.Click
        If chkPerfilWhats.Checked = True Then
            pbWhats.Visible = False
        Else
            pbWhats.Visible = True
        End If
    End Sub

    Private Sub TxtOldSenha_TextChanged(sender As Object, e As EventArgs) Handles TxtOldSenha.TextChanged
        If TxtOldSenha.Text.Length > 0 Then
            LblOldSenha.Visible = True
        Else
            LblOldSenha.Visible = False
            LblOldSenha.Visible = False
        End If
    End Sub

    Private Sub TxtNewSenha_TextChanged(sender As Object, e As EventArgs) Handles TxtNewSenha.TextChanged
        Select Case TxtNewSenha.Text.Length

            Case > 0
                LblNewSenha.Visible = True

                If TxtRetrySenha.Text.Length > 0 Then
                    If TxtNewSenha.Text <> TxtRetrySenha.Text Then
                        TxtRetrySenha.IconRight = imgRdf.Images(0)
                    End If
                End If

            Case Else
                LblNewSenha.Visible = False

        End Select
    End Sub

    Private Sub TxtRetrySenha_TextChanged(sender As Object, e As EventArgs) Handles TxtRetrySenha.TextChanged
        Select Case TxtRetrySenha.Text.Length

            Case > 0
                LblRetrySenha.Visible = True
                If TxtRetrySenha.Text <> TxtNewSenha.Text Then
                    TxtNewSenha.IconRight = imgRdf.Images(0)
                Else
                    TxtNewSenha.IconRight = Nothing
                End If

            Case Else
                TxtNewSenha.IconRight = Nothing
                LblRetrySenha.Visible = False

        End Select
    End Sub

    Private Sub TxtValidar_TextChanged(sender As Object, e As EventArgs) Handles TxtValidar.TextChanged
        If TxtValidar.Text.Length > 0 Then
            LblValidarCodigo.Visible = True
        Else
            LblValidarCodigo.Visible = False
            LblCodigoIncorreto.Visible = False
        End If
    End Sub

    Private Sub cbGenero_Enter(sender As Object, e As EventArgs) Handles cbGenero.Enter
        cbGenero.FillColor = Color.WhiteSmoke
        LblGenero.Visible = True
    End Sub

    Private Sub cbGenero_LostFocus(sender As Object, e As EventArgs) Handles cbGenero.LostFocus
        If cbGenero.SelectedIndex <= 0 Then
            LblGenero.Visible = False
        End If
    End Sub

    Private Sub txtNome_LostFocus(sender As Object, e As EventArgs) Handles txtNome.LostFocus
        If txtNome.Text.Length <= 0 Then
            txtNome.IconRight = imgRdf.Images(0)
        End If
    End Sub

    Private Sub txtNome_Enter(sender As Object, e As EventArgs) Handles txtNome.Enter

    End Sub

    Private Function ValidaData(strCheck As String) As Boolean
        Return Regex.IsMatch(strCheck, "^\d{2}/\d{2}/\d{4}$")
    End Function

    Private Sub txtNascimento_LostFocus(sender As Object, e As EventArgs) Handles txtNascimento.LostFocus
        If txtNascimento.Text.Length > 0 Then
            If ValidaData(txtNascimento.Text) = False Then
                txtNascimento.IconRight = imgRdf.Images(0)
            End If
        Else
            txtNascimento.IconRight = Nothing
        End If
    End Sub

    Private Sub txtNascimento_IconRightClick(sender As Object, e As EventArgs) Handles txtNascimento.IconRightClick

    End Sub

    Private Sub txtCell_LostFocus(sender As Object, e As EventArgs) Handles txtCell.LostFocus
        Select Case txtCell.Text.Length
            Case 0
                txtCell.IconRight = Nothing
            Case 10, 15
                txtCell.IconRight = Nothing
            Case Else
                txtCell.IconRight = imgRdf.Images(0)
        End Select
    End Sub

    Private Sub txtCell_Enter(sender As Object, e As EventArgs) Handles txtCell.Enter
        txtCell.Text = txtCell.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        txtCell.IconRight = Nothing
    End Sub

    Private Sub txtCell_Validated(sender As Object, e As EventArgs) Handles txtCell.Validated
        Dim mask = txtCell.Text
        Select Case txtCell.Text.Length
            Case 0
                txtCell.IconRight = Nothing

            Case 9
                If Not txtCell.Text.StartsWith("0") Then
                    txtCell.Text = mask.Insert(5, "-")
                    txtCell.IconRight = Nothing
                Else
                    txtCell.IconRight = imgRdf.Images(0)
                End If

            Case 11
                If Not txtCell.Text.StartsWith("0") Then
                    txtCell.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                    txtCell.IconRight = Nothing
                Else
                    txtCell.IconRight = imgRdf.Images(0)
                End If
        End Select
    End Sub

    Private Sub txtCell_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCell.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        If (Char.IsNumber(e.KeyChar)) OrElse (Char.IsSymbol(e.KeyChar)) OrElse (Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNascimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNascimento.KeyPress
        clValidaData.ApenasNumeros(e, sender)
    End Sub

    Private Sub txtCep_Enter(sender As Object, e As EventArgs) Handles txtCep.Enter
        txtCep.IconRight = Nothing
    End Sub

    Private Sub txtCep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCep.KeyPress
        clValidaCep.ApenasNumeros(e, sender)
    End Sub

    Private Function ValidaCEP(strCheck As String) As Boolean
        Return Regex.IsMatch(strCheck, "^\d{5}-\d{3}$")
    End Function

    Private Sub txtCep_LostFocus(sender As Object, e As EventArgs) Handles txtCep.LostFocus
        If txtCep.Text.Length > 0 Then
            If ValidaCEP(txtCep.Text) = False Then
                txtCep.IconRight = imgRdf.Images(0)
            End If
        Else
            txtCep.IconRight = Nothing
        End If
    End Sub

    Private Sub txtTel_Validated(sender As Object, e As EventArgs) Handles txtTel.Validated
        Dim mask = txtTel.Text
        Select Case txtTel.Text.Length
            Case 0
                txtTel.IconRight = Nothing
            Case 8
                If Not txtTel.Text.StartsWith("0") Then
                    txtTel.Text = mask.Insert(4, "-")
                    txtTel.IconRight = Nothing
                Else
                    txtTel.IconRight = imgRdf.Images(0)
                End If

            Case 9
                If Not txtTel.Text.StartsWith("0") Then
                    txtTel.Text = mask.Insert(5, "-")
                    txtTel.IconRight = Nothing
                Else
                    txtTel.IconRight = imgRdf.Images(0)
                End If

            Case 10
                If Not txtTel.Text.StartsWith("0") Then
                    txtTel.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(9, "-")
                    txtTel.IconRight = Nothing
                Else
                    txtTel.IconRight = imgRdf.Images(0)
                End If

            Case 11
                If txtTel.Text.StartsWith("0800") Then
                    txtTel.Text = mask.Insert(4, " ").Insert(8, " ")
                    txtTel.IconRight = Nothing
                Else
                    If Not txtTel.Text.StartsWith("0") Then
                        txtTel.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                        txtTel.IconRight = Nothing
                    Else
                        txtTel.IconRight = imgRdf.Images(0)
                    End If
                End If
            Case Else
                txtTel.IconRight = imgRdf.Images(0)
        End Select
    End Sub

    Private Sub txtTel_LostFocus(sender As Object, e As EventArgs) Handles txtTel.LostFocus
        Select Case txtTel.Text.Length
            Case 0
                txtTel.IconRight = Nothing
            Case 9, 13, 14
                txtTel.IconRight = Nothing
            Case Else
                txtTel.IconRight = imgRdf.Images(0)
        End Select
    End Sub

    Private Sub txtTel_Enter(sender As Object, e As EventArgs) Handles txtTel.Enter
        txtTel.Text = txtTel.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        txtTel.IconRight = Nothing
    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRamal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRamal.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNewEmail_Enter(sender As Object, e As EventArgs) Handles TxtNewEmail.Enter
        LblEmailIncorreto.Visible = False
    End Sub

    Private Sub TxtSenha_Enter(sender As Object, e As EventArgs) Handles TxtSenha.Enter
        LblEmailIncorreto.Visible = False
    End Sub

    Private Sub chkPerfilEmail_Click(sender As Object, e As EventArgs) Handles chkPerfilEmail.Click
        If chkPerfilEmail.Checked = True Then
            pbEmail.Visible = False
        Else
            pbEmail.Visible = True
        End If
    End Sub

    Private Sub chkPerfilTermos_Click(sender As Object, e As EventArgs) Handles chkPerfilTermos.Click
        If chkPerfilTermos.Checked = True Then
            pbTermos.Visible = False
        Else
            pbTermos.Visible = True
        End If
    End Sub

    Private Sub txtNascimento_Enter(sender As Object, e As EventArgs) Handles txtNascimento.Enter
        txtNascimento.IconRight = Nothing
    End Sub

    Private Sub FrmUserConfig_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        BuscarInfo()
    End Sub

    Private Sub TxtValidar_Enter(sender As Object, e As EventArgs) Handles TxtValidar.Enter
        LblCodigoIncorreto.Visible = False
    End Sub

    Private Sub TxtValidar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValidar.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtOldSenha_Enter(sender As Object, e As EventArgs) Handles TxtOldSenha.Enter
        LblOldSenhaIncorreta.Visible = False
    End Sub

    Private Sub TxtRetrySenha_IconRightClick(sender As Object, e As EventArgs) Handles TxtRetrySenha.IconRightClick
        If TxtRetrySenha.UseSystemPasswordChar = True Then
            TxtRetrySenha.UseSystemPasswordChar = False
            TxtNewSenha.UseSystemPasswordChar = False
            TxtRetrySenha.IconRight = imgRdf.Images(2)
        Else
            TxtRetrySenha.UseSystemPasswordChar = True
            TxtNewSenha.UseSystemPasswordChar = True
            TxtRetrySenha.IconRight = imgRdf.Images(3)
        End If
    End Sub

    Private Sub TxtRetrySenha_Enter(sender As Object, e As EventArgs) Handles TxtRetrySenha.Enter
        If CapsLock Then
            LblCapsLook.Visible = True
        End If
    End Sub

    Private Sub TxtNewSenha_Enter(sender As Object, e As EventArgs) Handles TxtNewSenha.Enter
        If CapsLock Then
            LblCapsLook.Visible = True
        End If
    End Sub

    Private Sub TxtRetrySenha_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtRetrySenha.KeyDown
        If CapsLock Then
            LblCapsLook.Visible = True
        Else
            LblCapsLook.Visible = False
        End If
    End Sub

    Private Sub TxtNewSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNewSenha.KeyDown
        If CapsLock Then
            LblCapsLook.Visible = True
        Else
            LblCapsLook.Visible = False
        End If
    End Sub

    Private Sub TimerEditar_Senha_Tick(sender As Object, e As EventArgs) Handles TimerEditar_Senha.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 80
                clUser.valida = False
                clUser.email = FrmPrincipal.LblEmailLeft.Text
                clUser.BuscarSenha()

                If clUser.pass = clCifer.Criptar(TxtOldSenha.Text, clCifer.senha) Then
                    clUser.valida = False
                    clUser.email = FrmPrincipal.LblEmailLeft.Text
                    clUser.pass = clCifer.Criptar(TxtNewSenha.Text, clCifer.senha)
                    clUser.pass_retry = clCifer.Criptar(TxtRetrySenha.Text, clCifer.senha)
                    clUser.UpdateSenha()
                Else
                    TimerEditar_Senha.Stop()
                    LblOldSenhaIncorreta.Visible = True
                    TabControl_UserConfig.SelectTab(3)
                End If

            Case 100
                TimerEditar_Senha.Stop()
                Application.Restart()

        End Select
    End Sub

    Private Sub TxtOldSenha_IconRightClick(sender As Object, e As EventArgs) Handles TxtOldSenha.IconRightClick
        If TxtOldSenha.UseSystemPasswordChar = True Then
            TxtOldSenha.UseSystemPasswordChar = False
            TxtOldSenha.IconRight = imgRdf.Images(2)
        Else
            TxtOldSenha.UseSystemPasswordChar = True
            TxtOldSenha.IconRight = imgRdf.Images(3)
        End If
    End Sub

    Private Sub imgPerfil_Click(sender As Object, e As EventArgs) Handles imgPerfil.Click
        'ClServerSFTP.CarregarArquivo_Usuario(Ofd, imgPerfil, FrmPrincipal.PbPerfilLeft, FrmPrincipal.PbPerfilTop, FrmPrincipal.ImageUserLeft, FrmPrincipal.ImageUserTop, $"{FrmPrincipal.LblEmailLeft.Text}")
    End Sub
End Class