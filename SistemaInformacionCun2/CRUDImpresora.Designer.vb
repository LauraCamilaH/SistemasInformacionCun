<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRUDImpresora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRUDImpresora))
        Me.DataGridImpresoras = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIdentificador = New System.Windows.Forms.TextBox()
        Me.TxTSerial = New System.Windows.Forms.Label()
        Me.TxtSerialImpresora = New System.Windows.Forms.TextBox()
        Me.TxtMarcaImpresora = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnAscendente = New System.Windows.Forms.Button()
        Me.BtnDescendente = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridImpresoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridImpresoras
        '
        Me.DataGridImpresoras.AllowUserToAddRows = False
        Me.DataGridImpresoras.AllowUserToDeleteRows = False
        Me.DataGridImpresoras.AllowUserToOrderColumns = True
        Me.DataGridImpresoras.AllowUserToResizeRows = False
        Me.DataGridImpresoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridImpresoras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Serial, Me.Marca})
        Me.DataGridImpresoras.Location = New System.Drawing.Point(12, 240)
        Me.DataGridImpresoras.MultiSelect = False
        Me.DataGridImpresoras.Name = "DataGridImpresoras"
        Me.DataGridImpresoras.ReadOnly = True
        Me.DataGridImpresoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridImpresoras.Size = New System.Drawing.Size(515, 225)
        Me.DataGridImpresoras.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "Identificador"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Serial
        '
        Me.Serial.HeaderText = "Serial"
        Me.Serial.Name = "Serial"
        Me.Serial.ReadOnly = True
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(174, 485)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 1
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(278, 195)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(120, 23)
        Me.BtnNuevo.TabIndex = 2
        Me.BtnNuevo.Text = "Crear nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(408, 195)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(120, 23)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(12, 485)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 4
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Id"
        '
        'TxtIdentificador
        '
        Me.TxtIdentificador.Location = New System.Drawing.Point(13, 96)
        Me.TxtIdentificador.Name = "TxtIdentificador"
        Me.TxtIdentificador.ReadOnly = True
        Me.TxtIdentificador.Size = New System.Drawing.Size(515, 20)
        Me.TxtIdentificador.TabIndex = 6
        '
        'TxTSerial
        '
        Me.TxTSerial.AutoSize = True
        Me.TxTSerial.Location = New System.Drawing.Point(14, 128)
        Me.TxTSerial.Name = "TxTSerial"
        Me.TxTSerial.Size = New System.Drawing.Size(33, 13)
        Me.TxTSerial.TabIndex = 7
        Me.TxTSerial.Text = "Serial"
        '
        'TxtSerialImpresora
        '
        Me.TxtSerialImpresora.Location = New System.Drawing.Point(17, 144)
        Me.TxtSerialImpresora.Name = "TxtSerialImpresora"
        Me.TxtSerialImpresora.Size = New System.Drawing.Size(250, 20)
        Me.TxtSerialImpresora.TabIndex = 8
        '
        'TxtMarcaImpresora
        '
        Me.TxtMarcaImpresora.Location = New System.Drawing.Point(278, 144)
        Me.TxtMarcaImpresora.Name = "TxtMarcaImpresora"
        Me.TxtMarcaImpresora.Size = New System.Drawing.Size(250, 20)
        Me.TxtMarcaImpresora.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Marca"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(233, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Impresoras"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(289, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Edite la información de impresoras en el siguiente formulario."
        '
        'BtnAscendente
        '
        Me.BtnAscendente.Location = New System.Drawing.Point(361, 485)
        Me.BtnAscendente.Name = "BtnAscendente"
        Me.BtnAscendente.Size = New System.Drawing.Size(75, 23)
        Me.BtnAscendente.TabIndex = 14
        Me.BtnAscendente.Text = "Ascendente "
        Me.BtnAscendente.UseVisualStyleBackColor = True
        '
        'BtnDescendente
        '
        Me.BtnDescendente.Location = New System.Drawing.Point(442, 485)
        Me.BtnDescendente.Name = "BtnDescendente"
        Me.BtnDescendente.Size = New System.Drawing.Size(85, 23)
        Me.BtnDescendente.TabIndex = 15
        Me.BtnDescendente.Text = "Descendente "
        Me.BtnDescendente.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(93, 485)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 16
        Me.BtnModificar.Text = "Modificar "
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 198)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 20)
        Me.TextBox1.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 198)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(80, 20)
        Me.TextBox2.TabIndex = 18
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(187, 198)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(80, 20)
        Me.TextBox3.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Día"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Mes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(184, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Año"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(310, 490)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Ordenar"
        '
        'CRUDImpresora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 540)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnDescendente)
        Me.Controls.Add(Me.BtnAscendente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMarcaImpresora)
        Me.Controls.Add(Me.TxtSerialImpresora)
        Me.Controls.Add(Me.TxTSerial)
        Me.Controls.Add(Me.TxtIdentificador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.DataGridImpresoras)
        Me.Name = "CRUDImpresora"
        Me.Text = "Administrar impresoras"
        CType(Me.DataGridImpresoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridImpresoras As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdentificador As TextBox
    Friend WithEvents TxTSerial As Label
    Friend WithEvents TxtSerialImpresora As TextBox
    Friend WithEvents TxtMarcaImpresora As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Serial As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnAscendente As Button
    Friend WithEvents BtnDescendente As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
