<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebBrowser
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
    	Me.web = New System.Windows.Forms.WebBrowser()
    	Me.SuspendLayout
    	'
    	'web
    	'
    	Me.web.AllowNavigation = false
    	Me.web.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.web.Location = New System.Drawing.Point(0, 0)
    	Me.web.MinimumSize = New System.Drawing.Size(20, 20)
    	Me.web.Name = "web"
    	Me.web.ScriptErrorsSuppressed = true
    	Me.web.Size = New System.Drawing.Size(633, 454)
    	Me.web.TabIndex = 0
    	'
    	'WebBrowser
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(633, 454)
    	Me.ControlBox = false
    	Me.Controls.Add(Me.web)
    	Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
    	Me.MaximizeBox = false
    	Me.MinimizeBox = false
    	Me.Name = "WebBrowser"
    	Me.ShowInTaskbar = false
    	Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    	Me.ResumeLayout(false)
    End Sub
    Friend WithEvents web As System.Windows.Forms.WebBrowser

End Class
