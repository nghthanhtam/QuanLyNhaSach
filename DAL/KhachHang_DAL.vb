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

    Public Function SelectALL_ListKhachHang() As Result

        Dim query As String = "SELECT * FROM [KHACHHANG]"

        Dim listKhachHang As New List(Of KhachHang_DTO)
        listKhachHang.Clear()

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
                            listKhachHang.Add(New KhachHang_DTO(Integer.Parse(reader("MaKhachHang")), reader("HoTenKhachHang"), reader("DiaChi"), reader("DienThoai"), reader("Email"), Double.Parse(reader("TienNo"))))
                        End While
                    End If
                Catch ex As Exception
                    Return New Result(False, Nothing, "Lấy danh sách khách hàng thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, listKhachHang)
            End Using
        End Using

    End Function


    Public Function SelectTienNo_KhachHang(iMaKH As Integer) As Result
        Dim tienno As Single
        Dim query As String = String.Empty
        query &= " SELECT [TienNo]"
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
                            tienno = reader("TienNo")
                        End While
                    Else
                        Throw New Exception("Không tìm thấy tiền nợ!")
                    End If

                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Lấy thông tin tiền nợ thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, tienno)
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function SelectALL_ListSachByStringMaKHHoTenSDT(text As String) As Result

        Dim listKhachHang As New List(Of KhachHang_DTO)
        listKhachHang.Clear()

        Dim textMaKhachHang As String = text

        While (textMaKhachHang.IndexOf(" ") <> -1)
            textMaKhachHang = textMaKhachHang.Replace(" ", "")
        End While
        text = " " + text + " "
        While (text.IndexOf("  ") <> -1)
            text = text.Replace("  ", " ")
        End While

        While (text.IndexOf(" ") <> -1)
            text = text.Replace(" ", "%")
        End While


        Dim maKH As Integer
        If (Integer.TryParse(textMaKhachHang, maKH) = True) Then

            Dim res As Result = selectKhachHang_ByMaKhachHang(maKH)
            If (res.FlagResult = True) Then

                listKhachHang.Add(CType(res.Obj1, KhachHang_DTO))

                Return New Result(True, listKhachHang)

            End If
        End If

        Dim query As String = "SELECT * FROM [KHACHHANG] WHERE ([DienThoai] like @text) OR ( [HoTenKhachHang] like @text)   "
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@text", text)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader
                    If (reader.HasRows = True) Then
                        While reader.Read
                            listKhachHang.Add(New KhachHang_DTO(Integer.Parse(reader("MaKhachHang")), reader("HoTenKhachHang"), reader("DiaChi"), reader("DienThoai"), reader("Email"), Double.Parse(reader("TienNo"))))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Tìm kiếm thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, listKhachHang)
            End Using
        End Using

    End Function


    Public Function update(x As KhachHang_DTO) As Result

        Dim query As String = "UPDATE [KHACHHANG] SET [HoTenKhachHang] = @HoTenKhachHang, [DiaChi] = @DiaChi, [DienThoai] = @DienThoai, [Email] = @Email, [TienNo] = @TienNo WHERE MaKhachHang = @MaKhachHang"
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKhachHang", x.MaKH1)
                    .Parameters.AddWithValue("@HoTenKhachHang", x.HoTenKhachHang1)
                    .Parameters.AddWithValue("@DiaChi", x.DiaChi1)
                    .Parameters.AddWithValue("@DienThoai", x.DienThoai1)
                    .Parameters.AddWithValue("@Email", x.Email1)
                    .Parameters.AddWithValue("@TienNo", x.TienNo1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Return New Result(False, Nothing, "Cập nhật thông tin khách hàng thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Cập nhật thông tin khách hàng thành công!")

            End Using
        End Using
        Return New Result(True)
    End Function

    Private Function selectKhachHang_ByMaKhachHang(maKH As Integer) As Result
        Dim khachHangDTO As KhachHang_DTO
        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [KHACHHANG]"
        query &= " WHERE "
        query &= " @MaKhachHang=[MaKhachHang] "

        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKhachHang", maKH)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read

                            khachHangDTO = New KhachHang_DTO(Integer.Parse(reader("MaKhachHang")), reader("HoTenKhachHang"), reader("DiaChi"), reader("DienThoai"), reader("Email"), Double.Parse(reader("TienNo")))
                        End While
                    Else
                        Throw New Exception("Không tìm thấy sách!")
                    End If

                Catch ex As Exception
                    Return New Result(False, Nothing, "Lấy thông tin sách thất bại!", ex.Message)
                Finally
                    conn.Close()

                End Try

                Return New Result(True, khachHangDTO)

            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(x As KhachHang_DTO) As Result
        Dim query As String = "INSERT INTO [KHACHHANG] ([HoTenKhachHang], [TienNo], [DiaChi], [DienThoai], [Email]) VALUES (@HoTenKhachHang, @TienNo, @DiaChi, @DienThoai, @Email)"
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@HoTenKhachHang", x.HoTenKhachHang1)
                    .Parameters.AddWithValue("@TienNo", x.TienNo1)
                    .Parameters.AddWithValue("@DiaChi", x.DiaChi1)
                    .Parameters.AddWithValue("@DienThoai", x.DienThoai1)
                    .Parameters.AddWithValue("@Email", x.Email1)

                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    Return New Result(False, Nothing, "Thêm KH mới thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Thêm KH mới thành công!")

            End Using
        End Using
        Return New Result(True)
    End Function

    Function GetNextIncrement() As Result
        Dim query As String = "SELECT IDENT_CURRENT('KHACHHANG') num"
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
                    Return New Result(False, Nothing, "Lấy mã KH dự định tạo thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Increment + 1)
            End Using
        End Using
    End Function





End Class
