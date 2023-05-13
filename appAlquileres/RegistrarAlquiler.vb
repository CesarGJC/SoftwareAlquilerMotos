Public Class RegistrarAlquiler
    Public Tipo As String
    Public Modelo As String
    Public Placa As String
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim Salir As DialogResult = MessageBox.Show("¿Estás seguro?", "¡Alerta!", MessageBoxButtons.YesNo)
        If Salir = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SeleccionarMoto.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ObjCliente As New cmpAlquileres.Clientes
        ObjCliente.ConsultarCliente(txtNDI.Text, Bd1.VCliente)
    End Sub

    Private Sub RegistrarAlquiler_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            txtTipo.Text = Tipo
            txtModelo.Text = Modelo
            txtPlaca.Text = Placa
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RegistrarAlquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class