Public Class CRUDMonitorDesign
    Private AdminMonitor As AdministradorMonitor = New AdministradorMonitor ' constructor inicializa un objetollama a la clase que administra el monitor y la instancia
    Private Columnas As String() = {"Identificador", "Serial", "Marca", "Fecha creación", "valor producto"} 'nombramos las columnas 

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
        LimpiarCampos() '?
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
        RecargarM()
    End Function
    Protected Overridable Function ValidarCampos() As String

        ''Si el campo está vácio o está lleno de espacios
        If String.IsNullOrWhiteSpace(TextBoxSerialMonitor.Text) Then
            Return "Por favor ingrese un valor para el serial"
        End If
        If String.IsNullOrWhiteSpace(TextBoxMarcaMonitor.Text) Then
            Return "Por favor ingrese la marca"
        End If
        If String.IsNullOrWhiteSpace(TextBoxValorM.Text) Then
            Return "Por favor ingrese el valor"
        End If
        Return "" ''No hay errores, retornamos una cadena vacia
    End Function
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        RecargarM()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'EliminarElemento(Matriz()(), TextBoxIdMonitor.Text)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim validacion = ValidarCampos()
        If Not String.IsNullOrEmpty(validacion) Then
            MsgBox(validacion)
            Return
        End If

        Dim id = TextBoxIdMonitor.Text
        If String.IsNullOrEmpty(id) Then ''Si el id está en blanco es que el elemento es nuevo
            ' Crear()
        Else
            'Actualizar()
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

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

    End Sub

    Private Sub BtnAscendente_Click(sender As Object, e As EventArgs) Handles BtnAscendente.Click

    End Sub
End Class