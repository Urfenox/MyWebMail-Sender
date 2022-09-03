<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarcomoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeleccionartodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LenguajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FastColoredTextBox1 = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_SeeEmailList = New System.Windows.Forms.Button()
        Me.Btn_SeeToEmailList = New System.Windows.Forms.Button()
        Me.Btn_SendToAll = New System.Windows.Forms.Button()
        Me.Btn_Send = New System.Windows.Forms.Button()
        Me.Txb_Subject = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.toolStripSeparator, Me.GuardarToolStripMenuItem, Me.GuardarcomoToolStripMenuItem, Me.toolStripSeparator2, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NuevoToolStripMenuItem.Text = "&Nuevo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Image = CType(resources.GetObject("AbrirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AbrirToolStripMenuItem.Text = "&Abrir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(153, 6)
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Image = CType(resources.GetObject("GuardarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.GuardarToolStripMenuItem.Text = "&Guardar"
        '
        'GuardarcomoToolStripMenuItem
        '
        Me.GuardarcomoToolStripMenuItem.Name = "GuardarcomoToolStripMenuItem"
        Me.GuardarcomoToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.GuardarcomoToolStripMenuItem.Text = "G&uardar como"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(153, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeshacerToolStripMenuItem, Me.RehacerToolStripMenuItem, Me.toolStripSeparator3, Me.CortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.toolStripSeparator4, Me.SeleccionartodoToolStripMenuItem, Me.ToolStripMenuItem2, Me.LenguajeToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "&Editar"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DeshacerToolStripMenuItem.Text = "&Deshacer"
        '
        'RehacerToolStripMenuItem
        '
        Me.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        Me.RehacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RehacerToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RehacerToolStripMenuItem.Text = "&Rehacer"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(160, 6)
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Image = CType(resources.GetObject("CortarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CortarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CortarToolStripMenuItem.Text = "Cor&tar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Image = CType(resources.GetObject("CopiarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopiarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CopiarToolStripMenuItem.Text = "&Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Image = CType(resources.GetObject("PegarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PegarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.PegarToolStripMenuItem.Text = "&Pegar"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(160, 6)
        '
        'SeleccionartodoToolStripMenuItem
        '
        Me.SeleccionartodoToolStripMenuItem.Name = "SeleccionartodoToolStripMenuItem"
        Me.SeleccionartodoToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SeleccionartodoToolStripMenuItem.Text = "&Seleccionar todo"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(160, 6)
        '
        'LenguajeToolStripMenuItem
        '
        Me.LenguajeToolStripMenuItem.Name = "LenguajeToolStripMenuItem"
        Me.LenguajeToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.LenguajeToolStripMenuItem.Text = "&Lenguaje"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalizarToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.ToolStripMenuItem1, Me.ConfiguraciónToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "&Herramientas"
        '
        'PersonalizarToolStripMenuItem
        '
        Me.PersonalizarToolStripMenuItem.Name = "PersonalizarToolStripMenuItem"
        Me.PersonalizarToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PersonalizarToolStripMenuItem.Text = "&Personalizar"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(147, 6)
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ConfiguraciónToolStripMenuItem.Text = "&Configuración"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercadeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ay&uda"
        '
        'AcercadeToolStripMenuItem
        '
        Me.AcercadeToolStripMenuItem.Name = "AcercadeToolStripMenuItem"
        Me.AcercadeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercadeToolStripMenuItem.Text = "&Acerca de..."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.FastColoredTextBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 460)
        Me.Panel1.TabIndex = 1
        '
        'FastColoredTextBox1
        '
        Me.FastColoredTextBox1.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.FastColoredTextBox1.AutoIndentCharsPatterns = ""
        Me.FastColoredTextBox1.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.FastColoredTextBox1.BackBrush = Nothing
        Me.FastColoredTextBox1.CharHeight = 14
        Me.FastColoredTextBox1.CharWidth = 8
        Me.FastColoredTextBox1.CommentPrefix = Nothing
        Me.FastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FastColoredTextBox1.IsReplaceMode = False
        Me.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        Me.FastColoredTextBox1.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.FastColoredTextBox1.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.FastColoredTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.FastColoredTextBox1.Name = "FastColoredTextBox1"
        Me.FastColoredTextBox1.Paddings = New System.Windows.Forms.Padding(0)
        Me.FastColoredTextBox1.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.FastColoredTextBox1.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.FastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FastColoredTextBox1.ServiceColors = CType(resources.GetObject("FastColoredTextBox1.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.FastColoredTextBox1.Size = New System.Drawing.Size(760, 460)
        Me.FastColoredTextBox1.TabIndex = 3
        Me.FastColoredTextBox1.Zoom = 100
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_SeeEmailList)
        Me.Panel2.Controls.Add(Me.Btn_SeeToEmailList)
        Me.Panel2.Controls.Add(Me.Btn_SendToAll)
        Me.Panel2.Controls.Add(Me.Btn_Send)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 545)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 56)
        Me.Panel2.TabIndex = 2
        '
        'Btn_SeeEmailList
        '
        Me.Btn_SeeEmailList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_SeeEmailList.Location = New System.Drawing.Point(282, 30)
        Me.Btn_SeeEmailList.Name = "Btn_SeeEmailList"
        Me.Btn_SeeEmailList.Size = New System.Drawing.Size(220, 23)
        Me.Btn_SeeEmailList.TabIndex = 20
        Me.Btn_SeeEmailList.Text = "Ver lista de correos"
        Me.Btn_SeeEmailList.UseVisualStyleBackColor = True
        '
        'Btn_SeeToEmailList
        '
        Me.Btn_SeeToEmailList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_SeeToEmailList.Location = New System.Drawing.Point(282, 3)
        Me.Btn_SeeToEmailList.Name = "Btn_SeeToEmailList"
        Me.Btn_SeeToEmailList.Size = New System.Drawing.Size(220, 23)
        Me.Btn_SeeToEmailList.TabIndex = 10
        Me.Btn_SeeToEmailList.Text = "Ver lista de destinatarios"
        Me.Btn_SeeToEmailList.UseVisualStyleBackColor = True
        '
        'Btn_SendToAll
        '
        Me.Btn_SendToAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_SendToAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SendToAll.Location = New System.Drawing.Point(646, 3)
        Me.Btn_SendToAll.Name = "Btn_SendToAll"
        Me.Btn_SendToAll.Size = New System.Drawing.Size(135, 50)
        Me.Btn_SendToAll.TabIndex = 5
        Me.Btn_SendToAll.Text = "Enviar a Todos"
        Me.Btn_SendToAll.UseVisualStyleBackColor = True
        '
        'Btn_Send
        '
        Me.Btn_Send.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Send.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Send.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Send.Name = "Btn_Send"
        Me.Btn_Send.Size = New System.Drawing.Size(135, 50)
        Me.Btn_Send.TabIndex = 4
        Me.Btn_Send.Text = "Enviar"
        Me.Btn_Send.UseVisualStyleBackColor = True
        '
        'Txb_Subject
        '
        Me.Txb_Subject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txb_Subject.Location = New System.Drawing.Point(98, 27)
        Me.Txb_Subject.Name = "Txb_Subject"
        Me.Txb_Subject.Size = New System.Drawing.Size(674, 20)
        Me.Txb_Subject.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Asunto: "
        Me.ToolTip1.SetToolTip(Me.Label1, "Subject")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Destinatario(s): "
        Me.ToolTip1.SetToolTip(Me.Label2, "Separated by ; (semi-colon)")
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(98, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(674, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 601)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txb_Subject)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyWebMail Sender"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarcomoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SeleccionartodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FastColoredTextBox1 As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btn_SendToAll As Button
    Friend WithEvents Btn_Send As Button
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents LenguajeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_SeeEmailList As Button
    Friend WithEvents Btn_SeeToEmailList As Button
    Friend WithEvents Txb_Subject As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
