Public Class EditarTipoMoto
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If String.IsNullOrWhiteSpace(txtID.Text) Then
                Dim ObjTipoMotos As New cmpAlquileres.Motos
                ObjTipoMotos.AgregarTipoMoto(txtTipoMoto.Text)
                MessageBox.Show("Guardado Exitosamente")
                Me.Close()
            Else Dim ObjTipomoto As New cmpAlquileres.Motos
                ObjTipomoto.EditarTipoMoto(txtTipoMoto.Text, txtID.Text)
                MessageBox.Show("Editado Exitosamente")
                Me.Close()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.Hide()
    End Sub
End Class