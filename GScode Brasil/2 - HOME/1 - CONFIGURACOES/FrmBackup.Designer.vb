<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBackup))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelSelect = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.BtnRestoreBkp = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnSelectFechar = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.BtnSelectApagar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnDownloadBkp = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LblSelect = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Ofd = New System.Windows.Forms.OpenFileDialog()
        Me.TimerDatabaseConfig = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSystemBkp = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDatabaseBkp = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSystemRestore = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDatabaseDownload = New System.Windows.Forms.Timer(Me.components)
        Me.SelectTransition = New Guna.UI2.WinForms.Guna2Transition()
        Me.TabControlBackup = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TpInicial = New System.Windows.Forms.TabPage()
        Me.ShPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.BtnListarBkp = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Lbl9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnDatabaseBkp = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ShPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.BtnSystemRestore = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Lbl8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnSystemBkp = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ShPanel3 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Lbl10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnDatabaseConfig = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Lbl1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Lbl2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TpBackups = New System.Windows.Forms.TabPage()
        Me.Tpl1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnUploadBkp = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DgvBackup = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DgvColumnSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PanelPaginacao = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblSelectRegister = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblPaginacao = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnVoltarMenu = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TpServerConfig = New System.Windows.Forms.TabPage()
        Me.LblBDAviso = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnDefault = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.BtnConnect = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LblPorta = New System.Windows.Forms.Label()
        Me.LblServidor = New System.Windows.Forms.Label()
        Me.BtnCancelar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnSalvar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TxtPorta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtServidor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblSenha = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.TxtSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblBanco = New System.Windows.Forms.Label()
        Me.TxtBanco = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TpAguarde = New System.Windows.Forms.TabPage()
        Me.ProgressAguarde = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.LblAguarde = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TimerDatabaseDefault = New System.Windows.Forms.Timer(Me.components)
        Me.Fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.TimerDatabaseRestore = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PanelSelect.SuspendLayout()
        Me.TabControlBackup.SuspendLayout()
        Me.TpInicial.SuspendLayout()
        Me.ShPanel2.SuspendLayout()
        Me.ShPanel1.SuspendLayout()
        Me.ShPanel3.SuspendLayout()
        Me.TpBackups.SuspendLayout()
        Me.Tpl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.DgvBackup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPaginacao.SuspendLayout()
        Me.TpServerConfig.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpAguarde.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSelect
        '
        Me.PanelSelect.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelSelect.BackColor = System.Drawing.Color.Transparent
        Me.PanelSelect.Controls.Add(Me.BtnRestoreBkp)
        Me.PanelSelect.Controls.Add(Me.BtnSelectFechar)
        Me.PanelSelect.Controls.Add(Me.BtnSelectApagar)
        Me.PanelSelect.Controls.Add(Me.BtnDownloadBkp)
        Me.PanelSelect.Controls.Add(Me.LblSelect)
        Me.SelectTransition.SetDecoration(Me.PanelSelect, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelSelect.FillColor = System.Drawing.Color.White
        Me.PanelSelect.Location = New System.Drawing.Point(185, 5)
        Me.PanelSelect.Name = "PanelSelect"
        Me.PanelSelect.ShadowColor = System.Drawing.Color.Black
        Me.PanelSelect.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.PanelSelect.Size = New System.Drawing.Size(368, 89)
        Me.PanelSelect.TabIndex = 6
        Me.PanelSelect.Visible = False
        '
        'BtnRestoreBkp
        '
        Me.BtnRestoreBkp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestoreBkp.BorderRadius = 5
        Me.BtnRestoreBkp.CheckedState.Parent = Me.BtnRestoreBkp
        Me.BtnRestoreBkp.CustomImages.Parent = Me.BtnRestoreBkp
        Me.SelectTransition.SetDecoration(Me.BtnRestoreBkp, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnRestoreBkp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnRestoreBkp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnRestoreBkp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnRestoreBkp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnRestoreBkp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnRestoreBkp.DisabledState.Parent = Me.BtnRestoreBkp
        Me.BtnRestoreBkp.FillColor = System.Drawing.Color.Indigo
        Me.BtnRestoreBkp.FillColor2 = System.Drawing.Color.Black
        Me.BtnRestoreBkp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnRestoreBkp.ForeColor = System.Drawing.Color.White
        Me.BtnRestoreBkp.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnRestoreBkp.HoverState.Parent = Me.BtnRestoreBkp
        Me.BtnRestoreBkp.Image = CType(resources.GetObject("BtnRestoreBkp.Image"), System.Drawing.Image)
        Me.BtnRestoreBkp.ImageSize = New System.Drawing.Size(13, 13)
        Me.BtnRestoreBkp.Location = New System.Drawing.Point(143, 46)
        Me.BtnRestoreBkp.Name = "BtnRestoreBkp"
        Me.BtnRestoreBkp.ShadowDecoration.Parent = Me.BtnRestoreBkp
        Me.BtnRestoreBkp.Size = New System.Drawing.Size(85, 32)
        Me.BtnRestoreBkp.TabIndex = 20
        Me.BtnRestoreBkp.Text = "Restaurar"
        '
        'BtnSelectFechar
        '
        Me.BtnSelectFechar.ActiveImage = Nothing
        Me.BtnSelectFechar.AllowAnimations = True
        Me.BtnSelectFechar.AllowBuffering = False
        Me.BtnSelectFechar.AllowToggling = False
        Me.BtnSelectFechar.AllowZooming = True
        Me.BtnSelectFechar.AllowZoomingOnFocus = False
        Me.BtnSelectFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectFechar.BackColor = System.Drawing.Color.White
        Me.BtnSelectFechar.CausesValidation = False
        Me.BtnSelectFechar.Cursor = System.Windows.Forms.Cursors.Default
        Me.SelectTransition.SetDecoration(Me.BtnSelectFechar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnSelectFechar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnSelectFechar.ErrorImage = CType(resources.GetObject("BtnSelectFechar.ErrorImage"), System.Drawing.Image)
        Me.BtnSelectFechar.FadeWhenInactive = False
        Me.BtnSelectFechar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.BtnSelectFechar.Image = CType(resources.GetObject("BtnSelectFechar.Image"), System.Drawing.Image)
        Me.BtnSelectFechar.ImageActive = Nothing
        Me.BtnSelectFechar.ImageLocation = Nothing
        Me.BtnSelectFechar.ImageMargin = 7
        Me.BtnSelectFechar.ImageSize = New System.Drawing.Size(13, 13)
        Me.BtnSelectFechar.ImageZoomSize = New System.Drawing.Size(20, 20)
        Me.BtnSelectFechar.InitialImage = CType(resources.GetObject("BtnSelectFechar.InitialImage"), System.Drawing.Image)
        Me.BtnSelectFechar.Location = New System.Drawing.Point(337, 6)
        Me.BtnSelectFechar.Name = "BtnSelectFechar"
        Me.BtnSelectFechar.Rotation = 0
        Me.BtnSelectFechar.ShowActiveImage = True
        Me.BtnSelectFechar.ShowCursorChanges = True
        Me.BtnSelectFechar.ShowImageBorders = True
        Me.BtnSelectFechar.ShowSizeMarkers = False
        Me.BtnSelectFechar.Size = New System.Drawing.Size(20, 20)
        Me.BtnSelectFechar.TabIndex = 19
        Me.BtnSelectFechar.ToolTipText = "Fechar"
        Me.BtnSelectFechar.WaitOnLoad = False
        Me.BtnSelectFechar.Zoom = 7
        Me.BtnSelectFechar.ZoomSpeed = 10
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
        Me.BtnSelectApagar.Location = New System.Drawing.Point(240, 46)
        Me.BtnSelectApagar.Name = "BtnSelectApagar"
        Me.BtnSelectApagar.ShadowDecoration.Parent = Me.BtnSelectApagar
        Me.BtnSelectApagar.Size = New System.Drawing.Size(85, 32)
        Me.BtnSelectApagar.TabIndex = 18
        Me.BtnSelectApagar.Text = "Excluir"
        '
        'BtnDownloadBkp
        '
        Me.BtnDownloadBkp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDownloadBkp.BorderRadius = 5
        Me.BtnDownloadBkp.CheckedState.Parent = Me.BtnDownloadBkp
        Me.BtnDownloadBkp.CustomImages.Parent = Me.BtnDownloadBkp
        Me.SelectTransition.SetDecoration(Me.BtnDownloadBkp, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnDownloadBkp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDownloadBkp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDownloadBkp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDownloadBkp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDownloadBkp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDownloadBkp.DisabledState.Parent = Me.BtnDownloadBkp
        Me.BtnDownloadBkp.FillColor = System.Drawing.Color.Blue
        Me.BtnDownloadBkp.FillColor2 = System.Drawing.Color.Black
        Me.BtnDownloadBkp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnDownloadBkp.ForeColor = System.Drawing.Color.White
        Me.BtnDownloadBkp.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnDownloadBkp.HoverState.Parent = Me.BtnDownloadBkp
        Me.BtnDownloadBkp.Image = CType(resources.GetObject("BtnDownloadBkp.Image"), System.Drawing.Image)
        Me.BtnDownloadBkp.ImageSize = New System.Drawing.Size(13, 13)
        Me.BtnDownloadBkp.Location = New System.Drawing.Point(44, 46)
        Me.BtnDownloadBkp.Name = "BtnDownloadBkp"
        Me.BtnDownloadBkp.ShadowDecoration.Parent = Me.BtnDownloadBkp
        Me.BtnDownloadBkp.Size = New System.Drawing.Size(85, 32)
        Me.BtnDownloadBkp.TabIndex = 17
        Me.BtnDownloadBkp.Text = "Download"
        '
        'LblSelect
        '
        Me.LblSelect.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.LblSelect, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblSelect.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblSelect.Location = New System.Drawing.Point(14, 10)
        Me.LblSelect.Name = "LblSelect"
        Me.LblSelect.Size = New System.Drawing.Size(153, 19)
        Me.LblSelect.TabIndex = 16
        Me.LblSelect.Text = "Usuários selecionados (1)"
        '
        'TimerDatabaseConfig
        '
        '
        'TimerSystemBkp
        '
        '
        'TimerDatabaseBkp
        '
        '
        'TimerSystemRestore
        '
        '
        'TimerDatabaseDownload
        '
        '
        'SelectTransition
        '
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
        '
        'TabControlBackup
        '
        Me.TabControlBackup.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControlBackup.Controls.Add(Me.TpInicial)
        Me.TabControlBackup.Controls.Add(Me.TpBackups)
        Me.TabControlBackup.Controls.Add(Me.TpServerConfig)
        Me.TabControlBackup.Controls.Add(Me.TpAguarde)
        Me.SelectTransition.SetDecoration(Me.TabControlBackup, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TabControlBackup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlBackup.ItemSize = New System.Drawing.Size(180, 33)
        Me.TabControlBackup.Location = New System.Drawing.Point(0, 0)
        Me.TabControlBackup.Name = "TabControlBackup"
        Me.TabControlBackup.SelectedIndex = 0
        Me.TabControlBackup.Size = New System.Drawing.Size(788, 565)
        Me.TabControlBackup.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabControlBackup.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControlBackup.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControlBackup.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabControlBackup.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControlBackup.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabControlBackup.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControlBackup.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControlBackup.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TabControlBackup.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControlBackup.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabControlBackup.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabControlBackup.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControlBackup.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabControlBackup.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlBackup.TabButtonSize = New System.Drawing.Size(180, 33)
        Me.TabControlBackup.TabIndex = 11
        Me.TabControlBackup.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControlBackup.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalBottom
        Me.TabControlBackup.Visible = False
        '
        'TpInicial
        '
        Me.TpInicial.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpInicial.Controls.Add(Me.ShPanel2)
        Me.TpInicial.Controls.Add(Me.ShPanel1)
        Me.TpInicial.Controls.Add(Me.ShPanel3)
        Me.TpInicial.Controls.Add(Me.Lbl1)
        Me.TpInicial.Controls.Add(Me.Lbl2)
        Me.SelectTransition.SetDecoration(Me.TpInicial, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TpInicial.Location = New System.Drawing.Point(4, 4)
        Me.TpInicial.Name = "TpInicial"
        Me.TpInicial.Padding = New System.Windows.Forms.Padding(3)
        Me.TpInicial.Size = New System.Drawing.Size(780, 524)
        Me.TpInicial.TabIndex = 1
        Me.TpInicial.Text = "Inicial"
        '
        'ShPanel2
        '
        Me.ShPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ShPanel2.BackColor = System.Drawing.Color.Transparent
        Me.ShPanel2.Controls.Add(Me.BtnListarBkp)
        Me.ShPanel2.Controls.Add(Me.Lbl9)
        Me.ShPanel2.Controls.Add(Me.Lbl6)
        Me.ShPanel2.Controls.Add(Me.BtnDatabaseBkp)
        Me.SelectTransition.SetDecoration(Me.ShPanel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShPanel2.FillColor = System.Drawing.Color.LightGray
        Me.ShPanel2.Location = New System.Drawing.Point(307, 98)
        Me.ShPanel2.Name = "ShPanel2"
        Me.ShPanel2.Radius = 4
        Me.ShPanel2.ShadowColor = System.Drawing.Color.Black
        Me.ShPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.ShPanel2.Size = New System.Drawing.Size(166, 310)
        Me.ShPanel2.TabIndex = 115
        '
        'BtnListarBkp
        '
        Me.BtnListarBkp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnListarBkp.BorderRadius = 5
        Me.BtnListarBkp.CheckedState.Parent = Me.BtnListarBkp
        Me.BtnListarBkp.CustomImages.Parent = Me.BtnListarBkp
        Me.SelectTransition.SetDecoration(Me.BtnListarBkp, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnListarBkp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnListarBkp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnListarBkp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnListarBkp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnListarBkp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnListarBkp.DisabledState.Parent = Me.BtnListarBkp
        Me.BtnListarBkp.FillColor = System.Drawing.Color.SlateGray
        Me.BtnListarBkp.FillColor2 = System.Drawing.Color.Black
        Me.BtnListarBkp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnListarBkp.ForeColor = System.Drawing.Color.White
        Me.BtnListarBkp.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnListarBkp.HoverState.Parent = Me.BtnListarBkp
        Me.BtnListarBkp.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnListarBkp.Location = New System.Drawing.Point(27, 259)
        Me.BtnListarBkp.Name = "BtnListarBkp"
        Me.BtnListarBkp.ShadowDecoration.Parent = Me.BtnListarBkp
        Me.BtnListarBkp.Size = New System.Drawing.Size(105, 30)
        Me.BtnListarBkp.TabIndex = 95
        Me.BtnListarBkp.Text = "Listar Backups"
        '
        'Lbl9
        '
        Me.Lbl9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl9.AutoSize = False
        Me.Lbl9.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.Lbl9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Lbl9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl9.ForeColor = System.Drawing.Color.Blue
        Me.Lbl9.Location = New System.Drawing.Point(9, 105)
        Me.Lbl9.Name = "Lbl9"
        Me.Lbl9.Size = New System.Drawing.Size(138, 26)
        Me.Lbl9.TabIndex = 93
        Me.Lbl9.Text = "Backup Database"
        Me.Lbl9.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl6
        '
        Me.Lbl6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl6.AutoSize = False
        Me.Lbl6.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.Lbl6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Lbl6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl6.Location = New System.Drawing.Point(10, 146)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(142, 109)
        Me.Lbl6.TabIndex = 92
        Me.Lbl6.Text = "Clique sobre o botão para realizar um backup do banco de dados. O arquivo sera sa" &
    "lvo no servidor, para realizar o download entre em Restore."
        Me.Lbl6.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnDatabaseBkp
        '
        Me.BtnDatabaseBkp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDatabaseBkp.Animated = True
        Me.BtnDatabaseBkp.BackColor = System.Drawing.Color.Transparent
        Me.BtnDatabaseBkp.BorderRadius = 10
        Me.BtnDatabaseBkp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnDatabaseBkp.CausesValidation = False
        Me.BtnDatabaseBkp.CheckedState.Parent = Me.BtnDatabaseBkp
        Me.BtnDatabaseBkp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDatabaseBkp.CustomImages.Parent = Me.BtnDatabaseBkp
        Me.SelectTransition.SetDecoration(Me.BtnDatabaseBkp, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnDatabaseBkp.DisabledState.Parent = Me.BtnDatabaseBkp
        Me.BtnDatabaseBkp.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnDatabaseBkp.FillColor2 = System.Drawing.Color.Black
        Me.BtnDatabaseBkp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDatabaseBkp.ForeColor = System.Drawing.Color.White
        Me.BtnDatabaseBkp.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnDatabaseBkp.HoverState.Parent = Me.BtnDatabaseBkp
        Me.BtnDatabaseBkp.Image = CType(resources.GetObject("BtnDatabaseBkp.Image"), System.Drawing.Image)
        Me.BtnDatabaseBkp.ImageOffset = New System.Drawing.Point(1, 0)
        Me.BtnDatabaseBkp.ImageSize = New System.Drawing.Size(58, 58)
        Me.BtnDatabaseBkp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDatabaseBkp.Location = New System.Drawing.Point(35, 16)
        Me.BtnDatabaseBkp.Name = "BtnDatabaseBkp"
        Me.BtnDatabaseBkp.ShadowDecoration.Parent = Me.BtnDatabaseBkp
        Me.BtnDatabaseBkp.Size = New System.Drawing.Size(85, 85)
        Me.BtnDatabaseBkp.TabIndex = 87
        '
        'ShPanel1
        '
        Me.ShPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ShPanel1.BackColor = System.Drawing.Color.Transparent
        Me.ShPanel1.Controls.Add(Me.BtnSystemRestore)
        Me.ShPanel1.Controls.Add(Me.Lbl8)
        Me.ShPanel1.Controls.Add(Me.Lbl5)
        Me.ShPanel1.Controls.Add(Me.BtnSystemBkp)
        Me.SelectTransition.SetDecoration(Me.ShPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShPanel1.FillColor = System.Drawing.Color.LightGray
        Me.ShPanel1.Location = New System.Drawing.Point(89, 97)
        Me.ShPanel1.Name = "ShPanel1"
        Me.ShPanel1.Radius = 4
        Me.ShPanel1.ShadowColor = System.Drawing.Color.Black
        Me.ShPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.ShPanel1.Size = New System.Drawing.Size(166, 310)
        Me.ShPanel1.TabIndex = 114
        '
        'BtnSystemRestore
        '
        Me.BtnSystemRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSystemRestore.BorderRadius = 5
        Me.BtnSystemRestore.CheckedState.Parent = Me.BtnSystemRestore
        Me.BtnSystemRestore.CustomImages.Parent = Me.BtnSystemRestore
        Me.SelectTransition.SetDecoration(Me.BtnSystemRestore, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnSystemRestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSystemRestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSystemRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSystemRestore.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSystemRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSystemRestore.DisabledState.Parent = Me.BtnSystemRestore
        Me.BtnSystemRestore.FillColor = System.Drawing.Color.SlateGray
        Me.BtnSystemRestore.FillColor2 = System.Drawing.Color.Black
        Me.BtnSystemRestore.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSystemRestore.ForeColor = System.Drawing.Color.White
        Me.BtnSystemRestore.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnSystemRestore.HoverState.Parent = Me.BtnSystemRestore
        Me.BtnSystemRestore.ImageSize = New System.Drawing.Size(12, 12)
        Me.BtnSystemRestore.Location = New System.Drawing.Point(27, 258)
        Me.BtnSystemRestore.Name = "BtnSystemRestore"
        Me.BtnSystemRestore.ShadowDecoration.Parent = Me.BtnSystemRestore
        Me.BtnSystemRestore.Size = New System.Drawing.Size(105, 30)
        Me.BtnSystemRestore.TabIndex = 94
        Me.BtnSystemRestore.Text = "Restore"
        '
        'Lbl8
        '
        Me.Lbl8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl8.AutoSize = False
        Me.Lbl8.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.Lbl8, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Lbl8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl8.ForeColor = System.Drawing.Color.Blue
        Me.Lbl8.Location = New System.Drawing.Point(0, 105)
        Me.Lbl8.Name = "Lbl8"
        Me.Lbl8.Size = New System.Drawing.Size(163, 26)
        Me.Lbl8.TabIndex = 93
        Me.Lbl8.Text = "Backup do sistema"
        Me.Lbl8.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl5
        '
        Me.Lbl5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl5.AutoSize = False
        Me.Lbl5.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.Lbl5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Lbl5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl5.Location = New System.Drawing.Point(10, 146)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(142, 96)
        Me.Lbl5.TabIndex = 92
        Me.Lbl5.Text = "Clique sobre o botão para realizar um backup do sistema. O arquivo sera salvo no " &
    "servidor, para realizar o download entre em Restore."
        Me.Lbl5.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnSystemBkp
        '
        Me.BtnSystemBkp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSystemBkp.Animated = True
        Me.BtnSystemBkp.BackColor = System.Drawing.Color.Transparent
        Me.BtnSystemBkp.BorderRadius = 10
        Me.BtnSystemBkp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnSystemBkp.CausesValidation = False
        Me.BtnSystemBkp.CheckedState.Parent = Me.BtnSystemBkp
        Me.BtnSystemBkp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSystemBkp.CustomImages.Parent = Me.BtnSystemBkp
        Me.SelectTransition.SetDecoration(Me.BtnSystemBkp, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnSystemBkp.DisabledState.Parent = Me.BtnSystemBkp
        Me.BtnSystemBkp.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnSystemBkp.FillColor2 = System.Drawing.Color.Black
        Me.BtnSystemBkp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSystemBkp.ForeColor = System.Drawing.Color.White
        Me.BtnSystemBkp.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnSystemBkp.HoverState.Parent = Me.BtnSystemBkp
        Me.BtnSystemBkp.Image = CType(resources.GetObject("BtnSystemBkp.Image"), System.Drawing.Image)
        Me.BtnSystemBkp.ImageOffset = New System.Drawing.Point(1, -2)
        Me.BtnSystemBkp.ImageSize = New System.Drawing.Size(110, 120)
        Me.BtnSystemBkp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSystemBkp.Location = New System.Drawing.Point(35, 16)
        Me.BtnSystemBkp.Name = "BtnSystemBkp"
        Me.BtnSystemBkp.ShadowDecoration.Parent = Me.BtnSystemBkp
        Me.BtnSystemBkp.Size = New System.Drawing.Size(85, 85)
        Me.BtnSystemBkp.TabIndex = 87
        '
        'ShPanel3
        '
        Me.ShPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ShPanel3.BackColor = System.Drawing.Color.Transparent
        Me.ShPanel3.Controls.Add(Me.Lbl10)
        Me.ShPanel3.Controls.Add(Me.Lbl7)
        Me.ShPanel3.Controls.Add(Me.BtnDatabaseConfig)
        Me.SelectTransition.SetDecoration(Me.ShPanel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShPanel3.FillColor = System.Drawing.Color.LightGray
        Me.ShPanel3.Location = New System.Drawing.Point(525, 98)
        Me.ShPanel3.Name = "ShPanel3"
        Me.ShPanel3.Radius = 4
        Me.ShPanel3.ShadowColor = System.Drawing.Color.Black
        Me.ShPanel3.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.ShPanel3.Size = New System.Drawing.Size(166, 310)
        Me.ShPanel3.TabIndex = 113
        '
        'Lbl10
        '
        Me.Lbl10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl10.AutoSize = False
        Me.Lbl10.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.Lbl10, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Lbl10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl10.ForeColor = System.Drawing.Color.Blue
        Me.Lbl10.Location = New System.Drawing.Point(9, 105)
        Me.Lbl10.Name = "Lbl10"
        Me.Lbl10.Size = New System.Drawing.Size(138, 26)
        Me.Lbl10.TabIndex = 93
        Me.Lbl10.Text = "Database Config"
        Me.Lbl10.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl7
        '
        Me.Lbl7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl7.AutoSize = False
        Me.Lbl7.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.Lbl7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Lbl7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl7.Location = New System.Drawing.Point(10, 146)
        Me.Lbl7.Name = "Lbl7"
        Me.Lbl7.Size = New System.Drawing.Size(142, 143)
        Me.Lbl7.TabIndex = 92
        Me.Lbl7.Text = "Clique sobre o botão para ir na pagina de configuração do Banco de Dados. O softw" &
    "are vem configurado com acesso ao banco de dados local."
        Me.Lbl7.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnDatabaseConfig
        '
        Me.BtnDatabaseConfig.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDatabaseConfig.Animated = True
        Me.BtnDatabaseConfig.BackColor = System.Drawing.Color.Transparent
        Me.BtnDatabaseConfig.BorderRadius = 10
        Me.BtnDatabaseConfig.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnDatabaseConfig.CausesValidation = False
        Me.BtnDatabaseConfig.CheckedState.Parent = Me.BtnDatabaseConfig
        Me.BtnDatabaseConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDatabaseConfig.CustomImages.Parent = Me.BtnDatabaseConfig
        Me.SelectTransition.SetDecoration(Me.BtnDatabaseConfig, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnDatabaseConfig.DisabledState.Parent = Me.BtnDatabaseConfig
        Me.BtnDatabaseConfig.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnDatabaseConfig.FillColor2 = System.Drawing.Color.Black
        Me.BtnDatabaseConfig.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDatabaseConfig.ForeColor = System.Drawing.Color.White
        Me.BtnDatabaseConfig.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.BtnDatabaseConfig.HoverState.Parent = Me.BtnDatabaseConfig
        Me.BtnDatabaseConfig.Image = CType(resources.GetObject("BtnDatabaseConfig.Image"), System.Drawing.Image)
        Me.BtnDatabaseConfig.ImageOffset = New System.Drawing.Point(1, 0)
        Me.BtnDatabaseConfig.ImageSize = New System.Drawing.Size(58, 58)
        Me.BtnDatabaseConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDatabaseConfig.Location = New System.Drawing.Point(35, 16)
        Me.BtnDatabaseConfig.Name = "BtnDatabaseConfig"
        Me.BtnDatabaseConfig.ShadowDecoration.Parent = Me.BtnDatabaseConfig
        Me.BtnDatabaseConfig.Size = New System.Drawing.Size(85, 85)
        Me.BtnDatabaseConfig.TabIndex = 87
        '
        'Lbl1
        '
        Me.Lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl1.AutoSize = False
        Me.Lbl1.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.Lbl1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Lbl1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl1.Location = New System.Drawing.Point(23, 0)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(734, 76)
        Me.Lbl1.TabIndex = 112
        Me.Lbl1.Text = resources.GetString("Lbl1.Text")
        Me.Lbl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
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
        'TpBackups
        '
        Me.TpBackups.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpBackups.Controls.Add(Me.Tpl1)
        Me.SelectTransition.SetDecoration(Me.TpBackups, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TpBackups.Location = New System.Drawing.Point(4, 4)
        Me.TpBackups.Name = "TpBackups"
        Me.TpBackups.Padding = New System.Windows.Forms.Padding(3)
        Me.TpBackups.Size = New System.Drawing.Size(780, 524)
        Me.TpBackups.TabIndex = 3
        Me.TpBackups.Text = "Backup Database"
        '
        'Tpl1
        '
        Me.Tpl1.ColumnCount = 3
        Me.Tpl1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.Tpl1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tpl1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.Tpl1.Controls.Add(Me.Panel1, 1, 1)
        Me.Tpl1.Controls.Add(Me.Guna2Panel1, 1, 2)
        Me.SelectTransition.SetDecoration(Me.Tpl1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Tpl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tpl1.Location = New System.Drawing.Point(3, 3)
        Me.Tpl1.Name = "Tpl1"
        Me.Tpl1.RowCount = 4
        Me.Tpl1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.Tpl1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.Tpl1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tpl1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.Tpl1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Tpl1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Tpl1.Size = New System.Drawing.Size(774, 518)
        Me.Tpl1.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.BtnUploadBkp)
        Me.SelectTransition.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(28, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 68)
        Me.Panel1.TabIndex = 8
        '
        'BtnUploadBkp
        '
        Me.BtnUploadBkp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnUploadBkp.BorderRadius = 5
        Me.BtnUploadBkp.CheckedState.Parent = Me.BtnUploadBkp
        Me.BtnUploadBkp.CustomImages.Parent = Me.BtnUploadBkp
        Me.SelectTransition.SetDecoration(Me.BtnUploadBkp, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnUploadBkp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUploadBkp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUploadBkp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUploadBkp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUploadBkp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUploadBkp.DisabledState.Parent = Me.BtnUploadBkp
        Me.BtnUploadBkp.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnUploadBkp.FillColor2 = System.Drawing.Color.Black
        Me.BtnUploadBkp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUploadBkp.ForeColor = System.Drawing.Color.White
        Me.BtnUploadBkp.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnUploadBkp.HoverState.Parent = Me.BtnUploadBkp
        Me.BtnUploadBkp.Image = CType(resources.GetObject("BtnUploadBkp.Image"), System.Drawing.Image)
        Me.BtnUploadBkp.ImageSize = New System.Drawing.Size(18, 18)
        Me.BtnUploadBkp.Location = New System.Drawing.Point(5, 29)
        Me.BtnUploadBkp.Name = "BtnUploadBkp"
        Me.BtnUploadBkp.ShadowDecoration.Parent = Me.BtnUploadBkp
        Me.BtnUploadBkp.Size = New System.Drawing.Size(162, 35)
        Me.BtnUploadBkp.TabIndex = 9
        Me.BtnUploadBkp.Text = "Carregar Arquivos"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.DgvBackup)
        Me.Guna2Panel1.Controls.Add(Me.PanelPaginacao)
        Me.SelectTransition.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(28, 107)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(718, 378)
        Me.Guna2Panel1.TabIndex = 10
        '
        'DgvBackup
        '
        Me.DgvBackup.AllowUserToAddRows = False
        Me.DgvBackup.AllowUserToDeleteRows = False
        Me.DgvBackup.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvBackup.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvBackup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvBackup.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DgvBackup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvBackup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvBackup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBackup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvBackup.ColumnHeadersHeight = 40
        Me.DgvBackup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvColumnSelect})
        Me.SelectTransition.SetDecoration(Me.DgvBackup, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvBackup.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvBackup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvBackup.EnableHeadersVisualStyles = False
        Me.DgvBackup.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DgvBackup.Location = New System.Drawing.Point(0, 0)
        Me.DgvBackup.Name = "DgvBackup"
        Me.DgvBackup.ReadOnly = True
        Me.DgvBackup.RowHeadersVisible = False
        Me.DgvBackup.RowTemplate.Height = 40
        Me.DgvBackup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBackup.Size = New System.Drawing.Size(718, 337)
        Me.DgvBackup.TabIndex = 235
        Me.DgvBackup.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvBackup.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvBackup.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvBackup.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvBackup.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvBackup.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvBackup.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DgvBackup.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvBackup.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvBackup.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvBackup.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvBackup.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvBackup.ThemeStyle.HeaderStyle.Height = 40
        Me.DgvBackup.ThemeStyle.ReadOnly = True
        Me.DgvBackup.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvBackup.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvBackup.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvBackup.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvBackup.ThemeStyle.RowsStyle.Height = 40
        Me.DgvBackup.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvBackup.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DgvColumnSelect
        '
        Me.DgvColumnSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DgvColumnSelect.DataPropertyName = "DgvColumnSelect"
        Me.DgvColumnSelect.HeaderText = ""
        Me.DgvColumnSelect.MinimumWidth = 50
        Me.DgvColumnSelect.Name = "DgvColumnSelect"
        Me.DgvColumnSelect.ReadOnly = True
        Me.DgvColumnSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvColumnSelect.Visible = False
        Me.DgvColumnSelect.Width = 50
        '
        'PanelPaginacao
        '
        Me.PanelPaginacao.Controls.Add(Me.LblSelectRegister)
        Me.PanelPaginacao.Controls.Add(Me.LblPaginacao)
        Me.PanelPaginacao.Controls.Add(Me.BtnVoltarMenu)
        Me.SelectTransition.SetDecoration(Me.PanelPaginacao, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelPaginacao.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPaginacao.Location = New System.Drawing.Point(0, 337)
        Me.PanelPaginacao.Name = "PanelPaginacao"
        Me.PanelPaginacao.ShadowDecoration.Parent = Me.PanelPaginacao
        Me.PanelPaginacao.Size = New System.Drawing.Size(718, 41)
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
        Me.LblPaginacao.Location = New System.Drawing.Point(353, 10)
        Me.LblPaginacao.Name = "LblPaginacao"
        Me.LblPaginacao.Size = New System.Drawing.Size(12, 15)
        Me.LblPaginacao.TabIndex = 5
        Me.LblPaginacao.Text = "..."
        Me.LblPaginacao.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnVoltarMenu
        '
        Me.BtnVoltarMenu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnVoltarMenu.AutoRoundedCorners = True
        Me.BtnVoltarMenu.BorderRadius = 15
        Me.BtnVoltarMenu.CheckedState.Parent = Me.BtnVoltarMenu
        Me.BtnVoltarMenu.CustomImages.Parent = Me.BtnVoltarMenu
        Me.SelectTransition.SetDecoration(Me.BtnVoltarMenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnVoltarMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnVoltarMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnVoltarMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnVoltarMenu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnVoltarMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnVoltarMenu.DisabledState.Parent = Me.BtnVoltarMenu
        Me.BtnVoltarMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnVoltarMenu.FillColor2 = System.Drawing.Color.Black
        Me.BtnVoltarMenu.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltarMenu.ForeColor = System.Drawing.Color.White
        Me.BtnVoltarMenu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnVoltarMenu.HoverState.Parent = Me.BtnVoltarMenu
        Me.BtnVoltarMenu.ImageSize = New System.Drawing.Size(18, 18)
        Me.BtnVoltarMenu.Location = New System.Drawing.Point(593, 4)
        Me.BtnVoltarMenu.Name = "BtnVoltarMenu"
        Me.BtnVoltarMenu.ShadowDecoration.Parent = Me.BtnVoltarMenu
        Me.BtnVoltarMenu.Size = New System.Drawing.Size(124, 33)
        Me.BtnVoltarMenu.TabIndex = 10
        Me.BtnVoltarMenu.Text = "Voltar ao Menu"
        '
        'TpServerConfig
        '
        Me.TpServerConfig.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpServerConfig.Controls.Add(Me.LblBDAviso)
        Me.TpServerConfig.Controls.Add(Me.BtnDefault)
        Me.TpServerConfig.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.TpServerConfig.Controls.Add(Me.BtnConnect)
        Me.TpServerConfig.Controls.Add(Me.LblPorta)
        Me.TpServerConfig.Controls.Add(Me.LblServidor)
        Me.TpServerConfig.Controls.Add(Me.BtnCancelar)
        Me.TpServerConfig.Controls.Add(Me.BtnSalvar)
        Me.TpServerConfig.Controls.Add(Me.TxtPorta)
        Me.TpServerConfig.Controls.Add(Me.TxtServidor)
        Me.TpServerConfig.Controls.Add(Me.LblSenha)
        Me.TpServerConfig.Controls.Add(Me.LblUsuario)
        Me.TpServerConfig.Controls.Add(Me.TxtSenha)
        Me.TpServerConfig.Controls.Add(Me.TxtUsuario)
        Me.TpServerConfig.Controls.Add(Me.LblBanco)
        Me.TpServerConfig.Controls.Add(Me.TxtBanco)
        Me.SelectTransition.SetDecoration(Me.TpServerConfig, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TpServerConfig.Location = New System.Drawing.Point(4, 4)
        Me.TpServerConfig.Name = "TpServerConfig"
        Me.TpServerConfig.Padding = New System.Windows.Forms.Padding(3)
        Me.TpServerConfig.Size = New System.Drawing.Size(780, 524)
        Me.TpServerConfig.TabIndex = 2
        Me.TpServerConfig.Text = "Configuração do servidor"
        '
        'LblBDAviso
        '
        Me.LblBDAviso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblBDAviso.AutoSize = False
        Me.LblBDAviso.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.LblBDAviso, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblBDAviso.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBDAviso.ForeColor = System.Drawing.Color.DimGray
        Me.LblBDAviso.Location = New System.Drawing.Point(196, 9)
        Me.LblBDAviso.Name = "LblBDAviso"
        Me.LblBDAviso.Size = New System.Drawing.Size(391, 73)
        Me.LblBDAviso.TabIndex = 178
        Me.LblBDAviso.Text = "..."
        Me.LblBDAviso.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnDefault
        '
        Me.BtnDefault.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnDefault.Animated = True
        Me.BtnDefault.AutoRoundedCorners = True
        Me.BtnDefault.BackColor = System.Drawing.Color.Transparent
        Me.BtnDefault.BorderRadius = 11
        Me.BtnDefault.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnDefault.CheckedState.Parent = Me.BtnDefault
        Me.BtnDefault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDefault.CustomImages.Parent = Me.BtnDefault
        Me.SelectTransition.SetDecoration(Me.BtnDefault, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnDefault.DisabledState.Parent = Me.BtnDefault
        Me.BtnDefault.FillColor = System.Drawing.Color.SlateGray
        Me.BtnDefault.FillColor2 = System.Drawing.Color.Black
        Me.BtnDefault.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDefault.ForeColor = System.Drawing.Color.White
        Me.BtnDefault.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnDefault.HoverState.Parent = Me.BtnDefault
        Me.BtnDefault.Location = New System.Drawing.Point(0, 114)
        Me.BtnDefault.Name = "BtnDefault"
        Me.BtnDefault.ShadowDecoration.Parent = Me.BtnDefault
        Me.BtnDefault.Size = New System.Drawing.Size(100, 25)
        Me.BtnDefault.TabIndex = 177
        Me.BtnDefault.Text = "Default"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.SelectTransition.SetDecoration(Me.Guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(131, 82)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 176
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'BtnConnect
        '
        Me.BtnConnect.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnConnect.Animated = True
        Me.BtnConnect.AutoRoundedCorners = True
        Me.BtnConnect.BackColor = System.Drawing.Color.Transparent
        Me.BtnConnect.BorderRadius = 11
        Me.BtnConnect.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnConnect.CheckedState.Parent = Me.BtnConnect
        Me.BtnConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConnect.CustomImages.Parent = Me.BtnConnect
        Me.SelectTransition.SetDecoration(Me.BtnConnect, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnConnect.DisabledState.Parent = Me.BtnConnect
        Me.BtnConnect.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnConnect.FillColor2 = System.Drawing.Color.Black
        Me.BtnConnect.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConnect.ForeColor = System.Drawing.Color.White
        Me.BtnConnect.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnConnect.HoverState.Parent = Me.BtnConnect
        Me.BtnConnect.Location = New System.Drawing.Point(0, 86)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.ShadowDecoration.Parent = Me.BtnConnect
        Me.BtnConnect.Size = New System.Drawing.Size(100, 25)
        Me.BtnConnect.TabIndex = 170
        Me.BtnConnect.Text = "Connect"
        '
        'LblPorta
        '
        Me.LblPorta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblPorta.AutoSize = True
        Me.SelectTransition.SetDecoration(Me.LblPorta, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblPorta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblPorta.ForeColor = System.Drawing.Color.Black
        Me.LblPorta.Location = New System.Drawing.Point(457, 155)
        Me.LblPorta.Name = "LblPorta"
        Me.LblPorta.Size = New System.Drawing.Size(35, 15)
        Me.LblPorta.TabIndex = 172
        Me.LblPorta.Text = "Porta"
        Me.LblPorta.Visible = False
        '
        'LblServidor
        '
        Me.LblServidor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblServidor.AutoSize = True
        Me.SelectTransition.SetDecoration(Me.LblServidor, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblServidor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblServidor.ForeColor = System.Drawing.Color.Black
        Me.LblServidor.Location = New System.Drawing.Point(187, 155)
        Me.LblServidor.Name = "LblServidor"
        Me.LblServidor.Size = New System.Drawing.Size(50, 15)
        Me.LblServidor.TabIndex = 171
        Me.LblServidor.Text = "Servidor"
        Me.LblServidor.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancelar.Animated = True
        Me.BtnCancelar.AutoRoundedCorners = True
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BorderRadius = 18
        Me.BtnCancelar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnCancelar.CausesValidation = False
        Me.BtnCancelar.CheckedState.Parent = Me.BtnCancelar
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.CustomImages.Parent = Me.BtnCancelar
        Me.SelectTransition.SetDecoration(Me.BtnCancelar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtnCancelar.DisabledState.Parent = Me.BtnCancelar
        Me.BtnCancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnCancelar.FillColor2 = System.Drawing.Color.Black
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnCancelar.HoverState.Parent = Me.BtnCancelar
        Me.BtnCancelar.Location = New System.Drawing.Point(264, 423)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.ShadowDecoration.Parent = Me.BtnCancelar
        Me.BtnCancelar.Size = New System.Drawing.Size(124, 38)
        Me.BtnCancelar.TabIndex = 169
        Me.BtnCancelar.Text = "CANCELAR"
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSalvar.Animated = True
        Me.BtnSalvar.AutoRoundedCorners = True
        Me.BtnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.BorderRadius = 18
        Me.BtnSalvar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
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
        Me.BtnSalvar.Location = New System.Drawing.Point(395, 423)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.ShadowDecoration.Parent = Me.BtnSalvar
        Me.BtnSalvar.Size = New System.Drawing.Size(124, 38)
        Me.BtnSalvar.TabIndex = 168
        Me.BtnSalvar.Text = "SALVAR"
        '
        'TxtPorta
        '
        Me.TxtPorta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtPorta.Animated = True
        Me.TxtPorta.BackColor = System.Drawing.Color.Transparent
        Me.TxtPorta.BorderColor = System.Drawing.Color.Gray
        Me.TxtPorta.BorderRadius = 7
        Me.TxtPorta.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtPorta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SelectTransition.SetDecoration(Me.TxtPorta, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TxtPorta.DefaultText = ""
        Me.TxtPorta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPorta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPorta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPorta.DisabledState.Parent = Me.TxtPorta
        Me.TxtPorta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPorta.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtPorta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtPorta.FocusedState.Parent = Me.TxtPorta
        Me.TxtPorta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPorta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtPorta.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtPorta.HoverState.Parent = Me.TxtPorta
        Me.TxtPorta.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtPorta.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtPorta.Location = New System.Drawing.Point(460, 173)
        Me.TxtPorta.Name = "TxtPorta"
        Me.TxtPorta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPorta.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TxtPorta.PlaceholderText = "Porta"
        Me.TxtPorta.SelectedText = ""
        Me.TxtPorta.ShadowDecoration.Parent = Me.TxtPorta
        Me.TxtPorta.Size = New System.Drawing.Size(134, 36)
        Me.TxtPorta.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtPorta.TabIndex = 164
        Me.TxtPorta.TextOffset = New System.Drawing.Point(5, 0)
        '
        'TxtServidor
        '
        Me.TxtServidor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtServidor.Animated = True
        Me.TxtServidor.BackColor = System.Drawing.Color.Transparent
        Me.TxtServidor.BorderColor = System.Drawing.Color.Gray
        Me.TxtServidor.BorderRadius = 7
        Me.TxtServidor.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtServidor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SelectTransition.SetDecoration(Me.TxtServidor, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TxtServidor.DefaultText = ""
        Me.TxtServidor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtServidor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtServidor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtServidor.DisabledState.Parent = Me.TxtServidor
        Me.TxtServidor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtServidor.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtServidor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtServidor.FocusedState.Parent = Me.TxtServidor
        Me.TxtServidor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtServidor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtServidor.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtServidor.HoverState.Parent = Me.TxtServidor
        Me.TxtServidor.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtServidor.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtServidor.Location = New System.Drawing.Point(190, 173)
        Me.TxtServidor.Name = "TxtServidor"
        Me.TxtServidor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtServidor.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TxtServidor.PlaceholderText = "Servidor"
        Me.TxtServidor.SelectedText = ""
        Me.TxtServidor.ShadowDecoration.Parent = Me.TxtServidor
        Me.TxtServidor.Size = New System.Drawing.Size(264, 36)
        Me.TxtServidor.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtServidor.TabIndex = 163
        Me.TxtServidor.TextOffset = New System.Drawing.Point(5, 0)
        '
        'LblSenha
        '
        Me.LblSenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblSenha.AutoSize = True
        Me.SelectTransition.SetDecoration(Me.LblSenha, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblSenha.ForeColor = System.Drawing.Color.Black
        Me.LblSenha.Location = New System.Drawing.Point(328, 301)
        Me.LblSenha.Name = "LblSenha"
        Me.LblSenha.Size = New System.Drawing.Size(39, 15)
        Me.LblSenha.TabIndex = 175
        Me.LblSenha.Text = "Senha"
        Me.LblSenha.Visible = False
        '
        'LblUsuario
        '
        Me.LblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblUsuario.AutoSize = True
        Me.SelectTransition.SetDecoration(Me.LblUsuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblUsuario.ForeColor = System.Drawing.Color.Black
        Me.LblUsuario.Location = New System.Drawing.Point(187, 301)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(47, 15)
        Me.LblUsuario.TabIndex = 174
        Me.LblUsuario.Text = "Usuário"
        Me.LblUsuario.Visible = False
        '
        'TxtSenha
        '
        Me.TxtSenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSenha.Animated = True
        Me.TxtSenha.BackColor = System.Drawing.Color.Transparent
        Me.TxtSenha.BorderColor = System.Drawing.Color.Gray
        Me.TxtSenha.BorderRadius = 7
        Me.TxtSenha.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SelectTransition.SetDecoration(Me.TxtSenha, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TxtSenha.DefaultText = ""
        Me.TxtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSenha.DisabledState.Parent = Me.TxtSenha
        Me.TxtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSenha.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtSenha.FocusedState.Parent = Me.TxtSenha
        Me.TxtSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtSenha.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtSenha.HoverState.Parent = Me.TxtSenha
        Me.TxtSenha.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtSenha.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtSenha.Location = New System.Drawing.Point(331, 320)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSenha.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TxtSenha.PlaceholderText = "Senha"
        Me.TxtSenha.SelectedText = ""
        Me.TxtSenha.ShadowDecoration.Parent = Me.TxtSenha
        Me.TxtSenha.Size = New System.Drawing.Size(263, 36)
        Me.TxtSenha.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtSenha.TabIndex = 167
        Me.TxtSenha.TextOffset = New System.Drawing.Point(5, 0)
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtUsuario.Animated = True
        Me.TxtUsuario.BackColor = System.Drawing.Color.Transparent
        Me.TxtUsuario.BorderColor = System.Drawing.Color.Gray
        Me.TxtUsuario.BorderRadius = 7
        Me.TxtUsuario.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SelectTransition.SetDecoration(Me.TxtUsuario, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TxtUsuario.DefaultText = ""
        Me.TxtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsuario.DisabledState.Parent = Me.TxtUsuario
        Me.TxtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsuario.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtUsuario.FocusedState.Parent = Me.TxtUsuario
        Me.TxtUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtUsuario.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtUsuario.HoverState.Parent = Me.TxtUsuario
        Me.TxtUsuario.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtUsuario.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtUsuario.Location = New System.Drawing.Point(190, 320)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUsuario.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TxtUsuario.PlaceholderText = "Usuário"
        Me.TxtUsuario.SelectedText = ""
        Me.TxtUsuario.ShadowDecoration.Parent = Me.TxtUsuario
        Me.TxtUsuario.Size = New System.Drawing.Size(135, 36)
        Me.TxtUsuario.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtUsuario.TabIndex = 166
        Me.TxtUsuario.TextOffset = New System.Drawing.Point(5, 0)
        '
        'LblBanco
        '
        Me.LblBanco.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblBanco.AutoSize = True
        Me.SelectTransition.SetDecoration(Me.LblBanco, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblBanco.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblBanco.ForeColor = System.Drawing.Color.Black
        Me.LblBanco.Location = New System.Drawing.Point(187, 227)
        Me.LblBanco.Name = "LblBanco"
        Me.LblBanco.Size = New System.Drawing.Size(40, 15)
        Me.LblBanco.TabIndex = 173
        Me.LblBanco.Text = "Banco"
        Me.LblBanco.Visible = False
        '
        'TxtBanco
        '
        Me.TxtBanco.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtBanco.Animated = True
        Me.TxtBanco.BackColor = System.Drawing.Color.Transparent
        Me.TxtBanco.BorderColor = System.Drawing.Color.Gray
        Me.TxtBanco.BorderRadius = 7
        Me.TxtBanco.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtBanco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SelectTransition.SetDecoration(Me.TxtBanco, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TxtBanco.DefaultText = "Banco"
        Me.TxtBanco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBanco.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBanco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBanco.DisabledState.Parent = Me.TxtBanco
        Me.TxtBanco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBanco.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtBanco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtBanco.FocusedState.Parent = Me.TxtBanco
        Me.TxtBanco.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBanco.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtBanco.HoverState.Parent = Me.TxtBanco
        Me.TxtBanco.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtBanco.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtBanco.Location = New System.Drawing.Point(190, 245)
        Me.TxtBanco.Name = "TxtBanco"
        Me.TxtBanco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBanco.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TxtBanco.PlaceholderText = "Chave SSH"
        Me.TxtBanco.SelectedText = ""
        Me.TxtBanco.SelectionStart = 5
        Me.TxtBanco.ShadowDecoration.Parent = Me.TxtBanco
        Me.TxtBanco.Size = New System.Drawing.Size(404, 36)
        Me.TxtBanco.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtBanco.TabIndex = 165
        Me.TxtBanco.TextOffset = New System.Drawing.Point(5, 0)
        '
        'TpAguarde
        '
        Me.TpAguarde.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpAguarde.Controls.Add(Me.ProgressAguarde)
        Me.TpAguarde.Controls.Add(Me.LblAguarde)
        Me.SelectTransition.SetDecoration(Me.TpAguarde, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TpAguarde.Location = New System.Drawing.Point(4, 4)
        Me.TpAguarde.Name = "TpAguarde"
        Me.TpAguarde.Padding = New System.Windows.Forms.Padding(3)
        Me.TpAguarde.Size = New System.Drawing.Size(780, 524)
        Me.TpAguarde.TabIndex = 0
        Me.TpAguarde.Text = "Aguarde"
        '
        'ProgressAguarde
        '
        Me.ProgressAguarde.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressAguarde.BackColor = System.Drawing.Color.Transparent
        Me.ProgressAguarde.BorderRadius = 4
        Me.SelectTransition.SetDecoration(Me.ProgressAguarde, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ProgressAguarde.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProgressAguarde.Location = New System.Drawing.Point(100, 193)
        Me.ProgressAguarde.Name = "ProgressAguarde"
        Me.ProgressAguarde.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ProgressAguarde.ProgressColor2 = System.Drawing.Color.Black
        Me.ProgressAguarde.ShadowDecoration.Parent = Me.ProgressAguarde
        Me.ProgressAguarde.Size = New System.Drawing.Size(580, 20)
        Me.ProgressAguarde.TabIndex = 199
        Me.ProgressAguarde.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.ProgressAguarde.Value = 80
        '
        'LblAguarde
        '
        Me.LblAguarde.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblAguarde.AutoSize = False
        Me.LblAguarde.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SelectTransition.SetDecoration(Me.LblAguarde, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblAguarde.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAguarde.ForeColor = System.Drawing.Color.Black
        Me.LblAguarde.Location = New System.Drawing.Point(140, 236)
        Me.LblAguarde.Name = "LblAguarde"
        Me.LblAguarde.Size = New System.Drawing.Size(501, 160)
        Me.LblAguarde.TabIndex = 198
        Me.LblAguarde.Text = "..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LblAguarde.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'TimerDatabaseDefault
        '
        '
        'TimerDatabaseRestore
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 95
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Column2"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 98
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Column3"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 98
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Column1"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 76
        '
        'FrmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(788, 565)
        Me.Controls.Add(Me.TabControlBackup)
        Me.Controls.Add(Me.PanelSelect)
        Me.SelectTransition.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBackup"
        Me.Text = "FrmBackup"
        Me.PanelSelect.ResumeLayout(False)
        Me.PanelSelect.PerformLayout()
        Me.TabControlBackup.ResumeLayout(False)
        Me.TpInicial.ResumeLayout(False)
        Me.ShPanel2.ResumeLayout(False)
        Me.ShPanel1.ResumeLayout(False)
        Me.ShPanel3.ResumeLayout(False)
        Me.TpBackups.ResumeLayout(False)
        Me.Tpl1.ResumeLayout(False)
        Me.Tpl1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.DgvBackup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPaginacao.ResumeLayout(False)
        Me.PanelPaginacao.PerformLayout()
        Me.TpServerConfig.ResumeLayout(False)
        Me.TpServerConfig.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpAguarde.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSelect As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents BtnSelectFechar As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents BtnSelectApagar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnDownloadBkp As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LblSelect As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnRestoreBkp As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Ofd As OpenFileDialog
    Friend WithEvents TimerDatabaseConfig As Timer
    Friend WithEvents TimerSystemBkp As Timer
    Friend WithEvents TimerDatabaseBkp As Timer
    Friend WithEvents TimerSystemRestore As Timer
    Friend WithEvents TimerDatabaseDownload As Timer
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents SelectTransition As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents TimerDatabaseDefault As Timer
    Friend WithEvents Fbd As FolderBrowserDialog
    Friend WithEvents TabControlBackup As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TpAguarde As TabPage
    Friend WithEvents TpInicial As TabPage
    Friend WithEvents TpServerConfig As TabPage
    Friend WithEvents ShPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents BtnListarBkp As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Lbl9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnDatabaseBkp As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ShPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents BtnSystemRestore As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Lbl8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnSystemBkp As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ShPanel3 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Lbl10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnDatabaseConfig As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Lbl1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Lbl2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TpBackups As TabPage
    Friend WithEvents Tpl1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnUploadBkp As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PanelPaginacao As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblSelectRegister As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblPaginacao As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnVoltarMenu As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LblBDAviso As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnDefault As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents BtnConnect As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LblPorta As Label
    Friend WithEvents LblServidor As Label
    Friend WithEvents BtnCancelar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnSalvar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TxtPorta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtServidor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblSenha As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents TxtSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblBanco As Label
    Friend WithEvents TxtBanco As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProgressAguarde As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents LblAguarde As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents TimerDatabaseRestore As Timer
    Friend WithEvents DgvBackup As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DgvColumnSelect As DataGridViewCheckBoxColumn
End Class
