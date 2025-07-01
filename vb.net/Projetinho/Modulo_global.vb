Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports ADODB
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports System.Text
Imports Projetinho.montarTreino
Imports Projetinho.MontarCardio

Module Modulo_global
    Public diretorio, sql, resp, EmailUsuario, Musculo1, Musculo2, DataSelecionada, Treino1, Treino2, sexo, adm As String 'Declaração de variáveis públicas
    Public db As New ADODB.Connection 'Variável do Banco
    Public rs As New ADODB.Recordset 'Variável da Tabela
    Public cont, tipoTreino As Integer
    Public preenchido As Boolean
    Public Const baseUrl As String = "http://localhost:8088"

    Private ReadOnly client As New HttpClient()


    ' Função para consultar dados de cardio na API (cache)
    Public Async Function CardioDoUsuario(email As String) As Task(Of List(Of Cardio))
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:8088/")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim response = Await client.GetAsync($"cardio/cardioCache?email={email}")
            If response.IsSuccessStatusCode Then
                Dim jsonString = Await response.Content.ReadAsStringAsync()
                Return JsonConvert.DeserializeObject(Of List(Of Cardio))(jsonString)
            Else
                Return Nothing
            End If
        End Using
    End Function


    'Excluir um treino de cardio
    Public Async Function ExcluirCardio(Id As Long) As Task(Of Boolean)
        Try
            Using client As New HttpClient()
                client.BaseAddress = New Uri("http://localhost:8088/")
                Dim url As String = $"cardio/excluir?Id={Id}"

                Dim response = Await client.DeleteAsync(url)

                If response.IsSuccessStatusCode Then
                    Return True
                Else
                    Dim erro = Await response.Content.ReadAsStringAsync()
                    MsgBox("Erro ao excluir treino: " & erro, MsgBoxStyle.Critical)
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox("Erro na requisição: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    'salvar os cardio na api
    Public Async Function SalvarCardio(cardio As Object) As Task(Of Boolean)
        Try
            Dim url As String = $"{baseUrl}/cardio/salvar" ' Altere para o endereço correto da sua API

            Using client As New HttpClient()
                Dim json As String = JsonConvert.SerializeObject(cardio)
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

                If response.IsSuccessStatusCode Then
                    Return True
                Else
                    MessageBox.Show("Erro ao enviar treino: " & response.StatusCode.ToString())
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro de conexão: " & ex.Message)
            Return False
        End Try
    End Function



    'Chama os treino de cardio 
    Public Async Function CardiosDoUsuario(email As String) As Task(Of List(Of Cardio))
        Try
            Using client As New HttpClient()
                Dim url As String = $"{baseUrl}/cardio/cardio/{email}"
                Dim response = Await client.GetAsync(url)

                If response.IsSuccessStatusCode Then
                    Dim json = Await response.Content.ReadAsStringAsync()
                    Dim listaCardio = JsonConvert.DeserializeObject(Of List(Of Cardio))(json)
                    Return listaCardio
                Else
                    MsgBox("Erro ao buscar cardios: " & response.StatusCode.ToString(), MsgBoxStyle.Critical)
                    Return Nothing
                End If
            End Using
        Catch ex As Exception
            MsgBox("Erro na requisição dos cardios: " & ex.Message, MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function

    'apaga o treino
    Public Async Function ExcluirTreino(Id As Long) As Task(Of Boolean)
        Try
            Using client As New HttpClient()
                client.BaseAddress = New Uri("http://localhost:8088/")
                Dim url As String = $"treino/excluir?Id={Id}"

                Dim response = Await client.DeleteAsync(url)

                If response.IsSuccessStatusCode Then
                    Return True
                Else
                    Dim erro = Await response.Content.ReadAsStringAsync()
                    MsgBox("Erro ao excluir treino: " & erro, MsgBoxStyle.Critical)
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox("Erro na requisição: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function


    'Apaga o cache de treino
    Public Async Function LimparCacheTreino(email As String) As Task(Of Boolean)
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:8088/")
            Dim response = Await client.DeleteAsync($"treino/limparCache/{email}")
            Return response.IsSuccessStatusCode
        End Using
    End Function


    'Apaga o cache de cardio
    Public Async Function LimparCacheCardio(email As String) As Task(Of Boolean)
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:8088/")
            Dim response = Await client.DeleteAsync($"cardio/limparCache/{email}")
            Return response.IsSuccessStatusCode
        End Using
    End Function



    'Esse salva os dados em cache
    Public Async Function DadosLoginDoUsuario(email As String) As Task(Of JObject)
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:8088/")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim response = Await client.GetAsync($"login/{email}")
            If response.IsSuccessStatusCode Then
                Dim jsonString = Await response.Content.ReadAsStringAsync()
                Return JObject.Parse(jsonString)
            Else
                Return Nothing
            End If
        End Using
    End Function


    'Esse salva os treinos em cache
    Public Async Function TreinosDoUsuario(email As String) As Task(Of List(Of Treino))
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:8088/")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim response = Await client.GetAsync($"treino/treinosCache?email={email}")
            If response.IsSuccessStatusCode Then
                Dim jsonString = Await response.Content.ReadAsStringAsync()
                Return JsonConvert.DeserializeObject(Of List(Of Treino))(jsonString)
            Else
                Return Nothing
            End If
        End Using
    End Function







    'Envia os treinos baseado no tipo
    Public Async Function EnviarTreino(tipo As String, sexo As String) As Task
        Try
            Dim gruposMusculares As String() = {"Peito", "Costas", "Ombro", "Perna", "Bíceps", "Tríceps"}
            Dim dataBase As Date = Date.Now

            ' Ajusta para segunda-feira
            Do While dataBase.DayOfWeek <> DayOfWeek.Monday
                dataBase = dataBase.AddDays(1)
            Loop

            Dim exercicios As New Dictionary(Of String, List(Of String))

            If tipo = "iniciante" And sexo = "masculino" Then
                exercicios("Peito") = New List(Of String) From {"Supino Reto com Barra", "Crucifixo Reto"}
                exercicios("Costas") = New List(Of String) From {"Puxada na Frente", "Remada Baixa"}
                exercicios("Ombro") = New List(Of String) From {"Elevação Lateral", "Desenvolvimento com Halteres"}
                exercicios("Perna") = New List(Of String) From {"Agachamento Livre", "Cadeira Extensora"}
                exercicios("Bíceps") = New List(Of String) From {"Rosca Direta", "Rosca Martelo"}
                exercicios("Tríceps") = New List(Of String) From {"Tríceps Pulley", "Tríceps Testa"}

            ElseIf tipo = "iniciante" And sexo = "feminino" Then
                exercicios("Peito") = New List(Of String) From {"Flexão de Braço", "Crucifixo Reto"}
                exercicios("Costas") = New List(Of String) From {"Puxada Frente", "Remada Unilateral"}
                exercicios("Ombro") = New List(Of String) From {"Elevação Lateral", "Desenvolvimento com Halteres"}
                exercicios("Perna") = New List(Of String) From {"Agachamento Livre", "Glúteo na Máquina"}
                exercicios("Bíceps") = New List(Of String) From {"Rosca Direta", "Rosca Alternada"}
                exercicios("Tríceps") = New List(Of String) From {"Tríceps Pulley", "Tríceps Francês"}

            ElseIf tipo = "intermediario" And sexo = "masculino" Then
                exercicios("Peito") = New List(Of String) From {"Supino Reto com Barra", "Supino Inclinado com Halteres", "Crucifixo Inclinado"}
                exercicios("Costas") = New List(Of String) From {"Puxada na Frente", "Remada Curvada com Barra", "Pulldown"}
                exercicios("Ombro") = New List(Of String) From {"Desenvolvimento com Halteres", "Elevação Lateral", "Remada Alta"}
                exercicios("Perna") = New List(Of String) From {"Agachamento Livre", "Leg Press", "Cadeira Extensora", "Mesa Flexora"}
                exercicios("Bíceps") = New List(Of String) From {"Rosca Direta", "Rosca Alternada", "Rosca Concentrada"}
                exercicios("Tríceps") = New List(Of String) From {"Tríceps Pulley", "Tríceps Testa", "Mergulho no Banco"}

            ElseIf tipo = "intermediario" And sexo = "feminino" Then
                exercicios("Peito") = New List(Of String) From {"Crucifixo com Halteres", "Supino Inclinado com Halteres", "Flexão de Braço"}
                exercicios("Costas") = New List(Of String) From {"Remada Unilateral", "Puxada na Frente", "Pulldown com Pegada Aberta"}
                exercicios("Ombro") = New List(Of String) From {"Desenvolvimento com Halteres", "Elevação Lateral", "Crucifixo Inverso"}
                exercicios("Perna") = New List(Of String) From {"Agachamento com Barra", "Avanço com Halteres", "Glúteo na Máquina", "Cadeira Abdutora"}
                exercicios("Bíceps") = New List(Of String) From {"Rosca Alternada", "Rosca Martelo", "Rosca Concentrada"}
                exercicios("Tríceps") = New List(Of String) From {"Tríceps Francês", "Tríceps Pulley", "Tríceps Coice"}

            ElseIf tipo = "avancado" Then

                Exit Function

            Else
                Throw New Exception("Tipo ou sexo inválido")
            End If

            Dim listaTreinos As New List(Of Object)

            For i As Integer = 0 To 4 ' Segunda a sexta
                Dim grupo = gruposMusculares(i)
                Dim diaTreino As String = dataBase.AddDays(i).ToString("dd/MM/yyyy")

                For Each exercicio In exercicios(grupo)
                    Dim carga As Double = If(tipo = "iniciante", 10, 20)
                    Dim repeticoes As Integer = If(tipo = "iniciante", 12, 10)
                    Dim descanso As Double = If(tipo = "iniciante", 30, 45) ' em segundos

                    Dim treino As New With {
                    .email = EmailUsuario,
                    .musculo = grupo,
                    .exercicio = exercicio,
                    .carga = carga,
                    .repeticoes = repeticoes,
                    .descanso = descanso,
                    .data = diaTreino
                }

                    listaTreinos.Add(treino)
                Next
            Next

            Dim json = JsonConvert.SerializeObject(listaTreinos)
            Using client As New HttpClient()
                Dim content = New StringContent(json, Encoding.UTF8, "application/json")
                Dim response = Await client.PostAsync("http://localhost:8088/treino/salvarTipo", content)

                If response.IsSuccessStatusCode Then
                    MsgBox("Treino gerado com sucesso!", MsgBoxStyle.Information, "OK")
                Else
                    Dim msg = Await response.Content.ReadAsStringAsync()
                    MsgBox("Erro ao salvar treino: " & msg, MsgBoxStyle.Critical)
                End If
            End Using

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function


    'Atualiza a senha do usuario
    Public Async Function AtualizarSenha(email As String, senhaAtual As String, novaSenha As String) As Task(Of Boolean)
        Try
            Using httpClient As New HttpClient()
                Dim dados = New Dictionary(Of String, String) From {
                    {"email", email},
                    {"senhaAtual", senhaAtual},
                    {"novaSenha", novaSenha}
                }

                Dim json = JsonConvert.SerializeObject(dados)
                Dim content = New StringContent(json, Encoding.UTF8, "application/json")

                Dim response = Await httpClient.PostAsync("http://localhost:8088/login/alterarSenha", content)

                If response.IsSuccessStatusCode Then
                    Return True
                Else
                    Dim erro = Await response.Content.ReadAsStringAsync()
                    Throw New Exception(erro)
                End If
            End Using

        Catch ex As Exception
            Throw New Exception("Erro ao atualizar senha: " & ex.Message)
        End Try
    End Function

    'limpa os dados do cache
    Public Async Function LimparDadosCacheAsync(email As String) As Task

        Try
            Dim url As String = $"http://localhost:8088/usuario/dados/cache/apagar/{email}"


            Dim response As HttpResponseMessage = Await client.GetAsync(url)

            If response.IsSuccessStatusCode Then
                Console.WriteLine("Cache limpo com sucesso.")
            Else
                Console.WriteLine($"Erro ao limpar cache: {response.StatusCode}")
            End If

        Catch ex As Exception
            Console.WriteLine($"Erro de requisição: {ex.Message}")
        End Try
    End Function
    ' Função para consultar dados do usuário na API (cache)
    Public Async Function ObterDadosUsuarioCache(email As String) As Task(Of JObject)
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:8088/")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim response = Await client.GetAsync($"usuario/dados/cache/{email}")
            If response.IsSuccessStatusCode Then
                Dim jsonString = Await response.Content.ReadAsStringAsync()
                Return JObject.Parse(jsonString)
            Else
                Return Nothing ' Ou lance uma exceção se preferir
            End If
        End Using
    End Function

    'verifica se existem dados ou nao (devolve false ou true apenas)
    Public Async Function VerificarDados(email As String) As Task(Of Boolean)
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:8088/")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim response = Await client.GetAsync($"usuario/dados/cache/{email}")
            Return response.IsSuccessStatusCode
        End Using
    End Function







End Module
