Public Class ChiTietBaoCaoCongNo_DTO
    Private MaChiTietBaoCaoCongNo As Integer
    Private MaBaoCaoTon As Integer
    Private MaSach As Integer
    Private NoDau As Integer
    Private PhatSinh As Integer
    Private NoCuoi As Integer

    Public Sub New(maBaoCaoCongNo As Integer, maSach As Integer, noDau As Integer, phatSinh As Integer, noCuoi As Integer)
        Me.MaBaoCaoTon1 = MaBaoCaoTon1
        Me.MaSach1 = maSach
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

End Class
