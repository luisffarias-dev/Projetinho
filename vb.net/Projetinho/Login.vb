Imports ADODB
Imports System.Net.Http
Imports System.Text
Imports System.Text.Json
Imports Newtonsoft.Json
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = EmailLoginBox.Text
        Dim senha As String = SenhaLoginBox.Text

        Dim loginData As New With {
        .login = email,
        .senha = senha
    }

        Dim json As String = JsonConvert.SerializeObject(loginData)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:8088/login/login", content)

                If response.IsSuccessStatusCode Then
                    Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                    Dim usuario = JsonConvert.DeserializeObject(Of LoginResponse)(responseBody)

                    If usuario.status = True Then
                        MsgBox("Usuário bloqueado! Por favor, entre em contato com o administrador do sistema.",
                           MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Usuário Bloqueado")
                        Return
                    End If

                    MsgBox("Login efetuado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Login")
                    EmailUsuario = email

                    If usuario.adm = True Then
                        Dim novoForm As New TelaAdmin
                        novoForm.Show()
                    Else
                        Dim novoForm As New TelaInicial
                        novoForm.Show()
                    End If

                    Hide()
                    EmailLoginBox.Clear()
                    SenhaLoginBox.Clear()
                ElseIf response.StatusCode = Net.HttpStatusCode.NotFound Then
                    MsgBox("Usuário não encontrado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
                ElseIf response.StatusCode = Net.HttpStatusCode.Unauthorized Then
                    MsgBox("Senha incorreta.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
                ElseIf response.StatusCode = Net.HttpStatusCode.Forbidden Then
                    MsgBox("Usuário bloqueado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
                Else
                    MsgBox("Erro desconhecido. Código: " & response.StatusCode, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Erro ao conectar à API: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Public Class LoginResponse
        Public Property login As String
        Public Property senha As String
        Public Property status As Boolean
        Public Property adm As Boolean
    End Class


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkCadastrar.LinkClicked
        Try
            Dim novoForm As New Cadastro()
            novoForm.Show()
            Me.Hide()
            EmailLoginBox.Clear()
            SenhaLoginBox.Clear()
        Catch ex As Exception
            MsgBox("Tente novamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim resposta As DialogResult = MessageBox.Show("Deseja sair do Projetinho?", "Sair do programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resposta = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
