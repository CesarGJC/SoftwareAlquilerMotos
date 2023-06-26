Public Class RegistrarAlquiler
    Public Tipo As String
    Public Modelo As String
    Public Placa As String
    Public Cliente As String
    Public Nacionalidad As String
    Public Tarifa As Double
    Public idMoto As String
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
            txtTXHora.Text = Tarifa
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RegistrarAlquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtDesde.Value = Now
        dtFecha.Value = Now
        dtHasta.Value = Now
        DateTimePicker2.Value = Now

    End Sub

    Private Sub txtHoras_TextChanged(sender As Object, e As EventArgs) Handles txtHoras.TextChanged
        Try
            Dim ObjAlquiler As New cmpAlquileres.Alquiler
            txtTotal.Text = ObjAlquiler.CalcularMotoAlquiler(txtTXHora.Text, txtHoras.Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtHasta_ValueChanged(sender As Object, e As EventArgs) Handles dtHasta.ValueChanged
        Try
            Dim Fecha1 As DateTime = dtDesde.Value
            Dim Fecha2 As DateTime = dtHasta.Value
            Dim Diferencia As Integer = Fecha2.Hour - Fecha1.Hour
            txtHoras.Text = Diferencia.ToString

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Limpiar(ByVal contenedor As Control)
        For Each Control As Control In contenedor.Controls
            If TypeOf Control Is TextBox Then
                CType(Control, TextBox).Clear()
            ElseIf Control.HasChildren Then
                Limpiar(Control)
            End If
        Next
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim ObjAlquiler As New cmpAlquileres.Alquiler
            ObjAlquiler.RegistrarAlquiler(dtFecha.Value, dtDesde.Value, dtHasta.Value, txtTXHora.Text, txtTotal.Text, txtNDI.Text, idMoto)
            MessageBox.Show("Registrado Exitosamente")
            Limpiar(Me)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class