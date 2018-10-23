Imports Microsoft.VisualBasic.FileIO

Public Class ConsultarDesign
    Dim currentRow As String() ' se declara variable a nivel de la clase 
    Private Sub BtConsultarPersonas_Click(sender As Object, e As EventArgs) Handles BtConsultarPersonas.Click
        Dim Bdpersonas = New AdministradorPersonas
        TxResultadoColsulta.Text = "Listado de registros en la BD" & vbNewLine & Bdpersonas.ConsultarComoString()
    End Sub

    Private Sub BtConsultarCpu_Click(sender As Object, e As EventArgs) Handles BtConsultarCpu.Click
        Dim Bdcpu = New AdministrardorCpu
        TxResultadoColsulta.Text = "listadfo de registro en la BD CPU" & vbNewLine & Bdcpu.ConsultarComoString()

    End Sub



    Private Sub ConsultarMonitor()

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(SpecialDirectories.MyDocuments & "\Bdmonitores.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",") 'establece los delimitadores para el lector en valores especificados 
            Dim cadena As String
            cadena = "Listado de registros en la BD de los monitores" & vbNewLine


            While Not MyReader.EndOfData 'recorre los campos del archivo end of data fin de los datos 
                Try
                    currentRow = MyReader.ReadFields() ' Current row Fila actual El ReadFields metodo para extraer los campos de texto o rompero o dividir las cadenas
                    'luego se incluye el codigo para manejar las filas 
                    Dim currentField As String ' asignamos una variable de tipo String Currentfield campo actual

                    For Each currentField In currentRow ' recore el archivo y muestra cada campo a la vez 
                        Dim vColeccion() As String = currentField.Split(";")
                        cadena &= vColeccion(0) & " " & vColeccion(1) & " " & vColeccion(2) & vbNewLine
                        'cadena &=   ->   cadena = cadena & 
                    Next

                Catch ex As Microsoft.VisualBasic.
                        FileIO.MalformedLineException
                    MsgBox("no existe archivo de lectura")

                End Try

            End While

            TxResultadoColsulta.Text = cadena 'validar    


        End Using
    End Sub

    Private Sub ConsultarImpresoras()
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(SpecialDirectories.MyDocuments & "\Bdimpresoras.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",") 'establece los delimitadores para el lector en valores especificados 
            Dim cadena As String
            cadena = "Listado de registros en la BD de las Impresoras" & vbNewLine


            While Not MyReader.EndOfData 'recorre los campos del archivo end of data fin de los datos 
                Try
                    currentRow = MyReader.ReadFields() ' Current row Fila actual El ReadFields metodo para extraer los campos de texto o rompero o dividir las cadenas
                    'luego se incluye el codigo para manejar las filas 
                    Dim currentField As String ' asignamos una variable de tipo String Currentfield campo actual

                    For Each currentField In currentRow ' recore el archivo y muestra cada campo a la vez 
                        Dim vColeccion() As String = currentField.Split(";")
                        cadena &= vColeccion(0) & " " & vColeccion(1) & " " & vColeccion(2) & vbNewLine
                        'cadena &=   ->   cadena = cadena & 
                    Next

                Catch ex As Microsoft.VisualBasic.
                        FileIO.MalformedLineException
                    MsgBox("no existe archivo de lectura")

                End Try

            End While

            TxResultadoColsulta.Text = cadena 'validar    
        End Using
    End Sub

    Private Sub BtRegresarConsultar_Click(sender As Object, e As EventArgs) Handles BtRegresarConsultar.Click
        Me.Close()
        Formularioinicial.Show()
    End Sub

    Private Sub BtConsultarMonitores_Click(sender As Object, e As EventArgs) Handles BtConsultarMonitores.Click
        ConsultarMonitor()
    End Sub

    Private Sub BtConsultarImpresoras_Click(sender As Object, e As EventArgs) Handles BtConsultarImpresoras.Click
        ConsultarImpresoras()
    End Sub
End Class