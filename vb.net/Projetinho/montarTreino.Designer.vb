<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class montarTreino
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(montarTreino))
        GroupBox1 = New GroupBox()
        DataTreino = New DateTimePicker()
        Label6 = New Label()
        TempoOpc1 = New ComboBox()
        CargaOpc1 = New ComboBox()
        LinkLabel1 = New LinkLabel()
        DGV_Treino1 = New DataGridView()
        musculoOpc1 = New ComboBox()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        BtnTreino1 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        RepOpc1 = New ComboBox()
        Label2 = New Label()
        ExOpc1 = New ComboBox()
        Label1 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        GroupBox1.SuspendLayout()
        CType(DGV_Treino1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(DataTreino)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TempoOpc1)
        GroupBox1.Controls.Add(CargaOpc1)
        GroupBox1.Controls.Add(LinkLabel1)
        GroupBox1.Controls.Add(DGV_Treino1)
        GroupBox1.Controls.Add(musculoOpc1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(BtnTreino1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(RepOpc1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(ExOpc1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ForeColor = SystemColors.ControlLightLight
        GroupBox1.Location = New Point(-4, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1188, 609)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Treino Selecionado:"
        ' 
        ' DataTreino
        ' 
        DataTreino.Location = New Point(476, 139)
        DataTreino.MinDate = New Date(2025, 6, 15, 0, 0, 0, 0)
        DataTreino.Name = "DataTreino"
        DataTreino.Size = New Size(143, 27)
        DataTreino.TabIndex = 50
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Transparent
        Label6.Location = New Point(479, 109)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 27)
        Label6.TabIndex = 49
        Label6.Text = "Data:"
        ' 
        ' TempoOpc1
        ' 
        TempoOpc1.FormattingEnabled = True
        TempoOpc1.Items.AddRange(New Object() {"20", "25", "30", "35", "40", "45", "50", "55", "60"})
        TempoOpc1.Location = New Point(888, 140)
        TempoOpc1.Name = "TempoOpc1"
        TempoOpc1.Size = New Size(151, 27)
        TempoOpc1.TabIndex = 48
        ' 
        ' CargaOpc1
        ' 
        CargaOpc1.FormattingEnabled = True
        CargaOpc1.Items.AddRange(New Object() {"1", "3", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95", "100"})
        CargaOpc1.Location = New Point(761, 139)
        CargaOpc1.Name = "CargaOpc1"
        CargaOpc1.Size = New Size(121, 27)
        CargaOpc1.TabIndex = 47
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(7, 22)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(59, 19)
        LinkLabel1.TabIndex = 46
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Voltar"
        ' 
        ' DGV_Treino1
        ' 
        DGV_Treino1.BackgroundColor = Color.GhostWhite
        DGV_Treino1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Treino1.Location = New Point(55, 226)
        DGV_Treino1.Name = "DGV_Treino1"
        DGV_Treino1.RowHeadersWidth = 51
        DGV_Treino1.RowTemplate.Height = 25
        DGV_Treino1.Size = New Size(1003, 316)
        DGV_Treino1.TabIndex = 45
        ' 
        ' musculoOpc1
        ' 
        musculoOpc1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        musculoOpc1.ForeColor = SystemColors.InactiveCaptionText
        musculoOpc1.FormattingEnabled = True
        musculoOpc1.Items.AddRange(New Object() {"Peito", "Costas", "Ombro", "Perna", "Triceps", "Biceps"})
        musculoOpc1.Location = New Point(55, 139)
        musculoOpc1.Name = "musculoOpc1"
        musculoOpc1.Size = New Size(152, 27)
        musculoOpc1.TabIndex = 44
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Transparent
        Label5.Location = New Point(55, 109)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 27)
        Label5.TabIndex = 43
        Label5.Text = "Músculo"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(368, -4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(403, 91)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' BtnTreino1
        ' 
        BtnTreino1.BackColor = Color.White
        BtnTreino1.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        BtnTreino1.ForeColor = Color.Black
        BtnTreino1.Location = New Point(513, 187)
        BtnTreino1.Name = "BtnTreino1"
        BtnTreino1.Size = New Size(129, 33)
        BtnTreino1.TabIndex = 41
        BtnTreino1.Text = "Adicionar"
        BtnTreino1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(879, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(171, 27)
        Label4.TabIndex = 6
        Label4.Text = "Tempo Descanso:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(786, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 27)
        Label3.TabIndex = 4
        Label3.Text = "Carga:"
        ' 
        ' RepOpc1
        ' 
        RepOpc1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        RepOpc1.ForeColor = SystemColors.InactiveCaptionText
        RepOpc1.FormattingEnabled = True
        RepOpc1.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "13", "14", "15"})
        RepOpc1.Location = New Point(634, 139)
        RepOpc1.Name = "RepOpc1"
        RepOpc1.Size = New Size(121, 27)
        RepOpc1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(634, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 27)
        Label2.TabIndex = 2
        Label2.Text = "Repetições:"
        ' 
        ' ExOpc1
        ' 
        ExOpc1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ExOpc1.ForeColor = SystemColors.InactiveCaptionText
        ExOpc1.FormattingEnabled = True
        ExOpc1.Location = New Point(235, 139)
        ExOpc1.Name = "ExOpc1"
        ExOpc1.Size = New Size(230, 27)
        ExOpc1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(235, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 27)
        Label1.TabIndex = 0
        Label1.Text = "Exercício"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Location = New Point(-2, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1175, 623)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1167, 595)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' montarTreino
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1176, 631)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "montarTreino"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Montar Treino - Projetinho"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DGV_Treino1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RepOpc1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ExOpc1 As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnTreino1 As Button
    Friend WithEvents musculoOpc1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DGV_Treino1 As DataGridView
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CargaOpc1 As ComboBox
    Friend WithEvents TempoOpc1 As ComboBox
    Friend WithEvents DataTreino As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
