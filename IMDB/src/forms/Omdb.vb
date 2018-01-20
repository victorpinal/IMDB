Imports System.Net
Imports MySql.Data.MySqlClient

Public Class Omdb

    Private baseDatos As BaseDatos

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        baseDatos = BaseDatos.getInstance

    End Sub

    Public Function cargar(id As Integer) As Object
        Try

            Dim myRow As DataRow = baseDatos.Select("SELECT imdb_id FROM film WHERE id=@id AND ifnull(imdb_id,'') <> ''", New MySqlParameter("@id", id)).AsEnumerable.FirstOrDefault

            If (myRow IsNot Nothing) Then

                Dim wb As New WebClient()
                wb.Encoding = System.Text.Encoding.UTF8
                Dim response As String = wb.DownloadString("http://www.omdbapi.com/?i=" & myRow("imdb_id").ToString & "&plot=full&r=json&tomatoes=true")

                If (Not String.IsNullOrEmpty(response)) Then
                    Dim j As Object = New Web.Script.Serialization.JavaScriptSerializer().Deserialize(Of Object)(response)
                    Dim imagen As New IO.MemoryStream
                    Try
                    	CType(WebRequest.Create(getObjValue(j,"Poster")), HttpWebRequest).GetResponse().GetResponseStream.CopyTo(imagen)
                    Catch ex As Exception
                    End Try
                    baseDatos.ExecuteNonQuery("UPDATE film SET omdb=@omdb, picture=@picture WHERE id=@id",
                                              {New MySqlParameter("@omdb", response),
                                               New MySqlParameter("@picture", If(imagen.Length = 0, Nothing, imagen.ToArray)),
                                               New MySqlParameter("@id", id)})
                    Return j
                End If

            End If

            Return Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function mostrar(id As Integer) As Boolean
        mostrar = False
        Try
            If (baseDatos.Select("SELECT id FROM film WHERE id=@id AND ifnull(omdb,'') <> ''", New MySqlParameter("@id", id)).Rows.Count = 0) Then
                cargar(id)
            End If
            Dim myRow As DataRow = baseDatos.Select("SELECT omdb,picture FROM film WHERE id=@id AND omdb IS NOT NULL", New MySqlParameter("@id", id)).AsEnumerable.FirstOrDefault
            If (myRow IsNot nothing) Then
                Dim j As Object = New Web.Script.Serialization.JavaScriptSerializer().Deserialize(Of Object)(myRow("omdb").ToString)
                Me.Text = getObjValue(j,"Title")
                uxlblAño.Text = getObjValue(j,"Year")
                uxlblRuntime.Text = getObjValue(j,"Runtime")
                uxlblGenre.Text = getObjValue(j,"Genre")
                uxlblDirector.Text = "Director : " & getObjValue(j,"Director")
                uxlblActors.Text = "Actores : " & getObjValue(j,"Actors")
                uxtxtPlot.Text = getObjValue(j,"Plot")
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
    
    Private Function getObjValue(obj As Object,propName As String) As String
    	Return obj.GetType().GetProperty(propName).GetValue(obj,Reflection.BindingFlags.GetProperty,Nothing,Nothing,Nothing).ToString()
    End Function

End Class