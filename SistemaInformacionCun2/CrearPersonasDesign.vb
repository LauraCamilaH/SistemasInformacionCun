Imports Microsoft.VisualBasic.FileIO

Public Class DesignEjercicioClase



    Private Sub BtRegresar_Click(sender As Object, e As EventArgs) Handles BtRegresar.Click
        Me.Close()
        Formularioinicial.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btRegistar.Click
        Dim AdministradorPer = New AdministradorPersonas()
        Dim idpersona = AdministradorPer.CrearPersona(Textcedula.Text, Textprimernombre.Text, TextBoxSegundoNombre.Text, Textapellido.Text, Textciudad.Text, TextBoxCargo.Text, TextBoxSueldo.Text, CInt(TextBoxDíaPersonas.Text), CInt(TextBoxMesPersonas.Text), CInt(TextBoxAnioPersonas.Text))


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
End Class