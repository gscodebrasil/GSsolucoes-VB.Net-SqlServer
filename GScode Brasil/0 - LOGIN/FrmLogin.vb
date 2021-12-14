Imports System.Text.RegularExpressions
Imports System.Console
Imports System.Threading
Imports System.Diagnostics.Process
Imports Guna.UI2.WinForms

Public Class FrmLogin

#Region "Ref. de classes"

    Private ReadOnly ClValidaData As New ValidaData
    Private ReadOnly ClValidaCep As New ValidaCep
    Private ReadOnly ClUserInfo As New UserInfo
    Private ReadOnly ClCifer As New Cifer
    Private ReadOnly ClEmail As New Email

#End Region

#Region "Ref. Local"

    Private ReadOnly Ttip As New ToolTip()
    Private ReadOnly AutoLogin As Boolean = My.Settings.AutoLogin
    Private ReadOnly LembrarAcesso As Boolean = My.Settings.LembrarAcesso
    'Private strLoginEmail As String = My.Settings.EmailAcesso
    'Private strLoginSenha As String = My.Settings.SenhaAcesso
    Private NewThread As Thread
    Private Contador = 6
    Private Valida As Boolean

#End Region

#Region "Sub/Function"

    Public Sub ErroNoBancoDeDados()
        PanelEtapa.Visible = False
        bpCadUser.SetPage(9)
    End Sub

    Public Sub LimpaPGLogin()
        txtLoginPassword.Clear()
        lblLoginRdf.Visible = False
    End Sub

    Private Sub TtipLoad()
        Ttip.AutoPopDelay = 3500
        Ttip.ShowAlways = True
        Ttip.SetToolTip(btnAddUser, "CADASTRAR-SE")
        Ttip.SetToolTip(btnInstagram, "@gscodebrasil")
        Ttip.SetToolTip(btnFacebook, "GScode Brasil")
        Ttip.SetToolTip(btnYoutube, "GScode Brasil")
        Ttip.SetToolTip(btnAcessoBD, "Acesso ao Banco de Dados")
        Ttip.SetToolTip(lblPerfilTermos, "Download do termo")
        Ttip.SetToolTip(txtCadPass, "A Senha deve conter um tamanho maximo de 18 caractere.")
        'Ttip.Active = True
    End Sub

    Private Sub TxtEmpty()
        For Each Txt As Guna2TextBox In New List(Of Guna2TextBox) From {txtLoginEmail, txtLoginPassword, txtCadEmail, txtCadPass, txtCadConfPass, txtPerfilNome, txtPerfilNascimento, txtPerfilCelular, txtPerfilCep, txtPerfilEndereco, txtPerfilComp, txtBusinessEmpresa, txtBusinessDepart, txtBusinessFuncao, txtBusinessTel, txtBusinessRamal}
            Txt.Clear()
            Txt.IconRight = Nothing
        Next

        cbPerfilGenero.SelectedIndex = -1
        cbPerfilGenero.FillColor = Color.WhiteSmoke
        chkPerfilWhats.Checked = False
        chkPerfilEmail.Checked = False
        chkPerfilTermos.Checked = False
        pbWhats.Visible = False
        pbEmail.Visible = False
        pbTermos.Visible = False
        lblCadEmail.Visible = False
        lblInvalido.Visible = False

    End Sub

    Private Function Valida_Perfil() As Boolean

        If txtPerfilNome.Text.Length <= 0 Then
            txtPerfilNome.IconRight = imgLogin.Images(0)
            Valida_Perfil = True
        End If

        If chkPerfilTermos.Checked = False Then
            pbTermos.Visible = True
            Valida_Perfil = True
        End If

        Return Valida_Perfil
    End Function

    Private Function Empty_Perfil() As Boolean
        For Each Txt As Guna2TextBox In New List(Of Guna2TextBox) From {txtPerfilNome, txtPerfilCelular, txtPerfilCep, txtPerfilEndereco, txtPerfilComp, txtPerfilCidade, txtPerfilUF}
            If Txt.Text.Length <= 0 Then
                pbTopProfile.Visible = True
                Empty_Perfil = True
                Exit For
            End If
        Next

        If txtPerfilNome.Text.Length <= 0 Then
            txtPerfilNome.IconRight = imgLogin.Images(0)
            pbTopProfile.Visible = True
            Empty_Perfil = True
        End If

        If cbPerfilGenero.Text.Length <= 0 Then
            cbPerfilGenero.FillColor = Color.FromArgb(255, 198, 198)
            pbTopProfile.Visible = True
            Empty_Perfil = True
        End If

        If chkPerfilWhats.Checked = False Then
            pbWhats.Visible = True
            pbTopProfile.Visible = True
            Empty_Perfil = True
        End If

        If chkPerfilEmail.Checked = False Then
            pbEmail.Visible = True
            pbTopProfile.Visible = True
            Empty_Perfil = True
        End If


        If chkPerfilTermos.Checked = False Then
            pbTermos.Visible = True
            pbTopProfile.Visible = True
            Empty_Perfil = True
        End If
        Return Empty_Perfil
    End Function

    Private Sub pagLogin()
        PanelEtapa.Visible = False
        btnInstagram.Visible = True
        btnFacebook.Visible = True
        btnYoutube.Visible = True
        txtLoginEmail.Select()
    End Sub

    Private Sub login()
        TimerAutoLogin.Enabled = False

        If txtLoginEmail.Text.Length <= 0 OrElse txtLoginPassword.Text.Length <= 0 OrElse ValidaEmail(txtLoginEmail.Text) = False Then
            lblInvalido.Text = "E-mail Inválido!"
            lblInvalido.Visible = True
            TimerUserInvalido.Start()
            ClUserInfo.StrEmail = Nothing
            ClUserInfo.StrPass = Nothing
            ClUserInfo.StrNome = Nothing
            txtLoginEmail.Focus()
            Exit Sub
        End If

        Me.Hide()
        FrmAguarde.Show()

    End Sub

    Private Senha = "#"

    Private Sub Insert()
        CodigoInterno()
        ClUserInfo.id_interno = Senha
        ClUserInfo.ValidaCodigoInterno()

        If ClUserInfo.valida = True Then
            ClUserInfo.valida = False

            CodigoInterno()
            ClUserInfo.id_interno = Senha
            ClUserInfo.ValidaCodigoInterno()

        Else

            ClUserInfo.email = txtCadEmail.Text
            ClUserInfo.pass = ClCifer.Criptar(txtCadPass.Text, ClCifer.senha)
            ClUserInfo.pass_retry = ClCifer.Criptar(txtCadConfPass.Text, ClCifer.senha)
            ClUserInfo.id_interno = Senha
            ClUserInfo.name = txtPerfilNome.Text
            ClUserInfo.foto = ""
            ClUserInfo.nascimento = txtPerfilNascimento.Text
            ClUserInfo.genero = cbPerfilGenero.Text
            ClUserInfo.cell = txtPerfilCelular.Text
            ClUserInfo.cep = txtPerfilCep.Text
            ClUserInfo.endereco = txtPerfilEndereco.Text
            ClUserInfo.comp = txtPerfilComp.Text
            ClUserInfo.cidade = txtPerfilCidade.Text
            ClUserInfo.uf = txtPerfilUF.Text
            ClUserInfo.not_whats = chkPerfilWhats.Checked
            ClUserInfo.not_email = chkPerfilEmail.Checked
            ClUserInfo.acept_termos = chkPerfilTermos.Checked
            ClUserInfo.empresa = txtBusinessEmpresa.Text
            ClUserInfo.depart = txtBusinessDepart.Text
            ClUserInfo.funcao = txtBusinessFuncao.Text

            ClUserInfo.tell_empresa = txtBusinessTel.Text
            ClUserInfo.ramal = txtBusinessRamal.Text
            ClUserInfo.token = txtConfToken.Text
            ClUserInfo.Cadastra()
        End If
    End Sub

    Private Sub VAutoLoginAcesso()
        If AutoLogin = True Then
            TimerAutoLogin.Enabled = True
        End If

        If My.Settings.Acesso_Senha.Length > 0 Then
            txtLoginPassword.Text = ClCifer.Decriptar(My.Settings.Acesso_Senha, ClCifer.senha)
        End If

        chkAutoLogin.Checked = AutoLogin
        chkLembrarAcesso.Checked = LembrarAcesso
        txtLoginEmail.Text = My.Settings.Acesso_Usuario
    End Sub

    Private Sub RdfSenha()

        ClUserInfo.email = txtRdfEmail.Text
        ClUserInfo.ValidarEmailRdf()

        If ClUserInfo.valida = True Then

            ClUserInfo.valida = False

            ClEmail.toEmail = ClUserInfo.email
            ClEmail.YourSenha = ClCifer.Decriptar(ClUserInfo.pass, ClCifer.senha)
            ClEmail.token = ClUserInfo.token
            ClEmail.EnviaCredenciais()

        Else

            lblRdfInvalido.Visible = True
            bpCadUser.SetPage(7)

        End If
    End Sub

    Private Function ValidaData(strCheck As String) As Boolean
        Return Regex.IsMatch(strCheck, "^\d{2}/\d{2}/\d{4}$")
    End Function

    Private Function ValidaEmail(strCheck As String) As Boolean
        Return Regex.IsMatch(strCheck, "^([0-9a-z]([-\.\w]*[0-9a-z])*@([0-9a-z][-\w]*[0-9a-z]\.)+[a-z]{2,9})$")
    End Function

    Private Function ValidaCEP(strCheck As String) As Boolean
        Return Regex.IsMatch(strCheck, "^\d{5}-\d{3}$")
    End Function

    Private Function ValidaCampos() As Boolean
        If txtPerfilNome.Text.Length <= 0 OrElse
            txtPerfilNascimento.Text.Length <= 0 OrElse
            cbPerfilGenero.Text.Length <= 0 OrElse
            txtPerfilCelular.Text.Length <= 0 OrElse
            txtPerfilCep.Text.Length <= 0 OrElse
            txtPerfilEndereco.Text.Length <= 0 OrElse
            txtPerfilComp.Text.Length <= 0 OrElse
            txtPerfilCidade.Text.Length <= 0 OrElse
            txtPerfilUF.Text.Length <= 0 OrElse
            chkPerfilWhats.Checked = False OrElse
            chkPerfilEmail.Checked = False OrElse
            txtBusinessEmpresa.Text.Length <= 0 OrElse
            txtBusinessDepart.Text.Length <= 0 OrElse
            txtBusinessFuncao.Text.Length <= 0 OrElse
            txtBusinessTel.Text.Length <= 0 OrElse
            txtBusinessRamal.Text.Length <= 0 Then Valida = False Else Valida = True
        Return Valida
    End Function

    Private Function ValidaBusiness() As Boolean
        If txtBusinessEmpresa.Text.Length <= 0 OrElse
            txtBusinessDepart.Text.Length <= 0 OrElse
            txtBusinessFuncao.Text.Length <= 0 OrElse
            txtBusinessTel.Text.Length <= 0 OrElse
            txtBusinessRamal.Text.Length <= 0 Then Valida = False Else Valida = True
        Return Valida
    End Function

    Private Function ValidaProfile() As Boolean
        If txtPerfilNome.Text.Length <= 0 OrElse
            cbPerfilGenero.Text.Length <= 0 OrElse
            txtPerfilCelular.Text.Length <= 0 OrElse
            txtPerfilCep.Text.Length <= 0 OrElse
            txtPerfilEndereco.Text.Length <= 0 OrElse
            txtPerfilComp.Text.Length <= 0 OrElse
            txtPerfilCidade.Text.Length <= 0 OrElse
            txtPerfilUF.Text.Length <= 0 OrElse
            chkPerfilWhats.Checked = False OrElse
            chkPerfilEmail.Checked = False Then Valida = False Else Valida = True
        Return Valida
    End Function

    Private Function ValidaBanco() As Boolean
        If txtBDServidor.Text.Length <= 0 OrElse
            txtBDPorta.Text.Length <= 0 OrElse
            txtBDBanco.Text.Length <= 0 OrElse
            txtBDUser.Text.Length <= 0 OrElse
            txtBDSenha.Text.Length <= 0 Then Valida = False Else Valida = True
        Return Valida
    End Function

    Private Function CodigoInterno() As String
        Dim Rand = New Random
        Dim Caracteres = "0123456789"
        Dim NumeroMaximo = Caracteres.Length
        Dim Numero As Integer

        For i = 0 To 4
            Numero = Rand.Next(NumeroMaximo)
            Senha = $"{Senha}{Caracteres(Numero)}"
        Next

        Return Senha
    End Function

#End Region

#Region "PAGINA DE LOGIN"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        TimerAutoLogin.Enabled = False
        btnLogin.Text = "LOGIN"
        PanelEtapa.Visible = True
        bpCadUser.SetPage(1)
    End Sub

    Private Sub txtLoginEmail_TextChanged(sender As Object, e As EventArgs) Handles txtLoginEmail.TextChanged
        If txtLoginEmail.Text.Length > 0 Then
            lblLoginEmail.Visible = True
        Else
            lblLoginEmail.Visible = False
            txtLoginEmail.IconRight = Nothing
        End If
    End Sub

    Private Sub txtLoginPassword_TextChanged(sender As Object, e As EventArgs) Handles txtLoginPassword.TextChanged
        If txtLoginPassword.Text.Length > 0 Then
            lblLoginPass.Visible = True
        Else
            lblLoginPass.Visible = False
            txtLoginPassword.IconRight = Nothing
        End If
    End Sub

    Private Sub txtLoginPassword_GotFocus(sender As Object, e As EventArgs) Handles txtLoginPassword.GotFocus
        If CapsLock Then
            lblCapsLook.Visible = True
        End If
    End Sub

    Private Sub txtLoginPassword_LostFocus(sender As Object, e As EventArgs) Handles txtLoginPassword.LostFocus
        lblCapsLook.Visible = False
    End Sub

    Private Sub txtLoginPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLoginPassword.KeyDown
        If CapsLock Then
            lblCapsLook.Visible = True
        Else
            lblCapsLook.Visible = False
        End If
    End Sub

    Private Sub txtLoginPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoginPassword.KeyPress
        If txtLoginPassword.Text.Length > 0 Then
            If e.KeyChar = Convert.ToChar(13) Then
                btnLogin.PerformClick()
            End If
        End If
    End Sub

    Private Sub lblLoginRdf_Click(sender As Object, e As EventArgs) Handles lblLoginRdf.Click

        PanelEtapa.Visible = False
        bpCadUser.SetPage(7)

    End Sub

    Private Sub lblLembrarAcesso_Click(sender As Object, e As EventArgs) Handles lblLembrarAcesso.Click
        If chkLembrarAcesso.Checked = False Then
            chkLembrarAcesso.Checked = True
        Else
            chkLembrarAcesso.Checked = False
        End If
    End Sub

    Private Sub lblAutoLogin_Click(sender As Object, e As EventArgs) Handles lblAutoLogin.Click
        If chkAutoLogin.Checked = False Then
            chkAutoLogin.Checked = True
        Else
            chkAutoLogin.Checked = False
        End If
    End Sub

    Private Sub TAutoLogin_Tick(sender As Object, e As EventArgs) Handles TimerAutoLogin.Tick
        Contador -= 1
        btnLogin.Text = $"AUTO-LOGIN EM {Contador}"

        Select Case Contador

            Case <= 0
                TimerAutoLogin.Enabled = False
                btnLogin.Text = "LOGIN"
                login()

            Case > 0
                If chkAutoLogin.Checked = False Then
                    TimerAutoLogin.Enabled = False
                    btnLogin.Text = "LOGIN"
                End If
        End Select
    End Sub

#End Region

#Region "PAGINA DADOS DE ACESSO"

    Private Sub btnVoltAcesso_Click(sender As Object, e As EventArgs) Handles btnVoltAcesso.Click
        TxtEmpty()
        pagLogin()
        bpCadUser.SetPage(0)
    End Sub

    Private Sub btnAvAcesso_Click(sender As Object, e As EventArgs) Handles btnAvAcesso.Click
        ClUserInfo.email = txtCadEmail.Text
        ClUserInfo.ValidaEmail()

        If ClUserInfo.valida = True Then
            ClUserInfo.valida = False
            lblCadEmail.Visible = True
        Else
            If ValidaEmail(txtCadEmail.Text) Then
                If txtCadPass.Text = txtCadConfPass.Text Then
                    ClUserInfo.valida = False
                    lblCadEmail.Visible = False
                    bpCadUser.SetPage(2)
                    txtPerfilNome.Focus()
                    bs2.LineColor = RGBColors.AvancarCadastro
                    bs3.LineColor = RGBColors.AvancarCadastro
                    pbProfile.BackColor = RGBColors.AvancarCadastro
                End If
            End If
        End If
    End Sub

    Private Sub txtCadEmail_TextChanged(sender As Object, e As EventArgs) Handles txtCadEmail.TextChanged
        If txtCadEmail.Text.Length > 0 Then
            lblAcessoEmail.Visible = True
        Else
            lblAcessoEmail.Visible = False
            txtCadEmail.IconRight = Nothing
        End If
    End Sub

    Private Sub txtCadPass_TextChanged(sender As Object, e As EventArgs) Handles txtCadPass.TextChanged

        Select Case txtCadPass.Text.Length

            Case > 0
                lblAcessoPass.Visible = True

                If txtCadConfPass.Text.Length > 0 Then
                    If txtCadPass.Text <> txtCadConfPass.Text Then
                        txtCadConfPass.IconRight = imgLogin.Images(0)
                    End If
                End If

            Case Else
                lblAcessoPass.Visible = False

        End Select

    End Sub

    Private Sub txtCadPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCadPass.KeyDown
        If CapsLock Then
            lblCadCapsLook.Visible = True
        Else
            lblCadCapsLook.Visible = False
        End If
    End Sub

    Private Sub txtCadPass_Enter(sender As Object, e As EventArgs) Handles txtCadPass.Enter
        If CapsLock Then
            lblCadCapsLook.Visible = True
        End If
    End Sub

    Private Sub txtCadConfPass_TextChanged(sender As Object, e As EventArgs) Handles txtCadConfPass.TextChanged
        Select Case txtCadConfPass.Text.Length

            Case > 0
                lblAcessoConfPass.Visible = True
                If txtCadConfPass.Text <> txtCadPass.Text Then
                    txtCadPass.IconRight = imgLogin.Images(0)
                Else
                    txtCadPass.IconRight = Nothing
                End If

            Case Else
                txtCadPass.IconRight = Nothing
                lblAcessoConfPass.Visible = False

        End Select
    End Sub

    Private Sub txtCadConfPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCadConfPass.KeyDown
        If CapsLock Then
            lblCadCapsLook.Visible = True
        Else
            lblCadCapsLook.Visible = False
        End If
    End Sub

    Private Sub txtCadConfPass_Enter(sender As Object, e As EventArgs) Handles txtCadConfPass.Enter
        If CapsLock Then
            lblCadCapsLook.Visible = True
        End If
    End Sub

    Private Sub txtCadConfPass_IconRightClick(sender As Object, e As EventArgs) Handles txtCadConfPass.IconRightClick
        If txtCadConfPass.UseSystemPasswordChar = True Then
            txtCadConfPass.UseSystemPasswordChar = False
            txtCadPass.UseSystemPasswordChar = False
            txtCadConfPass.IconRight = imgLogin.Images(2)
        Else
            txtCadConfPass.UseSystemPasswordChar = True
            txtCadPass.UseSystemPasswordChar = True
            txtCadConfPass.IconRight = imgLogin.Images(3)
        End If
    End Sub

#End Region

#Region "PAGINA DADOS PESSOAIS"

    Private Sub btnVoltPerfil_Click(sender As Object, e As EventArgs) Handles btnVoltPerfil.Click
        bpCadUser.SetPage(1)
        bs3.LineColor = RGBColors.VoltarCadastro
        bs2.LineColor = RGBColors.VoltarCadastro
        pbProfile.BackColor = RGBColors.VoltarCadastro
        pbTopProfile.Visible = False
    End Sub

    Private Sub btnAvPerfil_Click(sender As Object, e As EventArgs) Handles btnAvPerfil.Click
        If Empty_Perfil() = False Then
            pbTopProfile.Visible = False
        End If

        If Valida_Perfil() = False Then
            If txtPerfilCep.Text.Length = 0 OrElse ValidaCEP(txtPerfilCep.Text) = True Then
                If txtPerfilNascimento.Text.Length = 0 OrElse ValidaData(txtPerfilNascimento.Text) = True Then
                    bpCadUser.SetPage(3)
                    bs4.LineColor = RGBColors.AvancarCadastro
                    bs5.LineColor = RGBColors.AvancarCadastro
                    pbBusiness.BackColor = RGBColors.AvancarCadastro
                End If
            End If
        End If
    End Sub

    Private Sub txtPerfilNome_TextChanged(sender As Object, e As EventArgs) Handles txtPerfilNome.TextChanged
        Select Case txtPerfilNome.Text.Length

            Case > 0
                lblPerfilNome.Visible = True
                txtPerfilNome.IconRight = Nothing

            Case Else
                lblPerfilNome.Visible = False

                If txtPerfilNome.IconRight IsNot Nothing Then
                    txtPerfilNome.IconRight = Nothing
                End If

        End Select
    End Sub

    Private Sub txtPerfilNome_LostFocus(sender As Object, e As EventArgs) Handles txtPerfilNome.LostFocus
        If txtPerfilNome.Text.Length <= 0 Then
            txtPerfilNome.IconRight = imgLogin.Images(0)
        End If
    End Sub

    Private Sub txtPerfilNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPerfilNome.KeyPress
        If (Char.IsNumber(e.KeyChar)) OrElse (Char.IsSymbol(e.KeyChar)) OrElse (Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPerfilNascimento_TextChanged(sender As Object, e As EventArgs) Handles txtPerfilNascimento.TextChanged
        ClValidaData.MaskData(sender)
    End Sub

    Private Sub txtPerfilNascimento_LostFocus(sender As Object, e As EventArgs) Handles txtPerfilNascimento.LostFocus
        If txtPerfilNascimento.Text.Length > 0 Then
            If ValidaData(txtPerfilNascimento.Text) = False Then
                txtPerfilNascimento.IconRight = imgLogin.Images(0)
            End If
        Else
            txtPerfilNascimento.IconRight = Nothing
        End If
    End Sub

    Private Sub txtPerfilNascimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPerfilNascimento.KeyPress
        ClValidaData.ApenasNumeros(e, sender)
    End Sub

    Private Sub txtPerfilCelular_TextChanged(sender As Object, e As EventArgs) Handles txtPerfilCelular.TextChanged
        If txtPerfilCelular.Text.Length > 0 Then
            lblPerfilCelular.Visible = True
        Else
            lblPerfilCelular.Visible = False
            txtPerfilCelular.IconRight = Nothing
        End If
    End Sub

    Private Sub txtPerfilCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPerfilCelular.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPerfilCep_TextChanged(sender As Object, e As EventArgs) Handles txtPerfilCep.TextChanged
        ClValidaCep.MaskCep(sender)
        If txtPerfilCep.Text.Length > 0 Then
            lblPerfilCep.Visible = True
        Else
            lblPerfilCep.Visible = False
            txtPerfilCep.IconRight = Nothing
        End If
    End Sub

    Private Sub txtPerfilCep_LostFocus(sender As Object, e As EventArgs) Handles txtPerfilCep.LostFocus
        If txtPerfilCep.Text.Length > 0 Then
            If ValidaCEP(txtPerfilCep.Text) = False Then
                txtPerfilCep.IconRight = imgLogin.Images(0)
            End If
        Else
            txtPerfilCep.IconRight = Nothing
        End If
    End Sub

    Private Sub txtPerfilCep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPerfilCep.KeyPress
        ClValidaCep.ApenasNumeros(e, sender)
    End Sub

    Private Sub txtPerfilEndereco_TextChanged(sender As Object, e As EventArgs) Handles txtPerfilEndereco.TextChanged
        If txtPerfilEndereco.Text.Length > 0 Then
            lblPerfilEndereco.Visible = True
        Else
            lblPerfilEndereco.Visible = False
        End If
    End Sub

    Private Sub txtPerfilComp_TextChanged(sender As Object, e As EventArgs) Handles txtPerfilComp.TextChanged
        If txtPerfilComp.Text.Length > 0 Then
            lblPerfilComplemento.Visible = True
        Else
            lblPerfilComplemento.Visible = False
        End If
    End Sub

    Private Sub txtPerfilCidade_TextChanged(sender As Object, e As EventArgs) Handles txtPerfilCidade.TextChanged
        If txtPerfilCidade.Text.Length > 0 Then
            lblPerfilCidade.Visible = True
        Else
            lblPerfilCidade.Visible = False
        End If
    End Sub

    Private Sub txtPerfilUF_TextChanged(sender As Object, e As EventArgs) Handles txtPerfilUF.TextChanged
        If txtPerfilUF.Text.Length > 0 Then
            lblPerfilUF.Visible = True
        Else
            lblPerfilUF.Visible = False
        End If
    End Sub

    Private Sub txtPerfilUF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPerfilUF.KeyPress
        If (Char.IsNumber(e.KeyChar)) OrElse (Char.IsSymbol(e.KeyChar)) OrElse (Char.IsPunctuation(e.KeyChar)) OrElse (Char.IsSeparator(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub chkPerfilWhats_CheckedChanged(sender As Object, e As EventArgs) Handles chkPerfilWhats.CheckedChanged
        If pbWhats.Visible = True Then
            pbWhats.Visible = False
        End If
    End Sub

    Private Sub chkPerfilEmail_CheckedChanged(sender As Object, e As EventArgs) Handles chkPerfilEmail.CheckedChanged
        If pbEmail.Visible = True Then
            pbEmail.Visible = False
        End If
    End Sub

    Private Sub chkPerfilTermos_CheckedChanged(sender As Object, e As EventArgs) Handles chkPerfilTermos.CheckedChanged
        If pbTermos.Visible = True Then
            pbTermos.Visible = False
        End If
    End Sub

    Private Sub lblPerfilTermos_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPerfilTermos.LinkClicked
        MsgBox("Download")
    End Sub

#End Region

#Region "PAGINA DADOS PROFISSIONAIS"

    Private Sub btnVoltBusiness_Click(sender As Object, e As EventArgs) Handles btnVoltBusiness.Click
        If chkPerfilWhats.Checked = False Then
            pbWhats.Visible = True
        End If
        If chkPerfilEmail.Checked = False Then
            pbEmail.Visible = True
        End If
        bpCadUser.SetPage(2)
        bs5.LineColor = RGBColors.VoltarCadastro
        bs4.LineColor = RGBColors.VoltarCadastro
        pbBusiness.BackColor = RGBColors.VoltarCadastro
        pbTopProfile.Visible = False
    End Sub

    Private Sub btnAvBusiness_Click(sender As Object, e As EventArgs) Handles btnAvBusiness.Click
        bpCadUser.SetPage(4)
        bs6.LineColor = RGBColors.AvancarCadastro
        bs7.LineColor = RGBColors.AvancarCadastro
        pbPermissao.BackColor = RGBColors.AvancarCadastro

        If ValidaBusiness() Then
            pbTopBusiness.Visible = False
        Else
            pbTopBusiness.Visible = True
        End If
    End Sub

    Private Sub txtBusinessEmpresa_TextChanged(sender As Object, e As EventArgs) Handles txtBusinessEmpresa.TextChanged
        If txtBusinessEmpresa.Text.Length > 0 Then
            lblBusinessEmpresa.Visible = True
        Else
            lblBusinessEmpresa.Visible = False
        End If
    End Sub

    Private Sub txtBusinessDepart_TextChanged(sender As Object, e As EventArgs) Handles txtBusinessDepart.TextChanged
        If txtBusinessDepart.Text.Length > 0 Then
            lblBusinessDepart.Visible = True
        Else
            lblBusinessDepart.Visible = False
        End If
    End Sub

    Private Sub txtBusinessFuncao_TextChanged(sender As Object, e As EventArgs) Handles txtBusinessFuncao.TextChanged
        If txtBusinessFuncao.Text.Length > 0 Then
            lblBusinessFuncao.Visible = True
        Else
            lblBusinessFuncao.Visible = False
        End If
    End Sub

    Private Sub txtBusinessTel_TextChanged(sender As Object, e As EventArgs) Handles txtBusinessTel.TextChanged
        If txtBusinessTel.Text.Length > 0 Then
            lblBusinessTelefone.Visible = True
        Else
            lblBusinessTelefone.Visible = False
            txtBusinessTel.IconRight = Nothing
        End If
    End Sub

    Private Sub txtBusinessTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusinessTel.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBusinessRamal_TextChanged(sender As Object, e As EventArgs) Handles txtBusinessRamal.TextChanged
        If txtBusinessRamal.Text.Length > 0 Then
            lblBusinessRmal.Visible = True
        Else
            lblBusinessRmal.Visible = False
        End If
    End Sub

    Private Sub txtBusinessRamal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusinessRamal.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub chkPerfilTermos_Click(sender As Object, e As EventArgs) Handles chkPerfilTermos.Click
        Select Case chkPerfilTermos.Checked


            Case True
                pbTermos.Visible = False

            Case Else
                pbTermos.Visible = True

        End Select
    End Sub

    Private Sub chkPerfilEmail_Click(sender As Object, e As EventArgs) Handles chkPerfilEmail.Click
        Select Case chkPerfilEmail.Checked

            Case True
                pbEmail.Visible = False

            Case Else
                pbEmail.Visible = True

        End Select
    End Sub

    Private Sub chkPerfilWhats_Click(sender As Object, e As EventArgs) Handles chkPerfilWhats.Click
        Select Case chkPerfilWhats.Checked

            Case True
                pbWhats.Visible = False

            Case Else
                pbWhats.Visible = True

        End Select
    End Sub

#End Region

#Region "PAGINA PERMISSAO"

    Private Sub btnPermVoltar_Click(sender As Object, e As EventArgs) Handles btnPermVoltar.Click
        bpCadUser.SetPage(3)
        bs6.LineColor = RGBColors.VoltarCadastro
        bs7.LineColor = RGBColors.VoltarCadastro
        pbPermissao.BackColor = RGBColors.VoltarCadastro
        pbTopBusiness.Visible = False
    End Sub

    Private Sub btnPermAvancar_Click(sender As Object, e As EventArgs) Handles btnPermAvancar.Click
        If ValidaCampos() = True Then
            pbChklistAviso.Image = imgLogin1.Images(0)
            lblChklistAviso.Text = "Todos os campos foram preenchidos corretamente, clique em finalizar para realizar o cadastro."
            bpCadUser.SetPage(5)
            bs8.LineColor = RGBColors.AvancarCadastro
            pbChecklist.BackColor = RGBColors.AvancarCadastro
        Else
            pbChklistAviso.Image = imgLogin1.Images(1)
            lblChklistAviso.Text = "Existem campos sem preencher, mas isso não vai impedir o cadastro, caso desejar finalizar seu cadastro mais tarde, vá até seu perfil!"
            bpCadUser.SetPage(5)
            bs8.LineColor = RGBColors.AvancarCadastro
            pbChecklist.BackColor = RGBColors.AvancarCadastro
        End If
    End Sub

#End Region

#Region "PAGINA CHECKLIST"

    Private Sub btnChklistVoltar_Click(sender As Object, e As EventArgs) Handles btnChklistVoltar.Click
        bpCadUser.SetPage(4)
        bs8.LineColor = RGBColors.VoltarCadastro
        pbChecklist.BackColor = RGBColors.VoltarCadastro
    End Sub

    Private Sub btnChklistFinalizar_Click(sender As Object, e As EventArgs) Handles btnChklistFinalizar.Click

        ClEmail.ToEmail = txtCadEmail.Text
        NewThread = New Thread(AddressOf ClEmail.ValidarEmail) With {.IsBackground = True}
        NewThread.Start()
        PanelEtapa.Visible = False
        bpCadUser.SetPage(8)

    End Sub

#End Region

#Region "LIBERA ACESSO AO BANCO DE DADOS"

    Private Sub btnEditarBD_Click(sender As Object, e As EventArgs) Handles btnEditarBD.Click
        If txtEditarBDEmail.Text = My.Settings.AcessoAdmin_Usuario Then

            If txtEditarBDSenha.Text = ClCifer.Decriptar(My.Settings.AcessoAdmin_Senha, ClCifer.senha) Then
                txtBDServidor.Text = My.Settings.Database_Servidor
                txtBDPorta.Text = My.Settings.Database_Porta
                txtBDBanco.Text = My.Settings.Database_Banco
                txtBDUser.Text = My.Settings.Database_Usuario
                txtBDSenha.Text = My.Settings.Database_Senha

                lblBDAviso.Text = $"
                <b><font color='maroon'>Caminho padrão do banco de dados</font></b><br>
                <b>Servidor</b>: 192.168.2.225  
                <b>Porta:</b> 1433  
                <b>Banco:</b> gscode<br>
                <b>Usuário:</b> sa<br>
                <b>Senha:</b> ysQLa5ihU1gRA4cRtUuyCnOJZXm5UFE5LRn7UhkkTbI="

                bpCadUser.SetPage(6)
            Else
                lblEditarBDInvalido.Visible = True
                TimerEditarBD.Start()
            End If
        Else
            lblEditarBDInvalido.Visible = True
            TimerEditarBD.Start()
        End If
    End Sub

    Private Sub txtEditarBDEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEditarBDEmail.TextChanged
        Select Case txtEditarBDEmail.Text.Length

            Case > 0
                If ValidaEmail(txtEditarBDEmail.Text) = False Then
                    txtEditarBDEmail.IconRight = imgLogin.Images(0)
                    lblEditarBDEmail.Visible = True
                Else
                    txtEditarBDEmail.IconRight = Nothing
                    lblEditarBDEmail.Visible = True
                End If

            Case Else
                txtEditarBDEmail.IconRight = Nothing
                lblEditarBDEmail.Visible = False

        End Select
    End Sub

    Private Sub txtEditarBDSenha_TextChanged(sender As Object, e As EventArgs) Handles txtEditarBDSenha.TextChanged
        If txtEditarBDSenha.Text.Length > 0 Then
            lblEditarBDSenha.Visible = True
        Else
            lblEditarBDSenha.Visible = False
        End If
    End Sub

    Private Sub txtEditarBDSenha_GotFocus(sender As Object, e As EventArgs) Handles txtEditarBDSenha.GotFocus
        If CapsLock Then
            lblEditarBDCaps.Visible = True
        End If
    End Sub

    Private Sub txtEditarBDSenha_LostFocus(sender As Object, e As EventArgs) Handles txtEditarBDSenha.LostFocus
        lblEditarBDCaps.Visible = False
    End Sub

    Private Sub txtEditarBDSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEditarBDSenha.KeyDown
        If CapsLock Then
            lblEditarBDCaps.Visible = True
        Else
            lblEditarBDCaps.Visible = False
        End If
    End Sub

    Private Sub txtEditarBDSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEditarBDSenha.KeyPress
        If txtEditarBDSenha.Text.Length > 0 Then
            If e.KeyChar = Convert.ToChar(13) Then
                btnEditarBD.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnCancelarBD_Click(sender As Object, e As EventArgs) Handles btnCancelarBD.Click
        Application.Restart()
    End Sub

    Private Sub TEditarBD_Tick(sender As Object, e As EventArgs) Handles TimerEditarBD.Tick
        lblEditarBDInvalido.Visible = False
    End Sub

#End Region

#Region "PAGINA BANCO DE DADOS"

    Private Sub btnBDSalvar_Click(sender As Object, e As EventArgs) Handles btnBDSalvar.Click
        My.Settings.Database_Servidor = txtBDServidor.Text
        My.Settings.Database_Porta = txtBDPorta.Text
        My.Settings.Database_Banco = txtBDBanco.Text
        My.Settings.Database_Usuario = txtBDUser.Text
        My.Settings.Database_Senha = ClCifer.Criptar(txtBDSenha.Text, ClCifer.senha)
        My.Settings.Save()
        Application.Restart()
    End Sub

    Private Sub btnBDDefault_Click(sender As Object, e As EventArgs) Handles btnBDDefault.Click
        My.Settings.Reset()
    End Sub

    Private Sub btnBDCancelar_Click(sender As Object, e As EventArgs) Handles btnBDCancelar.Click
        Application.Restart()
    End Sub

    Private Sub btnBDConnect_Click(sender As Object, e As EventArgs) Handles btnBDConnect.Click
        If ValidaBanco() = False Then
            MessageBox.Show("Existem campos sem preenchers.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ClUserInfo.Connect()
        End If
    End Sub

    Private Sub txtBDServidor_TextChanged(sender As Object, e As EventArgs) Handles txtBDServidor.TextChanged
        If txtBDServidor.Text.Length > 0 Then
            lblBDServidor.Visible = True
        Else
            lblBDServidor.Visible = False
        End If
    End Sub

    Private Sub txtBDPorta_TextChanged(sender As Object, e As EventArgs) Handles txtBDPorta.TextChanged
        If txtBDPorta.Text.Length > 0 Then
            lblBDPorta.Visible = True
        Else
            lblBDPorta.Visible = False
        End If
    End Sub

    Private Sub txtBDBanco_TextChanged(sender As Object, e As EventArgs) Handles txtBDBanco.TextChanged
        If txtBDBanco.Text.Length > 0 Then
            lblBDBanco.Visible = True
        Else
            lblBDBanco.Visible = False
        End If
    End Sub

    Private Sub txtBDUser_TextChanged(sender As Object, e As EventArgs) Handles txtBDUser.TextChanged
        If txtBDUser.Text.Length > 0 Then
            lblBDUser.Visible = True
        Else
            lblBDUser.Visible = False
        End If
    End Sub

    Private Sub txtBDSenha_TextChanged(sender As Object, e As EventArgs) Handles txtBDSenha.TextChanged
        If txtBDSenha.Text.Length > 0 Then
            lblBDSenha.Visible = True
        Else
            lblBDSenha.Visible = False
        End If
    End Sub

#End Region

#Region "PAGINA REDEFINICAO DE SENHA"

    Private Sub btnRdfEnviar_Click(sender As Object, e As EventArgs) Handles btnRdfEnviar.Click

        If txtRdfEmail.Text.Length <= 0 OrElse ValidaEmail(txtRdfEmail.Text) = False Then
            lblRdfInvalido.Visible = True

        Else

            lblRdfInvalido.Visible = False

            ProgressAguarde.Value = 0
            LblLoading.Text = $"<b>Estamos processando sua solicitação...</b><br><br>
                                  <font color='DimGray'>Após a finalização o sistema será reiniciado, ao iniciar entre com suas credênciais.</font>"

            bpCadUser.SetPage(10)
            btnAcessoBD.Visible = False
            TimerRdfSenha.Start()

        End If

    End Sub

    Private Sub btnRdfCancel_Click(sender As Object, e As EventArgs) Handles btnRdfCancel.Click
        bpCadUser.SetPage(0)
        btnAcessoBD.Visible = True
    End Sub

    Private Sub txtRdfEmail_TextChanged(sender As Object, e As EventArgs) Handles txtRdfEmail.TextChanged
        Select Case txtRdfEmail.Text.Length

            Case > 0
                If ValidaEmail(txtRdfEmail.Text) = False Then
                    txtRdfEmail.IconRight = imgLogin.Images(0)
                    lblRdfEmail.Visible = True
                Else
                    txtRdfEmail.IconRight = Nothing
                    lblRdfEmail.Visible = True
                End If

            Case Else
                txtRdfEmail.IconRight = Nothing
                lblRdfEmail.Visible = False

        End Select
    End Sub

    Private Sub TRdf_Tick(sender As Object, e As EventArgs) Handles TimerRdf.Tick
        lblRdfInvalido.Visible = False
    End Sub

    Private Sub TRdfSenha_Tick(sender As Object, e As EventArgs) Handles TimerRdfSenha.Tick

        ProgressAguarde.Increment(1)

        Select Case ProgressAguarde.Value

            Case 80
                RdfSenha()

            Case 100
                Application.Restart()

        End Select

    End Sub

#End Region

#Region "PAGINA VALIDAR EMAIL"

    Private Sub btnConfValidar_Click(sender As Object, e As EventArgs) Handles btnConfValidar.Click

        If txtConfToken.Text.Length <= 0 Then
            lblConfInvalido.Text = "Campo obrigatório!"
            lblConfInvalido.Visible = True
            Exit Sub
        End If

        If txtConfToken.Text.Length > 0 Then
            If txtConfToken.Text = ClEmail.token Then
                lblConfInvalido.Visible = False

                ProgressAguarde.Value = 0
                LblLoading.Text = $"<b>Estamos processando sua solicitação...</b><br><br>
                                  <font color='DimGray'>Após a finalização o sistema será reiniciado, ao iniciar entre com suas credênciais.</font>"

                bpCadUser.SetPage(10)
                btnAcessoBD.Visible = False
                TimerCadastro.Start()

            Else

                lblConfInvalido.Text = "Código inválido!"
                lblConfInvalido.Visible = True

            End If
        End If

    End Sub

    Private Sub btnConfCancel_Click(sender As Object, e As EventArgs) Handles btnConfCancel.Click
        bpCadUser.SetPage(5)
        btnAcessoBD.Visible = True
        PanelEtapa.Visible = True
    End Sub

    Private Sub txtConfToken_TextChanged(sender As Object, e As EventArgs) Handles txtConfToken.TextChanged
        If txtConfToken.Text.Length > 0 Then
            lblConfToken.Visible = True
        Else
            lblConfToken.Visible = False
        End If
    End Sub

    Private Sub txtConfToken_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfToken.KeyPress
        If txtConfToken.Text.Length > 0 Then
            If e.KeyChar = Convert.ToChar(13) Then
                btnConfValidar.PerformClick()
            End If
        End If
    End Sub

    Private Sub TimerCadastro_Tick(sender As Object, e As EventArgs) Handles TimerCadastro.Tick
        ProgressAguarde.Increment(1)

        Select Case ProgressAguarde.Value

            Case 80
                Insert()

            Case 100
                Application.Restart()

        End Select

    End Sub

#End Region

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pagLogin()
        VAutoLoginAcesso()
        txtLoginEmail.Focus()
        TtipLoad()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAcessoBD_Click(sender As Object, e As EventArgs) Handles btnAcessoBD.Click
        bpCadUser.SetPage(9)
    End Sub

    Private Sub btnInstagram_Click(sender As Object, e As EventArgs) Handles btnInstagram.Click
        Start("http://instagram.com/gscodebrasil/")
    End Sub

    Private Sub btnFacebook_Click(sender As Object, e As EventArgs) Handles btnFacebook.Click

    End Sub

    Private Sub btnYoutube_Click(sender As Object, e As EventArgs) Handles btnYoutube.Click

    End Sub

    Private Sub txtPerfilCep_Enter(sender As Object, e As EventArgs) Handles txtPerfilCep.Enter
        txtPerfilCep.IconRight = Nothing
    End Sub

    Private Sub lblPerfilGenero_Enter(sender As Object, e As EventArgs) Handles lblPerfilGenero.Enter

    End Sub

    Private Sub cbPerfilGenero_Enter(sender As Object, e As EventArgs) Handles cbPerfilGenero.Enter
        cbPerfilGenero.FillColor = Color.WhiteSmoke
        lblPerfilGenero.Visible = True
    End Sub

    Private Sub cbPerfilGenero_LostFocus(sender As Object, e As EventArgs) Handles cbPerfilGenero.LostFocus
        If cbPerfilGenero.SelectedIndex <= 0 Then
            lblPerfilGenero.Visible = False
        End If
    End Sub

    Private Sub txtPerfilNascimento_Enter(sender As Object, e As EventArgs) Handles txtPerfilNascimento.Enter
        txtPerfilNascimento.IconRight = Nothing
    End Sub

    Private Sub txtPerfilCelular_Enter(sender As Object, e As EventArgs) Handles txtPerfilCelular.Enter
        txtPerfilCelular.Text = txtPerfilCelular.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        txtPerfilCelular.IconRight = Nothing
    End Sub

    Private Sub txtPerfilCelular_Validated(sender As Object, e As EventArgs) Handles txtPerfilCelular.Validated
        Dim mask = txtPerfilCelular.Text
        Select Case txtPerfilCelular.Text.Length
            Case 0
                txtPerfilCelular.IconRight = Nothing

            Case 9
                If Not txtPerfilCelular.Text.StartsWith("0") Then
                    txtPerfilCelular.Text = mask.Insert(5, "-")
                    txtPerfilCelular.IconRight = Nothing
                Else
                    txtPerfilCelular.IconRight = imgLogin.Images(0)
                End If

            Case 11
                If Not txtPerfilCelular.Text.StartsWith("0") Then
                    txtPerfilCelular.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                    txtPerfilCelular.IconRight = Nothing
                Else
                    txtPerfilCelular.IconRight = imgLogin.Images(0)
                End If
        End Select
    End Sub

    Private Sub txtBusinessTel_Enter(sender As Object, e As EventArgs) Handles txtBusinessTel.Enter
        txtBusinessTel.Text = txtBusinessTel.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        txtBusinessTel.IconRight = Nothing
    End Sub

    Private Sub txtPerfilCelular_LostFocus(sender As Object, e As EventArgs) Handles txtPerfilCelular.LostFocus
        Select Case txtPerfilCelular.Text.Length
            Case 0
                txtPerfilCelular.IconRight = Nothing
            Case 10, 15
                txtPerfilCelular.IconRight = Nothing
            Case Else
                txtPerfilCelular.IconRight = imgLogin.Images(0)
        End Select
    End Sub

    Private Sub txtBusinessTel_Validated(sender As Object, e As EventArgs) Handles txtBusinessTel.Validated
        Dim mask = txtBusinessTel.Text
        Select Case txtBusinessTel.Text.Length
            Case 0
                txtBusinessTel.IconRight = Nothing
            Case 8
                If Not txtBusinessTel.Text.StartsWith("0") Then
                    txtBusinessTel.Text = mask.Insert(4, "-")
                    txtBusinessTel.IconRight = Nothing
                Else
                    txtBusinessTel.IconRight = imgLogin.Images(0)
                End If

            Case 9
                If Not txtBusinessTel.Text.StartsWith("0") Then
                    txtBusinessTel.Text = mask.Insert(5, "-")
                    txtBusinessTel.IconRight = Nothing
                Else
                    txtBusinessTel.IconRight = imgLogin.Images(0)
                End If

            Case 10
                If Not txtBusinessTel.Text.StartsWith("0") Then
                    txtBusinessTel.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(9, "-")
                    txtBusinessTel.IconRight = Nothing
                Else
                    txtBusinessTel.IconRight = imgLogin.Images(0)
                End If

            Case 11
                If txtBusinessTel.Text.StartsWith("0800") Then
                    txtBusinessTel.Text = mask.Insert(4, " ").Insert(8, " ")
                    txtBusinessTel.IconRight = Nothing
                Else
                    If Not txtBusinessTel.Text.StartsWith("0") Then
                        txtBusinessTel.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                        txtBusinessTel.IconRight = Nothing
                    Else
                        txtBusinessTel.IconRight = imgLogin.Images(0)
                    End If
                End If
            Case Else
                txtBusinessTel.IconRight = imgLogin.Images(0)
        End Select
    End Sub

    Private Sub txtBusinessTel_LostFocus(sender As Object, e As EventArgs) Handles txtBusinessTel.LostFocus
        Select Case txtBusinessTel.Text.Length
            Case 0
                txtBusinessTel.IconRight = Nothing
            Case 9, 13, 14
                txtBusinessTel.IconRight = Nothing
            Case Else
                txtBusinessTel.IconRight = imgLogin.Images(0)
        End Select
    End Sub

    Private Sub txtCadEmail_Enter(sender As Object, e As EventArgs) Handles txtCadEmail.Enter
        txtCadEmail.IconRight = Nothing
        lblCadCapsLook.Visible = False
    End Sub

    Private Sub txtCadEmail_LostFocus(sender As Object, e As EventArgs) Handles txtCadEmail.LostFocus
        If txtCadEmail.Text.Length > 0 Then
            If ValidaEmail(txtCadEmail.Text) = False Then
                txtCadEmail.IconRight = imgLogin.Images(0)
            Else
                txtCadEmail.IconRight = Nothing
            End If
        End If
    End Sub

    Private Sub txtLoginEmail_LostFocus(sender As Object, e As EventArgs) Handles txtLoginEmail.LostFocus
        If txtLoginEmail.Text.Length > 0 Then
            If ValidaEmail(txtLoginEmail.Text) = False Then
                txtLoginEmail.IconRight = imgLogin.Images(0)
            Else
                txtLoginEmail.IconRight = Nothing
            End If
        End If
    End Sub

    Private Sub txtLoginEmail_Enter(sender As Object, e As EventArgs) Handles txtLoginEmail.Enter
        txtLoginEmail.IconRight = Nothing
    End Sub

    Private Sub txtLoginPassword_Enter(sender As Object, e As EventArgs) Handles txtLoginPassword.Enter
        txtLoginPassword.IconRight = Nothing
    End Sub
End Class