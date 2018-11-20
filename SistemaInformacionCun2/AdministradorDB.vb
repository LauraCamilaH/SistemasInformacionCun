Imports Microsoft.VisualBasic.FileIO
Imports MySql.Data.MySqlClient

Public Class AdministradorDB

    Private nombreColumnas As String()
    Public nombreTabla As String
    ''' <summary>
    ''' Es la cantidad de campos que debe contener cualquier 
    ''' elemento (sin contar el campo ID) que se debe ingresar, esto se valida al momento
    ''' de crear una nueva fila
    ''' </summary>
    Private CantidadCampos As Integer

    Public Sub New(nombre As String, nombresColumnas As String())
        nombreTabla = nombre
        nombreColumnas = nombresColumnas
        CantidadCampos = nombreColumnas.Length
    End Sub

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


        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\" & nombreTabla, Cadena, False) ''sobreescribe el archivo

    End Sub


    Public Function Eliminar(Id As String) As Boolean
        Dim conexion = AbrirConexion()
        Dim statement = New MySqlCommand
        statement.Connection = conexion
        Dim sql = "delete from " & nombreTabla & " where id = @id"
        statement.CommandText = sql
        statement.Prepare()
        statement.Parameters.AddWithValue("@id", Id)
        Dim FilasEliminadas = statement.ExecuteNonQuery()
        conexion.Close()

        Return If(FilasEliminadas = 0, False, True)

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

        Dim conexion = AbrirConexion()
        Dim statement = New MySqlCommand
        statement.Connection = conexion

        Dim sql = "INSERT INTO " & nombreTabla & " ( "
        ''( campo1, campo2, campo3 )  VALUES ( @campo1, @campo2, @campo3)

        For Each nombreColumna In nombreColumnas
            sql += nombreColumna & ", "
        Next
        sql = sql.Remove(sql.Length - 2, 1) ''Remueve la ultima coma que sobra
        sql += ") VALUES ( "

        For indice = 1 To nombreColumnas.Length
            sql += "@campo" & indice & ", "
        Next
        sql = sql.Remove(sql.Length - 2, 1) ''Remueve la ultima coma que sobra
        sql += ")"

        statement.CommandText = sql
        statement.Prepare()

        For indice = 1 To nombreColumnas.Length
            statement.Parameters.AddWithValue("@campo" & indice, Arreglo(indice - 1))
        Next
        Try
            Dim filasAfectadas = statement.ExecuteNonQuery
            conexion.Close()
            Return 1
        Catch ex As MySqlException
            If ex.Number = 1062 Then ''Codigo de error para una clave duplicada
                Return -1
            End If
            Return -2
        End Try
    End Function

    Private Function AbrirConexion() As MySqlConnection
        Dim conexion = New MySqlConnection("Server=localhost;Database=inventario_cun;Uid=root;Pwd='';SslMode=None")
        conexion.Open()
        Return conexion
    End Function

    ''' <summary>
    ''' carga en archivo en una arreglo de dos dimensiones y lo retorna 
    ''' </summary>
    ''' <returns></returns>
    Public Function CargarDBMemoria() As String()()
        Dim conexion = AbrirConexion()
        Dim statement = New MySqlCommand
        statement.Connection = conexion
        statement.CommandText = "SELECT * FROM " & nombreTabla
        statement.Prepare()
        Dim BdMemoria As String()() = {}

        Dim reader = statement.ExecuteReader()
        Dim columnas = reader.FieldCount
        Dim indiceFila = 0

        While reader.Read()
            Dim fila = New String(columnas - 1) {}
            For indice = 0 To columnas - 1
                fila(indice) = reader.GetString(indice)
            Next
            ReDim Preserve BdMemoria(indiceFila)
            BdMemoria(indiceFila) = fila
            indiceFila += 1
        End While

        reader.Close()
        conexion.Close()

        Return BdMemoria
    End Function



End Class
