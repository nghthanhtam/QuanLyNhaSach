Imports System.Configuration
Imports System.Data.SqlClient

Public Class ConnectDB

    Public Sub New()
    End Sub

    Public Shared Function GetConnectionDB() As SqlConnection
        Return New SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))
    End Function

End Class
