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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearCPUDesing))
        Me.BtRegistarcpu = New System.Windows.Forms.Button()
        Me.BttRegresarcpu = New System.Windows.Forms.Button()
        Me.LabelIDcpu = New System.Windows.Forms.Label()
        Me.LabelSeriecpu = New System.Windows.Forms.Label()
        Me.LabelNombrecpu = New System.Windows.Forms.Label()
        Me.TextBidCpu = New System.Windows.Forms.TextBox()
        Me.TextBserieCpu = New System.Windows.Forms.TextBox()
        Me.TextBmarcaCpu = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtRegistarcpu
        '
        Me.BtRegistarcpu.Location = New System.Drawing.Point(84, 240)
        Me.BtRegistarcpu.Name = "BtRegistarcpu"
        Me.BtRegistarcpu.Size = New System.Drawing.Size(82, 23)
        Me.BtRegistarcpu.TabIndex = 0
        Me.BtRegistarcpu.Text = "Registar"
        Me.BtRegistarcpu.UseVisualStyleBackColor = True
        '
        'BttRegresarcpu
        '
        Me.BttRegresarcpu.Location = New System.Drawing.Point(277, 240)
        Me.BttRegresarcpu.Name = "BttRegresarcpu"
        Me.BttRegresarcpu.Size = New System.Drawing.Size(86, 23)
        Me.BttRegresarcpu.TabIndex = 1
        Me.BttRegresarcpu.Text = "Regresar"
        Me.BttRegresarcpu.UseVisualStyleBackColor = True
        '
        'LabelIDcpu
        '
        Me.LabelIDcpu.AutoSize = True
        Me.LabelIDcpu.Location = New System.Drawing.Point(20, 100)
        Me.LabelIDcpu.Name = "LabelIDcpu"
        Me.LabelIDcpu.Size = New System.Drawing.Size(18, 13)
        Me.LabelIDcpu.TabIndex = 2
        Me.LabelIDcpu.Text = "ID"
        '
        'LabelSeriecpu
        '
        Me.LabelSeriecpu.AutoSize = True
        Me.LabelSeriecpu.Location = New System.Drawing.Point(20, 140)
        Me.LabelSeriecpu.Name = "LabelSeriecpu"
        Me.LabelSeriecpu.Size = New System.Drawing.Size(31, 13)
        Me.LabelSeriecpu.TabIndex = 3
        Me.LabelSeriecpu.Text = "Serie"
        '
        'LabelNombrecpu
        '
        Me.LabelNombrecpu.AutoSize = True
        Me.LabelNombrecpu.Location = New System.Drawing.Point(20, 180)
        Me.LabelNombrecpu.Name = "LabelNombrecpu"
        Me.LabelNombrecpu.Size = New System.Drawing.Size(37, 13)
        Me.LabelNombrecpu.TabIndex = 4
        Me.LabelNombrecpu.Text = "Marca"
        '
        'TextBidCpu
        '
        Me.TextBidCpu.Location = New System.Drawing.Point(84, 100)
        Me.TextBidCpu.Name = "TextBidCpu"
        Me.TextBidCpu.Size = New System.Drawing.Size(279, 20)
        Me.TextBidCpu.TabIndex = 5
        '
        'TextBserieCpu
        '
        Me.TextBserieCpu.Location = New System.Drawing.Point(84, 140)
        Me.TextBserieCpu.Name = "TextBserieCpu"
        Me.TextBserieCpu.Size = New System.Drawing.Size(279, 20)
        Me.TextBserieCpu.TabIndex = 6
        '
        'TextBmarcaCpu
        '
        Me.TextBmarcaCpu.Location = New System.Drawing.Point(84, 180)
        Me.TextBmarcaCpu.Name = "TextBmarcaCpu"
        Me.TextBmarcaCpu.Size = New System.Drawing.Size(279, 20)
        Me.TextBmarcaCpu.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ingrese los datos para crear las CPU a gestionar"
        '
        'CrearCPUDesing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 275)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBmarcaCpu)
        Me.Controls.Add(Me.TextBserieCpu)
        Me.Controls.Add(Me.TextBidCpu)
        Me.Controls.Add(Me.LabelNombrecpu)
        Me.Controls.Add(Me.LabelSeriecpu)
        Me.Controls.Add(Me.LabelIDcpu)
        Me.Controls.Add(Me.BttRegresarcpu)
        Me.Controls.Add(Me.BtRegistarcpu)
        Me.Name = "CrearCPUDesing"
        Me.Text = "CrearCPUDising"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtRegistarcpu As Button
    Friend WithEvents BttRegresarcpu As Button
    Friend WithEvents LabelIDcpu As Label
    Friend WithEvents LabelSeriecpu As Label
    Friend WithEvents LabelNombrecpu As Label
    Friend WithEvents TextBidCpu As TextBox
    Friend WithEvents TextBserieCpu As TextBox
    Friend WithEvents TextBmarcaCpu As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
