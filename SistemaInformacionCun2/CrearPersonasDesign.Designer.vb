<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesignEjercicioClase
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
        Me.BtRegresar = New System.Windows.Forms.Button()
        Me.btRegistar = New System.Windows.Forms.Button()
        Me.Textnombre = New System.Windows.Forms.TextBox()
        Me.Textapellido = New System.Windows.Forms.TextBox()
        Me.Textcedula = New System.Windows.Forms.TextBox()
        Me.Textciudad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtRegresar
        '
        Me.BtRegresar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtRegresar.Location = New System.Drawing.Point(207, 188)
        Me.BtRegresar.Name = "BtRegresar"
        Me.BtRegresar.Size = New System.Drawing.Size(75, 23)
        Me.BtRegresar.TabIndex = 0
        Me.BtRegresar.Text = "Regresar"
        Me.BtRegresar.UseVisualStyleBackColor = False
        '
        'btRegistar
        '
        Me.btRegistar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btRegistar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegistar.Location = New System.Drawing.Point(40, 188)
        Me.btRegistar.Name = "btRegistar"
        Me.btRegistar.Size = New System.Drawing.Size(75, 23)
        Me.btRegistar.TabIndex = 1
        Me.btRegistar.Text = "Registrar"
        Me.btRegistar.UseVisualStyleBackColor = False
        '
        'Textnombre
        '
        Me.Textnombre.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Textnombre.Location = New System.Drawing.Point(91, 36)
        Me.Textnombre.Name = "Textnombre"
        Me.Textnombre.Size = New System.Drawing.Size(100, 20)
        Me.Textnombre.TabIndex = 2
        '
        'Textapellido
        '
        Me.Textapellido.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Textapellido.Location = New System.Drawing.Point(299, 36)
        Me.Textapellido.Name = "Textapellido"
        Me.Textapellido.Size = New System.Drawing.Size(100, 20)
        Me.Textapellido.TabIndex = 3
        '
        'Textcedula
        '
        Me.Textcedula.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Textcedula.Location = New System.Drawing.Point(91, 90)
        Me.Textcedula.Name = "Textcedula"
        Me.Textcedula.Size = New System.Drawing.Size(100, 20)
        Me.Textcedula.TabIndex = 4
        '
        'Textciudad
        '
        Me.Textciudad.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Textciudad.Location = New System.Drawing.Point(299, 90)
        Me.Textciudad.Name = "Textciudad"
        Me.Textciudad.Size = New System.Drawing.Size(100, 20)
        Me.Textciudad.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Apellido"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(33, 102)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(40, 13)
        Me.label3.TabIndex = 8
        Me.label3.Text = "Cédula"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(231, 90)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(40, 13)
        Me.label4.TabIndex = 9
        Me.label4.Text = "Ciudad"
        '
        'DesignEjercicioClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(572, 283)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Textciudad)
        Me.Controls.Add(Me.Textcedula)
        Me.Controls.Add(Me.Textapellido)
        Me.Controls.Add(Me.Textnombre)
        Me.Controls.Add(Me.btRegistar)
        Me.Controls.Add(Me.BtRegresar)
        Me.Name = "DesignEjercicioClase"
        Me.Text = "Ejercicio Ingreso datos "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtRegresar As Button
    Friend WithEvents btRegistar As Button
    Friend WithEvents Textnombre As TextBox
    Friend WithEvents Textapellido As TextBox
    Friend WithEvents Textcedula As TextBox
    Friend WithEvents Textciudad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label4 As Label
End Class
