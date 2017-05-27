--1,duc anh tao bang nhanvien
Create TABLE [dbo].[NhanVien] (
    [MaNV]        INT            IDENTITY (1, 1) NOT NULL,
    [TenNV]       NVARCHAR (30)  NOT NULL,
    [DienThoaiLH] VARCHAR (12)   NULL,
    [MoTaKhac]    NVARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([MaNV] ASC)
);
go

--2,duc anh tao proc lay ra manv gan nhat
create proc ManvNext(@manv int output)
as
begin
	select @manv =  IDENT_CURRENT('NhanVien')
end

--3,Linh tao bang Loai Hang
CREATE TABLE [dbo].[LoaiHang] (
    [MaLoaiHang]  INT           IDENTITY (1, 1) NOT NULL,
    [TenLoaiHang] NVARCHAR (50) NULL,
    CONSTRAINT [PK_LoaiHang] PRIMARY KEY CLUSTERED ([MaLoaiHang] ASC),
);
go

--4,Linh tao proc LoaiHang gan nhat
create proc LoaiHangGanNhat(@MaLoaiHang int output)
as
begin
	select @MaLoaiHang =  IDENT_CURRENT('LoaiHang')
end

--5,khoa tao bang gian hang
CREATE TABLE [dbo].[GianHang] (
    [MaGianHang]  INT           IDENTITY (1, 1) NOT NULL,
    [TenGianHang] NVARCHAR (50) NULL,
    [LoaiHangMa]  INT           NOT NULL,
    CONSTRAINT [PK_GianHang] PRIMARY KEY CLUSTERED ([MaGianHang] ASC),
	CONSTRAINT [FK_GianHang_LoaiHang]  FOREIGN KEY ([LoaiHangMa]) REFERENCES [dbo].[LoaiHang] ([MaLoaiHang])
);
go

--6,khoa tao proc GianHangNext
create proc GianHangNext(@MaGianHang int output)
as
begin
	select @MaGianHang =  IDENT_CURRENT('GianHang')
end
go

--7,vao bang GiangHang ,click chuot phai chon show table definition roi chen doan nay xuong duoi roi update
--Constraint [FK_GianHang_LoaiHang] Foreign key (LoaiHangMa) references LoaiHang(MaLoaiHang)

--8
create proc [dbo].[MaNhaCCNext](@MaNCC int output)
as
begin
	select @MaNCC =  IDENT_CURRENT('NhaCungCap')
end

--9,tao bang nha cung cap

create table NhaCungCap(
	MaNCC int primary key identity(1,1),
	TenNCC nvarchar(150),
	DiaChi nvarchar(150),
	DienThoai varchar(12),
	Fax varchar(12),
	MaSoThue varchar(12)

)

--10,duc anh tao bang hang
Create table Hang(
	MaHang nvarchar(50) primary key ,
	TenHang nvarchar(50),
	DVT nvarchar(15),
	MaLoaiHang int references LoaiHang(MaLoaiHang),
	MaNCC int references NhaCungCap(MaNCC),
	GhiChu nvarchar(50)
)


--tạo nốt cho xong nè

--11,Tao bang hoa don
create table HoaDon
(
	SoHoaDon bigint primary key identity(1,1),
	NgayNhap datetime default GetDate(),
	MaNV int references NhanVien(MaNV)

)
go

--12,Tao bang don hang
Create table DonHang(
	MaDH bigint primary key identity(1,1),
	NgayDH datetime default GetDate(),
	MaNV int references NhanVien(MaNV)
)

--13 tao bang hang nhap
	Create table HangNhap(
		MaDH bigint references DonHang(MaDH),
		MaHang nvarchar(50) references Hang(MaHang),
		SoLuong int,
		DonGia decimal,
		Primary key (MaDH,MaHang)

	)

	--14 tao hang ban
	create table HangBan(
		SoHD bigint references HoaDon(SoHoaDon),
		MaHang nvarchar(50) references Hang(MaHang),
		SoLuong int,
		DonGia decimal,
		Primary key (SoHD,MaHang)
	)
	