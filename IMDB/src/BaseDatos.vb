Imports MySql.Data

Public Class BaseDatos
    Implements IDisposable

    Private Shared instance As BaseDatos

    Public Shared Function getInstance() As BaseDatos

        If (instance Is Nothing) Then instance = New BaseDatos()
        Return instance

    End Function

    Private myConection As MySqlClient.MySqlConnection
    Private myCommand As MySqlClient.MySqlCommand

    ''' <summary>
    ''' Comprueba la base de datos sqlite y la tabla "Film"
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub New()
        Try

            If (String.IsNullOrEmpty(My.MySettings.Default.Server)) Then
                My.MySettings.Default.Server = InputBox("Servidor MySQL?",, "localhost")
                My.MySettings.Default.Port = InputBox("Puerto",, If(String.IsNullOrEmpty(My.MySettings.Default.Port), "3306", My.MySettings.Default.Port))
                My.MySettings.Default.User = InputBox("Usuario",, If(String.IsNullOrEmpty(My.MySettings.Default.User), "", My.MySettings.Default.User))
                My.MySettings.Default.Password = InputBox("Password", "", If(String.IsNullOrEmpty(My.MySettings.Default.Password), "", My.MySettings.Default.Password))
            End If

            Dim conb As MySqlClient.MySqlConnectionStringBuilder = New MySqlClient.MySqlConnectionStringBuilder()
            conb.Server = My.MySettings.Default.Server
            conb.Port = CUInt(My.MySettings.Default.Port)
            conb.UserID = My.MySettings.Default.User
            conb.Password = My.MySettings.Default.Password
            conb.Database = "peliculas"
            myConection = New MySqlClient.MySqlConnection(conb.ConnectionString)
            myCommand = myConection.CreateCommand()
            myConection.Open()

        Catch ex As Exception
            LogErrores("BaseDatos:Check:" & ex.Message)
            If (myConection.State <> ConnectionState.Closed) Then myConection.Close()
            My.MySettings.Default.Server = String.Empty
            Application.Exit()
        End Try
    End Sub

    ''' <summary>
    ''' Ejecuta una consulta y devuelve la tabla resultante
    ''' </summary>
    ''' <param name="Sql"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function [Select](Sql As String, Optional Param As MySqlClient.MySqlParameter = Nothing) As DataTable
        Dim myTable As New DataTable
        Try
            myCommand.CommandText = Sql
            myCommand.Parameters.Clear()
            If (Param IsNot Nothing) Then myCommand.Parameters.Add(Param)
            myTable.Load(myCommand.ExecuteReader)
        Catch ex As Exception
            LogErrores("BaseDatos:ExecuteScalar:" & Sql & ":" & ex.Message)
        End Try
        Return myTable
    End Function

    Public Function [Select](Sql As String, Param() As MySqlClient.MySqlParameter) As DataTable
        Dim myTable As New DataTable
        Try
            myCommand.CommandText = Sql
            myCommand.Parameters.Clear()
            For Each myParam As MySqlClient.MySqlParameter In Param
                myCommand.Parameters.Add(myParam)
            Next
            myTable.Load(myCommand.ExecuteReader)
        Catch ex As Exception
            LogErrores("BaseDatos:ExecuteScalar:" & Sql & ":" & ex.Message)
        End Try
        Return myTable
    End Function

    ''' <summary>
    ''' Ejecuta una consulta DML y devuelve el numero de filas afectadas
    ''' </summary>
    ''' <param name="Sql"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExecuteNonQuery(Sql As String, Optional Param As MySqlClient.MySqlParameter = Nothing) As Integer
        ExecuteNonQuery = 0
        Try
            myCommand.CommandText = Sql
            myCommand.Parameters.Clear()
            If (Param IsNot Nothing) Then myCommand.Parameters.Add(Param)
            ExecuteNonQuery = myCommand.ExecuteNonQuery
        Catch ex As Exception
            LogErrores("BaseDatos:ExecuteNonQuery:" & Sql & ":" & ex.Message)
        End Try
    End Function

    Public Function ExecuteNonQuery(Sql As String, Param() As MySqlClient.MySqlParameter) As Integer
        ExecuteNonQuery = 0
        Try
            myCommand.CommandText = Sql
            myCommand.Parameters.Clear()
            For Each myParam As MySqlClient.MySqlParameter In Param
                myCommand.Parameters.Add(myParam)
            Next
            ExecuteNonQuery = myCommand.ExecuteNonQuery
        Catch ex As Exception
            LogErrores("BaseDatos:ExecuteNonQuery:" & Sql & ":" & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Ejecuta una consulta DML y devuelve un valor (p.ej. el id insertado)
    ''' </summary>
    ''' <param name="Sql"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExecuteScalar(Sql As String, Param() As MySqlClient.MySqlParameter) As Integer
        ExecuteScalar = Nothing
        Try
            myCommand.CommandText = Sql
            myCommand.Parameters.Clear()
            For Each myParam As MySqlClient.MySqlParameter In Param
                myCommand.Parameters.Add(myParam)
            Next
            ExecuteScalar = CInt(myCommand.ExecuteScalar)
        Catch ex As Exception
            LogErrores("BaseDatos:ExecuteScalar:" & Sql & ":" & ex.Message)
        End Try
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose

        If (myConection.State <> ConnectionState.Closed) Then myConection.Close()

    End Sub

End Class
