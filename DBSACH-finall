USE [master]
GO

CREATE DATABASE [DBSACH_UIT2T]
 
GO
USE [DBSACH_UIT2T]
GO
/****** Object:  Table [dbo].[BAOCAOCONGNO]    Script Date: 02-07-2018 12:11:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAOCONGNO](
	[MaBaoCaoCongNo] [int] IDENTITY(1,1) NOT NULL,
	[Thang] [datetime2](7) NULL,
	[NgayLap] [datetime2](7) NULL,
 CONSTRAINT [PK_BAOCAOCONGNO] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoCongNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BAOCAOTON]    Script Date: 02-07-2018 12:11:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAOTON](
	[MaBaoCaoTon] [int] IDENTITY(1,1) NOT NULL,
	[Thang] [datetime2](7) NULL,
	[NgayLap] [datetime2](7) NULL,
 CONSTRAINT [PK_BAOCAOTON] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoTon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETBAOCAOCONGNO]    Script Date: 02-07-2018 12:11:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETBAOCAOCONGNO](
	[MaChiTietBaoCaoCongNo] [int] IDENTITY(1,1) NOT NULL,
	[MaBaoCaoCongNo] [int] NULL,
	[MaKhachHang] [int] NULL,
	[NoDau] [float] NULL,
	[PhatSinh] [float] NULL,
	[NoCuoi] [float] NULL,
 CONSTRAINT [PK_CHITIETBAOCAOCONGNO] PRIMARY KEY CLUSTERED 
(
	[MaChiTietBaoCaoCongNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETBAOCAOTON]    Script Date: 02-07-2018 12:11:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETBAOCAOTON](
	[MaChiTietBaoCaoTon] [int] IDENTITY(1,1) NOT NULL,
	[MaBaoCaoTon] [int] NULL,
	[MaSach] [int] NULL,
	[TonDau] [int] NULL,
	[PhatSinh] [int] NULL,
	[TonCuoi] [int] NULL,
 CONSTRAINT [PK_CHITIETBAOCAOTON] PRIMARY KEY CLUSTERED 
(
	[MaChiTietBaoCaoTon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 02-07-2018 12:11:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaChiTietHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaHoaDon] [int] NULL,
	[MaSach] [int] NULL,
	[SoLuongBan] [int] NULL,
	[DonGiaBan] [float] NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[MaChiTietHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 02-07-2018 12:11:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[MaChiTietPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuNhap] [int] NULL,
	[MaSach] [int] NULL,
	[SoLuongNhap] [int] NULL,
 CONSTRAINT [PK_CHITIETPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 02-07-2018 12:11:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](100) NULL,
	[MatKhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_DANGNHAP] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 02-07-2018 12:11:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[NgayLapHoaDon] [datetime2](7) NULL,
	[MaKhachHang] [int] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 02-07-2018 12:11:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[HoTenKhachHang] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[TienNo] [float] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 02-07-2018 12:11:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[NgayNhap] [datetime2](7) NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUTHUTIEN]    Script Date: 02-07-2018 12:11:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUTIEN](
	[MaPhieuThu] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NULL,
	[NgayThuTien] [datetime2](7) NULL,
	[SoTienThu] [float] NULL,
 CONSTRAINT [PK_PHIEUTHUTIEN] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SACH]    Script Date: 02-07-2018 12:11:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](200) NULL,
	[TheLoai] [nvarchar](50) NULL,
	[TacGia] [nvarchar](100) NULL,
	[SoLuongTon] [int] NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 02-07-2018 12:11:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[SoLuongNhapToiThieu] [int] NOT NULL,
	[SoLuongTonToiDa] [int] NOT NULL,
	[SoLuongTonToiThieu] [int] NOT NULL,
	[SoTienNoToiDa] [float] NOT NULL,
	[SuDungQD4] [bit] NOT NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[BAOCAOCONGNO] ON 

INSERT [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo], [Thang], [NgayLap]) VALUES (1, CAST(N'2018-04-01 23:21:34.0000000' AS DateTime2), CAST(N'2018-07-01 23:21:34.8530000' AS DateTime2))
INSERT [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo], [Thang], [NgayLap]) VALUES (2, CAST(N'2018-04-02 00:08:18.0000000' AS DateTime2), CAST(N'2018-07-02 00:08:18.9030000' AS DateTime2))
INSERT [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo], [Thang], [NgayLap]) VALUES (3, CAST(N'2018-05-02 00:08:18.0000000' AS DateTime2), CAST(N'2018-07-02 00:08:18.9030000' AS DateTime2))
INSERT [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo], [Thang], [NgayLap]) VALUES (4, CAST(N'2018-06-02 00:08:18.0000000' AS DateTime2), CAST(N'2018-07-02 00:08:18.9030000' AS DateTime2))
INSERT [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo], [Thang], [NgayLap]) VALUES (5, CAST(N'2018-07-02 00:08:18.0000000' AS DateTime2), CAST(N'2018-07-02 00:08:18.9030000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[BAOCAOCONGNO] OFF
SET IDENTITY_INSERT [dbo].[BAOCAOTON] ON 

INSERT [dbo].[BAOCAOTON] ([MaBaoCaoTon], [Thang], [NgayLap]) VALUES (1, CAST(N'2018-04-01 23:20:55.0000000' AS DateTime2), CAST(N'2018-07-01 23:20:55.0600000' AS DateTime2))
INSERT [dbo].[BAOCAOTON] ([MaBaoCaoTon], [Thang], [NgayLap]) VALUES (2, CAST(N'2018-04-02 00:07:55.0000000' AS DateTime2), CAST(N'2018-07-02 00:07:55.8830000' AS DateTime2))
INSERT [dbo].[BAOCAOTON] ([MaBaoCaoTon], [Thang], [NgayLap]) VALUES (3, CAST(N'2018-05-02 00:07:55.0000000' AS DateTime2), CAST(N'2018-07-02 00:07:55.8830000' AS DateTime2))
INSERT [dbo].[BAOCAOTON] ([MaBaoCaoTon], [Thang], [NgayLap]) VALUES (4, CAST(N'2018-06-02 00:07:55.0000000' AS DateTime2), CAST(N'2018-07-02 00:07:55.8830000' AS DateTime2))
INSERT [dbo].[BAOCAOTON] ([MaBaoCaoTon], [Thang], [NgayLap]) VALUES (5, CAST(N'2018-07-02 00:07:55.0000000' AS DateTime2), CAST(N'2018-07-02 00:07:55.8830000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[BAOCAOTON] OFF
SET IDENTITY_INSERT [dbo].[CHITIETBAOCAOCONGNO] ON 

INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (1, 1, 1, 0, 0, 0)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (2, 1, 2, 0, 309000, 309000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (3, 2, 1, 0, 0, 0)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (4, 2, 2, 0, 309000, 309000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (5, 3, 1, 0, 0, 0)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (6, 3, 2, 309000, 0, 309000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (7, 3, 3, 0, 80000, 80000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (8, 3, 4, 0, 300000, 300000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (9, 4, 1, 0, 0, 0)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (10, 4, 2, 309000, -109000, 200000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (11, 4, 3, 80000, 0, 80000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (12, 4, 4, 300000, 0, 300000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (13, 4, 11, 0, 7900000, 7900000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (14, 4, 12, 0, 800000, 800000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (15, 4, 13, 0, 9696000, 9696000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (16, 5, 1, 0, 21000000, 21000000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (17, 5, 2, 200000, -10000, 190000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (18, 5, 3, 80000, -10000, 70000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (19, 5, 4, 300000, -150000, 150000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (20, 5, 11, 7900000, -900000, 7000000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (21, 5, 12, 800000, -70000, 730000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (22, 5, 13, 9696000, 0, 9696000)
INSERT [dbo].[CHITIETBAOCAOCONGNO] ([MaChiTietBaoCaoCongNo], [MaBaoCaoCongNo], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (23, 5, 14, 0, 20000000, 20000000)
SET IDENTITY_INSERT [dbo].[CHITIETBAOCAOCONGNO] OFF
SET IDENTITY_INSERT [dbo].[CHITIETBAOCAOTON] ON 

INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1, 1, 1, 0, 198, 198)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2, 1, 2, 0, 149, 149)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (3, 1, 3, 0, 149, 149)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (4, 1, 4, 0, 160, 160)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (5, 1, 5, 0, 170, 170)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (6, 2, 1, 0, 198, 198)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (7, 2, 2, 0, 149, 149)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (8, 2, 3, 0, 149, 149)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (9, 2, 4, 0, 160, 160)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (10, 2, 5, 0, 170, 170)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (11, 3, 1, 198, -1, 197)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (12, 3, 2, 149, -2, 147)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (13, 3, 3, 149, 0, 149)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (14, 3, 4, 160, 0, 160)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (15, 3, 5, 170, 0, 170)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (16, 3, 6, 0, 220, 220)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (17, 3, 7, 0, 150, 150)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (18, 3, 8, 0, 170, 170)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (19, 3, 9, 0, 175, 175)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (20, 3, 10, 0, 173, 173)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (21, 3, 11, 0, 170, 170)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (22, 3, 12, 0, 180, 180)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (23, 3, 13, 0, 160, 160)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (24, 3, 14, 0, 190, 190)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (25, 3, 16, 0, 200, 200)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (26, 3, 17, 0, 210, 210)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (27, 3, 19, 0, 198, 198)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (28, 4, 1, 197, -10, 187)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (29, 4, 2, 147, 100, 247)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (30, 4, 3, 149, 200, 349)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (31, 4, 4, 160, 198, 358)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (32, 4, 5, 170, 180, 350)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (33, 4, 6, 220, -100, 120)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (34, 4, 7, 150, -50, 100)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (35, 4, 8, 170, 0, 170)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (36, 4, 9, 175, 0, 175)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (37, 4, 10, 173, 0, 173)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (38, 4, 11, 170, 0, 170)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (39, 4, 12, 180, 0, 180)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (40, 4, 13, 160, 0, 160)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (41, 4, 14, 190, 0, 190)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (42, 4, 16, 200, 0, 200)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (43, 4, 17, 210, 0, 210)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (44, 4, 19, 198, 0, 198)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (45, 5, 1, 187, -12, 175)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (46, 5, 2, 247, -13, 234)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (47, 5, 3, 349, -14, 335)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (48, 5, 4, 358, -12, 346)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (49, 5, 5, 350, -14, 336)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (50, 5, 6, 120, -55, 65)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (51, 5, 7, 100, -12, 88)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (52, 5, 8, 170, -2, 168)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (53, 5, 9, 175, -3, 172)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (54, 5, 10, 173, 199, 372)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (55, 5, 11, 170, 105, 275)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (56, 5, 12, 180, 238, 418)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (57, 5, 13, 160, 37, 197)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (58, 5, 14, 190, 0, 190)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (59, 5, 16, 200, -100, 100)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (60, 5, 17, 210, -100, 110)
INSERT [dbo].[CHITIETBAOCAOTON] ([MaChiTietBaoCaoTon], [MaBaoCaoTon], [MaSach], [TonDau], [PhatSinh], [TonCuoi]) VALUES (61, 5, 19, 198, 0, 198)
SET IDENTITY_INSERT [dbo].[CHITIETBAOCAOTON] OFF
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] ON 

INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (1, 1, 1, 1, 80000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (2, 2, 1, 1, 80000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (3, 2, 2, 1, 79000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (4, 2, 3, 1, 150000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (5, 3, 1, 1, 80000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (6, 4, 2, 2, 79000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (7, 4, 10, 2, 50000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (8, 4, 19, 2, 21000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (9, 5, 2, 100, 79000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (10, 6, 1, 10, 80000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (11, 7, 4, 2, 90000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (12, 7, 5, 20, 40800)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (13, 7, 6, 100, 58000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (14, 7, 7, 50, 72000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (15, 8, 1, 12, 80000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (16, 8, 2, 13, 79000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (17, 8, 3, 14, 150000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (18, 8, 4, 12, 90000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (19, 8, 5, 14, 40800)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (20, 8, 6, 55, 58000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (21, 8, 7, 12, 72000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (22, 8, 8, 2, 56000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (23, 8, 9, 3, 14000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (24, 8, 10, 51, 50000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (25, 8, 11, 145, 73000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (26, 8, 12, 12, 23000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (27, 8, 13, 213, 28000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (28, 9, 16, 100, 60000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (29, 9, 17, 100, 150000)
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] OFF
SET IDENTITY_INSERT [dbo].[CHITIETPHIEUNHAP] ON 

INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (1, 1, 1, 200)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (2, 2, 2, 150)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (3, 2, 3, 150)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (4, 2, 4, 160)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (5, 2, 5, 170)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (6, 3, 6, 220)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (7, 3, 7, 150)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (8, 3, 8, 170)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (9, 3, 9, 175)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (10, 3, 10, 175)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (11, 3, 11, 170)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (12, 3, 12, 180)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (13, 3, 13, 160)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (14, 3, 14, 190)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (15, 3, 16, 200)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (16, 3, 17, 210)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (17, 3, 19, 200)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (18, 4, 2, 200)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (19, 4, 3, 200)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (20, 4, 4, 200)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (21, 4, 5, 200)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (22, 5, 10, 250)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (23, 5, 11, 250)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (24, 5, 12, 250)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (25, 5, 13, 250)
SET IDENTITY_INSERT [dbo].[CHITIETPHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[DANGNHAP] ON 

INSERT [dbo].[DANGNHAP] ([id], [TenDangNhap], [MatKhau]) VALUES (1, N'admin', N'BBB2CA48225EFB207E0EC1CD9F2877BD')
SET IDENTITY_INSERT [dbo].[DANGNHAP] OFF
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (1, CAST(N'2018-04-02 23:15:10.5200000' AS DateTime2), 1)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (2, CAST(N'2018-04-05 23:18:21.0000000' AS DateTime2), 2)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (3, CAST(N'2018-05-01 23:47:56.0670000' AS DateTime2), 3)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (4, CAST(N'2018-05-01 23:47:56.0670000' AS DateTime2), 4)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (5, CAST(N'2018-06-01 23:49:45.7230000' AS DateTime2), 11)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (6, CAST(N'2018-06-15 23:49:45.0000000' AS DateTime2), 12)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (7, CAST(N'2018-06-18 23:49:45.0000000' AS DateTime2), 13)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (8, CAST(N'2018-07-01 23:53:04.9930000' AS DateTime2), 14)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (9, CAST(N'2018-07-02 00:06:14.7700000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (1, N'Nguyễn Huỳnh Thanh Tâm', N'21 Lê Đức Thọ, P.15, TP.HCM', N'0122363295', N'16521062@gm.uit.edu.vn', 21000000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (2, N'Đặng Minh Tiến', N'212/2 đường số 8, Bến Tre', N'0961014106', N'dangminhtien06@gmail.com', 190000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (3, N'Nguyễn Tây Trung', N'33 Lê Đức Thọ, P15, quận Gò Vấp', N'0125334295', N'trungnt@yahoo.com', 70000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (4, N'Huỳnh Hạ Vy', N'120 Hai Bà Trưng, quận 1, TP.HCM', N'0902733050', N'vyvy98@gmail.com.vn', 150000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (5, N'Đỗ Ngọc Bích Trâm', N'212E đường CMT8, Q3, TP.HCM', N'0909322147', N'tramngoc@gmail.com.vn', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (6, N'Phan Trung Hiếu', N'12 Lê Văn Sỹ, Q3, TP.HCM', N'0133451629', N'hieuphan1403@yahoo.com', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (7, N'Huỳnh Phước Thịnh', N'32 Hoàng Văn Thụ, TP.HCM', N'0909281746', N'thinhhh_98@gmail.com.vn', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (9, N'Nguyễn Hải Ngân', N'234/100/1 đường số 2, Lê Văn Thọ, Q. Gò Vấp', N'0167122533', N'ngannghai1201@yahoo.com', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (10, N'Nguyễn Ngọc Mai Thi', N'44/3 Quang Trung, P12, Q. Gò Vấp, TP.HCM', N'0122414529', N'little_flower13@yahoo.com', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (11, N'Nguyễn Xuân Sang', N'45 Lê Thị Riêng TP.HCM', N'0903725416', N'15520983@gm.uit.edu.vn', 7000000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (12, N'Nguyễn Đan Thanh', N'34 Điện Biên Phủ, Q3, TP.HCM', N'0909284517', N'thanhnd@gmail.com', 730000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (13, N'Võ Ngọc Nam An', N'53/2 Hồ Bá Kiện, Q.10, TP.HCM', N'0167453199', N'annam@yahoo.com.vn', 9696000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (14, N'Trương Hồng Hoa', N'412 Phạm Ngọc Thạch, TP.HCM', N'0903129544', N'hoahong113@gmail.com', 20000000)
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap]) VALUES (1, CAST(N'2018-04-01 23:12:37.7170000' AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap]) VALUES (2, CAST(N'2018-04-02 23:13:39.0000000' AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap]) VALUES (3, CAST(N'2018-05-15 23:33:26.0000000' AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap]) VALUES (4, CAST(N'2018-06-10 23:46:52.0000000' AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap]) VALUES (5, CAST(N'2018-07-01 23:46:52.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[PHIEUTHUTIEN] ON 

INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (1, 1, CAST(N'2018-04-04 23:16:27.0000000' AS DateTime2), 50000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (2, 1, CAST(N'2018-04-04 23:17:18.5630000' AS DateTime2), 30000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (3, 2, CAST(N'2018-06-01 23:49:22.0000000' AS DateTime2), 109000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (4, 13, CAST(N'2018-06-18 23:52:01.0000000' AS DateTime2), 200000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (5, 13, CAST(N'2018-06-19 23:52:01.0000000' AS DateTime2), 500000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (6, 12, CAST(N'2018-07-01 23:52:01.0000000' AS DateTime2), 70000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (7, 11, CAST(N'2018-07-02 00:05:10.1000000' AS DateTime2), 900000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (8, 14, CAST(N'2018-07-02 00:05:10.1000000' AS DateTime2), 9321200)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (9, 2, CAST(N'2018-07-02 00:06:45.3270000' AS DateTime2), 10000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (10, 3, CAST(N'2018-07-02 00:07:23.7530000' AS DateTime2), 10000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (11, 4, CAST(N'2018-07-02 00:07:23.7530000' AS DateTime2), 150000)
SET IDENTITY_INSERT [dbo].[PHIEUTHUTIEN] OFF
SET IDENTITY_INSERT [dbo].[SACH] ON 

INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (1, N'Nhà Lãnh Đạo Không Chức Danh', N'Kinh tế', N'Robin Sharma', 175, 80000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (2, N'P.Kotler Tiếp thị 4.0', N'Kinh tế', N'Nguyễn Khoa Hồng Thành', 234, 79000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (3, N'Qua Pixar Là Vô Cực', N'Kinh tế', N'Lawrence Levy', 335, 150000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (4, N'Cẩm Nang Tự Học IELTS', N'Ngoại ngữ', N'Kiên Trần', 346, 90000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (5, N'Đề Kiểm Tra Tiếng Anh Lớp 7', N'Ngoại ngữ', N'Trần Mạnh Tường', 336, 40800)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (6, N'3000 Từ Vựng Tiếng Anh Thông Dụng Nhất', N'Ngoại ngữ', N'The Windy', 65, 58000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (7, N'Tự Học Tiếng Hàn Dành Cho Người Mới Bắt Đầu', N'Ngoại ngữ', N'NXB Thời Đại', 88, 72000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (8, N'Ai và Ky ở xứ sở những con số tàng hình', N'Văn học', N'Ngô Bảo Châu', 168, 56000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (9, N'Tiếng Việt 4', N'Sách giáo khoa', N'Hồ Thị Thập', 172, 14000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (10, N'24 quy tắc học Kanji', N'Tiếng Nhật', N'Trần Việt Thanh', 372, 50000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (11, N'Lịch sử loài người ', N'Lịch sử', N'Nguyễn Thị Mộng, Trần Minh Hòa', 275, 73000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (12, N'Truyện cổ Việt Nam', N'Văn học', N'Minh Triết', 418, 23000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (13, N'Hướng dẫn giải bài tập xác suất thống kê', N'Tham khảo', N'Hà Mạnh Linh, Lê Hoàng Tuấn, Dương Tôn Đảm', 197, 28000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (14, N'Toán học 10', N'Sách giáo khoa', N'Đỗ Thanh Sơn, Bùi Thị Kim Hoa', 190, 12000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (16, N'Những bài làm văn mẫu 9', N'Sách giáo khoa', N'Huỳnh Văn Bánh', 100, 60000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (17, N'Qua Pixar là vô cực', N'Kinh tế', N'Lawrence', 110, 150000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (19, N'Nhật ký Ngốc Xít', N'Văn học', N'Cohan Serance', 198, 21000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (20, N'Tài liệu giáo khoa chuyên tin 1', N'Tin học', N'Lê Minh Hoàng', 0, 100000)
SET IDENTITY_INSERT [dbo].[SACH] OFF
INSERT [dbo].[THAMSO] ([SoLuongNhapToiThieu], [SoLuongTonToiDa], [SoLuongTonToiThieu], [SoTienNoToiDa], [SuDungQD4]) VALUES (150, 300, 20, 20000, 1)
ALTER TABLE [dbo].[CHITIETBAOCAOCONGNO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETBAOCAOCONGNO_BAOCAOCONGNO] FOREIGN KEY([MaBaoCaoCongNo])
REFERENCES [dbo].[BAOCAOCONGNO] ([MaBaoCaoCongNo])
GO
ALTER TABLE [dbo].[CHITIETBAOCAOCONGNO] CHECK CONSTRAINT [FK_CHITIETBAOCAOCONGNO_BAOCAOCONGNO]
GO
ALTER TABLE [dbo].[CHITIETBAOCAOCONGNO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETBAOCAOCONGNO_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[CHITIETBAOCAOCONGNO] CHECK CONSTRAINT [FK_CHITIETBAOCAOCONGNO_KHACHHANG]
GO
ALTER TABLE [dbo].[CHITIETBAOCAOTON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETBAOCAOTON_BAOCAOTON] FOREIGN KEY([MaBaoCaoTon])
REFERENCES [dbo].[BAOCAOTON] ([MaBaoCaoTon])
GO
ALTER TABLE [dbo].[CHITIETBAOCAOTON] CHECK CONSTRAINT [FK_CHITIETBAOCAOTON_BAOCAOTON]
GO
ALTER TABLE [dbo].[CHITIETBAOCAOTON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETBAOCAOTON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CHITIETBAOCAOTON] CHECK CONSTRAINT [FK_CHITIETBAOCAOTON_SACH]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADON] ([MaHoaDon])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_SACH]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAP] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAP] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_SACH]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN] CHECK CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG]
GO
USE [master]
GO
ALTER DATABASE [DBSACH_UIT2T] SET  READ_WRITE 
GO
