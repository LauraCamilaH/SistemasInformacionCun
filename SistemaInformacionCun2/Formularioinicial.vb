Public Class Formularioinicial
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MenuStrip1.Visible = False

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LB_usuario.Click

    End Sub

    Private Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
        pantallaInicio()

    End Sub
    Public Sub pantallaInicio()
        If Tbusuario.Text = "cun" And Tbcontrasena.Text = "123" Then

            LB_usuario.Visible = False
            LB_clave.Visible = False
            Tbusuario.Visible = False
            Tbcontrasena.Visible = False
            BIngresar.Visible = False
            MenuStrip1.Visible = True

        ElseIf Tbcontrasena.Text <> "123" Then
            MsgBox("la contraseña no corresponde! Intente de nuevo")
            Tbusuario.Text = ""
            Tbcontrasena.Text = ""
        End If

    End Sub

    Private Sub AgregarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPersonaToolStripMenuItem.Click
        Dim Form = New DesignEjercicioClase
        Form.Show()
    End Sub

    Private Sub ItmCrearMonitor_Click(sender As Object, e As EventArgs) Handles ItmCrearMonitor.Click
        Dim CrearMonitorDising = New CrearMonitorDesign
        CrearMonitorDising.Show()

    End Sub

    Private Sub ItmCrearCPU_Click(sender As Object, e As EventArgs) Handles ItmCrearCPU.Click
        Dim CrearCpuDising = New CrearCPUDesing
        CrearCPUDesing.Show()

    End Sub

    Private Sub ItSalirArchivo_Click(sender As Object, e As EventArgs) Handles ItSalirArchivo.Click

        LB_usuario.Visible = True
        LB_clave.Visible = True
        Tbusuario.Visible = True
        Tbcontrasena.Visible = True
        BIngresar.Visible = True
        Tbusuario.Text = ""
        Tbcontrasena.Text = ""



    End Sub
    Private Sub AsignacionEquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionEquiposToolStripMenuItem.Click
        Dim Asignacion = New AsignacionDesign
        AsignacionDesign.Show()

    End Sub

    Private Sub CrearImpresorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearImpresorasToolStripMenuItem.Click
        Dim CrearImpresoras = New CrearImpresorasDesign
        CrearImpresorasDesign.Show()

    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        Dim Consultar = New ConsultarDesign
        ConsultarDesign.Show()

    End Sub

    Private Sub CRUDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CRUDToolStripMenuItem.Click
        Dim Crud = New CRUDImpresora
        Crud.Show()
    End Sub

    Private Sub AdministradorDePersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministradorDePersonalToolStripMenuItem.Click
        Dim Crud = New CRUDPersonasDesign
        Crud.Show()
    End Sub

    Private Sub AdministradorCPUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministradorCPUToolStripMenuItem.Click
        Dim Crud = New CRUDCpuDesign
        Crud.Show()

    End Sub

    Private Sub AdministradorMonitoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministradorMonitoresToolStripMenuItem.Click
        Dim Crud = New CRUDMonitorDesign
        Crud.Show()
    End Sub
End Class
