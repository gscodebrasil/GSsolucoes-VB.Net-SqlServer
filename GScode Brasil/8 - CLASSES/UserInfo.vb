Imports System.Data.SqlClient
Imports System.IO
Imports Guna.UI2.WinForms

Public Class UserInfo

#Region "Ref. de classes"

    Private clCifer As New Cifer

#End Region

#Region "Token e validação"

    Public TotalUser As Integer

    Public StrIdInterno As String
    Public StrEmail As String
    Public StrPass As String
    Public StrNome As String
    Public StrFoto As String
    Public StrNascimento As String
    Public StrGenero As String
    Public StrCell As String
    Public StrCep As String
    Public StrEndereco As String
    Public StrComp As String
    Public StrCidade As String
    Public StrUF As String
    Public StrEmpresa As String
    Public StrDepart As String
    Public StrFuncao As String
    Public StrTell As String
    Public StrRamal As String
    Public ChkNotwhats As Integer
    Public ChkNotemail As Integer
    Public ChkAcepttermos As Integer
    Public TokenKey As String

    Public AcessoConfig As Integer
    Public AcessoPhonebook As Integer
    Public AcessoHelpdesk As Integer
    Public AcessoEstoque As Integer
    Public AcessoFinanceiro As Integer
    Public AcessoDashboard As Integer

    Public valida As Boolean

#End Region

    Private Sub exception()
        FrmLogin.ErroNoBancoDeDados()
    End Sub

#Region "Property da tabela userlogin do Banco de dados"

    Public Property id As Integer
    Public Property id_interno As String
    Public Property email As String
    Public Property pass As String
    Public Property pass_retry As String
    Public Property name As String
    Public Property nascimento As String
    Public Property genero As String
    Public Property cell As String
    Public Property cep As String
    Public Property endereco As String
    Public Property comp As String
    Public Property cidade As String
    Public Property uf As String
    Public Property not_whats As Boolean
    Public Property not_email As Boolean
    Public Property acept_termos As Boolean
    Public Property empresa As String
    Public Property depart As String
    Public Property funcao As String
    Public Property tell_empresa As String
    Public Property ramal As String
    Public Property token As String
    Public Property gssolucoes As Char
    Public Property phonebook As Char
    Public Property helpdesk As Char
    Public Property estoque As Char
    Public Property financeiro As Char
    Public Property dashboard As Char
    Public Property date_cad As Date


    Public Property ColumnOpcoes As String
    Public Property ColumnGenero As String
    Public Property ColumnMes As String
    Public Property ColumnDataInicial As String
    Public Property ColumnDataFinal As String

#End Region

    Public Sub LimpaProperty()

    End Sub

    Public Sub DeleteTeste()
        Using conn As SqlConnection = Getconnection()
            conn.Open()
            Using command As SqlCommand = New SqlCommand($"DELETE FROM user_info WHERE id={id}", conn)
                command.ExecuteNonQuery()
                valida = True
            End Using
        End Using
    End Sub

    Public Sub Cadastra()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"INSERT INTO user_info(id_interno, email, pass, pass_retry, name, nascimento, genero, cell, cep, endereco, comp, cidade, uf, not_whats, not_email, acept_termos, empresa, depart, funcao, tell_empresa, ramal, token, gssolucoes, phonebook, helpdesk, estoque, financeiro, dashboard, date_cad) VALUES ('{id_interno}','{email}','{pass}','{pass_retry}','{name}','{nascimento}','{genero}','{cell}','{cep}','{endereco}','{comp}','{cidade}','{uf}','{not_whats}','{not_email}','{acept_termos}','{empresa}','{depart}','{funcao}','{tell_empresa}','{ramal}','{token}','{"1"}','{""}','{""}','{""}','{""}','{""}', GETDATE());", conn)

                    command.ExecuteNonQuery()
                    valida = True
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
            Else
                Application.Restart()
            End If
        End Try
    End Sub

    Public Sub Edita()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"UPDATE user_info SET name='{name}',nascimento='{nascimento}',genero='{genero}',cell='{cell}',cep='{cep}',endereco='{endereco}',comp='{comp}',cidade='{cidade}',uf='{uf}',not_whats='{not_whats}',not_email='{not_email}',acept_termos='{acept_termos}',empresa='{empresa}',depart='{depart}',funcao='{funcao}',tell_empresa='{tell_empresa}',ramal='{ramal}' WHERE email='{email}'", conn)
                    command.ExecuteNonQuery()
                    valida = True
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
            End If
        End Try
    End Sub

    Public Sub EditaPermissoes()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"UPDATE user_info SET gssolucoes='{gssolucoes}',phonebook='{phonebook}',helpdesk='{helpdesk}',estoque='{estoque}',financeiro='{financeiro}',dashboard='{dashboard}' WHERE token='{token}'", conn)
                    command.ExecuteNonQuery()
                    valida = True
                End Using
            End Using
        Catch ex As Exception

            valida = False

            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                FrmLogin.ErroNoBancoDeDados()
            End If
        End Try
    End Sub

    Public Sub EditarEmail()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"UPDATE user_info SET email='{email}' WHERE token='{token}'", conn)
                    command.ExecuteNonQuery()
                    valida = True
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
            End If
        End Try
    End Sub

    Public Sub UpdateSenha()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"UPDATE user_info SET pass='{pass}',pass_retry='{pass_retry}' WHERE email='{email}'", conn)
                    command.ExecuteNonQuery()
                    valida = True
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
            End If
        End Try
    End Sub

    Public Sub Delete()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"DELETE FROM user_info WHERE token='{token}'", conn)
                    command.ExecuteNonQuery()
                    valida = True
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
            End If
        End Try
    End Sub

    Public Sub Login()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT email, pass, name FROM user_info WHERE email='{email}'", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                If dr("pass") = pass Then
                                    StrEmail = dr("email")
                                    StrNome = dr("name")
                                    valida = True
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            FrmAguarde.TimerAguarde.Stop()
            FrmAguarde.Close()

            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
                StrEmail = Nothing
                StrPass = Nothing
                StrNome = Nothing
                AcessoConfig = Nothing
                AcessoPhonebook = Nothing
                AcessoHelpdesk = Nothing
                AcessoEstoque = Nothing
                AcessoFinanceiro = Nothing
                AcessoDashboard = Nothing
                valida = False
            End If
        End Try
    End Sub

    Public Sub Busca()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT * FROM user_info WHERE email='{email}'", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                If dr("email") = email Then
                                    id_interno = dr("id_interno")
                                    email = dr("email")
                                    pass = dr("pass")
                                    name = dr("name")
                                    nascimento = dr("nascimento")
                                    genero = dr("genero")
                                    cell = dr("cell")
                                    cep = dr("cep")
                                    endereco = dr("endereco")
                                    comp = dr("comp")
                                    cidade = dr("cidade")
                                    uf = dr("uf")
                                    empresa = dr("empresa")
                                    depart = dr("depart")
                                    funcao = dr("funcao")
                                    tell_empresa = dr("tell_empresa")
                                    ramal = dr("ramal")
                                    not_whats = dr("not_whats")
                                    not_email = dr("not_email")
                                    acept_termos = dr("acept_termos")
                                    token = dr("token")
                                    valida = True
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
                valida = False
            End If
        End Try
    End Sub

    Public Sub VE_FUConfig()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT email FROM user_info WHERE email='{email}'", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                If Not dr("email") = email Then
                                    valida = True
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
                valida = False
            Else
                Application.Restart()
            End If
        End Try
    End Sub

    Public Sub ValidaCodigoInterno()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT id_interno FROM user_info WHERE id_interno='{id_interno}'", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                If dr("id_interno") = id_interno Then
                                    valida = True
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
                valida = False
            Else
                Application.Restart()
            End If
        End Try
    End Sub

    Public Sub ValidarEmailRdf()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT email, pass, token FROM user_info WHERE email='{email}'", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                If dr("email") = email Then
                                    pass = dr("pass")
                                    token = dr("token")
                                    valida = True
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
                valida = False
            End If
        End Try
    End Sub

    Public Sub ValidaEmail()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT email FROM user_info WHERE email='{email}'", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                If dr("email") = email Then
                                    valida = True
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
                valida = False
            End If
        End Try
    End Sub

    Public Sub BuscarSenha()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT email, pass FROM user_info WHERE email='{email}'", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                pass = dr("pass")
                                valida = True
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
                StrPass = Nothing
                StrEmail = Nothing
                valida = False
            End If
        End Try
    End Sub

    Public Sub BuscarUser_Token()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT email, name, gssolucoes, phonebook, helpdesk, estoque, financeiro, dashboard FROM user_info WHERE token='{token}'", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                email = dr("email")
                                name = dr("name")
                                gssolucoes = dr("gssolucoes")
                                phonebook = dr("phonebook")
                                helpdesk = dr("helpdesk")
                                estoque = dr("estoque")
                                financeiro = dr("financeiro")
                                dashboard = dr("dashboard")
                                valida = True
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
                valida = False
            End If
        End Try
    End Sub

    Public Sub Connect()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                MessageBox.Show("Conexão realizada com sucesso.", "INFORMÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show($"Não foi possivel obter uma conexão com o banco de dados.{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function CountUsers(StrSql As String)
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand(StrSql, conn)

                    TotalUser = cmd.ExecuteScalar()

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Não foi possivel obter uma conexão com o banco de dados.{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return TotalUser
    End Function



    Public Function RegistroUserDesc(DgvUser As DataGridView, StrSql As String)
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using da = New SqlDataAdapter(StrSql, conn)
                    Using dt = New DataTable()
                        da.Fill(dt)
                        DgvUser.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            valida = False
            MessageBox.Show($"Não foi possivel obter uma conexão com o banco de dados.{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return DgvUser
    End Function

    Private Function Getconnection() As SqlConnection
        Dim strConn As String = $"Data Source={My.Settings.Database_Servidor},{My.Settings.Database_Porta};Initial Catalog={My.Settings.Database_Banco};User Id={My.Settings.Database_Usuario};Password={clCifer.Decriptar(My.Settings.Database_Senha, clCifer.senha)}"
        Return New SqlConnection(strConn)
    End Function
End Class
