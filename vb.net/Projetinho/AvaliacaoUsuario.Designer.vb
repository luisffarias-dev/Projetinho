<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AvaliacaoUsuario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AvaliacaoUsuario))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        lblNome = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        btnRecomendacoes = New Button()
        Label4 = New Label()
        lblCircCinturaIdeal = New Label()
        lblVolumeSanguineo = New Label()
        lblProteinas = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        lblMassaGorda = New Label()
        lblMassaMagra = New Label()
        Label13 = New Label()
        Label12 = New Label()
        lblAguaCorporal = New Label()
        Label10 = New Label()
        lblGastoCalorico = New Label()
        Label8 = New Label()
        lblTaxaBasal = New Label()
        Label5 = New Label()
        lblFaixaIMC = New Label()
        lblValorIMC = New Label()
        btn_Imprimir = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        Label9 = New Label()
        lbl_idade = New Label()
        lblPeso = New Label()
        lblAltura = New Label()
        lblGenero = New Label()
        Label20 = New Label()
        btn_voltar = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintDialog1 = New PrintDialog()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(btn_Imprimir, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(347, 12)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(292, 133)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(21, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 18)
        Label1.TabIndex = 2
        Label1.Text = "Usuário:"
        ' 
        ' lblNome
        ' 
        lblNome.AutoSize = True
        lblNome.BackColor = Color.Transparent
        lblNome.Font = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblNome.Location = New Point(89, 24)
        lblNome.Name = "lblNome"
        lblNome.Size = New Size(59, 18)
        lblNome.TabIndex = 3
        lblNome.Text = "lblNome"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(13, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(287, 21)
        Label3.TabIndex = 4
        Label3.Text = "Índice de Massa Corporal (IMC):"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.MediumOrchid
        GroupBox1.Controls.Add(btnRecomendacoes)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(lblCircCinturaIdeal)
        GroupBox1.Controls.Add(lblVolumeSanguineo)
        GroupBox1.Controls.Add(lblProteinas)
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(lblMassaGorda)
        GroupBox1.Controls.Add(lblMassaMagra)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(lblAguaCorporal)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(lblGastoCalorico)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(lblTaxaBasal)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(lblFaixaIMC)
        GroupBox1.Controls.Add(lblValorIMC)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 167)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.No
        GroupBox1.Size = New Size(1000, 377)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dados do usuário:"
        ' 
        ' btnRecomendacoes
        ' 
        btnRecomendacoes.BackColor = Color.Plum
        btnRecomendacoes.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnRecomendacoes.Location = New Point(791, 299)
        btnRecomendacoes.Name = "btnRecomendacoes"
        btnRecomendacoes.Size = New Size(171, 54)
        btnRecomendacoes.TabIndex = 23
        btnRecomendacoes.Text = "Recomendações"
        btnRecomendacoes.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(12, 77)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 21)
        Label4.TabIndex = 24
        Label4.Text = "Avaliado com:"
        ' 
        ' lblCircCinturaIdeal
        ' 
        lblCircCinturaIdeal.AutoSize = True
        lblCircCinturaIdeal.BackColor = SystemColors.ActiveBorder
        lblCircCinturaIdeal.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblCircCinturaIdeal.Location = New Point(288, 342)
        lblCircCinturaIdeal.Name = "lblCircCinturaIdeal"
        lblCircCinturaIdeal.Size = New Size(35, 21)
        lblCircCinturaIdeal.TabIndex = 23
        lblCircCinturaIdeal.Text = "cm"
        ' 
        ' lblVolumeSanguineo
        ' 
        lblVolumeSanguineo.AutoSize = True
        lblVolumeSanguineo.BackColor = SystemColors.ActiveBorder
        lblVolumeSanguineo.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblVolumeSanguineo.Location = New Point(293, 309)
        lblVolumeSanguineo.Name = "lblVolumeSanguineo"
        lblVolumeSanguineo.Size = New Size(20, 21)
        lblVolumeSanguineo.TabIndex = 22
        lblVolumeSanguineo.Text = "L"
        ' 
        ' lblProteinas
        ' 
        lblProteinas.AutoSize = True
        lblProteinas.BackColor = SystemColors.ActiveBorder
        lblProteinas.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblProteinas.Location = New Point(281, 276)
        lblProteinas.Name = "lblProteinas"
        lblProteinas.Size = New Size(57, 21)
        lblProteinas.TabIndex = 21
        lblProteinas.Text = "g/dia"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(13, 342)
        Label18.Name = "Label18"
        Label18.Size = New Size(276, 21)
        Label18.TabIndex = 20
        Label18.Text = "Circunferência ideal de cintura:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(12, 309)
        Label17.Name = "Label17"
        Label17.Size = New Size(281, 21)
        Label17.TabIndex = 19
        Label17.Text = "Volume sanguíneo aproximado:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(13, 277)
        Label16.Name = "Label16"
        Label16.Size = New Size(269, 21)
        Label16.TabIndex = 18
        Label16.Text = "Necessidade proteicas diárias:"
        ' 
        ' lblMassaGorda
        ' 
        lblMassaGorda.AutoSize = True
        lblMassaGorda.BackColor = SystemColors.ActiveBorder
        lblMassaGorda.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblMassaGorda.Location = New Point(135, 245)
        lblMassaGorda.Name = "lblMassaGorda"
        lblMassaGorda.Size = New Size(30, 21)
        lblMassaGorda.TabIndex = 17
        lblMassaGorda.Text = "%"
        ' 
        ' lblMassaMagra
        ' 
        lblMassaMagra.AutoSize = True
        lblMassaMagra.BackColor = SystemColors.ActiveBorder
        lblMassaMagra.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblMassaMagra.Location = New Point(139, 213)
        lblMassaMagra.Name = "lblMassaMagra"
        lblMassaMagra.Size = New Size(30, 21)
        lblMassaMagra.TabIndex = 16
        lblMassaMagra.Text = "%"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(12, 245)
        Label13.Name = "Label13"
        Label13.Size = New Size(124, 21)
        Label13.TabIndex = 15
        Label13.Text = "Massa gorda:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(13, 213)
        Label12.Name = "Label12"
        Label12.Size = New Size(128, 21)
        Label12.TabIndex = 14
        Label12.Text = "Massa magra:"
        ' 
        ' lblAguaCorporal
        ' 
        lblAguaCorporal.AutoSize = True
        lblAguaCorporal.BackColor = SystemColors.ActiveBorder
        lblAguaCorporal.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblAguaCorporal.Location = New Point(193, 178)
        lblAguaCorporal.Name = "lblAguaCorporal"
        lblAguaCorporal.Size = New Size(20, 21)
        lblAguaCorporal.TabIndex = 13
        lblAguaCorporal.Text = "L"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(13, 178)
        Label10.Name = "Label10"
        Label10.Size = New Size(181, 21)
        Label10.TabIndex = 12
        Label10.Text = "Água corporal total:"
        ' 
        ' lblGastoCalorico
        ' 
        lblGastoCalorico.AutoSize = True
        lblGastoCalorico.BackColor = SystemColors.ActiveBorder
        lblGastoCalorico.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblGastoCalorico.Location = New Point(194, 145)
        lblGastoCalorico.Name = "lblGastoCalorico"
        lblGastoCalorico.Size = New Size(82, 21)
        lblGastoCalorico.TabIndex = 11
        lblGastoCalorico.Text = "Kcal/dia"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(13, 145)
        Label8.Name = "Label8"
        Label8.Size = New Size(183, 21)
        Label8.TabIndex = 10
        Label8.Text = "Gasto calórico total:"
        ' 
        ' lblTaxaBasal
        ' 
        lblTaxaBasal.AutoSize = True
        lblTaxaBasal.BackColor = SystemColors.ActiveBorder
        lblTaxaBasal.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblTaxaBasal.Location = New Point(216, 111)
        lblTaxaBasal.Name = "lblTaxaBasal"
        lblTaxaBasal.Size = New Size(82, 21)
        lblTaxaBasal.TabIndex = 9
        lblTaxaBasal.Text = "Kcal/dia"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(13, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(205, 21)
        Label5.TabIndex = 8
        Label5.Text = "Taxa metabólica basal:"
        ' 
        ' lblFaixaIMC
        ' 
        lblFaixaIMC.AutoSize = True
        lblFaixaIMC.BackColor = SystemColors.ActiveBorder
        lblFaixaIMC.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblFaixaIMC.Location = New Point(139, 77)
        lblFaixaIMC.Name = "lblFaixaIMC"
        lblFaixaIMC.Size = New Size(103, 21)
        lblFaixaIMC.TabIndex = 7
        lblFaixaIMC.Text = "FAIXA IMC"
        ' 
        ' lblValorIMC
        ' 
        lblValorIMC.AutoSize = True
        lblValorIMC.BackColor = SystemColors.ActiveBorder
        lblValorIMC.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblValorIMC.Location = New Point(299, 45)
        lblValorIMC.Name = "lblValorIMC"
        lblValorIMC.Size = New Size(107, 21)
        lblValorIMC.TabIndex = 5
        lblValorIMC.Text = "VALOR IMC"
        ' 
        ' btn_Imprimir
        ' 
        btn_Imprimir.BackColor = Color.Transparent
        btn_Imprimir.BackgroundImage = CType(resources.GetObject("btn_Imprimir.BackgroundImage"), Image)
        btn_Imprimir.BackgroundImageLayout = ImageLayout.Stretch
        btn_Imprimir.Location = New Point(948, 110)
        btn_Imprimir.Margin = New Padding(3, 4, 3, 4)
        btn_Imprimir.Name = "btn_Imprimir"
        btn_Imprimir.Size = New Size(64, 49)
        btn_Imprimir.TabIndex = 6
        btn_Imprimir.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(21, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 18)
        Label6.TabIndex = 7
        Label6.Text = "Idade:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(21, 101)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 18)
        Label7.TabIndex = 8
        Label7.Text = "Peso:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(21, 125)
        Label9.Name = "Label9"
        Label9.Size = New Size(59, 18)
        Label9.TabIndex = 9
        Label9.Text = "Altura:"
        ' 
        ' lbl_idade
        ' 
        lbl_idade.AutoSize = True
        lbl_idade.BackColor = Color.Transparent
        lbl_idade.Font = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_idade.Location = New Point(75, 76)
        lbl_idade.Name = "lbl_idade"
        lbl_idade.Size = New Size(62, 18)
        lbl_idade.TabIndex = 10
        lbl_idade.Text = "lbl_idade"
        ' 
        ' lblPeso
        ' 
        lblPeso.AutoSize = True
        lblPeso.BackColor = Color.Transparent
        lblPeso.Font = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeso.Location = New Point(68, 101)
        lblPeso.Name = "lblPeso"
        lblPeso.Size = New Size(51, 18)
        lblPeso.TabIndex = 11
        lblPeso.Text = "lblPeso"
        ' 
        ' lblAltura
        ' 
        lblAltura.AutoSize = True
        lblAltura.BackColor = Color.Transparent
        lblAltura.Font = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblAltura.Location = New Point(77, 125)
        lblAltura.Name = "lblAltura"
        lblAltura.Size = New Size(57, 18)
        lblAltura.TabIndex = 12
        lblAltura.Text = "lblAltura"
        ' 
        ' lblGenero
        ' 
        lblGenero.AutoSize = True
        lblGenero.BackColor = Color.Transparent
        lblGenero.Font = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblGenero.Location = New Point(85, 50)
        lblGenero.Name = "lblGenero"
        lblGenero.Size = New Size(67, 18)
        lblGenero.TabIndex = 13
        lblGenero.Text = "lblGenero"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.Location = New Point(21, 50)
        Label20.Name = "Label20"
        Label20.Size = New Size(67, 18)
        Label20.TabIndex = 14
        Label20.Text = "Gênero:"
        ' 
        ' btn_voltar
        ' 
        btn_voltar.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btn_voltar.Location = New Point(926, 13)
        btn_voltar.Margin = New Padding(3, 4, 3, 4)
        btn_voltar.Name = "btn_voltar"
        btn_voltar.Size = New Size(86, 40)
        btn_voltar.TabIndex = 21
        btn_voltar.Text = "Voltar"
        btn_voltar.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(178, 556)
        Label2.Name = "Label2"
        Label2.Size = New Size(676, 18)
        Label2.TabIndex = 22
        Label2.Text = "Métricas calculadas de acordo com o gênero, idade, peso e altura fornecidos pelo usuário."
        ' 
        ' AvaliacaoUsuario
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1024, 583)
        Controls.Add(Label2)
        Controls.Add(btn_voltar)
        Controls.Add(Label20)
        Controls.Add(lblGenero)
        Controls.Add(lblAltura)
        Controls.Add(lblPeso)
        Controls.Add(lbl_idade)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(btn_Imprimir)
        Controls.Add(GroupBox1)
        Controls.Add(lblNome)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AvaliacaoUsuario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Perfil Metabólico - Projetinho"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(btn_Imprimir, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblValorIMC As Label
    Friend WithEvents lblFaixaIMC As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblGastoCalorico As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTaxaBasal As Label
    Friend WithEvents lblAguaCorporal As Label
    Friend WithEvents lblMassaGorda As Label
    Friend WithEvents lblMassaMagra As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblVolumeSanguineo As Label
    Friend WithEvents lblProteinas As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblCircCinturaIdeal As Label
    Friend WithEvents btn_Imprimir As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_idade As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblAltura As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btn_voltar As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRecomendacoes As Button
End Class
