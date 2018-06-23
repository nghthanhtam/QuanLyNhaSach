Imports Utility
Imports DTO
Imports System.Data.SqlClient

Public Class ChiTietBaoCaoCongNo_DAL

    Public Function ThongKeBaoCaoCongNo(thang As Integer, nam As Integer) As Result

        Dim listChiTietBaoCao As New List(Of Object)
        listChiTietBaoCao.Clear()


        Dim query As String = ""

        'Viet cho nay ne :v

        '''''''''''''''''''''''''''''''











        Dim demSTT As Integer = 0

        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Nam", nam)
                    .Parameters.AddWithValue("@Thang", thang)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader
                    If (reader.HasRows = True) Then
                        While reader.Read

                            demSTT += 1

                            Dim x As Object = New With {.STT = demSTT, .MaKhachHang = Integer.Parse(reader("MaKhachHang")), .TenSach = reader("HoTenKhachHang"), .NoDau = Integer.Parse(reader("NoDau")), .PhatSinh = Integer.Parse(reader("PhatSinh")), .NoCuoi = Integer.Parse(reader("NoCuoi"))}

                            listChiTietBaoCao.Add(x)

                        End While
                    End If
                Catch ex As Exception
                    Return New Result(False, Nothing, "Thống kê nợ thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, listChiTietBaoCao)
            End Using
        End Using

    End Function


    Public Function insert(x As ChiTietBaoCaoCongNo_DTO) As Result

        Dim query As String = "INSERT INTO [CHITIETBAOCAOCONGNO] ([MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (@MaBaoCaoCongNo, @MaKhachHang, @NoDau, @PhatSinh, @NoCuoi)"
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()
                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaBaoCaoTon", x.MaBaoCaoTon1)
                    .Parameters.AddWithValue("@MaSach", x.MaSach1)
                    .Parameters.AddWithValue("@TonDau", x.NoDau1)
                    .Parameters.AddWithValue("@PhatSinh", x.PhatSinh1)
                    .Parameters.AddWithValue("@TonCuoi", x.NoCuoi1)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    Return New Result(False, Nothing, "Thêm chi tiết báo cáo thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Thêm chi tiết báo cáo thành công!")

            End Using
        End Using
        Return New Result(True)

    End Function

End Class
