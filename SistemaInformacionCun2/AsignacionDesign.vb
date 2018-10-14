Imports Microsoft.VisualBasic.FileIO

Public Class AsignacionDesign
    Dim currentRow As String()
    Dim Bdasignacion As String()()
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
                        ReDim Preserve Bdasignacion(numero)
                        Bdasignacion(numero) = vColeccion

                        cadena &= Bdasignacion(numero)(0) & " " & Bdasignacion(numero)(1) & " " & Bdasignacion(numero)(2) & " " & Bdasignacion(numero)(3) & vbNewLine
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
        Dim cadena As String
        For index1 As Integer = 0 To (Bdasignacion.Length - 1) - 1
            For index2 As Integer = 0 To (Bdasignacion.Length - 1) - 1
                If CInt(Bdasignacion(index2)(3)) < CInt(Bdasignacion(index2 + 1)(3)) Then
                    Dim ArregloLocal As String()
                    ArregloLocal = Bdasignacion(index2 + 1)
                    Bdasignacion(index2 + 1) = Bdasignacion(index2)
                    Bdasignacion(index2) = ArregloLocal

                End If
            Next
        Next
        cadena = " Listado de registros enl la base de datos " & vbNewLine
        For index1 As Integer = 0 To (Bdasignacion.Length - 1)
            cadena &= Bdasignacion(index1)(0) & " " & Bdasignacion(index1)(1) & " " & Bdasignacion(index1)(2) & " " & Bdasignacion(index1)(3) & vbNewLine

        Next
        TextBoxListahistoria.Text = cadena
    End Sub
End Class