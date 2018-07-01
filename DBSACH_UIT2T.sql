USE [master]
GO
/****** Object:  Database [DBSACH_UIT2T]    Script Date: 7/1/2018 10:30:01 PM ******/
CREATE DATABASE [DBSACH_UIT2T]
GO
ALTER DATABASE [DBSACH_UIT2T] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBSACH_UIT2T].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBSACH_UIT2T] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBSACH_UIT2T] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBSACH_UIT2T] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBSACH_UIT2T] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBSACH_UIT2T] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET RECOVERY FULL 
GO
ALTER DATABASE [DBSACH_UIT2T] SET  MULTI_USER 
GO
ALTER DATABASE [DBSACH_UIT2T] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBSACH_UIT2T] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBSACH_UIT2T] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBSACH_UIT2T] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DBSACH_UIT2T] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBSACH_UIT2T', N'ON'
GO
ALTER DATABASE [DBSACH_UIT2T] SET QUERY_STORE = OFF
GO
USE [DBSACH_UIT2T]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [DBSACH_UIT2T]
GO
/****** Object:  Table [dbo].[BAOCAOCONGNO]    Script Date: 7/1/2018 10:30:01 PM ******/
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
/****** Object:  Table [dbo].[BAOCAOTON]    Script Date: 7/1/2018 10:30:01 PM ******/
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
/****** Object:  Table [dbo].[CHITIETBAOCAOCONGNO]    Script Date: 7/1/2018 10:30:01 PM ******/
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
/****** Object:  Table [dbo].[CHITIETBAOCAOTON]    Script Date: 7/1/2018 10:30:01 PM ******/
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
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 7/1/2018 10:30:01 PM ******/
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
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 7/1/2018 10:30:01 PM ******/
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
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 7/1/2018 10:30:01 PM ******/
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
/****** Object:  Table [dbo].[HOADON]    Script Date: 7/1/2018 10:30:01 PM ******/
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
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 7/1/2018 10:30:01 PM ******/
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
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 7/1/2018 10:30:01 PM ******/
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
/****** Object:  Table [dbo].[PHIEUTHUTIEN]    Script Date: 7/1/2018 10:30:01 PM ******/
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
/****** Object:  Table [dbo].[SACH]    Script Date: 7/1/2018 10:30:01 PM ******/
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
/****** Object:  Table [dbo].[THAMSO]    Script Date: 7/1/2018 10:30:01 PM ******/
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
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] ON 

INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (1, 1, 2, 2, 79000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (2, 1, 3, 1, 150000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (3, 2, 5, 1, 40800)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (4, 3, 9, 1, 14000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (5, 4, 10, 3, 50000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (6, 4, 11, 2, 73000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (7, 5, 5, 1, 40800)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (8, 5, 6, 3, 58000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (9, 6, 16, 1, 60000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (10, 7, 17, 2, 150000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (11, 7, 1, 1, 80000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (12, 7, 3, 3, 150000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (13, 8, 10, 1, 50000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (14, 8, 6, 1, 58000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (15, 9, 2, 1, 79000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (16, 9, 4, 0, 90000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (17, 9, 6, 3, 58000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (18, 10, 4, 1, 90000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (19, 11, 7, 5, 72000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (20, 12, 19, 2, 21000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (21, 13, 4, 1, 90000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (22, 14, 12, 550, 23000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (23, 15, 6, 1, 58000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (24, 15, 10, 1, 50000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (25, 16, 13, 1, 28000)
INSERT [dbo].[CHITIETHOADON] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuongBan], [DonGiaBan]) VALUES (26, 16, 4, 1, 90000)
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] OFF
SET IDENTITY_INSERT [dbo].[CHITIETPHIEUNHAP] ON 

INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (1, 1, 1, 160)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (2, 1, 2, 300)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (3, 1, 3, 210)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (4, 1, 4, 160)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (5, 1, 5, 190)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (6, 1, 6, 200)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (7, 1, 7, 400)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (8, 1, 8, 1000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (9, 1, 9, 500)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (10, 1, 10, 500)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (11, 1, 11, 600)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (12, 1, 12, 600)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (13, 1, 13, 700)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (14, 1, 14, 820)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (15, 2, 16, 200)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (16, 2, 17, 150)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (17, 2, 19, 900)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (18, 3, 1, 150)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (19, 3, 2, 200)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (20, 4, 4, 150)
SET IDENTITY_INSERT [dbo].[CHITIETPHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[DANGNHAP] ON 

INSERT [dbo].[DANGNHAP] ([id], [TenDangNhap], [MatKhau]) VALUES (1, N'admin', N'BBB2CA48225EFB207E0EC1CD9F2877BD')
SET IDENTITY_INSERT [dbo].[DANGNHAP] OFF
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (0, CAST(N'2018-07-01T22:03:19.6733333' AS DateTime2), 1)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (1, CAST(N'2018-07-01T22:03:19.6733333' AS DateTime2), 1)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (2, CAST(N'2018-07-01T22:03:19.6733333' AS DateTime2), 2)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (3, CAST(N'2018-07-01T22:04:09.1866667' AS DateTime2), 3)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (4, CAST(N'2018-07-01T22:04:09.1866667' AS DateTime2), 4)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (5, CAST(N'2018-07-01T22:04:09.1866667' AS DateTime2), 5)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (6, CAST(N'2018-07-01T22:04:09.1866667' AS DateTime2), 6)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (7, CAST(N'2018-07-01T22:04:09.1866667' AS DateTime2), 7)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (8, CAST(N'2018-07-01T22:04:09.1866667' AS DateTime2), 9)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (9, CAST(N'2018-07-01T22:04:09.1866667' AS DateTime2), 10)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (10, CAST(N'2018-07-01T22:04:09.1866667' AS DateTime2), 11)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (11, CAST(N'2018-07-01T22:04:09.1866667' AS DateTime2), 12)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (12, CAST(N'2018-07-01T22:04:09.1866667' AS DateTime2), 13)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (13, CAST(N'2018-07-01T22:04:09.1866667' AS DateTime2), 14)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (14, CAST(N'2018-05-04T22:14:29.0000000' AS DateTime2), 3)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (15, CAST(N'2018-04-18T22:18:35.0000000' AS DateTime2), 12)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (16, CAST(N'2018-04-22T22:18:35.0000000' AS DateTime2), 5)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (1, N'Nguyễn Huỳnh Thanh Tâm', N'21 Lê Đức Thọ, P.15, TP.HCM', N'01223632954', N'16521062@gm.uit.edu.vn', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (2, N'Đặng Minh Tiến', N'212/2 đường số 8, Bến Tre', N'0961014106', N'dangminhtien06@gmail.com', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (3, N'Nguyễn Tây Trung', N'33 Lê Đức Thọ, P15, quận Gò Vấp', N'01253342956', N'trungnt@yahoo.com', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (4, N'Huỳnh Hạ Vy', N'120 Hai Bà Trưng, quận 1, TP.HCM', N'0902733050', N'vyvy98@gmail.com.vn', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (5, N'Đỗ Ngọc Bích Trâm', N'212E đường CMT8, Q3, TP.HCM', N'0909322147', N'tramngoc@gmail.com.vn', 118000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (6, N'Phan Trung Hiếu', N'12 Lê Văn Sỹ, Q3, TP.HCM', N'0133451629', N'hieuphan1403@yahoo.com', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (7, N'Huỳnh Phước Thịnh', N'32 Hoàng Văn Thụ, TP.HCM', N'0909281746', N'thinhhh_98@gmail.com.vn', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (9, N'Nguyễn Hải Ngân', N'234/100/1 đường số 2, Lê Văn Thọ, Q. Gò Vấp', N'0167122533', N'ngannghai1201@yahoo.com', 108000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (10, N'Nguyễn Ngọc Mai Thi', N'44/3 Quang Trung, P12, Q. Gò Vấp, TP.HCM', N'01224145298', N'little_flower13@yahoo.com', 253000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (11, N'Nguyễn Xuân Sang', N'45 Lê Thị Riêng TP.HCM', N'0903725416', N'15520983@gm.uit.edu.vn', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (12, N'Nguyễn Đan Thanh', N'34 Điện Biên Phủ, Q3, TP.HCM', N'0909284517', N'thanhnd@gmail.com', 108000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (13, N'Võ Ngọc Nam An', N'53/2 Hồ Bá Kiện, Q.10, TP.HCM', N'0167453199', N'annam@yahoo.com.vn', 0)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DiaChi], [DienThoai], [Email], [TienNo]) VALUES (14, N'Trương Hồng Hoa', N'412 Phạm Ngọc Thạch, TP.HCM', N'0903129544', N'hoahong113@gmail.com', 0)
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap]) VALUES (0, CAST(N'2018-07-01T21:56:11.4366667' AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap]) VALUES (1, CAST(N'2018-07-01T21:56:11.4366667' AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap]) VALUES (2, CAST(N'2018-07-01T21:58:25.0633333' AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap]) VALUES (3, CAST(N'2018-04-11T22:12:32.0000000' AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap]) VALUES (4, CAST(N'2018-05-20T22:12:32.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[PHIEUTHUTIEN] ON 

INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (0, 1, CAST(N'2018-07-01T22:09:50.4200000' AS DateTime2), 308000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (1, 2, CAST(N'2018-07-01T22:10:19.5833333' AS DateTime2), 40800)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (2, 3, CAST(N'2018-07-01T22:10:19.5833333' AS DateTime2), 14000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (3, 5, CAST(N'2018-07-01T22:10:19.5833333' AS DateTime2), 214800)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (4, 6, CAST(N'2018-07-01T22:10:19.5833333' AS DateTime2), 60000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (5, 7, CAST(N'2018-07-01T22:10:19.5833333' AS DateTime2), 830000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (6, 4, CAST(N'2018-04-17T22:10:19.0000000' AS DateTime2), 296000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (7, 3, CAST(N'2018-07-01T22:15:09.4400000' AS DateTime2), 12650000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (8, 11, CAST(N'2018-07-01T22:15:09.4400000' AS DateTime2), 90000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (9, 14, CAST(N'2018-07-01T22:15:09.4400000' AS DateTime2), 90000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (10, 12, CAST(N'2018-07-01T22:18:14.9233333' AS DateTime2), 360000)
INSERT [dbo].[PHIEUTHUTIEN] ([MaPhieuThu], [MaKhachHang], [NgayThuTien], [SoTienThu]) VALUES (11, 13, CAST(N'2018-04-26T22:19:24.0000000' AS DateTime2), 42000)
SET IDENTITY_INSERT [dbo].[PHIEUTHUTIEN] OFF
SET IDENTITY_INSERT [dbo].[SACH] ON 

INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (1, N'Nhà Lãnh Đạo Không Chức Danh', N'Kinh tế', N'Robin Sharma', 309, 80000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (2, N'P.Kotler Tiếp thị 4.0', N'Kinh tế', N'Nguyễn Khoa Hồng Thành', 497, 79000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (3, N'Qua Pixar Là Vô Cực', N'Kinh tế', N'Lawrence Levy', 206, 150000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (4, N'Cẩm Nang Tự Học IELTS', N'Ngoại ngữ', N'Kiên Trần', 307, 90000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (5, N'Đề Kiểm Tra Tiếng Anh Lớp 7', N'Ngoại ngữ', N'Trần Mạnh Tường', 188, 40800)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (6, N'3000 Từ Vựng Tiếng Anh Thông Dụng Nhất', N'Ngoại ngữ', N'The Windy', 192, 58000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (7, N'Tự Học Tiếng Hàn Dành Cho Người Mới Bắt Đầu', N'Ngoại ngữ', N'NXB Thời Đại', 395, 72000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (8, N'Ai và Ky ở xứ sở những con số tàng hình', N'Văn học', N'Ngô Bảo Châu', 1000, 56000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (9, N'Tiếng Việt 4', N'Sách giáo khoa', N'Hồ Thị Thập', 499, 14000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (10, N'24 quy tắc học Kanji', N'Tiếng Nhật', N'Trần Việt Thanh', 495, 50000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (11, N'Lịch sử loài người ', N'Lịch sử', N'Nguyễn Thị Mộng, Trần Minh Hòa', 598, 73000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (12, N'Truyện cổ Việt Nam', N'Văn học', N'Minh Triết', 50, 23000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (13, N'Hướng dẫn giải bài tập xác suất thống kê', N'Tham khảo', N'Hà Mạnh Linh, Lê Hoàng Tuấn, Dương Tôn Đảm', 699, 28000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (14, N'Toán học 10', N'Sách giáo khoa', N'Đỗ Thanh Sơn, Bùi Thị Kim Hoa', 820, 12000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (16, N'Những bài làm văn mẫu 9', N'Sách giáo khoa', N'Huỳnh Văn Bánh', 199, 60000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (17, N'Qua Pixar là vô cực', N'Kinh tế', N'Lawrence', 148, 150000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [SoLuongTon], [DonGia]) VALUES (19, N'Nhật ký Ngốc Xít', N'Văn học', N'Cohan Serance', 898, 21000)
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
