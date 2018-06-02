Public Class KhachHang_DTO

    Private MaKH As Integer
    Private HoTenKhachHang As String
    Private DiaChi As String
    Private DienThoai As String
    Private Email As String
    Private TienNo As Single


    Public Sub New()

    End Sub

    Public Sub New(maKH As Integer, hoTenKhachHang As String, diaChi As String, dienThoai As String, email As String, tienNo As Single)
        Me.MaKH = maKH
        Me.HoTenKhachHang = hoTenKhachHang
        Me.DiaChi = diaChi
        Me.DienThoai = dienThoai
        Me.Email = email
        Me.TienNo = tienNo
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

    Public Property TienNo1 As Single
        Get
            Return TienNo
        End Get
        Set(value As Single)
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

    Public Property DienThoai1 As String
        Get
            Return DienThoai
        End Get
        Set(value As String)
            DienThoai = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property
End Class
