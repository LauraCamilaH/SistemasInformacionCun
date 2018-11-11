<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRUDMonitorDesign
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxIdMonitor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxSerialMonitor = New System.Windows.Forms.TextBox()
        Me.TextBoxMarcaMonitor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Mes = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxDiaMonitor = New System.Windows.Forms.TextBox()
        Me.TextBoxMesMonitor = New System.Windows.Forms.TextBox()
        Me.TextBoxAnioMonitor = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DataGridMonitor = New System.Windows.Forms.DataGridView()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxValorM = New System.Windows.Forms.TextBox()
        CType(Me.DataGridMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(254, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monitores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Edite la información de monitores en el siguiente formulario: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Id"
        '
        'TextBoxIdMonitor
        '
        Me.TextBoxIdMonitor.Location = New System.Drawing.Point(17, 97)
        Me.TextBoxIdMonitor.Name = "TextBoxIdMonitor"
        Me.TextBoxIdMonitor.ReadOnly = True
        Me.TextBoxIdMonitor.Size = New System.Drawing.Size(245, 20)
        Me.TextBoxIdMonitor.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Serial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(275, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Marca"
        '
        'TextBoxSerialMonitor
        '
        Me.TextBoxSerialMonitor.Location = New System.Drawing.Point(15, 144)
        Me.TextBoxSerialMonitor.Name = "TextBoxSerialMonitor"
        Me.TextBoxSerialMonitor.Size = New System.Drawing.Size(247, 20)
        Me.TextBoxSerialMonitor.TabIndex = 6
        '
        'TextBoxMarcaMonitor
        '
        Me.TextBoxMarcaMonitor.Location = New System.Drawing.Point(278, 97)
        Me.TextBoxMarcaMonitor.Name = "TextBoxMarcaMonitor"
        Me.TextBoxMarcaMonitor.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxMarcaMonitor.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Día"
        '
        'Mes
        '
        Me.Mes.AutoSize = True
        Me.Mes.Location = New System.Drawing.Point(105, 182)
        Me.Mes.Name = "Mes"
        Me.Mes.Size = New System.Drawing.Size(27, 13)
        Me.Mes.TabIndex = 9
        Me.Mes.Text = "Mes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(218, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Año"
        '
        'TextBoxDiaMonitor
        '
        Me.TextBoxDiaMonitor.Location = New System.Drawing.Point(12, 198)
        Me.TextBoxDiaMonitor.Name = "TextBoxDiaMonitor"
        Me.TextBoxDiaMonitor.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxDiaMonitor.TabIndex = 11
        '
        'TextBoxMesMonitor
        '
        Me.TextBoxMesMonitor.Location = New System.Drawing.Point(98, 198)
        Me.TextBoxMesMonitor.Name = "TextBoxMesMonitor"
        Me.TextBoxMesMonitor.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxMesMonitor.TabIndex = 12
        '
        'TextBoxAnioMonitor
        '
        Me.TextBoxAnioMonitor.Location = New System.Drawing.Point(182, 198)
        Me.TextBoxAnioMonitor.Name = "TextBoxAnioMonitor"
        Me.TextBoxAnioMonitor.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxAnioMonitor.TabIndex = 13
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(278, 195)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(120, 23)
        Me.BtnNuevo.TabIndex = 14
        Me.BtnNuevo.Text = "Crear Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(412, 195)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(120, 23)
        Me.BtnGuardar.TabIndex = 15
        Me.BtnGuardar.Text = "Modificar y Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'DataGridMonitor
        '
        Me.DataGridMonitor.AllowUserToAddRows = False
        Me.DataGridMonitor.AllowUserToDeleteRows = False
        Me.DataGridMonitor.AllowUserToOrderColumns = True
        Me.DataGridMonitor.AllowUserToResizeRows = False
        Me.DataGridMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMonitor.Location = New System.Drawing.Point(12, 240)
        Me.DataGridMonitor.MultiSelect = False
        Me.DataGridMonitor.Name = "DataGridMonitor"
        Me.DataGridMonitor.ReadOnly = True
        Me.DataGridMonitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMonitor.Size = New System.Drawing.Size(520, 150)
        Me.DataGridMonitor.TabIndex = 16
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(12, 418)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 17
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(98, 418)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 19
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaInformacionCun2.My.Resources.Resources.monitor
        Me.PictureBox1.Location = New System.Drawing.Point(17, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(275, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Valor"
        '
        'TextBoxValorM
        '
        Me.TextBoxValorM.Location = New System.Drawing.Point(278, 144)
        Me.TextBoxValorM.Name = "TextBoxValorM"
        Me.TextBoxValorM.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxValorM.TabIndex = 24
        '
        'CRUDMonitorDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 516)
        Me.Controls.Add(Me.TextBoxValorM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.DataGridMonitor)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TextBoxAnioMonitor)
        Me.Controls.Add(Me.TextBoxMesMonitor)
        Me.Controls.Add(Me.TextBoxDiaMonitor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Mes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxMarcaMonitor)
        Me.Controls.Add(Me.TextBoxSerialMonitor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxIdMonitor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CRUDMonitorDesign"
        Me.Text = "CRUDMonitorDesign"
        CType(Me.DataGridMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxIdMonitor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxSerialMonitor As TextBox
    Friend WithEvents TextBoxMarcaMonitor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Mes As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxDiaMonitor As TextBox
    Friend WithEvents TextBoxMesMonitor As TextBox
    Friend WithEvents TextBoxAnioMonitor As TextBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents DataGridMonitor As DataGridView
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxValorM As TextBox
End Class
