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
End Class
