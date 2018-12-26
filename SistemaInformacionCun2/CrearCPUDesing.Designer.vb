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
        Me.LabelSeriecpu = New System.Windows.Forms.Label()
        Me.LabelNombrecpu = New System.Windows.Forms.Label()
        Me.TextBserieCpu = New System.Windows.Forms.TextBox()
        Me.TextBmarcaCpu = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxDiaCpu = New System.Windows.Forms.TextBox()
        Me.TextBoxMesCpu = New System.Windows.Forms.TextBox()
        Me.TextBoxAnioCpu = New System.Windows.Forms.TextBox()
        Me.TextBoxValorCpu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtRegistarcpu
        '
        Me.BtRegistarcpu.Location = New System.Drawing.Point(196, 306)
        Me.BtRegistarcpu.Name = "BtRegistarcpu"
        Me.BtRegistarcpu.Size = New System.Drawing.Size(82, 23)
        Me.BtRegistarcpu.TabIndex = 0
        Me.BtRegistarcpu.Text = "Registar"
        Me.BtRegistarcpu.UseVisualStyleBackColor = True
        '
        'BttRegresarcpu
        '
        Me.BttRegresarcpu.Location = New System.Drawing.Point(284, 306)
        Me.BttRegresarcpu.Name = "BttRegresarcpu"
        Me.BttRegresarcpu.Size = New System.Drawing.Size(79, 23)
        Me.BttRegresarcpu.TabIndex = 1
        Me.BttRegresarcpu.Text = "Regresar"
        Me.BttRegresarcpu.UseVisualStyleBackColor = True
        '
        'LabelSeriecpu
        '
        Me.LabelSeriecpu.AutoSize = True
        Me.LabelSeriecpu.Location = New System.Drawing.Point(17, 105)
        Me.LabelSeriecpu.Name = "LabelSeriecpu"
        Me.LabelSeriecpu.Size = New System.Drawing.Size(31, 13)
        Me.LabelSeriecpu.TabIndex = 3
        Me.LabelSeriecpu.Text = "Serie"
        '
        'LabelNombrecpu
        '
        Me.LabelNombrecpu.AutoSize = True
        Me.LabelNombrecpu.Location = New System.Drawing.Point(17, 144)
        Me.LabelNombrecpu.Name = "LabelNombrecpu"
        Me.LabelNombrecpu.Size = New System.Drawing.Size(37, 13)
        Me.LabelNombrecpu.TabIndex = 4
        Me.LabelNombrecpu.Text = "Marca"
        '
        'TextBserieCpu
        '
        Me.TextBserieCpu.Location = New System.Drawing.Point(20, 121)
        Me.TextBserieCpu.Name = "TextBserieCpu"
        Me.TextBserieCpu.Size = New System.Drawing.Size(343, 20)
        Me.TextBserieCpu.TabIndex = 6
        '
        'TextBmarcaCpu
        '
        Me.TextBmarcaCpu.Location = New System.Drawing.Point(20, 157)
        Me.TextBmarcaCpu.Name = "TextBmarcaCpu"
        Me.TextBmarcaCpu.Size = New System.Drawing.Size(343, 20)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Día"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Mes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Año"
        '
        'TextBoxDiaCpu
        '
        Me.TextBoxDiaCpu.Location = New System.Drawing.Point(18, 248)
        Me.TextBoxDiaCpu.Name = "TextBoxDiaCpu"
        Me.TextBoxDiaCpu.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDiaCpu.TabIndex = 13
        '
        'TextBoxMesCpu
        '
        Me.TextBoxMesCpu.Location = New System.Drawing.Point(142, 248)
        Me.TextBoxMesCpu.Name = "TextBoxMesCpu"
        Me.TextBoxMesCpu.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMesCpu.TabIndex = 14
        '
        'TextBoxAnioCpu
        '
        Me.TextBoxAnioCpu.Location = New System.Drawing.Point(263, 248)
        Me.TextBoxAnioCpu.Name = "TextBoxAnioCpu"
        Me.TextBoxAnioCpu.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAnioCpu.TabIndex = 15
        '
        'TextBoxValorCpu
        '
        Me.TextBoxValorCpu.Location = New System.Drawing.Point(20, 200)
        Me.TextBoxValorCpu.Name = "TextBoxValorCpu"
        Me.TextBoxValorCpu.Size = New System.Drawing.Size(343, 20)
        Me.TextBoxValorCpu.TabIndex = 16
        Me.TextBoxValorCpu.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Valor"
        '
        'CrearCPUDesing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 341)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxValorCpu)
        Me.Controls.Add(Me.TextBoxAnioCpu)
        Me.Controls.Add(Me.TextBoxMesCpu)
        Me.Controls.Add(Me.TextBoxDiaCpu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBmarcaCpu)
        Me.Controls.Add(Me.TextBserieCpu)
        Me.Controls.Add(Me.LabelNombrecpu)
        Me.Controls.Add(Me.LabelSeriecpu)
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
    Friend WithEvents LabelSeriecpu As Label
    Friend WithEvents LabelNombrecpu As Label
    Friend WithEvents TextBserieCpu As TextBox
    Friend WithEvents TextBmarcaCpu As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxDiaCpu As TextBox
    Friend WithEvents TextBoxMesCpu As TextBox
    Friend WithEvents TextBoxAnioCpu As TextBox
    Friend WithEvents TextBoxValorCpu As TextBox
    Friend WithEvents Label5 As Label
End Class
