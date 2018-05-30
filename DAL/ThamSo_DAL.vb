Imports System.Data.SqlClient
Imports DTO
Imports Utility

Public Class ThamSo_DAL
    Public Function Update(thamsoDTO As ThamSo_DTO) As Result

        Dim query As String = "Update [THAMSO] SET SoLuongNhapToiThieu = @SoLuongNhapToiThieu, SoLuongTonToiDa = @SoLuongTonToiDa, SoLuongTonToiThieu=@SoLuongTonToiThieu, SoTienNoToiDa=@SoTienNoToiDa, SuDungQD4=@SuDungQD4"

        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@SoLuongNhapToiThieu", thamsoDTO.SoLuongNhapToiThieu1)
                    .Parameters.AddWithValue("@SoLuongTonToiDa", thamsoDTO.SoLuongTonToiDa1)
                    .Parameters.AddWithValue("@SoLuongTonToiThieu", thamsoDTO.SoLuongTonToiThieu1)
                    .Parameters.AddWithValue("@SoTienNoToiDa", thamsoDTO.SoTienNoToiDa1)
                    .Parameters.AddWithValue("@SuDungQD4", thamsoDTO.SuDungQD41)

                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Cập nhật tham số thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, Nothing, "Cập nhật tham số thành công!")

            End Using
        End Using


    End Function

    Public Function SelectAll_ThamSo() As Result

        Dim query As String = "SELECT * FROM [THAMSO]"

        Dim thamSoDTO As New ThamSo_DTO

        Using conn As SqlConnection = ConnectDB.GetConnectionDB()
            Using comm As SqlCommand = conn.CreateCommand()

                With comm
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader
                    If (reader.HasRows = True) Then
                        While reader.Read
                            With thamSoDTO
                                .SoLuongNhapToiThieu1 = Integer.Parse(reader("SoLuongNhapToiThieu"))
                                .SoLuongTonToiDa1 = Integer.Parse(reader("SoLuongTonToiDa"))
                                .SoLuongTonToiThieu1 = Integer.Parse(reader("SoLuongTonToiThieu"))
                                .SoTienNoToiDa1 = Double.Parse(reader("SoTienNoToiDa"))
                                .SuDungQD41 = reader("SuDungQD4")
                            End With
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, Nothing, "Lấy tham số từ hệ thống thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try
                Return New Result(True, thamSoDTO)
            End Using
        End Using

    End Function
End Class
