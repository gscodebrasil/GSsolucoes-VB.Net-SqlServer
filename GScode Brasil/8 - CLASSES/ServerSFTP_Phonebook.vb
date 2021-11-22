Imports System.ComponentModel
Imports System.IO
Imports Renci.SshNet
Imports Bunifu.UI.WinForms
Imports Guna.UI2.WinForms

Public Class ServerSFTP_Phonebook

#Region "Geral"

    Public Sub Connect()
        Try
            Using Sftp As SftpClient = Getconnection()
                Sftp.Connect()

                MessageBox.Show($"Conexão estabelecida com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Using
        Catch ex As Exception
            MessageBox.Show($"Erro ao estabelecer conexão com o servidor.{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Getconnection() As SftpClient
        Dim Sftp As New SftpClient(My.Settings.SFTP_Servidor, My.Settings.SFTP_Porta, My.Settings.SFTP_Usuario, My.Settings.SFTP_Senha)
        Return Sftp
    End Function

#End Region

#Region "Anexo de cliente - Phonebook"

    Public Function FormataGridViewCliente_Phonebook(ColumnChkBox As Boolean, ColumnName As String, ColumnData As String, ColumnTamanho As String, Dgv As BunifuDataGridView)
        With Dgv

            .GridColor = Color.WhiteSmoke
            .DefaultCellStyle.Font = New Font("Segoe UI Semibold", 9)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(223, 243, 251)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersDefaultCellStyle.Font = New Font("Segoe UI Bold", 9)
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersHeight = 40
            .RowTemplate.Height = 40

            .ColumnCount = 5

            .Rows.Add(ColumnChkBox, ColumnName, ColumnData, ColumnTamanho)

            .Columns(1).HeaderText = "Arquivo"
            .Columns(2).HeaderText = "Data"
            .Columns(3).HeaderText = "Tamanho"
            .Columns(0).HeaderCell = New CheckHeaderCell

            .Columns(0).Visible = True
            .Columns(0).ReadOnly = False
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True

            .Sort(.Columns(2), ListSortDirection.Descending)
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With
        Return Dgv
    End Function

    Public Function FileListCliente_Phonebook(Dgv As BunifuDataGridView, FolderCliente As String)
        Try
            Using Sftp As SftpClient = Getconnection()
                Sftp.Connect()

                Dim Files = Sftp.ListDirectory($"{My.Settings.SFTP_PhonebookClientes}{FolderCliente}/")

                For Each File In Files
                    If File.IsRegularFile Then
                        Dim FileAtributes = Sftp.GetAttributes($"{My.Settings.SFTP_PhonebookClientes}{FolderCliente}/{File.Name}")
                        Dim Tamanho As String = FileAtributes.Size
                        Dim MB = 1048576
                        Dim GB = 1048576000

                        If Tamanho < GB Then
                            Tamanho /= MB
                            Tamanho = $"{FormatNumber(Tamanho, 2).Replace(",", ".")} MB"

                        Else
                            Tamanho /= GB
                            Tamanho = $"{FormatNumber(Tamanho, 2).Replace(",", ".")} GB"

                        End If

                        FormataGridViewCliente_Phonebook(False, File.Name, FileAtributes.LastWriteTime, Tamanho, Dgv)

                    End If
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show($"Erro ao listar os arquivos.{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Dgv
    End Function

    Public Function CarregarArquivo_Phonebook(Dgv As BunifuDataGridView, Ofd As OpenFileDialog, FolderCliente As String, TabControl As Guna2TabControl)
        Ofd.Title = "Selecione Arquivo"
        Ofd.Filter = "Todos os arquivos (*.*)|*.*"
        Ofd.Multiselect = True
        Ofd.CheckFileExists = True
        Ofd.CheckPathExists = True
        Ofd.FilterIndex = 2
        Ofd.RestoreDirectory = True
        Ofd.ReadOnlyChecked = True
        Ofd.ShowReadOnly = True
        Ofd.FileName = ""

        Try
            Using Sftp As SftpClient = Getconnection()
                Sftp.Connect()

                If Ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim FilePath() As String = Ofd.FileNames
                    Dim FileName As String

                    'VERIFICA AS INFORMAÇÕES (ULTIMA ATUALIZAÇÃO E TAMANHO) DO ARQUIVO
                    For Each FileName In FilePath
                        Dim FileWriteTime As String = File.GetLastWriteTime(FileName)
                        Dim FileSize As String = File.OpenRead(FileName).Length
                        Dim MB = 1048576
                        Dim GB = 1048576000

                        If FileSize < GB Then
                            FileSize /= MB
                            FileSize = $"{FormatNumber(FileSize, 2).Replace(",", ".")} MB"

                        Else
                            FileSize /= GB
                            FileSize = $"{FormatNumber(FileSize, 2).Replace(",", ".")} GB"

                        End If

                        'VERIFICA SE EXISTE O ARQUIVO NO SERVIDOR
                        If Sftp.Exists($"{My.Settings.SFTP_PhonebookClientes}{FolderCliente}/{Path.GetFileName(FileName)}") Then
                            If MessageBox.Show($"O Arquivo {Path.GetFileName(FileName)} já existe no servidor, deseja substitui-lo?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                                'REMOVE A LINHA CORRESPONDENTE AO ARQUIVO QUE FOI SUBSTITUIDO
                                For Each VFile As DataGridViewRow In Dgv.Rows
                                    If VFile.Cells(1).Value.ToString.Contains(Path.GetFileName(FileName)) Then
                                        Dgv.Rows.Remove(VFile)
                                    End If
                                Next

                                'FAZ COPIA DO ARQUIVO PARA O SERVIDOR
                                Using stream As Stream = File.OpenRead($"{Path.GetFullPath(FileName)}")

                                    Sftp.UploadFile(stream, $"{My.Settings.SFTP_PhonebookClientes}{FolderCliente}/{Path.GetFileName(FileName)}")

                                    If Dgv.Rows.Count > 0 Then
                                        Dgv.Rows.Add(False, Path.GetFileName(FileName), FileWriteTime, FileSize)
                                    Else
                                        FormataGridViewCliente_Phonebook(False, Path.GetFileName(FileName), FileWriteTime, FileSize, Dgv)
                                    End If
                                End Using
                            End If

                        Else

                            'FAZ COPIA DO ARQUIVO PARA O SERVIDOR
                            Using stream As Stream = File.OpenRead($"{Path.GetFullPath(FileName)}")

                                Sftp.UploadFile(stream, $"{My.Settings.SFTP_PhonebookClientes}{FolderCliente}/{Path.GetFileName(FileName)}")

                                If Dgv.Rows.Count > 0 Then
                                    Dgv.Rows.Add(False, Path.GetFileName(FileName), FileWriteTime, FileSize)
                                Else
                                    FormataGridViewCliente_Phonebook(False, Path.GetFileName(FileName), FileWriteTime, FileSize, Dgv)
                                End If
                            End Using
                        End If
                    Next
                End If
            End Using
        Catch ex As Exception
            If MessageBox.Show($"Erro na operação com o servidor. {vbNewLine}{vbNewLine}ERRO: {ex.Message}{vbNewLine}{vbNewLine} Deseja verificar as informações do servidor?", "ERRO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

                TabControl.SelectTab(2)
            End If
        End Try
        Return Dgv
    End Function

#End Region

End Class
