CREATE TABLE [dbo].[TaiKhoan] (
    [Id]      INT           NOT NULL,
    [Role]    BIT           NOT NULL,
    [LogName] NVARCHAR (50) NULL,
    [Pass]    NVARCHAR (50) NULL,
    CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED ([Role] ASC, [Id] ASC),
    CONSTRAINT [UK_LogName] UNIQUE NONCLUSTERED ([LogName] ASC)
);

