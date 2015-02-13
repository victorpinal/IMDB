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
    	Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    	Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
    	Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    	Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    	Me.uxgrd = New System.Windows.Forms.DataGridView()
    	Me.uxMenuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
    	Me.uxMenuFormatearNombres = New System.Windows.Forms.ToolStripMenuItem()
    	Me.uxMenuFormatearNombresSeleccionados = New System.Windows.Forms.ToolStripMenuItem()
    	Me.uxMenuFormatearNombresTodos = New System.Windows.Forms.ToolStripMenuItem()
    	Me.uxMenuActualizarInfo = New System.Windows.Forms.ToolStripMenuItem()
    	Me.uxMenuActualizarInfoSeleccionados = New System.Windows.Forms.ToolStripMenuItem()
    	Me.uxMenuActualizarInfoTodos = New System.Windows.Forms.ToolStripMenuItem()
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
    	Me.uxchkPendientes = New System.Windows.Forms.CheckBox()
    	Me.uxchkDuplicados = New System.Windows.Forms.CheckBox()
    	Me.uxbtnConfiguracion = New System.Windows.Forms.Button()
    	Me.uxbtnXML = New System.Windows.Forms.Button()
    	Me.uxToolTip = New System.Windows.Forms.ToolTip(Me.components)
    	Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
    	Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
    	Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
    	Me.uxError = New System.Windows.Forms.ErrorProvider(Me.components)
    	Me.uxColumnVer = New System.Windows.Forms.DataGridViewImageColumn()
    	Me.uxColumnId = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.uxColumnRuta = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.uxColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.uxColumnFind = New System.Windows.Forms.DataGridViewImageColumn()
    	Me.uxColumnSub = New System.Windows.Forms.DataGridViewImageColumn()
    	Me.uxColumnLink = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.uxColumnGo = New System.Windows.Forms.DataGridViewImageColumn()
    	Me.uxColumnRating = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	Me.uxColumnRatingCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
    	CType(Me.uxgrd,System.ComponentModel.ISupportInitialize).BeginInit
    	Me.uxMenuGrid.SuspendLayout
    	Me.uxpnlAbajo.SuspendLayout
    	Me.uxpnlGrid.SuspendLayout
    	Me.uxpnlArriba.SuspendLayout
    	CType(Me.uxError,System.ComponentModel.ISupportInitialize).BeginInit
    	Me.SuspendLayout
    	'
    	'uxgrd
    	'
    	Me.uxgrd.AllowUserToAddRows = false
    	Me.uxgrd.AllowUserToDeleteRows = false
    	Me.uxgrd.AllowUserToResizeRows = false
    	Me.uxgrd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.uxColumnVer, Me.uxColumnId, Me.uxColumnRuta, Me.uxColumnName, Me.uxColumnFind, Me.uxColumnSub, Me.uxColumnLink, Me.uxColumnGo, Me.uxColumnRating, Me.uxColumnRatingCount})
    	Me.uxgrd.ContextMenuStrip = Me.uxMenuGrid
    	dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    	dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
    	dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
    	dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
    	dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    	dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    	Me.uxgrd.DefaultCellStyle = dataGridViewCellStyle3
    	Me.uxgrd.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.uxgrd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
    	Me.uxgrd.Location = New System.Drawing.Point(0, 0)
    	Me.uxgrd.Name = "uxgrd"
    	Me.uxgrd.RowHeadersWidth = 20
    	Me.uxgrd.Size = New System.Drawing.Size(1008, 599)
    	Me.uxgrd.TabIndex = 0
    	Me.uxgrd.VirtualMode = true
    	'
    	'uxMenuGrid
    	'
    	Me.uxMenuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uxMenuFormatearNombres, Me.uxMenuActualizarInfo})
    	Me.uxMenuGrid.Name = "uxMenuGrid"
    	Me.uxMenuGrid.Size = New System.Drawing.Size(179, 48)
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
    	Me.uxMenuActualizarInfo.Text = "Actualizar Info"
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
    	'fbDialog
    	'
    	Me.fbDialog.ShowNewFolderButton = false
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
    	Me.uxpnlAbajo.Size = New System.Drawing.Size(1008, 33)
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
    	Me.uxbntChange.UseVisualStyleBackColor = true
    	'
    	'uxcmbPath
    	'
    	Me.uxcmbPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
    	    	    	Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.uxcmbPath.FormattingEnabled = true
    	Me.uxcmbPath.Location = New System.Drawing.Point(112, 8)
    	Me.uxcmbPath.Name = "uxcmbPath"
    	Me.uxcmbPath.Size = New System.Drawing.Size(486, 21)
    	Me.uxcmbPath.TabIndex = 1
    	'
    	'uxbtnVerDirectorio
    	'
    	Me.uxbtnVerDirectorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.uxbtnVerDirectorio.Image = Global.IMDB.My.Resources.Resources.carpeta
    	Me.uxbtnVerDirectorio.Location = New System.Drawing.Point(604, 6)
    	Me.uxbtnVerDirectorio.Name = "uxbtnVerDirectorio"
    	Me.uxbtnVerDirectorio.Size = New System.Drawing.Size(23, 23)
    	Me.uxbtnVerDirectorio.TabIndex = 2
    	Me.uxToolTip.SetToolTip(Me.uxbtnVerDirectorio, "Abrir la carpeta indicada")
    	Me.uxbtnVerDirectorio.UseVisualStyleBackColor = true
    	'
    	'uxlblRegistros
    	'
    	Me.uxlblRegistros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.uxlblRegistros.Location = New System.Drawing.Point(633, 11)
    	Me.uxlblRegistros.Name = "uxlblRegistros"
    	Me.uxlblRegistros.Size = New System.Drawing.Size(291, 13)
    	Me.uxlblRegistros.TabIndex = 3
    	Me.uxlblRegistros.Text = "Registros:"
    	'
    	'uxbtnRefresh
    	'
    	Me.uxbtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.uxbtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    	Me.uxbtnRefresh.Image = Global.IMDB.My.Resources.Resources.refresca
    	Me.uxbtnRefresh.Location = New System.Drawing.Point(930, 4)
    	Me.uxbtnRefresh.Name = "uxbtnRefresh"
    	Me.uxbtnRefresh.Size = New System.Drawing.Size(75, 27)
    	Me.uxbtnRefresh.TabIndex = 4
    	Me.uxbtnRefresh.Text = "Refresh"
    	Me.uxbtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    	Me.uxbtnRefresh.UseVisualStyleBackColor = true
    	'
    	'uxpnlGrid
    	'
    	Me.uxpnlGrid.Controls.Add(Me.uxgrd)
    	Me.uxpnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.uxpnlGrid.Location = New System.Drawing.Point(0, 29)
    	Me.uxpnlGrid.Name = "uxpnlGrid"
    	Me.uxpnlGrid.Size = New System.Drawing.Size(1008, 599)
    	Me.uxpnlGrid.TabIndex = 2
    	'
    	'uxpnlArriba
    	'
    	Me.uxpnlArriba.Controls.Add(Me.uxbtnBorrarTexto)
    	Me.uxpnlArriba.Controls.Add(Me.uxtxtBuscar)
    	Me.uxpnlArriba.Controls.Add(Me.uxchkVerMRU)
    	Me.uxpnlArriba.Controls.Add(Me.uxchkVerTodo)
    	Me.uxpnlArriba.Controls.Add(Me.uxchkPendientes)
    	Me.uxpnlArriba.Controls.Add(Me.uxchkDuplicados)
    	Me.uxpnlArriba.Controls.Add(Me.uxbtnConfiguracion)
    	Me.uxpnlArriba.Controls.Add(Me.uxbtnXML)
    	Me.uxpnlArriba.Dock = System.Windows.Forms.DockStyle.Top
    	Me.uxpnlArriba.Location = New System.Drawing.Point(0, 0)
    	Me.uxpnlArriba.Name = "uxpnlArriba"
    	Me.uxpnlArriba.Size = New System.Drawing.Size(1008, 29)
    	Me.uxpnlArriba.TabIndex = 0
    	'
    	'uxbtnBorrarTexto
    	'
    	Me.uxbtnBorrarTexto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.uxbtnBorrarTexto.Image = Global.IMDB.My.Resources.Resources.close
    	Me.uxbtnBorrarTexto.Location = New System.Drawing.Point(630, 2)
    	Me.uxbtnBorrarTexto.Name = "uxbtnBorrarTexto"
    	Me.uxbtnBorrarTexto.Size = New System.Drawing.Size(23, 24)
    	Me.uxbtnBorrarTexto.TabIndex = 7
    	Me.uxToolTip.SetToolTip(Me.uxbtnBorrarTexto, "Configurar")
    	Me.uxbtnBorrarTexto.UseVisualStyleBackColor = true
    	'
    	'uxtxtBuscar
    	'
    	Me.uxtxtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
    	    	    	Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.uxtxtBuscar.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    	Me.uxtxtBuscar.Location = New System.Drawing.Point(3, 3)
    	Me.uxtxtBuscar.Name = "uxtxtBuscar"
    	Me.uxtxtBuscar.Size = New System.Drawing.Size(627, 22)
    	Me.uxtxtBuscar.TabIndex = 0
    	'
    	'uxchkVerMRU
    	'
    	Me.uxchkVerMRU.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.uxchkVerMRU.AutoSize = true
    	Me.uxchkVerMRU.Location = New System.Drawing.Point(669, 7)
    	Me.uxchkVerMRU.Name = "uxchkVerMRU"
    	Me.uxchkVerMRU.Size = New System.Drawing.Size(51, 17)
    	Me.uxchkVerMRU.TabIndex = 1
    	Me.uxchkVerMRU.Text = "MRU"
    	Me.uxchkVerMRU.UseVisualStyleBackColor = true
    	'
    	'uxchkVerTodo
    	'
    	Me.uxchkVerTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.uxchkVerTodo.AutoSize = true
    	Me.uxchkVerTodo.Location = New System.Drawing.Point(726, 7)
    	Me.uxchkVerTodo.Name = "uxchkVerTodo"
    	Me.uxchkVerTodo.Size = New System.Drawing.Size(51, 17)
    	Me.uxchkVerTodo.TabIndex = 2
    	Me.uxchkVerTodo.Text = "Todo"
    	Me.uxchkVerTodo.UseVisualStyleBackColor = true
    	'
    	'uxchkPendientes
    	'
    	Me.uxchkPendientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.uxchkPendientes.AutoSize = true
    	Me.uxchkPendientes.Location = New System.Drawing.Point(783, 7)
    	Me.uxchkPendientes.Name = "uxchkPendientes"
    	Me.uxchkPendientes.Size = New System.Drawing.Size(79, 17)
    	Me.uxchkPendientes.TabIndex = 3
    	Me.uxchkPendientes.Text = "Pendientes"
    	Me.uxchkPendientes.ThreeState = true
    	Me.uxToolTip.SetToolTip(Me.uxchkPendientes, "Visualizar los ficheros duplicados")
    	Me.uxchkPendientes.UseVisualStyleBackColor = true
    	'
    	'uxchkDuplicados
    	'
    	Me.uxchkDuplicados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.uxchkDuplicados.AutoSize = true
    	Me.uxchkDuplicados.Location = New System.Drawing.Point(868, 7)
    	Me.uxchkDuplicados.Name = "uxchkDuplicados"
    	Me.uxchkDuplicados.Size = New System.Drawing.Size(79, 17)
    	Me.uxchkDuplicados.TabIndex = 4
    	Me.uxchkDuplicados.Text = "Duplicados"
    	Me.uxToolTip.SetToolTip(Me.uxchkDuplicados, "Ver los ficheros con nombre duplicado")
    	Me.uxchkDuplicados.UseVisualStyleBackColor = true
    	'
    	'uxbtnConfiguracion
    	'
    	Me.uxbtnConfiguracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.uxbtnConfiguracion.Image = Global.IMDB.My.Resources.Resources.refresca
    	Me.uxbtnConfiguracion.Location = New System.Drawing.Point(953, 3)
    	Me.uxbtnConfiguracion.Name = "uxbtnConfiguracion"
    	Me.uxbtnConfiguracion.Size = New System.Drawing.Size(23, 23)
    	Me.uxbtnConfiguracion.TabIndex = 5
    	Me.uxToolTip.SetToolTip(Me.uxbtnConfiguracion, "Configurar")
    	Me.uxbtnConfiguracion.UseVisualStyleBackColor = true
    	'
    	'uxbtnXML
    	'
    	Me.uxbtnXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    	Me.uxbtnXML.Image = Global.IMDB.My.Resources.Resources.xml
    	Me.uxbtnXML.Location = New System.Drawing.Point(982, 3)
    	Me.uxbtnXML.Name = "uxbtnXML"
    	Me.uxbtnXML.Size = New System.Drawing.Size(23, 23)
    	Me.uxbtnXML.TabIndex = 6
    	Me.uxToolTip.SetToolTip(Me.uxbtnXML, "Gestión de fichero XML")
    	Me.uxbtnXML.UseVisualStyleBackColor = true
    	'
    	'DataGridViewImageColumn1
    	'
    	Me.DataGridViewImageColumn1.HeaderText = "Busca"
    	Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"),System.Drawing.Image)
    	Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
    	Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
    	Me.DataGridViewImageColumn1.ReadOnly = true
    	Me.DataGridViewImageColumn1.Width = 40
    	'
    	'DataGridViewImageColumn2
    	'
    	Me.DataGridViewImageColumn2.HeaderText = "Sub"
    	Me.DataGridViewImageColumn2.Image = Global.IMDB.My.Resources.Resources.subs
    	Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
    	Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
    	Me.DataGridViewImageColumn2.ReadOnly = true
    	Me.DataGridViewImageColumn2.Width = 35
    	'
    	'DataGridViewImageColumn3
    	'
    	Me.DataGridViewImageColumn3.HeaderText = "Sub"
    	Me.DataGridViewImageColumn3.Image = Global.IMDB.My.Resources.Resources.subs
    	Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
    	Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
    	Me.DataGridViewImageColumn3.ReadOnly = true
    	Me.DataGridViewImageColumn3.Width = 35
    	'
    	'uxError
    	'
    	Me.uxError.ContainerControl = Me
    	'
    	'uxColumnVer
    	'
    	Me.uxColumnVer.HeaderText = "Ver"
    	Me.uxColumnVer.Image = CType(resources.GetObject("uxColumnVer.Image"),System.Drawing.Image)
    	Me.uxColumnVer.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
    	Me.uxColumnVer.Name = "uxColumnVer"
    	Me.uxColumnVer.ReadOnly = true
    	Me.uxColumnVer.Width = 29
    	'
    	'uxColumnId
    	'
    	Me.uxColumnId.DataPropertyName = "Id"
    	Me.uxColumnId.HeaderText = "Archivo"
    	Me.uxColumnId.Name = "uxColumnId"
    	Me.uxColumnId.ReadOnly = true
    	Me.uxColumnId.Width = 300
    	'
    	'uxColumnRuta
    	'
    	Me.uxColumnRuta.DataPropertyName = "Ruta"
    	Me.uxColumnRuta.HeaderText = "Ruta"
    	Me.uxColumnRuta.Name = "uxColumnRuta"
    	Me.uxColumnRuta.ReadOnly = true
    	Me.uxColumnRuta.Width = 150
    	'
    	'uxColumnName
    	'
    	Me.uxColumnName.DataPropertyName = "Name"
    	Me.uxColumnName.HeaderText = "Nombre"
    	Me.uxColumnName.Name = "uxColumnName"
    	Me.uxColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    	Me.uxColumnName.Width = 130
    	'
    	'uxColumnFind
    	'
    	Me.uxColumnFind.HeaderText = ""
    	Me.uxColumnFind.Image = CType(resources.GetObject("uxColumnFind.Image"),System.Drawing.Image)
    	Me.uxColumnFind.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
    	Me.uxColumnFind.Name = "uxColumnFind"
    	Me.uxColumnFind.ReadOnly = true
    	Me.uxColumnFind.Width = 29
    	'
    	'uxColumnSub
    	'
    	Me.uxColumnSub.HeaderText = "Sub"
    	Me.uxColumnSub.Image = CType(resources.GetObject("uxColumnSub.Image"),System.Drawing.Image)
    	Me.uxColumnSub.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
    	Me.uxColumnSub.Name = "uxColumnSub"
    	Me.uxColumnSub.ReadOnly = true
    	Me.uxColumnSub.Width = 29
    	'
    	'uxColumnLink
    	'
    	Me.uxColumnLink.DataPropertyName = "Link"
    	Me.uxColumnLink.HeaderText = "Link"
    	Me.uxColumnLink.Name = "uxColumnLink"
    	Me.uxColumnLink.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    	Me.uxColumnLink.Width = 195
    	'
    	'uxColumnGo
    	'
    	Me.uxColumnGo.HeaderText = "IMDB"
    	Me.uxColumnGo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
    	Me.uxColumnGo.Name = "uxColumnGo"
    	Me.uxColumnGo.ReadOnly = true
    	Me.uxColumnGo.Width = 29
    	'
    	'uxColumnRating
    	'
    	Me.uxColumnRating.DataPropertyName = "Rating"
    	dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    	dataGridViewCellStyle1.Format = "N2"
    	Me.uxColumnRating.DefaultCellStyle = dataGridViewCellStyle1
    	Me.uxColumnRating.HeaderText = "Rating"
    	Me.uxColumnRating.Name = "uxColumnRating"
    	Me.uxColumnRating.ReadOnly = true
    	Me.uxColumnRating.Width = 35
    	'
    	'uxColumnRatingCount
    	'
    	Me.uxColumnRatingCount.DataPropertyName = "RatingCount"
    	dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    	dataGridViewCellStyle2.Format = "N0"
    	dataGridViewCellStyle2.NullValue = Nothing
    	Me.uxColumnRatingCount.DefaultCellStyle = dataGridViewCellStyle2
    	Me.uxColumnRatingCount.HeaderText = "R.Count"
    	Me.uxColumnRatingCount.Name = "uxColumnRatingCount"
    	Me.uxColumnRatingCount.ReadOnly = true
    	Me.uxColumnRatingCount.Width = 50
    	'
    	'MainForm
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(1008, 661)
    	Me.Controls.Add(Me.uxpnlGrid)
    	Me.Controls.Add(Me.uxpnlArriba)
    	Me.Controls.Add(Me.uxpnlAbajo)
    	Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
    	Me.Name = "MainForm"
    	Me.Text = "IMDB"
    	CType(Me.uxgrd,System.ComponentModel.ISupportInitialize).EndInit
    	Me.uxMenuGrid.ResumeLayout(false)
    	Me.uxpnlAbajo.ResumeLayout(false)
    	Me.uxpnlGrid.ResumeLayout(false)
    	Me.uxpnlArriba.ResumeLayout(false)
    	Me.uxpnlArriba.PerformLayout
    	CType(Me.uxError,System.ComponentModel.ISupportInitialize).EndInit
    	Me.ResumeLayout(false)
    End Sub
    Private uxColumnRuta As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents uxchkPendientes As System.Windows.Forms.CheckBox
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
    Private uxColumnVer As System.Windows.Forms.DataGridViewImageColumn
    Private uxColumnId As System.Windows.Forms.DataGridViewTextBoxColumn
    Private uxColumnName As System.Windows.Forms.DataGridViewTextBoxColumn
    Private uxColumnFind As System.Windows.Forms.DataGridViewImageColumn
    Private uxColumnSub As System.Windows.Forms.DataGridViewImageColumn
    Private uxColumnLink As System.Windows.Forms.DataGridViewTextBoxColumn
    Private uxColumnGo As System.Windows.Forms.DataGridViewImageColumn
    Private uxColumnRating As System.Windows.Forms.DataGridViewTextBoxColumn
    Private uxColumnRatingCount As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
