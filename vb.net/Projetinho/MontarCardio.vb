Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports ADODB
Imports Newtonsoft.Json
Imports Projetinho.montarTreino

Public Class MontarCardio
    Dim CaloriaSend As Double
    Private Async Sub MontarCardio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataCardio.Format = DateTimePickerFormat.Custom
        dataCardio.CustomFormat = "dd/MM/yyyy"
        Await carregarCardios()

    End Sub
    Public Async Function carregarCardios() As Task
        Try
            With DGV_CARDIO1
                .Rows.Clear()

                If .Columns.Count = 0 Then
                    With .Columns
                        .Add("Id", "ID")
                        .Add("TipoCardio", "Tipo Cardio")
                        .Add("TempoMinutos", "Tempo (min)")
                        .Add("Intensidade", "Intensidade")
                        .Add("CaloriasGastas", "Calorias Gastas")
                        .Add("Data", "Data")
                        .Add("Excluir", "Excluir")


                        .Item("Id").Visible = False

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

            Dim cardios As List(Of Cardio) = Await CardiosDoUsuario(EmailUsuario)


            If cardios IsNot Nothing Then
                For Each cardio In cardios
                    DGV_CARDIO1.Rows.Add(
                cardio.Id,
                cardio.TipoCardio,
                cardio.TempoMinutos,
                cardio.Intensidade,
                cardio.CaloriasGastas,
                cardio.Data,
                "🗑️"
            )
                Next

            Else
                MsgBox("Nenhum treino retornado ou erro ao buscar os dados.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar os treinos: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Function


    Public Class Cardio
        Public Property Id As Long
        Public Property TipoCardio As String
        Public Property TempoMinutos As Integer
        Public Property Intensidade As String
        Public Property CaloriasGastas As Double
        Public Property Data As String

    End Class




    Private Sub TipoCardioOpc1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Async Sub BtnCardio_Click(sender As Object, e As EventArgs) Handles BtnCardio1.Click

        Dim tipo = If(CardOpcTipo.SelectedItem?.ToString(), "")
        Dim intensidade = If(CardOpcIntensidade.SelectedItem?.ToString(), "")
        Dim dataSelecionadaCardio = dataCardio.Value.ToString("dd-MM-yyyy")

        Dim tempoMin As Integer = 0
        If CardOpcTempo.SelectedItem IsNot Nothing Then
            Integer.TryParse(CardOpcTempo.SelectedItem.ToString(), tempoMin)
        End If

        Dim cardio = New With {
            .email = EmailUsuario,
            .tipoCardio = tipo,
            .tempoMinutos = tempoMin,
            .intensidade = intensidade,
            .caloriasGastas = CaloriaSend,
            .data = dataSelecionadaCardio
        }

        Dim enviadoComSucesso As Boolean = Await SalvarCardio(cardio)

        If enviadoComSucesso Then
            MessageBox.Show("Cardio enviado com sucesso!")
            ' Limpa campos
            CardOpcTipo.SelectedIndex = -1
            CardOpcTempo.SelectedIndex = -1
            CardOpcIntensidade.SelectedIndex = -1
            LabelCal.Text = ""
            Await LimparCacheCardio(EmailUsuario)
            Await carregarCardios()

        Else
            MessageBox.Show("Falha ao enviar cardio. Tente novamente.")
        End If
    End Sub



    Sub criarDGVcardio()


        ' Limpa os campos após adicionar (opcional)
        CardOpcTipo.SelectedIndex = 0
        CardOpcTempo.SelectedIndex = 0
        CardOpcIntensidade.SelectedIndex = 0
        LabelCal.Text = ""


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CardOpcTipo.SelectedIndexChanged



    End Sub

    Sub CalcularCalorias()
        ' Pega o tipo cardio, se selecionado
        Dim tipoCardio As String = If(CardOpcTipo.SelectedItem IsNot Nothing, CardOpcTipo.SelectedItem.ToString(), "")
        ' Pega o tempo, se selecionado
        Dim tempoString As String = If(CardOpcTempo.SelectedItem IsNot Nothing, CardOpcTempo.SelectedItem.ToString(), "")
        ' Pega a intensidade, se selecionada
        Dim intensidade As String = If(CardOpcIntensidade.SelectedItem IsNot Nothing, CardOpcIntensidade.SelectedItem.ToString(), "")

        ' Tenta converter tempo, se possível
        Dim tempoMinutos As Integer = 0
        If Not String.IsNullOrEmpty(tempoString) Then
            Dim tempoParts() As String = tempoString.Split(" "c)
            If tempoParts.Length > 0 Then
                Integer.TryParse(tempoParts(0), tempoMinutos)
            End If
        End If

        ' Define calorias base pelo tipo, ou padrão
        Dim caloriasPorMinutoBase As Double = 5.0 ' padrão neutro
        If Not String.IsNullOrEmpty(tipoCardio) Then
            Select Case tipoCardio.ToLower()
                Case "corrida"
                    caloriasPorMinutoBase = 10.0
                Case "caminhada"
                    caloriasPorMinutoBase = 6.5
                Case "ciclismo"
                    caloriasPorMinutoBase = 7.0
                Case "natação"
                    caloriasPorMinutoBase = 9.0
                Case "elíptico"
                    caloriasPorMinutoBase = 7.0
                Case "polichinelos"
                    caloriasPorMinutoBase = 5.0
                Case "dança"
                    caloriasPorMinutoBase = 4.0
                Case "subir escadas"
                    caloriasPorMinutoBase = 8.0
                Case "pular corda"
                    caloriasPorMinutoBase = 8.0
                Case "arte marcial"
                    caloriasPorMinutoBase = 6.0
                Case "abdominais"
                    caloriasPorMinutoBase = 5.0
            End Select
        End If

        ' Define fator intensidade, padrão 1.0
        Dim fatorIntensidade As Double = 1.0
        If Not String.IsNullOrEmpty(intensidade) Then
            Select Case intensidade.ToLower()
                Case "leve"
                    fatorIntensidade = 0.8
                Case "moderada"
                    fatorIntensidade = 1.0
                Case "intensa"
                    fatorIntensidade = 1.2
            End Select
        End If

        ' Calcula calorias (se tempo for zero, calorias serão zero)
        Dim caloriasGastas As Double = caloriasPorMinutoBase * tempoMinutos * fatorIntensidade
        CaloriaSend = caloriasPorMinutoBase * tempoMinutos * fatorIntensidade

        ' Mostra resultado ou limpa label se zero
        If caloriasGastas > 0 Then
            LabelCal.Text = caloriasGastas.ToString("F0") & " Cal"
        Else
            LabelCal.Text = ""
        End If
    End Sub



    Private Sub LabelCal_Click(sender As Object, e As EventArgs) Handles LabelCal.Click

    End Sub
    Private Sub CardOpcTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CardOpcTipo.SelectedIndexChanged
        CalcularCalorias()
    End Sub

    Private Sub CardOpcTempo_TextChanged(sender As Object, e As EventArgs) Handles CardOpcTempo.TextChanged
        CalcularCalorias()
    End Sub

    Private Sub CardOpcIntensidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CardOpcIntensidade.SelectedIndexChanged
        CalcularCalorias()
    End Sub

    Private Async Sub DGV_CARDIO1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_CARDIO1.CellContentClick
        If e.ColumnIndex = DGV_CARDIO1.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            If MsgBox("Deseja realmente excluir este treino?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmação") = MsgBoxResult.Yes Then
                Try
                    Dim Id As Long = DGV_CARDIO1.Rows(e.RowIndex).Cells(0).Value

                    Dim sucesso As Boolean = Await ExcluirCardio(Id)

                    If sucesso Then
                        ' Await LimparCacheCardio(EmailUsuario)
                        Await LimparCacheCardio(EmailUsuario)
                        MsgBox("Treino excluído com sucesso!", MsgBoxStyle.Information, "Removido")
                        Await carregarCardios()
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
End Class
