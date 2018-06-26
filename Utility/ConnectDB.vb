Imports System.Configuration
Imports System.Data.SqlClient

Public Class ConnectDB

    Public Shared ConnectionStringConnectDB As String = ""

    Public Sub New()
    End Sub

    Public Shared Function GetConnectionDB() As SqlConnection
        Return New SqlConnection(ConnectionStringConnectDB) 'ConfigurationManager.AppSettings("ConnectionString"))
    End Function


    Public Shared Function CheckConnectionDB() As Boolean
        Try
            Using conn As SqlConnection = GetConnectionDB()
                Try
                    conn.Open()
                Catch ex As Exception
                    Return False
                Finally
                    conn.Close()
                End Try
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


End Class
