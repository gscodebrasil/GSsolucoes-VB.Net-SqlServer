<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAguarde
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
    <System.Diagnostics.DebuggerStepThrough()>
    <Obsolete>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAguarde))
        Me.Bordeless = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.lblAguarde = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TimerAguarde = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.ProgressAguarde = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bordeless
        '
        Me.Bordeless.BorderRadius = 20
        Me.Bordeless.ContainerControl = Me
        '
        'lblAguarde
        '
        Me.lblAguarde.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAguarde.AutoSize = False
        Me.lblAguarde.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblAguarde.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAguarde.ForeColor = System.Drawing.Color.White
        Me.lblAguarde.Location = New System.Drawing.Point(143, 210)
        Me.lblAguarde.Name = "lblAguarde"
        Me.lblAguarde.Size = New System.Drawing.Size(515, 35)
        Me.lblAguarde.TabIndex = 182
        Me.lblAguarde.Text = "..."
        Me.lblAguarde.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'TimerAguarde
        '
        Me.TimerAguarde.Interval = 20
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.Controls.Add(Me.ProgressAguarde)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblAguarde)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnClose)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(800, 500)
        Me.Guna2GradientPanel1.TabIndex = 185
        '
        'ProgressAguarde
        '
        Me.ProgressAguarde.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProgressAguarde.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ProgressAguarde.BorderRadius = 4
        Me.ProgressAguarde.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ProgressAguarde.Location = New System.Drawing.Point(59, 251)
        Me.ProgressAguarde.Name = "ProgressAguarde"
        Me.ProgressAguarde.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ProgressAguarde.ProgressColor2 = System.Drawing.Color.WhiteSmoke
        Me.ProgressAguarde.ShadowDecoration.Parent = Me.ProgressAguarde
        Me.ProgressAguarde.Size = New System.Drawing.Size(683, 15)
        Me.ProgressAguarde.TabIndex = 0
        Me.ProgressAguarde.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.ProgressAguarde.Value = 80
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
        Me.btnClose.Location = New System.Drawing.Point(763, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedState.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnClose.PressedState.Parent = Me.btnClose
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(22, 22)
        Me.btnClose.TabIndex = 186
        '
        'FrmAguarde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAguarde"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAguarde"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bordeless As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents lblAguarde As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TimerAguarde As Timer
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents ProgressAguarde As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ImageButton
End Class
