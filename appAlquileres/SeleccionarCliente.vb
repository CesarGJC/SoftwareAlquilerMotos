Public Class SeleccionarCliente
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim objCli As New cmpAlquileres.Clientes
            objCli.ConsultarXNombre(TextBox1.Text, Bd1.VCliente)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim ObjCli As New cmpAlquileres.Clientes
            Dim Salir As DialogResult = MessageBox.Show("¿Estás seguro?", "¡Alerta!", MessageBoxButtons.YesNo)
            If Salir = Windows.Forms.DialogResult.Yes Then
                ObjCli.EliminarCliente(DataGridView1.Item("NDIDataGridViewTextBoxColumn", DataGridView1.CurrentRow.Index).Value)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SeleccionarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        RegistrarCliente.ShowDialog()
    End Sub
End Class