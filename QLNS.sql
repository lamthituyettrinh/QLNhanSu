USE [QLNS]
GO
/****** Object:  Table [dbo].[LoaiHopDong]    Script Date: 12/11/2016 15:16:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHopDong](
	[MaLoaiHD] [nvarchar](5) NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiHopDong] PRIMARY KEY CLUSTERED 
(
	[MaLoaiHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoaiHopDong] ([MaLoaiHD], [Ten]) VALUES (N'1', N'Loại 1')
INSERT [dbo].[LoaiHopDong] ([MaLoaiHD], [Ten]) VALUES (N'2', N'Loại 2')
INSERT [dbo].[LoaiHopDong] ([MaLoaiHD], [Ten]) VALUES (N'3', N'Loại 3')
/****** Object:  Table [dbo].[PhongBan]    Script Date: 12/11/2016 15:16:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPB] [nvarchar](5) NOT NULL,
	[TenPB] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'1', N'Hành chánh')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'2', N'Kỹ thuật')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'3', N'Nhân Sự')
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/11/2016 15:16:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] NOT NULL,
	[HoNV] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](50) NULL,
	[MaPB] [nvarchar](5) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NhanVien] ([MaNV], [HoNV], [Ten], [DiaChi], [DienThoai], [MaPB]) VALUES (1, N'Lâm', N'Trinh', N'Quảng Ngãi', N'0128295753', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [HoNV], [Ten], [DiaChi], [DienThoai], [MaPB]) VALUES (2, N'Nguyễn ', N'Hạnh', N'Bình Định', N'0169276696', N'2')
INSERT [dbo].[NhanVien] ([MaNV], [HoNV], [Ten], [DiaChi], [DienThoai], [MaPB]) VALUES (3, N'Lê', N'Thủy', N'Đắc Lắc', N'0161575652', N'3')
/****** Object:  Table [dbo].[HopDong]    Script Date: 12/11/2016 15:16:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[MaHD] [nvarchar](5) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[MaLoaiHD] [nvarchar](5) NULL,
 CONSTRAINT [PK_HopDong] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HopDong] ([MaHD], [Ten], [MaLoaiHD]) VALUES (N'1', N'Lao động', N'1')
INSERT [dbo].[HopDong] ([MaHD], [Ten], [MaLoaiHD]) VALUES (N'2', N'Quảng Cáo', N'2')
INSERT [dbo].[HopDong] ([MaHD], [Ten], [MaLoaiHD]) VALUES (N'3', N'Bán thời gian', N'3')
/****** Object:  Table [dbo].[ChucVu]    Script Date: 12/11/2016 15:16:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [nvarchar](5) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[MaNV] [int] NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChucVu] ([MaChucVu], [Ten], [MaNV]) VALUES (N'1', N'Giám đốc', 1)
INSERT [dbo].[ChucVu] ([MaChucVu], [Ten], [MaNV]) VALUES (N'2', N'Thư ký', 2)
INSERT [dbo].[ChucVu] ([MaChucVu], [Ten], [MaNV]) VALUES (N'3', N'Lao động', 3)
/****** Object:  Table [dbo].[ChiTietHD]    Script Date: 12/11/2016 15:16:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHD](
	[MaHD] [nvarchar](5) NOT NULL,
	[MaNV] [int] NOT NULL,
	[NgayKy] [datetime] NULL,
	[NhiemVu] [nchar](10) NULL,
 CONSTRAINT [PK_ChiTietHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHD] ([MaHD], [MaNV], [NgayKy], [NhiemVu]) VALUES (N'1', 1, CAST(0x0000A29400000000 AS DateTime), N'Nhân viên ')
INSERT [dbo].[ChiTietHD] ([MaHD], [MaNV], [NgayKy], [NhiemVu]) VALUES (N'2', 2, CAST(0x0000A3FF00000000 AS DateTime), N'Quản lý   ')
INSERT [dbo].[ChiTietHD] ([MaHD], [MaNV], [NgayKy], [NhiemVu]) VALUES (N'3', 3, CAST(0x0000A56C00000000 AS DateTime), N'Thư ký    ')
/****** Object:  Table [dbo].[BangLuong]    Script Date: 12/11/2016 15:16:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangLuong](
	[MaLuong] [nvarchar](5) NOT NULL,
	[HeSoLuong] [nvarchar](50) NULL,
	[Thang] [datetime] NULL,
	[Gia] [nvarchar](50) NULL,
	[MaNV] [int] NULL,
 CONSTRAINT [PK_BangLuong] PRIMARY KEY CLUSTERED 
(
	[MaLuong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BangLuong] ([MaLuong], [HeSoLuong], [Thang], [Gia], [MaNV]) VALUES (N'1', N'5.5', CAST(0x0000A12500000000 AS DateTime), N'120', 3)
INSERT [dbo].[BangLuong] ([MaLuong], [HeSoLuong], [Thang], [Gia], [MaNV]) VALUES (N'2', N'5.6', CAST(0x0000A3FF00000000 AS DateTime), N'125', 2)
INSERT [dbo].[BangLuong] ([MaLuong], [HeSoLuong], [Thang], [Gia], [MaNV]) VALUES (N'3', N'5.8', CAST(0x0000A30B00000000 AS DateTime), N'130', 1)
/****** Object:  Table [dbo].[BangCong]    Script Date: 12/11/2016 15:16:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangCong](
	[MaCong] [nvarchar](5) NOT NULL,
	[SoNgay] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[MaLuong] [nvarchar](5) NULL,
 CONSTRAINT [PK_BangCong] PRIMARY KEY CLUSTERED 
(
	[MaCong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BangCong] ([MaCong], [SoNgay], [SoLuong], [MaLuong]) VALUES (N'1', N'5', 25, N'1')
INSERT [dbo].[BangCong] ([MaCong], [SoNgay], [SoLuong], [MaLuong]) VALUES (N'2', N'7', 35, N'2')
INSERT [dbo].[BangCong] ([MaCong], [SoNgay], [SoLuong], [MaLuong]) VALUES (N'3', N'8', 40, N'3')
/****** Object:  ForeignKey [FK_BangCong_BangLuong]    Script Date: 12/11/2016 15:16:46 ******/
ALTER TABLE [dbo].[BangCong]  WITH CHECK ADD  CONSTRAINT [FK_BangCong_BangLuong] FOREIGN KEY([MaLuong])
REFERENCES [dbo].[BangLuong] ([MaLuong])
GO
ALTER TABLE [dbo].[BangCong] CHECK CONSTRAINT [FK_BangCong_BangLuong]
GO
/****** Object:  ForeignKey [FK_BangLuong_NhanVien]    Script Date: 12/11/2016 15:16:46 ******/
ALTER TABLE [dbo].[BangLuong]  WITH CHECK ADD  CONSTRAINT [FK_BangLuong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[BangLuong] CHECK CONSTRAINT [FK_BangLuong_NhanVien]
GO
/****** Object:  ForeignKey [FK_ChiTietHD_HopDong]    Script Date: 12/11/2016 15:16:46 ******/
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_HopDong] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HopDong] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK_ChiTietHD_HopDong]
GO
/****** Object:  ForeignKey [FK_ChiTietHD_NhanVien]    Script Date: 12/11/2016 15:16:46 ******/
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK_ChiTietHD_NhanVien]
GO
/****** Object:  ForeignKey [FK_ChucVu_NhanVien]    Script Date: 12/11/2016 15:16:46 ******/
ALTER TABLE [dbo].[ChucVu]  WITH CHECK ADD  CONSTRAINT [FK_ChucVu_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ChucVu] CHECK CONSTRAINT [FK_ChucVu_NhanVien]
GO
/****** Object:  ForeignKey [FK_HopDong_LoaiHopDong]    Script Date: 12/11/2016 15:16:46 ******/
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_HopDong_LoaiHopDong] FOREIGN KEY([MaLoaiHD])
REFERENCES [dbo].[LoaiHopDong] ([MaLoaiHD])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_HopDong_LoaiHopDong]
GO
/****** Object:  ForeignKey [FK_NhanVien_PhongBan]    Script Date: 12/11/2016 15:16:46 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
