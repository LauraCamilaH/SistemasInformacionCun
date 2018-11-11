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
        Dim Bdcpu = New AdministrardorCpu
        Dim idcpu = Bdcpu.CrearCpu(TextBserieCpu.Text, TextBmarcaCpu.Text, TextBoxDiaCpu.Text, TextBoxMesCpu.Text, TextBoxAnioCpu.Text, TextBoxValorCpu.Text)
        MsgBox("Se ha creado la cpu con el id " & idcpu)
        TextBserieCpu.Text = ""
        TextBmarcaCpu.Text = ""
        TextBoxDiaCpu.Text = ""
        TextBoxMesCpu.Text = ""
        TextBoxValorCpu.Text = ""
        TextBoxAnioCpu.Text = ""

    End Sub

    Private Sub CrearCPUDesing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class