Imports Microsoft.VisualBasic.FileIO

Public Class AdministradorDB

    Public nombreArchivo As String

    Public Sub New(nombre As String)
        nombreArchivo = nombre
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

End Class
