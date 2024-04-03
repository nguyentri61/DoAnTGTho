CREATE TABLE [dbo].[TaiKhoan]
(
	[Id] INT NOT NULL , 
    [Role] NVARCHAR(50) NOT NULL,
    [LogName] NVARCHAR(50) NULL , 
	[Pass] NVARCHAR(50) NULL , 
    PRIMARY KEY ([Id], [Role]),
    CONSTRAINT UK_LogName UNIQUE ([LogName])
);
