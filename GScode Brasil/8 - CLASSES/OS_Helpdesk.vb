Imports System.Data.SqlClient
Public Class OS_Helpdesk

    Private ReadOnly ClCifer As New Cifer
    Public Valida As Boolean
    Public TotalOS As Integer

    Public Property id As Integer
    Public Property id_interno As String
    Public Property nome_oc As String
    Public Property email_oc As String
    Public Property data_oc As String
    Public Property cpf_cnpj As String
    Public Property name As String
    Public Property email As String
    Public Property contato_oc As String
    Public Property telefone_principal As String
    Public Property telefone_secundario As String
    Public Property celular As String
    Public Property cep As String
    Public Property endereco As String
    Public Property complemento As String
    Public Property cidade As String
    Public Property uf As String
    Public Property prioridade As String
    Public Property equipamento As String
    Public Property nserie As String
    Public Property ocorrencia As String
    Public Property condicao As String
    Public Property nome_res As String
    Public Property email_res As String
    Public Property data_res As String
    Public Property resultado As String
    Public Property contato_res As String
    Public Property tempo_conexao As String
    Public Property status As String
    Public Property data_os As Date

    Public Sub DeleteTeste()
        Using conn As SqlConnection = Getconnection()
            conn.Open()
            Using command As SqlCommand = New SqlCommand($"DELETE FROM os_helpdesk WHERE id={id}", conn)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Cadastra()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"INSERT INTO os_helpdesk(id_interno, nome_oc, email_oc, data_oc, cpf_cnpj, name, email, contato_oc, telefone_principal, telefone_secundario, celular, cep, endereco, complemento, cidade, uf, prioridade, equipamento, nserie, ocorrencia, condicao, nome_res, email_res, data_res, resultado, contato_res, tempo_conexao, status, data_os) VALUES ('{id_interno}','{nome_oc}','{email_oc}','{data_oc}','{cpf_cnpj}','{name}','{email}','{contato_oc}','{telefone_principal}','{telefone_secundario}','{celular}','{cep}','{endereco}','{complemento}','{cidade}','{uf}','{prioridade}','{equipamento}','{nserie}','{ocorrencia}','{condicao}','{nome_res}','{email_res}','{data_res}','{resultado}','{contato_res}','{tempo_conexao}','{status}', GETDATE());", conn)
                    command.ExecuteNonQuery()
                    Valida = True
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

    Public Sub Edita_oc()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"UPDATE os_helpdesk SET nome_oc='{nome_oc}',email_oc='{email_oc}',data_oc='{data_oc}',cpf_cnpj='{cpf_cnpj}',name='{name}',email='{email}',contato_oc='{contato_oc}',telefone_principal='{telefone_principal}',telefone_secundario='{telefone_secundario}',celular='{celular}',cep='{cep}',endereco='{endereco}',complemento='{complemento}',cidade='{cidade}',uf='{uf}',prioridade='{prioridade}',equipamento='{equipamento}',nserie='{nserie}',ocorrencia='{ocorrencia}',condicao='{condicao}' WHERE id_interno='{id_interno}'", conn)
                    command.ExecuteNonQuery()
                    Valida = True
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
            End If
        End Try
    End Sub

    Public Sub Edita_res()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"UPDATE os_helpdesk SET nome_res='{nome_res}',email_res='{email_res}',data_res='{data_res}',resultado='{resultado}',contato_res='{contato_res}',tempo_conexao='{tempo_conexao}',status='{status}' WHERE id_interno='{id_interno}' WHERE id_interno='{id_interno}'", conn)
                    command.ExecuteNonQuery()
                    Valida = True
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
            End If
        End Try
    End Sub

    Public Sub Deleta()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"DELETE FROM os_helpdesk WHERE id={id}", conn)
                    command.ExecuteNonQuery()
                    Valida = True
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}ERRO: {ex.Message}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                FrmLogin.ErroNoBancoDeDados()
            End If
        End Try
    End Sub

    Public Sub ValidaCodigoInterno()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT id_interno FROM os_helpdesk WHERE id_interno='{id_interno}'", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                If dr("id_interno") = id_interno Then
                                    Valida = True
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
                Valida = False
            Else
                Application.Restart()
            End If
        End Try
    End Sub

    Public Function BuscarOSAbertas(DgvUser As DataGridView)
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using da = New SqlDataAdapter($"SELECT * FROM os_helpdesk WHERE status LIKE '%andamento' OR status = '' ORDER BY id DESC", conn)
                    Using dt = New DataTable()
                        da.Fill(dt)
                        DgvUser.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Valida = False
            MessageBox.Show($"Não foi possivel obter uma conexão com o banco de dados.{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return DgvUser
    End Function

    Public Function BuscarTodasOS(DgvUser As DataGridView, StrSql As String)
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
            Valida = False
            MessageBox.Show($"Não foi possivel obter uma conexão com o banco de dados.{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return DgvUser
    End Function

    Public Function CountarOS(StrSql As String)
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand(StrSql, conn)

                    TotalOS = cmd.ExecuteScalar()

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Não foi possivel obter uma conexão com o banco de dados.{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return TotalOS
    End Function

    Private Function Getconnection() As SqlConnection
        Dim strConn As String = $"Data Source={My.Settings.Database_Servidor},{My.Settings.Database_Porta};Initial Catalog={My.Settings.Database_Banco};User Id={My.Settings.Database_Usuario};Password={clCifer.Decriptar(My.Settings.Database_Senha, clCifer.senha)}"
        Return New SqlConnection(strConn)
    End Function
End Class
