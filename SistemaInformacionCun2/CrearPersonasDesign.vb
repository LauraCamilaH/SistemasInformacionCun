Imports Microsoft.VisualBasic.FileIO

Public Class DesignEjercicioClase



    Private Sub BtRegresar_Click(sender As Object, e As EventArgs) Handles BtRegresar.Click
        Me.Close()
        Formularioinicial.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btRegistar.Click
        Dim AdministradorPer = New AdministradorPersonas()
        Dim id = AdministradorPer.CrearPersona(Textcedula.Text, Textnombre.Text, Textapellido.Text, Textciudad.Text)

        MsgBox("Se ha creado la persona con id " & id)
        Textcedula.Text = ""
        Textapellido.Text = ""
        Textnombre.Text = ""
        Textciudad.Text = ""

    End Sub

    Private Sub DesignEjercicioClase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class