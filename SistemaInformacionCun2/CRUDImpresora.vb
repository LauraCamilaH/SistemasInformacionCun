Public Class CRUDImpresora

    Private AdminImpresoras As AdministradorImpresora = New AdministradorImpresora 'llama a la clase administrador de impresora y la instancia
    Private Columnas As String() = {"Identificador", "Serial", "Marca", "Fecha creación", "valor producto"}

    Private Sub CRUDImpresora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridImpresoras.Columns.Clear()
        For Each Columna In Columnas 'ingresa a un ciclo Por cada Columna en el arreglo de string que tenemos 
            Dim ColumnaTabla = New DataGridViewColumn()
            ColumnaTabla.HeaderText = Columna ' obtiene o establece el texto del título en la celda del encabezado de la columna
            ColumnaTabla.Name = Columna 'Pone o estable el nombre de las columnas 
            ColumnaTabla.SortMode = DataGridViewColumnSortMode.Automatic '' super importante me encanto es el ordenar automatico funciona paracedio a a filtar en excel
            ColumnaTabla.CellTemplate = New DataGridViewTextBoxCell
            DataGridImpresoras.Columns.Add(ColumnaTabla) ' agrega las columnas de la coleccion 
        Next
        Recargar()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Recargar()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Id = TxtIdentificador.Text
        If Not String.IsNullOrEmpty(Id) Then
            If AdminImpresoras.Eliminar(Id) Then
                MsgBox("El elemento con id " & Id & " ha sido eliminado")
                Recargar()
            Else
                MsgBox("No se pudo eliminar ningún elemento")
            End If
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LimpiarCampos()
        TxtSerialImpresora.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Not validar() Then
            Return

        End If

        Dim id = TxtIdentificador.Text
        If String.IsNullOrEmpty(id) Then ''Si el id está en blanco es que el elemento es nuevo
            CrearC()
        Else
            Actualizar()
        End If
    End Sub

    Private Sub Actualizar()
        Dim Fila = CamposDeTextoArreglo()
        If AdminImpresoras.Actualizar(Fila) Then
            MsgBox("Se actualizó el registro")
            Recargar()
        Else
            MsgBox("No se actualizó ningún registro")
        End If
    End Sub

    Private Sub CrearC()
        Dim NuevoId = AdminImpresoras.Crear(CamposDeTextoArreglo())
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
        Dim fecha = TextBoxdia.Text & "/" & TextBoxmes.Text & "/" & TextBoxAnio.Text


        Dim Id = TxtIdentificador.Text

        ''Esta función es llamada al crear o actualizar, por tal motivo debemos
        ''agregar o no el campo id, ya que si es llamada desde actualizar es 
        ''porque hay un ID ya cargado en el campo de texto y debe agregarse,
        ''si no lo hay, entonces es llamado desde el crear y no se debe agregar
        ''este primer elemento
        If Not String.IsNullOrEmpty(Id) Then 'si no es nulo o vacio, registro antiguo tiene id
            Dim Fila() As String = New String(4) {Id, TxtSerialImpresora.Text, TxtMarcaImpresora.Text, fecha, TextBoxValorI.Text}
            Return Fila

        End If

        Return {TxtSerialImpresora.Text, TxtMarcaImpresora.Text, fecha, TextBoxValorI.Text}
    End Function

    Private Function ValidarCampos() As String

        ''Si el campo está vácio o está lleno de espacios
        If String.IsNullOrWhiteSpace(TxtSerialImpresora.Text) Then
            Return "Por favor ingrese un valor para el serial"
        End If
        If String.IsNullOrWhiteSpace(TxtMarcaImpresora.Text) Then
            Return "Por favor ingrese la marca "
        End If
        If String.IsNullOrWhiteSpace(TextBoxAnio.Text) Then
            Return "Por favor ingrese el año"
        End If

        If String.IsNullOrWhiteSpace(TextBoxmes.Text) Then
            Return "Por favor ingrese el mes"
        End If
        If String.IsNullOrWhiteSpace(TextBoxdia.Text) Then
            Return "Por favor ingrese el día"
        End If
        If String.IsNullOrWhiteSpace(TextBoxValorI.Text) Then
            Return "Por favor ingrese el Valor"
        End If

        Return "" ''No hay errores, retornamos una cadena vacia
    End Function

    Private Sub CargarCamposTexto(filaSeleccionada As DataGridViewRow)
        TxtIdentificador.Text = filaSeleccionada.Cells(0).Value
        TxtSerialImpresora.Text = filaSeleccionada.Cells(1).Value
        TxtMarcaImpresora.Text = filaSeleccionada.Cells(2).Value
        TextBoxValorI.Text = filaSeleccionada.Cells(4).Value

        Dim fecha As String = filaSeleccionada.Cells(3).Value
        If Not String.IsNullOrEmpty(fecha) Then
            Dim partes = fecha.Split("/")
            TextBoxdia.Text = partes(0)
            TextBoxmes.Text = partes(1)
            TextBoxAnio.Text = partes(2)
        End If

    End Sub

    Private Sub LimpiarCamposTexto()
        TxtIdentificador.Text = ""
        TxtSerialImpresora.Text = ""
        TxtMarcaImpresora.Text = ""
        TextBoxAnio.Text = ""
        TextBoxdia.Text = ""
        TextBoxmes.Text = ""
        TextBoxValorI.Text = ""
    End Sub

    Private Sub LimpiarCampos()
        LimpiarCamposTexto()
        BtnEliminar.Enabled = False
    End Sub

    Private Sub Recargar()
        Dim BD As String()() = AdminImpresoras.CargarDBMemoria
        LimpiarCampos()
        DataGridImpresoras.Rows.Clear() ''Eliminamos todas las filas del DataGrid

        For Each FilaBD In BD '' Itera sobre los registros en base de datos
            Dim FilaTabla = New DataGridViewRow ''Se crea una fila para el datagrid
            For Each CeldaBD In FilaBD ''Se itera sobre cada una de las celdas de la fila
                Dim Celda = New DataGridViewTextBoxCell '' Se crea una celda para el datagrid
                Celda.Value = CeldaBD ''Se asigna el valor del la celda del datagrid
                FilaTabla.Cells.Add(Celda) ''Agregamos la celda del datagrid a la fila del datagrid
            Next
            DataGridImpresoras.Rows.Add(FilaTabla) ''Se agrega la fila al datagrid
        Next
    End Sub

    ''' <summary>
    ''' Código ejecutado cuando se cambia la selección en la tabla, actualiza los campos
    ''' de texto en la parte superior.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridImpresoras.SelectionChanged
        If Not DataGridImpresoras.SelectedRows.Count = 1 Then
            LimpiarCampos()
            Return
        End If
        Dim filaSeleccionada = DataGridImpresoras.Rows(DataGridImpresoras.SelectedRows(0).Index)
        CargarCamposTexto(filaSeleccionada)
        BtnEliminar.Enabled = True
    End Sub
    Function validar() As Boolean
        Dim marca = TxtMarcaImpresora.Text
        Dim serie = TxTSerial.Text
        If (String.IsNullOrEmpty(TxtMarcaImpresora.Text)) Then
            MsgBox("Debe ingresar el nombre de la marca")
            Return False
        End If
        If (String.IsNullOrEmpty(TxTSerial.Text)) Then
            MsgBox("Debe ingresar el nombre de la marca")
            Return False
        End If

        If (Not serie.Length = 6) Then
            MsgBox("La longitud de la serie  debe ser de 6 caracteres")
            Return False
        End If


        If (Not ValidarEntero(TextBoxValorI.Text, 0, 100000000, "El precio")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxAnio.Text, 2000, 2500, "El año")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxmes.Text, 1, 12, "El mes")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxdia.Text, 1, 31, "El día")) Then
            Return False
        End If
        Return True
    End Function

    Private Function ValidarEntero(valor As String, min As Integer, max As Integer, nombreVariable As String) As Boolean
        Try ''ejecutarlo que esta despues del try y si falla salta a ejecutar lo que esta en el cacth

            Dim val = CInt(valor)

            If (val < min) Then
                MsgBox(nombreVariable & " debe ser mayor o igual a " & min)
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

End Class