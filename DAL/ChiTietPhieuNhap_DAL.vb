Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class ChiTietPhieuNhap_DAL

    Public Function insertChiTietPhieuNhap(x As ChiTIetPhieuNhap_DTO) As Result
        Dim query As String = "INSERT INTO [CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (@MaPhieuNhap, @MaSach, @SoLuongNhap)"

        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@MaPhieuNhap", x.MaPhieuNhap1)
                    .Parameters.AddWithValue("@MaSach", x.MaSach1)
                    .Parameters.AddWithValue("@SoLuongNhap", x.SoLuongNhap1)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    Return New Result(False, Nothing, "Thêm chi tiết phiếu nhập thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Thêm chi tiết phiếu nhập thành công!")

            End Using
        End Using
        Return New Result(True)
    End Function


    Function GetNextIncrement() As Result
        Dim query As String = "SELECT IDENT_CURRENT('CHITIETPHIEUNHAP') num"
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
                    Return New Result(False, Nothing, "Lấy mã chi tiết phiếu nhập dự định thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Increment + 1)
            End Using
        End Using
    End Function


    Public Function select_MaPhieuNhap() As Result
        Dim query As String = "SELECT TOP 1 [MAPHIEUNHAP] FROM [PHIEUNHAP] ORDER BY [MAPHIEUNHAP] DESC"

        Dim maPhieuNhapDTO As New ChiTIetPhieuNhap_DTO

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
                            With maPhieuNhapDTO
                                .MaPhieuNhap1 = reader("MaPhieuNhap")
                            End With
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Lấy danh sách các đầu sách thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, maPhieuNhapDTO)
            End Using
        End Using
    End Function

End Class
