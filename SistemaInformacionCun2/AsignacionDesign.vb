Imports Microsoft.VisualBasic.FileIO

Public Class AsignacionDesign
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
    Private Sub organizar()
        Dim cadena As String
        For index1 As Integer = 0 To (Bdcpu.Length - 1) - 1
            For index2 As Integer = 0 To (Bdcpu.Length - 1) - 1
                If CInt(Bdcpu(index2)(3)) < CInt(Bdcpu(index2 + 1)(3)) Then
                    Dim ArregloLocal As String()
                    ArregloLocal = Bdcpu(index2 + 1)
                    Bdcpu(index2 + 1) = Bdcpu(index2)
                    Bdcpu(index2) = ArregloLocal

                End If
            Next
        Next
        cadena = " Listado de registros enl la base de datos " & vbNewLine
        For index1 As Integer = 0 To (Bdcpu.Length - 1)
            cadena &= Bdcpu(index1)(0) & " " & Bdcpu(index1)(1) & " " & Bdcpu(index1)(2) & " " & Bdcpu(index1)(3) & vbNewLine

        Next
        TextBoxListahistoria.Text = cadena
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

    End Sub
End Class