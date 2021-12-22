Imports System.Net
Imports System.Net.Mail
Imports System.Guid

Public Class Email

#Region "Ref. de classes"
    Private ReadOnly ClCifer As New Cifer
    Private ReadOnly ClOS_Helpdesk As New OS_Helpdesk

    Public Property id_interno As String
    Public Property nome_oc As String
    Public Property email_oc As String
    Public Property data_oc As String
    Public Property cpf_cnpj As String
    Public Property name As String
    Public Property genero As String
    Public Property email_cont As String
    Public Property contato_oc As String
    Public Property telefone_principal As String
    Public Property telefone_secundario As String
    Public Property celular As String
    Public Property cep As String
    Public Property endereco As String
    Public Property complemento As String
    Public Property cidade As String
    Public Property uf As String
    Public Property prioridade As String
    Public Property equipamento As String
    Public Property nserie As String
    Public Property ocorrencia As String
    Public Property condicao As String
    Public Property nome_res As String
    Public Property email_res As String
    Public Property data_res As String
    Public Property resultado As String
    Public Property contato_res As String
    Public Property tempo_conexao As String
    Public Property status As String
    Public Property data_os As Date
    Public Property faturamento As String

    Public Property info_res As String
    Public Property Color As String
    Public Property ColorStatus As String
    Public Property Token As String
    Public Property ToEmail As String
    Public Property YourSenha As String
    Public Property CodRdf_Email As String
#End Region

#Region "Ref. Local"

    'Public Token As String
    'Public ToEmail As String
    'Public YourSenha As String
    Public ValidaEmail As Boolean
    Private Html As AlternateView
    Public Pass = ""

    Private ReadOnly LogoCredenciais As New LinkedResource($"{Application.StartupPath}\images\info_usuario.png")
    Private ReadOnly LogoCodRdfEmail As New LinkedResource($"{Application.StartupPath}\images\cod_rdf_email.png")
    Private ReadOnly LogoEmailTeste As New LinkedResource($"{Application.StartupPath}\images\auth_smtp.png")
    Private ReadOnly LogoValidaEmail As New LinkedResource($"{Application.StartupPath}\images\valida_email.png")

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
                    Email.Priority = MailPriority.Normal
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
            MessageBox.Show($"Não foi possível enviar o e-mail, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub

    Public Sub NewOS_Helpdesk()
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
                    Email.Priority = MailPriority.Normal
                    Email.Subject = "Nova OS - GScode Brasil"
                    Email.IsBodyHtml = True
                    Html = AlternateView.CreateAlternateViewFromString($"
                    <center><b><font color='Gray'>{nome_oc}</b><br>
                    {email_oc}<br>
                    {data_oc}</font><br><br><br><br><br>
                    <b><font size='4' color='DimGray'>OS - {id_interno}</font></b><br><br>
                    <b><font color='Gray'>Nome</b>: {name}<br>
                    <b>CNPJ/CPF</b>: {cpf_cnpj}<br>
                    <b>E-mail</b>: {email_cont}<br>
                    <b>Telefone principal</b>: {telefone_principal}<br>
                    <b>Telefone secundario</b>: {telefone_secundario}<br>
                    <b>Celular</b>: {celular}<br>
                    <b>Contato</b>: {contato_oc}<br>
                    <b>Endereço</b>: {endereco}, {complemento}, {cidade}, {uf}, {cep}<br><br>                    
                    <b>Condição</b>: {condicao}<br>
                    <b>Prioridade</b>:</font> <font color='{Color}'> {prioridade}</font><br>
                    <b>Equipamento</b>: {equipamento} - <b>Nº de Série</b>: {nserie}<br><br>
                    <b>Ocorrência</b>:<br>
                    {ocorrencia}", Nothing, "text/html")
                    Email.AlternateViews.Add(Html)
                    Smtp.Send(Email)
                    ValidaEmail = True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Não foi possível enviar o e-mail, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub

    Public Sub ResultadoOS_Helpdesk()
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
                    Email.Priority = MailPriority.Normal
                    Email.Subject = "Baixa de OS - GScode Brasil"
                    Email.IsBodyHtml = True
                    Html = AlternateView.CreateAlternateViewFromString($"
                    <center><b><font color='Gray'>{nome_oc}</b><br>
                    {email_oc}<br>
                    {data_oc}</font><br><br><br><br><br>
                    <b><font size='4' color='DimGray'>OS - {id_interno}</font></b><br><br>
                    <b><font color='Gray'>Nome</b>: {name}<br>
                    <b>CNPJ/CPF</b>: {cpf_cnpj}<br>
                    <b>E-mail</b>: {email_cont}<br>
                    <b>Telefone principal</b>: {telefone_principal}<br>
                    <b>Telefone secundario</b>: {telefone_secundario}<br>
                    <b>Celular</b>: {celular}<br>
                    <b>Contato</b>: {contato_oc}<br>
                    <b>Endereço</b>: {endereco}, {complemento}, {cidade}, {uf}, {cep}<br><br>                    
                    <b>Condição</b>: {condicao}<br>
                    <b>Prioridade</b>:</font> <font color='{Color}'>{prioridade}</font><br>
                    <b><font color='Gray'>Equipamento</b>: {equipamento} - <b>Nº de Série</b>: {nserie}<br><br>
                    <b>Ocorrência</b>:</font><br>
                    {ocorrencia}{faturamento}
                    <b><font size='4' color='MidnightBlue'>------------------------------ RESULTADO ------------------------------</font></b><br><br><br><br><br>
                    <b><font color='Gray'>{nome_res}</b><br>
                    {email_res}<br>
                    {data_res}<br><br><br><br>
                    <b>Contato</b>: {contato_res}<br>
                    <b>Status</b>:</font> <font color='{ColorStatus}'>{status}</font><br>
                    <b><font color='Gray'>Tempo de conexão</b>: {tempo_conexao}<br><br>
                    <b>Resultado</b>:<br>
                    {resultado}</font>", Nothing, "text/html")
                    Email.AlternateViews.Add(Html)
                    Smtp.Send(Email)
                    ValidaEmail = True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Não foi possível enviar o e-mail, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub

    Public Sub InformacoesOS_Helpdesk()
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
                    Email.Priority = MailPriority.Normal
                    Email.Subject = "Informações de OS - GScode Brasil"
                    Email.IsBodyHtml = True
                    Html = AlternateView.CreateAlternateViewFromString($"
                    <center><b><font color='Gray'>{nome_oc}</b><br>
                    {email_oc}<br>
                    {data_oc}</font><br><br><br><br><br>
                    <b><font size='4' color='DimGray'>OS - {id_interno}</font></b><br><br>
                    <b><font color='Gray'>Nome</b>: {name}<br>
                    <b>CNPJ/CPF</b>: {cpf_cnpj}<br>
                    <b>E-mail</b>: {email_cont}<br>
                    <b>Telefone principal</b>: {telefone_principal}<br>
                    <b>Telefone secundario</b>: {telefone_secundario}<br>
                    <b>Celular</b>: {celular}<br>
                    <b>Contato</b>: {contato_oc}<br>
                    <b>Endereço</b>: {endereco}, {complemento}, {cidade}, {uf}, {cep}<br><br>                    
                    <b>Condição</b>: {condicao}<br>
                    <b>Prioridade</b>:</font> <font color='{Color}'>{prioridade}</font><br>
                    <b><font color='Gray'><Equipamento</b>: {equipamento} - <b>Nº de Série</b>: {nserie}<br><br>
                    <b>Ocorrência</b>:<br>
                    {ocorrencia}</font>{info_res}", Nothing, "text/html")
                    Email.AlternateViews.Add(Html)
                    Smtp.Send(Email)
                    ValidaEmail = True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Não foi possível enviar o e-mail, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub

    Public Sub AlterarEmail()
        Try
            Using Smtp As New SmtpClient
                Using Email As New MailMessage
                    'SERVIDOR SMTP
                    Smtp.Host = My.Settings.SMTP_Servidor
                    Smtp.Credentials = New NetworkCredential(My.Settings.SMTP_Usuario, ClCifer.Decriptar(My.Settings.SMTP_Senha, ClCifer.senha))
                    Smtp.Port = My.Settings.SMTP_Porta
                    Smtp.EnableSsl = My.Settings.SMTP_SSL

                    'EMAIL (MENSAGEM)
                    Email.From = New MailAddress("contato@gscodebrasil.com.br")
                    Email.To.Add(ToEmail)
                    'email.CC.Add()
                    Email.Priority = MailPriority.Normal
                    Email.Subject = "Alteração de e-mail - GScode Brasil"
                    Email.IsBodyHtml = True
                    'email.Body =
                    Html = AlternateView.CreateAlternateViewFromString($"
                    <center><b><font size='4' color='DimGray'>Informações para alteração de e-mail</font></b><br><br>
                    <b><font color='Gray'>Código:</b> {CodRdf_Email}<br><br><br>
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
            MessageBox.Show($"Não foi possível enviar o e-mail, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
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
                    Email.Priority = MailPriority.Normal
                    Email.Subject = $"Informações de acesso ao sistema - GSCode Brasil"
                    Email.IsBodyHtml = True
                    'email.Body =

                    'EMAIL BODY HTML
                    Html = AlternateView.CreateAlternateViewFromString($"
                    <center><b><font size='4' color='DimGray'>Informações de acesso</font></b><br><br>
                    <b><font color='Gray'>Usuário</b>: {ToEmail}<br>
                    <b>Senha</b>: {YourSenha}<br>
                    <b>Token</b>: {Token}<br><br><br>
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
            MessageBox.Show($"Não foi possível enviar o e-mail, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub

    Public Sub ValidarEmail()
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
                    Email.Priority = MailPriority.Normal
                    Email.Subject = $"Validação de E-mail - GSCode Brasil"
                    Email.IsBodyHtml = True
                    'email.Body =

                    'EMAIL BODY HTML
                    Html = AlternateView.CreateAlternateViewFromString($"
                    <center><b><font size='4' color='DimGray'>Informações para validação de e-mail</font></b><br><br>
                    <b><font color='Gray'>{Token}</b><br><br><br>
                    <center><img src='cid:imagem'><br><br>
                    Caso não tenha solicitado essa informação, por favor desconsiderar o e-mail.</font><br><br>
                    Este é um e-mail automático, por favor não responda.", Nothing, "text/html")
                    LogoValidaEmail.ContentId = "imagem"
                    Html.LinkedResources.Add(LogoValidaEmail)
                    Email.AlternateViews.Add(Html)
                    Smtp.Send(Email)
                    ValidaEmail = True
                    Smtp.Dispose()
                    Email.Dispose()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Não foi possível enviar o e-mail, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub
End Class
