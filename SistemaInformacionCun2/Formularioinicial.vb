Public Class Formularioinicial
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


End Class
