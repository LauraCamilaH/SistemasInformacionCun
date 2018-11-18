<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUDCpuDesign
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRUDCpuDesign))
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.CPU = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxIDcpu = New System.Windows.Forms.TextBox()
        Me.TextBoxSerieCPU = New System.Windows.Forms.TextBox()
        Me.TextBoxMarcaCpu = New System.Windows.Forms.TextBox()
        Me.TextBoxDiaCpu = New System.Windows.Forms.TextBox()
        Me.TextBoxMesCpu = New System.Windows.Forms.TextBox()
        Me.TextBoxAnioCpu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridViewcpu = New System.Windows.Forms.DataGridView()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxValorC = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewcpu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(412, 202)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(120, 23)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Modificar o Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(282, 202)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(120, 23)
        Me.BtnNuevo.TabIndex = 2
        Me.BtnNuevo.Text = "Crear Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(12, 485)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 3
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'CPU
        '
        Me.CPU.AutoSize = True
        Me.CPU.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPU.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CPU.Location = New System.Drawing.Point(277, 9)
        Me.CPU.Name = "CPU"
        Me.CPU.Size = New System.Drawing.Size(57, 25)
        Me.CPU.TabIndex = 4
        Me.CPU.Text = "CPU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Edite la información de CPU en el siguiente formulario"
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.Location = New System.Drawing.Point(14, 80)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(16, 13)
        Me.Id.TabIndex = 6
        Me.Id.Text = "Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Marca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Serie"
        '
        'TextBoxIDcpu
        '
        Me.TextBoxIDcpu.Location = New System.Drawing.Point(11, 96)
        Me.TextBoxIDcpu.Name = "TextBoxIDcpu"
        Me.TextBoxIDcpu.ReadOnly = True
        Me.TextBoxIDcpu.Size = New System.Drawing.Size(251, 20)
        Me.TextBoxIDcpu.TabIndex = 10
        '
        'TextBoxSerieCPU
        '
        Me.TextBoxSerieCPU.Location = New System.Drawing.Point(12, 144)
        Me.TextBoxSerieCPU.Name = "TextBoxSerieCPU"
        Me.TextBoxSerieCPU.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxSerieCPU.TabIndex = 11
        '
        'TextBoxMarcaCpu
        '
        Me.TextBoxMarcaCpu.Location = New System.Drawing.Point(281, 96)
        Me.TextBoxMarcaCpu.Name = "TextBoxMarcaCpu"
        Me.TextBoxMarcaCpu.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxMarcaCpu.TabIndex = 12
        '
        'TextBoxDiaCpu
        '
        Me.TextBoxDiaCpu.Location = New System.Drawing.Point(12, 202)
        Me.TextBoxDiaCpu.Name = "TextBoxDiaCpu"
        Me.TextBoxDiaCpu.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxDiaCpu.TabIndex = 13
        '
        'TextBoxMesCpu
        '
        Me.TextBoxMesCpu.Location = New System.Drawing.Point(98, 202)
        Me.TextBoxMesCpu.Name = "TextBoxMesCpu"
        Me.TextBoxMesCpu.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxMesCpu.TabIndex = 14
        '
        'TextBoxAnioCpu
        '
        Me.TextBoxAnioCpu.Location = New System.Drawing.Point(182, 202)
        Me.TextBoxAnioCpu.Name = "TextBoxAnioCpu"
        Me.TextBoxAnioCpu.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxAnioCpu.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Día"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Mes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(182, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Año"
        '
        'DataGridViewcpu
        '
        Me.DataGridViewcpu.AllowUserToAddRows = False
        Me.DataGridViewcpu.AllowUserToDeleteRows = False
        Me.DataGridViewcpu.AllowUserToOrderColumns = True
        Me.DataGridViewcpu.AllowUserToResizeRows = False
        Me.DataGridViewcpu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewcpu.Location = New System.Drawing.Point(12, 240)
        Me.DataGridViewcpu.MultiSelect = False
        Me.DataGridViewcpu.Name = "DataGridViewcpu"
        Me.DataGridViewcpu.ReadOnly = True
        Me.DataGridViewcpu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewcpu.Size = New System.Drawing.Size(520, 229)
        Me.DataGridViewcpu.TabIndex = 19
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(93, 484)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 20
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaInformacionCun2.My.Resources.Resources.Cpu
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Valor"
        '
        'TextBoxValorC
        '
        Me.TextBoxValorC.Location = New System.Drawing.Point(281, 144)
        Me.TextBoxValorC.Name = "TextBoxValorC"
        Me.TextBoxValorC.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxValorC.TabIndex = 25
        '
        'CRUDCpuDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 541)
        Me.Controls.Add(Me.TextBoxValorC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.DataGridViewcpu)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxAnioCpu)
        Me.Controls.Add(Me.TextBoxMesCpu)
        Me.Controls.Add(Me.TextBoxDiaCpu)
        Me.Controls.Add(Me.TextBoxMarcaCpu)
        Me.Controls.Add(Me.TextBoxSerieCPU)
        Me.Controls.Add(Me.TextBoxIDcpu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CPU)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Name = "CRUDCpuDesign"
        Me.Text = "CRUPCpuDesign"
        CType(Me.DataGridViewcpu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents CPU As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Id As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxIDcpu As TextBox
    Friend WithEvents TextBoxSerieCPU As TextBox
    Friend WithEvents TextBoxMarcaCpu As TextBox
    Friend WithEvents TextBoxDiaCpu As TextBox
    Friend WithEvents TextBoxMesCpu As TextBox
    Friend WithEvents TextBoxAnioCpu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridViewcpu As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxValorC As TextBox
End Class
