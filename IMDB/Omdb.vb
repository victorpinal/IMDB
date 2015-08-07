Option Strict Off

Public Class Omdb

    Public Sub mostrar(id As String)
        Dim response As String = New System.Net.WebClient().DownloadString("http://www.omdbapi.com/?i=" & id & "&plot=full&r=json")
        If (Not String.IsNullOrEmpty(response)) Then
            Dim j As Object = New System.Web.Script.Serialization.JavaScriptSerializer().Deserialize(Of Object)(response)
            uxlblTitulo.Text = j("Title")
            uxlblAño.Text = j("Year")
            uxlblDescripcion.Text = j("Plot")
            Me.Show()
        End If
    End Sub

    Private Sub Me_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Hide()
    End Sub

End Class