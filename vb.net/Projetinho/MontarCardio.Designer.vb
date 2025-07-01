<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MontarCardio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MontarCardio))
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        CardOpcTipo = New ComboBox()
        CardOpcIntensidade = New ComboBox()
        CardOpcTempo = New ComboBox()
        BtnCardio1 = New Button()
        DGV_CARDIO1 = New DataGridView()
        LabelCal = New Label()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        dataCardio = New DateTimePicker()
        LinkLabel1 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGV_CARDIO1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(235, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(403, 91)
        PictureBox1.TabIndex = 49
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(32, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 27)
        Label3.TabIndex = 52
        Label3.Text = "Tipo de Cardio"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(187, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 27)
        Label1.TabIndex = 53
        Label1.Text = "Tempo Realizado"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(375, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 27)
        Label2.TabIndex = 54
        Label2.Text = "Intensidade"
        ' 
        ' CardOpcTipo
        ' 
        CardOpcTipo.FormattingEnabled = True
        CardOpcTipo.Items.AddRange(New Object() {"Corrida", "Caminhada", "Ciclismo", "Natação", "Elíptico", "Polichinelos", "Dança", "Subir Escadas", "Pular Corda", "Arte Marcial", "Abdominais"})
        CardOpcTipo.Location = New Point(41, 157)
        CardOpcTipo.Name = "CardOpcTipo"
        CardOpcTipo.Size = New Size(137, 23)
        CardOpcTipo.TabIndex = 55
        ' 
        ' CardOpcIntensidade
        ' 
        CardOpcIntensidade.FormattingEnabled = True
        CardOpcIntensidade.Items.AddRange(New Object() {"Leve", "Moderada", "Intensa"})
        CardOpcIntensidade.Location = New Point(375, 157)
        CardOpcIntensidade.Name = "CardOpcIntensidade"
        CardOpcIntensidade.Size = New Size(137, 23)
        CardOpcIntensidade.TabIndex = 56
        ' 
        ' CardOpcTempo
        ' 
        CardOpcTempo.FormattingEnabled = True
        CardOpcTempo.Items.AddRange(New Object() {"1", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60"})
        CardOpcTempo.Location = New Point(196, 157)
        CardOpcTempo.Name = "CardOpcTempo"
        CardOpcTempo.Size = New Size(156, 23)
        CardOpcTempo.TabIndex = 57
        ' 
        ' BtnCardio1
        ' 
        BtnCardio1.BackColor = SystemColors.ControlLight
        BtnCardio1.FlatStyle = FlatStyle.System
        BtnCardio1.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCardio1.ForeColor = Color.Black
        BtnCardio1.Location = New Point(375, 203)
        BtnCardio1.Name = "BtnCardio1"
        BtnCardio1.Size = New Size(129, 33)
        BtnCardio1.TabIndex = 58
        BtnCardio1.Text = "Adicionar"
        BtnCardio1.UseVisualStyleBackColor = False
        ' 
        ' DGV_CARDIO1
        ' 
        DGV_CARDIO1.BackgroundColor = Color.GhostWhite
        DGV_CARDIO1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_CARDIO1.Location = New Point(32, 242)
        DGV_CARDIO1.Name = "DGV_CARDIO1"
        DGV_CARDIO1.RowHeadersWidth = 51
        DGV_CARDIO1.RowTemplate.Height = 25
        DGV_CARDIO1.Size = New Size(787, 243)
        DGV_CARDIO1.TabIndex = 59
        ' 
        ' LabelCal
        ' 
        LabelCal.BackColor = Color.White
        LabelCal.BorderStyle = BorderStyle.Fixed3D
        LabelCal.Location = New Point(665, 156)
        LabelCal.Name = "LabelCal"
        LabelCal.Size = New Size(132, 24)
        LabelCal.TabIndex = 61
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Transparent
        Label6.Location = New Point(658, 114)
        Label6.Name = "Label6"
        Label6.Size = New Size(154, 27)
        Label6.TabIndex = 62
        Label6.Text = "Calorias Gastas"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.fire
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(818, 137)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(57, 43)
        PictureBox2.TabIndex = 64
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(554, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 27)
        Label4.TabIndex = 65
        Label4.Text = "Data"
        ' 
        ' dataCardio
        ' 
        dataCardio.Location = New Point(518, 156)
        dataCardio.MinDate = New Date(2025, 6, 15, 0, 0, 0, 0)
        dataCardio.Name = "dataCardio"
        dataCardio.Size = New Size(133, 23)
        dataCardio.TabIndex = 66
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.Location = New Point(12, 9)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(62, 25)
        LinkLabel1.TabIndex = 67
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Voltar"
        ' 
        ' MontarCardio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(874, 497)
        Controls.Add(LinkLabel1)
        Controls.Add(dataCardio)
        Controls.Add(Label4)
        Controls.Add(PictureBox2)
        Controls.Add(Label6)
        Controls.Add(LabelCal)
        Controls.Add(DGV_CARDIO1)
        Controls.Add(BtnCardio1)
        Controls.Add(CardOpcTempo)
        Controls.Add(CardOpcIntensidade)
        Controls.Add(CardOpcTipo)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Name = "MontarCardio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MontarCardio"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DGV_CARDIO1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CardOpcTipo As ComboBox
    Friend WithEvents CardOpcIntensidade As ComboBox
    Friend WithEvents CardOpcTempo As ComboBox
    Friend WithEvents BtnCardio1 As Button
    Friend WithEvents DGV_CARDIO1 As DataGridView
    Friend WithEvents LabelCal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dataCardio As DateTimePicker
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
