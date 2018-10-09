Imports Microsoft.VisualBasic.FileIO

Public Class DesignEjercicioClase
    Dim nombre As String
    Dim apellido As String
    Dim cedula As String
    Dim ciudad As String
    Dim cadena As String


    Private Sub BtRegresar_Click(sender As Object, e As EventArgs) Handles BtRegresar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btRegistar.Click

        nombre = Textnombre.Text
        apellido = Textapellido.Text
        cedula = Textcedula.Text
        ciudad = Textciudad.Text
        'Hola
        cadena = nombre & ";" & apellido & ";" & cedula & ";" & ciudad & vbCrLf
        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\Bdpersonas.txt", cadena, True)
    End Sub

End Class