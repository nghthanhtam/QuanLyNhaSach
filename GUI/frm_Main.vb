﻿Public Class frm_Main


    Private ButtonClickTr As Object = Nothing




    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.Location = New Point(0, 0)
        ' Me.Size = New Size(My.Computer.Screen.WorkingArea.Size.Width, My.Computer.Screen.WorkingArea.Size.Height)


        'MessageBox.Show(Panel_LoadUC.Size.Width.ToString() + " " + Panel_LoadUC.Size.Height.ToString())
        '  MessageBox.Show(Panel_LoadUC.Location.X.ToString() + " " + Panel_LoadUC.Location.Y.ToString())





    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        ' Add any initialization after the InitializeComponent() call.



        Panel_LoadUC.Size = New Size(Me.Size.Width - Panel_LoadUC.Location.X, Me.Size.Height - Panel_LoadUC.Location.Y)


    End Sub

    Private Sub frm_Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize


    End Sub


    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown

    End Sub


    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If (e.Button = MouseButtons.Left) Then
            Me.Size = New Size(MousePosition.X - Me.Location.X, MousePosition.Y - Me.Location.Y)

            Panel_ThanhTrangThaiTren.reloadThanhTrangThai()

            Dim xxx As Object = New UC_TraCuuSach()


            reloadGUI_MouseMove()
        End If
    End Sub


    Public Sub reloadGUI_MouseMove()
        'Panel_LoadUC.Size = New Size(MousePosition.X - Panel_LoadUC.Location.X - 298, MousePosition.Y - Panel_LoadUC.Location.Y - 127)


        Panel_LoadUC.Size = New Size(MousePosition.X - Me.Location.X - Panel_LoadUC.Location.X, MousePosition.Y - Panel_LoadUC.Location.Y - Me.Location.Y)



        Panel_Menu.Size = New Size(Panel_Menu.Size.Width, MousePosition.Y - Me.Location.Y - 40)



        ' Panel_LoadUC.Size = New Size(MousePosition.X - Panel_LoadUC.Location.X, MousePosition.Y - Panel_LoadUC.Location.Y - 127)

        'Panel_Menu.Size = New Size(Panel_Menu.Size.Width, MousePosition.Y - Me.Location.Y)

        'Debug.WriteLine("")
        'Debug.WriteLine("Vi tri chuot: " + MousePosition.ToString)
        'Debug.WriteLine("Vi tri app: " + Me.Location.ToString)

        'Debug.WriteLine("Vi tri panel: " + Panel_LoadUC.Location.ToString)
        'Debug.WriteLine("Size panel: " + Panel_LoadUC.Size.ToString)



    End Sub




    Private Sub btn_TraCuuSach_Click(sender As Object, e As EventArgs) Handles btn_TraCuuSach.Click
        Panel_LoadUC.Controls.Clear()
        Panel_LoadUC.Controls.Add(New UC_TraCuuSach())



        '  New UC_TraCuuSach(

    End Sub

    Private Sub btn_LapPhieuNhapSach_Click(sender As Object, e As EventArgs) Handles btn_LapPhieuNhapSach.Click
        Panel_LoadUC.Controls.Clear()
        Panel_LoadUC.Controls.Add(New UC_NhapSach())
    End Sub

    Private Sub btn_LapHoaDonBanSach_Click(sender As Object, e As EventArgs) Handles btn_LapHoaDonBanSach.Click
        Panel_LoadUC.Controls.Clear()
        Panel_LoadUC.Controls.Add(New UC_LapHoaDon())
    End Sub

    Private Sub btn_LapPhieuThuTien_Click(sender As Object, e As EventArgs) Handles btn_LapPhieuThuTien.Click

    End Sub

    Private Sub btn_LapBaoCaoThang_Click(sender As Object, e As EventArgs) Handles btn_LapBaoCaoThang.Click

    End Sub

    Private Sub btn_ThayDoiQuiDinh_Click(sender As Object, e As EventArgs) Handles btn_ThayDoiQuiDinh.Click
        Panel_LoadUC.Controls.Clear()
        Panel_LoadUC.Controls.Add(New UC_ThayDoiQuyDinh())

    End Sub

    Private Sub btn_QuanLiSach_Click(sender As Object, e As EventArgs) Handles btn_QuanLiSach.Click
        Panel_LoadUC.Controls.Clear()
        Panel_LoadUC.Controls.Add(New UC_QuanLiSach())

    End Sub

End Class