<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaps
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaps))
        Me.WbMaps = New System.Windows.Forms.WebBrowser()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.BtnBuscarMaps = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ShPPartida = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.LblPartida = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ShPDestinoFinal = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.LblDestinoFinal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtPartida = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtDestinoFinal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PanelSuperior.SuspendLayout()
        Me.ShPPartida.SuspendLayout()
        Me.ShPDestinoFinal.SuspendLayout()
        Me.SuspendLayout()
        '
        'WbMaps
        '
        Me.WbMaps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WbMaps.Location = New System.Drawing.Point(0, 131)
        Me.WbMaps.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WbMaps.Name = "WbMaps"
        Me.WbMaps.Size = New System.Drawing.Size(800, 319)
        Me.WbMaps.TabIndex = 0
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.ShPDestinoFinal)
        Me.PanelSuperior.Controls.Add(Me.ShPPartida)
        Me.PanelSuperior.Controls.Add(Me.BtnBuscarMaps)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(800, 131)
        Me.PanelSuperior.TabIndex = 1
        '
        'BtnBuscarMaps
        '
        Me.BtnBuscarMaps.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnBuscarMaps.AutoRoundedCorners = True
        Me.BtnBuscarMaps.BorderRadius = 12
        Me.BtnBuscarMaps.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBuscarMaps.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBuscarMaps.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBuscarMaps.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBuscarMaps.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBuscarMaps.FillColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnBuscarMaps.FillColor2 = System.Drawing.Color.Black
        Me.BtnBuscarMaps.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnBuscarMaps.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarMaps.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.BtnBuscarMaps.Image = CType(resources.GetObject("BtnBuscarMaps.Image"), System.Drawing.Image)
        Me.BtnBuscarMaps.ImageOffset = New System.Drawing.Point(1, 0)
        Me.BtnBuscarMaps.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnBuscarMaps.Location = New System.Drawing.Point(713, 31)
        Me.BtnBuscarMaps.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscarMaps.Name = "BtnBuscarMaps"
        Me.BtnBuscarMaps.Size = New System.Drawing.Size(63, 58)
        Me.BtnBuscarMaps.TabIndex = 95
        '
        'ShPPartida
        '
        Me.ShPPartida.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ShPPartida.BackColor = System.Drawing.Color.Transparent
        Me.ShPPartida.Controls.Add(Me.TxtPartida)
        Me.ShPPartida.Controls.Add(Me.LblPartida)
        Me.ShPPartida.FillColor = System.Drawing.Color.LightGray
        Me.ShPPartida.Location = New System.Drawing.Point(18, 10)
        Me.ShPPartida.Margin = New System.Windows.Forms.Padding(4)
        Me.ShPPartida.Name = "ShPPartida"
        Me.ShPPartida.Radius = 4
        Me.ShPPartida.ShadowColor = System.Drawing.Color.Black
        Me.ShPPartida.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.ShPPartida.Size = New System.Drawing.Size(330, 104)
        Me.ShPPartida.TabIndex = 120
        '
        'LblPartida
        '
        Me.LblPartida.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblPartida.AutoSize = False
        Me.LblPartida.BackColor = System.Drawing.Color.Transparent
        Me.LblPartida.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPartida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblPartida.Location = New System.Drawing.Point(55, 15)
        Me.LblPartida.Margin = New System.Windows.Forms.Padding(4)
        Me.LblPartida.Name = "LblPartida"
        Me.LblPartida.Size = New System.Drawing.Size(221, 32)
        Me.LblPartida.TabIndex = 93
        Me.LblPartida.Text = "Partida"
        Me.LblPartida.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'ShPDestinoFinal
        '
        Me.ShPDestinoFinal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ShPDestinoFinal.BackColor = System.Drawing.Color.Transparent
        Me.ShPDestinoFinal.Controls.Add(Me.TxtDestinoFinal)
        Me.ShPDestinoFinal.Controls.Add(Me.LblDestinoFinal)
        Me.ShPDestinoFinal.FillColor = System.Drawing.Color.LightGray
        Me.ShPDestinoFinal.Location = New System.Drawing.Point(362, 10)
        Me.ShPDestinoFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.ShPDestinoFinal.Name = "ShPDestinoFinal"
        Me.ShPDestinoFinal.Radius = 4
        Me.ShPDestinoFinal.ShadowColor = System.Drawing.Color.Black
        Me.ShPDestinoFinal.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.ShPDestinoFinal.Size = New System.Drawing.Size(330, 104)
        Me.ShPDestinoFinal.TabIndex = 121
        '
        'LblDestinoFinal
        '
        Me.LblDestinoFinal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblDestinoFinal.AutoSize = False
        Me.LblDestinoFinal.BackColor = System.Drawing.Color.Transparent
        Me.LblDestinoFinal.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDestinoFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblDestinoFinal.Location = New System.Drawing.Point(55, 15)
        Me.LblDestinoFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.LblDestinoFinal.Name = "LblDestinoFinal"
        Me.LblDestinoFinal.Size = New System.Drawing.Size(221, 32)
        Me.LblDestinoFinal.TabIndex = 93
        Me.LblDestinoFinal.Text = "Destino Final"
        Me.LblDestinoFinal.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtPartida
        '
        Me.TxtPartida.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtPartida.Animated = True
        Me.TxtPartida.AutoRoundedCorners = True
        Me.TxtPartida.BackColor = System.Drawing.Color.Transparent
        Me.TxtPartida.BorderColor = System.Drawing.Color.Gray
        Me.TxtPartida.BorderRadius = 12
        Me.TxtPartida.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtPartida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPartida.DefaultText = ""
        Me.TxtPartida.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPartida.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPartida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPartida.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPartida.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtPartida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtPartida.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPartida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtPartida.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtPartida.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtPartida.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtPartida.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.TxtPartida.IconRightSize = New System.Drawing.Size(16, 16)
        Me.TxtPartida.Location = New System.Drawing.Point(13, 47)
        Me.TxtPartida.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPartida.Name = "TxtPartida"
        Me.TxtPartida.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TxtPartida.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TxtPartida.PlaceholderText = "Digite sua partida..."
        Me.TxtPartida.SelectedText = ""
        Me.TxtPartida.Size = New System.Drawing.Size(302, 44)
        Me.TxtPartida.TabIndex = 153
        Me.TxtPartida.TextOffset = New System.Drawing.Point(5, 0)
        Me.TxtPartida.UseSystemPasswordChar = True
        '
        'TxtDestinoFinal
        '
        Me.TxtDestinoFinal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDestinoFinal.Animated = True
        Me.TxtDestinoFinal.AutoRoundedCorners = True
        Me.TxtDestinoFinal.BackColor = System.Drawing.Color.Transparent
        Me.TxtDestinoFinal.BorderColor = System.Drawing.Color.Gray
        Me.TxtDestinoFinal.BorderRadius = 12
        Me.TxtDestinoFinal.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.TxtDestinoFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDestinoFinal.DefaultText = ""
        Me.TxtDestinoFinal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtDestinoFinal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtDestinoFinal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDestinoFinal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDestinoFinal.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TxtDestinoFinal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TxtDestinoFinal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtDestinoFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtDestinoFinal.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtDestinoFinal.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.TxtDestinoFinal.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.TxtDestinoFinal.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.TxtDestinoFinal.IconRightSize = New System.Drawing.Size(16, 16)
        Me.TxtDestinoFinal.Location = New System.Drawing.Point(13, 47)
        Me.TxtDestinoFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDestinoFinal.Name = "TxtDestinoFinal"
        Me.TxtDestinoFinal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TxtDestinoFinal.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TxtDestinoFinal.PlaceholderText = "Digite seu destino final..."
        Me.TxtDestinoFinal.SelectedText = ""
        Me.TxtDestinoFinal.Size = New System.Drawing.Size(302, 44)
        Me.TxtDestinoFinal.TabIndex = 154
        Me.TxtDestinoFinal.TextOffset = New System.Drawing.Point(5, 0)
        Me.TxtDestinoFinal.UseSystemPasswordChar = True
        '
        'FrmMaps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.WbMaps)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMaps"
        Me.Text = "FrmMaps"
        Me.PanelSuperior.ResumeLayout(False)
        Me.ShPPartida.ResumeLayout(False)
        Me.ShPDestinoFinal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WbMaps As WebBrowser
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents BtnBuscarMaps As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ShPDestinoFinal As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents LblDestinoFinal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ShPPartida As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents LblPartida As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtDestinoFinal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtPartida As Guna.UI2.WinForms.Guna2TextBox
End Class
