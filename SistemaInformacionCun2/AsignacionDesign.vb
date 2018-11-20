Imports Microsoft.VisualBasic.FileIO

Public Class AsignacionDesign
    Private AdminAsigna As AdministradorHistorico = New AdministradorHistorico
    Private Columnas As String() = {"Operacion", "Elemento", "ID_persona", "ID_elemento"}
    Dim currentRow As String()
    Dim Bdcpu As String()()
    Dim numero As Integer

    Private Sub CargarBds()
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(SpecialDirectories.MyDocuments & "\Bdmonitores.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim cadena As String
            cadena = " listado de registros en la Base de datos " & vbNewLine
            numero = 0
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        Dim vColeccion() As String = currentField.Split(";")
                        ReDim Preserve Bdcpu(numero)
                        Bdcpu(numero) = vColeccion

                        cadena &= Bdcpu(numero)(0) & " " & Bdcpu(numero)(1) & " " & Bdcpu(numero)(2) & " " & Bdcpu(numero)(3) & vbNewLine
                        numero += 1

                    Next
                Catch ex As Microsoft.VisualBasic.
                        FileIO.MalformedLineException
                    MsgBox("no existe archivo de lectura")

                End Try
            End While

        End Using
    End Sub
    Private Sub BtRegresarAsignacion_Click(sender As Object, e As EventArgs) Handles BtRegresarAsignacion.Click
        Me.Close()
        Formularioinicial.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        Dim Buscarpersonas = New AdministradorPersonas
        Dim Datospersona = Buscarpersonas.BuscarDatosPersona(TextBbuscarcedula.Text)

        If Datospersona.Length = 0 Then
            TextBoxApellido.Text = ""
            TextBoxNombre.Text = ""
            TextBoxCpu.Text = ""
            TextBoxImpresora.Text = ""
            TextBoxMonitor.Text = ""
            MsgBox("No se encuentra la persona con ese numero de cédula")
            Return
        End If

        TextBoxApellido.Text = Datospersona(4)
        TextBoxNombre.Text = Datospersona(2)
        TextBoxCpu.Text = Datospersona(7)
        TextBoxImpresora.Text = Datospersona(8)
        TextBoxMonitor.Text = Datospersona(6)

    End Sub


    Private Sub BttCambiarMonitor_Click(sender As Object, e As EventArgs) Handles BttCambiarMonitor.Click
        Dim administrarPersonas = New AdministradorPersonas
        Dim Resultado = administrarPersonas.ActualizarMonitor(TextBbuscarcedula.Text, TextBoxMonitor.Text)
        If Resultado = 1 Then
            MsgBox(" monitor ya esta asignado")
            Return
        End If
        MsgBox("Se ha actualizado el registro")
    End Sub

    Private Sub BtCambiarCpu_Click(sender As Object, e As EventArgs) Handles BtCambiarCpu.Click
        Dim administrarPersonas = New AdministradorPersonas
        Dim resultado = administrarPersonas.ActualizarCpu(TextBbuscarcedula.Text, TextBoxCpu.Text)
        If resultado = 1 Then
            MsgBox(" cpu  ya esta asignado")
            Return
        End If

        MsgBox("Se ha actualizado el registro")
    End Sub

    Private Sub BtCambiarImpresora_Click(sender As Object, e As EventArgs) Handles BtCambiarImpresora.Click
        Dim administrarPersonas = New AdministradorPersonas
        Dim resultado = administrarPersonas.ActualizarImpresora(TextBbuscarcedula.Text, TextBoxImpresora.Text)
        If resultado = 1 Then
            MsgBox(" impresora ya esta asignado")
            Return
        End If
        MsgBox("Se ha actualizado el registro")
    End Sub

    Private Sub BtHistoria_Click(sender As Object, e As EventArgs) Handles BtHistoria.Click

    End Sub


    Private Sub AsignacionDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridAsignacion.Columns.Clear()
        For Each Columna In Columnas 'ingresa a un ciclo Por cada Columna en el arreglo de string que tenemos 
            Dim ColumnaTabla = New DataGridViewColumn()
            ColumnaTabla.HeaderText = Columna ' obtiene o establece el texto del título en la celda del encabezado de la columna
            ColumnaTabla.Name = Columna 'Pone o estable el nombre de las columnas 
            ColumnaTabla.SortMode = DataGridViewColumnSortMode.Automatic '' super importante me encanto es el ordenar automatico funciona paracedio a a filtar en excel
            ColumnaTabla.CellTemplate = New DataGridViewTextBoxCell
            DataGridAsignacion.Columns.Add(ColumnaTabla) ' agrega las columnas de la coleccion 
        Next

    End Sub


End Class