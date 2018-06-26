Imports Utility
Imports DTO
Imports System.Data.SqlClient

Public Class ChiTietBaoCaoTon_DAL
    Public Function ThongKeBaoCaoTon(thang As Integer, nam As Integer) As Result

        Dim listChiTietBaoCao As New List(Of Object)
        listChiTietBaoCao.Clear()


        Dim query As String ="
 SELECT  thongke.MaSach,sachfull.TenSach, thongke.TonDau, thongke.PhatSinh, thongke.TonCuoi
FROM
(
	SELECT TOP 100 PERCENT ISNULL(tonthang.MaSach, tontruoc.MaSach) MaSach, ISNULL(tontruoc.SLSachTon, 0) TonDau, ISNULL(tonthang.SLSachTon, 0) PhatSinh 
	,ISNULL(tonthang.SLSachTon , 0) + ISNULL(tontruoc.SLSachTon , 0) TonCuoi
	FROM 
	(
		/*Của 1 tháng*/
		 SELECT ISNULL(ctban.MaSach,ctnhap.MaSach) as MaSach,  ISNULL(ctnhap.SLSach,0)- ISNULL(ctban.SLSach,0) as SLSachTon
		FROM   
		(
		 SELECT CHITIETHOADON.MaSach, SUm(CHITIETHOADON.SoLuongBan) SLSach
		  FROM CHITIETHOADON, HOADON
		  WHERE CHITIETHOADON.MaHoaDon = HOADON.MaHoaDon AND MONTH(HOADON.NgayLapHoaDon) = @Thang AND YEAR(HOADON.NgayLapHoaDon) = @Nam
		 GROUP BY CHITIETHOADON.MaSach
		) ctban
		FULL JOIN
		(
			SELECT CHITIETPHIEUNHAP.MaSach, SUm(CHITIETPHIEUNHAP.SoLuongNhap) SLSach
			  FROM CHITIETPHIEUNHAP, PHIEUNHAP
			  WHERE CHITIETPHIEUNHAP.MaPhieuNhap = PHIEUNHAP.MaPhieuNhap AND MONTH(PHIEUNHAP.NgayNhap) = @Thang AND YEAR(PHIEUNHAP.NgayNhap) = @Nam 
			 GROUP BY CHITIETPHIEUNHAP.MaSach
		) ctnhap
		ON ctban.MaSach = ctnhap.MaSach
	) tonthang

	FULL JOIN

	(
		/*Từ đầu đến trước tháng đó*/
		 SELECT ISNULL(ctban.MaSach,ctnhap.MaSach) as MaSach,  ISNULL(ctnhap.SLSach,0)- ISNULL(ctban.SLSach,0) as SLSachTon
		FROM  
		(
		 SELECT CHITIETHOADON.MaSach, SUm(CHITIETHOADON.SoLuongBan) SLSach
		  FROM CHITIETHOADON, HOADON
		  WHERE CHITIETHOADON.MaHoaDon = HOADON.MaHoaDon AND
		 ( (YEAR(HOADON.NgayLapHoaDon) < @Nam) OR	 (	YEAR(HOADON.NgayLapHoaDon) = @Nam AND MONTH(HOADON.NgayLapHoaDon) <@Thang )  )
		 GROUP BY CHITIETHOADON.MaSach
		) ctban 
		FULL JOIN  
		(
			SELECT CHITIETPHIEUNHAP.MaSach, SUm(CHITIETPHIEUNHAP.SoLuongNhap) SLSach
			  FROM CHITIETPHIEUNHAP, PHIEUNHAP
			  WHERE  CHITIETPHIEUNHAP.MaPhieuNhap = PHIEUNHAP.MaPhieuNhap  AND
			   ( (YEAR(PHIEUNHAP.NgayNhap) < @Nam) OR (	YEAR(PHIEUNHAP.NgayNhap) = @Nam	AND	MONTH(PHIEUNHAP.NgayNhap) <@Thang) )	  
			 GROUP BY CHITIETPHIEUNHAP.MaSach
		) ctnhap
		ON ctban.MaSach = ctnhap.MaSach
	) tontruoc
	ON tonthang.MaSach = tontruoc.MaSach

 ) AS thongke, SACH as sachfull
 
WHERE thongke.MaSach = sachfull.MaSach
ORDER BY sachfull.MaSach ASC
"

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

                            Dim x As Object = New With {.STT = demSTT, .MaSach = Integer.Parse(reader("MaSach")), .TenSach = reader("TenSach"), .TonDau = Integer.Parse(reader("TonDau")), .PhatSinh = Integer.Parse(reader("PhatSinh")), .TonCuoi = Integer.Parse(reader("TonCuoi"))}

                            listChiTietBaoCao.Add(x)

                        End While
                    End If
                Catch ex As Exception
                    Return New Result(False, Nothing, "Thống kê sách tồn thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, listChiTietBaoCao)
            End Using
        End Using

    End Function



    Public Function insert(x As ChiTietBaoCaoTon_DTO) As Result

        Dim query As String = "INSERT INTO [CHITIETBAOCAOTON] ([MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (@MaBaoCaoTon, @MaSach, @TonDau, @PhatSinh, @TonCuoi)"
        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()
                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaBaoCaoTon", x.MaBaoCaoTon1)
                    .Parameters.AddWithValue("@MaSach", x.MaSach1)
                    .Parameters.AddWithValue("@TonDau", x.TonDau1)
                    .Parameters.AddWithValue("@PhatSinh", x.PhatSinh1)
                    .Parameters.AddWithValue("@TonCuoi", x.TonCuoi1)
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
