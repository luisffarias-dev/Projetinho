Imports System.Data.SqlClient
Imports ADODB
Imports Newtonsoft.Json.Linq

Public Class Recomendacoes

    ' Propriedade pública para receber o email do usuário
    Public Property EmailUsuario As String



    Private Sub Recomendacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(EmailUsuario) Then
            MessageBox.Show("Email do usuário não informado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        CarregarDadosUsuario()
    End Sub

    Private Async Sub CarregarDadosUsuario()
        Try
            Dim dadosUsuario As JObject = Await ObterDadosUsuarioCache(EmailUsuario)



            If dadosUsuario IsNot Nothing AndAlso dadosUsuario.HasValues Then
                Dim nomeCompleto As String = dadosUsuario("nome")?.ToString()
                Dim sexoUsuario As String = dadosUsuario("sexo")?.ToString().ToLower()
                Dim dataNasc As Date = DateTime.Parse(dadosUsuario("dataNasc")?.ToString())
                Dim alturaCm As Double = Convert.ToDouble(dadosUsuario("altura"))
                Dim pesoKg As Double = Convert.ToDouble(dadosUsuario("peso"))

                ' Cálculo da idade
                Dim idade As Integer = DateTime.Now.Year - dataNasc.Year
                If (dataNasc > DateTime.Now.AddYears(-idade)) Then
                    idade -= 1
                End If

                ' Preencher Labels
                lblNome.Text = nomeCompleto
                lblGenero.Text = sexoUsuario
                lbl_idade.Text = idade.ToString() & " anos"
                lblPeso.Text = pesoKg.ToString("F1") & " Kg"
                lblAltura.Text = (alturaCm / 100).ToString("F2") & " m"

                ' Calcular indicadores e preencher recomendações
                Dim imc As Double = CalcularIMC(pesoKg, alturaCm)
                Dim faixaImc As String = ObterFaixaIMC(imc)
                PreencherRecomendacoes(imc, faixaImc, idade, pesoKg, sexo)


            Else

                MessageBox.Show("Usuário não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados do usuário: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    ' Calcula IMC
    Private Function CalcularIMC(peso As Double, alturaCm As Double) As Double
        Dim alturaM As Double = alturaCm / 100
        If alturaM <= 0 Then Return 0
        Return peso / (alturaM * alturaM)
    End Function

    ' Retorna faixa IMC conforme valor
    Private Function ObterFaixaIMC(imc As Double) As String
        If imc < 18.5 Then Return "abaixo do peso"
        If imc < 24.9 Then Return "peso normal"
        If imc < 29.9 Then Return "sobrepeso"
        Return "obesidade"
    End Function

    ' Preenche o RichTextBox com recomendações detalhadas
    Public Sub PreencherRecomendacoes(imc As Double, faixaImc As String, idade As Integer, peso As Double, sexo As String)
        Dim texto As New System.Text.StringBuilder()

        texto.AppendLine(" --- Recomendações Personalizadas para seu Perfil --- ")
        texto.AppendLine()
        texto.AppendLine($"Seu IMC é {imc:F2} ({faixaImc}), idade: {idade} anos, sexo: {sexo}")
        texto.AppendLine()

        ' Recomendação geral para todas faixas
        texto.AppendLine("IMPORTANTE: Sempre consulte um profissional de saúde antes de iniciar qualquer programa intenso de exercícios ou dieta.")
        texto.AppendLine()

        Select Case faixaImc.ToLower()
            Case "abaixo do peso"
                texto.AppendLine("--- Perfil: Abaixo do Peso ---")
                texto.AppendLine()
                texto.AppendLine("- Objetivo: Ganho saudável de massa muscular e peso.")
                texto.AppendLine()
                texto.AppendLine("- Exercícios:")
                texto.AppendLine("    • Priorize exercícios de força para estimular o crescimento muscular.")
                texto.AppendLine("    • Sessões 3-4 vezes por semana, com foco em carga progressiva.")
                texto.AppendLine("    • Cardio moderado, evitando gasto calórico excessivo.")
                texto.AppendLine()
                texto.AppendLine("- Alimentação:")
                texto.AppendLine("    • Calorias acima do seu gasto total (superávit calórico).")
                texto.AppendLine("    • Proteína adequada: aproximadamente 1.8 a 2.2 g por kg de peso corporal.")
                texto.AppendLine("    • Inclua carboidratos complexos em cada refeição (arroz integral, batata doce, aveia).")
                texto.AppendLine("    • Gorduras saudáveis: abacate, azeite, oleaginosas.")
                texto.AppendLine("    • Faça de 5 a 6 refeições diárias para facilitar aporte calórico.")
                texto.AppendLine("    • Hidratação essencial: pelo menos 2 litros de água por dia.")
                texto.AppendLine()
                texto.AppendLine("- Dicas de refeições:")
                texto.AppendLine("    • Café da manhã: Omelete com espinafre, pão integral e frutas.")
                texto.AppendLine("    • Lanches intermediários: Iogurte natural com granola ou castanhas.")
                texto.AppendLine("    • Almoço/jantar: Frango grelhado, arroz integral, legumes variados.")
                texto.AppendLine("    • Ceia: Vitamina de banana com leite e aveia.")
                texto.AppendLine()

            Case "peso normal"
                texto.AppendLine("--- Perfil: Peso Normal ---")
                texto.AppendLine()
                texto.AppendLine("- Objetivo: Manutenção da composição corporal e saúde geral.")
                texto.AppendLine()
                texto.AppendLine("- Exercícios:")
                texto.AppendLine("    • Combinação equilibrada de treino de força e cardio.")
                texto.AppendLine("    • Força: 2-3 vezes por semana para preservar massa magra.")
                texto.AppendLine("    • Cardio: 3-4 sessões semanais, intensidade moderada a alta.")
                texto.AppendLine()
                texto.AppendLine("- Alimentação:")
                texto.AppendLine("    • Manter equilíbrio energético (calorias próximas do gasto total).")
                texto.AppendLine("    • Proteína: 1.2 a 1.6 g/kg para manutenção muscular.")
                texto.AppendLine("    • Priorize alimentos integrais e minimamente processados.")
                texto.AppendLine("    • Consuma frutas, verduras e legumes diariamente para fibras e micronutrientes.")
                texto.AppendLine("    • Hidrate-se bem.")
                texto.AppendLine()
                texto.AppendLine("- Dicas de refeições:")
                texto.AppendLine("    • Varie fontes de proteína: carnes magras, peixe, ovos, leguminosas.")
                texto.AppendLine("    • Include carboidratos complexos (quinoa, batata doce, legumes).")
                texto.AppendLine("    • Use azeite de oliva e oleaginosas para gorduras boas.")
                texto.AppendLine("    • Evite excesso de açúcares simples e alimentos ultra processados.")
                texto.AppendLine()

            Case "sobrepeso"
                texto.AppendLine("--- Perfil: Sobrepeso ---")
                texto.AppendLine()
                texto.AppendLine("- Objetivo: Redução de gordura corporal sem perda significativa de massa magra.")
                texto.AppendLine()
                texto.AppendLine("- Exercícios:")
                texto.AppendLine("    • Cardio aeróbico: Inicie com 4-5 vezes por semana 30-45 minutos (caminhada, bicicleta).")
                texto.AppendLine("    • Treino de força: 3 vezes por semana para preservar massa magra.")
                texto.AppendLine("    • Exercícios funcionais podem ajudar na coordenação e queima calórica.")
                texto.AppendLine()
                texto.AppendLine("- Alimentação:")
                texto.AppendLine("    • Déficit calórico controlado (reduzir 10-20% da necessidade diária).")
                texto.AppendLine("    • Proteína aumentada: 1.6 a 2 g/kg para preservar músculos.")
                texto.AppendLine("    • Carboidratos priorize complexos com baixo índice glicêmico.")
                texto.AppendLine("    • Consuma muita fibra (frutas, verduras, legumes).")
                texto.AppendLine("    • Evite gorduras saturadas em excesso e alimentos processados.")
                texto.AppendLine()
                texto.AppendLine("- Dicas de refeições:")
                texto.AppendLine("    • Café da manhã: Smoothie verde com proteína em pó, espinafre, banana e chia.")
                texto.AppendLine("    • Lanches: Castanhas, frutas frescas ou vegetais com homus.")
                texto.AppendLine("    • Almoço/jantar: Peixe grelhado, salada colorida, quinoa ou arroz integral.")
                texto.AppendLine("    • Evite frituras e bebidas açucaradas.")
                texto.AppendLine()

            Case "obesidade"
                texto.AppendLine("--- Perfil: Obeso ---")
                texto.AppendLine()
                texto.AppendLine("- Objetivo: Perda significativa de gordura para melhora da saúde e qualidade de vida.")
                texto.AppendLine()
                texto.AppendLine("- Exercícios:")
                texto.AppendLine("    • Comece com atividades de baixo impacto: caminhada, hidroginástica.")
                texto.AppendLine("    • Treino de força gradual para evitar perda muscular.")
                texto.AppendLine("    • Aumente progressivamente intensidade e duração das sessões.")
                texto.AppendLine()
                texto.AppendLine("- Alimentação:")
                texto.AppendLine("    • Déficit calórico rigoroso, mas sustentável e equilibrado.")
                texto.AppendLine("    • Proteína alta para preservar massa magra (até 2 g/kg).")
                texto.AppendLine("    • Reduza ao máximo açúcares e carboidratos simples.")
                texto.AppendLine("    • Priorize alimentos integrais e naturais.")
                texto.AppendLine("    • Consuma muitas fibras para melhorar saciedade e metabolismo.")
                texto.AppendLine()
                texto.AppendLine("- Dicas de refeições:")
                texto.AppendLine("    • Divida as refeições em 5-6 porções menores ao longo do dia.")
                texto.AppendLine("    • Evite refrigerantes e fast food.")
                texto.AppendLine("    • Prefira grelhados, cozidos e assados.")
                texto.AppendLine("    • Consulte profissional (nutricionista e/ou endocrinologista) para suplementação caso sinta necessidade.")
                texto.AppendLine()

            Case Else
                texto.AppendLine("Perfil não identificado. Recomendamos consultar um especialista para avaliação personalizada.")
        End Select

        texto.AppendLine("--- Dicas Gerais de Alimentação ---")
        texto.AppendLine("- Hidrate-se continuamente ao longo do dia.")
        texto.AppendLine("- Inclua fontes variadas de vegetais, frutas e grãos integrais.")
        texto.AppendLine("- Modere o consumo de sal e evite alimentos ultraprocessados.")
        texto.AppendLine("- Prefira cozinhar seus alimentos para evitar aditivos químicos.")
        texto.AppendLine("- Controle o tamanho das porções para evitar exageros.")
        texto.AppendLine()

        texto.AppendLine("--- Exemplos de Distribuição de Refeições Diárias ---")
        texto.AppendLine("• Café da manhã: fonte proteica + carboidrato complexo + gordura saudável + frutas.")
        texto.AppendLine("• Lanche da manhã: frutas, oleaginosas ou iogurte natural.")
        texto.AppendLine("• Almoço: proteína magra + carboidrato integral + salada colorida + legumes.")
        texto.AppendLine("• Lanche da tarde: similar ao lanche da manhã.")
        texto.AppendLine("• Jantar: semelhante ao almoço, porém com comidas mais leves.")
        texto.AppendLine("• Ceia (opcional): fonte proteica leve (ex.: queijo branco, ovos).")
        texto.AppendLine()

        texto.AppendLine("--- Cuidados importantes ---")
        texto.AppendLine("- Evite dietas restritivas sem acompanhamento profissional.")
        texto.AppendLine("- Combine alimentação saudável com atividade física regular.")
        texto.AppendLine("- Priorize sono de qualidade para melhor recuperação.")
        texto.AppendLine("- Monitore seus progressos, ajustando planos conforme necessário.")
        texto.AppendLine()

        texto.AppendLine("--- Exercícios recomendados ---")
        texto.AppendLine("- Aumente gradualmente a intensidade e duração dos exercícios.")
        texto.AppendLine("- Combine exercícios cardiovasculares com treinamento de força e flexibilidade.")
        texto.AppendLine("- Utilize atividades que você goste para manter regularidade.")
        texto.AppendLine("- Consulte profissionais para planos personalizados e orientações corretas.")

        rtbRecomendacoes.Text = texto.ToString()
        rtbRecomendacoes.Font = New Font("Tahoma", 9)
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub



End Class
