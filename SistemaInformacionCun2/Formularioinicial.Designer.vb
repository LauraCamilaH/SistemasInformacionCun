<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formularioinicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formularioinicial))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LB_usuario = New System.Windows.Forms.Label()
        Me.LB_clave = New System.Windows.Forms.Label()
        Me.Tbusuario = New System.Windows.Forms.TextBox()
        Me.Tbcontrasena = New System.Windows.Forms.TextBox()
        Me.BIngresar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EjercicioClaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeGestionar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmCrearCPU = New System.Windows.Forms.ToolStripMenuItem()
        Me.IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearImpresorasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeMonitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmCrearMonitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionEquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItSalirArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.CRUDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(159, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(288, 178)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LB_usuario
        '
        Me.LB_usuario.AutoSize = True
        Me.LB_usuario.Location = New System.Drawing.Point(156, 315)
        Me.LB_usuario.Name = "LB_usuario"
        Me.LB_usuario.Size = New System.Drawing.Size(81, 13)
        Me.LB_usuario.TabIndex = 1
        Me.LB_usuario.Text = "Ingrese Usuario"
        '
        'LB_clave
        '
        Me.LB_clave.AutoSize = True
        Me.LB_clave.Location = New System.Drawing.Point(156, 347)
        Me.LB_clave.Name = "LB_clave"
        Me.LB_clave.Size = New System.Drawing.Size(71, 13)
        Me.LB_clave.TabIndex = 2
        Me.LB_clave.Text = "Ingrese clave"
        '
        'Tbusuario
        '
        Me.Tbusuario.Location = New System.Drawing.Point(285, 315)
        Me.Tbusuario.Name = "Tbusuario"
        Me.Tbusuario.Size = New System.Drawing.Size(153, 20)
        Me.Tbusuario.TabIndex = 3
        '
        'Tbcontrasena
        '
        Me.Tbcontrasena.Location = New System.Drawing.Point(285, 347)
        Me.Tbcontrasena.Name = "Tbcontrasena"
        Me.Tbcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tbcontrasena.Size = New System.Drawing.Size(153, 20)
        Me.Tbcontrasena.TabIndex = 4
        '
        'BIngresar
        '
        Me.BIngresar.Location = New System.Drawing.Point(285, 387)
        Me.BIngresar.Name = "BIngresar"
        Me.BIngresar.Size = New System.Drawing.Size(153, 23)
        Me.BIngresar.TabIndex = 5
        Me.BIngresar.Text = "Ingresar"
        Me.BIngresar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EjercicioClaseToolStripMenuItem, Me.MeGestionar, Me.IToolStripMenuItem, Me.MeMonitor, Me.AsignacionToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.MeArchivo})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(595, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EjercicioClaseToolStripMenuItem
        '
        Me.EjercicioClaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPersonaToolStripMenuItem})
        Me.EjercicioClaseToolStripMenuItem.Name = "EjercicioClaseToolStripMenuItem"
        Me.EjercicioClaseToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.EjercicioClaseToolStripMenuItem.Text = "Personas "
        '
        'AgregarPersonaToolStripMenuItem
        '
        Me.AgregarPersonaToolStripMenuItem.Name = "AgregarPersonaToolStripMenuItem"
        Me.AgregarPersonaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AgregarPersonaToolStripMenuItem.Text = "Agregar Persona"
        '
        'MeGestionar
        '
        Me.MeGestionar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmCrearCPU})
        Me.MeGestionar.Name = "MeGestionar"
        Me.MeGestionar.Size = New System.Drawing.Size(95, 20)
        Me.MeGestionar.Text = "Gestionar CPU"
        '
        'ItmCrearCPU
        '
        Me.ItmCrearCPU.Name = "ItmCrearCPU"
        Me.ItmCrearCPU.Size = New System.Drawing.Size(128, 22)
        Me.ItmCrearCPU.Text = "Crear CPU"
        '
        'IToolStripMenuItem
        '
        Me.IToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearImpresorasToolStripMenuItem, Me.CRUDToolStripMenuItem})
        Me.IToolStripMenuItem.Name = "IToolStripMenuItem"
        Me.IToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.IToolStripMenuItem.Text = "Impresoras"
        '
        'CrearImpresorasToolStripMenuItem
        '
        Me.CrearImpresorasToolStripMenuItem.Name = "CrearImpresorasToolStripMenuItem"
        Me.CrearImpresorasToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CrearImpresorasToolStripMenuItem.Text = "Crear Impresoras"
        '
        'MeMonitor
        '
        Me.MeMonitor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmCrearMonitor})
        Me.MeMonitor.Name = "MeMonitor"
        Me.MeMonitor.Size = New System.Drawing.Size(76, 20)
        Me.MeMonitor.Text = "Monitores "
        '
        'ItmCrearMonitor
        '
        Me.ItmCrearMonitor.Name = "ItmCrearMonitor"
        Me.ItmCrearMonitor.Size = New System.Drawing.Size(159, 22)
        Me.ItmCrearMonitor.Text = "Crear Monitores"
        '
        'AsignacionToolStripMenuItem
        '
        Me.AsignacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignacionEquiposToolStripMenuItem})
        Me.AsignacionToolStripMenuItem.Name = "AsignacionToolStripMenuItem"
        Me.AsignacionToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.AsignacionToolStripMenuItem.Text = "Asignacion "
        '
        'AsignacionEquiposToolStripMenuItem
        '
        Me.AsignacionEquiposToolStripMenuItem.Name = "AsignacionEquiposToolStripMenuItem"
        Me.AsignacionEquiposToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AsignacionEquiposToolStripMenuItem.Text = "Asignacion equipos"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem})
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar "
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
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
        'CRUDToolStripMenuItem
        '
        Me.CRUDToolStripMenuItem.Name = "CRUDToolStripMenuItem"
        Me.CRUDToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CRUDToolStripMenuItem.Text = "CRUD"
        '
        'Formularioinicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 496)
        Me.Controls.Add(Me.BIngresar)
        Me.Controls.Add(Me.Tbcontrasena)
        Me.Controls.Add(Me.Tbusuario)
        Me.Controls.Add(Me.LB_clave)
        Me.Controls.Add(Me.LB_usuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Formularioinicial"
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
    Friend WithEvents MeMonitor As ToolStripMenuItem
    Friend WithEvents ItmCrearMonitor As ToolStripMenuItem
    Friend WithEvents EjercicioClaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearImpresorasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignacionEquiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CRUDToolStripMenuItem As ToolStripMenuItem
End Class
