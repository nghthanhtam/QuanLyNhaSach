Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class KhachHang_DAL

    Public Function selectTenKH_ByMaKH(iMaKH As Integer) As Result
        Dim kh As String
        Dim query As String = String.Empty
        query &= " SELECT [HoTenKhachHang]"
        query &= " FROM [KHACHHANG]"
        query &= " WHERE "
        query &= " @MaKH=[MaKhachHang] "

        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKH", iMaKH)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read
                            kh = reader("HoTenKhachHang")
                            '  Debug.WriteLine(sach)
                        End While
                    Else
                        Throw New Exception("Không tìm thấy kh!")
                    End If

                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Lấy thông tin kh thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, kh)
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
