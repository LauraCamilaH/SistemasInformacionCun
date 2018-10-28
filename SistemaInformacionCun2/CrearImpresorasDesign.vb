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

        administrador.CrearImpresora(TxSerieImpresora.Text, TxmarcaImpresora.Text, CInt(TextBoxDia.Text), CInt(TextBoxmes.Text), CInt(TextBoxaño.Text))
        MsgBox("Los datos han sido registrados")
        TextBoxmes.Text = ""
        TextBoxaño.Text = ""
        TextBoxDia.Text = ""
        TxSerieImpresora.Text = ""
        TxmarcaImpresora.Text = ""

    End Sub

End Class