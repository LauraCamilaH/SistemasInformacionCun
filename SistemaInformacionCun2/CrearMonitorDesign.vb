Imports Microsoft.VisualBasic.FileIO

Public Class CrearMonitorDesign

    Dim id As String
    Dim serie As String
    Dim marca As String
    Dim cadena As String

    Private Sub BttRegresarMonitor_Click(sender As Object, e As EventArgs) Handles BttRegresarMonitor.Click
        Me.Close()
        Formularioinicial.Show()
    End Sub

    Private Sub BttRegistarMonitor_Click(sender As Object, e As EventArgs) Handles BttRegistarMonitor.Click
        Dim administrador = New AdministradorMonitor
        If Not validar() Then
            Return

        End If
        Dim idmonitor = administrador.CrearMonitor(TexBSerieMonitor.Text, TexBMarcaMonitor.Text)
        MsgBox("los datos fueron registrados con id: " & idmonitor)

        TexBSerieMonitor.Text = ""
        TexBMarcaMonitor.Text = ""
    End Sub

    Private Sub CrearMonitorDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Function validar() As Boolean
        Dim marca = TexBMarcaMonitor.Text
        Dim serie = TexBSerieMonitor.Text
        If (String.IsNullOrEmpty(TexBMarcaMonitor.Text)) Then
            MsgBox("Debe ingresar el nombre de la marca")
            Return False
        End If
        If (String.IsNullOrEmpty(TexBSerieMonitor.Text)) Then
            MsgBox("Debe ingresar el nombre de la marca")
            Return False
        End If

        If (Not serie.Length = 6) Then
            MsgBox("La longitud de la serie  debe ser de 6 caracteres")
            Return False
        End If

        Dim precio = TextBoxValorMonitor.Text
        If (Not ValidarEntero(TextBoxValorMonitor.Text, 0, 100000000, "El precio")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxanioMonitor.Text, 2000, 2500, "El año")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoMesMonitor.Text, 1, 12, "El mes")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxDíaMonitor.Text, 1, 31, "El día")) Then
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
