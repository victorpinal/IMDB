<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionXML
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.uxbtnGuardarXML = New System.Windows.Forms.Button()
        Me.uxbtnCargarXML = New System.Windows.Forms.Button()
        Me.uxdlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.uxToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.uxlblEstadoCargado = New System.Windows.Forms.Label()
        Me.uxlblEstadoGuardado = New System.Windows.Forms.Label()
        Me.uxdlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'uxbtnGuardarXML
        '
        Me.uxbtnGuardarXML.AutoSize = True
        Me.uxbtnGuardarXML.Image = Global.IMDB.My.Resources.Resources.guarda
        Me.uxbtnGuardarXML.Location = New System.Drawing.Point(24, 41)
        Me.uxbtnGuardarXML.Name = "uxbtnGuardarXML"
        Me.uxbtnGuardarXML.Size = New System.Drawing.Size(96, 23)
        Me.uxbtnGuardarXML.TabIndex = 2
        Me.uxbtnGuardarXML.Text = "Guardar XML"
        Me.uxbtnGuardarXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.uxToolTip.SetToolTip(Me.uxbtnGuardarXML, "Guarda los registros de la base de datos en el fichero XML indicado")
        Me.uxbtnGuardarXML.UseVisualStyleBackColor = True
        '
        'uxbtnCargarXML
        '
        Me.uxbtnCargarXML.AutoSize = True
        Me.uxbtnCargarXML.Image = Global.IMDB.My.Resources.Resources.xml
        Me.uxbtnCargarXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.uxbtnCargarXML.Location = New System.Drawing.Point(24, 12)
        Me.uxbtnCargarXML.Name = "uxbtnCargarXML"
        Me.uxbtnCargarXML.Size = New System.Drawing.Size(96, 23)
        Me.uxbtnCargarXML.TabIndex = 1
        Me.uxbtnCargarXML.Text = "Cargar XML"
        Me.uxbtnCargarXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.uxToolTip.SetToolTip(Me.uxbtnCargarXML, "Carga la base de datos con los datos del fichero XML seleccionado")
        Me.uxbtnCargarXML.UseVisualStyleBackColor = True
        '
        'uxdlgOpen
        '
        Me.uxdlgOpen.DefaultExt = "xml"
        Me.uxdlgOpen.FileName = "Peliculas.xml"
        Me.uxdlgOpen.Filter = "XML Files|*.xml"
        Me.uxdlgOpen.Title = "Open XML"
        '
        'uxlblEstadoCargado
        '
        Me.uxlblEstadoCargado.AutoSize = True
        Me.uxlblEstadoCargado.Location = New System.Drawing.Point(126, 17)
        Me.uxlblEstadoCargado.Name = "uxlblEstadoCargado"
        Me.uxlblEstadoCargado.Size = New System.Drawing.Size(16, 13)
        Me.uxlblEstadoCargado.TabIndex = 3
        Me.uxlblEstadoCargado.Text = "..."
        '
        'uxlblEstadoGuardado
        '
        Me.uxlblEstadoGuardado.AutoSize = True
        Me.uxlblEstadoGuardado.Location = New System.Drawing.Point(126, 46)
        Me.uxlblEstadoGuardado.Name = "uxlblEstadoGuardado"
        Me.uxlblEstadoGuardado.Size = New System.Drawing.Size(16, 13)
        Me.uxlblEstadoGuardado.TabIndex = 4
        Me.uxlblEstadoGuardado.Text = "..."
        '
        'uxdlgSave
        '
        Me.uxdlgSave.DefaultExt = "xml"
        Me.uxdlgSave.FileName = "Peliculas.xml"
        Me.uxdlgSave.Filter = "XML File|*.xml"
        Me.uxdlgSave.Title = "Save XML"
        '
        'GestionXML
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.uxlblEstadoGuardado)
        Me.Controls.Add(Me.uxlblEstadoCargado)
        Me.Controls.Add(Me.uxbtnGuardarXML)
        Me.Controls.Add(Me.uxbtnCargarXML)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GestionXML"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestionar Base de datos - XML"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents uxbtnCargarXML As System.Windows.Forms.Button
    Friend WithEvents uxbtnGuardarXML As System.Windows.Forms.Button
    Friend WithEvents uxToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents uxdlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents uxlblEstadoCargado As System.Windows.Forms.Label
    Friend WithEvents uxlblEstadoGuardado As System.Windows.Forms.Label
    Friend WithEvents uxdlgSave As System.Windows.Forms.SaveFileDialog

End Class
