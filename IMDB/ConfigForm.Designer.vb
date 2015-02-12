<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigForm
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
        Me.uxlblIMDB = New System.Windows.Forms.Label()
        Me.uxtxtIMDB = New System.Windows.Forms.TextBox()
        Me.uxbtnGuardar = New System.Windows.Forms.Button()
        Me.uxbtnSalir = New System.Windows.Forms.Button()
        Me.uxtxtSUBDIVX = New System.Windows.Forms.TextBox()
        Me.uxlblSUBDIVX = New System.Windows.Forms.Label()
        Me.uxError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.uxlblMRU = New System.Windows.Forms.Label()
        Me.uxlstDirectorios = New System.Windows.Forms.ListBox()
        Me.uxtxtListaPalabras = New System.Windows.Forms.TextBox()
        Me.uxlblListaPalabras = New System.Windows.Forms.Label()
        Me.uxtxtListaExtensiones = New System.Windows.Forms.TextBox()
        Me.uxlblListaExtensiones = New System.Windows.Forms.Label()
        Me.uxlblFicheroDatos = New System.Windows.Forms.Label()
        Me.uxtxtFicheroDatos = New System.Windows.Forms.TextBox()
        Me.uxbtnBuscarFichero = New System.Windows.Forms.Button()
        Me.uxSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        CType(Me.uxError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uxlblIMDB
        '
        Me.uxlblIMDB.AutoSize = True
        Me.uxlblIMDB.Location = New System.Drawing.Point(12, 48)
        Me.uxlblIMDB.Name = "uxlblIMDB"
        Me.uxlblIMDB.Size = New System.Drawing.Size(152, 13)
        Me.uxlblIMDB.TabIndex = 0
        Me.uxlblIMDB.Text = "Buscar en la página de (IMDB)"
        '
        'uxtxtIMDB
        '
        Me.uxtxtIMDB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxtxtIMDB.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uxtxtIMDB.Location = New System.Drawing.Point(15, 64)
        Me.uxtxtIMDB.Name = "uxtxtIMDB"
        Me.uxtxtIMDB.Size = New System.Drawing.Size(684, 20)
        Me.uxtxtIMDB.TabIndex = 1
        '
        'uxbtnGuardar
        '
        Me.uxbtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxbtnGuardar.Image = Global.IMDB.My.Resources.Resources.guarda
        Me.uxbtnGuardar.Location = New System.Drawing.Point(565, 477)
        Me.uxbtnGuardar.Name = "uxbtnGuardar"
        Me.uxbtnGuardar.Size = New System.Drawing.Size(70, 23)
        Me.uxbtnGuardar.TabIndex = 10
        Me.uxbtnGuardar.Text = "Guardar"
        Me.uxbtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.uxbtnGuardar.UseVisualStyleBackColor = True
        '
        'uxbtnSalir
        '
        Me.uxbtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxbtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.uxbtnSalir.Image = Global.IMDB.My.Resources.Resources.close
        Me.uxbtnSalir.Location = New System.Drawing.Point(641, 477)
        Me.uxbtnSalir.Name = "uxbtnSalir"
        Me.uxbtnSalir.Size = New System.Drawing.Size(58, 23)
        Me.uxbtnSalir.TabIndex = 11
        Me.uxbtnSalir.Text = "Salir"
        Me.uxbtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.uxbtnSalir.UseVisualStyleBackColor = True
        '
        'uxtxtSUBDIVX
        '
        Me.uxtxtSUBDIVX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxtxtSUBDIVX.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uxtxtSUBDIVX.Location = New System.Drawing.Point(16, 103)
        Me.uxtxtSUBDIVX.Name = "uxtxtSUBDIVX"
        Me.uxtxtSUBDIVX.Size = New System.Drawing.Size(684, 20)
        Me.uxtxtSUBDIVX.TabIndex = 3
        '
        'uxlblSUBDIVX
        '
        Me.uxlblSUBDIVX.AutoSize = True
        Me.uxlblSUBDIVX.Location = New System.Drawing.Point(13, 87)
        Me.uxlblSUBDIVX.Name = "uxlblSUBDIVX"
        Me.uxlblSUBDIVX.Size = New System.Drawing.Size(124, 13)
        Me.uxlblSUBDIVX.TabIndex = 2
        Me.uxlblSUBDIVX.Text = "Subtitulos en (SUBDIVX)"
        '
        'uxError
        '
        Me.uxError.ContainerControl = Me
        '
        'uxlblMRU
        '
        Me.uxlblMRU.AutoSize = True
        Me.uxlblMRU.Location = New System.Drawing.Point(12, 256)
        Me.uxlblMRU.Name = "uxlblMRU"
        Me.uxlblMRU.Size = New System.Drawing.Size(85, 13)
        Me.uxlblMRU.TabIndex = 8
        Me.uxlblMRU.Text = "MRU Directorios"
        '
        'uxlstDirectorios
        '
        Me.uxlstDirectorios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxlstDirectorios.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uxlstDirectorios.FormattingEnabled = True
        Me.uxlstDirectorios.Location = New System.Drawing.Point(15, 272)
        Me.uxlstDirectorios.Name = "uxlstDirectorios"
        Me.uxlstDirectorios.Size = New System.Drawing.Size(683, 199)
        Me.uxlstDirectorios.TabIndex = 9
        '
        'uxtxtListaPalabras
        '
        Me.uxtxtListaPalabras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxtxtListaPalabras.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uxtxtListaPalabras.Location = New System.Drawing.Point(15, 181)
        Me.uxtxtListaPalabras.Multiline = True
        Me.uxtxtListaPalabras.Name = "uxtxtListaPalabras"
        Me.uxtxtListaPalabras.Size = New System.Drawing.Size(684, 72)
        Me.uxtxtListaPalabras.TabIndex = 7
        '
        'uxlblListaPalabras
        '
        Me.uxlblListaPalabras.AutoSize = True
        Me.uxlblListaPalabras.Location = New System.Drawing.Point(12, 165)
        Me.uxlblListaPalabras.Name = "uxlblListaPalabras"
        Me.uxlblListaPalabras.Size = New System.Drawing.Size(100, 13)
        Me.uxlblListaPalabras.TabIndex = 6
        Me.uxlblListaPalabras.Text = "Palabras eliminadas"
        '
        'uxtxtListaExtensiones
        '
        Me.uxtxtListaExtensiones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxtxtListaExtensiones.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uxtxtListaExtensiones.Location = New System.Drawing.Point(15, 142)
        Me.uxtxtListaExtensiones.Name = "uxtxtListaExtensiones"
        Me.uxtxtListaExtensiones.Size = New System.Drawing.Size(684, 20)
        Me.uxtxtListaExtensiones.TabIndex = 5
        '
        'uxlblListaExtensiones
        '
        Me.uxlblListaExtensiones.AutoSize = True
        Me.uxlblListaExtensiones.Location = New System.Drawing.Point(12, 126)
        Me.uxlblListaExtensiones.Name = "uxlblListaExtensiones"
        Me.uxlblListaExtensiones.Size = New System.Drawing.Size(90, 13)
        Me.uxlblListaExtensiones.TabIndex = 4
        Me.uxlblListaExtensiones.Text = "Extensiones (.ext)"
        '
        'uxlblFicheroDatos
        '
        Me.uxlblFicheroDatos.AutoSize = True
        Me.uxlblFicheroDatos.Location = New System.Drawing.Point(12, 9)
        Me.uxlblFicheroDatos.Name = "uxlblFicheroDatos"
        Me.uxlblFicheroDatos.Size = New System.Drawing.Size(86, 13)
        Me.uxlblFicheroDatos.TabIndex = 12
        Me.uxlblFicheroDatos.Text = "Fichero de datos"
        '
        'uxtxtFicheroDatos
        '
        Me.uxtxtFicheroDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxtxtFicheroDatos.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uxtxtFicheroDatos.Location = New System.Drawing.Point(15, 25)
        Me.uxtxtFicheroDatos.Name = "uxtxtFicheroDatos"
        Me.uxtxtFicheroDatos.Size = New System.Drawing.Size(655, 20)
        Me.uxtxtFicheroDatos.TabIndex = 13
        '
        'uxbtnBuscarFichero
        '
        Me.uxbtnBuscarFichero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uxbtnBuscarFichero.Image = Global.IMDB.My.Resources.Resources.carpeta
        Me.uxbtnBuscarFichero.Location = New System.Drawing.Point(676, 24)
        Me.uxbtnBuscarFichero.Name = "uxbtnBuscarFichero"
        Me.uxbtnBuscarFichero.Size = New System.Drawing.Size(23, 23)
        Me.uxbtnBuscarFichero.TabIndex = 14
        Me.uxbtnBuscarFichero.UseVisualStyleBackColor = True
        '
        'uxSaveFileDialog
        '
        Me.uxSaveFileDialog.DefaultExt = "xml"
        Me.uxSaveFileDialog.Filter = "XML files|*.xml"
        Me.uxSaveFileDialog.Title = "Seleccione un fichero donde guardar los datos"
        '
        'ConfigForm
        '
        Me.AcceptButton = Me.uxbtnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.uxbtnSalir
        Me.ClientSize = New System.Drawing.Size(711, 505)
        Me.Controls.Add(Me.uxbtnBuscarFichero)
        Me.Controls.Add(Me.uxlblFicheroDatos)
        Me.Controls.Add(Me.uxtxtFicheroDatos)
        Me.Controls.Add(Me.uxlblIMDB)
        Me.Controls.Add(Me.uxtxtIMDB)
        Me.Controls.Add(Me.uxlblSUBDIVX)
        Me.Controls.Add(Me.uxtxtSUBDIVX)
        Me.Controls.Add(Me.uxlblListaExtensiones)
        Me.Controls.Add(Me.uxtxtListaExtensiones)
        Me.Controls.Add(Me.uxlblListaPalabras)
        Me.Controls.Add(Me.uxtxtListaPalabras)
        Me.Controls.Add(Me.uxlblMRU)
        Me.Controls.Add(Me.uxlstDirectorios)
        Me.Controls.Add(Me.uxbtnGuardar)
        Me.Controls.Add(Me.uxbtnSalir)
        Me.Name = "ConfigForm"
        Me.Text = "Configuración"
        CType(Me.uxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uxlblIMDB As System.Windows.Forms.Label
    Friend WithEvents uxtxtIMDB As System.Windows.Forms.TextBox
    Friend WithEvents uxbtnGuardar As System.Windows.Forms.Button
    Friend WithEvents uxbtnSalir As System.Windows.Forms.Button
    Friend WithEvents uxtxtSUBDIVX As System.Windows.Forms.TextBox
    Friend WithEvents uxlblSUBDIVX As System.Windows.Forms.Label
    Friend WithEvents uxError As System.Windows.Forms.ErrorProvider
    Friend WithEvents uxlstDirectorios As System.Windows.Forms.ListBox
    Friend WithEvents uxlblMRU As System.Windows.Forms.Label
    Friend WithEvents uxtxtListaPalabras As System.Windows.Forms.TextBox
    Friend WithEvents uxlblListaPalabras As System.Windows.Forms.Label
    Friend WithEvents uxtxtListaExtensiones As System.Windows.Forms.TextBox
    Friend WithEvents uxlblListaExtensiones As System.Windows.Forms.Label
    Friend WithEvents uxlblFicheroDatos As System.Windows.Forms.Label
    Friend WithEvents uxtxtFicheroDatos As System.Windows.Forms.TextBox
    Friend WithEvents uxbtnBuscarFichero As System.Windows.Forms.Button
    Friend WithEvents uxSaveFileDialog As System.Windows.Forms.SaveFileDialog
End Class
