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
                Dim myTableBD As DataTable = BaseDatos.Select("SELECT * FROM Film")

                'Metemos registros nuevos
                For Each myRow As DataRow In myTableXML.Rows
                    If (myTableBD.Select("Id='" & BaseDatos.QuitaComilla(myRow("Id").ToString) & "'").Length = 0) Then
                        BaseDatos.ExecuteNonQuery("INSERT INTO Film (Id,Name,Ruta,Link,Rating,RatingCount) VALUES ('" & _
                                                  BaseDatos.QuitaComilla(myRow("Id").ToString) & "','" & _
                                                  BaseDatos.QuitaComilla(myRow("Name").ToString) & "','" & _
                                                  BaseDatos.QuitaComilla(myRow("Ruta").ToString) & "','" & _
                                                  BaseDatos.QuitaComilla(myRow("Link").ToString) & "'," & _
                                                  myRow("Rating").ToString & "," & _
                                                  myRow("RatingCount").ToString & ")")
                    Else
                        BaseDatos.ExecuteNonQuery("UPDATE Film SET " & _
                                                  "Name='" & BaseDatos.QuitaComilla(myRow("Name").ToString) & "'," & _
                                                  "Ruta='" & BaseDatos.QuitaComilla(myRow("Ruta").ToString) & "'," & _
                                                  "Link='" & BaseDatos.QuitaComilla(myRow("Link").ToString) & "'," & _
                                                  "Rating=" & myRow("Rating").ToString & "," & _
                                                  "RatingCount=" & myRow("RatingCount").ToString & _
                                                  " WHERE Id='" & BaseDatos.QuitaComilla(myRow("Id").ToString) & "'")
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
                Dim myTableBD As DataTable = BaseDatos.Select("SELECT Rowid,Id,Name,Ruta,Link,Rating,RatingCount,fecha_alta FROM Film")
                myTableBD.WriteXml(uxdlgSave.FileName) 'Guardamos los datos del grid en un xml      
                uxlblEstadoGuardado.Text = "Fichero " & uxdlgSave.FileName & " volcado"
            End If
        Catch ex As Exception
            MsgBox("SalvaXML: " & ex.Message)
        End Try
    End Sub

End Class
