Imports Utility
Imports DTO
Imports System.Data.SqlClient

Public Class ChiTietBaoCaoCongNo_DAL

    Public Function ThongKeBaoCaoCongNo(thang As Integer, nam As Integer) As Result

        Dim listChiTietBaoCao As New List(Of Object)
        listChiTietBaoCao.Clear()


        Dim query As String = "SELECT thongke.MaKhachHang, KHACHHANG.HoTenKhachHang ,thongke.NoDau, thongke.PhatSinh, thongke.NoCuoi
FROM
(
	SELECT TOP 100 PERCENT ISNULL(thangtruoc.MaKhachHang, thanghientai.MaKhachHang) MaKhachHang, ISNULL(thangtruoc.TienPhatSinh,0) NoDau, ISNULL(thanghientai.TienPhatSinh,0) PhatSinh, ISNULL(thangtruoc.TienPhatSinh,0) + ISNULL(thanghientai.TienPhatSinh,0) NoCuoi
	 FROM 
	 (
		/*của 1 tháng*/
		 SELECT ISNULL(ctmua.MaKhachHang,ctthu.MaKhachHang) as MaKhachHang, ISNULL(ctmua.TongThanhTien,0) - ISNULL(ctthu.TongTienThu,0) as TienPhatSinh
		 FROM
		 (
			 /*Tính tổng tiền mà KH mua trong tháng*/
			SELECT HDThanhTien.MaKhachHang, SUM(HDThanhTien.ThanhTien) TongThanhTien
			FROM
			(
				/*Tính thành tiền của các hóa đơn mà khách hàng mua trong tháng*/
				SELECT MaKhachHang, SoLuongBan*DonGiaBan ThanhTien
				FROM CHITIETHOADON, HOADON
				WHERE HOADON.MaHoaDon = CHITIETHOADON.MaHoaDon AND MONTH(HOADON.NgayLapHoaDon) = @Thang AND YEAR(HOADON.NgayLapHoaDon) = @Nam
			) HDThanhTien
			GROUP BY HDThanhTien.MaKhachHang
		 ) ctmua
		 FULL JOIN
		 (
			 /*Tổng số tiền đã thu của KH trong tháng*/
			SELECT MaKhachHang, sum(SoTienThu) TongTienThu
			FROM PHIEUTHUTIEN
			WHERE MONTH(PHIEUTHUTIEN.NgayThuTien) = @Thang AND YEAR(PHIEUTHUTIEN.NgayThuTien) = @Nam
			GROUP BY MaKhachHang
		 ) ctthu 
		 ON ctmua.MaKhachHang = ctthu.MaKhachHang
	 ) thanghientai

	 FULL JOIN

	 (
		/*của các tháng trước đó*/
		 SELECT ISNULL(ctmua.MaKhachHang,ctthu.MaKhachHang) as MaKhachHang, ISNULL(ctmua.TongThanhTien,0) - ISNULL(ctthu.TongTienThu,0) as TienPhatSinh
		 FROM
		 (
			 /*Tính tổng tiền mà KH mua trong tháng*/
			SELECT HDThanhTien.MaKhachHang, SUM(HDThanhTien.ThanhTien) TongThanhTien
			FROM
			(
				/*Tính thành tiền của các hóa đơn mà khách hàng mua trong tháng*/
				SELECT MaKhachHang, SoLuongBan*DonGiaBan ThanhTien
				FROM CHITIETHOADON, HOADON
				WHERE  HOADON.MaHoaDon = CHITIETHOADON.MaHoaDon AND
				((YEAR(HOADON.NgayLapHoaDon) < @Nam) OR (YEAR(HOADON.NgayLapHoaDon) = @Nam	AND	MONTH(HOADON.NgayLapHoaDon) <@Thang))
			) HDThanhTien
			GROUP BY HDThanhTien.MaKhachHang
		 ) ctmua
		 FULL JOIN
		 (
			 /*Tổng số tiền đã thu của KH trong tháng*/
			SELECT MaKhachHang, sum(SoTienThu) TongTienThu
			FROM PHIEUTHUTIEN
			WHERE  ( (YEAR(PHIEUTHUTIEN.NgayThuTien) < @Nam) OR (YEAR(PHIEUTHUTIEN.NgayThuTien) = @Nam AND MONTH(PHIEUTHUTIEN.NgayThuTien) <@Thang))
			GROUP BY MaKhachHang
		 ) ctthu 
		 ON ctmua.MaKhachHang = ctthu.MaKhachHang
	 ) thangtruoc
	  ON thanghientai.MaKhachHang = thangtruoc.MaKhachHang

 ) thongke, KHACHHANG


WHERE KHACHHANG.MaKhachHang = thongke.MaKhachHang
ORDER BY KHACHHANG.MaKhachHang ASC"

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

                            Dim x As Object = New With {.STT = demSTT, .MaKhachHang = Integer.Parse(reader("MaKhachHang")), .HoTenKhachHang = reader("HoTenKhachHang"), .NoDau = Double.Parse(reader("NoDau")), .PhatSinh = Double.Parse(reader("PhatSinh")), .NoCuoi = Double.Parse(reader("NoCuoi"))}

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
                    .Parameters.AddWithValue("@MaBaoCaoCongNo", x.MaBaoCaoCongNo1)
                    .Parameters.AddWithValue("@MaKhachHang", x.MaKhachHang1)
                    .Parameters.AddWithValue("@NoDau", x.NoDau1)
                    .Parameters.AddWithValue("@PhatSinh", x.PhatSinh1)
                    .Parameters.AddWithValue("@NoCuoi", x.NoCuoi1)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    Return New Result(False, Nothing, "Thêm chi tiết báo cáo công nợ thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Thêm chi tiết báo cáo công nợ thành công!")

            End Using
        End Using
        Return New Result(True)

    End Function

End Class
