<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSMTP
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
        Me.LblAdministrador = New System.Windows.Forms.Label()
        Me.TxtAdministrador = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblPorta = New System.Windows.Forms.Label()
        Me.LblServidor = New System.Windows.Forms.Label()
        Me.TxtPorta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtServidor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblSenha = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.TxtSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SwitchSSL = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.LblSSL = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator6 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnTeste = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnSalvar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnLimpar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblAdministrador
        '
        Me.LblAdministrador.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblAdministrador.AutoSize = True
        Me.LblAdministrador.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblAdministrador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblAdministrador.Location = New System.Drawing.Point(131, 240)
        Me.LblAdministrador.Name = "LblAdministrador"
        Me.LblAdministrador.Size = New System.Drawing.Size(83, 15)
        Me.LblAdministrador.TabIndex = 337
        Me.LblAdministrador.Text = "Administrador"
        '
        'TxtAdministrador
        '
        Me.TxtAdministrador.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtAdministrador.Animated = True
        Me.TxtAdministrador.BackColor = System.Drawing.Color.Transparent
        Me.TxtAdministrador.BorderColor = System.Drawing.Color.Silver
        Me.TxtAdministrador.BorderRadius = 7
        Me.TxtAdministrador.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtAdministrador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAdministrador.DefaultText = ""
        Me.TxtAdministrador.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtAdministrador.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtAdministrador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAdministrador.DisabledState.Parent = Me.TxtAdministrador
        Me.TxtAdministrador.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAdministrador.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtAdministrador.FocusedState.Parent = Me.TxtAdministrador
        Me.TxtAdministrador.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtAdministrador.ForeColor = System.Drawing.Color.Black
        Me.TxtAdministrador.HoverState.Parent = Me.TxtAdministrador
        Me.TxtAdministrador.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtAdministrador.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtAdministrador.Location = New System.Drawing.Point(134, 258)
        Me.TxtAdministrador.Name = "TxtAdministrador"
        Me.TxtAdministrador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAdministrador.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtAdministrador.PlaceholderText = ""
        Me.TxtAdministrador.SelectedText = ""
        Me.TxtAdministrador.ShadowDecoration.Parent = Me.TxtAdministrador
        Me.TxtAdministrador.Size = New System.Drawing.Size(491, 36)
        Me.TxtAdministrador.TabIndex = 336
        Me.TxtAdministrador.TextOffset = New System.Drawing.Point(10, 0)
        '
        'LblPorta
        '
        Me.LblPorta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblPorta.AutoSize = True
        Me.LblPorta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblPorta.ForeColor = System.Drawing.Color.Black
        Me.LblPorta.Location = New System.Drawing.Point(488, 106)
        Me.LblPorta.Name = "LblPorta"
        Me.LblPorta.Size = New System.Drawing.Size(35, 15)
        Me.LblPorta.TabIndex = 331
        Me.LblPorta.Text = "Porta"
        '
        'LblServidor
        '
        Me.LblServidor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblServidor.AutoSize = True
        Me.LblServidor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblServidor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblServidor.Location = New System.Drawing.Point(131, 106)
        Me.LblServidor.Name = "LblServidor"
        Me.LblServidor.Size = New System.Drawing.Size(83, 15)
        Me.LblServidor.TabIndex = 330
        Me.LblServidor.Text = "Servidor SMTP"
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
        Me.TxtPorta.Location = New System.Drawing.Point(491, 124)
        Me.TxtPorta.Name = "TxtPorta"
        Me.TxtPorta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPorta.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtPorta.PlaceholderText = ""
        Me.TxtPorta.SelectedText = ""
        Me.TxtPorta.ShadowDecoration.Parent = Me.TxtPorta
        Me.TxtPorta.Size = New System.Drawing.Size(134, 36)
        Me.TxtPorta.TabIndex = 327
        Me.TxtPorta.TextOffset = New System.Drawing.Point(10, 0)
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
        Me.TxtServidor.Location = New System.Drawing.Point(134, 124)
        Me.TxtServidor.Name = "TxtServidor"
        Me.TxtServidor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtServidor.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtServidor.PlaceholderText = ""
        Me.TxtServidor.SelectedText = ""
        Me.TxtServidor.ShadowDecoration.Parent = Me.TxtServidor
        Me.TxtServidor.Size = New System.Drawing.Size(351, 36)
        Me.TxtServidor.TabIndex = 326
        Me.TxtServidor.TextOffset = New System.Drawing.Point(10, 0)
        '
        'LblSenha
        '
        Me.LblSenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblSenha.AutoSize = True
        Me.LblSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblSenha.ForeColor = System.Drawing.Color.Black
        Me.LblSenha.Location = New System.Drawing.Point(400, 173)
        Me.LblSenha.Name = "LblSenha"
        Me.LblSenha.Size = New System.Drawing.Size(39, 15)
        Me.LblSenha.TabIndex = 333
        Me.LblSenha.Text = "Senha"
        '
        'LblUsuario
        '
        Me.LblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblUsuario.Location = New System.Drawing.Point(131, 173)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(47, 15)
        Me.LblUsuario.TabIndex = 332
        Me.LblUsuario.Text = "Usuário"
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
        Me.TxtSenha.Location = New System.Drawing.Point(403, 192)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSenha.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtSenha.PlaceholderText = ""
        Me.TxtSenha.SelectedText = ""
        Me.TxtSenha.ShadowDecoration.Parent = Me.TxtSenha
        Me.TxtSenha.Size = New System.Drawing.Size(222, 36)
        Me.TxtSenha.TabIndex = 329
        Me.TxtSenha.TextOffset = New System.Drawing.Point(10, 0)
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
        Me.TxtUsuario.Location = New System.Drawing.Point(134, 192)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUsuario.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtUsuario.PlaceholderText = ""
        Me.TxtUsuario.SelectedText = ""
        Me.TxtUsuario.ShadowDecoration.Parent = Me.TxtUsuario
        Me.TxtUsuario.Size = New System.Drawing.Size(263, 36)
        Me.TxtUsuario.TabIndex = 328
        Me.TxtUsuario.TextOffset = New System.Drawing.Point(10, 0)
        '
        'SwitchSSL
        '
        Me.SwitchSSL.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SwitchSSL.Animated = True
        Me.SwitchSSL.AutoRoundedCorners = True
        Me.SwitchSSL.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SwitchSSL.CheckedState.BorderRadius = 11
        Me.SwitchSSL.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SwitchSSL.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SwitchSSL.CheckedState.InnerBorderRadius = 7
        Me.SwitchSSL.CheckedState.InnerColor = System.Drawing.Color.White
        Me.SwitchSSL.CheckedState.Parent = Me.SwitchSSL
        Me.SwitchSSL.Location = New System.Drawing.Point(166, 302)
        Me.SwitchSSL.Name = "SwitchSSL"
        Me.SwitchSSL.ShadowDecoration.Parent = Me.SwitchSSL
        Me.SwitchSSL.Size = New System.Drawing.Size(60, 25)
        Me.SwitchSSL.TabIndex = 340
        Me.SwitchSSL.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SwitchSSL.UncheckedState.BorderRadius = 11
        Me.SwitchSSL.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SwitchSSL.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SwitchSSL.UncheckedState.InnerBorderRadius = 7
        Me.SwitchSSL.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.SwitchSSL.UncheckedState.Parent = Me.SwitchSSL
        '
        'LblSSL
        '
        Me.LblSSL.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblSSL.AutoSize = True
        Me.LblSSL.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSSL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblSSL.Location = New System.Drawing.Point(130, 305)
        Me.LblSSL.Name = "LblSSL"
        Me.LblSSL.Size = New System.Drawing.Size(33, 19)
        Me.LblSSL.TabIndex = 342
        Me.LblSSL.Text = "SSL"
        Me.LblSSL.Visible = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator6)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.BtnTeste)
        Me.Guna2Panel1.Controls.Add(Me.BtnSalvar)
        Me.Guna2Panel1.Controls.Add(Me.BtnLimpar)
        Me.Guna2Panel1.Controls.Add(Me.LblServidor)
        Me.Guna2Panel1.Controls.Add(Me.LblSSL)
        Me.Guna2Panel1.Controls.Add(Me.TxtUsuario)
        Me.Guna2Panel1.Controls.Add(Me.TxtSenha)
        Me.Guna2Panel1.Controls.Add(Me.SwitchSSL)
        Me.Guna2Panel1.Controls.Add(Me.LblUsuario)
        Me.Guna2Panel1.Controls.Add(Me.LblSenha)
        Me.Guna2Panel1.Controls.Add(Me.TxtServidor)
        Me.Guna2Panel1.Controls.Add(Me.LblAdministrador)
        Me.Guna2Panel1.Controls.Add(Me.TxtPorta)
        Me.Guna2Panel1.Controls.Add(Me.TxtAdministrador)
        Me.Guna2Panel1.Controls.Add(Me.LblPorta)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(756, 485)
        Me.Guna2Panel1.TabIndex = 344
        '
        'Guna2Separator6
        '
        Me.Guna2Separator6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Separator6.Location = New System.Drawing.Point(0, 53)
        Me.Guna2Separator6.Name = "Guna2Separator6"
        Me.Guna2Separator6.Size = New System.Drawing.Size(756, 10)
        Me.Guna2Separator6.TabIndex = 348
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(756, 53)
        Me.Guna2HtmlLabel3.TabIndex = 347
        Me.Guna2HtmlLabel3.Text = "CONFIGURAÇÃO DO SERVIDOR DE E-MAIL (SMTP)"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'BtnTeste
        '
        Me.BtnTeste.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnTeste.Animated = True
        Me.BtnTeste.AutoRoundedCorners = True
        Me.BtnTeste.BorderRadius = 11
        Me.BtnTeste.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnTeste.CheckedState.Parent = Me.BtnTeste
        Me.BtnTeste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTeste.CustomImages.Parent = Me.BtnTeste
        Me.BtnTeste.DisabledState.Parent = Me.BtnTeste
        Me.BtnTeste.FillColor = System.Drawing.Color.SlateGray
        Me.BtnTeste.FillColor2 = System.Drawing.Color.Black
        Me.BtnTeste.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTeste.ForeColor = System.Drawing.Color.White
        Me.BtnTeste.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnTeste.HoverState.Parent = Me.BtnTeste
        Me.BtnTeste.Location = New System.Drawing.Point(512, 302)
        Me.BtnTeste.Name = "BtnTeste"
        Me.BtnTeste.ShadowDecoration.Parent = Me.BtnTeste
        Me.BtnTeste.Size = New System.Drawing.Size(113, 25)
        Me.BtnTeste.TabIndex = 346
        Me.BtnTeste.Text = "E-mail de teste"
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSalvar.Animated = True
        Me.BtnSalvar.AutoRoundedCorners = True
        Me.BtnSalvar.BorderRadius = 18
        Me.BtnSalvar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnSalvar.CheckedState.Parent = Me.BtnSalvar
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.CustomImages.Parent = Me.BtnSalvar
        Me.BtnSalvar.DisabledState.Parent = Me.BtnSalvar
        Me.BtnSalvar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnSalvar.FillColor2 = System.Drawing.Color.Black
        Me.BtnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalvar.ForeColor = System.Drawing.Color.White
        Me.BtnSalvar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnSalvar.HoverState.Parent = Me.BtnSalvar
        Me.BtnSalvar.Location = New System.Drawing.Point(381, 439)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.ShadowDecoration.Parent = Me.BtnSalvar
        Me.BtnSalvar.Size = New System.Drawing.Size(124, 38)
        Me.BtnSalvar.TabIndex = 344
        Me.BtnSalvar.Text = "SALVAR"
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnLimpar.Animated = True
        Me.BtnLimpar.AutoRoundedCorners = True
        Me.BtnLimpar.BorderRadius = 18
        Me.BtnLimpar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnLimpar.CheckedState.Parent = Me.BtnLimpar
        Me.BtnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpar.CustomImages.Parent = Me.BtnLimpar
        Me.BtnLimpar.DisabledState.Parent = Me.BtnLimpar
        Me.BtnLimpar.FillColor = System.Drawing.Color.Gold
        Me.BtnLimpar.FillColor2 = System.Drawing.Color.Black
        Me.BtnLimpar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnLimpar.HoverState.Parent = Me.BtnLimpar
        Me.BtnLimpar.Location = New System.Drawing.Point(251, 439)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.ShadowDecoration.Parent = Me.BtnLimpar
        Me.BtnLimpar.Size = New System.Drawing.Size(124, 38)
        Me.BtnLimpar.TabIndex = 345
        Me.BtnLimpar.Text = "LIMPAR"
        '
        'FrmSMTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(756, 487)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSMTP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmSMTP"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblAdministrador As Label
    Friend WithEvents TxtAdministrador As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblPorta As Label
    Friend WithEvents LblServidor As Label
    Friend WithEvents TxtPorta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtServidor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblSenha As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents TxtSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SwitchSSL As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents LblSSL As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnSalvar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnLimpar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnTeste As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Separator6 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
