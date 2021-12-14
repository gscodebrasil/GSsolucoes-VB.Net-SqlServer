Public Class FrmAplicacoes

    Private ClUser As New UserInfo


    Public Sub AcessoNv0()
        MessageBox.Show("Usuário não possui acesso ao módulo, solicite ao administrador a liberação do acesso no token enviado no momento do cadastro.", "INFORMAÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Public Sub AcessoNv1()

    End Sub

    Public Sub AcessoNv2()

    End Sub

    Public Sub AcessoNv3()

    End Sub

    Public Sub AcessoNv4()

    End Sub

    Public Sub AcessoNv5()

    End Sub

    Private Sub FrmAplicacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPhonebook_Click(sender As Object, e As EventArgs) Handles BtnPhonebook.Click
        FrmPrincipal.Cad_Cons = 0
        FrmPrincipal.MenuAbertoOuFechado(1)
    End Sub

    Private Sub btnHelpdesk_Click(sender As Object, e As EventArgs) Handles btnHelpdesk.Click
        FrmPrincipal.Cad_Cons = 0
        FrmPrincipal.MenuAbertoOuFechado(2)
    End Sub

    Private Sub btnEstoque_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnFinanceiro_Click(sender As Object, e As EventArgs)
        FrmPrincipal.ActiveFormClose()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAttPhonebook_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAttHelpdesk_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAttEstoque_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAttFinanceiro_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAttDashboard_Click(sender As Object, e As EventArgs)

    End Sub
End Class