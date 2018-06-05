Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class ChiTietHoaDon_DAL

    Public Function insertChiTietHoaDon(x As ChiTietHoaDon_DTO) As Result
        Dim query As String = "INSERT INTO [CHITIETHOADON] ([MaHoaDon], [MaSach], [SoLuongban]) VALUES (@MaHoaDon, @MaSach, @SoLuongBan)"

        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@MaHoaDon", x.MaHoaDon1)
                    .Parameters.AddWithValue("@MaSach", x.MaSach1)
                    .Parameters.AddWithValue("@SoLuongban", x.SoLuongban1)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    Return New Result(False, Nothing, "Thêm vào chi tiết hóa đơn thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Thêm vào chi tiết hóa đơn thành công!")

            End Using
        End Using
        Return New Result(True)
    End Function



    Function GetNextIncrement() As Result
        Dim query As String = "SELECT IDENT_CURRENT('CHITIETHOADON') num"
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
                    Return New Result(False, Nothing, "Lấy mã chi tiết hóa đơn dự định thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Increment + 1)
            End Using
        End Using
    End Function

End Class
