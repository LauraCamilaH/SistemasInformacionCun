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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxIdimpresoras = New System.Windows.Forms.TextBox()
        Me.TxSerieImpresora = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxmarcaImpresora = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtRegresarImpresoras
        '
        Me.BtRegresarImpresoras.Location = New System.Drawing.Point(288, 229)
        Me.BtRegresarImpresoras.Name = "BtRegresarImpresoras"
        Me.BtRegresarImpresoras.Size = New System.Drawing.Size(75, 23)
        Me.BtRegresarImpresoras.TabIndex = 0
        Me.BtRegresarImpresoras.Text = "Regresar"
        Me.BtRegresarImpresoras.UseVisualStyleBackColor = True
        '
        'BtRegistarImpresoras
        '
        Me.BtRegistarImpresoras.Location = New System.Drawing.Point(103, 229)
        Me.BtRegistarImpresoras.Name = "BtRegistarImpresoras"
        Me.BtRegistarImpresoras.Size = New System.Drawing.Size(75, 23)
        Me.BtRegistarImpresoras.TabIndex = 1
        Me.BtRegistarImpresoras.Text = "Registrar"
        Me.BtRegistarImpresoras.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Serie"
        '
        'TxIdimpresoras
        '
        Me.TxIdimpresoras.Location = New System.Drawing.Point(103, 100)
        Me.TxIdimpresoras.Name = "TxIdimpresoras"
        Me.TxIdimpresoras.Size = New System.Drawing.Size(260, 20)
        Me.TxIdimpresoras.TabIndex = 4
        '
        'TxSerieImpresora
        '
        Me.TxSerieImpresora.Location = New System.Drawing.Point(103, 140)
        Me.TxSerieImpresora.Name = "TxSerieImpresora"
        Me.TxSerieImpresora.Size = New System.Drawing.Size(260, 20)
        Me.TxSerieImpresora.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Marca"
        '
        'TxmarcaImpresora
        '
        Me.TxmarcaImpresora.Location = New System.Drawing.Point(103, 180)
        Me.TxmarcaImpresora.Name = "TxmarcaImpresora"
        Me.TxmarcaImpresora.Size = New System.Drawing.Size(260, 20)
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
        'CrearImpresorasDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 275)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxmarcaImpresora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxSerieImpresora)
        Me.Controls.Add(Me.TxIdimpresoras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxIdimpresoras As TextBox
    Friend WithEvents TxSerieImpresora As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxmarcaImpresora As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
