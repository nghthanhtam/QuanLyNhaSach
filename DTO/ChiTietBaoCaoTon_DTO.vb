Public Class ChiTietBaoCaoTon_DTO
    Private MaChiTietBaoCaoTon As Integer
    Private MaBaoCaoTon As Integer
    Private MaSach As Integer
    Private TonDau As Integer
    Private PhatSinh As Integer
    Private TonCuoi As Integer

    Public Sub New(maBaoCaoTon As Integer, maSach As Integer, tonDau As Integer, phatSinh As Integer, tonCuoi As Integer)
        Me.MaBaoCaoTon = maBaoCaoTon
        Me.MaSach = maSach
        Me.TonDau = tonDau
        Me.PhatSinh = phatSinh
        Me.TonCuoi = tonCuoi
    End Sub

    Public Property MaChiTietBaoCaoTon1 As Integer
        Get
            Return MaChiTietBaoCaoTon
        End Get
        Set(value As Integer)
            MaChiTietBaoCaoTon = value
        End Set
    End Property

    Public Property MaBaoCaoTon1 As Integer
        Get
            Return MaBaoCaoTon
        End Get
        Set(value As Integer)
            MaBaoCaoTon = value
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

    Public Property TonDau1 As Integer
        Get
            Return TonDau
        End Get
        Set(value As Integer)
            TonDau = value
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

    Public Property TonCuoi1 As Integer
        Get
            Return TonCuoi
        End Get
        Set(value As Integer)
            TonCuoi = value
        End Set
    End Property
End Class
