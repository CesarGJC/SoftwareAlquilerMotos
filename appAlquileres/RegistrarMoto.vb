Imports System.IO
Public Class RegistrarMoto

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Placa As String = txtPlaca.Text
        Dim Color As String = txtColor.Text
        Dim Tipo As Integer = cbTipoMoto.SelectedValue
        Dim Modelo As String = txtModelo.Text
        Dim Detalle As String = txtDetalle.Text
        Dim Tarifa As Decimal = txtTarifa.Text
        Dim Estado As String = cbEstado.Text
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Try
            Dim ObjMoto As New cmpAlquileres.Motos
            ObjMoto.AgregarMoto(Placa, Color, Tipo, Modelo, Detalle, Tarifa, Estado, ms.GetBuffer)
            MessageBox.Show("Guardado Exitosamente")
            Limpiar(Me)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RegistrarMoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ObjMoto As New cmpAlquileres.Motos
            ObjMoto.CargarCategoria(Bd1.TiposMotos)
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Limpiar(Me)
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.Hide()
    End Sub

    Private Sub linkNuevo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkNuevo.LinkClicked
        Try
            EditarTipoMoto.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        OpenFileDialog1.Filter = "IMAGENES JPG|*.JPG"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
        End If
    End Sub
End Class