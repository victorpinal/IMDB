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
        Me.uxlblTitle = New System.Windows.Forms.Label()
        Me.uxlblAño = New System.Windows.Forms.Label()
        Me.uxlblDescripcion = New System.Windows.Forms.Label()
        Me.uxpcb = New System.Windows.Forms.PictureBox()
        Me.uxlblRuntime = New System.Windows.Forms.Label()
        Me.uxlblGenre = New System.Windows.Forms.Label()
        Me.uxlblDirector = New System.Windows.Forms.Label()
        Me.uxlblActors = New System.Windows.Forms.Label()
        CType(Me.uxpcb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uxlblTitle
        '
        Me.uxlblTitle.BackColor = System.Drawing.Color.Black
        Me.uxlblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uxlblTitle.ForeColor = System.Drawing.Color.White
        Me.uxlblTitle.Location = New System.Drawing.Point(3, 3)
        Me.uxlblTitle.Name = "uxlblTitle"
        Me.uxlblTitle.Size = New System.Drawing.Size(502, 16)
        Me.uxlblTitle.TabIndex = 0
        Me.uxlblTitle.Text = "Title"
        '
        'uxlblAño
        '
        Me.uxlblAño.BackColor = System.Drawing.Color.LightGray
        Me.uxlblAño.Location = New System.Drawing.Point(5, 23)
        Me.uxlblAño.Name = "uxlblAño"
        Me.uxlblAño.Size = New System.Drawing.Size(47, 16)
        Me.uxlblAño.TabIndex = 1
        Me.uxlblAño.Text = "Year"
        '
        'uxlblDescripcion
        '
        Me.uxlblDescripcion.BackColor = System.Drawing.Color.LightGray
        Me.uxlblDescripcion.Location = New System.Drawing.Point(5, 92)
        Me.uxlblDescripcion.Name = "uxlblDescripcion"
        Me.uxlblDescripcion.Size = New System.Drawing.Size(262, 227)
        Me.uxlblDescripcion.TabIndex = 2
        Me.uxlblDescripcion.Text = "Plot"
        '
        'uxpcb
        '
        Me.uxpcb.Location = New System.Drawing.Point(271, 22)
        Me.uxpcb.Name = "uxpcb"
        Me.uxpcb.Size = New System.Drawing.Size(233, 297)
        Me.uxpcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.uxpcb.TabIndex = 3
        Me.uxpcb.TabStop = False
        '
        'uxlblRuntime
        '
        Me.uxlblRuntime.BackColor = System.Drawing.Color.LightGray
        Me.uxlblRuntime.Location = New System.Drawing.Point(55, 23)
        Me.uxlblRuntime.Name = "uxlblRuntime"
        Me.uxlblRuntime.Size = New System.Drawing.Size(59, 16)
        Me.uxlblRuntime.TabIndex = 4
        Me.uxlblRuntime.Text = "Runtime"
        '
        'uxlblGenre
        '
        Me.uxlblGenre.BackColor = System.Drawing.Color.LightGray
        Me.uxlblGenre.Location = New System.Drawing.Point(116, 23)
        Me.uxlblGenre.Name = "uxlblGenre"
        Me.uxlblGenre.Size = New System.Drawing.Size(151, 16)
        Me.uxlblGenre.TabIndex = 5
        Me.uxlblGenre.Text = "Genre"
        '
        'uxlblDirector
        '
        Me.uxlblDirector.BackColor = System.Drawing.Color.LightGray
        Me.uxlblDirector.Location = New System.Drawing.Point(5, 41)
        Me.uxlblDirector.Name = "uxlblDirector"
        Me.uxlblDirector.Size = New System.Drawing.Size(262, 16)
        Me.uxlblDirector.TabIndex = 6
        Me.uxlblDirector.Text = "Director"
        '
        'uxlblActors
        '
        Me.uxlblActors.BackColor = System.Drawing.Color.LightGray
        Me.uxlblActors.Location = New System.Drawing.Point(5, 59)
        Me.uxlblActors.Name = "uxlblActors"
        Me.uxlblActors.Size = New System.Drawing.Size(262, 31)
        Me.uxlblActors.TabIndex = 7
        Me.uxlblActors.Text = "Actors"
        '
        'Omdb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 324)
        Me.Controls.Add(Me.uxlblActors)
        Me.Controls.Add(Me.uxlblDirector)
        Me.Controls.Add(Me.uxlblGenre)
        Me.Controls.Add(Me.uxlblRuntime)
        Me.Controls.Add(Me.uxlblTitle)
        Me.Controls.Add(Me.uxlblAño)
        Me.Controls.Add(Me.uxpcb)
        Me.Controls.Add(Me.uxlblDescripcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Omdb"
        Me.Text = "Omdb"
        CType(Me.uxpcb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents uxlblTitle As Label
    Friend WithEvents uxlblAño As Label
    Friend WithEvents uxlblDescripcion As Label
    Friend WithEvents uxpcb As PictureBox
    Friend WithEvents uxlblRuntime As Label
    Friend WithEvents uxlblGenre As Label
    Friend WithEvents uxlblDirector As Label
    Friend WithEvents uxlblActors As Label
End Class
