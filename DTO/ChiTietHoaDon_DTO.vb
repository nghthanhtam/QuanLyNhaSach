Public Class ChiTietHoaDon_DTO

    Private MaChiTietHoaDon As Integer
    Private MaHoaDon As Integer
    Private MaSach As Integer
    Private SoLuongban As Integer

    Public Sub New()
    End Sub

    Public Sub New(mact As Integer, mahd As Integer, masach As Integer, sl As Integer)
        Me.MaChiTietHoaDon1 = mact
        Me.MaHoaDon1 = mahd
        Me.MaSach1 = masach
        Me.SoLuongban1 = sl
    End Sub

    Public Property MaChiTietHoaDon1 As Integer
        Get
            Return MaChiTietHoaDon
        End Get
        Set(value As Integer)
            MaChiTietHoaDon = value
        End Set
    End Property

    Public Property MaHoaDon1 As Integer
        Get
            Return MaHoaDon
        End Get
        Set(value As Integer)
            MaHoaDon = value
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

    Public Property SoLuongban1 As Integer
        Get
            Return SoLuongban
        End Get
        Set(value As Integer)
            SoLuongban = value
        End Set
    End Property

End Class
