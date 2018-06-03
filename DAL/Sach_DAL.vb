Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class Sach_DAL

    Public Function insertSach(x As Sach_DTO) As Result
        Dim query As String = "INSERT INTO [SACH] ([TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (@TenSach, @TheLoai, @TacGia, @SoLuongTon, @DonGia)"
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm


                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@TenSach", x.TenSach1)
                    .Parameters.AddWithValue("@TheLoai", x.TheLoai1)
                    .Parameters.AddWithValue("@TacGia", x.TacGia1)
                    .Parameters.AddWithValue("@SoLuongTon", x.SoLuongTon1)
                    .Parameters.AddWithValue("@DonGia", x.DonGia1)

                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Thêm sách mới thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Thêm sách mới thành công!")

            End Using
        End Using
        Return New Result(True)
    End Function


    Function GetNextIncrement() As Result
        Dim query As String = "SELECT IDENT_CURRENT('SACH') num"
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
                    Return New Result(False, Nothing, "Lấy mã sách dự định tạo thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Increment + 1)
            End Using
        End Using
    End Function


    Public Function deleteSach(sachDTO As Sach_DTO) As Result

        Dim query As String = "DELETE [SACH] WHERE MaSach = @MaSach"
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm


                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSach", sachDTO.MaSach1)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Xóa sách thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Xóa sách thành công!")

            End Using
        End Using
        Return New Result(True)

    End Function


    Public Function SelectALL_ListSachByStringMaSachTenSach_Advanced(text As String, Advanced As String) As Result

        Dim listSach As New List(Of Sach_DTO)
        listSach.Clear()

        Dim textMaSach As String = text

        While (textMaSach.IndexOf(" ") <> -1)
            textMaSach = textMaSach.Replace(" ", "")
        End While
        text = " " + text + " "
        While (text.IndexOf("  ") <> -1)
            text = text.Replace("  ", " ")
        End While

        While (text.IndexOf(" ") <> -1)
            text = text.Replace(" ", "%")
        End While


        Dim masach As Integer
        If (Integer.TryParse(textMaSach, masach) = True) Then
            Dim res As Result = selectSach_ByMaSach_Advanced(masach, Advanced)
            If (res.FlagResult = True) Then
                listSach.Add(CType(res.Obj1, Sach_DTO))
                Return New Result(True, listSach)
            End If
        End If

        Dim query As String = "SELECT * FROM [SACH] WHERE ( ([MaSach] like @textGoc) OR ( [TenSach] like @text) )  " + Advanced
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm


                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@textGoc", textMaSach)
                    .Parameters.AddWithValue("@text", text)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader
                    If (reader.HasRows = True) Then
                        While reader.Read
                            listSach.Add(New Sach_DTO(Integer.Parse(reader("MaSach")), reader("TenSach"), reader("TheLoai"), reader("TacGia"), Integer.Parse(reader("SoLuongTon")), Double.Parse(reader("DonGia"))))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Tìm kiếm thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, listSach)
            End Using
        End Using
    End Function

    Public Function SelectALL_ListSachByStringMaSachTenSach(text As String) As Result

        Dim listSach As New List(Of Sach_DTO)
        listSach.Clear()

        Dim textMaSach As String = text

        While (textMaSach.IndexOf(" ") <> -1)
            textMaSach = textMaSach.Replace(" ", "")
        End While
        text = " " + text + " "
        While (text.IndexOf("  ") <> -1)
            text = text.Replace("  ", " ")
        End While

        While (text.IndexOf(" ") <> -1)
            text = text.Replace(" ", "%")
        End While


        Dim masach As Integer
        If (Integer.TryParse(textMaSach, masach) = True) Then

            Dim res As Result = selectSach_ByMaSach(masach)
            If (res.FlagResult = True) Then

                listSach.Add(CType(res.Obj1, Sach_DTO))
                Return New Result(True, listSach)

            End If
        End If



        Dim query As String = "SELECT * FROM [SACH] WHERE ([MaSach] like @textGoc) OR ( [TenSach] like @text)   "
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm


                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@textGoc", textMaSach)
                    .Parameters.AddWithValue("@text", text)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader
                    If (reader.HasRows = True) Then
                        While reader.Read
                            listSach.Add(New Sach_DTO(Integer.Parse(reader("MaSach")), reader("TenSach"), reader("TheLoai"), reader("TacGia"), Integer.Parse(reader("SoLuongTon")), Double.Parse(reader("DonGia"))))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Tìm kiếm thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, listSach)
            End Using
        End Using
    End Function

    Public Function selectSach_ByMaSach_Advanced(iMaSach As Integer, Advanced As String) As Result
        Dim sach As Sach_DTO
        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [SACH]"
        query &= " WHERE "
        query &= " ( @MaSach=[MaSach] )  " + Advanced

        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()
                With comm

                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSach", iMaSach)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read
                            sach = New Sach_DTO(reader("MaSach"), reader("TenSach"), reader("TheLoai"), reader("TacGia"), reader("SoLuongTon"), reader("DonGia"))
                            '  Debug.WriteLine(sach)
                        End While
                    Else
                        Throw New Exception("Không tìm thấy sách!")
                    End If

                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Lấy thông tin sách thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, sach)
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectSach_ByMaSach(iMaSach As Integer) As Result
        Return selectSach_ByMaSach_Advanced(iMaSach, "")
    End Function


    Public Function updateSach(x As Sach_DTO) As Result

        Dim query As String = "UPDATE [SACH] SET [TenSach] = @TenSach, [TheLoai] = @TheLoai, [TacGia] = @TacGia, [SoLuongTon] = @SoLuongTon, [DonGia] = @DonGia WHERE MaSach = @MaSach"
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm


                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSach", x.MaSach1)
                    .Parameters.AddWithValue("@TenSach", x.TenSach1)
                    .Parameters.AddWithValue("@TheLoai", x.TheLoai1)
                    .Parameters.AddWithValue("@TacGia", x.TacGia1)
                    .Parameters.AddWithValue("@SoLuongTon", x.SoLuongTon1)
                    .Parameters.AddWithValue("@DonGia", x.DonGia1)

                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Cập nhật thông tin sách thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Cập nhật thông tin sách thành công!")

            End Using
        End Using
        Return New Result(True)

    End Function

    Public Function SelectALL_ListSach() As Result
        Return SelectALL_ListSach_Advanced("")
    End Function

    Public Function SelectALL_ListSach_Advanced(Advanced As String) As Result
        Dim query As String = "SELECT * FROM [SACH] Where (1=1) " + Advanced

        Dim listSach As New List(Of Sach_DTO)
        listSach.Clear()

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
                            listSach.Add(New Sach_DTO(Integer.Parse(reader("MaSach")), reader("TenSach"), reader("TheLoai"), reader("TacGia"), Integer.Parse(reader("SoLuongTon")), Double.Parse(reader("DonGia"))))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Lấy danh sách các đầu sách thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, listSach)
            End Using
        End Using


    End Function

    Public Function SelectALL_ListTheLoai() As Result

        Dim query As String = "SELECT DISTINCT [TheLoai] FROM [SACH] ORDER BY [TheLoai] ASC"

        Dim listTheLoai As New List(Of String)
        listTheLoai.Clear()

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
                            listTheLoai.Add(reader("TheLoai"))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Lấy danh sách thể loại thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, listTheLoai)
            End Using
        End Using

    End Function



End Class
