Public Class Alquiler
    Public Sub ConsultarPeriodo(fi As String, ff As String, ds As BD.vAlquileresDataTable)
        Dim adap As New BDTableAdapters.vAlquileresTableAdapter
        adap.ConsultarXFecha(ds, fi, ff)
    End Sub
    Public Function TotalPeriodo(fi As Date, ff As Date) As Double
        Try
            Dim adap As New BDTableAdapters.TotalPeriodoTableAdapter
            Dim ds As New BD.TotalPeriodoDataTable
            adap.ConsultarTotalPeriodo(ds, fi, ff)
            Return ds.Item(0).TotalPeriodo
        Catch ex As Exception
            Return 0
            MsgBox(ex.Message)
        End Try
    End Function
    Public Sub CargarAlquileres(ds As BD.vAlquileresDataTable)
        Dim adap As New BDTableAdapters.vAlquileresTableAdapter
        adap.Fill(ds)
    End Sub
    Public Function CalcularMotoAlquiler(tarifa As Double, Horas As Integer) As Double
        Try
            Return tarifa * Horas
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Sub RegistrarAlquiler(Fecha As Date, hi As String, hf As String, Cantidad As Integer, Monto As Double, NDI As String, MotoId As String)
        Try
            Dim adap As New BDTableAdapters.AlquileresTableAdapter
            adap.Insert(Fecha, hi, hf, Cantidad, "EN ALQUILER", Monto, NDI, MotoId)
            Dim adapM As New BDTableAdapters.MotosTableAdapter
            adapM.AlquilarMoto(MotoId)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub FinalizarAlquiler(AlquilerID As String, MotoID As String)
        Try
            Dim adap As New BDTableAdapters.MotosTableAdapter
            Dim adapAl As New BDTableAdapters.AlquileresTableAdapter
            adapAl.FinalizarAlquiler(AlquilerID)
            adap.Devolver(MotoID)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ConsultarAlquilerNDI(NDI As String, ds As BD.vAlquileresDataTable)
        Try
            Dim adap As New BDTableAdapters.vAlquileresTableAdapter
            adap.ConsultarAlquilerPorNDI(ds, NDI)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ConsultarAqluilerPlaca(Placa As String, ds As BD.vAlquileresDataTable)
        Try
            Dim adap As New BDTableAdapters.vAlquileresTableAdapter
            adap.ConsultarAqluilerPlaca(ds, Placa)
        Catch ex As Exception

        End Try
    End Sub
End Class
