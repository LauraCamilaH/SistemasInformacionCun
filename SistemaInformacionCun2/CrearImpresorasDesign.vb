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
        id = TxIdimpresoras.Text
        serie = TxSerieImpresora.Text
        marca = TxmarcaImpresora.Text
        cadena = id & ";" & serie & ";" & marca & vbCrLf

        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & " \Bdimpresoras.txt", cadena, True)

        MsgBox("Los datos han sido registrados")
        TxIdimpresoras.Text = ""
        TxSerieImpresora.Text = ""
        TxmarcaImpresora.Text = ""

    End Sub
End Class