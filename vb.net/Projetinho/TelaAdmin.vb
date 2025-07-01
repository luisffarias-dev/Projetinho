Imports System.Net.Http
Imports System.Text
Imports ADODB
Imports Newtonsoft.Json.Linq

Public Class TelaAdmin
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub TelaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfigurarDataGridView()
        CarregarDados()
    End Sub

    Private Sub ConfigurarDataGridView()
        With DGV_EditarContas


            ' Estilo do DGV_EditarContas
            .DefaultCellStyle.Font = New Font("Tahoma", 9)
            .GridColor = Color.White
            .RowHeadersVisible = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .EnableHeadersVisualStyles = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .BackgroundColor = Me.BackColor
            .BorderStyle = BorderStyle.None
            .RowTemplate.Height = 40
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold)
            .Columns("Email").Width = 200
            .Columns("Nome").Width = 200
            .Columns("DataNasc").Width = 125
            .Columns("Sexo").Width = 100
            .Columns("AlterarStatus").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Excluir").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("AlterarStatus").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Excluir").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



        End With
    End Sub

    Private Async Sub CarregarDados()
        Try
            Dim url As String = "http://localhost:8088/usuario/todos"
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(url)

            If response.IsSuccessStatusCode Then
                Dim content As String = Await response.Content.ReadAsStringAsync()
                Dim usuarios As JArray = JArray.Parse(content)

                With DGV_EditarContas
                    .Rows.Clear()

                    For Each usuario As JObject In usuarios
                        Dim status As String = "Indefinido"
                        Dim login As JObject = usuario("login")

                        If login IsNot Nothing AndAlso login("status") IsNot Nothing Then
                            Dim rawStatus As Boolean = login("status").ToObject(Of Boolean)()
                            status = If(rawStatus, "Bloqueado", "Ativo")
                        End If

                        .Rows.Add(
                        usuario("email").ToString(),
                        usuario("nome").ToString(),
                        Date.Parse(usuario("dataNasc").ToString()).ToString("dd/MM/yyyy"),
                        usuario("sexo").ToString(),
                        status
                    )
                    Next
                End With
            Else
                MessageBox.Show("Erro ao carregar dados: " & response.StatusCode)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados: " & ex.Message)
        End Try
    End Sub






    Private Async Sub DGV_EditarContas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_EditarContas.CellContentClick
        If e.RowIndex >= 0 Then
            Dim colunaNome = DGV_EditarContas.Columns(e.ColumnIndex).Name
            Dim email As String = DGV_EditarContas.Rows(e.RowIndex).Cells("Email").Value.ToString()

            Using client As New HttpClient()
                If colunaNome = "AlterarStatus" Then
                    Dim statusAtual As String = DGV_EditarContas.Rows(e.RowIndex).Cells("Status").Value.ToString()
                    Dim novoStatus As String = If(statusAtual = "Bloqueado", "Ativo", "Bloqueado")
                    Dim statusBool As Boolean = (novoStatus = "Bloqueado")

                    Dim resposta = MsgBox("Alterar status de " & email & " para '" & novoStatus & "'?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Alterar status")

                    If resposta = MsgBoxResult.Yes Then
                        ' Monta JSON para envio
                        Dim jsonStatus As String = $"{{""status"": {statusBool.ToString().ToLower()}}}"
                        Dim content As New StringContent(jsonStatus, Encoding.UTF8, "application/json")

                        Dim response As HttpResponseMessage = Await client.PutAsync($"http://localhost:8088/login/login/status/{email}", content)

                        If response.IsSuccessStatusCode Then
                            DGV_EditarContas.Rows(e.RowIndex).Cells("Status").Value = novoStatus
                            MsgBox("Status alterado com sucesso!", MsgBoxStyle.Information, "Sucesso")
                        Else
                            MsgBox("Erro ao alterar status: " & response.StatusCode)
                        End If
                    End If

                ElseIf colunaNome = "Excluir" Then
                    Dim resposta = MsgBox("Deseja excluir o usuário " & email & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirmar exclusão?")

                    If resposta = MsgBoxResult.Yes Then
                        Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:8088/login/login/excluirTudo/{email}")

                        If response.IsSuccessStatusCode Then
                            DGV_EditarContas.Rows.RemoveAt(e.RowIndex)
                            MsgBox("Usuário excluído com sucesso.", MsgBoxStyle.Information, "Ação realizada")
                        Else
                            MsgBox("Erro ao excluir usuário: " & response.StatusCode)
                        End If
                    End If
                End If
            End Using
        End If
    End Sub







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resposta As DialogResult = MessageBox.Show("Deseja sair do painel do administrador?", "Sair do painel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resposta = DialogResult.Yes Then
            Me.Close()

            Dim form1 As New Login()
            form1.Show()
        End If
    End Sub

End Class
