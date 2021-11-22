Imports Guna.UI2.WinForms

Public Class FrmPrincipal

#Region "Ref. Local"

    Private CurrentFrm As Form
    Public Cad_Cons As Integer = 0

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
        For Each Btn As Guna2GradientButton In Pnc.Controls
            Btn.Checked = False
            Pnc.Visible = False
            TimerSubMenuDeslizante.HideSync(PncFlutuante)
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

            Case 3 'Financeiro

            Case 4 'Dashboard


        End Select
    End Sub

#End Region

#Region "Home"

    'FECHA O PAINEL LATERAL
    Private Sub OcultaPainelLateral()
        PanelFechado()
        HideSubMenu(PanelConfig, PanelSMConfig)
        BtnNotNomes()
        TabControlMenu.Width = 55
        TimerMenuDeslizante.ShowSync(TabControlMenu)
        TimerPanelDeslizante.ShowSync(PanelForms)
    End Sub

    Private Sub PanelFechado()
        PanelForms.Visible = False
        PanelSMConfig.Visible = False
        TabControlMenu.Visible = False
        PanelPerfilLeft.Visible = False
        PanelLogoFull.Visible = False
        PanelPerfilTop.Visible = True
        PbLogoP.Visible = True
    End Sub

    'ABRE O PAINEL LATERAL
    Private Sub PanelAberto()
        BtnPerfilLeft.Visible = False
        PanelForms.Visible = False
        PanelPerfilTop.Visible = False
        PanelSMConfig.Visible = False
        TabControlMenu.Visible = False
        PbLogoP.Visible = False
        PanelPerfilLeft.Visible = True
        PanelLogoFull.Visible = True
        BtnPerfilLeft.Visible = True
    End Sub

    Private Sub MostraPainelLateral()
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

    Public Sub MenuAbertoOuFechado(i As Integer)
        If TabControlMenu.Width >= 228 Then
            PanelAberto()
            BtnNomes()
            ActiveFormClose()
            TabControlMenu.SelectTab(i)
            AppTransition.ShowSync(TabControlMenu)
            PanelForms.Visible = True
        Else
            PanelFechado()
            BtnNotNomes()
            ActiveFormClose()
            TabControlMenu.SelectTab(i)
            AppTransition.ShowSync(TabControlMenu)
            PanelForms.Visible = True
        End If
    End Sub


    'FECHA O PAINEL LATERAL HOME
    Private Sub OcultaPainelLateral_Phonebook()
        PanelFechado_Phonebook()
        BtnNotNomes_Phonebook()
        TabControlMenu.Width = 55
        TimerMenuDeslizante.ShowSync(TabControlMenu)
        TimerPanelDeslizante.ShowSync(PanelForms)
    End Sub

    Private Sub PanelFechado_Phonebook()
        PanelForms.Visible = False
        TabControlMenu.Visible = False
        PanelPerfilLeft_Phonebook.Visible = False
        PanelLogoFull_Phonebook.Visible = False
        PanelPerfilTop.Visible = True
        PbLogoP_Phonebook.Visible = True
    End Sub

    'ABRE O PAINEL LATERAL
    Private Sub PanelAberto_Phonebook()
        BtnPerfilLeft_Phonebook.Visible = False
        PanelForms.Visible = False
        PanelPerfilTop.Visible = False
        TabControlMenu.Visible = False
        PbLogoP_Phonebook.Visible = False
        PanelPerfilLeft_Phonebook.Visible = True
        PanelLogoFull_Phonebook.Visible = True
        BtnPerfilLeft_Phonebook.Visible = True
    End Sub

    Private Sub MostraPainelLateral_Phonebook()
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

#End Region








    'MAXIMIZA O FORM SEM COBRIR A BARRA DO WINDOWS
    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PanelMenu.VerticalScroll.Visible = False
    End Sub

    Private Sub BtnAplication_Click(sender As Object, e As EventArgs) Handles BtnAplication.Click
        If Application.OpenForms.OfType(Of FrmAplicacoes)().Count = 0 Then
            HideSubMenu(PanelConfig, PanelSMConfig)
            FormShow(New FrmAplicacoes())
        End If
    End Sub

    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles BtnConfig.Click
        FrmAtivo(PanelConfig, PanelSMConfig)
        ActiveFormClose()
    End Sub

    Private Function VSubMenuAtivo()
        For Each Btn As Guna2GradientButton In PanelSMConfig.Controls
            If Btn.Checked Then
                PanelConfig.Visible = True
            End If
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
        If Application.OpenForms.OfType(Of FrmUsers)().Count = 0 Then
            Btnsoftphone.Checked = True
            FormShow(New FrmUsers())
        End If
    End Sub

    Private Sub BtnSMSmtp_Click(sender As Object, e As EventArgs) Handles BtnSMSmtp.Click
        TimerSubMenuDeslizante.HideSync(PanelSMConfig)
        If Application.OpenForms.OfType(Of FrmUsers)().Count = 0 Then
            BtnSmtp.Checked = True
            FormShow(New FrmUsers())
        End If
    End Sub

    Private Sub BtnSMBackup_Click(sender As Object, e As EventArgs) Handles BtnSMBackup.Click
        TimerSubMenuDeslizante.HideSync(PanelSMConfig)
        If Application.OpenForms.OfType(Of FrmUsers)().Count = 0 Then
            BtnBackup.Checked = True
            FormShow(New FrmUsers())
        End If
    End Sub

    Private Sub BtnSMArquivos_Click(sender As Object, e As EventArgs) Handles BtnSMArquivos.Click
        TimerSubMenuDeslizante.HideSync(PanelSMConfig)
        If Application.OpenForms.OfType(Of FrmUsers)().Count = 0 Then
            BtnArquivos.Checked = True
            FormShow(New FrmUsers())
        End If
    End Sub

    Private Sub BtnSMUsuarios_Click(sender As Object, e As EventArgs) Handles BtnSMUsuarios.Click
        TimerSubMenuDeslizante.HideSync(PanelSMConfig)
        If Application.OpenForms.OfType(Of FrmUsers)().Count = 0 Then
            Btnsoftphone.Checked = True
            FormShow(New FrmUsers())
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

    Private Sub BtnPerfilLeft_Click(sender As Object, e As EventArgs) Handles BtnPerfilLeft.Click
        If Application.OpenForms.OfType(Of FrmUserConfig)().Count = 0 Then
            HideSubMenu(PanelConfig, PanelSMConfig)
            FormShow(New FrmUserConfig())
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
            FrmCarregar.TimerCadastros_Phonebook.Start()
        End If
    End Sub

    Private Sub BtnContatos_Click(sender As Object, e As EventArgs) Handles BtnContatos.Click
        If Cad_Cons = 0 OrElse Cad_Cons = 2 Then
            Cad_Cons = 1
            BtnSMUsuarios.Checked = True
            FormShow(New FrmCarregar)
            FrmCarregar.TimerCadastros_Phonebook.Start()
        End If
    End Sub

    Private Sub BtnLocalizacao_Click(sender As Object, e As EventArgs) Handles BtnLocalizacao.Click

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

    End Sub

    Private Sub BtnNotLeft_Phonebook_Click(sender As Object, e As EventArgs) Handles BtnNotLeft_Phonebook.Click

    End Sub

    Private Sub BtnYoutube_Phonebook_Click(sender As Object, e As EventArgs) Handles BtnYoutube_Phonebook.Click

    End Sub

    Private Sub BtnFacebook_Phonebook_Click(sender As Object, e As EventArgs) Handles BtnFacebook_Phonebook.Click

    End Sub

    Private Sub BtnInstagram_Phonebook_Click(sender As Object, e As EventArgs) Handles BtnInstagram_Phonebook.Click

    End Sub
End Class