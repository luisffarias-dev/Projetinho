<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sobre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sobre))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(210, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(220, 99)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(130, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 13)
        Label1.TabIndex = 9
        Label1.Text = "Projeto em .NET para criar treinos diários para usuários de academias"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(284, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 14)
        Label2.TabIndex = 10
        Label2.Text = "O que é?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(160, 303)
        Label3.Name = "Label3"
        Label3.Size = New Size(298, 14)
        Label3.TabIndex = 11
        Label3.Text = "Faculdade de Tecnologia de Mauá - FATEC Mauá"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(249, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 14)
        Label4.TabIndex = 12
        Label4.Text = "Desenvolvido por:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(239, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(141, 13)
        Label5.TabIndex = 13
        Label5.Text = "Douglas Barbosa de Oliveira"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(238, 208)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 13)
        Label6.TabIndex = 14
        Label6.Text = "Luís Fernando França Farias"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(260, 249)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 13)
        Label7.TabIndex = 15
        Label7.Text = "Ryan Pereira da Mota"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(57, 275)
        Label8.Name = "Label8"
        Label8.Size = New Size(471, 14)
        Label8.TabIndex = 16
        Label8.Text = "Disciplina: Técnicas de Programação II - Professor: Humberto Luiz de Toledo"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(294, 327)
        Label9.Name = "Label9"
        Label9.Size = New Size(39, 14)
        Label9.TabIndex = 17
        Label9.Text = "2025"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(277, 228)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 13)
        Label10.TabIndex = 18
        Label10.Text = "Guilherme Pim"
        ' 
        ' Sobre
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(625, 382)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Sobre"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sobre - Projetinho"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
