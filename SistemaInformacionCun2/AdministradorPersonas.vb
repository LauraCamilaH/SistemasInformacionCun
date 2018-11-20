Imports Microsoft.VisualBasic.FileIO

Public Class AdministradorPersonas : Inherits AdministradorDB

    Private AdminHistorico As AdministradorHistorico = New AdministradorHistorico

    Public Sub New()
        MyBase.New("Persona", {"ID", "CEDULA", "PRIMER_NOMBRE", "SEG_NOMBRE", "APELLIDO", "CIUDAD", "ID_MONITOR", "ID_CPU", "ID_IMPRESORA", "CARGO", "SUELDO", "FECHA_INGRESO"})
    End Sub

    Public Function CrearPersona(cedula As String, Primernombre As String, SegundoNombre As String, apellido As String, ciudad As String, cargo As String, sueldo As String, dia As String, mes As String, anio As String) As Integer
        Dim idpersonas = 2
        Dim idmonitor = "0"
        Dim idcpu = "0"
        Dim idimpresora = "0"
        Dim fecha = dia & "/" & mes & "/" & anio
        Dim Cadena = idpersonas & ";" & cedula & ";" & Primernombre & ";" & SegundoNombre & ";" & apellido & ";" & ciudad & ";" & idmonitor & ";" & idcpu & ";" & idimpresora & ";" & cargo & ";" & sueldo & ";" & fecha & vbCrLf

        'Escribe la linea de texto en el archivo

        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\" & nombreTabla, Cadena, True)

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

    Public Function AsignarElemento(idPersona As Integer, idElemento As Integer, tipoElemento As String) As Integer

        Dim idPersonaAsignada = ObtenerPersonaAsignacion(idElemento, tipoElemento) ''Retorna 0 si no está asignado

        If (idPersonaAsignada > 0) Then
            Return 1 ''Ya está asignado
        End If

        Dim idElementoAsignado = ObtenerElemento(idPersona, tipoElemento) ''Retorna 0 si no tiene elemento asignado
        If (idElementoAsignado > 0) Then
            QuitarElemento(idPersona, tipoElemento, idElementoAsignado)
        End If

        Asignar(idPersona, tipoElemento, idElemento)

        Return 0
    End Function
    ''' <summary>
    ''' Obtiene el identificador de la persona que tiene asignado el elemento del tipo indicado
    ''' con el id dado.
    ''' </summary>
    ''' <param name="idElemento">El identificador del elemento a buscar</param>
    ''' <param name="tipoElemento">El nombre del tipo de elemento</param>
    ''' <returns>Retorna el id de la persona que tiene asignado el elemento o cero si ninguna
    ''' persona tiene el elemento asignado</returns>
    Private Function ObtenerPersonaAsignacion(idElemento As Integer, tipoElemento As String) As Integer

        Return 0
    End Function
    ''' <summary>
    ''' Busca el identificador de elemento del tipo indicado asignado a la persona dada.
    ''' 
    ''' Por ejemplo: Si buscamos el identificador del monitor actualmente asignado a la persona con id 4
    ''' entonces llamamos este método con los siguientes parámetros:
    ''' idPersona -> 4 , tipoElemento -> "monitor"
    ''' </summary>
    ''' <param name="idPersona">el identificador de la persona en la base de datos</param>
    ''' <param name="tipoElemento">el nombre del tipo de elemento Pej: monitor, cpu, impresora</param>
    ''' <returns>El identificador en base de datos del elemento actualmente asignado a la persona o 0
    ''' si la persona no tiene actualmente un elemento del tipo dado</returns>
    Private Function ObtenerElemento(idPersona As Integer, tipoElemento As String) As Integer
        Return 0
    End Function
    ''' <summary>
    ''' Inserta un registro en la tabla de asignaciones quitando el elemento a la persona indicada
    ''' </summary>
    ''' <param name="idPersona"></param>
    ''' <param name="tipoElemento">Nombre del elemento</param>
    ''' <param name="idElemento"></param>
    Private Sub QuitarElemento(idPersona As Integer, tipoElemento As String, idElemento As Integer)

    End Sub
    ''' <summary>
    ''' Crea un registro en la tabla de asignaciones asignando el elemento a la persona dada.
    ''' </summary>
    ''' <param name="idPersona"></param>
    ''' <param name="tipoElemento">Nombre del elemento. Pej: monitor, cpu, impresora</param>
    ''' <param name="idElemento"></param>
    Private Sub Asignar(idPersona As Integer, tipoElemento As String, idElemento As Integer)

    End Sub
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
        ''ActualizarArchivo(Datosmemoria)
        Return 0
    End Function


End Class
