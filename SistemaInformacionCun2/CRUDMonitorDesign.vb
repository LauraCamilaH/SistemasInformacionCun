Public Class CRUDMonitorDesign
    Private AdminMonitor As AdministradorMonitor = New AdministradorMonitor '
    'constructor inicializa un objetollama a la clase que administra el monitor y la instancia
    Private Columnas As String() = {"Identificador", "Serial", "Marca", "Fecha creación", "valor producto", "caracteristicas"} 'nombramos las columnas 

    Private Sub CRUDMonitorDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridMonitor.Columns.Clear()

        For Each columna In Columnas
            Dim columnaTabla = New DataGridViewColumn()
            columnaTabla.HeaderText = columna ' obtiene o establece el texto del título en la celda del encabezado de la columna
            columnaTabla.Name = columna 'Pone o estable el nombre de las columnas 
            columnaTabla.SortMode = DataGridViewColumnSortMode.Automatic '' super importante me encanto es el ordenar automatico funciona paracedio a a filtar en excel
            columnaTabla.CellTemplate = New DataGridViewTextBoxCell
            DataGridMonitor.Columns.Add(columnaTabla) ' agrega las columnas de la coleccion 

        Next
        Call RecargarM()
    End Sub
    Private Sub RecargarM()
        Dim BD As String()() = AdminMonitor.CargarDBMemoria
        LimpiarCampos()
        DataGridMonitor.Rows.Clear() ''Eliminamos todas las filas del DataGrid

        For Each FilaBD In BD '' Itera sobre los registros en base de datos
            Dim FilaTabla = New DataGridViewRow ''Se crea una fila para el datagrid
            For Each CeldaBD In FilaBD ''Se itera sobre cada una de las celdas de la fila
                Dim Celda = New DataGridViewTextBoxCell '' Se crea una celda para el datagrid
                Celda.Value = CeldaBD ''Se asigna el valor del la celda del datagrid
                FilaTabla.Cells.Add(Celda) ''Agregamos la celda del datagrid a la fila del datagrid
            Next
            DataGridMonitor.Rows.Add(FilaTabla) ''Se agrega la fila al datagrid
        Next
    End Sub
    Private Sub LimpiarCampos()
        LimpiarCamposTexto()
        BtnEliminar.Enabled = False
    End Sub
    Private Sub Actualizar()
        Dim Fila = CamposDeTextoArreglo()
        If AdminMonitor.Actualizar(Fila) Then
            MsgBox("Se actualizó el registro")
            RecargarM()
        Else
            MsgBox("No se actualizó ningún registro")
        End If
    End Sub

    Private Sub Crear()
        Dim NuevoId = AdminMonitor.Crear(CamposDeTextoArreglo())
        If NuevoId > 0 Then
            MsgBox("Se ha creado la impresora")
            RecargarM()
            LimpiarCampos()
        ElseIf NuevoId = -1 Then
            MsgBox("Ya existe un elemento con el serial")
            'ElseIf NuevoId = -2 Then
            ''Es un error del programador!!!
        End If
    End Sub
    Private Function CamposDeTextoArreglo() As String()
        Dim fecha = TextBoxAnioMonitor.Text & "-" & TextBoxMesMonitor.Text & "-" & TextBoxDiaMonitor.Text
        Dim Id = TextBoxIdMonitor.Text

        ''Esta función es llamada al crear o actualizar, por tal motivo debemos
        ''agregar o no el campo id, ya que si es llamada desde actualizar es 
        ''porque hay un ID ya cargado en el campo de texto y debe agregarse,
        ''si no lo hay, entonces es llamado desde el crear y no se debe agregar
        ''este primer elemento
        If Not String.IsNullOrEmpty(Id) Then 'si no es nulo o vacio, registro antiguo tiene id
            Dim Fila() As String = New String(5) {Id, TextBoxSerialMonitor.Text, TextBoxMarcaMonitor.Text, fecha, TextBoxValorM.Text, TextBoxCara.Text}
            Return Fila

        End If

        Return {TextBoxSerialMonitor.Text, TextBoxMarcaMonitor.Text, fecha, TextBoxValorM.Text, TextBoxCara.Text}
    End Function

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        RecargarM()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Id = TextBoxIdMonitor.Text
        If Not String.IsNullOrEmpty(Id) Then
            If AdminMonitor.Eliminar(Id) Then
                MsgBox("El elemento con id " & Id & " ha sido eliminado")
                RecargarM()
            Else
                MsgBox("No se pudo eliminar ningún elemento")
            End If
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If Not Validar() Then
            Return
        End If

        Dim id = TextBoxIdMonitor.Text
        If String.IsNullOrEmpty(id) Then ''Si el id está en blanco es que el elemento es nuevo
            Crear()
        Else
            Actualizar()
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LimpiarCampos()
        TextBoxSerialMonitor.Focus()
    End Sub



    Private Sub LimpiarCamposTexto()
        TextBoxAnioMonitor.Text = ""
        TextBoxDiaMonitor.Text = ""
        TextBoxIdMonitor.Text = ""
        TextBoxMarcaMonitor.Text = ""
        TextBoxSerialMonitor.Text = ""
        TextBoxMesMonitor.Text = ""
        TextBoxValorM.Text = ""
        TextBoxCara.Text = ""

    End Sub

    Private Sub CargarCamposTexto(filaSeleccionada As DataGridViewRow)
        TextBoxIdMonitor.Text = filaSeleccionada.Cells(0).Value
        TextBoxSerialMonitor.Text = filaSeleccionada.Cells(1).Value
        TextBoxMarcaMonitor.Text = filaSeleccionada.Cells(2).Value

        Dim fecha As String = filaSeleccionada.Cells(3).Value
        If Not String.IsNullOrEmpty(fecha) Then
            Dim partes = fecha.Split("/")
            TextBoxDiaMonitor.Text = partes(0)
            TextBoxMesMonitor.Text = partes(1)
            TextBoxAnioMonitor.Text = partes(2).Substring(0, 4)
        End If
        TextBoxValorM.Text = filaSeleccionada.Cells(4).Value
        TextBoxCara.Text = filaSeleccionada.Cells(5).Value
    End Sub
    Private Sub DataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridMonitor.SelectionChanged
        If Not DataGridMonitor.SelectedRows.Count = 1 Then
            LimpiarCampos()
            Return
        End If
        Dim filaSeleccionada = DataGridMonitor.Rows(DataGridMonitor.SelectedRows(0).Index)
        CargarCamposTexto(filaSeleccionada)
        BtnEliminar.Enabled = True
    End Sub
    Function validar() As Boolean
        Dim marca = TextBoxMarcaMonitor.Text
        Dim serie = TextBoxSerialMonitor.Text
        If (String.IsNullOrEmpty(TextBoxMarcaMonitor.Text)) Then
            MsgBox("Debe ingresar el nombre de la marca")
            Return False
        End If
        If (String.IsNullOrEmpty(TextBoxSerialMonitor.Text)) Then
            MsgBox("Debe ingresar el nombre de la serie")
            Return False
        End If

        If (Not serie.Length = 6) Then
            MsgBox("La longitud de la serie  debe ser de 6 caracteres")
            Return False
        End If

        If (Not ValidarEntero(TextBoxValorM.Text, 0, 100000000, "El precio")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxAnioMonitor.Text, 2000, 2500, "El año")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxMesMonitor.Text, 1, 12, "El mes")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxDiaMonitor.Text, 1, 31, "El día")) Then
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

End Class