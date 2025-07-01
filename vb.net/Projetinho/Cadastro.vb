Imports System.Net.Security
Imports System.Windows
Imports ADODB
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json


Public Class Cadastro


    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SenhaCadastrar.Text <> ConfirmarSenhaCadastrar.Text Then
            MsgBox("As senhas não coincidem", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Return
        End If

        Dim cadastroData As New With {
        .login = EmailCadastrar.Text,
        .senha = SenhaCadastrar.Text
    }

        Dim json As String = JsonConvert.SerializeObject(cadastroData)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:8088/login/cadastro", content)

                If response.IsSuccessStatusCode Then
                    MsgBox("Conta criada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso!")
                    Dim novoForm As New Login() ' Supondo que "Login" é o nome do formulário de login
                    novoForm.Show()
                    Me.Hide()
                Else
                    Dim msgErro = Await response.Content.ReadAsStringAsync()
                    MsgBox("Erro ao cadastrar: " & msgErro, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Erro de conexão com o servidor: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim novoForm As New Formulario

        novoForm.Show()
        Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogin.LinkClicked
        Dim novoForm As New Login()
        novoForm.Show()
        Me.Hide()
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class