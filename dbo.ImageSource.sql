CREATE TABLE [dbo].[ImageSource]
(
	[ID]         INT  IDENTITY (1, 1) NOT NULL,
	[Source] NVARCHAR(MAX) NOT NULL , 
    [IsDG] BIT NULL, 
    [IDCV] INT NOT NULL, 
    CONSTRAINT [PK_ImageSource] PRIMARY KEY ([ID])
)
