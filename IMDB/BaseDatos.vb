Imports System.IO

Public Class BaseDatos

    Private Shared myConection As SQLite.SQLiteConnection
    Private Shared myCommand As SQLite.SQLiteCommand

    ''' <summary>
    ''' Comprueba la base de datos sqlite y la tabla "Film"
    ''' </summary>
    ''' <remarks></remarks>
    Shared Sub Check()
        Try
            'Inicializamos la ruta por defecto del fichero de datos
            If (String.IsNullOrEmpty(My.Settings.FilePath)) Then
                My.Settings.FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Peliculas.db")
            End If
            'Creamos la base de datos y la tabla si no existe
            myConection = New SQLite.SQLiteConnection("Data Source=" & My.Settings.FilePath & ";Version=3;")
            myCommand = New SQLite.SQLiteCommand(myConection)

            If ([Select]("SELECT name FROM sqlite_master WHERE type='table' AND name='Film';").Rows.Count = 0) Then
                ExecuteNonQuery("CREATE TABLE Film (" & _
                                "   Rowid INTEGER PRIMARY KEY ASC," & _
                                "   Id TEXT NOT NULL UNIQUE," & _
                                "   Name TEXT," & _
                                "   Ruta TEXT," & _
                                "   Link TEXT," & _
                                "   Rating REAL," & _
                                "   RatingCount INTEGER," & _
                                "   html BLOB," & _
                                "   fecha_alta DATETIME)")
                ExecuteNonQuery("CREATE VIEW vw_Film AS " & _
                                "SELECT Rowid,Id,NAME,Ruta,t1.Link,IFNULL(Rating,0) AS Rating,IFNULL(RatingCount,0) AS RatingCount,Total,IFNULL(Duplicados,0) AS Duplicados," & _
                                "CASE WHEN html IS NOT NULL THEN 1 ELSE 0 END AS html " & _
                                "FROM Film t1 JOIN (" & _
                                "SELECT COUNT(*) AS Total FROM Film) " & _
                                "LEFT JOIN ( SELECT Link, COUNT(*) AS Duplicados " & _
                                "FROM Film WHERE LENGTH(Link) > 0 GROUP BY Link " & _
                                ") vw ON vw.Link = t1.Link")
            End If

        Catch ex As Exception
            Errores("BaseDatos:Check:" & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Ejecuta una consulta y devuelve la tabla resultante
    ''' </summary>
    ''' <param name="Sql"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function [Select](Sql As String) As DataTable
        Dim myTable As New DataTable
        Try
            myConection.Open()
            myCommand.CommandText = Sql
            myTable.Load(myCommand.ExecuteReader)
            myConection.Close()
        Catch ex As Exception
            Errores("BaseDatos:ExecuteScalar:" & Sql & ":" & ex.Message)
        End Try
        Return myTable
    End Function

    ''' <summary>
    ''' Ejecuta una consulta DML y devuelve el numero de filas afectadas
    ''' </summary>
    ''' <param name="Sql"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function ExecuteNonQuery(Sql As String, Optional Param As SQLite.SQLiteParameter = Nothing) As Integer
        ExecuteNonQuery = 0
        Try
            myConection.Open()
            myCommand.CommandText = Sql
            If (Param IsNot Nothing) Then myCommand.Parameters.Add(Param)
            ExecuteNonQuery = myCommand.ExecuteNonQuery
            myConection.Close()
        Catch ex As Exception
            Errores("BaseDatos:ExecuteNonQuery:" & Sql & ":" & ex.Message)
        End Try
    End Function

    Shared Function QuitaComilla(str As String) As String
        Return str.Replace("'", "''")
    End Function

    Shared Sub Errores(str As String)
        Using outfile As New StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ErroresIMDB.log"), True)
            outfile.WriteLine(Now.ToString & vbTab & str)
        End Using
    End Sub

End Class
