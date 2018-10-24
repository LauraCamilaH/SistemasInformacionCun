<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearImpresorasDesign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearImpresorasDesign))
        Me.BtRegresarImpresoras = New System.Windows.Forms.Button()
        Me.BtRegistarImpresoras = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxSerieImpresora = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxmarcaImpresora = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxmes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxaño = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtRegresarImpresoras
        '
        Me.BtRegresarImpresoras.Location = New System.Drawing.Point(288, 247)
        Me.BtRegresarImpresoras.Name = "BtRegresarImpresoras"
        Me.BtRegresarImpresoras.Size = New System.Drawing.Size(75, 23)
        Me.BtRegresarImpresoras.TabIndex = 0
        Me.BtRegresarImpresoras.Text = "Regresar"
        Me.BtRegresarImpresoras.UseVisualStyleBackColor = True
        '
        'BtRegistarImpresoras
        '
        Me.BtRegistarImpresoras.Location = New System.Drawing.Point(193, 247)
        Me.BtRegistarImpresoras.Name = "BtRegistarImpresoras"
        Me.BtRegistarImpresoras.Size = New System.Drawing.Size(75, 23)
        Me.BtRegistarImpresoras.TabIndex = 1
        Me.BtRegistarImpresoras.Text = "Registrar"
        Me.BtRegistarImpresoras.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Serie"
        '
        'TxSerieImpresora
        '
        Me.TxSerieImpresora.Location = New System.Drawing.Point(20, 126)
        Me.TxSerieImpresora.Name = "TxSerieImpresora"
        Me.TxSerieImpresora.Size = New System.Drawing.Size(343, 20)
        Me.TxSerieImpresora.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Marca"
        '
        'TxmarcaImpresora
        '
        Me.TxmarcaImpresora.Location = New System.Drawing.Point(18, 165)
        Me.TxmarcaImpresora.Name = "TxmarcaImpresora"
        Me.TxmarcaImpresora.Size = New System.Drawing.Size(345, 20)
        Me.TxmarcaImpresora.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ingrese los datos para crear las Impresoras a gestionar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Día"
        '
        'TextBoxDia
        '
        Me.TextBoxDia.Location = New System.Drawing.Point(18, 204)
        Me.TextBoxDia.Name = "TextBoxDia"
        Me.TextBoxDia.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDia.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Mes"
        '
        'TextBoxmes
        '
        Me.TextBoxmes.Location = New System.Drawing.Point(141, 204)
        Me.TextBoxmes.Name = "TextBoxmes"
        Me.TextBoxmes.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxmes.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Año"
        '
        'TextBoxaño
        '
        Me.TextBoxaño.Location = New System.Drawing.Point(263, 204)
        Me.TextBoxaño.Name = "TextBoxaño"
        Me.TextBoxaño.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxaño.TabIndex = 15
        '
        'CrearImpresorasDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 281)
        Me.Controls.Add(Me.TextBoxaño)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxmes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxDia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxmarcaImpresora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxSerieImpresora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtRegistarImpresoras)
        Me.Controls.Add(Me.BtRegresarImpresoras)
        Me.Name = "CrearImpresorasDesign"
        Me.Text = "ImpresorasCrearDising"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtRegresarImpresoras As Button
    Friend WithEvents BtRegistarImpresoras As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxSerieImpresora As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxmarcaImpresora As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxmes As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxaño As TextBox
End Class
