Imports System.Net.Http
Imports ADODB
Imports Newtonsoft.Json
Imports System.Net.Http.Headers
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class Formulario
    Private Async Sub Formulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim dadosUsuario As JObject = Await ObterDadosUsuarioCache(EmailUsuario)

            If dadosUsuario IsNot Nothing AndAlso dadosUsuario.HasValues Then
                preenchido = True

                NomePerfil.Text = dadosUsuario("nome")?.ToString()
                SexoPerfil.Text = dadosUsuario("sexo")?.ToString()
                DateTimePerfil.Value = Convert.ToDateTime(dadosUsuario("dataNasc")?.ToString())
                AlturaPerfil.Text = dadosUsuario("altura")?.ToString()
                PesoPerfil.Text = dadosUsuario("peso")?.ToString()

                Dim caminhoImagem As String = dadosUsuario("imagem")?.ToString()
                If Not String.IsNullOrEmpty(caminhoImagem) Then
                    img_foto.Load(caminhoImagem)
                End If

                ' Desabilita os campos se já preenchido
                img_foto.Enabled = False
                NomePerfil.Enabled = False
                SexoPerfil.Enabled = False
                DateTimePerfil.Enabled = False
                AlturaPerfil.Enabled = False
                PesoPerfil.Enabled = False
                Button2.Enabled = False
            End If

        Catch ex As Exception
            MsgBox("Erro ao carregar dados: " & ex.Message)
        End Try

    End Sub


    Public Async Function EnviarDadosUsuario() As Task
        Dim httpClient As New HttpClient()

        Dim dados = New Dictionary(Of String, Object) From {
        {"email", EmailUsuario},
        {"nome", NomePerfil.Text},
        {"sexo", SexoPerfil.Text},
        {"dataNasc", DateTimePerfil.Value.ToString("yyyy-MM-dd")},
        {"altura", Convert.ToDouble(AlturaPerfil.Text.Replace(",", "."))},
        {"peso", Convert.ToDouble(PesoPerfil.Text.Replace(",", "."))},
        {"imagem", diretorio}
    }

        Dim json = JsonConvert.SerializeObject(dados)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Dim response = Await httpClient.PostAsync("http://localhost:8088/usuario/salvar", content)

        If response.IsSuccessStatusCode Then
            MessageBox.Show("Dados enviados com sucesso!")
        Else
            MessageBox.Show("Erro ao enviar dados: " & response.StatusCode.ToString())
        End If
    End Function


    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Aqui você pode validar ou preparar os dados antes, se quiser

            Await EnviarDadosUsuario() ' chama sua função

            ' Desabilita os controles após sucesso
            img_foto.Enabled = False
            NomePerfil.Enabled = False
            SexoPerfil.Enabled = False
            DateTimePerfil.Enabled = False
            AlturaPerfil.Enabled = False
            PesoPerfil.Enabled = False
            Button2.Enabled = False



        Catch ex As Exception

        End Try
    End Sub


    Private Sub AlturaPerfil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AlturaPerfil.KeyPress
        ' Permite apenas números, vírgula, ponto e Backspace
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If

        ' Evita digitar mais de um ponto ou vírgula
        If (e.KeyChar = "." OrElse e.KeyChar = ",") AndAlso CType(sender, TextBox).Text.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PesoPerfil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PesoPerfil.KeyPress
        ' Permite apenas números, vírgula, ponto e Backspace
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If

        ' Evita digitar mais de um ponto ou vírgula
        If (e.KeyChar = "." OrElse e.KeyChar = ",") AndAlso CType(sender, TextBox).Text.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        If OpenFileDialog1 Is Nothing Then
            OpenFileDialog1 = New OpenFileDialog()
        End If
        With OpenFileDialog1
            .Title = "Selecione uma foto"
            .InitialDirectory = Application.StartupPath & "\fotos\"
            .Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp"
            .Multiselect = False
            .ShowDialog()
            diretorio = .FileName
            If System.IO.File.Exists(diretorio) Then
                img_foto.Load(diretorio)
            Else
                MsgBox("Arquivo não encontrado.", MsgBoxStyle.Exclamation)
            End If

        End With
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        img_foto.Enabled = True
        NomePerfil.Enabled = True
        SexoPerfil.Enabled = True
        DateTimePerfil.Enabled = True
        AlturaPerfil.Enabled = True
        PesoPerfil.Enabled = True
        Button2.Enabled = True

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim novoform As New TelaInicial()
        novoform.show()
        Me.Close()
    End Sub


End Class