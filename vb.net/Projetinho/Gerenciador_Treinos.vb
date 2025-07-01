Imports ADODB
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text




Public Class Gerenciador_Treinos


    Private Async Sub Gerenciado_Treinos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dadosUsuario As JObject = Await ObterDadosUsuarioCache(EmailUsuario)

            If dadosUsuario IsNot Nothing AndAlso dadosUsuario.HasValues Then
                Dim sexoUsuario As String = dadosUsuario("sexo")?.ToString()?.Trim().ToLower()

                If sexoUsuario = "masculino" Then
                    avancadoM.Visible = False
                    inicianteM.Visible = False
                    intermediarioM.Visible = False
                Else
                    avancadoH.Visible = False
                    inicianteH.Visible = False
                    intermediarioH.Visible = False
                End If
            Else
                MsgBox("Não foi possível obter os dados do usuário.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("Erro ao carregar dados do usuário: " & ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub


    Private Async Sub btnTipoTreino_Click(sender As Object, e As EventArgs) Handles btnTipoTreino.Click
        Try
            DataSelecionada = DataTreino.Value.ToShortDateString

            Dim tipo As String = ""
            If inicianteCheck.Checked Then
                tipo = "iniciante"
            ElseIf intermediarioCheck.Checked Then
                tipo = "intermediario"
            ElseIf avancadoCheck.Checked Then
                tipo = "avancado"
            Else
                MessageBox.Show("Selecione uma opção de treino.")
                Exit Sub
            End If

            ' Obtém sexo do usuário via cache
            Dim dadosUsuario As JObject = Await ObterDadosUsuarioCache(EmailUsuario)
            Dim sexoUsuario As String = dadosUsuario("sexo")?.ToString()?.Trim().ToLower()

            ' Chama a função que envia os treinos para a API
            Await EnviarTreino(tipo, sexoUsuario)

            ' Após gerar, abre a próxima tela se quiser
            Dim novoForm As New montarTreino()
            novoForm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao montar o treino: " & ex.Message)
        End Try
    End Sub


    Private Sub inicianteCheck_CheckedChanged(sender As Object, e As EventArgs) Handles inicianteCheck.CheckedChanged
        If inicianteCheck.Checked Then
            intermediarioCheck.Checked = False
            avancadoCheck.Checked = False
        End If


    End Sub

    Private Sub intermediarioCheck_CheckedChanged(sender As Object, e As EventArgs) Handles intermediarioCheck.CheckedChanged
        If intermediarioCheck.Checked Then
            inicianteCheck.Checked = False
            avancadoCheck.Checked = False
        End If

    End Sub

    Private Sub avancadoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles avancadoCheck.CheckedChanged
        If avancadoCheck.Checked Then
            intermediarioCheck.Checked = False
            inicianteCheck.Checked = False
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim novoForm As New TelaInicial()
        novoForm.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataTreino.MinDate = Date.Today
    End Sub

    Private Sub DataTreino_ValueChanged(sender As Object, e As EventArgs) Handles DataTreino.ValueChanged

    End Sub
End Class