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
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelSerie = New System.Windows.Forms.Label()
        Me.TexBIdmonitor = New System.Windows.Forms.TextBox()
        Me.TexBSerieMonitor = New System.Windows.Forms.TextBox()
        Me.TexBNombreMonitor = New System.Windows.Forms.TextBox()
        Me.LabelNombreEq = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BttRegresarMonitor
        '
        Me.BttRegresarMonitor.Location = New System.Drawing.Point(260, 240)
        Me.BttRegresarMonitor.Name = "BttRegresarMonitor"
        Me.BttRegresarMonitor.Size = New System.Drawing.Size(75, 23)
        Me.BttRegresarMonitor.TabIndex = 0
        Me.BttRegresarMonitor.Text = "Regresar"
        Me.BttRegresarMonitor.UseVisualStyleBackColor = True
        '
        'BttRegistarMonitor
        '
        Me.BttRegistarMonitor.Location = New System.Drawing.Point(92, 240)
        Me.BttRegistarMonitor.Name = "BttRegistarMonitor"
        Me.BttRegistarMonitor.Size = New System.Drawing.Size(75, 23)
        Me.BttRegistarMonitor.TabIndex = 1
        Me.BttRegistarMonitor.Text = "Registar"
        Me.BttRegistarMonitor.UseVisualStyleBackColor = True
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(3, 100)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(18, 13)
        Me.LabelID.TabIndex = 2
        Me.LabelID.Text = "ID"
        '
        'LabelSerie
        '
        Me.LabelSerie.AutoSize = True
        Me.LabelSerie.Location = New System.Drawing.Point(3, 130)
        Me.LabelSerie.Name = "LabelSerie"
        Me.LabelSerie.Size = New System.Drawing.Size(31, 13)
        Me.LabelSerie.TabIndex = 3
        Me.LabelSerie.Text = "Serie"
        '
        'TexBIdmonitor
        '
        Me.TexBIdmonitor.Location = New System.Drawing.Point(92, 100)
        Me.TexBIdmonitor.Name = "TexBIdmonitor"
        Me.TexBIdmonitor.Size = New System.Drawing.Size(254, 20)
        Me.TexBIdmonitor.TabIndex = 4
        '
        'TexBSerieMonitor
        '
        Me.TexBSerieMonitor.Location = New System.Drawing.Point(92, 130)
        Me.TexBSerieMonitor.Name = "TexBSerieMonitor"
        Me.TexBSerieMonitor.Size = New System.Drawing.Size(254, 20)
        Me.TexBSerieMonitor.TabIndex = 5
        '
        'TexBNombreMonitor
        '
        Me.TexBNombreMonitor.Location = New System.Drawing.Point(92, 160)
        Me.TexBNombreMonitor.Name = "TexBNombreMonitor"
        Me.TexBNombreMonitor.Size = New System.Drawing.Size(254, 20)
        Me.TexBNombreMonitor.TabIndex = 6
        '
        'LabelNombreEq
        '
        Me.LabelNombreEq.AutoSize = True
        Me.LabelNombreEq.Location = New System.Drawing.Point(3, 160)
        Me.LabelNombreEq.Name = "LabelNombreEq"
        Me.LabelNombreEq.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreEq.TabIndex = 7
        Me.LabelNombreEq.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ingrese los datos para crear los monitores a gestionar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'CrearMonitorDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 275)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelNombreEq)
        Me.Controls.Add(Me.TexBNombreMonitor)
        Me.Controls.Add(Me.TexBSerieMonitor)
        Me.Controls.Add(Me.TexBIdmonitor)
        Me.Controls.Add(Me.LabelSerie)
        Me.Controls.Add(Me.LabelID)
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
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelSerie As Label
    Friend WithEvents TexBIdmonitor As TextBox
    Friend WithEvents TexBSerieMonitor As TextBox
    Friend WithEvents TexBNombreMonitor As TextBox
    Friend WithEvents LabelNombreEq As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
