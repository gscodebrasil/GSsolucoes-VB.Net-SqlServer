Public Class ValidaData

    Private Press = 0
    Private UltimoChar As String

    Public Sub ApenasNumeros(Tecla As KeyPressEventArgs, Caixa As Object)
        Press = Tecla.KeyChar
        If Caixa.SelectionStart - 1 <> -1 Then
            UltimoChar = Caixa.text.chars(Caixa.SelectionStart - 1)
        Else
            UltimoChar = ""
        End If

        'Rejeitando teclas que sejam diferentes de BACKSPACE e que não sejam algum numero
        If (AscW(Tecla.KeyChar) < 48 Or AscW(Tecla.KeyChar) > 57) And (AscW(Tecla.KeyChar) <> 8) Then
            Tecla.KeyChar = ""
        End If
    End Sub

    Public Sub MaskData(Caixa As Object)

        Dim Cursor As Integer
        Dim Mask As String

        Caixa.MaxLength = 10

        If AscW(Press) <> 8 Then
            '----- Definindo a posição que o cursor esta no momento
            Cursor = Caixa.SelectionStart

            '----- Redefinindo a nova posição do cursor caso necessario
            If Len(Caixa.text) = 2 Or Len(Caixa.text) = 5 Then
                Cursor = Cursor + 1
            End If

            '----- Retirando as barras
            Mask = Replace(Caixa.text, "/", "")

            '----- Recolocando as barras
            If Len(Mask) < 5 And Len(Mask) >= 2 Then
                Mask = Mask.Insert(2, "/")
            End If

            If Len(Mask) >= 5 Then
                '----- Retirando as barras
                Mask = Replace(Caixa.text, "/", "")

                '----- Recolocando as barras
                Mask = Mask.Insert(2, "/")
                Mask = Mask.Insert(5, "/")

            End If

            '----- Passando a mascara criada para a caixa de texto e definindo a posição em que cursor deverá estar
            Caixa.text = Mask
            Caixa.SelectionStart = Cursor
        Else
            If UltimoChar = "/" Then
                SendKeys.Send("{BACKSPACE}")
            End If
        End If
    End Sub
End Class
