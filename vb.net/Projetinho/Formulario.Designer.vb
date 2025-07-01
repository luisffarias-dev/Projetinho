<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario))
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        LinkLabel1 = New LinkLabel()
        Button2 = New Button()
        SexoPerfil = New ComboBox()
        img_foto = New PictureBox()
        DateTimePerfil = New DateTimePicker()
        Label6 = New Label()
        PesoPerfil = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        AlturaPerfil = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        NomePerfil = New TextBox()
        Label1 = New Label()
        LinkLabel2 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(img_foto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(275, 3)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(338, 171)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.MediumPurple
        GroupBox1.Controls.Add(LinkLabel1)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(SexoPerfil)
        GroupBox1.Controls.Add(img_foto)
        GroupBox1.Controls.Add(DateTimePerfil)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(PesoPerfil)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(AlturaPerfil)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(NomePerfil)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(105, 181)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.RightToLeft = RightToLeft.No
        GroupBox1.Size = New Size(735, 403)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Perfil"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(653, 21)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(81, 28)
        LinkLabel1.TabIndex = 19
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Editar"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(371, 331)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(307, 45)
        Button2.TabIndex = 18
        Button2.Text = "Salvar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' SexoPerfil
        ' 
        SexoPerfil.FormattingEnabled = True
        SexoPerfil.Items.AddRange(New Object() {"Masculino", "Feminino"})
        SexoPerfil.Location = New Point(318, 169)
        SexoPerfil.Margin = New Padding(3, 4, 3, 4)
        SexoPerfil.Name = "SexoPerfil"
        SexoPerfil.Size = New Size(399, 36)
        SexoPerfil.TabIndex = 16
        ' 
        ' img_foto
        ' 
        img_foto.BackgroundImageLayout = ImageLayout.None
        img_foto.ErrorImage = CType(resources.GetObject("img_foto.ErrorImage"), Image)
        img_foto.Image = CType(resources.GetObject("img_foto.Image"), Image)
        img_foto.InitialImage = CType(resources.GetObject("img_foto.InitialImage"), Image)
        img_foto.Location = New Point(25, 80)
        img_foto.Margin = New Padding(3, 4, 3, 4)
        img_foto.Name = "img_foto"
        img_foto.Size = New Size(251, 131)
        img_foto.SizeMode = PictureBoxSizeMode.StretchImage
        img_foto.TabIndex = 15
        img_foto.TabStop = False
        ' 
        ' DateTimePerfil
        ' 
        DateTimePerfil.CustomFormat = "dd/MM/yyyy"
        DateTimePerfil.Format = DateTimePickerFormat.Custom
        DateTimePerfil.Location = New Point(318, 260)
        DateTimePerfil.Margin = New Padding(3, 4, 3, 4)
        DateTimePerfil.MaxDate = New Date(2005, 12, 31, 0, 0, 0, 0)
        DateTimePerfil.Name = "DateTimePerfil"
        DateTimePerfil.Size = New Size(399, 35)
        DateTimePerfil.TabIndex = 13
        DateTimePerfil.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(25, 45)
        Label6.Name = "Label6"
        Label6.RightToLeft = RightToLeft.No
        Label6.Size = New Size(284, 28)
        Label6.TabIndex = 10
        Label6.Text = "Selecione sua Imagem:"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PesoPerfil
        ' 
        PesoPerfil.Location = New Point(25, 333)
        PesoPerfil.Margin = New Padding(3, 4, 3, 4)
        PesoPerfil.Name = "PesoPerfil"
        PesoPerfil.Size = New Size(251, 35)
        PesoPerfil.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 301)
        Label5.Name = "Label5"
        Label5.Size = New Size(167, 28)
        Label5.TabIndex = 8
        Label5.Text = "Peso (em Kg)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(318, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(212, 28)
        Label4.TabIndex = 6
        Label4.Text = "Data Nascimento"
        ' 
        ' AlturaPerfil
        ' 
        AlturaPerfil.Location = New Point(25, 255)
        AlturaPerfil.Margin = New Padding(3, 4, 3, 4)
        AlturaPerfil.Name = "AlturaPerfil"
        AlturaPerfil.Size = New Size(251, 35)
        AlturaPerfil.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 28)
        Label3.TabIndex = 4
        Label3.Text = "Altura (em cm)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(318, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 28)
        Label2.TabIndex = 2
        Label2.Text = "Sexo"
        ' 
        ' NomePerfil
        ' 
        NomePerfil.Location = New Point(318, 81)
        NomePerfil.Margin = New Padding(3, 4, 3, 4)
        NomePerfil.Name = "NomePerfil"
        NomePerfil.Size = New Size(399, 35)
        NomePerfil.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(318, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 28)
        Label1.TabIndex = 0
        Label1.Text = "Nome Completo"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.Transparent
        LinkLabel2.AutoSize = True
        LinkLabel2.BackColor = Color.Transparent
        LinkLabel2.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LinkLabel2.LinkColor = SystemColors.MenuHighlight
        LinkLabel2.Location = New Point(1, 9)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(71, 24)
        LinkLabel2.TabIndex = 2
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Voltar"
        LinkLabel2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Formulario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(914, 600)
        Controls.Add(LinkLabel2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Formulario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cadastro de usuário - Projetinho"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(img_foto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AlturaPerfil As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NomePerfil As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePerfil As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents PesoPerfil As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents SexoPerfil As ComboBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
