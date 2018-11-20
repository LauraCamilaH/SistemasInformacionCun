Imports Microsoft.VisualBasic.FileIO

Public Class AdministradorImpresora : Inherits AdministradorDB 'hereda
    Public Sub New() 'constructor
        MyBase.New("BDimpresora.cvs", 4)
    End Sub
    Public Function CrearImpresora(serie As String, marca As String, dia As Integer, mes As Integer, anio As Integer, valor As String) As Integer
        Dim idimpresora = ObtenerUltimoId() + 1
        Dim fecha = dia & "/" & mes & "/" & anio
        Dim cadena = idimpresora & ";" & serie & ";" & marca & ";" & fecha & ";" & valor & vbCrLf
        ''Escribe la linea de texto en el archivo
        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\" & nombreArchivo, cadena, True)
        Return idimpresora
    End Function

End Class
