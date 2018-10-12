Imports Microsoft.VisualBasic.FileIO

Public Class ConsultarDesign
    Dim currentRow As String() ' se declara variable a nivel de la clase 
    Private Sub BtConsultarPersonas_Click(sender As Object, e As EventArgs) Handles BtConsultarPersonas.Click

        ListarDatosPersonas() ' se llama a Listar personas para que cuando se haga clic en el boton cargue los datos de las personas'
    End Sub

    Private Sub ListarDatosPersonas() ' se hace todo lo relacionado con listar personas'

        'Usando el archivo, se analiza los datos del campo de texto con el TextFieldParser que es similar a iterar sobre un archivo de texto
        'y se le indica en donde esta la ruta"
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(SpecialDirectories.MyDocuments & "\Bdpersonas.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",") 'establece los delimitadores para el lector en valores especificados 
            Dim cadena As String
            cadena = "Listado de registros en la BD" & vbNewLine


            While Not MyReader.EndOfData 'recorre los campos del archivo end of data fin de los datos 
                Try
                    currentRow = MyReader.ReadFields() ' Current row Fila actual El ReadFields metodo para extraer los campos de texto o rompero o dividir las cadenas
                    'luego se incluye el codigo para manejar las filas 
                    Dim currentField As String ' asignamos una variable de tipo String Currentfield campo actual

                    For Each currentField In currentRow ' recore el archivo y muestra cada campo a la vez 
                        Dim vColeccion() As String = currentField.Split(";")
                        cadena &= vColeccion(0) & " " & vColeccion(1) & " " & vColeccion(2) & " " & vColeccion(3) & vbNewLine
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


End Class