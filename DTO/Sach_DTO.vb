Public Class Sach_DTO
    Private MaSach As Integer
    Private TenSach As String
    Private TheLoai As String
    Private TacGia As String
    Private SoLuongTon As Integer
    Private DonGia As Double

    Public Sub New()

    End Sub


    Public Sub New(ma As Integer, ten As String, loai As String, tacGia As String, slTon As Integer, gia As Double)
        Me.MaSach = ma
        Me.TenSach = ten
        Me.TheLoai = loai
        Me.TacGia = tacGia
        Me.SoLuongTon = slTon
        Me.DonGia = gia
    End Sub

    Public Property MaSach1 As Integer
        Get
            Return MaSach
        End Get
        Set(value As Integer)
            MaSach = value
        End Set
    End Property

    Public Property TenSach1 As String
        Get
            Return TenSach
        End Get
        Set(value As String)
            TenSach = value
        End Set
    End Property

    Public Property TheLoai1 As String
        Get
            Return TheLoai
        End Get
        Set(value As String)
            TheLoai = value
        End Set
    End Property

    Public Property TacGia1 As String
        Get
            Return TacGia
        End Get
        Set(value As String)
            TacGia = value
        End Set
    End Property

    Public Property SoLuongTon1 As Integer
        Get
            Return SoLuongTon
        End Get
        Set(value As Integer)
            SoLuongTon = value
        End Set
    End Property

    Public Property DonGia1 As Double
        Get
            Return DonGia
        End Get
        Set(value As Double)
            DonGia = value
        End Set
    End Property
End Class
