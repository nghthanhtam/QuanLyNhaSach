Imports DTO
Imports DAL
Imports Utility

Public Class BaoCaoCongNo_BUS
    Private baoCaoCongNoDAL As New BaoCaoCongNo_DAL

    Public Function insert(x As BaoCaoCongNo_DTO) As Result
        Return baoCaoCongNoDAL.insert(x)
    End Function

    Function GetNextIncrement() As Result
        Return baoCaoCongNoDAL.GetNextIncrement()
    End Function
End Class
