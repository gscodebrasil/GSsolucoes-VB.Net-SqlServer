Imports System.Data.SqlClient

Public Class Backup

#Region "Ref. de classes"

    Private ReadOnly ClCifer As New Cifer

#End Region

#Region "Ref. Local"

    Public Property Arquivo As String
    Public Valida As Boolean

#End Region

    Public Sub ErroNoBancoDeDados()
        FrmBackup.TabControlBackup.SelectTab(2)
        FrmBackup.TxtServidor.Text = My.Settings.Database_Servidor
        FrmBackup.TxtPorta.Text = My.Settings.Database_Porta
        FrmBackup.TxtBanco.Text = My.Settings.Database_Banco
        FrmBackup.TxtUsuario.Text = My.Settings.Database_Usuario
        FrmBackup.TxtSenha.Text = My.Settings.Database_Senha
    End Sub

    Public Sub FazerBackup_BancoDados(TimerSystemBkp)
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As New SqlCommand($"BACKUP DATABASE gscode to disk = '{Arquivo}' WITH FORMAT, INIT;", conn)
                    command.ExecuteNonQuery()
                    Valida = True
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}{vbNewLine}ERRO: {ex.Message}{vbNewLine}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                TimerSystemBkp.Stop()
                ErroNoBancoDeDados()
            End If
        End Try
    End Sub

    Public Sub RestaurarBackup_BancoDados(TimerSystemBkp)
        Try
            Using conn As SqlConnection = Getconnection()
                conn.Open()
                Using command As New SqlCommand($"RESTORE DATABASE gscode FROM DISK = '{Arquivo}';", conn)
                    command.ExecuteNonQuery()
                    Valida = True
                End Using
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o banco de dados. {vbNewLine}{vbNewLine}ERRO: {ex.Message}{vbNewLine}{vbNewLine} Deseja verificar as informações do banco de dados?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                TimerSystemBkp.Stop()
                ErroNoBancoDeDados()
            End If
        End Try
    End Sub

    Private Function Getconnection() As SqlConnection
        Dim strConn As String = $"Data Source={My.Settings.Database_Servidor},{My.Settings.Database_Porta};Initial Catalog={My.Settings.Database_Banco};User Id={My.Settings.Database_Usuario};Password={ClCifer.Decriptar(My.Settings.Database_Senha, ClCifer.senha)}"
        Return New SqlConnection(strConn)
    End Function

End Class
