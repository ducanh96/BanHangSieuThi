Create TABLE [dbo].[NhanVien] (
    [MaNV]        INT            IDENTITY (1, 1) NOT NULL,
    [TenNV]       NVARCHAR (30)  NOT NULL,
    [DienThoaiLH] VARCHAR (12)   NULL,
    [MoTaKhac]    NVARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([MaNV] ASC)
);
go
--lay ra manv gan nhat
create proc ManvNext(@manv int output)
as
begin
	select @manv =  IDENT_CURRENT('NhanVien')
end


--tuyet them bang NhaCungCap ngay 24/5
CREATE TABLE [dbo].[nhacungcap] (
    [ma]            NVARCHAR (50)  NOT NULL,
    [tennhacungcap] NVARCHAR (50)  NULL,
    [diachi]        NVARCHAR (100) NULL,
    [sodienthoai]   VARCHAR (11)   NULL,
    [fax]           NVARCHAR (200) NULL,
    [masothue]      NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([ma] ASC)
);