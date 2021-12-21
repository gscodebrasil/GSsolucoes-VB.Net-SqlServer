<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSoftphone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSoftphone))
        Me.BtnSalvar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnLimpar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LblLocal = New System.Windows.Forms.Label()
        Me.TxtSoftphone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblSoftphone = New System.Windows.Forms.Label()
        Me.BtnBuscarSoftphone = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ImgSoftphone = New System.Windows.Forms.ImageList(Me.components)
        Me.Ofd = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPrefixo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ChkPrefixo = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.SuspendLayout()
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
        Me.BtnSalvar.Location = New System.Drawing.Point(397, 426)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.ShadowDecoration.Parent = Me.BtnSalvar
        Me.BtnSalvar.Size = New System.Drawing.Size(124, 38)
        Me.BtnSalvar.TabIndex = 361
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
        Me.BtnLimpar.Location = New System.Drawing.Point(267, 426)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.ShadowDecoration.Parent = Me.BtnLimpar
        Me.BtnLimpar.Size = New System.Drawing.Size(124, 38)
        Me.BtnLimpar.TabIndex = 362
        Me.BtnLimpar.Text = "LIMPAR"
        '
        'LblLocal
        '
        Me.LblLocal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblLocal.AutoSize = True
        Me.LblLocal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LblLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblLocal.Location = New System.Drawing.Point(148, 245)
        Me.LblLocal.Name = "LblLocal"
        Me.LblLocal.Size = New System.Drawing.Size(110, 15)
        Me.LblLocal.TabIndex = 353
        Me.LblLocal.Text = "Local do Softphone"
        '
        'TxtSoftphone
        '
        Me.TxtSoftphone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSoftphone.Animated = True
        Me.TxtSoftphone.BackColor = System.Drawing.Color.Transparent
        Me.TxtSoftphone.BorderColor = System.Drawing.Color.Silver
        Me.TxtSoftphone.BorderRadius = 7
        Me.TxtSoftphone.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtSoftphone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSoftphone.DefaultText = ""
        Me.TxtSoftphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSoftphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSoftphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSoftphone.DisabledState.Parent = Me.TxtSoftphone
        Me.TxtSoftphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSoftphone.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtSoftphone.FocusedState.Parent = Me.TxtSoftphone
        Me.TxtSoftphone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtSoftphone.ForeColor = System.Drawing.Color.Black
        Me.TxtSoftphone.HoverState.Parent = Me.TxtSoftphone
        Me.TxtSoftphone.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtSoftphone.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtSoftphone.Location = New System.Drawing.Point(151, 263)
        Me.TxtSoftphone.Name = "TxtSoftphone"
        Me.TxtSoftphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSoftphone.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtSoftphone.PlaceholderText = ""
        Me.TxtSoftphone.SelectedText = ""
        Me.TxtSoftphone.ShadowDecoration.Parent = Me.TxtSoftphone
        Me.TxtSoftphone.Size = New System.Drawing.Size(489, 36)
        Me.TxtSoftphone.TabIndex = 349
        Me.TxtSoftphone.TextOffset = New System.Drawing.Point(10, 0)
        '
        'LblSoftphone
        '
        Me.LblSoftphone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblSoftphone.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblSoftphone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblSoftphone.Location = New System.Drawing.Point(196, 165)
        Me.LblSoftphone.Name = "LblSoftphone"
        Me.LblSoftphone.Size = New System.Drawing.Size(396, 20)
        Me.LblSoftphone.TabIndex = 365
        Me.LblSoftphone.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblSoftphone.Visible = False
        '
        'BtnBuscarSoftphone
        '
        Me.BtnBuscarSoftphone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnBuscarSoftphone.Animated = True
        Me.BtnBuscarSoftphone.AutoRoundedCorners = True
        Me.BtnBuscarSoftphone.BorderRadius = 64
        Me.BtnBuscarSoftphone.CheckedState.Parent = Me.BtnBuscarSoftphone
        Me.BtnBuscarSoftphone.CustomImages.Parent = Me.BtnBuscarSoftphone
        Me.BtnBuscarSoftphone.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBuscarSoftphone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBuscarSoftphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBuscarSoftphone.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBuscarSoftphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBuscarSoftphone.DisabledState.Parent = Me.BtnBuscarSoftphone
        Me.BtnBuscarSoftphone.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BtnBuscarSoftphone.FillColor2 = System.Drawing.Color.Black
        Me.BtnBuscarSoftphone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnBuscarSoftphone.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarSoftphone.HoverState.Parent = Me.BtnBuscarSoftphone
        Me.BtnBuscarSoftphone.Image = CType(resources.GetObject("BtnBuscarSoftphone.Image"), System.Drawing.Image)
        Me.BtnBuscarSoftphone.ImageSize = New System.Drawing.Size(90, 90)
        Me.BtnBuscarSoftphone.Location = New System.Drawing.Point(329, 32)
        Me.BtnBuscarSoftphone.Name = "BtnBuscarSoftphone"
        Me.BtnBuscarSoftphone.ShadowDecoration.Parent = Me.BtnBuscarSoftphone
        Me.BtnBuscarSoftphone.Size = New System.Drawing.Size(130, 130)
        Me.BtnBuscarSoftphone.TabIndex = 366
        '
        'ImgSoftphone
        '
        Me.ImgSoftphone.ImageStream = CType(resources.GetObject("ImgSoftphone.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgSoftphone.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgSoftphone.Images.SetKeyName(0, "headphone_110px.png")
        '
        'Ofd
        '
        Me.Ofd.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(175, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 368
        Me.Label1.Text = "Perefixo"
        '
        'TxtPrefixo
        '
        Me.TxtPrefixo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtPrefixo.Animated = True
        Me.TxtPrefixo.BackColor = System.Drawing.Color.Transparent
        Me.TxtPrefixo.BorderColor = System.Drawing.Color.Silver
        Me.TxtPrefixo.BorderRadius = 7
        Me.TxtPrefixo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtPrefixo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPrefixo.DefaultText = ""
        Me.TxtPrefixo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPrefixo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPrefixo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrefixo.DisabledState.Parent = Me.TxtPrefixo
        Me.TxtPrefixo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPrefixo.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtPrefixo.FocusedState.Parent = Me.TxtPrefixo
        Me.TxtPrefixo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPrefixo.ForeColor = System.Drawing.Color.Black
        Me.TxtPrefixo.HoverState.Parent = Me.TxtPrefixo
        Me.TxtPrefixo.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtPrefixo.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtPrefixo.Location = New System.Drawing.Point(178, 332)
        Me.TxtPrefixo.Name = "TxtPrefixo"
        Me.TxtPrefixo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPrefixo.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TxtPrefixo.PlaceholderText = ""
        Me.TxtPrefixo.ReadOnly = True
        Me.TxtPrefixo.SelectedText = ""
        Me.TxtPrefixo.ShadowDecoration.Parent = Me.TxtPrefixo
        Me.TxtPrefixo.Size = New System.Drawing.Size(72, 36)
        Me.TxtPrefixo.TabIndex = 367
        Me.TxtPrefixo.TextOffset = New System.Drawing.Point(10, 0)
        '
        'ChkPrefixo
        '
        Me.ChkPrefixo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ChkPrefixo.BackColor = System.Drawing.Color.Transparent
        Me.ChkPrefixo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ChkPrefixo.CheckedState.BorderRadius = 3
        Me.ChkPrefixo.CheckedState.BorderThickness = 1
        Me.ChkPrefixo.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ChkPrefixo.CheckedState.Parent = Me.ChkPrefixo
        Me.ChkPrefixo.Location = New System.Drawing.Point(151, 341)
        Me.ChkPrefixo.Name = "ChkPrefixo"
        Me.ChkPrefixo.ShadowDecoration.Parent = Me.ChkPrefixo
        Me.ChkPrefixo.Size = New System.Drawing.Size(20, 20)
        Me.ChkPrefixo.TabIndex = 369
        Me.ChkPrefixo.UncheckedState.BorderColor = System.Drawing.Color.Gray
        Me.ChkPrefixo.UncheckedState.BorderRadius = 3
        Me.ChkPrefixo.UncheckedState.BorderThickness = 1
        Me.ChkPrefixo.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.ChkPrefixo.UncheckedState.Parent = Me.ChkPrefixo
        Me.ChkPrefixo.UseTransparentBackground = True
        '
        'FrmSoftphone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(788, 565)
        Me.Controls.Add(Me.ChkPrefixo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPrefixo)
        Me.Controls.Add(Me.BtnBuscarSoftphone)
        Me.Controls.Add(Me.LblSoftphone)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.LblLocal)
        Me.Controls.Add(Me.TxtSoftphone)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSoftphone"
        Me.Text = "FrmSoftphone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSalvar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnLimpar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LblLocal As Label
    Friend WithEvents TxtSoftphone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblSoftphone As Label
    Friend WithEvents BtnBuscarSoftphone As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ImgSoftphone As ImageList
    Friend WithEvents Ofd As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPrefixo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ChkPrefixo As Guna.UI2.WinForms.Guna2CustomCheckBox
End Class
