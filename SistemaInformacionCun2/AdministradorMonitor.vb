Imports Microsoft.VisualBasic.FileIO

Public Class AdministradorMonitor : Inherits AdministradorDB
    Public Sub New()
        MyBase.New("BDmonitor.cvs")
    End Sub
    Public Function CrearMonitor(serie As String, marca As String)

        Dim idmonitor = ObtenerUltimoId() + 1S
        Dim cadena = idmonitor & ";" & serie & ";" & marca & vbCrLf
        ''Escribe la linea de texto en el archivo
        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\" & nombreArchivo, cadena, True)
        Return idmonitor
    End Function

End Class