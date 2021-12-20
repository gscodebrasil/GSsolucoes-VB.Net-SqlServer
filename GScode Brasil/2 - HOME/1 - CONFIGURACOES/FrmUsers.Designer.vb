Imports Bunifu.UI.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsers
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SelectTransition = New Guna.UI2.WinForms.Guna2Transition()
        Me.PanelSelect = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.BtnSelectApagar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnInfoUsuario = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.HtmlLblSelect = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnSelectFechar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.PanelFilter = New Guna.UI2.WinForms.Guna2Panel()
        Me.GBoxOpcoes = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BtnEmail = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnNome = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnToken = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnRamal = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnUF = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnCidade = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnLimpar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnAplicar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnMesAtual = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnUltimos3Meses = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnUltimoMes = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.GBoxDataFinal = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.DataFinal = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.GBoxDataInicial = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.DataInicial = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.GBoxGenero = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BtnMasculino = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnFeminino = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnSelectIntervalo = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TabControlUsers = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TpInicial = New System.Windows.Forms.TabPage()
        Me.BtnListarUsuarios = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ShPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.LblUsuario = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtToken = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnEditarPermissoes = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Lbl5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TpListaUsuario = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.CbRegistrosPorPagina = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtFilter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PanelCentral = New Guna.UI2.WinForms.Guna2Panel()
        Me.DgvUsers = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.DgvColumnSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PanelPaginacao = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblSelectRegister = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblPaginacao = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnPrevio = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnNext = New Guna.UI2.WinForms.Guna2Button()
        Me.TpPerfil = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnAvPerfil = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnVoltarPerfil = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnCopy = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LblChaveKey = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblUserInfo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ImgPerfil = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.TpPermissoes = New System.Windows.Forms.TabPage()
        Me.TlpPermissoes = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelPermissoes = New System.Windows.Forms.Panel()
        Me.S6 = New Guna.UI2.WinForms.Guna2Separator()
        Me.PanelDashboard = New System.Windows.Forms.Panel()
        Me.PanelListDashboard = New System.Windows.Forms.Panel()
        Me.BtnDashboardNv1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnDashboardNv2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnDashboardNv3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnDashboardNv4 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnDashboard = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.S5 = New Guna.UI2.WinForms.Guna2Separator()
        Me.PanelFinanceiro = New System.Windows.Forms.Panel()
        Me.PanelListFinanceiro = New System.Windows.Forms.Panel()
        Me.BtnFinanceiroNv1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnFinanceiroNv2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnFinanceiroNv3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnFinanceiroNv4 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnFinanceiro = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.S4 = New Guna.UI2.WinForms.Guna2Separator()
        Me.PanelEstoque = New System.Windows.Forms.Panel()
        Me.PanelListEstoque = New System.Windows.Forms.Panel()
        Me.BtnEstoqueNv1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnEstoqueNv2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnEstoqueNv3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnEstoqueNv4 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnEstoque = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.S3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.PanelHelpdesk = New System.Windows.Forms.Panel()
        Me.PanelListHelpdesk = New System.Windows.Forms.Panel()
        Me.BtnHelpdeskNv1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnHelpdeskNv2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnHelpdeskNv3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnHelpdeskNv4 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnHelpdesk = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.S2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.PanelPhonebook = New System.Windows.Forms.Panel()
        Me.PanelListPhonebook = New System.Windows.Forms.Panel()
        Me.BtnPhonebookNv1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnPhonebookNv2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnPhonebookNv3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnPhonebookNv4 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnPhonebook = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.S1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.PanelHome = New System.Windows.Forms.Panel()
        Me.PanelListHome = New System.Windows.Forms.Panel()
        Me.BtnHomeNv1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnHomeNv2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnHomeNv3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnHomeNv4 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnHome = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PanelNextPrevio = New System.Windows.Forms.Panel()
        Me.BtnSalvar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnCancelarPerm = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.S0 = New Guna.UI2.WinForms.Guna2Separator()
        Me.ImgUsers = New System.Windows.Forms.ImageList(Me.components)
        Me.TimerSalvar = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TimerBuscarUsers = New System.Windows.Forms.Timer(Me.components)
        Me.PanelSelect.SuspendLayout()
        Me.PanelFilter.SuspendLayout()
        Me.GBoxOpcoes.SuspendLayout()
        Me.GBoxDataFinal.SuspendLayout()
        Me.GBoxDataInicial.SuspendLayout()
        Me.GBoxGenero.SuspendLayout()
        Me.TabControlUsers.SuspendLayout()
        Me.TpInicial.SuspendLayout()
        Me.ShPanel1.SuspendLayout()
        Me.TpListaUsuario.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.PanelCentral.SuspendLayout()
        CType(Me.DgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPaginacao.SuspendLayout()
        Me.TpPerfil.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.ImgPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpPermissoes.SuspendLayout()
        Me.TlpPermissoes.SuspendLayout()
        Me.PanelPermissoes.SuspendLayout()
        Me.PanelDashboard.SuspendLayout()
        Me.PanelListDashboard.SuspendLayout()
        Me.PanelFinanceiro.SuspendLayout()
        Me.PanelListFinanceiro.SuspendLayout()
        Me.PanelEstoque.SuspendLayout()
        Me.PanelListEstoque.SuspendLayout()
        Me.PanelHelpdesk.SuspendLayout()
        Me.PanelListHelpdesk.SuspendLayout()
        Me.PanelPhonebook.SuspendLayout()
        Me.PanelListPhonebook.SuspendLayout()
        Me.PanelHome.SuspendLayout()
        Me.PanelListHome.SuspendLayout()
        Me.PanelNextPrevio.SuspendLayout()
        Me.SuspendLayout()
        '
        'SelectTransition
        '
        Me.SelectTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide
        Me.SelectTransition.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.SelectTransition.DefaultAnimation = Animation1
        Me.SelectTransition.MaxAnimationTime = 1000
        Me.SelectTransition.TimeStep = 0.03!
        '
        'PanelSelect
        '
        Me.PanelSelect.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelSelect.BackColor = System.Drawing.Color.Transparent
        Me.PanelSelect.Controls.Add(Me.BtnSelectApagar)
        Me.PanelSelect.Controls.Add(Me.BtnInfoUsuario)
        Me.PanelSelect.Controls.Add(Me.HtmlLblSelect)
        Me.PanelSelect.Controls.Add(Me.BtnSelectFechar)
        Me.SelectTransition.SetDecoration(Me.PanelSelect, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelSelect.FillColor = System.Drawing.Color.White
        Me.PanelSelect.Location = New System.Drawing.Point(227, 5)
        Me.PanelSelect.Name = "PanelSelect"
        Me.PanelSelect.ShadowColor = System.Drawing.Color.Black
        Me.PanelSelect.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.PanelSelect.Size = New System.Drawing.Size(326, 89)
        Me.PanelSelect.TabIndex = 5
        Me.PanelSelect.Visible = False
        '
        'BtnSelectApagar
        '
        Me.BtnSelectApagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectApagar.BorderRadius = 5
        Me.BtnSelectApagar.CheckedState.Parent = Me.BtnSelectApagar
        Me.BtnSelectApagar.CustomImages.Parent = Me.BtnSelectApagar
        Me.SelectTransition.SetDecoration(Me.BtnSelectApagar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnSelectApagar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSelectApagar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSelectApagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSelectApagar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSelectApagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSelectApagar.DisabledState.Parent = Me.BtnSelectApagar
        Me.BtnSelectApagar.FillColor = System.Drawing.Color.Red
        Me.BtnSelectApagar.FillColor2 = System.Drawing.Color.Black
        Me.BtnSelectApagar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSelectApagar.ForeColor = System.Drawing.Color.White
        Me.BtnSelectApagar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnSelectApagar.HoverState.Parent = Me.BtnSelectApagar
        Me.BtnSelectApagar.Image = CType(resources.GetObject("BtnSelectApagar.Image"), System.Drawing.Image)
        Me.BtnSelectApagar.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnSelectApagar.Location = New System.Drawing.Point(168, 46)
        Me.BtnSelectApagar.Name = "BtnSelectApagar"
        Me.BtnSelectApagar.ShadowDecoration.Parent = Me.BtnSelectApagar
        Me.BtnSelectApagar.Size = New System.Drawing.Size(85, 32)
        Me.BtnSelectApagar.TabIndex = 18
        Me.BtnSelectApagar.Text = "Excluir"
        '
        'BtnInfoUsuario
        '
        Me.BtnInfoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnInfoUsuario.BorderRadius = 5
        Me.BtnInfoUsuario.CheckedState.Parent = Me.BtnInfoUsuario
        Me.BtnInfoUsuario.CustomImages.Parent = Me.BtnInfoUsuario
        Me.SelectTransition.SetDecoration(Me.BtnInfoUsuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnInfoUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnInfoUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnInfoUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnInfoUsuario.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnInfoUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnInfoUsuario.DisabledState.Parent = Me.BtnInfoUsuario
        Me.BtnInfoUsuario.FillColor = System.Drawing.Color.SlateGray
        Me.BtnInfoUsuario.FillColor2 = System.Drawing.Color.Black
        Me.BtnInfoUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnInfoUsuario.ForeColor = System.Drawing.Color.White
        Me.BtnInfoUsuario.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnInfoUsuario.HoverState.Parent = Me.BtnInfoUsuario
        Me.BtnInfoUsuario.Image = CType(resources.GetObject("BtnInfoUsuario.Image"), System.Drawing.Image)
        Me.BtnInfoUsuario.ImageSize = New System.Drawing.Size(13, 13)
        Me.BtnInfoUsuario.Location = New System.Drawing.Point(73, 46)
        Me.BtnInfoUsuario.Name = "BtnInfoUsuario"
        Me.BtnInfoUsuario.ShadowDecoration.Parent = Me.BtnInfoUsuario
        Me.BtnInfoUsuario.Size = New System.Drawing.Size(85, 32)
        Me.BtnInfoUsuario.TabIndex = 17
        Me.BtnInfoUsuario.Text = "Info"
        Me.BtnInfoUsuario.TextOffset = New System.Drawing.Point(1, 0)
        '
        'HtmlLblSelect
        '
        Me.HtmlLblSelect.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.HtmlLblSelect, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HtmlLblSelect.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HtmlLblSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HtmlLblSelect.Location = New System.Drawing.Point(14, 10)
        Me.HtmlLblSelect.Name = "HtmlLblSelect"
        Me.HtmlLblSelect.Size = New System.Drawing.Size(153, 19)
        Me.HtmlLblSelect.TabIndex = 16
        Me.HtmlLblSelect.Text = "Usuários selecionados (1)"
        '
        'BtnSelectFechar
        '
        Me.BtnSelectFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectFechar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSelectFechar.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BtnSelectFechar.CheckedState.Parent = Me.BtnSelectFechar
        Me.SelectTransition.SetDecoration(Me.BtnSelectFechar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnSelectFechar.HoverState.Parent = Me.BtnSelectFechar
        Me.BtnSelectFechar.Image = CType(resources.GetObject("BtnSelectFechar.Image"), System.Drawing.Image)
        Me.BtnSelectFechar.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BtnSelectFechar.ImageRotate = 0!
        Me.BtnSelectFechar.ImageSize = New System.Drawing.Size(16, 16)
        Me.BtnSelectFechar.Location = New System.Drawing.Point(295, 6)
        Me.BtnSelectFechar.Name = "BtnSelectFechar"
        Me.BtnSelectFechar.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.BtnSelectFechar.PressedState.Parent = Me.BtnSelectFechar
        Me.BtnSelectFechar.ShadowDecoration.Parent = Me.BtnSelectFechar
        Me.BtnSelectFechar.Size = New System.Drawing.Size(20, 20)
        Me.BtnSelectFechar.TabIndex = 188
        '
        'PanelFilter
        '
        Me.PanelFilter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelFilter.BorderColor = System.Drawing.Color.SlateGray
        Me.PanelFilter.BorderRadius = 6
        Me.PanelFilter.BorderThickness = 1
        Me.PanelFilter.Controls.Add(Me.GBoxOpcoes)
        Me.PanelFilter.Controls.Add(Me.BtnLimpar)
        Me.PanelFilter.Controls.Add(Me.BtnAplicar)
        Me.PanelFilter.Controls.Add(Me.BtnMesAtual)
        Me.PanelFilter.Controls.Add(Me.BtnUltimos3Meses)
        Me.PanelFilter.Controls.Add(Me.BtnUltimoMes)
        Me.PanelFilter.Controls.Add(Me.GBoxDataFinal)
        Me.PanelFilter.Controls.Add(Me.GBoxDataInicial)
        Me.PanelFilter.Controls.Add(Me.GBoxGenero)
        Me.PanelFilter.Controls.Add(Me.BtnSelectIntervalo)
        Me.PanelFilter.CustomizableEdges.TopLeft = False
        Me.PanelFilter.CustomizableEdges.TopRight = False
        Me.SelectTransition.SetDecoration(Me.PanelFilter, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelFilter.Location = New System.Drawing.Point(35, 75)
        Me.PanelFilter.Name = "PanelFilter"
        Me.PanelFilter.ShadowDecoration.Parent = Me.PanelFilter
        Me.PanelFilter.Size = New System.Drawing.Size(461, 320)
        Me.PanelFilter.TabIndex = 12
        Me.PanelFilter.Visible = False
        '
        'GBoxOpcoes
        '
        Me.GBoxOpcoes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBoxOpcoes.BorderColor = System.Drawing.Color.SlateGray
        Me.GBoxOpcoes.BorderThickness = 0
        Me.GBoxOpcoes.Controls.Add(Me.BtnEmail)
        Me.GBoxOpcoes.Controls.Add(Me.BtnNome)
        Me.GBoxOpcoes.Controls.Add(Me.BtnToken)
        Me.GBoxOpcoes.Controls.Add(Me.BtnRamal)
        Me.GBoxOpcoes.Controls.Add(Me.BtnUF)
        Me.GBoxOpcoes.Controls.Add(Me.BtnCidade)
        Me.GBoxOpcoes.CustomBorderColor = System.Drawing.Color.SlateGray
        Me.GBoxOpcoes.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.SelectTransition.SetDecoration(Me.GBoxOpcoes, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GBoxOpcoes.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GBoxOpcoes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GBoxOpcoes.ForeColor = System.Drawing.Color.White
        Me.GBoxOpcoes.Location = New System.Drawing.Point(1, 18)
        Me.GBoxOpcoes.Name = "GBoxOpcoes"
        Me.GBoxOpcoes.ShadowDecoration.Parent = Me.GBoxOpcoes
        Me.GBoxOpcoes.Size = New System.Drawing.Size(311, 77)
        Me.GBoxOpcoes.TabIndex = 53
        '
        'BtnEmail
        '
        Me.BtnEmail.BorderColor = System.Drawing.Color.DimGray
        Me.BtnEmail.BorderRadius = 3
        Me.BtnEmail.BorderThickness = 1
        Me.BtnEmail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnEmail.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnEmail.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnEmail.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnEmail.CheckedState.Parent = Me.BtnEmail
        Me.BtnEmail.CustomImages.Parent = Me.BtnEmail
        Me.BtnEmail.CustomizableEdges.BottomLeft = False
        Me.BtnEmail.CustomizableEdges.BottomRight = False
        Me.BtnEmail.CustomizableEdges.TopLeft = False
        Me.BtnEmail.CustomizableEdges.TopRight = False
        Me.SelectTransition.SetDecoration(Me.BtnEmail, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEmail.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnEmail.DisabledState.Parent = Me.BtnEmail
        Me.BtnEmail.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnEmail.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEmail.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnEmail.HoverState.Parent = Me.BtnEmail
        Me.BtnEmail.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnEmail.Location = New System.Drawing.Point(105, 7)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.ShadowDecoration.Parent = Me.BtnEmail
        Me.BtnEmail.Size = New System.Drawing.Size(100, 32)
        Me.BtnEmail.TabIndex = 47
        Me.BtnEmail.Text = "E-mail"
        '
        'BtnNome
        '
        Me.BtnNome.BorderColor = System.Drawing.Color.DimGray
        Me.BtnNome.BorderRadius = 3
        Me.BtnNome.BorderThickness = 1
        Me.BtnNome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnNome.Checked = True
        Me.BtnNome.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnNome.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnNome.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnNome.CheckedState.Parent = Me.BtnNome
        Me.BtnNome.CustomImages.Parent = Me.BtnNome
        Me.BtnNome.CustomizableEdges.BottomLeft = False
        Me.BtnNome.CustomizableEdges.BottomRight = False
        Me.BtnNome.CustomizableEdges.TopRight = False
        Me.SelectTransition.SetDecoration(Me.BtnNome, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnNome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnNome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnNome.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnNome.DisabledState.Parent = Me.BtnNome
        Me.BtnNome.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnNome.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnNome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnNome.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnNome.HoverState.Parent = Me.BtnNome
        Me.BtnNome.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnNome.Location = New System.Drawing.Point(6, 7)
        Me.BtnNome.Name = "BtnNome"
        Me.BtnNome.ShadowDecoration.Parent = Me.BtnNome
        Me.BtnNome.Size = New System.Drawing.Size(100, 32)
        Me.BtnNome.TabIndex = 44
        Me.BtnNome.Text = "Nome"
        '
        'BtnToken
        '
        Me.BtnToken.BorderColor = System.Drawing.Color.DimGray
        Me.BtnToken.BorderRadius = 3
        Me.BtnToken.BorderThickness = 1
        Me.BtnToken.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnToken.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnToken.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnToken.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnToken.CheckedState.Parent = Me.BtnToken
        Me.BtnToken.CustomImages.Parent = Me.BtnToken
        Me.BtnToken.CustomizableEdges.BottomLeft = False
        Me.BtnToken.CustomizableEdges.TopLeft = False
        Me.BtnToken.CustomizableEdges.TopRight = False
        Me.SelectTransition.SetDecoration(Me.BtnToken, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnToken.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnToken.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnToken.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnToken.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnToken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnToken.DisabledState.Parent = Me.BtnToken
        Me.BtnToken.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnToken.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnToken.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnToken.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnToken.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnToken.HoverState.Parent = Me.BtnToken
        Me.BtnToken.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnToken.Location = New System.Drawing.Point(204, 38)
        Me.BtnToken.Name = "BtnToken"
        Me.BtnToken.ShadowDecoration.Parent = Me.BtnToken
        Me.BtnToken.Size = New System.Drawing.Size(100, 32)
        Me.BtnToken.TabIndex = 46
        Me.BtnToken.Text = "Token"
        '
        'BtnRamal
        '
        Me.BtnRamal.BorderColor = System.Drawing.Color.DimGray
        Me.BtnRamal.BorderRadius = 3
        Me.BtnRamal.BorderThickness = 1
        Me.BtnRamal.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnRamal.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnRamal.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnRamal.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnRamal.CheckedState.Parent = Me.BtnRamal
        Me.BtnRamal.CustomImages.Parent = Me.BtnRamal
        Me.BtnRamal.CustomizableEdges.BottomLeft = False
        Me.BtnRamal.CustomizableEdges.BottomRight = False
        Me.BtnRamal.CustomizableEdges.TopLeft = False
        Me.SelectTransition.SetDecoration(Me.BtnRamal, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnRamal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnRamal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnRamal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnRamal.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnRamal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnRamal.DisabledState.Parent = Me.BtnRamal
        Me.BtnRamal.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnRamal.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnRamal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnRamal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnRamal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnRamal.HoverState.Parent = Me.BtnRamal
        Me.BtnRamal.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnRamal.Location = New System.Drawing.Point(204, 7)
        Me.BtnRamal.Name = "BtnRamal"
        Me.BtnRamal.ShadowDecoration.Parent = Me.BtnRamal
        Me.BtnRamal.Size = New System.Drawing.Size(100, 32)
        Me.BtnRamal.TabIndex = 49
        Me.BtnRamal.Text = "Ramal"
        '
        'BtnUF
        '
        Me.BtnUF.BorderColor = System.Drawing.Color.DimGray
        Me.BtnUF.BorderRadius = 3
        Me.BtnUF.BorderThickness = 1
        Me.BtnUF.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnUF.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnUF.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnUF.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnUF.CheckedState.Parent = Me.BtnUF
        Me.BtnUF.CustomImages.Parent = Me.BtnUF
        Me.BtnUF.CustomizableEdges.BottomLeft = False
        Me.BtnUF.CustomizableEdges.BottomRight = False
        Me.BtnUF.CustomizableEdges.TopLeft = False
        Me.BtnUF.CustomizableEdges.TopRight = False
        Me.SelectTransition.SetDecoration(Me.BtnUF, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnUF.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUF.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUF.DisabledState.Parent = Me.BtnUF
        Me.BtnUF.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnUF.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnUF.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnUF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnUF.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnUF.HoverState.Parent = Me.BtnUF
        Me.BtnUF.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnUF.Location = New System.Drawing.Point(105, 38)
        Me.BtnUF.Name = "BtnUF"
        Me.BtnUF.ShadowDecoration.Parent = Me.BtnUF
        Me.BtnUF.Size = New System.Drawing.Size(100, 32)
        Me.BtnUF.TabIndex = 45
        Me.BtnUF.Text = "UF"
        '
        'BtnCidade
        '
        Me.BtnCidade.BorderColor = System.Drawing.Color.DimGray
        Me.BtnCidade.BorderRadius = 3
        Me.BtnCidade.BorderThickness = 1
        Me.BtnCidade.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnCidade.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnCidade.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnCidade.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnCidade.CheckedState.Parent = Me.BtnCidade
        Me.BtnCidade.CustomImages.Parent = Me.BtnCidade
        Me.BtnCidade.CustomizableEdges.BottomRight = False
        Me.BtnCidade.CustomizableEdges.TopLeft = False
        Me.BtnCidade.CustomizableEdges.TopRight = False
        Me.SelectTransition.SetDecoration(Me.BtnCidade, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnCidade.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCidade.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCidade.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCidade.DisabledState.Parent = Me.BtnCidade
        Me.BtnCidade.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnCidade.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnCidade.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCidade.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnCidade.HoverState.Parent = Me.BtnCidade
        Me.BtnCidade.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnCidade.Location = New System.Drawing.Point(6, 38)
        Me.BtnCidade.Name = "BtnCidade"
        Me.BtnCidade.ShadowDecoration.Parent = Me.BtnCidade
        Me.BtnCidade.Size = New System.Drawing.Size(100, 32)
        Me.BtnCidade.TabIndex = 48
        Me.BtnCidade.Text = "Cidade"
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpar.BackColor = System.Drawing.Color.Transparent
        Me.BtnLimpar.BorderColor = System.Drawing.Color.Silver
        Me.BtnLimpar.BorderRadius = 3
        Me.BtnLimpar.BorderThickness = 1
        Me.BtnLimpar.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnLimpar.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnLimpar.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnLimpar.CheckedState.Parent = Me.BtnLimpar
        Me.BtnLimpar.CustomImages.Parent = Me.BtnLimpar
        Me.SelectTransition.SetDecoration(Me.BtnLimpar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnLimpar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnLimpar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnLimpar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnLimpar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnLimpar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnLimpar.DisabledState.Parent = Me.BtnLimpar
        Me.BtnLimpar.FillColor = System.Drawing.Color.Empty
        Me.BtnLimpar.FillColor2 = System.Drawing.Color.Empty
        Me.BtnLimpar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.Color.Gray
        Me.BtnLimpar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnLimpar.HoverState.Parent = Me.BtnLimpar
        Me.BtnLimpar.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnLimpar.Location = New System.Drawing.Point(315, 288)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.BtnLimpar.ShadowDecoration.Parent = Me.BtnLimpar
        Me.BtnLimpar.Size = New System.Drawing.Size(68, 28)
        Me.BtnLimpar.TabIndex = 52
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.Visible = False
        '
        'BtnAplicar
        '
        Me.BtnAplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAplicar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAplicar.BorderColor = System.Drawing.Color.SlateGray
        Me.BtnAplicar.BorderRadius = 3
        Me.BtnAplicar.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnAplicar.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnAplicar.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnAplicar.CheckedState.Parent = Me.BtnAplicar
        Me.BtnAplicar.CustomImages.Parent = Me.BtnAplicar
        Me.SelectTransition.SetDecoration(Me.BtnAplicar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnAplicar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAplicar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAplicar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAplicar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAplicar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAplicar.DisabledState.Parent = Me.BtnAplicar
        Me.BtnAplicar.FillColor = System.Drawing.Color.SlateGray
        Me.BtnAplicar.FillColor2 = System.Drawing.Color.Black
        Me.BtnAplicar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAplicar.ForeColor = System.Drawing.Color.White
        Me.BtnAplicar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnAplicar.HoverState.Parent = Me.BtnAplicar
        Me.BtnAplicar.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnAplicar.Location = New System.Drawing.Point(389, 288)
        Me.BtnAplicar.Name = "BtnAplicar"
        Me.BtnAplicar.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.BtnAplicar.ShadowDecoration.Parent = Me.BtnAplicar
        Me.BtnAplicar.Size = New System.Drawing.Size(68, 28)
        Me.BtnAplicar.TabIndex = 51
        Me.BtnAplicar.Text = "Aplicar"
        Me.BtnAplicar.Visible = False
        '
        'BtnMesAtual
        '
        Me.BtnMesAtual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnMesAtual.BorderColor = System.Drawing.Color.DimGray
        Me.BtnMesAtual.BorderRadius = 3
        Me.BtnMesAtual.BorderThickness = 1
        Me.BtnMesAtual.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnMesAtual.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnMesAtual.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnMesAtual.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnMesAtual.CheckedState.Parent = Me.BtnMesAtual
        Me.BtnMesAtual.CustomImages.Parent = Me.BtnMesAtual
        Me.BtnMesAtual.CustomizableEdges.BottomRight = False
        Me.BtnMesAtual.CustomizableEdges.TopRight = False
        Me.SelectTransition.SetDecoration(Me.BtnMesAtual, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnMesAtual.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnMesAtual.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnMesAtual.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnMesAtual.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnMesAtual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnMesAtual.DisabledState.Parent = Me.BtnMesAtual
        Me.BtnMesAtual.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnMesAtual.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnMesAtual.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.BtnMesAtual.ForeColor = System.Drawing.Color.Black
        Me.BtnMesAtual.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnMesAtual.HoverState.Parent = Me.BtnMesAtual
        Me.BtnMesAtual.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnMesAtual.Location = New System.Drawing.Point(62, 207)
        Me.BtnMesAtual.Name = "BtnMesAtual"
        Me.BtnMesAtual.ShadowDecoration.Parent = Me.BtnMesAtual
        Me.BtnMesAtual.Size = New System.Drawing.Size(113, 22)
        Me.BtnMesAtual.TabIndex = 49
        Me.BtnMesAtual.Text = "Mês Atual"
        '
        'BtnUltimos3Meses
        '
        Me.BtnUltimos3Meses.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnUltimos3Meses.BorderColor = System.Drawing.Color.DimGray
        Me.BtnUltimos3Meses.BorderRadius = 3
        Me.BtnUltimos3Meses.BorderThickness = 1
        Me.BtnUltimos3Meses.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnUltimos3Meses.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnUltimos3Meses.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnUltimos3Meses.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnUltimos3Meses.CheckedState.Parent = Me.BtnUltimos3Meses
        Me.BtnUltimos3Meses.CustomImages.Parent = Me.BtnUltimos3Meses
        Me.BtnUltimos3Meses.CustomizableEdges.BottomLeft = False
        Me.BtnUltimos3Meses.CustomizableEdges.TopLeft = False
        Me.SelectTransition.SetDecoration(Me.BtnUltimos3Meses, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnUltimos3Meses.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUltimos3Meses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUltimos3Meses.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUltimos3Meses.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUltimos3Meses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUltimos3Meses.DisabledState.Parent = Me.BtnUltimos3Meses
        Me.BtnUltimos3Meses.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnUltimos3Meses.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnUltimos3Meses.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnUltimos3Meses.ForeColor = System.Drawing.Color.Black
        Me.BtnUltimos3Meses.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnUltimos3Meses.HoverState.Parent = Me.BtnUltimos3Meses
        Me.BtnUltimos3Meses.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnUltimos3Meses.Location = New System.Drawing.Point(286, 207)
        Me.BtnUltimos3Meses.Name = "BtnUltimos3Meses"
        Me.BtnUltimos3Meses.ShadowDecoration.Parent = Me.BtnUltimos3Meses
        Me.BtnUltimos3Meses.Size = New System.Drawing.Size(113, 22)
        Me.BtnUltimos3Meses.TabIndex = 48
        Me.BtnUltimos3Meses.Text = "Ultimos 3 Meses"
        '
        'BtnUltimoMes
        '
        Me.BtnUltimoMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnUltimoMes.BorderColor = System.Drawing.Color.DimGray
        Me.BtnUltimoMes.BorderRadius = 3
        Me.BtnUltimoMes.BorderThickness = 1
        Me.BtnUltimoMes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnUltimoMes.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnUltimoMes.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnUltimoMes.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnUltimoMes.CheckedState.Parent = Me.BtnUltimoMes
        Me.BtnUltimoMes.CustomImages.Parent = Me.BtnUltimoMes
        Me.BtnUltimoMes.CustomizableEdges.BottomLeft = False
        Me.BtnUltimoMes.CustomizableEdges.BottomRight = False
        Me.BtnUltimoMes.CustomizableEdges.TopLeft = False
        Me.BtnUltimoMes.CustomizableEdges.TopRight = False
        Me.SelectTransition.SetDecoration(Me.BtnUltimoMes, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnUltimoMes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUltimoMes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUltimoMes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUltimoMes.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUltimoMes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUltimoMes.DisabledState.Parent = Me.BtnUltimoMes
        Me.BtnUltimoMes.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnUltimoMes.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnUltimoMes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnUltimoMes.ForeColor = System.Drawing.Color.Black
        Me.BtnUltimoMes.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnUltimoMes.HoverState.Parent = Me.BtnUltimoMes
        Me.BtnUltimoMes.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnUltimoMes.Location = New System.Drawing.Point(174, 207)
        Me.BtnUltimoMes.Name = "BtnUltimoMes"
        Me.BtnUltimoMes.ShadowDecoration.Parent = Me.BtnUltimoMes
        Me.BtnUltimoMes.Size = New System.Drawing.Size(113, 22)
        Me.BtnUltimoMes.TabIndex = 47
        Me.BtnUltimoMes.Text = "Ultimo Mês"
        '
        'GBoxDataFinal
        '
        Me.GBoxDataFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBoxDataFinal.BorderColor = System.Drawing.Color.SlateGray
        Me.GBoxDataFinal.Controls.Add(Me.DataFinal)
        Me.GBoxDataFinal.CustomBorderColor = System.Drawing.Color.SlateGray
        Me.GBoxDataFinal.CustomBorderThickness = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.SelectTransition.SetDecoration(Me.GBoxDataFinal, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GBoxDataFinal.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GBoxDataFinal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GBoxDataFinal.ForeColor = System.Drawing.Color.White
        Me.GBoxDataFinal.Location = New System.Drawing.Point(246, 119)
        Me.GBoxDataFinal.Name = "GBoxDataFinal"
        Me.GBoxDataFinal.ShadowDecoration.Parent = Me.GBoxDataFinal
        Me.GBoxDataFinal.Size = New System.Drawing.Size(194, 70)
        Me.GBoxDataFinal.TabIndex = 46
        Me.GBoxDataFinal.Text = "Data Final"
        Me.GBoxDataFinal.TextOffset = New System.Drawing.Point(0, -10)
        Me.GBoxDataFinal.Visible = False
        '
        'DataFinal
        '
        Me.DataFinal.Animated = True
        Me.DataFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DataFinal.BorderColor = System.Drawing.Color.Silver
        Me.DataFinal.BorderThickness = 1
        Me.DataFinal.CheckedState.Parent = Me.DataFinal
        Me.DataFinal.CustomFormat = ""
        Me.SelectTransition.SetDecoration(Me.DataFinal, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DataFinal.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DataFinal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DataFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFinal.HoverState.Parent = Me.DataFinal
        Me.DataFinal.Location = New System.Drawing.Point(7, 29)
        Me.DataFinal.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DataFinal.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataFinal.ShadowDecoration.Parent = Me.DataFinal
        Me.DataFinal.Size = New System.Drawing.Size(180, 30)
        Me.DataFinal.TabIndex = 33
        Me.DataFinal.Value = New Date(2021, 10, 6, 0, 0, 0, 0)
        '
        'GBoxDataInicial
        '
        Me.GBoxDataInicial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBoxDataInicial.BorderColor = System.Drawing.Color.SlateGray
        Me.GBoxDataInicial.Controls.Add(Me.DataInicial)
        Me.GBoxDataInicial.CustomBorderColor = System.Drawing.Color.SlateGray
        Me.GBoxDataInicial.CustomBorderThickness = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.SelectTransition.SetDecoration(Me.GBoxDataInicial, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GBoxDataInicial.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GBoxDataInicial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GBoxDataInicial.ForeColor = System.Drawing.Color.White
        Me.GBoxDataInicial.Location = New System.Drawing.Point(21, 119)
        Me.GBoxDataInicial.Name = "GBoxDataInicial"
        Me.GBoxDataInicial.ShadowDecoration.Parent = Me.GBoxDataInicial
        Me.GBoxDataInicial.Size = New System.Drawing.Size(194, 70)
        Me.GBoxDataInicial.TabIndex = 45
        Me.GBoxDataInicial.Text = "Data Inicial"
        Me.GBoxDataInicial.TextOffset = New System.Drawing.Point(0, -10)
        Me.GBoxDataInicial.Visible = False
        '
        'DataInicial
        '
        Me.DataInicial.Animated = True
        Me.DataInicial.BorderColor = System.Drawing.Color.Silver
        Me.DataInicial.BorderThickness = 1
        Me.DataInicial.CheckedState.Parent = Me.DataInicial
        Me.DataInicial.CustomFormat = ""
        Me.SelectTransition.SetDecoration(Me.DataInicial, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DataInicial.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DataInicial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DataInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInicial.HoverState.Parent = Me.DataInicial
        Me.DataInicial.Location = New System.Drawing.Point(7, 29)
        Me.DataInicial.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DataInicial.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataInicial.ShadowDecoration.Parent = Me.DataInicial
        Me.DataInicial.Size = New System.Drawing.Size(180, 30)
        Me.DataInicial.TabIndex = 33
        Me.DataInicial.Value = New Date(2021, 10, 6, 0, 0, 0, 0)
        '
        'GBoxGenero
        '
        Me.GBoxGenero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBoxGenero.BorderColor = System.Drawing.Color.SlateGray
        Me.GBoxGenero.Controls.Add(Me.BtnMasculino)
        Me.GBoxGenero.Controls.Add(Me.BtnFeminino)
        Me.GBoxGenero.CustomBorderColor = System.Drawing.Color.SlateGray
        Me.GBoxGenero.CustomBorderThickness = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.SelectTransition.SetDecoration(Me.GBoxGenero, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GBoxGenero.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GBoxGenero.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GBoxGenero.ForeColor = System.Drawing.Color.White
        Me.GBoxGenero.Location = New System.Drawing.Point(314, 7)
        Me.GBoxGenero.Name = "GBoxGenero"
        Me.GBoxGenero.ShadowDecoration.Parent = Me.GBoxGenero
        Me.GBoxGenero.Size = New System.Drawing.Size(143, 81)
        Me.GBoxGenero.TabIndex = 44
        Me.GBoxGenero.Text = "Gênero"
        Me.GBoxGenero.TextOffset = New System.Drawing.Point(0, -10)
        '
        'BtnMasculino
        '
        Me.BtnMasculino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnMasculino.BorderColor = System.Drawing.Color.DimGray
        Me.BtnMasculino.BorderRadius = 3
        Me.BtnMasculino.BorderThickness = 1
        Me.BtnMasculino.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnMasculino.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnMasculino.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnMasculino.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnMasculino.CheckedState.Parent = Me.BtnMasculino
        Me.BtnMasculino.CustomImages.Parent = Me.BtnMasculino
        Me.BtnMasculino.CustomizableEdges.TopLeft = False
        Me.BtnMasculino.CustomizableEdges.TopRight = False
        Me.SelectTransition.SetDecoration(Me.BtnMasculino, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnMasculino.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnMasculino.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnMasculino.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnMasculino.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnMasculino.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnMasculino.DisabledState.Parent = Me.BtnMasculino
        Me.BtnMasculino.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnMasculino.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnMasculino.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnMasculino.ForeColor = System.Drawing.Color.Black
        Me.BtnMasculino.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnMasculino.HoverState.Parent = Me.BtnMasculino
        Me.BtnMasculino.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnMasculino.Location = New System.Drawing.Point(15, 50)
        Me.BtnMasculino.Name = "BtnMasculino"
        Me.BtnMasculino.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.BtnMasculino.ShadowDecoration.Parent = Me.BtnMasculino
        Me.BtnMasculino.Size = New System.Drawing.Size(113, 23)
        Me.BtnMasculino.TabIndex = 50
        Me.BtnMasculino.Text = "Masculino"
        '
        'BtnFeminino
        '
        Me.BtnFeminino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnFeminino.BorderColor = System.Drawing.Color.DimGray
        Me.BtnFeminino.BorderRadius = 3
        Me.BtnFeminino.BorderThickness = 1
        Me.BtnFeminino.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnFeminino.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnFeminino.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnFeminino.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnFeminino.CheckedState.Parent = Me.BtnFeminino
        Me.BtnFeminino.CustomImages.Parent = Me.BtnFeminino
        Me.BtnFeminino.CustomizableEdges.BottomLeft = False
        Me.BtnFeminino.CustomizableEdges.BottomRight = False
        Me.SelectTransition.SetDecoration(Me.BtnFeminino, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnFeminino.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnFeminino.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnFeminino.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnFeminino.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnFeminino.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnFeminino.DisabledState.Parent = Me.BtnFeminino
        Me.BtnFeminino.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnFeminino.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BtnFeminino.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnFeminino.ForeColor = System.Drawing.Color.Black
        Me.BtnFeminino.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnFeminino.HoverState.Parent = Me.BtnFeminino
        Me.BtnFeminino.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnFeminino.Location = New System.Drawing.Point(15, 28)
        Me.BtnFeminino.Name = "BtnFeminino"
        Me.BtnFeminino.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.BtnFeminino.ShadowDecoration.Parent = Me.BtnFeminino
        Me.BtnFeminino.Size = New System.Drawing.Size(113, 23)
        Me.BtnFeminino.TabIndex = 49
        Me.BtnFeminino.Text = "Feminino"
        '
        'BtnSelectIntervalo
        '
        Me.BtnSelectIntervalo.BorderColor = System.Drawing.Color.SlateGray
        Me.BtnSelectIntervalo.BorderRadius = 3
        Me.BtnSelectIntervalo.BorderThickness = 1
        Me.BtnSelectIntervalo.CheckedState.FillColor = System.Drawing.Color.SlateGray
        Me.BtnSelectIntervalo.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnSelectIntervalo.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnSelectIntervalo.CheckedState.Parent = Me.BtnSelectIntervalo
        Me.BtnSelectIntervalo.CustomImages.Parent = Me.BtnSelectIntervalo
        Me.SelectTransition.SetDecoration(Me.BtnSelectIntervalo, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnSelectIntervalo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSelectIntervalo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSelectIntervalo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSelectIntervalo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSelectIntervalo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSelectIntervalo.DisabledState.Parent = Me.BtnSelectIntervalo
        Me.BtnSelectIntervalo.FillColor = System.Drawing.Color.SlateGray
        Me.BtnSelectIntervalo.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSelectIntervalo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSelectIntervalo.ForeColor = System.Drawing.Color.White
        Me.BtnSelectIntervalo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnSelectIntervalo.HoverState.Parent = Me.BtnSelectIntervalo
        Me.BtnSelectIntervalo.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnSelectIntervalo.Location = New System.Drawing.Point(128, 150)
        Me.BtnSelectIntervalo.Name = "BtnSelectIntervalo"
        Me.BtnSelectIntervalo.ShadowDecoration.Parent = Me.BtnSelectIntervalo
        Me.BtnSelectIntervalo.Size = New System.Drawing.Size(205, 35)
        Me.BtnSelectIntervalo.TabIndex = 50
        Me.BtnSelectIntervalo.Text = "Selecionar um intervalo de datas"
        '
        'TabControlUsers
        '
        Me.TabControlUsers.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControlUsers.Controls.Add(Me.TpInicial)
        Me.TabControlUsers.Controls.Add(Me.TpListaUsuario)
        Me.TabControlUsers.Controls.Add(Me.TpPerfil)
        Me.TabControlUsers.Controls.Add(Me.TpPermissoes)
        Me.SelectTransition.SetDecoration(Me.TabControlUsers, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TabControlUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlUsers.ItemSize = New System.Drawing.Size(100, 33)
        Me.TabControlUsers.Location = New System.Drawing.Point(0, 0)
        Me.TabControlUsers.Name = "TabControlUsers"
        Me.TabControlUsers.SelectedIndex = 0
        Me.TabControlUsers.Size = New System.Drawing.Size(788, 565)
        Me.TabControlUsers.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabControlUsers.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControlUsers.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControlUsers.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabControlUsers.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControlUsers.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabControlUsers.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControlUsers.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControlUsers.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TabControlUsers.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControlUsers.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabControlUsers.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabControlUsers.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControlUsers.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabControlUsers.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlUsers.TabButtonSize = New System.Drawing.Size(100, 33)
        Me.TabControlUsers.TabIndex = 13
        Me.TabControlUsers.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControlUsers.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalBottom
        Me.TabControlUsers.Visible = False
        '
        'TpInicial
        '
        Me.TpInicial.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpInicial.Controls.Add(Me.BtnListarUsuarios)
        Me.TpInicial.Controls.Add(Me.ShPanel1)
        Me.TpInicial.Controls.Add(Me.Lbl1)
        Me.TpInicial.Controls.Add(Me.Lbl2)
        Me.SelectTransition.SetDecoration(Me.TpInicial, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TpInicial.Location = New System.Drawing.Point(4, 4)
        Me.TpInicial.Name = "TpInicial"
        Me.TpInicial.Padding = New System.Windows.Forms.Padding(3)
        Me.TpInicial.Size = New System.Drawing.Size(780, 524)
        Me.TpInicial.TabIndex = 0
        Me.TpInicial.Text = "Tela Inicial"
        '
        'BtnListarUsuarios
        '
        Me.BtnListarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnListarUsuarios.Animated = True
        Me.BtnListarUsuarios.AutoRoundedCorners = True
        Me.BtnListarUsuarios.BorderRadius = 16
        Me.BtnListarUsuarios.CheckedState.Parent = Me.BtnListarUsuarios
        Me.BtnListarUsuarios.CustomImages.Parent = Me.BtnListarUsuarios
        Me.SelectTransition.SetDecoration(Me.BtnListarUsuarios, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnListarUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnListarUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnListarUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnListarUsuarios.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnListarUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnListarUsuarios.DisabledState.Parent = Me.BtnListarUsuarios
        Me.BtnListarUsuarios.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnListarUsuarios.FillColor2 = System.Drawing.Color.Black
        Me.BtnListarUsuarios.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnListarUsuarios.ForeColor = System.Drawing.Color.White
        Me.BtnListarUsuarios.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnListarUsuarios.HoverState.Parent = Me.BtnListarUsuarios
        Me.BtnListarUsuarios.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnListarUsuarios.Location = New System.Drawing.Point(245, 253)
        Me.BtnListarUsuarios.Name = "BtnListarUsuarios"
        Me.BtnListarUsuarios.ShadowDecoration.Parent = Me.BtnListarUsuarios
        Me.BtnListarUsuarios.Size = New System.Drawing.Size(290, 35)
        Me.BtnListarUsuarios.TabIndex = 115
        Me.BtnListarUsuarios.Text = "Listar Usuários"
        '
        'ShPanel1
        '
        Me.ShPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ShPanel1.BackColor = System.Drawing.Color.Transparent
        Me.ShPanel1.Controls.Add(Me.LblUsuario)
        Me.ShPanel1.Controls.Add(Me.TxtToken)
        Me.ShPanel1.Controls.Add(Me.BtnEditarPermissoes)
        Me.ShPanel1.Controls.Add(Me.Lbl5)
        Me.SelectTransition.SetDecoration(Me.ShPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShPanel1.FillColor = System.Drawing.Color.LightGray
        Me.ShPanel1.Location = New System.Drawing.Point(108, 81)
        Me.ShPanel1.Name = "ShPanel1"
        Me.ShPanel1.Radius = 4
        Me.ShPanel1.ShadowColor = System.Drawing.Color.Black
        Me.ShPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.ShPanel1.Size = New System.Drawing.Size(564, 147)
        Me.ShPanel1.TabIndex = 114
        '
        'LblUsuario
        '
        Me.LblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblUsuario.AutoSize = False
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.LblUsuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.Color.Black
        Me.LblUsuario.Location = New System.Drawing.Point(28, 105)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(399, 29)
        Me.LblUsuario.TabIndex = 96
        Me.LblUsuario.Text = Nothing
        Me.LblUsuario.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtToken
        '
        Me.TxtToken.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtToken.BorderColor = System.Drawing.Color.White
        Me.TxtToken.BorderRadius = 6
        Me.TxtToken.BorderThickness = 0
        Me.TxtToken.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtToken.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SelectTransition.SetDecoration(Me.TxtToken, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TxtToken.DefaultText = ""
        Me.TxtToken.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TxtToken.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TxtToken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtToken.DisabledState.Parent = Me.TxtToken
        Me.TxtToken.DisabledState.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtToken.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtToken.FocusedState.Parent = Me.TxtToken
        Me.TxtToken.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtToken.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtToken.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtToken.HoverState.Parent = Me.TxtToken
        Me.TxtToken.IconLeft = CType(resources.GetObject("TxtToken.IconLeft"), System.Drawing.Image)
        Me.TxtToken.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.TxtToken.IconLeftOffset = New System.Drawing.Point(15, 0)
        Me.TxtToken.IconLeftSize = New System.Drawing.Size(16, 16)
        Me.TxtToken.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.TxtToken.Location = New System.Drawing.Point(41, 36)
        Me.TxtToken.MaxLength = 36
        Me.TxtToken.Name = "TxtToken"
        Me.TxtToken.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtToken.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtToken.PlaceholderText = "INFORME O TOKEN..."
        Me.TxtToken.SelectedText = ""
        Me.TxtToken.ShadowDecoration.BorderRadius = 50
        Me.TxtToken.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.TxtToken.ShadowDecoration.CustomizableEdges.TopLeft = False
        Me.TxtToken.ShadowDecoration.CustomizableEdges.TopRight = False
        Me.TxtToken.ShadowDecoration.Depth = 50
        Me.TxtToken.ShadowDecoration.Parent = Me.TxtToken
        Me.TxtToken.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.TxtToken.Size = New System.Drawing.Size(461, 40)
        Me.TxtToken.TabIndex = 95
        Me.TxtToken.TextOffset = New System.Drawing.Point(5, 1)
        '
        'BtnEditarPermissoes
        '
        Me.BtnEditarPermissoes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEditarPermissoes.BorderRadius = 5
        Me.BtnEditarPermissoes.CheckedState.Parent = Me.BtnEditarPermissoes
        Me.BtnEditarPermissoes.CustomImages.Parent = Me.BtnEditarPermissoes
        Me.SelectTransition.SetDecoration(Me.BtnEditarPermissoes, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnEditarPermissoes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEditarPermissoes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnEditarPermissoes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEditarPermissoes.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEditarPermissoes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnEditarPermissoes.DisabledState.Parent = Me.BtnEditarPermissoes
        Me.BtnEditarPermissoes.FillColor = System.Drawing.Color.SlateGray
        Me.BtnEditarPermissoes.FillColor2 = System.Drawing.Color.Black
        Me.BtnEditarPermissoes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEditarPermissoes.ForeColor = System.Drawing.Color.White
        Me.BtnEditarPermissoes.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnEditarPermissoes.HoverState.Parent = Me.BtnEditarPermissoes
        Me.BtnEditarPermissoes.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnEditarPermissoes.Location = New System.Drawing.Point(440, 103)
        Me.BtnEditarPermissoes.Name = "BtnEditarPermissoes"
        Me.BtnEditarPermissoes.ShadowDecoration.Parent = Me.BtnEditarPermissoes
        Me.BtnEditarPermissoes.Size = New System.Drawing.Size(105, 30)
        Me.BtnEditarPermissoes.TabIndex = 94
        Me.BtnEditarPermissoes.Text = "Editar"
        '
        'Lbl5
        '
        Me.Lbl5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl5.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.Lbl5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Lbl5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl5.Location = New System.Drawing.Point(89, 14)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(368, 17)
        Me.Lbl5.TabIndex = 92
        Me.Lbl5.Text = "Insira o token do usuário para liberar ou editar o acesso aos módulos."
        Me.Lbl5.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl1
        '
        Me.Lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl1.AutoSize = False
        Me.Lbl1.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.Lbl1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Lbl1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl1.Location = New System.Drawing.Point(23, 20)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(734, 34)
        Me.Lbl1.TabIndex = 112
        Me.Lbl1.Text = "Não é possível cadastrar novos usuários por motivos de segurança e privacidade, l" &
    "ogo, para que se tenha acesso ao sistema é necessário registrar-se antes de efet" &
    "uar o login."
        Me.Lbl1.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = False
        Me.Lbl2.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.Lbl2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Lbl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl2.ForeColor = System.Drawing.Color.Black
        Me.Lbl2.Location = New System.Drawing.Point(3, 436)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(774, 85)
        Me.Lbl2.TabIndex = 111
        Me.Lbl2.Text = "<font color=DimGray>Em caso de duvidas contate nosso suporte</font><br>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<font co" &
    "lor=Blue>suporte@gscodebrasil.com.br</font>"
        Me.Lbl2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'TpListaUsuario
        '
        Me.TpListaUsuario.Controls.Add(Me.TableLayoutPanel5)
        Me.SelectTransition.SetDecoration(Me.TpListaUsuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TpListaUsuario.Location = New System.Drawing.Point(4, 4)
        Me.TpListaUsuario.Name = "TpListaUsuario"
        Me.TpListaUsuario.Padding = New System.Windows.Forms.Padding(3)
        Me.TpListaUsuario.Size = New System.Drawing.Size(780, 524)
        Me.TpListaUsuario.TabIndex = 2
        Me.TpListaUsuario.Text = "Lista de Usuarios"
        Me.TpListaUsuario.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel8, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.PanelCentral, 1, 2)
        Me.SelectTransition.SetDecoration(Me.TableLayoutPanel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(774, 518)
        Me.TableLayoutPanel5.TabIndex = 9
        '
        'Panel8
        '
        Me.Panel8.AutoSize = True
        Me.Panel8.Controls.Add(Me.CbRegistrosPorPagina)
        Me.Panel8.Controls.Add(Me.TxtFilter)
        Me.SelectTransition.SetDecoration(Me.Panel8, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(28, 33)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(718, 65)
        Me.Panel8.TabIndex = 8
        '
        'CbRegistrosPorPagina
        '
        Me.CbRegistrosPorPagina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbRegistrosPorPagina.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CbRegistrosPorPagina.BorderColor = System.Drawing.Color.Gray
        Me.SelectTransition.SetDecoration(Me.CbRegistrosPorPagina, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CbRegistrosPorPagina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbRegistrosPorPagina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbRegistrosPorPagina.DropDownWidth = 76
        Me.CbRegistrosPorPagina.FillColor = System.Drawing.Color.WhiteSmoke
        Me.CbRegistrosPorPagina.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.CbRegistrosPorPagina.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.CbRegistrosPorPagina.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbRegistrosPorPagina.FocusedState.Parent = Me.CbRegistrosPorPagina
        Me.CbRegistrosPorPagina.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.CbRegistrosPorPagina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CbRegistrosPorPagina.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.CbRegistrosPorPagina.HoverState.Parent = Me.CbRegistrosPorPagina
        Me.CbRegistrosPorPagina.ItemHeight = 30
        Me.CbRegistrosPorPagina.Items.AddRange(New Object() {"10", "20", "50", "150"})
        Me.CbRegistrosPorPagina.ItemsAppearance.Parent = Me.CbRegistrosPorPagina
        Me.CbRegistrosPorPagina.Location = New System.Drawing.Point(627, 26)
        Me.CbRegistrosPorPagina.Name = "CbRegistrosPorPagina"
        Me.CbRegistrosPorPagina.ShadowDecoration.Parent = Me.CbRegistrosPorPagina
        Me.CbRegistrosPorPagina.Size = New System.Drawing.Size(87, 36)
        Me.CbRegistrosPorPagina.StartIndex = 0
        Me.CbRegistrosPorPagina.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.CbRegistrosPorPagina.TabIndex = 3
        Me.CbRegistrosPorPagina.TextOffset = New System.Drawing.Point(5, 0)
        '
        'TxtFilter
        '
        Me.TxtFilter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtFilter.BorderColor = System.Drawing.Color.SlateGray
        Me.TxtFilter.BorderRadius = 6
        Me.TxtFilter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SelectTransition.SetDecoration(Me.TxtFilter, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TxtFilter.DefaultText = ""
        Me.TxtFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TxtFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TxtFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtFilter.DisabledState.Parent = Me.TxtFilter
        Me.TxtFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtFilter.Enabled = False
        Me.TxtFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TxtFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtFilter.FocusedState.Parent = Me.TxtFilter
        Me.TxtFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtFilter.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtFilter.HoverState.Parent = Me.TxtFilter
        Me.TxtFilter.IconLeft = CType(resources.GetObject("TxtFilter.IconLeft"), System.Drawing.Image)
        Me.TxtFilter.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.TxtFilter.IconLeftOffset = New System.Drawing.Point(15, 0)
        Me.TxtFilter.IconLeftSize = New System.Drawing.Size(16, 16)
        Me.TxtFilter.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.TxtFilter.Location = New System.Drawing.Point(0, 6)
        Me.TxtFilter.Name = "TxtFilter"
        Me.TxtFilter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFilter.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtFilter.PlaceholderText = "Informe o Nome..."
        Me.TxtFilter.SelectedText = ""
        Me.TxtFilter.ShadowDecoration.BorderRadius = 50
        Me.TxtFilter.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.TxtFilter.ShadowDecoration.CustomizableEdges.TopLeft = False
        Me.TxtFilter.ShadowDecoration.CustomizableEdges.TopRight = False
        Me.TxtFilter.ShadowDecoration.Depth = 50
        Me.TxtFilter.ShadowDecoration.Parent = Me.TxtFilter
        Me.TxtFilter.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.TxtFilter.Size = New System.Drawing.Size(461, 40)
        Me.TxtFilter.TabIndex = 0
        Me.TxtFilter.TextOffset = New System.Drawing.Point(5, 1)
        '
        'PanelCentral
        '
        Me.PanelCentral.Controls.Add(Me.DgvUsers)
        Me.PanelCentral.Controls.Add(Me.PanelPaginacao)
        Me.SelectTransition.SetDecoration(Me.PanelCentral, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Location = New System.Drawing.Point(28, 104)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.ShadowDecoration.Parent = Me.PanelCentral
        Me.PanelCentral.Size = New System.Drawing.Size(718, 381)
        Me.PanelCentral.TabIndex = 9
        '
        'DgvUsers
        '
        Me.DgvUsers.AllowCustomTheming = False
        Me.DgvUsers.AllowUserToAddRows = False
        Me.DgvUsers.AllowUserToDeleteRows = False
        Me.DgvUsers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DgvUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvUsers.ColumnHeadersHeight = 40
        Me.DgvUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvColumnSelect})
        Me.DgvUsers.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvUsers.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DgvUsers.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DgvUsers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvUsers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DgvUsers.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.DgvUsers.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvUsers.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.DgvUsers.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DgvUsers.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvUsers.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DgvUsers.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DgvUsers.CurrentTheme.Name = Nothing
        Me.DgvUsers.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvUsers.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DgvUsers.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DgvUsers.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvUsers.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.SelectTransition.SetDecoration(Me.DgvUsers, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvUsers.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvUsers.EnableHeadersVisualStyles = False
        Me.DgvUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvUsers.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.DgvUsers.HeaderBgColor = System.Drawing.Color.Empty
        Me.DgvUsers.HeaderForeColor = System.Drawing.Color.White
        Me.DgvUsers.Location = New System.Drawing.Point(0, 0)
        Me.DgvUsers.MultiSelect = False
        Me.DgvUsers.Name = "DgvUsers"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUsers.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvUsers.RowHeadersVisible = False
        Me.DgvUsers.RowTemplate.Height = 40
        Me.DgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUsers.Size = New System.Drawing.Size(718, 348)
        Me.DgvUsers.TabIndex = 9
        Me.DgvUsers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'DgvColumnSelect
        '
        Me.DgvColumnSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DgvColumnSelect.DataPropertyName = "DgvColumnSelect"
        Me.DgvColumnSelect.HeaderText = ""
        Me.DgvColumnSelect.MinimumWidth = 50
        Me.DgvColumnSelect.Name = "DgvColumnSelect"
        Me.DgvColumnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvColumnSelect.Visible = False
        Me.DgvColumnSelect.Width = 50
        '
        'PanelPaginacao
        '
        Me.PanelPaginacao.Controls.Add(Me.LblSelectRegister)
        Me.PanelPaginacao.Controls.Add(Me.LblPaginacao)
        Me.PanelPaginacao.Controls.Add(Me.BtnPrevio)
        Me.PanelPaginacao.Controls.Add(Me.BtnNext)
        Me.SelectTransition.SetDecoration(Me.PanelPaginacao, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelPaginacao.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPaginacao.Location = New System.Drawing.Point(0, 348)
        Me.PanelPaginacao.Name = "PanelPaginacao"
        Me.PanelPaginacao.ShadowDecoration.Parent = Me.PanelPaginacao
        Me.PanelPaginacao.Size = New System.Drawing.Size(718, 33)
        Me.PanelPaginacao.TabIndex = 10
        '
        'LblSelectRegister
        '
        Me.LblSelectRegister.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.LblSelectRegister, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblSelectRegister.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.LblSelectRegister.ForeColor = System.Drawing.Color.DimGray
        Me.LblSelectRegister.Location = New System.Drawing.Point(3, 3)
        Me.LblSelectRegister.Name = "LblSelectRegister"
        Me.LblSelectRegister.Size = New System.Drawing.Size(9, 14)
        Me.LblSelectRegister.TabIndex = 6
        Me.LblSelectRegister.Text = "..."
        Me.LblSelectRegister.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblSelectRegister.Visible = False
        '
        'LblPaginacao
        '
        Me.LblPaginacao.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.LblPaginacao, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblPaginacao.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LblPaginacao.ForeColor = System.Drawing.Color.DimGray
        Me.LblPaginacao.Location = New System.Drawing.Point(272, 10)
        Me.LblPaginacao.Name = "LblPaginacao"
        Me.LblPaginacao.Size = New System.Drawing.Size(144, 15)
        Me.LblPaginacao.TabIndex = 5
        Me.LblPaginacao.Text = "Página 0 de 0 (0 resultados)"
        Me.LblPaginacao.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnPrevio
        '
        Me.BtnPrevio.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnPrevio.BorderColor = System.Drawing.Color.Gray
        Me.BtnPrevio.BorderRadius = 4
        Me.BtnPrevio.BorderThickness = 1
        Me.BtnPrevio.CheckedState.Parent = Me.BtnPrevio
        Me.BtnPrevio.CustomImages.Parent = Me.BtnPrevio
        Me.BtnPrevio.CustomizableEdges.BottomRight = False
        Me.BtnPrevio.CustomizableEdges.TopRight = False
        Me.SelectTransition.SetDecoration(Me.BtnPrevio, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnPrevio.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnPrevio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnPrevio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPrevio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnPrevio.DisabledState.Parent = Me.BtnPrevio
        Me.BtnPrevio.FillColor = System.Drawing.Color.Empty
        Me.BtnPrevio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnPrevio.ForeColor = System.Drawing.Color.White
        Me.BtnPrevio.HoverState.Parent = Me.BtnPrevio
        Me.BtnPrevio.Image = CType(resources.GetObject("BtnPrevio.Image"), System.Drawing.Image)
        Me.BtnPrevio.ImageSize = New System.Drawing.Size(14, 14)
        Me.BtnPrevio.Location = New System.Drawing.Point(635, 4)
        Me.BtnPrevio.Name = "BtnPrevio"
        Me.BtnPrevio.ShadowDecoration.Parent = Me.BtnPrevio
        Me.BtnPrevio.Size = New System.Drawing.Size(40, 25)
        Me.BtnPrevio.TabIndex = 4
        '
        'BtnNext
        '
        Me.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnNext.BorderColor = System.Drawing.Color.Gray
        Me.BtnNext.BorderRadius = 4
        Me.BtnNext.BorderThickness = 1
        Me.BtnNext.CheckedState.Parent = Me.BtnNext
        Me.BtnNext.CustomImages.Parent = Me.BtnNext
        Me.BtnNext.CustomizableEdges.BottomLeft = False
        Me.BtnNext.CustomizableEdges.TopLeft = False
        Me.SelectTransition.SetDecoration(Me.BtnNext, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnNext.DisabledState.Parent = Me.BtnNext
        Me.BtnNext.FillColor = System.Drawing.Color.Empty
        Me.BtnNext.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnNext.ForeColor = System.Drawing.Color.White
        Me.BtnNext.HoverState.Parent = Me.BtnNext
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.ImageSize = New System.Drawing.Size(14, 14)
        Me.BtnNext.Location = New System.Drawing.Point(676, 4)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.ShadowDecoration.Parent = Me.BtnNext
        Me.BtnNext.Size = New System.Drawing.Size(40, 25)
        Me.BtnNext.TabIndex = 3
        '
        'TpPerfil
        '
        Me.TpPerfil.AutoScroll = True
        Me.TpPerfil.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpPerfil.Controls.Add(Me.TableLayoutPanel1)
        Me.SelectTransition.SetDecoration(Me.TpPerfil, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TpPerfil.Location = New System.Drawing.Point(4, 4)
        Me.TpPerfil.Name = "TpPerfil"
        Me.TpPerfil.Padding = New System.Windows.Forms.Padding(3)
        Me.TpPerfil.Size = New System.Drawing.Size(780, 524)
        Me.TpPerfil.TabIndex = 3
        Me.TpPerfil.Text = "Perfil"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel2, 1, 1)
        Me.SelectTransition.SetDecoration(Me.TableLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(757, 891)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.BtnAvPerfil)
        Me.Guna2Panel2.Controls.Add(Me.BtnVoltarPerfil)
        Me.Guna2Panel2.Controls.Add(Me.BtnCopy)
        Me.Guna2Panel2.Controls.Add(Me.LblChaveKey)
        Me.Guna2Panel2.Controls.Add(Me.LblUserInfo)
        Me.Guna2Panel2.Controls.Add(Me.ImgPerfil)
        Me.SelectTransition.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(28, 33)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(701, 825)
        Me.Guna2Panel2.TabIndex = 0
        '
        'BtnAvPerfil
        '
        Me.BtnAvPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAvPerfil.Animated = True
        Me.BtnAvPerfil.BackColor = System.Drawing.Color.Transparent
        Me.BtnAvPerfil.BorderRadius = 18
        Me.BtnAvPerfil.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnAvPerfil.CausesValidation = False
        Me.BtnAvPerfil.CheckedState.Parent = Me.BtnAvPerfil
        Me.BtnAvPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAvPerfil.CustomImages.Parent = Me.BtnAvPerfil
        Me.SelectTransition.SetDecoration(Me.BtnAvPerfil, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnAvPerfil.DisabledState.Parent = Me.BtnAvPerfil
        Me.BtnAvPerfil.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnAvPerfil.FillColor2 = System.Drawing.Color.Black
        Me.BtnAvPerfil.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAvPerfil.ForeColor = System.Drawing.Color.White
        Me.BtnAvPerfil.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnAvPerfil.HoverState.Parent = Me.BtnAvPerfil
        Me.BtnAvPerfil.Location = New System.Drawing.Point(353, 772)
        Me.BtnAvPerfil.Name = "BtnAvPerfil"
        Me.BtnAvPerfil.ShadowDecoration.Parent = Me.BtnAvPerfil
        Me.BtnAvPerfil.Size = New System.Drawing.Size(124, 38)
        Me.BtnAvPerfil.TabIndex = 196
        Me.BtnAvPerfil.Text = "AVANÇAR"
        '
        'BtnVoltarPerfil
        '
        Me.BtnVoltarPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnVoltarPerfil.Animated = True
        Me.BtnVoltarPerfil.BackColor = System.Drawing.Color.Transparent
        Me.BtnVoltarPerfil.BorderRadius = 18
        Me.BtnVoltarPerfil.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnVoltarPerfil.CausesValidation = False
        Me.BtnVoltarPerfil.CheckedState.Parent = Me.BtnVoltarPerfil
        Me.BtnVoltarPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVoltarPerfil.CustomImages.Parent = Me.BtnVoltarPerfil
        Me.SelectTransition.SetDecoration(Me.BtnVoltarPerfil, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnVoltarPerfil.DisabledState.Parent = Me.BtnVoltarPerfil
        Me.BtnVoltarPerfil.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnVoltarPerfil.FillColor2 = System.Drawing.Color.Black
        Me.BtnVoltarPerfil.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnVoltarPerfil.ForeColor = System.Drawing.Color.White
        Me.BtnVoltarPerfil.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnVoltarPerfil.HoverState.Parent = Me.BtnVoltarPerfil
        Me.BtnVoltarPerfil.Location = New System.Drawing.Point(222, 772)
        Me.BtnVoltarPerfil.Name = "BtnVoltarPerfil"
        Me.BtnVoltarPerfil.ShadowDecoration.Parent = Me.BtnVoltarPerfil
        Me.BtnVoltarPerfil.Size = New System.Drawing.Size(124, 38)
        Me.BtnVoltarPerfil.TabIndex = 197
        Me.BtnVoltarPerfil.Text = "VOLTAR"
        '
        'BtnCopy
        '
        Me.BtnCopy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCopy.Animated = True
        Me.BtnCopy.AutoRoundedCorners = True
        Me.BtnCopy.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCopy.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCopy.BorderRadius = 17
        Me.BtnCopy.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnCopy.CheckedState.Parent = Me.BtnCopy
        Me.BtnCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCopy.CustomImages.Parent = Me.BtnCopy
        Me.SelectTransition.SetDecoration(Me.BtnCopy, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnCopy.DisabledState.Parent = Me.BtnCopy
        Me.BtnCopy.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnCopy.FillColor2 = System.Drawing.Color.Black
        Me.BtnCopy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCopy.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCopy.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnCopy.HoverState.Parent = Me.BtnCopy
        Me.BtnCopy.Image = CType(resources.GetObject("BtnCopy.Image"), System.Drawing.Image)
        Me.BtnCopy.ImageOffset = New System.Drawing.Point(1, 0)
        Me.BtnCopy.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnCopy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCopy.Location = New System.Drawing.Point(580, 176)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.PressedColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCopy.ShadowDecoration.Parent = Me.BtnCopy
        Me.BtnCopy.Size = New System.Drawing.Size(37, 37)
        Me.BtnCopy.TabIndex = 195
        '
        'LblChaveKey
        '
        Me.LblChaveKey.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblChaveKey.AutoSize = False
        Me.LblChaveKey.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.LblChaveKey, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblChaveKey.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChaveKey.ForeColor = System.Drawing.Color.Black
        Me.LblChaveKey.Location = New System.Drawing.Point(133, 187)
        Me.LblChaveKey.Name = "LblChaveKey"
        Me.LblChaveKey.Size = New System.Drawing.Size(434, 21)
        Me.LblChaveKey.TabIndex = 192
        Me.LblChaveKey.Text = "..."
        Me.LblChaveKey.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'LblUserInfo
        '
        Me.LblUserInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblUserInfo.AutoSize = False
        Me.LblUserInfo.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.LblUserInfo, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblUserInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserInfo.ForeColor = System.Drawing.Color.Black
        Me.LblUserInfo.Location = New System.Drawing.Point(47, 261)
        Me.LblUserInfo.Name = "LblUserInfo"
        Me.LblUserInfo.Size = New System.Drawing.Size(503, 474)
        Me.LblUserInfo.TabIndex = 190
        Me.LblUserInfo.Text = "..."
        '
        'ImgPerfil
        '
        Me.ImgPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ImgPerfil.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.ImgPerfil, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ImgPerfil.Image = CType(resources.GetObject("ImgPerfil.Image"), System.Drawing.Image)
        Me.ImgPerfil.ImageRotate = 0!
        Me.ImgPerfil.Location = New System.Drawing.Point(290, 54)
        Me.ImgPerfil.Name = "ImgPerfil"
        Me.ImgPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ImgPerfil.ShadowDecoration.Parent = Me.ImgPerfil
        Me.ImgPerfil.Size = New System.Drawing.Size(120, 120)
        Me.ImgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgPerfil.TabIndex = 285
        Me.ImgPerfil.TabStop = False
        Me.ImgPerfil.UseTransparentBackground = True
        '
        'TpPermissoes
        '
        Me.TpPermissoes.AutoScroll = True
        Me.TpPermissoes.Controls.Add(Me.TlpPermissoes)
        Me.SelectTransition.SetDecoration(Me.TpPermissoes, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TpPermissoes.Location = New System.Drawing.Point(4, 4)
        Me.TpPermissoes.Name = "TpPermissoes"
        Me.TpPermissoes.Padding = New System.Windows.Forms.Padding(3)
        Me.TpPermissoes.Size = New System.Drawing.Size(780, 524)
        Me.TpPermissoes.TabIndex = 1
        Me.TpPermissoes.Text = "Permissoes"
        Me.TpPermissoes.UseVisualStyleBackColor = True
        '
        'TlpPermissoes
        '
        Me.TlpPermissoes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TlpPermissoes.ColumnCount = 3
        Me.TlpPermissoes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TlpPermissoes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpPermissoes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TlpPermissoes.Controls.Add(Me.PanelPermissoes, 1, 1)
        Me.SelectTransition.SetDecoration(Me.TlpPermissoes, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TlpPermissoes.Dock = System.Windows.Forms.DockStyle.Top
        Me.TlpPermissoes.Location = New System.Drawing.Point(3, 3)
        Me.TlpPermissoes.Name = "TlpPermissoes"
        Me.TlpPermissoes.RowCount = 3
        Me.TlpPermissoes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpPermissoes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 804.0!))
        Me.TlpPermissoes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TlpPermissoes.Size = New System.Drawing.Size(757, 863)
        Me.TlpPermissoes.TabIndex = 3
        '
        'PanelPermissoes
        '
        Me.PanelPermissoes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelPermissoes.Controls.Add(Me.S6)
        Me.PanelPermissoes.Controls.Add(Me.PanelDashboard)
        Me.PanelPermissoes.Controls.Add(Me.S5)
        Me.PanelPermissoes.Controls.Add(Me.PanelFinanceiro)
        Me.PanelPermissoes.Controls.Add(Me.S4)
        Me.PanelPermissoes.Controls.Add(Me.PanelEstoque)
        Me.PanelPermissoes.Controls.Add(Me.S3)
        Me.PanelPermissoes.Controls.Add(Me.PanelHelpdesk)
        Me.PanelPermissoes.Controls.Add(Me.S2)
        Me.PanelPermissoes.Controls.Add(Me.PanelPhonebook)
        Me.PanelPermissoes.Controls.Add(Me.S1)
        Me.PanelPermissoes.Controls.Add(Me.PanelHome)
        Me.PanelPermissoes.Controls.Add(Me.PanelNextPrevio)
        Me.PanelPermissoes.Controls.Add(Me.S0)
        Me.SelectTransition.SetDecoration(Me.PanelPermissoes, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelPermissoes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPermissoes.Location = New System.Drawing.Point(27, 33)
        Me.PanelPermissoes.Name = "PanelPermissoes"
        Me.PanelPermissoes.Size = New System.Drawing.Size(702, 798)
        Me.PanelPermissoes.TabIndex = 0
        '
        'S6
        '
        Me.SelectTransition.SetDecoration(Me.S6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.S6.Dock = System.Windows.Forms.DockStyle.Top
        Me.S6.Location = New System.Drawing.Point(0, 720)
        Me.S6.Name = "S6"
        Me.S6.Size = New System.Drawing.Size(702, 10)
        Me.S6.TabIndex = 38
        '
        'PanelDashboard
        '
        Me.PanelDashboard.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelDashboard.Controls.Add(Me.PanelListDashboard)
        Me.PanelDashboard.Controls.Add(Me.BtnDashboard)
        Me.SelectTransition.SetDecoration(Me.PanelDashboard, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDashboard.Location = New System.Drawing.Point(0, 610)
        Me.PanelDashboard.Name = "PanelDashboard"
        Me.PanelDashboard.Size = New System.Drawing.Size(702, 110)
        Me.PanelDashboard.TabIndex = 35
        '
        'PanelListDashboard
        '
        Me.PanelListDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelListDashboard.AutoSize = True
        Me.PanelListDashboard.Controls.Add(Me.BtnDashboardNv1)
        Me.PanelListDashboard.Controls.Add(Me.BtnDashboardNv2)
        Me.PanelListDashboard.Controls.Add(Me.BtnDashboardNv3)
        Me.PanelListDashboard.Controls.Add(Me.BtnDashboardNv4)
        Me.SelectTransition.SetDecoration(Me.PanelListDashboard, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelListDashboard.Location = New System.Drawing.Point(137, 40)
        Me.PanelListDashboard.Name = "PanelListDashboard"
        Me.PanelListDashboard.Size = New System.Drawing.Size(538, 35)
        Me.PanelListDashboard.TabIndex = 70
        '
        'BtnDashboardNv1
        '
        Me.BtnDashboardNv1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDashboardNv1.BorderRadius = 10
        Me.BtnDashboardNv1.BorderThickness = 1
        Me.BtnDashboardNv1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnDashboardNv1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnDashboardNv1.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnDashboardNv1.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnDashboardNv1.CheckedState.Parent = Me.BtnDashboardNv1
        Me.BtnDashboardNv1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDashboardNv1.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnDashboardNv1.CustomImages.Parent = Me.BtnDashboardNv1
        Me.SelectTransition.SetDecoration(Me.BtnDashboardNv1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnDashboardNv1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboardNv1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboardNv1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDashboardNv1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDashboardNv1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDashboardNv1.DisabledState.Parent = Me.BtnDashboardNv1
        Me.BtnDashboardNv1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnDashboardNv1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDashboardNv1.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnDashboardNv1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnDashboardNv1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDashboardNv1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnDashboardNv1.HoverState.Parent = Me.BtnDashboardNv1
        Me.BtnDashboardNv1.Location = New System.Drawing.Point(402, 0)
        Me.BtnDashboardNv1.Name = "BtnDashboardNv1"
        Me.BtnDashboardNv1.ShadowDecoration.Parent = Me.BtnDashboardNv1
        Me.BtnDashboardNv1.Size = New System.Drawing.Size(134, 35)
        Me.BtnDashboardNv1.TabIndex = 72
        Me.BtnDashboardNv1.Text = "Básico"
        '
        'BtnDashboardNv2
        '
        Me.BtnDashboardNv2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDashboardNv2.BorderRadius = 10
        Me.BtnDashboardNv2.BorderThickness = 1
        Me.BtnDashboardNv2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnDashboardNv2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnDashboardNv2.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnDashboardNv2.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnDashboardNv2.CheckedState.Parent = Me.BtnDashboardNv2
        Me.BtnDashboardNv2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDashboardNv2.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnDashboardNv2.CustomImages.Parent = Me.BtnDashboardNv2
        Me.SelectTransition.SetDecoration(Me.BtnDashboardNv2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnDashboardNv2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboardNv2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboardNv2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDashboardNv2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDashboardNv2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDashboardNv2.DisabledState.Parent = Me.BtnDashboardNv2
        Me.BtnDashboardNv2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnDashboardNv2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDashboardNv2.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnDashboardNv2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnDashboardNv2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDashboardNv2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnDashboardNv2.HoverState.Parent = Me.BtnDashboardNv2
        Me.BtnDashboardNv2.Location = New System.Drawing.Point(268, 0)
        Me.BtnDashboardNv2.Name = "BtnDashboardNv2"
        Me.BtnDashboardNv2.ShadowDecoration.Parent = Me.BtnDashboardNv2
        Me.BtnDashboardNv2.Size = New System.Drawing.Size(134, 35)
        Me.BtnDashboardNv2.TabIndex = 71
        Me.BtnDashboardNv2.Text = "Intermediário"
        '
        'BtnDashboardNv3
        '
        Me.BtnDashboardNv3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDashboardNv3.BorderRadius = 10
        Me.BtnDashboardNv3.BorderThickness = 1
        Me.BtnDashboardNv3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnDashboardNv3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnDashboardNv3.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnDashboardNv3.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnDashboardNv3.CheckedState.Parent = Me.BtnDashboardNv3
        Me.BtnDashboardNv3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDashboardNv3.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnDashboardNv3.CustomImages.Parent = Me.BtnDashboardNv3
        Me.SelectTransition.SetDecoration(Me.BtnDashboardNv3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnDashboardNv3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboardNv3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboardNv3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDashboardNv3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDashboardNv3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDashboardNv3.DisabledState.Parent = Me.BtnDashboardNv3
        Me.BtnDashboardNv3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnDashboardNv3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDashboardNv3.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnDashboardNv3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnDashboardNv3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDashboardNv3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnDashboardNv3.HoverState.Parent = Me.BtnDashboardNv3
        Me.BtnDashboardNv3.Location = New System.Drawing.Point(134, 0)
        Me.BtnDashboardNv3.Name = "BtnDashboardNv3"
        Me.BtnDashboardNv3.ShadowDecoration.Parent = Me.BtnDashboardNv3
        Me.BtnDashboardNv3.Size = New System.Drawing.Size(134, 35)
        Me.BtnDashboardNv3.TabIndex = 70
        Me.BtnDashboardNv3.Text = "Avançado"
        '
        'BtnDashboardNv4
        '
        Me.BtnDashboardNv4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDashboardNv4.BorderRadius = 10
        Me.BtnDashboardNv4.BorderThickness = 1
        Me.BtnDashboardNv4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnDashboardNv4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnDashboardNv4.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnDashboardNv4.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnDashboardNv4.CheckedState.Parent = Me.BtnDashboardNv4
        Me.BtnDashboardNv4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDashboardNv4.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnDashboardNv4.CustomImages.Parent = Me.BtnDashboardNv4
        Me.SelectTransition.SetDecoration(Me.BtnDashboardNv4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnDashboardNv4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboardNv4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboardNv4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDashboardNv4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDashboardNv4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDashboardNv4.DisabledState.Parent = Me.BtnDashboardNv4
        Me.BtnDashboardNv4.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnDashboardNv4.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDashboardNv4.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnDashboardNv4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnDashboardNv4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDashboardNv4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnDashboardNv4.HoverState.Parent = Me.BtnDashboardNv4
        Me.BtnDashboardNv4.Location = New System.Drawing.Point(0, 0)
        Me.BtnDashboardNv4.Name = "BtnDashboardNv4"
        Me.BtnDashboardNv4.ShadowDecoration.Parent = Me.BtnDashboardNv4
        Me.BtnDashboardNv4.Size = New System.Drawing.Size(134, 35)
        Me.BtnDashboardNv4.TabIndex = 69
        Me.BtnDashboardNv4.Text = "Administrador"
        '
        'BtnDashboard
        '
        Me.BtnDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnDashboard.Animated = True
        Me.BtnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.BtnDashboard.BorderRadius = 10
        Me.BtnDashboard.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnDashboard.CausesValidation = False
        Me.BtnDashboard.CheckedState.Parent = Me.BtnDashboard
        Me.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDashboard.CustomImages.Parent = Me.BtnDashboard
        Me.SelectTransition.SetDecoration(Me.BtnDashboard, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnDashboard.DisabledState.Parent = Me.BtnDashboard
        Me.BtnDashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnDashboard.FillColor2 = System.Drawing.Color.Black
        Me.BtnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDashboard.ForeColor = System.Drawing.Color.White
        Me.BtnDashboard.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnDashboard.HoverState.Parent = Me.BtnDashboard
        Me.BtnDashboard.Image = CType(resources.GetObject("BtnDashboard.Image"), System.Drawing.Image)
        Me.BtnDashboard.ImageOffset = New System.Drawing.Point(1, 0)
        Me.BtnDashboard.ImageSize = New System.Drawing.Size(80, 75)
        Me.BtnDashboard.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDashboard.Location = New System.Drawing.Point(21, 13)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.ShadowDecoration.Parent = Me.BtnDashboard
        Me.BtnDashboard.Size = New System.Drawing.Size(85, 85)
        Me.BtnDashboard.TabIndex = 69
        '
        'S5
        '
        Me.SelectTransition.SetDecoration(Me.S5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.S5.Dock = System.Windows.Forms.DockStyle.Top
        Me.S5.Location = New System.Drawing.Point(0, 600)
        Me.S5.Name = "S5"
        Me.S5.Size = New System.Drawing.Size(702, 10)
        Me.S5.TabIndex = 34
        '
        'PanelFinanceiro
        '
        Me.PanelFinanceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelFinanceiro.Controls.Add(Me.PanelListFinanceiro)
        Me.PanelFinanceiro.Controls.Add(Me.BtnFinanceiro)
        Me.SelectTransition.SetDecoration(Me.PanelFinanceiro, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelFinanceiro.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFinanceiro.Location = New System.Drawing.Point(0, 490)
        Me.PanelFinanceiro.Name = "PanelFinanceiro"
        Me.PanelFinanceiro.Size = New System.Drawing.Size(702, 110)
        Me.PanelFinanceiro.TabIndex = 33
        '
        'PanelListFinanceiro
        '
        Me.PanelListFinanceiro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelListFinanceiro.AutoSize = True
        Me.PanelListFinanceiro.Controls.Add(Me.BtnFinanceiroNv1)
        Me.PanelListFinanceiro.Controls.Add(Me.BtnFinanceiroNv2)
        Me.PanelListFinanceiro.Controls.Add(Me.BtnFinanceiroNv3)
        Me.PanelListFinanceiro.Controls.Add(Me.BtnFinanceiroNv4)
        Me.SelectTransition.SetDecoration(Me.PanelListFinanceiro, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelListFinanceiro.Location = New System.Drawing.Point(137, 40)
        Me.PanelListFinanceiro.Name = "PanelListFinanceiro"
        Me.PanelListFinanceiro.Size = New System.Drawing.Size(538, 35)
        Me.PanelListFinanceiro.TabIndex = 71
        '
        'BtnFinanceiroNv1
        '
        Me.BtnFinanceiroNv1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFinanceiroNv1.BorderRadius = 10
        Me.BtnFinanceiroNv1.BorderThickness = 1
        Me.BtnFinanceiroNv1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnFinanceiroNv1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnFinanceiroNv1.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnFinanceiroNv1.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnFinanceiroNv1.CheckedState.Parent = Me.BtnFinanceiroNv1
        Me.BtnFinanceiroNv1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFinanceiroNv1.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnFinanceiroNv1.CustomImages.Parent = Me.BtnFinanceiroNv1
        Me.SelectTransition.SetDecoration(Me.BtnFinanceiroNv1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnFinanceiroNv1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnFinanceiroNv1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnFinanceiroNv1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnFinanceiroNv1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnFinanceiroNv1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnFinanceiroNv1.DisabledState.Parent = Me.BtnFinanceiroNv1
        Me.BtnFinanceiroNv1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnFinanceiroNv1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnFinanceiroNv1.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnFinanceiroNv1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnFinanceiroNv1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFinanceiroNv1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnFinanceiroNv1.HoverState.Parent = Me.BtnFinanceiroNv1
        Me.BtnFinanceiroNv1.Location = New System.Drawing.Point(402, 0)
        Me.BtnFinanceiroNv1.Name = "BtnFinanceiroNv1"
        Me.BtnFinanceiroNv1.ShadowDecoration.Parent = Me.BtnFinanceiroNv1
        Me.BtnFinanceiroNv1.Size = New System.Drawing.Size(134, 35)
        Me.BtnFinanceiroNv1.TabIndex = 72
        Me.BtnFinanceiroNv1.Text = "Básico"
        '
        'BtnFinanceiroNv2
        '
        Me.BtnFinanceiroNv2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFinanceiroNv2.BorderRadius = 10
        Me.BtnFinanceiroNv2.BorderThickness = 1
        Me.BtnFinanceiroNv2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnFinanceiroNv2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnFinanceiroNv2.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnFinanceiroNv2.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnFinanceiroNv2.CheckedState.Parent = Me.BtnFinanceiroNv2
        Me.BtnFinanceiroNv2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFinanceiroNv2.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnFinanceiroNv2.CustomImages.Parent = Me.BtnFinanceiroNv2
        Me.SelectTransition.SetDecoration(Me.BtnFinanceiroNv2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnFinanceiroNv2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnFinanceiroNv2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnFinanceiroNv2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnFinanceiroNv2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnFinanceiroNv2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnFinanceiroNv2.DisabledState.Parent = Me.BtnFinanceiroNv2
        Me.BtnFinanceiroNv2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnFinanceiroNv2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnFinanceiroNv2.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnFinanceiroNv2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnFinanceiroNv2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFinanceiroNv2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnFinanceiroNv2.HoverState.Parent = Me.BtnFinanceiroNv2
        Me.BtnFinanceiroNv2.Location = New System.Drawing.Point(268, 0)
        Me.BtnFinanceiroNv2.Name = "BtnFinanceiroNv2"
        Me.BtnFinanceiroNv2.ShadowDecoration.Parent = Me.BtnFinanceiroNv2
        Me.BtnFinanceiroNv2.Size = New System.Drawing.Size(134, 35)
        Me.BtnFinanceiroNv2.TabIndex = 71
        Me.BtnFinanceiroNv2.Text = "Intermediário"
        '
        'BtnFinanceiroNv3
        '
        Me.BtnFinanceiroNv3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFinanceiroNv3.BorderRadius = 10
        Me.BtnFinanceiroNv3.BorderThickness = 1
        Me.BtnFinanceiroNv3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnFinanceiroNv3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnFinanceiroNv3.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnFinanceiroNv3.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnFinanceiroNv3.CheckedState.Parent = Me.BtnFinanceiroNv3
        Me.BtnFinanceiroNv3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFinanceiroNv3.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnFinanceiroNv3.CustomImages.Parent = Me.BtnFinanceiroNv3
        Me.SelectTransition.SetDecoration(Me.BtnFinanceiroNv3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnFinanceiroNv3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnFinanceiroNv3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnFinanceiroNv3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnFinanceiroNv3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnFinanceiroNv3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnFinanceiroNv3.DisabledState.Parent = Me.BtnFinanceiroNv3
        Me.BtnFinanceiroNv3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnFinanceiroNv3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnFinanceiroNv3.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnFinanceiroNv3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnFinanceiroNv3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFinanceiroNv3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnFinanceiroNv3.HoverState.Parent = Me.BtnFinanceiroNv3
        Me.BtnFinanceiroNv3.Location = New System.Drawing.Point(134, 0)
        Me.BtnFinanceiroNv3.Name = "BtnFinanceiroNv3"
        Me.BtnFinanceiroNv3.ShadowDecoration.Parent = Me.BtnFinanceiroNv3
        Me.BtnFinanceiroNv3.Size = New System.Drawing.Size(134, 35)
        Me.BtnFinanceiroNv3.TabIndex = 70
        Me.BtnFinanceiroNv3.Text = "Avançado"
        '
        'BtnFinanceiroNv4
        '
        Me.BtnFinanceiroNv4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFinanceiroNv4.BorderRadius = 10
        Me.BtnFinanceiroNv4.BorderThickness = 1
        Me.BtnFinanceiroNv4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnFinanceiroNv4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnFinanceiroNv4.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnFinanceiroNv4.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnFinanceiroNv4.CheckedState.Parent = Me.BtnFinanceiroNv4
        Me.BtnFinanceiroNv4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFinanceiroNv4.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnFinanceiroNv4.CustomImages.Parent = Me.BtnFinanceiroNv4
        Me.SelectTransition.SetDecoration(Me.BtnFinanceiroNv4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnFinanceiroNv4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnFinanceiroNv4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnFinanceiroNv4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnFinanceiroNv4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnFinanceiroNv4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnFinanceiroNv4.DisabledState.Parent = Me.BtnFinanceiroNv4
        Me.BtnFinanceiroNv4.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnFinanceiroNv4.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnFinanceiroNv4.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnFinanceiroNv4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnFinanceiroNv4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFinanceiroNv4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnFinanceiroNv4.HoverState.Parent = Me.BtnFinanceiroNv4
        Me.BtnFinanceiroNv4.Location = New System.Drawing.Point(0, 0)
        Me.BtnFinanceiroNv4.Name = "BtnFinanceiroNv4"
        Me.BtnFinanceiroNv4.ShadowDecoration.Parent = Me.BtnFinanceiroNv4
        Me.BtnFinanceiroNv4.Size = New System.Drawing.Size(134, 35)
        Me.BtnFinanceiroNv4.TabIndex = 69
        Me.BtnFinanceiroNv4.Text = "Administrador"
        '
        'BtnFinanceiro
        '
        Me.BtnFinanceiro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnFinanceiro.Animated = True
        Me.BtnFinanceiro.BackColor = System.Drawing.Color.Transparent
        Me.BtnFinanceiro.BorderRadius = 10
        Me.BtnFinanceiro.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnFinanceiro.CausesValidation = False
        Me.BtnFinanceiro.CheckedState.Parent = Me.BtnFinanceiro
        Me.BtnFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFinanceiro.CustomImages.Parent = Me.BtnFinanceiro
        Me.SelectTransition.SetDecoration(Me.BtnFinanceiro, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnFinanceiro.DisabledState.Parent = Me.BtnFinanceiro
        Me.BtnFinanceiro.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnFinanceiro.FillColor2 = System.Drawing.Color.Black
        Me.BtnFinanceiro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFinanceiro.ForeColor = System.Drawing.Color.White
        Me.BtnFinanceiro.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnFinanceiro.HoverState.Parent = Me.BtnFinanceiro
        Me.BtnFinanceiro.Image = CType(resources.GetObject("BtnFinanceiro.Image"), System.Drawing.Image)
        Me.BtnFinanceiro.ImageOffset = New System.Drawing.Point(1, 0)
        Me.BtnFinanceiro.ImageSize = New System.Drawing.Size(80, 50)
        Me.BtnFinanceiro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFinanceiro.Location = New System.Drawing.Point(21, 13)
        Me.BtnFinanceiro.Name = "BtnFinanceiro"
        Me.BtnFinanceiro.ShadowDecoration.Parent = Me.BtnFinanceiro
        Me.BtnFinanceiro.Size = New System.Drawing.Size(85, 85)
        Me.BtnFinanceiro.TabIndex = 69
        '
        'S4
        '
        Me.SelectTransition.SetDecoration(Me.S4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.S4.Dock = System.Windows.Forms.DockStyle.Top
        Me.S4.Location = New System.Drawing.Point(0, 480)
        Me.S4.Name = "S4"
        Me.S4.Size = New System.Drawing.Size(702, 10)
        Me.S4.TabIndex = 32
        '
        'PanelEstoque
        '
        Me.PanelEstoque.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelEstoque.Controls.Add(Me.PanelListEstoque)
        Me.PanelEstoque.Controls.Add(Me.BtnEstoque)
        Me.SelectTransition.SetDecoration(Me.PanelEstoque, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelEstoque.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEstoque.Location = New System.Drawing.Point(0, 370)
        Me.PanelEstoque.Name = "PanelEstoque"
        Me.PanelEstoque.Size = New System.Drawing.Size(702, 110)
        Me.PanelEstoque.TabIndex = 31
        '
        'PanelListEstoque
        '
        Me.PanelListEstoque.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelListEstoque.AutoSize = True
        Me.PanelListEstoque.Controls.Add(Me.BtnEstoqueNv1)
        Me.PanelListEstoque.Controls.Add(Me.BtnEstoqueNv2)
        Me.PanelListEstoque.Controls.Add(Me.BtnEstoqueNv3)
        Me.PanelListEstoque.Controls.Add(Me.BtnEstoqueNv4)
        Me.SelectTransition.SetDecoration(Me.PanelListEstoque, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelListEstoque.Location = New System.Drawing.Point(137, 40)
        Me.PanelListEstoque.Name = "PanelListEstoque"
        Me.PanelListEstoque.Size = New System.Drawing.Size(538, 35)
        Me.PanelListEstoque.TabIndex = 70
        '
        'BtnEstoqueNv1
        '
        Me.BtnEstoqueNv1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEstoqueNv1.BorderRadius = 10
        Me.BtnEstoqueNv1.BorderThickness = 1
        Me.BtnEstoqueNv1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnEstoqueNv1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnEstoqueNv1.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnEstoqueNv1.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnEstoqueNv1.CheckedState.Parent = Me.BtnEstoqueNv1
        Me.BtnEstoqueNv1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEstoqueNv1.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnEstoqueNv1.CustomImages.Parent = Me.BtnEstoqueNv1
        Me.SelectTransition.SetDecoration(Me.BtnEstoqueNv1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnEstoqueNv1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEstoqueNv1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnEstoqueNv1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEstoqueNv1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEstoqueNv1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnEstoqueNv1.DisabledState.Parent = Me.BtnEstoqueNv1
        Me.BtnEstoqueNv1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnEstoqueNv1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnEstoqueNv1.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnEstoqueNv1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEstoqueNv1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEstoqueNv1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnEstoqueNv1.HoverState.Parent = Me.BtnEstoqueNv1
        Me.BtnEstoqueNv1.Location = New System.Drawing.Point(402, 0)
        Me.BtnEstoqueNv1.Name = "BtnEstoqueNv1"
        Me.BtnEstoqueNv1.ShadowDecoration.Parent = Me.BtnEstoqueNv1
        Me.BtnEstoqueNv1.Size = New System.Drawing.Size(134, 35)
        Me.BtnEstoqueNv1.TabIndex = 72
        Me.BtnEstoqueNv1.Text = "Básico"
        '
        'BtnEstoqueNv2
        '
        Me.BtnEstoqueNv2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEstoqueNv2.BorderRadius = 10
        Me.BtnEstoqueNv2.BorderThickness = 1
        Me.BtnEstoqueNv2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnEstoqueNv2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnEstoqueNv2.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnEstoqueNv2.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnEstoqueNv2.CheckedState.Parent = Me.BtnEstoqueNv2
        Me.BtnEstoqueNv2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEstoqueNv2.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnEstoqueNv2.CustomImages.Parent = Me.BtnEstoqueNv2
        Me.SelectTransition.SetDecoration(Me.BtnEstoqueNv2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnEstoqueNv2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEstoqueNv2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnEstoqueNv2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEstoqueNv2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEstoqueNv2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnEstoqueNv2.DisabledState.Parent = Me.BtnEstoqueNv2
        Me.BtnEstoqueNv2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnEstoqueNv2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnEstoqueNv2.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnEstoqueNv2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEstoqueNv2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEstoqueNv2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnEstoqueNv2.HoverState.Parent = Me.BtnEstoqueNv2
        Me.BtnEstoqueNv2.Location = New System.Drawing.Point(268, 0)
        Me.BtnEstoqueNv2.Name = "BtnEstoqueNv2"
        Me.BtnEstoqueNv2.ShadowDecoration.Parent = Me.BtnEstoqueNv2
        Me.BtnEstoqueNv2.Size = New System.Drawing.Size(134, 35)
        Me.BtnEstoqueNv2.TabIndex = 71
        Me.BtnEstoqueNv2.Text = "Intermediário"
        '
        'BtnEstoqueNv3
        '
        Me.BtnEstoqueNv3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEstoqueNv3.BorderRadius = 10
        Me.BtnEstoqueNv3.BorderThickness = 1
        Me.BtnEstoqueNv3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnEstoqueNv3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnEstoqueNv3.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnEstoqueNv3.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnEstoqueNv3.CheckedState.Parent = Me.BtnEstoqueNv3
        Me.BtnEstoqueNv3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEstoqueNv3.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnEstoqueNv3.CustomImages.Parent = Me.BtnEstoqueNv3
        Me.SelectTransition.SetDecoration(Me.BtnEstoqueNv3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnEstoqueNv3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEstoqueNv3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnEstoqueNv3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEstoqueNv3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEstoqueNv3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnEstoqueNv3.DisabledState.Parent = Me.BtnEstoqueNv3
        Me.BtnEstoqueNv3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnEstoqueNv3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnEstoqueNv3.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnEstoqueNv3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEstoqueNv3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEstoqueNv3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnEstoqueNv3.HoverState.Parent = Me.BtnEstoqueNv3
        Me.BtnEstoqueNv3.Location = New System.Drawing.Point(134, 0)
        Me.BtnEstoqueNv3.Name = "BtnEstoqueNv3"
        Me.BtnEstoqueNv3.ShadowDecoration.Parent = Me.BtnEstoqueNv3
        Me.BtnEstoqueNv3.Size = New System.Drawing.Size(134, 35)
        Me.BtnEstoqueNv3.TabIndex = 70
        Me.BtnEstoqueNv3.Text = "Avançado"
        '
        'BtnEstoqueNv4
        '
        Me.BtnEstoqueNv4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEstoqueNv4.BorderRadius = 10
        Me.BtnEstoqueNv4.BorderThickness = 1
        Me.BtnEstoqueNv4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnEstoqueNv4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnEstoqueNv4.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnEstoqueNv4.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnEstoqueNv4.CheckedState.Parent = Me.BtnEstoqueNv4
        Me.BtnEstoqueNv4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEstoqueNv4.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnEstoqueNv4.CustomImages.Parent = Me.BtnEstoqueNv4
        Me.SelectTransition.SetDecoration(Me.BtnEstoqueNv4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnEstoqueNv4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEstoqueNv4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnEstoqueNv4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEstoqueNv4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEstoqueNv4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnEstoqueNv4.DisabledState.Parent = Me.BtnEstoqueNv4
        Me.BtnEstoqueNv4.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnEstoqueNv4.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnEstoqueNv4.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnEstoqueNv4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEstoqueNv4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEstoqueNv4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnEstoqueNv4.HoverState.Parent = Me.BtnEstoqueNv4
        Me.BtnEstoqueNv4.Location = New System.Drawing.Point(0, 0)
        Me.BtnEstoqueNv4.Name = "BtnEstoqueNv4"
        Me.BtnEstoqueNv4.ShadowDecoration.Parent = Me.BtnEstoqueNv4
        Me.BtnEstoqueNv4.Size = New System.Drawing.Size(134, 35)
        Me.BtnEstoqueNv4.TabIndex = 69
        Me.BtnEstoqueNv4.Text = "Administrador"
        '
        'BtnEstoque
        '
        Me.BtnEstoque.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEstoque.Animated = True
        Me.BtnEstoque.BackColor = System.Drawing.Color.Transparent
        Me.BtnEstoque.BorderRadius = 10
        Me.BtnEstoque.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnEstoque.CausesValidation = False
        Me.BtnEstoque.CheckedState.Parent = Me.BtnEstoque
        Me.BtnEstoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEstoque.CustomImages.Parent = Me.BtnEstoque
        Me.SelectTransition.SetDecoration(Me.BtnEstoque, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnEstoque.DisabledState.Parent = Me.BtnEstoque
        Me.BtnEstoque.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnEstoque.FillColor2 = System.Drawing.Color.Black
        Me.BtnEstoque.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEstoque.ForeColor = System.Drawing.Color.White
        Me.BtnEstoque.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnEstoque.HoverState.Parent = Me.BtnEstoque
        Me.BtnEstoque.Image = CType(resources.GetObject("BtnEstoque.Image"), System.Drawing.Image)
        Me.BtnEstoque.ImageSize = New System.Drawing.Size(89, 80)
        Me.BtnEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnEstoque.Location = New System.Drawing.Point(21, 13)
        Me.BtnEstoque.Name = "BtnEstoque"
        Me.BtnEstoque.ShadowDecoration.Parent = Me.BtnEstoque
        Me.BtnEstoque.Size = New System.Drawing.Size(85, 85)
        Me.BtnEstoque.TabIndex = 69
        '
        'S3
        '
        Me.SelectTransition.SetDecoration(Me.S3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.S3.Dock = System.Windows.Forms.DockStyle.Top
        Me.S3.Location = New System.Drawing.Point(0, 360)
        Me.S3.Name = "S3"
        Me.S3.Size = New System.Drawing.Size(702, 10)
        Me.S3.TabIndex = 36
        '
        'PanelHelpdesk
        '
        Me.PanelHelpdesk.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelHelpdesk.Controls.Add(Me.PanelListHelpdesk)
        Me.PanelHelpdesk.Controls.Add(Me.BtnHelpdesk)
        Me.SelectTransition.SetDecoration(Me.PanelHelpdesk, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelHelpdesk.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHelpdesk.Location = New System.Drawing.Point(0, 250)
        Me.PanelHelpdesk.Name = "PanelHelpdesk"
        Me.PanelHelpdesk.Size = New System.Drawing.Size(702, 110)
        Me.PanelHelpdesk.TabIndex = 30
        '
        'PanelListHelpdesk
        '
        Me.PanelListHelpdesk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelListHelpdesk.AutoSize = True
        Me.PanelListHelpdesk.Controls.Add(Me.BtnHelpdeskNv1)
        Me.PanelListHelpdesk.Controls.Add(Me.BtnHelpdeskNv2)
        Me.PanelListHelpdesk.Controls.Add(Me.BtnHelpdeskNv3)
        Me.PanelListHelpdesk.Controls.Add(Me.BtnHelpdeskNv4)
        Me.SelectTransition.SetDecoration(Me.PanelListHelpdesk, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelListHelpdesk.Location = New System.Drawing.Point(137, 40)
        Me.PanelListHelpdesk.Name = "PanelListHelpdesk"
        Me.PanelListHelpdesk.Size = New System.Drawing.Size(538, 35)
        Me.PanelListHelpdesk.TabIndex = 70
        '
        'BtnHelpdeskNv1
        '
        Me.BtnHelpdeskNv1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHelpdeskNv1.BorderRadius = 10
        Me.BtnHelpdeskNv1.BorderThickness = 1
        Me.BtnHelpdeskNv1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnHelpdeskNv1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnHelpdeskNv1.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnHelpdeskNv1.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnHelpdeskNv1.CheckedState.Parent = Me.BtnHelpdeskNv1
        Me.BtnHelpdeskNv1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHelpdeskNv1.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnHelpdeskNv1.CustomImages.Parent = Me.BtnHelpdeskNv1
        Me.SelectTransition.SetDecoration(Me.BtnHelpdeskNv1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnHelpdeskNv1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnHelpdeskNv1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnHelpdeskNv1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHelpdeskNv1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHelpdeskNv1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnHelpdeskNv1.DisabledState.Parent = Me.BtnHelpdeskNv1
        Me.BtnHelpdeskNv1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnHelpdeskNv1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnHelpdeskNv1.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnHelpdeskNv1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnHelpdeskNv1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHelpdeskNv1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnHelpdeskNv1.HoverState.Parent = Me.BtnHelpdeskNv1
        Me.BtnHelpdeskNv1.Location = New System.Drawing.Point(402, 0)
        Me.BtnHelpdeskNv1.Name = "BtnHelpdeskNv1"
        Me.BtnHelpdeskNv1.ShadowDecoration.Parent = Me.BtnHelpdeskNv1
        Me.BtnHelpdeskNv1.Size = New System.Drawing.Size(134, 35)
        Me.BtnHelpdeskNv1.TabIndex = 72
        Me.BtnHelpdeskNv1.Text = "Básico"
        '
        'BtnHelpdeskNv2
        '
        Me.BtnHelpdeskNv2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHelpdeskNv2.BorderRadius = 10
        Me.BtnHelpdeskNv2.BorderThickness = 1
        Me.BtnHelpdeskNv2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnHelpdeskNv2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnHelpdeskNv2.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnHelpdeskNv2.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnHelpdeskNv2.CheckedState.Parent = Me.BtnHelpdeskNv2
        Me.BtnHelpdeskNv2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHelpdeskNv2.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnHelpdeskNv2.CustomImages.Parent = Me.BtnHelpdeskNv2
        Me.SelectTransition.SetDecoration(Me.BtnHelpdeskNv2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnHelpdeskNv2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnHelpdeskNv2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnHelpdeskNv2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHelpdeskNv2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHelpdeskNv2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnHelpdeskNv2.DisabledState.Parent = Me.BtnHelpdeskNv2
        Me.BtnHelpdeskNv2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnHelpdeskNv2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnHelpdeskNv2.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnHelpdeskNv2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnHelpdeskNv2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHelpdeskNv2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnHelpdeskNv2.HoverState.Parent = Me.BtnHelpdeskNv2
        Me.BtnHelpdeskNv2.Location = New System.Drawing.Point(268, 0)
        Me.BtnHelpdeskNv2.Name = "BtnHelpdeskNv2"
        Me.BtnHelpdeskNv2.ShadowDecoration.Parent = Me.BtnHelpdeskNv2
        Me.BtnHelpdeskNv2.Size = New System.Drawing.Size(134, 35)
        Me.BtnHelpdeskNv2.TabIndex = 71
        Me.BtnHelpdeskNv2.Text = "Intermediário"
        '
        'BtnHelpdeskNv3
        '
        Me.BtnHelpdeskNv3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHelpdeskNv3.BorderRadius = 10
        Me.BtnHelpdeskNv3.BorderThickness = 1
        Me.BtnHelpdeskNv3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnHelpdeskNv3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnHelpdeskNv3.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnHelpdeskNv3.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnHelpdeskNv3.CheckedState.Parent = Me.BtnHelpdeskNv3
        Me.BtnHelpdeskNv3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHelpdeskNv3.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnHelpdeskNv3.CustomImages.Parent = Me.BtnHelpdeskNv3
        Me.SelectTransition.SetDecoration(Me.BtnHelpdeskNv3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnHelpdeskNv3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnHelpdeskNv3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnHelpdeskNv3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHelpdeskNv3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHelpdeskNv3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnHelpdeskNv3.DisabledState.Parent = Me.BtnHelpdeskNv3
        Me.BtnHelpdeskNv3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnHelpdeskNv3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnHelpdeskNv3.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnHelpdeskNv3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnHelpdeskNv3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHelpdeskNv3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnHelpdeskNv3.HoverState.Parent = Me.BtnHelpdeskNv3
        Me.BtnHelpdeskNv3.Location = New System.Drawing.Point(134, 0)
        Me.BtnHelpdeskNv3.Name = "BtnHelpdeskNv3"
        Me.BtnHelpdeskNv3.ShadowDecoration.Parent = Me.BtnHelpdeskNv3
        Me.BtnHelpdeskNv3.Size = New System.Drawing.Size(134, 35)
        Me.BtnHelpdeskNv3.TabIndex = 70
        Me.BtnHelpdeskNv3.Text = "Avançado"
        '
        'BtnHelpdeskNv4
        '
        Me.BtnHelpdeskNv4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHelpdeskNv4.BorderRadius = 10
        Me.BtnHelpdeskNv4.BorderThickness = 1
        Me.BtnHelpdeskNv4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnHelpdeskNv4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnHelpdeskNv4.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnHelpdeskNv4.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnHelpdeskNv4.CheckedState.Parent = Me.BtnHelpdeskNv4
        Me.BtnHelpdeskNv4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHelpdeskNv4.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnHelpdeskNv4.CustomImages.Parent = Me.BtnHelpdeskNv4
        Me.SelectTransition.SetDecoration(Me.BtnHelpdeskNv4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnHelpdeskNv4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnHelpdeskNv4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnHelpdeskNv4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHelpdeskNv4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHelpdeskNv4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnHelpdeskNv4.DisabledState.Parent = Me.BtnHelpdeskNv4
        Me.BtnHelpdeskNv4.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnHelpdeskNv4.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnHelpdeskNv4.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnHelpdeskNv4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnHelpdeskNv4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHelpdeskNv4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnHelpdeskNv4.HoverState.Parent = Me.BtnHelpdeskNv4
        Me.BtnHelpdeskNv4.Location = New System.Drawing.Point(0, 0)
        Me.BtnHelpdeskNv4.Name = "BtnHelpdeskNv4"
        Me.BtnHelpdeskNv4.ShadowDecoration.Parent = Me.BtnHelpdeskNv4
        Me.BtnHelpdeskNv4.Size = New System.Drawing.Size(134, 35)
        Me.BtnHelpdeskNv4.TabIndex = 69
        Me.BtnHelpdeskNv4.Text = "Administrador"
        '
        'BtnHelpdesk
        '
        Me.BtnHelpdesk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnHelpdesk.Animated = True
        Me.BtnHelpdesk.BackColor = System.Drawing.Color.Transparent
        Me.BtnHelpdesk.BorderRadius = 10
        Me.BtnHelpdesk.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnHelpdesk.CausesValidation = False
        Me.BtnHelpdesk.CheckedState.Parent = Me.BtnHelpdesk
        Me.BtnHelpdesk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHelpdesk.CustomImages.Parent = Me.BtnHelpdesk
        Me.SelectTransition.SetDecoration(Me.BtnHelpdesk, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnHelpdesk.DisabledState.Parent = Me.BtnHelpdesk
        Me.BtnHelpdesk.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnHelpdesk.FillColor2 = System.Drawing.Color.Black
        Me.BtnHelpdesk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnHelpdesk.ForeColor = System.Drawing.Color.White
        Me.BtnHelpdesk.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnHelpdesk.HoverState.Parent = Me.BtnHelpdesk
        Me.BtnHelpdesk.Image = CType(resources.GetObject("BtnHelpdesk.Image"), System.Drawing.Image)
        Me.BtnHelpdesk.ImageOffset = New System.Drawing.Point(1, 0)
        Me.BtnHelpdesk.ImageSize = New System.Drawing.Size(80, 60)
        Me.BtnHelpdesk.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnHelpdesk.Location = New System.Drawing.Point(21, 13)
        Me.BtnHelpdesk.Name = "BtnHelpdesk"
        Me.BtnHelpdesk.ShadowDecoration.Parent = Me.BtnHelpdesk
        Me.BtnHelpdesk.Size = New System.Drawing.Size(85, 85)
        Me.BtnHelpdesk.TabIndex = 69
        '
        'S2
        '
        Me.S2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SelectTransition.SetDecoration(Me.S2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.S2.Dock = System.Windows.Forms.DockStyle.Top
        Me.S2.Location = New System.Drawing.Point(0, 240)
        Me.S2.Name = "S2"
        Me.S2.Size = New System.Drawing.Size(702, 10)
        Me.S2.TabIndex = 37
        '
        'PanelPhonebook
        '
        Me.PanelPhonebook.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelPhonebook.Controls.Add(Me.PanelListPhonebook)
        Me.PanelPhonebook.Controls.Add(Me.BtnPhonebook)
        Me.SelectTransition.SetDecoration(Me.PanelPhonebook, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelPhonebook.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPhonebook.Location = New System.Drawing.Point(0, 130)
        Me.PanelPhonebook.Name = "PanelPhonebook"
        Me.PanelPhonebook.Size = New System.Drawing.Size(702, 110)
        Me.PanelPhonebook.TabIndex = 29
        '
        'PanelListPhonebook
        '
        Me.PanelListPhonebook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelListPhonebook.AutoSize = True
        Me.PanelListPhonebook.Controls.Add(Me.BtnPhonebookNv1)
        Me.PanelListPhonebook.Controls.Add(Me.BtnPhonebookNv2)
        Me.PanelListPhonebook.Controls.Add(Me.BtnPhonebookNv3)
        Me.PanelListPhonebook.Controls.Add(Me.BtnPhonebookNv4)
        Me.SelectTransition.SetDecoration(Me.PanelListPhonebook, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelListPhonebook.Location = New System.Drawing.Point(137, 40)
        Me.PanelListPhonebook.Name = "PanelListPhonebook"
        Me.PanelListPhonebook.Size = New System.Drawing.Size(538, 35)
        Me.PanelListPhonebook.TabIndex = 68
        '
        'BtnPhonebookNv1
        '
        Me.BtnPhonebookNv1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPhonebookNv1.BorderRadius = 10
        Me.BtnPhonebookNv1.BorderThickness = 1
        Me.BtnPhonebookNv1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnPhonebookNv1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnPhonebookNv1.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnPhonebookNv1.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnPhonebookNv1.CheckedState.Parent = Me.BtnPhonebookNv1
        Me.BtnPhonebookNv1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPhonebookNv1.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnPhonebookNv1.CustomImages.Parent = Me.BtnPhonebookNv1
        Me.SelectTransition.SetDecoration(Me.BtnPhonebookNv1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnPhonebookNv1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnPhonebookNv1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnPhonebookNv1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPhonebookNv1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPhonebookNv1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnPhonebookNv1.DisabledState.Parent = Me.BtnPhonebookNv1
        Me.BtnPhonebookNv1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPhonebookNv1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnPhonebookNv1.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnPhonebookNv1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnPhonebookNv1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPhonebookNv1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnPhonebookNv1.HoverState.Parent = Me.BtnPhonebookNv1
        Me.BtnPhonebookNv1.Location = New System.Drawing.Point(402, 0)
        Me.BtnPhonebookNv1.Name = "BtnPhonebookNv1"
        Me.BtnPhonebookNv1.ShadowDecoration.Parent = Me.BtnPhonebookNv1
        Me.BtnPhonebookNv1.Size = New System.Drawing.Size(134, 35)
        Me.BtnPhonebookNv1.TabIndex = 72
        Me.BtnPhonebookNv1.Text = "Básico"
        '
        'BtnPhonebookNv2
        '
        Me.BtnPhonebookNv2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPhonebookNv2.BorderRadius = 10
        Me.BtnPhonebookNv2.BorderThickness = 1
        Me.BtnPhonebookNv2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnPhonebookNv2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnPhonebookNv2.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnPhonebookNv2.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnPhonebookNv2.CheckedState.Parent = Me.BtnPhonebookNv2
        Me.BtnPhonebookNv2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPhonebookNv2.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnPhonebookNv2.CustomImages.Parent = Me.BtnPhonebookNv2
        Me.SelectTransition.SetDecoration(Me.BtnPhonebookNv2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnPhonebookNv2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnPhonebookNv2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnPhonebookNv2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPhonebookNv2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPhonebookNv2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnPhonebookNv2.DisabledState.Parent = Me.BtnPhonebookNv2
        Me.BtnPhonebookNv2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPhonebookNv2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnPhonebookNv2.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnPhonebookNv2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnPhonebookNv2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPhonebookNv2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnPhonebookNv2.HoverState.Parent = Me.BtnPhonebookNv2
        Me.BtnPhonebookNv2.Location = New System.Drawing.Point(268, 0)
        Me.BtnPhonebookNv2.Name = "BtnPhonebookNv2"
        Me.BtnPhonebookNv2.ShadowDecoration.Parent = Me.BtnPhonebookNv2
        Me.BtnPhonebookNv2.Size = New System.Drawing.Size(134, 35)
        Me.BtnPhonebookNv2.TabIndex = 71
        Me.BtnPhonebookNv2.Text = "Intermediário"
        '
        'BtnPhonebookNv3
        '
        Me.BtnPhonebookNv3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPhonebookNv3.BorderRadius = 10
        Me.BtnPhonebookNv3.BorderThickness = 1
        Me.BtnPhonebookNv3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnPhonebookNv3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnPhonebookNv3.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnPhonebookNv3.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnPhonebookNv3.CheckedState.Parent = Me.BtnPhonebookNv3
        Me.BtnPhonebookNv3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPhonebookNv3.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnPhonebookNv3.CustomImages.Parent = Me.BtnPhonebookNv3
        Me.SelectTransition.SetDecoration(Me.BtnPhonebookNv3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnPhonebookNv3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnPhonebookNv3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnPhonebookNv3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPhonebookNv3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPhonebookNv3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnPhonebookNv3.DisabledState.Parent = Me.BtnPhonebookNv3
        Me.BtnPhonebookNv3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPhonebookNv3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnPhonebookNv3.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnPhonebookNv3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnPhonebookNv3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPhonebookNv3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnPhonebookNv3.HoverState.Parent = Me.BtnPhonebookNv3
        Me.BtnPhonebookNv3.Location = New System.Drawing.Point(134, 0)
        Me.BtnPhonebookNv3.Name = "BtnPhonebookNv3"
        Me.BtnPhonebookNv3.ShadowDecoration.Parent = Me.BtnPhonebookNv3
        Me.BtnPhonebookNv3.Size = New System.Drawing.Size(134, 35)
        Me.BtnPhonebookNv3.TabIndex = 70
        Me.BtnPhonebookNv3.Text = "Avançado"
        '
        'BtnPhonebookNv4
        '
        Me.BtnPhonebookNv4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPhonebookNv4.BorderRadius = 10
        Me.BtnPhonebookNv4.BorderThickness = 1
        Me.BtnPhonebookNv4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnPhonebookNv4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnPhonebookNv4.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnPhonebookNv4.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnPhonebookNv4.CheckedState.Parent = Me.BtnPhonebookNv4
        Me.BtnPhonebookNv4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPhonebookNv4.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnPhonebookNv4.CustomImages.Parent = Me.BtnPhonebookNv4
        Me.SelectTransition.SetDecoration(Me.BtnPhonebookNv4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnPhonebookNv4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnPhonebookNv4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnPhonebookNv4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPhonebookNv4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPhonebookNv4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnPhonebookNv4.DisabledState.Parent = Me.BtnPhonebookNv4
        Me.BtnPhonebookNv4.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPhonebookNv4.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnPhonebookNv4.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnPhonebookNv4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnPhonebookNv4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPhonebookNv4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnPhonebookNv4.HoverState.Parent = Me.BtnPhonebookNv4
        Me.BtnPhonebookNv4.Location = New System.Drawing.Point(0, 0)
        Me.BtnPhonebookNv4.Name = "BtnPhonebookNv4"
        Me.BtnPhonebookNv4.ShadowDecoration.Parent = Me.BtnPhonebookNv4
        Me.BtnPhonebookNv4.Size = New System.Drawing.Size(134, 35)
        Me.BtnPhonebookNv4.TabIndex = 69
        Me.BtnPhonebookNv4.Text = "Administrador"
        '
        'BtnPhonebook
        '
        Me.BtnPhonebook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnPhonebook.Animated = True
        Me.BtnPhonebook.BackColor = System.Drawing.Color.Transparent
        Me.BtnPhonebook.BorderRadius = 10
        Me.BtnPhonebook.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnPhonebook.CausesValidation = False
        Me.BtnPhonebook.CheckedState.Parent = Me.BtnPhonebook
        Me.BtnPhonebook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPhonebook.CustomImages.Parent = Me.BtnPhonebook
        Me.SelectTransition.SetDecoration(Me.BtnPhonebook, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnPhonebook.DisabledState.Parent = Me.BtnPhonebook
        Me.BtnPhonebook.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnPhonebook.FillColor2 = System.Drawing.Color.Black
        Me.BtnPhonebook.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPhonebook.ForeColor = System.Drawing.Color.White
        Me.BtnPhonebook.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnPhonebook.HoverState.Parent = Me.BtnPhonebook
        Me.BtnPhonebook.Image = CType(resources.GetObject("BtnPhonebook.Image"), System.Drawing.Image)
        Me.BtnPhonebook.ImageOffset = New System.Drawing.Point(1, 0)
        Me.BtnPhonebook.ImageSize = New System.Drawing.Size(95, 80)
        Me.BtnPhonebook.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPhonebook.Location = New System.Drawing.Point(21, 13)
        Me.BtnPhonebook.Name = "BtnPhonebook"
        Me.BtnPhonebook.ShadowDecoration.Parent = Me.BtnPhonebook
        Me.BtnPhonebook.Size = New System.Drawing.Size(85, 85)
        Me.BtnPhonebook.TabIndex = 67
        '
        'S1
        '
        Me.SelectTransition.SetDecoration(Me.S1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.S1.Dock = System.Windows.Forms.DockStyle.Top
        Me.S1.Location = New System.Drawing.Point(0, 120)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(702, 10)
        Me.S1.TabIndex = 40
        '
        'PanelHome
        '
        Me.PanelHome.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelHome.Controls.Add(Me.PanelListHome)
        Me.PanelHome.Controls.Add(Me.BtnHome)
        Me.SelectTransition.SetDecoration(Me.PanelHome, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHome.Location = New System.Drawing.Point(0, 10)
        Me.PanelHome.Name = "PanelHome"
        Me.PanelHome.Size = New System.Drawing.Size(702, 110)
        Me.PanelHome.TabIndex = 39
        '
        'PanelListHome
        '
        Me.PanelListHome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelListHome.AutoSize = True
        Me.PanelListHome.Controls.Add(Me.BtnHomeNv1)
        Me.PanelListHome.Controls.Add(Me.BtnHomeNv2)
        Me.PanelListHome.Controls.Add(Me.BtnHomeNv3)
        Me.PanelListHome.Controls.Add(Me.BtnHomeNv4)
        Me.SelectTransition.SetDecoration(Me.PanelListHome, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelListHome.Location = New System.Drawing.Point(137, 40)
        Me.PanelListHome.Name = "PanelListHome"
        Me.PanelListHome.Size = New System.Drawing.Size(538, 35)
        Me.PanelListHome.TabIndex = 70
        '
        'BtnHomeNv1
        '
        Me.BtnHomeNv1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHomeNv1.BorderRadius = 10
        Me.BtnHomeNv1.BorderThickness = 1
        Me.BtnHomeNv1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnHomeNv1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnHomeNv1.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnHomeNv1.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnHomeNv1.CheckedState.Parent = Me.BtnHomeNv1
        Me.BtnHomeNv1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHomeNv1.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnHomeNv1.CustomImages.Parent = Me.BtnHomeNv1
        Me.SelectTransition.SetDecoration(Me.BtnHomeNv1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnHomeNv1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnHomeNv1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnHomeNv1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHomeNv1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHomeNv1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnHomeNv1.DisabledState.Parent = Me.BtnHomeNv1
        Me.BtnHomeNv1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnHomeNv1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnHomeNv1.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnHomeNv1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnHomeNv1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHomeNv1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnHomeNv1.HoverState.Parent = Me.BtnHomeNv1
        Me.BtnHomeNv1.Location = New System.Drawing.Point(402, 0)
        Me.BtnHomeNv1.Name = "BtnHomeNv1"
        Me.BtnHomeNv1.ShadowDecoration.Parent = Me.BtnHomeNv1
        Me.BtnHomeNv1.Size = New System.Drawing.Size(134, 35)
        Me.BtnHomeNv1.TabIndex = 72
        Me.BtnHomeNv1.Text = "Básico"
        '
        'BtnHomeNv2
        '
        Me.BtnHomeNv2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHomeNv2.BorderRadius = 10
        Me.BtnHomeNv2.BorderThickness = 1
        Me.BtnHomeNv2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnHomeNv2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnHomeNv2.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnHomeNv2.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnHomeNv2.CheckedState.Parent = Me.BtnHomeNv2
        Me.BtnHomeNv2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHomeNv2.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnHomeNv2.CustomImages.Parent = Me.BtnHomeNv2
        Me.SelectTransition.SetDecoration(Me.BtnHomeNv2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnHomeNv2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnHomeNv2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnHomeNv2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHomeNv2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHomeNv2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnHomeNv2.DisabledState.Parent = Me.BtnHomeNv2
        Me.BtnHomeNv2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnHomeNv2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnHomeNv2.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnHomeNv2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnHomeNv2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHomeNv2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnHomeNv2.HoverState.Parent = Me.BtnHomeNv2
        Me.BtnHomeNv2.Location = New System.Drawing.Point(268, 0)
        Me.BtnHomeNv2.Name = "BtnHomeNv2"
        Me.BtnHomeNv2.ShadowDecoration.Parent = Me.BtnHomeNv2
        Me.BtnHomeNv2.Size = New System.Drawing.Size(134, 35)
        Me.BtnHomeNv2.TabIndex = 71
        Me.BtnHomeNv2.Text = "Intermediário"
        '
        'BtnHomeNv3
        '
        Me.BtnHomeNv3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHomeNv3.BorderRadius = 10
        Me.BtnHomeNv3.BorderThickness = 1
        Me.BtnHomeNv3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnHomeNv3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnHomeNv3.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnHomeNv3.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnHomeNv3.CheckedState.Parent = Me.BtnHomeNv3
        Me.BtnHomeNv3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHomeNv3.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnHomeNv3.CustomImages.Parent = Me.BtnHomeNv3
        Me.SelectTransition.SetDecoration(Me.BtnHomeNv3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnHomeNv3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnHomeNv3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnHomeNv3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHomeNv3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHomeNv3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnHomeNv3.DisabledState.Parent = Me.BtnHomeNv3
        Me.BtnHomeNv3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnHomeNv3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnHomeNv3.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnHomeNv3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnHomeNv3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHomeNv3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnHomeNv3.HoverState.Parent = Me.BtnHomeNv3
        Me.BtnHomeNv3.Location = New System.Drawing.Point(134, 0)
        Me.BtnHomeNv3.Name = "BtnHomeNv3"
        Me.BtnHomeNv3.ShadowDecoration.Parent = Me.BtnHomeNv3
        Me.BtnHomeNv3.Size = New System.Drawing.Size(134, 35)
        Me.BtnHomeNv3.TabIndex = 70
        Me.BtnHomeNv3.Text = "Avançado"
        '
        'BtnHomeNv4
        '
        Me.BtnHomeNv4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHomeNv4.BorderRadius = 10
        Me.BtnHomeNv4.BorderThickness = 1
        Me.BtnHomeNv4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.BtnHomeNv4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnHomeNv4.CheckedState.FillColor2 = System.Drawing.Color.Black
        Me.BtnHomeNv4.CheckedState.ForeColor = System.Drawing.Color.White
        Me.BtnHomeNv4.CheckedState.Parent = Me.BtnHomeNv4
        Me.BtnHomeNv4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHomeNv4.CustomBorderColor = System.Drawing.Color.Black
        Me.BtnHomeNv4.CustomImages.Parent = Me.BtnHomeNv4
        Me.SelectTransition.SetDecoration(Me.BtnHomeNv4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnHomeNv4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnHomeNv4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnHomeNv4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHomeNv4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnHomeNv4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnHomeNv4.DisabledState.Parent = Me.BtnHomeNv4
        Me.BtnHomeNv4.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnHomeNv4.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BtnHomeNv4.FillColor2 = System.Drawing.Color.WhiteSmoke
        Me.BtnHomeNv4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnHomeNv4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnHomeNv4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnHomeNv4.HoverState.Parent = Me.BtnHomeNv4
        Me.BtnHomeNv4.Location = New System.Drawing.Point(0, 0)
        Me.BtnHomeNv4.Name = "BtnHomeNv4"
        Me.BtnHomeNv4.ShadowDecoration.Parent = Me.BtnHomeNv4
        Me.BtnHomeNv4.Size = New System.Drawing.Size(134, 35)
        Me.BtnHomeNv4.TabIndex = 69
        Me.BtnHomeNv4.Text = "Administrador"
        '
        'BtnHome
        '
        Me.BtnHome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnHome.Animated = True
        Me.BtnHome.BackColor = System.Drawing.Color.Transparent
        Me.BtnHome.BorderRadius = 10
        Me.BtnHome.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnHome.CausesValidation = False
        Me.BtnHome.CheckedState.Parent = Me.BtnHome
        Me.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHome.CustomImages.Parent = Me.BtnHome
        Me.SelectTransition.SetDecoration(Me.BtnHome, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnHome.DisabledState.Parent = Me.BtnHome
        Me.BtnHome.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnHome.FillColor2 = System.Drawing.Color.Black
        Me.BtnHome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnHome.ForeColor = System.Drawing.Color.White
        Me.BtnHome.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnHome.HoverState.Parent = Me.BtnHome
        Me.BtnHome.Image = CType(resources.GetObject("BtnHome.Image"), System.Drawing.Image)
        Me.BtnHome.ImageOffset = New System.Drawing.Point(1, 0)
        Me.BtnHome.ImageSize = New System.Drawing.Size(95, 90)
        Me.BtnHome.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnHome.Location = New System.Drawing.Point(21, 13)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.ShadowDecoration.Parent = Me.BtnHome
        Me.BtnHome.Size = New System.Drawing.Size(85, 85)
        Me.BtnHome.TabIndex = 69
        '
        'PanelNextPrevio
        '
        Me.PanelNextPrevio.Controls.Add(Me.BtnSalvar)
        Me.PanelNextPrevio.Controls.Add(Me.BtnCancelarPerm)
        Me.SelectTransition.SetDecoration(Me.PanelNextPrevio, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelNextPrevio.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelNextPrevio.Location = New System.Drawing.Point(0, 735)
        Me.PanelNextPrevio.Name = "PanelNextPrevio"
        Me.PanelNextPrevio.Size = New System.Drawing.Size(702, 63)
        Me.PanelNextPrevio.TabIndex = 0
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSalvar.Animated = True
        Me.BtnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.BorderRadius = 18
        Me.BtnSalvar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnSalvar.CausesValidation = False
        Me.BtnSalvar.CheckedState.Parent = Me.BtnSalvar
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.CustomImages.Parent = Me.BtnSalvar
        Me.SelectTransition.SetDecoration(Me.BtnSalvar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnSalvar.DisabledState.Parent = Me.BtnSalvar
        Me.BtnSalvar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnSalvar.FillColor2 = System.Drawing.Color.Black
        Me.BtnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalvar.ForeColor = System.Drawing.Color.White
        Me.BtnSalvar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnSalvar.HoverState.Parent = Me.BtnSalvar
        Me.BtnSalvar.Location = New System.Drawing.Point(355, 13)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.ShadowDecoration.Parent = Me.BtnSalvar
        Me.BtnSalvar.Size = New System.Drawing.Size(124, 38)
        Me.BtnSalvar.TabIndex = 167
        Me.BtnSalvar.Text = "SALVAR"
        '
        'BtnCancelarPerm
        '
        Me.BtnCancelarPerm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancelarPerm.Animated = True
        Me.BtnCancelarPerm.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarPerm.BorderRadius = 18
        Me.BtnCancelarPerm.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnCancelarPerm.CausesValidation = False
        Me.BtnCancelarPerm.CheckedState.Parent = Me.BtnCancelarPerm
        Me.BtnCancelarPerm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelarPerm.CustomImages.Parent = Me.BtnCancelarPerm
        Me.SelectTransition.SetDecoration(Me.BtnCancelarPerm, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnCancelarPerm.DisabledState.Parent = Me.BtnCancelarPerm
        Me.BtnCancelarPerm.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnCancelarPerm.FillColor2 = System.Drawing.Color.Black
        Me.BtnCancelarPerm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelarPerm.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarPerm.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnCancelarPerm.HoverState.Parent = Me.BtnCancelarPerm
        Me.BtnCancelarPerm.Location = New System.Drawing.Point(224, 13)
        Me.BtnCancelarPerm.Name = "BtnCancelarPerm"
        Me.BtnCancelarPerm.ShadowDecoration.Parent = Me.BtnCancelarPerm
        Me.BtnCancelarPerm.Size = New System.Drawing.Size(124, 38)
        Me.BtnCancelarPerm.TabIndex = 168
        Me.BtnCancelarPerm.Text = "CANCELAR"
        '
        'S0
        '
        Me.SelectTransition.SetDecoration(Me.S0, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.S0.Dock = System.Windows.Forms.DockStyle.Top
        Me.S0.Location = New System.Drawing.Point(0, 0)
        Me.S0.Name = "S0"
        Me.S0.Size = New System.Drawing.Size(702, 10)
        Me.S0.TabIndex = 41
        '
        'ImgUsers
        '
        Me.ImgUsers.ImageStream = CType(resources.GetObject("ImgUsers.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgUsers.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgUsers.Images.SetKeyName(0, "clear_symbol_20px.png")
        '
        'TimerSalvar
        '
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "DgvColumnSelect"
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 50
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'TimerBuscarUsers
        '
        '
        'FrmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(788, 565)
        Me.Controls.Add(Me.TabControlUsers)
        Me.Controls.Add(Me.PanelFilter)
        Me.Controls.Add(Me.PanelSelect)
        Me.SelectTransition.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUsers"
        Me.Text = "FrmUsers"
        Me.PanelSelect.ResumeLayout(False)
        Me.PanelSelect.PerformLayout()
        Me.PanelFilter.ResumeLayout(False)
        Me.GBoxOpcoes.ResumeLayout(False)
        Me.GBoxDataFinal.ResumeLayout(False)
        Me.GBoxDataInicial.ResumeLayout(False)
        Me.GBoxGenero.ResumeLayout(False)
        Me.TabControlUsers.ResumeLayout(False)
        Me.TpInicial.ResumeLayout(False)
        Me.ShPanel1.ResumeLayout(False)
        Me.ShPanel1.PerformLayout()
        Me.TpListaUsuario.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.PanelCentral.ResumeLayout(False)
        CType(Me.DgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPaginacao.ResumeLayout(False)
        Me.PanelPaginacao.PerformLayout()
        Me.TpPerfil.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.ImgPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpPermissoes.ResumeLayout(False)
        Me.TlpPermissoes.ResumeLayout(False)
        Me.PanelPermissoes.ResumeLayout(False)
        Me.PanelDashboard.ResumeLayout(False)
        Me.PanelDashboard.PerformLayout()
        Me.PanelListDashboard.ResumeLayout(False)
        Me.PanelFinanceiro.ResumeLayout(False)
        Me.PanelFinanceiro.PerformLayout()
        Me.PanelListFinanceiro.ResumeLayout(False)
        Me.PanelEstoque.ResumeLayout(False)
        Me.PanelEstoque.PerformLayout()
        Me.PanelListEstoque.ResumeLayout(False)
        Me.PanelHelpdesk.ResumeLayout(False)
        Me.PanelHelpdesk.PerformLayout()
        Me.PanelListHelpdesk.ResumeLayout(False)
        Me.PanelPhonebook.ResumeLayout(False)
        Me.PanelPhonebook.PerformLayout()
        Me.PanelListPhonebook.ResumeLayout(False)
        Me.PanelHome.ResumeLayout(False)
        Me.PanelHome.PerformLayout()
        Me.PanelListHome.ResumeLayout(False)
        Me.PanelNextPrevio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImgUsers As ImageList
    Friend WithEvents PanelSelect As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents BtnSelectApagar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnInfoUsuario As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents HtmlLblSelect As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents SelectTransition As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents TimerSalvar As Timer
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents PanelFilter As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnMesAtual As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnUltimos3Meses As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnUltimoMes As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents GBoxDataFinal As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents DataFinal As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents GBoxDataInicial As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents GBoxGenero As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BtnRamal As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnCidade As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnEmail As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnToken As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnUF As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnNome As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnAplicar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnLimpar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnMasculino As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnFeminino As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents DataInicial As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents GBoxOpcoes As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BtnSelectIntervalo As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TimerBuscarUsers As Timer
    Friend WithEvents TabControlUsers As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TpInicial As TabPage
    Friend WithEvents TpPermissoes As TabPage
    Friend WithEvents TpListaUsuario As TabPage
    Friend WithEvents TpPerfil As TabPage
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents CbRegistrosPorPagina As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtFilter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TlpPermissoes As TableLayoutPanel
    Friend WithEvents PanelPermissoes As Panel
    Friend WithEvents S6 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents PanelListDashboard As Panel
    Friend WithEvents BtnDashboardNv1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnDashboardNv2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnDashboardNv3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnDashboardNv4 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnDashboard As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents S5 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents PanelFinanceiro As Panel
    Friend WithEvents PanelListFinanceiro As Panel
    Friend WithEvents BtnFinanceiroNv1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnFinanceiroNv2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnFinanceiroNv3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnFinanceiroNv4 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnFinanceiro As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents S4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents PanelEstoque As Panel
    Friend WithEvents PanelListEstoque As Panel
    Friend WithEvents BtnEstoqueNv1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnEstoqueNv2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnEstoqueNv3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnEstoqueNv4 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnEstoque As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents S3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents PanelHelpdesk As Panel
    Friend WithEvents PanelListHelpdesk As Panel
    Friend WithEvents BtnHelpdeskNv1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnHelpdeskNv2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnHelpdeskNv3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnHelpdeskNv4 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnHelpdesk As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents S2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents PanelPhonebook As Panel
    Friend WithEvents PanelListPhonebook As Panel
    Friend WithEvents BtnPhonebookNv1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnPhonebookNv2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnPhonebookNv3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnPhonebookNv4 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnPhonebook As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents S1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents PanelHome As Panel
    Friend WithEvents PanelListHome As Panel
    Friend WithEvents BtnHomeNv1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnHomeNv2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnHomeNv3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnHomeNv4 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnHome As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PanelNextPrevio As Panel
    Friend WithEvents BtnSalvar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnCancelarPerm As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents S0 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents PanelCentral As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DgvUsers As BunifuDataGridView
    Friend WithEvents DgvColumnSelect As DataGridViewCheckBoxColumn
    Friend WithEvents PanelPaginacao As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblSelectRegister As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblPaginacao As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnPrevio As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnAvPerfil As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnVoltarPerfil As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnCopy As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LblChaveKey As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblUserInfo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnListarUsuarios As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ShPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents LblUsuario As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtToken As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnEditarPermissoes As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Lbl5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents BtnSelectFechar As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents ImgPerfil As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
