Public Class IndiceAlquieres
    Private Sub IndiceAlquieres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Now
        DateTimePicker2.Value = Now
        Mostrar()
    End Sub
    Public Sub Mostrar()
        Try
            Dim objAlq As New cmpAlquileres.Alquiler
            objAlq.ConsultarPeriodo(DateTimePicker1.Value, DateTimePicker2.Value, Bd1.vAlquileres)
            txtTotalIngreso.Text = objAlq.TotalPeriodo(DateTimePicker1.Value, DateTimePicker2.Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Mostrar()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click

        Try
            RegistrarAlquiler.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub
End Class