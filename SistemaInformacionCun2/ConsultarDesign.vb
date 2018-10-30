Imports Microsoft.VisualBasic.FileIO

Public Class ConsultarDesign
    Dim currentRow As String() ' se declara variable a nivel de la clase 
    Private Sub BtConsultarPersonas_Click(sender As Object, e As EventArgs) Handles BtConsultarPersonas.Click
        Dim Bdpersonas = New AdministradorPersonas
        TxResultadoColsulta.Text = "Listado de registros en la BD" & vbNewLine & Bdpersonas.ConsultarComoString()
    End Sub

    Private Sub BtConsultarCpu_Click(sender As Object, e As EventArgs) Handles BtConsultarCpu.Click
        Dim Bdcpu = New AdministrardorCpu
        TxResultadoColsulta.Text = "listadfo de registro en la BD CPU" & vbNewLine & Bdcpu.ConsultarComoString()

    End Sub

    Private Sub BtRegresarConsultar_Click(sender As Object, e As EventArgs) Handles BtRegresarConsultar.Click
        Me.Close()
        Formularioinicial.Show()
    End Sub

    Private Sub BtConsultarImpresoras_Click(sender As Object, e As EventArgs) Handles BtConsultarImpresoras.Click
        Dim bdimpresora = New AdministradorImpresora
        TxResultadoColsulta.Text = "listado de registro de impresoras en la BD " & vbNewLine & bdimpresora.ConsultarComoString()

    End Sub

    Private Sub BtConsultarMonitores_Click(sender As Object, e As EventArgs) Handles BtConsultarMonitores.Click
        Dim bdMonitor = New AdministradorMonitor
        TxResultadoColsulta.Text = "Listado de registro de monitores en la BD" & vbNewLine & bdMonitor.ConsultarComoString()
    End Sub
End Class