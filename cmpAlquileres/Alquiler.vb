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
End Class
