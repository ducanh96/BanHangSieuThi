Create TABLE [dbo].[NhanVien] (
    [MaNV]        INT            IDENTITY (1, 1) NOT NULL,
    [TenNV]       NVARCHAR (30)  NOT NULL,
    [DienThoaiLH] VARCHAR (12)   NULL,
    [MoTaKhac]    NVARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([MaNV] ASC)
);
go
--lay ra manv gan nhat
alter proc ManvNext(@manv int output)
as
begin
	select @manv =  IDENT_CURRENT('NhanVien')
end
