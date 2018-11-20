<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignacionDesign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AsignacionDesign))
        Me.BtRegresarAsignacion = New System.Windows.Forms.Button()
        Me.BtCambiarImpresora = New System.Windows.Forms.Button()
        Me.BtCambiarCpu = New System.Windows.Forms.Button()
        Me.BttCambiarMonitor = New System.Windows.Forms.Button()
        Me.BtHistoria = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.TextBoxMonitor = New System.Windows.Forms.TextBox()
        Me.TextBoxCpu = New System.Windows.Forms.TextBox()
        Me.TextBoxImpresora = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBbuscarcedula = New System.Windows.Forms.TextBox()
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridAsignacion = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridAsignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtRegresarAsignacion
        '
        Me.BtRegresarAsignacion.Location = New System.Drawing.Point(420, 466)
        Me.BtRegresarAsignacion.Name = "BtRegresarAsignacion"
        Me.BtRegresarAsignacion.Size = New System.Drawing.Size(75, 23)
        Me.BtRegresarAsignacion.TabIndex = 0
        Me.BtRegresarAsignacion.Text = "Regresar"
        Me.BtRegresarAsignacion.UseVisualStyleBackColor = True
        '
        'BtCambiarImpresora
        '
        Me.BtCambiarImpresora.Location = New System.Drawing.Point(420, 252)
        Me.BtCambiarImpresora.Name = "BtCambiarImpresora"
        Me.BtCambiarImpresora.Size = New System.Drawing.Size(75, 20)
        Me.BtCambiarImpresora.TabIndex = 1
        Me.BtCambiarImpresora.Text = "Cambiar"
        Me.BtCambiarImpresora.UseVisualStyleBackColor = True
        '
        'BtCambiarCpu
        '
        Me.BtCambiarCpu.Location = New System.Drawing.Point(420, 226)
        Me.BtCambiarCpu.Name = "BtCambiarCpu"
        Me.BtCambiarCpu.Size = New System.Drawing.Size(75, 20)
        Me.BtCambiarCpu.TabIndex = 2
        Me.BtCambiarCpu.Text = "Cambiar"
        Me.BtCambiarCpu.UseVisualStyleBackColor = True
        '
        'BttCambiarMonitor
        '
        Me.BttCambiarMonitor.Location = New System.Drawing.Point(420, 200)
        Me.BttCambiarMonitor.Name = "BttCambiarMonitor"
        Me.BttCambiarMonitor.Size = New System.Drawing.Size(75, 20)
        Me.BttCambiarMonitor.TabIndex = 3
        Me.BttCambiarMonitor.Text = "Cambiar"
        Me.BttCambiarMonitor.UseVisualStyleBackColor = True
        '
        'BtHistoria
        '
        Me.BtHistoria.Location = New System.Drawing.Point(22, 296)
        Me.BtHistoria.Name = "BtHistoria"
        Me.BtHistoria.Size = New System.Drawing.Size(70, 23)
        Me.BtHistoria.TabIndex = 4
        Me.BtHistoria.Text = "Historia"
        Me.BtHistoria.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Monitor "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CPU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Impresora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Apellido"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(80, 110)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(415, 20)
        Me.TextBoxNombre.TabIndex = 11
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(80, 136)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(415, 20)
        Me.TextBoxApellido.TabIndex = 12
        '
        'TextBoxMonitor
        '
        Me.TextBoxMonitor.Location = New System.Drawing.Point(80, 200)
        Me.TextBoxMonitor.Name = "TextBoxMonitor"
        Me.TextBoxMonitor.Size = New System.Drawing.Size(334, 20)
        Me.TextBoxMonitor.TabIndex = 15
        '
        'TextBoxCpu
        '
        Me.TextBoxCpu.Location = New System.Drawing.Point(80, 226)
        Me.TextBoxCpu.Name = "TextBoxCpu"
        Me.TextBoxCpu.Size = New System.Drawing.Size(334, 20)
        Me.TextBoxCpu.TabIndex = 16
        '
        'TextBoxImpresora
        '
        Me.TextBoxImpresora.Location = New System.Drawing.Point(80, 252)
        Me.TextBoxImpresora.Name = "TextBoxImpresora"
        Me.TextBoxImpresora.Size = New System.Drawing.Size(334, 20)
        Me.TextBoxImpresora.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Nombre"
        '
        'TextBbuscarcedula
        '
        Me.TextBbuscarcedula.Location = New System.Drawing.Point(23, 58)
        Me.TextBbuscarcedula.Name = "TextBbuscarcedula"
        Me.TextBbuscarcedula.Size = New System.Drawing.Size(391, 20)
        Me.TextBbuscarcedula.TabIndex = 19
        '
        'BtBuscar
        '
        Me.BtBuscar.Location = New System.Drawing.Point(420, 56)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtBuscar.TabIndex = 20
        Me.BtBuscar.Text = "Buscar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(162, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Ingrese numero de cedúla del usuario"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'DataGridAsignacion
        '
        Me.DataGridAsignacion.AllowUserToAddRows = False
        Me.DataGridAsignacion.AllowUserToDeleteRows = False
        Me.DataGridAsignacion.AllowUserToOrderColumns = True
        Me.DataGridAsignacion.AllowUserToResizeRows = False
        Me.DataGridAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAsignacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Serial, Me.Marca})
        Me.DataGridAsignacion.Location = New System.Drawing.Point(21, 325)
        Me.DataGridAsignacion.MultiSelect = False
        Me.DataGridAsignacion.Name = "DataGridAsignacion"
        Me.DataGridAsignacion.ReadOnly = True
        Me.DataGridAsignacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridAsignacion.Size = New System.Drawing.Size(415, 135)
        Me.DataGridAsignacion.TabIndex = 23
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
        'AsignacionDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 496)
        Me.Controls.Add(Me.DataGridAsignacion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtBuscar)
        Me.Controls.Add(Me.TextBbuscarcedula)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxImpresora)
        Me.Controls.Add(Me.TextBoxCpu)
        Me.Controls.Add(Me.TextBoxMonitor)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtHistoria)
        Me.Controls.Add(Me.BttCambiarMonitor)
        Me.Controls.Add(Me.BtCambiarCpu)
        Me.Controls.Add(Me.BtCambiarImpresora)
        Me.Controls.Add(Me.BtRegresarAsignacion)
        Me.Name = "AsignacionDesign"
        Me.Text = "AsignacionDising"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridAsignacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtRegresarAsignacion As Button
    Friend WithEvents BtCambiarImpresora As Button
    Friend WithEvents BtCambiarCpu As Button
    Friend WithEvents BttCambiarMonitor As Button
    Friend WithEvents BtHistoria As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents TextBoxMonitor As TextBox
    Friend WithEvents TextBoxCpu As TextBox
    Friend WithEvents TextBoxImpresora As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBbuscarcedula As TextBox
    Friend WithEvents BtBuscar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridAsignacion As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Serial As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
End Class
