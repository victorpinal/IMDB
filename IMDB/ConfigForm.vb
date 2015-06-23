Public Class ConfigForm

    Private Sub Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = Drawing.Icon.FromHandle(My.Resources.refresca.GetHicon)
        With My.MySettings.Default
            uxtxtFicheroDatos.Text = .FilePath
            uxtxtIMDB.Text = .urlImdb
            uxtxtSUBDIVX.Text = .urlSubdivx
            uxtxtListaExtensiones.Text = .ExtensionList
            uxtxtListaPalabras.Text = .WordsList
            uxlstDirectorios.Items.Clear()
            uxlstDirectorios.Items.AddRange(.MRU_Folders.Cast(Of String).ToArray)
            uxtxtServidor.Text = .Server
            uxtxtPuerto.Text = .Port
            uxtxtUsuario.Text = .User
            uxtxtPassword.Text = .Password
        End With

    End Sub

    Private Sub uxbtnGuardar_Click(sender As Object, e As EventArgs) Handles uxbtnGuardar.Click

        Try
            uxError.Clear()

            If (String.IsNullOrEmpty(uxtxtFicheroDatos.Text)) Then
                uxError.SetError(uxtxtFicheroDatos, "Debe de indicar un nombre de fichero donde guardar los datos.")
                uxtxtFicheroDatos.Focus()
                Exit Sub
            End If

            If (String.IsNullOrEmpty(uxtxtIMDB.Text) OrElse Not uxtxtIMDB.Text.Contains("TESTSEARCH")) Then
                uxError.SetError(uxlblIMDB, "La url debe de contener el término ""TESTSEARCH""")
                uxtxtIMDB.Focus()
                Exit Sub
            End If

            If (String.IsNullOrEmpty(uxtxtSUBDIVX.Text) OrElse Not uxtxtSUBDIVX.Text.Contains("TESTSEARCH")) Then
                uxError.SetError(uxlblSUBDIVX, "La url debe de contener el término ""TESTSEARCH""")
                uxtxtSUBDIVX.Focus()
                Exit Sub
            End If

            With My.MySettings.Default
                .FilePath = Trim(uxtxtFicheroDatos.Text)
                .urlImdb = Trim(uxtxtIMDB.Text)
                .urlSubdivx = Trim(uxtxtSUBDIVX.Text)
                .ExtensionList = Trim(uxtxtListaExtensiones.Text)
                .WordsList = Trim(uxtxtListaPalabras.Text)
                .MRU_Folders.Clear()
                .MRU_Folders.AddRange(uxlstDirectorios.Items.Cast(Of String).ToArray)
                .Server = Trim(uxtxtServidor.Text)
                .Port = Trim(uxtxtPuerto.Text)
                .User = Trim(uxtxtUsuario.Text)
                .Password = Trim(uxtxtPassword.Text)
            End With

            DialogResult = DialogResult.OK
        Catch ex As Exception
            MsgBox("uxbtnGuardar_Click: " & ex.Message)
            DialogResult = DialogResult.Cancel
        End Try

    End Sub

    Private Sub uxlstDirectorios_KeyDown(sender As Object, e As KeyEventArgs) Handles uxlstDirectorios.KeyDown
        Try
            If (uxlstDirectorios.SelectedItem IsNot Nothing AndAlso (e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back)) Then
                uxlstDirectorios.Items.Remove(uxlstDirectorios.SelectedItem)
            End If
        Catch ex As Exception
            MsgBox("uxlstDirectorios_KeyDown: " & ex.Message)
        End Try        
    End Sub

    Private Sub uxbtnBuscarFichero_Click(sender As Object, e As EventArgs) Handles uxbtnBuscarFichero.Click
        Try
            uxSaveFileDialog.InitialDirectory = IO.Path.GetDirectoryName(uxtxtFicheroDatos.Text)
            uxSaveFileDialog.FileName = IO.Path.GetFileName(uxtxtFicheroDatos.Text)
            If (uxSaveFileDialog.ShowDialog(Me) = DialogResult.OK) Then
                uxtxtFicheroDatos.Text = uxSaveFileDialog.FileName
            End If
        Catch ex As Exception
            MsgBox("uxbtnBuscarFichero_Click: " & ex.Message)
        End Try
    End Sub
    
End Class