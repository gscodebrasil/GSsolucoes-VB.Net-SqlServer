Imports System.Threading

Public Class FrmSMTP

#Region "Ref. de Classes"

    Private ClEmail As New Email
    Private ClCifer As New Cifer

#End Region

#Region "Ref. Local"

    Private NewThread As Thread

#End Region

#Region "Sub/Function"

    Private Sub Informacoes_Servidor()
        If My.Settings.SMTP_Senha.Length > 0 Then
            TxtSenha.Text = ClCifer.Decriptar(My.Settings.SMTP_Senha, ClCifer.senha)
        Else
            TxtSenha.Text = My.Settings.SMTP_Senha
        End If

        TxtServidor.Text = My.Settings.SMTP_Servidor
        TxtPorta.Text = My.Settings.SMTP_Porta
        TxtUsuario.Text = My.Settings.SMTP_Usuario
        TxtAdministrador.Text = My.Settings.SMTP_Administrador
        SwitchSSL.Checked = My.Settings.SMTP_SSL

    End Sub

    Private Sub Salvar()
        If TxtSenha.Text.Length > 0 Then
            My.Settings.SMTP_Senha = ClCifer.Criptar(TxtSenha.Text, ClCifer.senha)
        Else
            My.Settings.SMTP_Senha = TxtSenha.Text
        End If

        My.Settings.SMTP_Servidor = TxtServidor.Text
        My.Settings.SMTP_Porta = TxtPorta.Text
        My.Settings.SMTP_Usuario = TxtUsuario.Text
        My.Settings.SMTP_Administrador = TxtAdministrador.Text
        My.Settings.SMTP_SSL = SwitchSSL.Checked
        My.Settings.Save()

    End Sub

    Private Sub Apagar()

        My.Settings.SMTP_Servidor = ""
        My.Settings.SMTP_Porta = ""
        My.Settings.SMTP_Usuario = ""
        My.Settings.SMTP_Senha = ""
        My.Settings.SMTP_Administrador = ""
        My.Settings.SMTP_SSL = False
        My.Settings.Save()

        TxtServidor.Clear()
        TxtPorta.Clear()
        TxtUsuario.Clear()
        TxtSenha.Clear()
        TxtAdministrador.Clear()
        SwitchSSL.Checked = False

    End Sub

#End Region

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        Apagar()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()
        MsgBox("Informações salvas com sucesso!")
    End Sub

    Private Sub BtnTeste_Click(sender As Object, e As EventArgs) Handles BtnTeste.Click
        ClEmail.ToEmail = TxtAdministrador.Text
        NewThread = New Thread(AddressOf ClEmail.EmailTeste) With {.IsBackground = True}
        NewThread.Start()
    End Sub

    Private Sub FrmSMTP_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Informacoes_Servidor()
    End Sub

End Class