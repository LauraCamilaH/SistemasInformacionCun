Public Class CRUDPersonasDesign

    Dim AdmiPersonas As AdministradorPersonas = New AdministradorPersonas
    Private Columnas As String() = {"Identificador", "Cedula", "1er Nombre", "2do Nombre", "Apellido", "ciudad", "id.monitor", "id.cpu", "id.impresora", "cargo", "sueldo", "Fecha Ingreso"} 'nombramos las columnas 
    Private Sub CRUDPersonasDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridPersonas.Columns.Clear()

        For Each Columna In Columnas
            Dim columnaTabla = New DataGridViewColumn()
            columnaTabla.HeaderText = Columna ' obtiene o establece el texto del título en la celda del encabezado de la columna
            columnaTabla.Name = Columna 'Pone o estable el nombre de las columnas 
            columnaTabla.SortMode = DataGridViewColumnSortMode.Automatic '' super importante me encanto es el ordenar automatico funciona paracedio a a filtar en excel

            columnaTabla.CellTemplate = New DataGridViewTextBoxCell

            DataGridPersonas.Columns.Add(columnaTabla) ' agrega las columnas de la coleccion 
        Next
        recargar()
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
        Recargar()
    End Function

    Protected Overridable Function ValidarCampos() As String

        ''Si el campo está vácio o está lleno de espacios
        If String.IsNullOrWhiteSpace(TextBoxCedulaPersonas.Text) Then
            Return "Por favor ingrese un valor de la cedula"
        End If
        If String.IsNullOrWhiteSpace(TextBoxCargoPersonas.Text) Then
            Return "Por favor ingrese el cargo"
        End If
        If String.IsNullOrWhiteSpace(TextBoxApellidoPersonas.Text) Then
            Return "Por favor ingrese el apellido"
        End If
        Return "" ''No hay errores, retornamos una cadena vacia
    End Function


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim validacion = ValidarCampos()
        If Not String.IsNullOrEmpty(validacion) Then
            MsgBox(validacion)
            Return
        End If

        Dim id = TextBoxIDPersonas.Text
        If String.IsNullOrEmpty(id) Then ''Si el id está en blanco es que el elemento es nuevo
            ' Crear()
        Else
            'Actualizar()
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LimpiarCampos()
        TextBoxCedulaPersonas.Focus()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Recargar()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'EliminarElemento(Matriz()(), TextBoxIDPersonas.Text)
    End Sub

    Private Sub BtnAscendente_Click(sender As Object, e As EventArgs) Handles BtnAscendente.Click

    End Sub

    Private Sub BtnDesendente_Click(sender As Object, e As EventArgs) Handles BtnDesendente.Click

    End Sub


End Class
