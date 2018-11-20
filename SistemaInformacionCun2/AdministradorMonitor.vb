Imports Microsoft.VisualBasic.FileIO

Public Class AdministradorMonitor : Inherits AdministradorDB
    Public Sub New()
        MyBase.New("BDmonitor.cvs", 4)
    End Sub
    Public Function CrearMonitor(serie As String, marca As String, dia As String, mes As String, anio As String, valor As String)

        Dim idmonitor = ObtenerUltimoId() + 1
        Dim fecha = dia & "/" & mes & "/" & anio
        Dim cadena = idmonitor & ";" & serie & ";" & marca & ";" & fecha & ";" & valor & vbCrLf
        ''Escribe la linea de texto en el archivo
        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\" & nombreArchivo, cadena, True)
        Return idmonitor
    End Function

End Class