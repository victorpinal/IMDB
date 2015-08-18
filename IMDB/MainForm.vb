Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports MySql.Data
Imports SevenZip

Public Class MainForm

#Region "Inicializacion"

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Try

            'Seleccionar la cultura para tratar los puntos como decimales
            Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("es-ES")
            Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."

            BaseDatos.Check()       'Comprobamos la base de datos
            CargarRutasMRU()        'Carga las ultimas rutas abiertas

            uxgrd.AutoGenerateColumns = False
            FiltraYPintaGrid()

            AddHandler uxtxtBuscar.TextChanged, Sub() FiltraYPintaGrid()
            AddHandler uxbtnBorrarTexto.Click, Sub() uxtxtBuscar.ResetText()
            AddHandler uxchkVerMRU.CheckedChanged, Sub() FiltraYPintaGrid()
            AddHandler uxchkVerTodo.CheckedChanged, Sub() FiltraYPintaGrid()
            AddHandler uxchkPendientesIMDB.CheckStateChanged, Sub() FiltraYPintaGrid()
            AddHandler uxchkPendientesOMDB.CheckStateChanged, Sub() FiltraYPintaGrid()
            AddHandler uxchkDuplicados.CheckedChanged, Sub() FiltraYPintaGrid()
            AddHandler uxbtnRefresh.Click, Sub()
                                               FiltraYPintaGrid()
                                               uxError.Clear()
                                           End Sub
            AddHandler uxgrd.Sorted, Sub() FiltraYPintaGrid(False)

            AddHandler uxbtnConfiguracion.Click, Sub() ConfigForm.ShowDialog(Me)
            AddHandler uxbtnXML.Click, Sub() GestionXML.ShowDialog(Me)
            AddHandler uxbtnVerDirectorio.Click, Sub() Process.Start(My.Settings.LastFolder)
            AddHandler ConfigForm.FormClosed, Sub() CargarRutasMRU()

        Catch ex As Exception
            Errores("Form1_Load:" & ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Carga y valida la lista de ultimos directorios utilizados
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarRutasMRU()

        Try

            'Si no existe ya pedimos el directorio desde el que se cargará el listado de películas
            If (String.IsNullOrEmpty(My.Settings.LastFolder) OrElse Not Directory.Exists(My.Settings.LastFolder)) Then
                If (fbDialog.ShowDialog(Me) <> DialogResult.Cancel) Then
                    My.Settings.LastFolder = fbDialog.SelectedPath
                End If
            End If

            If (My.Settings.MRU_Folders Is Nothing) Then
                My.Settings.MRU_Folders = New Specialized.StringCollection
            Else

                'Cargamos como MRU si no existen el LastFolder y todos las distintas rutas de la base de datos
                If (Not My.Settings.MRU_Folders.Contains(My.Settings.LastFolder)) Then
                    My.Settings.MRU_Folders.Add(My.Settings.LastFolder)
                End If

                For Each myRow As DataRow In BaseDatos.Select("SELECT DISTINCT ruta FROM `film` WHERE ruta IS NOT NULL").Rows
                    'Convertimos el nombre de volumen guardado a una ruta válida p.e. ALMACEN/Videos -> D:/Videos
                    Dim ruta As String = myRow("ruta").ToString
                    Dim drive As DriveInfo = DriveInfo.GetDrives().FirstOrDefault(Function(d) d.VolumeLabel = ruta.Split(Path.DirectorySeparatorChar)(0))
                    If (drive IsNot Nothing) Then
                        ruta = ruta.Replace(drive.VolumeLabel & Path.DirectorySeparatorChar, drive.Name)
                        If (Not My.Settings.MRU_Folders.Contains(ruta)) Then
                            My.Settings.MRU_Folders.Add(ruta)
                        End If
                    End If
                Next

                'Filtramos los directorios si no existen los eliminamos
                Dim i As Integer = 0
                While i < My.Settings.MRU_Folders.Count
                    If (Not Directory.Exists(My.Settings.MRU_Folders(i))) Then
                        My.Settings.MRU_Folders.RemoveAt(i)
                    Else
                        i += 1
                    End If
                End While
            End If

            RemoveHandler uxcmbPath.SelectedIndexChanged, AddressOf uxcmbPath_SelectedIndexChanged
            uxcmbPath.Items.Clear()
            uxcmbPath.Items.AddRange(My.Settings.MRU_Folders.Cast(Of String).ToArray)
            uxcmbPath.SelectedItem = My.Settings.LastFolder
            AddHandler uxcmbPath.SelectedIndexChanged, AddressOf uxcmbPath_SelectedIndexChanged

        Catch ex As Exception
            Errores("CargarRutasMRU:" & ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Devuelve una lista de ficheros filtrados por extensión de los directorios indicados
    ''' </summary>
    ''' <param name="sDirs">Lista de directorios</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CargaFiles(sDirs() As String) As String()
        Try
            Return (From d In sDirs From f In Directory.GetFiles(d) Where My.Settings.ExtensionList.Split(","c).Contains(Path.GetExtension(f)) Select Replace(f, Path.GetPathRoot(f), DriveInfo.GetDrives().First(Function(i) i.Name = Path.GetPathRoot(f)).VolumeLabel & Path.DirectorySeparatorChar)).ToArray
        Catch ex As Exception
            Errores("CargaFiles: " & ex.Message)
            Return {}
        End Try
    End Function

    ''' <summary>
    ''' Carga la tabla de datos, realiza el filtrado del directorio actual y actualiza el grid
    ''' </summary>
    ''' <remarks></remarks>
    Private Function CargarTabla() As DataTable
        Try
            Dim sql As String = "SELECT * FROM vw_film"
            'Añade los registros (ficheros) que no existen en la base de datos
            If (uxchkVerTodo.Checked) Then
                sql &= " WHERE 1=1"
            Else
                Dim myFiles As String() = CargaFiles(CType(IIf(uxchkVerMRU.Checked, My.Settings.MRU_Folders.Cast(Of String).ToArray, {My.Settings.LastFolder}), String())).Select(Function(e) BaseDatos.QuitaComilla(e)).ToArray
                If (myFiles.Length > 0) Then
                    Dim myTableTmp As DataTable = BaseDatos.Select("SELECT id,filename,ruta FROM film WHERE filename IN ('" & If(myFiles.Length = 1, Path.GetFileName(myFiles(0)), myFiles.Aggregate(Function(a, b) Path.GetFileName(a) & "','" & Path.GetFileName(b))) & "')")
                    For Each myFile As String In myFiles
                        Dim myRow() As DataRow = myTableTmp.Select("filename='" & Path.GetFileName(myFile) & "'")
                        If (myRow.Length = 0) Then
                            BaseDatos.ExecuteNonQuery("INSERT INTO film (filename,name,ruta,fecha_alta) VALUES ('" & Path.GetFileName(myFile) & "','" & SplitWords(Path.GetFileNameWithoutExtension(myFile)) & "','" & Path.GetDirectoryName(myFile).Replace("\", "\\") & "',NOW())")
                        ElseIf (IsDBNull(myRow(0)("ruta")) OrElse myRow(0)("ruta").ToString <> Path.GetDirectoryName(myFile)) Then
                            BaseDatos.ExecuteNonQuery("UPDATE film SET ruta='" & Path.GetDirectoryName(myFile).Replace("\", "\\") & "' WHERE id=" & myRow(0)("id").ToString)
                        End If
                    Next
                    sql &= " WHERE filename IN ('" & If(myFiles.Length = 1, Path.GetFileName(myFiles(0)), myFiles.Aggregate(Function(a, b) Path.GetFileName(a) & "','" & Path.GetFileName(b))) & "')"
                Else
                    sql &= " WHERE 1<>1"
                End If
            End If
            If (uxchkPendientesIMDB.CheckState = CheckState.Checked) Then
                sql &= " AND (LENGTH(imdb_id) = 0 OR imdb_rating IS NULL OR imdb_rating = 0)"
            ElseIf (uxchkPendientesIMDB.CheckState = CheckState.Indeterminate) Then
                sql &= " AND NOT (LENGTH(imdb_id) = 0 OR imdb_rating IS NULL OR imdb_rating = 0)"
            End If
            If (uxchkPendientesOMDB.CheckState = CheckState.Checked) Then
                sql &= " AND tiene_omdb = 0"
            ElseIf (uxchkPendientesOMDB.CheckState = CheckState.Indeterminate) Then
                sql &= " AND tiene_omdb = 1"
            End If
            If (uxchkDuplicados.Checked) Then sql &= " AND duplicados > 1"
            If (uxtxtBuscar.Text.Length > 0) Then sql &= " AND CONCAT(filename ,' ',name,' ',IFNULL(imdb_id,'')) LIKE '%" & uxtxtBuscar.Text & "%'"
            Return BaseDatos.Select(sql & " ORDER BY imdb_rating DESC, imdb_ratingcount DESC, Id")
        Catch ex As Exception
            Errores("CargarTabla: " & ex.Message)
            Return New DataTable
        End Try
    End Function

    ''' <summary>
    ''' Actualiza el grid, mostrando los ficheros según las opciones seleccionadas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FiltraYPintaGrid(Optional bRecarga As Boolean = True)

        Try
            uxgrd.SuspendLayout()

            Dim media As Decimal = CalculaMediaRating()     'Da color a las películas que están sobre la media de puntuación

            If (bRecarga) Then
                Dim myTabla As DataTable = CargarTabla()
                uxgrd.DataSource = myTabla
                Dim NumTotal As Integer
                If (myTabla.Rows.Count > 0) Then NumTotal = CInt(myTabla.Rows(0)("total"))
                media = CalculaMediaRating()                'Recalcula la media
                Dim myTableMedia As DataTable = BaseDatos.Select("SELECT SUM(CASE WHEN imdb_rating>0 AND duplicados>0 THEN imdb_rating/duplicados ELSE 0 END)/SUM(CASE WHEN imdb_rating>0 AND duplicados>0 THEN 1/duplicados ELSE 0 END) AS media FROM vw_film")
                uxlblRegistros.Text = String.Format("Videos: {0} de {1} | Media Rating: {2:N2} de {3:N2}", myTabla.Rows.Count, NumTotal, media, myTableMedia.Rows(0)("media"))
            End If

            Dim sMRUFiles As String() = {}
            If (uxchkVerTodo.Checked) Then
                sMRUFiles = (From d In My.Settings.MRU_Folders.Cast(Of String).ToArray From f In Directory.GetFiles(d) Select f).ToArray
            End If

            For Each row As DataGridViewRow In uxgrd.Rows
                If (IsNumeric(row.Cells(uxColumnRating.Name).Value) AndAlso CDec(row.Cells(uxColumnRating.Name).Value) > media) Then
                    row.DefaultCellStyle.BackColor = Color.LightGreen
                Else
                    row.DefaultCellStyle.BackColor = Nothing
                End If
                If (uxchkVerTodo.Checked) Then
                    Dim sFile As String = (From f In sMRUFiles Where f.Contains(row.Cells(uxColumnFilename.Index).Value.ToString)).FirstOrDefault
                    If (Not String.IsNullOrEmpty(sFile)) Then
                        'row.Cells(uxColumnId.Index).Style.Font = New Font(uxgrd.DefaultCellStyle.Font, FontStyle.Bold)
                        row.Cells(uxColumnFilename.Index).Style.BackColor = Color.Black
                        row.Cells(uxColumnFilename.Index).Style.ForeColor = Color.WhiteSmoke
                        row.Cells(uxColumnFilename.Index).ToolTipText = sFile
                    End If
                End If
            Next

            uxgrd.ResumeLayout()

        Catch ex As Exception
            Errores("FiltraYPintaGrid: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "Utilidades"

    ''' <summary>
    ''' Elimina del nombre de fichero pasado una lista de palabras configurada
    ''' </summary>
    ''' <param name="s">Cadena con el nombre del fichero</param>
    ''' <returns>Cadena con el nombre filtrado</returns>
    ''' <remarks></remarks>
    Private Function SplitWords(ByVal s As String) As String
        Try
            Dim str As String = Regex.Replace(s, "^(\w+([\.\s]?\w+)*).*", "$1")
            Return Trim(Regex.Split(str, "\W+").Where(Function(e) Not My.Settings.WordsList.Split(","c).Contains(e.ToLower) And Not IsNumeric(e)).Aggregate(Function(e, f) e & " " & f))
        Catch ex As Exception
            Errores("SplitWords: " & ex.Message)
            Return s
        End Try
    End Function

    ''' <summary>
    ''' Calcula la media de valoraciones de los registros visibles del grid
    ''' </summary>
    ''' <returns>Valorarción media</returns>
    ''' <remarks></remarks>
    Private Function CalculaMediaRating() As Decimal
        Dim numRatings As Decimal = 0
        Dim sumRatings As Decimal = 0
        Dim media As Decimal = 0
        Try
            If (uxgrd.DataSource IsNot Nothing) Then
                For Each row As DataRow In TryCast(uxgrd.DataSource, DataTable).Rows
                    If (CInt(row("duplicados")) > 0 AndAlso IsNumeric(row(uxColumnRating.DataPropertyName)) AndAlso CDec(row(uxColumnRating.DataPropertyName)) > 0) Then
                        numRatings += CDec(1 / CInt(row("duplicados")))
                        sumRatings += CDec(row(uxColumnRating.DataPropertyName)) / CInt(row("duplicados"))
                    End If
                Next
                media = CDec(IIf(numRatings > 0, sumRatings / numRatings, 0))
            End If
        Catch ex As Exception
        End Try
        Return media
    End Function

    Private Function getImdbUrl(id As String) As String
        If (Not String.IsNullOrEmpty(id)) Then Return "http://www.imdb.com/title/" & id Else Return String.Empty
    End Function

    Private Function CheckURLFormat(url As String) As Boolean
        Return Regex.IsMatch(url, "/((([A-Za-z]{3,9}:(?:\/\/)?)(?:[-;:&=\+\$,\w]+@)?[A-Za-z0-9.-]+|(?:www.|[-;:&=\+\$,\w]+@)[A-Za-z0-9.-]+)((?:\/[\+~%\/.\w-_]*)?\??(?:[-\+=&;%@.\w_]*)#?(?:[\w]*))?)/")
    End Function

    Private Function GetHtml(url As String) As String
        GetHtml = String.Empty
        Try
            Dim wc As New Net.WebClient
            wc.Encoding = Encoding.UTF8
            GetHtml = wc.DownloadString(url)
        Catch ex As Exception
            Errores("GetHtml:" & ex.Message)
        End Try
    End Function

    Private Function GetRating(sourceString As String) As Decimal
        Dim rating As Decimal = 0
        Try
            sourceString = Regex.Replace(sourceString, "^.*<div class=""star-box giga-star"">(.*)<div class=""star-box-rating-widget"">.*", "$1", RegexOptions.Singleline)
            Dim reg As New Regex(".*\bclass=""titlePageSprite star-box-giga-star"">\s*(\d\.\d).*", RegexOptions.Singleline)
            If (reg.IsMatch(sourceString)) Then Decimal.TryParse(reg.Replace(sourceString, "$1"), rating)
        Catch ex As Exception
            Errores("GetRating:" & ex.Message)
        End Try
        Return rating
    End Function

    Private Function GetRatingCount(sourceString As String) As Integer
        Dim count As Integer = 0
        Try
            sourceString = Regex.Replace(sourceString, "^.*<span itemprop=""ratingCount"">\s*((\d+.)*\d+).*", "$1", RegexOptions.Singleline)
            Integer.TryParse(Replace(Replace(sourceString, ",", ""), ".", ""), count)
        Catch ex As Exception
            Errores("GetRating:" & ex.Message)
        End Try
        Return count
    End Function

#End Region

#Region "Grid"

    Private Sub uxgrd_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles uxgrd.CellEndEdit
        Dim myRow As DataRow = TryCast(uxgrd.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
        Dim myParam As MySqlClient.MySqlParameter = Nothing
        If (uxgrd.IsCurrentRowDirty) Then
            Dim sql = "UPDATE film SET "
            Select Case e.ColumnIndex
                Case uxColumnName.Index
                    sql &= "name='" & BaseDatos.QuitaComilla(myRow(uxColumnName.DataPropertyName).ToString) & "'"
                Case uxColumnImdb.Index
                    Dim url As String = Regex.Replace(myRow(uxColumnImdb.DataPropertyName).ToString, "(.+/).+$", "$1")
                    If (CheckURLFormat(url)) Then
                        Dim sourceString As String = GetHtml(url)
                        If (Not String.IsNullOrEmpty(sourceString)) Then
                            myRow(uxColumnImdb.DataPropertyName) = Split(url, "/"c)(4)
                            sql &= "imdb_id='" & myRow(uxColumnImdb.DataPropertyName).ToString & "'"
                            myRow("tiene_html") = 1
                            sql &= ",imdb_html=@imdb_html"
                            myParam = New MySqlClient.MySqlParameter("@imdb_html", CompressString(sourceString))
                            Dim Rating As Decimal = GetRating(sourceString)
                            myRow(uxColumnRating.DataPropertyName) = Rating
                            sql &= ",imdb_rating=" & Rating
                            Dim RatingCount As Integer = GetRatingCount(sourceString)
                            myRow(uxColumnRatingCount.DataPropertyName) = RatingCount
                            sql &= ",imdb_ratingcount=" & RatingCount
                        End If
                    Else
                        If (MsgBox("Eliminar los datos IMDB de la linea?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                            sql &= "imdb_id=NULL,imdb_html=NULL,imdb_rating=NULL,imdb_ratingcount=NULL"
                            myRow("tiene_html") = 0
                            myRow(uxColumnRating.DataPropertyName) = 0
                        Else
                            Exit Sub
                        End If
                    End If
                Case uxColumnRating.Index
                    sql &= "imdb_rating=" & IIf(IsNumeric(myRow(uxColumnRating.DataPropertyName)), myRow(uxColumnRating.DataPropertyName), 0).ToString
                Case uxColumnRatingCount.Index
                    sql &= "imdb_ratingcount=" & IIf(IsNumeric(myRow(uxColumnRatingCount.DataPropertyName)), myRow(uxColumnRatingCount.DataPropertyName), 0).ToString
            End Select
            sql &= " WHERE id=" & myRow("id").ToString
            BaseDatos.ExecuteNonQuery(sql, myParam)
            'Updateamos la info de Omdb Api
            If (e.ColumnIndex = uxColumnImdb.Index) Then
                If (Omdb.cargar(CInt(myRow("id")))) Then
                    myRow("tiene_omdb") = 1
                End If
            End If
            '----
            myRow.AcceptChanges()
        End If
    End Sub

    Private Sub uxgrd_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles uxgrd.DataError
        e.Cancel = True
    End Sub

    Private Sub uxgrd_CellValueNeeded(ByVal sender As Object, ByVal e As DataGridViewCellValueEventArgs) Handles uxgrd.CellValueNeeded
        Select Case e.ColumnIndex
            Case uxColumnImdbGo.Index
                If (CBool(CType(uxgrd.Rows(e.RowIndex).DataBoundItem, DataRowView).Row("tiene_html"))) Then
                    e.Value = Me.Icon
                Else
                    e.Value = New Bitmap(32, 32)
                End If
            Case uxColumnInfo.Index
                If (CBool(CType(uxgrd.Rows(e.RowIndex).DataBoundItem, DataRowView).Row("tiene_omdb"))) Then
                    e.Value = My.Resources.informacion
                Else
                    e.Value = New Bitmap(32, 32)
                End If
        End Select
    End Sub

    Private Sub uxgrd_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles uxgrd.CellMouseClick
        Dim url As String
        Try
            If (e.RowIndex >= 0) Then
                Select Case e.ColumnIndex
                    Case uxColumnInfo.Index   'Mostramos los datos en OmdbApi
                        Dim myRow As DataRow = CType(uxgrd.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
                        If (myRow IsNot Nothing AndAlso CBool(myRow("tiene_html"))) Then
                            If (Omdb.mostrar(CInt(myRow("id")))) Then
                                myRow("tiene_omdb") = 1
                            End If
                        End If
                    Case uxColumnImdbGo.Index       'Columna Ir a la página del enlace (IMDB)                        
                        If (e.Button = MouseButtons.Middle) Then
                            Dim myRow As DataRow = CType(uxgrd.Rows(e.RowIndex).DataBoundItem, DataRowView).Row
                            If (CBool(myRow("tiene_html"))) Then
                                Dim myTable As DataTable = BaseDatos.Select("SELECT imdb_html FROM film WHERE id=" & myRow("id").ToString)
                                If (myTable.Rows.Count > 0) Then
                                    Dim source As String = DecompressString(CType(myTable.Rows(0)(0), Byte()))
                                    If (source <> WebBrowser.source) Then
                                        WebBrowser.Ver(source)
                                    Else
                                        WebBrowser.Close()
                                    End If
                                End If
                            End If
                        Else
                            If (Not String.IsNullOrEmpty(uxgrd.Rows(e.RowIndex).Cells(uxColumnImdb.Name).Value.ToString)) Then
                                url = getImdbUrl(uxgrd.Rows(e.RowIndex).Cells(uxColumnImdb.Name).Value.ToString)
                                If (CheckURLFormat(url)) Then Process.Start(url)
                            End If
                        End If
                            Case uxColumnFind.Index     'Columna Buscar en la página de (IMDB)
                        Process.Start(My.Settings.urlImdb.Replace("TESTSEARCH", uxgrd.Rows(e.RowIndex).Cells(uxColumnName.Name).Value.ToString.Replace("  ", " ").Replace(" ", "+")))
                    Case uxColumnSub.Index      'Columna Subtitulos en (SUBDIVX)
                        Process.Start(My.Settings.urlSubdivx.Replace("TESTSEARCH", uxgrd.Rows(e.RowIndex).Cells(uxColumnName.Name).Value.ToString.Replace("  ", " ").Replace(" ", "+")))
                    Case uxColumnVer.Index
                        url = Path.Combine(My.Settings.LastFolder, uxgrd.Rows(e.RowIndex).Cells(uxColumnFilename.Name).Value.ToString)
                        If (File.Exists(url)) Then Process.Start(url)
                End Select
            End If
        Catch ex As Exception
            Errores("uxgrd_CellMouseClick: " & ex.Message)
        End Try
    End Sub

    Private Sub uxgrd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uxgrd.KeyDown
        Try
            Dim myRow As DataRow = TryCast(uxgrd.CurrentRow.DataBoundItem, DataRowView).Row
            If (e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back) Then
                If (MsgBox("Borrar " & myRow(uxColumnFilename.DataPropertyName).ToString, MsgBoxStyle.OkCancel, "BORRAR") = MsgBoxResult.Ok) Then
                    BaseDatos.ExecuteNonQuery("DELETE FROM film WHERE id=" & myRow("id").ToString)
                    myRow.Delete()
                End If
            End If
        Catch ex As Exception
            Errores("uxgrd_KeyDown: " & ex.Message)
        End Try
    End Sub

    Private Sub uxgrd_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles uxgrd.CellMouseDoubleClick
        Dim url As String
        Try
            If (e.RowIndex >= 0) Then
                Select Case e.ColumnIndex
                    Case uxColumnImdbGo.Index       'Columna Ir a la página del enlace (IMDB)
                        url = getImdbUrl(uxgrd.Rows(e.RowIndex).Cells(uxColumnImdb.Name).Value.ToString)
                        If (CheckURLFormat(url)) Then Process.Start(url)
                End Select
            End If
        Catch ex As Exception
            Errores("uxgrd_CellMouseDoubleClick: " & ex.Message)
        End Try
    End Sub

    Private Sub uxgrd_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles uxgrd.CellMouseDown
        If (e.ColumnIndex <> uxColumnImdbGo.Index) Then WebBrowser.Close()
    End Sub

#End Region

#Region "Directorio"

    Private Sub uxbntChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uxbntChange.Click

        fbDialog.SelectedPath = My.Settings.LastFolder
        If (fbDialog.ShowDialog(Me) = DialogResult.OK) Then
            My.Settings.LastFolder = fbDialog.SelectedPath
            If (Not My.Settings.MRU_Folders.Contains(fbDialog.SelectedPath)) Then
                My.Settings.MRU_Folders.Add(fbDialog.SelectedPath)
                CargarRutasMRU()
            End If
            FiltraYPintaGrid()
        End If

    End Sub

    Private Sub uxcmbPath_SelectedIndexChanged(sender As Object, e As EventArgs)

        If (uxcmbPath.SelectedItem IsNot Nothing) Then
            My.Settings.LastFolder = uxcmbPath.SelectedItem.ToString
            FiltraYPintaGrid()
        End If

    End Sub

#End Region

#Region "MenuGrid"

    Private Sub uxMenuFormatearNombres_Click(sender As Object, e As EventArgs) Handles uxMenuFormatearNombresTodos.Click, uxMenuFormatearNombresSeleccionados.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim index As Integer = 1
            Dim gridRows As IEnumerable(Of DataGridViewRow) = CType(IIf(sender Is uxMenuActualizarInfoSeleccionados, uxgrd.SelectedRows.Cast(Of DataGridViewRow), uxgrd.Rows.Cast(Of DataGridViewRow)), IEnumerable(Of DataGridViewRow))
            For Each myGridRow As DataGridViewRow In gridRows
                Me.Text = String.Format("IMDB. Actualizando registro {0} de {1}", index, gridRows.Count)
                Dim myRow As DataRow = CType(myGridRow.DataBoundItem, DataRowView).Row
                Dim str As String = SplitWords(myRow(uxColumnFilename.DataPropertyName).ToString)
                myRow(uxColumnName.DataPropertyName) = str
                BaseDatos.ExecuteNonQuery("UPDATE film SET name='" & BaseDatos.QuitaComilla(str) & "' WHERE id=" & myRow("id").ToString)
                myRow.AcceptChanges()
                index += 1
            Next
        Catch ex As Exception
            Errores("uxMenuFormatearNombres_Click:" & ex.Message)
        End Try
        Me.Text = "IMDB"
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub uxMenuActualizarInfo_Click(sender As Object, e As EventArgs) Handles uxMenuActualizarInfoTodos.Click, uxMenuActualizarInfoSeleccionados.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim index As Integer = 1
            Dim gridRows As IEnumerable(Of DataGridViewRow) = CType(IIf(sender Is uxMenuActualizarInfoSeleccionados, uxgrd.SelectedRows.Cast(Of DataGridViewRow), uxgrd.Rows.Cast(Of DataGridViewRow)), IEnumerable(Of DataGridViewRow))
            For Each myGridRow As DataGridViewRow In gridRows
                Me.Text = String.Format("IMDB. Actualizando registro {0} de {1}", index, gridRows.Count)
                Dim myRow As DataRow = CType(myGridRow.DataBoundItem, DataRowView).Row
                Dim url As String = getImdbUrl(myRow(uxColumnImdb.DataPropertyName).ToString)
                If (CheckURLFormat(url)) Then
                    Dim sourceString As String = GetHtml(url)
                    If (Not String.IsNullOrEmpty(sourceString)) Then
                        myRow("tiene_html") = 1
                        Dim sql As String = "UPDATE film SET imdb_html=@imdb_html"
                        Dim rating As Decimal = GetRating(sourceString)
                        If (rating > 0 AndAlso (IsDBNull(myRow(uxColumnRating.DataPropertyName)) OrElse rating <> CDec(myRow(uxColumnRating.DataPropertyName)))) Then
                            myRow(uxColumnRating.DataPropertyName) = rating
                            sql &= ",imdb_rating=" & rating
                        End If
                        Dim ratingCount As Integer = GetRatingCount(sourceString)
                        If (ratingCount > 0 AndAlso (IsDBNull(myRow(uxColumnRatingCount.DataPropertyName)) OrElse ratingCount <> CInt(myRow(uxColumnRatingCount.DataPropertyName)))) Then
                            myRow(uxColumnRatingCount.DataPropertyName) = ratingCount
                            sql &= ",imdb_ratingcount=" & ratingCount
                        End If
                        BaseDatos.ExecuteNonQuery(sql & " WHERE id=" & myRow("id").ToString, New MySqlClient.MySqlParameter("@imdb_html", CompressString(sourceString)))
                        myRow.AcceptChanges()
                    End If
                End If
                index += 1
            Next
        Catch ex As Exception
            Errores("uxMenuActualizarPuntuaciones_Click:" & ex.Message)
        End Try
        Me.Text = "IMDB"
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub uxMenuImportarOMDB_Click(sender As Object, e As EventArgs) Handles uxMenuImportarOMDBTodos.Click, uxMenuImportarOMDBSeleccionados.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim index As Integer = 1
            Dim gridRows As IEnumerable(Of DataGridViewRow) = CType(IIf(sender Is uxMenuImportarOMDBSeleccionados, uxgrd.SelectedRows.Cast(Of DataGridViewRow), uxgrd.Rows.Cast(Of DataGridViewRow)), IEnumerable(Of DataGridViewRow))
            For Each myGridRow As DataGridViewRow In gridRows
                Me.Text = String.Format("OMDB. Importando registro {0} de {1}", index, gridRows.Count)
                Dim myRow As DataRow = CType(myGridRow.DataBoundItem, DataRowView).Row
                If (Omdb.cargar(CInt((myRow("id"))))) Then
                    myRow("tiene_omdb") = 1
                End If
                index += 1
            Next
            uxgrd.Refresh()
        Catch ex As Exception
            Errores("uxMenuImportarOMDB_Click:" & ex.Message)
        End Try
        Me.Text = "IMDB"
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "7zip"

    Private Function CompressString(text As String) As Byte()
        Dim compressedData As Byte() = Nothing
        Dim compressor As New SevenZipCompressor()
        compressor.CompressionMethod = CompressionMethod.Ppmd
        compressor.CompressionLevel = CompressionLevel.Ultra
        compressor.ScanOnlyWritable = True
        compressor.DefaultItemName = "T"

        Dim utf8 As New UTF8Encoding()
        Using msin As New MemoryStream(utf8.GetBytes(text))
            Using msout As New MemoryStream()
                compressor.CompressStream(msin, msout)
                compressedData = msout.ToArray()
            End Using
        End Using
        Return compressedData
    End Function

    Private Function DecompressString(compressedText As Byte()) As String
        Dim uncompressedbuffer As Byte() = Nothing
        Using compressedbuffer As New MemoryStream(compressedText)
            Try
                Using extractor As New SevenZipExtractor(compressedbuffer)
                    Using msout As New MemoryStream()
                        extractor.ExtractFile(0, msout)
                        uncompressedbuffer = msout.ToArray()
                    End Using
                End Using
            Catch e As Exception
                uncompressedbuffer = Encoding.UTF8.GetBytes(e.Message)
            End Try
        End Using
        Return Encoding.UTF8.GetString(uncompressedbuffer)
    End Function

#End Region

#Region "Errores"

    Private Sub Errores(str As String)
        uxError.SetError(uxbtnRefresh, str)
        uxError.SetIconAlignment(uxbtnRefresh, ErrorIconAlignment.MiddleLeft)
        Using outfile As New StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ErroresIMDB.log"), True)
            outfile.WriteLine(Now.ToString & vbTab & str)
        End Using
    End Sub

#End Region

End Class
