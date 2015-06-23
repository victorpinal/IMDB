﻿Imports System.IO
imports MySql.Data

Public Class BaseDatos

    Private Shared myConection As MySqlClient.MySqlConnection
    Private Shared myCommand As MySqlClient.MySqlCommand

    ''' <summary>
    ''' Comprueba la base de datos sqlite y la tabla "Film"
    ''' </summary>
    ''' <remarks></remarks>
    Shared Sub Check()
        Try        
        	If (String.IsNullOrEmpty(My.MySettings.Default.Server)) Then
        		My.MySettings.Default.Server = InputBox("Servidor MySQL?",,"localhost")
        		My.MySettings.Default.Port = InputBox("Puerto",,"3306")
        		My.MySettings.Default.User = InputBox("Usuario")
        		My.MySettings.Default.Password = InputBox("Password")
        	End If
        	
        	dim conb As mySqlClient.MySqlConnectionStringBuilder = New MySqlClient.MySqlConnectionStringBuilder()
        	conb.Server = My.MySettings.Default.Server
        	conb.Port = CUInt(My.MySettings.Default.Port)
        	conb.UserID = My.MySettings.Default.User
        	conb.Password = My.MySettings.Default.Password
        	conb.Database = "peliculas"
        	myConection = New MySqlClient.MySqlConnection(conb.ConnectionString)        
        	
            myCommand = myConection.CreateCommand()
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
    Shared Function ExecuteNonQuery(Sql As String, Optional Param As MySqlClient.MySqlParameter = Nothing) As Integer
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
