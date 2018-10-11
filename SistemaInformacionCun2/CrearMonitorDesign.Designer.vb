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
        Me.BttRegresarMonitor = New System.Windows.Forms.Button()
        Me.BttRegistarMonitor = New System.Windows.Forms.Button()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelSerie = New System.Windows.Forms.Label()
        Me.TexBIdmonitor = New System.Windows.Forms.TextBox()
        Me.TexBSerieMonitor = New System.Windows.Forms.TextBox()
        Me.TexBNombreMonitor = New System.Windows.Forms.TextBox()
        Me.LabelNombreEq = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BttRegresarMonitor
        '
        Me.BttRegresarMonitor.Location = New System.Drawing.Point(197, 226)
        Me.BttRegresarMonitor.Name = "BttRegresarMonitor"
        Me.BttRegresarMonitor.Size = New System.Drawing.Size(75, 23)
        Me.BttRegresarMonitor.TabIndex = 0
        Me.BttRegresarMonitor.Text = "Regresar"
        Me.BttRegresarMonitor.UseVisualStyleBackColor = True
        '
        'BttRegistarMonitor
        '
        Me.BttRegistarMonitor.Location = New System.Drawing.Point(74, 226)
        Me.BttRegistarMonitor.Name = "BttRegistarMonitor"
        Me.BttRegistarMonitor.Size = New System.Drawing.Size(75, 23)
        Me.BttRegistarMonitor.TabIndex = 1
        Me.BttRegistarMonitor.Text = "Registar"
        Me.BttRegistarMonitor.UseVisualStyleBackColor = True
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(45, 37)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(18, 13)
        Me.LabelID.TabIndex = 2
        Me.LabelID.Text = "ID"
        '
        'LabelSerie
        '
        Me.LabelSerie.AutoSize = True
        Me.LabelSerie.Location = New System.Drawing.Point(45, 70)
        Me.LabelSerie.Name = "LabelSerie"
        Me.LabelSerie.Size = New System.Drawing.Size(31, 13)
        Me.LabelSerie.TabIndex = 3
        Me.LabelSerie.Text = "Serie"
        '
        'TexBIdmonitor
        '
        Me.TexBIdmonitor.Location = New System.Drawing.Point(99, 30)
        Me.TexBIdmonitor.Name = "TexBIdmonitor"
        Me.TexBIdmonitor.Size = New System.Drawing.Size(100, 20)
        Me.TexBIdmonitor.TabIndex = 4
        '
        'TexBSerieMonitor
        '
        Me.TexBSerieMonitor.Location = New System.Drawing.Point(99, 70)
        Me.TexBSerieMonitor.Name = "TexBSerieMonitor"
        Me.TexBSerieMonitor.Size = New System.Drawing.Size(100, 20)
        Me.TexBSerieMonitor.TabIndex = 5
        '
        'TexBNombreMonitor
        '
        Me.TexBNombreMonitor.Location = New System.Drawing.Point(99, 116)
        Me.TexBNombreMonitor.Name = "TexBNombreMonitor"
        Me.TexBNombreMonitor.Size = New System.Drawing.Size(100, 20)
        Me.TexBNombreMonitor.TabIndex = 6
        '
        'LabelNombreEq
        '
        Me.LabelNombreEq.AutoSize = True
        Me.LabelNombreEq.Location = New System.Drawing.Point(45, 116)
        Me.LabelNombreEq.Name = "LabelNombreEq"
        Me.LabelNombreEq.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreEq.TabIndex = 7
        Me.LabelNombreEq.Text = "Nombre"
        '
        'CrearMonitorDising
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LabelNombreEq)
        Me.Controls.Add(Me.TexBNombreMonitor)
        Me.Controls.Add(Me.TexBSerieMonitor)
        Me.Controls.Add(Me.TexBIdmonitor)
        Me.Controls.Add(Me.LabelSerie)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.BttRegistarMonitor)
        Me.Controls.Add(Me.BttRegresarMonitor)
        Me.Name = "CrearMonitorDising"
        Me.Text = "CrearMonitorDising"
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
End Class
