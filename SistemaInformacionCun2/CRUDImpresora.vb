Public Class CRUDImpresora


    Private AdminImpresoras As AdministradorImpresora = New AdministradorImpresora
    Private Columnas As String() = {"Identificador", "Serial", "Marca", "Fecha creación"}

    Private Sub CRUDImpresora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGrid.Columns.Clear()
        For Each Columna In Columnas
            Dim ColumnaTabla = New DataGridViewColumn()
            ColumnaTabla.HeaderText = Columna
            ColumnaTabla.Name = Columna
            ColumnaTabla.SortMode = DataGridViewColumnSortMode.Automatic '' super importante me encanto es el ordenar automatico funciona paracedio a a filtar en excel
            DataGrid.Columns.Add(ColumnaTabla)
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
        Dim validacion = ValidarCampos()
        If Not String.IsNullOrEmpty(validacion) Then
            MsgBox(validacion)
            Return
        End If

        Dim id = TxtIdentificador.Text
        If String.IsNullOrEmpty(id) Then ''Si el id está en blanco es que el elemento es nuevo
            Crear()
        Else
            Actualizar()
        End If
    End Sub

    Private Sub Actualizar()
        Dim Fila = CamposDeTextoALista()
        If AdminImpresoras.Actualizar(Fila) Then
            MsgBox("Se actualizó el registro")
            Recargar()
        Else
            MsgBox("No se actualizó ningún registro")
        End If
    End Sub

    Private Sub Crear()
        Dim NuevoId = AdminImpresoras.Crear(CamposDeTextoALista())
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

    Protected Overridable Function CamposDeTextoALista() As List(Of String)
        Dim lista = New List(Of String)
        Dim Id = TxtIdentificador.Text

        ''Esta función es llamada al crear o actualizar, por tal motivo debemos
        ''agregar o no el campo id, ya que si es llamada desde actualizar es 
        ''porque hay un ID ya cargado en el campo de texto y debe agregarse,
        ''si no lo hay, entonces es llamado desde el crear y no se debe agregar
        ''este primer elemento
        If Not String.IsNullOrEmpty(Id) Then
            lista.Add(Id)
        End If
        lista.Add(TxtSerialImpresora.Text)
        lista.Add(TxtMarcaImpresora.Text)
        lista.Add("01/01/2018")
        Return lista
    End Function

    Protected Overridable Function ValidarCampos() As String

        ''Si el campo está vácio o está lleno de espacios
        If String.IsNullOrWhiteSpace(TxtSerialImpresora.Text) Then
            Return "Por favor ingrese un valor para el serial"
        End If
        If String.IsNullOrWhiteSpace(TxtMarcaImpresora.Text) Then
            Return "Por favor ingrese la marca de la impresora"
        End If
        Return "" ''No hay errores, retornamos una cadena vacia
    End Function

    Protected Overridable Sub CargarCamposTexto(filaSeleccionada As DataGridViewRow)
        TxtIdentificador.Text = filaSeleccionada.Cells(0).Value
        TxtSerialImpresora.Text = filaSeleccionada.Cells(1).Value
        TxtMarcaImpresora.Text = filaSeleccionada.Cells(2).Value
    End Sub

    Protected Overridable Sub LimpiarCamposTexto()
        TxtIdentificador.Text = ""
        TxtSerialImpresora.Text = ""
        TxtMarcaImpresora.Text = ""
    End Sub

    Private Sub LimpiarCampos()
        LimpiarCamposTexto()
        BtnEliminar.Enabled = False
    End Sub

    Private Sub Recargar()
        Dim BD As List(Of List(Of String)) = AdminImpresoras.CargarBD()
        LimpiarCampos()
        DataGrid.Rows.Clear() ''Eliminamos todas las filas del DataGrid

        For Each FilaBD As List(Of String) In BD '' Itera sobre los registros en base de datos
            Dim FilaTabla = New DataGridViewRow ''Se crea una fila para el datagrid
            For Each CeldaBD In FilaBD ''Se itera sobre cada una de las celdas de la fila
                Dim Celda = New DataGridViewTextBoxCell '' Se crea una celda para el datagrid
                Celda.Value = CeldaBD ''Se asigna el valor del la celda del datagrid
                FilaTabla.Cells.Add(Celda) ''Agregamos la celda del datagrid a la fila del datagrid
            Next
            DataGrid.Rows.Add(FilaTabla) ''Se agrega la fila al datagrid
        Next
    End Sub

    ''' <summary>
    ''' Código ejecutado cuando se cambia la selección en la tabla, actualiza los campos
    ''' de texto en la parte superior.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles DataGrid.SelectionChanged
        If Not DataGrid.SelectedRows.Count = 1 Then
            LimpiarCampos()
            Return
        End If
        Dim filaSeleccionada = DataGrid.Rows(DataGrid.SelectedRows(0).Index)
        CargarCamposTexto(filaSeleccionada)
        BtnEliminar.Enabled = True
    End Sub
End Class