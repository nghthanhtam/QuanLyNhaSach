Public Class BaoCaoCongNo_DTO

    Private MaBaoCaoCongNo As Integer
    Private Thang As DateTime
    Private NgayLap As DateTime

    Public Sub New(thang1 As Date, ngayLap1 As Date)
        Me.Thang1 = thang1
        Me.NgayLap1 = ngayLap1
    End Sub

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

