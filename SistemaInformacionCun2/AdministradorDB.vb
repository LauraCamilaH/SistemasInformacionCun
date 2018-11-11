Imports Microsoft.VisualBasic.FileIO

Public Class AdministradorDB

    Public nombreArchivo As String
    ''' <summary>
    ''' Es la cantidad de campos que debe contener cualquier 
    ''' elemento (sin contar el campo ID) que se debe ingresar, esto se valida al momento
    ''' de crear una nueva fila
    ''' </summary>
    Private CantidadCampos As Integer

    Public Sub New(nombre As String, campos As Integer)
        nombreArchivo = nombre
        CantidadCampos = campos
    End Sub
    ''' <summary>
    ''' obtiene el ultimo id ingresado en la base de datos
    ''' </summary>
    ''' <returns></returns>
    Public Function ObtenerUltimoId() As Integer
        Dim Basedatos As String()() = CargarDBMemoria() 'cargael archivo en una variable que se llama base de datos 
        If Basedatos.Length = 0 Then
            Return 0
        End If
        Dim UltimaFila = Basedatos(Basedatos.Length - 1) ' para saber el indice a lo longitud de un arreglo cualquiera le resto-1  para saber el indice 
        Return UltimaFila(0) ' retorna el valor del indice que esta e cero en este caso es el Id 
    End Function
    ''' <summary>
    ''' Obtiene todo lo que esta en la base de datos y formatea en cadena de texto
    ''' </summary>
    ''' <returns></returns>
    Public Function ConsultarComoString() As String
        Dim ConsultarBD = CargarDBMemoria()
        Dim Cadena As String = ""

        For Each Fila In ConsultarBD
            Cadena = Cadena & vbNewLine

            For Each Celda In Fila
                Cadena = Cadena & " " & Celda
            Next Celda
        Next Fila

        Return Cadena

    End Function
    ''' <summary>
    ''' formatea la matriz en formato cvs y la guarda en el archivo separado por punto y coma
    ''' </summary>
    ''' <param name="BaseDatos"></param>

    Public Sub ActualizarArchivo(BaseDatos As String()())

        Dim Cadena As String = ""

        For Each Fila In BaseDatos
            For Each Celda In Fila
                Cadena = Cadena & Celda & ";"
            Next Celda
            Cadena = Cadena.Remove(Cadena.Length - 1, 1) ''Remover el punto y coma sobrante de cada linea
            Cadena = Cadena & vbNewLine
        Next Fila


        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\" & nombreArchivo, Cadena, False) ''sobreescribe el archivo

    End Sub


    Public Function Eliminar(Id As String) As Boolean
        Dim BaseDatos = CargarDBMemoria()

        Dim IndiceEliminar As Integer = -1 'Indicador para saber si entra al primer if 
        Dim IndiceActual As Integer = 0

        For Each FilaDB In BaseDatos
            If FilaDB(0) = Id Then
                IndiceEliminar = IndiceActual
                Exit For
            End If
            IndiceActual += 1
        Next

        If IndiceEliminar = -1 Then
            Return False
        End If
        BaseDatos = EliminarElemento(BaseDatos, IndiceEliminar)
        ActualizarArchivo(BaseDatos)
        Return True
    End Function


    Public Function Actualizar(Fila As String()) As Boolean
        Dim Id = Fila(0) ''El id de la fila viene en el indice cero
        Dim BaseDatos = CargarDBMemoria()

        Dim IndiceAEditar = -1
        Dim IndiceActual = 0

        For Each FilaBD In BaseDatos ''Recorremos cada fila de la bd
            If FilaBD(0) = Id Then ''Si el indice es igual al id
                IndiceAEditar = IndiceActual ''Hemos encontrado el indice a editar
                Exit For ''Forzamos el fin de la iteración
            End If
            IndiceActual += 1
        Next

        If IndiceAEditar = -1 Then ''No se encontró el registro con el id dado
            Return False
        End If

        BaseDatos(IndiceAEditar) = Fila
        ActualizarArchivo(BaseDatos)
        Return True ''La actualización fue satisfactoria

    End Function


    Public Function Crear(Arreglo As String()) As Integer
        Dim DB = CargarDBMemoria()

        If Not Arreglo.Count = CantidadCampos Then
            Return -2 ''La cantidad de campos no es valida
        End If

        Dim ValorUnico = Arreglo(0) ''Como no se incluye el id, el valor único está en el índice cero

        For Each FilaDB In DB
            If ValorUnico = FilaDB(1) Then
                Return -1 ''Ya existe un elemento con el valor unico
            End If
        Next

        Dim SiguienteId = ObtenerUltimoId() + 1
        Arreglo = InsertarElemento(Arreglo, 0, SiguienteId)

        DB = InsertarElemntoMatriz(DB, (DB.Length - 1), Arreglo)
        ActualizarArchivo(DB)
        Return SiguienteId
    End Function

    Public Function InsertarElemento(Arreglo As String(), indice As Integer, insertar As String) As String()

        Dim retornar As String() = New String(Arreglo.Length) {}
        Dim contador As Integer = 0
        For Each valor In Arreglo
            If contador < indice Then
                retornar(contador) = valor
            Else
                retornar(contador + 1) = valor
            End If
            contador += 1
        Next
        retornar(indice) = insertar
        Return retornar
    End Function
    Public Function InsertarElemntoMatriz(matriz As String()(), indice As Integer, insertar As String()) As String()()
        ''[a,b,c],[g,h,i],     1, [d,e,f]  -> [a,b,c],[d,e,f],[g,h,i]
        Dim retornar As String()() = New String(matriz.Length)() {}
        Dim contador As Integer = 0
        For Each valor In matriz
            If contador < indice Then
                retornar(contador) = valor
            Else
                retornar(contador + 1) = valor
            End If
            contador += 1
        Next
        retornar(indice) = insertar
        Return retornar
    End Function

    ''' <summary>
    ''' carga en archivo en una arreglo de dos dimensiones y lo retorna 
    ''' </summary>
    ''' <returns></returns>
    Public Function CargarDBMemoria() As String()()

        Dim currentRow As String()
        Dim BdMemoria As String()() = {}
        Dim indiceFilaActual As Integer

        Dim rutaArchivo = SpecialDirectories.MyDocuments & "\" & nombreArchivo

        If Not FileSystem.FileExists(rutaArchivo) Then ''No Existe este archivo?
            Return BdMemoria ''Retorna la matriz (vacía)
        End If

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(rutaArchivo)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            indiceFilaActual = 0
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        Dim filaActual() As String = currentField.Split(";")
                        ReDim Preserve BdMemoria(indiceFilaActual)
                        BdMemoria(indiceFilaActual) = filaActual
                        indiceFilaActual += 1
                    Next
                Catch ex As Microsoft.VisualBasic.
                        FileIO.MalformedLineException
                    MsgBox("no existe archivo de lectura")

                End Try
            End While

        End Using
        Return BdMemoria
    End Function

    Public Function EliminarElemento(Matriz As String()(), fila As Integer) As String()()
        Dim arreglo As String()() = New String(Matriz.Length - 2)() {}
        Dim contador As Integer = 0

        For Each filas In Matriz
            If Not contador = fila Then
                If contador < fila Then
                    arreglo(contador) = filas
                Else
                    arreglo(contador - 1) = filas
                End If
            End If
            contador += 1
        Next

        Return arreglo

    End Function



End Class
