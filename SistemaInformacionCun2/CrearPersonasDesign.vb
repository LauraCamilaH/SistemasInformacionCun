Imports Microsoft.VisualBasic.FileIO

Public Class DesignEjercicioClase



    Private Sub BtRegresar_Click(sender As Object, e As EventArgs) Handles BtRegresar.Click
        Me.Close()
        Formularioinicial.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btRegistar.Click
        Dim AdministradorPer = New AdministradorPersonas()
        If Not validar() Then
            Return
        End If
        Dim idpersona = AdministradorPer.CrearPersona(Textcedula.Text, Textprimernombre.Text, TextBoxSegundoNombre.Text, Textapellido.Text, Textciudad.Text, TextBoxCargo.Text, TextBoxSueldo.Text, TextBoxDíaPersonas.Text, TextBoxMesPersonas.Text, TextBoxAnioPersonas.Text)


        MsgBox("Se ha creado la persona con id " & idpersona)
        Textcedula.Text = ""
        Textapellido.Text = ""
        Textprimernombre.Text = ""
        Textciudad.Text = ""
        TextBoxSegundoNombre.Text = ""
        TextBoxAnioPersonas.Text = ""
        TextBoxCargo.Text = ""
        TextBoxDíaPersonas.Text = ""
        TextBoxCargo.Text = ""
        TextBoxMesPersonas.Text = ""

    End Sub

    Private Sub DesignEjercicioClase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Function validar() As Boolean

        If (String.IsNullOrEmpty(Textprimernombre.Text)) Then
            MsgBox("Debe ingresar el primer nombre")
            Return False
        End If
        If (String.IsNullOrEmpty(TextBoxSegundoNombre.Text)) Then
            MsgBox("Debe ingresar el segundo nombre")
            Return False
        End If
        If (String.IsNullOrEmpty(Textapellido.Text)) Then
            MsgBox("Debe ingresar el apellido")
            Return False
        End If
        If (String.IsNullOrEmpty(Textciudad.Text)) Then
            MsgBox("Debe ingresar la ciudad ")
            Return False
        End If
        If (String.IsNullOrEmpty(TextBoxCargo.Text)) Then
            MsgBox("Debe ingresar el cargo")
            Return False
        End If
        If (Not ValidarEntero(Textcedula.Text, 0, 100000000, "La cedula")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxAnioPersonas.Text, 2000, 2500, "El año")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxMesPersonas.Text, 1, 12, "El mes")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxDíaPersonas.Text, 1, 31, "El día")) Then
            Return False
        End If
        If (Not ValidarEntero(TextBoxSueldo.Text, 1, 80000000, "El sueldo")) Then
            Return False
        End If
        Return True
    End Function

    Private Function ValidarEntero(valor As String, min As Integer, max As Integer, nombreVariable As String) As Boolean
        Try ''ejecutarlo que esta despues del try y si falla salta a ejecutar lo que esta en el cacth

            Dim val = CInt(valor)

            If (val < min) Then
                MsgBox(nombreVariable & " debe ser mayor a  " & min)
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