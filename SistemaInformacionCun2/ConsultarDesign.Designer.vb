<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarDesign
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
        Me.BtRegresarConsultar = New System.Windows.Forms.Button()
        Me.BtConsultarCpu = New System.Windows.Forms.Button()
        Me.BtConsultarPersonas = New System.Windows.Forms.Button()
        Me.BtConsultarMonitores = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtConsultarImpresoras = New System.Windows.Forms.Button()
        Me.BtConsultarLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtRegresarConsultar
        '
        Me.BtRegresarConsultar.Location = New System.Drawing.Point(174, 226)
        Me.BtRegresarConsultar.Name = "BtRegresarConsultar"
        Me.BtRegresarConsultar.Size = New System.Drawing.Size(156, 23)
        Me.BtRegresarConsultar.TabIndex = 0
        Me.BtRegresarConsultar.Text = "Regresar"
        Me.BtRegresarConsultar.UseVisualStyleBackColor = True
        '
        'BtConsultarCpu
        '
        Me.BtConsultarCpu.Location = New System.Drawing.Point(93, 181)
        Me.BtConsultarCpu.Name = "BtConsultarCpu"
        Me.BtConsultarCpu.Size = New System.Drawing.Size(75, 42)
        Me.BtConsultarCpu.TabIndex = 1
        Me.BtConsultarCpu.Text = "Consultar CPU"
        Me.BtConsultarCpu.UseVisualStyleBackColor = True
        '
        'BtConsultarPersonas
        '
        Me.BtConsultarPersonas.Location = New System.Drawing.Point(12, 181)
        Me.BtConsultarPersonas.Name = "BtConsultarPersonas"
        Me.BtConsultarPersonas.Size = New System.Drawing.Size(75, 42)
        Me.BtConsultarPersonas.TabIndex = 2
        Me.BtConsultarPersonas.Text = "Consultar Personas "
        Me.BtConsultarPersonas.UseVisualStyleBackColor = True
        '
        'BtConsultarMonitores
        '
        Me.BtConsultarMonitores.Location = New System.Drawing.Point(174, 181)
        Me.BtConsultarMonitores.Name = "BtConsultarMonitores"
        Me.BtConsultarMonitores.Size = New System.Drawing.Size(75, 39)
        Me.BtConsultarMonitores.TabIndex = 3
        Me.BtConsultarMonitores.Text = "Consultar Monitores"
        Me.BtConsultarMonitores.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(318, 163)
        Me.TextBox1.TabIndex = 4
        '
        'BtConsultarImpresoras
        '
        Me.BtConsultarImpresoras.Location = New System.Drawing.Point(255, 181)
        Me.BtConsultarImpresoras.Name = "BtConsultarImpresoras"
        Me.BtConsultarImpresoras.Size = New System.Drawing.Size(75, 39)
        Me.BtConsultarImpresoras.TabIndex = 5
        Me.BtConsultarImpresoras.Text = "Consultar Impresoras"
        Me.BtConsultarImpresoras.UseVisualStyleBackColor = True
        '
        'BtConsultarLimpiar
        '
        Me.BtConsultarLimpiar.Location = New System.Drawing.Point(13, 226)
        Me.BtConsultarLimpiar.Name = "BtConsultarLimpiar"
        Me.BtConsultarLimpiar.Size = New System.Drawing.Size(155, 24)
        Me.BtConsultarLimpiar.TabIndex = 6
        Me.BtConsultarLimpiar.Text = "Limpiar "
        Me.BtConsultarLimpiar.UseVisualStyleBackColor = True
        '
        'ConsultarDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 262)
        Me.Controls.Add(Me.BtConsultarLimpiar)
        Me.Controls.Add(Me.BtConsultarImpresoras)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtConsultarMonitores)
        Me.Controls.Add(Me.BtConsultarPersonas)
        Me.Controls.Add(Me.BtConsultarCpu)
        Me.Controls.Add(Me.BtRegresarConsultar)
        Me.Name = "ConsultarDesign"
        Me.Text = "ConsultarDesign"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtRegresarConsultar As Button
    Friend WithEvents BtConsultarCpu As Button
    Friend WithEvents BtConsultarPersonas As Button
    Friend WithEvents BtConsultarMonitores As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtConsultarImpresoras As Button
    Friend WithEvents BtConsultarLimpiar As Button
End Class
