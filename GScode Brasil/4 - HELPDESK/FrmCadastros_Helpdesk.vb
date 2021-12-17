Imports System.Text.RegularExpressions
Imports System.Threading
Imports Guna.UI2.WinForms

Public Class FrmCadastros_Helpdesk

    Private ReadOnly ClEmail As New Email
    Private ReadOnly ClOS_Helpdesk As New OS_Helpdesk
    Private ReadOnly ClCliente_Phonebook As New Cliente_Phonebook
    Private ReadOnly ClValidaCep As New ValidaCep

    Private PaginaAtual As Integer = 1
    Private PaginaTotal As Double
    Private ColumnOpcoes As String = "name"
    Private ColumnPrioridade As String = ""
    Private ColumnCondicao As String = ""
    Private ColumnStatus As String = ""
    Private ColumnData As String = ""
    Private RegistroDe As Integer
    Private RegistroAte As Integer
    Private Senha = "#"

    Private Sub FormataGridView_Gerenciador()
        With DgvGerenciador
            .GridColor = Color.WhiteSmoke
            .DefaultCellStyle.Font = New Font("Segoe UI Semibold", 9)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(223, 243, 251)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersDefaultCellStyle.Font = New Font("Segoe UI Bold", 9)
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(6).HeaderText = "Data"
            .Columns(8).HeaderText = "Nome"
            .Columns(22).HeaderText = "Ocorrência"
            .Columns(23).HeaderText = "Condição Contratual"
            .Columns(0).HeaderCell = New CheckHeaderCell

            .Columns(0).Visible = True
            .Columns(1).Visible = True
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(7).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            .Columns(19).Visible = False
            .Columns(20).Visible = False
            .Columns(21).Visible = False
            .Columns(24).Visible = False
            .Columns(25).Visible = False
            .Columns(26).Visible = False
            .Columns(27).Visible = False
            .Columns(28).Visible = False
            .Columns(29).Visible = False
            .Columns(30).Visible = False
            .Columns(31).Visible = False

            .Columns(0).ReadOnly = False
            .Columns(1).ReadOnly = True
            .Columns(6).ReadOnly = True
            .Columns(8).ReadOnly = True
            .Columns(22).ReadOnly = True

            .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(22).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        End With
    End Sub

    Public Sub FormataGridView_Painel()
        With DgvPainel

            .GridColor = Color.WhiteSmoke
            .DefaultCellStyle.Font = New Font("Segoe UI Semibold", 10)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(223, 243, 251)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersDefaultCellStyle.Font = New Font("Segoe UI Bold", 10)
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(5).HeaderText = "Data"
            .Columns(7).HeaderText = "Nome"
            .Columns(21).HeaderText = "Ocorrência"
            .Columns(22).HeaderText = "Condição"

            .Columns(0).Visible = True
            .Columns(1).Visible = False
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(6).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            .Columns(19).Visible = False
            .Columns(20).Visible = False
            .Columns(23).Visible = False
            .Columns(24).Visible = False
            .Columns(25).Visible = False
            .Columns(26).Visible = False
            .Columns(27).Visible = False
            .Columns(28).Visible = False
            .Columns(29).Visible = False
            .Columns(30).Visible = False

            .Columns(0).ReadOnly = False
            .Columns(5).ReadOnly = True
            .Columns(7).ReadOnly = True
            .Columns(21).ReadOnly = True
            .Columns(22).ReadOnly = True

            .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(21).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        End With
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

                Case "Equipamento"
                    ColumnOpcoes = "equipamento"
                    TxtFilter.Text = ""
                    TxtFilter.PlaceholderText = "Informe o Equipamento..."
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "Nº de serie"
                    ColumnOpcoes = "nserie"
                    TxtFilter.Text = ""
                    TxtFilter.PlaceholderText = "Informe o Nº de serie do Equipamento..."
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "ID"
                    ColumnOpcoes = "id_interno"
                    TxtFilter.Text = ""
                    TxtFilter.PlaceholderText = "Informe o ID..."
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "Baixa"
                    ColumnPrioridade = "prioridade = 'Baixa' And "
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "Média"
                    ColumnPrioridade = "prioridade = 'Média' And "
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "Alta"
                    ColumnPrioridade = "prioridade = 'Alta' And "
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "Urgente"
                    ColumnPrioridade = "prioridade = 'Urgente' And "
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "C/ Contrato"
                    ColumnCondicao = "condicao = 'C/ Contrato' And "
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "S/ Contrato"
                    ColumnCondicao = "condicao = 'S/ Contrato' And "
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "Garantia"
                    ColumnCondicao = "condicao = 'Garantia' And "
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "Mês Atual"
                    ColumnData = "data_os between DATEADD( DAY, 1, EOMONTH(GETDATE(), -1)) And EOMONTH( GETDATE(), 0) And"
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True
                    GBoxDataInicial.Visible = False
                    GBoxDataFinal.Visible = False
                    BtnSelectIntervalo.Visible = True

                Case "Ultimo Mês"
                    ColumnData = "data_os between DATEADD( DAY, 1, EOMONTH(GETDATE(), -2)) And EOMONTH( GETDATE(), -1) And"
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True
                    GBoxDataInicial.Visible = False
                    GBoxDataFinal.Visible = False
                    BtnSelectIntervalo.Visible = True

                Case "Ultimos 3 Meses"
                    ColumnData = "data_os between DATEADD( DAY, 1, EOMONTH(GETDATE(), -4)) And EOMONTH( GETDATE(), -1) And"
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True
                    GBoxDataInicial.Visible = False
                    GBoxDataFinal.Visible = False
                    BtnSelectIntervalo.Visible = True

            End Select
        End If
    End Sub

    Private Sub BuscarRegistros()
        Dim NDecimal As Integer

        RegistroAte = CbRegistrosPorPagina.Text

        ClOS_Helpdesk.CountarOS($"Select COUNT(*) FROM os_helpdesk WHERE {ColumnData} {ColumnPrioridade} {ColumnCondicao} {ColumnStatus} {ColumnOpcoes} Like '{TxtFilter.Text}%'")
        ClOS_Helpdesk.BuscarTodasOS(DgvGerenciador, $"SELECT * FROM os_helpdesk WHERE {ColumnData} {ColumnPrioridade} {ColumnCondicao} {ColumnStatus} {ColumnOpcoes} like '{TxtFilter.Text}%' ORDER BY id DESC OFFSET {RegistroDe} ROWS FETCH NEXT {RegistroAte} ROWS ONLY")

        If ClOS_Helpdesk.TotalOS > 0 Then
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

        PaginaTotal = ClOS_Helpdesk.TotalOS / CInt(CbRegistrosPorPagina.Text)
        PaginaTotal = ClOS_Helpdesk.TotalOS / CInt(CbRegistrosPorPagina.Text)
        NDecimal = ClOS_Helpdesk.TotalOS Mod CInt(CbRegistrosPorPagina.Text)
        If DgvGerenciador.Rows.Count > 0 Then
            If PaginaTotal > 0 Then
                If NDecimal > 0 Then
                    PaginaTotal = ClOS_Helpdesk.TotalOS \ CInt(CbRegistrosPorPagina.Text)
                    PaginaTotal += 1
                End If
            Else
                PaginaTotal += 1
            End If
        Else
            PaginaTotal = 0
        End If


        LblPaginacao.Text = $"Página {PaginaAtual} de {PaginaTotal} ({ClOS_Helpdesk.TotalOS} registros)"


        LblSelectRegister.Visible = False
        PanelSelect.Visible = False
    End Sub

    Private Sub DgvPaginacao_Seguinte()
        Dim NDecimal As Integer

        RegistroAte = CbRegistrosPorPagina.Text

        If PaginaAtual = PaginaTotal Then
            Exit Sub
        End If

        RegistroDe = CInt(CbRegistrosPorPagina.Text) * PaginaAtual

        ClOS_Helpdesk.CountarOS($"Select COUNT(*) FROM os_helpdesk WHERE {ColumnData} {ColumnPrioridade} {ColumnCondicao} {ColumnStatus} {ColumnOpcoes} Like '{TxtFilter.Text}%'")
        ClOS_Helpdesk.BuscarTodasOS(DgvGerenciador, $"SELECT * FROM os_helpdesk WHERE {ColumnData} {ColumnPrioridade} {ColumnCondicao} {ColumnStatus} {ColumnOpcoes} like '{TxtFilter.Text}%' ORDER BY id DESC OFFSET {RegistroDe} ROWS FETCH NEXT {RegistroAte} ROWS ONLY")

        PaginaAtual += 1
        PaginaTotal = ClOS_Helpdesk.TotalOS / CInt(CbRegistrosPorPagina.Text)
        PaginaTotal = ClOS_Helpdesk.TotalOS / CInt(CbRegistrosPorPagina.Text)
        NDecimal = ClOS_Helpdesk.TotalOS Mod CInt(CbRegistrosPorPagina.Text)
        If PaginaTotal > 0 Then
            If NDecimal > 0 Then
                PaginaTotal = ClOS_Helpdesk.TotalOS \ CInt(CbRegistrosPorPagina.Text)
                PaginaTotal += 1
            End If
        Else
            PaginaTotal += 1
        End If

        LblPaginacao.Text = $"Página {PaginaAtual} de {PaginaTotal} ({ClOS_Helpdesk.TotalOS} registros)"
        DgvGerenciador.Columns(0).HeaderCell = New CheckHeaderCell
        LblSelectRegister.Visible = False
        PanelSelect.Visible = False
    End Sub

    Private Sub DgvPaginacao_Anterior()
        Dim NDecimal As Integer

        RegistroAte = CbRegistrosPorPagina.Text

        If PaginaAtual = 1 Then
            Exit Sub
        End If

        RegistroDe -= CInt(CbRegistrosPorPagina.Text)

        ClOS_Helpdesk.CountarOS($"Select COUNT(*) FROM os_helpdesk WHERE {ColumnData} {ColumnPrioridade} {ColumnCondicao} {ColumnStatus} {ColumnOpcoes} Like '{TxtFilter.Text}%'")
        ClOS_Helpdesk.BuscarTodasOS(DgvGerenciador, $"SELECT * FROM os_helpdesk WHERE {ColumnData} {ColumnPrioridade} {ColumnCondicao} {ColumnStatus} {ColumnOpcoes} like '{TxtFilter.Text}%' ORDER BY id DESC OFFSET {RegistroDe} ROWS FETCH NEXT {RegistroAte} ROWS ONLY")

        PaginaAtual -= 1
        PaginaTotal = ClOS_Helpdesk.TotalOS / CInt(CbRegistrosPorPagina.Text)
        PaginaTotal = ClOS_Helpdesk.TotalOS / CInt(CbRegistrosPorPagina.Text)
        NDecimal = ClOS_Helpdesk.TotalOS Mod CInt(CbRegistrosPorPagina.Text)
        If PaginaTotal > 0 Then
            If NDecimal > 0 Then
                PaginaTotal = ClOS_Helpdesk.TotalOS \ CInt(CbRegistrosPorPagina.Text)
                PaginaTotal += 1
            End If
        Else
            PaginaTotal += 1
        End If


        LblPaginacao.Text = $"Página {PaginaAtual} de {PaginaTotal} ({ClOS_Helpdesk.TotalOS} registros)"
        DgvGerenciador.Columns(0).HeaderCell = New CheckHeaderCell
        LblSelectRegister.Visible = False
        PanelSelect.Visible = False
    End Sub

    Private Sub ToolTipLoad()
        Dim Ttip As New ToolTip With {
            .AutoPopDelay = 3500,
            .ShowAlways = True
        }
        Ttip.SetToolTip(BtnVoltarLista, "Voltar")
        Ttip.SetToolTip(BtnLigar, "Ligar")
        Ttip.SetToolTip(BtnEditar, "Editar OS")
        Ttip.SetToolTip(BtnDeletar, "Excluir OS")
        Ttip.Active = True
    End Sub

    Private Function CodigoInterno() As String
        Dim Rand = New Random
        Dim Caracteres = "0123456789"
        Dim NumeroMaximo = Caracteres.Length
        Dim Numero As Integer

        For i = 0 To 4
            Numero = Rand.Next(NumeroMaximo)
            Senha = $"{Senha}{Caracteres(Numero)}"
        Next

        Return Senha
    End Function

    Private Sub FrmCadastros_Helpdesk_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ToolTipLoad()

        Select Case FrmPrincipal.TabSelect

            Case "Abrir OS"
                TabControl_CadCons.SelectTab(4)
            Case "Painel"
                ClOS_Helpdesk.BuscarOSAbertas(DgvPainel)
                FormataGridView_Painel()
                TabControl_CadCons.SelectTab(1)
            Case "Gerenciador"
                BuscarRegistros()
                FormataGridView_Gerenciador()
                TabControl_CadCons.SelectTab(0)
            Case "Agenda"

            Case "Relatório"

            Case "Home"

        End Select

        TabControl_CadCons.TabMenuVisible = False
        TabControl_CadCons.Visible = True

        ClCliente_Phonebook.BuscarNomeCliente(TxtNome_Ocorrencia)
    End Sub

    Private Sub MostrarLabel(Txt As Guna2TextBox, Lbl As Label)
        If Txt.Text.Length > 0 Then
            Lbl.Visible = True
        Else
            Lbl.Visible = False
        End If
    End Sub

    Private Function TxtEmpty(Valida As Boolean)
        For Each Txt As Guna2TextBox In New List(Of Guna2TextBox) From {TxtCPFouCNPJ_Ocorrencia, TxtNome_Ocorrencia, TxtEmail_Ocorrencia, TxtContato_Ocorrencia, TxtContatoPrincipal_Ocorrencia, TxtEquipamento_Ocorrencia, TxtOcorrencia}
            If Txt.Text.Length <= 0 Then
                Txt.IconRight = ImageList.Images(1)
                Valida = True
            End If
        Next
        For Each Cbox As Guna2ComboBox In New List(Of Guna2ComboBox) From {CbPrioridade_Ocorrencia, CbCondicao_Ocorrencia}
            If Cbox.Text.Length <= 0 Then
                Cbox.FillColor = Color.FromArgb(255, 198, 198)
                Valida = True
            End If
        Next
        Return Valida
    End Function

    Private Sub BtnSalvar_Ocorrencia_Click(sender As Object, e As EventArgs) Handles BtnSalvar_Ocorrencia.Click
        Dim Valida As Boolean
        TxtEmpty(Valida)

        If Valida = False Then
            If ValidaEmail(TxtEmail_Ocorrencia.Text) Then
                If TxtCEP_Ocorrencia.Text.Length = 0 OrElse (TxtCEP_Ocorrencia.Text) Then
                    ProgressAguarde.Value = 0
                    TabControl_CadCons.SelectTab(7)
                    TimerCad.Start()
                End If
            End If
        End If
    End Sub

    Private Sub Limpar_OC()
        TxtCPFouCNPJ_Ocorrencia.Clear()
        TxtNome_Ocorrencia.Clear()
        TxtEmail_Ocorrencia.Clear()
        TxtContato_Ocorrencia.Clear()
        TxtContatoPrincipal_Ocorrencia.Clear()
        TxtContatoSecundario_Ocorrencia.Clear()
        TxtCelular_Ocorrencia.Clear()
        TxtCEP_Ocorrencia.Clear()
        TxtEndereco_Ocorrencia.Clear()
        TxtComplemento_Ocorrencia.Clear()
        TxtUF_Ocorrencia.Clear()
        CbPrioridade_Ocorrencia.SelectedIndex = -1
        TxtEquipamento_Ocorrencia.Clear()
        TxtNSerie_Ocorrencia.Clear()
        TxtOcorrencia.Clear()
        CbCondicao_Ocorrencia.SelectedIndex = -1
    End Sub

    Private Sub Limpar_RES()
        TxtResultado.Clear()
        TxtContato_Resultado.Clear()
        CbTempo_Resultado.SelectedIndex = -1
        CbStatus_Resultado.SelectedIndex = -1
    End Sub

    Private Cad_Cons As Integer

    Private Sub TimerCad_Tick(sender As Object, e As EventArgs) Handles TimerCad.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 80
                Select Case Cad_Cons

                    Case 0
                        CodigoInterno()
                        ClOS_Helpdesk.id_interno = Senha
                        ClOS_Helpdesk.ValidaCodigoInterno()

                        If ClOS_Helpdesk.Valida = True Then
                            ClOS_Helpdesk.Valida = False
                            CodigoInterno()
                            ClOS_Helpdesk.id_interno = Senha
                            ClOS_Helpdesk.ValidaCodigoInterno()
                        Else
                            ClOS_Helpdesk.id_interno = Senha
                            ClOS_Helpdesk.nome_oc = FrmPrincipal.LblNameLeft.Text
                            ClOS_Helpdesk.email_oc = FrmPrincipal.LblEmailLeft.Text
                            ClOS_Helpdesk.data_oc = DateAndTime.Now
                            ClOS_Helpdesk.cpf_cnpj = TxtCPFouCNPJ_Ocorrencia.Text
                            ClOS_Helpdesk.name = TxtNome_Ocorrencia.Text
                            ClOS_Helpdesk.email = TxtEmail_Ocorrencia.Text
                            ClOS_Helpdesk.contato_oc = TxtContato_Ocorrencia.Text
                            ClOS_Helpdesk.telefone_principal = TxtContatoPrincipal_Ocorrencia.Text
                            ClOS_Helpdesk.telefone_secundario = TxtContatoSecundario_Ocorrencia.Text
                            ClOS_Helpdesk.celular = TxtCelular_Ocorrencia.Text
                            ClOS_Helpdesk.cep = TxtCEP_Ocorrencia.Text
                            ClOS_Helpdesk.endereco = TxtEndereco_Ocorrencia.Text
                            ClOS_Helpdesk.complemento = TxtComplemento_Ocorrencia.Text
                            ClOS_Helpdesk.cidade = TxtCidade_Ocorrencia.Text
                            ClOS_Helpdesk.uf = TxtUF_Ocorrencia.Text
                            ClOS_Helpdesk.prioridade = CbPrioridade_Ocorrencia.Text
                            ClOS_Helpdesk.equipamento = TxtEquipamento_Ocorrencia.Text
                            ClOS_Helpdesk.nserie = TxtNSerie_Ocorrencia.Text
                            ClOS_Helpdesk.ocorrencia = TxtOcorrencia.Text
                            ClOS_Helpdesk.condicao = CbCondicao_Ocorrencia.Text
                            ClOS_Helpdesk.nome_res = ""
                            ClOS_Helpdesk.email_res = ""
                            ClOS_Helpdesk.data_res = ""
                            ClOS_Helpdesk.resultado = ""
                            ClOS_Helpdesk.contato_res = ""
                            ClOS_Helpdesk.tempo_conexao = ""
                            ClOS_Helpdesk.status = ""
                            ClOS_Helpdesk.Cadastra()

                            If ClOS_Helpdesk.Valida = True Then
                                ClOS_Helpdesk.Valida = False
                                If TxtSendEmail_Ocorrencia.Text.Length > 0 Then
                                    ClEmail.nome_oc = FrmPrincipal.LblNameLeft.Text
                                    ClEmail.email_oc = FrmPrincipal.LblEmailLeft.Text
                                    ClEmail.data_oc = DateAndTime.Now

                                    ClEmail.id_interno = Senha
                                    ClEmail.name = TxtNome_Ocorrencia.Text
                                    ClEmail.cpf_cnpj = TxtCPFouCNPJ_Ocorrencia.Text
                                    ClEmail.email_cont = TxtEmail_Ocorrencia.Text
                                    ClEmail.telefone_principal = TxtContatoPrincipal_Ocorrencia.Text
                                    ClEmail.telefone_secundario = TxtContatoSecundario_Ocorrencia.Text
                                    ClEmail.celular = TxtCelular_Ocorrencia.Text
                                    ClEmail.contato_oc = TxtContato_Ocorrencia.Text
                                    ClEmail.endereco = TxtEndereco_Ocorrencia.Text
                                    ClEmail.complemento = TxtComplemento_Ocorrencia.Text
                                    ClEmail.cidade = TxtCidade_Ocorrencia.Text
                                    ClEmail.uf = TxtUF_Ocorrencia.Text
                                    ClEmail.cep = TxtCEP_Ocorrencia.Text
                                    ClEmail.condicao = CbCondicao_Ocorrencia.Text
                                    ClEmail.prioridade = CbPrioridade_Ocorrencia.Text
                                    ClEmail.equipamento = TxtEquipamento_Ocorrencia.Text
                                    ClEmail.nserie = TxtNSerie_Ocorrencia.Text
                                    ClEmail.ocorrencia = TxtOcorrencia.Text

                                    Select Case CbPrioridade_Ocorrencia.Text
                                        Case "Baixa"
                                            ClEmail.Color = "SodgerBlue"
                                        Case "Média"
                                            ClEmail.Color = "OliveDrab"
                                        Case "Alta"
                                            ClEmail.Color = "DarkOrange"
                                        Case "Urgente"
                                            ClEmail.Color = "Red"
                                    End Select

                                    ClEmail.ToEmail = TxtSendEmail_Ocorrencia.Text
                                    ClEmail.NewOS_Helpdesk()
                                End If
                            End If
                        End If
                    Case 1
                        ClOS_Helpdesk.nome_oc = FrmPrincipal.LblNameLeft.Text
                        ClOS_Helpdesk.email_oc = FrmPrincipal.LblEmailLeft.Text
                        ClOS_Helpdesk.data_oc = DateAndTime.Now
                        ClOS_Helpdesk.cpf_cnpj = TxtCPFouCNPJ_Ocorrencia.Text
                        ClOS_Helpdesk.name = TxtNome_Ocorrencia.Text
                        ClOS_Helpdesk.email = TxtEmail_Ocorrencia.Text
                        ClOS_Helpdesk.contato_oc = TxtContato_Ocorrencia.Text
                        ClOS_Helpdesk.telefone_principal = TxtContatoPrincipal_Ocorrencia.Text
                        ClOS_Helpdesk.telefone_secundario = TxtContatoSecundario_Ocorrencia.Text
                        ClOS_Helpdesk.celular = TxtCelular_Ocorrencia.Text
                        ClOS_Helpdesk.cep = TxtCEP_Ocorrencia.Text
                        ClOS_Helpdesk.endereco = TxtEndereco_Ocorrencia.Text
                        ClOS_Helpdesk.complemento = TxtComplemento_Ocorrencia.Text
                        ClOS_Helpdesk.cidade = TxtCidade_Ocorrencia.Text
                        ClOS_Helpdesk.uf = TxtUF_Ocorrencia.Text
                        ClOS_Helpdesk.prioridade = CbPrioridade_Ocorrencia.Text
                        ClOS_Helpdesk.equipamento = TxtEquipamento_Ocorrencia.Text
                        ClOS_Helpdesk.nserie = TxtNSerie_Ocorrencia.Text
                        ClOS_Helpdesk.ocorrencia = TxtOcorrencia.Text
                        ClOS_Helpdesk.condicao = CbCondicao_Ocorrencia.Text
                        ClOS_Helpdesk.id_interno = DgvGerenciador.CurrentRow.Cells(3).Value
                        ClOS_Helpdesk.Edita_oc()

                        If ClOS_Helpdesk.Valida = True Then
                            ClOS_Helpdesk.Valida = False
                            If TxtSendEmail_Ocorrencia.Text.Length > 0 Then
                                ClEmail.nome_oc = FrmPrincipal.LblNameLeft.Text
                                ClEmail.email_oc = FrmPrincipal.LblEmailLeft.Text
                                ClEmail.data_oc = DateAndTime.Now

                                ClEmail.id_interno = Senha
                                ClEmail.name = TxtNome_Ocorrencia.Text
                                ClEmail.cpf_cnpj = TxtCPFouCNPJ_Ocorrencia.Text
                                ClEmail.email_cont = TxtEmail_Ocorrencia.Text
                                ClEmail.telefone_principal = TxtContatoPrincipal_Ocorrencia.Text
                                ClEmail.telefone_secundario = TxtContatoSecundario_Ocorrencia.Text
                                ClEmail.celular = TxtCelular_Ocorrencia.Text
                                ClEmail.contato_oc = TxtContato_Ocorrencia.Text
                                ClEmail.endereco = TxtEndereco_Ocorrencia.Text
                                ClEmail.complemento = TxtComplemento_Ocorrencia.Text
                                ClEmail.cidade = TxtCidade_Ocorrencia.Text
                                ClEmail.uf = TxtUF_Ocorrencia.Text
                                ClEmail.cep = TxtCEP_Ocorrencia.Text
                                ClEmail.condicao = CbCondicao_Ocorrencia.Text
                                ClEmail.prioridade = CbPrioridade_Ocorrencia.Text
                                ClEmail.equipamento = TxtEquipamento_Ocorrencia.Text
                                ClEmail.nserie = TxtNSerie_Ocorrencia.Text
                                ClEmail.ocorrencia = TxtOcorrencia.Text

                                Select Case CbPrioridade_Ocorrencia.Text
                                    Case "Baixa"
                                        ClEmail.Color = "SodgerBlue"
                                    Case "Média"
                                        ClEmail.Color = "OliveDrab"
                                    Case "Alta"
                                        ClEmail.Color = "DarkOrange"
                                    Case "Urgente"
                                        ClEmail.Color = "Red"
                                End Select

                                ClEmail.ToEmail = TxtSendEmail_Ocorrencia.Text
                                ClEmail.NewOS_Helpdesk()
                            End If
                        End If
                    Case 2
                        ClOS_Helpdesk.nome_res = FrmPrincipal.LblNameLeft.Text
                        ClOS_Helpdesk.email_res = FrmPrincipal.LblEmailLeft.Text
                        ClOS_Helpdesk.data_res = DateAndTime.Now
                        ClOS_Helpdesk.resultado = TxtResultado.Text
                        ClOS_Helpdesk.contato_res = TxtContato_Resultado.Text
                        ClOS_Helpdesk.tempo_conexao = CbTempo_Resultado.Text
                        ClOS_Helpdesk.status = CbStatus_Resultado.Text
                        ClOS_Helpdesk.id_interno = DgvGerenciador.CurrentRow.Cells(3).Value
                        ClOS_Helpdesk.Edita_res()

                        If ClOS_Helpdesk.Valida = True Then
                            ClOS_Helpdesk.Valida = False
                            If TxtSendEmail_Resultado.Text.Length > 0 Then
                                ClEmail.nome_oc = DgvGerenciador.CurrentRow.Cells(4).Value
                                ClEmail.email_oc = DgvGerenciador.CurrentRow.Cells(5).Value
                                ClEmail.data_oc = DgvGerenciador.CurrentRow.Cells(6).Value

                                ClEmail.id_interno = DgvGerenciador.CurrentRow.Cells(3).Value
                                ClEmail.name = DgvGerenciador.CurrentRow.Cells(8).Value
                                ClEmail.cpf_cnpj = DgvGerenciador.CurrentRow.Cells(7).Value
                                ClEmail.email_cont = DgvGerenciador.CurrentRow.Cells(9).Value
                                ClEmail.telefone_principal = DgvGerenciador.CurrentRow.Cells(11).Value
                                ClEmail.telefone_secundario = DgvGerenciador.CurrentRow.Cells(12).Value
                                ClEmail.celular = DgvGerenciador.CurrentRow.Cells(13).Value
                                ClEmail.contato_oc = DgvGerenciador.CurrentRow.Cells(10).Value
                                ClEmail.endereco = DgvGerenciador.CurrentRow.Cells(15).Value
                                ClEmail.complemento = DgvGerenciador.CurrentRow.Cells(16).Value
                                ClEmail.cidade = DgvGerenciador.CurrentRow.Cells(17).Value
                                ClEmail.uf = DgvGerenciador.CurrentRow.Cells(18).Value
                                ClEmail.cep = DgvGerenciador.CurrentRow.Cells(14).Value
                                ClEmail.condicao = DgvGerenciador.CurrentRow.Cells(23).Value
                                ClEmail.prioridade = DgvGerenciador.CurrentRow.Cells(19).Value
                                ClEmail.equipamento = DgvGerenciador.CurrentRow.Cells(20).Value
                                ClEmail.nserie = DgvGerenciador.CurrentRow.Cells(21).Value
                                ClEmail.ocorrencia = DgvGerenciador.CurrentRow.Cells(22).Value

                                If CbStatus_Resultado.Text = "Encerrado - Cliente sem Contrato" Then
                                    ClEmail.faturamento = $"<br><br><br>
                                                            <b><font size ='5' color='Red'>{LblFaturamento.Text}</font></b><br><br><br><br><br><br><br>"
                                Else
                                    ClEmail.faturamento = $"<br><br><br><br><br><br><br>"
                                End If

                                ClEmail.nome_res = FrmPrincipal.LblNameLeft.Text
                                ClEmail.email_res = FrmPrincipal.LblEmailLeft.Text
                                ClEmail.data_res = DateAndTime.Now
                                ClEmail.resultado = TxtResultado.Text
                                ClEmail.contato_res = TxtContato_Resultado.Text
                                ClEmail.tempo_conexao = CbTempo_Resultado.Text
                                ClEmail.status = CbStatus_Resultado.Text

                                Select Case CbPrioridade_Ocorrencia.Text
                                    Case "Baixa"
                                        ClEmail.Color = "SodgerBlue"
                                    Case "Média"
                                        ClEmail.Color = "OliveDrab"
                                    Case "Alta"
                                        ClEmail.Color = "DarkOrange"
                                    Case "Urgente"
                                        ClEmail.Color = "Red"
                                End Select

                                ClEmail.ToEmail = TxtSendEmail_Resultado.Text

                                NewThread = New Thread(AddressOf ClEmail.ResultadoOS_Helpdesk) With {.IsBackground = True}
                                NewThread.Start()
                            End If
                        End If
                End Select

            Case 100
                TimerPainel.Enabled = True
                Select Case Cad_Cons
                    Case 0
                        TimerCad.Stop()
                        Limpar_RES()
                        Limpar_OC()
                        TabControl_CadCons.SelectTab(4)
                        MessageBox.Show($"OS aberta com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case Else
                        TimerCad.Stop()
                        Limpar_RES()
                        Limpar_OC()
                        TabControl_CadCons.SelectTab(0)
                        BuscarRegistros()
                        FormataGridView_Gerenciador()
                        ClOS_Helpdesk.BuscarOSAbertas(DgvPainel)
                        FormataGridView_Painel()
                        MessageBox.Show($"OS atualizada com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Select
        End Select
    End Sub

    Private Sub DgvPainel_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DgvPainel.RowsAdded
        For Each linha As DataGridViewRow In DgvPainel.Rows
            Select Case linha.Cells(18).Value
                Case "Baixa"
                    linha.Cells(0).Value = IMG_list.Images(0)
                Case "Média"
                    linha.Cells(0).Value = IMG_list.Images(1)
                Case "Alta"
                    linha.Cells(0).Value = IMG_list.Images(2)
                Case "Urgente"
                    linha.Cells(0).Value = IMG_list.Images(3)
            End Select
        Next

        For Intx As Integer = 0 To DgvPainel.Rows.Count - 1

            Dim StatusColor As String = DgvPainel.Rows(Intx).Cells(29).Value.ToString

            If StatusColor = "Encerrado - Cliente S/ Contrato" Then
                DgvPainel.Rows(Intx).DefaultCellStyle.BackColor = Color.Red
                DgvPainel.Rows(Intx).DefaultCellStyle.ForeColor = Color.White
            End If

            If StatusColor = "Necessário abrir OS para ir ao local" Then
                DgvPainel.Rows(Intx).DefaultCellStyle.BackColor = Color.YellowGreen
            End If

            If StatusColor = "Chamado está em andamento" Then
                DgvPainel.Rows(Intx).DefaultCellStyle.BackColor = Color.LightSkyBlue
            End If

            If StatusColor = "Aguardando Pendência da Erimat" Then
                DgvPainel.Rows(Intx).DefaultCellStyle.BackColor = Color.Olive
            End If

            If StatusColor = "Aguardando Pendência do Cliente" Then
                DgvPainel.Rows(Intx).DefaultCellStyle.BackColor = Color.Yellow
            End If

        Next
    End Sub

    Private Sub DgvGerenciador_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DgvGerenciador.RowsAdded
        For Each linha As DataGridViewRow In DgvGerenciador.Rows
            Select Case linha.Cells(19).Value
                Case "Baixa"
                    linha.Cells(1).Value = IMG_list.Images(0)
                Case "Média"
                    linha.Cells(1).Value = IMG_list.Images(1)
                Case "Alta"
                    linha.Cells(1).Value = IMG_list.Images(2)
                Case "Urgente"
                    linha.Cells(1).Value = IMG_list.Images(3)
            End Select

            If linha.Cells(30).Value = "Encerrado - Cliente de Contrato" OrElse linha.Cells(30).Value = "Encerrado - Cliente S/ Contrato" OrElse linha.Cells(30).Value = "Encerrado - Sem Cobrança" OrElse linha.Cells(30).Value = "Cancelado pela Erimat" OrElse linha.Cells(30).Value = "Cancelado pelo Cliente" OrElse linha.Cells(30).Value = "Necessário abrir OS para ir ao local" Then
                linha.Cells(1).Value = IMG_list.Images(4)
            End If
        Next

        For Intx As Integer = 0 To DgvPainel.Rows.Count - 1

            Dim StatusColor As String = DgvPainel.Rows(Intx).Cells(30).Value.ToString

            If StatusColor = "Encerrado - Cliente S/ Contrato" Then
                DgvPainel.Rows(Intx).DefaultCellStyle.BackColor = Color.Red
                DgvPainel.Rows(Intx).DefaultCellStyle.ForeColor = Color.White
            End If

            If StatusColor = "Necessário abrir OS para ir ao local" Then
                DgvPainel.Rows(Intx).DefaultCellStyle.BackColor = Color.YellowGreen
            End If

            If StatusColor = "Chamado está em andamento" Then
                DgvPainel.Rows(Intx).DefaultCellStyle.BackColor = Color.LightSkyBlue
            End If

            If StatusColor = "Aguardando Pendência da Erimat" Then
                DgvPainel.Rows(Intx).DefaultCellStyle.BackColor = Color.Olive
            End If

            If StatusColor = "Aguardando Pendência do Cliente" Then
                DgvPainel.Rows(Intx).DefaultCellStyle.BackColor = Color.Yellow
            End If

        Next
    End Sub

    Private Sub PanelPaginacao_Resize(sender As Object, e As EventArgs) Handles PanelVoltar_Anexo.Resize

        Dim x = (PanelVoltar_Anexo.Size.Width - LblPaginacao.Width) / 2
        Dim y = (PanelVoltar_Anexo.Size.Height - LblPaginacao.Height) / 2

        LblPaginacao.Location = New Point(x, y)

    End Sub

    Private Sub CbRegistrosPorPagina_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbRegistrosPorPagina.SelectionChangeCommitted
        If DgvGerenciador.Rows.Count > 0 Then
            BuscarRegistros()
            FormataGridView_Gerenciador()
        End If
    End Sub

    Private Sub TxtFilter_TextChanged(sender As Object, e As EventArgs) Handles TxtFilter.TextChanged
        If DgvGerenciador.DataSource IsNot Nothing Then
            BuscarRegistros()
            FormataGridView_Gerenciador()
        End If
    End Sub

    Private Sub TxtFilter_IconLeftClick(sender As Object, e As EventArgs) Handles TxtFilter.IconLeftClick
        If DgvGerenciador.DataSource IsNot Nothing Then
            If PanelFilter.Visible = False Then
                TxtFilter.ReadOnly = True
                TxtFilter.Clear()
                PanelFilter.BringToFront()
                SelectTransition.ShowSync(PanelFilter)
            Else
                TxtFilter.ReadOnly = False
                SelectTransition.HideSync(PanelFilter)
            End If
        End If
    End Sub

    Private Sub CBStatus_Validated(sender As Object, e As EventArgs) Handles CBStatus.Validated
        If CBStatus.Text = "OS Aberta" Then
            ColumnStatus = $"status Like '%andamento' OR status = '' And"
        Else
            ColumnStatus = $"status = '{CBStatus.Text}' And"
        End If
    End Sub

    Private Sub TimerPainel_Tick(sender As Object, e As EventArgs) Handles TimerPainel.Tick
        TimerPainel.Enabled = False
        ClOS_Helpdesk.BuscarOSAbertas(DgvPainel)
        FormataGridView_Painel()

    End Sub

    Private Sub FrmCadastros_Helpdesk_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Cad_Cons = 0
        TimerPainel.Enabled = False
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        DgvPaginacao_Seguinte()
    End Sub

    Private Sub BtnPrevio_Click(sender As Object, e As EventArgs) Handles BtnPrevio.Click
        DgvPaginacao_Anterior()
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

    Private Sub BtnEquipamento_Click(sender As Object, e As EventArgs) Handles BtnEquipamento.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnNSerie_Click(sender As Object, e As EventArgs) Handles BtnNSerie.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnID_Click(sender As Object, e As EventArgs) Handles BtnID.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnBaixa_Click(sender As Object, e As EventArgs) Handles BtnBaixa.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnMedia_Click(sender As Object, e As EventArgs) Handles BtnMedia.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnUrgente_Click(sender As Object, e As EventArgs) Handles BtnUrgente.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnCContrato_Click(sender As Object, e As EventArgs) Handles BtnCContrato.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnSContrato_Click(sender As Object, e As EventArgs) Handles BtnSContrato.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnGarantia_Click(sender As Object, e As EventArgs) Handles BtnGarantia.Click
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

    Private Sub BtnAplicar_Click(sender As Object, e As EventArgs) Handles BtnAplicar.Click
        If BtnSelectIntervalo.Visible = False Then
            If ColumnOpcoes = "" Then
                ColumnData = $"data_os between '{DataInicial.Value.ToShortDateString()}' and '{DataFinal.Value.ToShortDateString()}'"
            Else
                ColumnData = $"data_os between '{DataInicial.Value.ToShortDateString()}' and '{DataFinal.Value.ToShortDateString()}' and"
            End If
        End If

        SelectTransition.HideSync(PanelFilter)
        BuscarRegistros()
        FormataGridView_Gerenciador()
        TxtFilter.ReadOnly = False
    End Sub

    Private Sub LimparFiltroAvancado()
        For Each Btn As Guna2GradientButton In New List(Of Guna2GradientButton) From {BtnEmail, BtnCnpj_Cpf, BtnCidade, BtnUF, BtnEquipamento, BtnNSerie, BtnID, BtnBaixa, BtnMedia, BtnAlta, BtnUrgente, BtnCContrato, BtnSContrato, BtnGarantia, BtnMesAtual, BtnUltimoMes, BtnUltimos3Meses}
            If Btn.Checked Then
                Btn.Checked = False
            End If
        Next

        BtnNome.Checked = True
        GBoxDataInicial.Visible = False
        GBoxDataFinal.Visible = False
        BtnAplicar.Visible = False
        BtnSelectIntervalo.Visible = True
        BtnLimpar.Visible = False
        CBStatus.SelectedIndex = -1
        TxtFilter.Clear()
        TxtFilter.PlaceholderText = "Informe o Nome..."
        ColumnData = ""
        ColumnPrioridade = ""
        ColumnCondicao = ""
        ColumnStatus = ""
        ColumnOpcoes = "name"
        SelectTransition.HideSync(PanelFilter)
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimparFiltroAvancado()
        BuscarRegistros()
        FormataGridView_Gerenciador()
    End Sub

    Private Sub SelecionarLinha_Contar(e As DataGridViewCellEventArgs)
        Dim count As Integer

        If DgvGerenciador.Rows.Count() > 0 Then
            If DgvGerenciador.Columns(e.ColumnIndex).Index = 0 Then
                For i As Integer = 0 To DgvGerenciador.Rows.Count() - 1
                    If DgvGerenciador.Rows(i).Cells(0).Value Then
                        count += 1
                    End If
                Next

                Select Case count
                    Case 0
                        LblSelectRegister.Visible = False
                        PanelSelect.Visible = False
                        BtnInfo.Enabled = True

                    Case 1
                        LblSelectRegister.Text = $"{count} Registro selecionado"
                        LblSelectRegister.Visible = True

                        LblRegistrosSelect_Gerenciador.Text = $"Registros selecionados ({count})"
                        PanelSelect.BringToFront()
                        SelectTransition.ShowSync(PanelSelect)
                        BtnInfo.Enabled = True

                    Case Else
                        LblSelectRegister.Text = $"{count} Registros selecionados"
                        LblSelectRegister.Visible = True

                        LblRegistrosSelect_Gerenciador.Text = $"Registros selecionados ({count})"
                        PanelSelect.BringToFront()
                        SelectTransition.ShowSync(PanelSelect)
                        BtnInfo.Enabled = False

                End Select
            End If
        End If
    End Sub

    Private Sub SelecionarLinha_DgvArquivos(e As DataGridViewCellEventArgs)
        Dim count As Integer

        If DgvArquivos.Rows.Count() > 0 Then
            If DgvArquivos.Columns(e.ColumnIndex).Index = 0 Then
                For i As Integer = 0 To DgvArquivos.Rows.Count() - 1
                    If DgvArquivos.Rows(i).Cells(0).Value Then
                        count += 1
                    End If
                Next

                Select Case count
                    Case 0
                        PanelSelect_Anexo.Visible = False

                    Case 1
                        LblAquivos_Anexo.Text = $"Registros selecionados ({count})"
                        PanelSelect_Anexo.BringToFront()
                        SelectTransition.ShowSync(PanelSelect_Anexo)

                    Case Else
                        LblAquivos_Anexo.Text = $"Registros selecionados ({count})"
                        PanelSelect_Anexo.BringToFront()
                        SelectTransition.ShowSync(PanelSelect_Anexo)

                End Select
            End If
        End If
    End Sub

    Private Sub DgvGerenciador_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvGerenciador.CellValueChanged
        'MultSelectRow(sender)
        SelecionarLinha_Contar(e)
    End Sub

    Private Sub DgvGerenciador_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DgvGerenciador.CurrentCellDirtyStateChanged
        If DgvGerenciador.IsCurrentCellDirty Then
            DgvGerenciador.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles BtnInfo.Click
        Dim i As Integer
        While i < DgvGerenciador.Rows.Count
            Dim row As DataGridViewRow = DgvGerenciador.Rows(i)
            If Convert.ToBoolean(row.Cells(0).Value) Then

                LblUsuario_Ocorrencia.Text = $"<b>{row.Cells(4).Value}</b><br>
                                               {row.Cells(5).Value}<br>
                                               {row.Cells(6).Value}"

                LblNome.Text = $"{row.Cells(8).Value}"

                LblId_Interno.Text = $"{row.Cells(3).Value}"

                LblInformacoes.Text = $"<b>CNPJ/CPF</b>: {row.Cells(7).Value}<br>
                                        <b>E-mail</b>: {row.Cells(9).Value}<br>
                                        <b>Contato</b>: {row.Cells(10).Value}<br>
                                        <b>Telefone principal</b>: {row.Cells(11).Value}<br>
                                        <b>Telefone secundário</b>: {row.Cells(12).Value}<br>
                                        <b>Celular</b>: {row.Cells(13).Value}<br>
                                        <b>Endereço</b>: {row.Cells(15).Value}, {row.Cells(16).Value}, {row.Cells(17).Value}, {row.Cells(18).Value}, {row.Cells(14).Value}<br>
                                        <b>Prioridade</b>: {row.Cells(19).Value}<br>
                                        <b>Condição</b>: {row.Cells(23).Value}<br>
                                        <b>Equipamento</b>: {row.Cells(20).Value} - <b>Nº de Série</b>: {row.Cells(21).Value}<br><br>
                                        <b>Ocorrência</b>:<br> {row.Cells(22).Value}"

                LblUsuario_Resultado.Text = $"<b>{row.Cells(24).Value}</b><br>
                                              {row.Cells(25).Value}<br>
                                              {row.Cells(26).Value}"

                LblResultado.Text = $"<b>Contato</b>: {row.Cells(28).Value}<br>
                                      <b>Status</b>: {row.Cells(30).Value}<br>
                                      <b>Tempo de conexão</b>: {row.Cells(29).Value}<br><br>
                                      <b>Resultado</b>:<br> {row.Cells(27).Value}"

                TxtCPFouCNPJ_Ocorrencia.Text = row.Cells(7).Value
                TxtNome_Ocorrencia.Text = row.Cells(8).Value
                TxtEmail_Ocorrencia.Text = row.Cells(9).Value
                TxtContato_Ocorrencia.Text = row.Cells(10).Value
                TxtContatoPrincipal_Ocorrencia.Text = row.Cells(11).Value
                LblContatoSecundario_Ocorrencia.Text = row.Cells(12).Value
                TxtCelular_Ocorrencia.Text = row.Cells(13).Value
                TxtCEP_Ocorrencia.Text = row.Cells(14).Value
                TxtEndereco_Ocorrencia.Text = row.Cells(15).Value
                TxtComplemento_Ocorrencia.Text = row.Cells(16).Value
                TxtCidade_Ocorrencia.Text = row.Cells(17).Value
                TxtUF_Ocorrencia.Text = row.Cells(18).Value
                CbPrioridade_Ocorrencia.Text = row.Cells(19).Value
                CbCondicao_Ocorrencia.Text = row.Cells(23).Value
                TxtEquipamento_Ocorrencia.Text = row.Cells(20).Value
                TxtNSerie_Ocorrencia.Text = row.Cells(21).Value
                TxtOcorrencia.Text = row.Cells(22).Value

                CbStatus_Resultado.Text = row.Cells(30).Value
                TxtContato_Resultado.Text = row.Cells(28).Value
                CbTempo_Resultado.Text = row.Cells(29).Value
                TxtResultado.Text = row.Cells(27).Value

                PanelSelect.Visible = False

                If row.Cells(27).Value.ToString.Length > 0 Then
                    If row.Cells(28).Value.ToString.Length > 0 Then
                        If row.Cells(29).Value.ToString.Length > 0 Then
                            If row.Cells(30).Value.ToString.Length > 0 Then
                                BtnVerResultado.Visible = True
                            Else
                                BtnVerResultado.Visible = False
                            End If
                        End If
                    End If
                End If

                If row.Cells(30).Value = "Encerrado - Cliente sem Contrato" Then
                    LblFaturamento.Visible = True
                Else
                    LblFaturamento.Visible = False
                End If

                TlpOS.Size = New Size(757, 1026)
                TabControl_CadCons.SelectTab(2)
            End If
            i += 1
        End While
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        TabControl_CadCons.SelectTab(3)
    End Sub

    Private Sub BtnCad_Ocorrencia_Click(sender As Object, e As EventArgs) Handles BtnCad_Ocorrencia.Click
        TabControl_CadCons.SelectTab(4)
        Cad_Cons = 1
        EditarOC = True
    End Sub

    Private Sub BtnCad_Resultado_Click(sender As Object, e As EventArgs) Handles BtnCad_Resultado.Click
        TabControl_CadCons.SelectTab(5)
        Cad_Cons = 2
    End Sub

    Private Sub TxtNome_Ocorrencia_IconRightClick(sender As Object, e As EventArgs) Handles TxtNome_Ocorrencia.IconRightClick

    End Sub

    Private Sub TxtNome_Ocorrencia_LostFocus(sender As Object, e As EventArgs) Handles TxtNome_Ocorrencia.LostFocus
        If TxtNome_Ocorrencia.Text.Length > 0 Then
            ClCliente_Phonebook.name = TxtNome_Ocorrencia.Text
            ClCliente_Phonebook.BuscarClienteHelpdesk(TxtCPFouCNPJ_Ocorrencia, TxtEmail_Ocorrencia, TxtContatoPrincipal_Ocorrencia, TxtContatoSecundario_Ocorrencia, TxtCelular_Ocorrencia, TxtCEP_Ocorrencia, TxtEndereco_Ocorrencia, TxtComplemento_Ocorrencia, TxtCidade_Ocorrencia, TxtUF_Ocorrencia, CbCondicao_Ocorrencia, TxtEquipamento_Ocorrencia, TxtNSerie_Ocorrencia)
        End If
    End Sub

    Private Sub TxtCPFouCNPJ_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Ocorrencia.TextChanged
        If TxtCPFouCNPJ_Ocorrencia.Text.Length > 0 Then
            LblCPFouCNPJ_Ocorrencia.Visible = True
        Else
            LblCPFouCNPJ_Ocorrencia.Visible = False
            TxtCPFouCNPJ_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCPFouCNPJ_Ocorrencia_LostFocus(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Ocorrencia.LostFocus
        Select Case TxtCPFouCNPJ_Ocorrencia.Text.Length
            Case 0
                TxtCPFouCNPJ_Ocorrencia.IconRight = Nothing
            Case 11
                TxtCPFouCNPJ_Ocorrencia.Text = Convert.ToUInt64(TxtCPFouCNPJ_Ocorrencia.Text).ToString($"000\.000\.000\-00")
                TxtCPFouCNPJ_Ocorrencia.IconRight = Nothing
            Case 14
                TxtCPFouCNPJ_Ocorrencia.Text = Convert.ToUInt64(TxtCPFouCNPJ_Ocorrencia.Text).ToString($"00\.000\.000\/0000\-00")
                TxtCPFouCNPJ_Ocorrencia.IconRight = Nothing
            Case Else
                TxtCPFouCNPJ_Ocorrencia.IconRight = ImageList.Images(1)
        End Select
    End Sub

    Private Sub TxtCPFouCNPJ_Ocorrencia_Enter(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Ocorrencia.Enter
        TxtCPFouCNPJ_Ocorrencia.Text = TxtCPFouCNPJ_Ocorrencia.Text.Replace(".", "").Replace("-", "").Replace("/", "")
        TxtCPFouCNPJ_Ocorrencia.IconRight = Nothing
    End Sub

    Private Sub TxtCPFouCNPJ_Ocorrencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCPFouCNPJ_Ocorrencia.KeyPress, TxtContatoPrincipal_Ocorrencia.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtEmail_Ocorrencia_Enter(sender As Object, e As EventArgs) Handles TxtEmail_Ocorrencia.Enter
        TxtEmail_Ocorrencia.IconRight = Nothing
    End Sub

    Private Sub TxtEmail_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail_Ocorrencia.TextChanged
        If TxtEmail_Ocorrencia.Text.Length > 0 Then
            LblEmail_Ocorrencia.Visible = True
        Else
            LblEmail_Ocorrencia.Visible = False
            TxtEmail_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtContatoPrincipal_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Ocorrencia.TextChanged
        If TxtContatoPrincipal_Ocorrencia.Text.Length > 0 Then
            LblContatoPrincipal_Ocorrencia.Visible = True
        Else
            LblContatoPrincipal_Ocorrencia.Visible = False
            TxtContatoPrincipal_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtContatoPrincipal_Ocorrencia_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtContatoPrincipal_Ocorrencia_Enter(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Ocorrencia.Enter
        TxtContatoPrincipal_Ocorrencia.Text = TxtContatoPrincipal_Ocorrencia.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        TxtContatoPrincipal_Ocorrencia.IconRight = Nothing
    End Sub

    Private Sub TxtContatoSecundario_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Ocorrencia.TextChanged
        If TxtContatoSecundario_Ocorrencia.Text.Length > 0 Then
            LblContatoSecundario_Ocorrencia.Visible = True
        Else
            LblContatoSecundario_Ocorrencia.Visible = False
            TxtContatoSecundario_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtContatoSecundario_Ocorrencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContatoSecundario_Ocorrencia.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtContatoSecundario_Ocorrencia_Enter(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Ocorrencia.Enter
        TxtContatoSecundario_Ocorrencia.Text = TxtContatoSecundario_Ocorrencia.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        TxtContatoSecundario_Ocorrencia.IconRight = Nothing
    End Sub

    Private Sub TxtContatoSecundario_Ocorrencia_LostFocus(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Ocorrencia.LostFocus
        Select Case TxtContatoPrincipal_Ocorrencia.Text.Length
            Case 0
                TxtContatoSecundario_Ocorrencia.IconRight = Nothing
            Case 9, 13, 14
                TxtContatoSecundario_Ocorrencia.IconRight = Nothing
            Case Else
                TxtContatoSecundario_Ocorrencia.IconRight = ImageList.Images(1)
        End Select
    End Sub

    Private Sub TxtCelular_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtCelular_Ocorrencia.TextChanged
        If TxtCelular_Ocorrencia.Text.Length > 0 Then
            LblCelular_Ocorrencia.Visible = True
        Else
            LblCelular_Ocorrencia.Visible = False
            TxtCelular_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCelular_Ocorrencia_Validated(sender As Object, e As EventArgs) Handles TxtCelular_Ocorrencia.Validated
        Dim mask = TxtCelular_Ocorrencia.Text
        Select Case TxtCelular_Ocorrencia.Text.Length
            Case 0
                TxtCelular_Ocorrencia.IconRight = Nothing

            Case 9
                If Not TxtCelular_Ocorrencia.Text.StartsWith("0") Then
                    TxtCelular_Ocorrencia.Text = mask.Insert(5, "-")
                    TxtCelular_Ocorrencia.IconRight = Nothing
                Else
                    TxtCelular_Ocorrencia.IconRight = ImageList.Images(1)
                End If

            Case 11
                If Not TxtCelular_Ocorrencia.Text.StartsWith("0") Then
                    TxtCelular_Ocorrencia.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                    TxtCelular_Ocorrencia.IconRight = Nothing
                Else
                    TxtCelular_Ocorrencia.IconRight = ImageList.Images(1)
                End If
        End Select
    End Sub

    Private Sub TxtCelular_Ocorrencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCelular_Ocorrencia.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCelular_Ocorrencia_Enter(sender As Object, e As EventArgs) Handles TxtCelular_Ocorrencia.Enter
        TxtCelular_Ocorrencia.Text = TxtCelular_Ocorrencia.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        TxtCelular_Ocorrencia.IconRight = Nothing
    End Sub

    Private Sub TxtCelular_Ocorrencia_LostFocus(sender As Object, e As EventArgs) Handles TxtCelular_Ocorrencia.LostFocus
        Select Case TxtCelular_Ocorrencia.Text.Length
            Case 0
                TxtCelular_Ocorrencia.IconRight = Nothing
            Case 10, 15
                TxtCelular_Ocorrencia.IconRight = Nothing
            Case Else
                TxtCelular_Ocorrencia.IconRight = ImageList.Images(1)
        End Select
    End Sub

    Private Sub TxtNome_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtNome_Ocorrencia.TextChanged
        If TxtNome_Ocorrencia.Text.Length > 0 Then
            LblNome_Ocorrencia.Visible = True
        Else
            LblNome_Ocorrencia.Visible = False
            TxtNome_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtContato_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtContato_Ocorrencia.TextChanged
        If TxtContato_Ocorrencia.Text.Length > 0 Then
            LblContato_Ocorrencia.Visible = True
        Else
            LblContato_Ocorrencia.Visible = False
            TxtContato_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCEP_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtCEP_Ocorrencia.TextChanged
        ClValidaCep.MaskCep(sender)
        If TxtCEP_Ocorrencia.Text.Length > 0 Then
            LblCEP_Ocorrencia.Visible = True
        Else
            LblCEP_Ocorrencia.Visible = False
            TxtCEP_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCEP_Ocorrencia_Enter(sender As Object, e As EventArgs) Handles TxtCEP_Ocorrencia.Enter
        TxtCEP_Ocorrencia.IconRight = Nothing
    End Sub

    Private Sub TxtCEP_Ocorrencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCEP_Ocorrencia.KeyPress
        ClValidaCep.ApenasNumeros(e, sender)
    End Sub

    Private Function ValidaCEP(strCheck As String) As Boolean
        Return Regex.IsMatch(strCheck, "^\d{5}-\d{3}$")
    End Function

    Private Function ValidaEmail(strCheck As String) As Boolean
        Return Regex.IsMatch(strCheck, "^([0-9a-z]([-\.\w]*[0-9a-z])*@([0-9a-z][-\w]*[0-9a-z]\.)+[a-z]{2,9})$")
    End Function

    Private Sub TxtCEP_Ocorrencia_LostFocus(sender As Object, e As EventArgs) Handles TxtCEP_Ocorrencia.LostFocus
        If TxtCEP_Ocorrencia.Text.Length > 0 Then
            If ValidaCEP(TxtCEP_Ocorrencia.Text) = False Then
                TxtCEP_Ocorrencia.IconRight = ImageList.Images(1)
            End If
        Else
            TxtCEP_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtEmail_Ocorrencia_LostFocus(sender As Object, e As EventArgs) Handles TxtEmail_Ocorrencia.LostFocus
        If TxtEmail_Ocorrencia.Text.Length > 0 Then
            If ValidaEmail(TxtEmail_Ocorrencia.Text) = False Then
                TxtEmail_Ocorrencia.IconRight = ImageList.Images(1)
            End If
        Else
            TxtEmail_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtEndereco_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtEndereco_Ocorrencia.TextChanged
        If TxtEndereco_Ocorrencia.Text.Length > 0 Then
            LblEndereco_Ocorrencia.Visible = True
        Else
            LblEndereco_Ocorrencia.Visible = False
            TxtEndereco_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtComplemento_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtComplemento_Ocorrencia.TextChanged
        If TxtComplemento_Ocorrencia.Text.Length > 0 Then
            LblComplemento_Ocorrencia.Visible = True
        Else
            LblComplemento_Ocorrencia.Visible = False
            TxtComplemento_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCidade_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtCidade_Ocorrencia.TextChanged
        If TxtCidade_Ocorrencia.Text.Length > 0 Then
            LblCidade_Ocorrencia.Visible = True
        Else
            LblCidade_Ocorrencia.Visible = False
            TxtCidade_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtUF_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtUF_Ocorrencia.TextChanged
        If TxtUF_Ocorrencia.Text.Length > 0 Then
            LblUF_Ocorrencia.Visible = True
        Else
            LblUF_Ocorrencia.Visible = False
            TxtUF_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtEquipamento_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtEquipamento_Ocorrencia.TextChanged
        If TxtEquipamento_Ocorrencia.Text.Length > 0 Then
            LblEquipamento_Ocorrencia.Visible = True
        Else
            LblEquipamento_Ocorrencia.Visible = False
            TxtEquipamento_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtNSerie_Ocorrencia_TextChanged(sender As Object, e As EventArgs) Handles TxtNSerie_Ocorrencia.TextChanged
        If TxtNSerie_Ocorrencia.Text.Length > 0 Then
            LblNSerie_Ocorrencia.Visible = True
        Else
            LblNSerie_Ocorrencia.Visible = False
            TxtNSerie_Ocorrencia.IconRight = Nothing
        End If
    End Sub

    Private Sub BtnSendEmail_Ocorrencia_Click(sender As Object, e As EventArgs) Handles BtnSendEmail_Ocorrencia.Click
        If TxtSendEmail_Ocorrencia.Visible = True Then
            TxtSendEmail_Ocorrencia.Visible = False
            TxtSendEmail_Ocorrencia.Clear()
        Else
            TxtSendEmail_Ocorrencia.Visible = True
        End If
    End Sub

    Private Sub BtnSendEmail_Resultado_Click(sender As Object, e As EventArgs) Handles BtnSendEmail_Resultado.Click
        If TxtSendEmail_Resultado.Visible = True Then
            TxtSendEmail_Resultado.Visible = False
            TxtSendEmail_Resultado.Clear()
        Else
            TxtSendEmail_Resultado.Visible = True
        End If
    End Sub

    Private Sub TxtContato_Resultado_TextChanged(sender As Object, e As EventArgs) Handles TxtContato_Resultado.TextChanged
        If TxtContato_Resultado.Text.Length > 0 Then
            LblContato_Resultado.Visible = True
        Else
            LblContato_Resultado.Visible = False
        End If
    End Sub

    Private EditarOC As Boolean

    Private Sub BtnCancelar_Ocorrencia_Click(sender As Object, e As EventArgs) Handles BtnCancelar_Ocorrencia.Click
        If EditarOC = False Then
            FrmPrincipal.ActiveFormClose()
            FrmPrincipal.BtnAbrirOS_Helpdesk.Checked = False
        Else
            EditarOC = False
            TabControl_CadCons.SelectTab(2)
        End If
    End Sub

    Private Sub BtnCancelar_Edicao_Click(sender As Object, e As EventArgs) Handles BtnCancelar_Edicao.Click
        TabControl_CadCons.SelectTab(2)
    End Sub

    Private Sub BtnCancelar_Resultado_Click(sender As Object, e As EventArgs) Handles BtnCancelar_Resultado.Click
        TabControl_CadCons.SelectTab(2)
    End Sub

    Private Sub BtnSalvar_Resultado_Click(sender As Object, e As EventArgs) Handles BtnSalvar_Resultado.Click
        If CbStatus_Resultado.Text.Length > 0 Then
            If TxtContato_Resultado.Text.Length > 0 Then
                If CbTempo_Resultado.Text.Length > 0 Then
                    If TxtResultado.Text.Length > 0 Then

                        ProgressAguarde.Value = 0
                        TabControl_CadCons.SelectTab(7)
                        TimerCad.Start()

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnDeletar_Click(sender As Object, e As EventArgs) Handles BtnDeletar.Click
        ProgressAguarde.Value = 0
        TabControl_CadCons.SelectTab(7)
        TimerDel.Start()
    End Sub

    Private ReadOnly ClServerSFTP As New ServerSFTP

    Private Sub ExcluirRegistro()
        Dim i As Integer = 0
        While i < DgvGerenciador.Rows.Count
            Dim row As DataGridViewRow = DgvGerenciador.Rows(i)
            If Convert.ToBoolean(row.Cells(0).Value) Then
                Dim id As Integer = Convert.ToInt16(row.Cells(2).Value)
                Dim id_interno As String = Convert.ToString(row.Cells(3).Value)
                ClOS_Helpdesk.id = id
                ClOS_Helpdesk.Deleta()
                If ClOS_Helpdesk.Valida = True Then
                    ClOS_Helpdesk.Valida = False
                    ClServerSFTP.PathDelete_Helpdesk($"{My.Settings.SFTP_HelpdeskOSRemoto}{id_interno}/")
                    DgvGerenciador.Rows.Remove(row)
                    LblSelectRegister.Visible = False
                    PanelSelect.Visible = False
                End If
                i -= 1
            End If
            i += 1
        End While
    End Sub

    Private Sub TimerDel_Tick(sender As Object, e As EventArgs) Handles TimerDel.Tick
        ProgressAguarde.Increment(5)
        Select Case ProgressAguarde.Value
            Case 80
                ExcluirRegistro()

            Case 100
                ClCliente_Phonebook.valida = False
                TimerDel.Stop()
                TabControl_CadCons.SelectTab(0)
                BuscarRegistros()
                FormataGridView_Gerenciador()
                MessageBox.Show($"A OS foi deletada com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Select
    End Sub

    Private Sub BtnSelectApagar_Click(sender As Object, e As EventArgs) Handles BtnSelectApagar.Click
        ExcluirRegistro()
        BuscarRegistros()
        FormataGridView_Gerenciador()
    End Sub

    Private NewThread As Thread

    Private Sub BtnSendEmail_OS_Click(sender As Object, e As EventArgs) Handles BtnSendEmail_OS.Click
        If TxtSendEmail_OS.Text.Length > 0 Then
            ClEmail.nome_oc = DgvGerenciador.CurrentRow.Cells(4).Value
            ClEmail.email_oc = DgvGerenciador.CurrentRow.Cells(5).Value
            ClEmail.data_oc = DgvGerenciador.CurrentRow.Cells(6).Value

            ClEmail.id_interno = DgvGerenciador.CurrentRow.Cells(3).Value
            ClEmail.name = DgvGerenciador.CurrentRow.Cells(8).Value
            ClEmail.cpf_cnpj = DgvGerenciador.CurrentRow.Cells(7).Value
            ClEmail.email_cont = DgvGerenciador.CurrentRow.Cells(9).Value
            ClEmail.telefone_principal = DgvGerenciador.CurrentRow.Cells(11).Value
            ClEmail.telefone_secundario = DgvGerenciador.CurrentRow.Cells(12).Value
            ClEmail.celular = DgvGerenciador.CurrentRow.Cells(13).Value
            ClEmail.contato_oc = DgvGerenciador.CurrentRow.Cells(10).Value
            ClEmail.endereco = DgvGerenciador.CurrentRow.Cells(15).Value
            ClEmail.complemento = DgvGerenciador.CurrentRow.Cells(16).Value
            ClEmail.cidade = DgvGerenciador.CurrentRow.Cells(17).Value
            ClEmail.uf = DgvGerenciador.CurrentRow.Cells(18).Value
            ClEmail.cep = DgvGerenciador.CurrentRow.Cells(14).Value
            ClEmail.condicao = DgvGerenciador.CurrentRow.Cells(23).Value
            ClEmail.prioridade = DgvGerenciador.CurrentRow.Cells(19).Value
            ClEmail.equipamento = DgvGerenciador.CurrentRow.Cells(20).Value
            ClEmail.nserie = DgvGerenciador.CurrentRow.Cells(21).Value
            ClEmail.ocorrencia = DgvGerenciador.CurrentRow.Cells(22).Value

            If DgvGerenciador.CurrentRow.Cells(27).Value.ToString.Length > 0 Then
                ClEmail.info_res = $"<br><br><br><br><br><br><br>
                                     <b><font size ='4' color='MidnightBlue'>------------------------------ RESULTADO ------------------------------</font></b><br><br><br><br><br>
                                     <b><font color='Gray'>{DgvGerenciador.CurrentRow.Cells(24).Value}</b> < br >
                                     {DgvGerenciador.CurrentRow.Cells(25).Value} < br >
                                     {DgvGerenciador.CurrentRow.Cells(26).Value}</font><br><br><br><br>
                                     <b>Contato</b>: {DgvGerenciador.CurrentRow.Cells(28).Value}<br>
                                     <b>Status</b>: {DgvGerenciador.CurrentRow.Cells(30).Value}<br>
                                     <b>Tempo de conexão</b>: {DgvGerenciador.CurrentRow.Cells(29).Value}<br><br>
                                     <Resultado</b>:<br>
                                     {DgvGerenciador.CurrentRow.Cells(27).Value}"
            Else
                ClEmail.info_res = ""
            End If

            If DgvGerenciador.CurrentRow.Cells(30).Value = "Encerrado - Cliente sem Contrato" Then
                ClEmail.faturamento = $"<br><br><br>
                                                            <b><font size ='5' color='Red'>{LblFaturamento.Text}</font></b><br><br><br><br><br><br><br>"
            Else
                ClEmail.faturamento = $"<br><br><br><br><br><br><br>"
            End If


            Select Case CbPrioridade_Ocorrencia.Text
                Case "Baixa"
                    ClEmail.Color = "SodgerBlue"
                Case "Média"
                    ClEmail.Color = "OliveDrab"
                Case "Alta"
                    ClEmail.Color = "DarkOrange"
                Case "Urgente"
                    ClEmail.Color = "Red"
            End Select

            ClEmail.ToEmail = TxtSendEmail_OS.Text


            NewThread = New Thread(AddressOf ClEmail.InformacoesOS_Helpdesk) With {.IsBackground = True}
            NewThread.Start()
        End If
    End Sub

    Private Sub BtnAnexo_Click(sender As Object, e As EventArgs) Handles BtnAnexo.Click
        Result = False
        DgvArquivos.Rows.Clear()
        ClServerSFTP.FileList_Helpdesk(DgvArquivos, LblId_Interno.Text, "OCORRENCIA")
        TabControl_CadCons.SelectTab(6)
    End Sub

    Private Sub BtnArquivos_Resultado_Click(sender As Object, e As EventArgs) Handles BtnArquivos_Resultado.Click
        Result = True
        DgvArquivos.Rows.Clear()
        ClServerSFTP.FileList_Helpdesk(DgvArquivos, LblId_Interno.Text, "RESULTADO")
        TabControl_CadCons.SelectTab(6)
    End Sub

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        TabControl_CadCons.SelectTab(2)
    End Sub

    Private Result As Boolean

    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click
        If Result = True Then
            ClServerSFTP.CarregarArquivo_Helpdesk(DgvArquivos, Ofd, LblId_Interno.Text, "RESULTADO", TabControl_CadCons)
        Else
            ClServerSFTP.CarregarArquivo_Helpdesk(DgvArquivos, Ofd, LblId_Interno.Text, "OCORRENCIA", TabControl_CadCons)
        End If
    End Sub

    Private Sub BtnVerResultado_Click(sender As Object, e As EventArgs) Handles BtnVerResultado.Click
        If PanelResultado.Visible = False Then
            BtnVerResultado.Text = "Ocultar Resultado"
            TlpOS.Size = New Size(757, 1555)
            PanelResultado.Visible = True
        Else
            BtnVerResultado.Text = "Visualizar Resultado"
            PanelResultado.Visible = False
            TlpOS.Size = New Size(757, 1026)
            PanelPerfil.Refresh()
        End If
    End Sub

    Private Sub BtnVoltarLista_Click(sender As Object, e As EventArgs) Handles BtnVoltarLista.Click
        DgvGerenciador.CurrentRow.Cells(0).Value = False
        TabControl_CadCons.SelectTab(0)
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If Result = True Then
            ClServerSFTP.FileDelete_Helpdesk(DgvArquivos, PanelSelect_Anexo, $"{My.Settings.SFTP_HelpdeskOSRemoto}{LblId_Interno.Text}/RESULTADO/")
        Else
            ClServerSFTP.FileDelete_Helpdesk(DgvArquivos, PanelSelect_Anexo, $"{My.Settings.SFTP_HelpdeskOSRemoto}{LblId_Interno.Text}/OCORRENCIA/")
        End If
    End Sub

    Private Sub BtnDownload_Click(sender As Object, e As EventArgs) Handles BtnDownload.Click
        If Result = True Then
            ClServerSFTP.FileDownload_Helpdesk(DgvArquivos, Fbd, LblId_Interno.Text, "RESULTADO", ProgressAguarde, TabControl_CadCons)
        Else
            ClServerSFTP.FileDownload_Helpdesk(DgvArquivos, Fbd, LblId_Interno.Text, "OCORRENCIA", ProgressAguarde, TabControl_CadCons)
        End If
    End Sub

    Private Sub DgvArquivos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvArquivos.CellValueChanged
        'MultSelectRow(sender)
        SelecionarLinha_DgvArquivos(e)
    End Sub

    Private Sub DgvArquivos_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DgvArquivos.CurrentCellDirtyStateChanged
        If DgvArquivos.IsCurrentCellDirty Then
            DgvArquivos.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub BtnSelectFechar_Arquivos_Click(sender As Object, e As EventArgs) Handles BtnSelectFechar_Arquivos.Click
        SelectTransition.HideSync(PanelSelect_Anexo)
    End Sub

    Private Sub BtnSelectFechar_Click(sender As Object, e As EventArgs) Handles BtnSelectFechar.Click
        SelectTransition.HideSync(PanelSelect)
    End Sub

    Private Sub TxtNome_Ocorrencia_Enter(sender As Object, e As EventArgs) Handles TxtNome_Ocorrencia.Enter
        TxtNome_Ocorrencia.IconRight = Nothing
    End Sub

    Private Sub TxtContato_Ocorrencia_Enter(sender As Object, e As EventArgs) Handles TxtContato_Ocorrencia.Enter
        TxtContato_Ocorrencia.IconRight = Nothing
    End Sub

    Private Sub CbPrioridade_Ocorrencia_Enter(sender As Object, e As EventArgs) Handles CbPrioridade_Ocorrencia.Enter
        CbPrioridade_Ocorrencia.FillColor = Color.WhiteSmoke
    End Sub

    Private Sub CbCondicao_Ocorrencia_Enter(sender As Object, e As EventArgs) Handles CbCondicao_Ocorrencia.Enter
        CbCondicao_Ocorrencia.FillColor = Color.WhiteSmoke
    End Sub

    Private Sub TxtEquipamento_Ocorrencia_Enter(sender As Object, e As EventArgs) Handles TxtEquipamento_Ocorrencia.Enter
        TxtEquipamento_Ocorrencia.IconRight = Nothing
    End Sub

    Private Sub TxtOcorrencia_Enter(sender As Object, e As EventArgs) Handles TxtOcorrencia.Enter
        TxtOcorrencia.IconRight = Nothing
    End Sub

    Private Sub TxtContatoPrincipal_Ocorrencia_Validated(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Ocorrencia.Validated
        Dim mask = TxtContatoPrincipal_Ocorrencia.Text
        Select Case TxtContatoPrincipal_Ocorrencia.Text.Length
            Case 0
                TxtContatoPrincipal_Ocorrencia.IconRight = Nothing
            Case 8
                If Not TxtContatoPrincipal_Ocorrencia.Text.StartsWith("0") Then
                    TxtContatoPrincipal_Ocorrencia.Text = mask.Insert(4, "-")
                    TxtContatoPrincipal_Ocorrencia.IconRight = Nothing
                Else
                    TxtContatoPrincipal_Ocorrencia.IconRight = ImageList.Images(1)
                End If

            Case 9
                If Not TxtContatoPrincipal_Ocorrencia.Text.StartsWith("0") Then
                    TxtContatoPrincipal_Ocorrencia.Text = mask.Insert(5, "-")
                    TxtContatoPrincipal_Ocorrencia.IconRight = Nothing
                Else
                    TxtContatoPrincipal_Ocorrencia.IconRight = ImageList.Images(1)
                End If

            Case 10
                If Not TxtContatoPrincipal_Ocorrencia.Text.StartsWith("0") Then
                    TxtContatoPrincipal_Ocorrencia.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(9, "-")
                    TxtContatoPrincipal_Ocorrencia.IconRight = Nothing
                Else
                    TxtContatoPrincipal_Ocorrencia.IconRight = ImageList.Images(1)
                End If

            Case 11
                If TxtContatoPrincipal_Ocorrencia.Text.StartsWith("0800") Then
                    TxtContatoPrincipal_Ocorrencia.Text = mask.Insert(4, " ").Insert(8, " ")
                    TxtContatoPrincipal_Ocorrencia.IconRight = Nothing
                Else
                    If Not TxtContatoPrincipal_Ocorrencia.Text.StartsWith("0") Then
                        TxtContatoPrincipal_Ocorrencia.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                        TxtContatoPrincipal_Ocorrencia.IconRight = Nothing
                    Else
                        TxtContatoPrincipal_Ocorrencia.IconRight = ImageList.Images(1)
                    End If
                End If
            Case Else
                TxtContatoPrincipal_Ocorrencia.IconRight = ImageList.Images(1)
        End Select
    End Sub

    Private Sub FrmCadastros_Helpdesk_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        PanelFilter.Location = TxtFilter.Location + New Point(35, 71)
    End Sub

    Private Sub TxtContatoPrincipal_Ocorrencia_LostFocus(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Ocorrencia.LostFocus
        Select Case TxtContatoPrincipal_Ocorrencia.Text.Length
            Case 0
                TxtContatoPrincipal_Ocorrencia.IconRight = Nothing
            Case 9, 13, 14
                TxtContatoPrincipal_Ocorrencia.IconRight = Nothing
            Case Else
                TxtContatoPrincipal_Ocorrencia.IconRight = ImageList.Images(1)
        End Select
    End Sub

    Private Sub TxtContatoSecundario_Ocorrencia_Validated(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Ocorrencia.Validated
        Dim mask = TxtContatoSecundario_Ocorrencia.Text
        Select Case TxtContatoSecundario_Ocorrencia.Text.Length
            Case 0
                TxtContatoSecundario_Ocorrencia.IconRight = Nothing
            Case 8
                If Not TxtContatoSecundario_Ocorrencia.Text.StartsWith("0") Then
                    TxtContatoSecundario_Ocorrencia.Text = mask.Insert(4, "-")
                    TxtContatoSecundario_Ocorrencia.IconRight = Nothing
                Else
                    TxtContatoSecundario_Ocorrencia.IconRight = ImageList.Images(1)
                End If

            Case 9
                If Not TxtContatoSecundario_Ocorrencia.Text.StartsWith("0") Then
                    TxtContatoSecundario_Ocorrencia.Text = mask.Insert(5, "-")
                    TxtContatoSecundario_Ocorrencia.IconRight = Nothing
                Else
                    TxtContatoSecundario_Ocorrencia.IconRight = ImageList.Images(1)
                End If

            Case 10
                If Not TxtContatoSecundario_Ocorrencia.Text.StartsWith("0") Then
                    TxtContatoSecundario_Ocorrencia.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(9, "-")
                    TxtContatoSecundario_Ocorrencia.IconRight = Nothing
                Else
                    TxtContatoSecundario_Ocorrencia.IconRight = ImageList.Images(1)
                End If

            Case 11
                If TxtContatoSecundario_Ocorrencia.Text.StartsWith("0800") Then
                    TxtContatoSecundario_Ocorrencia.Text = mask.Insert(4, " ").Insert(8, " ")
                    TxtContatoSecundario_Ocorrencia.IconRight = Nothing
                Else
                    If Not TxtContatoSecundario_Ocorrencia.Text.StartsWith("0") Then
                        TxtContatoSecundario_Ocorrencia.Text = mask.Insert(0, "(").Insert(3, ") ").Insert(10, "-")
                        TxtContatoSecundario_Ocorrencia.IconRight = Nothing
                    Else
                        TxtContatoSecundario_Ocorrencia.IconRight = ImageList.Images(1)
                    End If

                End If
            Case Else
                TxtContatoSecundario_Ocorrencia.IconRight = ImageList.Images(1)
        End Select
    End Sub

    Private Sub CBStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBStatus.SelectedIndexChanged
        BtnLimpar.Visible = True
        BtnAplicar.Visible = True
    End Sub
End Class