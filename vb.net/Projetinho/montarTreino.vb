Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports ADODB
Imports Newtonsoft.Json

Public Class montarTreino
    Private Async Sub Treino1Load()
        Try
            DGV_Treino1.Rows.Clear()

            ' Aguarda e obtém a lista de treinos do usuário
            Dim treinos As List(Of Treino) = Await TreinosDoUsuario(EmailUsuario)

            If treinos IsNot Nothing Then
                For Each treino In treinos
                    DGV_Treino1.Rows.Add(
                    treino.Id,
                    treino.Musculo,
                    treino.Exercicio,
                    treino.Carga,
                    treino.Repeticoes,
                    treino.Descanso,
                    treino.Data,
                    "🗑️"
                )
                Next
            Else
                MsgBox("Nenhum treino retornado ou erro ao buscar os dados.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("Erro ao carregar os dados: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub



    ' Defina a classe Treino para desserialização:
    Public Class Treino
        Public Property Id As Long
        Public Property Email As String
        Public Property Musculo As String
        Public Property Exercicio As String
        Public Property Carga As Double
        Public Property Repeticoes As Integer
        Public Property Descanso As Double
        Public Property Data As String
    End Class



    Private Async Sub MontarTreino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            DataTreino.Format = DateTimePickerFormat.Custom
            DataTreino.CustomFormat = "dd/MM/yyyy"
            TabControl1.TabPages(0).Text = "Treino "
            musculoOpc1.SelectedItem = Musculo1

            With DGV_Treino1
                .Rows.Clear()

                If .Columns.Count = 0 Then
                    With .Columns
                        .Add("Codigo", "Codigo")
                        .Add("Musculo", "Músculo")
                        .Add("Exercicio", "Exercício")
                        .Add("Repeticoes", "Repetições")
                        .Add("Carga", "Carga")
                        .Add("Descanso", "Descanso")
                        .Add("Data", "Data")
                        .Add("Excluir", "Excluir")

                        .Item("Codigo").Visible = False

                    End With
                End If

                .DefaultCellStyle.ForeColor = Color.Black
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .RowHeadersVisible = False
                .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .RowTemplate.Height = 30
            End With



            Await LimparCacheTreino(EmailUsuario)
            Treino1Load()

        Catch ex As Exception
            MsgBox("Erro ao carregar treino: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub



    Private Function BuscarExercicioAleatorio(musculo As String, tipo As String, sexo As String) As String
        Dim listaExercicios As New List(Of String)

        ' Aqui você pode refinar os exercícios por sexo/tipo se quiser
        Select Case musculo
            Case "Peito"
                listaExercicios.AddRange({"Supino Reto com Barra", "Supino Inclinado com Halteres", "Crucifixo Reto"})
            Case "Costas"
                listaExercicios.AddRange({"Puxada na Frente com Pegada Aberta", "Remada Curvada com Barra", "Remada Unilateral com Halter"})
            Case "Ombro"
                listaExercicios.AddRange({"Desenvolvimento com Halteres", "Elevação Lateral com Halteres", "Remada Alta com Barra"})
            Case "Perna"
                listaExercicios.AddRange({"Agachamento Livre", "Leg Press 45°", "Cadeira Extensora"})
            Case "Biceps"
                listaExercicios.AddRange({"Rosca Direta com Barra", "Rosca Alternada", "Rosca Martelo"})
            Case "Triceps"
                listaExercicios.AddRange({"Tríceps Corda", "Tríceps Testa com Barra W", "Tríceps Banco"})
        End Select

        Dim rand As New Random()
        Return listaExercicios(rand.Next(listaExercicios.Count))
    End Function



    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles musculoOpc1.SelectedIndexChanged
        ' Evita erro se nada estiver selecionado
        If musculoOpc1.SelectedItem Is Nothing Then
            Exit Sub
        End If

        ExOpc1.Items.Clear()

        Select Case musculoOpc1.SelectedItem.ToString()
            Case "Peito"
                ExOpc1.Items.AddRange(New String() {
                "Supino Reto com Barra",
                "Supino Inclinado com Barra",
                "Supino Declinado com Barra",
                "Supino Reto com Halteres",
                "Supino Inclinado com Halteres",
                "Supino Declinado com Halteres",
                "Crucifixo Reto",
                "Crucifixo Inclinado",
                "Crucifixo Declinado",
                "Cross Over Alto",
                "Cross Over Médio",
                "Cross Over Baixo",
                "Peck Deck",
                "Flexão de Braço Tradicional",
                "Flexão de Braço com Pés Elevados",
                "Pullover com Halter",
                "Pressão na Máquina",
                "Flexão com Pegada Aberta",
                "Flexão com Pegada Fechada",
                "Flexão Explosiva"
            })

            Case "Costas"
                ExOpc1.Items.AddRange(New String() {
                "Puxada na Frente com Pegada Aberta",
                "Puxada na Frente com Pegada Fechada",
                "Puxada Atrás da Nuca",
                "Remada Curvada com Barra",
                "Remada Curvada com Pegada Invertida",
                "Remada Unilateral com Halter",
                "Remada Baixa na Polia",
                "Remada Máquina Hammer",
                "Levantamento Terra",
                "Remada Cavalinho",
                "Barra Fixa Pronada",
                "Barra Fixa Supinada",
                "Barra Fixa com Peso",
                "Remada Serrote",
                "Pull Down na Polia Alta",
                "Pull Over com Halter",
                "Encolhimento para Trapézio",
                "Good Morning com Barra",
                "Deadlift com Pegada Sumô",
                "Remada Alta com Corda"
            })

            Case "Ombro"
                ExOpc1.Items.AddRange(New String() {
                "Desenvolvimento com Halteres",
                "Desenvolvimento com Barra",
                "Desenvolvimento na Máquina",
                "Desenvolvimento Arnold",
                "Elevação Lateral com Halteres",
                "Elevação Lateral na Polia",
                "Elevação Frontal com Halteres",
                "Elevação Frontal na Polia",
                "Remada Alta com Barra",
                "Remada Alta com Corda",
                "Crucifixo Inverso com Halteres",
                "Crucifixo Inverso na Máquina",
                "Crucifixo Inverso na Polia",
                "Encolhimento com Halteres",
                "Encolhimento na Barra",
                "Encolhimento na Máquina",
                "Desenvolvimento Militar",
                "Desenvolvimento com Pegada Fechada",
                "Rotação Externa com Halteres",
                "Rotação Interna com Halteres"
            })

            Case "Perna"
                ExOpc1.Items.AddRange(New String() {
                "Agachamento Livre",
                "Agachamento no Smith",
                "Agachamento Hack",
                "Afundo com Halteres",
                "Afundo no Smith",
                "Cadeira Extensora",
                "Mesa Flexora",
                "Leg Press 45°",
                "Leg Press Horizontal",
                "Stiff com Halteres",
                "Stiff com Barra",
                "Passada no Step",
                "Agachamento Búlgaro",
                "Sumô com Halteres",
                "Glúteo no Cabo",
                "Glúteo na Máquina",
                "Panturrilha Sentado",
                "Panturrilha em Pé",
                "Panturrilha no Leg Press",
                "Elevação de Quadril com Barra"
            })

            Case "Triceps"
                ExOpc1.Items.AddRange(New String() {
                "Tríceps Corda",
                "Tríceps Pulley com Barra",
                "Tríceps Pulley Inverso",
                "Tríceps Testa com Barra W",
                "Tríceps Testa com Halteres",
                "Tríceps Banco",
                "Tríceps Francês com Halter",
                "Tríceps Francês com Barra",
                "Tríceps Coice com Halteres",
                "Tríceps Paralela",
                "Mergulho entre Bancos",
                "Kickback no Cabo",
                "Pulley Unilateral",
                "Tríceps Máquina",
                "Tríceps na Polia Alta",
                "Tríceps no Smith Invertido",
                "Pressão de Tríceps com Pegada Invertida",
                "Tríceps deitado com Corda",
                "Tríceps 21s",
                "Pressão de Tríceps com Pegada Martelo"
            })

            Case "Biceps"
                ExOpc1.Items.AddRange(New String() {
                "Rosca Direta com Barra",
                "Rosca Direta com Halteres",
                "Rosca Alternada",
                "Rosca Martelo",
                "Rosca Concentrada",
                "Rosca Scott com Barra",
                "Rosca Scott com Halteres",
                "Rosca Inversa com Barra",
                "Rosca Inversa na Polia",
                "Rosca no Cabo com Barra",
                "Rosca 21s",
                "Rosca no Banco Inclinado",
                "Rosca Simultânea",
                "Rosca no Cabo com Corda",
                "Rosca Martelo Alternada",
                "Rosca com Pegada Supinada",
                "Rosca Máquina",
                "Rosca com Pegada Fechada",
                "Rosca com Pegada Aberta",
                "Rosca Spider"
            })
        End Select
    End Sub


    Public Class NovoTreino
        Public Property email As String
        Public Property musculo As String
        Public Property exercicio As String
        Public Property carga As Double
        Public Property repeticoes As Integer
        Public Property descanso As Double
        Public Property data As String
    End Class

    Private Async Sub BtnTreino1_Click(sender As Object, e As EventArgs) Handles BtnTreino1.Click
        ' Verificação se todos os campos estão selecionados
        If musculoOpc1.SelectedItem Is Nothing OrElse
       ExOpc1.SelectedItem Is Nothing OrElse
       CargaOpc1.SelectedItem Is Nothing OrElse
       RepOpc1.SelectedItem Is Nothing OrElse
       TempoOpc1.SelectedItem Is Nothing Then

            MsgBox("Por favor, preencha todos os campos antes de salvar o treino.", MsgBoxStyle.Exclamation, "Campos obrigatórios")
            Exit Sub
        End If

        Try
            ' Cria objeto Treino com os dados do formulário
            Dim treino As New NovoTreino With {
            .email = EmailUsuario,
            .musculo = musculoOpc1.SelectedItem.ToString(),
            .exercicio = ExOpc1.SelectedItem.ToString(),
            .carga = Convert.ToDouble(CargaOpc1.SelectedItem),
            .repeticoes = Convert.ToInt32(RepOpc1.SelectedItem),
            .descanso = Convert.ToDouble(TempoOpc1.SelectedItem),
            .data = DataTreino.Value.ToString("dd/MM/yyyy")
        }

            ' Coloca em uma lista porque o endpoint espera uma lista de treinos
            Dim listaTreinos As New List(Of NovoTreino) From {treino}

            ' Serializa e envia
            Dim json = JsonConvert.SerializeObject(listaTreinos)
            Using client As New HttpClient()
                client.BaseAddress = New Uri("http://localhost:8088/")
                client.DefaultRequestHeaders.Accept.Clear()
                client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                Dim content = New StringContent(json, Encoding.UTF8, "application/json")
                Dim response = Await client.PostAsync("treino/salvarTreino", content)

                If response.IsSuccessStatusCode Then
                    MsgBox("Treino salvo com sucesso!", MsgBoxStyle.Information, "Confirmação")
                    Await LimparCacheTreino(EmailUsuario)
                    Treino1Load() ' Atualiza a grid após salvar
                    LimparCampos()
                Else
                    Dim erro = Await response.Content.ReadAsStringAsync()
                    MsgBox("Erro ao salvar treino: " & erro, MsgBoxStyle.Critical)
                End If
            End Using

        Catch ex As Exception
            MsgBox("Erro ao salvar treino: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub



    Private Async Sub DGV_Treino1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Treino1.CellContentClick
        If e.ColumnIndex = DGV_Treino1.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            If MsgBox("Deseja realmente excluir este treino?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmação") = MsgBoxResult.Yes Then
                Try
                    Dim Id As Long = DGV_Treino1.Rows(e.RowIndex).Cells(0).Value

                    Dim sucesso As Boolean = Await ExcluirTreino(Id)

                    If sucesso Then
                        Await LimparCacheTreino(EmailUsuario)
                        Treino1Load()
                        MsgBox("Treino excluído com sucesso!", MsgBoxStyle.Information, "Removido")
                    End If

                Catch ex As Exception
                    MsgBox("Erro ao excluir treino: " & ex.Message, MsgBoxStyle.Critical, "Erro")
                End Try
            End If
        End If
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim novoForm As New TelaInicial()
        novoForm.Show()
        Me.Close()
    End Sub

    Private Sub CargaOpc1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CargaOpc1.SelectedIndexChanged

    End Sub

    Private Sub ExOpc1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExOpc1.SelectedIndexChanged

    End Sub

    Private Sub RepOpc1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RepOpc1.SelectedIndexChanged

    End Sub
    Private Sub LimparCampos()
        musculoOpc1.SelectedIndex = -1
        ExOpc1.SelectedItem = -1
        ExOpc1.SelectedIndex = -1
        CargaOpc1.SelectedIndex = -1
        RepOpc1.SelectedIndex = -1
        TempoOpc1.SelectedIndex = -1
        DataTreino.Value = DateTime.Today

    End Sub

End Class