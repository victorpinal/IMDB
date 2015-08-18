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
        Me.uxlblAño = New System.Windows.Forms.Label()
        Me.uxpcb = New System.Windows.Forms.PictureBox()
        Me.uxlblRuntime = New System.Windows.Forms.Label()
        Me.uxlblGenre = New System.Windows.Forms.Label()
        Me.uxlblDirector = New System.Windows.Forms.Label()
        Me.uxlblActors = New System.Windows.Forms.Label()
        Me.uxtxtPlot = New System.Windows.Forms.TextBox()
        CType(Me.uxpcb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uxlblAño
        '
        Me.uxlblAño.BackColor = System.Drawing.Color.LightGray
        Me.uxlblAño.Location = New System.Drawing.Point(5, 4)
        Me.uxlblAño.Name = "uxlblAño"
        Me.uxlblAño.Size = New System.Drawing.Size(47, 16)
        Me.uxlblAño.TabIndex = 1
        Me.uxlblAño.Text = "Year"
        '
        'uxpcb
        '
        Me.uxpcb.Location = New System.Drawing.Point(271, 3)
        Me.uxpcb.Name = "uxpcb"
        Me.uxpcb.Size = New System.Drawing.Size(233, 297)
        Me.uxpcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.uxpcb.TabIndex = 3
        Me.uxpcb.TabStop = False
        '
        'uxlblRuntime
        '
        Me.uxlblRuntime.BackColor = System.Drawing.Color.LightGray
        Me.uxlblRuntime.Location = New System.Drawing.Point(55, 4)
        Me.uxlblRuntime.Name = "uxlblRuntime"
        Me.uxlblRuntime.Size = New System.Drawing.Size(59, 16)
        Me.uxlblRuntime.TabIndex = 4
        Me.uxlblRuntime.Text = "Runtime"
        '
        'uxlblGenre
        '
        Me.uxlblGenre.BackColor = System.Drawing.Color.LightGray
        Me.uxlblGenre.Location = New System.Drawing.Point(116, 4)
        Me.uxlblGenre.Name = "uxlblGenre"
        Me.uxlblGenre.Size = New System.Drawing.Size(151, 16)
        Me.uxlblGenre.TabIndex = 5
        Me.uxlblGenre.Text = "Genre"
        '
        'uxlblDirector
        '
        Me.uxlblDirector.BackColor = System.Drawing.Color.LightGray
        Me.uxlblDirector.Location = New System.Drawing.Point(5, 22)
        Me.uxlblDirector.Name = "uxlblDirector"
        Me.uxlblDirector.Size = New System.Drawing.Size(262, 16)
        Me.uxlblDirector.TabIndex = 6
        Me.uxlblDirector.Text = "Director"
        '
        'uxlblActors
        '
        Me.uxlblActors.BackColor = System.Drawing.Color.LightGray
        Me.uxlblActors.Location = New System.Drawing.Point(5, 40)
        Me.uxlblActors.Name = "uxlblActors"
        Me.uxlblActors.Size = New System.Drawing.Size(262, 31)
        Me.uxlblActors.TabIndex = 7
        Me.uxlblActors.Text = "Actors"
        '
        'uxtxtPlot
        '
        Me.uxtxtPlot.BackColor = System.Drawing.Color.LightGray
        Me.uxtxtPlot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.uxtxtPlot.Location = New System.Drawing.Point(5, 73)
        Me.uxtxtPlot.Multiline = True
        Me.uxtxtPlot.Name = "uxtxtPlot"
        Me.uxtxtPlot.ReadOnly = True
        Me.uxtxtPlot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.uxtxtPlot.Size = New System.Drawing.Size(262, 227)
        Me.uxtxtPlot.TabIndex = 8
        Me.uxtxtPlot.TabStop = False
        Me.uxtxtPlot.Text = "Plot"
        '
        'Omdb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 305)
        Me.Controls.Add(Me.uxtxtPlot)
        Me.Controls.Add(Me.uxlblActors)
        Me.Controls.Add(Me.uxlblDirector)
        Me.Controls.Add(Me.uxlblGenre)
        Me.Controls.Add(Me.uxlblRuntime)
        Me.Controls.Add(Me.uxlblAño)
        Me.Controls.Add(Me.uxpcb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Omdb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Omdb"
        CType(Me.uxpcb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uxlblAño As Label
    Friend WithEvents uxpcb As PictureBox
    Friend WithEvents uxlblRuntime As Label
    Friend WithEvents uxlblGenre As Label
    Friend WithEvents uxlblDirector As Label
    Friend WithEvents uxlblActors As Label
    Friend WithEvents uxtxtPlot As TextBox
End Class
