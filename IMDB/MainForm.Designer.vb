<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.uxgrd = New System.Windows.Forms.DataGridView()
        Me.uxColumnVer = New System.Windows.Forms.DataGridViewImageColumn()
        Me.uxColumnFilename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uxColumnInfo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.uxColumnRuta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uxColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uxColumnFind = New System.Windows.Forms.DataGridViewImageColumn()
        Me.uxColumnSub = New System.Windows.Forms.DataGridViewImageColumn()
        Me.uxColumnImdb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uxColumnImdbGo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.uxColumnRating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uxColumnRatingCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uxMenuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.uxMenuFormatearNombres = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuFormatearNombresSeleccionados = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuFormatearNombresTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuActualizarInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuActualizarInfoSeleccionados = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuActualizarInfoTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuImportarOMDB = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuImportarOMDBSeleccionados = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxMenuImportarOMDBTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.fbDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.uxpnlAbajo = New System.Windows.Forms.Panel()
        Me.uxbntChange = New System.Windows.Forms.Button()
        Me.uxcmbPath = New System.Windows.Forms.ComboBox()
        Me.uxbtnVerDirectorio = New System.Windows.Forms.Button()
        Me.uxlblRegistros = New System.Windows.Forms.Label()
        Me.uxbtnRefresh = New System.Windows.Forms.Button()
        Me.uxpnlGrid = New System.Windows.Forms.Panel()
        Me.uxpnlArriba = New System.Windows.Forms.Panel()
        Me.uxbtnBorrarTexto = New System.Windows.Forms.Button()
        Me.uxtxtBuscar = New System.Windows.Forms.TextBox()
        Me.uxchkVerMRU = New System.Windows.Forms.CheckBox()
        Me.uxchkVerTodo = New System.Windows.Forms.CheckBox()
        Me.uxchkPendientesIMDB = New System.Windows.Forms.CheckBox()
        Me.uxchkDuplicados = New System.Windows.Forms.CheckBox()
        Me.uxbtnConfiguracion = New System.Windows.Forms.Button()
        Me.uxbtnXML = New System.Windows.Forms.Button()
        Me.uxToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.uxError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.uxchkPendientesOMDB = New System.Windows.Forms.CheckBox()
        CType(Me.uxgrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uxMenuGrid.SuspendLayout()
        Me.uxpnlAbajo.SuspendLayout()
        Me.uxpnlGrid.SuspendLayout()
        Me.uxpnlArriba.SuspendLayout()
        CType(Me.uxError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uxgrd
        '
        Me.uxgrd.AllowUserToAddRows = False
        Me.uxgrd.AllowUserToDeleteRows = False
        Me.uxgrd.AllowUserToResizeRows = False
        Me.uxgrd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.uxColumnVer, Me.uxColumnFilename, Me.uxColumnInfo, Me.uxColumnRuta, Me.uxColumnName, Me.uxColumnFind, Me.uxColumnSub, Me.uxColumnImdb, Me.uxColumnImdbGo, Me.uxColumnRating, Me.uxColumnRatingCount})
        Me.uxgrd.ContextMenuStrip = Me.uxMenuGrid
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.uxgrd.DefaultCellStyle = DataGridViewCellStyle3
        Me.uxgrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uxgrd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.uxgrd.Location = New System.Drawing.Point(0, 0)
        Me.uxgrd.Name = "uxgrd"
        Me.uxgrd.RowHeadersWidth = 20
        Me.uxgrd.Size = New System.Drawing.Size(1024, 599)
        Me.uxgrd.TabIndex = 0
        Me.uxgrd.VirtualMode = True
        '
        'uxColumnVer
        '
        Me.uxColumnVer.HeaderText = "Ver"
        Me.uxColumnVer.Image = CType(resources.GetObject("uxColumnVer.Image"), System.Drawing.Image)
        Me.uxColumnVer.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.uxColumnVer.Name = "uxColumnVer"
        Me.uxColumnVer.ReadOnly = True
        Me.uxColumnVer.Width = 29
        '
        'uxColumnFilename
        '
        Me.uxColumnFilename.DataPropertyName = "filename"
        Me.uxColumnFilename.HeaderText = "Archivo"
        Me.uxColumnFilename.Name = "uxColumnFilename"
        Me.uxColumnFilename.ReadOnly = True
        Me.uxColumnFilename.Width = 350
        '
        'uxColumnInfo
        '
        Me.uxColumnInfo.HeaderText = "Info"
        Me.uxColumnInfo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.uxColumnInfo.Name = "uxColumnInfo"
        Me.uxColumnInfo.ReadOnly = True
        Me.uxColumnInfo.Width = 29
        '
        'uxColumnRuta
        '
        Me.uxColumnRuta.DataPropertyName = "ruta"
        Me.uxColumnRuta.HeaderText = "Ruta"
        Me.uxColumnRuta.Name = "uxColumnRuta"
        Me.uxColumnRuta.ReadOnly = True
        Me.uxColumnRuta.Width = 150
        '
        'uxColumnName
        '
        Me.uxColumnName.DataPropertyName = "name"
        Me.uxColumnName.HeaderText = "Nombre"
        Me.uxColumnName.Name = "uxColumnName"
        Me.uxColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.uxColumnName.Width = 180
        '
        'uxColumnFind
        '
        Me.uxColumnFind.HeaderText = ""
        Me.uxColumnFind.Image = CType(resources.GetObject("uxColumnFind.Image"), System.Drawing.Image)
        Me.uxColumnFind.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.uxColumnFind.Name = "uxColumnFind"
        Me.uxColumnFind.ReadOnly = True
        Me.uxColumnFind.Width = 29
        '
        'uxColumnSub
        '
        Me.uxColumnSub.HeaderText = "Sub"
        Me.uxColumnSub.Image = CType(resources.GetObject("uxColumnSub.Image"), System.Drawing.Image)
        Me.uxColumnSub.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.uxColumnSub.Name = "uxColumnSub"
        Me.uxColumnSub.ReadOnly = True
        Me.uxColumnSub.Width = 29
        '
        'uxColumnImdb
        '
        Me.uxColumnImdb.DataPropertyName = "imdb_id"
        Me.uxColumnImdb.HeaderText = "Imdb"
        Me.uxColumnImdb.Name = "uxColumnImdb"
        Me.uxColumnImdb.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.uxColumnImdb.Width = 60
        '
        'uxColumnImdbGo
        '
        Me.uxColumnImdbGo.HeaderText = ""
        Me.uxColumnImdbGo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.uxColumnImdbGo.Name = "uxColumnImdbGo"
        Me.uxColumnImdbGo.ReadOnly = True
        Me.uxColumnImdbGo.Width = 29
        '
        'uxColumnRating
        '
        Me.uxColumnRating.DataPropertyName = "imdb_rating"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.uxColumnRating.DefaultCellStyle = DataGridViewCellStyle1
        Me.uxColumnRating.HeaderText = "Rating"
        Me.uxColumnRating.Name = "uxColumnRating"
        Me.uxColumnRating.ReadOnly = True
        Me.uxColumnRating.Width = 40
        '
        'uxColumnRatingCount
        '
        Me.uxColumnRatingCount.DataPropertyName = "imdb_ratingcount"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.uxColumnRatingCount.DefaultCellStyle = DataGridViewCellStyle2
        Me.uxColumnRatingCount.HeaderText = "R.Count"
        Me.uxColumnRatingCount.Name = "uxColumnRatingCount"
        Me.uxColumnRatingCount.ReadOnly = True
        Me.uxColumnRatingCount.Width = 55
        '
        'uxMenuGrid
        '
        Me.uxMenuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uxMenuFormatearNombres, Me.uxMenuActualizarInfo, Me.uxMenuImportarOMDB})
        Me.uxMenuGrid.Name = "uxMenuGrid"
        Me.uxMenuGrid.Size = New System.Drawing.Size(179, 70)
        '
        'uxMenuFormatearNombres
        '
        Me.uxMenuFormatearNombres.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uxMenuFormatearNombresSeleccionados, Me.uxMenuFormatearNombresTodos})
        Me.uxMenuFormatearNombres.Name = "uxMenuFormatearNombres"
        Me.uxMenuFormatearNombres.Size = New System.Drawing.Size(178, 22)
        Me.uxMenuFormatearNombres.Text = "Formatear nombres"
        '
        'uxMenuFormatearNombresSeleccionados
        '
        Me.uxMenuFormatearNombresSeleccionados.Name = "uxMenuFormatearNombresSeleccionados"
        Me.uxMenuFormatearNombresSeleccionados.Size = New System.Drawing.Size(149, 22)
        Me.uxMenuFormatearNombresSeleccionados.Text = "Seleccionados"
        '
        'uxMenuFormatearNombresTodos
        '
        Me.uxMenuFormatearNombresTodos.Name = "uxMenuFormatearNombresTodos"
        Me.uxMenuFormatearNombresTodos.Size = New System.Drawing.Size(149, 22)
        Me.uxMenuFormatearNombresTodos.Text = "Todos"
        '
        'uxMenuActualizarInfo
        '
        Me.uxMenuActualizarInfo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uxMenuActualizarInfoSeleccionados, Me.uxMenuActualizarInfoTodos})
        Me.uxMenuActualizarInfo.Name = "uxMenuActualizarInfo"
        Me.uxMenuActualizarInfo.Size = New System.Drawing.Size(178, 22)
        Me.uxMenuActualizarInfo.Text = "Actualizar IMDB"
        '
        'uxMenuActualizarInfoSeleccionados
        '
        Me.uxMenuActualizarInfoSeleccionados.Name = "uxMenuActualizarInfoSeleccionados"
        Me.uxMenuActualizarInfoSeleccionados.Size = New System.Drawing.Size(149, 22)
        Me.uxMenuActualizarInfoSeleccionados.Text = "Seleccionados"
        '
        'uxMenuActualizarInfoTodos
        '
        Me.uxMenuActualizarInfoTodos.Name = "uxMenuActualizarInfoTodos"
        Me.uxMenuActualizarInfoTodos.Size = New System.Drawing.Size(149, 22)
        Me.uxMenuActualizarInfoTodos.Text = "Todos"
        '
        'uxMenuImportarOMDB
        '
        Me.uxMenuImportarOMDB.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uxMenuImportarOMDBSeleccionados, Me.uxMenuImportarOMDBTodos})
        Me.uxMenuImportarOMDB.Name = "uxMenuImportarOMDB"
        Me.uxMenuImportarOMDB.Size = New System.Drawing.Size(178, 22)
        Me.uxMenuImportarOMDB.Text = "Importar OMDB"
        '
        'uxMenuImportarOMDBSeleccionados
        '
        Me.uxMenuImportarOMDBSeleccionados.Name = "uxMenuImportarOMDBSeleccionados"
        Me.uxMenuImportarOMDBSeleccionados.Size = New System.Drawing.Size(149, 22)
        Me.uxMenuImportarOMDBSeleccionados.Text = "Seleccionados"
        '
        'uxMenuImportarOMDBTodos
        '
        Me.uxMenuImportarOMDBTodos.Name = "uxMenuImportarOMDBTodos"
        Me.uxMenuImportarOMDBTodos.Size = New System.Drawing.Size(149, 22)
        Me.uxMenuImportarOMDBTodos.Text = "Todos"
        '
        'fbDialog
        '
        Me.fbDialog.ShowNewFolderButton = False
        '
        'uxpnlAbajo
        '
        Me.uxpnlAbajo.Controls.Add(Me.uxbntChange)
        Me.uxpnlAbajo.Controls.Add(Me.uxcmbPath)
        Me.uxpnlAbajo.Controls.Add(Me.uxbtnVerDirectorio)
        Me.uxpnlAbajo.Controls.Add(Me.uxlblRegistros)
        Me.uxpnlAbajo.Controls.Add(Me.uxbtnRefresh)
        Me.uxpnlAbajo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.uxpnlAbajo.Location = New System.Drawing.Point(0, 628)
        Me.uxpnlAbajo.Name = "uxpnlAbajo"
        Me.uxpnlAbajo.Size = New System.Drawing.Size(1024, 33)
        Me.uxpnlAbajo.TabIndex = 1
        '
        'uxbntChange
        '
        Me.uxbntChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.uxbntChange.Image = Global.IMDB.My.Resources.Resources.Home
        Me.uxbntChange.Location = New System.Drawing.Point(3, 4)
        Me.uxbntChange.Name = "uxbntChange"
        Me.uxbntChange.Size = New System.Drawing.Size(103, 27)
        Me.uxbntChange.TabIndex = 0
        Me.uxbntChange.Text = "Change dir"
        Me.uxbntChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.uxToolTip.SetToolTip(Me.uxbntChange, "Seleccionar otro directorio")
        Me.uxbntChange.UseVisualStyleBackColor = True
        '
        'uxcmbPath
        '
        Me.uxcmbPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxcmbPath.FormattingEnabled = True
        Me.uxcmbPath.Location = New System.Drawing.Point(112, 8)
        Me.uxcmbPath.Name = "uxcmbPath"
        Me.uxcmbPath.Size = New System.Drawing.Size(502, 21)
        Me.uxcmbPath.TabIndex = 1
        '
        'uxbtnVerDirectorio
        '
        Me.uxbtnVerDirectorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxbtnVerDirectorio.Image = Global.IMDB.My.Resources.Resources.carpeta
        Me.uxbtnVerDirectorio.Location = New System.Drawing.Point(620, 6)
        Me.uxbtnVerDirectorio.Name = "uxbtnVerDirectorio"
        Me.uxbtnVerDirectorio.Size = New System.Drawing.Size(23, 23)
        Me.uxbtnVerDirectorio.TabIndex = 2
        Me.uxToolTip.SetToolTip(Me.uxbtnVerDirectorio, "Abrir la carpeta indicada")
        Me.uxbtnVerDirectorio.UseVisualStyleBackColor = True
        '
        'uxlblRegistros
        '
        Me.uxlblRegistros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxlblRegistros.Location = New System.Drawing.Point(649, 11)
        Me.uxlblRegistros.Name = "uxlblRegistros"
        Me.uxlblRegistros.Size = New System.Drawing.Size(291, 13)
        Me.uxlblRegistros.TabIndex = 3
        Me.uxlblRegistros.Text = "Registros:"
        '
        'uxbtnRefresh
        '
        Me.uxbtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxbtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.uxbtnRefresh.Image = Global.IMDB.My.Resources.Resources.refresca
        Me.uxbtnRefresh.Location = New System.Drawing.Point(946, 4)
        Me.uxbtnRefresh.Name = "uxbtnRefresh"
        Me.uxbtnRefresh.Size = New System.Drawing.Size(75, 27)
        Me.uxbtnRefresh.TabIndex = 4
        Me.uxbtnRefresh.Text = "Refresh"
        Me.uxbtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.uxbtnRefresh.UseVisualStyleBackColor = True
        '
        'uxpnlGrid
        '
        Me.uxpnlGrid.Controls.Add(Me.uxgrd)
        Me.uxpnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uxpnlGrid.Location = New System.Drawing.Point(0, 29)
        Me.uxpnlGrid.Name = "uxpnlGrid"
        Me.uxpnlGrid.Size = New System.Drawing.Size(1024, 599)
        Me.uxpnlGrid.TabIndex = 2
        '
        'uxpnlArriba
        '
        Me.uxpnlArriba.Controls.Add(Me.uxchkPendientesOMDB)
        Me.uxpnlArriba.Controls.Add(Me.uxbtnBorrarTexto)
        Me.uxpnlArriba.Controls.Add(Me.uxtxtBuscar)
        Me.uxpnlArriba.Controls.Add(Me.uxchkVerMRU)
        Me.uxpnlArriba.Controls.Add(Me.uxchkVerTodo)
        Me.uxpnlArriba.Controls.Add(Me.uxchkPendientesIMDB)
        Me.uxpnlArriba.Controls.Add(Me.uxchkDuplicados)
        Me.uxpnlArriba.Controls.Add(Me.uxbtnConfiguracion)
        Me.uxpnlArriba.Controls.Add(Me.uxbtnXML)
        Me.uxpnlArriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.uxpnlArriba.Location = New System.Drawing.Point(0, 0)
        Me.uxpnlArriba.Name = "uxpnlArriba"
        Me.uxpnlArriba.Size = New System.Drawing.Size(1024, 29)
        Me.uxpnlArriba.TabIndex = 0
        '
        'uxbtnBorrarTexto
        '
        Me.uxbtnBorrarTexto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxbtnBorrarTexto.Image = Global.IMDB.My.Resources.Resources.close
        Me.uxbtnBorrarTexto.Location = New System.Drawing.Point(549, 2)
        Me.uxbtnBorrarTexto.Name = "uxbtnBorrarTexto"
        Me.uxbtnBorrarTexto.Size = New System.Drawing.Size(23, 24)
        Me.uxbtnBorrarTexto.TabIndex = 7
        Me.uxToolTip.SetToolTip(Me.uxbtnBorrarTexto, "Configurar")
        Me.uxbtnBorrarTexto.UseVisualStyleBackColor = True
        '
        'uxtxtBuscar
        '
        Me.uxtxtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxtxtBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uxtxtBuscar.Location = New System.Drawing.Point(3, 3)
        Me.uxtxtBuscar.Name = "uxtxtBuscar"
        Me.uxtxtBuscar.Size = New System.Drawing.Size(546, 22)
        Me.uxtxtBuscar.TabIndex = 0
        '
        'uxchkVerMRU
        '
        Me.uxchkVerMRU.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxchkVerMRU.AutoSize = True
        Me.uxchkVerMRU.Location = New System.Drawing.Point(591, 7)
        Me.uxchkVerMRU.Name = "uxchkVerMRU"
        Me.uxchkVerMRU.Size = New System.Drawing.Size(51, 17)
        Me.uxchkVerMRU.TabIndex = 1
        Me.uxchkVerMRU.Text = "MRU"
        Me.uxchkVerMRU.UseVisualStyleBackColor = True
        '
        'uxchkVerTodo
        '
        Me.uxchkVerTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxchkVerTodo.AutoSize = True
        Me.uxchkVerTodo.Location = New System.Drawing.Point(648, 7)
        Me.uxchkVerTodo.Name = "uxchkVerTodo"
        Me.uxchkVerTodo.Size = New System.Drawing.Size(51, 17)
        Me.uxchkVerTodo.TabIndex = 2
        Me.uxchkVerTodo.Text = "Todo"
        Me.uxchkVerTodo.UseVisualStyleBackColor = True
        '
        'uxchkPendientesIMDB
        '
        Me.uxchkPendientesIMDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxchkPendientesIMDB.AutoSize = True
        Me.uxchkPendientesIMDB.Location = New System.Drawing.Point(700, 7)
        Me.uxchkPendientesIMDB.Name = "uxchkPendientesIMDB"
        Me.uxchkPendientesIMDB.Size = New System.Drawing.Size(84, 17)
        Me.uxchkPendientesIMDB.TabIndex = 3
        Me.uxchkPendientesIMDB.Text = "Pend. IMDB"
        Me.uxchkPendientesIMDB.ThreeState = True
        Me.uxToolTip.SetToolTip(Me.uxchkPendientesIMDB, "Visualizar los ficheros duplicados")
        Me.uxchkPendientesIMDB.UseVisualStyleBackColor = True
        '
        'uxchkDuplicados
        '
        Me.uxchkDuplicados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxchkDuplicados.AutoSize = True
        Me.uxchkDuplicados.Location = New System.Drawing.Point(884, 7)
        Me.uxchkDuplicados.Name = "uxchkDuplicados"
        Me.uxchkDuplicados.Size = New System.Drawing.Size(79, 17)
        Me.uxchkDuplicados.TabIndex = 4
        Me.uxchkDuplicados.Text = "Duplicados"
        Me.uxToolTip.SetToolTip(Me.uxchkDuplicados, "Ver los ficheros con nombre duplicado")
        Me.uxchkDuplicados.UseVisualStyleBackColor = True
        '
        'uxbtnConfiguracion
        '
        Me.uxbtnConfiguracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxbtnConfiguracion.Image = Global.IMDB.My.Resources.Resources.refresca
        Me.uxbtnConfiguracion.Location = New System.Drawing.Point(969, 3)
        Me.uxbtnConfiguracion.Name = "uxbtnConfiguracion"
        Me.uxbtnConfiguracion.Size = New System.Drawing.Size(23, 23)
        Me.uxbtnConfiguracion.TabIndex = 5
        Me.uxToolTip.SetToolTip(Me.uxbtnConfiguracion, "Configurar")
        Me.uxbtnConfiguracion.UseVisualStyleBackColor = True
        '
        'uxbtnXML
        '
        Me.uxbtnXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxbtnXML.Image = Global.IMDB.My.Resources.Resources.xml
        Me.uxbtnXML.Location = New System.Drawing.Point(998, 3)
        Me.uxbtnXML.Name = "uxbtnXML"
        Me.uxbtnXML.Size = New System.Drawing.Size(23, 23)
        Me.uxbtnXML.TabIndex = 6
        Me.uxToolTip.SetToolTip(Me.uxbtnXML, "Gestión de fichero XML")
        Me.uxbtnXML.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Busca"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 40
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Sub"
        Me.DataGridViewImageColumn2.Image = Global.IMDB.My.Resources.Resources.subs
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 35
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "Sub"
        Me.DataGridViewImageColumn3.Image = Global.IMDB.My.Resources.Resources.subs
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Width = 35
        '
        'uxError
        '
        Me.uxError.ContainerControl = Me
        '
        'uxchkPendientesOMDB
        '
        Me.uxchkPendientesOMDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxchkPendientesOMDB.AutoSize = True
        Me.uxchkPendientesOMDB.Location = New System.Drawing.Point(789, 7)
        Me.uxchkPendientesOMDB.Name = "uxchkPendientesOMDB"
        Me.uxchkPendientesOMDB.Size = New System.Drawing.Size(89, 17)
        Me.uxchkPendientesOMDB.TabIndex = 8
        Me.uxchkPendientesOMDB.Text = "Pend. OMDB"
        Me.uxchkPendientesOMDB.ThreeState = True
        Me.uxToolTip.SetToolTip(Me.uxchkPendientesOMDB, "Visualizar los ficheros duplicados")
        Me.uxchkPendientesOMDB.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 661)
        Me.Controls.Add(Me.uxpnlGrid)
        Me.Controls.Add(Me.uxpnlArriba)
        Me.Controls.Add(Me.uxpnlAbajo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "IMDB"
        CType(Me.uxgrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uxMenuGrid.ResumeLayout(False)
        Me.uxpnlAbajo.ResumeLayout(False)
        Me.uxpnlGrid.ResumeLayout(False)
        Me.uxpnlArriba.ResumeLayout(False)
        Me.uxpnlArriba.PerformLayout()
        CType(Me.uxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents uxgrd As System.Windows.Forms.DataGridView
    Friend WithEvents fbDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents uxpnlAbajo As System.Windows.Forms.Panel
    Friend WithEvents uxbtnRefresh As System.Windows.Forms.Button
    Friend WithEvents uxpnlGrid As System.Windows.Forms.Panel
    Friend WithEvents uxbntChange As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents uxlblRegistros As System.Windows.Forms.Label
    Friend WithEvents uxpnlArriba As System.Windows.Forms.Panel
    Friend WithEvents uxchkDuplicados As System.Windows.Forms.CheckBox
    Friend WithEvents uxbtnConfiguracion As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents uxtxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents uxcmbPath As System.Windows.Forms.ComboBox
    Friend WithEvents uxbtnVerDirectorio As System.Windows.Forms.Button
    Friend WithEvents uxToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents uxbtnXML As System.Windows.Forms.Button
    Friend WithEvents uxchkPendientesIMDB As System.Windows.Forms.CheckBox
    Friend WithEvents uxchkVerTodo As System.Windows.Forms.CheckBox
    Friend WithEvents uxchkVerMRU As System.Windows.Forms.CheckBox
    Friend WithEvents uxMenuGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents uxMenuFormatearNombres As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uxbtnBorrarTexto As System.Windows.Forms.Button
    Friend WithEvents uxError As System.Windows.Forms.ErrorProvider
    Friend WithEvents uxMenuActualizarInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uxMenuFormatearNombresSeleccionados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uxMenuFormatearNombresTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uxMenuActualizarInfoSeleccionados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uxMenuActualizarInfoTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uxMenuImportarOMDB As ToolStripMenuItem
    Friend WithEvents uxMenuImportarOMDBSeleccionados As ToolStripMenuItem
    Friend WithEvents uxMenuImportarOMDBTodos As ToolStripMenuItem
    Friend WithEvents uxColumnVer As DataGridViewImageColumn
    Friend WithEvents uxColumnFilename As DataGridViewTextBoxColumn
    Friend WithEvents uxColumnInfo As DataGridViewImageColumn
    Friend WithEvents uxColumnRuta As DataGridViewTextBoxColumn
    Friend WithEvents uxColumnName As DataGridViewTextBoxColumn
    Friend WithEvents uxColumnFind As DataGridViewImageColumn
    Friend WithEvents uxColumnSub As DataGridViewImageColumn
    Friend WithEvents uxColumnImdb As DataGridViewTextBoxColumn
    Friend WithEvents uxColumnImdbGo As DataGridViewImageColumn
    Friend WithEvents uxColumnRating As DataGridViewTextBoxColumn
    Friend WithEvents uxColumnRatingCount As DataGridViewTextBoxColumn
    Friend WithEvents uxchkPendientesOMDB As CheckBox
End Class
