Imports Utility
Imports DTO
Imports System.Data.SqlClient

Public Class BaoCaoCongNo_DAL

    Public Function insert(x As BaoCaoCongNo_DTO) As Result
        Dim query As String = "INSERT INTO [BAOCAOCONGNO] ([Thang], [NgayLap]) VALUES (@Thang, @NgayLap)"
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()
                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Thang", x.Thang1)
                    .Parameters.AddWithValue("@NgayLap", x.NgayLap1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Return New Result(False, Nothing, "Thêm báo cáo công nợ thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Thêm báo cáo công nợ thành công!")
            End Using
        End Using
        Return New Result(True)
    End Function


    Public Function GetNextIncrement() As Result
        Dim query As String = "SELECT IDENT_CURRENT('BAOCAOCONGNO') num"
        Dim Increment As Integer = 0
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()
                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader
                    If (reader.HasRows = True) Then
                        While reader.Read
                            Increment = Integer.Parse(reader("num"))
                        End While
                    End If
                Catch ex As Exception
                    Return New Result(False, Nothing, "Lấy mã báo cáo công nợ dự định tạo thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Increment + 1)
            End Using
        End Using
    End Function

End Class
