CREATE TABLE [dbo].[DSCongViec] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [IDTho]      INT            NULL,
    [IDUser]     INT            NULL,
    [TieuDe]     NVARCHAR (MAX) NULL,
    [MoTa]       NVARCHAR (MAX) NULL,
    [GhiChu]     NVARCHAR (MAX) NULL,
    [LinhVuc]    NVARCHAR (50)  NULL,
    [KhuVuc]     NVARCHAR (50)  NULL,
    [DateThue]   DATETIME       NULL,
    [TrangThai] NVARCHAR (50)  NULL,
    [ChiTietSua] NVARCHAR (MAX) DEFAULT ('') NULL,
    [ChiPhi]     INT            DEFAULT ((0)) NULL,
    [Image]      NVARCHAR (MAX) DEFAULT ('') NULL,
    [IDBaiDang]  INT            DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

