Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class PhieuNhapSach_DAL

    Public Function insertPhieuNhap(x As PhieuNhapSach_DTO) As Result
        Dim query As String = "INSERT INTO [PHIEUNHAP] ([NgayNhap]) VALUES (@NgayNhap)"

        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@NgayNhap", x.NgayNhap1)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Thêm vào phiếu nhập thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Thêm vào phiếu nhập thành công!")

            End Using
        End Using
        Return New Result(True)
    End Function


    Function GetNextIncrement() As Result
        Dim query As String = "SELECT IDENT_CURRENT('PHIEUNHAP') num"
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
                    conn.Close()
                    Return New Result(False, Nothing, "Lấy mã phiếu nhập dự định thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Increment + 1)
            End Using
        End Using
    End Function

End Class