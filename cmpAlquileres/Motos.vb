Public Class Motos
    Public Sub ConsultarMotoDisponible(tipo As String, ds As BD.MotosDataTable)
        Dim adap As New BDTableAdapters.MotosTableAdapter
        adap.ConsultarMotosDisponibles(ds, tipo)
    End Sub

    Public Sub CargarCategoria(moto As BD.TiposMotosDataTable)
        Try
            Dim adap As New BDTableAdapters.TiposMotosTableAdapter
            adap.Fill(moto)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ConsultarMotos(a As String, ds As BD.VMotosDataTable)
        Try
            Dim adap As New BDTableAdapters.VMotosTableAdapter
            adap.ConsultarMoto(ds, a)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub EditarTipoMoto(tipo As String, tipoid As Integer)
        Try
            Dim adap As New BDTableAdapters.TiposMotosTableAdapter
            adap.EditarTipoMoto(tipo, tipoid)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub AgregarTipoMoto(tipo As String)
        Try
            Dim adap As New BDTableAdapters.TiposMotosTableAdapter
            adap.AgregarTipoMoto(tipo)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub CargarMotos(ds As BD.VMotosDataTable)
        Dim adap As New BDTableAdapters.VMotosTableAdapter
        adap.Fill(ds)
    End Sub
    Public Sub AgregarMoto(Placa As String, Color As String, Tipo As Integer, Modelo As String, Detalle As String, Tarifa As Decimal, Estado As String, foto As Byte())
        Dim adap As New BDTableAdapters.MotosTableAdapter
        adap.InsertarMoto(Placa, Color, Tipo, Modelo, Detalle, Tarifa, Estado, foto)
    End Sub
    Public Sub EliminarMoto(Placa As String)
        Try
            Dim adap As New BDTableAdapters.MotosTableAdapter
            adap.EliminarMoto(Placa)
        Catch ex As Exception

        End Try
    End Sub
End Class
