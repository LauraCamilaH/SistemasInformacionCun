﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LB_usuario = New System.Windows.Forms.Label()
        Me.LB_clave = New System.Windows.Forms.Label()
        Me.Tbusuario = New System.Windows.Forms.TextBox()
        Me.Tbcontrasena = New System.Windows.Forms.TextBox()
        Me.BIngresar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MeArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItSalirArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeGestionar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmCrearCPU = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmListarCPU = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeMonitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmCrearMonitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmListarMonitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.MePersonas = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EjercicioClaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarPersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(666, 232)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LB_usuario
        '
        Me.LB_usuario.AutoSize = True
        Me.LB_usuario.Location = New System.Drawing.Point(202, 306)
        Me.LB_usuario.Name = "LB_usuario"
        Me.LB_usuario.Size = New System.Drawing.Size(81, 13)
        Me.LB_usuario.TabIndex = 1
        Me.LB_usuario.Text = "Ingrese Usuario"
        '
        'LB_clave
        '
        Me.LB_clave.AutoSize = True
        Me.LB_clave.Location = New System.Drawing.Point(202, 344)
        Me.LB_clave.Name = "LB_clave"
        Me.LB_clave.Size = New System.Drawing.Size(71, 13)
        Me.LB_clave.TabIndex = 2
        Me.LB_clave.Text = "Ingrese clave"
        '
        'Tbusuario
        '
        Me.Tbusuario.Location = New System.Drawing.Point(297, 306)
        Me.Tbusuario.Name = "Tbusuario"
        Me.Tbusuario.Size = New System.Drawing.Size(100, 20)
        Me.Tbusuario.TabIndex = 3
        '
        'Tbcontrasena
        '
        Me.Tbcontrasena.Location = New System.Drawing.Point(297, 344)
        Me.Tbcontrasena.Name = "Tbcontrasena"
        Me.Tbcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tbcontrasena.Size = New System.Drawing.Size(100, 20)
        Me.Tbcontrasena.TabIndex = 4
        '
        'BIngresar
        '
        Me.BIngresar.Location = New System.Drawing.Point(205, 391)
        Me.BIngresar.Name = "BIngresar"
        Me.BIngresar.Size = New System.Drawing.Size(75, 23)
        Me.BIngresar.TabIndex = 5
        Me.BIngresar.Text = "Ingresar"
        Me.BIngresar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MeArchivo, Me.MeGestionar, Me.MeMonitor, Me.MePersonas, Me.EjercicioClaseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(713, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MeArchivo
        '
        Me.MeArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItSalirArchivo})
        Me.MeArchivo.Name = "MeArchivo"
        Me.MeArchivo.Size = New System.Drawing.Size(60, 20)
        Me.MeArchivo.Text = "Archivo"
        '
        'ItSalirArchivo
        '
        Me.ItSalirArchivo.Name = "ItSalirArchivo"
        Me.ItSalirArchivo.Size = New System.Drawing.Size(96, 22)
        Me.ItSalirArchivo.Text = "Salir"
        '
        'MeGestionar
        '
        Me.MeGestionar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmCrearCPU, Me.ItmListarCPU})
        Me.MeGestionar.Name = "MeGestionar"
        Me.MeGestionar.Size = New System.Drawing.Size(95, 20)
        Me.MeGestionar.Text = "Gestionar CPU"
        '
        'ItmCrearCPU
        '
        Me.ItmCrearCPU.Name = "ItmCrearCPU"
        Me.ItmCrearCPU.Size = New System.Drawing.Size(102, 22)
        Me.ItmCrearCPU.Text = "Crear"
        '
        'ItmListarCPU
        '
        Me.ItmListarCPU.Name = "ItmListarCPU"
        Me.ItmListarCPU.Size = New System.Drawing.Size(102, 22)
        Me.ItmListarCPU.Text = "Listar"
        '
        'MeMonitor
        '
        Me.MeMonitor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmCrearMonitor, Me.ItmListarMonitor})
        Me.MeMonitor.Name = "MeMonitor"
        Me.MeMonitor.Size = New System.Drawing.Size(76, 20)
        Me.MeMonitor.Text = "Monitores "
        '
        'ItmCrearMonitor
        '
        Me.ItmCrearMonitor.Name = "ItmCrearMonitor"
        Me.ItmCrearMonitor.Size = New System.Drawing.Size(102, 22)
        Me.ItmCrearMonitor.Text = "Crear"
        '
        'ItmListarMonitor
        '
        Me.ItmListarMonitor.Name = "ItmListarMonitor"
        Me.ItmListarMonitor.Size = New System.Drawing.Size(102, 22)
        Me.ItmListarMonitor.Text = "Listar"
        '
        'MePersonas
        '
        Me.MePersonas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearToolStripMenuItem2, Me.ListarToolStripMenuItem2})
        Me.MePersonas.Name = "MePersonas"
        Me.MePersonas.Size = New System.Drawing.Size(69, 20)
        Me.MePersonas.Text = "Personas "
        '
        'CrearToolStripMenuItem2
        '
        Me.CrearToolStripMenuItem2.Name = "CrearToolStripMenuItem2"
        Me.CrearToolStripMenuItem2.Size = New System.Drawing.Size(102, 22)
        Me.CrearToolStripMenuItem2.Text = "Crear"
        '
        'ListarToolStripMenuItem2
        '
        Me.ListarToolStripMenuItem2.Name = "ListarToolStripMenuItem2"
        Me.ListarToolStripMenuItem2.Size = New System.Drawing.Size(102, 22)
        Me.ListarToolStripMenuItem2.Text = "Listar"
        '
        'EjercicioClaseToolStripMenuItem
        '
        Me.EjercicioClaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPersonaToolStripMenuItem, Me.MostrarPersonasToolStripMenuItem})
        Me.EjercicioClaseToolStripMenuItem.Name = "EjercicioClaseToolStripMenuItem"
        Me.EjercicioClaseToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.EjercicioClaseToolStripMenuItem.Text = "EjercicioClase"
        '
        'AgregarPersonaToolStripMenuItem
        '
        Me.AgregarPersonaToolStripMenuItem.Name = "AgregarPersonaToolStripMenuItem"
        Me.AgregarPersonaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AgregarPersonaToolStripMenuItem.Text = "Agregar Persona"
        '
        'MostrarPersonasToolStripMenuItem
        '
        Me.MostrarPersonasToolStripMenuItem.Name = "MostrarPersonasToolStripMenuItem"
        Me.MostrarPersonasToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MostrarPersonasToolStripMenuItem.Text = "Mostrar Personas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 489)
        Me.Controls.Add(Me.BIngresar)
        Me.Controls.Add(Me.Tbcontrasena)
        Me.Controls.Add(Me.Tbusuario)
        Me.Controls.Add(Me.LB_clave)
        Me.Controls.Add(Me.LB_usuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Sistema informacion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LB_usuario As Label
    Friend WithEvents LB_clave As Label
    Friend WithEvents Tbusuario As TextBox
    Friend WithEvents Tbcontrasena As TextBox
    Friend WithEvents BIngresar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MeArchivo As ToolStripMenuItem
    Friend WithEvents ItSalirArchivo As ToolStripMenuItem
    Friend WithEvents MeGestionar As ToolStripMenuItem
    Friend WithEvents ItmCrearCPU As ToolStripMenuItem
    Friend WithEvents ItmListarCPU As ToolStripMenuItem
    Friend WithEvents MeMonitor As ToolStripMenuItem
    Friend WithEvents ItmCrearMonitor As ToolStripMenuItem
    Friend WithEvents ItmListarMonitor As ToolStripMenuItem
    Friend WithEvents MePersonas As ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EjercicioClaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarPersonasToolStripMenuItem As ToolStripMenuItem
End Class
