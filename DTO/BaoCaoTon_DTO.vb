Public Class BaoCaoTon_DTO
    Private MaBaoCaoTon As Integer
    Private Thang As DateTime
    Private NgayLap As DateTime

    Public Sub New(thang As Date, ngayLap As Date)
        Me.Thang = thang
        Me.NgayLap = ngayLap
    End Sub

    Public Property MaBaoCaoTon1 As Integer
        Get
            Return MaBaoCaoTon
        End Get
        Set(value As Integer)
            MaBaoCaoTon = value
        End Set
    End Property

    Public Property Thang1 As Date
        Get
            Return Thang
        End Get
        Set(value As Date)
            Thang = value
        End Set
    End Property

    Public Property NgayLap1 As Date
        Get
            Return NgayLap
        End Get
        Set(value As Date)
            NgayLap = value
        End Set
    End Property
End Class
