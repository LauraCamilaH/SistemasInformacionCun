Imports Microsoft.VisualBasic.FileIO

Public Class CrearCPUDesing

    Dim id As String
    Dim serie As String
    Dim marca As String
    Dim Cadena As String

    Private Sub BttRegresarcpu_Click(sender As Object, e As EventArgs) Handles BttRegresarcpu.Click
        Me.Close()
        Formularioinicial.Show()
    End Sub

    Private Sub BtRegistarcpu_Click(sender As Object, e As EventArgs) Handles BtRegistarcpu.Click
        Dim Bdcpu = New AdministrardorCpu
        If Not validar() Then
            Return
        End If
        Dim idcpu = Bdcpu.CrearCpu(TextBserieCpu.Text, TextBmarcaCpu.Text, TextBoxDiaCpu.Text, TextBoxMesCpu.Text, TextBoxAnioCpu.Text, TextBoxValorCpu.Text)
        MsgBox("Se ha creado la cpu con el id " & idcpu)
        TextBserieCpu.Text = ""
        TextBmarcaCpu.Text = ""
        TextBoxDiaCpu.Text = ""
        TextBoxMesCpu.Text = ""
        TextBoxValorCpu.Text = ""
        TextBoxAnioCpu.Text = ""

    End Sub
    Function validar() As Boolean
        Dim marca = TextBmarcaCpu.Text
        Dim serie = TextBserieCpu.Text
        If (String.IsNullOrEmpty(TextBmarcaCpu.Text)) Then
            MsgBox("Debe ingresar el nombre de la marca")
            Return False
        End If
        If (String.IsNullOrEmpty(TextBmarcaCpu.Text)) Then
            MsgBox("Debe ingresar el nombre de la marca")
            Return False
        End If

        If (Not serie.Length = 6) Then
            MsgBox("La longitud de la serie  debe ser de 6 caracteres")
            Return False
        End If

        Dim precio = TextBoxValorCpu.Text
        If (Not ValidarEntero(TextBoxValorCpu.Text, 0, 100000000, "El precio")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxAnioCpu.Text, 2000, 2500, "El año")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxMesCpu.Text, 1, 12, "El mes")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxDiaCpu.Text, 1, 31, "El día")) Then
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
