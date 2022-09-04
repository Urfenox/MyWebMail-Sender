<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ToEmailList
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Btn_New = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Remove = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txb_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txb_Email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txb_Identification = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Export = New System.Windows.Forms.Button()
        Me.Btn_Import = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(515, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Direcciónes de correo de destinatarios"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Location = New System.Drawing.Point(395, 93)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(356, 333)
        Me.Panel3.TabIndex = 15
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.Controls.Add(Me.Btn_New)
        Me.Panel4.Controls.Add(Me.Btn_Save)
        Me.Panel4.Controls.Add(Me.Btn_Remove)
        Me.Panel4.Location = New System.Drawing.Point(3, 285)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(350, 45)
        Me.Panel4.TabIndex = 9
        '
        'Btn_New
        '
        Me.Btn_New.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_New.Location = New System.Drawing.Point(57, 11)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(75, 23)
        Me.Btn_New.TabIndex = 6
        Me.Btn_New.Text = "Nuevo"
        Me.Btn_New.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Save.Location = New System.Drawing.Point(138, 11)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Save.TabIndex = 7
        Me.Btn_Save.Text = "Guardar"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Btn_Remove
        '
        Me.Btn_Remove.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Remove.Location = New System.Drawing.Point(219, 11)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Remove.TabIndex = 8
        Me.Btn_Remove.Text = "Eliminar"
        Me.Btn_Remove.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txb_ID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txb_Email)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txb_Identification)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 100)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Correo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(11, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ID: "
        '
        'Txb_ID
        '
        Me.Txb_ID.Location = New System.Drawing.Point(108, 18)
        Me.Txb_ID.Name = "Txb_ID"
        Me.Txb_ID.Size = New System.Drawing.Size(231, 20)
        Me.Txb_ID.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(11, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre: "
        '
        'Txb_Email
        '
        Me.Txb_Email.Location = New System.Drawing.Point(108, 70)
        Me.Txb_Email.Name = "Txb_Email"
        Me.Txb_Email.Size = New System.Drawing.Size(231, 20)
        Me.Txb_Email.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(11, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Correo: "
        '
        'Txb_Identification
        '
        Me.Txb_Identification.Location = New System.Drawing.Point(108, 44)
        Me.Txb_Identification.Name = "Txb_Identification"
        Me.Txb_Identification.Size = New System.Drawing.Size(231, 20)
        Me.Txb_Identification.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Location = New System.Drawing.Point(33, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 333)
        Me.Panel2.TabIndex = 14
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(356, 333)
        Me.ListBox1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_Export)
        Me.Panel1.Controls.Add(Me.Btn_Import)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 432)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 29)
        Me.Panel1.TabIndex = 13
        '
        'Btn_Export
        '
        Me.Btn_Export.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Export.Location = New System.Drawing.Point(395, 3)
        Me.Btn_Export.Name = "Btn_Export"
        Me.Btn_Export.Size = New System.Drawing.Size(123, 23)
        Me.Btn_Export.TabIndex = 1
        Me.Btn_Export.Text = "Exportar"
        Me.Btn_Export.UseVisualStyleBackColor = True
        '
        'Btn_Import
        '
        Me.Btn_Import.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Import.Location = New System.Drawing.Point(266, 3)
        Me.Btn_Import.Name = "Btn_Import"
        Me.Btn_Import.Size = New System.Drawing.Size(123, 23)
        Me.Btn_Import.TabIndex = 0
        Me.Btn_Import.Text = "Importar"
        Me.Btn_Import.UseVisualStyleBackColor = True
        '
        'ToEmailList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "ToEmailList"
        Me.Text = "ToEmailList"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Btn_New As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Btn_Remove As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txb_ID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txb_Email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txb_Identification As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Export As Button
    Friend WithEvents Btn_Import As Button
End Class
