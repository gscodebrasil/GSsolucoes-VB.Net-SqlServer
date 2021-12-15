Imports Guna.UI2.WinForms
Imports System.Data.SqlClient
Imports System.Threading
Public Class FrmUsers

#Region "Ref. de Classe"

    Private ReadOnly ClUserInfo As New UserInfo

#End Region

#Region "Ref. Local"

    Private Nv As Char
    Private PaginaAtual As Integer = 1
    Private PaginaTotal As Double

    Private ColumnOpcoes As String = "name"
    Private ColumnGenero As String = ""
    Private ColumnData As String = ""
    Private RegistroDe As Integer
    Private RegistroAte As Integer

#End Region

#Region "Sub/Function"

    Private Sub FormataGridView()
        With DgvUsers
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
            .Columns(6).HeaderText = "Nome"
            .Columns(3).HeaderText = "E-mail"
            .Columns(20).HeaderText = "Setor"
            .Columns(24).HeaderText = "Token"
            .Columns(31).HeaderText = "Cadastrado Em"
            .Columns(0).HeaderCell = New CheckHeaderCell

            .Columns(0).Visible = True
            .Columns(1).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(7).Visible = False
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
            .Columns(21).Visible = False
            .Columns(22).Visible = False
            .Columns(23).Visible = False
            .Columns(25).Visible = False
            .Columns(26).Visible = False
            .Columns(27).Visible = False
            .Columns(28).Visible = False
            .Columns(29).Visible = False
            .Columns(30).Visible = False

            .Columns(0).ReadOnly = False
            .Columns(3).ReadOnly = True
            .Columns(6).ReadOnly = True
            .Columns(20).ReadOnly = True
            .Columns(24).ReadOnly = True
            .Columns(25).ReadOnly = True

            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(24).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        End With
    End Sub

    Private Sub DgvPaginacao_Seguinte()
        Dim NDecimal As Integer

        RegistroAte = CbRegistrosPorPagina.Text

        If PaginaAtual = PaginaTotal Then
            Exit Sub
        End If

        RegistroDe = CInt(CbRegistrosPorPagina.Text) * PaginaAtual

        ClUserInfo.CountUsers($"Select COUNT(*) FROM user_info WHERE {ColumnGenero} {ColumnData} {ColumnOpcoes} Like '{TxtFilter.Text}%'")
        ClUserInfo.RegistroUserDesc(DgvUsers, $"SELECT * FROM user_info WHERE {ColumnGenero} {ColumnData} {ColumnOpcoes} Like '{TxtFilter.Text}%' ORDER BY id DESC OFFSET {RegistroDe} ROWS FETCH NEXT {RegistroAte} ROWS ONLY")

        PaginaAtual += 1
        PaginaTotal = ClUserInfo.TotalUser / CInt(CbRegistrosPorPagina.Text)
        NDecimal -= Math.Floor(PaginaTotal)
        PaginaTotal = ClUserInfo.TotalUser / CInt(CbRegistrosPorPagina.Text)
        NDecimal = ClUserInfo.TotalUser Mod CInt(CbRegistrosPorPagina.Text)
        If PaginaTotal > 0 Then
            If NDecimal > 0 Then
                PaginaTotal = ClUserInfo.TotalUser \ CInt(CbRegistrosPorPagina.Text)
                PaginaTotal += 1
            End If
        Else
            PaginaTotal += 1
        End If

        LblPaginacao.Text = $"Página {PaginaAtual} de {PaginaTotal} ({ClUserInfo.TotalUser} registros)"
        DgvUsers.Columns(0).HeaderCell = New CheckHeaderCell
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

        ClUserInfo.CountUsers($"Select COUNT(*) FROM user_info WHERE {ColumnGenero} {ColumnData} {ColumnOpcoes} Like '{TxtFilter.Text}%'")
        ClUserInfo.RegistroUserDesc(DgvUsers, $"SELECT * FROM user_info WHERE {ColumnGenero} {ColumnData} {ColumnOpcoes} Like '{TxtFilter.Text}%' ORDER BY id DESC OFFSET {RegistroDe} ROWS FETCH NEXT {RegistroAte} ROWS ONLY")

        PaginaAtual -= 1
        PaginaTotal = ClUserInfo.TotalUser / CInt(CbRegistrosPorPagina.Text)
        NDecimal -= Math.Floor(PaginaTotal)
        PaginaTotal = ClUserInfo.TotalUser / CInt(CbRegistrosPorPagina.Text)
        NDecimal = ClUserInfo.TotalUser Mod CInt(CbRegistrosPorPagina.Text)
        If PaginaTotal > 0 Then
            If NDecimal > 0 Then
                PaginaTotal = ClUserInfo.TotalUser \ CInt(CbRegistrosPorPagina.Text)
                PaginaTotal += 1
            End If
        Else
            PaginaTotal += 1
        End If


        LblPaginacao.Text = $"Página {PaginaAtual} de {PaginaTotal} ({ClUserInfo.TotalUser} registros)"
        DgvUsers.Columns(0).HeaderCell = New CheckHeaderCell
        LblSelectRegister.Visible = False
        PanelSelect.Visible = False
    End Sub

    Private Sub SelecionarLinha_Contar(e As DataGridViewCellEventArgs)
        Dim count As Integer

        If DgvUsers.Rows.Count() > 0 Then
            If DgvUsers.Columns(e.ColumnIndex).Index = 0 Then
                For i As Integer = 0 To DgvUsers.Rows.Count() - 1
                    If DgvUsers.Rows(i).Cells(0).Value Then
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
                        BtnInfoUsuario.Enabled = True

                    Case Else
                        LblSelectRegister.Text = $"{count} Registros selecionados"
                        LblSelectRegister.Visible = True

                        HtmlLblSelect.Text = $"Usuários selecionados ({count})"
                        PanelSelect.BringToFront()
                        SelectTransition.ShowSync(PanelSelect)
                        BtnInfoUsuario.Enabled = False

                End Select
            End If
        End If
    End Sub

    Private Sub Informacoes_Usuario()
        Dim i As Integer = 0
        While i < DgvUsers.Rows.Count
            Dim row As DataGridViewRow = DgvUsers.Rows(i)
            If Convert.ToBoolean(row.Cells(0).Value) Then

                Dim StrColorWhats As String
                Dim StrWhats As String

                Dim StrColorEmail As String
                Dim StrEmail As String

                If row.Cells(16).Value IsNot DBNull.Value Then
                    StrWhats = "Ativado"
                    StrColorWhats = "Green"
                Else
                    StrWhats = "Desativado"
                    StrColorWhats = "Red"
                End If

                If row.Cells(17).Value IsNot DBNull.Value Then
                    StrEmail = "Ativado"
                    StrColorEmail = "Green"
                Else
                    StrEmail = "Desativado"
                    StrColorEmail = "Red"
                End If

                LblChaveKey.Text = $"{row.Cells(24).Value}"

                LblUserInfo.Text = $"<b>Informações  Pessoais</b><br><br>
                            {row.Cells(2).Value}.<br>
                            <b>Nome:</b> {row.Cells(6).Value}.<br>
                            <b>E-mail:</b> {row.Cells(3).Value}.<br>
                            <b>Data de Nascimento:</b> {row.Cells(8).Value}.<br>
                            <b>Gênero:</b> {row.Cells(9).Value}.<br>
                            <b>Celular:</b> {row.Cells(10).Value}.<br>
                            <b>Endereço:</b> {row.Cells(12).Value}, {row.Cells(13).Value}, {row.Cells(14).Value}, {row.Cells(15).Value}, {row.Cells(11).Value}.<br>
                            <b>Notificações via Whatsapp:</b><font color={StrColorWhats}> {StrWhats}.</font> <b>Email:</b><font color={StrColorEmail}> {StrEmail}.</font><br><br><br>
                            <b>Informações Profissionais</b><br>
                            <b>Empresa:</b> {row.Cells(19).Value}.<br>
                            <b>Departamento:</b> {row.Cells(20).Value}.<br>
                            <b>Função:</b> {row.Cells(21).Value}.<br>
                            <b>Telefone:</b> {row.Cells(22).Value}.<br>
                            <b>Ramal:</b> {row.Cells(23).Value}."

                Me.PanelSelect.Visible = False
                TabControlUsers.SelectTab(2)
            End If
            i += 1
        End While
    End Sub

    Private Sub ExcluirUsuario()

        Dim i As Integer = 0
        While i < DgvUsers.Rows.Count
            Dim row As DataGridViewRow = DgvUsers.Rows(i)
            If Convert.ToBoolean(row.Cells(0).Value) Then
                Dim id As Integer = Convert.ToInt16(row.Cells(1).Value)
                ClUserInfo.id = id
                ClUserInfo.DeleteTeste()
                DgvUsers.Rows.Remove(row)
                LblSelectRegister.Visible = False
                PanelSelect.Visible = False
                i -= 1
            End If
            i += 1
        End While
        BuscarUsuarios()
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

                Case "Ramal"
                    ColumnOpcoes = "ramal"
                    TxtFilter.Text = ""
                    TxtFilter.PlaceholderText = "Informe o Ramal..."
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

                Case "Token"
                    ColumnOpcoes = "token"
                    TxtFilter.Text = ""
                    TxtFilter.PlaceholderText = "Informe o Token..."
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "Feminino"
                    ColumnGenero = "genero='Feminino' and"
                    BtnAplicar.Visible = True
                    BtnLimpar.Visible = True

                Case "Masculino"
                    ColumnGenero = "genero='Masculino' and"
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

    Private Sub BuscarUsuarios()
        Dim NDecimal As Integer
        Dim RegistroDe As Integer
        Dim RegistroAte As Integer = CbRegistrosPorPagina.Text

        ClUserInfo.CountUsers($"Select COUNT(*) FROM user_info WHERE {ColumnGenero} {ColumnData} {ColumnOpcoes} Like '{TxtFilter.Text}%'")
        ClUserInfo.RegistroUserDesc(DgvUsers, $"SELECT * FROM user_info WHERE {ColumnGenero} {ColumnData} {ColumnOpcoes} like '{TxtFilter.Text}%' ORDER BY id DESC OFFSET {RegistroDe} ROWS FETCH NEXT {RegistroAte} ROWS ONLY")

        If ClUserInfo.TotalUser > 0 Then
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

        PaginaTotal = ClUserInfo.TotalUser / CInt(CbRegistrosPorPagina.Text)
        'NDecimal -= Math.Floor(PaginaTotal)
        PaginaTotal = ClUserInfo.TotalUser / CInt(CbRegistrosPorPagina.Text)
        NDecimal = ClUserInfo.TotalUser Mod CInt(CbRegistrosPorPagina.Text)
        If DgvUsers.Rows.Count > 0 Then
            If PaginaTotal > 0 Then
                If NDecimal > 0 Then
                    PaginaTotal = ClUserInfo.TotalUser \ CInt(CbRegistrosPorPagina.Text)
                    PaginaTotal += 1
                End If
            Else
                PaginaTotal += 1
            End If
        Else
            PaginaTotal = 0
        End If


        LblPaginacao.Text = $"Página {PaginaAtual} de {PaginaTotal} ({ClUserInfo.TotalUser} registros)"

        FormataGridView()
        LblSelectRegister.Visible = False
        PanelSelect.Visible = False
    End Sub

    Private Sub EditarPermissoes()
        Dim i As Integer = 0
        While i < DgvUsers.Rows.Count
            Dim row As DataGridViewRow = DgvUsers.Rows(i)
            If Convert.ToBoolean(row.Cells(0).Value) Then
                Select Case row.Cells(25).Value

                    Case "1"
                        BtnHomeNv1.Checked = True
                    Case "2"
                        BtnHomeNv2.Checked = True
                    Case "3"
                        BtnHomeNv3.Checked = True
                    Case "4"
                        BtnHomeNv4.Checked = True

                End Select

                Select Case row.Cells(26).Value

                    Case "1"
                        BtnPhonebookNv1.Checked = True
                    Case "2"
                        BtnPhonebookNv2.Checked = True
                    Case "3"
                        BtnPhonebookNv3.Checked = True
                    Case "4"
                        BtnPhonebookNv4.Checked = True

                End Select

                Select Case row.Cells(27).Value

                    Case "1"
                        BtnHelpdeskNv1.Checked = True
                    Case "2"
                        BtnHelpdeskNv2.Checked = True
                    Case "3"
                        BtnHelpdeskNv3.Checked = True
                    Case "4"
                        BtnHelpdeskNv4.Checked = True

                End Select

                Select Case row.Cells(28).Value

                    Case "1"
                        BtnEstoqueNv1.Checked = True
                    Case "2"
                        BtnEstoqueNv2.Checked = True
                    Case "3"
                        BtnEstoqueNv3.Checked = True
                    Case "4"
                        BtnEstoqueNv4.Checked = True

                End Select

                Select Case row.Cells(29).Value

                    Case "1"
                        BtnFinanceiroNv1.Checked = True
                    Case "2"
                        BtnFinanceiroNv2.Checked = True
                    Case "3"
                        BtnFinanceiroNv3.Checked = True
                    Case "4"
                        BtnFinanceiroNv4.Checked = True

                End Select

                Select Case row.Cells(30).Value

                    Case "1"
                        BtnDashboardNv1.Checked = True
                    Case "2"
                        BtnDashboardNv2.Checked = True
                    Case "3"
                        BtnDashboardNv3.Checked = True
                    Case "4"
                        BtnDashboardNv4.Checked = True

                End Select
            End If
            i += 1
        End While

        TabControlUsers.SelectTab(3)
    End Sub

    Private Sub LimparFiltroAvancado()
        For Each Btn As Guna2GradientButton In New List(Of Guna2GradientButton) From {BtnEmail, BtnRamal, BtnCidade, BtnUF, BtnToken, BtnFeminino, BtnMasculino, BtnMesAtual, BtnUltimoMes, BtnUltimos3Meses}
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
                BuscarUsuarios()
            End If
        Next
    End Sub

    Private Sub LimparPermissoes(Pnc As Panel)
        For Each Ctrl In Pnc.Controls

            If Ctrl IsNot Nothing Then
                Ctrl.Checked = False
            End If

        Next
    End Sub

    Private Sub EditarUsuario_Permissoes(Btn As Guna2GradientButton, PanelOpc As Panel)

        For Each Btn In PanelOpc.Controls
            If Btn.Checked = True Then

                Select Case Btn.Text

                    Case "Básico"
                        Nv = "1"
                        Exit Sub

                    Case "Intermediário"
                        Nv = "2"
                        Exit Sub

                    Case "Avançado"
                        Nv = "3"
                        Exit Sub

                    Case "Administrador"
                        Nv = "4"
                        Exit Sub

                End Select
            End If

        Next

    End Sub

    Private Sub BuscarUsuario_Token()
        Dim NewThread As Thread

        Select Case TxtToken.Text.Length

            Case 0
                TimerBuscarUsers.Enabled = False
                LblUsuario.Text = ""

            Case 36
                ClUserInfo.token = TxtToken.Text
                NewThread = New Thread(AddressOf ClUserInfo.BuscarUser_Token) With {.IsBackground = True}
                NewThread.Start()
                TimerBuscarUsers.Enabled = True

            Case Else
                ClUserInfo.valida = False
                TimerBuscarUsers.Enabled = False
                LblUsuario.ForeColor = Color.Red
                LblUsuario.Text = "O Token deve conter 36 caracteres"

        End Select
    End Sub

    Private Sub BuscarUsuario_Nivel()
        If ClUserInfo.valida = True Then
            TimerBuscarUsers.Enabled = False
            LblUsuario.ForeColor = Color.Blue
            LblUsuario.Text = $"{ClUserInfo.name} - {ClUserInfo.email}"

            Select Case ClUserInfo.gssolucoes

                Case "1"
                    BtnHomeNv1.Checked = True
                Case "2"
                    BtnHomeNv2.Checked = True
                Case "3"
                    BtnHomeNv3.Checked = True
                Case "4"
                    BtnHomeNv4.Checked = True

            End Select

            Select Case ClUserInfo.phonebook

                Case "1"
                    BtnPhonebookNv1.Checked = True
                Case "2"
                    BtnPhonebookNv2.Checked = True
                Case "3"
                    BtnPhonebookNv3.Checked = True
                Case "4"
                    BtnPhonebookNv4.Checked = True

            End Select

            Select Case ClUserInfo.helpdesk

                Case "1"
                    BtnHelpdeskNv1.Checked = True
                Case "2"
                    BtnHelpdeskNv2.Checked = True
                Case "3"
                    BtnHelpdeskNv3.Checked = True
                Case "4"
                    BtnHelpdeskNv4.Checked = True

            End Select

            Select Case ClUserInfo.estoque

                Case "1"
                    BtnEstoqueNv1.Checked = True
                Case "2"
                    BtnEstoqueNv2.Checked = True
                Case "3"
                    BtnEstoqueNv3.Checked = True
                Case "4"
                    BtnEstoqueNv4.Checked = True

            End Select

            Select Case ClUserInfo.financeiro

                Case "1"
                    BtnFinanceiroNv1.Checked = True
                Case "2"
                    BtnFinanceiroNv2.Checked = True
                Case "3"
                    BtnFinanceiroNv3.Checked = True
                Case "4"
                    BtnFinanceiroNv4.Checked = True

            End Select

            Select Case ClUserInfo.dashboard

                Case "1"
                    BtnDashboardNv1.Checked = True
                Case "2"
                    BtnDashboardNv2.Checked = True
                Case "3"
                    BtnDashboardNv3.Checked = True
                Case "4"
                    BtnDashboardNv4.Checked = True

            End Select

        Else
            LblUsuario.ForeColor = Color.Red
            LblUsuario.Text = $"Usuário não identificado"
        End If
    End Sub

#End Region

#Region "Inicial"

    Private Sub BtnListarUsuarios_Click(sender As Object, e As EventArgs) Handles BtnListarUsuarios.Click
        TxtToken.Text = Nothing
        LblUserInfo.Text = Nothing
        LblUserInfo.ForeColor = Nothing

        BuscarUsuarios()
        TxtFilter.Enabled = True
        TxtToken.Enabled = False
        TabControlUsers.SelectTab(1)
    End Sub

    Private Sub TxtToken_TextChanged(sender As Object, e As EventArgs) Handles TxtToken.TextChanged
        BuscarUsuario_Token()
    End Sub

    Private Sub TimerBuscarUsers_Tick(sender As Object, e As EventArgs) Handles TimerBuscarUsers.Tick
        BuscarUsuario_Nivel()
    End Sub

    Private Sub BtnEditarPermissoes_Click(sender As Object, e As EventArgs) Handles BtnEditarPermissoes.Click
        If ClUserInfo.valida = True Then
            TimerBuscarUsers.Enabled = False
            TabControlUsers.SelectTab(3)

            ClUserInfo.valida = False
            TxtToken.Text = Nothing
            LblUserInfo.Text = Nothing
            LblUserInfo.ForeColor = Nothing
        End If
    End Sub

#End Region

#Region "Lista"

    Private Sub TxtFilter_TextChanged(sender As Object, e As EventArgs) Handles TxtFilter.TextChanged
        If DgvUsers.DataSource IsNot Nothing Then
            BuscarUsuarios()
        End If
    End Sub

    Private Sub TxtFilter_IconLeftClick(sender As Object, e As EventArgs) Handles TxtFilter.IconLeftClick
        If DgvUsers.DataSource IsNot Nothing Then
            If PanelFilter.Visible = False Then
                PanelFilter.BringToFront()
                SelectTransition.ShowSync(PanelFilter)
            Else
                SelectTransition.HideSync(PanelFilter)
            End If
        End If
    End Sub

    Private Sub CbRegistrosPorPagina_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbRegistrosPorPagina.SelectionChangeCommitted
        If DgvUsers.Rows.Count > 0 Then
            BuscarUsuarios()
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        DgvPaginacao_Seguinte()
    End Sub

    Private Sub BtnPrevio_Click(sender As Object, e As EventArgs) Handles BtnPrevio.Click
        DgvPaginacao_Anterior()
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LimparFiltroAvancado()
    End Sub

    Private Sub BtnNome_Click(sender As Object, e As EventArgs) Handles BtnNome.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnEmail_Click(sender As Object, e As EventArgs) Handles BtnEmail.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnRamal_Click(sender As Object, e As EventArgs) Handles BtnRamal.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnCidade_Click(sender As Object, e As EventArgs) Handles BtnCidade.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnUF_Click(sender As Object, e As EventArgs) Handles BtnUF.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnToken_Click(sender As Object, e As EventArgs) Handles BtnToken.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnFeminino_Click(sender As Object, e As EventArgs) Handles BtnFeminino.Click
        FiltroAvancado(sender)
    End Sub

    Private Sub BtnMasculino_Click(sender As Object, e As EventArgs) Handles BtnMasculino.Click
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
                ColumnData = $"date_cad between '{DataInicial.Value.ToShortDateString()}' and '{DataFinal.Value.ToShortDateString()}'"
            Else
                ColumnData = $"date_cad between '{DataInicial.Value.ToShortDateString()}' and '{DataFinal.Value.ToShortDateString()}' and"
            End If
        End If

        SelectTransition.HideSync(PanelFilter)
        BuscarUsuarios()
    End Sub

    Private Sub BtnInfoUsuario_Click(sender As Object, e As EventArgs) Handles BtnInfoUsuario.Click
        Informacoes_Usuario()
    End Sub

    Private Sub BtnSelectApagar_Click(sender As Object, e As EventArgs) Handles BtnSelectApagar.Click
        ExcluirUsuario()
    End Sub

    Private Sub BtnSelectFechar_Click(sender As Object, e As EventArgs) Handles BtnSelectFechar.Click
        PanelSelect.Hide()
    End Sub

    'Public Sub MultSelectRow(sender As Object)
    '    With CType(sender, DataGridView)

    '        Dim intRow As Integer = .CurrentRow.Index
    '            If Not IntSelectedRows.Contains(intRow) Then
    '                IntSelectedRows.Add(intRow)

    '            Else
    '                .CurrentRow.Selected = False
    '                IntSelectedRows.Remove(intRow)
    '            End If

    '    End With
    'End Sub

    Private Sub DgvUsers_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsers.CellValueChanged
        'MultSelectRow(sender)
        SelecionarLinha_Contar(e)
    End Sub

    Private Sub DgvUsers_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DgvUsers.CurrentCellDirtyStateChanged
        If DgvUsers.IsCurrentCellDirty Then
            DgvUsers.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    'Private ReadOnly IntSelectedRows As New List(Of Integer)

    'Private Sub DgvUsers_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DgvUsers.RowPostPaint

    '    If IntSelectedRows.Contains(e.RowIndex) Then
    '        CType(sender, DataGridView).Rows(e.RowIndex).Selected = True
    '    Else
    '        CType(sender, DataGridView).Rows(e.RowIndex).Selected = False
    '    End If

    'End Sub

    Private Sub PanelPaginacao_Resize(sender As Object, e As EventArgs) Handles PanelPaginacao.Resize

        Dim x = (PanelPaginacao.Size.Width - LblPaginacao.Width) / 2
        Dim y = (PanelPaginacao.Size.Height - LblPaginacao.Height) / 2

        LblPaginacao.Location = New Point(x, y)

    End Sub

#End Region

#Region "Perfil"

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        Clipboard.SetDataObject(LblChaveKey.Text, True)
    End Sub

    Private Sub BtnVoltarPerfil_Click_1(sender As Object, e As EventArgs) Handles BtnVoltarPerfil.Click
        TabControlUsers.SelectTab(1)
        PanelSelect.Visible = True
    End Sub

    Private Sub BtnAvPerfil_Click(sender As Object, e As EventArgs) Handles BtnAvPerfil.Click
        EditarPermissoes()
    End Sub

#End Region

#Region "Permissões"

    Private Sub BtnCancelarPerm_Click(sender As Object, e As EventArgs) Handles BtnCancelarPerm.Click
        TabControlUsers.SelectTab(0)
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        ClUserInfo.token = LblChaveKey.Text
        ClUserInfo.EditaPermissoes()
        TabControlUsers.SelectTab(0)
        TimerSalvar.Enabled = True
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        BtnHomeNv1.Checked = True
        ClUserInfo.gssolucoes = "1"
    End Sub

    Private Sub BtnPhonebook_Click(sender As Object, e As EventArgs) Handles BtnPhonebook.Click
        LimparPermissoes(PanelListPhonebook)
        ClUserInfo.gssolucoes = ""
    End Sub

    Private Sub btnHelpdesk_Click(sender As Object, e As EventArgs) Handles BtnHelpdesk.Click
        LimparPermissoes(PanelListHelpdesk)
        ClUserInfo.gssolucoes = ""
    End Sub

    Private Sub btnEstoque_Click(sender As Object, e As EventArgs) Handles BtnEstoque.Click
        LimparPermissoes(PanelListEstoque)
        ClUserInfo.gssolucoes = ""
    End Sub

    Private Sub btnFinanceiro_Click(sender As Object, e As EventArgs) Handles BtnFinanceiro.Click
        LimparPermissoes(PanelListFinanceiro)
        ClUserInfo.gssolucoes = ""
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        LimparPermissoes(PanelListDashboard)
        ClUserInfo.gssolucoes = ""
    End Sub

    Private Sub BtnHomeNv1_Click(sender As Object, e As EventArgs) Handles BtnHomeNv1.Click
        EditarUsuario_Permissoes(sender, PanelListHome)
        ClUserInfo.gssolucoes = Nv
    End Sub

    Private Sub BtnHomeNv2_Click(sender As Object, e As EventArgs) Handles BtnHomeNv2.Click
        EditarUsuario_Permissoes(sender, PanelListHome)
        ClUserInfo.gssolucoes = Nv
    End Sub

    Private Sub BtnHomeNv3_Click(sender As Object, e As EventArgs) Handles BtnHomeNv3.Click
        EditarUsuario_Permissoes(sender, PanelListHome)
        ClUserInfo.gssolucoes = Nv
    End Sub

    Private Sub BtnHomeNv4_Click(sender As Object, e As EventArgs) Handles BtnHomeNv4.Click
        EditarUsuario_Permissoes(sender, PanelListHome)
        ClUserInfo.gssolucoes = Nv
    End Sub

    Private Sub BtnPhonebookNv1_Click(sender As Object, e As EventArgs) Handles BtnPhonebookNv1.Click
        EditarUsuario_Permissoes(sender, PanelListPhonebook)
        ClUserInfo.phonebook = Nv
    End Sub

    Private Sub BtnPhonebookNv2_Click(sender As Object, e As EventArgs) Handles BtnPhonebookNv2.Click
        EditarUsuario_Permissoes(sender, PanelListPhonebook)
        ClUserInfo.phonebook = Nv
    End Sub

    Private Sub BtnPhonebookNv3_Click(sender As Object, e As EventArgs) Handles BtnPhonebookNv3.Click
        EditarUsuario_Permissoes(sender, PanelListPhonebook)
        ClUserInfo.phonebook = Nv
    End Sub

    Private Sub BtnPhonebookNv4_Click(sender As Object, e As EventArgs) Handles BtnPhonebookNv4.Click
        EditarUsuario_Permissoes(sender, PanelListPhonebook)
        ClUserInfo.phonebook = Nv
    End Sub

    Private Sub BtnHelpdeskNv1_Click(sender As Object, e As EventArgs) Handles BtnHelpdeskNv1.Click
        EditarUsuario_Permissoes(sender, PanelListHelpdesk)
        ClUserInfo.helpdesk = Nv
    End Sub

    Private Sub BtnHelpdeskNv2_Click(sender As Object, e As EventArgs) Handles BtnHelpdeskNv2.Click
        EditarUsuario_Permissoes(sender, PanelListHelpdesk)
        ClUserInfo.helpdesk = Nv
    End Sub

    Private Sub BtnHelpdeskNv3_Click(sender As Object, e As EventArgs) Handles BtnHelpdeskNv3.Click
        EditarUsuario_Permissoes(sender, PanelListHelpdesk)
        ClUserInfo.helpdesk = Nv
    End Sub

    Private Sub BtnHelpdeskNv4_Click(sender As Object, e As EventArgs) Handles BtnHelpdeskNv4.Click
        EditarUsuario_Permissoes(sender, PanelListHelpdesk)
        ClUserInfo.helpdesk = Nv
    End Sub

    Private Sub BtnEstoqueNv1_Click(sender As Object, e As EventArgs) Handles BtnEstoqueNv1.Click
        EditarUsuario_Permissoes(sender, PanelListEstoque)
        ClUserInfo.estoque = Nv
    End Sub

    Private Sub BtnEstoqueNv2_Click(sender As Object, e As EventArgs) Handles BtnEstoqueNv2.Click
        EditarUsuario_Permissoes(sender, PanelListEstoque)
        ClUserInfo.estoque = Nv
    End Sub

    Private Sub BtnEstoqueNv3_Click(sender As Object, e As EventArgs) Handles BtnEstoqueNv3.Click
        EditarUsuario_Permissoes(sender, PanelListEstoque)
        ClUserInfo.estoque = Nv
    End Sub

    Private Sub BtnEstoqueNv4_Click(sender As Object, e As EventArgs) Handles BtnEstoqueNv4.Click
        EditarUsuario_Permissoes(sender, PanelListEstoque)
        ClUserInfo.estoque = Nv
    End Sub

    Private Sub BtnFinanceiroNv1_Click(sender As Object, e As EventArgs) Handles BtnFinanceiroNv1.Click
        EditarUsuario_Permissoes(sender, PanelListFinanceiro)
        ClUserInfo.financeiro = Nv
    End Sub

    Private Sub BtnFinanceiroNv2_Click(sender As Object, e As EventArgs) Handles BtnFinanceiroNv2.Click
        EditarUsuario_Permissoes(sender, PanelListFinanceiro)
        ClUserInfo.financeiro = Nv
    End Sub

    Private Sub BtnFinanceiroNv3_Click(sender As Object, e As EventArgs) Handles BtnFinanceiroNv3.Click
        EditarUsuario_Permissoes(sender, PanelListFinanceiro)
        ClUserInfo.financeiro = Nv
    End Sub

    Private Sub BtnFinanceiroNv4_Click(sender As Object, e As EventArgs) Handles BtnFinanceiroNv4.Click
        EditarUsuario_Permissoes(sender, PanelListFinanceiro)
        ClUserInfo.financeiro = Nv
    End Sub

    Private Sub BtnDashboardNv1_Click(sender As Object, e As EventArgs) Handles BtnDashboardNv1.Click
        EditarUsuario_Permissoes(sender, PanelListDashboard)
        ClUserInfo.dashboard = Nv
    End Sub

    Private Sub BtnDashboardNv2_Click(sender As Object, e As EventArgs) Handles BtnDashboardNv2.Click
        EditarUsuario_Permissoes(sender, PanelListDashboard)
        ClUserInfo.dashboard = Nv
    End Sub

    Private Sub BtnDashboardNv3_Click(sender As Object, e As EventArgs) Handles BtnDashboardNv3.Click
        EditarUsuario_Permissoes(sender, PanelListDashboard)
        ClUserInfo.dashboard = Nv
    End Sub

    Private Sub BtnDashboardNv4_Click(sender As Object, e As EventArgs) Handles BtnDashboardNv4.Click
        EditarUsuario_Permissoes(sender, PanelListDashboard)
        ClUserInfo.dashboard = Nv
    End Sub

    Private Sub TimerSalvar_Tick(sender As Object, e As EventArgs) Handles TimerSalvar.Tick
        If ClUserInfo.valida = True Then
            TimerSalvar.Enabled = False
            ClUserInfo.valida = False
            MessageBox.Show($"Permissões aplicadas com sucesso ao usuário {DgvUsers.CurrentRow.Cells(6).Value}.", "INFORMÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

    Private Sub FrmUsers_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TabControlUsers.TabMenuVisible = False
        TabControlUsers.Visible = True
    End Sub

    Private Sub FrmUsers_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        PanelFilter.Location = TxtFilter.Location + New Point(35, 71)
    End Sub
End Class