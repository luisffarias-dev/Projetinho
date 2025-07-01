Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Reflection.Emit
Imports ADODB
Imports Newtonsoft.Json.Linq

Public Class AvaliacaoUsuario


    Public Property EmailUsuario As String
    Private Sub AvaliacaoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmailUsuario = Modulo_global.EmailUsuario
        If String.IsNullOrEmpty(EmailUsuario) Then
            MessageBox.Show("Usuário não definido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        CarregarDadosECalcular()
    End Sub


    Private Async Sub CarregarDadosECalcular()
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

                ' Cálculos do perfil metabólico
                Dim imc As Double = CalcularIMC(pesoKg, alturaCm)
                Dim faixaImc As String = ObterFaixaIMC(imc)
                Dim taxaBasal As Double = CalcularTaxaMetabolicaBasal(pesoKg, alturaCm, dataNasc, sexoUsuario)
                Dim gastoTotal As Double = taxaBasal * 1.2
                Dim aguaCorporal As Double = CalcularAguaCorporal(pesoKg, sexoUsuario)
                Dim percGordura As Double = EstimarPercentualGordura(imc, sexoUsuario)
                Dim massaMagra As Double = pesoKg * (1 - percGordura / 100)
                Dim massaGorda As Double = pesoKg * (percGordura / 100)
                Dim proteinaDiaria As Double = pesoKg * 1.3
                Dim volumeSanguineo As Double = CalcularVolumeSanguineo(pesoKg, sexoUsuario)
                Dim circCintura As Double = CalcularCircunferenciaCintura(alturaCm, sexoUsuario)

                ' Labels
                lblNome.Text = nomeCompleto
                lbl_idade.Text = idade.ToString() & " anos"
                lblPeso.Text = pesoKg.ToString("F1") & " Kg"
                lblAltura.Text = (alturaCm / 100).ToString("F2") & " m"
                lblGenero.Text = sexoUsuario

                lblValorIMC.Text = imc.ToString("F2")
                lblFaixaIMC.Text = faixaImc

                lblTaxaBasal.Text = taxaBasal.ToString("F0") & " Kcal/dia"
                lblGastoCalorico.Text = gastoTotal.ToString("F0") & " Kcal/dia"
                lblAguaCorporal.Text = aguaCorporal.ToString("F1") & " L"
                lblMassaMagra.Text = massaMagra.ToString("F1") & " Kg (" & (massaMagra / pesoKg * 100).ToString("F1") & "%)"
                lblMassaGorda.Text = massaGorda.ToString("F1") & " Kg (" & percGordura.ToString("F1") & "%)"
                lblProteinas.Text = proteinaDiaria.ToString("F0") & " g/dia"
                lblVolumeSanguineo.Text = volumeSanguineo.ToString("F1") & " L"
                lblCircCinturaIdeal.Text = circCintura.ToString("F1") & " cm"

                ' Para preencher o formulário Recomendacoes
                Dim formRec As New Recomendacoes()
                formRec.PreencherRecomendacoes(imc, faixaImc, idade, pesoKg, sexoUsuario)
            Else
                MessageBox.Show("Usuário não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados e calcular: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Cálculos de acordo com as entradas da tabela DadosUsuario

    Private Function CalcularIMC(peso As Double, alturaCm As Double) As Double
        Dim alturaM As Double = alturaCm / 100
        If alturaM <= 0 Then Return 0
        Return peso / (alturaM * alturaM)
    End Function

    Private Function ObterFaixaIMC(imc As Double) As String
        If imc < 18.5 Then Return "Abaixo do peso"
        If imc < 24.9 Then Return "Peso normal"
        If imc < 29.9 Then Return "Sobrepeso"
        Return "Obesidade"
    End Function

    Private Function CalcularTaxaMetabolicaBasal(peso As Double, alturaCm As Double, dataNasc As Date, sexo As String) As Double
        Dim idade As Integer = DateTime.Now.Year - dataNasc.Year
        If dataNasc > DateTime.Now.AddYears(-idade) Then idade -= 1

        If sexo.Contains("masculino") Then
            Return 66 + (13.7 * peso) + (5 * alturaCm) - (6.8 * idade)
        Else
            Return 655 + (9.6 * peso) + (1.8 * alturaCm) - (4.7 * idade)
        End If
    End Function

    Private Function CalcularAguaCorporal(peso As Double, sexo As String) As Double
        If sexo.Contains("masculino") Then
            Return peso * 0.6
        Else
            Return peso * 0.5
        End If
    End Function

    Private Function EstimarPercentualGordura(imc As Double, sexo As String) As Double
        Dim idadeEstimada As Integer = 30
        Dim percentual As Double
        If sexo.Contains("masculino") Then
            percentual = (1.2 * imc) + (0.23 * idadeEstimada) - 16.2
        Else
            percentual = (1.2 * imc) + (0.23 * idadeEstimada) - 5.4
        End If
        If percentual < 5 Then percentual = 5
        If percentual > 60 Then percentual = 60
        Return percentual
    End Function

    Private Function CalcularVolumeSanguineo(peso As Double, sexo As String) As Double
        If sexo.Contains("masculino") Then
            Return (peso * 70) / 1000
        Else
            Return (peso * 65) / 1000
        End If
    End Function

    Private Function CalcularCircunferenciaCintura(alturaCm As Double, sexo As String) As Double
        If sexo.Contains("masculino") Then
            Return alturaCm * 0.54
        Else
            Return alturaCm * 0.48
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Dim novoForm As New TelaInicial()
        novoForm.Show()
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fonteTitulo As New Font("Tahoma", 14, FontStyle.Bold)
        Dim fonteNormal As New Font("Tahoma", 11)
        Dim yPos As Integer = 50
        Dim leftMargin As Integer = e.MarginBounds.Left

        ' Imprime o logo (PictureBox1)
        If PictureBox1.Image IsNot Nothing Then
            Dim logo As Image = PictureBox1.Image
            Dim imageWidth As Integer = 200
            Dim imageHeight As Integer = CInt(logo.Height * (imageWidth / logo.Width))
            e.Graphics.DrawImage(logo, leftMargin + 350, yPos, imageWidth, imageHeight)
        End If

        ' Imprime o título
        e.Graphics.DrawString("Dados do usuário - Projetinho", fonteTitulo, Brushes.Black, leftMargin, yPos)
        yPos += 60  ' Espaçamento vertical após o título

        ' Imprime os dados pessoais
        e.Graphics.DrawString("Usuário: " & lblNome.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 25
        e.Graphics.DrawString("Gênero: " & lblGenero.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 25
        e.Graphics.DrawString("Idade: " & lbl_idade.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 25
        e.Graphics.DrawString("Peso: " & lblPeso.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 25
        e.Graphics.DrawString("Altura: " & lblAltura.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 40

        ' Imprime o cabeçalho da seção "Dados do usuário"
        e.Graphics.DrawString("Perfil Metabólico:", fonteTitulo, Brushes.Black, leftMargin, yPos)
        yPos += 40

        ' Imprime os dados detalhados da avaliação
        e.Graphics.DrawString("Índice de Massa Corporal (IMC): " & lblValorIMC.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 25
        e.Graphics.DrawString("Avaliado com: " & lblFaixaIMC.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 25
        e.Graphics.DrawString("Taxa metabólica basal: " & lblTaxaBasal.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 25
        e.Graphics.DrawString("Gasto calórico total: " & lblGastoCalorico.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 25
        e.Graphics.DrawString("Água corporal total: " & lblAguaCorporal.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 25
        e.Graphics.DrawString("Massa magra: " & lblMassaMagra.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 25
        e.Graphics.DrawString("Massa gorda: " & lblMassaGorda.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 25
        e.Graphics.DrawString("Necessidade proteicas diárias: " & lblProteinas.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 25
        e.Graphics.DrawString("Volume sanguíneo aproximado: " & lblVolumeSanguineo.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 25
        e.Graphics.DrawString("Circunferência ideal de cintura: " & lblCircCinturaIdeal.Text, fonteNormal, Brushes.Black, leftMargin, yPos)
        yPos += 60

        e.Graphics.DrawString("Métricas calculadas de acordo com o gênero, idade, peso e altura fornecidos pelo usuário.", fonteNormal, Brushes.Black, leftMargin, yPos)


        ' Indica que essa é a última página
        e.HasMorePages = False
    End Sub


    Private Sub btn_Imprimir_Click(sender As Object, e As EventArgs) Handles btn_Imprimir.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub btnRecomendacoes_Click(sender As Object, e As EventArgs) Handles btnRecomendacoes.Click
        Dim formRec As New Recomendacoes()
        formRec.EmailUsuario = Me.EmailUsuario ' ou da variável que armazena o email
        formRec.ShowDialog()
        ' Me.Close() ' opcional: fechar AvaliacaoUsuario se quiser
    End Sub

End Class
