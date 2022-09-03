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
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Btn_Remove = New System.Windows.Forms.Button()
        Me.Btn_Import = New System.Windows.Forms.Button()
        Me.Btn_Export = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(356, 333)
        Me.ListBox1.TabIndex = 0
        '
        'Btn_New
        '
        Me.Btn_New.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_New.Location = New System.Drawing.Point(60, 3)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(75, 23)
        Me.Btn_New.TabIndex = 1
        Me.Btn_New.Text = "Nuevo"
        Me.Btn_New.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Edit.Location = New System.Drawing.Point(141, 3)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Edit.TabIndex = 2
        Me.Btn_Edit.Text = "Editar"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_Remove
        '
        Me.Btn_Remove.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Remove.Location = New System.Drawing.Point(222, 3)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Remove.TabIndex = 3
        Me.Btn_Remove.Text = "Quitar"
        Me.Btn_Remove.UseVisualStyleBackColor = True
        '
        'Btn_Import
        '
        Me.Btn_Import.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Import.Location = New System.Drawing.Point(266, 3)
        Me.Btn_Import.Name = "Btn_Import"
        Me.Btn_Import.Size = New System.Drawing.Size(123, 23)
        Me.Btn_Import.TabIndex = 4
        Me.Btn_Import.Text = "Importar"
        Me.Btn_Import.UseVisualStyleBackColor = True
        '
        'Btn_Export
        '
        Me.Btn_Export.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Export.Location = New System.Drawing.Point(395, 3)
        Me.Btn_Export.Name = "Btn_Export"
        Me.Btn_Export.Size = New System.Drawing.Size(123, 23)
        Me.Btn_Export.TabIndex = 5
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
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(395, 93)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(356, 333)
        Me.Panel3.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 304)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Correo: name@domain.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Identificación: Domain Solutions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contraseña: pas" &
    "sword" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Server: mx.domain.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Type: SMTP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Port: 0000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SSL enabled: True"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.Controls.Add(Me.Btn_New)
        Me.Panel4.Controls.Add(Me.Btn_Edit)
        Me.Panel4.Controls.Add(Me.Btn_Remove)
        Me.Panel4.Location = New System.Drawing.Point(33, 59)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(356, 28)
        Me.Panel4.TabIndex = 9
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
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EmailList"
        Me.Text = "EmailList"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Btn_New As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Remove As Button
    Friend WithEvents Btn_Import As Button
    Friend WithEvents Btn_Export As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
