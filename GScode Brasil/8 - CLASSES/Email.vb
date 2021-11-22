Imports System.Net
Imports System.Net.Mail
Imports System.Guid

Public Class Email

#Region "Ref. de classes"
    Private ReadOnly clCifer As New Cifer
#End Region

#Region "Ref. Local"

    Public Token As String
    Public ToEmail As String
    Public YourSenha As String
    Public ValidaEmail As Boolean
    Private Html As AlternateView
    Public Pass = ""

    Private ReadOnly LogoCredenciais As New LinkedResource($"{Application.StartupPath}\images\info_usuario.png")
    Private ReadOnly LogoCodRdfEmail As New LinkedResource($"{Application.StartupPath}\images\cod_rdf_email.png")
    Private ReadOnly LogoEmailTeste As New LinkedResource($"{Application.StartupPath}\images\auth_smtp.png")

#End Region

    Private Function CodVerificador() As String
        Dim Rand = New Random
        Dim Caracteres = "0123456789"
        Dim NumeroMaximo = caracteres.Length
        Dim Numero As Integer

        For i = 0 To 3
            Numero = Rand.Next(NumeroMaximo)
            Pass = $"{Pass}{Caracteres(Numero)}"
        Next

        Return Pass
    End Function

    Public Function SenhaRandom() As String
        Dim Rand = New Random
        Dim Caracteres = "!@#$%+-*0123456789ABCDEFGHIJKLMNOPQRSTUVXYWZabcdefghijklmnopqrstuvxywz"
        Dim NumeroMaximo = Caracteres.Length
        Dim Numero As Integer

        For i = 0 To 4
            numero = rand.Next(numeroMaximo)
            Pass = $"{Pass}{caracteres(numero)}"
        Next

        Return Pass
    End Function

    Public Sub EmailTeste()
        Try
            Using Smtp As New SmtpClient
                Using Email As New MailMessage
                    'SERVIDOR SMTP
                    Smtp.Host = My.Settings.SMTP_Servidor
                    Smtp.Credentials = New NetworkCredential(My.Settings.SMTP_Usuario, clCifer.Decriptar(My.Settings.SMTP_Senha, clCifer.senha))
                    Smtp.Port = My.Settings.SMTP_Porta
                    Smtp.EnableSsl = My.Settings.SMTP_SSL

                    'EMAIL (MENSAGEM)
                    Email.From = New MailAddress("contato@gscodebrasil.com.br")
                    Email.To.Add(ToEmail)
                    Email.Priority = MailPriority.High
                    Email.Subject = "Autênticação SMTP de teste - GScode Brasil"
                    Email.IsBodyHtml = True
                    Html = AlternateView.CreateAlternateViewFromString($"<center><img src='cid:imagem'><br><br>
                    Caso não tenha solicitado essa informação, por favor desconsiderar o e-mail.</font><br><br>
                    Este é um e-mail automático, por favor não responda.", Nothing, "text/html")
                    LogoEmailTeste.ContentId = "imagem"
                    Html.LinkedResources.Add(LogoEmailTeste)
                    Email.AlternateViews.Add(Html)
                    Smtp.Send(Email)
                    ValidaEmail = True
                End Using
            End Using
        Catch ex As Exception
            ValidaEmail = False
            MessageBox.Show($"Não foi possível enviar o e-mail. {vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub AlterarEmail()
        Try
            Using Smtp As New SmtpClient
                Using Email As New MailMessage
                    'SERVIDOR SMTP
                    Smtp.Host = My.Settings.SMTP_Servidor
                    Smtp.Credentials = New NetworkCredential(My.Settings.SMTP_Usuario, clCifer.Decriptar(My.Settings.SMTP_Senha, clCifer.senha))
                    Smtp.Port = My.Settings.SMTP_Porta
                    Smtp.EnableSsl = My.Settings.SMTP_SSL

                    'EMAIL (MENSAGEM)
                    Email.From = New MailAddress("contato@gscodebrasil.com.br")
                    Email.To.Add(ToEmail)
                    'email.CC.Add()
                    Email.Priority = MailPriority.High
                    Email.Subject = "Alteração de e-mail - GScode Brasil"
                    Email.IsBodyHtml = True
                    'email.Body =
                    Html = AlternateView.CreateAlternateViewFromString($"
                    <center><b><font size='4' color='DimGray'>Informações para alteração de e-mail</font></b><br><br>
                    <b><font color='Gray'>Código:</b> {CodVerificador()}<br><br><br>
                    <center><img src='cid:imagem'><br><br>
                    Caso não tenha solicitado essa informação, por favor desconsiderar o e-mail.</font><br><br>
                    Este é um e-mail automático, por favor não responda.", Nothing, "text/html")
                    LogoCodRdfEmail.ContentId = "imagem"
                    Html.LinkedResources.Add(LogoCodRdfEmail)
                    Email.AlternateViews.Add(Html)
                    Smtp.Send(Email)
                    ValidaEmail = True
                End Using
            End Using
        Catch ex As Exception
            ValidaEmail = False
            MessageBox.Show($"Não foi possível enviar o e-mail. {vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub EnviaCredenciais()
        Try
            Using Smtp As New SmtpClient
                Using Email As New MailMessage
                    'SERVIDOR SMTP
                    Smtp.Host = My.Settings.SMTP_Servidor
                    Smtp.Credentials = New NetworkCredential(My.Settings.SMTP_Usuario, clCifer.Decriptar(My.Settings.SMTP_Senha, clCifer.senha))
                    Smtp.Port = My.Settings.SMTP_Porta
                    Smtp.EnableSsl = My.Settings.SMTP_SSL

                    'EMAIL (MENSAGEM)
                    Email.From = New MailAddress("contato@gscodebrasil.com.br")
                    Email.To.Add(ToEmail)

                    'EMAIL.CC.Add()
                    Email.Priority = MailPriority.High
                    Email.Subject = $"Informações de acesso ao sistema GSCode Brasil"
                    Email.IsBodyHtml = True
                    'email.Body =

                    'EMAIL BODY HTML
                    Html = AlternateView.CreateAlternateViewFromString($"
                    <center><b><font size='4' color='DimGray'>Informações de acesso</font></b><br><br>
                    <b><font color='Gray'>Usuário:</b> {ToEmail}<br>
                    <b>Senha:</b> {clCifer.Decriptar(YourSenha, clCifer.senha)}<br>
                    <b>Token:</b> {Token}<br><br><br>
                    <center><img src='cid:imagem'><br><br>
                    Caso não tenha solicitado essa informação, por favor desconsiderar o e-mail.</font><br><br>
                    Este é um e-mail automático, por favor não responda.", Nothing, "text/html")
                    LogoCredenciais.ContentId = "imagem"
                    Html.LinkedResources.Add(LogoCredenciais)
                    Email.AlternateViews.Add(Html)
                    Smtp.Send(Email)
                    ValidaEmail = True
                End Using
            End Using
        Catch ex As Exception
            ValidaEmail = False
            MessageBox.Show($"Não foi possível enviar o e-mail. {vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CreateUser()
        Try
            Token = NewGuid.ToString.ToUpper()

            Using Smtp As New SmtpClient
                Using Email As New MailMessage
                    'SERVIDOR SMTP
                    Smtp.Host = My.Settings.SMTP_Servidor
                    Smtp.Credentials = New NetworkCredential(My.Settings.SMTP_Usuario, clCifer.Decriptar(My.Settings.SMTP_Senha, clCifer.senha))
                    Smtp.Port = My.Settings.SMTP_Porta
                    Smtp.EnableSsl = My.Settings.SMTP_SSL

                    'EMAIL (MENSAGEM)
                    Email.From = New MailAddress("contato@gscodebrasil.com.br")
                    Email.To.Add(ToEmail)

                    'EMAIL.CC.Add()
                    Email.Priority = MailPriority.High
                    Email.Subject = $"Informações de acesso ao sistema GSCode Brasil"
                    Email.IsBodyHtml = True
                    'email.Body =

                    'EMAIL BODY HTML
                    Html = AlternateView.CreateAlternateViewFromString($"
                    <center><b><font size='4' color='DimGray'>Informações de acesso</font></b><br><br>
                    <b>Usuário:</b> {ToEmail}<br>
                    <b>Senha:</b> {YourSenha}<br>
                    <b>Token:</b> {Token}<br><br>
                    <b>Importante:</b> Para acessar os módulos é necessário solicitar ao administrador as devidas liberações na sua chave key.<br><br><br>
                    <center><img src='cid:imagem'><br><br>
                    Caso não tenha solicitado essa informação, por favor desconsiderar o e-mail.</font><br><br>
                    Este é um e-mail automático, por favor não responda.", Nothing, "text/html")
                    LogoCredenciais.ContentId = "imagem"
                    Html.LinkedResources.Add(LogoCredenciais)
                    Email.AlternateViews.Add(Html)
                    Smtp.Send(Email)
                    ValidaEmail = True
                End Using
            End Using
        Catch ex As Exception
            ValidaEmail = False
            ToEmail = Nothing
            YourSenha = Nothing
            FrmLogin.TimerCadastro.Enabled = False
            FrmLogin.pbChklistAviso.Visible = True
            FrmLogin.lblChklistAviso.Visible = True
            FrmLogin.btnChklistVoltar.Visible = True
            FrmLogin.btnChklistFinalizar.Visible = True
            MessageBox.Show($"Não foi possível enviar o e-mail. {vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
