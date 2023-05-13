<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndiceAlquieres
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IndiceAlquieres))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalIngreso = New System.Windows.Forms.TextBox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.IndiceRegistrosAlquileres = New System.Windows.Forms.DataGridView()
        Me.Bd1 = New cmpAlquileres.BD()
        Me.AlquilerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadHorasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NDIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoPaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoMaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NacionalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndiceRegistrosAlquileres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bd1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(62, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(211, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(353, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(213, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(294, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(584, 393)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TOTA INGRESOS:"
        '
        'txtTotalIngreso
        '
        Me.txtTotalIngreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalIngreso.Location = New System.Drawing.Point(688, 386)
        Me.txtTotalIngreso.Name = "txtTotalIngreso"
        Me.txtTotalIngreso.ReadOnly = True
        Me.txtTotalIngreso.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalIngreso.TabIndex = 6
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(578, 19)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(30, 30)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 7
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(614, 19)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(30, 30)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 8
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'IndiceRegistrosAlquileres
        '
        Me.IndiceRegistrosAlquileres.AllowUserToAddRows = False
        Me.IndiceRegistrosAlquileres.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndiceRegistrosAlquileres.AutoGenerateColumns = False
        Me.IndiceRegistrosAlquileres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.IndiceRegistrosAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IndiceRegistrosAlquileres.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AlquilerIDDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.HoraInicioDataGridViewTextBoxColumn, Me.HoraFinDataGridViewTextBoxColumn, Me.CantidadHorasDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.NDIDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidoPaternoDataGridViewTextBoxColumn, Me.ApellidoMaternoDataGridViewTextBoxColumn, Me.NacionalidadDataGridViewTextBoxColumn, Me.MotoIDDataGridViewTextBoxColumn, Me.PlacaDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.DetalleDataGridViewTextBoxColumn, Me.TipoMotoDataGridViewTextBoxColumn})
        Me.IndiceRegistrosAlquileres.DataMember = "vAlquileres"
        Me.IndiceRegistrosAlquileres.DataSource = Me.Bd1
        Me.IndiceRegistrosAlquileres.Location = New System.Drawing.Point(12, 55)
        Me.IndiceRegistrosAlquileres.Name = "IndiceRegistrosAlquileres"
        Me.IndiceRegistrosAlquileres.ReadOnly = True
        Me.IndiceRegistrosAlquileres.Size = New System.Drawing.Size(776, 325)
        Me.IndiceRegistrosAlquileres.TabIndex = 0
        '
        'Bd1
        '
        Me.Bd1.DataSetName = "BD"
        Me.Bd1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlquilerIDDataGridViewTextBoxColumn
        '
        Me.AlquilerIDDataGridViewTextBoxColumn.DataPropertyName = "AlquilerID"
        Me.AlquilerIDDataGridViewTextBoxColumn.HeaderText = "AlquilerID"
        Me.AlquilerIDDataGridViewTextBoxColumn.Name = "AlquilerIDDataGridViewTextBoxColumn"
        Me.AlquilerIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlquilerIDDataGridViewTextBoxColumn.Visible = False
        Me.AlquilerIDDataGridViewTextBoxColumn.Width = 77
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 62
        '
        'HoraInicioDataGridViewTextBoxColumn
        '
        Me.HoraInicioDataGridViewTextBoxColumn.DataPropertyName = "HoraInicio"
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.HoraInicioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.HoraInicioDataGridViewTextBoxColumn.HeaderText = "HoraInicio"
        Me.HoraInicioDataGridViewTextBoxColumn.Name = "HoraInicioDataGridViewTextBoxColumn"
        Me.HoraInicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoraInicioDataGridViewTextBoxColumn.Width = 80
        '
        'HoraFinDataGridViewTextBoxColumn
        '
        Me.HoraFinDataGridViewTextBoxColumn.DataPropertyName = "HoraFin"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.HoraFinDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.HoraFinDataGridViewTextBoxColumn.HeaderText = "HoraFin"
        Me.HoraFinDataGridViewTextBoxColumn.Name = "HoraFinDataGridViewTextBoxColumn"
        Me.HoraFinDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoraFinDataGridViewTextBoxColumn.Width = 69
        '
        'CantidadHorasDataGridViewTextBoxColumn
        '
        Me.CantidadHorasDataGridViewTextBoxColumn.DataPropertyName = "CantidadHoras"
        Me.CantidadHorasDataGridViewTextBoxColumn.HeaderText = "CantidadHoras"
        Me.CantidadHorasDataGridViewTextBoxColumn.Name = "CantidadHorasDataGridViewTextBoxColumn"
        Me.CantidadHorasDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadHorasDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CantidadHorasDataGridViewTextBoxColumn.Visible = False
        Me.CantidadHorasDataGridViewTextBoxColumn.Width = 102
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoDataGridViewTextBoxColumn.Width = 62
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Width = 65
        '
        'NDIDataGridViewTextBoxColumn
        '
        Me.NDIDataGridViewTextBoxColumn.DataPropertyName = "NDI"
        Me.NDIDataGridViewTextBoxColumn.HeaderText = "NDI"
        Me.NDIDataGridViewTextBoxColumn.Name = "NDIDataGridViewTextBoxColumn"
        Me.NDIDataGridViewTextBoxColumn.ReadOnly = True
        Me.NDIDataGridViewTextBoxColumn.Width = 51
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombresDataGridViewTextBoxColumn.Width = 74
        '
        'ApellidoPaternoDataGridViewTextBoxColumn
        '
        Me.ApellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPaterno"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoPaterno"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.Name = "ApellidoPaternoDataGridViewTextBoxColumn"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidoPaternoDataGridViewTextBoxColumn.Width = 106
        '
        'ApellidoMaternoDataGridViewTextBoxColumn
        '
        Me.ApellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMaterno"
        Me.ApellidoMaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoMaterno"
        Me.ApellidoMaternoDataGridViewTextBoxColumn.Name = "ApellidoMaternoDataGridViewTextBoxColumn"
        Me.ApellidoMaternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidoMaternoDataGridViewTextBoxColumn.Width = 108
        '
        'NacionalidadDataGridViewTextBoxColumn
        '
        Me.NacionalidadDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidad"
        Me.NacionalidadDataGridViewTextBoxColumn.HeaderText = "Nacionalidad"
        Me.NacionalidadDataGridViewTextBoxColumn.Name = "NacionalidadDataGridViewTextBoxColumn"
        Me.NacionalidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.NacionalidadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NacionalidadDataGridViewTextBoxColumn.Visible = False
        Me.NacionalidadDataGridViewTextBoxColumn.Width = 94
        '
        'MotoIDDataGridViewTextBoxColumn
        '
        Me.MotoIDDataGridViewTextBoxColumn.DataPropertyName = "MotoID"
        Me.MotoIDDataGridViewTextBoxColumn.HeaderText = "MotoID"
        Me.MotoIDDataGridViewTextBoxColumn.Name = "MotoIDDataGridViewTextBoxColumn"
        Me.MotoIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MotoIDDataGridViewTextBoxColumn.Visible = False
        Me.MotoIDDataGridViewTextBoxColumn.Width = 67
        '
        'PlacaDataGridViewTextBoxColumn
        '
        Me.PlacaDataGridViewTextBoxColumn.DataPropertyName = "Placa"
        Me.PlacaDataGridViewTextBoxColumn.HeaderText = "Placa"
        Me.PlacaDataGridViewTextBoxColumn.Name = "PlacaDataGridViewTextBoxColumn"
        Me.PlacaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PlacaDataGridViewTextBoxColumn.Width = 59
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ColorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColorDataGridViewTextBoxColumn.Width = 56
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TipoDataGridViewTextBoxColumn.Visible = False
        Me.TipoDataGridViewTextBoxColumn.Width = 53
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Width = 67
        '
        'DetalleDataGridViewTextBoxColumn
        '
        Me.DetalleDataGridViewTextBoxColumn.DataPropertyName = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.HeaderText = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.Name = "DetalleDataGridViewTextBoxColumn"
        Me.DetalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DetalleDataGridViewTextBoxColumn.Visible = False
        Me.DetalleDataGridViewTextBoxColumn.Width = 65
        '
        'TipoMotoDataGridViewTextBoxColumn
        '
        Me.TipoMotoDataGridViewTextBoxColumn.DataPropertyName = "TipoMoto"
        Me.TipoMotoDataGridViewTextBoxColumn.HeaderText = "TipoMoto"
        Me.TipoMotoDataGridViewTextBoxColumn.Name = "TipoMotoDataGridViewTextBoxColumn"
        Me.TipoMotoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoMotoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TipoMotoDataGridViewTextBoxColumn.Visible = False
        Me.TipoMotoDataGridViewTextBoxColumn.Width = 77
        '
        'IndiceAlquieres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 418)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.txtTotalIngreso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.IndiceRegistrosAlquileres)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IndiceAlquieres"
        Me.Text = "IndiceAlquieres"
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndiceRegistrosAlquileres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Bd1 As cmpAlquileres.BD
    Friend WithEvents IndiceRegistrosAlquileres As DataGridView
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtTotalIngreso As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents AlquilerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraFinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadHorasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NDIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPaternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMaternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NacionalidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlacaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoMotoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
