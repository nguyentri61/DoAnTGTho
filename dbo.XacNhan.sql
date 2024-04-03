CREATE TABLE [dbo].[Table]
(
	[ID]         INT            IDENTITY (1, 1) NOT NULL,
    [IDUser]     NVARCHAR (50)  NULL, 
    [IDTho]			NVARCHAR(50) NULL, 
    [TieuDe] NVARCHAR(MAX) NULL, 
    [MoTa] NVARCHAR(MAX) NULL, 
    [DateThue] DATETIME2 NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([ID]),

)
