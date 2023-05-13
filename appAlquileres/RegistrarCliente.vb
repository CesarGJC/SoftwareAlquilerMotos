Public Class RegistrarCliente
    Private Sub RegistrarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ObjCli As New cmpAlquileres.Clientes
            ObjCli.CargarNacionalidad(Bd1.Nacionalidades)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim NDI As String = txtNDI.Text
        Dim Nombre As String = txtNombres.Text
        Dim APaterno As String = txtApellidoP.Text
        Dim AMaterno As String = txtApellidoM.Text
        Dim Telefono As String = txtTelefono.Text
        Dim Direccion As String = txtDireccion.Text
        Dim Nacionalidad As Integer = cbNacionalidad.SelectedValue

        Try
            Dim ObjCli As New cmpAlquileres.Clientes
            ObjCli.AgregarCLiente(NDI, Nombre, APaterno, AMaterno, Telefono, Direccion, Nacionalidad)
            MessageBox.Show("Guardado Exitosamente!")
            Limpiar(Me)
            Me.Close()

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
End Class