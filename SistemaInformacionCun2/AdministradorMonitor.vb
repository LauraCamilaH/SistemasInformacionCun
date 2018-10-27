Imports Microsoft.VisualBasic.FileIO

Public Class AdministradorMonitor : Inherits AdministradorDB
    Public Sub New()
        MyBase.New("BDmonitor.cvs", 3)
    End Sub
    Public Function CrearMonitor(serie As String, marca As String)

        Dim idmonitor = ObtenerUltimoId() + 1
        Dim cadena = idmonitor & ";" & serie & ";" & marca & vbCrLf
        ''Escribe la linea de texto en el archivo
        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\" & nombreArchivo, cadena, True)
        Return idmonitor
    End Function

End Class