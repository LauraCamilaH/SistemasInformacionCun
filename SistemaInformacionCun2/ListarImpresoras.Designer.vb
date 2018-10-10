<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarImpresoras
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
        Me.TextBlistaimpresoras = New System.Windows.Forms.TextBox()
        Me.BtlistarImpre = New System.Windows.Forms.Button()
        Me.BtRegresarImpre = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBlistaimpresoras
        '
        Me.TextBlistaimpresoras.Location = New System.Drawing.Point(97, 73)
        Me.TextBlistaimpresoras.Multiline = True
        Me.TextBlistaimpresoras.Name = "TextBlistaimpresoras"
        Me.TextBlistaimpresoras.Size = New System.Drawing.Size(100, 20)
        Me.TextBlistaimpresoras.TabIndex = 0
        '
        'BtlistarImpre
        '
        Me.BtlistarImpre.Location = New System.Drawing.Point(36, 205)
        Me.BtlistarImpre.Name = "BtlistarImpre"
        Me.BtlistarImpre.Size = New System.Drawing.Size(75, 23)
        Me.BtlistarImpre.TabIndex = 1
        Me.BtlistarImpre.Text = "Listar"
        Me.BtlistarImpre.UseVisualStyleBackColor = True
        '
        'BtRegresarImpre
        '
        Me.BtRegresarImpre.Location = New System.Drawing.Point(188, 205)
        Me.BtRegresarImpre.Name = "BtRegresarImpre"
        Me.BtRegresarImpre.Size = New System.Drawing.Size(75, 23)
        Me.BtRegresarImpre.TabIndex = 2
        Me.BtRegresarImpre.Text = "Regresar"
        Me.BtRegresarImpre.UseVisualStyleBackColor = True
        '
        'ListarImpresoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtRegresarImpre)
        Me.Controls.Add(Me.BtlistarImpre)
        Me.Controls.Add(Me.TextBlistaimpresoras)
        Me.Name = "ListarImpresoras"
        Me.Text = "ListarImpresoras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBlistaimpresoras As TextBox
    Friend WithEvents BtlistarImpre As Button
    Friend WithEvents BtRegresarImpre As Button
End Class
