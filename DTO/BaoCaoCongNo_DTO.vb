Public Class BaoCaoCongNo_DTO

    Private MaBaoCaoCongNo As Integer
    Private Thang As DateTime
    Private NgayLap As DateTime

    Public Property MaBaoCaoCongNo1 As Integer
        Get
            Return MaBaoCaoCongNo
        End Get
        Set(value As Integer)
            MaBaoCaoCongNo = value
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

