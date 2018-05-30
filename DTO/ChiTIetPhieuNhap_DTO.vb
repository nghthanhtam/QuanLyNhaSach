Public Class ChiTIetPhieuNhap_DTO
    Private MaChiTietPhieuNhap As Integer
    Private MaPhieuNhap As Integer
    Private MaSach As Integer
    Private SoLuongNhap As Integer

    Public Sub New()

    End Sub

    Public Sub New(ma As Integer, mapn As Integer, mas As Integer, sl As Integer)
        Me.MaChiTietPhieuNhap = ma
        Me.MaPhieuNhap = mapn
        Me.MaSach = mas
        Me.SoLuongNhap = sl
    End Sub

    Public Property MaChiTietPhieuNhap1 As Integer
        Get
            Return MaChiTietPhieuNhap
        End Get
        Set(value As Integer)
            MaChiTietPhieuNhap = value
        End Set
    End Property

    Public Property MaPhieuNhap1 As Integer
        Get
            Return MaPhieuNhap
        End Get
        Set(value As Integer)
            MaPhieuNhap = value
        End Set
    End Property

    Public Property MaSach1 As Integer
        Get
            Return MaSach
        End Get
        Set(value As Integer)
            MaSach = value
        End Set
    End Property

    Public Property SoLuongNhap1 As Integer
        Get
            Return SoLuongNhap
        End Get
        Set(value As Integer)
            SoLuongNhap = value
        End Set
    End Property

End Class
