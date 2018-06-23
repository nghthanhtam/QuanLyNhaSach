Public Class ChiTietBaoCaoCongNo_DTO
    Private MaChiTietBaoCaoCongNo As Integer
    Private MaBaoCaoCongNo As Integer
    Private MaKhachHang As Integer
    Private NoDau As Integer
    Private PhatSinh As Integer
    Private NoCuoi As Integer

    Public Sub New(maBaoCaoCongNo As Integer, maKH As Integer, noDau As Integer, phatSinh As Integer, noCuoi As Integer)
        Me.MaBaoCaoCongNo1 = maBaoCaoCongNo
        Me.MaKhachHang1 = maKH
        Me.NoDau1 = noDau
        Me.PhatSinh1 = phatSinh
        Me.NoCuoi1 = noCuoi
    End Sub

    Public Property MaChiTietBaoCaoCongNo1 As Integer
        Get
            Return MaChiTietBaoCaoCongNo
        End Get
        Set(value As Integer)
            MaChiTietBaoCaoCongNo = value
        End Set
    End Property



    Public Property NoDau1 As Integer
        Get
            Return NoDau
        End Get
        Set(value As Integer)
            NoDau = value
        End Set
    End Property

    Public Property PhatSinh1 As Integer
        Get
            Return PhatSinh
        End Get
        Set(value As Integer)
            PhatSinh = value
        End Set
    End Property

    Public Property NoCuoi1 As Integer
        Get
            Return NoCuoi
        End Get
        Set(value As Integer)
            NoCuoi = value
        End Set
    End Property

    Public Property MaBaoCaoCongNo1 As Integer
        Get
            Return MaBaoCaoCongNo
        End Get
        Set(value As Integer)
            MaBaoCaoCongNo = value
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
End Class
