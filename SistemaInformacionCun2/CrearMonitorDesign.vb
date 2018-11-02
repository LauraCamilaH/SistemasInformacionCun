Imports Microsoft.VisualBasic.FileIO

Public Class CrearMonitorDesign

    Dim id As String
    Dim serie As String
    Dim marca As String
    Dim cadena As String

    Private Sub BttRegresarMonitor_Click(sender As Object, e As EventArgs) Handles BttRegresarMonitor.Click
        Me.Close()
        Formularioinicial.Show()
    End Sub

    Private Sub BttRegistarMonitor_Click(sender As Object, e As EventArgs) Handles BttRegistarMonitor.Click
        Dim administrador = New AdministradorMonitor

        Dim idmonitor = administrador.CrearMonitor(TexBSerieMonitor.Text, TexBMarcaMonitor.Text)
        MsgBox("los datos fueron registrados con id: " & idmonitor)

        TexBSerieMonitor.Text = ""
        TexBMarcaMonitor.Text = ""
    End Sub

    Private Sub CrearMonitorDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class