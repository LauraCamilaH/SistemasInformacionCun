﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarPersonas
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TaListado = New System.Windows.Forms.TextBox()
        Me.BtRegresarListarPersonas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Listar datos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TaListado
        '
        Me.TaListado.Location = New System.Drawing.Point(12, 12)
        Me.TaListado.Multiline = True
        Me.TaListado.Name = "TaListado"
        Me.TaListado.Size = New System.Drawing.Size(260, 208)
        Me.TaListado.TabIndex = 1
        '
        'BtRegresarListarPersonas
        '
        Me.BtRegresarListarPersonas.Location = New System.Drawing.Point(197, 226)
        Me.BtRegresarListarPersonas.Name = "BtRegresarListarPersonas"
        Me.BtRegresarListarPersonas.Size = New System.Drawing.Size(75, 23)
        Me.BtRegresarListarPersonas.TabIndex = 2
        Me.BtRegresarListarPersonas.Text = "Regresar"
        Me.BtRegresarListarPersonas.UseVisualStyleBackColor = True
        '
        'ListarPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtRegresarListarPersonas)
        Me.Controls.Add(Me.TaListado)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ListarPersonas"
        Me.Text = "ListarPersonas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TaListado As TextBox
    Friend WithEvents BtRegresarListarPersonas As Button
End Class
