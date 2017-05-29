create database SieuThiDB
go
use SieuThiDB
go
--duc anh tao bang nhanvien
Create TABLE [dbo].[NhanVien] (
    [MaNV]        INT            IDENTITY (1, 1) NOT NULL,
    [TenNV]       NVARCHAR (30)  NOT NULL,
    [DienThoaiLH] VARCHAR (12)   NULL,
    [MoTaKhac]    NVARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([MaNV] ASC)
);
go
--duc anh tao proc lay ra manv gan nhat
create proc ManvNext(@manv int output)
as
begin
	select @manv =  IDENT_CURRENT('NhanVien')
end

--khoa tao bang gian hang
CREATE TABLE [dbo].[GianHang] (
    [MaGianHang]  INT           IDENTITY (1, 1) NOT NULL,
    [TenGianHang] NVARCHAR (50) NULL,
    [LoaiHangMa]  INT           NULL,
    CONSTRAINT [PK_GianHang] PRIMARY KEY CLUSTERED ([MaGianHang] ASC)
);
go

--khoa tao proc GianHangNext
create proc GianHangNext(@MaGianHang int output)
as
begin
	select @MaGianHang =  IDENT_CURRENT('GianHang')
end

-- Dũng tạo bảng Hàng
CREATE TABLE [dbo].[Hang] (
    [MaHang] VARCHAR(10) PRIMARY KEY NOT NULL,
    [TenHang] NVARCHAR (30) NULL,
	[DVT] NVARCHAR(15) NULL,
	[SoLuong] INT NOT NULL, 
    [MaLoaiHang] VARCHAR(10) NOT NULL REFERENCES LoaiHang(MaLoaiHang), 
	[MaNCC] VARCHAR(10) NOT NULL REFERENCES NhaCungCap(MaNCC),
	[GhiChu] NVARCHAR(255) NULL
    
);
GO


-- Tạo bảng LoaiHang
IF OBJECT_ID('dbo.LoaiHang', 'U') IS NOT NULL
 DROP TABLE [dbo].[LoaiHang]
GO
CREATE TABLE [dbo].[LoaiHang] 
( 
	MaLoaiHang VARCHAR(10) NOT NULL PRIMARY KEY,
	TenLoaiHang	NVARCHAR(50) NOT NULL	
)
ON [PRIMARY]
GO


-- Tạo bảng NhaCungCap
IF OBJECT_ID('dbo.NhaCungCap', 'U') IS NOT NULL
 DROP TABLE [dbo].[NhaCungCap]
GO
CREATE TABLE [dbo].[NhaCungCap] 
( 
	MaNCC VARCHAR(10) NOT NULL PRIMARY KEY,
	TenNCC NVARCHAR(150) NOT NULL,
	DiaChi NVARCHAR(150) NOT NULL,
	DienThoai VARCHAR(12) NULL,
	FAX VARCHAR(12) NULL,
	MaSoThue VARCHAR(12) NULL
)
ON [PRIMARY]
GO



-- Tạo bảng DangNhap
CREATE TABLE [dbo].[DangNhap] 
(  
	Username VARCHAR(50) NOT NULL PRIMARY KEY,
	Password VARCHAR(50)
)
ON [PRIMARY]
GO
