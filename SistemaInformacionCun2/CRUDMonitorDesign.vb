Public Class CRUDMonitorDesign
    Private AdminMonitor As AdministradorMonitor = New AdministradorMonitor ' constructor inicializa un objetollama a la clase que administra el monitor y la instancia
    Private Columnas As String() = {"Identificador", "Serial", "Marca"} 'nombramos las columnas 

    Private Sub CRUDMonitorDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

    End Sub


    Private Sub Recargar()
        Dim BD As List(Of List(Of String)) = AdminMonitor.CargarBD

        LimpiarCampos() ' llama al metodo limpiar campos
        DataGridMonitor.Rows.Clear() ''Eliminamos todas las filas del DataGrid las que estaban antes recargadas 

        For Each FilaBD As List(Of String) In BD '' Itera sobre los registros en base de datos
            Dim FilaTabla = New DataGridViewRow ''Se crea una fila para el datagrid
            For Each CeldaBD In FilaBD ''Se itera sobre cada una de las celdas de la fila
                Dim Celda = New DataGridViewTextBoxCell '' Se crea una celda para el datagrid
                Celda.Value = CeldaBD '' Value devuelve el valor asociado Se asigna el valor del la celda del datagrid
                FilaTabla.Cells.Add(Celda) ''Agregamos la celda del datagrid a la fila del datagrid
            Next
            DataGridMonitor.Rows.Add(FilaTabla) ''Se agrega la fila al datagrid
        Next
    End Sub
    Private Sub LimpiarCampos()
        TextBoxAnioMonitor.Text = ""
        TextBoxDiaMonitor.Text = ""
        TextBoxIdMonitor.Text = ""
        TextBoxMarcaMonitor.Text = ""
        TextBoxSerialMonitor.Text = ""
        TextBoxMesMonitor.Text = ""




    End Sub
End Class