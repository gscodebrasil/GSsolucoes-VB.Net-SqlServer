Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class Cliente_Phonebook

#Region "Ref. de classes"

    Private ClCifer As New Cifer

#End Region

#Region "Ref. Local"

    Public valida As Boolean
    Public TotalUser As Integer

#End Region

#Region "Property da tabela userlogin do Banco de dados"

    Public Property id As Integer
    Public Property id_interno As String
    Public Property cpf_cnpj As String
    Public Property name As String
    Public Property email As String
    Public Property contato_principal As String
    Public Property contato_secundario As String
    Public Property celular As String
    Public Property cep As String
    Public Property endereco As String
    Public Property complemento As String
    Public Property cidade As String
    Public Property uf As String
    Public Property cond_contratual As String
    Public Property equipamento As String
    Public Property numero_serie As String
    Public Property info_complementar As String

#End Region



    Public Sub Cadastra()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"INSERT INTO cliente_phonebook(id_interno, cpf_cnpj, name, email, contato_principal, contato_secundario, celular, cep, endereco, complemento, cidade, uf, cond_contratual, equipamento, numero_serie, info_complementar, date_cad) VALUES ('{id_interno}','{cpf_cnpj}','{name}','{email}','{contato_principal}','{contato_secundario}','{celular}','{cep}','{endereco}','{complemento}','{cidade}','{uf}','{cond_contratual}','{equipamento}','{numero_serie}','{info_complementar}', GETDATE());", conn)

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
                Using command As SqlCommand = New SqlCommand($"UPDATE cliente_phonebook SET cpf_cnpj='{cpf_cnpj}',name='{name}',email='{email}',contato_principal='{contato_principal}',contato_secundario='{contato_secundario}',celular='{celular}',cep='{cep}',endereco='{endereco}',complemento='{complemento}',cidade='{cidade}',uf='{uf}',cond_contratual='{cond_contratual}',equipamento='{equipamento}',numero_serie='{numero_serie}',info_complementar='{info_complementar}' WHERE id_interno='{id_interno}'", conn)
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

    Public Sub Deleta()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"DELETE FROM cliente_phonebook WHERE id={id}", conn)
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

    Public Sub BuscarCliente()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT * FROM cliente_phonebook WHERE name='{name}'", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            valida = True
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

    Public Sub BuscarClienteHelpdesk(Txtcpf_cnpj As Guna2TextBox, Txtemail As Guna2TextBox, Txtcontato_principal As Guna2TextBox, Txtcontato_secundario As Guna2TextBox, Txtcelular As Guna2TextBox, Txtcep As Guna2TextBox, Txtendereco As Guna2TextBox, Txtcomplemento As Guna2TextBox, Txtcidade As Guna2TextBox, Txtuf As Guna2TextBox, Cbcond_contratual As Guna2ComboBox, Txtequipamento As Guna2TextBox, Txtnumero_serie As Guna2TextBox)
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT cpf_cnpj, email, contato_principal, contato_secundario, celular, cep, endereco, complemento, cidade, uf, cond_contratual, equipamento, numero_serie FROM cliente_phonebook WHERE name='{name}'", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read Then
                                Txtcpf_cnpj.Text = dr("cpf_cnpj")
                                Txtemail.Text = dr("email")
                                Txtcontato_principal.Text = dr("contato_principal")
                                Txtcontato_secundario.Text = dr("contato_secundario")
                                Txtcelular.Text = dr("celular")
                                Txtcep.Text = dr("cep")
                                Txtendereco.Text = dr("endereco")
                                Txtcomplemento.Text = dr("complemento")
                                Txtcidade.Text = dr("cidade")
                                Txtuf.Text = dr("uf")
                                Cbcond_contratual.Text = dr("cond_contratual")
                                Txtequipamento.Text = dr("equipamento")
                                Txtnumero_serie.Text = dr("numero_serie")
                                For Each Txt As Guna2TextBox In New List(Of Guna2TextBox) From {Txtcpf_cnpj, Txtemail, Txtcontato_principal, Txtequipamento}
                                    If Txt.Text.Length > 0 Then
                                        Txt.IconRight = Nothing
                                    End If
                                Next
                                If Cbcond_contratual.Text.Length > 0 Then
                                    Cbcond_contratual.FillColor = Color.WhiteSmoke
                                End If
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

    Public Function BuscarNomeCliente(Txt As Guna2TextBox)
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using da = New SqlDataAdapter($"SELECT name FROM cliente_phonebook WHERE name <> ''", conn)
                    Using ds = New DataSet()
                        Dim col As New AutoCompleteStringCollection
                        Dim i As Integer
                        da.Fill(ds, "list")
                        For i = 0 To ds.Tables(0).Rows.Count - 1
                            col.Add(ds.Tables(0).Rows(i)("name").ToString())
                        Next
                        Txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                        Txt.AutoCompleteCustomSource = col
                        Txt.AutoCompleteMode = AutoCompleteMode.Suggest
                        Txt.PlaceholderText = "NOME *"
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
        Return Txt
    End Function

    Public Sub ValidaCodigoInterno()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT id_interno FROM cliente_phonebook WHERE id_interno='{id_interno}'", conn)
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
        Dim strConn As String = $"Data Source={My.Settings.Database_Servidor},{My.Settings.Database_Porta};Initial Catalog={My.Settings.Database_Banco};User Id={My.Settings.Database_Usuario};Password={ClCifer.Decriptar(My.Settings.Database_Senha, ClCifer.senha)}"
        Return New SqlConnection(strConn)
    End Function

End Class
