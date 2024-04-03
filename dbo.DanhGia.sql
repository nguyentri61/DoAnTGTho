CREATE TABLE [dbo].[DanhGia] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [IDCongViec]  INT            NULL,
	[TieuDeCViec] NVARCHAR (MAX) NULL,
    [DanhGia]     FLOAT (53)     NULL,
    [MoTaDanhGia] NVARCHAR (MAX) NULL
);

