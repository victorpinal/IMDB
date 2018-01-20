Imports System.Net
Imports MySql.Data.MySqlClient

Public Class Imdb

    Public Shared Function cargar(id As Integer) As Object
        Try

            Dim baseDatos As BaseDatos = BaseDatos.getInstance

            Dim myRow As DataRow = baseDatos.Select("SELECT imdb_id FROM film WHERE id=@id AND ifnull(imdb_id,'') <> ''", New MySqlParameter("@id", id)).AsEnumerable.FirstOrDefault

            If (myRow IsNot Nothing) Then

                Dim wb As New WebClient()
                wb.Encoding = System.Text.Encoding.UTF8
                Dim response As String = wb.DownloadString("http://app.imdb.com/title/maindetails?tconst=" & myRow("imdb_id").ToString)

                If (Not String.IsNullOrEmpty(response)) Then
                    Dim j As Object = New Web.Script.Serialization.JavaScriptSerializer().Deserialize(Of Object)(response)
                    'Dim imagen As New IO.MemoryStream
                    'Try
                    '    CType(WebRequest.Create(j("Poster")), HttpWebRequest).GetResponse().GetResponseStream.CopyTo(imagen)
                    'Catch ex As Exception
                    'End Try
                    'baseDatos.ExecuteNonQuery("UPDATE film SET omdb=@omdb, picture=@picture WHERE id=@id",
                    '                          {New MySqlParameter("@omdb", response),
                    '                           New MySqlParameter("@picture", If(imagen.Length = 0, Nothing, imagen.ToArray)),
                    '                           New MySqlParameter("@id", id)})
                    Return j
                End If

            End If

            Return Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


End Class
