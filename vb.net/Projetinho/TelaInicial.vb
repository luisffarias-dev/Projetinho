Imports System.Drawing.Drawing2D
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json.Linq

Public Class TelaInicial
    Private Async Sub TelaInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim loginCache As JObject = Await DadosLoginDoUsuario(EmailUsuario)
            Dim isAdmin As Boolean = loginCache("adm").ToObject(Of Boolean)()
            Dim dadosUsuario As JObject = Await ObterDadosUsuarioCache(EmailUsuario)

            EditarContasToolStripMenuItem.Visible = isAdmin
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub cadastrobtn_Click(sender As Object, e As EventArgs) Handles cadastrobtn.Click

        Dim novoForm As New Formulario()
        novoForm.Show()
        Me.Close()

    End Sub

    Private Async Sub montartreinobtn_Click(sender As Object, e As EventArgs) Handles montartreinobtn.Click
        Try
            Dim dadosCadastrados = Await VerificarDados(EmailUsuario)

            If dadosCadastrados Then
                Dim novoForm As New Gerenciador_Treinos
                novoForm.Show
                Close
            Else
                MsgBox("Por favor, cadastre seus dados antes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Preencha os dados!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao verificar dados do usuário: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Async Sub meustreinosbtn_Click(sender As Object, e As EventArgs) Handles meustreinosbtn.Click
        Try
            Dim dadosCadastrados As Boolean = Await VerificarDados(EmailUsuario)

            If dadosCadastrados Then
                Dim novoForm As New MeusTreinos()
                novoForm.Show()
                Me.Close()
            Else
                MsgBox("Por favor, cadastre seus dados antes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Preencha os dados!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao verificar dados do usuário: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CadastrarDadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarDadosToolStripMenuItem.Click
        Dim novoForm As New Formulario()
        novoForm.Show()
        Me.Close()
    End Sub

    Private Async Sub GerenciadorDeTreinosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciadorDeTreinosToolStripMenuItem.Click
        Try
            Dim dadosCadastrados As Boolean = Await VerificarDados(EmailUsuario)

            If dadosCadastrados Then
                Dim novoForm As New Gerenciador_Treinos()
                novoForm.Show()
                Me.Close()
            Else
                MsgBox("Por favor, cadastre seus dados antes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Preencha os dados!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao verificar dados do usuário: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Async Sub MeusTreinosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeusTreinosToolStripMenuItem.Click
        Try
            Dim dadosCadastrados As Boolean = Await VerificarDados(EmailUsuario)

            If dadosCadastrados Then
                Dim novoForm As New MeusTreinos()
                novoForm.Show()
                Me.Close()
            Else
                MsgBox("Por favor, cadastre seus dados antes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Preencha os dados!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao verificar dados do usuário: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub EditarSenharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarSenharToolStripMenuItem.Click
        Dim novoForm As New EditarSenha()
        novoForm.Show()
        Me.Close()
    End Sub

    Private Async Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Dim resposta As DialogResult = MessageBox.Show("Deseja encerrar a sessão?", "Sair do programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resposta = DialogResult.Yes Then
            Me.Close()
            Await LimparDadosCacheAsync(EmailUsuario)

            Dim form1 As New Login()
            form1.Show()
        End If
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim janelaSobre As New Sobre()
        janelaSobre.ShowDialog()
    End Sub

    Private Sub EditarContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarContasToolStripMenuItem.Click

    End Sub

    Private Async Sub avaliacaoBTN_Click(sender As Object, e As EventArgs) Handles avaliacaoBTN.Click
        Try
            Dim dadosCadastrados = Await VerificarDados(EmailUsuario)

            If dadosCadastrados Then
                Dim novoForm As New AvaliacaoUsuario()
                novoForm.Show()
                Me.Close()
            Else
                MsgBox("Por favor, cadastre seus dados antes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Preencha os dados!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao verificar dados do usuário: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try


    End Sub

    Private Async Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            Dim dadosCadastrados = Await VerificarDados(EmailUsuario)

            If dadosCadastrados Then
                Dim novoForm As New AvaliacaoUsuario()
                novoForm.Show()
                Me.Close()
            Else
                MsgBox("Por favor, cadastre seus dados antes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Preencha os dados!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao verificar dados do usuário: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Public Class RoundedGroupBox
        Inherits GroupBox

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Dim bounds As Rectangle = Me.ClientRectangle
            bounds.Height -= 1
            bounds.Width -= 1

            Dim radius As Integer = 15
            Dim path As New Drawing2D.GraphicsPath()
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90)
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90)
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90)
            path.CloseAllFigures()

            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            e.Graphics.DrawPath(Pens.Black, path)
        End Sub
    End Class

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Async Sub cardioBTN_Click(sender As Object, e As EventArgs) Handles cardioBTN.Click
        Try
            Dim dadosCadastrados = Await VerificarDados(EmailUsuario)

            If dadosCadastrados Then
                Dim novoForm As New MontarCardio()
                novoForm.Show()
                Me.Close()
            Else
                MsgBox("Por favor, cadastre seus dados antes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Preencha os dados!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao verificar dados do usuário: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Async Sub MontarCardioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MontarCardioToolStripMenuItem.Click
        Try
            Dim dadosCadastrados = Await VerificarDados(EmailUsuario)

            If dadosCadastrados Then
                Dim novoForm As New MontarCardio()
                novoForm.Show()
                Me.Close()
            Else
                MsgBox("Por favor, cadastre seus dados antes.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Preencha os dados!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao verificar dados do usuário: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

End Class