<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarSenha))
        PictureBox1 = New PictureBox()
        SenhaAntigaRecuperar = New TextBox()
        EmailRecuperar = New TextBox()
        btnatualizar = New Button()
        Label3 = New Label()
        Label2 = New Label()
        NovaSenhaRecuperar = New TextBox()
        Label1 = New Label()
        LinkLabel1 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(280, 81)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(354, 188)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' SenhaAntigaRecuperar
        ' 
        SenhaAntigaRecuperar.Location = New Point(280, 368)
        SenhaAntigaRecuperar.Margin = New Padding(3, 4, 3, 4)
        SenhaAntigaRecuperar.Name = "SenhaAntigaRecuperar"
        SenhaAntigaRecuperar.PasswordChar = "*"c
        SenhaAntigaRecuperar.Size = New Size(354, 27)
        SenhaAntigaRecuperar.TabIndex = 14
        ' 
        ' EmailRecuperar
        ' 
        EmailRecuperar.Location = New Point(280, 297)
        EmailRecuperar.Margin = New Padding(3, 4, 3, 4)
        EmailRecuperar.Name = "EmailRecuperar"
        EmailRecuperar.Size = New Size(354, 27)
        EmailRecuperar.TabIndex = 13
        ' 
        ' btnatualizar
        ' 
        btnatualizar.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnatualizar.Location = New Point(374, 492)
        btnatualizar.Margin = New Padding(3, 4, 3, 4)
        btnatualizar.Name = "btnatualizar"
        btnatualizar.Size = New Size(181, 40)
        btnatualizar.TabIndex = 11
        btnatualizar.Text = "Atualizar Senha"
        btnatualizar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(280, 344)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 18)
        Label3.TabIndex = 10
        Label3.Text = "Senha Antiga"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(280, 273)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 18)
        Label2.TabIndex = 9
        Label2.Text = "Email"
        ' 
        ' NovaSenhaRecuperar
        ' 
        NovaSenhaRecuperar.Location = New Point(280, 453)
        NovaSenhaRecuperar.Margin = New Padding(3, 4, 3, 4)
        NovaSenhaRecuperar.Name = "NovaSenhaRecuperar"
        NovaSenhaRecuperar.PasswordChar = "*"c
        NovaSenhaRecuperar.Size = New Size(354, 27)
        NovaSenhaRecuperar.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(280, 429)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 18)
        Label1.TabIndex = 16
        Label1.Text = "Nova Senha"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkColor = SystemColors.MenuHighlight
        LinkLabel1.Location = New Point(1, 9)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(63, 24)
        LinkLabel1.TabIndex = 18
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Voltar"
        LinkLabel1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' EditarSenha
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(914, 600)
        Controls.Add(LinkLabel1)
        Controls.Add(NovaSenhaRecuperar)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(SenhaAntigaRecuperar)
        Controls.Add(EmailRecuperar)
        Controls.Add(btnatualizar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "EditarSenha"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Alterar senha - Projetinho"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SenhaAntigaRecuperar As TextBox
    Friend WithEvents EmailRecuperar As TextBox
    Friend WithEvents btnatualizar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NovaSenhaRecuperar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblNomeUsuario As Label
End Class
