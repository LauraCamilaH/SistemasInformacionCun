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

        Dim Conoceridmonitor = administrador.CrearMonitor(TexBSerieMonitor.Text, TexBMarcaMonitor.Text, CInt(TextBoxDíaMonitor.Text), CInt(TextBoMesMonitor.Text), CInt(TextBoxanioMonitor.Text), TextBoxValorMonitor.Text)
        MsgBox("los datos fueron registrados con id: " & Conoceridmonitor)

        TexBSerieMonitor.Text = ""
        TexBMarcaMonitor.Text = ""
        TextBoMesMonitor.Text = ""
        TextBoxanioMonitor.Text = ""
        TextBoxValorMonitor.Text = ""
        TextBoxDíaMonitor.Text = ""
    End Sub

End Class