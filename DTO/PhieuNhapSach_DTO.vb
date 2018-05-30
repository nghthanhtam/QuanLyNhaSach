Public Class PhieuNhapSach_DTO

    Private MaPhieuNhap As Integer
    Private NgayNhap As DateTime

    Public Sub New()

    End Sub

    Public Property MaPhieuNhap1 As Integer
        Get
            Return MaPhieuNhap
        End Get
        Set(value As Integer)
            MaPhieuNhap = value
        End Set
    End Property

    Public Property NgayNhap1 As Date
        Get
            Return NgayNhap
        End Get
        Set(value As Date)
            NgayNhap = value
        End Set
    End Property

End Class

