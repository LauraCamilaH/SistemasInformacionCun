Imports Microsoft.VisualBasic.FileIO

Public Class AdministradorPersonas : Inherits AdministradorDB

    Public Sub New()
        MyBase.New("BDPersonas.csv")
    End Sub

    Public Function CrearPersona(cedula As String, nombre As String, apellido As String, ciudad As String) As Integer
        Dim idpersonas = ObtenerUltimoId() + 1

        Dim idmonitor = "0"
        Dim idcpu = "0"
        Dim idimpresora = "0"

        Dim cadena = idpersonas & ";" & cedula & ";" & nombre & ";" & apellido & ";" & ciudad & ";" & idmonitor & ";" & idcpu & ";" & idimpresora & vbCrLf
        ''Escribe la linea de texto en el archivo
        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\" & nombreArchivo, cadena, True)
        Return idpersonas
    End Function

    Public Function BuscarDatosPersona(cedula As String) As String()
        Dim Datosmemoria = CargarDBMemoria()
        For Each Fila In Datosmemoria
            If cedula = Fila(1) Then
                Return Fila
            End If
        Next Fila
        Return {} ''arreglo vacio

    End Function
End Class
