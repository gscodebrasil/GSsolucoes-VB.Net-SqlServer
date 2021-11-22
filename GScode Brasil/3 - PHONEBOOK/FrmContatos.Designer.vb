<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmContatos
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
        Me.TpAnexo = New System.Windows.Forms.TabPage()
        Me.TpInicio = New System.Windows.Forms.TabPage()
        Me.TabControl_Cadastros = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabControl_Cadastros.SuspendLayout()
        Me.SuspendLayout()
        '
        'TpAnexo
        '
        Me.TpAnexo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TpAnexo.Location = New System.Drawing.Point(4, 4)
        Me.TpAnexo.Name = "TpAnexo"
        Me.TpAnexo.Padding = New System.Windows.Forms.Padding(3)
        Me.TpAnexo.Size = New System.Drawing.Size(764, 493)
        Me.TpAnexo.TabIndex = 6
        Me.TpAnexo.Text = "Anexo"
        '
        'TpInicio
        '
        Me.TpInicio.Location = New System.Drawing.Point(4, 4)
        Me.TpInicio.Name = "TpInicio"
        Me.TpInicio.Padding = New System.Windows.Forms.Padding(3)
        Me.TpInicio.Size = New System.Drawing.Size(764, 493)
        Me.TpInicio.TabIndex = 1
        Me.TpInicio.Text = "Inicio"
        Me.TpInicio.UseVisualStyleBackColor = True
        '
        'TabControl_Cadastros
        '
        Me.TabControl_Cadastros.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl_Cadastros.Controls.Add(Me.TpInicio)
        Me.TabControl_Cadastros.Controls.Add(Me.TpAnexo)
        Me.TabControl_Cadastros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_Cadastros.ItemSize = New System.Drawing.Size(100, 25)
        Me.TabControl_Cadastros.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_Cadastros.Name = "TabControl_Cadastros"
        Me.TabControl_Cadastros.SelectedIndex = 0
        Me.TabControl_Cadastros.Size = New System.Drawing.Size(772, 526)
        Me.TabControl_Cadastros.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl_Cadastros.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControl_Cadastros.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl_Cadastros.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabControl_Cadastros.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControl_Cadastros.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl_Cadastros.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControl_Cadastros.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl_Cadastros.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TabControl_Cadastros.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControl_Cadastros.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl_Cadastros.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabControl_Cadastros.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl_Cadastros.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabControl_Cadastros.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl_Cadastros.TabButtonSize = New System.Drawing.Size(100, 25)
        Me.TabControl_Cadastros.TabIndex = 1
        Me.TabControl_Cadastros.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControl_Cadastros.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalBottom
        Me.TabControl_Cadastros.Visible = False
        '
        'FrmContatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(772, 526)
        Me.Controls.Add(Me.TabControl_Cadastros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmContatos"
        Me.Text = "FrmContatos"
        Me.TabControl_Cadastros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TpAnexo As TabPage
    Friend WithEvents TpInicio As TabPage
    Friend WithEvents TabControl_Cadastros As Guna.UI2.WinForms.Guna2TabControl
End Class
