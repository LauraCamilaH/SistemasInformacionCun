Imports Microsoft.VisualBasic.FileIO

Public Class DesignEjercicioClase



    Private Sub BtRegresar_Click(sender As Object, e As EventArgs) Handles BtRegresar.Click
        Me.Close()
        Formularioinicial.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btRegistar.Click
        Dim Laurita = New AdministradorPersonas()
        Dim id = Laurita.CrearPersona(Textcedula.Text, Textnombre.Text, Textapellido.Text, Textciudad.Text)

        MsgBox("Se ha creado la persona con id " & id)
        Textcedula.Text = ""
        Textapellido.Text = ""
        Textnombre.Text = ""
        Textciudad.Text = ""

    End Sub



End Class