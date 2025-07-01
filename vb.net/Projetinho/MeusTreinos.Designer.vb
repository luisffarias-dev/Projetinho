<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MeusTreinos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MeusTreinos))
        PictureBox1 = New PictureBox()
        DGV_Treinos = New DataGridView()
        Label1 = New Label()
        DataMeusTreinos = New DateTimePicker()
        PrintDocument1 = New Printing.PrintDocument()
        PictureBox2 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        LinkLabel2 = New LinkLabel()
        PictureBox4 = New PictureBox()
        Label2 = New Label()
        DGVCardio = New DataGridView()
        DataCardios = New DateTimePicker()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGV_Treinos, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVCardio, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(211, 14)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(352, 160)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DGV_Treinos
        ' 
        DGV_Treinos.AllowUserToAddRows = False
        DGV_Treinos.AllowUserToDeleteRows = False
        DGV_Treinos.BackgroundColor = Color.MediumPurple
        DGV_Treinos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Treinos.GridColor = Color.MediumPurple
        DGV_Treinos.Location = New Point(64, 268)
        DGV_Treinos.Name = "DGV_Treinos"
        DGV_Treinos.ReadOnly = True
        DGV_Treinos.RowHeadersWidth = 51
        DGV_Treinos.RowTemplate.Height = 25
        DGV_Treinos.Size = New Size(634, 267)
        DGV_Treinos.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(337, 214)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 23)
        Label1.TabIndex = 2
        Label1.Text = "MEUS TREINOS"
        ' 
        ' DataMeusTreinos
        ' 
        DataMeusTreinos.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataMeusTreinos.Location = New Point(211, 240)
        DataMeusTreinos.MinDate = New Date(2000, 6, 15, 0, 0, 0, 0)
        DataMeusTreinos.Name = "DataMeusTreinos"
        DataMeusTreinos.Size = New Size(352, 22)
        DataMeusTreinos.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(639, 225)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(56, 37)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkColor = SystemColors.MenuHighlight
        LinkLabel1.Location = New Point(3, 3)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(51, 19)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Voltar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(1, 3)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(756, 583)
        TabControl1.TabIndex = 7
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), Image)
        TabPage1.Controls.Add(PictureBox1)
        TabPage1.Controls.Add(LinkLabel1)
        TabPage1.Controls.Add(PictureBox2)
        TabPage1.Controls.Add(DGV_Treinos)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(DataMeusTreinos)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(748, 555)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Meus Treinos"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), Image)
        TabPage2.Controls.Add(LinkLabel2)
        TabPage2.Controls.Add(PictureBox4)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(DGVCardio)
        TabPage2.Controls.Add(DataCardios)
        TabPage2.Controls.Add(PictureBox3)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(748, 555)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Meus Cardios"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.BackColor = Color.Transparent
        LinkLabel2.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel2.LinkColor = SystemColors.MenuHighlight
        LinkLabel2.Location = New Point(3, 3)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(51, 19)
        LinkLabel2.TabIndex = 7
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Voltar"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(637, 228)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(55, 33)
        PictureBox4.TabIndex = 5
        PictureBox4.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(329, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 23)
        Label2.TabIndex = 4
        Label2.Text = "MEUS CARDIOS"
        ' 
        ' DGVCardio
        ' 
        DGVCardio.BackgroundColor = Color.Indigo
        DGVCardio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVCardio.Location = New Point(58, 267)
        DGVCardio.Name = "DGVCardio"
        DGVCardio.RowTemplate.Height = 25
        DGVCardio.Size = New Size(634, 268)
        DGVCardio.TabIndex = 3
        ' 
        ' DataCardios
        ' 
        DataCardios.Location = New Point(207, 242)
        DataCardios.MinDate = New Date(2000, 6, 15, 0, 0, 0, 0)
        DataCardios.Name = "DataCardios"
        DataCardios.Size = New Size(352, 23)
        DataCardios.TabIndex = 2
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(202, 21)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(352, 160)
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' MeusTreinos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumPurple
        ClientSize = New Size(759, 582)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MeusTreinos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Meus treinos - Projetinho"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DGV_Treinos, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVCardio, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGV_Treinos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DataMeusTreinos As DateTimePicker
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGVCardio As DataGridView
    Friend WithEvents DataCardios As DateTimePicker
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
