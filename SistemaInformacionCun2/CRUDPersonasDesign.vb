Public Class CRUDPersonasDesign

    Dim AdmiPersonas As AdministradorPersonas = New AdministradorPersonas
    Private Columnas As String() = {"Identificador", "Cedula", "1er Nombre", "2do Nombre", "Apellido", "ciudad", "id.monitor", "id.cpu", "id.impresora", "cargo", "sueldo", "Fecha Ingreso"} 'nombramos las columnas 
    Private Sub CRUDPersonasDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridPersonas.Columns.Clear()

        For Each Columna In Columnas
            'personas
            Dim columnaTabla = New DataGridViewColumn()
            columnaTabla.HeaderText = Columna ' obtiene o establece el texto del título en la celda del encabezado de la columna
            columnaTabla.Name = Columna 'Pone o estable el nombre de las columnas 
            columnaTabla.SortMode = DataGridViewColumnSortMode.Automatic '' super importante me encanto es el ordenar automatico funciona paracedio a a filtar en excel

            columnaTabla.CellTemplate = New DataGridViewTextBoxCell

            DataGridPersonas.Columns.Add(columnaTabla) ' agrega las columnas de la coleccion 
        Next
        Recargar()
    End Sub
    Private Sub LimpiarCampos()
        LimpiarCamposTexto()
        BtnEliminar.Enabled = False
    End Sub

    Private Sub Recargar()
        Dim BD As String()() = AdmiPersonas.CargarDBMemoria
        LimpiarCampos() '?
        DataGridPersonas.Rows.Clear() ''Eliminamos todas las filas del DataGrid

        For Each FilaBD In BD '' Itera sobre los registros en base de datos
            Dim FilaTabla = New DataGridViewRow ''Se crea una fila para el datagrid
            For Each CeldaBD In FilaBD ''Se itera sobre cada una de las celdas de la fila
                Dim Celda = New DataGridViewTextBoxCell '' Se crea una celda para el datagrid
                Celda.Value = CeldaBD ''Se asigna el valor del la celda del datagrid
                FilaTabla.Cells.Add(Celda) ''Agregamos la celda del datagrid a la fila del datagrid
            Next
            DataGridPersonas.Rows.Add(FilaTabla) ''Se agrega la fila al datagrid
        Next
    End Sub
    Private Sub LimpiarCamposTexto()
        TextBoxApellidoPersonas.Text = ""
        TextBoxCargoPersonas.Text = ""
        TextBoxSdoNombrePersonas.Text = ""
        TextBoxCedulaPersonas.Text = ""
        TextBoxPrimerNombrePersonas.Text = ""
        TextBoxCiudadPersonas.Text = ""
        TextBoxSueldoPersonas.Text = ""
        TextBoxIDPersonas.Text = ""
        TextBoxAño.Text = ""
        TextBoxdia.Text = ""
        TextBoxMes.Text = ""

    End Sub


    Function validar() As Boolean

        If (String.IsNullOrEmpty(TextBoxPrimerNombrePersonas.Text)) Then
            MsgBox("Debe ingresar el primer nombre")
            Return False
        End If
        If (String.IsNullOrEmpty(TextBoxSdoNombrePersonas.Text)) Then
            MsgBox("Debe ingresar el segundo nombre")
            Return False
        End If
        If (String.IsNullOrEmpty(TextBoxApellidoPersonas.Text)) Then
            MsgBox("Debe ingresar el apellido")
            Return False
        End If
        If (String.IsNullOrEmpty(TextBoxCiudadPersonas.Text)) Then
            MsgBox("Debe ingresar la ciudad ")
            Return False
        End If
        If (String.IsNullOrEmpty(TextBoxCargoPersonas.Text)) Then
            MsgBox("Debe ingresar el cargo")
            Return False
        End If
        If (Not ValidarEntero(TextBoxCedulaPersonas.Text, 0, 100000000, "La cedula")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxAño.Text, 2000, 2500, "El año")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxMes.Text, 1, 12, "El mes")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxdia.Text, 1, 31, "El día")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxSueldoPersonas.Text, 1, 80000000, "El sueldo")) Then
            Return False
        End If
        Return True
    End Function

    Private Function ValidarEntero(valor As String, min As Integer, max As Integer, nombreVariable As String) As Boolean
        Try ''ejecutarlo que esta despues del try y si falla salta a ejecutar lo que esta en el cacth

            Dim val = CInt(valor)

            If (val < min) Then
                MsgBox(nombreVariable & " debe ser mayor a  " & min)
                Return False
            End If

            If (val > max) Then
                MsgBox(nombreVariable & " debe ser menor o igual a " & max)
                Return False
            End If

            Return True
        Catch ex As InvalidCastException
            MsgBox(nombreVariable & " no es un número valido")
            Return False
        End Try
    End Function

    Private Sub DataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridPersonas.SelectionChanged
        If Not DataGridPersonas.SelectedRows.Count = 1 Then
            LimpiarCampos()
            Return
        End If
        Dim filaSeleccionada = DataGridPersonas.Rows(DataGridPersonas.SelectedRows(0).Index)
        CargarCamposTexto(filaSeleccionada)
        BtnEliminar.Enabled = True
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If Not validar() Then

            Return
        End If

        Dim id = TextBoxIDPersonas.Text
        If String.IsNullOrEmpty(id) Then ''Si el id está en blanco es que el elemento es nuevo
            Crear()
        Else
            Actualizar()
        End If
    End Sub
    Private Sub Actualizar()
        Dim Fila = CamposDeTextoArreglo()
        If AdmiPersonas.Actualizar(Fila) Then
            MsgBox("Se actualizó el registro")
            Recargar()
        Else
            MsgBox("No se actualizó ningún registro")
        End If
    End Sub

    Private Sub Crear()
        Dim NuevoId = AdmiPersonas.Crear(CamposDeTextoArreglo())
        If NuevoId > 0 Then
            MsgBox("Se ha creado la impresora con Id: " & NuevoId)
            Recargar()
            LimpiarCampos()
        ElseIf NuevoId = -1 Then
            MsgBox("Ya existe un elemento con el serial")
        ElseIf NuevoId = -2 Then
            MsgBox("Error interno, comuniquese con el administrador") ''Es un error del programador!!!
        End If
    End Sub
    ''
    Private Function CamposDeTextoArreglo() As String()
        Dim fecha = TextBoxdia.Text & "/" & TextBoxMes.Text & "/" & TextBoxAño.Text


        Dim Id = TextBoxIDPersonas.Text
        Dim Codmonitor = "0"
        Dim CodImpresora = "0"
        Dim CodCpu = "0"

        ''Esta función es llamada al crear o actualizar, por tal motivo debemos
        ''agregar o no el campo id, ya que si es llamada desde actualizar es 
        ''porque hay un ID ya cargado en el campo de texto y debe agregarse,
        ''si no lo hay, entonces es llamado desde el crear y no se debe agregar
        ''este primer elemento
        If Not String.IsNullOrEmpty(Id) Then 'si no es nulo o vacio, registro antiguo tiene id
            Dim Fila() As String = New String(11) {Id, TextBoxCedulaPersonas.Text, TextBoxPrimerNombrePersonas.Text, TextBoxSdoNombrePersonas.Text, TextBoxApellidoPersonas.Text, TextBoxCiudadPersonas.Text, Codmonitor, CodCpu, CodImpresora, TextBoxCargoPersonas.Text, TextBoxSueldoPersonas.Text, fecha}
            Return Fila

        End If

        Return {Id, TextBoxCedulaPersonas.Text, TextBoxPrimerNombrePersonas.Text,
            TextBoxSdoNombrePersonas.Text, TextBoxApellidoPersonas.Text, TextBoxCiudadPersonas.Text,
            Codmonitor, CodCpu, CodImpresora, TextBoxCargoPersonas.Text, TextBoxSueldoPersonas.Text, fecha}
    End Function

    Private Sub CargarCamposTexto(filaSeleccionada As DataGridViewRow)
        TextBoxIDPersonas.Text = filaSeleccionada.Cells(0).Value
        TextBoxCedulaPersonas.Text = filaSeleccionada.Cells(1).Value
        TextBoxPrimerNombrePersonas.Text = filaSeleccionada.Cells(2).Value
        TextBoxSdoNombrePersonas.Text = filaSeleccionada.Cells(3).Value
        TextBoxApellidoPersonas.Text = filaSeleccionada.Cells(4).Value
        TextBoxCiudadPersonas.Text = filaSeleccionada.Cells(5).Value
        TextBoxCargoPersonas.Text = filaSeleccionada.Cells(9).Value
        TextBoxSueldoPersonas.Text = filaSeleccionada.Cells(10).Value

        Dim fecha As String = filaSeleccionada.Cells(11).Value
        If Not String.IsNullOrEmpty(fecha) Then
            Dim partes = fecha.Split("/")
            TextBoxdia.Text = partes(0)
            TextBoxMes.Text = partes(1)
            TextBoxAño.Text = partes(2).Substring(0, 4) '' trae una partee del la cadena

        End If
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LimpiarCampos()
        TextBoxCedulaPersonas.Focus()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Recargar()
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Id = TextBoxIDPersonas.Text
        If Not String.IsNullOrEmpty(Id) Then
            If AdmiPersonas.Eliminar(Id) Then
                MsgBox("El elemento con id " & Id & " ha sido eliminado")
                Recargar()
            Else
                MsgBox("No se pudo eliminar ningún elemento")
            End If
        End If
    End Sub

    Private Sub BtnAscendente_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BtnDesendente_Click(sender As Object, e As EventArgs) 

    End Sub


End Class
