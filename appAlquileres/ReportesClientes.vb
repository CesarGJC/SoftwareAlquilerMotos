Public Class ReportesClientes
    Private Sub ReportesClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Dim Obj As New cmpAlquileres.Clientes
        Obj.Listar(Bd1.Clientes)
    End Sub
End Class