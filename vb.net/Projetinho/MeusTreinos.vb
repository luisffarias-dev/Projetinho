Imports ADODB
Imports Projetinho.montarTreino
Imports System.Drawing.Printing
Imports System.Net.Http
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Projetinho.MontarCardio
Public Class MeusTreinos
    Dim documento As New PrintDocument()
    Dim linhaAtual As Integer = 0
    Dim nomeUsuario As String = ""
    Dim documentoCardio As New PrintDocument()


    Private Async Sub MeusTreinos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataCardios.Format = DateTimePickerFormat.Custom
        DataCardios.CustomFormat = "dd/MM/yyyy"

        DataMeusTreinos.Format = DateTimePickerFormat.Custom
        DataMeusTreinos.CustomFormat = "dd/MM/yyyy"


        AddHandler documento.PrintPage, AddressOf PrintDocument1_PrintPage
        AddHandler documentoCardio.PrintPage, AddressOf PrintDocumentCardio_PrintPage


        With DGV_Treinos
            .Rows.Clear()

            If .Columns.Count = 0 Then
                With .Columns
                    .Add("Musculo", "Músculo")
                    .Add("Exercicio", "Exercício")
                    .Add("Repeticoes", "Repetições")
                    .Add("Carga", "Carga")
                    .Add("Descanso", "Descanso")
                    .Add("Data", "Data")
                End With
            End If

            With DGV_Treinos
                .GridColor = Color.White
                .CellBorderStyle = DataGridViewCellBorderStyle.None
                .RowHeadersVisible = False
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                .EnableHeadersVisualStyles = False

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

                .BackgroundColor = Me.BackColor
                .BorderStyle = BorderStyle.None
                .DefaultCellStyle.BackColor = Me.BackColor
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.LightGray
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
                .RowTemplate.Height = 40
            End With
        End With

        Await carregarTreinos()
        dgvcardiolayout()
    End Sub

    Private Sub PrintDocumentCardio_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim fonteTitulo As New Font("Arial", 18, FontStyle.Bold)
        Dim fonteCabecalho As New Font("Arial", 10, FontStyle.Bold)
        Dim fonteConteudo As New Font("Arial", 10)

        Dim alturaLinha As Integer = fonteConteudo.GetHeight(e.Graphics) + 10
        Dim margemEsquerda As Integer = e.MarginBounds.Left
        Dim margemTopo As Integer = e.MarginBounds.Top
        Dim linhaY As Integer = margemTopo

        ' Larguras das colunas de cardio
        Dim largurasColunas() As Integer = {150, 150, 100, 100, 100}

        ' TÍTULO
        Dim textoTitulo As String = "Meu Cardio"
        Dim larguraTitulo As SizeF = e.Graphics.MeasureString(textoTitulo, fonteTitulo)
        Dim posicaoTituloX As Integer = margemEsquerda + (e.MarginBounds.Width - larguraTitulo.Width) \ 2
        e.Graphics.DrawString(textoTitulo, fonteTitulo, Brushes.Black, posicaoTituloX, linhaY)

        linhaY += CInt(fonteTitulo.GetHeight(e.Graphics)) + 10

        ' NOME DO USUÁRIO
        e.Graphics.DrawString("Usuário: " & nomeUsuario, fonteConteudo, Brushes.Black, margemEsquerda, linhaY)
        linhaY += alturaLinha

        ' DATA DO CARDIO
        Dim dataSelecionada As String = DataCardios.Value.ToString("dd/MM/yyyy")
        e.Graphics.DrawString("Data do cardio: " & dataSelecionada, fonteConteudo, Brushes.Black, margemEsquerda, linhaY)
        linhaY += alturaLinha + 10

        ' CABEÇALHOS
        Dim posX As Integer = margemEsquerda
        For i As Integer = 1 To DGVCardio.Columns.Count - 1 ' Pula o ID (coluna 0)
            Dim textoCabecalho As String = DGVCardio.Columns(i).HeaderText
            e.Graphics.DrawString(textoCabecalho, fonteCabecalho, Brushes.Black, posX, linhaY)
            posX += largurasColunas(i - 1)
        Next

        linhaY += alturaLinha

        ' CONTEÚDO
        For Each row As DataGridViewRow In DGVCardio.Rows
            If row.IsNewRow Then Continue For

            posX = margemEsquerda
            For i As Integer = 1 To DGVCardio.Columns.Count - 1
                Dim valor As String = row.Cells(i).Value?.ToString()
                e.Graphics.DrawString(valor, fonteConteudo, Brushes.Black, posX, linhaY)
                posX += largurasColunas(i - 1)
            Next

            linhaY += alturaLinha

            If linhaY + alturaLinha > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Return
            End If
        Next

        e.HasMorePages = False
    End Sub

    Private Async Sub dgvcardiolayout()
        Try
            With DGVCardio

                .Rows.Clear()

                If .Columns.Count = 0 Then
                    With .Columns
                        .Add("Id", "ID")
                        .Add("TipoCardio", "Tipo Cardio")
                        .Add("TempoMinutos", "Tempo (min)")
                        .Add("Intensidade", "Intensidade")
                        .Add("CaloriasGastas", "Calorias Gastas")
                        .Add("Data", "Data")



                        .Item("Id").Visible = False

                    End With
                End If

                .GridColor = Color.White
                .CellBorderStyle = DataGridViewCellBorderStyle.None
                .RowHeadersVisible = False
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                .EnableHeadersVisualStyles = False

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

                .BackgroundColor = Me.BackColor
                .BorderStyle = BorderStyle.None
                .DefaultCellStyle.BackColor = Me.BackColor
                .DefaultCellStyle.ForeColor = Color.Black
                .DefaultCellStyle.SelectionBackColor = Color.LightGray
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
                .RowTemplate.Height = 40
            End With

            Await carregarCardios()
        Catch ex As Exception
            MsgBox("Erro ao carregar os treinos: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try

    End Sub
    Public Async Function carregarTreinos() As Task
        Try
            Dim treinos As List(Of Treino) = Await TreinosDoUsuario(EmailUsuario)

            Dim dataSelecionada As Date = DataMeusTreinos.Value.Date

            ' Comparação segura de datas
            Dim treinosFiltrados = treinos.Where(Function(t) Date.Parse(t.Data).Date = dataSelecionada).ToList()

            With DGV_Treinos
                .Rows.Clear()
                For Each treino In treinosFiltrados
                    .Rows.Add(
                    treino.Musculo,
                    treino.Exercicio,
                    treino.Repeticoes,
                    treino.Carga,
                    treino.Descanso,
                    treino.Data
                )
                Next
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar os treinos: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Function

    Public Async Function carregarCardios() As Task
        Try
            Dim cardios As List(Of Cardio) = Await CardioDoUsuario(EmailUsuario)

            Dim dataSelecionada As Date = DataCardios.Value.Date

            ' Comparação segura de datas
            Dim cardioFiltrados = cardios.Where(Function(t) Date.Parse(t.Data).Date = dataSelecionada).ToList()

            With DGVCardio
                .Rows.Clear()
                For Each cardio In cardioFiltrados
                    .Rows.Add(
                    cardio.Id,
                    cardio.TipoCardio,
                    cardio.TempoMinutos,
                    cardio.Intensidade,
                    cardio.CaloriasGastas,
                    cardio.Data
                )
                Next
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar os cardios: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Function






    Private Async Sub DataMeusTreinos_ValueChanged_1(sender As Object, e As EventArgs) Handles DataMeusTreinos.ValueChanged
        Await carregarTreinos()
    End Sub

    Private Async Sub BuscarNomeUsuario()
        Try
            Dim dados As JObject = Await ObterDadosUsuarioCache(EmailUsuario)

            If dados IsNot Nothing AndAlso dados.ContainsKey("nome") Then
                nomeUsuario = dados("nome").ToString()
            Else
                MsgBox("Nome do usuário não encontrado no cache.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("Erro ao obter nome do usuário: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub



    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim fonteTitulo As New Font("Arial", 18, FontStyle.Bold)
        Dim fonteCabecalho As New Font("Arial", 10, FontStyle.Bold)
        Dim fonteConteudo As New Font("Arial", 10)

        Dim alturaLinha As Integer = fonteConteudo.GetHeight(e.Graphics) + 10
        Dim margemEsquerda As Integer = e.MarginBounds.Left
        Dim margemTopo As Integer = e.MarginBounds.Top
        Dim linhaY As Integer = margemTopo

        ' LARGURAS DAS COLUNAS
        Dim largurasColunas() As Integer = {100, 300, 80, 80, 80}

        ' TÍTULO
        Dim textoTitulo As String = "Meu Treino"
        Dim larguraTitulo As SizeF = e.Graphics.MeasureString(textoTitulo, fonteTitulo)
        Dim posicaoTituloX As Integer = margemEsquerda + (e.MarginBounds.Width - larguraTitulo.Width) \ 2
        e.Graphics.DrawString(textoTitulo, fonteTitulo, Brushes.Black, posicaoTituloX, linhaY)

        linhaY += CInt(fonteTitulo.GetHeight(e.Graphics)) + 10

        ' NOME DO USUÁRIO
        e.Graphics.DrawString("Usuário: " & nomeUsuario, fonteConteudo, Brushes.Black, margemEsquerda, linhaY)
        linhaY += alturaLinha

        ' DATA DO TREINO
        Dim dataSelecionada As String = DataMeusTreinos.Value.ToString("dd/MM/yyyy")
        e.Graphics.DrawString("Data do treino: " & dataSelecionada, fonteConteudo, Brushes.Black, margemEsquerda, linhaY)
        linhaY += alturaLinha + 10

        ' CABEÇALHOS
        Dim posX As Integer = margemEsquerda
        For i As Integer = 0 To DGV_Treinos.Columns.Count - 2
            Dim textoCabecalho As String = DGV_Treinos.Columns(i).HeaderText
            e.Graphics.DrawString(textoCabecalho, fonteCabecalho, Brushes.Black, posX, linhaY)
            posX += largurasColunas(i)
        Next

        linhaY += alturaLinha

        ' CONTEÚDO
        While linhaAtual < DGV_Treinos.Rows.Count
            Dim row = DGV_Treinos.Rows(linhaAtual)
            If row.IsNewRow Then Exit While

            posX = margemEsquerda
            For i As Integer = 0 To DGV_Treinos.Columns.Count - 2
                Dim valor As String = row.Cells(i).Value?.ToString()
                e.Graphics.DrawString(valor, fonteConteudo, Brushes.Black, posX, linhaY)
                posX += largurasColunas(i)
            Next

            linhaY += alturaLinha
            linhaAtual += 1

            If linhaY + alturaLinha > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Return
            End If
        End While

        e.HasMorePages = False
        linhaAtual = 0
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        BuscarNomeUsuario()

        Dim dialogo As New PrintDialog
        dialogo.Document = documento

        If dialogo.ShowDialog = DialogResult.OK Then
            documento.Print()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim novoForm As New TelaInicial
        novoForm.Show()
        Close()
    End Sub



    Private Async Sub DataCardios_ValueChanged(sender As Object, e As EventArgs) Handles DataCardios.ValueChanged

        Await carregarCardios()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim novoForm As New TelaInicial
        novoForm.Show()
        Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        BuscarNomeUsuario() ' Pega o nome antes da impressão

        Dim dialogo As New PrintDialog()
        dialogo.Document = documentoCardio

        If dialogo.ShowDialog() = DialogResult.OK Then
            documentoCardio.Print()
        End If
    End Sub

End Class
