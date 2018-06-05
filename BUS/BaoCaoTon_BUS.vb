Imports DTO
Imports DAL
Imports Utility

Public Class BaoCaoTon_BUS
    Private baoCaoTonDAL As New BaoCaoTon_DAL

    Public Function insert(x As BaoCaoTon_DTO) As Result
        Return baoCaoTonDAL.insert(x)
    End Function

    Function GetNextIncrement() As Result
        Return baoCaoTonDAL.GetNextIncrement()
    End Function
End Class
