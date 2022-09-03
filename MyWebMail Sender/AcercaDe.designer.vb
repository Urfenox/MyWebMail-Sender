<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AcercaDe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AcercaDe))
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblAppDescription = New System.Windows.Forms.Label()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.gbItems = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        Me.gbItems.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLogo.ImageLocation = "https://avatars.githubusercontent.com/u/31778194?v=4"
        Me.picLogo.Location = New System.Drawing.Point(5, 11)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(130, 130)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblAppDescription
        '
        Me.lblAppDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAppDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblAppDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppDescription.Location = New System.Drawing.Point(12, 54)
        Me.lblAppDescription.Name = "lblAppDescription"
        Me.lblAppDescription.Size = New System.Drawing.Size(570, 38)
        Me.lblAppDescription.TabIndex = 5
        Me.lblAppDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAppName
        '
        Me.lblAppName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAppName.BackColor = System.Drawing.Color.Transparent
        Me.lblAppName.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.ForeColor = System.Drawing.Color.Black
        Me.lblAppName.Location = New System.Drawing.Point(3, 9)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(588, 45)
        Me.lblAppName.TabIndex = 4
        Me.lblAppName.Text = "MyWebMail Sender"
        Me.lblAppName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblAppName.UseCompatibleTextRendering = True
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.ForeColor = System.Drawing.Color.DarkGray
        Me.lblInfo.Location = New System.Drawing.Point(3, 1)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(588, 14)
        Me.lblInfo.TabIndex = 7
        Me.lblInfo.Text = "0.0.0.0"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlTitle
        '
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTitle.Controls.Add(Me.lblInfo)
        Me.pnlTitle.Controls.Add(Me.lblAppName)
        Me.pnlTitle.Controls.Add(Me.lblAppDescription)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(594, 95)
        Me.pnlTitle.TabIndex = 8
        '
        'gbItems
        '
        Me.gbItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbItems.Controls.Add(Me.Label3)
        Me.gbItems.Controls.Add(Me.Label2)
        Me.gbItems.Controls.Add(Me.picLogo)
        Me.gbItems.Location = New System.Drawing.Point(12, 352)
        Me.gbItems.Name = "gbItems"
        Me.gbItems.Size = New System.Drawing.Size(570, 147)
        Me.gbItems.TabIndex = 10
        Me.gbItems.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(141, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(423, 105)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Programado por Cristopher (Urfenox)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Santiago, Chile. 03/09/2022."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(423, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Creado en Chile con mucho amor."
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 416)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(570, 250)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'AcercaDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 511)
        Me.Controls.Add(Me.gbItems)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(455, 300)
        Me.Name = "AcercaDe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        Me.gbItems.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblAppDescription As Label
    Friend WithEvents lblAppName As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents gbItems As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
