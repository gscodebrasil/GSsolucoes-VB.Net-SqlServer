<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArquivos
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
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArquivos))
        Me.TabControlServidorSFTP = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TpInicial = New System.Windows.Forms.TabPage()
        Me.LblContato = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnPhonebook = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnHelpdesk = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEstoque = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnFinanceiro = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnHome = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LblInfoServidor = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TpGSHome = New System.Windows.Forms.TabPage()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblChaveSSH = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.TxtChaveSSH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblDirBkpSistema = New System.Windows.Forms.Label()
        Me.LblServidor = New System.Windows.Forms.Label()
        Me.TxtDirBkpSistema = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnCencelarGSHome = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LblDirBkpBD = New System.Windows.Forms.Label()
        Me.BtnSalvarGSHome = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TxtDirBkpBD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblPorta = New System.Windows.Forms.Label()
        Me.TxtSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.TxtPorta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblSenha = New System.Windows.Forms.Label()
        Me.TxtServidor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TpPhonebook = New System.Windows.Forms.TabPage()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblParceiro = New System.Windows.Forms.Label()
        Me.TxtParceiro = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnSalvarPhonebook = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnCancelarPhonebook = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LblFornecedor = New System.Windows.Forms.Label()
        Me.LblColaborador = New System.Windows.Forms.Label()
        Me.LblClientes = New System.Windows.Forms.Label()
        Me.TxtFornecedor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtColaborador = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtClientes = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TpHelpdesk = New System.Windows.Forms.TabPage()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnSalvarHelpdesk = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnCancelarHelpdesk = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LblOsRemoto = New System.Windows.Forms.Label()
        Me.LblOSExterno = New System.Windows.Forms.Label()
        Me.TxtOSRemoto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtOSExterna = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TpEstoque = New System.Windows.Forms.TabPage()
        Me.Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtSalvarEstoque = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnCancelarEstoque = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDiretorioEstoque = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TpFinanceiro = New System.Windows.Forms.TabPage()
        Me.Guna2Separator5 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnSalvarFinanceiro = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnCancelarFinanceiro = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtNFe = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtNFSe = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TpDashboard = New System.Windows.Forms.TabPage()
        Me.Guna2Separator6 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnSalvarDashboard = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnCancelarDashboard = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtFinanceiro = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtEstoque = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtPhonebook = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtHelpdesk = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabControlServidorSFTP.SuspendLayout()
        Me.TpInicial.SuspendLayout()
        Me.TpGSHome.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.TpPhonebook.SuspendLayout()
        Me.TpHelpdesk.SuspendLayout()
        Me.TpEstoque.SuspendLayout()
        Me.TpFinanceiro.SuspendLayout()
        Me.TpDashboard.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlServidorSFTP
        '
        Me.TabControlServidorSFTP.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControlServidorSFTP.Controls.Add(Me.TpInicial)
        Me.TabControlServidorSFTP.Controls.Add(Me.TpGSHome)
        Me.TabControlServidorSFTP.Controls.Add(Me.TpPhonebook)
        Me.TabControlServidorSFTP.Controls.Add(Me.TpHelpdesk)
        Me.TabControlServidorSFTP.Controls.Add(Me.TpEstoque)
        Me.TabControlServidorSFTP.Controls.Add(Me.TpFinanceiro)
        Me.TabControlServidorSFTP.Controls.Add(Me.TpDashboard)
        Me.TabControlServidorSFTP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlServidorSFTP.ItemSize = New System.Drawing.Size(70, 30)
        Me.TabControlServidorSFTP.Location = New System.Drawing.Point(0, 0)
        Me.TabControlServidorSFTP.Name = "TabControlServidorSFTP"
        Me.TabControlServidorSFTP.SelectedIndex = 0
        Me.TabControlServidorSFTP.Size = New System.Drawing.Size(772, 526)
        Me.TabControlServidorSFTP.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabControlServidorSFTP.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControlServidorSFTP.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControlServidorSFTP.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabControlServidorSFTP.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControlServidorSFTP.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabControlServidorSFTP.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControlServidorSFTP.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControlServidorSFTP.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TabControlServidorSFTP.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControlServidorSFTP.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabControlServidorSFTP.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabControlServidorSFTP.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControlServidorSFTP.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabControlServidorSFTP.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlServidorSFTP.TabButtonSize = New System.Drawing.Size(70, 30)
        Me.TabControlServidorSFTP.TabIndex = 311
        Me.TabControlServidorSFTP.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControlServidorSFTP.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalBottom
        Me.TabControlServidorSFTP.Visible = False
        '
        'TpInicial
        '
        Me.TpInicial.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpInicial.Controls.Add(Me.LblContato)
        Me.TpInicial.Controls.Add(Me.BtnPhonebook)
        Me.TpInicial.Controls.Add(Me.btnHelpdesk)
        Me.TpInicial.Controls.Add(Me.btnEstoque)
        Me.TpInicial.Controls.Add(Me.btnFinanceiro)
        Me.TpInicial.Controls.Add(Me.btnDashboard)
        Me.TpInicial.Controls.Add(Me.BtnHome)
        Me.TpInicial.Controls.Add(Me.LblInfoServidor)
        Me.TpInicial.Location = New System.Drawing.Point(4, 4)
        Me.TpInicial.Name = "TpInicial"
        Me.TpInicial.Padding = New System.Windows.Forms.Padding(3)
        Me.TpInicial.Size = New System.Drawing.Size(764, 488)
        Me.TpInicial.TabIndex = 0
        Me.TpInicial.Text = "Inicial"
        '
        'LblContato
        '
        Me.LblContato.AutoSize = False
        Me.LblContato.BackColor = System.Drawing.Color.Transparent
        Me.LblContato.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblContato.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContato.ForeColor = System.Drawing.Color.Black
        Me.LblContato.Location = New System.Drawing.Point(3, 400)
        Me.LblContato.Name = "LblContato"
        Me.LblContato.Size = New System.Drawing.Size(758, 85)
        Me.LblContato.TabIndex = 110
        Me.LblContato.Text = "<font color=DimGray>Em caso de duvidas contate nosso suporte</font><br>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<font co" &
    "lor=Blue>suporte@gscodebrasil.com.br</font>"
        Me.LblContato.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
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
        Me.BtnPhonebook.Location = New System.Drawing.Point(180, 22)
        Me.BtnPhonebook.Name = "BtnPhonebook"
        Me.BtnPhonebook.ShadowDecoration.Parent = Me.BtnPhonebook
        Me.BtnPhonebook.Size = New System.Drawing.Size(85, 85)
        Me.BtnPhonebook.TabIndex = 105
        '
        'btnHelpdesk
        '
        Me.btnHelpdesk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnHelpdesk.Animated = True
        Me.btnHelpdesk.BackColor = System.Drawing.Color.Transparent
        Me.btnHelpdesk.BorderRadius = 10
        Me.btnHelpdesk.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnHelpdesk.CausesValidation = False
        Me.btnHelpdesk.CheckedState.Parent = Me.btnHelpdesk
        Me.btnHelpdesk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelpdesk.CustomImages.Parent = Me.btnHelpdesk
        Me.btnHelpdesk.DisabledState.Parent = Me.btnHelpdesk
        Me.btnHelpdesk.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnHelpdesk.FillColor2 = System.Drawing.Color.Black
        Me.btnHelpdesk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHelpdesk.ForeColor = System.Drawing.Color.White
        Me.btnHelpdesk.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.btnHelpdesk.HoverState.Parent = Me.btnHelpdesk
        Me.btnHelpdesk.Image = CType(resources.GetObject("btnHelpdesk.Image"), System.Drawing.Image)
        Me.btnHelpdesk.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btnHelpdesk.ImageSize = New System.Drawing.Size(80, 60)
        Me.btnHelpdesk.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnHelpdesk.Location = New System.Drawing.Point(286, 22)
        Me.btnHelpdesk.Name = "btnHelpdesk"
        Me.btnHelpdesk.ShadowDecoration.Parent = Me.btnHelpdesk
        Me.btnHelpdesk.Size = New System.Drawing.Size(85, 85)
        Me.btnHelpdesk.TabIndex = 106
        '
        'btnEstoque
        '
        Me.btnEstoque.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEstoque.Animated = True
        Me.btnEstoque.BackColor = System.Drawing.Color.Transparent
        Me.btnEstoque.BorderRadius = 10
        Me.btnEstoque.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnEstoque.CausesValidation = False
        Me.btnEstoque.CheckedState.Parent = Me.btnEstoque
        Me.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEstoque.CustomImages.Parent = Me.btnEstoque
        Me.btnEstoque.DisabledState.Parent = Me.btnEstoque
        Me.btnEstoque.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnEstoque.FillColor2 = System.Drawing.Color.Black
        Me.btnEstoque.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEstoque.ForeColor = System.Drawing.Color.White
        Me.btnEstoque.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.btnEstoque.HoverState.Parent = Me.btnEstoque
        Me.btnEstoque.Image = CType(resources.GetObject("btnEstoque.Image"), System.Drawing.Image)
        Me.btnEstoque.ImageSize = New System.Drawing.Size(89, 80)
        Me.btnEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEstoque.Location = New System.Drawing.Point(392, 22)
        Me.btnEstoque.Name = "btnEstoque"
        Me.btnEstoque.ShadowDecoration.Parent = Me.btnEstoque
        Me.btnEstoque.Size = New System.Drawing.Size(85, 85)
        Me.btnEstoque.TabIndex = 107
        '
        'btnFinanceiro
        '
        Me.btnFinanceiro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFinanceiro.Animated = True
        Me.btnFinanceiro.BackColor = System.Drawing.Color.Transparent
        Me.btnFinanceiro.BorderRadius = 10
        Me.btnFinanceiro.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnFinanceiro.CausesValidation = False
        Me.btnFinanceiro.CheckedState.Parent = Me.btnFinanceiro
        Me.btnFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinanceiro.CustomImages.Parent = Me.btnFinanceiro
        Me.btnFinanceiro.DisabledState.Parent = Me.btnFinanceiro
        Me.btnFinanceiro.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnFinanceiro.FillColor2 = System.Drawing.Color.Black
        Me.btnFinanceiro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnFinanceiro.ForeColor = System.Drawing.Color.White
        Me.btnFinanceiro.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.btnFinanceiro.HoverState.Parent = Me.btnFinanceiro
        Me.btnFinanceiro.Image = CType(resources.GetObject("btnFinanceiro.Image"), System.Drawing.Image)
        Me.btnFinanceiro.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btnFinanceiro.ImageSize = New System.Drawing.Size(80, 50)
        Me.btnFinanceiro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFinanceiro.Location = New System.Drawing.Point(498, 22)
        Me.btnFinanceiro.Name = "btnFinanceiro"
        Me.btnFinanceiro.ShadowDecoration.Parent = Me.btnFinanceiro
        Me.btnFinanceiro.Size = New System.Drawing.Size(85, 85)
        Me.btnFinanceiro.TabIndex = 108
        '
        'btnDashboard
        '
        Me.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDashboard.Animated = True
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BorderRadius = 10
        Me.btnDashboard.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnDashboard.CausesValidation = False
        Me.btnDashboard.CheckedState.Parent = Me.btnDashboard
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.CustomImages.Parent = Me.btnDashboard
        Me.btnDashboard.DisabledState.Parent = Me.btnDashboard
        Me.btnDashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnDashboard.FillColor2 = System.Drawing.Color.Black
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.btnDashboard.HoverState.Parent = Me.btnDashboard
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btnDashboard.ImageSize = New System.Drawing.Size(80, 75)
        Me.btnDashboard.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDashboard.Location = New System.Drawing.Point(604, 22)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.ShadowDecoration.Parent = Me.btnDashboard
        Me.btnDashboard.Size = New System.Drawing.Size(85, 85)
        Me.btnDashboard.TabIndex = 109
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
        Me.BtnHome.Location = New System.Drawing.Point(74, 22)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.ShadowDecoration.Parent = Me.BtnHome
        Me.BtnHome.Size = New System.Drawing.Size(85, 85)
        Me.BtnHome.TabIndex = 104
        '
        'LblInfoServidor
        '
        Me.LblInfoServidor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblInfoServidor.AutoSize = False
        Me.LblInfoServidor.BackColor = System.Drawing.Color.Transparent
        Me.LblInfoServidor.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfoServidor.ForeColor = System.Drawing.Color.DimGray
        Me.LblInfoServidor.Location = New System.Drawing.Point(7, 136)
        Me.LblInfoServidor.Name = "LblInfoServidor"
        Me.LblInfoServidor.Size = New System.Drawing.Size(748, 152)
        Me.LblInfoServidor.TabIndex = 111
        Me.LblInfoServidor.Text = "..."
        Me.LblInfoServidor.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'TpGSHome
        '
        Me.TpGSHome.AutoScroll = True
        Me.TpGSHome.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpGSHome.Controls.Add(Me.Guna2Panel1)
        Me.TpGSHome.Location = New System.Drawing.Point(4, 4)
        Me.TpGSHome.Name = "TpGSHome"
        Me.TpGSHome.Padding = New System.Windows.Forms.Padding(3)
        Me.TpGSHome.Size = New System.Drawing.Size(764, 488)
        Me.TpGSHome.TabIndex = 1
        Me.TpGSHome.Text = "Servidor"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.LblChaveSSH)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel1.Controls.Add(Me.TxtChaveSSH)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.LblDirBkpSistema)
        Me.Guna2Panel1.Controls.Add(Me.LblServidor)
        Me.Guna2Panel1.Controls.Add(Me.TxtDirBkpSistema)
        Me.Guna2Panel1.Controls.Add(Me.BtnCencelarGSHome)
        Me.Guna2Panel1.Controls.Add(Me.LblDirBkpBD)
        Me.Guna2Panel1.Controls.Add(Me.BtnSalvarGSHome)
        Me.Guna2Panel1.Controls.Add(Me.TxtDirBkpBD)
        Me.Guna2Panel1.Controls.Add(Me.TxtUsuario)
        Me.Guna2Panel1.Controls.Add(Me.LblPorta)
        Me.Guna2Panel1.Controls.Add(Me.TxtSenha)
        Me.Guna2Panel1.Controls.Add(Me.LblUsuario)
        Me.Guna2Panel1.Controls.Add(Me.TxtPorta)
        Me.Guna2Panel1.Controls.Add(Me.LblSenha)
        Me.Guna2Panel1.Controls.Add(Me.TxtServidor)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(741, 531)
        Me.Guna2Panel1.TabIndex = 328
        '
        'LblChaveSSH
        '
        Me.LblChaveSSH.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblChaveSSH.AutoSize = True
        Me.LblChaveSSH.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblChaveSSH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblChaveSSH.Location = New System.Drawing.Point(167, 226)
        Me.LblChaveSSH.Name = "LblChaveSSH"
        Me.LblChaveSSH.Size = New System.Drawing.Size(64, 15)
        Me.LblChaveSSH.TabIndex = 327
        Me.LblChaveSSH.Text = "Chave SSH"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 53)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(741, 10)
        Me.Guna2Separator1.TabIndex = 314
        '
        'TxtChaveSSH
        '
        Me.TxtChaveSSH.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtChaveSSH.Animated = True
        Me.TxtChaveSSH.BackColor = System.Drawing.Color.Transparent
        Me.TxtChaveSSH.BorderColor = System.Drawing.Color.Silver
        Me.TxtChaveSSH.BorderRadius = 7
        Me.TxtChaveSSH.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtChaveSSH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtChaveSSH.DefaultText = ""
        Me.TxtChaveSSH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtChaveSSH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtChaveSSH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtChaveSSH.DisabledState.Parent = Me.TxtChaveSSH
        Me.TxtChaveSSH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtChaveSSH.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtChaveSSH.FocusedState.Parent = Me.TxtChaveSSH
        Me.TxtChaveSSH.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtChaveSSH.ForeColor = System.Drawing.Color.Black
        Me.TxtChaveSSH.HoverState.Parent = Me.TxtChaveSSH
        Me.TxtChaveSSH.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtChaveSSH.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtChaveSSH.Location = New System.Drawing.Point(170, 244)
        Me.TxtChaveSSH.Name = "TxtChaveSSH"
        Me.TxtChaveSSH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtChaveSSH.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtChaveSSH.PlaceholderText = ""
        Me.TxtChaveSSH.SelectedText = ""
        Me.TxtChaveSSH.ShadowDecoration.Parent = Me.TxtChaveSSH
        Me.TxtChaveSSH.Size = New System.Drawing.Size(404, 36)
        Me.TxtChaveSSH.TabIndex = 326
        Me.TxtChaveSSH.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(741, 53)
        Me.Guna2HtmlLabel1.TabIndex = 315
        Me.Guna2HtmlLabel1.Text = "SERVIFOR SFTP"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'LblDirBkpSistema
        '
        Me.LblDirBkpSistema.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblDirBkpSistema.AutoSize = True
        Me.LblDirBkpSistema.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblDirBkpSistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblDirBkpSistema.Location = New System.Drawing.Point(167, 368)
        Me.LblDirBkpSistema.Name = "LblDirBkpSistema"
        Me.LblDirBkpSistema.Size = New System.Drawing.Size(172, 15)
        Me.LblDirBkpSistema.TabIndex = 325
        Me.LblDirBkpSistema.Text = "Diretorio de Backup do Sistema"
        '
        'LblServidor
        '
        Me.LblServidor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblServidor.AutoSize = True
        Me.LblServidor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblServidor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblServidor.Location = New System.Drawing.Point(167, 90)
        Me.LblServidor.Name = "LblServidor"
        Me.LblServidor.Size = New System.Drawing.Size(50, 15)
        Me.LblServidor.TabIndex = 318
        Me.LblServidor.Text = "Servidor"
        '
        'TxtDirBkpSistema
        '
        Me.TxtDirBkpSistema.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDirBkpSistema.Animated = True
        Me.TxtDirBkpSistema.BackColor = System.Drawing.Color.Transparent
        Me.TxtDirBkpSistema.BorderColor = System.Drawing.Color.Silver
        Me.TxtDirBkpSistema.BorderRadius = 7
        Me.TxtDirBkpSistema.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtDirBkpSistema.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDirBkpSistema.DefaultText = ""
        Me.TxtDirBkpSistema.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtDirBkpSistema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtDirBkpSistema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDirBkpSistema.DisabledState.Parent = Me.TxtDirBkpSistema
        Me.TxtDirBkpSistema.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDirBkpSistema.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtDirBkpSistema.FocusedState.Parent = Me.TxtDirBkpSistema
        Me.TxtDirBkpSistema.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtDirBkpSistema.ForeColor = System.Drawing.Color.Black
        Me.TxtDirBkpSistema.HoverState.Parent = Me.TxtDirBkpSistema
        Me.TxtDirBkpSistema.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtDirBkpSistema.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtDirBkpSistema.Location = New System.Drawing.Point(170, 386)
        Me.TxtDirBkpSistema.Name = "TxtDirBkpSistema"
        Me.TxtDirBkpSistema.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDirBkpSistema.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtDirBkpSistema.PlaceholderText = ""
        Me.TxtDirBkpSistema.SelectedText = ""
        Me.TxtDirBkpSistema.ShadowDecoration.Parent = Me.TxtDirBkpSistema
        Me.TxtDirBkpSistema.Size = New System.Drawing.Size(404, 36)
        Me.TxtDirBkpSistema.TabIndex = 324
        Me.TxtDirBkpSistema.TextOffset = New System.Drawing.Point(10, 0)
        '
        'BtnCencelarGSHome
        '
        Me.BtnCencelarGSHome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCencelarGSHome.Animated = True
        Me.BtnCencelarGSHome.AutoRoundedCorners = True
        Me.BtnCencelarGSHome.BorderRadius = 18
        Me.BtnCencelarGSHome.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnCencelarGSHome.CheckedState.Parent = Me.BtnCencelarGSHome
        Me.BtnCencelarGSHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCencelarGSHome.CustomImages.Parent = Me.BtnCencelarGSHome
        Me.BtnCencelarGSHome.DisabledState.Parent = Me.BtnCencelarGSHome
        Me.BtnCencelarGSHome.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnCencelarGSHome.FillColor2 = System.Drawing.Color.Black
        Me.BtnCencelarGSHome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCencelarGSHome.ForeColor = System.Drawing.Color.White
        Me.BtnCencelarGSHome.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnCencelarGSHome.HoverState.Parent = Me.BtnCencelarGSHome
        Me.BtnCencelarGSHome.Location = New System.Drawing.Point(243, 483)
        Me.BtnCencelarGSHome.Name = "BtnCencelarGSHome"
        Me.BtnCencelarGSHome.ShadowDecoration.Parent = Me.BtnCencelarGSHome
        Me.BtnCencelarGSHome.Size = New System.Drawing.Size(124, 38)
        Me.BtnCencelarGSHome.TabIndex = 312
        Me.BtnCencelarGSHome.Text = "CANCELAR"
        '
        'LblDirBkpBD
        '
        Me.LblDirBkpBD.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblDirBkpBD.AutoSize = True
        Me.LblDirBkpBD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblDirBkpBD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblDirBkpBD.Location = New System.Drawing.Point(167, 298)
        Me.LblDirBkpBD.Name = "LblDirBkpBD"
        Me.LblDirBkpBD.Size = New System.Drawing.Size(216, 15)
        Me.LblDirBkpBD.TabIndex = 323
        Me.LblDirBkpBD.Text = "Diretorio de Backup do Banco de Dados"
        '
        'BtnSalvarGSHome
        '
        Me.BtnSalvarGSHome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSalvarGSHome.Animated = True
        Me.BtnSalvarGSHome.AutoRoundedCorners = True
        Me.BtnSalvarGSHome.BorderRadius = 18
        Me.BtnSalvarGSHome.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnSalvarGSHome.CheckedState.Parent = Me.BtnSalvarGSHome
        Me.BtnSalvarGSHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvarGSHome.CustomImages.Parent = Me.BtnSalvarGSHome
        Me.BtnSalvarGSHome.DisabledState.Parent = Me.BtnSalvarGSHome
        Me.BtnSalvarGSHome.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnSalvarGSHome.FillColor2 = System.Drawing.Color.Black
        Me.BtnSalvarGSHome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalvarGSHome.ForeColor = System.Drawing.Color.White
        Me.BtnSalvarGSHome.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnSalvarGSHome.HoverState.Parent = Me.BtnSalvarGSHome
        Me.BtnSalvarGSHome.Location = New System.Drawing.Point(373, 483)
        Me.BtnSalvarGSHome.Name = "BtnSalvarGSHome"
        Me.BtnSalvarGSHome.ShadowDecoration.Parent = Me.BtnSalvarGSHome
        Me.BtnSalvarGSHome.Size = New System.Drawing.Size(124, 38)
        Me.BtnSalvarGSHome.TabIndex = 311
        Me.BtnSalvarGSHome.Text = "SALVAR"
        '
        'TxtDirBkpBD
        '
        Me.TxtDirBkpBD.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDirBkpBD.Animated = True
        Me.TxtDirBkpBD.BackColor = System.Drawing.Color.Transparent
        Me.TxtDirBkpBD.BorderColor = System.Drawing.Color.Silver
        Me.TxtDirBkpBD.BorderRadius = 7
        Me.TxtDirBkpBD.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtDirBkpBD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDirBkpBD.DefaultText = ""
        Me.TxtDirBkpBD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtDirBkpBD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtDirBkpBD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDirBkpBD.DisabledState.Parent = Me.TxtDirBkpBD
        Me.TxtDirBkpBD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDirBkpBD.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtDirBkpBD.FocusedState.Parent = Me.TxtDirBkpBD
        Me.TxtDirBkpBD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtDirBkpBD.ForeColor = System.Drawing.Color.Black
        Me.TxtDirBkpBD.HoverState.Parent = Me.TxtDirBkpBD
        Me.TxtDirBkpBD.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtDirBkpBD.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtDirBkpBD.Location = New System.Drawing.Point(170, 316)
        Me.TxtDirBkpBD.Name = "TxtDirBkpBD"
        Me.TxtDirBkpBD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDirBkpBD.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtDirBkpBD.PlaceholderText = ""
        Me.TxtDirBkpBD.SelectedText = ""
        Me.TxtDirBkpBD.ShadowDecoration.Parent = Me.TxtDirBkpBD
        Me.TxtDirBkpBD.Size = New System.Drawing.Size(404, 36)
        Me.TxtDirBkpBD.TabIndex = 322
        Me.TxtDirBkpBD.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtUsuario.Animated = True
        Me.TxtUsuario.BackColor = System.Drawing.Color.Transparent
        Me.TxtUsuario.BorderColor = System.Drawing.Color.Silver
        Me.TxtUsuario.BorderRadius = 7
        Me.TxtUsuario.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUsuario.DefaultText = ""
        Me.TxtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsuario.DisabledState.Parent = Me.TxtUsuario
        Me.TxtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsuario.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtUsuario.FocusedState.Parent = Me.TxtUsuario
        Me.TxtUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtUsuario.ForeColor = System.Drawing.Color.Black
        Me.TxtUsuario.HoverState.Parent = Me.TxtUsuario
        Me.TxtUsuario.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtUsuario.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtUsuario.Location = New System.Drawing.Point(170, 175)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUsuario.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtUsuario.PlaceholderText = ""
        Me.TxtUsuario.SelectedText = ""
        Me.TxtUsuario.ShadowDecoration.Parent = Me.TxtUsuario
        Me.TxtUsuario.Size = New System.Drawing.Size(176, 36)
        Me.TxtUsuario.TabIndex = 316
        Me.TxtUsuario.TextOffset = New System.Drawing.Point(10, 0)
        '
        'LblPorta
        '
        Me.LblPorta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblPorta.AutoSize = True
        Me.LblPorta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblPorta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblPorta.Location = New System.Drawing.Point(437, 90)
        Me.LblPorta.Name = "LblPorta"
        Me.LblPorta.Size = New System.Drawing.Size(35, 15)
        Me.LblPorta.TabIndex = 319
        Me.LblPorta.Text = "Porta"
        '
        'TxtSenha
        '
        Me.TxtSenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSenha.Animated = True
        Me.TxtSenha.BackColor = System.Drawing.Color.Transparent
        Me.TxtSenha.BorderColor = System.Drawing.Color.Silver
        Me.TxtSenha.BorderRadius = 7
        Me.TxtSenha.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSenha.DefaultText = ""
        Me.TxtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSenha.DisabledState.Parent = Me.TxtSenha
        Me.TxtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSenha.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtSenha.FocusedState.Parent = Me.TxtSenha
        Me.TxtSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtSenha.ForeColor = System.Drawing.Color.Black
        Me.TxtSenha.HoverState.Parent = Me.TxtSenha
        Me.TxtSenha.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtSenha.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtSenha.Location = New System.Drawing.Point(352, 175)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSenha.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtSenha.PlaceholderText = ""
        Me.TxtSenha.SelectedText = ""
        Me.TxtSenha.ShadowDecoration.Parent = Me.TxtSenha
        Me.TxtSenha.Size = New System.Drawing.Size(222, 36)
        Me.TxtSenha.TabIndex = 317
        Me.TxtSenha.TextOffset = New System.Drawing.Point(10, 0)
        '
        'LblUsuario
        '
        Me.LblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblUsuario.Location = New System.Drawing.Point(167, 156)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(47, 15)
        Me.LblUsuario.TabIndex = 320
        Me.LblUsuario.Text = "Usuário"
        '
        'TxtPorta
        '
        Me.TxtPorta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtPorta.Animated = True
        Me.TxtPorta.BackColor = System.Drawing.Color.Transparent
        Me.TxtPorta.BorderColor = System.Drawing.Color.Silver
        Me.TxtPorta.BorderRadius = 7
        Me.TxtPorta.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtPorta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPorta.DefaultText = ""
        Me.TxtPorta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPorta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPorta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPorta.DisabledState.Parent = Me.TxtPorta
        Me.TxtPorta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPorta.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtPorta.FocusedState.Parent = Me.TxtPorta
        Me.TxtPorta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPorta.ForeColor = System.Drawing.Color.Black
        Me.TxtPorta.HoverState.Parent = Me.TxtPorta
        Me.TxtPorta.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtPorta.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtPorta.Location = New System.Drawing.Point(440, 108)
        Me.TxtPorta.Name = "TxtPorta"
        Me.TxtPorta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPorta.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtPorta.PlaceholderText = ""
        Me.TxtPorta.SelectedText = ""
        Me.TxtPorta.ShadowDecoration.Parent = Me.TxtPorta
        Me.TxtPorta.Size = New System.Drawing.Size(134, 36)
        Me.TxtPorta.TabIndex = 315
        Me.TxtPorta.TextOffset = New System.Drawing.Point(10, 0)
        '
        'LblSenha
        '
        Me.LblSenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblSenha.AutoSize = True
        Me.LblSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblSenha.Location = New System.Drawing.Point(349, 156)
        Me.LblSenha.Name = "LblSenha"
        Me.LblSenha.Size = New System.Drawing.Size(39, 15)
        Me.LblSenha.TabIndex = 321
        Me.LblSenha.Text = "Senha"
        '
        'TxtServidor
        '
        Me.TxtServidor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtServidor.Animated = True
        Me.TxtServidor.BackColor = System.Drawing.Color.Transparent
        Me.TxtServidor.BorderColor = System.Drawing.Color.Silver
        Me.TxtServidor.BorderRadius = 7
        Me.TxtServidor.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtServidor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtServidor.DefaultText = ""
        Me.TxtServidor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtServidor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtServidor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtServidor.DisabledState.Parent = Me.TxtServidor
        Me.TxtServidor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtServidor.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtServidor.FocusedState.Parent = Me.TxtServidor
        Me.TxtServidor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtServidor.ForeColor = System.Drawing.Color.Black
        Me.TxtServidor.HoverState.Parent = Me.TxtServidor
        Me.TxtServidor.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtServidor.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtServidor.Location = New System.Drawing.Point(170, 108)
        Me.TxtServidor.Name = "TxtServidor"
        Me.TxtServidor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtServidor.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtServidor.PlaceholderText = ""
        Me.TxtServidor.SelectedText = ""
        Me.TxtServidor.ShadowDecoration.Parent = Me.TxtServidor
        Me.TxtServidor.Size = New System.Drawing.Size(264, 36)
        Me.TxtServidor.TabIndex = 314
        Me.TxtServidor.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TpPhonebook
        '
        Me.TpPhonebook.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpPhonebook.Controls.Add(Me.Guna2Separator2)
        Me.TpPhonebook.Controls.Add(Me.Guna2HtmlLabel2)
        Me.TpPhonebook.Controls.Add(Me.LblParceiro)
        Me.TpPhonebook.Controls.Add(Me.TxtParceiro)
        Me.TpPhonebook.Controls.Add(Me.BtnSalvarPhonebook)
        Me.TpPhonebook.Controls.Add(Me.BtnCancelarPhonebook)
        Me.TpPhonebook.Controls.Add(Me.LblFornecedor)
        Me.TpPhonebook.Controls.Add(Me.LblColaborador)
        Me.TpPhonebook.Controls.Add(Me.LblClientes)
        Me.TpPhonebook.Controls.Add(Me.TxtFornecedor)
        Me.TpPhonebook.Controls.Add(Me.TxtClientes)
        Me.TpPhonebook.Controls.Add(Me.TxtColaborador)
        Me.TpPhonebook.Location = New System.Drawing.Point(4, 4)
        Me.TpPhonebook.Name = "TpPhonebook"
        Me.TpPhonebook.Padding = New System.Windows.Forms.Padding(3)
        Me.TpPhonebook.Size = New System.Drawing.Size(764, 488)
        Me.TpPhonebook.TabIndex = 2
        Me.TpPhonebook.Text = "Phonebook"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator2.Location = New System.Drawing.Point(3, 56)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(758, 10)
        Me.Guna2Separator2.TabIndex = 327
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(758, 53)
        Me.Guna2HtmlLabel2.TabIndex = 314
        Me.Guna2HtmlLabel2.Text = "PHONEBOOK"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'LblParceiro
        '
        Me.LblParceiro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblParceiro.AutoSize = True
        Me.LblParceiro.BackColor = System.Drawing.Color.Transparent
        Me.LblParceiro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblParceiro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblParceiro.Location = New System.Drawing.Point(138, 276)
        Me.LblParceiro.Name = "LblParceiro"
        Me.LblParceiro.Size = New System.Drawing.Size(50, 15)
        Me.LblParceiro.TabIndex = 313
        Me.LblParceiro.Text = "Parceiro"
        '
        'TxtParceiro
        '
        Me.TxtParceiro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtParceiro.Animated = True
        Me.TxtParceiro.BackColor = System.Drawing.Color.Transparent
        Me.TxtParceiro.BorderColor = System.Drawing.Color.Silver
        Me.TxtParceiro.BorderRadius = 7
        Me.TxtParceiro.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtParceiro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtParceiro.DefaultText = ""
        Me.TxtParceiro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtParceiro.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtParceiro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtParceiro.DisabledState.Parent = Me.TxtParceiro
        Me.TxtParceiro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtParceiro.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtParceiro.FocusedState.Parent = Me.TxtParceiro
        Me.TxtParceiro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtParceiro.ForeColor = System.Drawing.Color.Black
        Me.TxtParceiro.HoverState.Parent = Me.TxtParceiro
        Me.TxtParceiro.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtParceiro.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtParceiro.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.TxtParceiro.Location = New System.Drawing.Point(139, 295)
        Me.TxtParceiro.Name = "TxtParceiro"
        Me.TxtParceiro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtParceiro.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtParceiro.PlaceholderText = ""
        Me.TxtParceiro.SelectedText = ""
        Me.TxtParceiro.ShadowDecoration.Parent = Me.TxtParceiro
        Me.TxtParceiro.Size = New System.Drawing.Size(487, 36)
        Me.TxtParceiro.TabIndex = 312
        Me.TxtParceiro.TextOffset = New System.Drawing.Point(10, 0)
        '
        'BtnSalvarPhonebook
        '
        Me.BtnSalvarPhonebook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSalvarPhonebook.Animated = True
        Me.BtnSalvarPhonebook.AutoRoundedCorners = True
        Me.BtnSalvarPhonebook.BorderRadius = 18
        Me.BtnSalvarPhonebook.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnSalvarPhonebook.CheckedState.Parent = Me.BtnSalvarPhonebook
        Me.BtnSalvarPhonebook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvarPhonebook.CustomImages.Parent = Me.BtnSalvarPhonebook
        Me.BtnSalvarPhonebook.DisabledState.Parent = Me.BtnSalvarPhonebook
        Me.BtnSalvarPhonebook.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnSalvarPhonebook.FillColor2 = System.Drawing.Color.Black
        Me.BtnSalvarPhonebook.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalvarPhonebook.ForeColor = System.Drawing.Color.White
        Me.BtnSalvarPhonebook.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnSalvarPhonebook.HoverState.Parent = Me.BtnSalvarPhonebook
        Me.BtnSalvarPhonebook.Location = New System.Drawing.Point(385, 444)
        Me.BtnSalvarPhonebook.Name = "BtnSalvarPhonebook"
        Me.BtnSalvarPhonebook.ShadowDecoration.Parent = Me.BtnSalvarPhonebook
        Me.BtnSalvarPhonebook.Size = New System.Drawing.Size(124, 38)
        Me.BtnSalvarPhonebook.TabIndex = 310
        Me.BtnSalvarPhonebook.Text = "SALVAR"
        '
        'BtnCancelarPhonebook
        '
        Me.BtnCancelarPhonebook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancelarPhonebook.Animated = True
        Me.BtnCancelarPhonebook.AutoRoundedCorners = True
        Me.BtnCancelarPhonebook.BorderRadius = 18
        Me.BtnCancelarPhonebook.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnCancelarPhonebook.CheckedState.Parent = Me.BtnCancelarPhonebook
        Me.BtnCancelarPhonebook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelarPhonebook.CustomImages.Parent = Me.BtnCancelarPhonebook
        Me.BtnCancelarPhonebook.DisabledState.Parent = Me.BtnCancelarPhonebook
        Me.BtnCancelarPhonebook.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnCancelarPhonebook.FillColor2 = System.Drawing.Color.Black
        Me.BtnCancelarPhonebook.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelarPhonebook.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarPhonebook.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnCancelarPhonebook.HoverState.Parent = Me.BtnCancelarPhonebook
        Me.BtnCancelarPhonebook.Location = New System.Drawing.Point(255, 444)
        Me.BtnCancelarPhonebook.Name = "BtnCancelarPhonebook"
        Me.BtnCancelarPhonebook.ShadowDecoration.Parent = Me.BtnCancelarPhonebook
        Me.BtnCancelarPhonebook.Size = New System.Drawing.Size(124, 38)
        Me.BtnCancelarPhonebook.TabIndex = 311
        Me.BtnCancelarPhonebook.Text = "CANCELAR"
        '
        'LblFornecedor
        '
        Me.LblFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblFornecedor.AutoSize = True
        Me.LblFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.LblFornecedor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblFornecedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblFornecedor.Location = New System.Drawing.Point(138, 209)
        Me.LblFornecedor.Name = "LblFornecedor"
        Me.LblFornecedor.Size = New System.Drawing.Size(67, 15)
        Me.LblFornecedor.TabIndex = 309
        Me.LblFornecedor.Text = "Fornecedor"
        '
        'LblColaborador
        '
        Me.LblColaborador.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblColaborador.AutoSize = True
        Me.LblColaborador.BackColor = System.Drawing.Color.Transparent
        Me.LblColaborador.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblColaborador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblColaborador.Location = New System.Drawing.Point(138, 142)
        Me.LblColaborador.Name = "LblColaborador"
        Me.LblColaborador.Size = New System.Drawing.Size(73, 15)
        Me.LblColaborador.TabIndex = 308
        Me.LblColaborador.Text = "Colaborador"
        '
        'LblClientes
        '
        Me.LblClientes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblClientes.AutoSize = True
        Me.LblClientes.BackColor = System.Drawing.Color.Transparent
        Me.LblClientes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblClientes.Location = New System.Drawing.Point(138, 78)
        Me.LblClientes.Name = "LblClientes"
        Me.LblClientes.Size = New System.Drawing.Size(49, 15)
        Me.LblClientes.TabIndex = 306
        Me.LblClientes.Text = "Clientes"
        '
        'TxtFornecedor
        '
        Me.TxtFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtFornecedor.Animated = True
        Me.TxtFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.TxtFornecedor.BorderColor = System.Drawing.Color.Silver
        Me.TxtFornecedor.BorderRadius = 7
        Me.TxtFornecedor.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtFornecedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFornecedor.DefaultText = ""
        Me.TxtFornecedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtFornecedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtFornecedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFornecedor.DisabledState.Parent = Me.TxtFornecedor
        Me.TxtFornecedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFornecedor.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtFornecedor.FocusedState.Parent = Me.TxtFornecedor
        Me.TxtFornecedor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtFornecedor.ForeColor = System.Drawing.Color.Black
        Me.TxtFornecedor.HoverState.Parent = Me.TxtFornecedor
        Me.TxtFornecedor.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtFornecedor.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtFornecedor.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.TxtFornecedor.Location = New System.Drawing.Point(139, 228)
        Me.TxtFornecedor.Name = "TxtFornecedor"
        Me.TxtFornecedor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFornecedor.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtFornecedor.PlaceholderText = ""
        Me.TxtFornecedor.SelectedText = ""
        Me.TxtFornecedor.ShadowDecoration.Parent = Me.TxtFornecedor
        Me.TxtFornecedor.Size = New System.Drawing.Size(487, 36)
        Me.TxtFornecedor.TabIndex = 305
        Me.TxtFornecedor.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TxtColaborador
        '
        Me.TxtColaborador.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtColaborador.Animated = True
        Me.TxtColaborador.BackColor = System.Drawing.Color.Transparent
        Me.TxtColaborador.BorderColor = System.Drawing.Color.Silver
        Me.TxtColaborador.BorderRadius = 7
        Me.TxtColaborador.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtColaborador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtColaborador.DefaultText = ""
        Me.TxtColaborador.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtColaborador.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtColaborador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtColaborador.DisabledState.Parent = Me.TxtColaborador
        Me.TxtColaborador.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtColaborador.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtColaborador.FocusedState.Parent = Me.TxtColaborador
        Me.TxtColaborador.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtColaborador.ForeColor = System.Drawing.Color.Black
        Me.TxtColaborador.HoverState.Parent = Me.TxtColaborador
        Me.TxtColaborador.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtColaborador.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtColaborador.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.TxtColaborador.IconRightSize = New System.Drawing.Size(18, 18)
        Me.TxtColaborador.Location = New System.Drawing.Point(139, 161)
        Me.TxtColaborador.MaxLength = 9
        Me.TxtColaborador.Name = "TxtColaborador"
        Me.TxtColaborador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtColaborador.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtColaborador.PlaceholderText = ""
        Me.TxtColaborador.SelectedText = ""
        Me.TxtColaborador.ShadowDecoration.Parent = Me.TxtColaborador
        Me.TxtColaborador.Size = New System.Drawing.Size(487, 36)
        Me.TxtColaborador.TabIndex = 304
        Me.TxtColaborador.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TxtClientes
        '
        Me.TxtClientes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtClientes.Animated = True
        Me.TxtClientes.BackColor = System.Drawing.Color.Transparent
        Me.TxtClientes.BorderColor = System.Drawing.Color.Silver
        Me.TxtClientes.BorderRadius = 7
        Me.TxtClientes.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtClientes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtClientes.DefaultText = ""
        Me.TxtClientes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtClientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtClientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtClientes.DisabledState.Parent = Me.TxtClientes
        Me.TxtClientes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtClientes.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtClientes.FocusedState.Parent = Me.TxtClientes
        Me.TxtClientes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtClientes.ForeColor = System.Drawing.Color.Black
        Me.TxtClientes.HoverState.Parent = Me.TxtClientes
        Me.TxtClientes.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtClientes.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtClientes.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.TxtClientes.Location = New System.Drawing.Point(139, 96)
        Me.TxtClientes.Name = "TxtClientes"
        Me.TxtClientes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtClientes.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtClientes.PlaceholderText = ""
        Me.TxtClientes.SelectedText = ""
        Me.TxtClientes.ShadowDecoration.Parent = Me.TxtClientes
        Me.TxtClientes.Size = New System.Drawing.Size(487, 36)
        Me.TxtClientes.TabIndex = 302
        Me.TxtClientes.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TpHelpdesk
        '
        Me.TpHelpdesk.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpHelpdesk.Controls.Add(Me.Guna2Separator3)
        Me.TpHelpdesk.Controls.Add(Me.Guna2HtmlLabel6)
        Me.TpHelpdesk.Controls.Add(Me.BtnSalvarHelpdesk)
        Me.TpHelpdesk.Controls.Add(Me.BtnCancelarHelpdesk)
        Me.TpHelpdesk.Controls.Add(Me.LblOsRemoto)
        Me.TpHelpdesk.Controls.Add(Me.LblOSExterno)
        Me.TpHelpdesk.Controls.Add(Me.TxtOSRemoto)
        Me.TpHelpdesk.Controls.Add(Me.TxtOSExterna)
        Me.TpHelpdesk.Location = New System.Drawing.Point(4, 4)
        Me.TpHelpdesk.Name = "TpHelpdesk"
        Me.TpHelpdesk.Padding = New System.Windows.Forms.Padding(3)
        Me.TpHelpdesk.Size = New System.Drawing.Size(764, 488)
        Me.TpHelpdesk.TabIndex = 3
        Me.TpHelpdesk.Text = "Helpdesk"
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator3.Location = New System.Drawing.Point(3, 56)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(758, 10)
        Me.Guna2Separator3.TabIndex = 327
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(758, 53)
        Me.Guna2HtmlLabel6.TabIndex = 312
        Me.Guna2HtmlLabel6.Text = "HELPDESK"
        Me.Guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'BtnSalvarHelpdesk
        '
        Me.BtnSalvarHelpdesk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSalvarHelpdesk.Animated = True
        Me.BtnSalvarHelpdesk.AutoRoundedCorners = True
        Me.BtnSalvarHelpdesk.BorderRadius = 18
        Me.BtnSalvarHelpdesk.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnSalvarHelpdesk.CheckedState.Parent = Me.BtnSalvarHelpdesk
        Me.BtnSalvarHelpdesk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvarHelpdesk.CustomImages.Parent = Me.BtnSalvarHelpdesk
        Me.BtnSalvarHelpdesk.DisabledState.Parent = Me.BtnSalvarHelpdesk
        Me.BtnSalvarHelpdesk.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnSalvarHelpdesk.FillColor2 = System.Drawing.Color.Black
        Me.BtnSalvarHelpdesk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalvarHelpdesk.ForeColor = System.Drawing.Color.White
        Me.BtnSalvarHelpdesk.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnSalvarHelpdesk.HoverState.Parent = Me.BtnSalvarHelpdesk
        Me.BtnSalvarHelpdesk.Location = New System.Drawing.Point(385, 444)
        Me.BtnSalvarHelpdesk.Name = "BtnSalvarHelpdesk"
        Me.BtnSalvarHelpdesk.ShadowDecoration.Parent = Me.BtnSalvarHelpdesk
        Me.BtnSalvarHelpdesk.Size = New System.Drawing.Size(124, 38)
        Me.BtnSalvarHelpdesk.TabIndex = 310
        Me.BtnSalvarHelpdesk.Text = "SALVAR"
        '
        'BtnCancelarHelpdesk
        '
        Me.BtnCancelarHelpdesk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancelarHelpdesk.Animated = True
        Me.BtnCancelarHelpdesk.AutoRoundedCorners = True
        Me.BtnCancelarHelpdesk.BorderRadius = 18
        Me.BtnCancelarHelpdesk.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnCancelarHelpdesk.CheckedState.Parent = Me.BtnCancelarHelpdesk
        Me.BtnCancelarHelpdesk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelarHelpdesk.CustomImages.Parent = Me.BtnCancelarHelpdesk
        Me.BtnCancelarHelpdesk.DisabledState.Parent = Me.BtnCancelarHelpdesk
        Me.BtnCancelarHelpdesk.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnCancelarHelpdesk.FillColor2 = System.Drawing.Color.Black
        Me.BtnCancelarHelpdesk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelarHelpdesk.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarHelpdesk.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnCancelarHelpdesk.HoverState.Parent = Me.BtnCancelarHelpdesk
        Me.BtnCancelarHelpdesk.Location = New System.Drawing.Point(255, 444)
        Me.BtnCancelarHelpdesk.Name = "BtnCancelarHelpdesk"
        Me.BtnCancelarHelpdesk.ShadowDecoration.Parent = Me.BtnCancelarHelpdesk
        Me.BtnCancelarHelpdesk.Size = New System.Drawing.Size(124, 38)
        Me.BtnCancelarHelpdesk.TabIndex = 311
        Me.BtnCancelarHelpdesk.Text = "CANCELAR"
        '
        'LblOsRemoto
        '
        Me.LblOsRemoto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblOsRemoto.AutoSize = True
        Me.LblOsRemoto.BackColor = System.Drawing.Color.Transparent
        Me.LblOsRemoto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblOsRemoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblOsRemoto.Location = New System.Drawing.Point(138, 204)
        Me.LblOsRemoto.Name = "LblOsRemoto"
        Me.LblOsRemoto.Size = New System.Drawing.Size(140, 15)
        Me.LblOsRemoto.TabIndex = 308
        Me.LblOsRemoto.Text = "OS Atendimento Remoto"
        '
        'LblOSExterno
        '
        Me.LblOSExterno.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblOSExterno.AutoSize = True
        Me.LblOSExterno.BackColor = System.Drawing.Color.Transparent
        Me.LblOSExterno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblOSExterno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblOSExterno.Location = New System.Drawing.Point(138, 139)
        Me.LblOSExterno.Name = "LblOSExterno"
        Me.LblOSExterno.Size = New System.Drawing.Size(138, 15)
        Me.LblOSExterno.TabIndex = 306
        Me.LblOSExterno.Text = "OS Atendimento Externo"
        '
        'TxtOSRemoto
        '
        Me.TxtOSRemoto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtOSRemoto.Animated = True
        Me.TxtOSRemoto.BackColor = System.Drawing.Color.Transparent
        Me.TxtOSRemoto.BorderColor = System.Drawing.Color.Silver
        Me.TxtOSRemoto.BorderRadius = 7
        Me.TxtOSRemoto.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtOSRemoto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtOSRemoto.DefaultText = ""
        Me.TxtOSRemoto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtOSRemoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtOSRemoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOSRemoto.DisabledState.Parent = Me.TxtOSRemoto
        Me.TxtOSRemoto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOSRemoto.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtOSRemoto.FocusedState.Parent = Me.TxtOSRemoto
        Me.TxtOSRemoto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtOSRemoto.ForeColor = System.Drawing.Color.Black
        Me.TxtOSRemoto.HoverState.Parent = Me.TxtOSRemoto
        Me.TxtOSRemoto.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtOSRemoto.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtOSRemoto.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.TxtOSRemoto.IconRightSize = New System.Drawing.Size(18, 18)
        Me.TxtOSRemoto.Location = New System.Drawing.Point(139, 223)
        Me.TxtOSRemoto.MaxLength = 9
        Me.TxtOSRemoto.Name = "TxtOSRemoto"
        Me.TxtOSRemoto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtOSRemoto.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtOSRemoto.PlaceholderText = ""
        Me.TxtOSRemoto.SelectedText = ""
        Me.TxtOSRemoto.ShadowDecoration.Parent = Me.TxtOSRemoto
        Me.TxtOSRemoto.Size = New System.Drawing.Size(487, 36)
        Me.TxtOSRemoto.TabIndex = 304
        Me.TxtOSRemoto.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TxtOSExterna
        '
        Me.TxtOSExterna.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtOSExterna.Animated = True
        Me.TxtOSExterna.BackColor = System.Drawing.Color.Transparent
        Me.TxtOSExterna.BorderColor = System.Drawing.Color.Silver
        Me.TxtOSExterna.BorderRadius = 7
        Me.TxtOSExterna.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtOSExterna.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtOSExterna.DefaultText = ""
        Me.TxtOSExterna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtOSExterna.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtOSExterna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOSExterna.DisabledState.Parent = Me.TxtOSExterna
        Me.TxtOSExterna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOSExterna.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtOSExterna.FocusedState.Parent = Me.TxtOSExterna
        Me.TxtOSExterna.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtOSExterna.ForeColor = System.Drawing.Color.Black
        Me.TxtOSExterna.HoverState.Parent = Me.TxtOSExterna
        Me.TxtOSExterna.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtOSExterna.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtOSExterna.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.TxtOSExterna.Location = New System.Drawing.Point(139, 157)
        Me.TxtOSExterna.Name = "TxtOSExterna"
        Me.TxtOSExterna.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtOSExterna.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtOSExterna.PlaceholderText = ""
        Me.TxtOSExterna.SelectedText = ""
        Me.TxtOSExterna.ShadowDecoration.Parent = Me.TxtOSExterna
        Me.TxtOSExterna.Size = New System.Drawing.Size(487, 36)
        Me.TxtOSExterna.TabIndex = 302
        Me.TxtOSExterna.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TpEstoque
        '
        Me.TpEstoque.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpEstoque.Controls.Add(Me.Guna2Separator4)
        Me.TpEstoque.Controls.Add(Me.Guna2HtmlLabel5)
        Me.TpEstoque.Controls.Add(Me.TxtSalvarEstoque)
        Me.TpEstoque.Controls.Add(Me.BtnCancelarEstoque)
        Me.TpEstoque.Controls.Add(Me.Label9)
        Me.TpEstoque.Controls.Add(Me.TxtDiretorioEstoque)
        Me.TpEstoque.Location = New System.Drawing.Point(4, 4)
        Me.TpEstoque.Name = "TpEstoque"
        Me.TpEstoque.Padding = New System.Windows.Forms.Padding(3)
        Me.TpEstoque.Size = New System.Drawing.Size(764, 488)
        Me.TpEstoque.TabIndex = 4
        Me.TpEstoque.Text = "Estoque"
        '
        'Guna2Separator4
        '
        Me.Guna2Separator4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator4.Location = New System.Drawing.Point(3, 56)
        Me.Guna2Separator4.Name = "Guna2Separator4"
        Me.Guna2Separator4.Size = New System.Drawing.Size(758, 10)
        Me.Guna2Separator4.TabIndex = 327
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(758, 53)
        Me.Guna2HtmlLabel5.TabIndex = 306
        Me.Guna2HtmlLabel5.Text = "ESTOQUE"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'TxtSalvarEstoque
        '
        Me.TxtSalvarEstoque.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSalvarEstoque.Animated = True
        Me.TxtSalvarEstoque.AutoRoundedCorners = True
        Me.TxtSalvarEstoque.BorderRadius = 18
        Me.TxtSalvarEstoque.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtSalvarEstoque.CheckedState.Parent = Me.TxtSalvarEstoque
        Me.TxtSalvarEstoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TxtSalvarEstoque.CustomImages.Parent = Me.TxtSalvarEstoque
        Me.TxtSalvarEstoque.DisabledState.Parent = Me.TxtSalvarEstoque
        Me.TxtSalvarEstoque.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtSalvarEstoque.FillColor2 = System.Drawing.Color.Black
        Me.TxtSalvarEstoque.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxtSalvarEstoque.ForeColor = System.Drawing.Color.White
        Me.TxtSalvarEstoque.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TxtSalvarEstoque.HoverState.Parent = Me.TxtSalvarEstoque
        Me.TxtSalvarEstoque.Location = New System.Drawing.Point(385, 444)
        Me.TxtSalvarEstoque.Name = "TxtSalvarEstoque"
        Me.TxtSalvarEstoque.ShadowDecoration.Parent = Me.TxtSalvarEstoque
        Me.TxtSalvarEstoque.Size = New System.Drawing.Size(124, 38)
        Me.TxtSalvarEstoque.TabIndex = 304
        Me.TxtSalvarEstoque.Text = "SALVAR"
        '
        'BtnCancelarEstoque
        '
        Me.BtnCancelarEstoque.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancelarEstoque.Animated = True
        Me.BtnCancelarEstoque.AutoRoundedCorners = True
        Me.BtnCancelarEstoque.BorderRadius = 18
        Me.BtnCancelarEstoque.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnCancelarEstoque.CheckedState.Parent = Me.BtnCancelarEstoque
        Me.BtnCancelarEstoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelarEstoque.CustomImages.Parent = Me.BtnCancelarEstoque
        Me.BtnCancelarEstoque.DisabledState.Parent = Me.BtnCancelarEstoque
        Me.BtnCancelarEstoque.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnCancelarEstoque.FillColor2 = System.Drawing.Color.Black
        Me.BtnCancelarEstoque.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelarEstoque.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarEstoque.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnCancelarEstoque.HoverState.Parent = Me.BtnCancelarEstoque
        Me.BtnCancelarEstoque.Location = New System.Drawing.Point(255, 444)
        Me.BtnCancelarEstoque.Name = "BtnCancelarEstoque"
        Me.BtnCancelarEstoque.ShadowDecoration.Parent = Me.BtnCancelarEstoque
        Me.BtnCancelarEstoque.Size = New System.Drawing.Size(124, 38)
        Me.BtnCancelarEstoque.TabIndex = 305
        Me.BtnCancelarEstoque.Text = "CANCELAR"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(138, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 15)
        Me.Label9.TabIndex = 303
        Me.Label9.Text = "Equipamentos, peças e acessórios"
        '
        'TxtDiretorioEstoque
        '
        Me.TxtDiretorioEstoque.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDiretorioEstoque.Animated = True
        Me.TxtDiretorioEstoque.BackColor = System.Drawing.Color.Transparent
        Me.TxtDiretorioEstoque.BorderColor = System.Drawing.Color.Silver
        Me.TxtDiretorioEstoque.BorderRadius = 7
        Me.TxtDiretorioEstoque.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtDiretorioEstoque.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDiretorioEstoque.DefaultText = ""
        Me.TxtDiretorioEstoque.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtDiretorioEstoque.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtDiretorioEstoque.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDiretorioEstoque.DisabledState.Parent = Me.TxtDiretorioEstoque
        Me.TxtDiretorioEstoque.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDiretorioEstoque.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtDiretorioEstoque.FocusedState.Parent = Me.TxtDiretorioEstoque
        Me.TxtDiretorioEstoque.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtDiretorioEstoque.ForeColor = System.Drawing.Color.Black
        Me.TxtDiretorioEstoque.HoverState.Parent = Me.TxtDiretorioEstoque
        Me.TxtDiretorioEstoque.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtDiretorioEstoque.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtDiretorioEstoque.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.TxtDiretorioEstoque.Location = New System.Drawing.Point(139, 178)
        Me.TxtDiretorioEstoque.Name = "TxtDiretorioEstoque"
        Me.TxtDiretorioEstoque.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDiretorioEstoque.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtDiretorioEstoque.PlaceholderText = ""
        Me.TxtDiretorioEstoque.SelectedText = ""
        Me.TxtDiretorioEstoque.ShadowDecoration.Parent = Me.TxtDiretorioEstoque
        Me.TxtDiretorioEstoque.Size = New System.Drawing.Size(487, 36)
        Me.TxtDiretorioEstoque.TabIndex = 302
        Me.TxtDiretorioEstoque.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TpFinanceiro
        '
        Me.TpFinanceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpFinanceiro.Controls.Add(Me.Guna2Separator5)
        Me.TpFinanceiro.Controls.Add(Me.Guna2HtmlLabel4)
        Me.TpFinanceiro.Controls.Add(Me.BtnSalvarFinanceiro)
        Me.TpFinanceiro.Controls.Add(Me.BtnCancelarFinanceiro)
        Me.TpFinanceiro.Controls.Add(Me.Label12)
        Me.TpFinanceiro.Controls.Add(Me.Label13)
        Me.TpFinanceiro.Controls.Add(Me.TxtNFe)
        Me.TpFinanceiro.Controls.Add(Me.TxtNFSe)
        Me.TpFinanceiro.Location = New System.Drawing.Point(4, 4)
        Me.TpFinanceiro.Name = "TpFinanceiro"
        Me.TpFinanceiro.Padding = New System.Windows.Forms.Padding(3)
        Me.TpFinanceiro.Size = New System.Drawing.Size(764, 488)
        Me.TpFinanceiro.TabIndex = 5
        Me.TpFinanceiro.Text = "Financeiro"
        '
        'Guna2Separator5
        '
        Me.Guna2Separator5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator5.Location = New System.Drawing.Point(3, 56)
        Me.Guna2Separator5.Name = "Guna2Separator5"
        Me.Guna2Separator5.Size = New System.Drawing.Size(758, 10)
        Me.Guna2Separator5.TabIndex = 327
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(758, 53)
        Me.Guna2HtmlLabel4.TabIndex = 313
        Me.Guna2HtmlLabel4.Text = "FINANCEIRO"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'BtnSalvarFinanceiro
        '
        Me.BtnSalvarFinanceiro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSalvarFinanceiro.Animated = True
        Me.BtnSalvarFinanceiro.AutoRoundedCorners = True
        Me.BtnSalvarFinanceiro.BorderRadius = 18
        Me.BtnSalvarFinanceiro.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnSalvarFinanceiro.CheckedState.Parent = Me.BtnSalvarFinanceiro
        Me.BtnSalvarFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvarFinanceiro.CustomImages.Parent = Me.BtnSalvarFinanceiro
        Me.BtnSalvarFinanceiro.DisabledState.Parent = Me.BtnSalvarFinanceiro
        Me.BtnSalvarFinanceiro.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnSalvarFinanceiro.FillColor2 = System.Drawing.Color.Black
        Me.BtnSalvarFinanceiro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalvarFinanceiro.ForeColor = System.Drawing.Color.White
        Me.BtnSalvarFinanceiro.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnSalvarFinanceiro.HoverState.Parent = Me.BtnSalvarFinanceiro
        Me.BtnSalvarFinanceiro.Location = New System.Drawing.Point(385, 444)
        Me.BtnSalvarFinanceiro.Name = "BtnSalvarFinanceiro"
        Me.BtnSalvarFinanceiro.ShadowDecoration.Parent = Me.BtnSalvarFinanceiro
        Me.BtnSalvarFinanceiro.Size = New System.Drawing.Size(124, 38)
        Me.BtnSalvarFinanceiro.TabIndex = 311
        Me.BtnSalvarFinanceiro.Text = "SALVAR"
        '
        'BtnCancelarFinanceiro
        '
        Me.BtnCancelarFinanceiro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancelarFinanceiro.Animated = True
        Me.BtnCancelarFinanceiro.AutoRoundedCorners = True
        Me.BtnCancelarFinanceiro.BorderRadius = 18
        Me.BtnCancelarFinanceiro.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnCancelarFinanceiro.CheckedState.Parent = Me.BtnCancelarFinanceiro
        Me.BtnCancelarFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelarFinanceiro.CustomImages.Parent = Me.BtnCancelarFinanceiro
        Me.BtnCancelarFinanceiro.DisabledState.Parent = Me.BtnCancelarFinanceiro
        Me.BtnCancelarFinanceiro.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnCancelarFinanceiro.FillColor2 = System.Drawing.Color.Black
        Me.BtnCancelarFinanceiro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelarFinanceiro.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarFinanceiro.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnCancelarFinanceiro.HoverState.Parent = Me.BtnCancelarFinanceiro
        Me.BtnCancelarFinanceiro.Location = New System.Drawing.Point(255, 444)
        Me.BtnCancelarFinanceiro.Name = "BtnCancelarFinanceiro"
        Me.BtnCancelarFinanceiro.ShadowDecoration.Parent = Me.BtnCancelarFinanceiro
        Me.BtnCancelarFinanceiro.Size = New System.Drawing.Size(124, 38)
        Me.BtnCancelarFinanceiro.TabIndex = 312
        Me.BtnCancelarFinanceiro.Text = "CANCELAR"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(138, 211)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 15)
        Me.Label12.TabIndex = 310
        Me.Label12.Text = "NFSe"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(138, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 15)
        Me.Label13.TabIndex = 309
        Me.Label13.Text = "NFe"
        '
        'TxtNFe
        '
        Me.TxtNFe.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNFe.Animated = True
        Me.TxtNFe.BackColor = System.Drawing.Color.Transparent
        Me.TxtNFe.BorderColor = System.Drawing.Color.Silver
        Me.TxtNFe.BorderRadius = 7
        Me.TxtNFe.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtNFe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNFe.DefaultText = ""
        Me.TxtNFe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtNFe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtNFe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNFe.DisabledState.Parent = Me.TxtNFe
        Me.TxtNFe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNFe.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtNFe.FocusedState.Parent = Me.TxtNFe
        Me.TxtNFe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtNFe.ForeColor = System.Drawing.Color.Black
        Me.TxtNFe.HoverState.Parent = Me.TxtNFe
        Me.TxtNFe.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtNFe.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtNFe.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.TxtNFe.Location = New System.Drawing.Point(139, 164)
        Me.TxtNFe.Name = "TxtNFe"
        Me.TxtNFe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtNFe.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtNFe.PlaceholderText = ""
        Me.TxtNFe.SelectedText = ""
        Me.TxtNFe.ShadowDecoration.Parent = Me.TxtNFe
        Me.TxtNFe.Size = New System.Drawing.Size(487, 36)
        Me.TxtNFe.TabIndex = 307
        Me.TxtNFe.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TxtNFSe
        '
        Me.TxtNFSe.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNFSe.Animated = True
        Me.TxtNFSe.BackColor = System.Drawing.Color.Transparent
        Me.TxtNFSe.BorderColor = System.Drawing.Color.Silver
        Me.TxtNFSe.BorderRadius = 7
        Me.TxtNFSe.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtNFSe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNFSe.DefaultText = ""
        Me.TxtNFSe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtNFSe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtNFSe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNFSe.DisabledState.Parent = Me.TxtNFSe
        Me.TxtNFSe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNFSe.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtNFSe.FocusedState.Parent = Me.TxtNFSe
        Me.TxtNFSe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtNFSe.ForeColor = System.Drawing.Color.Black
        Me.TxtNFSe.HoverState.Parent = Me.TxtNFSe
        Me.TxtNFSe.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtNFSe.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtNFSe.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.TxtNFSe.Location = New System.Drawing.Point(139, 229)
        Me.TxtNFSe.MaxLength = 8
        Me.TxtNFSe.Name = "TxtNFSe"
        Me.TxtNFSe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtNFSe.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtNFSe.PlaceholderText = ""
        Me.TxtNFSe.SelectedText = ""
        Me.TxtNFSe.ShadowDecoration.Parent = Me.TxtNFSe
        Me.TxtNFSe.Size = New System.Drawing.Size(487, 36)
        Me.TxtNFSe.TabIndex = 308
        Me.TxtNFSe.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TpDashboard
        '
        Me.TpDashboard.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpDashboard.Controls.Add(Me.Guna2Separator6)
        Me.TpDashboard.Controls.Add(Me.Guna2HtmlLabel3)
        Me.TpDashboard.Controls.Add(Me.BtnSalvarDashboard)
        Me.TpDashboard.Controls.Add(Me.BtnCancelarDashboard)
        Me.TpDashboard.Controls.Add(Me.Label6)
        Me.TpDashboard.Controls.Add(Me.Label7)
        Me.TpDashboard.Controls.Add(Me.Label8)
        Me.TpDashboard.Controls.Add(Me.Label10)
        Me.TpDashboard.Controls.Add(Me.TxtFinanceiro)
        Me.TpDashboard.Controls.Add(Me.TxtEstoque)
        Me.TpDashboard.Controls.Add(Me.TxtPhonebook)
        Me.TpDashboard.Controls.Add(Me.TxtHelpdesk)
        Me.TpDashboard.Location = New System.Drawing.Point(4, 4)
        Me.TpDashboard.Name = "TpDashboard"
        Me.TpDashboard.Padding = New System.Windows.Forms.Padding(3)
        Me.TpDashboard.Size = New System.Drawing.Size(764, 488)
        Me.TpDashboard.TabIndex = 6
        Me.TpDashboard.Text = "Dashboard"
        '
        'Guna2Separator6
        '
        Me.Guna2Separator6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator6.Location = New System.Drawing.Point(3, 56)
        Me.Guna2Separator6.Name = "Guna2Separator6"
        Me.Guna2Separator6.Size = New System.Drawing.Size(758, 10)
        Me.Guna2Separator6.TabIndex = 327
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(758, 53)
        Me.Guna2HtmlLabel3.TabIndex = 319
        Me.Guna2HtmlLabel3.Text = "DASHBOARD"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'BtnSalvarDashboard
        '
        Me.BtnSalvarDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSalvarDashboard.Animated = True
        Me.BtnSalvarDashboard.AutoRoundedCorners = True
        Me.BtnSalvarDashboard.BorderRadius = 18
        Me.BtnSalvarDashboard.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnSalvarDashboard.CheckedState.Parent = Me.BtnSalvarDashboard
        Me.BtnSalvarDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvarDashboard.CustomImages.Parent = Me.BtnSalvarDashboard
        Me.BtnSalvarDashboard.DisabledState.Parent = Me.BtnSalvarDashboard
        Me.BtnSalvarDashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnSalvarDashboard.FillColor2 = System.Drawing.Color.Black
        Me.BtnSalvarDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalvarDashboard.ForeColor = System.Drawing.Color.White
        Me.BtnSalvarDashboard.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnSalvarDashboard.HoverState.Parent = Me.BtnSalvarDashboard
        Me.BtnSalvarDashboard.Location = New System.Drawing.Point(385, 444)
        Me.BtnSalvarDashboard.Name = "BtnSalvarDashboard"
        Me.BtnSalvarDashboard.ShadowDecoration.Parent = Me.BtnSalvarDashboard
        Me.BtnSalvarDashboard.Size = New System.Drawing.Size(124, 38)
        Me.BtnSalvarDashboard.TabIndex = 317
        Me.BtnSalvarDashboard.Text = "SALVAR"
        '
        'BtnCancelarDashboard
        '
        Me.BtnCancelarDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancelarDashboard.Animated = True
        Me.BtnCancelarDashboard.AutoRoundedCorners = True
        Me.BtnCancelarDashboard.BorderRadius = 18
        Me.BtnCancelarDashboard.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnCancelarDashboard.CheckedState.Parent = Me.BtnCancelarDashboard
        Me.BtnCancelarDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelarDashboard.CustomImages.Parent = Me.BtnCancelarDashboard
        Me.BtnCancelarDashboard.DisabledState.Parent = Me.BtnCancelarDashboard
        Me.BtnCancelarDashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnCancelarDashboard.FillColor2 = System.Drawing.Color.Black
        Me.BtnCancelarDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelarDashboard.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarDashboard.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnCancelarDashboard.HoverState.Parent = Me.BtnCancelarDashboard
        Me.BtnCancelarDashboard.Location = New System.Drawing.Point(255, 444)
        Me.BtnCancelarDashboard.Name = "BtnCancelarDashboard"
        Me.BtnCancelarDashboard.ShadowDecoration.Parent = Me.BtnCancelarDashboard
        Me.BtnCancelarDashboard.Size = New System.Drawing.Size(124, 38)
        Me.BtnCancelarDashboard.TabIndex = 318
        Me.BtnCancelarDashboard.Text = "CANCELAR"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(138, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 316
        Me.Label6.Text = "Financeiro"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(138, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 315
        Me.Label7.Text = "Estoque"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(138, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 314
        Me.Label8.Text = "Helpdesk"
        Me.Label8.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(138, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 15)
        Me.Label10.TabIndex = 313
        Me.Label10.Text = "Phonebook"
        Me.Label10.Visible = False
        '
        'TxtFinanceiro
        '
        Me.TxtFinanceiro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtFinanceiro.Animated = True
        Me.TxtFinanceiro.BackColor = System.Drawing.Color.Transparent
        Me.TxtFinanceiro.BorderColor = System.Drawing.Color.Silver
        Me.TxtFinanceiro.BorderRadius = 7
        Me.TxtFinanceiro.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtFinanceiro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFinanceiro.DefaultText = ""
        Me.TxtFinanceiro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtFinanceiro.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtFinanceiro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFinanceiro.DisabledState.Parent = Me.TxtFinanceiro
        Me.TxtFinanceiro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFinanceiro.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtFinanceiro.FocusedState.Parent = Me.TxtFinanceiro
        Me.TxtFinanceiro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtFinanceiro.ForeColor = System.Drawing.Color.Black
        Me.TxtFinanceiro.HoverState.Parent = Me.TxtFinanceiro
        Me.TxtFinanceiro.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtFinanceiro.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtFinanceiro.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.TxtFinanceiro.Location = New System.Drawing.Point(139, 295)
        Me.TxtFinanceiro.Name = "TxtFinanceiro"
        Me.TxtFinanceiro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFinanceiro.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtFinanceiro.PlaceholderText = ""
        Me.TxtFinanceiro.SelectedText = ""
        Me.TxtFinanceiro.ShadowDecoration.Parent = Me.TxtFinanceiro
        Me.TxtFinanceiro.Size = New System.Drawing.Size(487, 36)
        Me.TxtFinanceiro.TabIndex = 312
        Me.TxtFinanceiro.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TxtEstoque
        '
        Me.TxtEstoque.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtEstoque.Animated = True
        Me.TxtEstoque.BackColor = System.Drawing.Color.Transparent
        Me.TxtEstoque.BorderColor = System.Drawing.Color.Silver
        Me.TxtEstoque.BorderRadius = 7
        Me.TxtEstoque.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtEstoque.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEstoque.DefaultText = ""
        Me.TxtEstoque.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtEstoque.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtEstoque.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEstoque.DisabledState.Parent = Me.TxtEstoque
        Me.TxtEstoque.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEstoque.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtEstoque.FocusedState.Parent = Me.TxtEstoque
        Me.TxtEstoque.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtEstoque.ForeColor = System.Drawing.Color.Black
        Me.TxtEstoque.HoverState.Parent = Me.TxtEstoque
        Me.TxtEstoque.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtEstoque.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtEstoque.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.TxtEstoque.IconRightSize = New System.Drawing.Size(18, 18)
        Me.TxtEstoque.Location = New System.Drawing.Point(139, 233)
        Me.TxtEstoque.MaxLength = 9
        Me.TxtEstoque.Name = "TxtEstoque"
        Me.TxtEstoque.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEstoque.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtEstoque.PlaceholderText = ""
        Me.TxtEstoque.SelectedText = ""
        Me.TxtEstoque.ShadowDecoration.Parent = Me.TxtEstoque
        Me.TxtEstoque.Size = New System.Drawing.Size(487, 36)
        Me.TxtEstoque.TabIndex = 311
        Me.TxtEstoque.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TxtPhonebook
        '
        Me.TxtPhonebook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtPhonebook.Animated = True
        Me.TxtPhonebook.BackColor = System.Drawing.Color.Transparent
        Me.TxtPhonebook.BorderColor = System.Drawing.Color.Silver
        Me.TxtPhonebook.BorderRadius = 7
        Me.TxtPhonebook.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtPhonebook.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPhonebook.DefaultText = ""
        Me.TxtPhonebook.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPhonebook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPhonebook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPhonebook.DisabledState.Parent = Me.TxtPhonebook
        Me.TxtPhonebook.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPhonebook.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtPhonebook.FocusedState.Parent = Me.TxtPhonebook
        Me.TxtPhonebook.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPhonebook.ForeColor = System.Drawing.Color.Black
        Me.TxtPhonebook.HoverState.Parent = Me.TxtPhonebook
        Me.TxtPhonebook.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtPhonebook.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtPhonebook.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.TxtPhonebook.Location = New System.Drawing.Point(139, 111)
        Me.TxtPhonebook.Name = "TxtPhonebook"
        Me.TxtPhonebook.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPhonebook.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtPhonebook.PlaceholderText = ""
        Me.TxtPhonebook.SelectedText = ""
        Me.TxtPhonebook.ShadowDecoration.Parent = Me.TxtPhonebook
        Me.TxtPhonebook.Size = New System.Drawing.Size(487, 36)
        Me.TxtPhonebook.TabIndex = 309
        Me.TxtPhonebook.TextOffset = New System.Drawing.Point(10, 0)
        '
        'TxtHelpdesk
        '
        Me.TxtHelpdesk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtHelpdesk.Animated = True
        Me.TxtHelpdesk.BackColor = System.Drawing.Color.Transparent
        Me.TxtHelpdesk.BorderColor = System.Drawing.Color.Silver
        Me.TxtHelpdesk.BorderRadius = 7
        Me.TxtHelpdesk.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtHelpdesk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtHelpdesk.DefaultText = ""
        Me.TxtHelpdesk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtHelpdesk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtHelpdesk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtHelpdesk.DisabledState.Parent = Me.TxtHelpdesk
        Me.TxtHelpdesk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtHelpdesk.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtHelpdesk.FocusedState.Parent = Me.TxtHelpdesk
        Me.TxtHelpdesk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtHelpdesk.ForeColor = System.Drawing.Color.Black
        Me.TxtHelpdesk.HoverState.Parent = Me.TxtHelpdesk
        Me.TxtHelpdesk.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtHelpdesk.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtHelpdesk.IconRightOffset = New System.Drawing.Point(3, 0)
        Me.TxtHelpdesk.Location = New System.Drawing.Point(139, 171)
        Me.TxtHelpdesk.MaxLength = 8
        Me.TxtHelpdesk.Name = "TxtHelpdesk"
        Me.TxtHelpdesk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtHelpdesk.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtHelpdesk.PlaceholderText = ""
        Me.TxtHelpdesk.SelectedText = ""
        Me.TxtHelpdesk.ShadowDecoration.Parent = Me.TxtHelpdesk
        Me.TxtHelpdesk.Size = New System.Drawing.Size(487, 36)
        Me.TxtHelpdesk.TabIndex = 310
        Me.TxtHelpdesk.TextOffset = New System.Drawing.Point(10, 0)
        '
        'FrmArquivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(772, 526)
        Me.Controls.Add(Me.TabControlServidorSFTP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmArquivos"
        Me.Text = "FrmArquivos"
        Me.TabControlServidorSFTP.ResumeLayout(False)
        Me.TpInicial.ResumeLayout(False)
        Me.TpGSHome.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.TpPhonebook.ResumeLayout(False)
        Me.TpPhonebook.PerformLayout()
        Me.TpHelpdesk.ResumeLayout(False)
        Me.TpHelpdesk.PerformLayout()
        Me.TpEstoque.ResumeLayout(False)
        Me.TpEstoque.PerformLayout()
        Me.TpFinanceiro.ResumeLayout(False)
        Me.TpFinanceiro.PerformLayout()
        Me.TpDashboard.ResumeLayout(False)
        Me.TpDashboard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlServidorSFTP As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TpInicial As TabPage
    Friend WithEvents LblContato As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnPhonebook As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnHelpdesk As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEstoque As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnFinanceiro As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnHome As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LblInfoServidor As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TpGSHome As TabPage
    Friend WithEvents LblDirBkpSistema As Label
    Friend WithEvents TxtDirBkpSistema As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblDirBkpBD As Label
    Friend WithEvents TxtDirBkpBD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblPorta As Label
    Friend WithEvents LblServidor As Label
    Friend WithEvents TxtPorta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtServidor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblSenha As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents TxtSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnSalvarGSHome As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnCencelarGSHome As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TpPhonebook As TabPage
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblParceiro As Label
    Friend WithEvents TxtParceiro As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnSalvarPhonebook As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnCancelarPhonebook As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LblFornecedor As Label
    Friend WithEvents LblColaborador As Label
    Friend WithEvents LblClientes As Label
    Friend WithEvents TxtFornecedor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtColaborador As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtClientes As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TpHelpdesk As TabPage
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnSalvarHelpdesk As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnCancelarHelpdesk As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LblOsRemoto As Label
    Friend WithEvents LblOSExterno As Label
    Friend WithEvents TxtOSRemoto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtOSExterna As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TpEstoque As TabPage
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtSalvarEstoque As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnCancelarEstoque As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDiretorioEstoque As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TpFinanceiro As TabPage
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnSalvarFinanceiro As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnCancelarFinanceiro As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtNFe As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtNFSe As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TpDashboard As TabPage
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnSalvarDashboard As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnCancelarDashboard As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtFinanceiro As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtEstoque As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtPhonebook As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtHelpdesk As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator5 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator6 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblChaveSSH As Label
    Friend WithEvents TxtChaveSSH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
