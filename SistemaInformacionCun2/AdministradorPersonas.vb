Imports Microsoft.VisualBasic.FileIO

Public Class AdministradorPersonas : Inherits AdministradorDB

    Private AdminHistorico As AdministradorHistorico = New AdministradorHistorico

    Public Sub New()
        MyBase.New("BDPersonas.txt", 12)
    End Sub

    Public Function CrearPersona(cedula As String, Primernombre As String, SegundoNombre As String, apellido As String, ciudad As String, cargo As String, sueldo As String, dia As String, mes As String, anio As String) As Integer
        Dim idpersonas = ObtenerUltimoId() + 1
        Dim idmonitor = "0"
        Dim idcpu = "0"
        Dim idimpresora = "0"
        Dim fecha = dia & "/" & mes & "/" & anio
        Dim Cadena = idpersonas & ";" & cedula & ";" & Primernombre & ";" & SegundoNombre & ";" & apellido & ";" & ciudad & ";" & idmonitor & ";" & idcpu & ";" & idimpresora & ";" & cargo & ";" & sueldo & ";" & fecha & vbCrLf
        
        'Escribe la linea de texto en el archivo

        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\" & nombreArchivo, Cadena, True)

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

    Public Function ActualizarCpu(cedula As String, idcpu As String) As Integer
        Dim resultado = ActualizarRegistroPorCedula(cedula, idcpu, 6)
        Dim fecha = DateTime.Now.ToString("dd/MM/yyyy")
        AdminHistorico.Crear({"asignar", "cpu", 1, idcpu, fecha})
        Return resultado
    End Function

    Public Function ActualizarMonitor(cedula As String, idmonitor As String) As Integer
        Dim resultado = ActualizarRegistroPorCedula(cedula, idmonitor, 5)
        Return resultado
    End Function

    Public Function ActualizarImpresora(cedula As String, idimpresora As String) As Integer
        Dim resultado = ActualizarRegistroPorCedula(cedula, idimpresora, 7) ' dim resultado captura el retorno de la funcion que tenemos 
        Return resultado

    End Function

    Public Function ActualizarRegistroPorCedula(cedula As String, valor As String, indice As Integer) As Integer

        Dim Datosmemoria = CargarDBMemoria()
        For Each Fila In Datosmemoria
            If Fila(indice) = valor Then
                Return 1 ' uno si el valor ya esta asigando en otro fila 
            End If
        Next

        For Each Fila In Datosmemoria
            If cedula = Fila(1) Then
                Fila(indice) = valor
            End If
        Next Fila
        ActualizarArchivo(Datosmemoria)
        Return 0
    End Function


End Class
