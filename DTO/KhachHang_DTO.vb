Public Class KhachHang_DTO

    Private MaKH As Integer
    Private HoTenKhachHang As String
    Private TienNo As String
    Private DiaChi As String
    Private DienThoai As Integer
    Private Email As Double

    Public Sub New()

    End Sub


    Public Sub New(ma As Integer, hoten As String, tienno As String, diachi As String, dt As Integer, email As Double)
        Me.MaKH1 = ma
        Me.HoTenKhachHang1 = hoten
        Me.TienNo1 = tienno
        Me.DiaChi1 = diachi
        Me.DienThoai1 = dt
        Me.Email1 = email
    End Sub

    Public Property MaKH1 As Integer
        Get
            Return MaKH
        End Get
        Set(value As Integer)
            MaKH = value
        End Set
    End Property

    Public Property HoTenKhachHang1 As String
        Get
            Return HoTenKhachHang
        End Get
        Set(value As String)
            HoTenKhachHang = value
        End Set
    End Property

    Public Property TienNo1 As String
        Get
            Return TienNo
        End Get
        Set(value As String)
            TienNo = value
        End Set
    End Property

    Public Property DiaChi1 As String
        Get
            Return DiaChi
        End Get
        Set(value As String)
            DiaChi = value
        End Set
    End Property

    Public Property DienThoai1 As Integer
        Get
            Return DienThoai
        End Get
        Set(value As Integer)
            DienThoai = value
        End Set
    End Property

    Public Property Email1 As Double
        Get
            Return Email
        End Get
        Set(value As Double)
            Email = value
        End Set
    End Property

End Class
