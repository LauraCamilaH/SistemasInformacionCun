<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearCPUDesing
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
        Me.BtRegistarcpu = New System.Windows.Forms.Button()
        Me.BttRegresarcpu = New System.Windows.Forms.Button()
        Me.LabelIDcpu = New System.Windows.Forms.Label()
        Me.LabelSeriecpu = New System.Windows.Forms.Label()
        Me.LabelNombrecpu = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtRegistarcpu
        '
        Me.BtRegistarcpu.Location = New System.Drawing.Point(13, 216)
        Me.BtRegistarcpu.Name = "BtRegistarcpu"
        Me.BtRegistarcpu.Size = New System.Drawing.Size(75, 23)
        Me.BtRegistarcpu.TabIndex = 0
        Me.BtRegistarcpu.Text = "Registar"
        Me.BtRegistarcpu.UseVisualStyleBackColor = True
        '
        'BttRegresarcpu
        '
        Me.BttRegresarcpu.Location = New System.Drawing.Point(202, 215)
        Me.BttRegresarcpu.Name = "BttRegresarcpu"
        Me.BttRegresarcpu.Size = New System.Drawing.Size(75, 23)
        Me.BttRegresarcpu.TabIndex = 1
        Me.BttRegresarcpu.Text = "Regresar"
        Me.BttRegresarcpu.UseVisualStyleBackColor = True
        '
        'LabelIDcpu
        '
        Me.LabelIDcpu.AutoSize = True
        Me.LabelIDcpu.Location = New System.Drawing.Point(41, 33)
        Me.LabelIDcpu.Name = "LabelIDcpu"
        Me.LabelIDcpu.Size = New System.Drawing.Size(18, 13)
        Me.LabelIDcpu.TabIndex = 2
        Me.LabelIDcpu.Text = "ID"
        '
        'LabelSeriecpu
        '
        Me.LabelSeriecpu.AutoSize = True
        Me.LabelSeriecpu.Location = New System.Drawing.Point(41, 73)
        Me.LabelSeriecpu.Name = "LabelSeriecpu"
        Me.LabelSeriecpu.Size = New System.Drawing.Size(31, 13)
        Me.LabelSeriecpu.TabIndex = 3
        Me.LabelSeriecpu.Text = "Serie"
        '
        'LabelNombrecpu
        '
        Me.LabelNombrecpu.AutoSize = True
        Me.LabelNombrecpu.Location = New System.Drawing.Point(41, 125)
        Me.LabelNombrecpu.Name = "LabelNombrecpu"
        Me.LabelNombrecpu.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombrecpu.TabIndex = 4
        Me.LabelNombrecpu.Text = "Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(124, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(124, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(124, 117)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'CrearCPUDising
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelNombrecpu)
        Me.Controls.Add(Me.LabelSeriecpu)
        Me.Controls.Add(Me.LabelIDcpu)
        Me.Controls.Add(Me.BttRegresarcpu)
        Me.Controls.Add(Me.BtRegistarcpu)
        Me.Name = "CrearCPUDising"
        Me.Text = "CrearCPUDising"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtRegistarcpu As Button
    Friend WithEvents BttRegresarcpu As Button
    Friend WithEvents LabelIDcpu As Label
    Friend WithEvents LabelSeriecpu As Label
    Friend WithEvents LabelNombrecpu As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
