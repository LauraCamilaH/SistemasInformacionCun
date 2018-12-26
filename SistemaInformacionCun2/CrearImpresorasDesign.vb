Imports Microsoft.VisualBasic.FileIO

Public Class CrearImpresorasDesign
    Dim id As String
    Dim serie As String
    Dim marca As String
    Dim cadena As String

    Private Sub BtRegresarImpresoras_Click(sender As Object, e As EventArgs) Handles BtRegresarImpresoras.Click
        Me.Close()
        Formularioinicial.Show()
    End Sub

    Private Sub BtRegistarImpresoras_Click(sender As Object, e As EventArgs) Handles BtRegistarImpresoras.Click
        Dim administrador = New AdministradorImpresora
        If Not validar() Then
            Return
        End If
        administrador.CrearImpresora(TxSerieImpresora.Text, TxmarcaImpresora.Text, CInt(TextBoxDia.Text), CInt(TextBoxmes.Text), CInt(TextBoxaño.Text))
        MsgBox("Los datos han sido registrados")
        TextBoxmes.Text = ""
        TextBoxaño.Text = ""
        TextBoxDia.Text = ""
        TxSerieImpresora.Text = ""
        TxmarcaImpresora.Text = ""

    End Sub
    Function validar() As Boolean
        Dim marca = TxmarcaImpresora.Text
        Dim serie = TxSerieImpresora.Text
        If (String.IsNullOrEmpty(TxmarcaImpresora.Text)) Then
            MsgBox("Debe ingresar el nombre de la marca")
            Return False
        End If
        If (String.IsNullOrEmpty(TxSerieImpresora.Text)) Then
            MsgBox("Debe ingresar el nombre de la marca")
            Return False
        End If

        If (Not serie.Length = 6) Then
            MsgBox("La longitud de la serie  debe ser de 6 caracteres")
            Return False
        End If

        Dim precio = TextBoxValorImpresora.Text
        If (Not ValidarEntero(TextBoxValorImpresora.Text, 0, 100000000, "El precio")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxaño.Text, 2000, 2500, "El año")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxmes.Text, 1, 12, "El mes")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxDia.Text, 1, 31, "El día")) Then
            Return False
        End If
        Return True
    End Function

    Private Function ValidarEntero(valor As String, min As Integer, max As Integer, nombreVariable As String) As Boolean
        Try ''ejecutarlo que esta despues del try y si falla salta a ejecutar lo que esta en el cacth

            Dim val = CInt(valor)

            If (val < min) Then
                MsgBox(nombreVariable & " debe ser mayor o igual a " & min)
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

