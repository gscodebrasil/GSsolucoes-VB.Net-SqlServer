Imports System.Data.SqlClient

Public Class Backup

#Region "Ref. de classes"

    Private ReadOnly ClCifer As New Cifer

#End Region

#Region "Ref. Local"

    Public Property Arquivo As String
    Public Valida As Boolean

#End Region

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
            MessageBox.Show($"Não foi possível fazer o backup, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
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
            MessageBox.Show($"Não foi possível restaurar o backup, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub

    Private Function Getconnection() As SqlConnection
        Dim strConn As String = $"Data Source={My.Settings.Database_Servidor},{My.Settings.Database_Porta};Initial Catalog={My.Settings.Database_Banco};User Id={My.Settings.Database_Usuario};Password={ClCifer.Decriptar(My.Settings.Database_Senha, ClCifer.senha)}"
        Return New SqlConnection(strConn)
    End Function

End Class
