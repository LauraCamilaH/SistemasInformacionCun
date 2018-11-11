﻿Public Class CRUDCpuDesign
    Private AdmiCpu As AdministrardorCpu = New AdministrardorCpu

    Private Columnas As String() = {"Identificador", "Serial", "Marca", "Fecha creación", "valor producto"}


    Private Sub CRUPCpuDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Clear()

        For Each columna In Columnas
            Dim columnaTabla = New DataGridViewColumn()
            columnaTabla.HeaderText = columna ' obtiene o establece el texto del título en la celda del encabezado de la columna
            columnaTabla.Name = columna 'Pone o estable el nombre de las columnas 
            columnaTabla.SortMode = DataGridViewColumnSortMode.Automatic '' super importante me encanto es el ordenar automatico funciona paracedio a a filtar en excel
            columnaTabla.CellTemplate = New DataGridViewTextBoxCell ' Indica que cada celda de la columna será un campo de texto
            DataGridView1.Columns.Add(columnaTabla) ' agrega las columnas de la coleccion 
        Next
        Call Recargar()
    End Sub
    Private Sub Recargar()
        Dim BD As String()() = AdmiCpu.CargarDBMemoria
        LimpiarCampos()
        DataGridView1.Rows.Clear() ''Eliminamos todas las filas del DataGrid

        For Each FilaBD In BD '' Itera sobre los registros en base de datos
            Dim FilaTabla = New DataGridViewRow ''Se crea una fila para el datagrid
            For Each CeldaBD In FilaBD ''Se itera sobre cada una de las celdas de la fila
                Dim Celda = New DataGridViewTextBoxCell '' Se crea una celda para el datagrid
                Celda.Value = CeldaBD ''Se asigna el valor del la celda del datagrid
                FilaTabla.Cells.Add(Celda) ''Agregamos la celda del datagrid a la fila del datagrid
            Next
            DataGridView1.Rows.Add(FilaTabla) ''Se agrega la fila al datagrid
        Next
    End Sub
    Private Sub LimpiarCampos()
        LimpiarCamposTexto()
        BtnEliminar.Enabled = False
    End Sub
    Private Sub LimpiarCamposTexto()
        TextBoxAnioCpu.Text = ""
        TextBoxDiaCpu.Text = ""
        TextBoxIDPersonas.Text = ""
        TextBoxMarcaCpu.Text = ""
        TextBoxValorC.Text = ""

    End Sub

    Protected Overridable Function ValidarCampos() As String

        ''Si el campo está vácio o está lleno de espacios
        If String.IsNullOrWhiteSpace(TextBoxSerieCPU.Text) Then
            Return "Por favor ingrese un valor para el serial"
        End If
        If String.IsNullOrWhiteSpace(TextBoxMarcaCpu.Text) Then
            Return "Por favor ingrese la marca"
        End If
        If String.IsNullOrWhiteSpace(TextBoxValorC.Text) Then
            Return "Por favor ingrese el valor"
        End If
        Return "" ''No hay errores, retornamos una cadena vacia
    End Function

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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LimpiarCampos()
        TextBoxIDPersonas.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim validacion = ValidarCampos()
        If Not String.IsNullOrEmpty(validacion) Then
            MsgBox(validacion)
            Return
        End If

        Dim id = TextBoxIDPersonas.Text
        If String.IsNullOrEmpty(id) Then ''Si el id está en blanco es que el elemento es nuevo
            'Crear()
        Else
            'Actualizar()
        End If
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

    Private Sub BtnDescendente_Click(sender As Object, e As EventArgs) Handles BtnDescendente.Click

    End Sub
End Class