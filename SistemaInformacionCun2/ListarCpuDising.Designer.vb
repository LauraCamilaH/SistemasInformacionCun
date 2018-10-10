<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarCpuDising
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
        Me.Btcargarcpu = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtRegresar
        '
        Me.BtRegresar.Location = New System.Drawing.Point(197, 212)
        Me.BtRegresar.Name = "BtRegresar"
        Me.BtRegresar.Size = New System.Drawing.Size(75, 23)
        Me.BtRegresar.TabIndex = 0
        Me.BtRegresar.Text = "Regresar"
        Me.BtRegresar.UseVisualStyleBackColor = True
        '
        'Btcargarcpu
        '
        Me.Btcargarcpu.Location = New System.Drawing.Point(70, 211)
        Me.Btcargarcpu.Name = "Btcargarcpu"
        Me.Btcargarcpu.Size = New System.Drawing.Size(75, 23)
        Me.Btcargarcpu.TabIndex = 1
        Me.Btcargarcpu.Text = "Cargar"
        Me.Btcargarcpu.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(59, 52)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 138)
        Me.TextBox1.TabIndex = 2
        '
        'ListarCpuDising
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Btcargarcpu)
        Me.Controls.Add(Me.BtRegresar)
        Me.Name = "ListarCpuDising"
        Me.Text = "ListarCpuDising"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtRegresar As Button
    Friend WithEvents Btcargarcpu As Button
    Friend WithEvents TextBox1 As TextBox
End Class
