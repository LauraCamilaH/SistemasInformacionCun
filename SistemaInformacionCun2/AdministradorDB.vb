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
        Dim conexion = AbrirConexion()
        Dim statement = New MySqlCommand
        statement.Connection = conexion
        ''UPDATE persona SET primer_nombre=@campo1, seg_nombre=@campo2 WHERE id=@id
        Dim sql = "UPDATE " & nombreTabla & " SET "

        For indice = 0 To nombreColumnas.Length - 1
            sql += nombreColumnas(indice) & " = @campo" & indice & ", "
        Next

        sql = sql.Remove(sql.Length - 2, 1) ''Me quita la ultima coma
        sql += "WHERE id = @id"

        statement.CommandText = sql
        statement.Prepare()

        For indice = 1 To Fila.Length - 1
            statement.Parameters.AddWithValue("@campo" & (indice - 1), Fila(indice))
        Next

        statement.Parameters.AddWithValue("@id", Fila(0))

        Dim filasActualizadas = statement.ExecuteNonQuery()

        Return If(filasActualizadas = 0, False, True) ''La actualización fue satisfactoria

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
