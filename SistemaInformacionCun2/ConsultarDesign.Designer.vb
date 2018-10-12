<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultarDesign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultarDesign))
        Me.BtRegresarConsultar = New System.Windows.Forms.Button()
        Me.BtConsultarCpu = New System.Windows.Forms.Button()
        Me.BtConsultarPersonas = New System.Windows.Forms.Button()
        Me.BtConsultarMonitores = New System.Windows.Forms.Button()
        Me.TxResultadoColsulta = New System.Windows.Forms.TextBox()
        Me.BtConsultarImpresoras = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtRegresarConsultar
        '
        Me.BtRegresarConsultar.Location = New System.Drawing.Point(411, 304)
        Me.BtRegresarConsultar.Name = "BtRegresarConsultar"
        Me.BtRegresarConsultar.Size = New System.Drawing.Size(130, 23)
        Me.BtRegresarConsultar.TabIndex = 0
        Me.BtRegresarConsultar.Text = "Regresar"
        Me.BtRegresarConsultar.UseVisualStyleBackColor = True
        '
        'BtConsultarCpu
        '
        Me.BtConsultarCpu.Location = New System.Drawing.Point(139, 275)
        Me.BtConsultarCpu.Name = "BtConsultarCpu"
        Me.BtConsultarCpu.Size = New System.Drawing.Size(130, 23)
        Me.BtConsultarCpu.TabIndex = 1
        Me.BtConsultarCpu.Text = "Consultar CPU"
        Me.BtConsultarCpu.UseVisualStyleBackColor = True
        '
        'BtConsultarPersonas
        '
        Me.BtConsultarPersonas.Location = New System.Drawing.Point(3, 275)
        Me.BtConsultarPersonas.Name = "BtConsultarPersonas"
        Me.BtConsultarPersonas.Size = New System.Drawing.Size(130, 23)
        Me.BtConsultarPersonas.TabIndex = 2
        Me.BtConsultarPersonas.Text = "Consultar Personas "
        Me.BtConsultarPersonas.UseVisualStyleBackColor = True
        '
        'BtConsultarMonitores
        '
        Me.BtConsultarMonitores.Location = New System.Drawing.Point(275, 275)
        Me.BtConsultarMonitores.Name = "BtConsultarMonitores"
        Me.BtConsultarMonitores.Size = New System.Drawing.Size(130, 23)
        Me.BtConsultarMonitores.TabIndex = 3
        Me.BtConsultarMonitores.Text = "Consultar Monitores"
        Me.BtConsultarMonitores.UseVisualStyleBackColor = True
        '
        'TxResultadoColsulta
        '
        Me.TxResultadoColsulta.Location = New System.Drawing.Point(3, 69)
        Me.TxResultadoColsulta.Multiline = True
        Me.TxResultadoColsulta.Name = "TxResultadoColsulta"
        Me.TxResultadoColsulta.ReadOnly = True
        Me.TxResultadoColsulta.Size = New System.Drawing.Size(538, 200)
        Me.TxResultadoColsulta.TabIndex = 4
        '
        'BtConsultarImpresoras
        '
        Me.BtConsultarImpresoras.Location = New System.Drawing.Point(411, 275)
        Me.BtConsultarImpresoras.Name = "BtConsultarImpresoras"
        Me.BtConsultarImpresoras.Size = New System.Drawing.Size(130, 23)
        Me.BtConsultarImpresoras.TabIndex = 5
        Me.BtConsultarImpresoras.Text = "Consultar Impresoras"
        Me.BtConsultarImpresoras.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Listado de datos sistemas de informacion CUN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ConsultarDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 335)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtConsultarImpresoras)
        Me.Controls.Add(Me.TxResultadoColsulta)
        Me.Controls.Add(Me.BtConsultarMonitores)
        Me.Controls.Add(Me.BtConsultarPersonas)
        Me.Controls.Add(Me.BtConsultarCpu)
        Me.Controls.Add(Me.BtRegresarConsultar)
        Me.Name = "ConsultarDesign"
        Me.Text = "ConsultarDesign"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtRegresarConsultar As Button
    Friend WithEvents BtConsultarCpu As Button
    Friend WithEvents BtConsultarPersonas As Button
    Friend WithEvents BtConsultarMonitores As Button
    Friend WithEvents TxResultadoColsulta As TextBox
    Friend WithEvents BtConsultarImpresoras As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
