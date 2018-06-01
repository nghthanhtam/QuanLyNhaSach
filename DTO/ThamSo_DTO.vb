
Public Class ThamSo_DTO

    ''' <summary>
    ''' Số lượng nhập tối thiểu mỗi khi nhập sách về
    ''' </summary>
    Private SoLuongNhapToiThieu As Integer

    ''' <summary>
    ''' Số lượng tồn tối đa cho phép nhập sách
    ''' </summary>
    Private SoLuongTonToiDa As Integer


    Private SoLuongTonToiThieu As Integer
    Private SoTienNoToiDa As Double
    Private SuDungQD4 As Boolean

    Public Property SoLuongNhapToiThieu1 As Integer
        Get
            Return SoLuongNhapToiThieu
        End Get
        Set(value As Integer)
            SoLuongNhapToiThieu = value
        End Set
    End Property

    Public Property SoLuongTonToiDa1 As Integer
        Get
            Return SoLuongTonToiDa
        End Get
        Set(value As Integer)
            SoLuongTonToiDa = value
        End Set
    End Property

    Public Property SoLuongTonToiThieu1 As Integer
        Get
            Return SoLuongTonToiThieu
        End Get
        Set(value As Integer)
            SoLuongTonToiThieu = value
        End Set
    End Property

    Public Property SoTienNoToiDa1 As Double
        Get
            Return SoTienNoToiDa
        End Get
        Set(value As Double)
            SoTienNoToiDa = value
        End Set
    End Property

    Public Property SuDungQD41 As Boolean
        Get
            Return SuDungQD4
        End Get
        Set(value As Boolean)
            SuDungQD4 = value
        End Set
    End Property

End Class
