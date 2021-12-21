Imports System.IO

Public Class FrmSoftphone

    Private Sub Buscar_Softphone()
        Ofd.Title = "Selecione Arquivo"
        Ofd.Filter = "Arquivos (*.exe)|*.exe"
        Ofd.Multiselect = True
        Ofd.CheckFileExists = True
        Ofd.CheckPathExists = True
        Ofd.FilterIndex = 2
        Ofd.RestoreDirectory = True
        Ofd.ReadOnlyChecked = True
        Ofd.ShowReadOnly = True
        Ofd.FileName = ""

        If Ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            TxtSoftphone.Text = Ofd.FileName
            LblSoftphone.Text = Strings.StrConv(Path.GetFileNameWithoutExtension(Ofd.FileName), VbStrConv.ProperCase)
            LblSoftphone.Visible = True
        End If
    End Sub

    Private Sub BtnBuscarSoftphone_Click(sender As Object, e As EventArgs) Handles BtnBuscarSoftphone.Click
        Buscar_Softphone()
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click

        TxtSoftphone.Clear()
        LblSoftphone.Visible = False
        LblSoftphone.Text = ""

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        My.Settings.Softphone_Nome = LblSoftphone.Text
        My.Settings.Softphone_Local = TxtSoftphone.Text
        My.Settings.Softphone_AceptPrefixo = ChkPrefixo.Checked
        My.Settings.Softphone_Prefixo = TxtPrefixo.Text
        My.Settings.Save()

    End Sub

    Private Sub FrmSoftphone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ChkPrefixo.Checked = True Then
            TxtPrefixo.ReadOnly = False
        End If

        If My.Settings.Softphone_Nome.Length > 0 Then
            LblSoftphone.Text = My.Settings.Softphone_Nome
            TxtSoftphone.Text = My.Settings.Softphone_Local
            TxtPrefixo.Text = My.Settings.Softphone_Prefixo
            ChkPrefixo.Checked = My.Settings.Softphone_AceptPrefixo
            LblSoftphone.Visible = True
        End If
    End Sub

    Private Sub chkPerfilTermos_Click(sender As Object, e As EventArgs) Handles ChkPrefixo.Click
        If ChkPrefixo.Checked = True Then
            TxtPrefixo.ReadOnly = False
        Else
            TxtPrefixo.ReadOnly = False
        End If
    End Sub
End Class