<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaInicial))
        MenuStrip1 = New MenuStrip()
        UsuarioToolStripMenuItem = New ToolStripMenuItem()
        CadastrarDadosToolStripMenuItem = New ToolStripMenuItem()
        EditarSenharToolStripMenuItem = New ToolStripMenuItem()
        EditarContasToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        SairToolStripMenuItem = New ToolStripMenuItem()
        TreinoToolStripMenuItem = New ToolStripMenuItem()
        GerenciadorDeTreinosToolStripMenuItem = New ToolStripMenuItem()
        MontarCardioToolStripMenuItem = New ToolStripMenuItem()
        MeusTreinosToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        cardioBTN = New Button()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        avaliacaoBTN = New Button()
        meustreinosbtn = New Button()
        Label2 = New Label()
        cadastrobtn = New Button()
        montartreinobtn = New Button()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.SlateBlue
        MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), Image)
        MenuStrip1.Font = New Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {UsuarioToolStripMenuItem, TreinoToolStripMenuItem, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(761, 26)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' UsuarioToolStripMenuItem
        ' 
        UsuarioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CadastrarDadosToolStripMenuItem, EditarSenharToolStripMenuItem, EditarContasToolStripMenuItem, ToolStripMenuItem2, SairToolStripMenuItem})
        UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        UsuarioToolStripMenuItem.Size = New Size(68, 22)
        UsuarioToolStripMenuItem.Text = "&Usuário"
        ' 
        ' CadastrarDadosToolStripMenuItem
        ' 
        CadastrarDadosToolStripMenuItem.Name = "CadastrarDadosToolStripMenuItem"
        CadastrarDadosToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F1
        CadastrarDadosToolStripMenuItem.Size = New Size(239, 22)
        CadastrarDadosToolStripMenuItem.Text = "&Cadastrar dados"
        ' 
        ' EditarSenharToolStripMenuItem
        ' 
        EditarSenharToolStripMenuItem.Name = "EditarSenharToolStripMenuItem"
        EditarSenharToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F2
        EditarSenharToolStripMenuItem.Size = New Size(239, 22)
        EditarSenharToolStripMenuItem.Text = "&Editar Senha"
        ' 
        ' EditarContasToolStripMenuItem
        ' 
        EditarContasToolStripMenuItem.Name = "EditarContasToolStripMenuItem"
        EditarContasToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F3
        EditarContasToolStripMenuItem.Size = New Size(239, 22)
        EditarContasToolStripMenuItem.Text = "Editar Contas"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.ShortcutKeys = Keys.Control Or Keys.F5
        ToolStripMenuItem2.Size = New Size(239, 22)
        ToolStripMenuItem2.Text = "Avaliação "
        ' 
        ' SairToolStripMenuItem
        ' 
        SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        SairToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        SairToolStripMenuItem.Size = New Size(239, 22)
        SairToolStripMenuItem.Text = "&Sair"
        ' 
        ' TreinoToolStripMenuItem
        ' 
        TreinoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GerenciadorDeTreinosToolStripMenuItem, MontarCardioToolStripMenuItem, MeusTreinosToolStripMenuItem})
        TreinoToolStripMenuItem.Name = "TreinoToolStripMenuItem"
        TreinoToolStripMenuItem.Size = New Size(61, 22)
        TreinoToolStripMenuItem.Text = "&Treino"
        ' 
        ' GerenciadorDeTreinosToolStripMenuItem
        ' 
        GerenciadorDeTreinosToolStripMenuItem.Name = "GerenciadorDeTreinosToolStripMenuItem"
        GerenciadorDeTreinosToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.G
        GerenciadorDeTreinosToolStripMenuItem.Size = New Size(218, 22)
        GerenciadorDeTreinosToolStripMenuItem.Text = "Montar Treino"
        ' 
        ' MontarCardioToolStripMenuItem
        ' 
        MontarCardioToolStripMenuItem.Name = "MontarCardioToolStripMenuItem"
        MontarCardioToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.L
        MontarCardioToolStripMenuItem.Size = New Size(218, 22)
        MontarCardioToolStripMenuItem.Text = "Montar Cardio"
        ' 
        ' MeusTreinosToolStripMenuItem
        ' 
        MeusTreinosToolStripMenuItem.Name = "MeusTreinosToolStripMenuItem"
        MeusTreinosToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.T
        MeusTreinosToolStripMenuItem.Size = New Size(218, 22)
        MeusTreinosToolStripMenuItem.Text = "&Meus Treinos"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(57, 22)
        ToolStripMenuItem1.Text = "&Sobre"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(266, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(296, 111)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(222), CByte(222), CByte(255))
        GroupBox1.Controls.Add(cardioBTN)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(avaliacaoBTN)
        GroupBox1.Controls.Add(meustreinosbtn)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(cadastrobtn)
        GroupBox1.Controls.Add(montartreinobtn)
        GroupBox1.Location = New Point(246, 117)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(350, 382)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' cardioBTN
        ' 
        cardioBTN.BackColor = Color.MediumPurple
        cardioBTN.Cursor = Cursors.IBeam
        cardioBTN.FlatStyle = FlatStyle.Popup
        cardioBTN.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        cardioBTN.Location = New Point(108, 279)
        cardioBTN.Name = "cardioBTN"
        cardioBTN.Size = New Size(142, 24)
        cardioBTN.TabIndex = 7
        cardioBTN.Text = "Montar Cardio"
        cardioBTN.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(72, -4)
        Label1.Name = "Label1"
        Label1.Size = New Size(205, 23)
        Label1.TabIndex = 0
        Label1.Text = "Bem-Vindo ao Projetinho"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(50, 17)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(259, 182)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' avaliacaoBTN
        ' 
        avaliacaoBTN.BackColor = Color.MediumPurple
        avaliacaoBTN.Cursor = Cursors.IBeam
        avaliacaoBTN.FlatStyle = FlatStyle.Popup
        avaliacaoBTN.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        avaliacaoBTN.Location = New Point(108, 309)
        avaliacaoBTN.Name = "avaliacaoBTN"
        avaliacaoBTN.Size = New Size(142, 24)
        avaliacaoBTN.TabIndex = 6
        avaliacaoBTN.Text = "Avaliação"
        avaliacaoBTN.UseVisualStyleBackColor = False
        ' 
        ' meustreinosbtn
        ' 
        meustreinosbtn.BackColor = Color.MediumOrchid
        meustreinosbtn.Cursor = Cursors.IBeam
        meustreinosbtn.FlatStyle = FlatStyle.Popup
        meustreinosbtn.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        meustreinosbtn.Location = New Point(108, 339)
        meustreinosbtn.Name = "meustreinosbtn"
        meustreinosbtn.Size = New Size(142, 23)
        meustreinosbtn.TabIndex = 4
        meustreinosbtn.Text = "Meus Treinos"
        meustreinosbtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(90, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 23)
        Label2.TabIndex = 5
        Label2.Text = "Selecione uma Opção:"
        ' 
        ' cadastrobtn
        ' 
        cadastrobtn.BackColor = Color.MediumPurple
        cadastrobtn.Cursor = Cursors.IBeam
        cadastrobtn.FlatStyle = FlatStyle.Popup
        cadastrobtn.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        cadastrobtn.Location = New Point(108, 220)
        cadastrobtn.Name = "cadastrobtn"
        cadastrobtn.Size = New Size(142, 23)
        cadastrobtn.TabIndex = 3
        cadastrobtn.Text = "Cadastro"
        cadastrobtn.UseVisualStyleBackColor = False
        ' 
        ' montartreinobtn
        ' 
        montartreinobtn.BackColor = Color.MediumPurple
        montartreinobtn.Cursor = Cursors.IBeam
        montartreinobtn.FlatStyle = FlatStyle.Popup
        montartreinobtn.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        montartreinobtn.Location = New Point(108, 249)
        montartreinobtn.Name = "montartreinobtn"
        montartreinobtn.Size = New Size(142, 24)
        montartreinobtn.TabIndex = 2
        montartreinobtn.Text = "Montar Treino"
        montartreinobtn.UseVisualStyleBackColor = False
        ' 
        ' TelaInicial
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(761, 517)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        ForeColor = Color.Black
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "TelaInicial"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bem vindo - Projetinho"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarDadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarSenharToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreinoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciadorDeTreinosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents montartreinobtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents meustreinosbtn As Button
    Friend WithEvents cadastrobtn As Button
    Friend WithEvents MeusTreinosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditarContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents avaliacaoBTN As Button
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents cardioBTN As Button
    Friend WithEvents MontarCardioToolStripMenuItem As ToolStripMenuItem
End Class
