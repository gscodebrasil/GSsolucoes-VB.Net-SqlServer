Imports Guna.UI2.WinForms

Public Class FrmPrincipal

#Region "Ref. Local"

    Private CurrentFrm As Form
    Public Cad_Cons As Integer
    Public TabSelect As String

#End Region

#Region "Subs/Functions"

#Region "Gerais"

    'INCLUSAO DE UM FORM NO PAINEL PRINCIPAL
    Public Sub FormShow(Frm As Form)
        ActiveFormClose()
        CurrentFrm = Frm
        Frm.TopLevel = False
        Frm.FormBorderStyle = FormBorderStyle.None
        Frm.Dock = DockStyle.Fill
        PanelForms.Controls.Add(Frm)
        PanelForms.Tag = Frm
        Frm.BringToFront()
        Frm.Show()
    End Sub

    'FECHA FORM ATIVO DO PAINEL PRINCIPAL
    Public Sub ActiveFormClose()
        If CurrentFrm IsNot Nothing Then
            CurrentFrm.Close()
        End If
    End Sub

    'OCULTA SUBMENUS
    Private Sub HideSubMenu(Pnc As Guna2Panel, PncFlutuante As Guna2Panel)
        If TabControlMenu.Width >= 228 Then
            For Each Btn As Guna2GradientButton In Pnc.Controls
                Pnc.Visible = False
                Btn.Checked = False
            Next
        Else
            TimerSubMenuDeslizante.HideSync(PncFlutuante)
            For Each Btn As Guna2GradientButton In PncFlutuante.Controls
                Pnc.Visible = False
                Btn.Checked = False
            Next
        End If
    End Sub

    Private Sub UnCheckBtn_home()
        PanelConfig.Visible = False
        PanelSMConfig.Visible = False
        For Each Btn As Guna2GradientButton In New List(Of Guna2GradientButton) From {BtnAplication, BtnConfig, BtnLicencas, BtnAjuda, Btnsoftphone, BtnSMSoftphone, BtnSmtp, BtnSMSmtp, BtnBackup, BtnSMBackup, BtnArquivos, BtnSMArquivos, BtnUsuarios, BtnSMUsuarios}
            Btn.Checked = False
        Next
    End Sub

    Public Sub UnCheckBtn_Phonebook()
        For Each Btn As Guna2GradientButton In New List(Of Guna2GradientButton) From {BtnCadastros_Phonebook, BtnContatos, BtnLocalizacao}
            Btn.Checked = False
        Next
    End Sub

    Private Sub UnCheckBtn_Helpdesk()
        For Each Btn As Guna2GradientButton In New List(Of Guna2GradientButton) From {BtnAbrirOS_Helpdesk, BtnPainel_Helpdesk, BtnGerenciador_Helpdesk, BtnAgenda_Helpdesk, BtnRelatorio_Helpdesk}
            Btn.Checked = False
        Next
    End Sub

    'VERIFICA SE TEM SUB MENUS ATIVOS
    Private Sub FrmAtivo(Pnc As Guna2Panel, PncFlutuante As Guna2Panel)
        If TabControlMenu.Width >= 228 Then
            If Pnc.Visible = False Then
                Pnc.Visible = True
            Else
                For Each Btn As Guna2GradientButton In Pnc.Controls
                    If Btn.Checked = False Then
                        Pnc.Visible = False
                        Me.BtnConfig.Checked = False
                    Else
                        Pnc.Visible = False
                        Me.BtnConfig.Checked = True
                        Exit For
                    End If
                Next
            End If
        Else
            If PncFlutuante.Visible = False Then
                PncFlutuante.Location = New Point(55, 155)
                PncFlutuante.BringToFront()
                TimerSubMenuDeslizante.ShowSync(PncFlutuante)

            Else
                For Each Btn As Guna2GradientButton In PncFlutuante.Controls
                    If Btn.Checked = False Then
                        PncFlutuante.Location = New Point(55, 155)
                        TimerSubMenuDeslizante.HideSync(PncFlutuante)
                        Me.BtnConfig.Checked = False
                    Else
                        PncFlutuante.Location = New Point(55, 155)
                        TimerSubMenuDeslizante.HideSync(PncFlutuante)
                        Me.BtnConfig.Checked = True
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub MostraPanelAtivo()
        Select Case TabControlMenu.SelectedIndex

            Case 0 'Home
                MostraPainelLateral()

            Case 1 'Phonebook
                MostraPainelLateral_Phonebook()

            Case 2 'HelpDesk
                MostraPainelLateral_Helpdesk()

            Case 3 'Financeiro

            Case 4 'Dashboard


        End Select
    End Sub

    Public Sub MenuAbertoOuFechado(i As Integer)
        If TabControlMenu.Width >= 228 Then
            PanelAberto()
            BtnNomes()
            ActiveFormClose()
            TabControlMenu.SelectTab(i)
        Else
            PanelFechado()
            BtnNotNomes()
            ActiveFormClose()
            TabControlMenu.SelectTab(i)
        End If
    End Sub

#End Region

#Region "Home"

    'FECHA O PAINEL LATERAL
    Private Sub OcultaPainelLateral()
        PanelForms.Visible = False
        TabControlMenu.Visible = False
        PanelFechado()
        BtnNotNomes()
        TabControlMenu.Width = 55
        TimerSubMenuDeslizante.HideSync(PanelSMConfig)
        TimerMenuDeslizante.ShowSync(TabControlMenu)
        TimerPanelDeslizante.ShowSync(PanelForms)
    End Sub

    Private Sub PanelFechado()
        PanelSMConfig.Visible = False
        PanelPerfilLeft.Visible = False
        PanelLogoFull.Visible = False
        PanelConfig.Visible = False
        PanelPerfilTop.Visible = True
        PbLogoP.Visible = True
    End Sub

    'ABRE O PAINEL LATERAL
    Private Sub PanelAberto()
        PanelSMConfig.Visible = False
        PbLogoP.Visible = False
        PanelPerfilTop.Visible = False
        PanelPerfilLeft.Visible = True
        PanelLogoFull.Visible = True
        BtnPerfilLeft.Visible = True
    End Sub

    Private Sub MostraPainelLateral()
        PanelForms.Visible = False
        TabControlMenu.Visible = False
        PanelAberto()
        BtnNomes()
        VSubMenuAtivo()
        TabControlMenu.Width = 228
        TimerMenuDeslizante.ShowSync(TabControlMenu)
        TimerPanelDeslizante.ShowSync(PanelForms)
    End Sub

    'REMOVE OS NOMES DOS BOTÕES
    Private Sub BtnNotNomes()

        BtnAplication.Text = Nothing
        BtnConfig.Text = Nothing
        Btnsoftphone.Text = Nothing
        BtnSmtp.Text = Nothing
        BtnBackup.Text = Nothing
        BtnArquivos.Text = Nothing
        BtnUsuarios.Text = Nothing
        BtnLicencas.Text = Nothing
        BtnAjuda.Text = Nothing

        BtnAplication.ImageOffset = New Point(0, 0)
        BtnConfig.ImageOffset = New Point(0, 0)
        BtnLicencas.ImageOffset = New Point(0, 0)
        BtnAjuda.ImageOffset = New Point(0, 0)

    End Sub

    'INSERE OS NOMES DOS BOTÕES
    Private Sub BtnNomes()

        BtnAplication.Text = "Aplicações"
        BtnConfig.Text = "Configurações"
        Btnsoftphone.Text = "Softphone"
        BtnSmtp.Text = "SMTP"

        BtnBackup.Text = "Backup"
        BtnArquivos.Text = "Servidor de Arquivos"
        BtnUsuarios.Text = "Usuários"
        BtnLicencas.Text = "Licenças"
        BtnAjuda.Text = "Ajuda"

        BtnAplication.ImageOffset = New Point(10, 0)
        BtnConfig.ImageOffset = New Point(10, 0)
        BtnLicencas.ImageOffset = New Point(10, 0)
        BtnAjuda.ImageOffset = New Point(10, 0)

    End Sub

#End Region

#Region "Phonebook"

    'FECHA O PAINEL LATERAL HOME
    Private Sub OcultaPainelLateral_Phonebook()
        PanelForms.Visible = False
        TabControlMenu.Visible = False
        PanelFechado_Phonebook()
        BtnNotNomes_Phonebook()
        TabControlMenu.Width = 55
        TimerMenuDeslizante.ShowSync(TabControlMenu)
        TimerPanelDeslizante.ShowSync(PanelForms)
    End Sub

    Private Sub PanelFechado_Phonebook()
        PanelPerfilLeft_Phonebook.Visible = False
        PanelLogoFull_Phonebook.Visible = False
        PanelPerfilTop.Visible = True
        PbLogoP_Phonebook.Visible = True
    End Sub

    'ABRE O PAINEL LATERAL
    Private Sub PanelAberto_Phonebook()
        PanelPerfilTop.Visible = False
        PbLogoP_Phonebook.Visible = False
        PanelPerfilLeft_Phonebook.Visible = True
        PanelLogoFull_Phonebook.Visible = True
    End Sub

    Private Sub MostraPainelLateral_Phonebook()
        PanelForms.Visible = False
        TabControlMenu.Visible = False
        PanelAberto_Phonebook()
        BtnNomes_Phonebook()
        TabControlMenu.Width = 228
        TimerMenuDeslizante.ShowSync(TabControlMenu)
        TimerPanelDeslizante.ShowSync(PanelForms)
    End Sub

    'REMOVE OS NOMES DOS BOTÕES
    Private Sub BtnNotNomes_Phonebook()

        BtnCadastros_Phonebook.Text = Nothing
        BtnContatos.Text = Nothing
        BtnLocalizacao.Text = Nothing
        BtnHome_Phonebook.Text = Nothing

        BtnCadastros_Phonebook.ImageOffset = New Point(0, 0)
        BtnContatos.ImageOffset = New Point(0, 0)
        BtnLocalizacao.ImageOffset = New Point(0, 0)
        BtnHome_Phonebook.ImageOffset = New Point(0, 0)

    End Sub

    'INSERE OS NOMES DOS BOTÕES
    Private Sub BtnNomes_Phonebook()

        BtnCadastros_Phonebook.Text = "Cadastros"
        BtnContatos.Text = "Contatos"
        BtnLocalizacao.Text = "Localização"
        BtnHome_Phonebook.Text = "Home"

        BtnCadastros_Phonebook.ImageOffset = New Point(10, 0)
        BtnContatos.ImageOffset = New Point(10, 0)
        BtnLocalizacao.ImageOffset = New Point(10, 0)
        BtnHome_Phonebook.ImageOffset = New Point(10, 0)

    End Sub

#End Region

#Region "Helpdesk"

    'FECHA O PAINEL LATERAL HOME
    Private Sub OcultaPainelLateral_Helpdesk(i As Integer)
        PanelForms.Visible = False
        TabControlMenu.Visible = False
        PanelFechado_Helpdesk()
        BtnNotNomes_Helpdesk()
        TabControlMenu.Width = i
        TimerMenuDeslizante.ShowSync(TabControlMenu)
        TimerPanelDeslizante.ShowSync(PanelForms)
    End Sub

    Private Sub PanelFechado_Helpdesk()
        PanelPerfilLeft_Helpdesk.Visible = False
        PanelLogoFull_Helpdesk.Visible = False
        PanelPerfilTop.Visible = True
        PbLogoP_Helpdesk.Visible = True
    End Sub

    'ABRE O PAINEL LATERAL
    Private Sub PanelAberto_Helpdesk()
        PanelPerfilTop.Visible = False
        PbLogoP_Helpdesk.Visible = False
        PanelPerfilLeft_Helpdesk.Visible = True
        PanelLogoFull_Helpdesk.Visible = True
    End Sub

    Private Sub MostraPainelLateral_Helpdesk()
        PanelForms.Visible = False
        TabControlMenu.Visible = False
        PanelAberto_Helpdesk()
        BtnNomes_Helpdesk()
        TabControlMenu.Width = 228
        TimerMenuDeslizante.ShowSync(TabControlMenu)
        TimerPanelDeslizante.ShowSync(PanelForms)
    End Sub

    'REMOVE OS NOMES DOS BOTÕES
    Private Sub BtnNotNomes_Helpdesk()

        BtnAbrirOS_Helpdesk.Text = Nothing
        BtnPainel_Helpdesk.Text = Nothing
        BtnGerenciador_Helpdesk.Text = Nothing
        BtnAgenda_Helpdesk.Text = Nothing
        BtnRelatorio_Helpdesk.Text = Nothing
        BtnHome_Helpdesk.Text = Nothing

        BtnAbrirOS_Helpdesk.ImageOffset = New Point(0, 0)
        BtnPainel_Helpdesk.ImageOffset = New Point(0, 0)
        BtnGerenciador_Helpdesk.ImageOffset = New Point(0, 0)
        BtnAgenda_Helpdesk.ImageOffset = New Point(0, 0)
        BtnRelatorio_Helpdesk.ImageOffset = New Point(0, 0)
        BtnHome_Helpdesk.ImageOffset = New Point(0, 0)

    End Sub

    'INSERE OS NOMES DOS BOTÕES
    Private Sub BtnNomes_Helpdesk()

        BtnAbrirOS_Helpdesk.Text = "Abrir OS"
        BtnPainel_Helpdesk.Text = "Painel"
        BtnGerenciador_Helpdesk.Text = "Gerenciador"
        BtnAgenda_Helpdesk.Text = "Agenda"
        BtnRelatorio_Helpdesk.Text = "Relatório"
        BtnHome_Helpdesk.Text = "Home"

        BtnAbrirOS_Helpdesk.ImageOffset = New Point(10, 0)
        BtnPainel_Helpdesk.ImageOffset = New Point(10, 0)
        BtnGerenciador_Helpdesk.ImageOffset = New Point(10, 0)
        BtnAgenda_Helpdesk.ImageOffset = New Point(10, 0)
        BtnRelatorio_Helpdesk.ImageOffset = New Point(10, 0)
        BtnHome_Helpdesk.ImageOffset = New Point(10, 0)

    End Sub

#End Region

    Public Sub MenuAbertoOuFechado_Phonebook(i As Integer)
        If TabControlMenu.Width >= 228 Then
            PanelAberto_Phonebook()
            BtnNomes_Phonebook()
            ActiveFormClose()
            TabControlMenu.SelectTab(i)
        Else
            PanelFechado_Phonebook()
            BtnNotNomes_Phonebook()
            ActiveFormClose()
            TabControlMenu.SelectTab(i)
        End If
    End Sub

    Public Sub MenuAbertoOuFechado_Helpdesk(i As Integer)
        If TabControlMenu.Width >= 228 Then
            PanelAberto_Helpdesk()
            BtnNomes_Helpdesk()
            ActiveFormClose()
            TabControlMenu.SelectTab(i)
        Else
            PanelFechado_Helpdesk()
            BtnNotNomes_Helpdesk()
            ActiveFormClose()
            TabControlMenu.SelectTab(i)
        End If
    End Sub

#End Region

    'MAXIMIZA O FORM SEM COBRIR A BARRA DO WINDOWS
    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PanelMenu.VerticalScroll.Visible = False
        TabControlMenu.TabMenuVisible = False
    End Sub

    Private Sub BtnAplication_Click(sender As Object, e As EventArgs) Handles BtnAplication.Click
        If Application.OpenForms.OfType(Of FrmAplicacoes)().Count = 0 Then
            HideSubMenu(PanelConfig, PanelSMConfig)
            FormShow(New FrmAplicacoes())
        End If
    End Sub

    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles BtnConfig.Click
        FrmAtivo(PanelConfig, PanelSMConfig)
        'ActiveFormClose()
    End Sub

    Private Function VSubMenuAtivo()
        For Each Btn As Guna2GradientButton In PanelSMConfig.Controls
            If Btn.Checked Then
                PanelConfig.Visible = True
            End If
            Exit For
        Next
        Return True
    End Function

    Private Sub Btnsoftphone_Click(sender As Object, e As EventArgs) Handles Btnsoftphone.Click
        If Application.OpenForms.OfType(Of FrmSoftphone)().Count = 0 Then
            BtnSMSoftphone.Checked = True
            FormShow(New FrmSoftphone())
        End If
    End Sub

    Private Sub BtnSmtp_Click(sender As Object, e As EventArgs) Handles BtnSmtp.Click
        If Application.OpenForms.OfType(Of FrmSMTP)().Count = 0 Then
            BtnSMSmtp.Checked = True
            FormShow(New FrmSMTP())
        End If
    End Sub

    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles BtnBackup.Click
        If Application.OpenForms.OfType(Of FrmBackup)().Count = 0 Then
            BtnSMBackup.Checked = True
            FormShow(New FrmCarregar)
            FrmCarregar.TimerBackup.Start()
        End If
    End Sub

    Private Sub BtnArquivos_Click(sender As Object, e As EventArgs) Handles BtnArquivos.Click
        If Application.OpenForms.OfType(Of FrmArquivos)().Count = 0 Then
            BtnSMArquivos.Checked = True
            FormShow(New FrmCarregar)
            FrmCarregar.TimerArquivos.Start()
        End If
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        If Application.OpenForms.OfType(Of FrmUsers)().Count = 0 Then
            BtnSMUsuarios.Checked = True
            FormShow(New FrmCarregar)
            FrmCarregar.TimerFrmUsers.Start()
        End If
    End Sub

    Private Sub BtnSMSoftphone_Click(sender As Object, e As EventArgs) Handles BtnSMSoftphone.Click
        TimerSubMenuDeslizante.HideSync(PanelSMConfig)
        If Application.OpenForms.OfType(Of FrmSoftphone)().Count = 0 Then
            Btnsoftphone.Checked = True
            FormShow(New FrmSoftphone())
        End If
    End Sub

    Private Sub BtnSMSmtp_Click(sender As Object, e As EventArgs) Handles BtnSMSmtp.Click
        TimerSubMenuDeslizante.HideSync(PanelSMConfig)
        If Application.OpenForms.OfType(Of FrmSMTP)().Count = 0 Then
            BtnSmtp.Checked = True
            FormShow(New FrmSMTP())
        End If
    End Sub

    Private Sub BtnSMBackup_Click(sender As Object, e As EventArgs) Handles BtnSMBackup.Click
        TimerSubMenuDeslizante.HideSync(PanelSMConfig)
        If Application.OpenForms.OfType(Of FrmBackup)().Count = 0 Then
            BtnBackup.Checked = True
            FormShow(New FrmCarregar)
            FrmCarregar.TimerBackup.Start()
        End If
    End Sub

    Private Sub BtnSMArquivos_Click(sender As Object, e As EventArgs) Handles BtnSMArquivos.Click
        TimerSubMenuDeslizante.HideSync(PanelSMConfig)
        If Application.OpenForms.OfType(Of FrmArquivos)().Count = 0 Then
            BtnArquivos.Checked = True
            FormShow(New FrmCarregar)
            FrmCarregar.TimerArquivos.Start()
        End If
    End Sub

    Private Sub BtnSMUsuarios_Click(sender As Object, e As EventArgs) Handles BtnSMUsuarios.Click
        TimerSubMenuDeslizante.HideSync(PanelSMConfig)
        If Application.OpenForms.OfType(Of FrmUsers)().Count = 0 Then
            BtnUsuarios.Checked = True
            FormShow(New FrmCarregar)
            FrmCarregar.TimerFrmUsers.Start()
        End If
    End Sub

    Private Sub BtnLicencas_Click(sender As Object, e As EventArgs) Handles BtnLicencas.Click
        If Application.OpenForms.OfType(Of FrmArquivos)().Count = 0 Then
            HideSubMenu(PanelConfig, PanelSMConfig)
            ActiveFormClose()
        End If
    End Sub

    Private Sub BtnAjuda_Click(sender As Object, e As EventArgs) Handles BtnAjuda.Click
        If Application.OpenForms.OfType(Of FrmArquivos)().Count = 0 Then
            HideSubMenu(PanelConfig, PanelSMConfig)
            ActiveFormClose()
        End If
    End Sub

    Private Sub BtnPanelDeslizanteLeft_Click(sender As Object, e As EventArgs) Handles BtnPanelDeslizanteLeft.Click
        OcultaPainelLateral()
    End Sub

    Private Sub BtnPanelDeslizanteTop_Click(sender As Object, e As EventArgs) Handles BtnPanelDeslizanteTop.Click
        MostraPanelAtivo()
    End Sub

    Private Sub BtnPerfilLeft_Click(sender As Object, e As EventArgs) Handles BtnPerfilLeft.click
        If Application.OpenForms.OfType(Of FrmUserConfig)().Count = 0 Then
            FormShow(New FrmUserConfig())
            UnCheckBtn_home()
        End If
    End Sub

    Private Sub PbPerfilTop_Click(sender As Object, e As EventArgs) Handles PbPerfilTop.Click
        If Application.OpenForms.OfType(Of FrmUserConfig)().Count = 0 Then
            HideSubMenu(PanelConfig, PanelSMConfig)
            FormShow(New FrmUserConfig())
        End If
    End Sub

    Private Sub FrmGSSolucoesHome_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmLogin.Show()
    End Sub

    Private Sub BtnCadastros_Phonebook_Click(sender As Object, e As EventArgs) Handles BtnCadastros_Phonebook.Click
        If Cad_Cons = 0 OrElse Cad_Cons = 1 Then
            Cad_Cons = 2
            BtnSMUsuarios.Checked = True
            FormShow(New FrmCarregar)
            FrmCarregar.TimerPhonebook.Start()
        End If
    End Sub

    Private Sub BtnContatos_Click(sender As Object, e As EventArgs) Handles BtnContatos.Click
        If Cad_Cons = 0 OrElse Cad_Cons = 2 Then
            Cad_Cons = 1
            BtnSMUsuarios.Checked = True
            FormShow(New FrmCarregar)
            FrmCarregar.TimerPhonebook.Start()
        End If
    End Sub

    Private Sub BtnLocalizacao_Click(sender As Object, e As EventArgs) Handles BtnLocalizacao.Click
        If Application.OpenForms.OfType(Of FrmUserConfig)().Count = 0 Then
            ActiveFormClose()
        End If
    End Sub

    Private Sub BtnHome_Phonebook_Click(sender As Object, e As EventArgs) Handles BtnHome_Phonebook.Click
        Me.BtnHome_Phonebook.Checked = False
        BtnAplication.Checked = False
        MenuAbertoOuFechado(0)
    End Sub

    Private Sub BtnPanelDeslizanteLeft_Phonebook_Click(sender As Object, e As EventArgs) Handles BtnPanelDeslizanteLeft_Phonebook.Click
        OcultaPainelLateral_Phonebook()
    End Sub


    Private Sub BtnPerfilLeft_Phonebook_Click(sender As Object, e As EventArgs) Handles BtnPerfilLeft_Phonebook.Click
        If Application.OpenForms.OfType(Of FrmUserConfig)().Count = 0 Then
            FormShow(New FrmUserConfig())
            UnCheckBtn_Phonebook()
        End If
    End Sub

    Private Sub BtnYoutube_Phonebook_Click(sender As Object, e As EventArgs) Handles BtnYoutube_Phonebook.Click

    End Sub

    Private Sub BtnFacebook_Phonebook_Click(sender As Object, e As EventArgs) Handles BtnFacebook_Phonebook.Click

    End Sub

    Private Sub BtnInstagram_Phonebook_Click(sender As Object, e As EventArgs) Handles BtnInstagram_Phonebook.Click

    End Sub

    Private Sub BtnAbrirOS_Helpdesk_Click(sender As Object, e As EventArgs) Handles BtnAbrirOS_Helpdesk.Click
        If TabSelect <> Me.BtnAbrirOS_Helpdesk.Text Then
            TabSelect = Me.BtnAbrirOS_Helpdesk.Text
            FormShow(New FrmCarregar())
            FrmCarregar.TimerHelpdesk.Start()
        End If
    End Sub

    Private Sub BtnPainel_Helpdesk_Click(sender As Object, e As EventArgs) Handles BtnPainel_Helpdesk.Click
        If TabSelect <> Me.BtnPainel_Helpdesk.Text Then
            TabSelect = Me.BtnPainel_Helpdesk.Text
            FormShow(New FrmCarregar())
            FrmCarregar.TimerHelpdesk.Start()
        End If
    End Sub

    Private Sub BtnGerenciador_Helpdesk_Click(sender As Object, e As EventArgs) Handles BtnGerenciador_Helpdesk.Click
        If TabSelect <> Me.BtnGerenciador_Helpdesk.Text Then
            TabSelect = Me.BtnGerenciador_Helpdesk.Text
            FormShow(New FrmCarregar())
            FrmCarregar.TimerHelpdesk.Start()
        End If
    End Sub

    Private Sub BtnAgenda_Helpdesk_Click(sender As Object, e As EventArgs) Handles BtnAgenda_Helpdesk.Click
        If Application.OpenForms.OfType(Of FrmUserConfig)().Count = 0 Then
            ActiveFormClose()
        End If
    End Sub

    Private Sub BtnRelatorio_Helpdesk_Click(sender As Object, e As EventArgs) Handles BtnRelatorio_Helpdesk.Click
        If Application.OpenForms.OfType(Of FrmUserConfig)().Count = 0 Then
            ActiveFormClose()
        End If
    End Sub

    Private Sub BtnHome_Helpdesk_Click(sender As Object, e As EventArgs) Handles BtnHome_Helpdesk.Click
        Me.BtnHome_Helpdesk.Checked = False
        BtnAplication.Checked = False
        MenuAbertoOuFechado(0)
    End Sub

    Private Sub BtnPanelDeslizanteLeft_Helpdesk_Click(sender As Object, e As EventArgs) Handles BtnPanelDeslizanteLeft_Helpdesk.Click
        If TabSelect = "Painel" Then
            OcultaPainelLateral_Helpdesk(0)
        Else
            OcultaPainelLateral_Helpdesk(55)
        End If
    End Sub

    Private Sub BtnPerfilTop_Click(sender As Object, e As EventArgs) Handles BtnPerfilTop.Click
        If Application.OpenForms.OfType(Of FrmUserConfig)().Count = 0 Then
            FormShow(New FrmUserConfig())
            UnCheckBtn_home()
        End If
    End Sub

    Private Sub BtnPerfilLeft_Helpdesk_Click(sender As Object, e As EventArgs) Handles BtnPerfilLeft_Helpdesk.Click
        If Application.OpenForms.OfType(Of FrmUserConfig)().Count = 0 Then
            FormShow(New FrmUserConfig())
            UnCheckBtn_Helpdesk()
        End If
    End Sub
End Class