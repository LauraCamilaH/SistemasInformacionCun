﻿Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LB_usuario.Click

    End Sub

    Private Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
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

    Private Sub MePersonas_Click(sender As Object, e As EventArgs) Handles MePersonas.Click

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AgregarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPersonaToolStripMenuItem.Click
        Dim Form = New DesignEjercicioClase
        Form.Show()
    End Sub

    Private Sub MostrarPersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarPersonasToolStripMenuItem.Click
        Dim ListarPersonas = New ListarPersonas
        ListarPersonas.Show()
    End Sub

    Private Sub CrearToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CrearToolStripMenuItem2.Click
        Dim CrearPersonasDising = New CrearPersonasDising
        CrearPersonasDising.Show()


    End Sub

    Private Sub ItmCrearMonitor_Click(sender As Object, e As EventArgs) Handles ItmCrearMonitor.Click
        Dim CrearMonitorDising = New CrearMonitorDising
        CrearMonitorDising.Show()

    End Sub

    Private Sub ItmListarMonitor_Click(sender As Object, e As EventArgs) Handles ItmListarMonitor.Click
        Dim ListarMonitorDising = New ListarMonitorDising
        ListarMonitorDising.Show()


    End Sub

    Private Sub ItmListarCPU_Click(sender As Object, e As EventArgs) Handles ItmListarCPU.Click
        Dim ListarCpuDising = New ListarCpuDising
        ListarCpuDising.Show()


    End Sub

    Private Sub ItmCrearCPU_Click(sender As Object, e As EventArgs) Handles ItmCrearCPU.Click
        Dim CrearCpuDising = New CrearMonitorDising
        CrearMonitorDising.Show()

    End Sub

    Private Sub ItSalirArchivo_Click(sender As Object, e As EventArgs) Handles ItSalirArchivo.Click
        Dim ArchivoSalirDising = New ArchivoSalirDising
        ArchivoSalirDising.Show()
    End Sub
End Class
