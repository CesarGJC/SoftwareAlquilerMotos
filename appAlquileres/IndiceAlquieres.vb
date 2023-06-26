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

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Mostrar()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click

        Try
            RegistrarAlquiler.ShowDialog()
            IndiceAlquieres_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub rbPlaca_CheckedChanged(sender As Object, e As EventArgs) Handles rbPlaca.CheckedChanged
        Try
            If rbPlaca.Checked Then
                txtPlaca.Visible = True
            Else
                txtPlaca.Visible = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbNDI_CheckedChanged(sender As Object, e As EventArgs) Handles rbNDI.CheckedChanged
        Try
            If rbNDI.Checked Then
                txtNDI.Visible = True
            Else
                txtNDI.Visible = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPlaca_TextChanged(sender As Object, e As EventArgs) Handles txtPlaca.TextChanged
        Try
            Dim ObjAlquiler As New cmpAlquileres.Alquiler
            ObjAlquiler.ConsultarAqluilerPlaca(txtPlaca.Text, Bd1.vAlquileres)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNDI_TextChanged(sender As Object, e As EventArgs) Handles txtNDI.TextChanged
        Try
            Dim ObjAlquiler As New cmpAlquileres.Alquiler
            ObjAlquiler.ConsultarAlquilerNDI(txtNDI.Text, Bd1.vAlquileres)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FinalizarAlquilerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalizarAlquilerToolStripMenuItem.Click
        Dim ObjAlquiler As New cmpAlquileres.Alquiler
        Dim AlquilerId As String
        Dim MotoID As String
        AlquilerId = IndiceRegistrosAlquileres.Item("AlquilerIDDataGridViewTextBoxColumn", IndiceRegistrosAlquileres.CurrentRow.Index).Value
        MotoID = IndiceRegistrosAlquileres.Item("MotoIDDataGridViewTextBoxColumn", IndiceRegistrosAlquileres.CurrentRow.Index).Value

        Try
            If MsgBox("¿Desea Finalizar Alquiler?", vbYesNo, "Finalizar Alquiler") = MsgBoxResult.Yes Then
                ObjAlquiler.FinalizarAlquiler(AlquilerId, MotoID)
                MsgBox("Finalizado Correctamente")
            End If
        Catch ex As Exception

        End Try

    End Sub

End Class