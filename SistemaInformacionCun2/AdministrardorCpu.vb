Imports Microsoft.VisualBasic.FileIO

Public Class AdministrardorCpu : Inherits AdministradorDB
    Public Sub New()
        MyBase.New("BDcpu.txt", 4) ' nombre y campos

    End Sub
    Public Function CrearCpu(serie As String, marca As String, dia As String, mes As String, anio As String, valor As String)

        Dim idcpu = ObtenerUltimoId() + 1
        Dim fecha = dia & "/" & mes & "/" & anio
        Dim cadena = idcpu & ";" & serie & ";" & marca & ";" & fecha & ";" & valor & vbCrLf
        ''Escribe la linea de texto en el archivo
        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\" & nombreArchivo, cadena, True)
        Return idcpu
    End Function

End Class
