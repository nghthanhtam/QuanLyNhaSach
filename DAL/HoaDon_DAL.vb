Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class HoaDon_DAL
    Function GetNextIncrement() As Result
        Dim query As String = "SELECT IDENT_CURRENT('HOADON') num"
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
                    Return New Result(False, Nothing, "Lấy mã hóa đơn dự định tạo thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Increment + 1)
            End Using
        End Using
    End Function


    Public Function insertHoaDon(x As HoaDon_DTO) As Result
        Dim query As String = "INSERT INTO [HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang])"
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@MaHoaDon", x.MaHoaDon1)
                    .Parameters.AddWithValue("@NgayLapHoaDon", x.NgayLapHoaDon1)
                    .Parameters.AddWithValue("@MaKhachHang", x.MaKhachHang1)

                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Thêm hóa đơn mới thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Thêm hóa đơn mới thành công!")

            End Using
        End Using
        Return New Result(True)
    End Function
End Class
