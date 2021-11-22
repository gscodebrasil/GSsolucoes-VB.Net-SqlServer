Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms

Public Class FrmCadastros_Phonebook

    Private ReadOnly ClServerSFTP As New ServerSFTP
    Private ReadOnly ClServerSFTP_Phonebook As New ServerSFTP_Phonebook
    Private ClCliente_Phonebook As New Cliente_Phonebook
    Private ClColaborador_Phonebook As New Colaborador_Phonebook
    Private ClFornecedor_Phonebook As New Fornecedor_Phonebook
    Private ClValidaCep As New ValidaCep
    Private PaginaAtual As Integer = 1
    Private PaginaTotal As Double
    Private ColumnOpcoes As String = "name"
    Private ColumnGenero As String = ""
    Private ColumnData As String = ""
    Private Perfil As String

    Private Sub FormataGridView_Cliente()
        With DgvRegistros
            .GridColor = Color.WhiteSmoke
            .DefaultCellStyle.Font = New Font("Segoe UI Semibold", 9)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(223, 243, 251)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersDefaultCellStyle.Font = New Font("Segoe UI Bold", 9)
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(2).HeaderText = "ID"
            .Columns(4).HeaderText = "Nome"
            .Columns(6).HeaderText = "E-mail"
            .Columns(7).HeaderText = "Contato"
            .Columns(15).HeaderText = "Condição"
            .Columns(19).HeaderText = "Data"
            .Columns(0).HeaderCell = New CheckHeaderCell

            .Columns(0).Visible = True
            .Columns(1).Visible = False
            .Columns(3).Visible = False
            .Columns(5).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False

            .Columns(0).ReadOnly = False
            .Columns(4).ReadOnly = True
            .Columns(6).ReadOnly = True
            .Columns(7).ReadOnly = True
            .Columns(15).ReadOnly = True

            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        End With
    End Sub

    Private Sub FormataGridView_Colaborador_Fornecedor()
        With DgvRegistros
            .GridColor = Color.WhiteSmoke
            .DefaultCellStyle.Font = New Font("Segoe UI Semibold", 9)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(223, 243, 251)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersDefaultCellStyle.Font = New Font("Segoe UI Bold", 9)
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(2).HeaderText = "ID"
            .Columns(4).HeaderText = "Nome"
            .Columns(6).HeaderText = "E-mail"
            .Columns(7).HeaderText = "Contato"
            .Columns(16).HeaderText = "Data"
            .Columns(0).HeaderCell = New CheckHeaderCell

            .Columns(0).Visible = True
            .Columns(1).Visible = False
            .Columns(3).Visible = False
            .Columns(5).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False

            .Columns(0).ReadOnly = False
            .Columns(4).ReadOnly = True
            .Columns(6).ReadOnly = True
            .Columns(7).ReadOnly = True

            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        End With
    End Sub

    Private Sub BuscarRegistros(Tabela As String)
        Dim NDecimal As Integer
        Dim RegistroDe As Integer
        Dim RegistroAte As Integer = CbRegistrosPorPagina.Text

        ClCliente_Phonebook.CountUsers($"Select COUNT(*) FROM {Tabela} WHERE {ColumnData} {ColumnOpcoes} Like '{TxtFilter.Text}%'")
        ClCliente_Phonebook.RegistroUserDesc(DgvRegistros, $"SELECT * FROM {Tabela} WHERE {ColumnData} {ColumnOpcoes} like '{TxtFilter.Text}%' ORDER BY date_cad DESC OFFSET {RegistroDe} ROWS FETCH NEXT {RegistroAte} ROWS ONLY")

        If ClCliente_Phonebook.TotalUser > 0 Then
            PaginaAtual = 1
            LblPaginacao.Visible = True
            BtnPrevio.Visible = True
            BtnNext.Visible = True
        Else
            PaginaAtual = 0
            LblPaginacao.Visible = False
            BtnPrevio.Visible = False
            BtnNext.Visible = False
        End If

        PaginaTotal = ClCliente_Phonebook.TotalUser / CInt(CbRegistrosPorPagina.Text)
        'NDecimal -= Math.Floor(PaginaTotal)
        PaginaTotal = ClCliente_Phonebook.TotalUser / CInt(CbRegistrosPorPagina.Text)
        NDecimal = ClCliente_Phonebook.TotalUser Mod CInt(CbRegistrosPorPagina.Text)
        If DgvRegistros.Rows.Count > 0 Then
            If PaginaTotal > 0 Then
                If NDecimal > 0 Then
                    PaginaTotal = ClCliente_Phonebook.TotalUser \ CInt(CbRegistrosPorPagina.Text)
                    PaginaTotal += 1
                End If
            Else
                PaginaTotal += 1
            End If
        Else
            PaginaTotal = 0
        End If


        LblPaginacao.Text = $"Página {PaginaAtual} de {PaginaTotal} ({ClCliente_Phonebook.TotalUser} registros)"


        LblSelectRegister.Visible = False
        PanelSelect.Visible = False
    End Sub

    Private Sub DgvPaginacao_Seguinte(Tabela As String)
        Dim NDecimal As Integer
        Dim RegistroDe As Integer
        Dim RegistroAte As Integer = CbRegistrosPorPagina.Text

        If PaginaAtual = PaginaTotal Then
            Exit Sub
        End If

        RegistroDe = CInt(CbRegistrosPorPagina.Text) * PaginaAtual

        ClCliente_Phonebook.CountUsers($"SELECT COUNT(*) FROM user_info")
        ClCliente_Phonebook.RegistroUserDesc(DgvRegistros, $"SELECT * FROM {Tabela} ORDER BY id DESC OFFSET {RegistroDe} ROWS FETCH NEXT {RegistroAte} ROWS ONLY")

        PaginaAtual += 1
        PaginaTotal = ClCliente_Phonebook.TotalUser / CInt(CbRegistrosPorPagina.Text)
        NDecimal -= Math.Floor(PaginaTotal)
        PaginaTotal = ClCliente_Phonebook.TotalUser / CInt(CbRegistrosPorPagina.Text)
        NDecimal = ClCliente_Phonebook.TotalUser Mod CInt(CbRegistrosPorPagina.Text)
        If PaginaTotal > 0 Then
            If NDecimal > 0 Then
                PaginaTotal = ClCliente_Phonebook.TotalUser \ CInt(CbRegistrosPorPagina.Text)
                PaginaTotal += 1
            End If
        Else
            PaginaTotal += 1
        End If

        LblPaginacao.Text = $"Página {PaginaAtual} de {PaginaTotal} ({ClCliente_Phonebook.TotalUser} registros)"
        DgvRegistros.Columns(0).HeaderCell = New CheckHeaderCell
        LblSelectRegister.Visible = False
        PanelSelect.Visible = False
    End Sub

    Private Sub DgvPaginacao_Anterior(Tabela As String)
        Dim NDecimal As Integer
        Dim RegistroDe As Integer
        Dim RegistroAte As Integer = CbRegistrosPorPagina.Text

        If PaginaAtual = 1 Then
            Exit Sub
        End If

        RegistroDe -= CInt(CbRegistrosPorPagina.Text)

        ClCliente_Phonebook.CountUsers($"SELECT COUNT(*) FROM user_info")
        ClCliente_Phonebook.RegistroUserDesc(DgvRegistros, $"SELECT * FROM {Tabela} ORDER BY id DESC OFFSET {RegistroDe} ROWS FETCH NEXT {RegistroAte} ROWS ONLY")

        PaginaAtual -= 1
        PaginaTotal = ClCliente_Phonebook.TotalUser / CInt(CbRegistrosPorPagina.Text)
        NDecimal -= Math.Floor(PaginaTotal)
        PaginaTotal = ClCliente_Phonebook.TotalUser / CInt(CbRegistrosPorPagina.Text)
        NDecimal = ClCliente_Phonebook.TotalUser Mod CInt(CbRegistrosPorPagina.Text)
        If PaginaTotal > 0 Then
            If NDecimal > 0 Then
                PaginaTotal = ClCliente_Phonebook.TotalUser \ CInt(CbRegistrosPorPagina.Text)
                PaginaTotal += 1
            End If
        Else
            PaginaTotal += 1
        End If


        LblPaginacao.Text = $"Página {PaginaAtual} de {PaginaTotal} ({ClCliente_Phonebook.TotalUser} registros)"
        DgvRegistros.Columns(0).HeaderCell = New CheckHeaderCell
        LblSelectRegister.Visible = False
        PanelSelect.Visible = False
    End Sub

    Private Sub SelecionarLinha_Contar(e As DataGridViewCellEventArgs)
        Dim count As Integer

        If DgvRegistros.Rows.Count() > 0 Then
            If DgvRegistros.Columns(e.ColumnIndex).Index = 0 Then
                For i As Integer = 0 To DgvRegistros.Rows.Count() - 1
                    If DgvRegistros.Rows(i).Cells(0).Value Then
                        count += 1
                    End If
                Next

                Select Case count
                    Case 0
                        LblSelectRegister.Visible = False
                        PanelSelect.Visible = False

                    Case 1
                        LblSelectRegister.Text = $"{count} Registros selecionados"
                        LblSelectRegister.Visible = True

                        HtmlLblSelect.Text = $"Usuários selecionados ({count})"
                        PanelSelect.BringToFront()
                        SelectTransition.ShowSync(PanelSelect)
                        BtnInfo.Enabled = True
                        BtnAbrirOS.Enabled = True

                    Case Else
                        LblSelectRegister.Text = $"{count} Registros selecionados"
                        LblSelectRegister.Visible = True

                        HtmlLblSelect.Text = $"Usuários selecionados ({count})"
                        PanelSelect.BringToFront()
                        SelectTransition.ShowSync(PanelSelect)
                        BtnInfo.Enabled = False
                        BtnAbrirOS.Enabled = False

                End Select
            End If
        End If
    End Sub

    Private Sub ExcluirUsuario()

        Dim i As Integer = 0
        While i < DgvRegistros.Rows.Count
            Dim row As DataGridViewRow = DgvRegistros.Rows(i)
            If Convert.ToBoolean(row.Cells(0).Value) Then
                Dim id As Integer = Convert.ToInt16(row.Cells(1).Value)
                ClCliente_Phonebook.id = id
                ClCliente_Phonebook.Deleta()
                DgvRegistros.Rows.Remove(row)
                LblSelectRegister.Visible = False
                PanelSelect.Visible = False
                i -= 1
            End If
            i += 1
        End While
    End Sub

    Private Sub FiltroAvancado(Ctrl As Guna2GradientButton)
        If Ctrl.Checked Then
            Select Case Ctrl.Text

                Case "Nome"
                    ColumnOpcoes = "name"
                    TxtFilter.Text = ""
                    TxtFilter.PlaceholderText = "Informe o Nome..."
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "E-mail"
                    ColumnOpcoes = "email"
                    TxtFilter.Text = ""
                    TxtFilter.PlaceholderText = "Informe o E-mail..."
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "CNPJ/CPF"
                    ColumnOpcoes = "cpf_cnpj"
                    TxtFilter.Text = ""
                    TxtFilter.PlaceholderText = "Informe o CPF ou o CNPJ..."
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "Cidade"
                    ColumnOpcoes = "cidade"
                    TxtFilter.Text = ""
                    TxtFilter.PlaceholderText = "Informe a Cidade..."
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "UF"
                    ColumnOpcoes = "uf"
                    TxtFilter.Text = ""
                    TxtFilter.PlaceholderText = "Informe o UF..."
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "ID"
                    ColumnOpcoes = "id_interno"
                    TxtFilter.Text = ""
                    TxtFilter.PlaceholderText = "Informe o ID..."
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "Mês Atual"
                    ColumnData = "date_cad between DATEADD( DAY, 1, EOMONTH(GETDATE(), -1)) AND EOMONTH( GETDATE(), 0) and"
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True
                    GBoxDataInicial.Visible = False
                    GBoxDataFinal.Visible = False
                    BtnSelectIntervalo.Visible = True

                Case "Ultimo Mês"
                    ColumnData = "date_cad between DATEADD( DAY, 1, EOMONTH(GETDATE(), -2)) AND EOMONTH( GETDATE(), -1) and"
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True
                    GBoxDataInicial.Visible = False
                    GBoxDataFinal.Visible = False
                    BtnSelectIntervalo.Visible = True

                Case "Ultimos 3 Meses"
                    ColumnData = "date_cad between DATEADD( DAY, 1, EOMONTH(GETDATE(), -4)) AND EOMONTH( GETDATE(), -1) and"
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True
                    GBoxDataInicial.Visible = False
                    GBoxDataFinal.Visible = False
                    BtnSelectIntervalo.Visible = True

            End Select
        End If
    End Sub

    Private Sub LimparFiltroAvancado()
        For Each Btn As Guna2GradientButton In New List(Of Guna2GradientButton) From {BtnEmail, BtnCnpj_Cpf, BtnCidade, BtnUF, BtnID, BtnMesAtual, BtnUltimoMes, BtnUltimos3Meses}
            If Btn.Checked Then
                Btn.Checked = False
                BtnNome.Checked = True
                GBoxDataInicial.Visible = False
                GBoxDataFinal.Visible = False
                BtnSelectIntervalo.Visible = True
                TxtFilter.Text = ""
                TxtFilter.PlaceholderText = "Informe o Nome..."
                ColumnOpcoes = "name"
                ColumnGenero = ""
                ColumnData = ""
                SelectTransition.HideSync(PanelFilter)
            End If
        Next
    End Sub

    Public Sub ContarLinha_Dgv()
        Select Case DgvArquivos.Rows.Count

            Case 0
                DgvArquivos.ColumnHeadersVisible = False
                LblQuantidade_Cliente.Visible = False

            Case 1
                LblQuantidade_Cliente.Visible = True
                LblQuantidade_Cliente.Text = $"{DgvArquivos.Rows.Count} Registro"

            Case Else
                LblQuantidade_Cliente.Visible = True
                LblQuantidade_Cliente.Text = $"{DgvArquivos.Rows.Count} Registros"

        End Select
    End Sub

    Private Sub BtnInfoComplementar_Cliente_Click(sender As Object, e As EventArgs) Handles BtnInfoComplementar_Cliente.Click
        If PanelInfoComplementar_Cliente.Visible = False Then
            PanelInfoComplementar_Cliente.Visible = True
        Else
            TxtInfoComplementar_Cliente.Clear()
            PanelInfoComplementar_Cliente.Visible = False
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar_Cliente.Click
        If TxtCPFouCNPJ_Cliente.Text.Length = 14 OrElse TxtCPFouCNPJ_Cliente.Text.Length = 18 Then
            If TxtNome_Cliente.Text.Length > 0 Then
                If CbGenero_Cliente.Text.Length > 0 Then
                    If TxtEmail_Cliente.Text.Length > 0 Then
                        If TxtContatoPrincipal_Cliente.Text.Length > 0 Then
                            If CbCondicao_Cliente.Text.Length > 0 Then
                                If TxtEquipamento_Cliente.Text.Length > 0 Then

                                    ProgressAguarde.Value = 0
                                    TabControl_CadCons.SelectTab(8)
                                    TimerCad_Cliente.Start()

                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TxtCPFouCNPJ_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Cliente.TextChanged
        Select Case Me.TxtCPFouCNPJ_Cliente.Text.Length
            Case 0
                LblCPFouCNPJ_Cliente.Visible = False
            Case Else
                LblCPFouCNPJ_Cliente.Visible = True
        End Select
    End Sub

    Private Sub TxtNome_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtNome_Cliente.TextChanged
        If Me.TxtNome_Cliente.Text.Length > 0 Then
            LblNome_Cliente.Visible = True
        Else
            LblNome_Cliente.Visible = False
        End If
    End Sub

    Private Sub TxtContatoPrincipal_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Cliente.TextChanged
        If Me.TxtContatoPrincipal_Cliente.Text.Length > 0 Then
            LblContatoPrincipal_Cliente.Visible = True
        Else
            LblContatoPrincipal_Cliente.Visible = False
        End If
    End Sub

    Private Sub TxtContatoSecundario_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Cliente.TextChanged
        If Me.TxtContatoSecundario_Cliente.Text.Length > 0 Then
            LblContatoSecundario_Cliente.Visible = True
        Else
            LblContatoSecundario_Cliente.Visible = False
        End If
    End Sub

    Private Sub TxtCelular_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtCelular_Cliente.TextChanged
        If Me.TxtCelular_Cliente.Text.Length > 0 Then
            LblCelular_Cliente.Visible = True
        Else
            LblCelular_Cliente.Visible = False
        End If
    End Sub

    Private Function ValidaCEP(strCheck As String) As Boolean
        Return Regex.IsMatch(strCheck, "^\d{5}-\d{3}$")
    End Function

    Private Sub TxtCEP_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtCEP_Cliente.TextChanged

        ClValidaCep.MaskCep(sender)
        Select Case TxtCEP_Cliente.Text.Length

            Case > 0
                If ValidaCEP(TxtCEP_Cliente.Text) = False Then
                    LblCEP_Cliente.Visible = True
                    TxtCEP_Cliente.IconRight = ImageList.Images(1)
                Else
                    LblCEP_Cliente.Visible = True
                    TxtCEP_Cliente.IconRight = ImageList.Images(0)
                End If

            Case Else
                LblCEP_Cliente.Visible = False
                TxtCEP_Cliente.IconRight = Nothing

        End Select
    End Sub

    Private Sub TxtEndereco_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtEndereco_Cliente.TextChanged
        If Me.TxtEndereco_Cliente.Text.Length > 0 Then
            LblEndereco_Cliente.Visible = True
        Else
            LblEndereco_Cliente.Visible = False
        End If
    End Sub

    Private Sub TxtComplemento_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtComplemento_Cliente.TextChanged
        If Me.TxtComplemento_Cliente.Text.Length > 0 Then
            LblComplemento_Cliente.Visible = True
        Else
            LblComplemento_Cliente.Visible = False
        End If
    End Sub

    Private Sub TxtCidade_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtCidade_Cliente.TextChanged
        If Me.TxtCidade_Cliente.Text.Length > 0 Then
            LblCidade_Cliente.Visible = True
        Else
            LblCidade_Cliente.Visible = False
        End If
    End Sub

    Private Sub TxtUF_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtUF_Cliente.TextChanged
        If Me.TxtUF_Cliente.Text.Length > 0 Then
            LblUF_Cliente.Visible = True
        Else
            LblUF_Cliente.Visible = False
        End If
    End Sub

    Private Sub TxtEquipamento_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtEquipamento_Cliente.TextChanged
        If Me.TxtEquipamento_Cliente.Text.Length > 0 Then
            LblEquipamento_Cliente.Visible = True
        Else
            LblEquipamento_Cliente.Visible = False
        End If
    End Sub

    Private Sub TxtNSerie_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtNSerie_Cliente.TextChanged
        If Me.TxtNSerie_Cliente.Text.Length > 0 Then
            LblNSerie_Cliente.Visible = True
        Else
            LblNSerie_Cliente.Visible = False
        End If
    End Sub

    Private Sub FrmCadastros_Phonebook_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If FrmPrincipal.Cad_Cons = 1 Then
            TabControl_CadCons.SelectTab(1)

        Else
            TabControl_CadCons.SelectTab(0)
        End If

        TabControl_CadCons.TabMenuVisible = False
        TabControl_CadCons.Visible = True
        ClServerSFTP_Phonebook.FileListCliente_Phonebook(DgvArquivos, "Erimat Teleinformatica ltda")
        ContarLinha_Dgv()
    End Sub

    Private Sub BtnCad_Cliente_Click(sender As Object, e As EventArgs) Handles BtnCad_Cliente.Click
        LimparCliente()
        TabControl_CadCons.SelectTab(4)
    End Sub

    Private Sub BtnAnexar_Click(sender As Object, e As EventArgs)
        ClServerSFTP_Phonebook.CarregarArquivo_Phonebook(DgvArquivos, Ofd, "Erimat Teleinformatica ltda", TabControl_CadCons)
    End Sub

    Private Sub LimparCliente()
        TxtCPFouCNPJ_Cliente.Clear()
        TxtNome_Cliente.Clear()
        CbGenero_Cliente.SelectedIndex = -1
        TxtContatoPrincipal_Cliente.Clear()
        TxtContatoSecundario_Cliente.Clear()
        TxtCelular_Cliente.Clear()
        TxtCEP_Cliente.Clear()
        TxtEndereco_Cliente.Clear()
        TxtComplemento_Cliente.Clear()
        TxtCidade_Cliente.Clear()
        TxtUF_Cliente.Clear()
        CbCondicao_Cliente.SelectedIndex = -1
        TxtEquipamento_Cliente.Clear()
        TxtNSerie_Cliente.Clear()
        TxtInfoComplementar_Cliente.Clear()
    End Sub

    Private Sub LimparColaborador()
        TxtCPFouCNPJ_Colaborador.Clear()
        TxtNome_Colaborador.Clear()
        CbGenero_Colaborador.SelectedIndex = -1
        TxtContatoPrincipal_Colaborador.Clear()
        TxtContatoSecundario_Colaborador.Clear()
        TxtCelular_Colaborador.Clear()
        TxtCEP_Colaborador.Clear()
        TxtEndereco_Colaborador.Clear()
        TxtComplemento_Colaborador.Clear()
        TxtCidade_Colaborador.Clear()
        TxtUF_Colaborador.Clear()
        TxtInfoComplementar_Colaborador.Clear()
    End Sub

    Private Sub LimparFornecedor()
        TxtCPFouCNPJ_Fornecedor.Clear()
        TxtNome_Fornecedor.Clear()
        CbGenero_Fornecedor.SelectedIndex = -1
        TxtContatoPrincipal_Fornecedor.Clear()
        TxtContatoSecundario_Fornecedor.Clear()
        TxtCelular_Fornecedor.Clear()
        TxtCEP_Fornecedor.Clear()
        TxtEndereco_Fornecedor.Clear()
        TxtComplemento_Fornecedor.Clear()
        TxtCidade_Fornecedor.Clear()
        TxtUF_Fornecedor.Clear()
        TxtInfoComplementar_Fornecedor.Clear()
    End Sub

    Private Sub BtnCancelar_Cliente_Click(sender As Object, e As EventArgs) Handles BtnCancelar_Cliente.Click
        LimparCliente()

        If FrmPrincipal.Cad_Cons = 2 Then
            TabControl_CadCons.SelectTab(0)
        Else
            TabControl_CadCons.SelectTab(3)
        End If
    End Sub

    Private Sub BtnCancelar_Colaborador_Click(sender As Object, e As EventArgs) Handles BtnCancelar_Colaborador.Click
        LimparColaborador()

        If FrmPrincipal.Cad_Cons = 2 Then
            TabControl_CadCons.SelectTab(0)
        Else
            TabControl_CadCons.SelectTab(3)
        End If
    End Sub

    Private Sub BtnCad_Colaborador_Click(sender As Object, e As EventArgs) Handles BtnCad_Colaborador.Click
        LimparColaborador()
        TabControl_CadCons.SelectTab(5)
    End Sub

    Private Sub TimerCad_Cliente_Tick(sender As Object, e As EventArgs) Handles TimerCad_Cliente.Tick
        ProgressAguarde.Increment(3)

        Select Case ProgressAguarde.Value

            Case 45
                If FrmPrincipal.Cad_Cons = 2 Then
                    ClCliente_Phonebook.cpf_cnpj = TxtCPFouCNPJ_Cliente.Text
                    ClCliente_Phonebook.name = TxtNome_Cliente.Text
                    ClCliente_Phonebook.genero = CbGenero_Cliente.Text
                    ClCliente_Phonebook.email = TxtEmail_Cliente.Text
                    ClCliente_Phonebook.contato_principal = TxtContatoPrincipal_Cliente.Text
                    ClCliente_Phonebook.contato_secundario = TxtContatoSecundario_Cliente.Text
                    ClCliente_Phonebook.celular = TxtCelular_Cliente.Text
                    ClCliente_Phonebook.cep = TxtCEP_Cliente.Text
                    ClCliente_Phonebook.endereco = TxtEndereco_Cliente.Text
                    ClCliente_Phonebook.complemento = TxtComplemento_Cliente.Text
                    ClCliente_Phonebook.cidade = TxtCidade_Cliente.Text
                    ClCliente_Phonebook.uf = TxtUF_Cliente.Text
                    ClCliente_Phonebook.cond_contratual = CbCondicao_Cliente.Text
                    ClCliente_Phonebook.equipamento = TxtEquipamento_Cliente.Text
                    ClCliente_Phonebook.numero_serie = TxtNSerie_Cliente.Text
                    ClCliente_Phonebook.info_complementar = TxtInfoComplementar_Cliente.Text
                    ClCliente_Phonebook.Cadastra()

                Else
                    ClCliente_Phonebook.cpf_cnpj = TxtCPFouCNPJ_Cliente.Text
                    ClCliente_Phonebook.name = TxtNome_Cliente.Text
                    ClCliente_Phonebook.genero = CbGenero_Cliente.Text
                    ClCliente_Phonebook.email = TxtEmail_Cliente.Text
                    ClCliente_Phonebook.contato_principal = TxtContatoPrincipal_Cliente.Text
                    ClCliente_Phonebook.contato_secundario = TxtContatoSecundario_Cliente.Text
                    ClCliente_Phonebook.celular = TxtCelular_Cliente.Text
                    ClCliente_Phonebook.cep = TxtCEP_Cliente.Text
                    ClCliente_Phonebook.endereco = TxtEndereco_Cliente.Text
                    ClCliente_Phonebook.complemento = TxtComplemento_Cliente.Text
                    ClCliente_Phonebook.cidade = TxtCidade_Cliente.Text
                    ClCliente_Phonebook.uf = TxtUF_Cliente.Text
                    ClCliente_Phonebook.cond_contratual = CbCondicao_Cliente.Text
                    ClCliente_Phonebook.equipamento = TxtEquipamento_Cliente.Text
                    ClCliente_Phonebook.numero_serie = TxtNSerie_Cliente.Text
                    ClCliente_Phonebook.info_complementar = TxtInfoComplementar_Cliente.Text
                    ClCliente_Phonebook.Edita()

                End If

            Case 80


            Case 100
                If FrmPrincipal.Cad_Cons = 2 Then
                    TimerCad_Cliente.Stop()
                    LimparCliente()
                    TabControl_CadCons.SelectTab(0)
                    MessageBox.Show($"Cliente cadastrado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    TimerCad_Cliente.Stop()
                    LimparCliente()

                    TabControl_CadCons.SelectTab(3)
                    MessageBox.Show($"Cliente atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


        End Select
    End Sub

    Private Sub TimerCad_Colaborador_Tick(sender As Object, e As EventArgs) Handles TimerCad_Colaborador.Tick
        ProgressAguarde.Increment(3)

        Select Case ProgressAguarde.Value

            Case 45
                If FrmPrincipal.Cad_Cons = 2 Then
                    ClColaborador_Phonebook.cpf_cnpj = TxtCPFouCNPJ_Colaborador.Text
                    ClColaborador_Phonebook.name = TxtNome_Colaborador.Text
                    ClColaborador_Phonebook.genero = CbGenero_Colaborador.Text
                    ClColaborador_Phonebook.email = TxtEmail_Colaborador.Text
                    ClColaborador_Phonebook.contato_principal = TxtContatoPrincipal_Colaborador.Text
                    ClColaborador_Phonebook.contato_secundario = TxtContatoSecundario_Colaborador.Text
                    ClColaborador_Phonebook.celular = TxtCelular_Colaborador.Text
                    ClColaborador_Phonebook.cep = TxtCEP_Colaborador.Text
                    ClColaborador_Phonebook.endereco = TxtEndereco_Colaborador.Text
                    ClColaborador_Phonebook.complemento = TxtComplemento_Colaborador.Text
                    ClColaborador_Phonebook.cidade = TxtCidade_Colaborador.Text
                    ClColaborador_Phonebook.uf = TxtUF_Colaborador.Text
                    ClColaborador_Phonebook.info_complementar = TxtInfoComplementar_Colaborador.Text
                    ClColaborador_Phonebook.Cadastra()

                Else
                    ClColaborador_Phonebook.cpf_cnpj = TxtCPFouCNPJ_Colaborador.Text
                    ClColaborador_Phonebook.name = TxtNome_Colaborador.Text
                    ClColaborador_Phonebook.genero = CbGenero_Colaborador.Text
                    ClColaborador_Phonebook.email = TxtEmail_Colaborador.Text
                    ClColaborador_Phonebook.contato_principal = TxtContatoPrincipal_Colaborador.Text
                    ClColaborador_Phonebook.contato_secundario = TxtContatoSecundario_Colaborador.Text
                    ClColaborador_Phonebook.celular = TxtCelular_Colaborador.Text
                    ClColaborador_Phonebook.cep = TxtCEP_Colaborador.Text
                    ClColaborador_Phonebook.endereco = TxtEndereco_Colaborador.Text
                    ClColaborador_Phonebook.complemento = TxtComplemento_Colaborador.Text
                    ClColaborador_Phonebook.cidade = TxtCidade_Colaborador.Text
                    ClColaborador_Phonebook.uf = TxtUF_Colaborador.Text
                    ClColaborador_Phonebook.info_complementar = TxtInfoComplementar_Colaborador.Text
                    ClColaborador_Phonebook.Edita()

                End If

            Case 80


            Case 100
                If FrmPrincipal.Cad_Cons = 2 Then
                    TimerCad_Colaborador.Stop()
                    LimparColaborador()
                    TabControl_CadCons.SelectTab(0)
                    MessageBox.Show($"Colaborador cadastrado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    TimerCad_Colaborador.Stop()
                    LimparColaborador()
                    TabControl_CadCons.SelectTab(3)
                    MessageBox.Show($"Colaborador atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

        End Select
    End Sub

    Private Sub BtnSalvar_Colaborador_Click(sender As Object, e As EventArgs) Handles BtnSalvar_Colaborador.Click
        If TxtCPFouCNPJ_Colaborador.Text.Length = 14 OrElse 18 Then
            If TxtNome_Colaborador.Text.Length > 0 Then
                If CbGenero_Colaborador.Text.Length > 0 Then
                    If TxtEmail_Colaborador.Text.Length > 0 Then
                        If TxtContatoPrincipal_Colaborador.Text.Length > 0 Then

                            ProgressAguarde.Value = 0
                            TabControl_CadCons.SelectTab(8)
                            TimerCad_Colaborador.Start()

                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnInfoComplementar_Colaborador_Click(sender As Object, e As EventArgs) Handles BtnInfoComplementar_Colaborador.Click
        If PanelInfoComplementar_Colaborador.Visible = False Then
            PanelInfoComplementar_Colaborador.Visible = True
        Else
            TxtInfoComplementar_Colaborador.Clear()
            PanelInfoComplementar_Colaborador.Visible = False
        End If
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles BtnInfoComplementar_Fornecedor.Click
        If PanelInfoComplementar_Fornecedor.Visible = False Then
            PanelInfoComplementar_Fornecedor.Visible = True
        Else
            TxtInfoComplementar_Fornecedor.Clear()
            PanelInfoComplementar_Fornecedor.Visible = False
        End If
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles BtnSalvar_Fornecedor.Click
        If TxtCPFouCNPJ_Fornecedor.Text.Length = 14 OrElse 18 Then
            If TxtNome_Fornecedor.Text.Length > 0 Then
                If TxtEmail_Fornecedor.Text.Length > 0 Then
                    If TxtContatoPrincipal_Fornecedor.Text.Length > 0 Then

                        ProgressAguarde.Value = 0
                        TabControl_CadCons.SelectTab(8)
                        TimerCad_Fornecedor.Start()

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Fornecedor_Click(sender As Object, e As EventArgs) Handles BtnCancelar_Fornecedor.Click
        LimparFornecedor()

        If FrmPrincipal.Cad_Cons = 2 Then
            TabControl_CadCons.SelectTab(0)
        Else
            TabControl_CadCons.SelectTab(3)
        End If
    End Sub

    Private Sub TimerCad_Fornecedor_Tick(sender As Object, e As EventArgs) Handles TimerCad_Fornecedor.Tick
        ProgressAguarde.Increment(3)

        Select Case ProgressAguarde.Value

            Case 45
                If FrmPrincipal.Cad_Cons = 2 Then
                    ClFornecedor_Phonebook.cpf_cnpj = TxtCPFouCNPJ_Fornecedor.Text
                    ClFornecedor_Phonebook.name = TxtNome_Fornecedor.Text
                    ClFornecedor_Phonebook.genero = CbGenero_Fornecedor.Text
                    ClFornecedor_Phonebook.email = TxtEmail_Fornecedor.Text
                    ClFornecedor_Phonebook.contato_principal = TxtContatoPrincipal_Fornecedor.Text
                    ClFornecedor_Phonebook.contato_secundario = TxtContatoSecundario_Fornecedor.Text
                    ClFornecedor_Phonebook.celular = TxtCelular_Fornecedor.Text
                    ClFornecedor_Phonebook.cep = TxtCEP_Fornecedor.Text
                    ClFornecedor_Phonebook.endereco = TxtEndereco_Fornecedor.Text
                    ClFornecedor_Phonebook.complemento = TxtComplemento_Fornecedor.Text
                    ClFornecedor_Phonebook.cidade = TxtCidade_Fornecedor.Text
                    ClFornecedor_Phonebook.uf = TxtUF_Fornecedor.Text
                    ClFornecedor_Phonebook.info_complementar = TxtInfoComplementar_Fornecedor.Text
                    ClFornecedor_Phonebook.Cadastra()

                Else
                    ClFornecedor_Phonebook.cpf_cnpj = TxtCPFouCNPJ_Fornecedor.Text
                    ClFornecedor_Phonebook.name = TxtNome_Fornecedor.Text
                    ClFornecedor_Phonebook.genero = CbGenero_Fornecedor.Text
                    ClFornecedor_Phonebook.email = TxtEmail_Fornecedor.Text
                    ClFornecedor_Phonebook.contato_principal = TxtContatoPrincipal_Fornecedor.Text
                    ClFornecedor_Phonebook.contato_secundario = TxtContatoSecundario_Fornecedor.Text
                    ClFornecedor_Phonebook.celular = TxtCelular_Fornecedor.Text
                    ClFornecedor_Phonebook.cep = TxtCEP_Fornecedor.Text
                    ClFornecedor_Phonebook.endereco = TxtEndereco_Fornecedor.Text
                    ClFornecedor_Phonebook.complemento = TxtComplemento_Fornecedor.Text
                    ClFornecedor_Phonebook.cidade = TxtCidade_Fornecedor.Text
                    ClFornecedor_Phonebook.uf = TxtUF_Fornecedor.Text
                    ClFornecedor_Phonebook.info_complementar = TxtInfoComplementar_Fornecedor.Text
                    ClFornecedor_Phonebook.Edita()

                End If

            Case 80


            Case 100
                If FrmPrincipal.Cad_Cons = 2 Then
                    TimerCad_Fornecedor.Stop()
                    LimparFornecedor()
                    TabControl_CadCons.SelectTab(0)
                    MessageBox.Show($"Fornecedor cadastrado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    TimerCad_Fornecedor.Stop()
                    LimparFornecedor()
                    TabControl_CadCons.SelectTab(3)
                    MessageBox.Show($"Fornecedor cadastrado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

        End Select
    End Sub

    Private Sub TimerDel_Cliente_Tick(sender As Object, e As EventArgs) Handles TimerDel_Cliente.Tick
        ProgressAguarde.Increment(3)

        Select Case ProgressAguarde.Value

            Case 45
                ClCliente_Phonebook.cpf_cnpj = LblId_Interno.Text
                ClCliente_Phonebook.Deleta()

            Case 80


            Case 100
                TimerDel_Cliente.Stop()
                LimparCliente()
                TabControl_CadCons.SelectTab(1)
                MessageBox.Show($"Cliente deletado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Select
    End Sub

    Private Sub BtnDeletar_Click(sender As Object, e As EventArgs) Handles BtnDeletar.Click
        Select Case Perfil

            Case "Cliente"
                ProgressAguarde.Value = 0
                TabControl_CadCons.SelectTab(8)
                TimerDel_Cliente.Start()

            Case "Colaborador"
                ProgressAguarde.Value = 0
                TabControl_CadCons.SelectTab(8)
                TimerDel_Colaborador.Start()

            Case "Fornecedor"
                ProgressAguarde.Value = 0
                TabControl_CadCons.SelectTab(8)
                TimerDel_Fornecedor.Start()

        End Select

    End Sub

    Private Sub TimerDel_Colaborador_Tick(sender As Object, e As EventArgs) Handles TimerDel_Colaborador.Tick
        ProgressAguarde.Increment(3)

        Select Case ProgressAguarde.Value

            Case 45
                ClColaborador_Phonebook.cpf_cnpj = LblId_Interno.Text
                ClColaborador_Phonebook.Deleta()

            Case 80


            Case 100
                TimerDel_Colaborador.Stop()
                LimparColaborador()
                TabControl_CadCons.SelectTab(1)
                MessageBox.Show($"Colaborador deletado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Select
    End Sub

    Private Sub TimerDel_Fornecedor_Tick(sender As Object, e As EventArgs) Handles TimerDel_Fornecedor.Tick
        ProgressAguarde.Increment(3)

        Select Case ProgressAguarde.Value

            Case 45
                ClFornecedor_Phonebook.cpf_cnpj = LblId_Interno.Text
                ClFornecedor_Phonebook.Deleta()

            Case 80


            Case 100
                TimerDel_Fornecedor.Stop()
                LimparFornecedor()
                TabControl_CadCons.SelectTab(1)
                MessageBox.Show($"Fornecedor deletado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Select
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

    End Sub

    Private Sub BtnAnexo_Click(sender As Object, e As EventArgs) Handles BtnAnexo.Click
        ClServerSFTP_Phonebook.FileListCliente_Phonebook(DgvArquivos, LblNome.Text)
        TabControl_CadCons.SelectTab(7)
    End Sub

    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click
        ClServerSFTP_Phonebook.CarregarArquivo_Phonebook(DgvArquivos, Ofd, LblNome.Text, TabControl_CadCons)
        ContarLinha_Dgv()
    End Sub

    Private Sub BtnCad_Fornecedor_Click(sender As Object, e As EventArgs) Handles BtnCad_Fornecedor.Click
        LimparFornecedor()
        TabControl_CadCons.SelectTab(6)
    End Sub

    Private Sub BtnInfoUsuario_Click(sender As Object, e As EventArgs) Handles BtnInfo.Click
        Dim i As Integer = 0

        Select Case Perfil

            Case "Cliente"
                While i < DgvRegistros.Rows.Count
                    Dim row As DataGridViewRow = DgvRegistros.Rows(i)
                    If Convert.ToBoolean(row.Cells(0).Value) Then

                        LblNome.Text = $"{row.Cells(4).Value}"
                        LblId_Interno.Text = $"{row.Cells(2).Value}"
                        LblInformacoes.Text = $"<b>CNPJ/CPF:</b> {row.Cells(3).Value}<br>
                                                <b>Nome:</b> {row.Cells(4).Value}<br>
                                                <b>E-mail:</b> {row.Cells(6).Value}<br>
                                                <b>Contato principal:</b> {row.Cells(7).Value}<br>
                                                <b>Whatsapp:</b> {row.Cells(9).Value}<br>
                                                <b>Endereço:</b> {row.Cells(11).Value}, {row.Cells(12).Value}, {row.Cells(13).Value}, {row.Cells(14).Value}, {row.Cells(10).Value}<br>
                                                <b>Condição:</b> {row.Cells(15).Value}<br>
                                                <b>Equipamento:</b> {row.Cells(16).Value}<br> - <b>Nº de Série:</b> {row.Cells(17).Value}<br><br>
                                                <b>Informações complementares:</b><br> {row.Cells(18).Value}"

                        PanelSelect.Visible = False
                        TabControl_CadCons.SelectTab(3)
                    End If
                    i += 1
                End While


            Case "Colaborador"
                While i < DgvRegistros.Rows.Count
                    Dim row As DataGridViewRow = DgvRegistros.Rows(i)
                    If Convert.ToBoolean(row.Cells(0).Value) Then

                        LblNome.Text = $"{row.Cells(4).Value}"
                        LblId_Interno.Text = $"{row.Cells(2).Value}"
                        LblInformacoes.Text = $"<b>CNPJ/CPF:</b> {row.Cells(3).Value}<br>
                                                <b>Nome:</b> {row.Cells(4).Value}<br>
                                                <b>Gênero:</b> {row.Cells(5).Value}<br>
                                                <b>E-mail:</b> {row.Cells(6).Value}<br>
                                                <b>Contato principal:</b> {row.Cells(7).Value}<br>
                                                <b>Whatsapp:</b> {row.Cells(9).Value}<br>
                                                <b>Endereço:</b> {row.Cells(11).Value}, {row.Cells(12).Value}, {row.Cells(13).Value}, {row.Cells(14).Value}, {row.Cells(10).Value}<br><br>
                                                <b>Informações complementares:</b><br> {row.Cells(15).Value}"

                        PanelSelect.Visible = False
                        TabControl_CadCons.SelectTab(3)
                    End If
                    i += 1
                End While

            Case "Fornecedor"
                While i < DgvRegistros.Rows.Count
                    Dim row As DataGridViewRow = DgvRegistros.Rows(i)
                    If Convert.ToBoolean(row.Cells(0).Value) Then

                        LblNome.Text = $"{row.Cells(4).Value}"
                        LblId_Interno.Text = $"{row.Cells(2).Value}"
                        LblInformacoes.Text = $"<b>CNPJ/CPF:</b> {row.Cells(3).Value}<br>
                                                <b>Nome:</b> {row.Cells(4).Value}<br>
                                                <b>E-mail:</b> {row.Cells(6).Value}<br>
                                                <b>Contato principal:</b> {row.Cells(7).Value}<br>
                                                <b>Whatsapp:</b> {row.Cells(9).Value}<br>
                                                <b>Endereço:</b> {row.Cells(11).Value}, {row.Cells(12).Value}, {row.Cells(13).Value}, {row.Cells(14).Value}, {row.Cells(10).Value}<br><br>
                                                <b>Informações complementares:</b><br> {row.Cells(15).Value}"

                        PanelSelect.Visible = False
                        TabControl_CadCons.SelectTab(3)
                    End If
                    i += 1
                End While

        End Select
    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        DgvArquivos.Rows.Clear()
        PanelSelect_Anexo.Visible = False
        TabControl_CadCons.SelectTab(3)
    End Sub

    Private Sub BtnVoltarMenu_Click(sender As Object, e As EventArgs) Handles BtnVoltarLista.Click
        TabControl_CadCons.SelectTab(2)
    End Sub

    Private Sub VoltarMenu_Click(sender As Object, e As EventArgs) Handles VoltarMenu.Click
        DgvArquivos.Rows.Clear()
        PanelSelect.Visible = False
        TabControl_CadCons.SelectTab(1)
    End Sub

    Private Sub BtnListar_Cliente_Click_1(sender As Object, e As EventArgs) Handles BtnListar_Cliente.Click
        Perfil = "Cliente"
        VerificaTabela()
        TabControl_CadCons.SelectTab(2)
    End Sub

    Private Sub BtnListar_Colaborador_Click(sender As Object, e As EventArgs) Handles BtnListar_Colaborador.Click
        Perfil = "Colaborador"
        VerificaTabela()
        TabControl_CadCons.SelectTab(2)
    End Sub

    Private Sub BtnListar_Fornecedor_Click(sender As Object, e As EventArgs) Handles BtnListar_Fornecedor.Click
        Perfil = "Fornecedor"
        VerificaTabela()
        TabControl_CadCons.SelectTab(2)
    End Sub

    Private Sub VerificaTabela()
        Select Case Perfil

            Case "Cliente"
                BuscarRegistros("cliente_phonebook")
                FormataGridView_Cliente()

            Case "Colaborador"
                BuscarRegistros("colaborador_phonebook")
                FormataGridView_Colaborador_Fornecedor()

            Case "Fornecedor"
                BuscarRegistros("fornecedor_phonebook")
                FormataGridView_Colaborador_Fornecedor()

        End Select
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimparFiltroAvancado()
        VerificaTabela()
    End Sub

    Private Sub BtnAplicar_Click(sender As Object, e As EventArgs) Handles BtnAplicar.Click
        If BtnSelectIntervalo.Visible = False Then
            If ColumnOpcoes = "" Then
                ColumnData = $"date_cad between '{DataInicial.Value.ToShortDateString()}' and '{DataFinal.Value.ToShortDateString()}'"
            Else
                ColumnData = $"date_cad between '{DataInicial.Value.ToShortDateString()}' and '{DataFinal.Value.ToShortDateString()}' and"
            End If
        End If

        SelectTransition.HideSync(PanelFilter)
        VerificaTabela()
    End Sub

    Private Sub BtnNome_Click(sender As Object, e As EventArgs) Handles BtnNome.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnEmail_Click(sender As Object, e As EventArgs) Handles BtnEmail.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnCnpj_Cpf_Click(sender As Object, e As EventArgs) Handles BtnCnpj_Cpf.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnCidade_Click(sender As Object, e As EventArgs) Handles BtnCidade.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnUF_Click(sender As Object, e As EventArgs) Handles BtnUF.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnID_Click(sender As Object, e As EventArgs) Handles BtnID.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnMesAtual_Click(sender As Object, e As EventArgs) Handles BtnMesAtual.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnUltimoMes_Click(sender As Object, e As EventArgs) Handles BtnUltimoMes.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnUltimos3Meses_Click(sender As Object, e As EventArgs) Handles BtnUltimos3Meses.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnSelectIntervalo_Click(sender As Object, e As EventArgs) Handles BtnSelectIntervalo.Click
        BtnSelectIntervalo.Visible = False
        GBoxDataInicial.Visible = True
        GBoxDataFinal.Visible = True
        BtnMesAtual.Checked = False
        BtnUltimoMes.Checked = False
        BtnUltimos3Meses.Checked = False
        BtnAplicar.Visible = True
        BtnLimpar.Visible = True
    End Sub

    Private Sub FrmCadastros_Phonebook_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        PanelFilter.Location = TxtFilter.Location + New Point(35, 71)
    End Sub

    Private Sub BtnSelectApagar_Click(sender As Object, e As EventArgs) Handles BtnSelectApagar.Click
        ExcluirUsuario()
        VerificaTabela()
    End Sub

    Private Sub TxtFilter_TextChanged(sender As Object, e As EventArgs) Handles TxtFilter.TextChanged
        If DgvRegistros.DataSource IsNot Nothing Then
            VerificaTabela()
        End If
    End Sub

    Private Sub TxtFilter_IconLeftClick(sender As Object, e As EventArgs) Handles TxtFilter.IconLeftClick
        If DgvRegistros.DataSource IsNot Nothing Then
            If PanelFilter.Visible = False Then
                PanelFilter.BringToFront()
                SelectTransition.ShowSync(PanelFilter)
            Else
                SelectTransition.HideSync(PanelFilter)
            End If
        End If
    End Sub

    Private Sub CbRegistrosPorPagina_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbRegistrosPorPagina.SelectionChangeCommitted
        If DgvRegistros.Rows.Count > 0 Then
            VerificaTabela()
        End If
    End Sub

    Private Sub DgvRegistros_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRegistros.CellValueChanged
        'MultSelectRow(sender)
        SelecionarLinha_Contar(e)
    End Sub

    Private Sub DgvRegistros_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DgvRegistros.CurrentCellDirtyStateChanged
        If DgvRegistros.IsCurrentCellDirty Then
            DgvRegistros.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub PanelPaginacao_Resize(sender As Object, e As EventArgs) Handles PanelVoltar_Anexo.Resize

        Dim x = (PanelVoltar_Anexo.Size.Width - LblPaginacao.Width) / 2
        Dim y = (PanelVoltar_Anexo.Size.Height - LblPaginacao.Height) / 2

        LblPaginacao.Location = New Point(x, y)

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Select Case Perfil

            Case "Cliente"
                DgvPaginacao_Seguinte("cliente_phonebook")

            Case "Colaborador"
                DgvPaginacao_Seguinte("colaborador_phonebook")

            Case "Fornecedor"
                DgvPaginacao_Seguinte("fornecedor_phonebook")

        End Select
    End Sub

    Private Sub BtnPrevio_Click(sender As Object, e As EventArgs) Handles BtnPrevio.Click
        Select Case Perfil

            Case "Cliente"
                DgvPaginacao_Anterior("cliente_phonebook")

            Case "Colaborador"
                DgvPaginacao_Anterior("colaborador_phonebook")

            Case "Fornecedor"
                DgvPaginacao_Anterior("fornecedor_phonebook")

        End Select
    End Sub

    Private Sub TxtCPFouCNPJ_Cliente_LostFocus(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Cliente.LostFocus
        Select Case Me.TxtCPFouCNPJ_Cliente.Text.Length
            Case 11
                Me.TxtCPFouCNPJ_Cliente.Text = Convert.ToUInt64(Me.TxtCPFouCNPJ_Cliente.Text).ToString($"000\.000\.000\-00")
                Me.TxtCPFouCNPJ_Cliente.IconRight = Nothing
            Case 14
                Me.TxtCPFouCNPJ_Cliente.Text = Convert.ToUInt64(Me.TxtCPFouCNPJ_Cliente.Text).ToString($"00\.000\.000\/0000\-00")
                Me.TxtCPFouCNPJ_Cliente.IconRight = Nothing
            Case Else
                Me.TxtCPFouCNPJ_Cliente.IconRight = ImageList.Images(1)
        End Select
    End Sub

    Private Sub TxtCPFouCNPJ_Cliente_Enter(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Cliente.Enter
        Me.TxtCPFouCNPJ_Cliente.Text = Me.TxtCPFouCNPJ_Cliente.Text.Replace(".", "").Replace("-", "").Replace("/", "")
        Me.TxtCPFouCNPJ_Cliente.IconRight = Nothing
    End Sub

    Private Sub TxtCelular_Cliente_LostFocus(sender As Object, e As EventArgs) Handles TxtCelular_Cliente.LostFocus
        If Me.TxtCelular_Cliente.Text.Length <> 10 Then
            If Me.TxtCelular_Cliente.Text.Length <> 15 Then
                Me.TxtCelular_Cliente.IconRight = ImageList.Images(1)
            End If
        End If
    End Sub

    Private Sub TxtCelular_Cliente_Enter(sender As Object, e As EventArgs) Handles TxtCelular_Cliente.Enter
        Me.TxtCelular_Cliente.Text = Me.TxtCelular_Cliente.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        Me.TxtCelular_Cliente.IconRight = Nothing
    End Sub

    Private Sub TxtContatoPrincipal_Cliente_LostFocus(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Cliente.LostFocus
        Dim mask = Me.TxtContatoPrincipal_Cliente.Text
        Select Case Me.TxtContatoPrincipal_Cliente.Text.Length
            Case 8
                If Not Me.TxtContatoPrincipal_Cliente.Text.StartsWith("0") Then
                    Me.TxtContatoPrincipal_Cliente.Text = mask.Insert(4, "-")
                    Me.TxtContatoPrincipal_Cliente.IconRight = Nothing
                Else
                    Me.TxtContatoPrincipal_Cliente.IconRight = ImageList.Images(1)
                End If

            Case 9
                If Not Me.TxtContatoPrincipal_Cliente.Text.StartsWith("0") Then
                    Me.TxtContatoPrincipal_Cliente.Text = mask.Insert(5, "-")
                    Me.TxtContatoPrincipal_Cliente.IconRight = Nothing
                Else
                    Me.TxtContatoPrincipal_Cliente.IconRight = ImageList.Images(1)
                End If

            Case 10
                If Not Me.TxtContatoPrincipal_Cliente.Text.StartsWith("0") Then
                    Me.TxtContatoPrincipal_Cliente.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(9, "-")
                    Me.TxtContatoPrincipal_Cliente.IconRight = Nothing
                Else
                    Me.TxtContatoPrincipal_Cliente.IconRight = ImageList.Images(1)
                End If

            Case 11
                If Me.TxtContatoPrincipal_Cliente.Text.StartsWith("0800") Then
                    Me.TxtContatoPrincipal_Cliente.Text = mask.Insert(4, " ").Insert(8, " ")
                    Me.TxtContatoPrincipal_Cliente.IconRight = Nothing
                Else
                    If Not Me.TxtContatoPrincipal_Cliente.Text.StartsWith("0") Then
                        Me.TxtContatoPrincipal_Cliente.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                        Me.TxtContatoPrincipal_Cliente.IconRight = Nothing
                    Else
                        Me.TxtContatoPrincipal_Cliente.IconRight = ImageList.Images(1)
                    End If

                End If
        End Select
    End Sub

    Private Sub TxtContatoPrincipal_Cliente_Enter(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Cliente.Enter
        Me.TxtContatoPrincipal_Cliente.Text = Me.TxtContatoPrincipal_Cliente.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        Me.TxtContatoPrincipal_Cliente.IconRight = Nothing
    End Sub

    Private Sub TxtContatoSecundario_Cliente_LostFocus(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Cliente.LostFocus
        Dim mask = Me.TxtContatoSecundario_Cliente.Text
        Select Case Me.TxtContatoSecundario_Cliente.Text.Length
            Case 8
                If Not Me.TxtContatoSecundario_Cliente.Text.StartsWith("0") Then
                    Me.TxtContatoSecundario_Cliente.Text = mask.Insert(4, "-")
                    Me.TxtContatoSecundario_Cliente.IconRight = Nothing
                Else
                    Me.TxtContatoSecundario_Cliente.IconRight = ImageList.Images(1)
                End If

            Case 9
                If Not Me.TxtContatoSecundario_Cliente.Text.StartsWith("0") Then
                    Me.TxtContatoSecundario_Cliente.Text = mask.Insert(5, "-")
                    Me.TxtContatoSecundario_Cliente.IconRight = Nothing
                Else
                    Me.TxtContatoSecundario_Cliente.IconRight = ImageList.Images(1)
                End If

            Case 10
                If Not Me.TxtContatoSecundario_Cliente.Text.StartsWith("0") Then
                    Me.TxtContatoSecundario_Cliente.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(9, "-")
                    Me.TxtContatoSecundario_Cliente.IconRight = Nothing
                Else
                    Me.TxtContatoSecundario_Cliente.IconRight = ImageList.Images(1)
                End If

            Case 11
                If Me.TxtContatoSecundario_Cliente.Text.StartsWith("0800") Then
                    Me.TxtContatoSecundario_Cliente.Text = mask.Insert(4, " ").Insert(8, " ")
                    Me.TxtContatoSecundario_Cliente.IconRight = Nothing
                Else
                    If Not Me.TxtContatoSecundario_Cliente.Text.StartsWith("0") Then
                        Me.TxtContatoSecundario_Cliente.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                        Me.TxtContatoSecundario_Cliente.IconRight = Nothing
                    Else
                        Me.TxtContatoSecundario_Cliente.IconRight = ImageList.Images(1)
                    End If

                End If
        End Select
    End Sub

    Private Sub TxtContatoSecundario_Cliente_Enter(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Cliente.Enter
        Me.TxtContatoSecundario_Cliente.Text = Me.TxtContatoSecundario_Cliente.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        Me.TxtContatoSecundario_Cliente.IconRight = Nothing
    End Sub

    Private Sub TxtCelular_Cliente_Validated(sender As Object, e As EventArgs) Handles TxtCelular_Cliente.Validated
        Dim mask = Me.TxtCelular_Cliente.Text
        Select Case Me.TxtCelular_Cliente.Text.Length
            Case 0
                Me.TxtCelular_Cliente.IconRight = Nothing

            Case 9
                If Me.TxtCelular_Cliente.Text.StartsWith("0") Then
                    Me.TxtCelular_Cliente.Text = mask.Insert(5, "-")
                    Me.TxtCelular_Cliente.IconRight = Nothing
                Else
                    Me.TxtCelular_Cliente.IconRight = ImageList.Images(1)
                End If

            Case 11
                If Not Me.TxtCelular_Cliente.Text.StartsWith("0") Then
                    Me.TxtCelular_Cliente.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                    Me.TxtCelular_Cliente.IconRight = Nothing
                Else
                    Me.TxtCelular_Cliente.IconRight = ImageList.Images(1)
                End If
        End Select
    End Sub

    Private Sub TxtContatoPrincipal_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContatoPrincipal_Cliente.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCPFouCNPJ_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCPFouCNPJ_Cliente.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtContatoSecundario_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContatoSecundario_Cliente.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCelular_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCelular_Cliente.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True

        End If
    End Sub





    Private Sub TxtCPFouCNPJ_Colaborador_LostFocus(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Colaborador.LostFocus
        Select Case Me.TxtCPFouCNPJ_Colaborador.Text.Length
            Case 11
                Me.TxtCPFouCNPJ_Colaborador.Text = Convert.ToUInt64(Me.TxtCPFouCNPJ_Colaborador.Text).ToString($"000\.000\.000\-00")
                Me.TxtCPFouCNPJ_Colaborador.IconRight = Nothing
            Case 14
                Me.TxtCPFouCNPJ_Colaborador.Text = Convert.ToUInt64(Me.TxtCPFouCNPJ_Colaborador.Text).ToString($"00\.000\.000\/0000\-00")
                Me.TxtCPFouCNPJ_Colaborador.IconRight = Nothing
            Case Else
                Me.TxtCPFouCNPJ_Colaborador.IconRight = ImageList.Images(1)
        End Select
    End Sub

    Private Sub TxtCPFouCNPJ_Colaborador_Enter(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Colaborador.Enter
        Me.TxtCPFouCNPJ_Colaborador.Text = Me.TxtCPFouCNPJ_Colaborador.Text.Replace(".", "").Replace("-", "").Replace("/", "")
        Me.TxtCPFouCNPJ_Colaborador.IconRight = Nothing
    End Sub

    Private Sub TxtCelular_Colaborador_LostFocus(sender As Object, e As EventArgs) Handles TxtCelular_Colaborador.LostFocus
        If Me.TxtCelular_Colaborador.Text.Length <> 10 Then
            If Me.TxtCelular_Colaborador.Text.Length <> 15 Then
                Me.TxtCelular_Colaborador.IconRight = ImageList.Images(1)
            End If
        End If
    End Sub

    Private Sub TxtCelular_Colaborador_Enter(sender As Object, e As EventArgs) Handles TxtCelular_Colaborador.Enter
        Me.TxtCelular_Colaborador.Text = Me.TxtCelular_Colaborador.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        Me.TxtCelular_Colaborador.IconRight = Nothing
    End Sub

    Private Sub TxtContatoPrincipal_Colaborador_LostFocus(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Colaborador.LostFocus
        Dim mask = Me.TxtContatoPrincipal_Colaborador.Text
        Select Case Me.TxtContatoPrincipal_Colaborador.Text.Length
            Case 8
                If Not Me.TxtContatoPrincipal_Colaborador.Text.StartsWith("0") Then
                    Me.TxtContatoPrincipal_Colaborador.Text = mask.Insert(4, "-")
                    Me.TxtContatoPrincipal_Colaborador.IconRight = Nothing
                Else
                    Me.TxtContatoPrincipal_Colaborador.IconRight = ImageList.Images(1)
                End If

            Case 9
                If Not Me.TxtContatoPrincipal_Colaborador.Text.StartsWith("0") Then
                    Me.TxtContatoPrincipal_Colaborador.Text = mask.Insert(5, "-")
                    Me.TxtContatoPrincipal_Colaborador.IconRight = Nothing
                Else
                    Me.TxtContatoPrincipal_Colaborador.IconRight = ImageList.Images(1)
                End If

            Case 10
                If Not Me.TxtContatoPrincipal_Colaborador.Text.StartsWith("0") Then
                    Me.TxtContatoPrincipal_Colaborador.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(9, "-")
                    Me.TxtContatoPrincipal_Colaborador.IconRight = Nothing
                Else
                    Me.TxtContatoPrincipal_Colaborador.IconRight = ImageList.Images(1)
                End If

            Case 11
                If Me.TxtContatoPrincipal_Colaborador.Text.StartsWith("0800") Then
                    Me.TxtContatoPrincipal_Colaborador.Text = mask.Insert(4, " ").Insert(8, " ")
                    Me.TxtContatoPrincipal_Colaborador.IconRight = Nothing
                Else
                    If Not Me.TxtContatoPrincipal_Colaborador.Text.StartsWith("0") Then
                        Me.TxtContatoPrincipal_Colaborador.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                        Me.TxtContatoPrincipal_Colaborador.IconRight = Nothing
                    Else
                        Me.TxtContatoPrincipal_Colaborador.IconRight = ImageList.Images(1)
                    End If

                End If
        End Select
    End Sub

    Private Sub TxtContatoPrincipal_Colaborador_Enter(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Colaborador.Enter
        Me.TxtContatoPrincipal_Colaborador.Text = Me.TxtContatoPrincipal_Colaborador.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        Me.TxtContatoPrincipal_Colaborador.IconRight = Nothing
    End Sub

    Private Sub TxtContatoSecundario_Colaborador_LostFocus(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Colaborador.LostFocus
        Dim mask = Me.TxtContatoSecundario_Colaborador.Text
        Select Case Me.TxtContatoSecundario_Colaborador.Text.Length
            Case 8
                If Not Me.TxtContatoSecundario_Colaborador.Text.StartsWith("0") Then
                    Me.TxtContatoSecundario_Colaborador.Text = mask.Insert(4, "-")
                    Me.TxtContatoSecundario_Colaborador.IconRight = Nothing
                Else
                    Me.TxtContatoSecundario_Colaborador.IconRight = ImageList.Images(1)
                End If

            Case 9
                If Not Me.TxtContatoSecundario_Colaborador.Text.StartsWith("0") Then
                    Me.TxtContatoSecundario_Colaborador.Text = mask.Insert(5, "-")
                    Me.TxtContatoSecundario_Colaborador.IconRight = Nothing
                Else
                    Me.TxtContatoSecundario_Colaborador.IconRight = ImageList.Images(1)
                End If

            Case 10
                If Not Me.TxtContatoSecundario_Colaborador.Text.StartsWith("0") Then
                    Me.TxtContatoSecundario_Colaborador.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(9, "-")
                    Me.TxtContatoSecundario_Colaborador.IconRight = Nothing
                Else
                    Me.TxtContatoSecundario_Colaborador.IconRight = ImageList.Images(1)
                End If

            Case 11
                If Me.TxtContatoSecundario_Colaborador.Text.StartsWith("0800") Then
                    Me.TxtContatoSecundario_Colaborador.Text = mask.Insert(4, " ").Insert(8, " ")
                    Me.TxtContatoSecundario_Colaborador.IconRight = Nothing
                Else
                    If Not Me.TxtContatoSecundario_Colaborador.Text.StartsWith("0") Then
                        Me.TxtContatoSecundario_Colaborador.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                        Me.TxtContatoSecundario_Colaborador.IconRight = Nothing
                    Else
                        Me.TxtContatoSecundario_Colaborador.IconRight = ImageList.Images(1)
                    End If

                End If
        End Select
    End Sub

    Private Sub TxtContatoSecundario_Colaborador_Enter(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Colaborador.Enter
        Me.TxtContatoSecundario_Colaborador.Text = Me.TxtContatoSecundario_Colaborador.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        Me.TxtContatoSecundario_Colaborador.IconRight = Nothing
    End Sub

    Private Sub TxtCelular_Colaborador_Validated(sender As Object, e As EventArgs) Handles TxtCelular_Colaborador.Validated
        Dim mask = Me.TxtCelular_Colaborador.Text
        Select Case Me.TxtCelular_Colaborador.Text.Length
            Case 0
                Me.TxtCelular_Colaborador.IconRight = Nothing

            Case 9
                If Me.TxtCelular_Colaborador.Text.StartsWith("0") Then
                    Me.TxtCelular_Colaborador.Text = mask.Insert(5, "-")
                    Me.TxtCelular_Colaborador.IconRight = Nothing
                Else
                    Me.TxtCelular_Colaborador.IconRight = ImageList.Images(1)
                End If

            Case 11
                If Not Me.TxtCelular_Colaborador.Text.StartsWith("0") Then
                    Me.TxtCelular_Colaborador.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                    Me.TxtCelular_Colaborador.IconRight = Nothing
                Else
                    Me.TxtCelular_Colaborador.IconRight = ImageList.Images(1)
                End If
        End Select
    End Sub

    Private Sub TxtContatoPrincipal_Colaborador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContatoPrincipal_Colaborador.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCPFouCNPJ_Colaborador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCPFouCNPJ_Colaborador.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtContatoSecundario_Colaborador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContatoSecundario_Colaborador.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCelular_Colaborador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCelular_Colaborador.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub





    Private Sub TxtCPFouCNPJ_Fornecedor_LostFocus(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Fornecedor.LostFocus
        Select Case Me.TxtCPFouCNPJ_Fornecedor.Text.Length
            Case 11
                Me.TxtCPFouCNPJ_Fornecedor.Text = Convert.ToUInt64(Me.TxtCPFouCNPJ_Fornecedor.Text).ToString($"000\.000\.000\-00")
                Me.TxtCPFouCNPJ_Fornecedor.IconRight = Nothing
            Case 14
                Me.TxtCPFouCNPJ_Fornecedor.Text = Convert.ToUInt64(Me.TxtCPFouCNPJ_Fornecedor.Text).ToString($"00\.000\.000\/0000\-00")
                Me.TxtCPFouCNPJ_Fornecedor.IconRight = Nothing
            Case Else
                Me.TxtCPFouCNPJ_Fornecedor.IconRight = ImageList.Images(1)
        End Select
    End Sub

    Private Sub TxtCPFouCNPJ_Fornecedor_Enter(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Fornecedor.Enter
        Me.TxtCPFouCNPJ_Fornecedor.Text = Me.TxtCPFouCNPJ_Fornecedor.Text.Replace(".", "").Replace("-", "").Replace("/", "")
        Me.TxtCPFouCNPJ_Fornecedor.IconRight = Nothing
    End Sub

    Private Sub TxtCelular_Fornecedor_LostFocus(sender As Object, e As EventArgs) Handles TxtCelular_Fornecedor.LostFocus
        If Me.TxtCelular_Fornecedor.Text.Length <> 10 Then
            If Me.TxtCelular_Fornecedor.Text.Length <> 15 Then
                Me.TxtCelular_Fornecedor.IconRight = ImageList.Images(1)
            End If
        End If
    End Sub

    Private Sub TxtCelular_Fornecedor_Enter(sender As Object, e As EventArgs) Handles TxtCelular_Fornecedor.Enter
        Me.TxtCelular_Fornecedor.Text = Me.TxtCelular_Fornecedor.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        Me.TxtCelular_Fornecedor.IconRight = Nothing
    End Sub

    Private Sub TxtContatoPrincipal_Fornecedor_LostFocus(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Fornecedor.LostFocus
        Dim mask = Me.TxtContatoPrincipal_Fornecedor.Text
        Select Case Me.TxtContatoPrincipal_Fornecedor.Text.Length
            Case 8
                If Not Me.TxtContatoPrincipal_Fornecedor.Text.StartsWith("0") Then
                    Me.TxtContatoPrincipal_Fornecedor.Text = mask.Insert(4, "-")
                    Me.TxtContatoPrincipal_Fornecedor.IconRight = Nothing
                Else
                    Me.TxtContatoPrincipal_Fornecedor.IconRight = ImageList.Images(1)
                End If

            Case 9
                If Not Me.TxtContatoPrincipal_Fornecedor.Text.StartsWith("0") Then
                    Me.TxtContatoPrincipal_Fornecedor.Text = mask.Insert(5, "-")
                    Me.TxtContatoPrincipal_Fornecedor.IconRight = Nothing
                Else
                    Me.TxtContatoPrincipal_Fornecedor.IconRight = ImageList.Images(1)
                End If

            Case 10
                If Not Me.TxtContatoPrincipal_Fornecedor.Text.StartsWith("0") Then
                    Me.TxtContatoPrincipal_Fornecedor.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(9, "-")
                    Me.TxtContatoPrincipal_Fornecedor.IconRight = Nothing
                Else
                    Me.TxtContatoPrincipal_Fornecedor.IconRight = ImageList.Images(1)
                End If

            Case 11
                If Me.TxtContatoPrincipal_Fornecedor.Text.StartsWith("0800") Then
                    Me.TxtContatoPrincipal_Fornecedor.Text = mask.Insert(4, " ").Insert(8, " ")
                    Me.TxtContatoPrincipal_Fornecedor.IconRight = Nothing
                Else
                    If Not Me.TxtContatoPrincipal_Fornecedor.Text.StartsWith("0") Then
                        Me.TxtContatoPrincipal_Fornecedor.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                        Me.TxtContatoPrincipal_Fornecedor.IconRight = Nothing
                    Else
                        Me.TxtContatoPrincipal_Fornecedor.IconRight = ImageList.Images(1)
                    End If

                End If
        End Select
    End Sub

    Private Sub TxtContatoPrincipal_Fornecedor_Enter(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Fornecedor.Enter
        Me.TxtContatoPrincipal_Fornecedor.Text = Me.TxtContatoPrincipal_Fornecedor.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        Me.TxtContatoPrincipal_Fornecedor.IconRight = Nothing
    End Sub

    Private Sub TxtContatoSecundario_Fornecedor_LostFocus(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Fornecedor.LostFocus
        Dim mask = Me.TxtContatoSecundario_Fornecedor.Text
        Select Case Me.TxtContatoSecundario_Fornecedor.Text.Length
            Case 8
                If Not Me.TxtContatoSecundario_Fornecedor.Text.StartsWith("0") Then
                    Me.TxtContatoSecundario_Fornecedor.Text = mask.Insert(4, "-")
                    Me.TxtContatoSecundario_Fornecedor.IconRight = Nothing
                Else
                    Me.TxtContatoSecundario_Fornecedor.IconRight = ImageList.Images(1)
                End If

            Case 9
                If Not Me.TxtContatoSecundario_Fornecedor.Text.StartsWith("0") Then
                    Me.TxtContatoSecundario_Fornecedor.Text = mask.Insert(5, "-")
                    Me.TxtContatoSecundario_Fornecedor.IconRight = Nothing
                Else
                    Me.TxtContatoSecundario_Fornecedor.IconRight = ImageList.Images(1)
                End If

            Case 10
                If Not Me.TxtContatoSecundario_Fornecedor.Text.StartsWith("0") Then
                    Me.TxtContatoSecundario_Fornecedor.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(9, "-")
                    Me.TxtContatoSecundario_Fornecedor.IconRight = Nothing
                Else
                    Me.TxtContatoSecundario_Fornecedor.IconRight = ImageList.Images(1)
                End If

            Case 11
                If Me.TxtContatoSecundario_Fornecedor.Text.StartsWith("0800") Then
                    Me.TxtContatoSecundario_Fornecedor.Text = mask.Insert(4, " ").Insert(8, " ")
                    Me.TxtContatoSecundario_Fornecedor.IconRight = Nothing
                Else
                    If Not Me.TxtContatoSecundario_Fornecedor.Text.StartsWith("0") Then
                        Me.TxtContatoSecundario_Fornecedor.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                        Me.TxtContatoSecundario_Fornecedor.IconRight = Nothing
                    Else
                        Me.TxtContatoSecundario_Fornecedor.IconRight = ImageList.Images(1)
                    End If

                End If
        End Select
    End Sub

    Private Sub TxtContatoSecundario_Fornecedor_Enter(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Fornecedor.Enter
        Me.TxtContatoSecundario_Fornecedor.Text = Me.TxtContatoSecundario_Fornecedor.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        Me.TxtContatoSecundario_Fornecedor.IconRight = Nothing
    End Sub

    Private Sub TxtCelular_Fornecedor_Validated(sender As Object, e As EventArgs) Handles TxtCelular_Fornecedor.Validated
        Dim mask = Me.TxtCelular_Fornecedor.Text
        Select Case Me.TxtCelular_Fornecedor.Text.Length
            Case 0
                Me.TxtCelular_Fornecedor.IconRight = Nothing

            Case 9
                If Me.TxtCelular_Fornecedor.Text.StartsWith("0") Then
                    Me.TxtCelular_Fornecedor.Text = mask.Insert(5, "-")
                    Me.TxtCelular_Fornecedor.IconRight = Nothing
                Else
                    Me.TxtCelular_Fornecedor.IconRight = ImageList.Images(1)
                End If

            Case 11
                If Not Me.TxtCelular_Fornecedor.Text.StartsWith("0") Then
                    Me.TxtCelular_Fornecedor.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                    Me.TxtCelular_Fornecedor.IconRight = Nothing
                Else
                    Me.TxtCelular_Fornecedor.IconRight = ImageList.Images(1)
                End If
        End Select
    End Sub

    Private Sub TxtContatoPrincipal_Fornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContatoPrincipal_Fornecedor.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCPFouCNPJ_Fornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCPFouCNPJ_Fornecedor.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtContatoSecundario_Fornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContatoSecundario_Fornecedor.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCelular_Fornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCelular_Fornecedor.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class