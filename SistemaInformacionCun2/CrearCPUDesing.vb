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
        id = TextBidCpu.Text
        serie = TextBserieCpu.Text
        marca = TextBmarcaCpu.Text
        Cadena = id & ";" & serie & ";" & marca & vbCrLf
        My.Computer.FileSystem.WriteAllText(SpecialDirectories.MyDocuments & "\Bdcpu.txt", Cadena, True)
        MsgBox("los datos fueron registrados")
        TextBidCpu.Text = ""
        TextBserieCpu.Text = ""
        TextBmarcaCpu.Text = ""

    End Sub
End Class