Imports System.ComponentModel
Imports System.IO
Imports System.Threading
Imports System.Xml
Imports Utility

Public Class frm_LoadDB
    Private Sub frm_LoadDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_ThanhTrangThaiTren.Controls.Add(New ThanhTrangThaiTren("Load cấu hình CSDL"))

        Timer.Start()


    End Sub

    Private Sub frm_LoadDB_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged

    End Sub




    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        Timer.Stop()

        Debug.WriteLine("van con chay timer")

            Dim ConnectionString As String = ""
            If ((File.Exists("ConfigDB.xml"))) Then
                Dim objXmlTextReader As XmlTextReader = New XmlTextReader("ConfigDB.xml")
                Dim sName As String = ""
                While (objXmlTextReader.Read())
                    Select Case objXmlTextReader.NodeType
                        Case XmlNodeType.Element
                            sName = objXmlTextReader.Name
                        Case XmlNodeType.Text
                            If (sName = "ConnectionString") Then
                                ConnectionString = objXmlTextReader.Value
                            End If
                    End Select
            End While
            objXmlTextReader.Close()
        End If

            ConnectDB.ConnectionStringConnectDB = ConnectionString

            If (ConnectionString = "") Then
                Panel_Nhap.Visible = True
                PictureBox_load.Visible = False
                Debug.WriteLine("Empty config")
            Else

                Dim kqCheckConnect As Boolean
                kqCheckConnect = ConnectDB.CheckConnectionDB()

                If (kqCheckConnect = False) Then
                    Panel_Nhap.Invoke(
                    Sub()
                        Panel_Nhap.Visible = True
                    End Sub)

                    PictureBox_load.Invoke(
                    Sub()
                        PictureBox_load.Visible = False
                    End Sub)
                    Debug.WriteLine("Sai config")
                Else
                    Dim frmMain As New frm_Main
                    frmMain.Show()
                    Me.Close()
                End If
            End If
    End Sub



    Private Sub btn_KetNoiCSDL_Click(sender As Object, e As EventArgs) Handles btn_KetNoiCSDL.Click

        Dim loi As Boolean = False
        Dim objXmlTextWriter As XmlTextWriter
        'ghi ra file xml
        Try
            objXmlTextWriter = New XmlTextWriter("ConfigDB.xml", Nothing)
            objXmlTextWriter.Formatting = Formatting.Indented
            objXmlTextWriter.WriteStartDocument()
            objXmlTextWriter.WriteStartElement("ConfigDB")
            objXmlTextWriter.WriteStartElement("ConnectionString")
            objXmlTextWriter.WriteString(txt_ConnectionString.Text)
            objXmlTextWriter.WriteEndElement()
            objXmlTextWriter.WriteEndElement()
            objXmlTextWriter.WriteEndDocument()
            objXmlTextWriter.Flush()

        Catch ex As Exception
            loi = True
            MessageBox.Show("Không thể lưu cấu hình ConnectionString!" + Environment.NewLine + ex.Message, "Có lỗi xảy!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objXmlTextWriter.Close()
        End Try

        If (loi = False) Then
            Panel_Nhap.Visible = False
            PictureBox_load.Visible = True
            Timer.Start()
        End If




    End Sub
End Class