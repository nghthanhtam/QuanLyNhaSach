Public Class HoaDon_DTO

    Private MaHoaDon As Integer
    Private NgayLapHoaDon As DateTime
    Private MaKhachHang As Integer

    Public Sub New(ma As Integer, ngaylap As DateTime, makh As Integer)
        Me.MaHoaDon = ma
        Me.NgayLapHoaDon = ngaylap
        Me.MaKhachHang = makh
    End Sub

    Public Sub New()

    End Sub

    Public Property MaHoaDon1 As Integer
        Get
            Return MaHoaDon
        End Get
        Set(value As Integer)
            MaHoaDon = value
        End Set
    End Property

    Public Property NgayLapHoaDon1 As Date
        Get
            Return NgayLapHoaDon
        End Get
        Set(value As Date)
            NgayLapHoaDon = value
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
