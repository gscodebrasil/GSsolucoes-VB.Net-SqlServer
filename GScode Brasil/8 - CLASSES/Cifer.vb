Imports System.Security.Cryptography
Imports System.Text

Public Class Cifer
    Public senha = "26112009"

    Public Function Criptar(mensagem As String, pass As String) As String
        Dim AES As New RijndaelManaged
        Dim Hash_AES As New MD5CryptoServiceProvider
        Dim msgEncriptada As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(UnicodeEncoding.Unicode.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 16, 15)
            AES.Key = hash
            AES.Mode = CipherMode.ECB
            Dim encrypt As ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = UnicodeEncoding.Unicode.GetBytes(mensagem)
            msgEncriptada = Convert.ToBase64String(encrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Criptar = msgEncriptada
        Catch ex As Exception
            MessageBox.Show($"Não foi possível criptar, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Function

    Public Function Decriptar(mensagem As String, pass As String) As String
        Dim AES As New RijndaelManaged
        Dim Hash_AES As New MD5CryptoServiceProvider
        Dim msgDecriptada As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(UnicodeEncoding.Unicode.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 16, 15)
            AES.Key = hash
            AES.Mode = CipherMode.ECB
            Dim decrypt As ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(mensagem)
            msgDecriptada = UnicodeEncoding.Unicode.GetString(decrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Decriptar = msgDecriptada
        Catch ex As Exception
            MessageBox.Show($"Não foi possível decriptar, o sistema será reiniciado, entre em contato com o suporte para mais informações.{vbNewLine}{vbNewLine}ERRO: {ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Function
End Class
