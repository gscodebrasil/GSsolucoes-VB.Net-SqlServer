Imports System.Data.SqlClient

Public Class Fornecedor_Phonebook

#Region "Ref. de classes"

    Private ClCifer As New Cifer

#End Region

#Region "Ref. Local"

    Public valida As Boolean

#End Region

#Region "Property da tabela userlogin do Banco de dados"

    Public Property id As Integer
    Public Property id_interno As String
    Public Property cpf_cnpj As String
    Public Property name As String
    Public Property genero As String
    Public Property email As String
    Public Property contato_principal As String
    Public Property contato_secundario As String
    Public Property celular As String
    Public Property cep As String
    Public Property endereco As String
    Public Property complemento As String
    Public Property cidade As String
    Public Property uf As String
    Public Property info_complementar As String

#End Region

    Public Sub Cadastra()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"INSERT INTO fornecedor_phonebook(id_interno, cpf_cnpj, name, genero, email, contato_principal, contato_secundario, celular, cep, endereco, complemento, cidade, uf, info_complementar, date_cad) VALUES ('{id_interno}','{cpf_cnpj}','{name}','{genero}','{email}','{contato_principal}','{contato_secundario}','{celular}','{cep}','{endereco}','{complemento}','{cidade}','{uf}','{info_complementar}', GETDATE());", conn)

                    command.ExecuteNonQuery()
                    valida = True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Não foi possível cadastrar o registro, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub

    Public Sub Edita()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"UPDATE fornecedor_phonebook SET cpf_cnpj='{cpf_cnpj}',nome='{name}',genero='{genero}',email='{email}',contato_principal='{contato_principal}',contato_secundario='{contato_secundario}',celular='{celular}',cep='{cep}',endereco='{endereco}',complemento='{complemento}',cidade='{cidade}',uf='{uf}',info_complementar='{info_complementar}' WHERE id_interno='{id_interno}'", conn)
                    command.ExecuteNonQuery()
                    valida = True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Não foi possível editar o registro, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub

    Public Sub Deleta()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As SqlCommand = New SqlCommand($"DELETE FROM fornecedor_phonebook WHERE id={id}", conn)
                    command.ExecuteNonQuery()
                    valida = True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Não foi possível excluir o registro, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub

    Public Sub BuscarFornecedor()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT * FROM fornecedor_phonebook WHERE name='{name}'", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            valida = True
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Não foi possível buscar o registro, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub

    Public Sub ValidaCodigoInterno()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT id_interno FROM fornecedor_phonebook WHERE id_interno='{id_interno}'", conn)
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
            MessageBox.Show($"Não foi possível validar o código do registro, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub

    Private Function Getconnection() As SqlConnection
        Dim strConn As String = $"Data Source={My.Settings.Database_Servidor},{My.Settings.Database_Porta};Initial Catalog={My.Settings.Database_Banco};User Id={My.Settings.Database_Usuario};Password={ClCifer.Decriptar(My.Settings.Database_Senha, ClCifer.senha)}"
        Return New SqlConnection(strConn)
    End Function

End Class
