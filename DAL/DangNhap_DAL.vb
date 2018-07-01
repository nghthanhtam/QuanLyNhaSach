Imports Utility
Imports DTO
Imports System.Data.SqlClient

Public Class DangNhap_DAL
    Public Function update(x As DangNhap_DTO) As Result

        Dim query As String = "UPDATE [DANGNHAP] SET [TenDangNhap] = @TenDangNhap, [MatKhau] = @MatKhau WHERE id = @id"
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()
                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenDangNhap", x.TenDangNhap1)
                    .Parameters.AddWithValue("@MatKhau", x.MatKhau1)
                    .Parameters.AddWithValue("@id", x.Id1)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Cập nhật thông tin đăng nhập thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Cập nhật thông tin đăng nhập thành công!")

            End Using
        End Using
        Return New Result(True)

    End Function

    Public Function KiemTraDangNhap(x As DangNhap_DTO) As Result

        Dim query As String = "SELECT id FROM DANGNHAP WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau"
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm
                    .Parameters.AddWithValue("@TenDangNhap", x.TenDangNhap1)
                    .Parameters.AddWithValue("@MatKhau", x.MatKhau1)

                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader
                    If (reader.HasRows = True) Then
                        reader.Read() ' đọc thông tin user vào reader
                        Return New Result(True, CInt(reader("id")), "Đăng nhập thành công!")
                    End If
                Catch ex As Exception
                    Return New Result(False, Nothing, "Đăng nhập thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(False, Nothing, "Tên đăng nhập hoặc mật khẩu chưa chính xác!" + Environment.NewLine + "Vui lòng thử lại!")
            End Using
        End Using



    End Function
End Class
