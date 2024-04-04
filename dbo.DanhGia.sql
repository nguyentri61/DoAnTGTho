CREATE TABLE [dbo].[DanhGia] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [IDCongViec]  INT            NULL,
    [TieuDeCViec] NVARCHAR (MAX) NULL,
    [DanhGia]     INT            NULL,
    [MoTaDanhGia] NVARCHAR (MAX) NULL,
    [Image]       NVARCHAR (MAX) NULL
);

