Imports MySql.Data.MySqlClient

Public Class GestionXML

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub uxbtnCargarXML_Click(sender As Object, e As EventArgs) Handles uxbtnCargarXML.Click
        Try
            uxdlgOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            If (uxdlgOpen.ShowDialog = DialogResult.OK) Then
                Dim DS As New DataSet
                DS.ReadXml(uxdlgOpen.FileName)
                Dim myTableXML As DataTable = DS.Tables(0)
                Dim myTableBD As DataTable = BaseDatos.Select("SELECT filename FROM Film")

                'Metemos registros nuevos
                For Each myRow As DataRow In myTableXML.Rows
                    If (myTableBD.Select("filename='" & BaseDatos.QuitaComilla(myRow("filename").ToString) & "'").Length = 0) Then
                        BaseDatos.ExecuteNonQuery("INSERT INTO Film (filename, name, imdb_id, imdb_rating, imdb_ratingcount, omdb, ruta, fecha_alta) " &
                                                  "VALUES (@filename, @name, @imdb_id, @imdb_rating, @imdb_ratingcount, @omdb, @ruta, @fecha_alta)",
                                                  {New MySqlParameter("@filename", myRow("filename")),
                                                  New MySqlParameter("@name", myRow("name")),
                                                  New MySqlParameter("@imdb_id", myRow("imdb_id")),
                                                  New MySqlParameter("@imdb_rating", myRow("imdb_rating")),
                                                  New MySqlParameter("@imdb_ratingcount", myRow("imdb_ratingcount")),
                                                  New MySqlParameter("@omdb", myRow("omdb")),
                                                  New MySqlParameter("@ruta", myRow("ruta")),
                                                  New MySqlParameter("@fecha_alta", myRow("fecha_alta"))})
                    Else
                        BaseDatos.ExecuteNonQuery("UPDATE Film SET " &
                                                  "name=@name, imdb_id=@imdb_id, imdb_rating=@imdb_rating, imdb_ratingcount=@imdb_ratingcount, omdb=@omdb, ruta=@ruta, fecha_alta=@fecha_alta " &
                                                  "WHERE filename=@filename",
                                                  {New MySqlParameter("@filename", myRow("filename")),
                                                  New MySqlParameter("@name", myRow("name")),
                                                  New MySqlParameter("@imdb_id", myRow("imdb_id")),
                                                  New MySqlParameter("@imdb_rating", myRow("imdb_rating")),
                                                  New MySqlParameter("@imdb_ratingcount", myRow("imdb_ratingcount")),
                                                  New MySqlParameter("@omdb", myRow("omdb")),
                                                  New MySqlParameter("@ruta", myRow("ruta")),
                                                  New MySqlParameter("@fecha_alta", myRow("fecha_alta"))})
                    End If
                Next

                uxlblEstadoCargado.Text = "Fichero " & uxdlgOpen.FileName & " cargado en la base de datos"
            End If
        Catch ex As Exception
            MsgBox("CargaXML: " & ex.Message)
        End Try
    End Sub

    Private Sub uxbtnGuardarXML_Click(sender As Object, e As EventArgs) Handles uxbtnGuardarXML.Click
        Try
            uxdlgSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            If (uxdlgSave.ShowDialog = DialogResult.OK) Then
                Dim myTableBD As DataTable = BaseDatos.Select("SELECT id,filename,name,imdb_id,imdb_rating,imdb_ratingcount,omdb,ruta,fecha_alta FROM Film")
                myTableBD.WriteXml(uxdlgSave.FileName) 'Guardamos los datos del grid en un xml      
                uxlblEstadoGuardado.Text = "Fichero " & uxdlgSave.FileName & " volcado"
            End If
        Catch ex As Exception
            MsgBox("SalvaXML: " & ex.Message)
        End Try
    End Sub

End Class
