<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerenciador_Treinos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerenciador_Treinos))
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        DataTreino = New DateTimePicker()
        avancadoM = New PictureBox()
        intermediarioM = New PictureBox()
        inicianteM = New PictureBox()
        btnTipoTreino = New Button()
        avancadoH = New PictureBox()
        avancadoCheck = New CheckBox()
        intermediarioH = New PictureBox()
        inicianteH = New PictureBox()
        intermediarioCheck = New CheckBox()
        inicianteCheck = New CheckBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        PictureBox1 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        GroupBox1.SuspendLayout()
        CType(avancadoM, ComponentModel.ISupportInitialize).BeginInit()
        CType(intermediarioM, ComponentModel.ISupportInitialize).BeginInit()
        CType(inicianteM, ComponentModel.ISupportInitialize).BeginInit()
        CType(avancadoH, ComponentModel.ISupportInitialize).BeginInit()
        CType(intermediarioH, ComponentModel.ISupportInitialize).BeginInit()
        CType(inicianteH, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(DataTreino)
        GroupBox1.Controls.Add(avancadoM)
        GroupBox1.Controls.Add(intermediarioM)
        GroupBox1.Controls.Add(inicianteM)
        GroupBox1.Controls.Add(btnTipoTreino)
        GroupBox1.Controls.Add(avancadoH)
        GroupBox1.Controls.Add(avancadoCheck)
        GroupBox1.Controls.Add(intermediarioH)
        GroupBox1.Controls.Add(inicianteH)
        GroupBox1.Controls.Add(intermediarioCheck)
        GroupBox1.Controls.Add(inicianteCheck)
        GroupBox1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(13, 93)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(902, 556)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Escolha uma Opção:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(279, 356)
        Label2.Name = "Label2"
        Label2.Size = New Size(392, 24)
        Label2.TabIndex = 12
        Label2.Text = "Bora treinar! Escolha seu foco de hoje"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(315, 406)
        Label1.Name = "Label1"
        Label1.Size = New Size(304, 24)
        Label1.TabIndex = 11
        Label1.Text = "Escolha a Data Do Seu Treino"
        ' 
        ' DataTreino
        ' 
        DataTreino.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataTreino.Format = DateTimePickerFormat.Short
        DataTreino.Location = New Point(350, 436)
        DataTreino.Margin = New Padding(3, 4, 3, 4)
        DataTreino.MinDate = New Date(2025, 4, 15, 0, 0, 0, 0)
        DataTreino.Name = "DataTreino"
        DataTreino.Size = New Size(230, 30)
        DataTreino.TabIndex = 10
        DataTreino.Value = New Date(2025, 5, 6, 3, 31, 59, 0)
        ' 
        ' avancadoM
        ' 
        avancadoM.BackgroundImage = CType(resources.GetObject("avancadoM.BackgroundImage"), Image)
        avancadoM.BackgroundImageLayout = ImageLayout.Stretch
        avancadoM.Location = New Point(632, 61)
        avancadoM.Margin = New Padding(3, 4, 3, 4)
        avancadoM.Name = "avancadoM"
        avancadoM.Size = New Size(199, 245)
        avancadoM.TabIndex = 9
        avancadoM.TabStop = False
        ' 
        ' intermediarioM
        ' 
        intermediarioM.BackgroundImage = CType(resources.GetObject("intermediarioM.BackgroundImage"), Image)
        intermediarioM.BackgroundImageLayout = ImageLayout.Stretch
        intermediarioM.Location = New Point(370, 61)
        intermediarioM.Margin = New Padding(3, 4, 3, 4)
        intermediarioM.Name = "intermediarioM"
        intermediarioM.Size = New Size(199, 245)
        intermediarioM.TabIndex = 8
        intermediarioM.TabStop = False
        ' 
        ' inicianteM
        ' 
        inicianteM.BackgroundImage = CType(resources.GetObject("inicianteM.BackgroundImage"), Image)
        inicianteM.BackgroundImageLayout = ImageLayout.Stretch
        inicianteM.Location = New Point(112, 61)
        inicianteM.Margin = New Padding(3, 4, 3, 4)
        inicianteM.Name = "inicianteM"
        inicianteM.Size = New Size(199, 245)
        inicianteM.TabIndex = 7
        inicianteM.TabStop = False
        ' 
        ' btnTipoTreino
        ' 
        btnTipoTreino.Location = New Point(350, 478)
        btnTipoTreino.Margin = New Padding(3, 4, 3, 4)
        btnTipoTreino.Name = "btnTipoTreino"
        btnTipoTreino.Size = New Size(231, 45)
        btnTipoTreino.TabIndex = 6
        btnTipoTreino.Text = "Confirmar"
        btnTipoTreino.UseVisualStyleBackColor = True
        ' 
        ' avancadoH
        ' 
        avancadoH.BackgroundImage = CType(resources.GetObject("avancadoH.BackgroundImage"), Image)
        avancadoH.BackgroundImageLayout = ImageLayout.Stretch
        avancadoH.Location = New Point(632, 63)
        avancadoH.Margin = New Padding(3, 4, 3, 4)
        avancadoH.Name = "avancadoH"
        avancadoH.Size = New Size(199, 245)
        avancadoH.TabIndex = 5
        avancadoH.TabStop = False
        ' 
        ' avancadoCheck
        ' 
        avancadoCheck.AutoSize = True
        avancadoCheck.BackColor = Color.Transparent
        avancadoCheck.Location = New Point(623, 316)
        avancadoCheck.Margin = New Padding(3, 4, 3, 4)
        avancadoCheck.Name = "avancadoCheck"
        avancadoCheck.Size = New Size(224, 22)
        avancadoCheck.TabIndex = 4
        avancadoCheck.Text = "Prefiro montar meu treino"
        avancadoCheck.UseVisualStyleBackColor = False
        ' 
        ' intermediarioH
        ' 
        intermediarioH.BackgroundImage = CType(resources.GetObject("intermediarioH.BackgroundImage"), Image)
        intermediarioH.BackgroundImageLayout = ImageLayout.Stretch
        intermediarioH.Location = New Point(370, 63)
        intermediarioH.Margin = New Padding(3, 4, 3, 4)
        intermediarioH.Name = "intermediarioH"
        intermediarioH.Size = New Size(199, 245)
        intermediarioH.TabIndex = 3
        intermediarioH.TabStop = False
        ' 
        ' inicianteH
        ' 
        inicianteH.BackgroundImage = CType(resources.GetObject("inicianteH.BackgroundImage"), Image)
        inicianteH.BackgroundImageLayout = ImageLayout.Stretch
        inicianteH.Location = New Point(112, 63)
        inicianteH.Margin = New Padding(3, 4, 3, 4)
        inicianteH.Name = "inicianteH"
        inicianteH.Size = New Size(199, 245)
        inicianteH.TabIndex = 2
        inicianteH.TabStop = False
        ' 
        ' intermediarioCheck
        ' 
        intermediarioCheck.AutoSize = True
        intermediarioCheck.BackColor = Color.Transparent
        intermediarioCheck.Location = New Point(350, 316)
        intermediarioCheck.Margin = New Padding(3, 4, 3, 4)
        intermediarioCheck.Name = "intermediarioCheck"
        intermediarioCheck.Size = New Size(257, 22)
        intermediarioCheck.TabIndex = 1
        intermediarioCheck.Text = "Monte um treino intermediário"
        intermediarioCheck.UseVisualStyleBackColor = False
        ' 
        ' inicianteCheck
        ' 
        inicianteCheck.AutoSize = True
        inicianteCheck.BackColor = Color.Transparent
        inicianteCheck.Location = New Point(98, 316)
        inicianteCheck.Margin = New Padding(3, 4, 3, 4)
        inicianteCheck.Name = "inicianteCheck"
        inicianteCheck.Size = New Size(224, 22)
        inicianteCheck.TabIndex = 0
        inicianteCheck.Text = "Monte um treino para mim"
        inicianteCheck.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(317, -2)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(358, 109)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkColor = SystemColors.MenuHighlight
        LinkLabel1.Location = New Point(3, 9)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(63, 24)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Voltar"
        LinkLabel1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Gerenciador_Treinos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(944, 663)
        Controls.Add(LinkLabel1)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Gerenciador_Treinos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Escolher Treino - Projetinho"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(avancadoM, ComponentModel.ISupportInitialize).EndInit()
        CType(intermediarioM, ComponentModel.ISupportInitialize).EndInit()
        CType(inicianteM, ComponentModel.ISupportInitialize).EndInit()
        CType(avancadoH, ComponentModel.ISupportInitialize).EndInit()
        CType(intermediarioH, ComponentModel.ISupportInitialize).EndInit()
        CType(inicianteH, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents intermediarioH As PictureBox
    Friend WithEvents inicianteH As PictureBox
    Friend WithEvents intermediarioCheck As CheckBox
    Friend WithEvents inicianteCheck As CheckBox
    Friend WithEvents avancadoH As PictureBox
    Friend WithEvents avancadoCheck As CheckBox
    Friend WithEvents btnTipoTreino As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents DataTreino As DateTimePicker
    Friend WithEvents avancadoM As PictureBox
    Friend WithEvents intermediarioM As PictureBox
    Friend WithEvents inicianteM As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
