<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        LinkCadastrar = New LinkLabel()
        EmailLoginBox = New TextBox()
        SenhaLoginBox = New TextBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(246, 233)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 18)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(246, 304)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 18)
        Label3.TabIndex = 2
        Label3.Text = "Senha"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(333, 384)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(181, 40)
        Button1.TabIndex = 3
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkCadastrar
        ' 
        LinkCadastrar.AutoSize = True
        LinkCadastrar.BackColor = Color.Transparent
        LinkCadastrar.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LinkCadastrar.Location = New Point(387, 459)
        LinkCadastrar.Name = "LinkCadastrar"
        LinkCadastrar.Size = New Size(82, 18)
        LinkCadastrar.TabIndex = 4
        LinkCadastrar.TabStop = True
        LinkCadastrar.Text = "Cadastrar"
        ' 
        ' EmailLoginBox
        ' 
        EmailLoginBox.Location = New Point(246, 257)
        EmailLoginBox.Margin = New Padding(3, 4, 3, 4)
        EmailLoginBox.Name = "EmailLoginBox"
        EmailLoginBox.Size = New Size(354, 27)
        EmailLoginBox.TabIndex = 5
        ' 
        ' SenhaLoginBox
        ' 
        SenhaLoginBox.Location = New Point(246, 328)
        SenhaLoginBox.Margin = New Padding(3, 4, 3, 4)
        SenhaLoginBox.Name = "SenhaLoginBox"
        SenhaLoginBox.PasswordChar = "*"c
        SenhaLoginBox.Size = New Size(354, 27)
        SenhaLoginBox.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(246, 41)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(354, 188)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(335, 428)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 18)
        Label1.TabIndex = 8
        Label1.Text = "Não possui uma conta?"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(719, 13)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 40)
        Button2.TabIndex = 20
        Button2.Text = "Sair"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(817, 567)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(SenhaLoginBox)
        Controls.Add(EmailLoginBox)
        Controls.Add(LinkCadastrar)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Entrar - Projetinho"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkCadastrar As LinkLabel
    Friend WithEvents EmailLoginBox As TextBox
    Friend WithEvents SenhaLoginBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
