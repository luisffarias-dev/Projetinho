<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recomendacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recomendacoes))
        rtbRecomendacoes = New RichTextBox()
        Label20 = New Label()
        lblGenero = New Label()
        lblAltura = New Label()
        lblPeso = New Label()
        lbl_idade = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        lblNome = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btn_voltar = New Button()
        PrintDialog1 = New PrintDialog()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' rtbRecomendacoes
        ' 
        rtbRecomendacoes.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        rtbRecomendacoes.Location = New Point(16, 165)
        rtbRecomendacoes.Name = "rtbRecomendacoes"
        rtbRecomendacoes.ReadOnly = True
        rtbRecomendacoes.Size = New Size(863, 338)
        rtbRecomendacoes.TabIndex = 0
        rtbRecomendacoes.Text = ""
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.Location = New Point(16, 51)
        Label20.Name = "Label20"
        Label20.Size = New Size(67, 18)
        Label20.TabIndex = 25
        Label20.Text = "Gênero:"
        ' 
        ' lblGenero
        ' 
        lblGenero.AutoSize = True
        lblGenero.BackColor = Color.Transparent
        lblGenero.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblGenero.Location = New Point(80, 51)
        lblGenero.Name = "lblGenero"
        lblGenero.Size = New Size(67, 18)
        lblGenero.TabIndex = 24
        lblGenero.Text = "lblGenero"
        ' 
        ' lblAltura
        ' 
        lblAltura.AutoSize = True
        lblAltura.BackColor = Color.Transparent
        lblAltura.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblAltura.Location = New Point(72, 126)
        lblAltura.Name = "lblAltura"
        lblAltura.Size = New Size(57, 18)
        lblAltura.TabIndex = 23
        lblAltura.Text = "lblAltura"
        ' 
        ' lblPeso
        ' 
        lblPeso.AutoSize = True
        lblPeso.BackColor = Color.Transparent
        lblPeso.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPeso.Location = New Point(63, 102)
        lblPeso.Name = "lblPeso"
        lblPeso.Size = New Size(51, 18)
        lblPeso.TabIndex = 22
        lblPeso.Text = "lblPeso"
        ' 
        ' lbl_idade
        ' 
        lbl_idade.AutoSize = True
        lbl_idade.BackColor = Color.Transparent
        lbl_idade.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_idade.Location = New Point(70, 77)
        lbl_idade.Name = "lbl_idade"
        lbl_idade.Size = New Size(62, 18)
        lbl_idade.TabIndex = 21
        lbl_idade.Text = "lbl_idade"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(16, 126)
        Label9.Name = "Label9"
        Label9.Size = New Size(59, 18)
        Label9.TabIndex = 20
        Label9.Text = "Altura:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(16, 102)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 18)
        Label7.TabIndex = 19
        Label7.Text = "Peso:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(16, 77)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 18)
        Label6.TabIndex = 18
        Label6.Text = "Idade:"
        ' 
        ' lblNome
        ' 
        lblNome.AutoSize = True
        lblNome.BackColor = Color.Transparent
        lblNome.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblNome.Location = New Point(84, 25)
        lblNome.Name = "lblNome"
        lblNome.Size = New Size(59, 18)
        lblNome.TabIndex = 17
        lblNome.Text = "lblNome"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(16, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 18)
        Label1.TabIndex = 16
        Label1.Text = "Usuário:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(307, 11)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(292, 133)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' btn_voltar
        ' 
        btn_voltar.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_voltar.Location = New Point(789, 13)
        btn_voltar.Margin = New Padding(3, 4, 3, 4)
        btn_voltar.Name = "btn_voltar"
        btn_voltar.Size = New Size(86, 40)
        btn_voltar.TabIndex = 26
        btn_voltar.Text = "Voltar"
        btn_voltar.UseVisualStyleBackColor = True
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Recomendacoes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(892, 515)
        Controls.Add(btn_voltar)
        Controls.Add(Label20)
        Controls.Add(lblGenero)
        Controls.Add(lblAltura)
        Controls.Add(lblPeso)
        Controls.Add(lbl_idade)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(lblNome)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(rtbRecomendacoes)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Recomendacoes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Recomendações - Projetinho"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rtbRecomendacoes As RichTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents lblAltura As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents lbl_idade As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_voltar As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
