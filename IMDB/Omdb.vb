Option Strict Off
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class Omdb

    Public Function cargar(id As Integer) As Boolean
        cargar = False
        Try
            Dim url As String = BaseDatos.Select("SELECT imdb_id FROM film WHERE id=@id", New MySqlParameter("@id", id)).Rows(0)("imdb_id").ToString
            If (Not String.IsNullOrWhiteSpace(url)) Then
                Dim wb As New WebClient()
                wb.Encoding = System.Text.Encoding.UTF8
                Dim response As String = wb.DownloadString("http://www.omdbapi.com/?i=" & url & "&plot=full&r=json&tomatoes=true")
                If (Not String.IsNullOrEmpty(response)) Then
                    Dim j As Object = New Web.Script.Serialization.JavaScriptSerializer().Deserialize(Of Object)(response)
                    Dim imagen As New IO.MemoryStream
                    Try
                        CType(WebRequest.Create(j("Poster")), HttpWebRequest).GetResponse().GetResponseStream.CopyTo(imagen)
                    Catch ex As Exception
                    End Try
                    BaseDatos.ExecuteNonQuery("UPDATE film SET omdb=@omdb,picture=@picture WHERE id=@id", {New MySqlParameter("@omdb", response),
                                              New MySqlParameter("@picture", If(imagen.Length = 0, DBNull.Value, imagen.ToArray)),
                                              New MySqlParameter("@id", id)})
                    cargar = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function mostrar(id As Integer) As Boolean
        mostrar = False
        Try
            If (BaseDatos.Select("SELECT id FROM film WHERE id=@id AND ifnull(omdb,'') <> ''", New MySqlParameter("@id", id)).Rows.Count = 0) Then
                cargar(id)
            End If
            Dim myRow As DataRow = BaseDatos.Select("SELECT omdb,picture FROM film WHERE id=@id", New MySqlParameter("@id", id)).Rows(0)
            If (Not IsDBNull(myRow("omdb"))) Then
                Dim j As Object = New Web.Script.Serialization.JavaScriptSerializer().Deserialize(Of Object)(myRow("omdb").ToString)
                Me.Text = j("Title")
                uxlblAño.Text = j("Year")
                uxlblRuntime.Text = j("Runtime")
                uxlblGenre.Text = j("Genre")
                uxlblDirector.Text = "Director : " & j("Director")
                uxlblActors.Text = "Actores : " & j("Actors")
                uxtxtPlot.Text = j("Plot")
                If (IsDBNull(myRow("picture"))) Then
                    uxpcb.Image = Nothing
                Else
                    uxpcb.Image = Image.FromStream(New IO.MemoryStream(CType(myRow("picture"), Byte())))
                End If
                Me.Show()
                Me.SetDesktopLocation(MousePosition.X + 20, MousePosition.Y)
                Me.BringToFront()
                mostrar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub Me_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Hide()
    End Sub

End Class