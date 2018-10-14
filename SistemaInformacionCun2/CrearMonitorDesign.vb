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

        id = TexBIdmonitor.Text
        serie = TexBSerieMonitor.Text
        marca = TexBMarcaMonitor.Text
        cadena = id & ";" & serie & ";" & marca & vbCrLf
        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\Bdmonitores.txt", cadena, True)
        MsgBox("los datos fueron registrados")
        TexBIdmonitor.Text = ""
        TexBSerieMonitor.Text = ""
        TexBMarcaMonitor.Text = ""
    End Sub
End Class