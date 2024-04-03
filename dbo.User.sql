CREATE TABLE [dbo].[User] (
    [ID]     INT           IDENTITY (1, 1) NOT NULL,
    [HoTen]  NVARCHAR (50) NULL,
    [CCCD]   NVARCHAR (50) NULL,
    [SDT]    NVARCHAR (50) NULL,
    [Dob]    DATETIME2 (7) NULL,
    [KhuVuc] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);



Insert into [User] Values ( N'Huỳnh Việt Đan', '099900134386', '08765678542', '2016-10-23', N'Quận 1')
Insert into [User] Values ( N'Nguyễn Phan Minh Trí', '071200134386', '08765678542', '2005-11-20', N'Quận 2')
Insert into [User] Values ( N'Doãn Thế Hùng', '020934623391', '08765678542', '2002-01-5', N'Quận 3')
Insert into [User] Values ( N'Đậu An Cơ', '087514705223', '08765678542', '1999-9-8', N'Quận 4')
Insert into [User] Values ( N'Liêu Quốc Thịnh', '034725622094', '08765678542', '2001-8-13', N'Quận 5')
Insert into [User] Values ( N'Hoàng Nhật Nam', '011249001343', '08765678542', '2004-7-26', N'Quận 7')
Insert into [User] Values ( N'Khoa Minh Trung', '099870013431', '08765678542', '2004-6-23', N'Quận 8')
Insert into [User] Values ( N'Diệp Mạnh Dũng', '01390201343', '08765678542', '2002-12-3', N'Quận 9')
Insert into [User] Values (N'Tạ Hùng Anh', '011290013433', '08765678542', '2003-4-2', N'Thủ Đức')
Insert into [User] Values ( N'Chung Trọng Hà', '085700134313', '08765678542', '1998-3-9', N'Bình Thạnh')
