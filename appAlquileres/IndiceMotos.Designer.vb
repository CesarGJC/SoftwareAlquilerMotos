<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IndiceMotos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IndiceMotos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtBuscadorMotos = New System.Windows.Forms.TextBox()
        Me.btnEditar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAgregar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnEliminar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Bd1 = New cmpAlquileres.BD()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foto = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.btnEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bd1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'txtBuscadorMotos
        '
        Me.txtBuscadorMotos.Location = New System.Drawing.Point(124, 22)
        Me.txtBuscadorMotos.Name = "txtBuscadorMotos"
        Me.txtBuscadorMotos.Size = New System.Drawing.Size(413, 20)
        Me.txtBuscadorMotos.TabIndex = 20
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageActive = Nothing
        Me.btnEditar.Location = New System.Drawing.Point(583, 12)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(30, 30)
        Me.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEditar.TabIndex = 24
        Me.btnEditar.TabStop = False
        Me.btnEditar.Zoom = 10
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageActive = Nothing
        Me.btnAgregar.Location = New System.Drawing.Point(547, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAgregar.TabIndex = 23
        Me.btnAgregar.TabStop = False
        Me.btnAgregar.Zoom = 10
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageActive = Nothing
        Me.btnEliminar.Location = New System.Drawing.Point(619, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(30, 30)
        Me.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEliminar.TabIndex = 22
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Zoom = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(37, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Consultar Moto:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ModeloDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.PlacaDataGridViewTextBoxColumn, Me.DetalleDataGridViewTextBoxColumn, Me.TarifaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.MotoIDDataGridViewTextBoxColumn, Me.Foto})
        Me.DataGridView1.DataMember = "VMotos"
        Me.DataGridView1.DataSource = Me.Bd1
        Me.DataGridView1.Location = New System.Drawing.Point(40, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(626, 331)
        Me.DataGridView1.TabIndex = 21
        '
        'Bd1
        '
        Me.Bd1.DataSetName = "BD"
        Me.Bd1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlacaDataGridViewTextBoxColumn
        '
        Me.PlacaDataGridViewTextBoxColumn.DataPropertyName = "Placa"
        Me.PlacaDataGridViewTextBoxColumn.HeaderText = "Placa"
        Me.PlacaDataGridViewTextBoxColumn.Name = "PlacaDataGridViewTextBoxColumn"
        Me.PlacaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetalleDataGridViewTextBoxColumn
        '
        Me.DetalleDataGridViewTextBoxColumn.DataPropertyName = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.HeaderText = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.Name = "DetalleDataGridViewTextBoxColumn"
        Me.DetalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TarifaDataGridViewTextBoxColumn
        '
        Me.TarifaDataGridViewTextBoxColumn.DataPropertyName = "Tarifa"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.TarifaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TarifaDataGridViewTextBoxColumn.HeaderText = "Tarifa"
        Me.TarifaDataGridViewTextBoxColumn.Name = "TarifaDataGridViewTextBoxColumn"
        Me.TarifaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EstadoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MotoIDDataGridViewTextBoxColumn
        '
        Me.MotoIDDataGridViewTextBoxColumn.DataPropertyName = "MotoID"
        Me.MotoIDDataGridViewTextBoxColumn.HeaderText = "MotoID"
        Me.MotoIDDataGridViewTextBoxColumn.Name = "MotoIDDataGridViewTextBoxColumn"
        Me.MotoIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MotoIDDataGridViewTextBoxColumn.Visible = False
        '
        'Foto
        '
        Me.Foto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Foto.DataPropertyName = "Foto"
        Me.Foto.HeaderText = "Foto"
        Me.Foto.Name = "Foto"
        Me.Foto.ReadOnly = True
        '
        'IndiceMotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(714, 429)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtBuscadorMotos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IndiceMotos"
        Me.Text = "IndiceMotos"
        CType(Me.btnEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtBuscadorMotos As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Bd1 As cmpAlquileres.BD
    Friend WithEvents btnEditar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAgregar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnEliminar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label2 As Label
    Friend WithEvents ModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlacaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TarifaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Foto As DataGridViewImageColumn
End Class
