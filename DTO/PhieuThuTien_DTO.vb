﻿Public Class PhieuThuTien_DTO
    Private MaPhieuThu As Integer
    Private MaKhachHang As Integer
    Private NgayThuTien As DateTime
    Private SoTienThu As Double

    Public Property MaPhieuThu1 As Integer
        Get
            Return MaPhieuThu
        End Get
        Set(value As Integer)
            MaPhieuThu = value
        End Set
    End Property

    Public Property MaKhachHang1 As Integer
        Get
            Return MaKhachHang
        End Get
        Set(value As Integer)
            MaKhachHang = value
        End Set
    End Property

    Public Property NgayThuTien1 As Date
        Get
            Return NgayThuTien
        End Get
        Set(value As Date)
            NgayThuTien = value
        End Set
    End Property

    Public Property SoTienThu1 As Double
        Get
            Return SoTienThu
        End Get
        Set(value As Double)
            SoTienThu = value
        End Set
    End Property
End Class
