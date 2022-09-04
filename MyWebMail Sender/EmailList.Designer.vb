<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailList
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Btn_New = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Remove = New System.Windows.Forms.Button()
        Me.Btn_Import = New System.Windows.Forms.Button()
        Me.Btn_Export = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txb_Server = New System.Windows.Forms.TextBox()
        Me.Txb_StatusSSL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txb_Type = New System.Windows.Forms.TextBox()
        Me.Txb_Port = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txb_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txb_Email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txb_Identification = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txb_Password = New System.Windows.Forms.TextBox()
        Me.Lbl_CurrentEmail = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'Btn_New
        '
        Me.Btn_New.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_New.Location = New System.Drawing.Point(57, 11)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(75, 23)
        Me.Btn_New.TabIndex = 11
        Me.Btn_New.Text = "Nuevo"
        Me.Btn_New.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Save.Location = New System.Drawing.Point(138, 11)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Save.TabIndex = 12
        Me.Btn_Save.Text = "Guardar"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Btn_Remove
        '
        Me.Btn_Remove.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Remove.Location = New System.Drawing.Point(219, 11)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Remove.TabIndex = 13
        Me.Btn_Remove.Text = "Eliminar"
        Me.Btn_Remove.UseVisualStyleBackColor = True
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_Export)
        Me.Panel1.Controls.Add(Me.Btn_Import)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 432)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 29)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Location = New System.Drawing.Point(33, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 333)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Location = New System.Drawing.Point(395, 93)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(356, 333)
        Me.Panel3.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Txb_Server)
        Me.GroupBox2.Controls.Add(Me.Txb_StatusSSL)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Txb_Type)
        Me.GroupBox2.Controls.Add(Me.Txb_Port)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 135)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Servidor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Servidor: "
        '
        'Txb_Server
        '
        Me.Txb_Server.Location = New System.Drawing.Point(109, 18)
        Me.Txb_Server.Name = "Txb_Server"
        Me.Txb_Server.Size = New System.Drawing.Size(229, 20)
        Me.Txb_Server.TabIndex = 7
        '
        'Txb_StatusSSL
        '
        Me.Txb_StatusSSL.Location = New System.Drawing.Point(109, 96)
        Me.Txb_StatusSSL.Name = "Txb_StatusSSL"
        Me.Txb_StatusSSL.Size = New System.Drawing.Size(229, 20)
        Me.Txb_StatusSSL.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Tipo: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "SSL Activo: "
        '
        'Txb_Type
        '
        Me.Txb_Type.Location = New System.Drawing.Point(109, 44)
        Me.Txb_Type.Name = "Txb_Type"
        Me.Txb_Type.Size = New System.Drawing.Size(229, 20)
        Me.Txb_Type.TabIndex = 8
        '
        'Txb_Port
        '
        Me.Txb_Port.Location = New System.Drawing.Point(109, 70)
        Me.Txb_Port.Name = "Txb_Port"
        Me.Txb_Port.Size = New System.Drawing.Size(229, 20)
        Me.Txb_Port.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Puerto: "
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txb_ID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txb_Email)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txb_Identification)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txb_Password)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 135)
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
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Correo: "
        '
        'Txb_Email
        '
        Me.Txb_Email.Location = New System.Drawing.Point(108, 44)
        Me.Txb_Email.Name = "Txb_Email"
        Me.Txb_Email.Size = New System.Drawing.Size(231, 20)
        Me.Txb_Email.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(11, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Identificación: "
        '
        'Txb_Identification
        '
        Me.Txb_Identification.Location = New System.Drawing.Point(108, 70)
        Me.Txb_Identification.Name = "Txb_Identification"
        Me.Txb_Identification.Size = New System.Drawing.Size(231, 20)
        Me.Txb_Identification.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Contraseña: "
        '
        'Txb_Password
        '
        Me.Txb_Password.Location = New System.Drawing.Point(108, 96)
        Me.Txb_Password.Name = "Txb_Password"
        Me.Txb_Password.Size = New System.Drawing.Size(231, 20)
        Me.Txb_Password.TabIndex = 6
        '
        'Lbl_CurrentEmail
        '
        Me.Lbl_CurrentEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CurrentEmail.Location = New System.Drawing.Point(33, 40)
        Me.Lbl_CurrentEmail.Name = "Lbl_CurrentEmail"
        Me.Lbl_CurrentEmail.Size = New System.Drawing.Size(356, 50)
        Me.Lbl_CurrentEmail.TabIndex = 0
        Me.Lbl_CurrentEmail.Text = "Actualmente en uso" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Correo: name@domain.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Identificación: Domain Solut" &
    "ions"
        Me.Lbl_CurrentEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tus direcciónes de correo"
        '
        'EmailList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lbl_CurrentEmail)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "EmailList"
        Me.Text = "EmailList"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Btn_New As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Btn_Remove As Button
    Friend WithEvents Btn_Import As Button
    Friend WithEvents Btn_Export As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_CurrentEmail As Label
    Friend WithEvents Txb_StatusSSL As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txb_Port As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txb_Type As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txb_Server As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txb_Password As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txb_Identification As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txb_Email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txb_ID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
