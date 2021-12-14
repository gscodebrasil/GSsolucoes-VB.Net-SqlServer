Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms

Public Class FrmCadastros_Phonebook

#Region "Ref. Classes"
    Private ReadOnly ClServerSFTP As New ServerSFTP
    Private ReadOnly ClCliente_Phonebook As New Cliente_Phonebook
    Private ReadOnly ClColaborador_Phonebook As New Colaborador_Phonebook
    Private ReadOnly ClFornecedor_Phonebook As New Fornecedor_Phonebook
    Private ReadOnly ClValidaCep As New ValidaCep
#End Region

#Region "Ref. Local"
    Private PaginaAtual As Integer = 1
    Private PaginaTotal As Double
    Private ColumnOpcoes As String = "name"
    Private ColumnData As String = ""
    Private Perfil As String
    Private RegistroDe As Integer
    Private RegistroAte As Integer
    Private Senha = "#"
#End Region

#Region "Function/Sub"
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
            .Columns(5).HeaderText = "E-mail"
            .Columns(6).HeaderText = "Contato Principal"
            .Columns(14).HeaderText = "Condição Contratual"
            .Columns(18).HeaderText = "Cadastrado Em"
            .Columns(0).HeaderCell = New CheckHeaderCell

            .Columns(0).Visible = True
            .Columns(1).Visible = False
            .Columns(3).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False

            .Columns(0).ReadOnly = False
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True
            .Columns(6).ReadOnly = True
            .Columns(14).ReadOnly = True

            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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
            .Columns(5).HeaderText = "E-mail"
            .Columns(6).HeaderText = "Contato Principal"
            .Columns(15).HeaderText = "Cadastrado Em"
            .Columns(0).HeaderCell = New CheckHeaderCell

            .Columns(0).Visible = True
            .Columns(1).Visible = False
            .Columns(3).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False

            .Columns(0).ReadOnly = False
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True
            .Columns(6).ReadOnly = True

            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        End With
    End Sub

    Private Sub BuscarRegistros(Tabela As String)
        Dim NDecimal As Integer

        RegistroAte = CbRegistrosPorPagina.Text

        ClCliente_Phonebook.CountUsers($"Select COUNT(*) FROM {Tabela} WHERE {ColumnData} {ColumnOpcoes} Like '{TxtFilter.Text}%'")
        ClCliente_Phonebook.RegistroUserDesc(DgvRegistros, $"SELECT * FROM {Tabela} WHERE {ColumnData} {ColumnOpcoes} like '{TxtFilter.Text}%' ORDER BY id DESC OFFSET {RegistroDe} ROWS FETCH NEXT {RegistroAte} ROWS ONLY")

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

        RegistroAte = CbRegistrosPorPagina.Text

        If PaginaAtual = PaginaTotal Then
            Exit Sub
        End If

        RegistroDe = CInt(CbRegistrosPorPagina.Text) * PaginaAtual

        ClCliente_Phonebook.CountUsers($"Select COUNT(*) FROM {Tabela} WHERE {ColumnData} {ColumnOpcoes} Like '{TxtFilter.Text}%'")
        ClCliente_Phonebook.RegistroUserDesc(DgvRegistros, $"SELECT * FROM {Tabela} WHERE {ColumnData} {ColumnOpcoes} Like '{TxtFilter.Text}%' ORDER BY id DESC OFFSET {RegistroDe} ROWS FETCH NEXT {RegistroAte} ROWS ONLY")

        PaginaAtual += 1
        PaginaTotal = ClCliente_Phonebook.TotalUser / CInt(CbRegistrosPorPagina.Text)
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

        RegistroAte = CbRegistrosPorPagina.Text

        If PaginaAtual = 1 Then
            Exit Sub
        End If

        RegistroDe -= CInt(CbRegistrosPorPagina.Text)

        ClCliente_Phonebook.CountUsers($"Select COUNT(*) FROM {Tabela} WHERE {ColumnData} {ColumnOpcoes} Like '{TxtFilter.Text}%'")
        ClCliente_Phonebook.RegistroUserDesc(DgvRegistros, $"SELECT * FROM {Tabela} WHERE {ColumnData} {ColumnOpcoes} Like '{TxtFilter.Text}%' ORDER BY id DESC OFFSET {RegistroDe} ROWS FETCH NEXT {RegistroAte} ROWS ONLY")

        PaginaAtual -= 1
        PaginaTotal = ClCliente_Phonebook.TotalUser / CInt(CbRegistrosPorPagina.Text)
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
                        BtnAbrirOS.Enabled = True

                    Case 1
                        LblSelectRegister.Text = $"{count} Registro selecionado"
                        LblSelectRegister.Visible = True

                        HtmlLblSelect.Text = $"Registros selecionados ({count})"
                        PanelSelect.BringToFront()
                        SelectTransition.ShowSync(PanelSelect)
                        BtnInfo.Enabled = True
                        BtnAbrirOS.Enabled = True

                    Case Else
                        LblSelectRegister.Text = $"{count} Registros selecionados"
                        LblSelectRegister.Visible = True

                        HtmlLblSelect.Text = $"Registros selecionados ({count})"
                        PanelSelect.BringToFront()
                        SelectTransition.ShowSync(PanelSelect)
                        BtnInfo.Enabled = False
                        BtnAbrirOS.Enabled = False

                End Select
            End If
        End If
    End Sub

    Private Sub SelecionarLinhaDgvArquivos_Contar(e As DataGridViewCellEventArgs)
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

                    Case Else
                        LblAquivos_Anexo.Text = $"Arquivos selecionados ({count})"
                        PanelSelect_Anexo.BringToFront()
                        SelectTransition.ShowSync(PanelSelect_Anexo)

                End Select
            End If
        End If
    End Sub

    Private Sub ExcluirRegistro()
        Dim i As Integer = 0
        While i < DgvRegistros.Rows.Count
            Dim row As DataGridViewRow = DgvRegistros.Rows(i)
            If Convert.ToBoolean(row.Cells(0).Value) Then
                Dim id As Integer = Convert.ToInt16(row.Cells(1).Value)
                Dim id_interno As String = Convert.ToString(row.Cells(2).Value)
                Select Case Perfil
                    Case "Cliente"
                        ClCliente_Phonebook.id = id
                        ClCliente_Phonebook.Deleta()
                        ClServerSFTP.PathDelete_Phonebook($"{My.Settings.SFTP_PhonebookClientes}{id_interno}/")
                    Case "Colaborador"
                        ClColaborador_Phonebook.id = id
                        ClColaborador_Phonebook.Deleta()
                        ClServerSFTP.PathDelete_Phonebook($"{My.Settings.SFTP_PhonebookColaborador}{id_interno}/")
                    Case "Fornecedor"
                        ClFornecedor_Phonebook.id = id
                        ClFornecedor_Phonebook.Deleta()
                        ClServerSFTP.PathDelete_Phonebook($"{My.Settings.SFTP_PhonebookFornecedor}{id_interno}/")
                End Select
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
                    ColumnData = "date_cad between DATEADD( DAY, 1, EOMONTH(GETDATE(), -1)) And EOMONTH( GETDATE(), 0) And"
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True
                    GBoxDataInicial.Visible = False
                    GBoxDataFinal.Visible = False
                    BtnSelectIntervalo.Visible = True

                Case "Ultimo Mês"
                    ColumnData = "date_cad between DATEADD( DAY, 1, EOMONTH(GETDATE(), -2)) And EOMONTH( GETDATE(), -1) And"
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True
                    GBoxDataInicial.Visible = False
                    GBoxDataFinal.Visible = False
                    BtnSelectIntervalo.Visible = True

                Case "Ultimos 3 Meses"
                    ColumnData = "date_cad between DATEADD( DAY, 1, EOMONTH(GETDATE(), -4)) And EOMONTH( GETDATE(), -1) And"
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

    Private Sub Limpar(TxtCPF_CNPJ As Guna2TextBox, TxtNome As Guna2TextBox, TxtEmail As Guna2TextBox, TxtContatoPrincipal As Guna2TextBox, TxtContatoSecundario As Guna2TextBox, TxtCelular As Guna2TextBox, TxtCep As Guna2TextBox, TxtEndereco As Guna2TextBox, TxtComplemento As Guna2TextBox, TxtCidade As Guna2TextBox, TxtUF As Guna2TextBox, TxtInfoComplementar As Guna2TextBox, Pnc As Guna2Panel, Btn As Guna2GradientButton)
        For Each Txt As Guna2TextBox In New List(Of Guna2TextBox) From {TxtCPF_CNPJ, TxtNome, TxtEmail, TxtContatoPrincipal, TxtContatoSecundario, TxtCelular, TxtCep, TxtEndereco, TxtComplemento, TxtCidade, TxtUF, TxtInfoComplementar}
            Txt.IconRight = Nothing
            Txt.Clear()
        Next
        Pnc.Visible = False
        Btn.Text = $"Adicionar informação complementar"
    End Sub

    Private Sub ToolTipLoad()
        Dim Ttip As New ToolTip With {
            .AutoPopDelay = 3500,
            .ShowAlways = True
        }
        Ttip.SetToolTip(BtnDeletar, "Excluir o registro")
        Ttip.SetToolTip(BtnEditar, "Editar")
        Ttip.Active = True
    End Sub

    Private Sub Upload()
        Select Case Perfil

            Case "Cliente"
                ClServerSFTP.CarregarArquivoCliente_Phonebook(DgvArquivos, Ofd, LblId_Interno.Text, TabControl_CadCons)

            Case "Colaborador"
                ClServerSFTP.CarregarArquivoColaborador_Phonebook(DgvArquivos, Ofd, LblId_Interno.Text, TabControl_CadCons)

            Case "Fornecedor"
                ClServerSFTP.CarregarArquivoFornecedor_Phonebook(DgvArquivos, Ofd, LblId_Interno.Text, TabControl_CadCons)

        End Select
    End Sub

    Private Sub Anexos()
        Select Case Perfil

            Case "Cliente"
                ClServerSFTP.FileListCliente_Phonebook(DgvArquivos, LblId_Interno.Text)

            Case "Colaborador"
                ClServerSFTP.FileListColaborador_Phonebook(DgvArquivos, LblId_Interno.Text)

            Case "Fornecedor"
                ClServerSFTP.FileListFornecedor_Phonebook(DgvArquivos, LblId_Interno.Text)

        End Select
    End Sub

    Private Sub Download()
        Select Case Perfil

            Case "Cliente"
                ClServerSFTP.FileDownload_Phonebook_Cliente(DgvArquivos, Fbd, LblId_Interno.Text, ProgressAguarde, TabControl_CadCons)

            Case "Colaborador"
                ClServerSFTP.FileDownload_Phonebook_Colaborador(DgvArquivos, Fbd, LblId_Interno.Text, ProgressAguarde, TabControl_CadCons)

            Case "Fornecedor"
                ClServerSFTP.FileDownload_Phonebook_Fornecedor(DgvArquivos, Fbd, LblId_Interno.Text, ProgressAguarde, TabControl_CadCons)

        End Select
    End Sub

    Private Sub Excluir()
        Select Case Perfil

            Case "Cliente"
                ClServerSFTP.FileDelete_Phonebook(DgvArquivos, PanelSelect_Anexo, $"{My.Settings.SFTP_PhonebookClientes}{LblId_Interno.Text}/")

            Case "Colaborador"
                ClServerSFTP.FileDelete_Phonebook(DgvArquivos, PanelSelect_Anexo, $"{My.Settings.SFTP_PhonebookColaborador}{LblId_Interno.Text}/")

            Case "Fornecedor"
                ClServerSFTP.FileDelete_Phonebook(DgvArquivos, PanelSelect_Anexo, $"{My.Settings.SFTP_PhonebookFornecedor}{LblId_Interno.Text}/")

        End Select
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

    Private Function TxtEmpty(Valida As Boolean, TxtCPF_CNPJ As Guna2TextBox, TxtNome As Guna2TextBox, TxtEmail As Guna2TextBox, TxtContatoPrincipal As Guna2TextBox)
        For Each Txt As Guna2TextBox In New List(Of Guna2TextBox) From {TxtCPF_CNPJ, TxtNome, TxtEmail, TxtContatoPrincipal}
            If Txt.Text.Length <= 0 Then
                Txt.IconRight = ImageList.Images(1)
                Valida = True
            End If
        Next
        Return Valida
    End Function

    Private Function ValidaEmail(strCheck As String) As Boolean
        Return Regex.IsMatch(strCheck, "^([0-9a-z]([-\.\w]*[0-9a-z])*@([0-9a-z][-\w]*[0-9a-z]\.)+[a-z]{2,9})$")
    End Function

    Private Function ValidaCEP(strCheck As String) As Boolean
        Return Regex.IsMatch(strCheck, "^\d{5}-\d{3}$")
    End Function
#End Region

#Region "Inicio Cadastro"
    Private Sub BtnCad_Cliente_Click(sender As Object, e As EventArgs) Handles BtnCad_Cliente.Click
        TabControl_CadCons.SelectTab(4)
    End Sub

    Private Sub BtnCad_Colaborador_Click(sender As Object, e As EventArgs) Handles BtnCad_Colaborador.Click
        TabControl_CadCons.SelectTab(5)
    End Sub

    Private Sub BtnCad_Fornecedor_Click(sender As Object, e As EventArgs) Handles BtnCad_Fornecedor.Click
        TabControl_CadCons.SelectTab(6)
    End Sub
#End Region

#Region "Inicio Consulta"
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
#End Region

#Region "Lista"
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

    Private Sub TxtFilter_TextChanged(sender As Object, e As EventArgs) Handles TxtFilter.TextChanged
        If DgvRegistros.DataSource IsNot Nothing Then
            VerificaTabela()
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

    Private Sub VoltarMenu_Click(sender As Object, e As EventArgs) Handles VoltarMenu.Click
        DgvArquivos.Rows.Clear()
        PanelSelect.Visible = False
        TabControl_CadCons.SelectTab(1)
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

    Private Sub BtnInfoUsuario_Click(sender As Object, e As EventArgs) Handles BtnInfo.Click
        Dim i As Integer = 0

        Select Case Perfil

            Case "Cliente"
                While i < DgvRegistros.Rows.Count
                    Dim row As DataGridViewRow = DgvRegistros.Rows(i)
                    If Convert.ToBoolean(row.Cells(0).Value) Then

                        LblNome.Text = $"{row.Cells(4).Value}"
                        LblId_Interno.Text = $"{row.Cells(2).Value}"
                        LblInformacoes.Text = $"<b>CNPJ/CPF</b>: {row.Cells(3).Value}<br>
                                                <b>E-mail</b>: {row.Cells(5).Value}<br>
                                                <b>Contato principal</b>: {row.Cells(6).Value}<br>
                                                <b>Whatsapp</b>: {row.Cells(7).Value}<br>
                                                <b>Endereço</b>: {row.Cells(10).Value}, {row.Cells(11).Value}, {row.Cells(12).Value}, {row.Cells(13).Value}, {row.Cells(9).Value}<br>
                                                <b>Condição</b>: {row.Cells(14).Value}<br>
                                                <b>Equipamento</b>: {row.Cells(15).Value} - <b>Nº de Série</b>: {row.Cells(16).Value}<br><br>
                                                <b>Informações complementares</b>:<br> {row.Cells(17).Value}"


                        TxtCPFouCNPJ_Cliente.Text = row.Cells(3).Value
                        TxtNome_Cliente.Text = row.Cells(4).Value
                        TxtEmail_Cliente.Text = row.Cells(5).Value
                        TxtContatoPrincipal_Cliente.Text = row.Cells(6).Value
                        LblContatoSecundario_Cliente.Text = row.Cells(7).Value
                        TxtCelular_Cliente.Text = row.Cells(8).Value
                        TxtCEP_Cliente.Text = row.Cells(9).Value
                        TxtEndereco_Cliente.Text = row.Cells(10).Value
                        TxtComplemento_Cliente.Text = row.Cells(11).Value
                        TxtCidade_Cliente.Text = row.Cells(12).Value
                        TxtUF_Cliente.Text = row.Cells(13).Value
                        CbCondicao_Cliente.Text = row.Cells(14).Value
                        TxtEquipamento_Cliente.Text = row.Cells(15).Value
                        TxtNSerie_Cliente.Text = row.Cells(16).Value
                        TxtInfoComplementar_Cliente.Text = row.Cells(17).Value

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
                        LblInformacoes.Text = $"<b>CNPJ/CPF</b>: {row.Cells(3).Value}<br>
                                                <b>E-mail</b>: {row.Cells(5).Value}<br>
                                                <b>Contato principal</b>: {row.Cells(6).Value}<br>
                                                <b>Whatsapp</b>: {row.Cells(8).Value}<br>
                                                <b>Endereço</b>: {row.Cells(10).Value}, {row.Cells(11).Value}, {row.Cells(12).Value}, {row.Cells(13).Value}, {row.Cells(9).Value}<br><br>
                                                <b>Informações complementares</b>:<br> {row.Cells(14).Value}"

                        TxtCPFouCNPJ_Colaborador.Text = row.Cells(3).Value
                        TxtNome_Colaborador.Text = row.Cells(4).Value
                        TxtEmail_Colaborador.Text = row.Cells(5).Value
                        TxtContatoPrincipal_Colaborador.Text = row.Cells(6).Value
                        LblContatoSecundario_Colaborador.Text = row.Cells(7).Value
                        TxtCelular_Colaborador.Text = row.Cells(8).Value
                        TxtCEP_Colaborador.Text = row.Cells(9).Value
                        TxtEndereco_Colaborador.Text = row.Cells(10).Value
                        TxtComplemento_Colaborador.Text = row.Cells(11).Value
                        TxtCidade_Colaborador.Text = row.Cells(12).Value
                        TxtUF_Colaborador.Text = row.Cells(13).Value
                        TxtInfoComplementar_Colaborador.Text = row.Cells(14).Value

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
                        LblInformacoes.Text = $"<b>CNPJ/CPF</b>: {row.Cells(3).Value}<br>
                                                <b>E-mail</b>: {row.Cells(5).Value}<br>
                                                <b>Contato principal</b>: {row.Cells(6).Value}<br>
                                                <b>Whatsapp</b>: {row.Cells(8).Value}<br>
                                                <b>Endereço</b>: {row.Cells(10).Value}, {row.Cells(11).Value}, {row.Cells(12).Value}, {row.Cells(13).Value}, {row.Cells(9).Value}<br><br>
                                                <b>Informações complementares</b>:<br> {row.Cells(14).Value}"

                        TxtCPFouCNPJ_Fornecedor.Text = row.Cells(2).Value
                        TxtNome_Fornecedor.Text = row.Cells(3).Value
                        TxtEmail_Fornecedor.Text = row.Cells(5).Value
                        TxtContatoPrincipal_Fornecedor.Text = row.Cells(6).Value
                        LblContatoSecundario_Fornecedor.Text = row.Cells(7).Value
                        TxtCelular_Fornecedor.Text = row.Cells(8).Value
                        TxtCEP_Fornecedor.Text = row.Cells(9).Value
                        TxtEndereco_Fornecedor.Text = row.Cells(10).Value
                        TxtComplemento_Fornecedor.Text = row.Cells(11).Value
                        TxtCidade_Fornecedor.Text = row.Cells(12).Value
                        TxtUF_Fornecedor.Text = row.Cells(13).Value
                        TxtInfoComplementar_Fornecedor.Text = row.Cells(14).Value

                        PanelSelect.Visible = False
                        TabControl_CadCons.SelectTab(3)
                    End If
                    i += 1
                End While

        End Select
    End Sub

    Private Sub BtnAbrirOS_Click(sender As Object, e As EventArgs) Handles BtnAbrirOS.Click

    End Sub

    Private Sub BtnSelectApagar_Click(sender As Object, e As EventArgs) Handles BtnSelectApagar.Click
        ExcluirRegistro()
        VerificaTabela()
    End Sub
#End Region

#Region "Perfil"
    Private Sub BtnAnexo_Click(sender As Object, e As EventArgs) Handles BtnAnexo.Click
        Anexos()
        TabControl_CadCons.SelectTab(7)
    End Sub

    Private Sub BtnVoltarLista_Click(sender As Object, e As EventArgs) Handles BtnVoltarLista.Click
        TabControl_CadCons.SelectTab(2)
        PanelSelect.Visible = True
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Select Case Perfil

            Case "Cliente"
                TabControl_CadCons.SelectTab(4)

            Case "Colaborador"
                TabControl_CadCons.SelectTab(5)

            Case "Fornecedor"
                TabControl_CadCons.SelectTab(6)

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
#End Region

#Region "Cliente"
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar_Cliente.Click
        Dim Valida As Boolean
        TxtEmpty(Valida, TxtCPFouCNPJ_Cliente, TxtNome_Cliente, TxtEmail_Cliente, TxtContatoPrincipal_Cliente)
        If CbCondicao_Cliente.Text.Length <= 0 Then
            CbCondicao_Cliente.FillColor = Color.FromArgb(255, 198, 198)
            Valida = True
        End If
        If TxtEquipamento_Cliente.Text.Length <= 0 Then
            TxtEquipamento_Cliente.IconRight = ImageList.Images(1)
            Valida = True
        End If

        If Valida = False Then
            If ValidaEmail(TxtEmail_Cliente.Text) Then
                If TxtCEP_Cliente.Text.Length = 0 OrElse ValidaCEP(TxtCEP_Cliente.Text) Then
                    ProgressAguarde.Value = 0
                    TabControl_CadCons.SelectTab(8)
                    TimerCad_Cliente.Start()
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Cliente_Click(sender As Object, e As EventArgs) Handles BtnCancelar_Cliente.Click
        If FrmPrincipal.Cad_Cons = 2 Then
            TabControl_CadCons.SelectTab(0)
        Else
            TabControl_CadCons.SelectTab(3)
        End If

        Limpar(TxtNome_Cliente, TxtCPFouCNPJ_Cliente, TxtEmail_Cliente, TxtContatoPrincipal_Cliente, TxtContatoSecundario_Cliente, TxtCelular_Cliente, TxtCEP_Cliente, TxtEndereco_Cliente, TxtComplemento_Cliente, TxtCidade_Cliente, TxtUF_Cliente, TxtInfoComplementar_Cliente, PanelInfoComplementar_Cliente, BtnInfoComplementar_Cliente)
        TxtEquipamento_Cliente.Clear()
        TxtEquipamento_Cliente.IconRight = Nothing
        TxtNSerie_Cliente.Clear()
        CbCondicao_Cliente.SelectedIndex = -1
        CbCondicao_Cliente.FillColor = Color.WhiteSmoke
    End Sub

    Private Sub BtnInfoComplementar_Cliente_Click(sender As Object, e As EventArgs) Handles BtnInfoComplementar_Cliente.Click
        If PanelInfoComplementar_Cliente.Visible = False Then
            PanelInfoComplementar_Cliente.Visible = True
            BtnInfoComplementar_Cliente.Text = $"Ocultar informação complementar"
        Else
            PanelInfoComplementar_Cliente.Visible = False
            BtnInfoComplementar_Cliente.Text = $"Adicionar informação complementar"
        End If
    End Sub

    Private Sub TxtCPFouCNPJ_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Cliente.TextChanged
        If Me.TxtCPFouCNPJ_Cliente.Text.Length > 0 Then
            LblCPFouCNPJ_Cliente.Visible = True
        Else
            LblCPFouCNPJ_Cliente.Visible = False
            TxtCPFouCNPJ_Cliente.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtNome_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtNome_Cliente.TextChanged
        If Me.TxtNome_Cliente.Text.Length > 0 Then
            LblNome_Cliente.Visible = True
        Else
            LblNome_Cliente.Visible = False
        End If
    End Sub

    Private Sub TxtCPFouCNPJ_Cliente_LostFocus(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Cliente.LostFocus
        Select Case Me.TxtCPFouCNPJ_Cliente.Text.Length
            Case 0
                Me.TxtCPFouCNPJ_Cliente.IconRight = Nothing
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
        Select Case Me.TxtCelular_Cliente.Text.Length
            Case 0
                Me.TxtCelular_Cliente.IconRight = Nothing
            Case 10, 15
                Me.TxtCelular_Cliente.IconRight = Nothing
            Case Else
                Me.TxtCelular_Cliente.IconRight = ImageList.Images(1)
        End Select
    End Sub

    Private Sub TxtCelular_Cliente_Enter(sender As Object, e As EventArgs) Handles TxtCelular_Cliente.Enter
        Me.TxtCelular_Cliente.Text = Me.TxtCelular_Cliente.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        Me.TxtCelular_Cliente.IconRight = Nothing
    End Sub

    Private Sub TxtContatoPrincipal_Cliente_LostFocus(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Cliente.LostFocus
        Dim mask = Me.TxtContatoPrincipal_Cliente.Text
        Select Case Me.TxtContatoPrincipal_Cliente.Text.Length
            Case 0
                Me.TxtContatoPrincipal_Cliente.IconRight = Nothing
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
            Case Else
                Me.TxtContatoPrincipal_Cliente.IconRight = ImageList.Images(1)
        End Select
    End Sub

    Private Sub TxtContatoPrincipal_Cliente_Enter(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Cliente.Enter
        Me.TxtContatoPrincipal_Cliente.Text = Me.TxtContatoPrincipal_Cliente.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        Me.TxtContatoPrincipal_Cliente.IconRight = Nothing
    End Sub

    Private Sub TxtCEP_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCEP_Cliente.KeyPress
        ClValidaCep.ApenasNumeros(e, sender)
    End Sub

    Private Sub TxtContatoSecundario_Cliente_LostFocus(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Cliente.LostFocus
        Dim mask = Me.TxtContatoSecundario_Cliente.Text
        Select Case Me.TxtContatoSecundario_Cliente.Text.Length
            Case 0
                Me.TxtContatoSecundario_Cliente.IconRight = Nothing
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
            Case Else
                Me.TxtContatoSecundario_Cliente.IconRight = ImageList.Images(1)
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
                If Not Me.TxtCelular_Cliente.Text.StartsWith("0") Then
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

    Private Sub TxtContatoPrincipal_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Cliente.TextChanged
        If Me.TxtContatoPrincipal_Cliente.Text.Length > 0 Then
            LblContatoPrincipal_Cliente.Visible = True
        Else
            LblContatoPrincipal_Cliente.Visible = False
            TxtContatoPrincipal_Cliente.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtContatoSecundario_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Cliente.TextChanged
        If Me.TxtContatoSecundario_Cliente.Text.Length > 0 Then
            LblContatoSecundario_Cliente.Visible = True
        Else
            LblContatoSecundario_Cliente.Visible = False
            TxtContatoSecundario_Cliente.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCelular_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtCelular_Cliente.TextChanged
        If Me.TxtCelular_Cliente.Text.Length > 0 Then
            LblCelular_Cliente.Visible = True
        Else
            LblCelular_Cliente.Visible = False
            TxtCelular_Cliente.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCEP_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtCEP_Cliente.TextChanged
        ClValidaCep.MaskCep(sender)
        If TxtCEP_Cliente.Text.Length > 0 Then
            LblCEP_Cliente.Visible = True
        Else
            LblCEP_Cliente.Visible = False
            TxtCEP_Cliente.IconRight = Nothing
        End If
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

    Private Sub TxtEmail_Cliente_LostFocus(sender As Object, e As EventArgs) Handles TxtEmail_Cliente.LostFocus
        If TxtEmail_Cliente.Text.Length > 0 Then
            If ValidaEmail(TxtEmail_Cliente.Text) = False Then
                TxtEmail_Cliente.IconRight = ImageList.Images(1)
            End If
        Else
            TxtEmail_Cliente.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtEmail_Cliente_Enter(sender As Object, e As EventArgs) Handles TxtEmail_Cliente.Enter
        TxtEmail_Cliente.IconRight = Nothing
    End Sub

    Private Sub TxtUF_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUF_Cliente.KeyPress
        If (Char.IsNumber(e.KeyChar)) OrElse (Char.IsSymbol(e.KeyChar)) OrElse (Char.IsPunctuation(e.KeyChar)) OrElse (Char.IsSeparator(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCEP_Cliente_LostFocus(sender As Object, e As EventArgs) Handles TxtCEP_Cliente.LostFocus
        If TxtCEP_Cliente.Text.Length > 0 Then
            If ValidaCEP(TxtCEP_Cliente.Text) = False Then
                TxtCEP_Cliente.IconRight = ImageList.Images(1)
            End If
        Else
            TxtCEP_Cliente.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCEP_Cliente_Enter(sender As Object, e As EventArgs) Handles TxtCEP_Cliente.Enter
        TxtCEP_Cliente.IconRight = Nothing
    End Sub

    Private Sub TxtEmail_Cliente_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail_Cliente.TextChanged
        If TxtEmail_Cliente.Text.Length > 0 Then
            LblEmail_Cliente.Visible = True
        Else
            LblEmail_Cliente.Visible = False
            TxtEmail_Cliente.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtNome_Cliente_Enter(sender As Object, e As EventArgs) Handles TxtNome_Cliente.Enter
        TxtNome_Cliente.IconRight = Nothing
    End Sub

    Private Sub TimerCad_Cliente_Tick(sender As Object, e As EventArgs) Handles TimerCad_Cliente.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 80
                If FrmPrincipal.Cad_Cons = 2 Then
                    CodigoInterno()
                    ClCliente_Phonebook.id_interno = Senha
                    ClCliente_Phonebook.ValidaCodigoInterno()

                    If ClCliente_Phonebook.valida = True Then
                        ClCliente_Phonebook.valida = False

                        CodigoInterno()
                        ClCliente_Phonebook.id_interno = Senha
                        ClCliente_Phonebook.ValidaCodigoInterno()
                        Return
                    Else
                        ClCliente_Phonebook.name = TxtNome_Cliente.Text
                        ClCliente_Phonebook.BuscarCliente()

                        If ClCliente_Phonebook.valida = False Then
                            ClCliente_Phonebook.id_interno = Senha
                            ClCliente_Phonebook.cpf_cnpj = TxtCPFouCNPJ_Cliente.Text
                            ClCliente_Phonebook.name = TxtNome_Cliente.Text
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
                            ClCliente_Phonebook.valida = False
                            TimerCad_Cliente.Stop()
                            TabControl_CadCons.SelectTab(4)
                            TxtNome_Cliente.IconRight = ImageList.Images(1)
                            MessageBox.Show($"O cliente já encontra-se na base de dados!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Else
                    ClCliente_Phonebook.cpf_cnpj = TxtCPFouCNPJ_Cliente.Text
                    ClCliente_Phonebook.name = TxtNome_Cliente.Text
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

            Case 100
                If FrmPrincipal.Cad_Cons = 2 Then
                    TimerCad_Cliente.Stop()
                    Limpar(TxtNome_Cliente, TxtCPFouCNPJ_Cliente, TxtEmail_Cliente, TxtContatoPrincipal_Cliente, TxtContatoSecundario_Cliente, TxtCelular_Cliente, TxtCEP_Cliente, TxtEndereco_Cliente, TxtComplemento_Cliente, TxtCidade_Cliente, TxtUF_Cliente, TxtInfoComplementar_Cliente, PanelInfoComplementar_Cliente, BtnInfoComplementar_Cliente)
                    TxtEquipamento_Cliente.Clear()
                    TxtEquipamento_Cliente.IconRight = Nothing
                    TxtNSerie_Cliente.Clear()
                    CbCondicao_Cliente.SelectedIndex = -1
                    CbCondicao_Cliente.FillColor = Color.WhiteSmoke
                    TabControl_CadCons.SelectTab(0)
                    MessageBox.Show($"Cliente cadastrado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    TimerCad_Cliente.Stop()
                    Limpar(TxtNome_Cliente, TxtCPFouCNPJ_Cliente, TxtEmail_Cliente, TxtContatoPrincipal_Cliente, TxtContatoSecundario_Cliente, TxtCelular_Cliente, TxtCEP_Cliente, TxtEndereco_Cliente, TxtComplemento_Cliente, TxtCidade_Cliente, TxtUF_Cliente, TxtInfoComplementar_Cliente, PanelInfoComplementar_Cliente, BtnInfoComplementar_Cliente)
                    TxtEquipamento_Cliente.Clear()
                    TxtEquipamento_Cliente.IconRight = Nothing
                    TxtNSerie_Cliente.Clear()
                    CbCondicao_Cliente.SelectedIndex = -1
                    CbCondicao_Cliente.FillColor = Color.WhiteSmoke
                    VerificaTabela()
                    TabControl_CadCons.SelectTab(2)
                    MessageBox.Show($"Cliente atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


        End Select
    End Sub

    Private Sub TimerDel_Cliente_Tick(sender As Object, e As EventArgs) Handles TimerDel_Cliente.Tick

        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 80
                ExcluirRegistro()
                VerificaTabela()

            Case 100
                ClCliente_Phonebook.valida = False
                TimerDel_Cliente.Stop()
                Limpar(TxtNome_Cliente, TxtCPFouCNPJ_Cliente, TxtEmail_Cliente, TxtContatoPrincipal_Cliente, TxtContatoSecundario_Cliente, TxtCelular_Cliente, TxtCEP_Cliente, TxtEndereco_Cliente, TxtComplemento_Cliente, TxtCidade_Cliente, TxtUF_Cliente, TxtInfoComplementar_Cliente, PanelInfoComplementar_Cliente, BtnInfoComplementar_Cliente)
                TabControl_CadCons.SelectTab(2)
                MessageBox.Show($"Cliente deletado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Select
    End Sub
#End Region

#Region "Colaborador"
    Private Sub BtnSalvar_Colaborador_Click(sender As Object, e As EventArgs) Handles BtnSalvar_Colaborador.Click
        Dim Valida As Boolean
        TxtEmpty(Valida, TxtCPFouCNPJ_Colaborador, TxtNome_Colaborador, TxtEmail_Colaborador, TxtContatoPrincipal_Colaborador)

        If Valida = False Then
            If ValidaEmail(TxtEmail_Colaborador.Text) Then
                If TxtCEP_Cliente.Text.Length = 0 OrElse ValidaCEP(TxtCEP_Colaborador.Text) Then
                    ProgressAguarde.Value = 0
                    TabControl_CadCons.SelectTab(8)
                    TimerCad_Colaborador.Start()
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Colaborador_Click(sender As Object, e As EventArgs) Handles BtnCancelar_Colaborador.Click
        If FrmPrincipal.Cad_Cons = 2 Then
            TabControl_CadCons.SelectTab(0)
        Else
            TabControl_CadCons.SelectTab(3)
        End If

        Limpar(TxtNome_Fornecedor, TxtCPFouCNPJ_Colaborador, TxtEmail_Colaborador, TxtContatoPrincipal_Colaborador, TxtContatoSecundario_Colaborador, TxtCelular_Colaborador, TxtCEP_Colaborador, TxtEndereco_Colaborador, TxtComplemento_Colaborador, TxtCidade_Colaborador, TxtUF_Colaborador, TxtInfoComplementar_Colaborador, PanelInfoComplementar_Colaborador, BtnInfoComplementar_Colaborador)
    End Sub

    Private Sub BtnInfoComplementar_Colaborador_Click(sender As Object, e As EventArgs) Handles BtnInfoComplementar_Colaborador.Click
        If PanelInfoComplementar_Colaborador.Visible = False Then
            PanelInfoComplementar_Colaborador.Visible = True
            Me.BtnInfoComplementar_Colaborador.Text = $"Ocultar informação complementar"
        Else
            PanelInfoComplementar_Colaborador.Visible = False
            Me.BtnInfoComplementar_Colaborador.Text = $"Adicionar informação complementar"
        End If
    End Sub

    Private Sub TxtCPFouCNPJ_Colaborador_LostFocus(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Colaborador.LostFocus
        Select Case Me.TxtCPFouCNPJ_Colaborador.Text.Length
            Case 0
                Me.TxtCPFouCNPJ_Colaborador.IconRight = Nothing
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
        Select Case Me.TxtCelular_Colaborador.Text.Length
            Case 0
                Me.TxtCelular_Colaborador.IconRight = Nothing
            Case <> 10, 15
                Me.TxtCelular_Colaborador.IconRight = ImageList.Images(1)
        End Select
    End Sub

    Private Sub TxtCelular_Colaborador_Enter(sender As Object, e As EventArgs) Handles TxtCelular_Colaborador.Enter
        Me.TxtCelular_Colaborador.Text = Me.TxtCelular_Colaborador.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        Me.TxtCelular_Colaborador.IconRight = Nothing
    End Sub

    Private Sub TxtContatoPrincipal_Colaborador_LostFocus(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Colaborador.LostFocus
        Dim mask = Me.TxtContatoPrincipal_Colaborador.Text
        Select Case Me.TxtContatoPrincipal_Colaborador.Text.Length
            Case 0
                Me.TxtContatoPrincipal_Colaborador.IconRight = Nothing
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
            Case Else
                Me.TxtContatoPrincipal_Colaborador.IconRight = ImageList.Images(1)
        End Select
    End Sub

    Private Sub TxtEmail_Colaborador_Enter(sender As Object, e As EventArgs) Handles TxtEmail_Colaborador.Enter
        TxtEmail_Colaborador.IconRight = Nothing
    End Sub

    Private Sub TxtContatoPrincipal_Colaborador_Enter(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Colaborador.Enter
        Me.TxtContatoPrincipal_Colaborador.Text = Me.TxtContatoPrincipal_Colaborador.Text.Replace("(", "").Replace(") ", "").Replace("-", "").Replace(" ", "")
        Me.TxtContatoPrincipal_Colaborador.IconRight = Nothing
    End Sub

    Private Sub TxtContatoSecundario_Colaborador_LostFocus(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Colaborador.LostFocus
        Dim mask = Me.TxtContatoSecundario_Colaborador.Text
        Select Case Me.TxtContatoSecundario_Colaborador.Text.Length
            Case 0
                Me.TxtContatoSecundario_Colaborador.IconRight = Nothing
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
            Case Else
                Me.TxtContatoSecundario_Colaborador.IconRight = ImageList.Images(1)
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
                If Not Me.TxtCelular_Colaborador.Text.StartsWith("0") Then
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

    Private Sub TxtContatoSecundario_Colaborador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContatoSecundario_Colaborador.KeyPress, TxtContatoPrincipal_Colaborador.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCelular_Colaborador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCelular_Colaborador.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCidade_Colaborador_TextChanged(sender As Object, e As EventArgs) Handles TxtCidade_Colaborador.TextChanged
        If Me.TxtCidade_Colaborador.Text.Length > 0 Then
            LblCidade_Colaborador.Visible = True
        Else
            LblCidade_Colaborador.Visible = False
        End If
    End Sub

    Private Sub TxtCPFouCNPJ_Colaborador_TextChanged(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Colaborador.TextChanged
        If Me.TxtCPFouCNPJ_Colaborador.Text.Length > 0 Then
            LblCPFouCNPJ_Colaborador.Visible = True
        Else
            LblCPFouCNPJ_Colaborador.Visible = False
            TxtCPFouCNPJ_Colaborador.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtNome_Colaborador_TextChanged(sender As Object, e As EventArgs) Handles TxtNome_Colaborador.TextChanged
        If Me.TxtNome_Colaborador.Text.Length > 0 Then
            LblNome_Colaborador.Visible = True
        Else
            LblNome_Colaborador.Visible = False
        End If
    End Sub

    Private Sub TxtContatoPrincipal_Colaborador_TextChanged(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Colaborador.TextChanged
        If Me.TxtContatoPrincipal_Colaborador.Text.Length > 0 Then
            LblContatoPrincipal_Colaborador.Visible = True
        Else
            LblContatoPrincipal_Colaborador.Visible = False
            TxtContatoPrincipal_Colaborador.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtContatoSecundario_Colaborador_TextChanged(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Colaborador.TextChanged
        If Me.TxtContatoSecundario_Colaborador.Text.Length > 0 Then
            LblContatoSecundario_Colaborador.Visible = True
        Else
            LblContatoSecundario_Colaborador.Visible = False
            TxtContatoSecundario_Colaborador.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCelular_Colaborador_TextChanged(sender As Object, e As EventArgs) Handles TxtCelular_Colaborador.TextChanged
        If Me.TxtCelular_Colaborador.Text.Length > 0 Then
            LblCelular_Colaborador.Visible = True
        Else
            LblCelular_Colaborador.Visible = False
            TxtCelular_Colaborador.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtEndereco_Colaborador_TextChanged(sender As Object, e As EventArgs) Handles TxtEndereco_Colaborador.TextChanged
        If Me.TxtEndereco_Colaborador.Text.Length > 0 Then
            LblEndereco_Colaborador.Visible = True
        Else
            LblEndereco_Colaborador.Visible = False
        End If
    End Sub

    Private Sub TxtComplemento_Colaborador_TextChanged(sender As Object, e As EventArgs) Handles TxtComplemento_Colaborador.TextChanged
        If Me.TxtComplemento_Colaborador.Text.Length > 0 Then
            LblComplemento_Colaborador.Visible = True
        Else
            LblComplemento_Colaborador.Visible = False
        End If
    End Sub

    Private Sub TxtCEP_Colaborador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCEP_Colaborador.KeyPress
        ClValidaCep.ApenasNumeros(e, sender)
    End Sub

    Private Sub TxtCEP_Colaborador_TextChanged(sender As Object, e As EventArgs) Handles TxtCEP_Colaborador.TextChanged
        ClValidaCep.MaskCep(sender)
        If TxtCEP_Colaborador.Text.Length > 0 Then
            LblCEP_Colaborador.Visible = True
        Else
            LblCEP_Colaborador.Visible = False
            TxtCEP_Colaborador.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtUF_Colaborador_TextChanged(sender As Object, e As EventArgs) Handles TxtUF_Colaborador.TextChanged
        If Me.TxtUF_Colaborador.Text.Length > 0 Then
            LblUF_Colaborador.Visible = True
        Else
            LblUF_Colaborador.Visible = False
        End If
    End Sub

    Private Sub TxtUF_Colaborador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUF_Colaborador.KeyPress
        If (Char.IsNumber(e.KeyChar)) OrElse (Char.IsSymbol(e.KeyChar)) OrElse (Char.IsPunctuation(e.KeyChar)) OrElse (Char.IsSeparator(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtEmail_Fornecedor_Enter(sender As Object, e As EventArgs) Handles TxtEmail_Fornecedor.Enter
        TxtEmail_Fornecedor.IconRight = Nothing
    End Sub

    Private Sub TxtEmail_Colaborador_LostFocus(sender As Object, e As EventArgs) Handles TxtEmail_Colaborador.LostFocus
        If TxtEmail_Colaborador.Text.Length > 0 Then
            If ValidaEmail(TxtEmail_Colaborador.Text) = False Then
                TxtEmail_Colaborador.IconRight = ImageList.Images(1)
            End If
        Else
            TxtEmail_Colaborador.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCEP_Colaborador_LostFocus(sender As Object, e As EventArgs) Handles TxtCEP_Colaborador.LostFocus
        If TxtCEP_Colaborador.Text.Length > 0 Then
            If ValidaCEP(TxtCEP_Colaborador.Text) = False Then
                TxtCEP_Colaborador.IconRight = ImageList.Images(1)
            End If
        Else
            TxtCEP_Colaborador.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCEP_Colaborador_Enter(sender As Object, e As EventArgs) Handles TxtCEP_Colaborador.Enter
        TxtCEP_Colaborador.IconRight = Nothing
    End Sub

    Private Sub TxtNome_Colaborador_Enter(sender As Object, e As EventArgs) Handles TxtNome_Colaborador.Enter
        TxtNome_Colaborador.IconRight = Nothing
    End Sub

    Private Sub TxtEmail_Colaborador_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail_Colaborador.TextChanged
        If TxtEmail_Colaborador.Text.Length > 0 Then
            LblEmail_Colaborador.Visible = True
        Else
            LblEmail_Colaborador.Visible = False
            TxtEmail_Colaborador.IconRight = Nothing
        End If
    End Sub

    Private Sub TimerCad_Colaborador_Tick(sender As Object, e As EventArgs) Handles TimerCad_Colaborador.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 80
                If FrmPrincipal.Cad_Cons = 2 Then
                    ClColaborador_Phonebook.id_interno = CodigoInterno()
                    ClColaborador_Phonebook.ValidaCodigoInterno()

                    If ClColaborador_Phonebook.valida = True Then
                        ClColaborador_Phonebook.id_interno = CodigoInterno()
                        ClColaborador_Phonebook.ValidaCodigoInterno()
                    Else
                        ClColaborador_Phonebook.name = TxtNome_Colaborador.Text
                        ClColaborador_Phonebook.BuscarColaborador()

                        If ClColaborador_Phonebook.valida = False Then
                            ClColaborador_Phonebook.id_interno = Senha
                            ClColaborador_Phonebook.cpf_cnpj = TxtCPFouCNPJ_Colaborador.Text
                            ClColaborador_Phonebook.name = TxtNome_Colaborador.Text
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
                            ClColaborador_Phonebook.valida = False
                            TimerCad_Colaborador.Stop()
                            TabControl_CadCons.SelectTab(5)
                            TxtNome_Colaborador.IconRight = ImageList.Images(1)
                            MessageBox.Show($"O colaborador já encontra-se na base de dados!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Else
                    ClColaborador_Phonebook.id_interno = LblId_Interno.Text
                    ClColaborador_Phonebook.cpf_cnpj = TxtCPFouCNPJ_Cliente.Text
                    ClColaborador_Phonebook.name = TxtNome_Cliente.Text
                    ClColaborador_Phonebook.email = TxtEmail_Cliente.Text
                    ClColaborador_Phonebook.contato_principal = TxtContatoPrincipal_Cliente.Text
                    ClColaborador_Phonebook.contato_secundario = TxtContatoSecundario_Cliente.Text
                    ClColaborador_Phonebook.celular = TxtCelular_Cliente.Text
                    ClColaborador_Phonebook.cep = TxtCEP_Cliente.Text
                    ClColaborador_Phonebook.endereco = TxtEndereco_Cliente.Text
                    ClColaborador_Phonebook.complemento = TxtComplemento_Cliente.Text
                    ClColaborador_Phonebook.cidade = TxtCidade_Cliente.Text
                    ClColaborador_Phonebook.uf = TxtUF_Cliente.Text
                    ClColaborador_Phonebook.info_complementar = TxtInfoComplementar_Cliente.Text
                    ClColaborador_Phonebook.Edita()

                End If

            Case 100
                If FrmPrincipal.Cad_Cons = 2 Then
                    TimerCad_Colaborador.Stop()
                    Limpar(TxtNome_Fornecedor, TxtCPFouCNPJ_Colaborador, TxtEmail_Colaborador, TxtContatoPrincipal_Colaborador, TxtContatoSecundario_Colaborador, TxtCelular_Colaborador, TxtCEP_Colaborador, TxtEndereco_Colaborador, TxtComplemento_Colaborador, TxtCidade_Colaborador, TxtUF_Colaborador, TxtInfoComplementar_Colaborador, PanelInfoComplementar_Colaborador, BtnInfoComplementar_Colaborador)
                    TabControl_CadCons.SelectTab(0)
                    MessageBox.Show($"Cliente cadastrado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    TimerCad_Colaborador.Stop()
                    Limpar(TxtNome_Fornecedor, TxtCPFouCNPJ_Colaborador, TxtEmail_Colaborador, TxtContatoPrincipal_Colaborador, TxtContatoSecundario_Colaborador, TxtCelular_Colaborador, TxtCEP_Colaborador, TxtEndereco_Colaborador, TxtComplemento_Colaborador, TxtCidade_Colaborador, TxtUF_Colaborador, TxtInfoComplementar_Colaborador, PanelInfoComplementar_Colaborador, BtnInfoComplementar_Colaborador)
                    VerificaTabela()
                    TabControl_CadCons.SelectTab(2)
                    MessageBox.Show($"Cliente atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


        End Select
    End Sub

    Private Sub TimerDel_Colaborador_Tick(sender As Object, e As EventArgs) Handles TimerDel_Colaborador.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 80
                ExcluirRegistro()
                VerificaTabela()

            Case 100
                TimerDel_Colaborador.Stop()
                Limpar(TxtNome_Fornecedor, TxtCPFouCNPJ_Colaborador, TxtEmail_Colaborador, TxtContatoPrincipal_Colaborador, TxtContatoSecundario_Colaborador, TxtCelular_Colaborador, TxtCEP_Colaborador, TxtEndereco_Colaborador, TxtComplemento_Colaborador, TxtCidade_Colaborador, TxtUF_Colaborador, TxtInfoComplementar_Colaborador, PanelInfoComplementar_Colaborador, BtnInfoComplementar_Colaborador)
                TabControl_CadCons.SelectTab(1)
                MessageBox.Show($"Colaborador deletado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Select
    End Sub
#End Region

#Region "Fornecedor"
    Private Sub BtnSalvar_Fornecedor_Click(sender As Object, e As EventArgs) Handles BtnSalvar_Fornecedor.Click
        Dim Valida As Boolean
        TxtEmpty(Valida, TxtCPFouCNPJ_Fornecedor, TxtNome_Fornecedor, TxtEmail_Fornecedor, TxtContatoPrincipal_Fornecedor)

        If Valida = False Then
            If ValidaEmail(TxtEmail_Fornecedor.Text) Then
                If TxtCEP_Cliente.Text.Length = 0 OrElse ValidaCEP(TxtCEP_Fornecedor.Text) Then
                    ProgressAguarde.Value = 0
                    TabControl_CadCons.SelectTab(8)
                    TimerCad_Fornecedor.Start()
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Fornecedor_Click(sender As Object, e As EventArgs) Handles BtnCancelar_Fornecedor.Click
        If FrmPrincipal.Cad_Cons = 2 Then
            TabControl_CadCons.SelectTab(0)
        Else
            TabControl_CadCons.SelectTab(3)
        End If

        Limpar(TxtNome_Fornecedor, TxtCPFouCNPJ_Fornecedor, TxtEmail_Fornecedor, TxtContatoPrincipal_Fornecedor, TxtContatoSecundario_Fornecedor, TxtCelular_Fornecedor, TxtCEP_Fornecedor, TxtEndereco_Fornecedor, TxtComplemento_Fornecedor, TxtCidade_Fornecedor, TxtUF_Fornecedor, TxtInfoComplementar_Fornecedor, PanelInfoComplementar_Fornecedor, BtnInfoComplementar_Fornecedor)
    End Sub

    Private Sub BtnInfoComplementar_Fornecedor_Click(sender As Object, e As EventArgs) Handles BtnInfoComplementar_Fornecedor.Click
        If PanelInfoComplementar_Fornecedor.Visible = False Then
            PanelInfoComplementar_Fornecedor.Visible = True
            Me.BtnInfoComplementar_Fornecedor.Text = $"Ocultar informação complementar"
        Else
            PanelInfoComplementar_Fornecedor.Visible = False
            Me.BtnInfoComplementar_Fornecedor.Text = $"Adicionar informação complementar"
        End If
    End Sub

    Private Sub TxtCPFouCNPJ_Fornecedor_LostFocus(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Fornecedor.LostFocus
        Select Case Me.TxtCPFouCNPJ_Fornecedor.Text.Length
            Case 0
                Me.TxtCPFouCNPJ_Fornecedor.IconRight = Nothing
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
        Select Case Me.TxtCelular_Fornecedor.Text.Length
            Case 0
                Me.TxtCelular_Fornecedor.IconRight = Nothing
            Case <> 10, 15
                Me.TxtCelular_Fornecedor.IconRight = ImageList.Images(1)
        End Select
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
            Case 0
                Me.TxtContatoSecundario_Fornecedor.IconRight = Nothing
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
            Case Else
                Me.TxtContatoSecundario_Fornecedor.IconRight = ImageList.Images(1)
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
                If Not Me.TxtCelular_Fornecedor.Text.StartsWith("0") Then
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

    Private Sub TxtCEP_Fornecedor_TextChanged(sender As Object, e As EventArgs) Handles TxtCEP_Fornecedor.TextChanged
        ClValidaCep.MaskCep(sender)
        If TxtCEP_Fornecedor.Text.Length > 0 Then
            LblCEP_Fornecedor.Visible = True
        Else
            LblCEP_Fornecedor.Visible = False
            TxtCEP_Fornecedor.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCEP_Fornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCEP_Fornecedor.KeyPress
        ClValidaCep.ApenasNumeros(e, sender)
    End Sub

    Private Sub TxtUF_Fornecedor_TextChanged(sender As Object, e As EventArgs) Handles TxtUF_Fornecedor.TextChanged
        If Me.TxtUF_Fornecedor.Text.Length > 0 Then
            LblUF_Fornecedor.Visible = True
        Else
            LblUF_Fornecedor.Visible = False
        End If
    End Sub

    Private Sub TxtUF_Fornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUF_Fornecedor.KeyPress
        If (Char.IsNumber(e.KeyChar)) OrElse (Char.IsSymbol(e.KeyChar)) OrElse (Char.IsPunctuation(e.KeyChar)) OrElse (Char.IsSeparator(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCPFouCNPJ_Fornecedor_TextChanged(sender As Object, e As EventArgs) Handles TxtCPFouCNPJ_Fornecedor.TextChanged
        If Me.TxtCPFouCNPJ_Fornecedor.Text.Length > 0 Then
            LblCPFouCNPJ_Fornecedor.Visible = True
        Else
            LblCPFouCNPJ_Fornecedor.Visible = False
            TxtCPFouCNPJ_Fornecedor.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtNome_Fornecedor_TextChanged(sender As Object, e As EventArgs) Handles TxtNome_Fornecedor.TextChanged
        If Me.TxtNome_Fornecedor.Text.Length > 0 Then
            LblNome_Fornecedor.Visible = True
        Else
            LblNome_Fornecedor.Visible = False
        End If
    End Sub

    Private Sub TxtContatoPrincipal_Fornecedor_TextChanged(sender As Object, e As EventArgs) Handles TxtContatoPrincipal_Fornecedor.TextChanged
        If Me.TxtContatoPrincipal_Fornecedor.Text.Length > 0 Then
            LblContatoPrincipal_Fornecedor.Visible = True
        Else
            LblContatoPrincipal_Fornecedor.Visible = False
            TxtContatoPrincipal_Fornecedor.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtContatoSecundario_Fornecedor_TextChanged(sender As Object, e As EventArgs) Handles TxtContatoSecundario_Fornecedor.TextChanged
        If Me.TxtContatoSecundario_Fornecedor.Text.Length > 0 Then
            LblContatoSecundario_Fornecedor.Visible = True
        Else
            LblContatoSecundario_Fornecedor.Visible = False
            TxtContatoSecundario_Fornecedor.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCelular_Fornecedor_TextChanged(sender As Object, e As EventArgs) Handles TxtCelular_Fornecedor.TextChanged
        If Me.TxtCelular_Fornecedor.Text.Length > 0 Then
            LblCelular_Fornecedor.Visible = True
        Else
            LblCelular_Fornecedor.Visible = False
            TxtCelular_Fornecedor.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtEndereco_Fornecedor_TextChanged(sender As Object, e As EventArgs) Handles TxtEndereco_Fornecedor.TextChanged
        If Me.TxtEndereco_Fornecedor.Text.Length > 0 Then
            LblEndereco_Fornecedor.Visible = True
        Else
            LblEndereco_Fornecedor.Visible = False
        End If
    End Sub

    Private Sub TxtComplemento_Fornecedor_TextChanged(sender As Object, e As EventArgs) Handles TxtComplemento_Fornecedor.TextChanged
        If Me.TxtComplemento_Fornecedor.Text.Length > 0 Then
            LblComplemento_Fornecedor.Visible = True
        Else
            LblComplemento_Fornecedor.Visible = False
        End If
    End Sub

    Private Sub TxtCidade_Fornecedor_TextChanged(sender As Object, e As EventArgs) Handles TxtCidade_Fornecedor.TextChanged
        If Me.TxtCidade_Fornecedor.Text.Length > 0 Then
            LblCidade_Fornecedor.Visible = True
        Else
            LblCidade_Fornecedor.Visible = False
        End If
    End Sub

    Private Sub TxtEmail_Fornecedor_LostFocus(sender As Object, e As EventArgs) Handles TxtEmail_Fornecedor.LostFocus
        If TxtEmail_Fornecedor.Text.Length > 0 Then
            If ValidaEmail(TxtEmail_Fornecedor.Text) = False Then
                TxtEmail_Fornecedor.IconRight = ImageList.Images(1)
            End If
        Else
            TxtEmail_Fornecedor.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCEP_Fornecedor_LostFocus(sender As Object, e As EventArgs) Handles TxtCEP_Fornecedor.LostFocus
        If TxtCEP_Fornecedor.Text.Length > 0 Then
            If ValidaCEP(TxtCEP_Fornecedor.Text) = False Then
                TxtCEP_Fornecedor.IconRight = ImageList.Images(1)
            End If
        Else
            TxtCEP_Fornecedor.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtCEP_Fornecedor_Enter(sender As Object, e As EventArgs) Handles TxtCEP_Fornecedor.Enter
        TxtCEP_Fornecedor.IconRight = Nothing
    End Sub

    Private Sub TxtEmail_Fornecedor_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail_Fornecedor.TextChanged
        If TxtEmail_Fornecedor.Text.Length > 0 Then
            LblEmail_Fornecedor.Visible = True
        Else
            LblEmail_Fornecedor.Visible = False
            TxtEmail_Fornecedor.IconRight = Nothing
        End If
    End Sub

    Private Sub TxtNome_Fornecedor_Enter(sender As Object, e As EventArgs) Handles TxtNome_Fornecedor.Enter
        TxtNome_Fornecedor.IconRight = Nothing
    End Sub

    Private Sub TimerCad_Fornecedor_Tick(sender As Object, e As EventArgs) Handles TimerCad_Fornecedor.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 80
                If FrmPrincipal.Cad_Cons = 2 Then
                    ClFornecedor_Phonebook.id_interno = CodigoInterno()
                    ClFornecedor_Phonebook.ValidaCodigoInterno()

                    If ClFornecedor_Phonebook.valida = True Then
                        ClFornecedor_Phonebook.id_interno = CodigoInterno()
                        ClFornecedor_Phonebook.ValidaCodigoInterno()
                    Else
                        ClFornecedor_Phonebook.name = TxtNome_Fornecedor.Text
                        ClFornecedor_Phonebook.BuscarFornecedor()

                        If ClFornecedor_Phonebook.valida = False Then
                            ClFornecedor_Phonebook.id_interno = Senha
                            ClFornecedor_Phonebook.cpf_cnpj = TxtCPFouCNPJ_Fornecedor.Text
                            ClFornecedor_Phonebook.name = TxtNome_Fornecedor.Text
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
                            ClFornecedor_Phonebook.valida = False
                            TimerCad_Fornecedor.Stop()
                            TabControl_CadCons.SelectTab(6)
                            TxtNome_Fornecedor.IconRight = ImageList.Images(1)
                            MessageBox.Show($"O fornecedor já encontra-se na base de dados!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Else
                    ClFornecedor_Phonebook.id_interno = LblId_Interno.Text
                    ClFornecedor_Phonebook.cpf_cnpj = TxtCPFouCNPJ_Cliente.Text
                    ClFornecedor_Phonebook.name = TxtNome_Cliente.Text
                    ClFornecedor_Phonebook.email = TxtEmail_Cliente.Text
                    ClFornecedor_Phonebook.contato_principal = TxtContatoPrincipal_Cliente.Text
                    ClFornecedor_Phonebook.contato_secundario = TxtContatoSecundario_Cliente.Text
                    ClFornecedor_Phonebook.celular = TxtCelular_Cliente.Text
                    ClFornecedor_Phonebook.cep = TxtCEP_Cliente.Text
                    ClFornecedor_Phonebook.endereco = TxtEndereco_Cliente.Text
                    ClFornecedor_Phonebook.complemento = TxtComplemento_Cliente.Text
                    ClFornecedor_Phonebook.cidade = TxtCidade_Cliente.Text
                    ClFornecedor_Phonebook.uf = TxtUF_Cliente.Text
                    ClFornecedor_Phonebook.info_complementar = TxtInfoComplementar_Cliente.Text
                    ClFornecedor_Phonebook.Edita()

                End If

            Case 100
                If FrmPrincipal.Cad_Cons = 2 Then
                    TimerCad_Fornecedor.Stop()
                    Limpar(TxtNome_Fornecedor, TxtCPFouCNPJ_Fornecedor, TxtEmail_Fornecedor, TxtContatoPrincipal_Fornecedor, TxtContatoSecundario_Fornecedor, TxtCelular_Fornecedor, TxtCEP_Fornecedor, TxtEndereco_Fornecedor, TxtComplemento_Fornecedor, TxtCidade_Fornecedor, TxtUF_Fornecedor, TxtInfoComplementar_Fornecedor, PanelInfoComplementar_Fornecedor, BtnInfoComplementar_Fornecedor)
                    TabControl_CadCons.SelectTab(0)
                    MessageBox.Show($"Fornecedor cadastrado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    TimerCad_Fornecedor.Stop()
                    Limpar(TxtNome_Fornecedor, TxtCPFouCNPJ_Fornecedor, TxtEmail_Fornecedor, TxtContatoPrincipal_Fornecedor, TxtContatoSecundario_Fornecedor, TxtCelular_Fornecedor, TxtCEP_Fornecedor, TxtEndereco_Fornecedor, TxtComplemento_Fornecedor, TxtCidade_Fornecedor, TxtUF_Fornecedor, TxtInfoComplementar_Fornecedor, PanelInfoComplementar_Fornecedor, BtnInfoComplementar_Fornecedor)
                    VerificaTabela()
                    TabControl_CadCons.SelectTab(2)
                    MessageBox.Show($"Fornecedor atualizado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


        End Select
    End Sub

    Private Sub TimerDel_Fornecedor_Tick(sender As Object, e As EventArgs) Handles TimerDel_Fornecedor.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 80
                ExcluirRegistro()
                VerificaTabela()

            Case 100
                TimerDel_Fornecedor.Stop()
                Limpar(TxtNome_Fornecedor, TxtCPFouCNPJ_Fornecedor, TxtEmail_Fornecedor, TxtContatoPrincipal_Fornecedor, TxtContatoSecundario_Fornecedor, TxtCelular_Fornecedor, TxtCEP_Fornecedor, TxtEndereco_Fornecedor, TxtComplemento_Fornecedor, TxtCidade_Fornecedor, TxtUF_Fornecedor, TxtInfoComplementar_Fornecedor, PanelInfoComplementar_Fornecedor, BtnInfoComplementar_Fornecedor)
                TabControl_CadCons.SelectTab(1)
                MessageBox.Show($"Fornecedor deletado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Select
    End Sub
#End Region

#Region "Anexo"
    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        DgvArquivos.Rows.Clear()
        PanelSelect_Anexo.Visible = False
        TabControl_CadCons.SelectTab(3)
    End Sub

    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click
        Upload()
    End Sub

    Private Sub BtnDownload_Click(sender As Object, e As EventArgs) Handles BtnDownload.Click
        Download()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Excluir()
    End Sub

    Private Sub DgvArquivos_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DgvArquivos.CurrentCellDirtyStateChanged
        If DgvArquivos.IsCurrentCellDirty Then
            DgvArquivos.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub DgvArquivos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvArquivos.CellValueChanged
        'MultSelectRow(sender)
        SelecionarLinhaDgvArquivos_Contar(e)
    End Sub

    Private Sub TimerDownload_Tick(sender As Object, e As EventArgs) Handles TimerDownload.Tick
        ProgressAguarde.Increment(5)

        Select Case ProgressAguarde.Value

            Case 100
                Select Case Perfil

                    Case "Cliente"
                        PanelSelect_Anexo.Visible = False
                        TimerDownload.Stop()
                        DgvArquivos.Rows.Clear()
                        ClServerSFTP.FileListCliente_Phonebook(DgvArquivos, LblId_Interno.Text)
                        TabControl_CadCons.SelectTab(7)

                    Case "Colaborador"
                        PanelSelect_Anexo.Visible = False
                        TimerDownload.Stop()
                        DgvArquivos.Rows.Clear()
                        ClServerSFTP.FileListColaborador_Phonebook(DgvArquivos, LblId_Interno.Text)
                        TabControl_CadCons.SelectTab(7)

                    Case "Fornecedor"
                        PanelSelect_Anexo.Visible = False
                        TimerDownload.Stop()
                        DgvArquivos.Rows.Clear()
                        ClServerSFTP.FileListFornecedor_Phonebook(DgvArquivos, LblId_Interno.Text)
                        TabControl_CadCons.SelectTab(7)

                End Select
        End Select
    End Sub
#End Region

#Region "Aguarde"

#End Region

    Private Sub FrmCadastros_Phonebook_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        PanelFilter.Location = TxtFilter.Location + New Point(35, 71)
    End Sub

    Private Sub FrmCadastros_Phonebook_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ToolTipLoad()

        If FrmPrincipal.Cad_Cons = 1 Then
            TabControl_CadCons.SelectTab(1)

        Else
            TabControl_CadCons.SelectTab(0)
        End If

        TabControl_CadCons.TabMenuVisible = False
        TabControl_CadCons.Visible = True
    End Sub

    Private Sub BtnSelectFechar_Click(sender As Object, e As EventArgs) Handles BtnSelectFechar.Click
        SelectTransition.HideSync(PanelSelect)
    End Sub

    Private Sub BtnSelectFechar_Arquivos_Click(sender As Object, e As EventArgs) Handles BtnSelectFechar_Arquivos.Click
        SelectTransition.HideSync(PanelSelect_Anexo)
    End Sub

    Private Sub TxtEquipamento_Cliente_Enter(sender As Object, e As EventArgs) Handles TxtEquipamento_Cliente.Enter
        TxtEquipamento_Cliente.IconRight = Nothing
    End Sub

    Private Sub CbCondicao_Cliente_Enter(sender As Object, e As EventArgs) Handles CbCondicao_Cliente.Enter
        CbCondicao_Cliente.FillColor = Color.WhiteSmoke
    End Sub
End Class