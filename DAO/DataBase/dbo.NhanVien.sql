﻿--duc anh tao bang nhanvien
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

--Linh tao bang Loai Hang
CREATE TABLE [dbo].[LoaiHang] (
    [MaLoaiHang]  INT           IDENTITY (1, 1) NOT NULL,
    [TenLoaiHang] NVARCHAR (50) NULL,
    CONSTRAINT [PK_LoaiHang] PRIMARY KEY CLUSTERED ([MaLoaiHang] ASC),
);
go

--Linh tao proc LoaiHang gan nhat
create proc LoaiHangGanNhat(@MaLoaiHang int output)
as
begin
	select @MaLoaiHang =  IDENT_CURRENT('LoaiHang')
end

--khoa tao bang gian hang
CREATE TABLE [dbo].[GianHang] (
    [MaGianHang]  INT           IDENTITY (1, 1) NOT NULL,
    [TenGianHang] NVARCHAR (50) NULL,
    [LoaiHangMa]  INT           NOT NULL,
    CONSTRAINT [PK_GianHang] PRIMARY KEY CLUSTERED ([MaGianHang] ASC),
	CONSTRAINT [FK_GianHang_LoaiHang]  FOREIGN KEY ([LoaiHangMa]) REFERENCES [dbo].[LoaiHang] ([MaLoaiHang])
);
go

--khoa tao proc GianHangNext
create proc GianHangNext(@MaGianHang int output)
as
begin
	select @MaGianHang =  IDENT_CURRENT('GianHang')
end
