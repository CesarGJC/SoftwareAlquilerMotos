Public Class IndiceMotos
    Private Sub txtBuscadorMotos_TextChanged(sender As Object, e As EventArgs) Handles txtBuscadorMotos.TextChanged
        Try
            Dim adap As New cmpAlquileres.Motos
            adap.ConsultarMotos(txtBuscadorMotos.Text, Bd1.VMotos)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IndiceMotos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim adap As New cmpAlquileres.Motos
            adap.CargarMotos(Bd1.VMotos)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        RegistrarMoto.ShowDialog()
        IndiceMotos_Load(sender, e)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim ObjMoto As New cmpAlquileres.Motos
            Dim Salir As DialogResult = MessageBox.Show("Estás Seguro?", "¡Alerta!", MessageBoxButtons.YesNo)
            If Salir = Windows.Forms.DialogResult.Yes Then
                ObjMoto.EliminarMoto(DataGridView1.Item("PlacaDataGridViewTextBoxColumn", DataGridView1.CurrentRow.Index).Value)
                IndiceMotos_Load(sender, e)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class