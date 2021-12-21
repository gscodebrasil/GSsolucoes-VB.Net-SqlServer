Imports System.Threading

Public Class FrmAguarde
    Private clValidaData As New ValidaData
    Private clValidaCep As New ValidaCep
    Private clUserInfo As New UserInfo
    Private clCifer As New Cifer
    Private clEmail As New Email
    Private clRGB As New RGBColors
    Private ClServerSFTP As New ServerSFTP

    Private TH_aguarde As Thread
    Private LembrarAcesso As Boolean = My.Settings.LembrarAcesso
    Private AutoLogin As Boolean = My.Settings.AutoLogin

    Private Sub SalvarAcesso()
        If FrmLogin.chkLembrarAcesso.Checked = False Then
            LembrarAcesso = False
            My.Settings.Acesso_Usuario = Nothing
            My.Settings.Acesso_Senha = Nothing
        Else
            LembrarAcesso = True
            My.Settings.Acesso_Usuario = FrmLogin.txtLoginEmail.Text
            My.Settings.Acesso_Senha = clCifer.Criptar(FrmLogin.txtLoginPassword.Text, clCifer.senha)
        End If

        My.Settings.LembrarAcesso = LembrarAcesso
        My.Settings.Save()
    End Sub

    Private Sub SalvarAutoLogin()
        If FrmLogin.chkAutoLogin.Checked = False Then
            AutoLogin = False
        Else
            AutoLogin = True
        End If

        My.Settings.AutoLogin = AutoLogin
        My.Settings.Save()
    End Sub

    Private Sub ErroDeLogin()
        FrmLogin.LimpaPGLogin()
        FrmLogin.lblInvalido.Text = "E-mail ou senha inválido!"
        FrmLogin.btnLogin.Text = "LOGIN"
        FrmLogin.lblInvalido.Visible = True
        FrmLogin.lblLoginRdf.Visible = True
        Me.Close()
        FrmLogin.Show()
        FrmLogin.TimerUserInvalido.Start()

        clUserInfo.StrEmail = Nothing
        clUserInfo.StrPass = Nothing
        clUserInfo.StrNome = Nothing

        Me.Close()
        FrmLogin.Show()
    End Sub

    Private Sub LoginAceito()

        lblAguarde.Text = $"Olá {clUserInfo.StrNome}, seja bem vindo(a) novamente."

        ClServerSFTP.FileList_Usuario(FrmPrincipal.PbPerfilLeft, clUserInfo.email)

        FrmPrincipal.LblNameLeft.Text = clUserInfo.StrNome
        FrmPrincipal.LblNameTop.Text = clUserInfo.StrNome
        FrmPrincipal.LblNameLeft_Phonebook.Text = clUserInfo.StrNome
        FrmPrincipal.LblNameLeft_Helpdesk.Text = clUserInfo.StrNome

        FrmPrincipal.LblEmailLeft.Text = clUserInfo.StrEmail
        FrmPrincipal.LblEmailTop.Text = clUserInfo.StrEmail
        FrmPrincipal.LblEmailLeft_Phonebook.Text = clUserInfo.StrEmail
        FrmPrincipal.LblEmailLeft_Helpdesk.Text = clUserInfo.StrEmail

        FrmPrincipal.PbPerfilLeft_Helpdesk.Image = FrmPrincipal.PbPerfilLeft.Image
        FrmPrincipal.PbPerfilLeft_Phonebook.Image = FrmPrincipal.PbPerfilLeft.Image
        FrmPrincipal.PbPerfilTop.Image = FrmPrincipal.PbPerfilLeft.Image

        clUserInfo.StrEmail = Nothing
        clUserInfo.StrPass = Nothing
        clUserInfo.StrNome = Nothing
        clUserInfo.StrFoto = Nothing

        SalvarAcesso()
        SalvarAutoLogin()
        FrmLogin.LimpaPGLogin()

    End Sub

    Private Sub FrmAguarde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAguarde.Text = $"Aguarde um instante, estamos verificando suas credênciais."
        ProgressAguarde.Value = 0
        TimerAguarde.Start()
    End Sub

    Private Sub TimerAguarde_Tick(sender As Object, e As EventArgs) Handles TimerAguarde.Tick
        ProgressAguarde.Increment(1)

        Select Case ProgressAguarde.Value

            Case 30
                clUserInfo.email = FrmLogin.txtLoginEmail.Text
                clUserInfo.pass = clCifer.Criptar(FrmLogin.txtLoginPassword.Text, clCifer.senha)
                clUserInfo.Login()

                Select Case clUserInfo.valida

                    Case False
                        ErroDeLogin()

                    Case Else
                        LoginAceito()

                End Select

            Case 100
                TimerAguarde.Stop()
                Me.Close()
                FrmPrincipal.Show()

        End Select

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class