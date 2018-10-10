<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarMonitorDising
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
        Me.TextBoxListarMonitor = New System.Windows.Forms.TextBox()
        Me.BtCargarListarMonitor = New System.Windows.Forms.Button()
        Me.BtRegresarListarMonitor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxListarMonitor
        '
        Me.TextBoxListarMonitor.Location = New System.Drawing.Point(80, 72)
        Me.TextBoxListarMonitor.Multiline = True
        Me.TextBoxListarMonitor.Name = "TextBoxListarMonitor"
        Me.TextBoxListarMonitor.Size = New System.Drawing.Size(178, 104)
        Me.TextBoxListarMonitor.TabIndex = 0
        '
        'BtCargarListarMonitor
        '
        Me.BtCargarListarMonitor.Location = New System.Drawing.Point(80, 203)
        Me.BtCargarListarMonitor.Name = "BtCargarListarMonitor"
        Me.BtCargarListarMonitor.Size = New System.Drawing.Size(75, 23)
        Me.BtCargarListarMonitor.TabIndex = 1
        Me.BtCargarListarMonitor.Text = "Cargar"
        Me.BtCargarListarMonitor.UseVisualStyleBackColor = True
        '
        'BtRegresarListarMonitor
        '
        Me.BtRegresarListarMonitor.Location = New System.Drawing.Point(183, 203)
        Me.BtRegresarListarMonitor.Name = "BtRegresarListarMonitor"
        Me.BtRegresarListarMonitor.Size = New System.Drawing.Size(75, 23)
        Me.BtRegresarListarMonitor.TabIndex = 2
        Me.BtRegresarListarMonitor.Text = "Regresar"
        Me.BtRegresarListarMonitor.UseVisualStyleBackColor = True
        '
        'ListarMonitorDising
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtRegresarListarMonitor)
        Me.Controls.Add(Me.BtCargarListarMonitor)
        Me.Controls.Add(Me.TextBoxListarMonitor)
        Me.Name = "ListarMonitorDising"
        Me.Text = "ListarMonitorDising"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxListarMonitor As TextBox
    Friend WithEvents BtCargarListarMonitor As Button
    Friend WithEvents BtRegresarListarMonitor As Button
End Class
