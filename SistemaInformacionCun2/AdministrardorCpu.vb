﻿Imports Microsoft.VisualBasic.FileIO

Public Class AdministrardorCpu : Inherits AdministradorDB
    Public Sub New()
        MyBase.New("BDcpu.cvs", 3)
    End Sub
    Public Function CrearCpu(serie As String, marca As String)

        Dim idcpu = ObtenerUltimoId() + 1
        Dim cadena = idcpu & ";" & serie & ";" & marca & vbCrLf
        ''Escribe la linea de texto en el archivo
        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\" & nombreArchivo, cadena, True)
        Return idcpu
    End Function

End Class
