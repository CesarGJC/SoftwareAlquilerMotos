Public Class Menú
    Private Sub Menú_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Const TamañoGrid As Integer = 10
    Private Const AreaMouse As Integer = 132
    Private Const botonIzquierdo As Integer = 17
    Private RectanguloGrid As Rectangle
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim Salir As DialogResult = MessageBox.Show("¿Estás seguro de cerrar el programa?", "¡Alerta!", MessageBoxButtons.YesNo)
        If Salir = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
    Public Sub AbrirFormulario(frmHijo As Object)
        If (PanelContenedor.Controls.Count > 0) Then
            PanelContenedor.Controls.RemoveAt(0)
        Else
            Dim frm As Form
            frm = frmHijo
            frm.TopLevel = False
            frm.Dock = DockStyle.Fill
            PanelContenedor.Controls.Add(frm)
            PanelContenedor.Tag = frm
            frm.Show()
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCliente.Click
        AbrirFormulario(New SeleccionarCliente)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub



    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)

        Dim region As New Region(New Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height))

        RectanguloGrid = New Rectangle(ClientRectangle.Width - TamañoGrid, ClientRectangle.Height - TamañoGrid, TamañoGrid, TamañoGrid)

        region.Exclude(RectanguloGrid)
        PanelMain.Region = region
        Invalidate()
    End Sub
    Protected Overrides Sub WndProc(ByRef sms As Message)
        Select Case sms.Msg
            Case AreaMouse
                MyBase.WndProc(sms)
                Dim RefPoint As Point = PointToClient(New Point(sms.LParam.ToInt32() And &HFFFFFF, sms.LParam.ToInt32() >> 16))
                If Not RectanguloGrid.Contains(RefPoint) Then
                    Exit Select
                End If
                sms.Result = New IntPtr(botonIzquierdo)
                Exit Select
            Case Else
                MyBase.WndProc(sms)
                Exit Select
        End Select
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim solidBrush As New SolidBrush(Color.FromArgb(55, 61, 69))
        e.Graphics.FillRectangle(solidBrush, RectanguloGrid)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, RectanguloGrid)
    End Sub
    Dim lx, ly As Integer
    Private Sub Switch(msg As Integer)
        Throw New NotImplementedException()
    End Sub
    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAlquileres_Click(sender As Object, e As EventArgs) Handles btnAlquileres.Click
        AbrirFormulario(New IndiceAlquieres)
    End Sub

    Dim sw, sh As Integer
End Class
