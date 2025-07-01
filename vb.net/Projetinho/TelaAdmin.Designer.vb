<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaAdmin
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaAdmin))
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        DGV_EditarContas = New DataGridView()
        Email = New DataGridViewTextBoxColumn()
        Nome = New DataGridViewTextBoxColumn()
        DataNasc = New DataGridViewTextBoxColumn()
        Sexo = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        AlterarStatus = New DataGridViewImageColumn()
        Excluir = New DataGridViewImageColumn()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGV_EditarContas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(281, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(278, 115)
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(314, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 19)
        Label2.TabIndex = 17
        Label2.Text = "Painel do administrador"
        ' 
        ' DGV_EditarContas
        ' 
        DGV_EditarContas.AllowUserToAddRows = False
        DGV_EditarContas.AllowUserToOrderColumns = True
        DGV_EditarContas.BackgroundColor = Color.MediumPurple
        DGV_EditarContas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_EditarContas.Columns.AddRange(New DataGridViewColumn() {Email, Nome, DataNasc, Sexo, Status, AlterarStatus, Excluir})
        DGV_EditarContas.Location = New Point(13, 164)
        DGV_EditarContas.Margin = New Padding(3, 2, 3, 2)
        DGV_EditarContas.Name = "DGV_EditarContas"
        DGV_EditarContas.RowHeadersWidth = 51
        DGV_EditarContas.RowTemplate.Height = 29
        DGV_EditarContas.Size = New Size(822, 229)
        DGV_EditarContas.TabIndex = 18
        ' 
        ' Email
        ' 
        Email.HeaderText = "Email"
        Email.MinimumWidth = 6
        Email.Name = "Email"
        Email.Width = 125
        ' 
        ' Nome
        ' 
        Nome.HeaderText = "Nome"
        Nome.MinimumWidth = 6
        Nome.Name = "Nome"
        Nome.Width = 125
        ' 
        ' DataNasc
        ' 
        DataNasc.HeaderText = "Data de nascimento"
        DataNasc.MinimumWidth = 6
        DataNasc.Name = "DataNasc"
        DataNasc.Width = 125
        ' 
        ' Sexo
        ' 
        Sexo.HeaderText = "Gênero"
        Sexo.MinimumWidth = 6
        Sexo.Name = "Sexo"
        Sexo.Width = 125
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.MinimumWidth = 6
        Status.Name = "Status"
        Status.Width = 125
        ' 
        ' AlterarStatus
        ' 
        AlterarStatus.HeaderText = "Alterar Status"
        AlterarStatus.Image = CType(resources.GetObject("AlterarStatus.Image"), Image)
        AlterarStatus.MinimumWidth = 6
        AlterarStatus.Name = "AlterarStatus"
        AlterarStatus.Resizable = DataGridViewTriState.True
        AlterarStatus.Width = 125
        ' 
        ' Excluir
        ' 
        Excluir.HeaderText = "Excluir"
        Excluir.Image = CType(resources.GetObject("Excluir.Image"), Image)
        Excluir.MinimumWidth = 6
        Excluir.Name = "Excluir"
        Excluir.Resizable = DataGridViewTriState.True
        Excluir.Width = 125
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(703, 10)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 30)
        Button1.TabIndex = 19
        Button1.Text = "Sair"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TelaAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(843, 395)
        Controls.Add(Button1)
        Controls.Add(DGV_EditarContas)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "TelaAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Painel do administrador - Projetinho"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DGV_EditarContas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV_EditarContas As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents DataNasc As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents AlterarStatus As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
End Class
