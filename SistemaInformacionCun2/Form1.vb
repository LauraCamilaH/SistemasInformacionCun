Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LB_usuario.Click

    End Sub

    Private Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
        If Tbusuario.Text = "cun" And Tbcontrasena.Text = "123" Then

            LB_usuario.Visible = False
            LB_clave.Visible = False
            Tbusuario.Visible = False
            Tbcontrasena.Visible = False
            BIngresar.Visible = False
        ElseIf Tbcontrasena.Text <> "123" Then
            MsgBox("la contraseña no corresponde! Intente de nuevo")
            Tbusuario.Text = ""
            Tbcontrasena.Text = ""

        End If
    End Sub

    Private Sub MePersonas_Click(sender As Object, e As EventArgs) Handles MePersonas.Click

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AgregarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPersonaToolStripMenuItem.Click
        Dim Form = New DesignEjercicioClase
        Form.Show()
    End Sub

    Private Sub MostrarPersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarPersonasToolStripMenuItem.Click
        Dim ListarPersonas = New ListarPersonas
        ListarPersonas.Show()
    End Sub
End Class
