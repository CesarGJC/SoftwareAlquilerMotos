Public Class SeleccionarMoto
    Dim Tipo As String
    Dim Modelo As String
    Dim Placa As String
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            Dim ObjCli As New cmpAlquileres.Motos
            ObjCli.ConsultarMotoDisponible(ComboBox1.SelectedValue, Bd1.Motos)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim ObjMoto As New cmpAlquileres.Motos
            ObjMoto.ConsultarMotoDisponible(ComboBox1.SelectedValue, Bd1.Motos)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SeleccionarMoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ObjCli As New cmpAlquileres.Motos
            ObjCli.CargarCategoria(Bd1.TiposMotos)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub MostrarMoto(f As RegistrarAlquiler)
        Try
            f.Modelo = Modelo
            f.Tipo = Tipo
            f.Placa = Placa
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Try

            Tipo = DataGridView1.Item("TipoDataGridViewTextBoxColumn", DataGridView1.CurrentRow.Index).Value
            Modelo = DataGridView1.Item("ModeloDataGridViewTextBoxColumn", DataGridView1.CurrentRow.Index).Value
            Placa = DataGridView1.Item("PlacaDataGridViewTextBoxColumn", DataGridView1.CurrentRow.Index).Value

            MostrarMoto(RegistrarAlquiler)
            Close()
        Catch ex As Exception

        End Try
    End Sub
End Class