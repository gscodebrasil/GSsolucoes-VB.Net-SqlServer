Imports System.Data.SqlClient

Public Class Colaborador_Phonebook

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
                Using command As SqlCommand = New SqlCommand($"INSERT INTO dbo.cliente_phonebook(id_interno, cpf_cnpj, name, genero, email, contato_principal, contato_secundario, celular, cep, endereco, complemento, cidade, uf, cond_contratual, equipamento, numero_serie, info_complementar, date_cad) VALUES ('{id_interno}','{cpf_cnpj}','{name}','{genero}','{email}','{contato_principal}','{contato_secundario}','{celular}','{cep}','{endereco}','{complemento}','{cidade}','{uf}','{info_complementar}', GETDATE());", conn)

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
                Using command As SqlCommand = New SqlCommand($"UPDATE dbo.user_info SET cpf_cnpj='{cpf_cnpj}',name='{name}',genero='{genero}',email='{email}',contato_principal='{contato_principal}',contato_secundario='{contato_secundario}',celular='{celular}',cep='{cep}',endereco='{endereco}',complemento='{complemento}',cidade='{cidade}',uf='{uf}',info_complementar='{info_complementar}'", conn)
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
                Using command As SqlCommand = New SqlCommand($"DELETE FROM dbo.cliente_phonebook cpf_cnpj={cpf_cnpj}", conn)
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

    Public Sub Busca()
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using cmd As SqlCommand = New SqlCommand($"SELECT * FROM dbo.cliente_phonebook WHERE cpf_cnpj='{cpf_cnpj}'", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                If dr("cpf_cnpj") = cpf_cnpj Then
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

    Private Function Getconnection() As SqlConnection
        Dim strConn As String = $"Data Source={My.Settings.Database_Servidor},{My.Settings.Database_Porta};Initial Catalog={My.Settings.Database_Banco};User Id={My.Settings.Database_Usuario};Password={ClCifer.Decriptar(My.Settings.Database_Senha, ClCifer.senha)}"
        Return New SqlConnection(strConn)
    End Function

End Class
