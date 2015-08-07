<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Omdb
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
        Me.uxlblTitulo = New System.Windows.Forms.Label()
        Me.uxlblAño = New System.Windows.Forms.Label()
        Me.uxlblDescripcion = New System.Windows.Forms.Label()
        Me.uxpcb = New System.Windows.Forms.PictureBox()
        CType(Me.uxpcb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uxlblTitulo
        '
        Me.uxlblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.uxlblTitulo.Name = "uxlblTitulo"
        Me.uxlblTitulo.Size = New System.Drawing.Size(342, 16)
        Me.uxlblTitulo.TabIndex = 0
        Me.uxlblTitulo.Text = "Label1"
        '
        'uxlblAño
        '
        Me.uxlblAño.Location = New System.Drawing.Point(360, 9)
        Me.uxlblAño.Name = "uxlblAño"
        Me.uxlblAño.Size = New System.Drawing.Size(78, 16)
        Me.uxlblAño.TabIndex = 1
        Me.uxlblAño.Text = "Label2"
        '
        'uxlblDescripcion
        '
        Me.uxlblDescripcion.Location = New System.Drawing.Point(252, 28)
        Me.uxlblDescripcion.Name = "uxlblDescripcion"
        Me.uxlblDescripcion.Size = New System.Drawing.Size(259, 292)
        Me.uxlblDescripcion.TabIndex = 2
        Me.uxlblDescripcion.Text = "Label3"
        '
        'uxpcb
        '
        Me.uxpcb.Location = New System.Drawing.Point(15, 28)
        Me.uxpcb.Name = "uxpcb"
        Me.uxpcb.Size = New System.Drawing.Size(231, 292)
        Me.uxpcb.TabIndex = 3
        Me.uxpcb.TabStop = False
        '
        'Omdb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 332)
        Me.Controls.Add(Me.uxlblTitulo)
        Me.Controls.Add(Me.uxlblAño)
        Me.Controls.Add(Me.uxpcb)
        Me.Controls.Add(Me.uxlblDescripcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Omdb"
        Me.Opacity = 0.8R
        Me.Text = "Omdb"
        CType(Me.uxpcb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents uxlblTitulo As Label
    Friend WithEvents uxlblAño As Label
    Friend WithEvents uxlblDescripcion As Label
    Friend WithEvents uxpcb As PictureBox
End Class
