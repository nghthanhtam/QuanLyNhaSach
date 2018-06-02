Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class PhieuThuTien_DAL






    Function GetNextIncrement() As Result
        Dim query As String = "SELECT IDENT_CURRENT('PHIEUTHUTIEN') num"
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
                    Return New Result(False, Nothing, "Lấy mã phiếu thu tiền dự định tạo thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Increment + 1)
            End Using
        End Using
    End Function

    Public Function insert(x As PhieuThuTien_DTO) As Result
        Dim query As String = "INSERT INTO [PHIEUTHUTIEN] ([MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (@MaKhachHang, @NgayThuTien, @SoTienThu)"
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKhachHang", x.MaKhachHang1)
                    .Parameters.AddWithValue("@NgayThuTien", x.NgayThuTien1)
                    .Parameters.AddWithValue("@SoTienThu", x.SoTienThu1)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    Return New Result(False, Nothing, "Thêm phiếu thu tiền mới thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Thêm phiếu thu tiền mới thành công!")

            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectAll_ListPhieuThuTien() As Result
        Dim query As String = "SELECT [MaPhieuThu],[PHIEUTHUTIEN].[MaKhachHang],[HoTenKhachHang],[NgayThuTien],[SoTienThu] FROM [PHIEUTHUTIEN],[KHACHHANG] WHERE [PHIEUTHUTIEN].[MaKhachHang] = [KHACHHANG].[MaKhachHang]"

        Dim listPhieuThuTien As New List(Of Object)
        listPhieuThuTien.Clear()

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
                            Dim x As Object = New With {.MaPhieuThu = Integer.Parse(reader("MaPhieuThu")), .MaKhachHang = Integer.Parse(reader("MaKhachHang")), .SoTienThu = Double.Parse(reader("SoTienThu")), .NgayThuTien = DateTime.Parse(reader("NgayThuTien")), .HoTenKhachHang = reader("HoTenKhachHang")}
                            listPhieuThuTien.Add(x)
                        End While
                    End If
                Catch ex As Exception
                    Return New Result(False, Nothing, "Lấy danh sách phiếu thu tiền thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, listPhieuThuTien)
            End Using
        End Using
    End Function
End Class
