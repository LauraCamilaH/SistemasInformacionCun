Public Class CRUDCpuDesign
    Private AdmiCpu As AdministrardorCpu = New AdministrardorCpu
    Private Columnas As String() = {"Identificador", "Serial", "Marca", "Fecha creación", "valor producto"}


    Private Sub CRUPCpuDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewcpu.Columns.Clear()

        For Each Columna In Columnas
            Dim columnaTabla = New DataGridViewColumn()
            columnaTabla.HeaderText = Columna ' obtiene o establece el texto del título en la celda del encabezado de la columna
            columnaTabla.Name = Columna 'Pone o estable el nombre de las columnas 
            columnaTabla.SortMode = DataGridViewColumnSortMode.Automatic '' super importante me encanto es el ordenar automatico funciona paracedio a a filtar en excel
            columnaTabla.CellTemplate = New DataGridViewTextBoxCell ' Indica que cada celda de la columna será un campo de texto
            DataGridViewcpu.Columns.Add(columnaTabla) ' agrega las columnas de la coleccion 
        Next
        Recargar()
    End Sub
    Private Sub Recargar()
        Dim BD As String()() = AdmiCpu.CargarDBMemoria
        LimpiarCampos()
        DataGridViewcpu.Rows.Clear() ''Eliminamos todas las filas del DataGrid

        For Each FilaBD In BD '' Itera sobre los registros en base de datos
            Dim FilaTabla = New DataGridViewRow ''Se crea una fila para el datagrid
            For Each CeldaBD In FilaBD ''Se itera sobre cada una de las celdas de la fila
                Dim Celda = New DataGridViewTextBoxCell '' Se crea una celda para el datagrid
                Celda.Value = CeldaBD ''Se asigna el valor del la celda del datagrid
                FilaTabla.Cells.Add(Celda) ''Agregamos la celda del datagrid a la fila del datagrid
            Next
            DataGridViewcpu.Rows.Add(FilaTabla) ''Se agrega la fila al datagrid
        Next
    End Sub


    Private Sub LimpiarCampos()
        LimpiarCamposTexto()
        BtnEliminar.Enabled = False
    End Sub
    Private Sub LimpiarCamposTexto()
        TextBoxAnioCpu.Text = ""
        TextBoxDiaCpu.Text = ""
        TextBoxIDcpu.Text = ""
        TextBoxMarcaCpu.Text = ""
        TextBoxValorC.Text = ""
        TextBoxSerieCPU.Text = ""

    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LimpiarCampos()
        TextBoxIDcpu.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Not Validar() Then
            Return

        End If

        Dim id = TextBoxIDcpu.Text
        If String.IsNullOrEmpty(id) Then ''Si el id está en blanco es que el elemento es nuevo
            CrearC()
        Else
            Actualizar()
        End If
    End Sub
    Private Sub Actualizar()
        Dim Fila = CamposDeTextoArreglo()
        If AdmiCpu.Actualizar(Fila) Then
            MsgBox("Se actualizó el registro")
            Recargar()
        Else
            MsgBox("No se actualizó ningún registro")
        End If
    End Sub

    Private Sub CrearC()
        Dim NuevoId = AdmiCpu.Crear(CamposDeTextoArreglo())
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
    Private Function CamposDeTextoArreglo() As String()
        Dim fecha = TextBoxDiaCpu.Text & "/" & TextBoxMesCpu.Text & "/" & TextBoxAnioCpu.Text


        Dim Id = TextBoxIDcpu.Text

        ''Esta función es llamada al crear o actualizar, por tal motivo debemos
        ''agregar o no el campo id, ya que si es llamada desde actualizar es 
        ''porque hay un ID ya cargado en el campo de texto y debe agregarse,
        ''si no lo hay, entonces es llamado desde el crear y no se debe agregar
        ''este primer elemento
        If Not String.IsNullOrEmpty(Id) Then 'si no es nulo o vacio, registro antiguo tiene id
            Dim Fila() As String = New String(4) {Id, TextBoxSerieCPU.Text, TextBoxMarcaCpu.Text, fecha, TextBoxValorC.Text}
            Return Fila

        End If

        Return {TextBoxSerieCPU.Text, TextBoxMarcaCpu.Text, fecha, TextBoxValorC.Text}
    End Function
    Function validar() As Boolean
        Dim marca = TextBoxMarcaCpu.Text
        Dim serie = TextBoxSerieCPU.Text
        If (String.IsNullOrEmpty(TextBoxMarcaCpu.Text)) Then
            MsgBox("Debe ingresar el nombre de la marca")
            Return False
        End If
        If (String.IsNullOrEmpty(TextBoxSerieCPU.Text)) Then
            MsgBox("Debe ingresar el nombre de la serie")
            Return False
        End If

        If (Not serie.Length = 6) Then
            MsgBox("La longitud de la serie  debe ser de 6 caracteres")
            Return False
        End If

        Dim precio = TextBoxValorC.Text
        If (Not ValidarEntero(TextBoxValorC.Text, 0, 100000000, "El precio")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxAnioCpu.Text, 2000, 2500, "El año")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxMesCpu.Text, 1, 12, "El mes")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxDiaCpu.Text, 1, 31, "El día")) Then
            Return False
        End If
        Return True
    End Function
    Private Function ValidarEntero(valor As String, min As Integer, max As Integer, nombreVariable As String) As Boolean
        Try ''ejecutarlo que esta despues del try y si falla salta a ejecutar lo que esta en el cacth

            Dim val = CInt(valor)

            If (val < min) Then
                MsgBox(nombreVariable & " debe ser mayor  a " & min)
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
    Private Sub CargarCamposTexto(filaSeleccionada As DataGridViewRow)
        TextBoxIDcpu.Text = filaSeleccionada.Cells(0).Value
        TextBoxSerieCPU.Text = filaSeleccionada.Cells(1).Value
        TextBoxMarcaCpu.Text = filaSeleccionada.Cells(2).Value

        Dim fecha As String = filaSeleccionada.Cells(3).Value
        If Not String.IsNullOrEmpty(fecha) Then
            Dim partes = fecha.Split("/")
            TextBoxDiaCpu.Text = partes(0)
            TextBoxMesCpu.Text = partes(1)
            TextBoxAnioCpu.Text = partes(2)
        End If

        TextBoxValorC.Text = filaSeleccionada.Cells(4).Value

    End Sub
    '' <summary>
    ''' Código ejecutado cuando se cambia la selección en la tabla, actualiza los campos
    ''' de texto en la parte superior.
    '''
    Private Sub DataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewcpu.SelectionChanged
        If Not DataGridViewcpu.SelectedRows.Count = 1 Then
            LimpiarCampos()
            Return
        End If
        Dim filaSeleccionada = DataGridViewcpu.Rows(DataGridViewcpu.SelectedRows(0).Index)
        CargarCamposTexto(filaSeleccionada)
        BtnEliminar.Enabled = True
    End Sub


    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Recargar()
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Id = TextBoxIDcpu.Text
        If Not String.IsNullOrEmpty(Id) Then
            If AdmiCpu.Eliminar(Id) Then
                MsgBox("El elemento con id " & Id & " ha sido eliminado")
                Recargar()
            Else
                MsgBox("No se pudo eliminar ningún elemento")
            End If
        End If
    End Sub

    Private Sub BtnAscendente_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BtnDescendente_Click(sender As Object, e As EventArgs) 

    End Sub


End Class