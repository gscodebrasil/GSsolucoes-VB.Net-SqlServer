<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    <Obsolete>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PanelBarraSup = New System.Windows.Forms.Panel()
        Me.btnYoutube = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnFacebook = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnInstagram = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnAcessoBD = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnMinimizar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnMaximizar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.drag = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.lblProfile = New System.Windows.Forms.Label()
        Me.lblBusiness = New System.Windows.Forms.Label()
        Me.lblPermissao = New System.Windows.Forms.Label()
        Me.lblAcesso = New System.Windows.Forms.Label()
        Me.lblChecklist = New System.Windows.Forms.Label()
        Me.PanelEtapa = New System.Windows.Forms.Panel()
        Me.pbTopBusiness = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbTopProfile = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbAcesso = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.bs1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.bs2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.bs3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.bs6 = New Guna.UI2.WinForms.Guna2Separator()
        Me.bs8 = New Guna.UI2.WinForms.Guna2Separator()
        Me.bs7 = New Guna.UI2.WinForms.Guna2Separator()
        Me.bs5 = New Guna.UI2.WinForms.Guna2Separator()
        Me.bs4 = New Guna.UI2.WinForms.Guna2Separator()
        Me.pbProfile = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.pbBusiness = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.pbPermissao = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.pbChecklist = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.imgLogin = New System.Windows.Forms.ImageList(Me.components)
        Me.imgLogin1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TimerUserInvalido = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAutoLogin = New System.Windows.Forms.Timer(Me.components)
        Me.TimerEditarBD = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRdf = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRdfSenha = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCadastro = New System.Windows.Forms.Timer(Me.components)
        Me.bpCadUser = New Guna.UI2.WinForms.Guna2TabControl()
        Me.tpUserLogin = New System.Windows.Forms.TabPage()
        Me.lblLoginRdf = New System.Windows.Forms.Label()
        Me.chkLembrarAcesso = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.lblAutoLogin = New System.Windows.Forms.Label()
        Me.lblLembrarAcesso = New System.Windows.Forms.Label()
        Me.chkAutoLogin = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.lblInvalido = New System.Windows.Forms.Label()
        Me.lblCapsLook = New System.Windows.Forms.Label()
        Me.lblLoginPass = New System.Windows.Forms.Label()
        Me.lblLoginEmail = New System.Windows.Forms.Label()
        Me.btnAddUser = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtLoginEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLoginPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.tpAcesso = New System.Windows.Forms.TabPage()
        Me.lblCadEmail = New System.Windows.Forms.Label()
        Me.lblCadCapsLook = New System.Windows.Forms.Label()
        Me.lblAcessoConfPass = New System.Windows.Forms.Label()
        Me.lblAcessoPass = New System.Windows.Forms.Label()
        Me.lblAcessoEmail = New System.Windows.Forms.Label()
        Me.btnAvAcesso = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnVoltAcesso = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtCadEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCadPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCadConfPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tpPerfil = New System.Windows.Forms.TabPage()
        Me.pbWhats = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbEmail = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbTermos = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblPerfilUF = New System.Windows.Forms.Label()
        Me.lblPerfilCidade = New System.Windows.Forms.Label()
        Me.lblPerfilComplemento = New System.Windows.Forms.Label()
        Me.lblPerfilCelular = New System.Windows.Forms.Label()
        Me.lblPerfilGenero = New System.Windows.Forms.Label()
        Me.lblPerfilEndereco = New System.Windows.Forms.Label()
        Me.lblPerfilCep = New System.Windows.Forms.Label()
        Me.lblPerfilNascimento = New System.Windows.Forms.Label()
        Me.lblPerfilNome = New System.Windows.Forms.Label()
        Me.txtPerfilNascimento = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAvPerfil = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnVoltPerfil = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblPerfilEmail = New System.Windows.Forms.Label()
        Me.lblPerfilTermos = New System.Windows.Forms.LinkLabel()
        Me.lblPerfilAceptTermos = New System.Windows.Forms.Label()
        Me.lblPerfilWhats = New System.Windows.Forms.Label()
        Me.txtPerfilNome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPerfilCelular = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPerfilEndereco = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPerfilCep = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPerfilComp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPerfilCidade = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chkPerfilWhats = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.chkPerfilEmail = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.chkPerfilTermos = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.cbPerfilGenero = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblPerfilInf = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPerfilUF = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tpBusiness = New System.Windows.Forms.TabPage()
        Me.lblBusinessRmal = New System.Windows.Forms.Label()
        Me.lblBusinessTelefone = New System.Windows.Forms.Label()
        Me.lblBusinessFuncao = New System.Windows.Forms.Label()
        Me.lblBusinessDepart = New System.Windows.Forms.Label()
        Me.lblBusinessEmpresa = New System.Windows.Forms.Label()
        Me.btnAvBusiness = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnVoltBusiness = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtBusinessEmpresa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBusinessDepart = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBusinessFuncao = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBusinessTel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBusinessRamal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tpPermissao = New System.Windows.Forms.TabPage()
        Me.btnPermAvancar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnPermVoltar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pbPermAviso = New System.Windows.Forms.PictureBox()
        Me.lblPermAviso = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tpCheckList = New System.Windows.Forms.TabPage()
        Me.btnChklistFinalizar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnChklistVoltar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblChklistAviso = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pbChklistAviso = New System.Windows.Forms.PictureBox()
        Me.tpBanco = New System.Windows.Forms.TabPage()
        Me.btnBDConnect = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblBDAviso = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblBDSenha = New System.Windows.Forms.Label()
        Me.lblBDUser = New System.Windows.Forms.Label()
        Me.lblBDBanco = New System.Windows.Forms.Label()
        Me.lblBDPorta = New System.Windows.Forms.Label()
        Me.lblBDServidor = New System.Windows.Forms.Label()
        Me.btnBDDefault = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnBDCancelar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnBDSalvar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtBDPorta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBDSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBDUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBDBanco = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBDServidor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.tpRedefinir = New System.Windows.Forms.TabPage()
        Me.lblRdfInvalido = New System.Windows.Forms.Label()
        Me.btnRdfCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnRdfEnviar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblRdfEmail = New System.Windows.Forms.Label()
        Me.txtRdfEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblRdfAviso = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tpConfUser = New System.Windows.Forms.TabPage()
        Me.lblConfInvalido = New System.Windows.Forms.Label()
        Me.lblConfAviso = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnConfCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnConfValidar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblConfToken = New System.Windows.Forms.Label()
        Me.txtConfToken = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tpEditarBanco = New System.Windows.Forms.TabPage()
        Me.lblEditarBDInvalido = New System.Windows.Forms.Label()
        Me.lblEditarBDCaps = New System.Windows.Forms.Label()
        Me.lblEditarBDSenha = New System.Windows.Forms.Label()
        Me.txtEditarBDSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblEditarBD = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnCancelarBD = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEditarBD = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblEditarBDEmail = New System.Windows.Forms.Label()
        Me.txtEditarBDEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TpLoading = New System.Windows.Forms.TabPage()
        Me.ProgressAguarde = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.LblLoading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Bordeless = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.PanelBarraSup.SuspendLayout()
        Me.PanelEtapa.SuspendLayout()
        CType(Me.pbTopBusiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTopProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bpCadUser.SuspendLayout()
        Me.tpUserLogin.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAcesso.SuspendLayout()
        Me.tpPerfil.SuspendLayout()
        CType(Me.pbWhats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTermos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpBusiness.SuspendLayout()
        Me.tpPermissao.SuspendLayout()
        CType(Me.pbPermAviso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCheckList.SuspendLayout()
        CType(Me.pbChklistAviso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpBanco.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRedefinir.SuspendLayout()
        Me.tpConfUser.SuspendLayout()
        Me.tpEditarBanco.SuspendLayout()
        Me.TpLoading.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(263, 272)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(408, 41)
        Me.Guna2HtmlLabel2.TabIndex = 93
        Me.Guna2HtmlLabel2.Text = "Existem campos sem preencher"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(161, 292)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(611, 54)
        Me.Guna2HtmlLabel1.TabIndex = 116
        Me.Guna2HtmlLabel1.Text = "Vamos manter os seus dados só enquanto assim o pretender. Ficarão sempre em segur" &
    "ança e a qualquer momento pode deixar de receber nossas mensagens ou editar os s" &
    "eus dados. "
        '
        'PanelBarraSup
        '
        Me.PanelBarraSup.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PanelBarraSup.Controls.Add(Me.btnYoutube)
        Me.PanelBarraSup.Controls.Add(Me.btnFacebook)
        Me.PanelBarraSup.Controls.Add(Me.btnInstagram)
        Me.PanelBarraSup.Controls.Add(Me.btnAcessoBD)
        Me.PanelBarraSup.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraSup.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraSup.Controls.Add(Me.btnClose)
        Me.PanelBarraSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraSup.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraSup.Name = "PanelBarraSup"
        Me.PanelBarraSup.Size = New System.Drawing.Size(700, 34)
        Me.PanelBarraSup.TabIndex = 57
        '
        'btnYoutube
        '
        Me.btnYoutube.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnYoutube.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnYoutube.CheckedState.Parent = Me.btnYoutube
        Me.btnYoutube.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnYoutube.HoverState.Parent = Me.btnYoutube
        Me.btnYoutube.Image = CType(resources.GetObject("btnYoutube.Image"), System.Drawing.Image)
        Me.btnYoutube.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnYoutube.ImageRotate = 0!
        Me.btnYoutube.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnYoutube.Location = New System.Drawing.Point(78, 5)
        Me.btnYoutube.Name = "btnYoutube"
        Me.btnYoutube.PressedState.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnYoutube.PressedState.Parent = Me.btnYoutube
        Me.btnYoutube.ShadowDecoration.Parent = Me.btnYoutube
        Me.btnYoutube.Size = New System.Drawing.Size(24, 24)
        Me.btnYoutube.TabIndex = 154
        '
        'btnFacebook
        '
        Me.btnFacebook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFacebook.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnFacebook.CheckedState.Parent = Me.btnFacebook
        Me.btnFacebook.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnFacebook.HoverState.Parent = Me.btnFacebook
        Me.btnFacebook.Image = CType(resources.GetObject("btnFacebook.Image"), System.Drawing.Image)
        Me.btnFacebook.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnFacebook.ImageRotate = 0!
        Me.btnFacebook.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnFacebook.Location = New System.Drawing.Point(45, 5)
        Me.btnFacebook.Name = "btnFacebook"
        Me.btnFacebook.PressedState.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnFacebook.PressedState.Parent = Me.btnFacebook
        Me.btnFacebook.ShadowDecoration.Parent = Me.btnFacebook
        Me.btnFacebook.Size = New System.Drawing.Size(24, 24)
        Me.btnFacebook.TabIndex = 153
        '
        'btnInstagram
        '
        Me.btnInstagram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInstagram.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnInstagram.CheckedState.Parent = Me.btnInstagram
        Me.btnInstagram.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnInstagram.HoverState.Parent = Me.btnInstagram
        Me.btnInstagram.Image = CType(resources.GetObject("btnInstagram.Image"), System.Drawing.Image)
        Me.btnInstagram.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnInstagram.ImageRotate = 0!
        Me.btnInstagram.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnInstagram.Location = New System.Drawing.Point(13, 5)
        Me.btnInstagram.Name = "btnInstagram"
        Me.btnInstagram.PressedState.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnInstagram.PressedState.Parent = Me.btnInstagram
        Me.btnInstagram.ShadowDecoration.Parent = Me.btnInstagram
        Me.btnInstagram.Size = New System.Drawing.Size(24, 24)
        Me.btnInstagram.TabIndex = 152
        '
        'btnAcessoBD
        '
        Me.btnAcessoBD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAcessoBD.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnAcessoBD.CheckedState.Parent = Me.btnAcessoBD
        Me.btnAcessoBD.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAcessoBD.HoverState.Parent = Me.btnAcessoBD
        Me.btnAcessoBD.Image = CType(resources.GetObject("btnAcessoBD.Image"), System.Drawing.Image)
        Me.btnAcessoBD.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnAcessoBD.ImageRotate = 0!
        Me.btnAcessoBD.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnAcessoBD.Location = New System.Drawing.Point(559, 4)
        Me.btnAcessoBD.Name = "btnAcessoBD"
        Me.btnAcessoBD.PressedState.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnAcessoBD.PressedState.Parent = Me.btnAcessoBD
        Me.btnAcessoBD.ShadowDecoration.Parent = Me.btnAcessoBD
        Me.btnAcessoBD.Size = New System.Drawing.Size(24, 24)
        Me.btnAcessoBD.TabIndex = 155
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnMinimizar.CheckedState.Parent = Me.btnMinimizar
        Me.btnMinimizar.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnMinimizar.HoverState.Parent = Me.btnMinimizar
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnMinimizar.ImageRotate = 0!
        Me.btnMinimizar.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnMinimizar.Location = New System.Drawing.Point(601, 7)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.PressedState.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnMinimizar.PressedState.Parent = Me.btnMinimizar
        Me.btnMinimizar.ShadowDecoration.Parent = Me.btnMinimizar
        Me.btnMinimizar.Size = New System.Drawing.Size(22, 22)
        Me.btnMinimizar.TabIndex = 156
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnMaximizar.CheckedState.Parent = Me.btnMaximizar
        Me.btnMaximizar.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnMaximizar.HoverState.Parent = Me.btnMaximizar
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnMaximizar.ImageRotate = 0!
        Me.btnMaximizar.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnMaximizar.Location = New System.Drawing.Point(634, 7)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.PressedState.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnMaximizar.PressedState.Parent = Me.btnMaximizar
        Me.btnMaximizar.ShadowDecoration.Parent = Me.btnMaximizar
        Me.btnMaximizar.Size = New System.Drawing.Size(22, 22)
        Me.btnMaximizar.TabIndex = 157
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.HoverState.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnClose.ImageRotate = 0!
        Me.btnClose.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnClose.Location = New System.Drawing.Point(665, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedState.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnClose.PressedState.Parent = Me.btnClose
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(22, 22)
        Me.btnClose.TabIndex = 158
        '
        'drag
        '
        Me.drag.ContainerControl = Me
        Me.drag.TargetControl = Me.PanelBarraSup
        '
        'lblProfile
        '
        Me.lblProfile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblProfile.AutoSize = True
        Me.lblProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblProfile.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblProfile.ForeColor = System.Drawing.Color.Gray
        Me.lblProfile.Location = New System.Drawing.Point(200, 54)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(93, 19)
        Me.lblProfile.TabIndex = 80
        Me.lblProfile.Text = "Info. pessoais"
        '
        'lblBusiness
        '
        Me.lblBusiness.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBusiness.AutoSize = True
        Me.lblBusiness.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblBusiness.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblBusiness.ForeColor = System.Drawing.Color.Gray
        Me.lblBusiness.Location = New System.Drawing.Point(302, 54)
        Me.lblBusiness.Name = "lblBusiness"
        Me.lblBusiness.Size = New System.Drawing.Size(120, 19)
        Me.lblBusiness.TabIndex = 79
        Me.lblBusiness.Text = "Info. Profissionais"
        '
        'lblPermissao
        '
        Me.lblPermissao.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPermissao.AutoSize = True
        Me.lblPermissao.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblPermissao.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPermissao.ForeColor = System.Drawing.Color.Gray
        Me.lblPermissao.Location = New System.Drawing.Point(438, 54)
        Me.lblPermissao.Name = "lblPermissao"
        Me.lblPermissao.Size = New System.Drawing.Size(78, 19)
        Me.lblPermissao.TabIndex = 78
        Me.lblPermissao.Text = "Permissões"
        '
        'lblAcesso
        '
        Me.lblAcesso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAcesso.AutoSize = True
        Me.lblAcesso.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblAcesso.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAcesso.ForeColor = System.Drawing.Color.White
        Me.lblAcesso.Location = New System.Drawing.Point(75, 54)
        Me.lblAcesso.Name = "lblAcesso"
        Me.lblAcesso.Size = New System.Drawing.Size(112, 19)
        Me.lblAcesso.TabIndex = 63
        Me.lblAcesso.Text = "Dados de acesso"
        '
        'lblChecklist
        '
        Me.lblChecklist.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblChecklist.AutoSize = True
        Me.lblChecklist.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblChecklist.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblChecklist.ForeColor = System.Drawing.Color.Gray
        Me.lblChecklist.Location = New System.Drawing.Point(556, 54)
        Me.lblChecklist.Name = "lblChecklist"
        Me.lblChecklist.Size = New System.Drawing.Size(66, 19)
        Me.lblChecklist.TabIndex = 77
        Me.lblChecklist.Text = "Checklist"
        '
        'PanelEtapa
        '
        Me.PanelEtapa.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PanelEtapa.Controls.Add(Me.lblProfile)
        Me.PanelEtapa.Controls.Add(Me.lblBusiness)
        Me.PanelEtapa.Controls.Add(Me.lblPermissao)
        Me.PanelEtapa.Controls.Add(Me.lblAcesso)
        Me.PanelEtapa.Controls.Add(Me.lblChecklist)
        Me.PanelEtapa.Controls.Add(Me.pbTopBusiness)
        Me.PanelEtapa.Controls.Add(Me.pbTopProfile)
        Me.PanelEtapa.Controls.Add(Me.pbAcesso)
        Me.PanelEtapa.Controls.Add(Me.bs1)
        Me.PanelEtapa.Controls.Add(Me.bs2)
        Me.PanelEtapa.Controls.Add(Me.bs3)
        Me.PanelEtapa.Controls.Add(Me.bs6)
        Me.PanelEtapa.Controls.Add(Me.bs8)
        Me.PanelEtapa.Controls.Add(Me.bs7)
        Me.PanelEtapa.Controls.Add(Me.bs5)
        Me.PanelEtapa.Controls.Add(Me.bs4)
        Me.PanelEtapa.Controls.Add(Me.pbProfile)
        Me.PanelEtapa.Controls.Add(Me.pbBusiness)
        Me.PanelEtapa.Controls.Add(Me.pbPermissao)
        Me.PanelEtapa.Controls.Add(Me.pbChecklist)
        Me.PanelEtapa.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEtapa.Location = New System.Drawing.Point(0, 34)
        Me.PanelEtapa.Name = "PanelEtapa"
        Me.PanelEtapa.Size = New System.Drawing.Size(700, 92)
        Me.PanelEtapa.TabIndex = 58
        Me.PanelEtapa.Visible = False
        '
        'pbTopBusiness
        '
        Me.pbTopBusiness.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbTopBusiness.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.pbTopBusiness.Image = CType(resources.GetObject("pbTopBusiness.Image"), System.Drawing.Image)
        Me.pbTopBusiness.ImageRotate = 0!
        Me.pbTopBusiness.Location = New System.Drawing.Point(370, 9)
        Me.pbTopBusiness.Name = "pbTopBusiness"
        Me.pbTopBusiness.ShadowDecoration.Parent = Me.pbTopBusiness
        Me.pbTopBusiness.Size = New System.Drawing.Size(18, 18)
        Me.pbTopBusiness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbTopBusiness.TabIndex = 160
        Me.pbTopBusiness.TabStop = False
        Me.pbTopBusiness.Visible = False
        '
        'pbTopProfile
        '
        Me.pbTopProfile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbTopProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.pbTopProfile.Image = CType(resources.GetObject("pbTopProfile.Image"), System.Drawing.Image)
        Me.pbTopProfile.ImageRotate = 0!
        Me.pbTopProfile.Location = New System.Drawing.Point(254, 9)
        Me.pbTopProfile.Name = "pbTopProfile"
        Me.pbTopProfile.ShadowDecoration.Parent = Me.pbTopProfile
        Me.pbTopProfile.Size = New System.Drawing.Size(18, 18)
        Me.pbTopProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbTopProfile.TabIndex = 160
        Me.pbTopProfile.TabStop = False
        Me.pbTopProfile.Visible = False
        '
        'pbAcesso
        '
        Me.pbAcesso.Animated = True
        Me.pbAcesso.BackColor = System.Drawing.Color.Transparent
        Me.pbAcesso.CheckedState.Parent = Me.pbAcesso
        Me.pbAcesso.CustomImages.Parent = Me.pbAcesso
        Me.pbAcesso.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.pbAcesso.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.pbAcesso.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.pbAcesso.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.pbAcesso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.pbAcesso.DisabledState.Parent = Me.pbAcesso
        Me.pbAcesso.FillColor = System.Drawing.Color.Black
        Me.pbAcesso.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pbAcesso.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pbAcesso.ForeColor = System.Drawing.Color.White
        Me.pbAcesso.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pbAcesso.HoverState.Parent = Me.pbAcesso
        Me.pbAcesso.Image = CType(resources.GetObject("pbAcesso.Image"), System.Drawing.Image)
        Me.pbAcesso.ImageOffset = New System.Drawing.Point(1, 0)
        Me.pbAcesso.ImageSize = New System.Drawing.Size(21, 21)
        Me.pbAcesso.Location = New System.Drawing.Point(108, 13)
        Me.pbAcesso.Name = "pbAcesso"
        Me.pbAcesso.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbAcesso.ShadowDecoration.Parent = Me.pbAcesso
        Me.pbAcesso.Size = New System.Drawing.Size(38, 38)
        Me.pbAcesso.TabIndex = 191
        Me.pbAcesso.UseTransparentBackground = True
        '
        'bs1
        '
        Me.bs1.BackColor = System.Drawing.Color.Transparent
        Me.bs1.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.bs1.FillThickness = 3
        Me.bs1.Location = New System.Drawing.Point(145, 26)
        Me.bs1.Name = "bs1"
        Me.bs1.Size = New System.Drawing.Size(40, 10)
        Me.bs1.TabIndex = 196
        Me.bs1.UseTransparentBackground = True
        '
        'bs2
        '
        Me.bs2.BackColor = System.Drawing.Color.Transparent
        Me.bs2.FillColor = System.Drawing.Color.Gray
        Me.bs2.FillThickness = 3
        Me.bs2.Location = New System.Drawing.Point(185, 26)
        Me.bs2.Name = "bs2"
        Me.bs2.Size = New System.Drawing.Size(40, 10)
        Me.bs2.TabIndex = 197
        Me.bs2.UseTransparentBackground = True
        '
        'bs3
        '
        Me.bs3.BackColor = System.Drawing.Color.Transparent
        Me.bs3.FillColor = System.Drawing.Color.Gray
        Me.bs3.FillThickness = 3
        Me.bs3.Location = New System.Drawing.Point(261, 26)
        Me.bs3.Name = "bs3"
        Me.bs3.Size = New System.Drawing.Size(40, 10)
        Me.bs3.TabIndex = 198
        Me.bs3.UseTransparentBackground = True
        '
        'bs6
        '
        Me.bs6.BackColor = System.Drawing.Color.Transparent
        Me.bs6.FillColor = System.Drawing.Color.Gray
        Me.bs6.FillThickness = 3
        Me.bs6.Location = New System.Drawing.Point(417, 26)
        Me.bs6.Name = "bs6"
        Me.bs6.Size = New System.Drawing.Size(40, 10)
        Me.bs6.TabIndex = 201
        Me.bs6.UseTransparentBackground = True
        '
        'bs8
        '
        Me.bs8.BackColor = System.Drawing.Color.Transparent
        Me.bs8.FillColor = System.Drawing.Color.Gray
        Me.bs8.FillThickness = 3
        Me.bs8.Location = New System.Drawing.Point(533, 26)
        Me.bs8.Name = "bs8"
        Me.bs8.Size = New System.Drawing.Size(40, 10)
        Me.bs8.TabIndex = 203
        Me.bs8.UseTransparentBackground = True
        '
        'bs7
        '
        Me.bs7.BackColor = System.Drawing.Color.Transparent
        Me.bs7.FillColor = System.Drawing.Color.Gray
        Me.bs7.FillThickness = 3
        Me.bs7.Location = New System.Drawing.Point(493, 26)
        Me.bs7.Name = "bs7"
        Me.bs7.Size = New System.Drawing.Size(40, 10)
        Me.bs7.TabIndex = 202
        Me.bs7.UseTransparentBackground = True
        '
        'bs5
        '
        Me.bs5.BackColor = System.Drawing.Color.Transparent
        Me.bs5.FillColor = System.Drawing.Color.Gray
        Me.bs5.FillThickness = 3
        Me.bs5.Location = New System.Drawing.Point(377, 26)
        Me.bs5.Name = "bs5"
        Me.bs5.Size = New System.Drawing.Size(40, 10)
        Me.bs5.TabIndex = 200
        Me.bs5.UseTransparentBackground = True
        '
        'bs4
        '
        Me.bs4.BackColor = System.Drawing.Color.Transparent
        Me.bs4.FillColor = System.Drawing.Color.Gray
        Me.bs4.FillThickness = 3
        Me.bs4.Location = New System.Drawing.Point(301, 26)
        Me.bs4.Name = "bs4"
        Me.bs4.Size = New System.Drawing.Size(40, 10)
        Me.bs4.TabIndex = 199
        Me.bs4.UseTransparentBackground = True
        '
        'pbProfile
        '
        Me.pbProfile.Animated = True
        Me.pbProfile.BackColor = System.Drawing.Color.Transparent
        Me.pbProfile.CheckedState.Parent = Me.pbProfile
        Me.pbProfile.CustomImages.Parent = Me.pbProfile
        Me.pbProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.pbProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.pbProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.pbProfile.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.pbProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.pbProfile.DisabledState.Parent = Me.pbProfile
        Me.pbProfile.FillColor = System.Drawing.Color.Black
        Me.pbProfile.FillColor2 = System.Drawing.Color.Gray
        Me.pbProfile.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pbProfile.ForeColor = System.Drawing.Color.White
        Me.pbProfile.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pbProfile.HoverState.Parent = Me.pbProfile
        Me.pbProfile.Image = CType(resources.GetObject("pbProfile.Image"), System.Drawing.Image)
        Me.pbProfile.ImageOffset = New System.Drawing.Point(1, 0)
        Me.pbProfile.Location = New System.Drawing.Point(224, 13)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbProfile.ShadowDecoration.Parent = Me.pbProfile
        Me.pbProfile.Size = New System.Drawing.Size(38, 38)
        Me.pbProfile.TabIndex = 194
        Me.pbProfile.UseTransparentBackground = True
        '
        'pbBusiness
        '
        Me.pbBusiness.Animated = True
        Me.pbBusiness.BackColor = System.Drawing.Color.Transparent
        Me.pbBusiness.CheckedState.Parent = Me.pbBusiness
        Me.pbBusiness.CustomImages.Parent = Me.pbBusiness
        Me.pbBusiness.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.pbBusiness.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.pbBusiness.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.pbBusiness.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.pbBusiness.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.pbBusiness.DisabledState.Parent = Me.pbBusiness
        Me.pbBusiness.FillColor = System.Drawing.Color.Black
        Me.pbBusiness.FillColor2 = System.Drawing.Color.Gray
        Me.pbBusiness.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pbBusiness.ForeColor = System.Drawing.Color.White
        Me.pbBusiness.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pbBusiness.HoverState.Parent = Me.pbBusiness
        Me.pbBusiness.Image = CType(resources.GetObject("pbBusiness.Image"), System.Drawing.Image)
        Me.pbBusiness.ImageOffset = New System.Drawing.Point(1, 0)
        Me.pbBusiness.ImageSize = New System.Drawing.Size(18, 18)
        Me.pbBusiness.Location = New System.Drawing.Point(340, 13)
        Me.pbBusiness.Name = "pbBusiness"
        Me.pbBusiness.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbBusiness.ShadowDecoration.Parent = Me.pbBusiness
        Me.pbBusiness.Size = New System.Drawing.Size(38, 38)
        Me.pbBusiness.TabIndex = 193
        Me.pbBusiness.UseTransparentBackground = True
        '
        'pbPermissao
        '
        Me.pbPermissao.Animated = True
        Me.pbPermissao.BackColor = System.Drawing.Color.Transparent
        Me.pbPermissao.CheckedState.Parent = Me.pbPermissao
        Me.pbPermissao.CustomImages.Parent = Me.pbPermissao
        Me.pbPermissao.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.pbPermissao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.pbPermissao.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.pbPermissao.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.pbPermissao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.pbPermissao.DisabledState.Parent = Me.pbPermissao
        Me.pbPermissao.FillColor = System.Drawing.Color.Black
        Me.pbPermissao.FillColor2 = System.Drawing.Color.Gray
        Me.pbPermissao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pbPermissao.ForeColor = System.Drawing.Color.White
        Me.pbPermissao.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pbPermissao.HoverState.Parent = Me.pbPermissao
        Me.pbPermissao.Image = CType(resources.GetObject("pbPermissao.Image"), System.Drawing.Image)
        Me.pbPermissao.ImageOffset = New System.Drawing.Point(1, 0)
        Me.pbPermissao.ImageSize = New System.Drawing.Size(21, 21)
        Me.pbPermissao.Location = New System.Drawing.Point(456, 13)
        Me.pbPermissao.Name = "pbPermissao"
        Me.pbPermissao.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbPermissao.ShadowDecoration.Parent = Me.pbPermissao
        Me.pbPermissao.Size = New System.Drawing.Size(38, 38)
        Me.pbPermissao.TabIndex = 195
        Me.pbPermissao.UseTransparentBackground = True
        '
        'pbChecklist
        '
        Me.pbChecklist.Animated = True
        Me.pbChecklist.BackColor = System.Drawing.Color.Transparent
        Me.pbChecklist.CheckedState.Parent = Me.pbChecklist
        Me.pbChecklist.CustomImages.Parent = Me.pbChecklist
        Me.pbChecklist.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.pbChecklist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.pbChecklist.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.pbChecklist.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.pbChecklist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.pbChecklist.DisabledState.Parent = Me.pbChecklist
        Me.pbChecklist.FillColor = System.Drawing.Color.Black
        Me.pbChecklist.FillColor2 = System.Drawing.Color.Gray
        Me.pbChecklist.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pbChecklist.ForeColor = System.Drawing.Color.White
        Me.pbChecklist.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pbChecklist.HoverState.Parent = Me.pbChecklist
        Me.pbChecklist.Image = CType(resources.GetObject("pbChecklist.Image"), System.Drawing.Image)
        Me.pbChecklist.ImageOffset = New System.Drawing.Point(1, 0)
        Me.pbChecklist.Location = New System.Drawing.Point(572, 13)
        Me.pbChecklist.Name = "pbChecklist"
        Me.pbChecklist.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbChecklist.ShadowDecoration.Parent = Me.pbChecklist
        Me.pbChecklist.Size = New System.Drawing.Size(38, 38)
        Me.pbChecklist.TabIndex = 192
        Me.pbChecklist.UseTransparentBackground = True
        '
        'imgLogin
        '
        Me.imgLogin.ImageStream = CType(resources.GetObject("imgLogin.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLogin.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLogin.Images.SetKeyName(0, "cancel_18px.png")
        Me.imgLogin.Images.SetKeyName(1, "ok_18px.png")
        Me.imgLogin.Images.SetKeyName(2, "eye_40px.png")
        Me.imgLogin.Images.SetKeyName(3, "hide_40px.png")
        Me.imgLogin.Images.SetKeyName(4, "warning_18px.png")
        Me.imgLogin.Images.SetKeyName(5, "search2_18px.png")
        '
        'imgLogin1
        '
        Me.imgLogin1.ImageStream = CType(resources.GetObject("imgLogin1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLogin1.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLogin1.Images.SetKeyName(0, "ok_127px.png")
        Me.imgLogin1.Images.SetKeyName(1, "warning_127px.png")
        '
        'TimerUserInvalido
        '
        Me.TimerUserInvalido.Interval = 7000
        '
        'TimerAutoLogin
        '
        Me.TimerAutoLogin.Interval = 1000
        '
        'TimerEditarBD
        '
        Me.TimerEditarBD.Interval = 7000
        '
        'TimerRdf
        '
        Me.TimerRdf.Interval = 7000
        '
        'TimerRdfSenha
        '
        Me.TimerRdfSenha.Interval = 20
        '
        'TimerCadastro
        '
        Me.TimerCadastro.Interval = 20
        '
        'bpCadUser
        '
        Me.bpCadUser.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.bpCadUser.Controls.Add(Me.tpUserLogin)
        Me.bpCadUser.Controls.Add(Me.tpAcesso)
        Me.bpCadUser.Controls.Add(Me.tpPerfil)
        Me.bpCadUser.Controls.Add(Me.tpBusiness)
        Me.bpCadUser.Controls.Add(Me.tpPermissao)
        Me.bpCadUser.Controls.Add(Me.tpCheckList)
        Me.bpCadUser.Controls.Add(Me.tpBanco)
        Me.bpCadUser.Controls.Add(Me.tpRedefinir)
        Me.bpCadUser.Controls.Add(Me.tpConfUser)
        Me.bpCadUser.Controls.Add(Me.tpEditarBanco)
        Me.bpCadUser.Controls.Add(Me.TpLoading)
        Me.bpCadUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bpCadUser.ItemSize = New System.Drawing.Size(60, 30)
        Me.bpCadUser.Location = New System.Drawing.Point(0, 126)
        Me.bpCadUser.Name = "bpCadUser"
        Me.bpCadUser.SelectedIndex = 0
        Me.bpCadUser.Size = New System.Drawing.Size(700, 514)
        Me.bpCadUser.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.bpCadUser.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.bpCadUser.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.bpCadUser.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.bpCadUser.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.bpCadUser.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.bpCadUser.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.bpCadUser.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.bpCadUser.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.bpCadUser.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.bpCadUser.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.bpCadUser.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.bpCadUser.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.bpCadUser.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.bpCadUser.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bpCadUser.TabButtonSize = New System.Drawing.Size(60, 30)
        Me.bpCadUser.TabIndex = 173
        Me.bpCadUser.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.bpCadUser.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalBottom
        Me.bpCadUser.TabMenuVisible = False
        '
        'tpUserLogin
        '
        Me.tpUserLogin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpUserLogin.Controls.Add(Me.lblLoginRdf)
        Me.tpUserLogin.Controls.Add(Me.chkLembrarAcesso)
        Me.tpUserLogin.Controls.Add(Me.lblAutoLogin)
        Me.tpUserLogin.Controls.Add(Me.lblLembrarAcesso)
        Me.tpUserLogin.Controls.Add(Me.chkAutoLogin)
        Me.tpUserLogin.Controls.Add(Me.lblInvalido)
        Me.tpUserLogin.Controls.Add(Me.lblCapsLook)
        Me.tpUserLogin.Controls.Add(Me.lblLoginPass)
        Me.tpUserLogin.Controls.Add(Me.lblLoginEmail)
        Me.tpUserLogin.Controls.Add(Me.btnAddUser)
        Me.tpUserLogin.Controls.Add(Me.btnLogin)
        Me.tpUserLogin.Controls.Add(Me.txtLoginEmail)
        Me.tpUserLogin.Controls.Add(Me.txtLoginPassword)
        Me.tpUserLogin.Controls.Add(Me.Guna2PictureBox1)
        Me.tpUserLogin.Location = New System.Drawing.Point(4, 4)
        Me.tpUserLogin.Name = "tpUserLogin"
        Me.tpUserLogin.Size = New System.Drawing.Size(692, 476)
        Me.tpUserLogin.TabIndex = 10
        Me.tpUserLogin.Text = "Login"
        '
        'lblLoginRdf
        '
        Me.lblLoginRdf.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.lblLoginRdf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLoginRdf.AutoSize = True
        Me.lblLoginRdf.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginRdf.CausesValidation = False
        Me.lblLoginRdf.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLoginRdf.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginRdf.ForeColor = System.Drawing.Color.Black
        Me.lblLoginRdf.Location = New System.Drawing.Point(291, 453)
        Me.lblLoginRdf.Name = "lblLoginRdf"
        Me.lblLoginRdf.Size = New System.Drawing.Size(111, 13)
        Me.lblLoginRdf.TabIndex = 164
        Me.lblLoginRdf.Text = "Esqueci minha senha"
        Me.lblLoginRdf.Visible = False
        '
        'chkLembrarAcesso
        '
        Me.chkLembrarAcesso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkLembrarAcesso.BackColor = System.Drawing.Color.Transparent
        Me.chkLembrarAcesso.CausesValidation = False
        Me.chkLembrarAcesso.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkLembrarAcesso.CheckedState.BorderRadius = 3
        Me.chkLembrarAcesso.CheckedState.BorderThickness = 1
        Me.chkLembrarAcesso.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkLembrarAcesso.CheckedState.Parent = Me.chkLembrarAcesso
        Me.chkLembrarAcesso.Location = New System.Drawing.Point(173, 328)
        Me.chkLembrarAcesso.Name = "chkLembrarAcesso"
        Me.chkLembrarAcesso.ShadowDecoration.Parent = Me.chkLembrarAcesso
        Me.chkLembrarAcesso.Size = New System.Drawing.Size(18, 18)
        Me.chkLembrarAcesso.TabIndex = 162
        Me.chkLembrarAcesso.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkLembrarAcesso.UncheckedState.BorderRadius = 3
        Me.chkLembrarAcesso.UncheckedState.BorderThickness = 1
        Me.chkLembrarAcesso.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.chkLembrarAcesso.UncheckedState.Parent = Me.chkLembrarAcesso
        Me.chkLembrarAcesso.UseTransparentBackground = True
        '
        'lblAutoLogin
        '
        Me.lblAutoLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.lblAutoLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAutoLogin.AutoSize = True
        Me.lblAutoLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblAutoLogin.CausesValidation = False
        Me.lblAutoLogin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAutoLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutoLogin.ForeColor = System.Drawing.Color.Black
        Me.lblAutoLogin.Location = New System.Drawing.Point(191, 353)
        Me.lblAutoLogin.Name = "lblAutoLogin"
        Me.lblAutoLogin.Size = New System.Drawing.Size(186, 13)
        Me.lblAutoLogin.TabIndex = 161
        Me.lblAutoLogin.Text = "Logar automaticamente no sistema"
        '
        'lblLembrarAcesso
        '
        Me.lblLembrarAcesso.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.lblLembrarAcesso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLembrarAcesso.AutoSize = True
        Me.lblLembrarAcesso.BackColor = System.Drawing.Color.Transparent
        Me.lblLembrarAcesso.CausesValidation = False
        Me.lblLembrarAcesso.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLembrarAcesso.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLembrarAcesso.ForeColor = System.Drawing.Color.Black
        Me.lblLembrarAcesso.Location = New System.Drawing.Point(191, 330)
        Me.lblLembrarAcesso.Name = "lblLembrarAcesso"
        Me.lblLembrarAcesso.Size = New System.Drawing.Size(156, 13)
        Me.lblLembrarAcesso.TabIndex = 160
        Me.lblLembrarAcesso.Text = "Salvar meus dados de acesso" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'chkAutoLogin
        '
        Me.chkAutoLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkAutoLogin.BackColor = System.Drawing.Color.Transparent
        Me.chkAutoLogin.CausesValidation = False
        Me.chkAutoLogin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkAutoLogin.CheckedState.BorderRadius = 3
        Me.chkAutoLogin.CheckedState.BorderThickness = 1
        Me.chkAutoLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkAutoLogin.CheckedState.Parent = Me.chkAutoLogin
        Me.chkAutoLogin.Location = New System.Drawing.Point(173, 351)
        Me.chkAutoLogin.Name = "chkAutoLogin"
        Me.chkAutoLogin.ShadowDecoration.Parent = Me.chkAutoLogin
        Me.chkAutoLogin.Size = New System.Drawing.Size(18, 18)
        Me.chkAutoLogin.TabIndex = 159
        Me.chkAutoLogin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkAutoLogin.UncheckedState.BorderRadius = 3
        Me.chkAutoLogin.UncheckedState.BorderThickness = 1
        Me.chkAutoLogin.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.chkAutoLogin.UncheckedState.Parent = Me.chkAutoLogin
        Me.chkAutoLogin.UseTransparentBackground = True
        '
        'lblInvalido
        '
        Me.lblInvalido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInvalido.BackColor = System.Drawing.Color.Transparent
        Me.lblInvalido.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalido.ForeColor = System.Drawing.Color.Red
        Me.lblInvalido.Location = New System.Drawing.Point(189, 130)
        Me.lblInvalido.Name = "lblInvalido"
        Me.lblInvalido.Size = New System.Drawing.Size(314, 35)
        Me.lblInvalido.TabIndex = 158
        Me.lblInvalido.Text = "E-MAIL OU SENHA INVÁLIDO"
        Me.lblInvalido.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblInvalido.Visible = False
        '
        'lblCapsLook
        '
        Me.lblCapsLook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCapsLook.BackColor = System.Drawing.Color.Transparent
        Me.lblCapsLook.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapsLook.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lblCapsLook.Location = New System.Drawing.Point(215, 296)
        Me.lblCapsLook.Name = "lblCapsLook"
        Me.lblCapsLook.Size = New System.Drawing.Size(263, 23)
        Me.lblCapsLook.TabIndex = 157
        Me.lblCapsLook.Text = "CAPS LOOK ATIVADA"
        Me.lblCapsLook.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCapsLook.Visible = False
        '
        'lblLoginPass
        '
        Me.lblLoginPass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLoginPass.AutoSize = True
        Me.lblLoginPass.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLoginPass.ForeColor = System.Drawing.Color.Black
        Me.lblLoginPass.Location = New System.Drawing.Point(170, 236)
        Me.lblLoginPass.Name = "lblLoginPass"
        Me.lblLoginPass.Size = New System.Drawing.Size(39, 15)
        Me.lblLoginPass.TabIndex = 156
        Me.lblLoginPass.Text = "Senha"
        Me.lblLoginPass.Visible = False
        '
        'lblLoginEmail
        '
        Me.lblLoginEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLoginEmail.AutoSize = True
        Me.lblLoginEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLoginEmail.ForeColor = System.Drawing.Color.Black
        Me.lblLoginEmail.Location = New System.Drawing.Point(170, 170)
        Me.lblLoginEmail.Name = "lblLoginEmail"
        Me.lblLoginEmail.Size = New System.Drawing.Size(41, 15)
        Me.lblLoginEmail.TabIndex = 155
        Me.lblLoginEmail.Text = "E-mail"
        Me.lblLoginEmail.Visible = False
        '
        'btnAddUser
        '
        Me.btnAddUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddUser.Animated = True
        Me.btnAddUser.AutoRoundedCorners = True
        Me.btnAddUser.BackColor = System.Drawing.Color.Transparent
        Me.btnAddUser.BorderRadius = 24
        Me.btnAddUser.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnAddUser.CausesValidation = False
        Me.btnAddUser.CheckedState.Parent = Me.btnAddUser
        Me.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddUser.CustomImages.Parent = Me.btnAddUser
        Me.btnAddUser.DisabledState.Parent = Me.btnAddUser
        Me.btnAddUser.FillColor = System.Drawing.Color.Teal
        Me.btnAddUser.FillColor2 = System.Drawing.Color.Black
        Me.btnAddUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddUser.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnAddUser.HoverState.Parent = Me.btnAddUser
        Me.btnAddUser.Image = CType(resources.GetObject("btnAddUser.Image"), System.Drawing.Image)
        Me.btnAddUser.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btnAddUser.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAddUser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddUser.Location = New System.Drawing.Point(634, 418)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.ShadowDecoration.Parent = Me.btnAddUser
        Me.btnAddUser.Size = New System.Drawing.Size(51, 51)
        Me.btnAddUser.TabIndex = 154
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLogin.Animated = True
        Me.btnLogin.AutoRoundedCorners = True
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLogin.BorderRadius = 21
        Me.btnLogin.CausesValidation = False
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.btnLogin.DisabledState.Parent = Me.btnLogin
        Me.btnLogin.FillColor = System.Drawing.Color.Black
        Me.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnLogin.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(245, 404)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(203, 45)
        Me.btnLogin.TabIndex = 153
        Me.btnLogin.Text = "LOGIN"
        '
        'txtLoginEmail
        '
        Me.txtLoginEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLoginEmail.Animated = True
        Me.txtLoginEmail.AutoRoundedCorners = True
        Me.txtLoginEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtLoginEmail.BorderColor = System.Drawing.Color.Gray
        Me.txtLoginEmail.BorderRadius = 17
        Me.txtLoginEmail.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtLoginEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoginEmail.DefaultText = ""
        Me.txtLoginEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLoginEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLoginEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLoginEmail.DisabledState.Parent = Me.txtLoginEmail
        Me.txtLoginEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLoginEmail.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtLoginEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtLoginEmail.FocusedState.Parent = Me.txtLoginEmail
        Me.txtLoginEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLoginEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLoginEmail.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtLoginEmail.HoverState.Parent = Me.txtLoginEmail
        Me.txtLoginEmail.IconLeft = CType(resources.GetObject("txtLoginEmail.IconLeft"), System.Drawing.Image)
        Me.txtLoginEmail.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.txtLoginEmail.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtLoginEmail.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtLoginEmail.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtLoginEmail.IconRightSize = New System.Drawing.Size(16, 16)
        Me.txtLoginEmail.Location = New System.Drawing.Point(173, 188)
        Me.txtLoginEmail.Name = "txtLoginEmail"
        Me.txtLoginEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLoginEmail.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtLoginEmail.PlaceholderText = "E-mail..."
        Me.txtLoginEmail.SelectedText = ""
        Me.txtLoginEmail.ShadowDecoration.Parent = Me.txtLoginEmail
        Me.txtLoginEmail.Size = New System.Drawing.Size(350, 36)
        Me.txtLoginEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtLoginEmail.TabIndex = 151
        Me.txtLoginEmail.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLoginPassword.Animated = True
        Me.txtLoginPassword.AutoRoundedCorners = True
        Me.txtLoginPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtLoginPassword.BorderColor = System.Drawing.Color.Gray
        Me.txtLoginPassword.BorderRadius = 17
        Me.txtLoginPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtLoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoginPassword.DefaultText = ""
        Me.txtLoginPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLoginPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLoginPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLoginPassword.DisabledState.Parent = Me.txtLoginPassword
        Me.txtLoginPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLoginPassword.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtLoginPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtLoginPassword.FocusedState.Parent = Me.txtLoginPassword
        Me.txtLoginPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLoginPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLoginPassword.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtLoginPassword.HoverState.Parent = Me.txtLoginPassword
        Me.txtLoginPassword.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtLoginPassword.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtLoginPassword.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtLoginPassword.IconRightSize = New System.Drawing.Size(16, 16)
        Me.txtLoginPassword.Location = New System.Drawing.Point(173, 254)
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLoginPassword.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtLoginPassword.PlaceholderText = "Senha..."
        Me.txtLoginPassword.SelectedText = ""
        Me.txtLoginPassword.ShadowDecoration.Parent = Me.txtLoginPassword
        Me.txtLoginPassword.Size = New System.Drawing.Size(350, 36)
        Me.txtLoginPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtLoginPassword.TabIndex = 152
        Me.txtLoginPassword.TextOffset = New System.Drawing.Point(5, 0)
        Me.txtLoginPassword.UseSystemPasswordChar = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(283, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(126, 124)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 163
        Me.Guna2PictureBox1.TabStop = False
        '
        'tpAcesso
        '
        Me.tpAcesso.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpAcesso.Controls.Add(Me.lblCadEmail)
        Me.tpAcesso.Controls.Add(Me.lblCadCapsLook)
        Me.tpAcesso.Controls.Add(Me.lblAcessoConfPass)
        Me.tpAcesso.Controls.Add(Me.lblAcessoPass)
        Me.tpAcesso.Controls.Add(Me.lblAcessoEmail)
        Me.tpAcesso.Controls.Add(Me.btnAvAcesso)
        Me.tpAcesso.Controls.Add(Me.btnVoltAcesso)
        Me.tpAcesso.Controls.Add(Me.txtCadEmail)
        Me.tpAcesso.Controls.Add(Me.txtCadPass)
        Me.tpAcesso.Controls.Add(Me.txtCadConfPass)
        Me.tpAcesso.Location = New System.Drawing.Point(4, 4)
        Me.tpAcesso.Name = "tpAcesso"
        Me.tpAcesso.Size = New System.Drawing.Size(692, 476)
        Me.tpAcesso.TabIndex = 1
        Me.tpAcesso.Text = "Acesso"
        '
        'lblCadEmail
        '
        Me.lblCadEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCadEmail.AutoSize = True
        Me.lblCadEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblCadEmail.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblCadEmail.ForeColor = System.Drawing.Color.Red
        Me.lblCadEmail.Location = New System.Drawing.Point(172, 87)
        Me.lblCadEmail.Name = "lblCadEmail"
        Me.lblCadEmail.Size = New System.Drawing.Size(93, 12)
        Me.lblCadEmail.TabIndex = 171
        Me.lblCadEmail.Text = "E-mail já cadastrado"
        Me.lblCadEmail.Visible = False
        '
        'lblCadCapsLook
        '
        Me.lblCadCapsLook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCadCapsLook.BackColor = System.Drawing.Color.Transparent
        Me.lblCadCapsLook.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCadCapsLook.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lblCadCapsLook.Location = New System.Drawing.Point(189, 245)
        Me.lblCadCapsLook.Name = "lblCadCapsLook"
        Me.lblCadCapsLook.Size = New System.Drawing.Size(314, 23)
        Me.lblCadCapsLook.TabIndex = 170
        Me.lblCadCapsLook.Text = "CAPS LOOK ATIVADA"
        Me.lblCadCapsLook.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCadCapsLook.Visible = False
        '
        'lblAcessoConfPass
        '
        Me.lblAcessoConfPass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAcessoConfPass.AutoSize = True
        Me.lblAcessoConfPass.BackColor = System.Drawing.Color.Transparent
        Me.lblAcessoConfPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAcessoConfPass.ForeColor = System.Drawing.Color.Black
        Me.lblAcessoConfPass.Location = New System.Drawing.Point(172, 184)
        Me.lblAcessoConfPass.Name = "lblAcessoConfPass"
        Me.lblAcessoConfPass.Size = New System.Drawing.Size(108, 15)
        Me.lblAcessoConfPass.TabIndex = 167
        Me.lblAcessoConfPass.Text = "Confirme a senha *"
        Me.lblAcessoConfPass.Visible = False
        '
        'lblAcessoPass
        '
        Me.lblAcessoPass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAcessoPass.AutoSize = True
        Me.lblAcessoPass.BackColor = System.Drawing.Color.Transparent
        Me.lblAcessoPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAcessoPass.ForeColor = System.Drawing.Color.Black
        Me.lblAcessoPass.Location = New System.Drawing.Point(172, 107)
        Me.lblAcessoPass.Name = "lblAcessoPass"
        Me.lblAcessoPass.Size = New System.Drawing.Size(47, 15)
        Me.lblAcessoPass.TabIndex = 168
        Me.lblAcessoPass.Text = "Senha *"
        Me.lblAcessoPass.Visible = False
        '
        'lblAcessoEmail
        '
        Me.lblAcessoEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAcessoEmail.AutoSize = True
        Me.lblAcessoEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblAcessoEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAcessoEmail.ForeColor = System.Drawing.Color.Black
        Me.lblAcessoEmail.Location = New System.Drawing.Point(172, 30)
        Me.lblAcessoEmail.Name = "lblAcessoEmail"
        Me.lblAcessoEmail.Size = New System.Drawing.Size(49, 15)
        Me.lblAcessoEmail.TabIndex = 169
        Me.lblAcessoEmail.Text = "E-mail *"
        Me.lblAcessoEmail.Visible = False
        '
        'btnAvAcesso
        '
        Me.btnAvAcesso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAvAcesso.Animated = True
        Me.btnAvAcesso.BackColor = System.Drawing.Color.Transparent
        Me.btnAvAcesso.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnAvAcesso.BorderRadius = 18
        Me.btnAvAcesso.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnAvAcesso.CheckedState.Parent = Me.btnAvAcesso
        Me.btnAvAcesso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAvAcesso.CustomImages.Parent = Me.btnAvAcesso
        Me.btnAvAcesso.DisabledState.Parent = Me.btnAvAcesso
        Me.btnAvAcesso.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnAvAcesso.FillColor2 = System.Drawing.Color.Black
        Me.btnAvAcesso.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAvAcesso.ForeColor = System.Drawing.Color.White
        Me.btnAvAcesso.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnAvAcesso.HoverState.Parent = Me.btnAvAcesso
        Me.btnAvAcesso.Location = New System.Drawing.Point(350, 431)
        Me.btnAvAcesso.Name = "btnAvAcesso"
        Me.btnAvAcesso.ShadowDecoration.Parent = Me.btnAvAcesso
        Me.btnAvAcesso.Size = New System.Drawing.Size(124, 38)
        Me.btnAvAcesso.TabIndex = 165
        Me.btnAvAcesso.Text = "AVANÇAR"
        '
        'btnVoltAcesso
        '
        Me.btnVoltAcesso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnVoltAcesso.Animated = True
        Me.btnVoltAcesso.BackColor = System.Drawing.Color.Transparent
        Me.btnVoltAcesso.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnVoltAcesso.BorderRadius = 18
        Me.btnVoltAcesso.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnVoltAcesso.CausesValidation = False
        Me.btnVoltAcesso.CheckedState.Parent = Me.btnVoltAcesso
        Me.btnVoltAcesso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoltAcesso.CustomImages.Parent = Me.btnVoltAcesso
        Me.btnVoltAcesso.DisabledState.Parent = Me.btnVoltAcesso
        Me.btnVoltAcesso.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnVoltAcesso.FillColor2 = System.Drawing.Color.Black
        Me.btnVoltAcesso.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnVoltAcesso.ForeColor = System.Drawing.Color.White
        Me.btnVoltAcesso.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnVoltAcesso.HoverState.Parent = Me.btnVoltAcesso
        Me.btnVoltAcesso.Location = New System.Drawing.Point(219, 431)
        Me.btnVoltAcesso.Name = "btnVoltAcesso"
        Me.btnVoltAcesso.ShadowDecoration.Parent = Me.btnVoltAcesso
        Me.btnVoltAcesso.Size = New System.Drawing.Size(124, 38)
        Me.btnVoltAcesso.TabIndex = 166
        Me.btnVoltAcesso.Text = "CANCELAR"
        '
        'txtCadEmail
        '
        Me.txtCadEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCadEmail.Animated = True
        Me.txtCadEmail.AutoRoundedCorners = True
        Me.txtCadEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtCadEmail.BorderColor = System.Drawing.Color.DimGray
        Me.txtCadEmail.BorderRadius = 17
        Me.txtCadEmail.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtCadEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCadEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCadEmail.DefaultText = ""
        Me.txtCadEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCadEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCadEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCadEmail.DisabledState.Parent = Me.txtCadEmail
        Me.txtCadEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCadEmail.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtCadEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtCadEmail.FocusedState.Parent = Me.txtCadEmail
        Me.txtCadEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCadEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCadEmail.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtCadEmail.HoverState.Parent = Me.txtCadEmail
        Me.txtCadEmail.IconLeft = CType(resources.GetObject("txtCadEmail.IconLeft"), System.Drawing.Image)
        Me.txtCadEmail.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.txtCadEmail.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtCadEmail.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtCadEmail.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtCadEmail.IconRightSize = New System.Drawing.Size(16, 16)
        Me.txtCadEmail.Location = New System.Drawing.Point(171, 48)
        Me.txtCadEmail.Name = "txtCadEmail"
        Me.txtCadEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCadEmail.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtCadEmail.PlaceholderText = "digite seu e-mail... *"
        Me.txtCadEmail.SelectedText = ""
        Me.txtCadEmail.ShadowDecoration.Parent = Me.txtCadEmail
        Me.txtCadEmail.Size = New System.Drawing.Size(350, 36)
        Me.txtCadEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCadEmail.TabIndex = 162
        Me.txtCadEmail.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtCadPass
        '
        Me.txtCadPass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCadPass.Animated = True
        Me.txtCadPass.AutoRoundedCorners = True
        Me.txtCadPass.BackColor = System.Drawing.Color.Transparent
        Me.txtCadPass.BorderColor = System.Drawing.Color.DimGray
        Me.txtCadPass.BorderRadius = 17
        Me.txtCadPass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtCadPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCadPass.DefaultText = ""
        Me.txtCadPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCadPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCadPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCadPass.DisabledState.Parent = Me.txtCadPass
        Me.txtCadPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCadPass.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtCadPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtCadPass.FocusedState.Parent = Me.txtCadPass
        Me.txtCadPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCadPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCadPass.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtCadPass.HoverState.Parent = Me.txtCadPass
        Me.txtCadPass.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtCadPass.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtCadPass.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtCadPass.IconRightSize = New System.Drawing.Size(16, 16)
        Me.txtCadPass.Location = New System.Drawing.Point(172, 125)
        Me.txtCadPass.MaxLength = 18
        Me.txtCadPass.Name = "txtCadPass"
        Me.txtCadPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCadPass.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtCadPass.PlaceholderText = "Digite uma senha... *"
        Me.txtCadPass.SelectedText = ""
        Me.txtCadPass.ShadowDecoration.Parent = Me.txtCadPass
        Me.txtCadPass.Size = New System.Drawing.Size(350, 36)
        Me.txtCadPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCadPass.TabIndex = 163
        Me.txtCadPass.TextOffset = New System.Drawing.Point(5, 0)
        Me.txtCadPass.UseSystemPasswordChar = True
        '
        'txtCadConfPass
        '
        Me.txtCadConfPass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCadConfPass.Animated = True
        Me.txtCadConfPass.AutoRoundedCorners = True
        Me.txtCadConfPass.BackColor = System.Drawing.Color.Transparent
        Me.txtCadConfPass.BorderColor = System.Drawing.Color.DimGray
        Me.txtCadConfPass.BorderRadius = 17
        Me.txtCadConfPass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtCadConfPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCadConfPass.DefaultText = ""
        Me.txtCadConfPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCadConfPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCadConfPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCadConfPass.DisabledState.Parent = Me.txtCadConfPass
        Me.txtCadConfPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCadConfPass.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtCadConfPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtCadConfPass.FocusedState.Parent = Me.txtCadConfPass
        Me.txtCadConfPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCadConfPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCadConfPass.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtCadConfPass.HoverState.Parent = Me.txtCadConfPass
        Me.txtCadConfPass.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtCadConfPass.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtCadConfPass.IconRight = CType(resources.GetObject("txtCadConfPass.IconRight"), System.Drawing.Image)
        Me.txtCadConfPass.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.txtCadConfPass.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtCadConfPass.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtCadConfPass.Location = New System.Drawing.Point(172, 202)
        Me.txtCadConfPass.MaxLength = 18
        Me.txtCadConfPass.Name = "txtCadConfPass"
        Me.txtCadConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCadConfPass.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtCadConfPass.PlaceholderText = "Confirme a senha... *"
        Me.txtCadConfPass.SelectedText = ""
        Me.txtCadConfPass.ShadowDecoration.Parent = Me.txtCadConfPass
        Me.txtCadConfPass.Size = New System.Drawing.Size(350, 36)
        Me.txtCadConfPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCadConfPass.TabIndex = 164
        Me.txtCadConfPass.TextOffset = New System.Drawing.Point(5, 0)
        Me.txtCadConfPass.UseSystemPasswordChar = True
        '
        'tpPerfil
        '
        Me.tpPerfil.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpPerfil.Controls.Add(Me.pbWhats)
        Me.tpPerfil.Controls.Add(Me.pbEmail)
        Me.tpPerfil.Controls.Add(Me.pbTermos)
        Me.tpPerfil.Controls.Add(Me.lblPerfilUF)
        Me.tpPerfil.Controls.Add(Me.lblPerfilCidade)
        Me.tpPerfil.Controls.Add(Me.lblPerfilComplemento)
        Me.tpPerfil.Controls.Add(Me.lblPerfilCelular)
        Me.tpPerfil.Controls.Add(Me.lblPerfilGenero)
        Me.tpPerfil.Controls.Add(Me.lblPerfilEndereco)
        Me.tpPerfil.Controls.Add(Me.lblPerfilCep)
        Me.tpPerfil.Controls.Add(Me.lblPerfilNascimento)
        Me.tpPerfil.Controls.Add(Me.lblPerfilNome)
        Me.tpPerfil.Controls.Add(Me.txtPerfilNascimento)
        Me.tpPerfil.Controls.Add(Me.btnAvPerfil)
        Me.tpPerfil.Controls.Add(Me.btnVoltPerfil)
        Me.tpPerfil.Controls.Add(Me.lblPerfilEmail)
        Me.tpPerfil.Controls.Add(Me.lblPerfilTermos)
        Me.tpPerfil.Controls.Add(Me.lblPerfilAceptTermos)
        Me.tpPerfil.Controls.Add(Me.lblPerfilWhats)
        Me.tpPerfil.Controls.Add(Me.txtPerfilNome)
        Me.tpPerfil.Controls.Add(Me.txtPerfilCelular)
        Me.tpPerfil.Controls.Add(Me.txtPerfilEndereco)
        Me.tpPerfil.Controls.Add(Me.txtPerfilCep)
        Me.tpPerfil.Controls.Add(Me.txtPerfilComp)
        Me.tpPerfil.Controls.Add(Me.txtPerfilCidade)
        Me.tpPerfil.Controls.Add(Me.chkPerfilWhats)
        Me.tpPerfil.Controls.Add(Me.chkPerfilEmail)
        Me.tpPerfil.Controls.Add(Me.chkPerfilTermos)
        Me.tpPerfil.Controls.Add(Me.cbPerfilGenero)
        Me.tpPerfil.Controls.Add(Me.lblPerfilInf)
        Me.tpPerfil.Controls.Add(Me.txtPerfilUF)
        Me.tpPerfil.Location = New System.Drawing.Point(4, 4)
        Me.tpPerfil.Name = "tpPerfil"
        Me.tpPerfil.Size = New System.Drawing.Size(692, 505)
        Me.tpPerfil.TabIndex = 2
        Me.tpPerfil.Text = "Perfil"
        '
        'pbWhats
        '
        Me.pbWhats.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbWhats.BackColor = System.Drawing.Color.Transparent
        Me.pbWhats.Image = CType(resources.GetObject("pbWhats.Image"), System.Drawing.Image)
        Me.pbWhats.ImageRotate = 0!
        Me.pbWhats.Location = New System.Drawing.Point(59, 329)
        Me.pbWhats.Name = "pbWhats"
        Me.pbWhats.ShadowDecoration.Parent = Me.pbWhats
        Me.pbWhats.Size = New System.Drawing.Size(12, 12)
        Me.pbWhats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbWhats.TabIndex = 190
        Me.pbWhats.TabStop = False
        Me.pbWhats.Visible = False
        '
        'pbEmail
        '
        Me.pbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbEmail.BackColor = System.Drawing.Color.Transparent
        Me.pbEmail.Image = CType(resources.GetObject("pbEmail.Image"), System.Drawing.Image)
        Me.pbEmail.ImageRotate = 0!
        Me.pbEmail.Location = New System.Drawing.Point(59, 358)
        Me.pbEmail.Name = "pbEmail"
        Me.pbEmail.ShadowDecoration.Parent = Me.pbEmail
        Me.pbEmail.Size = New System.Drawing.Size(12, 12)
        Me.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEmail.TabIndex = 189
        Me.pbEmail.TabStop = False
        Me.pbEmail.Visible = False
        '
        'pbTermos
        '
        Me.pbTermos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbTermos.BackColor = System.Drawing.Color.Transparent
        Me.pbTermos.Image = CType(resources.GetObject("pbTermos.Image"), System.Drawing.Image)
        Me.pbTermos.ImageRotate = 0!
        Me.pbTermos.Location = New System.Drawing.Point(59, 387)
        Me.pbTermos.Name = "pbTermos"
        Me.pbTermos.ShadowDecoration.Parent = Me.pbTermos
        Me.pbTermos.Size = New System.Drawing.Size(12, 12)
        Me.pbTermos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbTermos.TabIndex = 188
        Me.pbTermos.TabStop = False
        Me.pbTermos.Visible = False
        '
        'lblPerfilUF
        '
        Me.lblPerfilUF.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilUF.AutoSize = True
        Me.lblPerfilUF.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilUF.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPerfilUF.ForeColor = System.Drawing.Color.Black
        Me.lblPerfilUF.Location = New System.Drawing.Point(552, 212)
        Me.lblPerfilUF.Name = "lblPerfilUF"
        Me.lblPerfilUF.Size = New System.Drawing.Size(21, 15)
        Me.lblPerfilUF.TabIndex = 187
        Me.lblPerfilUF.Text = "UF"
        Me.lblPerfilUF.Visible = False
        '
        'lblPerfilCidade
        '
        Me.lblPerfilCidade.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilCidade.AutoSize = True
        Me.lblPerfilCidade.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilCidade.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPerfilCidade.ForeColor = System.Drawing.Color.Black
        Me.lblPerfilCidade.Location = New System.Drawing.Point(281, 212)
        Me.lblPerfilCidade.Name = "lblPerfilCidade"
        Me.lblPerfilCidade.Size = New System.Drawing.Size(44, 15)
        Me.lblPerfilCidade.TabIndex = 186
        Me.lblPerfilCidade.Text = "Cidade"
        Me.lblPerfilCidade.Visible = False
        '
        'lblPerfilComplemento
        '
        Me.lblPerfilComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilComplemento.AutoSize = True
        Me.lblPerfilComplemento.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilComplemento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPerfilComplemento.ForeColor = System.Drawing.Color.Black
        Me.lblPerfilComplemento.Location = New System.Drawing.Point(56, 212)
        Me.lblPerfilComplemento.Name = "lblPerfilComplemento"
        Me.lblPerfilComplemento.Size = New System.Drawing.Size(84, 15)
        Me.lblPerfilComplemento.TabIndex = 185
        Me.lblPerfilComplemento.Text = "Complemento"
        Me.lblPerfilComplemento.Visible = False
        '
        'lblPerfilCelular
        '
        Me.lblPerfilCelular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilCelular.AutoSize = True
        Me.lblPerfilCelular.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilCelular.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPerfilCelular.ForeColor = System.Drawing.Color.Black
        Me.lblPerfilCelular.Location = New System.Drawing.Point(394, 79)
        Me.lblPerfilCelular.Name = "lblPerfilCelular"
        Me.lblPerfilCelular.Size = New System.Drawing.Size(44, 15)
        Me.lblPerfilCelular.TabIndex = 184
        Me.lblPerfilCelular.Text = "Celular"
        Me.lblPerfilCelular.Visible = False
        '
        'lblPerfilGenero
        '
        Me.lblPerfilGenero.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilGenero.AutoSize = True
        Me.lblPerfilGenero.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilGenero.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPerfilGenero.ForeColor = System.Drawing.Color.Black
        Me.lblPerfilGenero.Location = New System.Drawing.Point(230, 78)
        Me.lblPerfilGenero.Name = "lblPerfilGenero"
        Me.lblPerfilGenero.Size = New System.Drawing.Size(45, 15)
        Me.lblPerfilGenero.TabIndex = 183
        Me.lblPerfilGenero.Text = "Gênero"
        Me.lblPerfilGenero.Visible = False
        '
        'lblPerfilEndereco
        '
        Me.lblPerfilEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilEndereco.AutoSize = True
        Me.lblPerfilEndereco.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilEndereco.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPerfilEndereco.ForeColor = System.Drawing.Color.Black
        Me.lblPerfilEndereco.Location = New System.Drawing.Point(191, 145)
        Me.lblPerfilEndereco.Name = "lblPerfilEndereco"
        Me.lblPerfilEndereco.Size = New System.Drawing.Size(56, 15)
        Me.lblPerfilEndereco.TabIndex = 182
        Me.lblPerfilEndereco.Text = "Endereço"
        Me.lblPerfilEndereco.Visible = False
        '
        'lblPerfilCep
        '
        Me.lblPerfilCep.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilCep.AutoSize = True
        Me.lblPerfilCep.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilCep.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPerfilCep.ForeColor = System.Drawing.Color.Black
        Me.lblPerfilCep.Location = New System.Drawing.Point(56, 145)
        Me.lblPerfilCep.Name = "lblPerfilCep"
        Me.lblPerfilCep.Size = New System.Drawing.Size(28, 15)
        Me.lblPerfilCep.TabIndex = 181
        Me.lblPerfilCep.Text = "Cep"
        Me.lblPerfilCep.Visible = False
        '
        'lblPerfilNascimento
        '
        Me.lblPerfilNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilNascimento.AutoSize = True
        Me.lblPerfilNascimento.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilNascimento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPerfilNascimento.ForeColor = System.Drawing.Color.Black
        Me.lblPerfilNascimento.Location = New System.Drawing.Point(56, 78)
        Me.lblPerfilNascimento.Name = "lblPerfilNascimento"
        Me.lblPerfilNascimento.Size = New System.Drawing.Size(71, 15)
        Me.lblPerfilNascimento.TabIndex = 180
        Me.lblPerfilNascimento.Text = "Nascimento"
        Me.lblPerfilNascimento.Visible = False
        '
        'lblPerfilNome
        '
        Me.lblPerfilNome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilNome.AutoSize = True
        Me.lblPerfilNome.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilNome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPerfilNome.ForeColor = System.Drawing.Color.Black
        Me.lblPerfilNome.Location = New System.Drawing.Point(56, 12)
        Me.lblPerfilNome.Name = "lblPerfilNome"
        Me.lblPerfilNome.Size = New System.Drawing.Size(102, 15)
        Me.lblPerfilNome.TabIndex = 179
        Me.lblPerfilNome.Text = "Nome completo *"
        Me.lblPerfilNome.Visible = False
        '
        'txtPerfilNascimento
        '
        Me.txtPerfilNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPerfilNascimento.Animated = True
        Me.txtPerfilNascimento.AutoRoundedCorners = True
        Me.txtPerfilNascimento.BackColor = System.Drawing.Color.Transparent
        Me.txtPerfilNascimento.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilNascimento.BorderRadius = 17
        Me.txtPerfilNascimento.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtPerfilNascimento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPerfilNascimento.DefaultText = ""
        Me.txtPerfilNascimento.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilNascimento.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtPerfilNascimento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPerfilNascimento.DisabledState.Parent = Me.txtPerfilNascimento
        Me.txtPerfilNascimento.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPerfilNascimento.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtPerfilNascimento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtPerfilNascimento.FocusedState.Parent = Me.txtPerfilNascimento
        Me.txtPerfilNascimento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPerfilNascimento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPerfilNascimento.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilNascimento.HoverState.Parent = Me.txtPerfilNascimento
        Me.txtPerfilNascimento.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilNascimento.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtPerfilNascimento.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilNascimento.IconRightSize = New System.Drawing.Size(16, 16)
        Me.txtPerfilNascimento.Location = New System.Drawing.Point(55, 97)
        Me.txtPerfilNascimento.MaxLength = 8
        Me.txtPerfilNascimento.Name = "txtPerfilNascimento"
        Me.txtPerfilNascimento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPerfilNascimento.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPerfilNascimento.PlaceholderText = "Nascimento..."
        Me.txtPerfilNascimento.SelectedText = ""
        Me.txtPerfilNascimento.ShadowDecoration.Parent = Me.txtPerfilNascimento
        Me.txtPerfilNascimento.Size = New System.Drawing.Size(166, 36)
        Me.txtPerfilNascimento.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPerfilNascimento.TabIndex = 161
        Me.txtPerfilNascimento.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnAvPerfil
        '
        Me.btnAvPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAvPerfil.Animated = True
        Me.btnAvPerfil.BackColor = System.Drawing.Color.Transparent
        Me.btnAvPerfil.BorderRadius = 18
        Me.btnAvPerfil.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnAvPerfil.CheckedState.Parent = Me.btnAvPerfil
        Me.btnAvPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAvPerfil.CustomImages.Parent = Me.btnAvPerfil
        Me.btnAvPerfil.DisabledState.Parent = Me.btnAvPerfil
        Me.btnAvPerfil.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnAvPerfil.FillColor2 = System.Drawing.Color.Black
        Me.btnAvPerfil.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAvPerfil.ForeColor = System.Drawing.Color.White
        Me.btnAvPerfil.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnAvPerfil.HoverState.Parent = Me.btnAvPerfil
        Me.btnAvPerfil.Location = New System.Drawing.Point(350, 431)
        Me.btnAvPerfil.Name = "btnAvPerfil"
        Me.btnAvPerfil.ShadowDecoration.Parent = Me.btnAvPerfil
        Me.btnAvPerfil.Size = New System.Drawing.Size(124, 38)
        Me.btnAvPerfil.TabIndex = 172
        Me.btnAvPerfil.Text = "AVANÇAR"
        '
        'btnVoltPerfil
        '
        Me.btnVoltPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnVoltPerfil.Animated = True
        Me.btnVoltPerfil.BackColor = System.Drawing.Color.Transparent
        Me.btnVoltPerfil.BorderRadius = 18
        Me.btnVoltPerfil.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnVoltPerfil.CausesValidation = False
        Me.btnVoltPerfil.CheckedState.Parent = Me.btnVoltPerfil
        Me.btnVoltPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoltPerfil.CustomImages.Parent = Me.btnVoltPerfil
        Me.btnVoltPerfil.DisabledState.Parent = Me.btnVoltPerfil
        Me.btnVoltPerfil.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnVoltPerfil.FillColor2 = System.Drawing.Color.Black
        Me.btnVoltPerfil.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnVoltPerfil.ForeColor = System.Drawing.Color.White
        Me.btnVoltPerfil.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnVoltPerfil.HoverState.Parent = Me.btnVoltPerfil
        Me.btnVoltPerfil.Location = New System.Drawing.Point(219, 431)
        Me.btnVoltPerfil.Name = "btnVoltPerfil"
        Me.btnVoltPerfil.ShadowDecoration.Parent = Me.btnVoltPerfil
        Me.btnVoltPerfil.Size = New System.Drawing.Size(124, 38)
        Me.btnVoltPerfil.TabIndex = 173
        Me.btnVoltPerfil.Text = "VOLTAR"
        '
        'lblPerfilEmail
        '
        Me.lblPerfilEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.lblPerfilEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilEmail.AutoSize = True
        Me.lblPerfilEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPerfilEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfilEmail.ForeColor = System.Drawing.Color.Black
        Me.lblPerfilEmail.Location = New System.Drawing.Point(96, 360)
        Me.lblPerfilEmail.Name = "lblPerfilEmail"
        Me.lblPerfilEmail.Size = New System.Drawing.Size(206, 15)
        Me.lblPerfilEmail.TabIndex = 177
        Me.lblPerfilEmail.Text = "Desejo receber notificações no E-mail"
        '
        'lblPerfilTermos
        '
        Me.lblPerfilTermos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilTermos.AutoSize = True
        Me.lblPerfilTermos.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilTermos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfilTermos.LinkColor = System.Drawing.Color.DodgerBlue
        Me.lblPerfilTermos.Location = New System.Drawing.Point(476, 291)
        Me.lblPerfilTermos.Name = "lblPerfilTermos"
        Me.lblPerfilTermos.Size = New System.Drawing.Size(112, 15)
        Me.lblPerfilTermos.TabIndex = 176
        Me.lblPerfilTermos.TabStop = True
        Me.lblPerfilTermos.Text = "Termos e condições"
        '
        'lblPerfilAceptTermos
        '
        Me.lblPerfilAceptTermos.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.lblPerfilAceptTermos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilAceptTermos.AutoSize = True
        Me.lblPerfilAceptTermos.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilAceptTermos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPerfilAceptTermos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfilAceptTermos.ForeColor = System.Drawing.Color.Black
        Me.lblPerfilAceptTermos.Location = New System.Drawing.Point(96, 389)
        Me.lblPerfilAceptTermos.Name = "lblPerfilAceptTermos"
        Me.lblPerfilAceptTermos.Size = New System.Drawing.Size(377, 15)
        Me.lblPerfilAceptTermos.TabIndex = 175
        Me.lblPerfilAceptTermos.Text = "Li e estou de acordo com os termos de uso e políticas de privacidade *"
        '
        'lblPerfilWhats
        '
        Me.lblPerfilWhats.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.lblPerfilWhats.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilWhats.AutoSize = True
        Me.lblPerfilWhats.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilWhats.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPerfilWhats.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfilWhats.ForeColor = System.Drawing.Color.Black
        Me.lblPerfilWhats.Location = New System.Drawing.Point(96, 331)
        Me.lblPerfilWhats.Name = "lblPerfilWhats"
        Me.lblPerfilWhats.Size = New System.Drawing.Size(223, 15)
        Me.lblPerfilWhats.TabIndex = 174
        Me.lblPerfilWhats.Text = "Desejo receber notificações no whatsapp"
        '
        'txtPerfilNome
        '
        Me.txtPerfilNome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPerfilNome.Animated = True
        Me.txtPerfilNome.AutoRoundedCorners = True
        Me.txtPerfilNome.BackColor = System.Drawing.Color.Transparent
        Me.txtPerfilNome.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilNome.BorderRadius = 17
        Me.txtPerfilNome.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtPerfilNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPerfilNome.DefaultText = ""
        Me.txtPerfilNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPerfilNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPerfilNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilNome.DisabledState.Parent = Me.txtPerfilNome
        Me.txtPerfilNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilNome.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtPerfilNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtPerfilNome.FocusedState.Parent = Me.txtPerfilNome
        Me.txtPerfilNome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPerfilNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPerfilNome.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilNome.HoverState.Parent = Me.txtPerfilNome
        Me.txtPerfilNome.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilNome.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtPerfilNome.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilNome.IconRightSize = New System.Drawing.Size(16, 16)
        Me.txtPerfilNome.Location = New System.Drawing.Point(55, 30)
        Me.txtPerfilNome.Name = "txtPerfilNome"
        Me.txtPerfilNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPerfilNome.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPerfilNome.PlaceholderText = "Digite seu nome completo... *"
        Me.txtPerfilNome.SelectedText = ""
        Me.txtPerfilNome.ShadowDecoration.Parent = Me.txtPerfilNome
        Me.txtPerfilNome.Size = New System.Drawing.Size(582, 36)
        Me.txtPerfilNome.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPerfilNome.TabIndex = 160
        Me.txtPerfilNome.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtPerfilCelular
        '
        Me.txtPerfilCelular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPerfilCelular.Animated = True
        Me.txtPerfilCelular.AutoRoundedCorners = True
        Me.txtPerfilCelular.BackColor = System.Drawing.Color.Transparent
        Me.txtPerfilCelular.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilCelular.BorderRadius = 17
        Me.txtPerfilCelular.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtPerfilCelular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPerfilCelular.DefaultText = ""
        Me.txtPerfilCelular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPerfilCelular.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPerfilCelular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilCelular.DisabledState.Parent = Me.txtPerfilCelular
        Me.txtPerfilCelular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilCelular.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtPerfilCelular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtPerfilCelular.FocusedState.Parent = Me.txtPerfilCelular
        Me.txtPerfilCelular.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPerfilCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPerfilCelular.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilCelular.HoverState.Parent = Me.txtPerfilCelular
        Me.txtPerfilCelular.IconLeft = CType(resources.GetObject("txtPerfilCelular.IconLeft"), System.Drawing.Image)
        Me.txtPerfilCelular.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilCelular.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtPerfilCelular.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilCelular.IconRightSize = New System.Drawing.Size(16, 16)
        Me.txtPerfilCelular.Location = New System.Drawing.Point(393, 97)
        Me.txtPerfilCelular.MaxLength = 16
        Me.txtPerfilCelular.Name = "txtPerfilCelular"
        Me.txtPerfilCelular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPerfilCelular.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPerfilCelular.PlaceholderText = "Digite seu celular..."
        Me.txtPerfilCelular.SelectedText = ""
        Me.txtPerfilCelular.ShadowDecoration.Parent = Me.txtPerfilCelular
        Me.txtPerfilCelular.Size = New System.Drawing.Size(244, 36)
        Me.txtPerfilCelular.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPerfilCelular.TabIndex = 163
        Me.txtPerfilCelular.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtPerfilEndereco
        '
        Me.txtPerfilEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPerfilEndereco.Animated = True
        Me.txtPerfilEndereco.AutoRoundedCorners = True
        Me.txtPerfilEndereco.BackColor = System.Drawing.Color.Transparent
        Me.txtPerfilEndereco.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilEndereco.BorderRadius = 17
        Me.txtPerfilEndereco.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtPerfilEndereco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPerfilEndereco.DefaultText = ""
        Me.txtPerfilEndereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPerfilEndereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPerfilEndereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilEndereco.DisabledState.Parent = Me.txtPerfilEndereco
        Me.txtPerfilEndereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilEndereco.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtPerfilEndereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtPerfilEndereco.FocusedState.Parent = Me.txtPerfilEndereco
        Me.txtPerfilEndereco.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPerfilEndereco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPerfilEndereco.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilEndereco.HoverState.Parent = Me.txtPerfilEndereco
        Me.txtPerfilEndereco.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilEndereco.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtPerfilEndereco.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilEndereco.IconRightSize = New System.Drawing.Size(16, 16)
        Me.txtPerfilEndereco.Location = New System.Drawing.Point(194, 164)
        Me.txtPerfilEndereco.Name = "txtPerfilEndereco"
        Me.txtPerfilEndereco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPerfilEndereco.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPerfilEndereco.PlaceholderText = "Digite seu endereço..."
        Me.txtPerfilEndereco.SelectedText = ""
        Me.txtPerfilEndereco.ShadowDecoration.Parent = Me.txtPerfilEndereco
        Me.txtPerfilEndereco.Size = New System.Drawing.Size(443, 36)
        Me.txtPerfilEndereco.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPerfilEndereco.TabIndex = 165
        Me.txtPerfilEndereco.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtPerfilCep
        '
        Me.txtPerfilCep.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPerfilCep.Animated = True
        Me.txtPerfilCep.AutoRoundedCorners = True
        Me.txtPerfilCep.BackColor = System.Drawing.Color.Transparent
        Me.txtPerfilCep.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilCep.BorderRadius = 17
        Me.txtPerfilCep.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtPerfilCep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPerfilCep.DefaultText = ""
        Me.txtPerfilCep.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPerfilCep.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPerfilCep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilCep.DisabledState.Parent = Me.txtPerfilCep
        Me.txtPerfilCep.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilCep.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtPerfilCep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtPerfilCep.FocusedState.Parent = Me.txtPerfilCep
        Me.txtPerfilCep.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPerfilCep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPerfilCep.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilCep.HoverState.Parent = Me.txtPerfilCep
        Me.txtPerfilCep.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilCep.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtPerfilCep.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilCep.IconRightSize = New System.Drawing.Size(16, 16)
        Me.txtPerfilCep.Location = New System.Drawing.Point(55, 164)
        Me.txtPerfilCep.MaxLength = 9
        Me.txtPerfilCep.Name = "txtPerfilCep"
        Me.txtPerfilCep.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPerfilCep.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPerfilCep.PlaceholderText = "CEP..."
        Me.txtPerfilCep.SelectedText = ""
        Me.txtPerfilCep.ShadowDecoration.Parent = Me.txtPerfilCep
        Me.txtPerfilCep.Size = New System.Drawing.Size(133, 36)
        Me.txtPerfilCep.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPerfilCep.TabIndex = 164
        Me.txtPerfilCep.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtPerfilComp
        '
        Me.txtPerfilComp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPerfilComp.Animated = True
        Me.txtPerfilComp.AutoRoundedCorners = True
        Me.txtPerfilComp.BackColor = System.Drawing.Color.Transparent
        Me.txtPerfilComp.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilComp.BorderRadius = 17
        Me.txtPerfilComp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtPerfilComp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPerfilComp.DefaultText = ""
        Me.txtPerfilComp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPerfilComp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPerfilComp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilComp.DisabledState.Parent = Me.txtPerfilComp
        Me.txtPerfilComp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilComp.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtPerfilComp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtPerfilComp.FocusedState.Parent = Me.txtPerfilComp
        Me.txtPerfilComp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPerfilComp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPerfilComp.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilComp.HoverState.Parent = Me.txtPerfilComp
        Me.txtPerfilComp.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilComp.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtPerfilComp.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilComp.IconRightSize = New System.Drawing.Size(16, 16)
        Me.txtPerfilComp.Location = New System.Drawing.Point(55, 231)
        Me.txtPerfilComp.Name = "txtPerfilComp"
        Me.txtPerfilComp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPerfilComp.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPerfilComp.PlaceholderText = "Digite um complemento..."
        Me.txtPerfilComp.SelectedText = ""
        Me.txtPerfilComp.ShadowDecoration.Parent = Me.txtPerfilComp
        Me.txtPerfilComp.Size = New System.Drawing.Size(219, 36)
        Me.txtPerfilComp.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPerfilComp.TabIndex = 166
        Me.txtPerfilComp.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtPerfilCidade
        '
        Me.txtPerfilCidade.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPerfilCidade.Animated = True
        Me.txtPerfilCidade.AutoRoundedCorners = True
        Me.txtPerfilCidade.BackColor = System.Drawing.Color.Transparent
        Me.txtPerfilCidade.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilCidade.BorderRadius = 17
        Me.txtPerfilCidade.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtPerfilCidade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPerfilCidade.DefaultText = ""
        Me.txtPerfilCidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPerfilCidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPerfilCidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilCidade.DisabledState.Parent = Me.txtPerfilCidade
        Me.txtPerfilCidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilCidade.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtPerfilCidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtPerfilCidade.FocusedState.Parent = Me.txtPerfilCidade
        Me.txtPerfilCidade.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPerfilCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPerfilCidade.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilCidade.HoverState.Parent = Me.txtPerfilCidade
        Me.txtPerfilCidade.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilCidade.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtPerfilCidade.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilCidade.IconRightSize = New System.Drawing.Size(16, 16)
        Me.txtPerfilCidade.Location = New System.Drawing.Point(280, 231)
        Me.txtPerfilCidade.Name = "txtPerfilCidade"
        Me.txtPerfilCidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPerfilCidade.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPerfilCidade.PlaceholderText = "Digite a cidade..."
        Me.txtPerfilCidade.SelectedText = ""
        Me.txtPerfilCidade.ShadowDecoration.Parent = Me.txtPerfilCidade
        Me.txtPerfilCidade.Size = New System.Drawing.Size(265, 36)
        Me.txtPerfilCidade.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPerfilCidade.TabIndex = 167
        Me.txtPerfilCidade.TextOffset = New System.Drawing.Point(5, 0)
        '
        'chkPerfilWhats
        '
        Me.chkPerfilWhats.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkPerfilWhats.BackColor = System.Drawing.Color.Transparent
        Me.chkPerfilWhats.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.chkPerfilWhats.CheckedState.BorderRadius = 3
        Me.chkPerfilWhats.CheckedState.BorderThickness = 1
        Me.chkPerfilWhats.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.chkPerfilWhats.CheckedState.Parent = Me.chkPerfilWhats
        Me.chkPerfilWhats.Location = New System.Drawing.Point(73, 329)
        Me.chkPerfilWhats.Name = "chkPerfilWhats"
        Me.chkPerfilWhats.ShadowDecoration.Parent = Me.chkPerfilWhats
        Me.chkPerfilWhats.Size = New System.Drawing.Size(20, 20)
        Me.chkPerfilWhats.TabIndex = 169
        Me.chkPerfilWhats.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkPerfilWhats.UncheckedState.BorderRadius = 3
        Me.chkPerfilWhats.UncheckedState.BorderThickness = 1
        Me.chkPerfilWhats.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.chkPerfilWhats.UncheckedState.Parent = Me.chkPerfilWhats
        Me.chkPerfilWhats.UseTransparentBackground = True
        '
        'chkPerfilEmail
        '
        Me.chkPerfilEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkPerfilEmail.BackColor = System.Drawing.Color.Transparent
        Me.chkPerfilEmail.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.chkPerfilEmail.CheckedState.BorderRadius = 3
        Me.chkPerfilEmail.CheckedState.BorderThickness = 1
        Me.chkPerfilEmail.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.chkPerfilEmail.CheckedState.Parent = Me.chkPerfilEmail
        Me.chkPerfilEmail.Location = New System.Drawing.Point(73, 358)
        Me.chkPerfilEmail.Name = "chkPerfilEmail"
        Me.chkPerfilEmail.ShadowDecoration.Parent = Me.chkPerfilEmail
        Me.chkPerfilEmail.Size = New System.Drawing.Size(20, 20)
        Me.chkPerfilEmail.TabIndex = 170
        Me.chkPerfilEmail.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkPerfilEmail.UncheckedState.BorderRadius = 3
        Me.chkPerfilEmail.UncheckedState.BorderThickness = 1
        Me.chkPerfilEmail.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.chkPerfilEmail.UncheckedState.Parent = Me.chkPerfilEmail
        Me.chkPerfilEmail.UseTransparentBackground = True
        '
        'chkPerfilTermos
        '
        Me.chkPerfilTermos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkPerfilTermos.BackColor = System.Drawing.Color.Transparent
        Me.chkPerfilTermos.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.chkPerfilTermos.CheckedState.BorderRadius = 3
        Me.chkPerfilTermos.CheckedState.BorderThickness = 1
        Me.chkPerfilTermos.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.chkPerfilTermos.CheckedState.Parent = Me.chkPerfilTermos
        Me.chkPerfilTermos.Location = New System.Drawing.Point(73, 387)
        Me.chkPerfilTermos.Name = "chkPerfilTermos"
        Me.chkPerfilTermos.ShadowDecoration.Parent = Me.chkPerfilTermos
        Me.chkPerfilTermos.Size = New System.Drawing.Size(20, 20)
        Me.chkPerfilTermos.TabIndex = 171
        Me.chkPerfilTermos.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkPerfilTermos.UncheckedState.BorderRadius = 3
        Me.chkPerfilTermos.UncheckedState.BorderThickness = 1
        Me.chkPerfilTermos.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.chkPerfilTermos.UncheckedState.Parent = Me.chkPerfilTermos
        Me.chkPerfilTermos.UseTransparentBackground = True
        '
        'cbPerfilGenero
        '
        Me.cbPerfilGenero.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbPerfilGenero.BackColor = System.Drawing.Color.Transparent
        Me.cbPerfilGenero.BorderColor = System.Drawing.Color.Gray
        Me.cbPerfilGenero.BorderRadius = 17
        Me.cbPerfilGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbPerfilGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPerfilGenero.FillColor = System.Drawing.Color.WhiteSmoke
        Me.cbPerfilGenero.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.cbPerfilGenero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.cbPerfilGenero.FocusedState.Parent = Me.cbPerfilGenero
        Me.cbPerfilGenero.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbPerfilGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbPerfilGenero.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.cbPerfilGenero.HoverState.Parent = Me.cbPerfilGenero
        Me.cbPerfilGenero.ItemHeight = 30
        Me.cbPerfilGenero.Items.AddRange(New Object() {"Feminino", "Masculino", "Personalizado"})
        Me.cbPerfilGenero.ItemsAppearance.Parent = Me.cbPerfilGenero
        Me.cbPerfilGenero.Location = New System.Drawing.Point(229, 97)
        Me.cbPerfilGenero.Name = "cbPerfilGenero"
        Me.cbPerfilGenero.ShadowDecoration.Parent = Me.cbPerfilGenero
        Me.cbPerfilGenero.Size = New System.Drawing.Size(156, 36)
        Me.cbPerfilGenero.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbPerfilGenero.TabIndex = 162
        Me.cbPerfilGenero.TextOffset = New System.Drawing.Point(5, 0)
        Me.cbPerfilGenero.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'lblPerfilInf
        '
        Me.lblPerfilInf.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPerfilInf.AutoSize = False
        Me.lblPerfilInf.BackColor = System.Drawing.Color.Transparent
        Me.lblPerfilInf.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPerfilInf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPerfilInf.Location = New System.Drawing.Point(67, 276)
        Me.lblPerfilInf.Name = "lblPerfilInf"
        Me.lblPerfilInf.Size = New System.Drawing.Size(558, 54)
        Me.lblPerfilInf.TabIndex = 178
        Me.lblPerfilInf.Text = "Vamos manter os seus dados só enquanto assim o pretender. Ficarão sempre em segur" &
    "ança e a qualquer momento pode deixar de receber nossas mensagens ou editar os s" &
    "eus dados. "
        '
        'txtPerfilUF
        '
        Me.txtPerfilUF.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPerfilUF.Animated = True
        Me.txtPerfilUF.AutoRoundedCorners = True
        Me.txtPerfilUF.BackColor = System.Drawing.Color.Transparent
        Me.txtPerfilUF.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilUF.BorderRadius = 17
        Me.txtPerfilUF.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtPerfilUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPerfilUF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPerfilUF.DefaultText = ""
        Me.txtPerfilUF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPerfilUF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPerfilUF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilUF.DisabledState.Parent = Me.txtPerfilUF
        Me.txtPerfilUF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPerfilUF.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtPerfilUF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtPerfilUF.FocusedState.Parent = Me.txtPerfilUF
        Me.txtPerfilUF.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPerfilUF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPerfilUF.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtPerfilUF.HoverState.Parent = Me.txtPerfilUF
        Me.txtPerfilUF.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilUF.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtPerfilUF.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtPerfilUF.IconRightSize = New System.Drawing.Size(16, 16)
        Me.txtPerfilUF.Location = New System.Drawing.Point(551, 231)
        Me.txtPerfilUF.MaxLength = 2
        Me.txtPerfilUF.Name = "txtPerfilUF"
        Me.txtPerfilUF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPerfilUF.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPerfilUF.PlaceholderText = "UF..."
        Me.txtPerfilUF.SelectedText = ""
        Me.txtPerfilUF.ShadowDecoration.Parent = Me.txtPerfilUF
        Me.txtPerfilUF.Size = New System.Drawing.Size(86, 36)
        Me.txtPerfilUF.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPerfilUF.TabIndex = 168
        Me.txtPerfilUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPerfilUF.TextOffset = New System.Drawing.Point(5, 0)
        '
        'tpBusiness
        '
        Me.tpBusiness.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpBusiness.Controls.Add(Me.lblBusinessRmal)
        Me.tpBusiness.Controls.Add(Me.lblBusinessTelefone)
        Me.tpBusiness.Controls.Add(Me.lblBusinessFuncao)
        Me.tpBusiness.Controls.Add(Me.lblBusinessDepart)
        Me.tpBusiness.Controls.Add(Me.lblBusinessEmpresa)
        Me.tpBusiness.Controls.Add(Me.btnAvBusiness)
        Me.tpBusiness.Controls.Add(Me.btnVoltBusiness)
        Me.tpBusiness.Controls.Add(Me.txtBusinessEmpresa)
        Me.tpBusiness.Controls.Add(Me.txtBusinessDepart)
        Me.tpBusiness.Controls.Add(Me.txtBusinessFuncao)
        Me.tpBusiness.Controls.Add(Me.txtBusinessTel)
        Me.tpBusiness.Controls.Add(Me.txtBusinessRamal)
        Me.tpBusiness.Location = New System.Drawing.Point(4, 4)
        Me.tpBusiness.Name = "tpBusiness"
        Me.tpBusiness.Size = New System.Drawing.Size(692, 505)
        Me.tpBusiness.TabIndex = 3
        Me.tpBusiness.Text = "Business"
        '
        'lblBusinessRmal
        '
        Me.lblBusinessRmal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBusinessRmal.AutoSize = True
        Me.lblBusinessRmal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBusinessRmal.ForeColor = System.Drawing.Color.Black
        Me.lblBusinessRmal.Location = New System.Drawing.Point(165, 291)
        Me.lblBusinessRmal.Name = "lblBusinessRmal"
        Me.lblBusinessRmal.Size = New System.Drawing.Size(40, 15)
        Me.lblBusinessRmal.TabIndex = 167
        Me.lblBusinessRmal.Text = "Ramal"
        Me.lblBusinessRmal.Visible = False
        '
        'lblBusinessTelefone
        '
        Me.lblBusinessTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBusinessTelefone.AutoSize = True
        Me.lblBusinessTelefone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBusinessTelefone.ForeColor = System.Drawing.Color.Black
        Me.lblBusinessTelefone.Location = New System.Drawing.Point(165, 224)
        Me.lblBusinessTelefone.Name = "lblBusinessTelefone"
        Me.lblBusinessTelefone.Size = New System.Drawing.Size(51, 15)
        Me.lblBusinessTelefone.TabIndex = 168
        Me.lblBusinessTelefone.Text = "Telefone"
        Me.lblBusinessTelefone.Visible = False
        '
        'lblBusinessFuncao
        '
        Me.lblBusinessFuncao.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBusinessFuncao.AutoSize = True
        Me.lblBusinessFuncao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBusinessFuncao.ForeColor = System.Drawing.Color.Black
        Me.lblBusinessFuncao.Location = New System.Drawing.Point(165, 159)
        Me.lblBusinessFuncao.Name = "lblBusinessFuncao"
        Me.lblBusinessFuncao.Size = New System.Drawing.Size(46, 15)
        Me.lblBusinessFuncao.TabIndex = 169
        Me.lblBusinessFuncao.Text = "Função"
        Me.lblBusinessFuncao.Visible = False
        '
        'lblBusinessDepart
        '
        Me.lblBusinessDepart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBusinessDepart.AutoSize = True
        Me.lblBusinessDepart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBusinessDepart.ForeColor = System.Drawing.Color.Black
        Me.lblBusinessDepart.Location = New System.Drawing.Point(165, 92)
        Me.lblBusinessDepart.Name = "lblBusinessDepart"
        Me.lblBusinessDepart.Size = New System.Drawing.Size(83, 15)
        Me.lblBusinessDepart.TabIndex = 170
        Me.lblBusinessDepart.Text = "Departamento"
        Me.lblBusinessDepart.Visible = False
        '
        'lblBusinessEmpresa
        '
        Me.lblBusinessEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBusinessEmpresa.AutoSize = True
        Me.lblBusinessEmpresa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBusinessEmpresa.ForeColor = System.Drawing.Color.Black
        Me.lblBusinessEmpresa.Location = New System.Drawing.Point(165, 26)
        Me.lblBusinessEmpresa.Name = "lblBusinessEmpresa"
        Me.lblBusinessEmpresa.Size = New System.Drawing.Size(52, 15)
        Me.lblBusinessEmpresa.TabIndex = 171
        Me.lblBusinessEmpresa.Text = "Empresa"
        Me.lblBusinessEmpresa.Visible = False
        '
        'btnAvBusiness
        '
        Me.btnAvBusiness.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAvBusiness.Animated = True
        Me.btnAvBusiness.BackColor = System.Drawing.Color.Transparent
        Me.btnAvBusiness.BorderRadius = 18
        Me.btnAvBusiness.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnAvBusiness.CausesValidation = False
        Me.btnAvBusiness.CheckedState.Parent = Me.btnAvBusiness
        Me.btnAvBusiness.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAvBusiness.CustomImages.Parent = Me.btnAvBusiness
        Me.btnAvBusiness.DisabledState.Parent = Me.btnAvBusiness
        Me.btnAvBusiness.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnAvBusiness.FillColor2 = System.Drawing.Color.Black
        Me.btnAvBusiness.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAvBusiness.ForeColor = System.Drawing.Color.White
        Me.btnAvBusiness.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnAvBusiness.HoverState.Parent = Me.btnAvBusiness
        Me.btnAvBusiness.Location = New System.Drawing.Point(350, 431)
        Me.btnAvBusiness.Name = "btnAvBusiness"
        Me.btnAvBusiness.ShadowDecoration.Parent = Me.btnAvBusiness
        Me.btnAvBusiness.Size = New System.Drawing.Size(124, 38)
        Me.btnAvBusiness.TabIndex = 165
        Me.btnAvBusiness.Text = "AVANÇAR"
        '
        'btnVoltBusiness
        '
        Me.btnVoltBusiness.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnVoltBusiness.Animated = True
        Me.btnVoltBusiness.BackColor = System.Drawing.Color.Transparent
        Me.btnVoltBusiness.BorderRadius = 18
        Me.btnVoltBusiness.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnVoltBusiness.CausesValidation = False
        Me.btnVoltBusiness.CheckedState.Parent = Me.btnVoltBusiness
        Me.btnVoltBusiness.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoltBusiness.CustomImages.Parent = Me.btnVoltBusiness
        Me.btnVoltBusiness.DisabledState.Parent = Me.btnVoltBusiness
        Me.btnVoltBusiness.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnVoltBusiness.FillColor2 = System.Drawing.Color.Black
        Me.btnVoltBusiness.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnVoltBusiness.ForeColor = System.Drawing.Color.White
        Me.btnVoltBusiness.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnVoltBusiness.HoverState.Parent = Me.btnVoltBusiness
        Me.btnVoltBusiness.Location = New System.Drawing.Point(219, 431)
        Me.btnVoltBusiness.Name = "btnVoltBusiness"
        Me.btnVoltBusiness.ShadowDecoration.Parent = Me.btnVoltBusiness
        Me.btnVoltBusiness.Size = New System.Drawing.Size(124, 38)
        Me.btnVoltBusiness.TabIndex = 166
        Me.btnVoltBusiness.Text = "VOLTAR"
        '
        'txtBusinessEmpresa
        '
        Me.txtBusinessEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBusinessEmpresa.Animated = True
        Me.txtBusinessEmpresa.AutoRoundedCorners = True
        Me.txtBusinessEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.txtBusinessEmpresa.BorderColor = System.Drawing.Color.Gray
        Me.txtBusinessEmpresa.BorderRadius = 17
        Me.txtBusinessEmpresa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtBusinessEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBusinessEmpresa.DefaultText = ""
        Me.txtBusinessEmpresa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBusinessEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBusinessEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusinessEmpresa.DisabledState.Parent = Me.txtBusinessEmpresa
        Me.txtBusinessEmpresa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusinessEmpresa.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtBusinessEmpresa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtBusinessEmpresa.FocusedState.Parent = Me.txtBusinessEmpresa
        Me.txtBusinessEmpresa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBusinessEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBusinessEmpresa.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtBusinessEmpresa.HoverState.Parent = Me.txtBusinessEmpresa
        Me.txtBusinessEmpresa.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtBusinessEmpresa.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtBusinessEmpresa.Location = New System.Drawing.Point(164, 44)
        Me.txtBusinessEmpresa.Name = "txtBusinessEmpresa"
        Me.txtBusinessEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusinessEmpresa.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtBusinessEmpresa.PlaceholderText = "Digite o nome da empresa..."
        Me.txtBusinessEmpresa.SelectedText = ""
        Me.txtBusinessEmpresa.ShadowDecoration.Parent = Me.txtBusinessEmpresa
        Me.txtBusinessEmpresa.Size = New System.Drawing.Size(364, 36)
        Me.txtBusinessEmpresa.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtBusinessEmpresa.TabIndex = 160
        Me.txtBusinessEmpresa.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtBusinessDepart
        '
        Me.txtBusinessDepart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBusinessDepart.Animated = True
        Me.txtBusinessDepart.AutoRoundedCorners = True
        Me.txtBusinessDepart.BackColor = System.Drawing.Color.Transparent
        Me.txtBusinessDepart.BorderColor = System.Drawing.Color.Gray
        Me.txtBusinessDepart.BorderRadius = 17
        Me.txtBusinessDepart.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtBusinessDepart.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBusinessDepart.DefaultText = ""
        Me.txtBusinessDepart.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBusinessDepart.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBusinessDepart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusinessDepart.DisabledState.Parent = Me.txtBusinessDepart
        Me.txtBusinessDepart.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusinessDepart.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtBusinessDepart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtBusinessDepart.FocusedState.Parent = Me.txtBusinessDepart
        Me.txtBusinessDepart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBusinessDepart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBusinessDepart.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtBusinessDepart.HoverState.Parent = Me.txtBusinessDepart
        Me.txtBusinessDepart.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtBusinessDepart.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtBusinessDepart.Location = New System.Drawing.Point(164, 110)
        Me.txtBusinessDepart.Name = "txtBusinessDepart"
        Me.txtBusinessDepart.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusinessDepart.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtBusinessDepart.PlaceholderText = "Digite seu departamento..."
        Me.txtBusinessDepart.SelectedText = ""
        Me.txtBusinessDepart.ShadowDecoration.Parent = Me.txtBusinessDepart
        Me.txtBusinessDepart.Size = New System.Drawing.Size(364, 36)
        Me.txtBusinessDepart.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtBusinessDepart.TabIndex = 161
        Me.txtBusinessDepart.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtBusinessFuncao
        '
        Me.txtBusinessFuncao.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBusinessFuncao.Animated = True
        Me.txtBusinessFuncao.AutoRoundedCorners = True
        Me.txtBusinessFuncao.BackColor = System.Drawing.Color.Transparent
        Me.txtBusinessFuncao.BorderColor = System.Drawing.Color.Gray
        Me.txtBusinessFuncao.BorderRadius = 17
        Me.txtBusinessFuncao.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtBusinessFuncao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBusinessFuncao.DefaultText = ""
        Me.txtBusinessFuncao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBusinessFuncao.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBusinessFuncao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusinessFuncao.DisabledState.Parent = Me.txtBusinessFuncao
        Me.txtBusinessFuncao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusinessFuncao.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtBusinessFuncao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtBusinessFuncao.FocusedState.Parent = Me.txtBusinessFuncao
        Me.txtBusinessFuncao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBusinessFuncao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBusinessFuncao.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtBusinessFuncao.HoverState.Parent = Me.txtBusinessFuncao
        Me.txtBusinessFuncao.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtBusinessFuncao.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtBusinessFuncao.Location = New System.Drawing.Point(165, 177)
        Me.txtBusinessFuncao.Name = "txtBusinessFuncao"
        Me.txtBusinessFuncao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusinessFuncao.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtBusinessFuncao.PlaceholderText = "Digite sua função..."
        Me.txtBusinessFuncao.SelectedText = ""
        Me.txtBusinessFuncao.ShadowDecoration.Parent = Me.txtBusinessFuncao
        Me.txtBusinessFuncao.Size = New System.Drawing.Size(362, 36)
        Me.txtBusinessFuncao.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtBusinessFuncao.TabIndex = 162
        Me.txtBusinessFuncao.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtBusinessTel
        '
        Me.txtBusinessTel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBusinessTel.Animated = True
        Me.txtBusinessTel.AutoRoundedCorners = True
        Me.txtBusinessTel.BackColor = System.Drawing.Color.Transparent
        Me.txtBusinessTel.BorderColor = System.Drawing.Color.Gray
        Me.txtBusinessTel.BorderRadius = 17
        Me.txtBusinessTel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtBusinessTel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBusinessTel.DefaultText = ""
        Me.txtBusinessTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBusinessTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBusinessTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusinessTel.DisabledState.Parent = Me.txtBusinessTel
        Me.txtBusinessTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusinessTel.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtBusinessTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtBusinessTel.FocusedState.Parent = Me.txtBusinessTel
        Me.txtBusinessTel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBusinessTel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBusinessTel.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtBusinessTel.HoverState.Parent = Me.txtBusinessTel
        Me.txtBusinessTel.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtBusinessTel.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtBusinessTel.Location = New System.Drawing.Point(164, 242)
        Me.txtBusinessTel.MaxLength = 16
        Me.txtBusinessTel.Name = "txtBusinessTel"
        Me.txtBusinessTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusinessTel.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtBusinessTel.PlaceholderText = "Digite o telefone..."
        Me.txtBusinessTel.SelectedText = ""
        Me.txtBusinessTel.ShadowDecoration.Parent = Me.txtBusinessTel
        Me.txtBusinessTel.Size = New System.Drawing.Size(365, 36)
        Me.txtBusinessTel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtBusinessTel.TabIndex = 163
        Me.txtBusinessTel.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtBusinessRamal
        '
        Me.txtBusinessRamal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBusinessRamal.Animated = True
        Me.txtBusinessRamal.AutoRoundedCorners = True
        Me.txtBusinessRamal.BackColor = System.Drawing.Color.Transparent
        Me.txtBusinessRamal.BorderColor = System.Drawing.Color.Gray
        Me.txtBusinessRamal.BorderRadius = 17
        Me.txtBusinessRamal.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtBusinessRamal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBusinessRamal.DefaultText = ""
        Me.txtBusinessRamal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBusinessRamal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBusinessRamal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusinessRamal.DisabledState.Parent = Me.txtBusinessRamal
        Me.txtBusinessRamal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBusinessRamal.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtBusinessRamal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtBusinessRamal.FocusedState.Parent = Me.txtBusinessRamal
        Me.txtBusinessRamal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBusinessRamal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBusinessRamal.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtBusinessRamal.HoverState.Parent = Me.txtBusinessRamal
        Me.txtBusinessRamal.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtBusinessRamal.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtBusinessRamal.Location = New System.Drawing.Point(164, 309)
        Me.txtBusinessRamal.MaxLength = 5
        Me.txtBusinessRamal.Name = "txtBusinessRamal"
        Me.txtBusinessRamal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusinessRamal.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtBusinessRamal.PlaceholderText = "Digite seu ramal..."
        Me.txtBusinessRamal.SelectedText = ""
        Me.txtBusinessRamal.ShadowDecoration.Parent = Me.txtBusinessRamal
        Me.txtBusinessRamal.Size = New System.Drawing.Size(365, 36)
        Me.txtBusinessRamal.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtBusinessRamal.TabIndex = 164
        Me.txtBusinessRamal.TextOffset = New System.Drawing.Point(5, 0)
        '
        'tpPermissao
        '
        Me.tpPermissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpPermissao.Controls.Add(Me.btnPermAvancar)
        Me.tpPermissao.Controls.Add(Me.btnPermVoltar)
        Me.tpPermissao.Controls.Add(Me.pbPermAviso)
        Me.tpPermissao.Controls.Add(Me.lblPermAviso)
        Me.tpPermissao.Location = New System.Drawing.Point(4, 4)
        Me.tpPermissao.Name = "tpPermissao"
        Me.tpPermissao.Size = New System.Drawing.Size(692, 505)
        Me.tpPermissao.TabIndex = 4
        Me.tpPermissao.Text = "Permissao"
        '
        'btnPermAvancar
        '
        Me.btnPermAvancar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPermAvancar.Animated = True
        Me.btnPermAvancar.BackColor = System.Drawing.Color.Transparent
        Me.btnPermAvancar.BorderRadius = 18
        Me.btnPermAvancar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnPermAvancar.CausesValidation = False
        Me.btnPermAvancar.CheckedState.Parent = Me.btnPermAvancar
        Me.btnPermAvancar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPermAvancar.CustomImages.Parent = Me.btnPermAvancar
        Me.btnPermAvancar.DisabledState.Parent = Me.btnPermAvancar
        Me.btnPermAvancar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnPermAvancar.FillColor2 = System.Drawing.Color.Black
        Me.btnPermAvancar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPermAvancar.ForeColor = System.Drawing.Color.White
        Me.btnPermAvancar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnPermAvancar.HoverState.Parent = Me.btnPermAvancar
        Me.btnPermAvancar.Location = New System.Drawing.Point(350, 415)
        Me.btnPermAvancar.Name = "btnPermAvancar"
        Me.btnPermAvancar.ShadowDecoration.Parent = Me.btnPermAvancar
        Me.btnPermAvancar.Size = New System.Drawing.Size(124, 38)
        Me.btnPermAvancar.TabIndex = 126
        Me.btnPermAvancar.Text = "AVANÇAR"
        '
        'btnPermVoltar
        '
        Me.btnPermVoltar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPermVoltar.Animated = True
        Me.btnPermVoltar.BackColor = System.Drawing.Color.Transparent
        Me.btnPermVoltar.BorderRadius = 18
        Me.btnPermVoltar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnPermVoltar.CausesValidation = False
        Me.btnPermVoltar.CheckedState.Parent = Me.btnPermVoltar
        Me.btnPermVoltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPermVoltar.CustomImages.Parent = Me.btnPermVoltar
        Me.btnPermVoltar.DisabledState.Parent = Me.btnPermVoltar
        Me.btnPermVoltar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnPermVoltar.FillColor2 = System.Drawing.Color.Black
        Me.btnPermVoltar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPermVoltar.ForeColor = System.Drawing.Color.White
        Me.btnPermVoltar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnPermVoltar.HoverState.Parent = Me.btnPermVoltar
        Me.btnPermVoltar.Location = New System.Drawing.Point(219, 415)
        Me.btnPermVoltar.Name = "btnPermVoltar"
        Me.btnPermVoltar.ShadowDecoration.Parent = Me.btnPermVoltar
        Me.btnPermVoltar.Size = New System.Drawing.Size(124, 38)
        Me.btnPermVoltar.TabIndex = 125
        Me.btnPermVoltar.Text = "VOLTAR"
        '
        'pbPermAviso
        '
        Me.pbPermAviso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbPermAviso.BackColor = System.Drawing.Color.Transparent
        Me.pbPermAviso.Image = CType(resources.GetObject("pbPermAviso.Image"), System.Drawing.Image)
        Me.pbPermAviso.Location = New System.Drawing.Point(289, 23)
        Me.pbPermAviso.Name = "pbPermAviso"
        Me.pbPermAviso.Size = New System.Drawing.Size(115, 115)
        Me.pbPermAviso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPermAviso.TabIndex = 128
        Me.pbPermAviso.TabStop = False
        '
        'lblPermAviso
        '
        Me.lblPermAviso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPermAviso.AutoSize = False
        Me.lblPermAviso.BackColor = System.Drawing.Color.Transparent
        Me.lblPermAviso.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermAviso.ForeColor = System.Drawing.Color.Black
        Me.lblPermAviso.Location = New System.Drawing.Point(48, 172)
        Me.lblPermAviso.Name = "lblPermAviso"
        Me.lblPermAviso.Size = New System.Drawing.Size(597, 146)
        Me.lblPermAviso.TabIndex = 127
        Me.lblPermAviso.Text = "O usuário é cadastrado sem acesso aos módulos, é necessário solicitar ao administ" &
    "rador as liberações.<br>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblPermAviso.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'tpCheckList
        '
        Me.tpCheckList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpCheckList.Controls.Add(Me.btnChklistFinalizar)
        Me.tpCheckList.Controls.Add(Me.btnChklistVoltar)
        Me.tpCheckList.Controls.Add(Me.lblChklistAviso)
        Me.tpCheckList.Controls.Add(Me.pbChklistAviso)
        Me.tpCheckList.Location = New System.Drawing.Point(4, 4)
        Me.tpCheckList.Name = "tpCheckList"
        Me.tpCheckList.Size = New System.Drawing.Size(692, 505)
        Me.tpCheckList.TabIndex = 5
        Me.tpCheckList.Text = "Cheklist"
        '
        'btnChklistFinalizar
        '
        Me.btnChklistFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnChklistFinalizar.Animated = True
        Me.btnChklistFinalizar.BackColor = System.Drawing.Color.Transparent
        Me.btnChklistFinalizar.BorderRadius = 18
        Me.btnChklistFinalizar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnChklistFinalizar.CausesValidation = False
        Me.btnChklistFinalizar.CheckedState.Parent = Me.btnChklistFinalizar
        Me.btnChklistFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChklistFinalizar.CustomImages.Parent = Me.btnChklistFinalizar
        Me.btnChklistFinalizar.DisabledState.Parent = Me.btnChklistFinalizar
        Me.btnChklistFinalizar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnChklistFinalizar.FillColor2 = System.Drawing.Color.Black
        Me.btnChklistFinalizar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnChklistFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnChklistFinalizar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnChklistFinalizar.HoverState.Parent = Me.btnChklistFinalizar
        Me.btnChklistFinalizar.Location = New System.Drawing.Point(350, 423)
        Me.btnChklistFinalizar.Name = "btnChklistFinalizar"
        Me.btnChklistFinalizar.ShadowDecoration.Parent = Me.btnChklistFinalizar
        Me.btnChklistFinalizar.Size = New System.Drawing.Size(124, 38)
        Me.btnChklistFinalizar.TabIndex = 126
        Me.btnChklistFinalizar.Text = "FINALIZAR"
        '
        'btnChklistVoltar
        '
        Me.btnChklistVoltar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnChklistVoltar.Animated = True
        Me.btnChklistVoltar.BackColor = System.Drawing.Color.Transparent
        Me.btnChklistVoltar.BorderRadius = 18
        Me.btnChklistVoltar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnChklistVoltar.CausesValidation = False
        Me.btnChklistVoltar.CheckedState.Parent = Me.btnChklistVoltar
        Me.btnChklistVoltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChklistVoltar.CustomImages.Parent = Me.btnChklistVoltar
        Me.btnChklistVoltar.DisabledState.Parent = Me.btnChklistVoltar
        Me.btnChklistVoltar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnChklistVoltar.FillColor2 = System.Drawing.Color.Black
        Me.btnChklistVoltar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnChklistVoltar.ForeColor = System.Drawing.Color.White
        Me.btnChklistVoltar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnChklistVoltar.HoverState.Parent = Me.btnChklistVoltar
        Me.btnChklistVoltar.Location = New System.Drawing.Point(219, 424)
        Me.btnChklistVoltar.Name = "btnChklistVoltar"
        Me.btnChklistVoltar.ShadowDecoration.Parent = Me.btnChklistVoltar
        Me.btnChklistVoltar.Size = New System.Drawing.Size(124, 38)
        Me.btnChklistVoltar.TabIndex = 125
        Me.btnChklistVoltar.Text = "VOLTAR"
        '
        'lblChklistAviso
        '
        Me.lblChklistAviso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblChklistAviso.AutoSize = False
        Me.lblChklistAviso.BackColor = System.Drawing.Color.Transparent
        Me.lblChklistAviso.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChklistAviso.ForeColor = System.Drawing.Color.Black
        Me.lblChklistAviso.Location = New System.Drawing.Point(44, 149)
        Me.lblChklistAviso.Name = "lblChklistAviso"
        Me.lblChklistAviso.Size = New System.Drawing.Size(604, 104)
        Me.lblChklistAviso.TabIndex = 128
        Me.lblChklistAviso.Text = "..."
        Me.lblChklistAviso.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'pbChklistAviso
        '
        Me.pbChklistAviso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbChklistAviso.BackColor = System.Drawing.Color.Transparent
        Me.pbChklistAviso.Image = CType(resources.GetObject("pbChklistAviso.Image"), System.Drawing.Image)
        Me.pbChklistAviso.Location = New System.Drawing.Point(289, 23)
        Me.pbChklistAviso.Name = "pbChklistAviso"
        Me.pbChklistAviso.Size = New System.Drawing.Size(115, 115)
        Me.pbChklistAviso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChklistAviso.TabIndex = 127
        Me.pbChklistAviso.TabStop = False
        '
        'tpBanco
        '
        Me.tpBanco.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpBanco.Controls.Add(Me.btnBDConnect)
        Me.tpBanco.Controls.Add(Me.lblBDAviso)
        Me.tpBanco.Controls.Add(Me.lblBDSenha)
        Me.tpBanco.Controls.Add(Me.lblBDUser)
        Me.tpBanco.Controls.Add(Me.lblBDBanco)
        Me.tpBanco.Controls.Add(Me.lblBDPorta)
        Me.tpBanco.Controls.Add(Me.lblBDServidor)
        Me.tpBanco.Controls.Add(Me.btnBDDefault)
        Me.tpBanco.Controls.Add(Me.btnBDCancelar)
        Me.tpBanco.Controls.Add(Me.btnBDSalvar)
        Me.tpBanco.Controls.Add(Me.txtBDPorta)
        Me.tpBanco.Controls.Add(Me.txtBDSenha)
        Me.tpBanco.Controls.Add(Me.txtBDUser)
        Me.tpBanco.Controls.Add(Me.txtBDBanco)
        Me.tpBanco.Controls.Add(Me.txtBDServidor)
        Me.tpBanco.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.tpBanco.Location = New System.Drawing.Point(4, 4)
        Me.tpBanco.Name = "tpBanco"
        Me.tpBanco.Size = New System.Drawing.Size(692, 505)
        Me.tpBanco.TabIndex = 6
        Me.tpBanco.Text = "Banco"
        '
        'btnBDConnect
        '
        Me.btnBDConnect.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBDConnect.Animated = True
        Me.btnBDConnect.AutoRoundedCorners = True
        Me.btnBDConnect.BackColor = System.Drawing.Color.Transparent
        Me.btnBDConnect.BorderRadius = 11
        Me.btnBDConnect.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnBDConnect.CheckedState.Parent = Me.btnBDConnect
        Me.btnBDConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBDConnect.CustomImages.Parent = Me.btnBDConnect
        Me.btnBDConnect.DisabledState.Parent = Me.btnBDConnect
        Me.btnBDConnect.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnBDConnect.FillColor2 = System.Drawing.Color.Black
        Me.btnBDConnect.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDConnect.ForeColor = System.Drawing.Color.White
        Me.btnBDConnect.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnBDConnect.HoverState.Parent = Me.btnBDConnect
        Me.btnBDConnect.Location = New System.Drawing.Point(8, 92)
        Me.btnBDConnect.Name = "btnBDConnect"
        Me.btnBDConnect.ShadowDecoration.Parent = Me.btnBDConnect
        Me.btnBDConnect.Size = New System.Drawing.Size(100, 25)
        Me.btnBDConnect.TabIndex = 165
        Me.btnBDConnect.Text = "Connect"
        '
        'lblBDAviso
        '
        Me.lblBDAviso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBDAviso.AutoSize = False
        Me.lblBDAviso.BackColor = System.Drawing.Color.Transparent
        Me.lblBDAviso.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBDAviso.ForeColor = System.Drawing.Color.Black
        Me.lblBDAviso.Location = New System.Drawing.Point(156, 41)
        Me.lblBDAviso.Name = "lblBDAviso"
        Me.lblBDAviso.Size = New System.Drawing.Size(391, 73)
        Me.lblBDAviso.TabIndex = 172
        Me.lblBDAviso.Text = "..."
        Me.lblBDAviso.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBDSenha
        '
        Me.lblBDSenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBDSenha.AutoSize = True
        Me.lblBDSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBDSenha.ForeColor = System.Drawing.Color.Black
        Me.lblBDSenha.Location = New System.Drawing.Point(289, 297)
        Me.lblBDSenha.Name = "lblBDSenha"
        Me.lblBDSenha.Size = New System.Drawing.Size(39, 15)
        Me.lblBDSenha.TabIndex = 171
        Me.lblBDSenha.Text = "Senha"
        Me.lblBDSenha.Visible = False
        '
        'lblBDUser
        '
        Me.lblBDUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBDUser.AutoSize = True
        Me.lblBDUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBDUser.ForeColor = System.Drawing.Color.Black
        Me.lblBDUser.Location = New System.Drawing.Point(148, 296)
        Me.lblBDUser.Name = "lblBDUser"
        Me.lblBDUser.Size = New System.Drawing.Size(47, 15)
        Me.lblBDUser.TabIndex = 170
        Me.lblBDUser.Text = "Usuário"
        Me.lblBDUser.Visible = False
        '
        'lblBDBanco
        '
        Me.lblBDBanco.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBDBanco.AutoSize = True
        Me.lblBDBanco.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBDBanco.ForeColor = System.Drawing.Color.Black
        Me.lblBDBanco.Location = New System.Drawing.Point(148, 224)
        Me.lblBDBanco.Name = "lblBDBanco"
        Me.lblBDBanco.Size = New System.Drawing.Size(40, 15)
        Me.lblBDBanco.TabIndex = 169
        Me.lblBDBanco.Text = "Banco"
        Me.lblBDBanco.Visible = False
        '
        'lblBDPorta
        '
        Me.lblBDPorta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBDPorta.AutoSize = True
        Me.lblBDPorta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBDPorta.ForeColor = System.Drawing.Color.Black
        Me.lblBDPorta.Location = New System.Drawing.Point(417, 152)
        Me.lblBDPorta.Name = "lblBDPorta"
        Me.lblBDPorta.Size = New System.Drawing.Size(35, 15)
        Me.lblBDPorta.TabIndex = 168
        Me.lblBDPorta.Text = "Porta"
        Me.lblBDPorta.Visible = False
        '
        'lblBDServidor
        '
        Me.lblBDServidor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBDServidor.AutoSize = True
        Me.lblBDServidor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBDServidor.ForeColor = System.Drawing.Color.Black
        Me.lblBDServidor.Location = New System.Drawing.Point(148, 152)
        Me.lblBDServidor.Name = "lblBDServidor"
        Me.lblBDServidor.Size = New System.Drawing.Size(50, 15)
        Me.lblBDServidor.TabIndex = 167
        Me.lblBDServidor.Text = "Servidor"
        Me.lblBDServidor.Visible = False
        '
        'btnBDDefault
        '
        Me.btnBDDefault.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBDDefault.Animated = True
        Me.btnBDDefault.AutoRoundedCorners = True
        Me.btnBDDefault.BackColor = System.Drawing.Color.Transparent
        Me.btnBDDefault.BorderRadius = 11
        Me.btnBDDefault.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnBDDefault.CheckedState.Parent = Me.btnBDDefault
        Me.btnBDDefault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBDDefault.CustomImages.Parent = Me.btnBDDefault
        Me.btnBDDefault.DisabledState.Parent = Me.btnBDDefault
        Me.btnBDDefault.FillColor = System.Drawing.Color.SlateGray
        Me.btnBDDefault.FillColor2 = System.Drawing.Color.Black
        Me.btnBDDefault.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDDefault.ForeColor = System.Drawing.Color.White
        Me.btnBDDefault.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnBDDefault.HoverState.Parent = Me.btnBDDefault
        Me.btnBDDefault.Location = New System.Drawing.Point(8, 119)
        Me.btnBDDefault.Name = "btnBDDefault"
        Me.btnBDDefault.ShadowDecoration.Parent = Me.btnBDDefault
        Me.btnBDDefault.Size = New System.Drawing.Size(100, 25)
        Me.btnBDDefault.TabIndex = 166
        Me.btnBDDefault.Text = "Default"
        '
        'btnBDCancelar
        '
        Me.btnBDCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBDCancelar.Animated = True
        Me.btnBDCancelar.AutoRoundedCorners = True
        Me.btnBDCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnBDCancelar.BorderRadius = 18
        Me.btnBDCancelar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnBDCancelar.CausesValidation = False
        Me.btnBDCancelar.CheckedState.Parent = Me.btnBDCancelar
        Me.btnBDCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBDCancelar.CustomImages.Parent = Me.btnBDCancelar
        Me.btnBDCancelar.DisabledState.Parent = Me.btnBDCancelar
        Me.btnBDCancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnBDCancelar.FillColor2 = System.Drawing.Color.Black
        Me.btnBDCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBDCancelar.ForeColor = System.Drawing.Color.White
        Me.btnBDCancelar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnBDCancelar.HoverState.Parent = Me.btnBDCancelar
        Me.btnBDCancelar.Location = New System.Drawing.Point(220, 427)
        Me.btnBDCancelar.Name = "btnBDCancelar"
        Me.btnBDCancelar.ShadowDecoration.Parent = Me.btnBDCancelar
        Me.btnBDCancelar.Size = New System.Drawing.Size(124, 38)
        Me.btnBDCancelar.TabIndex = 164
        Me.btnBDCancelar.Text = "CANCELAR"
        '
        'btnBDSalvar
        '
        Me.btnBDSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBDSalvar.Animated = True
        Me.btnBDSalvar.AutoRoundedCorners = True
        Me.btnBDSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnBDSalvar.BorderRadius = 18
        Me.btnBDSalvar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnBDSalvar.CheckedState.Parent = Me.btnBDSalvar
        Me.btnBDSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBDSalvar.CustomImages.Parent = Me.btnBDSalvar
        Me.btnBDSalvar.DisabledState.Parent = Me.btnBDSalvar
        Me.btnBDSalvar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnBDSalvar.FillColor2 = System.Drawing.Color.Black
        Me.btnBDSalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBDSalvar.ForeColor = System.Drawing.Color.White
        Me.btnBDSalvar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnBDSalvar.HoverState.Parent = Me.btnBDSalvar
        Me.btnBDSalvar.Location = New System.Drawing.Point(351, 427)
        Me.btnBDSalvar.Name = "btnBDSalvar"
        Me.btnBDSalvar.ShadowDecoration.Parent = Me.btnBDSalvar
        Me.btnBDSalvar.Size = New System.Drawing.Size(124, 38)
        Me.btnBDSalvar.TabIndex = 163
        Me.btnBDSalvar.Text = "SALVAR"
        '
        'txtBDPorta
        '
        Me.txtBDPorta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBDPorta.Animated = True
        Me.txtBDPorta.AutoRoundedCorners = True
        Me.txtBDPorta.BackColor = System.Drawing.Color.Transparent
        Me.txtBDPorta.BorderColor = System.Drawing.Color.Gray
        Me.txtBDPorta.BorderRadius = 17
        Me.txtBDPorta.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtBDPorta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBDPorta.DefaultText = ""
        Me.txtBDPorta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBDPorta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBDPorta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBDPorta.DisabledState.Parent = Me.txtBDPorta
        Me.txtBDPorta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBDPorta.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtBDPorta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtBDPorta.FocusedState.Parent = Me.txtBDPorta
        Me.txtBDPorta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBDPorta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBDPorta.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtBDPorta.HoverState.Parent = Me.txtBDPorta
        Me.txtBDPorta.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtBDPorta.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtBDPorta.Location = New System.Drawing.Point(415, 169)
        Me.txtBDPorta.Name = "txtBDPorta"
        Me.txtBDPorta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBDPorta.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtBDPorta.PlaceholderText = "Porta..."
        Me.txtBDPorta.SelectedText = ""
        Me.txtBDPorta.ShadowDecoration.Parent = Me.txtBDPorta
        Me.txtBDPorta.Size = New System.Drawing.Size(134, 36)
        Me.txtBDPorta.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtBDPorta.TabIndex = 159
        Me.txtBDPorta.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtBDSenha
        '
        Me.txtBDSenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBDSenha.Animated = True
        Me.txtBDSenha.AutoRoundedCorners = True
        Me.txtBDSenha.BackColor = System.Drawing.Color.Transparent
        Me.txtBDSenha.BorderColor = System.Drawing.Color.Gray
        Me.txtBDSenha.BorderRadius = 17
        Me.txtBDSenha.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtBDSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBDSenha.DefaultText = ""
        Me.txtBDSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBDSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBDSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBDSenha.DisabledState.Parent = Me.txtBDSenha
        Me.txtBDSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBDSenha.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtBDSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtBDSenha.FocusedState.Parent = Me.txtBDSenha
        Me.txtBDSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBDSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBDSenha.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtBDSenha.HoverState.Parent = Me.txtBDSenha
        Me.txtBDSenha.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtBDSenha.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtBDSenha.Location = New System.Drawing.Point(286, 314)
        Me.txtBDSenha.Name = "txtBDSenha"
        Me.txtBDSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBDSenha.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtBDSenha.PlaceholderText = "Digite a senha..."
        Me.txtBDSenha.SelectedText = ""
        Me.txtBDSenha.ShadowDecoration.Parent = Me.txtBDSenha
        Me.txtBDSenha.Size = New System.Drawing.Size(263, 36)
        Me.txtBDSenha.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtBDSenha.TabIndex = 162
        Me.txtBDSenha.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtBDUser
        '
        Me.txtBDUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBDUser.Animated = True
        Me.txtBDUser.AutoRoundedCorners = True
        Me.txtBDUser.BackColor = System.Drawing.Color.Transparent
        Me.txtBDUser.BorderColor = System.Drawing.Color.Gray
        Me.txtBDUser.BorderRadius = 17
        Me.txtBDUser.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtBDUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBDUser.DefaultText = ""
        Me.txtBDUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBDUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBDUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBDUser.DisabledState.Parent = Me.txtBDUser
        Me.txtBDUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBDUser.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtBDUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtBDUser.FocusedState.Parent = Me.txtBDUser
        Me.txtBDUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBDUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBDUser.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtBDUser.HoverState.Parent = Me.txtBDUser
        Me.txtBDUser.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtBDUser.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtBDUser.Location = New System.Drawing.Point(145, 314)
        Me.txtBDUser.Name = "txtBDUser"
        Me.txtBDUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBDUser.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtBDUser.PlaceholderText = "Digite o usuário..."
        Me.txtBDUser.SelectedText = ""
        Me.txtBDUser.ShadowDecoration.Parent = Me.txtBDUser
        Me.txtBDUser.Size = New System.Drawing.Size(135, 36)
        Me.txtBDUser.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtBDUser.TabIndex = 161
        Me.txtBDUser.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtBDBanco
        '
        Me.txtBDBanco.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBDBanco.Animated = True
        Me.txtBDBanco.AutoRoundedCorners = True
        Me.txtBDBanco.BackColor = System.Drawing.Color.Transparent
        Me.txtBDBanco.BorderColor = System.Drawing.Color.Gray
        Me.txtBDBanco.BorderRadius = 17
        Me.txtBDBanco.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtBDBanco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBDBanco.DefaultText = ""
        Me.txtBDBanco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBDBanco.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBDBanco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBDBanco.DisabledState.Parent = Me.txtBDBanco
        Me.txtBDBanco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBDBanco.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtBDBanco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtBDBanco.FocusedState.Parent = Me.txtBDBanco
        Me.txtBDBanco.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBDBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBDBanco.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtBDBanco.HoverState.Parent = Me.txtBDBanco
        Me.txtBDBanco.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtBDBanco.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtBDBanco.Location = New System.Drawing.Point(145, 241)
        Me.txtBDBanco.Name = "txtBDBanco"
        Me.txtBDBanco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBDBanco.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtBDBanco.PlaceholderText = "Digite o nome do banco..."
        Me.txtBDBanco.SelectedText = ""
        Me.txtBDBanco.ShadowDecoration.Parent = Me.txtBDBanco
        Me.txtBDBanco.Size = New System.Drawing.Size(404, 36)
        Me.txtBDBanco.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtBDBanco.TabIndex = 160
        Me.txtBDBanco.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtBDServidor
        '
        Me.txtBDServidor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBDServidor.Animated = True
        Me.txtBDServidor.AutoRoundedCorners = True
        Me.txtBDServidor.BackColor = System.Drawing.Color.Transparent
        Me.txtBDServidor.BorderColor = System.Drawing.Color.Gray
        Me.txtBDServidor.BorderRadius = 17
        Me.txtBDServidor.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtBDServidor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBDServidor.DefaultText = ""
        Me.txtBDServidor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBDServidor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBDServidor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBDServidor.DisabledState.Parent = Me.txtBDServidor
        Me.txtBDServidor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBDServidor.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtBDServidor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtBDServidor.FocusedState.Parent = Me.txtBDServidor
        Me.txtBDServidor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBDServidor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBDServidor.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtBDServidor.HoverState.Parent = Me.txtBDServidor
        Me.txtBDServidor.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtBDServidor.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtBDServidor.Location = New System.Drawing.Point(145, 169)
        Me.txtBDServidor.Name = "txtBDServidor"
        Me.txtBDServidor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBDServidor.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtBDServidor.PlaceholderText = "Digite o dominio..."
        Me.txtBDServidor.SelectedText = ""
        Me.txtBDServidor.ShadowDecoration.Parent = Me.txtBDServidor
        Me.txtBDServidor.Size = New System.Drawing.Size(264, 36)
        Me.txtBDServidor.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtBDServidor.TabIndex = 158
        Me.txtBDServidor.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(-10, 11)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(153, 78)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 157
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'tpRedefinir
        '
        Me.tpRedefinir.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpRedefinir.Controls.Add(Me.lblRdfInvalido)
        Me.tpRedefinir.Controls.Add(Me.btnRdfCancel)
        Me.tpRedefinir.Controls.Add(Me.btnRdfEnviar)
        Me.tpRedefinir.Controls.Add(Me.lblRdfEmail)
        Me.tpRedefinir.Controls.Add(Me.txtRdfEmail)
        Me.tpRedefinir.Controls.Add(Me.lblRdfAviso)
        Me.tpRedefinir.Location = New System.Drawing.Point(4, 4)
        Me.tpRedefinir.Name = "tpRedefinir"
        Me.tpRedefinir.Size = New System.Drawing.Size(692, 505)
        Me.tpRedefinir.TabIndex = 7
        Me.tpRedefinir.Text = "Redefinir"
        '
        'lblRdfInvalido
        '
        Me.lblRdfInvalido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblRdfInvalido.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRdfInvalido.ForeColor = System.Drawing.Color.Red
        Me.lblRdfInvalido.Location = New System.Drawing.Point(189, 177)
        Me.lblRdfInvalido.Name = "lblRdfInvalido"
        Me.lblRdfInvalido.Size = New System.Drawing.Size(314, 23)
        Me.lblRdfInvalido.TabIndex = 185
        Me.lblRdfInvalido.Text = "E-MAIL INVÁLIDO"
        Me.lblRdfInvalido.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblRdfInvalido.Visible = False
        '
        'btnRdfCancel
        '
        Me.btnRdfCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRdfCancel.Animated = True
        Me.btnRdfCancel.AutoRoundedCorners = True
        Me.btnRdfCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnRdfCancel.BorderRadius = 18
        Me.btnRdfCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnRdfCancel.CausesValidation = False
        Me.btnRdfCancel.CheckedState.Parent = Me.btnRdfCancel
        Me.btnRdfCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRdfCancel.CustomImages.Parent = Me.btnRdfCancel
        Me.btnRdfCancel.DisabledState.Parent = Me.btnRdfCancel
        Me.btnRdfCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnRdfCancel.FillColor2 = System.Drawing.Color.Black
        Me.btnRdfCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRdfCancel.ForeColor = System.Drawing.Color.White
        Me.btnRdfCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnRdfCancel.HoverState.Parent = Me.btnRdfCancel
        Me.btnRdfCancel.Location = New System.Drawing.Point(219, 425)
        Me.btnRdfCancel.Name = "btnRdfCancel"
        Me.btnRdfCancel.ShadowDecoration.Parent = Me.btnRdfCancel
        Me.btnRdfCancel.Size = New System.Drawing.Size(124, 38)
        Me.btnRdfCancel.TabIndex = 183
        Me.btnRdfCancel.Text = "CANCELAR"
        '
        'btnRdfEnviar
        '
        Me.btnRdfEnviar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRdfEnviar.Animated = True
        Me.btnRdfEnviar.AutoRoundedCorners = True
        Me.btnRdfEnviar.BackColor = System.Drawing.Color.Transparent
        Me.btnRdfEnviar.BorderRadius = 18
        Me.btnRdfEnviar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnRdfEnviar.CheckedState.Parent = Me.btnRdfEnviar
        Me.btnRdfEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRdfEnviar.CustomImages.Parent = Me.btnRdfEnviar
        Me.btnRdfEnviar.DisabledState.Parent = Me.btnRdfEnviar
        Me.btnRdfEnviar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnRdfEnviar.FillColor2 = System.Drawing.Color.Black
        Me.btnRdfEnviar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRdfEnviar.ForeColor = System.Drawing.Color.White
        Me.btnRdfEnviar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnRdfEnviar.HoverState.Parent = Me.btnRdfEnviar
        Me.btnRdfEnviar.Location = New System.Drawing.Point(350, 425)
        Me.btnRdfEnviar.Name = "btnRdfEnviar"
        Me.btnRdfEnviar.ShadowDecoration.Parent = Me.btnRdfEnviar
        Me.btnRdfEnviar.Size = New System.Drawing.Size(124, 38)
        Me.btnRdfEnviar.TabIndex = 182
        Me.btnRdfEnviar.Text = "ENVIAR"
        '
        'lblRdfEmail
        '
        Me.lblRdfEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblRdfEmail.AutoSize = True
        Me.lblRdfEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRdfEmail.ForeColor = System.Drawing.Color.Black
        Me.lblRdfEmail.Location = New System.Drawing.Point(187, 223)
        Me.lblRdfEmail.Name = "lblRdfEmail"
        Me.lblRdfEmail.Size = New System.Drawing.Size(41, 15)
        Me.lblRdfEmail.TabIndex = 184
        Me.lblRdfEmail.Text = "E-mail"
        Me.lblRdfEmail.Visible = False
        '
        'txtRdfEmail
        '
        Me.txtRdfEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRdfEmail.Animated = True
        Me.txtRdfEmail.AutoRoundedCorners = True
        Me.txtRdfEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtRdfEmail.BorderColor = System.Drawing.Color.Gray
        Me.txtRdfEmail.BorderRadius = 17
        Me.txtRdfEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRdfEmail.DefaultText = ""
        Me.txtRdfEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRdfEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRdfEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRdfEmail.DisabledState.Parent = Me.txtRdfEmail
        Me.txtRdfEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRdfEmail.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtRdfEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtRdfEmail.FocusedState.Parent = Me.txtRdfEmail
        Me.txtRdfEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRdfEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRdfEmail.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtRdfEmail.HoverState.Parent = Me.txtRdfEmail
        Me.txtRdfEmail.IconLeft = CType(resources.GetObject("txtRdfEmail.IconLeft"), System.Drawing.Image)
        Me.txtRdfEmail.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtRdfEmail.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtRdfEmail.Location = New System.Drawing.Point(191, 241)
        Me.txtRdfEmail.Name = "txtRdfEmail"
        Me.txtRdfEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRdfEmail.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtRdfEmail.PlaceholderText = "E-mail..."
        Me.txtRdfEmail.SelectedText = ""
        Me.txtRdfEmail.ShadowDecoration.Parent = Me.txtRdfEmail
        Me.txtRdfEmail.Size = New System.Drawing.Size(315, 36)
        Me.txtRdfEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtRdfEmail.TabIndex = 181
        Me.txtRdfEmail.TextOffset = New System.Drawing.Point(5, 0)
        '
        'lblRdfAviso
        '
        Me.lblRdfAviso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblRdfAviso.AutoSize = False
        Me.lblRdfAviso.BackColor = System.Drawing.Color.Transparent
        Me.lblRdfAviso.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRdfAviso.ForeColor = System.Drawing.Color.Gray
        Me.lblRdfAviso.Location = New System.Drawing.Point(68, 19)
        Me.lblRdfAviso.Name = "lblRdfAviso"
        Me.lblRdfAviso.Size = New System.Drawing.Size(556, 82)
        Me.lblRdfAviso.TabIndex = 186
        Me.lblRdfAviso.Text = resources.GetString("lblRdfAviso.Text")
        Me.lblRdfAviso.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'tpConfUser
        '
        Me.tpConfUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpConfUser.Controls.Add(Me.lblConfInvalido)
        Me.tpConfUser.Controls.Add(Me.lblConfAviso)
        Me.tpConfUser.Controls.Add(Me.btnConfCancel)
        Me.tpConfUser.Controls.Add(Me.btnConfValidar)
        Me.tpConfUser.Controls.Add(Me.lblConfToken)
        Me.tpConfUser.Controls.Add(Me.txtConfToken)
        Me.tpConfUser.Location = New System.Drawing.Point(4, 4)
        Me.tpConfUser.Name = "tpConfUser"
        Me.tpConfUser.Size = New System.Drawing.Size(692, 505)
        Me.tpConfUser.TabIndex = 8
        Me.tpConfUser.Text = "ConfUser"
        '
        'lblConfInvalido
        '
        Me.lblConfInvalido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblConfInvalido.AutoSize = True
        Me.lblConfInvalido.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblConfInvalido.ForeColor = System.Drawing.Color.Red
        Me.lblConfInvalido.Location = New System.Drawing.Point(147, 197)
        Me.lblConfInvalido.Name = "lblConfInvalido"
        Me.lblConfInvalido.Size = New System.Drawing.Size(74, 12)
        Me.lblConfInvalido.TabIndex = 168
        Me.lblConfInvalido.Text = "Código inválido"
        Me.lblConfInvalido.Visible = False
        '
        'lblConfAviso
        '
        Me.lblConfAviso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblConfAviso.AutoSize = False
        Me.lblConfAviso.BackColor = System.Drawing.Color.Transparent
        Me.lblConfAviso.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfAviso.ForeColor = System.Drawing.Color.Gray
        Me.lblConfAviso.Location = New System.Drawing.Point(36, 16)
        Me.lblConfAviso.Name = "lblConfAviso"
        Me.lblConfAviso.Size = New System.Drawing.Size(620, 73)
        Me.lblConfAviso.TabIndex = 167
        Me.lblConfAviso.Text = "<b><font color='black'>Por favor verifique seu e-mail, enviamos um token para val" &
    "idar o usuário de acesso informado.</font></b>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<br>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Insira o <b>Token</b> no c" &
    "ampo solicitado e clique em validar"
        Me.lblConfAviso.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'btnConfCancel
        '
        Me.btnConfCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnConfCancel.Animated = True
        Me.btnConfCancel.AutoRoundedCorners = True
        Me.btnConfCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnConfCancel.BorderRadius = 18
        Me.btnConfCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnConfCancel.CausesValidation = False
        Me.btnConfCancel.CheckedState.Parent = Me.btnConfCancel
        Me.btnConfCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfCancel.CustomImages.Parent = Me.btnConfCancel
        Me.btnConfCancel.DisabledState.Parent = Me.btnConfCancel
        Me.btnConfCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnConfCancel.FillColor2 = System.Drawing.Color.Black
        Me.btnConfCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfCancel.ForeColor = System.Drawing.Color.White
        Me.btnConfCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnConfCancel.HoverState.Parent = Me.btnConfCancel
        Me.btnConfCancel.Location = New System.Drawing.Point(219, 424)
        Me.btnConfCancel.Name = "btnConfCancel"
        Me.btnConfCancel.ShadowDecoration.Parent = Me.btnConfCancel
        Me.btnConfCancel.Size = New System.Drawing.Size(124, 38)
        Me.btnConfCancel.TabIndex = 165
        Me.btnConfCancel.Text = "CANCELAR"
        '
        'btnConfValidar
        '
        Me.btnConfValidar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnConfValidar.Animated = True
        Me.btnConfValidar.AutoRoundedCorners = True
        Me.btnConfValidar.BackColor = System.Drawing.Color.Transparent
        Me.btnConfValidar.BorderRadius = 18
        Me.btnConfValidar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnConfValidar.CheckedState.Parent = Me.btnConfValidar
        Me.btnConfValidar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfValidar.CustomImages.Parent = Me.btnConfValidar
        Me.btnConfValidar.DisabledState.Parent = Me.btnConfValidar
        Me.btnConfValidar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnConfValidar.FillColor2 = System.Drawing.Color.Black
        Me.btnConfValidar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfValidar.ForeColor = System.Drawing.Color.White
        Me.btnConfValidar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnConfValidar.HoverState.Parent = Me.btnConfValidar
        Me.btnConfValidar.Location = New System.Drawing.Point(350, 424)
        Me.btnConfValidar.Name = "btnConfValidar"
        Me.btnConfValidar.ShadowDecoration.Parent = Me.btnConfValidar
        Me.btnConfValidar.Size = New System.Drawing.Size(124, 38)
        Me.btnConfValidar.TabIndex = 164
        Me.btnConfValidar.Text = "VALIDAR"
        '
        'lblConfToken
        '
        Me.lblConfToken.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblConfToken.AutoSize = True
        Me.lblConfToken.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblConfToken.ForeColor = System.Drawing.Color.Black
        Me.lblConfToken.Location = New System.Drawing.Point(139, 140)
        Me.lblConfToken.Name = "lblConfToken"
        Me.lblConfToken.Size = New System.Drawing.Size(38, 15)
        Me.lblConfToken.TabIndex = 166
        Me.lblConfToken.Text = "Token"
        Me.lblConfToken.Visible = False
        '
        'txtConfToken
        '
        Me.txtConfToken.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtConfToken.Animated = True
        Me.txtConfToken.AutoRoundedCorners = True
        Me.txtConfToken.BackColor = System.Drawing.Color.Transparent
        Me.txtConfToken.BorderColor = System.Drawing.Color.Gray
        Me.txtConfToken.BorderRadius = 17
        Me.txtConfToken.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConfToken.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfToken.DefaultText = ""
        Me.txtConfToken.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfToken.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfToken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfToken.DisabledState.Parent = Me.txtConfToken
        Me.txtConfToken.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfToken.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtConfToken.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtConfToken.FocusedState.Parent = Me.txtConfToken
        Me.txtConfToken.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfToken.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtConfToken.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtConfToken.HoverState.Parent = Me.txtConfToken
        Me.txtConfToken.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtConfToken.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtConfToken.Location = New System.Drawing.Point(142, 158)
        Me.txtConfToken.Name = "txtConfToken"
        Me.txtConfToken.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfToken.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtConfToken.PlaceholderText = "TOKEN..."
        Me.txtConfToken.SelectedText = ""
        Me.txtConfToken.ShadowDecoration.Parent = Me.txtConfToken
        Me.txtConfToken.Size = New System.Drawing.Size(408, 36)
        Me.txtConfToken.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtConfToken.TabIndex = 163
        Me.txtConfToken.TextOffset = New System.Drawing.Point(5, 0)
        '
        'tpEditarBanco
        '
        Me.tpEditarBanco.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpEditarBanco.Controls.Add(Me.lblEditarBDInvalido)
        Me.tpEditarBanco.Controls.Add(Me.lblEditarBDCaps)
        Me.tpEditarBanco.Controls.Add(Me.lblEditarBDSenha)
        Me.tpEditarBanco.Controls.Add(Me.txtEditarBDSenha)
        Me.tpEditarBanco.Controls.Add(Me.lblEditarBD)
        Me.tpEditarBanco.Controls.Add(Me.btnCancelarBD)
        Me.tpEditarBanco.Controls.Add(Me.btnEditarBD)
        Me.tpEditarBanco.Controls.Add(Me.lblEditarBDEmail)
        Me.tpEditarBanco.Controls.Add(Me.txtEditarBDEmail)
        Me.tpEditarBanco.Location = New System.Drawing.Point(4, 4)
        Me.tpEditarBanco.Name = "tpEditarBanco"
        Me.tpEditarBanco.Size = New System.Drawing.Size(692, 505)
        Me.tpEditarBanco.TabIndex = 9
        Me.tpEditarBanco.Text = "Editar Banco"
        '
        'lblEditarBDInvalido
        '
        Me.lblEditarBDInvalido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEditarBDInvalido.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditarBDInvalido.ForeColor = System.Drawing.Color.Red
        Me.lblEditarBDInvalido.Location = New System.Drawing.Point(189, 117)
        Me.lblEditarBDInvalido.Name = "lblEditarBDInvalido"
        Me.lblEditarBDInvalido.Size = New System.Drawing.Size(314, 23)
        Me.lblEditarBDInvalido.TabIndex = 180
        Me.lblEditarBDInvalido.Text = "E-MAIL OU SENHA INVÁLIDO"
        Me.lblEditarBDInvalido.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblEditarBDInvalido.Visible = False
        '
        'lblEditarBDCaps
        '
        Me.lblEditarBDCaps.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEditarBDCaps.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditarBDCaps.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lblEditarBDCaps.Location = New System.Drawing.Point(189, 311)
        Me.lblEditarBDCaps.Name = "lblEditarBDCaps"
        Me.lblEditarBDCaps.Size = New System.Drawing.Size(314, 23)
        Me.lblEditarBDCaps.TabIndex = 179
        Me.lblEditarBDCaps.Text = "CAPS LOOK ATIVADA"
        Me.lblEditarBDCaps.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblEditarBDCaps.Visible = False
        '
        'lblEditarBDSenha
        '
        Me.lblEditarBDSenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEditarBDSenha.AutoSize = True
        Me.lblEditarBDSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEditarBDSenha.ForeColor = System.Drawing.Color.Black
        Me.lblEditarBDSenha.Location = New System.Drawing.Point(187, 249)
        Me.lblEditarBDSenha.Name = "lblEditarBDSenha"
        Me.lblEditarBDSenha.Size = New System.Drawing.Size(39, 15)
        Me.lblEditarBDSenha.TabIndex = 178
        Me.lblEditarBDSenha.Text = "Senha"
        Me.lblEditarBDSenha.Visible = False
        '
        'txtEditarBDSenha
        '
        Me.txtEditarBDSenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtEditarBDSenha.Animated = True
        Me.txtEditarBDSenha.AutoRoundedCorners = True
        Me.txtEditarBDSenha.BackColor = System.Drawing.Color.Transparent
        Me.txtEditarBDSenha.BorderColor = System.Drawing.Color.Gray
        Me.txtEditarBDSenha.BorderRadius = 17
        Me.txtEditarBDSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEditarBDSenha.DefaultText = ""
        Me.txtEditarBDSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEditarBDSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEditarBDSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEditarBDSenha.DisabledState.Parent = Me.txtEditarBDSenha
        Me.txtEditarBDSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEditarBDSenha.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtEditarBDSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtEditarBDSenha.FocusedState.Parent = Me.txtEditarBDSenha
        Me.txtEditarBDSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEditarBDSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEditarBDSenha.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtEditarBDSenha.HoverState.Parent = Me.txtEditarBDSenha
        Me.txtEditarBDSenha.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.txtEditarBDSenha.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtEditarBDSenha.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtEditarBDSenha.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtEditarBDSenha.IconRightSize = New System.Drawing.Size(16, 16)
        Me.txtEditarBDSenha.Location = New System.Drawing.Point(190, 268)
        Me.txtEditarBDSenha.Name = "txtEditarBDSenha"
        Me.txtEditarBDSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEditarBDSenha.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtEditarBDSenha.PlaceholderText = "Senha..."
        Me.txtEditarBDSenha.SelectedText = ""
        Me.txtEditarBDSenha.ShadowDecoration.Parent = Me.txtEditarBDSenha
        Me.txtEditarBDSenha.Size = New System.Drawing.Size(315, 36)
        Me.txtEditarBDSenha.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtEditarBDSenha.TabIndex = 173
        Me.txtEditarBDSenha.TextOffset = New System.Drawing.Point(5, 0)
        Me.txtEditarBDSenha.UseSystemPasswordChar = True
        '
        'lblEditarBD
        '
        Me.lblEditarBD.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEditarBD.AutoSize = False
        Me.lblEditarBD.BackColor = System.Drawing.Color.Transparent
        Me.lblEditarBD.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditarBD.ForeColor = System.Drawing.Color.Gray
        Me.lblEditarBD.Location = New System.Drawing.Point(36, 13)
        Me.lblEditarBD.Name = "lblEditarBD"
        Me.lblEditarBD.Size = New System.Drawing.Size(620, 73)
        Me.lblEditarBD.TabIndex = 177
        Me.lblEditarBD.Text = resources.GetString("lblEditarBD.Text")
        Me.lblEditarBD.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCancelarBD
        '
        Me.btnCancelarBD.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancelarBD.Animated = True
        Me.btnCancelarBD.AutoRoundedCorners = True
        Me.btnCancelarBD.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelarBD.BorderRadius = 18
        Me.btnCancelarBD.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnCancelarBD.CausesValidation = False
        Me.btnCancelarBD.CheckedState.Parent = Me.btnCancelarBD
        Me.btnCancelarBD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarBD.CustomImages.Parent = Me.btnCancelarBD
        Me.btnCancelarBD.DisabledState.Parent = Me.btnCancelarBD
        Me.btnCancelarBD.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnCancelarBD.FillColor2 = System.Drawing.Color.Black
        Me.btnCancelarBD.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelarBD.ForeColor = System.Drawing.Color.White
        Me.btnCancelarBD.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnCancelarBD.HoverState.Parent = Me.btnCancelarBD
        Me.btnCancelarBD.Location = New System.Drawing.Point(219, 429)
        Me.btnCancelarBD.Name = "btnCancelarBD"
        Me.btnCancelarBD.ShadowDecoration.Parent = Me.btnCancelarBD
        Me.btnCancelarBD.Size = New System.Drawing.Size(124, 38)
        Me.btnCancelarBD.TabIndex = 175
        Me.btnCancelarBD.Text = "CANCELAR"
        '
        'btnEditarBD
        '
        Me.btnEditarBD.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditarBD.Animated = True
        Me.btnEditarBD.AutoRoundedCorners = True
        Me.btnEditarBD.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarBD.BorderRadius = 18
        Me.btnEditarBD.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnEditarBD.CheckedState.Parent = Me.btnEditarBD
        Me.btnEditarBD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarBD.CustomImages.Parent = Me.btnEditarBD
        Me.btnEditarBD.DisabledState.Parent = Me.btnEditarBD
        Me.btnEditarBD.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnEditarBD.FillColor2 = System.Drawing.Color.Black
        Me.btnEditarBD.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditarBD.ForeColor = System.Drawing.Color.White
        Me.btnEditarBD.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnEditarBD.HoverState.Parent = Me.btnEditarBD
        Me.btnEditarBD.Location = New System.Drawing.Point(350, 430)
        Me.btnEditarBD.Name = "btnEditarBD"
        Me.btnEditarBD.ShadowDecoration.Parent = Me.btnEditarBD
        Me.btnEditarBD.Size = New System.Drawing.Size(124, 38)
        Me.btnEditarBD.TabIndex = 174
        Me.btnEditarBD.Text = "VALIDAR"
        '
        'lblEditarBDEmail
        '
        Me.lblEditarBDEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEditarBDEmail.AutoSize = True
        Me.lblEditarBDEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEditarBDEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEditarBDEmail.Location = New System.Drawing.Point(189, 171)
        Me.lblEditarBDEmail.Name = "lblEditarBDEmail"
        Me.lblEditarBDEmail.Size = New System.Drawing.Size(41, 15)
        Me.lblEditarBDEmail.TabIndex = 176
        Me.lblEditarBDEmail.Text = "E-mail"
        Me.lblEditarBDEmail.Visible = False
        '
        'txtEditarBDEmail
        '
        Me.txtEditarBDEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtEditarBDEmail.Animated = True
        Me.txtEditarBDEmail.AutoRoundedCorners = True
        Me.txtEditarBDEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEditarBDEmail.BorderColor = System.Drawing.Color.Gray
        Me.txtEditarBDEmail.BorderRadius = 17
        Me.txtEditarBDEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEditarBDEmail.DefaultText = ""
        Me.txtEditarBDEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEditarBDEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEditarBDEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEditarBDEmail.DisabledState.Parent = Me.txtEditarBDEmail
        Me.txtEditarBDEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEditarBDEmail.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtEditarBDEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtEditarBDEmail.FocusedState.Parent = Me.txtEditarBDEmail
        Me.txtEditarBDEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEditarBDEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEditarBDEmail.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtEditarBDEmail.HoverState.Parent = Me.txtEditarBDEmail
        Me.txtEditarBDEmail.IconLeft = CType(resources.GetObject("txtEditarBDEmail.IconLeft"), System.Drawing.Image)
        Me.txtEditarBDEmail.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.txtEditarBDEmail.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtEditarBDEmail.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtEditarBDEmail.Location = New System.Drawing.Point(190, 190)
        Me.txtEditarBDEmail.Name = "txtEditarBDEmail"
        Me.txtEditarBDEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEditarBDEmail.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtEditarBDEmail.PlaceholderText = "E-mail..."
        Me.txtEditarBDEmail.SelectedText = ""
        Me.txtEditarBDEmail.ShadowDecoration.Parent = Me.txtEditarBDEmail
        Me.txtEditarBDEmail.Size = New System.Drawing.Size(315, 36)
        Me.txtEditarBDEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtEditarBDEmail.TabIndex = 172
        Me.txtEditarBDEmail.TextOffset = New System.Drawing.Point(5, 0)
        '
        'TpLoading
        '
        Me.TpLoading.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpLoading.Controls.Add(Me.ProgressAguarde)
        Me.TpLoading.Controls.Add(Me.LblLoading)
        Me.TpLoading.Location = New System.Drawing.Point(4, 4)
        Me.TpLoading.Name = "TpLoading"
        Me.TpLoading.Size = New System.Drawing.Size(692, 505)
        Me.TpLoading.TabIndex = 0
        Me.TpLoading.Text = "Loading"
        '
        'ProgressAguarde
        '
        Me.ProgressAguarde.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressAguarde.BackColor = System.Drawing.Color.Transparent
        Me.ProgressAguarde.BorderRadius = 4
        Me.ProgressAguarde.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProgressAguarde.Location = New System.Drawing.Point(21, 123)
        Me.ProgressAguarde.Name = "ProgressAguarde"
        Me.ProgressAguarde.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ProgressAguarde.ProgressColor2 = System.Drawing.Color.Black
        Me.ProgressAguarde.ShadowDecoration.Parent = Me.ProgressAguarde
        Me.ProgressAguarde.Size = New System.Drawing.Size(650, 15)
        Me.ProgressAguarde.TabIndex = 197
        Me.ProgressAguarde.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.ProgressAguarde.Value = 80
        '
        'LblLoading
        '
        Me.LblLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblLoading.AutoSize = False
        Me.LblLoading.BackColor = System.Drawing.Color.Transparent
        Me.LblLoading.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLoading.ForeColor = System.Drawing.Color.Black
        Me.LblLoading.Location = New System.Drawing.Point(96, 166)
        Me.LblLoading.Name = "LblLoading"
        Me.LblLoading.Size = New System.Drawing.Size(501, 160)
        Me.LblLoading.TabIndex = 196
        Me.LblLoading.Text = resources.GetString("LblLoading.Text")
        Me.LblLoading.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Bordeless
        '
        Me.Bordeless.BorderRadius = 20
        Me.Bordeless.ContainerControl = Me
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(700, 640)
        Me.Controls.Add(Me.bpCadUser)
        Me.Controls.Add(Me.PanelEtapa)
        Me.Controls.Add(Me.PanelBarraSup)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelBarraSup.ResumeLayout(False)
        Me.PanelEtapa.ResumeLayout(False)
        Me.PanelEtapa.PerformLayout()
        CType(Me.pbTopBusiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTopProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bpCadUser.ResumeLayout(False)
        Me.tpUserLogin.ResumeLayout(False)
        Me.tpUserLogin.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAcesso.ResumeLayout(False)
        Me.tpAcesso.PerformLayout()
        Me.tpPerfil.ResumeLayout(False)
        Me.tpPerfil.PerformLayout()
        CType(Me.pbWhats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTermos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpBusiness.ResumeLayout(False)
        Me.tpBusiness.PerformLayout()
        Me.tpPermissao.ResumeLayout(False)
        CType(Me.pbPermAviso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCheckList.ResumeLayout(False)
        CType(Me.pbChklistAviso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpBanco.ResumeLayout(False)
        Me.tpBanco.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRedefinir.ResumeLayout(False)
        Me.tpRedefinir.PerformLayout()
        Me.tpConfUser.ResumeLayout(False)
        Me.tpConfUser.PerformLayout()
        Me.tpEditarBanco.ResumeLayout(False)
        Me.tpEditarBanco.PerformLayout()
        Me.TpLoading.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PanelBarraSup As Panel
    Friend WithEvents drag As Guna.UI2.WinForms.Guna2DragControl
    Private WithEvents lblProfile As Label
    Private WithEvents lblBusiness As Label
    Private WithEvents lblPermissao As Label
    Private WithEvents lblAcesso As Label
    Private WithEvents lblChecklist As Label
    Friend WithEvents PanelEtapa As Panel
    Friend WithEvents imgLogin As ImageList
    Friend WithEvents imgLogin1 As ImageList
    Friend WithEvents pbTopBusiness As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pbTopProfile As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TimerUserInvalido As Timer
    Friend WithEvents TimerAutoLogin As Timer
    Friend WithEvents TimerEditarBD As Timer
    Friend WithEvents TimerRdf As Timer
    Friend WithEvents TimerRdfSenha As Timer
    Friend WithEvents TimerCadastro As Timer
    Friend WithEvents btnYoutube As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnFacebook As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnInstagram As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnAcessoBD As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnMaximizar As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnMinimizar As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents bpCadUser As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents tpUserLogin As TabPage
    Friend WithEvents chkLembrarAcesso As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents lblAutoLogin As Label
    Friend WithEvents lblLembrarAcesso As Label
    Friend WithEvents chkAutoLogin As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents lblInvalido As Label
    Friend WithEvents lblCapsLook As Label
    Friend WithEvents lblLoginPass As Label
    Friend WithEvents lblLoginEmail As Label
    Friend WithEvents btnAddUser As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtLoginEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLoginPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents tpAcesso As TabPage
    Friend WithEvents lblCadEmail As Label
    Friend WithEvents lblCadCapsLook As Label
    Friend WithEvents lblAcessoConfPass As Label
    Friend WithEvents lblAcessoPass As Label
    Friend WithEvents lblAcessoEmail As Label
    Friend WithEvents btnAvAcesso As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnVoltAcesso As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtCadEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCadPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCadConfPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tpPerfil As TabPage
    Friend WithEvents pbWhats As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pbEmail As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pbTermos As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblPerfilUF As Label
    Friend WithEvents lblPerfilCidade As Label
    Friend WithEvents lblPerfilComplemento As Label
    Friend WithEvents lblPerfilCelular As Label
    Friend WithEvents lblPerfilGenero As Label
    Friend WithEvents lblPerfilEndereco As Label
    Friend WithEvents lblPerfilCep As Label
    Friend WithEvents lblPerfilNascimento As Label
    Friend WithEvents lblPerfilNome As Label
    Friend WithEvents txtPerfilNascimento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAvPerfil As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnVoltPerfil As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblPerfilEmail As Label
    Friend WithEvents lblPerfilTermos As LinkLabel
    Friend WithEvents lblPerfilAceptTermos As Label
    Friend WithEvents lblPerfilWhats As Label
    Friend WithEvents txtPerfilNome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPerfilCelular As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPerfilEndereco As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPerfilCep As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPerfilComp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPerfilCidade As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chkPerfilWhats As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents chkPerfilEmail As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents chkPerfilTermos As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents cbPerfilGenero As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblPerfilInf As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPerfilUF As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tpBusiness As TabPage
    Friend WithEvents lblBusinessRmal As Label
    Friend WithEvents lblBusinessTelefone As Label
    Friend WithEvents lblBusinessFuncao As Label
    Friend WithEvents lblBusinessDepart As Label
    Friend WithEvents lblBusinessEmpresa As Label
    Friend WithEvents btnAvBusiness As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnVoltBusiness As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtBusinessEmpresa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBusinessDepart As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBusinessFuncao As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBusinessTel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBusinessRamal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tpPermissao As TabPage
    Friend WithEvents btnPermAvancar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnPermVoltar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pbPermAviso As PictureBox
    Friend WithEvents lblPermAviso As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tpCheckList As TabPage
    Friend WithEvents btnChklistFinalizar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnChklistVoltar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblChklistAviso As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pbChklistAviso As PictureBox
    Friend WithEvents tpBanco As TabPage
    Friend WithEvents btnBDConnect As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblBDAviso As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblBDSenha As Label
    Friend WithEvents lblBDUser As Label
    Friend WithEvents lblBDBanco As Label
    Friend WithEvents lblBDPorta As Label
    Friend WithEvents lblBDServidor As Label
    Friend WithEvents btnBDDefault As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnBDCancelar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnBDSalvar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtBDPorta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBDSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBDUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBDBanco As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBDServidor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents tpRedefinir As TabPage
    Friend WithEvents lblRdfInvalido As Label
    Friend WithEvents btnRdfCancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnRdfEnviar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblRdfEmail As Label
    Friend WithEvents txtRdfEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblRdfAviso As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tpConfUser As TabPage
    Friend WithEvents lblConfInvalido As Label
    Friend WithEvents lblConfAviso As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnConfCancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnConfValidar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblConfToken As Label
    Friend WithEvents txtConfToken As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tpEditarBanco As TabPage
    Friend WithEvents lblEditarBDInvalido As Label
    Friend WithEvents lblEditarBDCaps As Label
    Friend WithEvents lblEditarBDSenha As Label
    Friend WithEvents txtEditarBDSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblEditarBD As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnCancelarBD As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEditarBD As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblEditarBDEmail As Label
    Friend WithEvents txtEditarBDEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TpLoading As TabPage
    Friend WithEvents ProgressAguarde As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents LblLoading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblLoginRdf As Label
    Friend WithEvents pbBusiness As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents pbProfile As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents pbChecklist As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents pbPermissao As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents bs6 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents bs8 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents bs7 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents bs5 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents bs4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents bs3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents bs2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents bs1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents pbAcesso As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents Bordeless As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
