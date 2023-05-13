Public Class Clientes
    Public Sub ConsultarCliente(NDI As String, ds As BD.VClienteDataTable)
        Dim adap As New BDTableAdapters.VClienteTableAdapter
        adap.ConsultarClientes(ds, NDI)
    End Sub

    Public Sub ConsultarXNombre(cli As String, ds As BD.VClienteDataTable)
        Dim adap As New BDTableAdapters.VClienteTableAdapter
        adap.ConsultarXNombre(ds, cli)
    End Sub
    Public Sub EliminarCliente(NDI As String)
        Try
            Dim adap As New BDTableAdapters.ClientesTableAdapter
            adap.EliminarCliente(NDI)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub AgregarCLiente(NDI As String, Nombres As String, APaterno As String, AMaterno As String, Telefono As String, Direccion As String, Nacionalidad As Integer)
        Dim adap As New BDTableAdapters.ClientesTableAdapter
        adap.InsertarCliente(NDI, Nombres, APaterno, AMaterno, Telefono, Direccion, Nacionalidad)
    End Sub
    Public Sub CargarNacionalidad(Nacionalidad As BD.NacionalidadesDataTable)
        Try
            Dim adap As New BDTableAdapters.NacionalidadesTableAdapter
            adap.Fill(Nacionalidad)
        Catch ex As Exception

        End Try
    End Sub
End Class
