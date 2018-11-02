<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearMonitorDesign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearMonitorDesign))
        Me.BttRegresarMonitor = New System.Windows.Forms.Button()
        Me.BttRegistarMonitor = New System.Windows.Forms.Button()
        Me.LabelSerie = New System.Windows.Forms.Label()
        Me.TexBSerieMonitor = New System.Windows.Forms.TextBox()
        Me.TexBMarcaMonitor = New System.Windows.Forms.TextBox()
        Me.LabelNombreEq = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxDíaMonitor = New System.Windows.Forms.TextBox()
        Me.TextBoxanioMonitor = New System.Windows.Forms.TextBox()
        Me.TextBoMesMonitor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxValorMonitor = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BttRegresarMonitor
        '
        Me.BttRegresarMonitor.Location = New System.Drawing.Point(280, 307)
        Me.BttRegresarMonitor.Name = "BttRegresarMonitor"
        Me.BttRegresarMonitor.Size = New System.Drawing.Size(75, 23)
        Me.BttRegresarMonitor.TabIndex = 0
        Me.BttRegresarMonitor.Text = "Regresar"
        Me.BttRegresarMonitor.UseVisualStyleBackColor = True
        '
        'BttRegistarMonitor
        '
        Me.BttRegistarMonitor.Location = New System.Drawing.Point(199, 307)
        Me.BttRegistarMonitor.Name = "BttRegistarMonitor"
        Me.BttRegistarMonitor.Size = New System.Drawing.Size(75, 23)
        Me.BttRegistarMonitor.TabIndex = 1
        Me.BttRegistarMonitor.Text = "Registar"
        Me.BttRegistarMonitor.UseVisualStyleBackColor = True
        '
        'LabelSerie
        '
        Me.LabelSerie.AutoSize = True
        Me.LabelSerie.Location = New System.Drawing.Point(18, 105)
        Me.LabelSerie.Name = "LabelSerie"
        Me.LabelSerie.Size = New System.Drawing.Size(31, 13)
        Me.LabelSerie.TabIndex = 3
        Me.LabelSerie.Text = "Serie"
        '
        'TexBSerieMonitor
        '
        Me.TexBSerieMonitor.Location = New System.Drawing.Point(20, 121)
        Me.TexBSerieMonitor.Name = "TexBSerieMonitor"
        Me.TexBSerieMonitor.Size = New System.Drawing.Size(340, 20)
        Me.TexBSerieMonitor.TabIndex = 5
        '
        'TexBMarcaMonitor
        '
        Me.TexBMarcaMonitor.Location = New System.Drawing.Point(21, 164)
        Me.TexBMarcaMonitor.Name = "TexBMarcaMonitor"
        Me.TexBMarcaMonitor.Size = New System.Drawing.Size(340, 20)
        Me.TexBMarcaMonitor.TabIndex = 6
        '
        'LabelNombreEq
        '
        Me.LabelNombreEq.AutoSize = True
        Me.LabelNombreEq.Location = New System.Drawing.Point(18, 144)
        Me.LabelNombreEq.Name = "LabelNombreEq"
        Me.LabelNombreEq.Size = New System.Drawing.Size(37, 13)
        Me.LabelNombreEq.TabIndex = 7
        Me.LabelNombreEq.Text = "Marca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ingrese los datos para crear los monitores a gestionar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'TextBoxDíaMonitor
        '
        Me.TextBoxDíaMonitor.Location = New System.Drawing.Point(21, 248)
        Me.TextBoxDíaMonitor.Name = "TextBoxDíaMonitor"
        Me.TextBoxDíaMonitor.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDíaMonitor.TabIndex = 10
        '
        'TextBoxanioMonitor
        '
        Me.TextBoxanioMonitor.Location = New System.Drawing.Point(255, 248)
        Me.TextBoxanioMonitor.Name = "TextBoxanioMonitor"
        Me.TextBoxanioMonitor.Size = New System.Drawing.Size(105, 20)
        Me.TextBoxanioMonitor.TabIndex = 11
        '
        'TextBoMesMonitor
        '
        Me.TextBoMesMonitor.Location = New System.Drawing.Point(139, 248)
        Me.TextBoMesMonitor.Name = "TextBoMesMonitor"
        Me.TextBoMesMonitor.Size = New System.Drawing.Size(100, 20)
        Me.TextBoMesMonitor.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Día"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Mes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Año"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Valor"
        '
        'TextBoxValorMonitor
        '
        Me.TextBoxValorMonitor.Location = New System.Drawing.Point(21, 203)
        Me.TextBoxValorMonitor.Name = "TextBoxValorMonitor"
        Me.TextBoxValorMonitor.Size = New System.Drawing.Size(340, 20)
        Me.TextBoxValorMonitor.TabIndex = 17
        '
        'CrearMonitorDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 342)
        Me.Controls.Add(Me.TextBoxValorMonitor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoMesMonitor)
        Me.Controls.Add(Me.TextBoxanioMonitor)
        Me.Controls.Add(Me.TextBoxDíaMonitor)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelNombreEq)
        Me.Controls.Add(Me.TexBMarcaMonitor)
        Me.Controls.Add(Me.TexBSerieMonitor)
        Me.Controls.Add(Me.LabelSerie)
        Me.Controls.Add(Me.BttRegistarMonitor)
        Me.Controls.Add(Me.BttRegresarMonitor)
        Me.Name = "CrearMonitorDesign"
        Me.Text = "CrearMonitorDising"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BttRegresarMonitor As Button
    Friend WithEvents BttRegistarMonitor As Button
    Friend WithEvents LabelSerie As Label
    Friend WithEvents TexBSerieMonitor As TextBox
    Friend WithEvents TexBMarcaMonitor As TextBox
    Friend WithEvents LabelNombreEq As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxDíaMonitor As TextBox
    Friend WithEvents TextBoxanioMonitor As TextBox
    Friend WithEvents TextBoMesMonitor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxValorMonitor As TextBox
End Class
