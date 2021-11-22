<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserConfig
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserConfig))
        Dim Animation1 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgRdf = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.tpEdit = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblRamal = New System.Windows.Forms.Label()
        Me.LblTelefone = New System.Windows.Forms.Label()
        Me.LblFunção = New System.Windows.Forms.Label()
        Me.LblDepartamento = New System.Windows.Forms.Label()
        Me.LblEmpresa = New System.Windows.Forms.Label()
        Me.LblUF = New System.Windows.Forms.Label()
        Me.LblCidade = New System.Windows.Forms.Label()
        Me.LblComplemento = New System.Windows.Forms.Label()
        Me.LblEndereço = New System.Windows.Forms.Label()
        Me.LblCep = New System.Windows.Forms.Label()
        Me.LblCelular = New System.Windows.Forms.Label()
        Me.LblNascimento = New System.Windows.Forms.Label()
        Me.LblGenero = New System.Windows.Forms.Label()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.btnSalvar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblTermos = New System.Windows.Forms.LinkLabel()
        Me.cbGenero = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblInfDados = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pbWhats = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtCidade = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbEmail = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtComplemento = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbTermos = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtCep = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblNotEmail = New System.Windows.Forms.Label()
        Me.txtEndereco = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAceiteTermo = New System.Windows.Forms.Label()
        Me.txtCell = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblNotWhats = New System.Windows.Forms.Label()
        Me.txtNome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chkPerfilWhats = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.txtUF = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chkPerfilEmail = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.txtNascimento = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chkPerfilTermos = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.txtRamal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtFuncao = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDepart = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmpresa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblInfoB = New System.Windows.Forms.Label()
        Me.lblInfoP = New System.Windows.Forms.Label()
        Me.tpInfoPerfil = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnCopy = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEditSenha = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnEditEmail = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnDeletar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblChaveKey = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblUserInfo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.imgPerfil = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.bpInfo = New Bunifu.UI.WinForms.BunifuPages()
        Me.tpEditEmail = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblEmailIncorreto = New System.Windows.Forms.Label()
        Me.LblSenha = New System.Windows.Forms.Label()
        Me.LblNewEmail = New System.Windows.Forms.Label()
        Me.LblEmailSenhaIncorreta = New System.Windows.Forms.Label()
        Me.LblEmailCapsLook = New System.Windows.Forms.Label()
        Me.TxtSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnEmailCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnEmailEnviar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TxtNewEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblEmailInf = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tpEditSenha = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblNewSenha = New System.Windows.Forms.Label()
        Me.LblRetrySenha = New System.Windows.Forms.Label()
        Me.LblOldSenha = New System.Windows.Forms.Label()
        Me.TxtNewSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblCapsLook = New System.Windows.Forms.Label()
        Me.LblOldSenhaIncorreta = New System.Windows.Forms.Label()
        Me.TxtRetrySenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnSenhaCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnSenhaSalvar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LblSenhaInf = New System.Windows.Forms.Label()
        Me.TxtOldSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TpLoading = New System.Windows.Forms.TabPage()
        Me.ProgressAguarde = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.LblLoading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TpValidar = New System.Windows.Forms.TabPage()
        Me.LblCodigoIncorreto = New System.Windows.Forms.Label()
        Me.LblValidarCodigo = New System.Windows.Forms.Label()
        Me.BtnValidarCancelar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnValidar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TxtValidar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblValidarInf = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TimerExcluir = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRdfEmail = New System.Windows.Forms.Timer(Me.components)
        Me.pbBordaLeft = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.tpEdit.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.pbWhats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTermos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpInfoPerfil.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.imgPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bpInfo.SuspendLayout()
        Me.tpEditEmail.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.tpEditSenha.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.TpLoading.SuspendLayout()
        Me.TpValidar.SuspendLayout()
        CType(Me.pbBordaLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgRdf
        '
        Me.imgRdf.ImageStream = CType(resources.GetObject("imgRdf.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgRdf.TransparentColor = System.Drawing.Color.Transparent
        Me.imgRdf.Images.SetKeyName(0, "cancel_18px.png")
        Me.imgRdf.Images.SetKeyName(1, "ok_18px.png")
        Me.imgRdf.Images.SetKeyName(2, "eye_40px.png")
        Me.imgRdf.Images.SetKeyName(3, "hide_40px.png")
        Me.imgRdf.Images.SetKeyName(4, "warning_18px.png")
        Me.imgRdf.Images.SetKeyName(5, "search_40px.png")
        '
        'Timer2
        '
        '
        'tpEdit
        '
        Me.tpEdit.AutoScroll = True
        Me.tpEdit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpEdit.Controls.Add(Me.TableLayoutPanel2)
        Me.tpEdit.Location = New System.Drawing.Point(4, 4)
        Me.tpEdit.Name = "tpEdit"
        Me.tpEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEdit.Size = New System.Drawing.Size(780, 539)
        Me.tpEdit.TabIndex = 7
        Me.tpEdit.Text = "Editar Perfil"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel2, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(757, 910)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.LblRamal)
        Me.Guna2Panel2.Controls.Add(Me.LblTelefone)
        Me.Guna2Panel2.Controls.Add(Me.LblFunção)
        Me.Guna2Panel2.Controls.Add(Me.LblDepartamento)
        Me.Guna2Panel2.Controls.Add(Me.LblEmpresa)
        Me.Guna2Panel2.Controls.Add(Me.LblUF)
        Me.Guna2Panel2.Controls.Add(Me.LblCidade)
        Me.Guna2Panel2.Controls.Add(Me.LblComplemento)
        Me.Guna2Panel2.Controls.Add(Me.LblEndereço)
        Me.Guna2Panel2.Controls.Add(Me.LblCep)
        Me.Guna2Panel2.Controls.Add(Me.LblCelular)
        Me.Guna2Panel2.Controls.Add(Me.LblNascimento)
        Me.Guna2Panel2.Controls.Add(Me.LblGenero)
        Me.Guna2Panel2.Controls.Add(Me.LblNome)
        Me.Guna2Panel2.Controls.Add(Me.btnSalvar)
        Me.Guna2Panel2.Controls.Add(Me.lblTermos)
        Me.Guna2Panel2.Controls.Add(Me.cbGenero)
        Me.Guna2Panel2.Controls.Add(Me.lblInfDados)
        Me.Guna2Panel2.Controls.Add(Me.pbWhats)
        Me.Guna2Panel2.Controls.Add(Me.txtCidade)
        Me.Guna2Panel2.Controls.Add(Me.pbEmail)
        Me.Guna2Panel2.Controls.Add(Me.txtComplemento)
        Me.Guna2Panel2.Controls.Add(Me.pbTermos)
        Me.Guna2Panel2.Controls.Add(Me.txtCep)
        Me.Guna2Panel2.Controls.Add(Me.lblNotEmail)
        Me.Guna2Panel2.Controls.Add(Me.txtEndereco)
        Me.Guna2Panel2.Controls.Add(Me.lblAceiteTermo)
        Me.Guna2Panel2.Controls.Add(Me.txtCell)
        Me.Guna2Panel2.Controls.Add(Me.lblNotWhats)
        Me.Guna2Panel2.Controls.Add(Me.txtNome)
        Me.Guna2Panel2.Controls.Add(Me.chkPerfilWhats)
        Me.Guna2Panel2.Controls.Add(Me.txtUF)
        Me.Guna2Panel2.Controls.Add(Me.chkPerfilEmail)
        Me.Guna2Panel2.Controls.Add(Me.txtNascimento)
        Me.Guna2Panel2.Controls.Add(Me.chkPerfilTermos)
        Me.Guna2Panel2.Controls.Add(Me.txtRamal)
        Me.Guna2Panel2.Controls.Add(Me.txtTel)
        Me.Guna2Panel2.Controls.Add(Me.btnCancel)
        Me.Guna2Panel2.Controls.Add(Me.txtFuncao)
        Me.Guna2Panel2.Controls.Add(Me.txtDepart)
        Me.Guna2Panel2.Controls.Add(Me.txtEmpresa)
        Me.Guna2Panel2.Controls.Add(Me.lblInfoB)
        Me.Guna2Panel2.Controls.Add(Me.lblInfoP)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(28, 33)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(701, 844)
        Me.Guna2Panel2.TabIndex = 0
        '
        'LblRamal
        '
        Me.LblRamal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblRamal.AutoSize = True
        Me.LblRamal.BackColor = System.Drawing.Color.Transparent
        Me.LblRamal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblRamal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblRamal.Location = New System.Drawing.Point(440, 520)
        Me.LblRamal.Name = "LblRamal"
        Me.LblRamal.Size = New System.Drawing.Size(40, 15)
        Me.LblRamal.TabIndex = 252
        Me.LblRamal.Text = "Ramal"
        Me.LblRamal.Visible = False
        '
        'LblTelefone
        '
        Me.LblTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblTelefone.AutoSize = True
        Me.LblTelefone.BackColor = System.Drawing.Color.Transparent
        Me.LblTelefone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblTelefone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblTelefone.Location = New System.Drawing.Point(112, 520)
        Me.LblTelefone.Name = "LblTelefone"
        Me.LblTelefone.Size = New System.Drawing.Size(51, 15)
        Me.LblTelefone.TabIndex = 251
        Me.LblTelefone.Text = "Telefone"
        Me.LblTelefone.Visible = False
        '
        'LblFunção
        '
        Me.LblFunção.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblFunção.AutoSize = True
        Me.LblFunção.BackColor = System.Drawing.Color.Transparent
        Me.LblFunção.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblFunção.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblFunção.Location = New System.Drawing.Point(334, 458)
        Me.LblFunção.Name = "LblFunção"
        Me.LblFunção.Size = New System.Drawing.Size(46, 15)
        Me.LblFunção.TabIndex = 250
        Me.LblFunção.Text = "Função"
        Me.LblFunção.Visible = False
        '
        'LblDepartamento
        '
        Me.LblDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblDepartamento.AutoSize = True
        Me.LblDepartamento.BackColor = System.Drawing.Color.Transparent
        Me.LblDepartamento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblDepartamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblDepartamento.Location = New System.Drawing.Point(112, 458)
        Me.LblDepartamento.Name = "LblDepartamento"
        Me.LblDepartamento.Size = New System.Drawing.Size(83, 15)
        Me.LblDepartamento.TabIndex = 249
        Me.LblDepartamento.Text = "Departamento"
        Me.LblDepartamento.Visible = False
        '
        'LblEmpresa
        '
        Me.LblEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblEmpresa.AutoSize = True
        Me.LblEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.LblEmpresa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblEmpresa.Location = New System.Drawing.Point(112, 396)
        Me.LblEmpresa.Name = "LblEmpresa"
        Me.LblEmpresa.Size = New System.Drawing.Size(52, 15)
        Me.LblEmpresa.TabIndex = 248
        Me.LblEmpresa.Text = "Empresa"
        Me.LblEmpresa.Visible = False
        '
        'LblUF
        '
        Me.LblUF.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblUF.AutoSize = True
        Me.LblUF.BackColor = System.Drawing.Color.Transparent
        Me.LblUF.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblUF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblUF.Location = New System.Drawing.Point(506, 250)
        Me.LblUF.Name = "LblUF"
        Me.LblUF.Size = New System.Drawing.Size(21, 15)
        Me.LblUF.TabIndex = 247
        Me.LblUF.Text = "UF"
        Me.LblUF.Visible = False
        '
        'LblCidade
        '
        Me.LblCidade.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblCidade.AutoSize = True
        Me.LblCidade.BackColor = System.Drawing.Color.Transparent
        Me.LblCidade.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblCidade.Location = New System.Drawing.Point(251, 250)
        Me.LblCidade.Name = "LblCidade"
        Me.LblCidade.Size = New System.Drawing.Size(44, 15)
        Me.LblCidade.TabIndex = 246
        Me.LblCidade.Text = "Cidade"
        Me.LblCidade.Visible = False
        '
        'LblComplemento
        '
        Me.LblComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblComplemento.AutoSize = True
        Me.LblComplemento.BackColor = System.Drawing.Color.Transparent
        Me.LblComplemento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblComplemento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblComplemento.Location = New System.Drawing.Point(112, 250)
        Me.LblComplemento.Name = "LblComplemento"
        Me.LblComplemento.Size = New System.Drawing.Size(84, 15)
        Me.LblComplemento.TabIndex = 245
        Me.LblComplemento.Text = "Complemento"
        Me.LblComplemento.Visible = False
        '
        'LblEndereço
        '
        Me.LblEndereço.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblEndereço.AutoSize = True
        Me.LblEndereço.BackColor = System.Drawing.Color.Transparent
        Me.LblEndereço.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblEndereço.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblEndereço.Location = New System.Drawing.Point(232, 188)
        Me.LblEndereço.Name = "LblEndereço"
        Me.LblEndereço.Size = New System.Drawing.Size(56, 15)
        Me.LblEndereço.TabIndex = 244
        Me.LblEndereço.Text = "Endereço"
        Me.LblEndereço.Visible = False
        '
        'LblCep
        '
        Me.LblCep.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblCep.AutoSize = True
        Me.LblCep.BackColor = System.Drawing.Color.Transparent
        Me.LblCep.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblCep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblCep.Location = New System.Drawing.Point(112, 188)
        Me.LblCep.Name = "LblCep"
        Me.LblCep.Size = New System.Drawing.Size(28, 15)
        Me.LblCep.TabIndex = 243
        Me.LblCep.Text = "Cep"
        Me.LblCep.Visible = False
        '
        'LblCelular
        '
        Me.LblCelular.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblCelular.AutoSize = True
        Me.LblCelular.BackColor = System.Drawing.Color.Transparent
        Me.LblCelular.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblCelular.Location = New System.Drawing.Point(395, 127)
        Me.LblCelular.Name = "LblCelular"
        Me.LblCelular.Size = New System.Drawing.Size(44, 15)
        Me.LblCelular.TabIndex = 242
        Me.LblCelular.Text = "Celular"
        Me.LblCelular.Visible = False
        '
        'LblNascimento
        '
        Me.LblNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblNascimento.AutoSize = True
        Me.LblNascimento.BackColor = System.Drawing.Color.Transparent
        Me.LblNascimento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblNascimento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblNascimento.Location = New System.Drawing.Point(112, 126)
        Me.LblNascimento.Name = "LblNascimento"
        Me.LblNascimento.Size = New System.Drawing.Size(71, 15)
        Me.LblNascimento.TabIndex = 241
        Me.LblNascimento.Text = "Nascimento"
        Me.LblNascimento.Visible = False
        '
        'LblGenero
        '
        Me.LblGenero.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblGenero.AutoSize = True
        Me.LblGenero.BackColor = System.Drawing.Color.Transparent
        Me.LblGenero.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblGenero.Location = New System.Drawing.Point(261, 126)
        Me.LblGenero.Name = "LblGenero"
        Me.LblGenero.Size = New System.Drawing.Size(45, 15)
        Me.LblGenero.TabIndex = 240
        Me.LblGenero.Text = "Genero"
        Me.LblGenero.Visible = False
        '
        'LblNome
        '
        Me.LblNome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblNome.AutoSize = True
        Me.LblNome.BackColor = System.Drawing.Color.Transparent
        Me.LblNome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblNome.Location = New System.Drawing.Point(112, 66)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(48, 15)
        Me.LblNome.TabIndex = 239
        Me.LblNome.Text = "Nome *"
        Me.LblNome.Visible = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.Animated = True
        Me.btnSalvar.AutoRoundedCorners = True
        Me.btnSalvar.BorderRadius = 18
        Me.btnSalvar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnSalvar.CheckedState.Parent = Me.btnSalvar
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.CustomImages.Parent = Me.btnSalvar
        Me.btnSalvar.DisabledState.Parent = Me.btnSalvar
        Me.btnSalvar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSalvar.FillColor2 = System.Drawing.Color.Black
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnSalvar.HoverState.Parent = Me.btnSalvar
        Me.btnSalvar.Location = New System.Drawing.Point(353, 784)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.ShadowDecoration.Parent = Me.btnSalvar
        Me.btnSalvar.Size = New System.Drawing.Size(124, 38)
        Me.btnSalvar.TabIndex = 226
        Me.btnSalvar.Text = "SALVAR"
        '
        'lblTermos
        '
        Me.lblTermos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTermos.AutoSize = True
        Me.lblTermos.BackColor = System.Drawing.Color.Transparent
        Me.lblTermos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTermos.LinkColor = System.Drawing.Color.DodgerBlue
        Me.lblTermos.Location = New System.Drawing.Point(246, 609)
        Me.lblTermos.Name = "lblTermos"
        Me.lblTermos.Size = New System.Drawing.Size(112, 15)
        Me.lblTermos.TabIndex = 238
        Me.lblTermos.TabStop = True
        Me.lblTermos.Text = "Termos e condições"
        '
        'cbGenero
        '
        Me.cbGenero.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbGenero.BackColor = System.Drawing.Color.Transparent
        Me.cbGenero.BorderColor = System.Drawing.Color.Gray
        Me.cbGenero.BorderRadius = 17
        Me.cbGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGenero.FillColor = System.Drawing.Color.WhiteSmoke
        Me.cbGenero.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.cbGenero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.cbGenero.FocusedState.Parent = Me.cbGenero
        Me.cbGenero.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbGenero.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.cbGenero.HoverState.Parent = Me.cbGenero
        Me.cbGenero.ItemHeight = 30
        Me.cbGenero.Items.AddRange(New Object() {"Feminino", "Masculino", "Personalizado"})
        Me.cbGenero.ItemsAppearance.Parent = Me.cbGenero
        Me.cbGenero.Location = New System.Drawing.Point(261, 145)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.ShadowDecoration.Parent = Me.cbGenero
        Me.cbGenero.Size = New System.Drawing.Size(131, 36)
        Me.cbGenero.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbGenero.TabIndex = 212
        Me.cbGenero.TextOffset = New System.Drawing.Point(5, 0)
        Me.cbGenero.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'lblInfDados
        '
        Me.lblInfDados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInfDados.AutoSize = False
        Me.lblInfDados.BackColor = System.Drawing.Color.Transparent
        Me.lblInfDados.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfDados.ForeColor = System.Drawing.Color.Gray
        Me.lblInfDados.Location = New System.Drawing.Point(133, 581)
        Me.lblInfDados.Name = "lblInfDados"
        Me.lblInfDados.Size = New System.Drawing.Size(435, 54)
        Me.lblInfDados.TabIndex = 234
        Me.lblInfDados.Text = "Vamos manter os seus dados só enquanto assim o pretender. Ficarão sempre em segur" &
    "ança e a qualquer momento pode deixar de receber nossas mensagens ou editar os s" &
    "eus dados. "
        '
        'pbWhats
        '
        Me.pbWhats.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbWhats.Image = CType(resources.GetObject("pbWhats.Image"), System.Drawing.Image)
        Me.pbWhats.ImageRotate = 0!
        Me.pbWhats.Location = New System.Drawing.Point(98, 653)
        Me.pbWhats.Name = "pbWhats"
        Me.pbWhats.ShadowDecoration.Parent = Me.pbWhats
        Me.pbWhats.Size = New System.Drawing.Size(12, 12)
        Me.pbWhats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbWhats.TabIndex = 235
        Me.pbWhats.TabStop = False
        Me.pbWhats.Visible = False
        '
        'txtCidade
        '
        Me.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCidade.Animated = True
        Me.txtCidade.AutoRoundedCorners = True
        Me.txtCidade.BackColor = System.Drawing.Color.Transparent
        Me.txtCidade.BorderColor = System.Drawing.Color.Gray
        Me.txtCidade.BorderRadius = 17
        Me.txtCidade.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtCidade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCidade.DefaultText = ""
        Me.txtCidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCidade.DisabledState.Parent = Me.txtCidade
        Me.txtCidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCidade.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtCidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtCidade.FocusedState.Parent = Me.txtCidade
        Me.txtCidade.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCidade.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtCidade.HoverState.Parent = Me.txtCidade
        Me.txtCidade.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtCidade.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtCidade.Location = New System.Drawing.Point(251, 269)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCidade.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtCidade.PlaceholderText = "Digite a cidade..."
        Me.txtCidade.SelectedText = ""
        Me.txtCidade.ShadowDecoration.Parent = Me.txtCidade
        Me.txtCidade.Size = New System.Drawing.Size(249, 36)
        Me.txtCidade.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCidade.TabIndex = 217
        Me.txtCidade.TextOffset = New System.Drawing.Point(5, 0)
        '
        'pbEmail
        '
        Me.pbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbEmail.Image = CType(resources.GetObject("pbEmail.Image"), System.Drawing.Image)
        Me.pbEmail.ImageRotate = 0!
        Me.pbEmail.Location = New System.Drawing.Point(98, 682)
        Me.pbEmail.Name = "pbEmail"
        Me.pbEmail.ShadowDecoration.Parent = Me.pbEmail
        Me.pbEmail.Size = New System.Drawing.Size(12, 12)
        Me.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEmail.TabIndex = 236
        Me.pbEmail.TabStop = False
        Me.pbEmail.Visible = False
        '
        'txtComplemento
        '
        Me.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtComplemento.Animated = True
        Me.txtComplemento.AutoRoundedCorners = True
        Me.txtComplemento.BackColor = System.Drawing.Color.Transparent
        Me.txtComplemento.BorderColor = System.Drawing.Color.Gray
        Me.txtComplemento.BorderRadius = 17
        Me.txtComplemento.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtComplemento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtComplemento.DefaultText = ""
        Me.txtComplemento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtComplemento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtComplemento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtComplemento.DisabledState.Parent = Me.txtComplemento
        Me.txtComplemento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtComplemento.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtComplemento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtComplemento.FocusedState.Parent = Me.txtComplemento
        Me.txtComplemento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtComplemento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtComplemento.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtComplemento.HoverState.Parent = Me.txtComplemento
        Me.txtComplemento.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtComplemento.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtComplemento.Location = New System.Drawing.Point(112, 269)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComplemento.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtComplemento.PlaceholderText = "Complemento..."
        Me.txtComplemento.SelectedText = ""
        Me.txtComplemento.ShadowDecoration.Parent = Me.txtComplemento
        Me.txtComplemento.Size = New System.Drawing.Size(133, 36)
        Me.txtComplemento.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtComplemento.TabIndex = 216
        Me.txtComplemento.TextOffset = New System.Drawing.Point(5, 0)
        '
        'pbTermos
        '
        Me.pbTermos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbTermos.Image = CType(resources.GetObject("pbTermos.Image"), System.Drawing.Image)
        Me.pbTermos.ImageRotate = 0!
        Me.pbTermos.Location = New System.Drawing.Point(98, 711)
        Me.pbTermos.Name = "pbTermos"
        Me.pbTermos.ShadowDecoration.Parent = Me.pbTermos
        Me.pbTermos.Size = New System.Drawing.Size(12, 12)
        Me.pbTermos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbTermos.TabIndex = 237
        Me.pbTermos.TabStop = False
        Me.pbTermos.Visible = False
        '
        'txtCep
        '
        Me.txtCep.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCep.Animated = True
        Me.txtCep.AutoRoundedCorners = True
        Me.txtCep.BackColor = System.Drawing.Color.Transparent
        Me.txtCep.BorderColor = System.Drawing.Color.Gray
        Me.txtCep.BorderRadius = 17
        Me.txtCep.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtCep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCep.DefaultText = ""
        Me.txtCep.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCep.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCep.DisabledState.Parent = Me.txtCep
        Me.txtCep.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCep.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtCep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtCep.FocusedState.Parent = Me.txtCep
        Me.txtCep.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCep.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtCep.HoverState.Parent = Me.txtCep
        Me.txtCep.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtCep.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtCep.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtCep.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtCep.Location = New System.Drawing.Point(112, 207)
        Me.txtCep.MaxLength = 9
        Me.txtCep.Name = "txtCep"
        Me.txtCep.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCep.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtCep.PlaceholderText = "CEP..."
        Me.txtCep.SelectedText = ""
        Me.txtCep.ShadowDecoration.Parent = Me.txtCep
        Me.txtCep.Size = New System.Drawing.Size(114, 36)
        Me.txtCep.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCep.TabIndex = 214
        Me.txtCep.TextOffset = New System.Drawing.Point(5, 0)
        '
        'lblNotEmail
        '
        Me.lblNotEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.lblNotEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNotEmail.AutoSize = True
        Me.lblNotEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblNotEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNotEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotEmail.ForeColor = System.Drawing.Color.Black
        Me.lblNotEmail.Location = New System.Drawing.Point(135, 684)
        Me.lblNotEmail.Name = "lblNotEmail"
        Me.lblNotEmail.Size = New System.Drawing.Size(206, 15)
        Me.lblNotEmail.TabIndex = 233
        Me.lblNotEmail.Text = "Desejo receber notificações no E-mail"
        '
        'txtEndereco
        '
        Me.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtEndereco.Animated = True
        Me.txtEndereco.AutoRoundedCorners = True
        Me.txtEndereco.BackColor = System.Drawing.Color.Transparent
        Me.txtEndereco.BorderColor = System.Drawing.Color.Gray
        Me.txtEndereco.BorderRadius = 17
        Me.txtEndereco.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndereco.DefaultText = ""
        Me.txtEndereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEndereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEndereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEndereco.DisabledState.Parent = Me.txtEndereco
        Me.txtEndereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEndereco.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtEndereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtEndereco.FocusedState.Parent = Me.txtEndereco
        Me.txtEndereco.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEndereco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEndereco.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtEndereco.HoverState.Parent = Me.txtEndereco
        Me.txtEndereco.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtEndereco.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtEndereco.Location = New System.Drawing.Point(232, 207)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEndereco.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtEndereco.PlaceholderText = "Digite seu endereço..."
        Me.txtEndereco.SelectedText = ""
        Me.txtEndereco.ShadowDecoration.Parent = Me.txtEndereco
        Me.txtEndereco.Size = New System.Drawing.Size(360, 36)
        Me.txtEndereco.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtEndereco.TabIndex = 215
        Me.txtEndereco.TextOffset = New System.Drawing.Point(5, 0)
        '
        'lblAceiteTermo
        '
        Me.lblAceiteTermo.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.lblAceiteTermo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAceiteTermo.AutoSize = True
        Me.lblAceiteTermo.BackColor = System.Drawing.Color.Transparent
        Me.lblAceiteTermo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAceiteTermo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAceiteTermo.ForeColor = System.Drawing.Color.Black
        Me.lblAceiteTermo.Location = New System.Drawing.Point(135, 713)
        Me.lblAceiteTermo.Name = "lblAceiteTermo"
        Me.lblAceiteTermo.Size = New System.Drawing.Size(377, 15)
        Me.lblAceiteTermo.TabIndex = 232
        Me.lblAceiteTermo.Text = "Li e estou de acordo com os termos de uso e políticas de privacidade *"
        '
        'txtCell
        '
        Me.txtCell.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCell.Animated = True
        Me.txtCell.AutoRoundedCorners = True
        Me.txtCell.BackColor = System.Drawing.Color.Transparent
        Me.txtCell.BorderColor = System.Drawing.Color.Gray
        Me.txtCell.BorderRadius = 17
        Me.txtCell.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtCell.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCell.DefaultText = ""
        Me.txtCell.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCell.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCell.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCell.DisabledState.Parent = Me.txtCell
        Me.txtCell.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCell.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtCell.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtCell.FocusedState.Parent = Me.txtCell
        Me.txtCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCell.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtCell.HoverState.Parent = Me.txtCell
        Me.txtCell.IconLeft = CType(resources.GetObject("txtCell.IconLeft"), System.Drawing.Image)
        Me.txtCell.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtCell.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtCell.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtCell.Location = New System.Drawing.Point(398, 145)
        Me.txtCell.MaxLength = 35
        Me.txtCell.Name = "txtCell"
        Me.txtCell.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCell.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtCell.PlaceholderText = "Digite seu celular..."
        Me.txtCell.SelectedText = ""
        Me.txtCell.ShadowDecoration.Parent = Me.txtCell
        Me.txtCell.Size = New System.Drawing.Size(194, 36)
        Me.txtCell.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCell.TabIndex = 213
        Me.txtCell.TextOffset = New System.Drawing.Point(5, 0)
        '
        'lblNotWhats
        '
        Me.lblNotWhats.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.lblNotWhats.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNotWhats.AutoSize = True
        Me.lblNotWhats.BackColor = System.Drawing.Color.Transparent
        Me.lblNotWhats.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNotWhats.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotWhats.ForeColor = System.Drawing.Color.Black
        Me.lblNotWhats.Location = New System.Drawing.Point(135, 655)
        Me.lblNotWhats.Name = "lblNotWhats"
        Me.lblNotWhats.Size = New System.Drawing.Size(223, 15)
        Me.lblNotWhats.TabIndex = 231
        Me.lblNotWhats.Text = "Desejo receber notificações no whatsapp"
        '
        'txtNome
        '
        Me.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNome.Animated = True
        Me.txtNome.AutoRoundedCorners = True
        Me.txtNome.BackColor = System.Drawing.Color.Transparent
        Me.txtNome.BorderColor = System.Drawing.Color.Gray
        Me.txtNome.BorderRadius = 17
        Me.txtNome.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNome.DefaultText = ""
        Me.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNome.DisabledState.Parent = Me.txtNome
        Me.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNome.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtNome.FocusedState.Parent = Me.txtNome
        Me.txtNome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNome.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtNome.HoverState.Parent = Me.txtNome
        Me.txtNome.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtNome.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtNome.Location = New System.Drawing.Point(101, 84)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNome.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtNome.PlaceholderText = "Digite seu nome... *"
        Me.txtNome.SelectedText = ""
        Me.txtNome.ShadowDecoration.Parent = Me.txtNome
        Me.txtNome.Size = New System.Drawing.Size(480, 36)
        Me.txtNome.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtNome.TabIndex = 210
        Me.txtNome.TextOffset = New System.Drawing.Point(5, 0)
        '
        'chkPerfilWhats
        '
        Me.chkPerfilWhats.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkPerfilWhats.BackColor = System.Drawing.Color.Transparent
        Me.chkPerfilWhats.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.chkPerfilWhats.CheckedState.BorderRadius = 3
        Me.chkPerfilWhats.CheckedState.BorderThickness = 1
        Me.chkPerfilWhats.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.chkPerfilWhats.CheckedState.Parent = Me.chkPerfilWhats
        Me.chkPerfilWhats.CheckMarkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkPerfilWhats.Location = New System.Drawing.Point(112, 653)
        Me.chkPerfilWhats.Name = "chkPerfilWhats"
        Me.chkPerfilWhats.ShadowDecoration.Parent = Me.chkPerfilWhats
        Me.chkPerfilWhats.Size = New System.Drawing.Size(20, 20)
        Me.chkPerfilWhats.TabIndex = 228
        Me.chkPerfilWhats.UncheckedState.BorderColor = System.Drawing.Color.Gray
        Me.chkPerfilWhats.UncheckedState.BorderRadius = 3
        Me.chkPerfilWhats.UncheckedState.BorderThickness = 1
        Me.chkPerfilWhats.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.chkPerfilWhats.UncheckedState.Parent = Me.chkPerfilWhats
        Me.chkPerfilWhats.UseTransparentBackground = True
        '
        'txtUF
        '
        Me.txtUF.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtUF.Animated = True
        Me.txtUF.AutoRoundedCorners = True
        Me.txtUF.BackColor = System.Drawing.Color.Transparent
        Me.txtUF.BorderColor = System.Drawing.Color.Gray
        Me.txtUF.BorderRadius = 17
        Me.txtUF.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUF.DefaultText = ""
        Me.txtUF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUF.DisabledState.Parent = Me.txtUF
        Me.txtUF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUF.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtUF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtUF.FocusedState.Parent = Me.txtUF
        Me.txtUF.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUF.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtUF.HoverState.Parent = Me.txtUF
        Me.txtUF.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtUF.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtUF.Location = New System.Drawing.Point(506, 269)
        Me.txtUF.MaxLength = 2
        Me.txtUF.Name = "txtUF"
        Me.txtUF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUF.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtUF.PlaceholderText = "UF..."
        Me.txtUF.SelectedText = ""
        Me.txtUF.ShadowDecoration.Parent = Me.txtUF
        Me.txtUF.Size = New System.Drawing.Size(86, 36)
        Me.txtUF.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtUF.TabIndex = 218
        Me.txtUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUF.TextOffset = New System.Drawing.Point(5, 0)
        '
        'chkPerfilEmail
        '
        Me.chkPerfilEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkPerfilEmail.BackColor = System.Drawing.Color.Transparent
        Me.chkPerfilEmail.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.chkPerfilEmail.CheckedState.BorderRadius = 3
        Me.chkPerfilEmail.CheckedState.BorderThickness = 1
        Me.chkPerfilEmail.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.chkPerfilEmail.CheckedState.Parent = Me.chkPerfilEmail
        Me.chkPerfilEmail.CheckMarkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkPerfilEmail.Location = New System.Drawing.Point(112, 682)
        Me.chkPerfilEmail.Name = "chkPerfilEmail"
        Me.chkPerfilEmail.ShadowDecoration.Parent = Me.chkPerfilEmail
        Me.chkPerfilEmail.Size = New System.Drawing.Size(20, 20)
        Me.chkPerfilEmail.TabIndex = 229
        Me.chkPerfilEmail.UncheckedState.BorderColor = System.Drawing.Color.Gray
        Me.chkPerfilEmail.UncheckedState.BorderRadius = 3
        Me.chkPerfilEmail.UncheckedState.BorderThickness = 1
        Me.chkPerfilEmail.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.chkPerfilEmail.UncheckedState.Parent = Me.chkPerfilEmail
        Me.chkPerfilEmail.UseTransparentBackground = True
        '
        'txtNascimento
        '
        Me.txtNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNascimento.Animated = True
        Me.txtNascimento.AutoRoundedCorners = True
        Me.txtNascimento.BackColor = System.Drawing.Color.Transparent
        Me.txtNascimento.BorderColor = System.Drawing.Color.Gray
        Me.txtNascimento.BorderRadius = 17
        Me.txtNascimento.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtNascimento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNascimento.DefaultText = ""
        Me.txtNascimento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNascimento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNascimento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNascimento.DisabledState.Parent = Me.txtNascimento
        Me.txtNascimento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNascimento.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtNascimento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtNascimento.FocusedState.Parent = Me.txtNascimento
        Me.txtNascimento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNascimento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNascimento.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtNascimento.HoverState.Parent = Me.txtNascimento
        Me.txtNascimento.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtNascimento.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtNascimento.Location = New System.Drawing.Point(112, 145)
        Me.txtNascimento.MaxLength = 8
        Me.txtNascimento.Name = "txtNascimento"
        Me.txtNascimento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNascimento.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtNascimento.PlaceholderText = "Nascimento..."
        Me.txtNascimento.SelectedText = ""
        Me.txtNascimento.ShadowDecoration.Parent = Me.txtNascimento
        Me.txtNascimento.Size = New System.Drawing.Size(143, 36)
        Me.txtNascimento.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtNascimento.TabIndex = 211
        Me.txtNascimento.TextOffset = New System.Drawing.Point(5, 0)
        '
        'chkPerfilTermos
        '
        Me.chkPerfilTermos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkPerfilTermos.BackColor = System.Drawing.Color.Transparent
        Me.chkPerfilTermos.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.chkPerfilTermos.CheckedState.BorderRadius = 3
        Me.chkPerfilTermos.CheckedState.BorderThickness = 1
        Me.chkPerfilTermos.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.chkPerfilTermos.CheckedState.Parent = Me.chkPerfilTermos
        Me.chkPerfilTermos.CheckMarkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkPerfilTermos.Location = New System.Drawing.Point(112, 711)
        Me.chkPerfilTermos.Name = "chkPerfilTermos"
        Me.chkPerfilTermos.ShadowDecoration.Parent = Me.chkPerfilTermos
        Me.chkPerfilTermos.Size = New System.Drawing.Size(20, 20)
        Me.chkPerfilTermos.TabIndex = 230
        Me.chkPerfilTermos.UncheckedState.BorderColor = System.Drawing.Color.Gray
        Me.chkPerfilTermos.UncheckedState.BorderRadius = 3
        Me.chkPerfilTermos.UncheckedState.BorderThickness = 1
        Me.chkPerfilTermos.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.chkPerfilTermos.UncheckedState.Parent = Me.chkPerfilTermos
        Me.chkPerfilTermos.UseTransparentBackground = True
        '
        'txtRamal
        '
        Me.txtRamal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRamal.Animated = True
        Me.txtRamal.AutoRoundedCorners = True
        Me.txtRamal.BackColor = System.Drawing.Color.Transparent
        Me.txtRamal.BorderColor = System.Drawing.Color.Gray
        Me.txtRamal.BorderRadius = 17
        Me.txtRamal.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtRamal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRamal.DefaultText = ""
        Me.txtRamal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRamal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRamal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRamal.DisabledState.Parent = Me.txtRamal
        Me.txtRamal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRamal.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtRamal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtRamal.FocusedState.Parent = Me.txtRamal
        Me.txtRamal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRamal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRamal.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtRamal.HoverState.Parent = Me.txtRamal
        Me.txtRamal.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtRamal.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtRamal.Location = New System.Drawing.Point(440, 539)
        Me.txtRamal.MaxLength = 5
        Me.txtRamal.Name = "txtRamal"
        Me.txtRamal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRamal.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtRamal.PlaceholderText = "Digite seu ramal..."
        Me.txtRamal.SelectedText = ""
        Me.txtRamal.ShadowDecoration.Parent = Me.txtRamal
        Me.txtRamal.Size = New System.Drawing.Size(152, 36)
        Me.txtRamal.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtRamal.TabIndex = 223
        Me.txtRamal.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtTel
        '
        Me.txtTel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTel.Animated = True
        Me.txtTel.AutoRoundedCorners = True
        Me.txtTel.BackColor = System.Drawing.Color.Transparent
        Me.txtTel.BorderColor = System.Drawing.Color.Gray
        Me.txtTel.BorderRadius = 17
        Me.txtTel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTel.DefaultText = ""
        Me.txtTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTel.DisabledState.Parent = Me.txtTel
        Me.txtTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTel.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtTel.FocusedState.Parent = Me.txtTel
        Me.txtTel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTel.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtTel.HoverState.Parent = Me.txtTel
        Me.txtTel.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtTel.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtTel.Location = New System.Drawing.Point(112, 539)
        Me.txtTel.MaxLength = 10
        Me.txtTel.Name = "txtTel"
        Me.txtTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTel.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtTel.PlaceholderText = "Digite o telefone..."
        Me.txtTel.SelectedText = ""
        Me.txtTel.ShadowDecoration.Parent = Me.txtTel
        Me.txtTel.Size = New System.Drawing.Size(322, 36)
        Me.txtTel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtTel.TabIndex = 222
        Me.txtTel.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.Animated = True
        Me.btnCancel.AutoRoundedCorners = True
        Me.btnCancel.BorderRadius = 18
        Me.btnCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.DisabledState.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnCancel.FillColor2 = System.Drawing.Color.Black
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(223, 784)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(124, 38)
        Me.btnCancel.TabIndex = 227
        Me.btnCancel.Text = "CANCELAR"
        '
        'txtFuncao
        '
        Me.txtFuncao.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFuncao.Animated = True
        Me.txtFuncao.AutoRoundedCorners = True
        Me.txtFuncao.BackColor = System.Drawing.Color.Transparent
        Me.txtFuncao.BorderColor = System.Drawing.Color.Gray
        Me.txtFuncao.BorderRadius = 17
        Me.txtFuncao.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtFuncao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFuncao.DefaultText = ""
        Me.txtFuncao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFuncao.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFuncao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFuncao.DisabledState.Parent = Me.txtFuncao
        Me.txtFuncao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFuncao.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtFuncao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtFuncao.FocusedState.Parent = Me.txtFuncao
        Me.txtFuncao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFuncao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFuncao.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtFuncao.HoverState.Parent = Me.txtFuncao
        Me.txtFuncao.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtFuncao.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtFuncao.Location = New System.Drawing.Point(334, 477)
        Me.txtFuncao.Name = "txtFuncao"
        Me.txtFuncao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFuncao.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtFuncao.PlaceholderText = "Digite sua função..."
        Me.txtFuncao.SelectedText = ""
        Me.txtFuncao.ShadowDecoration.Parent = Me.txtFuncao
        Me.txtFuncao.Size = New System.Drawing.Size(258, 36)
        Me.txtFuncao.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtFuncao.TabIndex = 221
        Me.txtFuncao.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtDepart
        '
        Me.txtDepart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDepart.Animated = True
        Me.txtDepart.AutoRoundedCorners = True
        Me.txtDepart.BackColor = System.Drawing.Color.Transparent
        Me.txtDepart.BorderColor = System.Drawing.Color.Gray
        Me.txtDepart.BorderRadius = 17
        Me.txtDepart.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtDepart.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDepart.DefaultText = ""
        Me.txtDepart.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDepart.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDepart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDepart.DisabledState.Parent = Me.txtDepart
        Me.txtDepart.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDepart.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtDepart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtDepart.FocusedState.Parent = Me.txtDepart
        Me.txtDepart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDepart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDepart.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtDepart.HoverState.Parent = Me.txtDepart
        Me.txtDepart.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtDepart.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtDepart.Location = New System.Drawing.Point(112, 477)
        Me.txtDepart.Name = "txtDepart"
        Me.txtDepart.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDepart.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtDepart.PlaceholderText = "Digite seu departamento..."
        Me.txtDepart.SelectedText = ""
        Me.txtDepart.ShadowDecoration.Parent = Me.txtDepart
        Me.txtDepart.Size = New System.Drawing.Size(216, 36)
        Me.txtDepart.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtDepart.TabIndex = 220
        Me.txtDepart.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtEmpresa.Animated = True
        Me.txtEmpresa.AutoRoundedCorners = True
        Me.txtEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.txtEmpresa.BorderColor = System.Drawing.Color.Gray
        Me.txtEmpresa.BorderRadius = 17
        Me.txtEmpresa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmpresa.DefaultText = ""
        Me.txtEmpresa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmpresa.DisabledState.Parent = Me.txtEmpresa
        Me.txtEmpresa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmpresa.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmpresa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtEmpresa.FocusedState.Parent = Me.txtEmpresa
        Me.txtEmpresa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmpresa.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.txtEmpresa.HoverState.Parent = Me.txtEmpresa
        Me.txtEmpresa.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtEmpresa.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtEmpresa.Location = New System.Drawing.Point(112, 415)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpresa.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtEmpresa.PlaceholderText = "Digite o nome da empresa..."
        Me.txtEmpresa.SelectedText = ""
        Me.txtEmpresa.ShadowDecoration.Parent = Me.txtEmpresa
        Me.txtEmpresa.Size = New System.Drawing.Size(480, 36)
        Me.txtEmpresa.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtEmpresa.TabIndex = 219
        Me.txtEmpresa.TextOffset = New System.Drawing.Point(5, 0)
        '
        'lblInfoB
        '
        Me.lblInfoB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInfoB.AutoSize = True
        Me.lblInfoB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInfoB.Location = New System.Drawing.Point(68, 361)
        Me.lblInfoB.Name = "lblInfoB"
        Me.lblInfoB.Size = New System.Drawing.Size(235, 21)
        Me.lblInfoB.TabIndex = 225
        Me.lblInfoB.Text = "INFORMÇÕES PROFISSIONAIS"
        '
        'lblInfoP
        '
        Me.lblInfoP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInfoP.AutoSize = True
        Me.lblInfoP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblInfoP.Location = New System.Drawing.Point(68, 26)
        Me.lblInfoP.Name = "lblInfoP"
        Me.lblInfoP.Size = New System.Drawing.Size(191, 21)
        Me.lblInfoP.TabIndex = 224
        Me.lblInfoP.Text = "INFORMÇÕES PESSOAIS"
        '
        'tpInfoPerfil
        '
        Me.tpInfoPerfil.AutoScroll = True
        Me.tpInfoPerfil.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tpInfoPerfil.Controls.Add(Me.TableLayoutPanel1)
        Me.tpInfoPerfil.Location = New System.Drawing.Point(4, 4)
        Me.tpInfoPerfil.Name = "tpInfoPerfil"
        Me.tpInfoPerfil.Padding = New System.Windows.Forms.Padding(3)
        Me.tpInfoPerfil.Size = New System.Drawing.Size(780, 539)
        Me.tpInfoPerfil.TabIndex = 0
        Me.tpInfoPerfil.Text = "Perfil"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(757, 891)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BtnCopy)
        Me.Guna2Panel1.Controls.Add(Me.btnEditSenha)
        Me.Guna2Panel1.Controls.Add(Me.BtnEditEmail)
        Me.Guna2Panel1.Controls.Add(Me.btnDeletar)
        Me.Guna2Panel1.Controls.Add(Me.btnEdit)
        Me.Guna2Panel1.Controls.Add(Me.lblChaveKey)
        Me.Guna2Panel1.Controls.Add(Me.lblUserInfo)
        Me.Guna2Panel1.Controls.Add(Me.imgPerfil)
        Me.Guna2Panel1.Controls.Add(Me.pbBordaLeft)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(28, 33)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(701, 825)
        Me.Guna2Panel1.TabIndex = 0
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
        Me.BtnCopy.Location = New System.Drawing.Point(568, 183)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.PressedColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCopy.ShadowDecoration.Parent = Me.BtnCopy
        Me.BtnCopy.Size = New System.Drawing.Size(37, 37)
        Me.BtnCopy.TabIndex = 198
        '
        'btnEditSenha
        '
        Me.btnEditSenha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditSenha.Animated = True
        Me.btnEditSenha.AutoRoundedCorners = True
        Me.btnEditSenha.BorderRadius = 11
        Me.btnEditSenha.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnEditSenha.CheckedState.Parent = Me.btnEditSenha
        Me.btnEditSenha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditSenha.CustomImages.Parent = Me.btnEditSenha
        Me.btnEditSenha.DisabledState.Parent = Me.btnEditSenha
        Me.btnEditSenha.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnEditSenha.FillColor2 = System.Drawing.Color.Black
        Me.btnEditSenha.Font = New System.Drawing.Font("Segoe UI", 6.5!, System.Drawing.FontStyle.Bold)
        Me.btnEditSenha.ForeColor = System.Drawing.Color.White
        Me.btnEditSenha.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnEditSenha.HoverState.Parent = Me.btnEditSenha
        Me.btnEditSenha.Image = CType(resources.GetObject("btnEditSenha.Image"), System.Drawing.Image)
        Me.btnEditSenha.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.btnEditSenha.ImageSize = New System.Drawing.Size(13, 13)
        Me.btnEditSenha.Location = New System.Drawing.Point(563, 297)
        Me.btnEditSenha.Name = "btnEditSenha"
        Me.btnEditSenha.ShadowDecoration.Parent = Me.btnEditSenha
        Me.btnEditSenha.Size = New System.Drawing.Size(72, 24)
        Me.btnEditSenha.TabIndex = 197
        Me.btnEditSenha.Text = "SENHA"
        Me.btnEditSenha.TextOffset = New System.Drawing.Point(1, 0)
        '
        'BtnEditEmail
        '
        Me.BtnEditEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEditEmail.Animated = True
        Me.BtnEditEmail.AutoRoundedCorners = True
        Me.BtnEditEmail.BorderRadius = 11
        Me.BtnEditEmail.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnEditEmail.CheckedState.Parent = Me.BtnEditEmail
        Me.BtnEditEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditEmail.CustomImages.Parent = Me.BtnEditEmail
        Me.BtnEditEmail.DisabledState.Parent = Me.BtnEditEmail
        Me.BtnEditEmail.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnEditEmail.FillColor2 = System.Drawing.Color.Black
        Me.BtnEditEmail.Font = New System.Drawing.Font("Segoe UI", 6.5!, System.Drawing.FontStyle.Bold)
        Me.BtnEditEmail.ForeColor = System.Drawing.Color.White
        Me.BtnEditEmail.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnEditEmail.HoverState.Parent = Me.BtnEditEmail
        Me.BtnEditEmail.Image = CType(resources.GetObject("BtnEditEmail.Image"), System.Drawing.Image)
        Me.BtnEditEmail.ImageOffset = New System.Drawing.Point(-1, 0)
        Me.BtnEditEmail.ImageSize = New System.Drawing.Size(13, 13)
        Me.BtnEditEmail.Location = New System.Drawing.Point(563, 324)
        Me.BtnEditEmail.Name = "BtnEditEmail"
        Me.BtnEditEmail.ShadowDecoration.Parent = Me.BtnEditEmail
        Me.BtnEditEmail.Size = New System.Drawing.Size(72, 24)
        Me.BtnEditEmail.TabIndex = 196
        Me.BtnEditEmail.Text = "E-MAIL"
        Me.BtnEditEmail.TextOffset = New System.Drawing.Point(1, 0)
        '
        'btnDeletar
        '
        Me.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeletar.Animated = True
        Me.btnDeletar.BorderRadius = 18
        Me.btnDeletar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnDeletar.CheckedState.Parent = Me.btnDeletar
        Me.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeletar.CustomImages.Parent = Me.btnDeletar
        Me.btnDeletar.DisabledState.Parent = Me.btnDeletar
        Me.btnDeletar.FillColor = System.Drawing.Color.Red
        Me.btnDeletar.FillColor2 = System.Drawing.Color.Black
        Me.btnDeletar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeletar.ForeColor = System.Drawing.Color.White
        Me.btnDeletar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnDeletar.HoverState.Parent = Me.btnDeletar
        Me.btnDeletar.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnDeletar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDeletar.Location = New System.Drawing.Point(352, 752)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.ShadowDecoration.Parent = Me.btnDeletar
        Me.btnDeletar.Size = New System.Drawing.Size(124, 38)
        Me.btnDeletar.TabIndex = 194
        Me.btnDeletar.Text = "EXCLUIR"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEdit.Animated = True
        Me.btnEdit.BorderRadius = 18
        Me.btnEdit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.DisabledState.Parent = Me.btnEdit
        Me.btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnEdit.FillColor2 = System.Drawing.Color.Black
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.ImageOffset = New System.Drawing.Point(1, -1)
        Me.btnEdit.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEdit.Location = New System.Drawing.Point(224, 753)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(124, 38)
        Me.btnEdit.TabIndex = 193
        Me.btnEdit.Text = "EDITAR"
        '
        'lblChaveKey
        '
        Me.lblChaveKey.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblChaveKey.AutoSize = False
        Me.lblChaveKey.BackColor = System.Drawing.Color.Transparent
        Me.lblChaveKey.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChaveKey.ForeColor = System.Drawing.Color.Black
        Me.lblChaveKey.Location = New System.Drawing.Point(144, 194)
        Me.lblChaveKey.Name = "lblChaveKey"
        Me.lblChaveKey.Size = New System.Drawing.Size(412, 21)
        Me.lblChaveKey.TabIndex = 192
        Me.lblChaveKey.Text = "..."
        Me.lblChaveKey.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUserInfo
        '
        Me.lblUserInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUserInfo.AutoSize = False
        Me.lblUserInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblUserInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInfo.ForeColor = System.Drawing.Color.Black
        Me.lblUserInfo.Location = New System.Drawing.Point(62, 261)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(503, 474)
        Me.lblUserInfo.TabIndex = 190
        Me.lblUserInfo.Text = resources.GetString("lblUserInfo.Text")
        '
        'imgPerfil
        '
        Me.imgPerfil.AllowFocused = False
        Me.imgPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imgPerfil.AutoSizeHeight = True
        Me.imgPerfil.BackColor = System.Drawing.Color.White
        Me.imgPerfil.BorderRadius = 65
        Me.imgPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgPerfil.Image = CType(resources.GetObject("imgPerfil.Image"), System.Drawing.Image)
        Me.imgPerfil.IsCircle = True
        Me.imgPerfil.Location = New System.Drawing.Point(285, 38)
        Me.imgPerfil.Name = "imgPerfil"
        Me.imgPerfil.Size = New System.Drawing.Size(130, 130)
        Me.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPerfil.TabIndex = 191
        Me.imgPerfil.TabStop = False
        Me.imgPerfil.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'bpInfo
        '
        Me.bpInfo.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.bpInfo.AllowTransitions = True
        Me.bpInfo.Controls.Add(Me.tpInfoPerfil)
        Me.bpInfo.Controls.Add(Me.tpEdit)
        Me.bpInfo.Controls.Add(Me.tpEditEmail)
        Me.bpInfo.Controls.Add(Me.tpEditSenha)
        Me.bpInfo.Controls.Add(Me.TpLoading)
        Me.bpInfo.Controls.Add(Me.TpValidar)
        Me.bpInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bpInfo.Location = New System.Drawing.Point(0, 0)
        Me.bpInfo.Multiline = True
        Me.bpInfo.Name = "bpInfo"
        Me.bpInfo.Page = Me.tpInfoPerfil
        Me.bpInfo.PageIndex = 0
        Me.bpInfo.PageName = "tpInfoPerfil"
        Me.bpInfo.PageTitle = "Perfil"
        Me.bpInfo.SelectedIndex = 0
        Me.bpInfo.Size = New System.Drawing.Size(788, 565)
        Me.bpInfo.TabIndex = 171
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.bpInfo.Transition = Animation1
        Me.bpInfo.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Transparent
        '
        'tpEditEmail
        '
        Me.tpEditEmail.AutoScroll = True
        Me.tpEditEmail.BackColor = System.Drawing.SystemColors.Control
        Me.tpEditEmail.Controls.Add(Me.TableLayoutPanel3)
        Me.tpEditEmail.Location = New System.Drawing.Point(4, 4)
        Me.tpEditEmail.Name = "tpEditEmail"
        Me.tpEditEmail.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEditEmail.Size = New System.Drawing.Size(780, 539)
        Me.tpEditEmail.TabIndex = 8
        Me.tpEditEmail.Text = "Email"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Guna2Panel3, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(774, 536)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel3.Controls.Add(Me.LblEmailIncorreto)
        Me.Guna2Panel3.Controls.Add(Me.LblSenha)
        Me.Guna2Panel3.Controls.Add(Me.LblNewEmail)
        Me.Guna2Panel3.Controls.Add(Me.LblEmailSenhaIncorreta)
        Me.Guna2Panel3.Controls.Add(Me.LblEmailCapsLook)
        Me.Guna2Panel3.Controls.Add(Me.TxtSenha)
        Me.Guna2Panel3.Controls.Add(Me.BtnEmailCancel)
        Me.Guna2Panel3.Controls.Add(Me.BtnEmailEnviar)
        Me.Guna2Panel3.Controls.Add(Me.TxtNewEmail)
        Me.Guna2Panel3.Controls.Add(Me.LblEmailInf)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel3.Location = New System.Drawing.Point(28, 33)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(718, 470)
        Me.Guna2Panel3.TabIndex = 0
        '
        'LblEmailIncorreto
        '
        Me.LblEmailIncorreto.AutoSize = True
        Me.LblEmailIncorreto.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.LblEmailIncorreto.ForeColor = System.Drawing.Color.Red
        Me.LblEmailIncorreto.Location = New System.Drawing.Point(161, 194)
        Me.LblEmailIncorreto.Name = "LblEmailIncorreto"
        Me.LblEmailIncorreto.Size = New System.Drawing.Size(75, 12)
        Me.LblEmailIncorreto.TabIndex = 198
        Me.LblEmailIncorreto.Text = "Senha incorreta."
        Me.LblEmailIncorreto.Visible = False
        '
        'LblSenha
        '
        Me.LblSenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblSenha.AutoSize = True
        Me.LblSenha.BackColor = System.Drawing.Color.Transparent
        Me.LblSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblSenha.Location = New System.Drawing.Point(156, 235)
        Me.LblSenha.Name = "LblSenha"
        Me.LblSenha.Size = New System.Drawing.Size(39, 15)
        Me.LblSenha.TabIndex = 196
        Me.LblSenha.Text = "Senha"
        Me.LblSenha.Visible = False
        '
        'LblNewEmail
        '
        Me.LblNewEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblNewEmail.AutoSize = True
        Me.LblNewEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblNewEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblNewEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblNewEmail.Location = New System.Drawing.Point(156, 137)
        Me.LblNewEmail.Name = "LblNewEmail"
        Me.LblNewEmail.Size = New System.Drawing.Size(41, 15)
        Me.LblNewEmail.TabIndex = 195
        Me.LblNewEmail.Text = "E-mail"
        Me.LblNewEmail.Visible = False
        '
        'LblEmailSenhaIncorreta
        '
        Me.LblEmailSenhaIncorreta.AutoSize = True
        Me.LblEmailSenhaIncorreta.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.LblEmailSenhaIncorreta.ForeColor = System.Drawing.Color.Red
        Me.LblEmailSenhaIncorreta.Location = New System.Drawing.Point(161, 292)
        Me.LblEmailSenhaIncorreta.Name = "LblEmailSenhaIncorreta"
        Me.LblEmailSenhaIncorreta.Size = New System.Drawing.Size(75, 12)
        Me.LblEmailSenhaIncorreta.TabIndex = 194
        Me.LblEmailSenhaIncorreta.Text = "Senha incorreta."
        Me.LblEmailSenhaIncorreta.Visible = False
        '
        'LblEmailCapsLook
        '
        Me.LblEmailCapsLook.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmailCapsLook.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.LblEmailCapsLook.Location = New System.Drawing.Point(202, 310)
        Me.LblEmailCapsLook.Name = "LblEmailCapsLook"
        Me.LblEmailCapsLook.Size = New System.Drawing.Size(314, 23)
        Me.LblEmailCapsLook.TabIndex = 193
        Me.LblEmailCapsLook.Text = "CAPS LOOK ATIVADA"
        Me.LblEmailCapsLook.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblEmailCapsLook.Visible = False
        '
        'TxtSenha
        '
        Me.TxtSenha.Animated = True
        Me.TxtSenha.AutoRoundedCorners = True
        Me.TxtSenha.BackColor = System.Drawing.Color.Transparent
        Me.TxtSenha.BorderColor = System.Drawing.Color.Gray
        Me.TxtSenha.BorderRadius = 17
        Me.TxtSenha.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.TxtSenha.ForeColor = System.Drawing.Color.Black
        Me.TxtSenha.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtSenha.HoverState.Parent = Me.TxtSenha
        Me.TxtSenha.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtSenha.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtSenha.IconRight = CType(resources.GetObject("TxtSenha.IconRight"), System.Drawing.Image)
        Me.TxtSenha.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.TxtSenha.Location = New System.Drawing.Point(155, 253)
        Me.TxtSenha.MaxLength = 18
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSenha.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtSenha.PlaceholderText = "Informe sua Senha..."
        Me.TxtSenha.SelectedText = ""
        Me.TxtSenha.ShadowDecoration.Parent = Me.TxtSenha
        Me.TxtSenha.Size = New System.Drawing.Size(408, 36)
        Me.TxtSenha.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtSenha.TabIndex = 189
        Me.TxtSenha.TextOffset = New System.Drawing.Point(5, 0)
        Me.TxtSenha.UseSystemPasswordChar = True
        '
        'BtnEmailCancel
        '
        Me.BtnEmailCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEmailCancel.Animated = True
        Me.BtnEmailCancel.AutoRoundedCorners = True
        Me.BtnEmailCancel.BorderRadius = 18
        Me.BtnEmailCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnEmailCancel.CheckedState.Parent = Me.BtnEmailCancel
        Me.BtnEmailCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmailCancel.CustomImages.Parent = Me.BtnEmailCancel
        Me.BtnEmailCancel.DisabledState.Parent = Me.BtnEmailCancel
        Me.BtnEmailCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnEmailCancel.FillColor2 = System.Drawing.Color.Black
        Me.BtnEmailCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEmailCancel.ForeColor = System.Drawing.Color.White
        Me.BtnEmailCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnEmailCancel.HoverState.Parent = Me.BtnEmailCancel
        Me.BtnEmailCancel.Location = New System.Drawing.Point(232, 381)
        Me.BtnEmailCancel.Name = "BtnEmailCancel"
        Me.BtnEmailCancel.ShadowDecoration.Parent = Me.BtnEmailCancel
        Me.BtnEmailCancel.Size = New System.Drawing.Size(124, 38)
        Me.BtnEmailCancel.TabIndex = 191
        Me.BtnEmailCancel.Text = "CANCELAR"
        '
        'BtnEmailEnviar
        '
        Me.BtnEmailEnviar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEmailEnviar.Animated = True
        Me.BtnEmailEnviar.AutoRoundedCorners = True
        Me.BtnEmailEnviar.BorderRadius = 18
        Me.BtnEmailEnviar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnEmailEnviar.CheckedState.Parent = Me.BtnEmailEnviar
        Me.BtnEmailEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmailEnviar.CustomImages.Parent = Me.BtnEmailEnviar
        Me.BtnEmailEnviar.DisabledState.Parent = Me.BtnEmailEnviar
        Me.BtnEmailEnviar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnEmailEnviar.FillColor2 = System.Drawing.Color.Black
        Me.BtnEmailEnviar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEmailEnviar.ForeColor = System.Drawing.Color.White
        Me.BtnEmailEnviar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnEmailEnviar.HoverState.Parent = Me.BtnEmailEnviar
        Me.BtnEmailEnviar.Location = New System.Drawing.Point(362, 381)
        Me.BtnEmailEnviar.Name = "BtnEmailEnviar"
        Me.BtnEmailEnviar.ShadowDecoration.Parent = Me.BtnEmailEnviar
        Me.BtnEmailEnviar.Size = New System.Drawing.Size(124, 38)
        Me.BtnEmailEnviar.TabIndex = 190
        Me.BtnEmailEnviar.Text = "ENVIAR"
        '
        'TxtNewEmail
        '
        Me.TxtNewEmail.Animated = True
        Me.TxtNewEmail.AutoRoundedCorners = True
        Me.TxtNewEmail.BackColor = System.Drawing.Color.Transparent
        Me.TxtNewEmail.BorderColor = System.Drawing.Color.Gray
        Me.TxtNewEmail.BorderRadius = 17
        Me.TxtNewEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNewEmail.DefaultText = ""
        Me.TxtNewEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtNewEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtNewEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNewEmail.DisabledState.Parent = Me.TxtNewEmail
        Me.TxtNewEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNewEmail.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtNewEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtNewEmail.FocusedState.Parent = Me.TxtNewEmail
        Me.TxtNewEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtNewEmail.ForeColor = System.Drawing.Color.Black
        Me.TxtNewEmail.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtNewEmail.HoverState.Parent = Me.TxtNewEmail
        Me.TxtNewEmail.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtNewEmail.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtNewEmail.Location = New System.Drawing.Point(156, 155)
        Me.TxtNewEmail.Name = "TxtNewEmail"
        Me.TxtNewEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtNewEmail.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtNewEmail.PlaceholderText = "Digite o novo E-mail..."
        Me.TxtNewEmail.SelectedText = ""
        Me.TxtNewEmail.ShadowDecoration.Parent = Me.TxtNewEmail
        Me.TxtNewEmail.Size = New System.Drawing.Size(408, 36)
        Me.TxtNewEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtNewEmail.TabIndex = 188
        Me.TxtNewEmail.TextOffset = New System.Drawing.Point(5, 0)
        '
        'LblEmailInf
        '
        Me.LblEmailInf.AutoSize = False
        Me.LblEmailInf.BackColor = System.Drawing.Color.Transparent
        Me.LblEmailInf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmailInf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblEmailInf.Location = New System.Drawing.Point(96, 51)
        Me.LblEmailInf.Name = "LblEmailInf"
        Me.LblEmailInf.Size = New System.Drawing.Size(526, 82)
        Me.LblEmailInf.TabIndex = 197
        Me.LblEmailInf.Text = "..."
        Me.LblEmailInf.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'tpEditSenha
        '
        Me.tpEditSenha.AutoScroll = True
        Me.tpEditSenha.BackColor = System.Drawing.SystemColors.Control
        Me.tpEditSenha.Controls.Add(Me.TableLayoutPanel4)
        Me.tpEditSenha.Location = New System.Drawing.Point(4, 4)
        Me.tpEditSenha.Name = "tpEditSenha"
        Me.tpEditSenha.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEditSenha.Size = New System.Drawing.Size(780, 539)
        Me.tpEditSenha.TabIndex = 9
        Me.tpEditSenha.Text = "Senha"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Guna2Panel4, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(757, 611)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel4.Controls.Add(Me.LblNewSenha)
        Me.Guna2Panel4.Controls.Add(Me.LblRetrySenha)
        Me.Guna2Panel4.Controls.Add(Me.LblOldSenha)
        Me.Guna2Panel4.Controls.Add(Me.TxtNewSenha)
        Me.Guna2Panel4.Controls.Add(Me.LblCapsLook)
        Me.Guna2Panel4.Controls.Add(Me.LblOldSenhaIncorreta)
        Me.Guna2Panel4.Controls.Add(Me.TxtRetrySenha)
        Me.Guna2Panel4.Controls.Add(Me.BtnSenhaCancel)
        Me.Guna2Panel4.Controls.Add(Me.BtnSenhaSalvar)
        Me.Guna2Panel4.Controls.Add(Me.LblSenhaInf)
        Me.Guna2Panel4.Controls.Add(Me.TxtOldSenha)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel4.Location = New System.Drawing.Point(28, 33)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(701, 545)
        Me.Guna2Panel4.TabIndex = 0
        '
        'LblNewSenha
        '
        Me.LblNewSenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblNewSenha.AutoSize = True
        Me.LblNewSenha.BackColor = System.Drawing.Color.Transparent
        Me.LblNewSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblNewSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblNewSenha.Location = New System.Drawing.Point(146, 206)
        Me.LblNewSenha.Name = "LblNewSenha"
        Me.LblNewSenha.Size = New System.Drawing.Size(69, 15)
        Me.LblNewSenha.TabIndex = 199
        Me.LblNewSenha.Text = "Nova senha"
        Me.LblNewSenha.Visible = False
        '
        'LblRetrySenha
        '
        Me.LblRetrySenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblRetrySenha.AutoSize = True
        Me.LblRetrySenha.BackColor = System.Drawing.Color.Transparent
        Me.LblRetrySenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblRetrySenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblRetrySenha.Location = New System.Drawing.Point(146, 286)
        Me.LblRetrySenha.Name = "LblRetrySenha"
        Me.LblRetrySenha.Size = New System.Drawing.Size(95, 15)
        Me.LblRetrySenha.TabIndex = 198
        Me.LblRetrySenha.Text = "Confirmar senha"
        Me.LblRetrySenha.Visible = False
        '
        'LblOldSenha
        '
        Me.LblOldSenha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblOldSenha.AutoSize = True
        Me.LblOldSenha.BackColor = System.Drawing.Color.Transparent
        Me.LblOldSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblOldSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblOldSenha.Location = New System.Drawing.Point(148, 124)
        Me.LblOldSenha.Name = "LblOldSenha"
        Me.LblOldSenha.Size = New System.Drawing.Size(75, 15)
        Me.LblOldSenha.TabIndex = 197
        Me.LblOldSenha.Text = "Senha antiga"
        Me.LblOldSenha.Visible = False
        '
        'TxtNewSenha
        '
        Me.TxtNewSenha.Animated = True
        Me.TxtNewSenha.AutoRoundedCorners = True
        Me.TxtNewSenha.BackColor = System.Drawing.Color.Transparent
        Me.TxtNewSenha.BorderColor = System.Drawing.Color.Gray
        Me.TxtNewSenha.BorderRadius = 17
        Me.TxtNewSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNewSenha.DefaultText = ""
        Me.TxtNewSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtNewSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtNewSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNewSenha.DisabledState.Parent = Me.TxtNewSenha
        Me.TxtNewSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtNewSenha.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtNewSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtNewSenha.FocusedState.Parent = Me.TxtNewSenha
        Me.TxtNewSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtNewSenha.ForeColor = System.Drawing.Color.Black
        Me.TxtNewSenha.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtNewSenha.HoverState.Parent = Me.TxtNewSenha
        Me.TxtNewSenha.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtNewSenha.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtNewSenha.Location = New System.Drawing.Point(146, 224)
        Me.TxtNewSenha.Name = "TxtNewSenha"
        Me.TxtNewSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtNewSenha.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtNewSenha.PlaceholderText = "Informe a nova senha..."
        Me.TxtNewSenha.SelectedText = ""
        Me.TxtNewSenha.ShadowDecoration.Parent = Me.TxtNewSenha
        Me.TxtNewSenha.Size = New System.Drawing.Size(408, 36)
        Me.TxtNewSenha.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtNewSenha.TabIndex = 182
        Me.TxtNewSenha.TextOffset = New System.Drawing.Point(5, 0)
        '
        'LblCapsLook
        '
        Me.LblCapsLook.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCapsLook.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.LblCapsLook.Location = New System.Drawing.Point(193, 349)
        Me.LblCapsLook.Name = "LblCapsLook"
        Me.LblCapsLook.Size = New System.Drawing.Size(314, 23)
        Me.LblCapsLook.TabIndex = 181
        Me.LblCapsLook.Text = "CAPS LOOK ATIVADA"
        Me.LblCapsLook.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblCapsLook.Visible = False
        '
        'LblOldSenhaIncorreta
        '
        Me.LblOldSenhaIncorreta.AutoSize = True
        Me.LblOldSenhaIncorreta.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.LblOldSenhaIncorreta.ForeColor = System.Drawing.Color.Red
        Me.LblOldSenhaIncorreta.Location = New System.Drawing.Point(152, 181)
        Me.LblOldSenhaIncorreta.Name = "LblOldSenhaIncorreta"
        Me.LblOldSenhaIncorreta.Size = New System.Drawing.Size(75, 12)
        Me.LblOldSenhaIncorreta.TabIndex = 180
        Me.LblOldSenhaIncorreta.Text = "Senha incorreta."
        Me.LblOldSenhaIncorreta.Visible = False
        '
        'TxtRetrySenha
        '
        Me.TxtRetrySenha.Animated = True
        Me.TxtRetrySenha.AutoRoundedCorners = True
        Me.TxtRetrySenha.BackColor = System.Drawing.Color.Transparent
        Me.TxtRetrySenha.BorderColor = System.Drawing.Color.Gray
        Me.TxtRetrySenha.BorderRadius = 17
        Me.TxtRetrySenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtRetrySenha.DefaultText = ""
        Me.TxtRetrySenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtRetrySenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtRetrySenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtRetrySenha.DisabledState.Parent = Me.TxtRetrySenha
        Me.TxtRetrySenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtRetrySenha.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtRetrySenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtRetrySenha.FocusedState.Parent = Me.TxtRetrySenha
        Me.TxtRetrySenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtRetrySenha.ForeColor = System.Drawing.Color.Black
        Me.TxtRetrySenha.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtRetrySenha.HoverState.Parent = Me.TxtRetrySenha
        Me.TxtRetrySenha.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtRetrySenha.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtRetrySenha.IconRight = CType(resources.GetObject("TxtRetrySenha.IconRight"), System.Drawing.Image)
        Me.TxtRetrySenha.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.TxtRetrySenha.Location = New System.Drawing.Point(146, 305)
        Me.TxtRetrySenha.MaxLength = 18
        Me.TxtRetrySenha.Name = "TxtRetrySenha"
        Me.TxtRetrySenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtRetrySenha.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtRetrySenha.PlaceholderText = "Confirme a senha..."
        Me.TxtRetrySenha.SelectedText = ""
        Me.TxtRetrySenha.ShadowDecoration.Parent = Me.TxtRetrySenha
        Me.TxtRetrySenha.Size = New System.Drawing.Size(408, 36)
        Me.TxtRetrySenha.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtRetrySenha.TabIndex = 176
        Me.TxtRetrySenha.TextOffset = New System.Drawing.Point(5, 0)
        Me.TxtRetrySenha.UseSystemPasswordChar = True
        Me.TxtRetrySenha.Visible = False
        '
        'BtnSenhaCancel
        '
        Me.BtnSenhaCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSenhaCancel.Animated = True
        Me.BtnSenhaCancel.AutoRoundedCorners = True
        Me.BtnSenhaCancel.BorderRadius = 18
        Me.BtnSenhaCancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnSenhaCancel.CheckedState.Parent = Me.BtnSenhaCancel
        Me.BtnSenhaCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSenhaCancel.CustomImages.Parent = Me.BtnSenhaCancel
        Me.BtnSenhaCancel.DisabledState.Parent = Me.BtnSenhaCancel
        Me.BtnSenhaCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnSenhaCancel.FillColor2 = System.Drawing.Color.Black
        Me.BtnSenhaCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSenhaCancel.ForeColor = System.Drawing.Color.White
        Me.BtnSenhaCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnSenhaCancel.HoverState.Parent = Me.BtnSenhaCancel
        Me.BtnSenhaCancel.Location = New System.Drawing.Point(223, 437)
        Me.BtnSenhaCancel.Name = "BtnSenhaCancel"
        Me.BtnSenhaCancel.ShadowDecoration.Parent = Me.BtnSenhaCancel
        Me.BtnSenhaCancel.Size = New System.Drawing.Size(124, 38)
        Me.BtnSenhaCancel.TabIndex = 178
        Me.BtnSenhaCancel.Text = "CANCELAR"
        '
        'BtnSenhaSalvar
        '
        Me.BtnSenhaSalvar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSenhaSalvar.Animated = True
        Me.BtnSenhaSalvar.AutoRoundedCorners = True
        Me.BtnSenhaSalvar.BorderRadius = 18
        Me.BtnSenhaSalvar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnSenhaSalvar.CheckedState.Parent = Me.BtnSenhaSalvar
        Me.BtnSenhaSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSenhaSalvar.CustomImages.Parent = Me.BtnSenhaSalvar
        Me.BtnSenhaSalvar.DisabledState.Parent = Me.BtnSenhaSalvar
        Me.BtnSenhaSalvar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnSenhaSalvar.FillColor2 = System.Drawing.Color.Black
        Me.BtnSenhaSalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSenhaSalvar.ForeColor = System.Drawing.Color.White
        Me.BtnSenhaSalvar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnSenhaSalvar.HoverState.Parent = Me.BtnSenhaSalvar
        Me.BtnSenhaSalvar.Location = New System.Drawing.Point(353, 437)
        Me.BtnSenhaSalvar.Name = "BtnSenhaSalvar"
        Me.BtnSenhaSalvar.ShadowDecoration.Parent = Me.BtnSenhaSalvar
        Me.BtnSenhaSalvar.Size = New System.Drawing.Size(124, 38)
        Me.BtnSenhaSalvar.TabIndex = 177
        Me.BtnSenhaSalvar.Text = "SALVAR"
        '
        'LblSenhaInf
        '
        Me.LblSenhaInf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSenhaInf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblSenhaInf.Location = New System.Drawing.Point(95, 50)
        Me.LblSenhaInf.Name = "LblSenhaInf"
        Me.LblSenhaInf.Size = New System.Drawing.Size(511, 82)
        Me.LblSenhaInf.TabIndex = 179
        Me.LblSenhaInf.Text = "Para alterar sua senha é necessário informar a antiga. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LblSenhaInf.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtOldSenha
        '
        Me.TxtOldSenha.Animated = True
        Me.TxtOldSenha.AutoRoundedCorners = True
        Me.TxtOldSenha.BackColor = System.Drawing.Color.Transparent
        Me.TxtOldSenha.BorderColor = System.Drawing.Color.Gray
        Me.TxtOldSenha.BorderRadius = 17
        Me.TxtOldSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtOldSenha.DefaultText = ""
        Me.TxtOldSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtOldSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtOldSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOldSenha.DisabledState.Parent = Me.TxtOldSenha
        Me.TxtOldSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOldSenha.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtOldSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtOldSenha.FocusedState.Parent = Me.TxtOldSenha
        Me.TxtOldSenha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtOldSenha.ForeColor = System.Drawing.Color.Black
        Me.TxtOldSenha.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtOldSenha.HoverState.Parent = Me.TxtOldSenha
        Me.TxtOldSenha.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtOldSenha.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtOldSenha.Location = New System.Drawing.Point(147, 142)
        Me.TxtOldSenha.Name = "TxtOldSenha"
        Me.TxtOldSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtOldSenha.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtOldSenha.PlaceholderText = "Digite sua senha..."
        Me.TxtOldSenha.SelectedText = ""
        Me.TxtOldSenha.ShadowDecoration.Parent = Me.TxtOldSenha
        Me.TxtOldSenha.Size = New System.Drawing.Size(408, 36)
        Me.TxtOldSenha.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtOldSenha.TabIndex = 175
        Me.TxtOldSenha.TextOffset = New System.Drawing.Point(5, 0)
        '
        'TpLoading
        '
        Me.TpLoading.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpLoading.Controls.Add(Me.ProgressAguarde)
        Me.TpLoading.Controls.Add(Me.LblLoading)
        Me.TpLoading.Location = New System.Drawing.Point(4, 4)
        Me.TpLoading.Name = "TpLoading"
        Me.TpLoading.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLoading.Size = New System.Drawing.Size(780, 539)
        Me.TpLoading.TabIndex = 10
        Me.TpLoading.Text = "Loading"
        '
        'ProgressAguarde
        '
        Me.ProgressAguarde.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProgressAguarde.BackColor = System.Drawing.Color.Transparent
        Me.ProgressAguarde.BorderRadius = 4
        Me.ProgressAguarde.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProgressAguarde.Location = New System.Drawing.Point(49, 192)
        Me.ProgressAguarde.Name = "ProgressAguarde"
        Me.ProgressAguarde.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ProgressAguarde.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProgressAguarde.ShadowDecoration.Parent = Me.ProgressAguarde
        Me.ProgressAguarde.Size = New System.Drawing.Size(683, 10)
        Me.ProgressAguarde.TabIndex = 193
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
        Me.LblLoading.Location = New System.Drawing.Point(97, 235)
        Me.LblLoading.Name = "LblLoading"
        Me.LblLoading.Size = New System.Drawing.Size(587, 160)
        Me.LblLoading.TabIndex = 192
        Me.LblLoading.Text = resources.GetString("LblLoading.Text")
        Me.LblLoading.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'TpValidar
        '
        Me.TpValidar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpValidar.Controls.Add(Me.LblCodigoIncorreto)
        Me.TpValidar.Controls.Add(Me.LblValidarCodigo)
        Me.TpValidar.Controls.Add(Me.BtnValidarCancelar)
        Me.TpValidar.Controls.Add(Me.BtnValidar)
        Me.TpValidar.Controls.Add(Me.TxtValidar)
        Me.TpValidar.Controls.Add(Me.LblValidarInf)
        Me.TpValidar.Location = New System.Drawing.Point(4, 4)
        Me.TpValidar.Name = "TpValidar"
        Me.TpValidar.Padding = New System.Windows.Forms.Padding(3)
        Me.TpValidar.Size = New System.Drawing.Size(780, 539)
        Me.TpValidar.TabIndex = 11
        Me.TpValidar.Text = "Validar"
        '
        'LblCodigoIncorreto
        '
        Me.LblCodigoIncorreto.AutoSize = True
        Me.LblCodigoIncorreto.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.LblCodigoIncorreto.ForeColor = System.Drawing.Color.Red
        Me.LblCodigoIncorreto.Location = New System.Drawing.Point(188, 277)
        Me.LblCodigoIncorreto.Name = "LblCodigoIncorreto"
        Me.LblCodigoIncorreto.Size = New System.Drawing.Size(81, 12)
        Me.LblCodigoIncorreto.TabIndex = 203
        Me.LblCodigoIncorreto.Text = "Código incorreto."
        Me.LblCodigoIncorreto.Visible = False
        '
        'LblValidarCodigo
        '
        Me.LblValidarCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblValidarCodigo.AutoSize = True
        Me.LblValidarCodigo.BackColor = System.Drawing.Color.Transparent
        Me.LblValidarCodigo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblValidarCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblValidarCodigo.Location = New System.Drawing.Point(187, 220)
        Me.LblValidarCodigo.Name = "LblValidarCodigo"
        Me.LblValidarCodigo.Size = New System.Drawing.Size(46, 15)
        Me.LblValidarCodigo.TabIndex = 201
        Me.LblValidarCodigo.Text = "Código"
        Me.LblValidarCodigo.Visible = False
        '
        'BtnValidarCancelar
        '
        Me.BtnValidarCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnValidarCancelar.Animated = True
        Me.BtnValidarCancelar.AutoRoundedCorners = True
        Me.BtnValidarCancelar.BorderRadius = 18
        Me.BtnValidarCancelar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnValidarCancelar.CheckedState.Parent = Me.BtnValidarCancelar
        Me.BtnValidarCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnValidarCancelar.CustomImages.Parent = Me.BtnValidarCancelar
        Me.BtnValidarCancelar.DisabledState.Parent = Me.BtnValidarCancelar
        Me.BtnValidarCancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnValidarCancelar.FillColor2 = System.Drawing.Color.Black
        Me.BtnValidarCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnValidarCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnValidarCancelar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnValidarCancelar.HoverState.Parent = Me.BtnValidarCancelar
        Me.BtnValidarCancelar.Location = New System.Drawing.Point(263, 350)
        Me.BtnValidarCancelar.Name = "BtnValidarCancelar"
        Me.BtnValidarCancelar.ShadowDecoration.Parent = Me.BtnValidarCancelar
        Me.BtnValidarCancelar.Size = New System.Drawing.Size(124, 38)
        Me.BtnValidarCancelar.TabIndex = 200
        Me.BtnValidarCancelar.Text = "CANCELAR"
        '
        'BtnValidar
        '
        Me.BtnValidar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnValidar.Animated = True
        Me.BtnValidar.AutoRoundedCorners = True
        Me.BtnValidar.BorderRadius = 18
        Me.BtnValidar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BtnValidar.CheckedState.Parent = Me.BtnValidar
        Me.BtnValidar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnValidar.CustomImages.Parent = Me.BtnValidar
        Me.BtnValidar.DisabledState.Parent = Me.BtnValidar
        Me.BtnValidar.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnValidar.FillColor2 = System.Drawing.Color.Black
        Me.BtnValidar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnValidar.ForeColor = System.Drawing.Color.White
        Me.BtnValidar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnValidar.HoverState.Parent = Me.BtnValidar
        Me.BtnValidar.Location = New System.Drawing.Point(393, 350)
        Me.BtnValidar.Name = "BtnValidar"
        Me.BtnValidar.ShadowDecoration.Parent = Me.BtnValidar
        Me.BtnValidar.Size = New System.Drawing.Size(124, 38)
        Me.BtnValidar.TabIndex = 199
        Me.BtnValidar.Text = "VALIDAR"
        '
        'TxtValidar
        '
        Me.TxtValidar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtValidar.Animated = True
        Me.TxtValidar.AutoRoundedCorners = True
        Me.TxtValidar.BackColor = System.Drawing.Color.Transparent
        Me.TxtValidar.BorderColor = System.Drawing.Color.Gray
        Me.TxtValidar.BorderRadius = 17
        Me.TxtValidar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtValidar.DefaultText = ""
        Me.TxtValidar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtValidar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtValidar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtValidar.DisabledState.Parent = Me.TxtValidar
        Me.TxtValidar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtValidar.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtValidar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtValidar.FocusedState.Parent = Me.TxtValidar
        Me.TxtValidar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtValidar.ForeColor = System.Drawing.Color.Black
        Me.TxtValidar.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtValidar.HoverState.Parent = Me.TxtValidar
        Me.TxtValidar.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtValidar.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtValidar.Location = New System.Drawing.Point(187, 238)
        Me.TxtValidar.Name = "TxtValidar"
        Me.TxtValidar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtValidar.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtValidar.PlaceholderText = "Informe o código..."
        Me.TxtValidar.SelectedText = ""
        Me.TxtValidar.ShadowDecoration.Parent = Me.TxtValidar
        Me.TxtValidar.Size = New System.Drawing.Size(408, 36)
        Me.TxtValidar.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtValidar.TabIndex = 198
        Me.TxtValidar.TextOffset = New System.Drawing.Point(5, 0)
        '
        'LblValidarInf
        '
        Me.LblValidarInf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblValidarInf.AutoSize = False
        Me.LblValidarInf.BackColor = System.Drawing.Color.Transparent
        Me.LblValidarInf.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValidarInf.Location = New System.Drawing.Point(127, 85)
        Me.LblValidarInf.Name = "LblValidarInf"
        Me.LblValidarInf.Size = New System.Drawing.Size(526, 82)
        Me.LblValidarInf.TabIndex = 202
        Me.LblValidarInf.Text = "Enviamos o código no endereço de e-mail informado." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            Para prosseguir c" &
    "om a substituição é necessário validar seu novo email. Insira o código no campo " &
    "correspondente."
        Me.LblValidarInf.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'TimerExcluir
        '
        Me.TimerExcluir.Interval = 50
        '
        'TimerRdfEmail
        '
        Me.TimerRdfEmail.Interval = 20
        '
        'pbBordaLeft
        '
        Me.pbBordaLeft.AllowFocused = False
        Me.pbBordaLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbBordaLeft.AutoSizeHeight = True
        Me.pbBordaLeft.BorderRadius = 86
        Me.pbBordaLeft.Image = CType(resources.GetObject("pbBordaLeft.Image"), System.Drawing.Image)
        Me.pbBordaLeft.IsCircle = True
        Me.pbBordaLeft.Location = New System.Drawing.Point(263, 19)
        Me.pbBordaLeft.Name = "pbBordaLeft"
        Me.pbBordaLeft.Size = New System.Drawing.Size(173, 173)
        Me.pbBordaLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBordaLeft.TabIndex = 199
        Me.pbBordaLeft.TabStop = False
        Me.pbBordaLeft.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'FrmUserConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(788, 565)
        Me.Controls.Add(Me.bpInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUserConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmUserConfig"
        Me.tpEdit.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.pbWhats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTermos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpInfoPerfil.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.imgPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bpInfo.ResumeLayout(False)
        Me.tpEditEmail.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.tpEditSenha.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.TpLoading.ResumeLayout(False)
        Me.TpValidar.ResumeLayout(False)
        Me.TpValidar.PerformLayout()
        CType(Me.pbBordaLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents imgRdf As ImageList
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents tpEdit As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSalvar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblTermos As LinkLabel
    Friend WithEvents cbGenero As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblInfDados As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pbWhats As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtCidade As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pbEmail As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtComplemento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pbTermos As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtCep As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblNotEmail As Label
    Friend WithEvents txtEndereco As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblAceiteTermo As Label
    Friend WithEvents txtCell As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblNotWhats As Label
    Friend WithEvents txtNome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chkPerfilWhats As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents txtUF As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chkPerfilEmail As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents txtNascimento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chkPerfilTermos As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents txtRamal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtFuncao As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDepart As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmpresa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblInfoB As Label
    Friend WithEvents lblInfoP As Label
    Friend WithEvents tpInfoPerfil As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnEditSenha As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnEditEmail As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnDeletar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblChaveKey As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblUserInfo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents imgPerfil As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents bpInfo As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents tpEditEmail As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblSenha As Label
    Friend WithEvents LblNewEmail As Label
    Friend WithEvents LblEmailSenhaIncorreta As Label
    Friend WithEvents LblEmailCapsLook As Label
    Friend WithEvents TxtSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnEmailCancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnEmailEnviar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TxtNewEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblEmailInf As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tpEditSenha As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtNewSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblCapsLook As Label
    Friend WithEvents LblOldSenhaIncorreta As Label
    Friend WithEvents TxtRetrySenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnSenhaCancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnSenhaSalvar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LblSenhaInf As Label
    Friend WithEvents TxtOldSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnCopy As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LblNewSenha As Label
    Friend WithEvents LblRetrySenha As Label
    Friend WithEvents LblOldSenha As Label
    Friend WithEvents TpLoading As TabPage
    Friend WithEvents LblLoading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TimerExcluir As Timer
    Friend WithEvents ProgressAguarde As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents LblNome As Label
    Friend WithEvents LblRamal As Label
    Friend WithEvents LblTelefone As Label
    Friend WithEvents LblFunção As Label
    Friend WithEvents LblDepartamento As Label
    Friend WithEvents LblEmpresa As Label
    Friend WithEvents LblUF As Label
    Friend WithEvents LblCidade As Label
    Friend WithEvents LblComplemento As Label
    Friend WithEvents LblEndereço As Label
    Friend WithEvents LblCep As Label
    Friend WithEvents LblCelular As Label
    Friend WithEvents LblNascimento As Label
    Friend WithEvents LblGenero As Label
    Friend WithEvents TpValidar As TabPage
    Friend WithEvents LblValidarCodigo As Label
    Friend WithEvents BtnValidarCancelar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnValidar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TxtValidar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblValidarInf As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblEmailIncorreto As Label
    Friend WithEvents TimerRdfEmail As Timer
    Friend WithEvents LblCodigoIncorreto As Label
    Friend WithEvents pbBordaLeft As Bunifu.UI.WinForms.BunifuPictureBox
End Class
