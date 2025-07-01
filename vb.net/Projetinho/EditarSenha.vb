Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Public Class EditarSenha
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles btnatualizar.Click
        Try
            Dim sucesso As Boolean = Await AtualizarSenha(EmailRecuperar.Text, SenhaAntigaRecuperar.Text, NovaSenhaRecuperar.Text)
            If sucesso Then
                MsgBox("Senha Atualizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
                'Apagar Cache para verificação
                Await LimparDadosCacheAsync(EmailUsuario)
                Dim novoForm As New Login()
                novoForm.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim novoForm As New TelaInicial()
        novoForm.Show()
        Me.Close()
    End Sub
End Class