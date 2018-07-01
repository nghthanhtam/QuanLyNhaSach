Public Class DangNhap_DTO
    Private id As Integer
    Private TenDangNhap As String
    Private MatKhau As String

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property TenDangNhap1 As String
        Get
            Return TenDangNhap
        End Get
        Set(value As String)
            TenDangNhap = value
        End Set
    End Property

    Public Property MatKhau1 As String
        Get
            Return MatKhau
        End Get
        Set(value As String)
            MatKhau = value
        End Set
    End Property
End Class
