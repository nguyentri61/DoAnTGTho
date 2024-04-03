CREATE TABLE [dbo].[Tho] (
    [Id]         int identity(1,1) primary key,
    [HoTen]      NVARCHAR (MAX) NOT NULL,
    [CCCD]       NVARCHAR (MAX) NOT NULL,
    [SDT]        NVARCHAR (MAX) NOT NULL,
    [Dob]        DATETIME2 (7)  NOT NULL,
    [KhuVuc]     NVARCHAR (MAX) NOT NULL,
    [LinhVuc]    NVARCHAR (MAX) NOT NULL,
    [ChuyenMon]  NVARCHAR (MAX) NOT NULL,
    [KinhNghiem] NVARCHAR (MAX) NOT NULL,
    [GiaTien]    INT            NOT NULL,
    [DanhGia]    FLOAT (53)     NOT NULL,
);

Insert into Tho Values (N'Nguyễn Ngọc Hoàng', '099900134386', '08765678542', '2016-10-23', N'Quận 1', N'Điện lạnh', N'Sửa máy lạnh', N'2 năm', 500000, 4)
Insert into Tho Values (N'Lê Hoài An', '071200134386', '08765678542', '2005-11-20', N'Quận 2', N'Điện tử', N'Sửa tivi', N'1 - 2 năm', 552000, 4.5)
Insert into Tho Values (N'Trịnh Phúc Bảo', '020934623391', '08765678542', '2002-01-5', N'Quận 3', N'Điện lạnh', N'Sửa máy giặt', N'3 năm', 580000, 5)
Insert into Tho Values (N'Võ Minh Hiếu', '087514705223', '08765678542', '1999-9-8', N'Quận 4', N'Sửa nhà', N'Sơn tường', N'2 năm', 500000, 3)
Insert into Tho Values (N'Nguyễn Hồng Sơn', '034725622094', '08765678542', '2001-8-13', N'Quận 5', N'Điện nước', N'Sửa ống nước', N'Dưới 1 năm', 100000, 1)
Insert into Tho Values (N'Nguyễn Nhựt Tân', '011249001343', '08765678542', '2004-7-26', N'Quận 7', N'Điện tử', N'Sửa máy tính', N'2 năm', 150000, 2)
Insert into Tho Values (N'Hoàng Bảo Ngọc', '099870013431', '08765678542', '2004-6-23', N'Quận 8', N'Điện lạnh', N'Sửa tủ lạnh', N'Trên 3 năm', 280000, 3.5)
Insert into Tho Values (N'Lê Minh Tân', '01390201343', '08765678542', '2002-12-3', N'Quận 9', N'Gia Sư', N'Dạy kèm cấp 2', N'2 - 3 năm', 500000, 2.5)
Insert into Tho Values (N'Phan Phúc Bảo', '011290013433', '08765678542', '2003-4-2', N'Thủ Đức', N'Điện nước', N'Sửa đèn/quạt', N'1 năm', 110000, 5)
Insert into Tho Values (N'Nguyễn Đức Toàn', '085700134313', '08765678542', '1998-3-9', N'Bình Thạnh', N'Điện nước', N'Sửa đường điện', N'1 - 2 năm', 450000, 4)


Insert into Tho Values (N'Ngô Minh An', '099900134386', '08765678542', '2016-10-23', N'Quận 2', N'Điện lạnh', N'Sửa máy lạnh', N'1 năm', 500000, 4)
Insert into Tho Values (N'Trương Thị Yến Ngọc', '071200134386', '08765678542', '2005-11-20', N'Quận 1', N'Điện tử', N'Sửa tivi', N'Dưới 1 năm', 552000, 4.5)
Insert into Tho Values (N'Nguyễn Thị Thùy Dung', '020934623391', '08765678542', '2002-01-5', N'Quận 1', N'Điện lạnh', N'Sửa máy giặt', N'3 năm', 580000, 5)
Insert into Tho Values (N'Nguyễn Văn Trọng', '087514705223', '08765678542', '1999-9-8', N'Quận 2', N'Sửa nhà', N'Sơn tường', N'2 năm', 500000, 3)
Insert into Tho Values (N'Trương Đức Hiệu', '034725622094', '08765678542', '2001-8-13', N'Quận 3', N'Điện nước', N'Sửa ống nước', N'Dưới 1 năm', 100000, 1)
Insert into Tho Values (N'Nguyễn Thiên Nga', '011249001343', '08765678542', '2004-7-26', N'Quận 5', N'Điện tử', N'Sửa máy tính', N'2 năm', 150000, 2)
Insert into Tho Values (N'Trần Phú Quang', '099870013431', '08765678542', '2004-6-23', N'Quận 8', N'Điện lạnh', N'Sửa tủ lạnh', N'Trên 3 năm', 280000, 3.5)
Insert into Tho Values (N'Phạm Thị Đăng Thơ', '01390201343', '08765678542', '2002-12-3', N'Quận 9', N'Gia Sư', N'Dạy kèm cấp 2', N'2 - 3 năm', 500000, 2.5)
Insert into Tho Values (N'Lê Hữu Thắng', '011290013433', '08765678542', '2003-4-2', N'Thủ Đức', N'Điện nước', N'Sửa đèn/quạt', N'1 năm', 110000, 5)
Insert into Tho Values (N'Lê Thị Thanh Phương', '085700134313', '08765678542', '1998-3-9', N'Bình Thạnh', N'Điện nước', N'Sửa đường điện', N'1 năm', 450000, 4)

Insert into Tho Values (N'Trần Nguyễn Minh Tuyền', '099900134386', '08765678542', '2016-10-23', N'Quận 4', N'Điện lạnh', N'Sửa máy lạnh', N'1 - 2 năm', 500000, 4)
Insert into Tho Values (N'Nguyễn Thị Khánh', '071200134386', '08765678542', '2005-11-20', N'Quận 7', N'Điện tử', N'Sửa tivi', N'2 - 3 năm', 552000, 4.5)
Insert into Tho Values (N'Nguyễn Gia Thuật', '020934623391', '08765678542', '2002-01-5', N'Quận 8', N'Điện lạnh', N'Sửa máy giặt', N'3 năm', 580000, 5)
Insert into Tho Values (N'Nguyễn Ngọc Thơ', '087514705223', '08765678542', '1999-9-8', N'Quận 9', N'Sửa nhà', N'Sơn tường', N'2 năm', 500000, 3)
Insert into Tho Values (N'Nguyễn Văn Đông Nhi', '034725622094', '08765678542', '2001-8-13', N'Quận 2', N'Điện nước', N'Sửa ống nước', N'Dưới 1 năm', 100000, 1)
Insert into Tho Values (N'Đỗ Thị Mai', '011249001343', '08765678542', '2004-7-26', N'Quận 1', N'Điện tử', N'Sửa máy tính', N'2 năm', 150000, 2)
Insert into Tho Values (N'Trương Phi Lâm', '099870013431', '08765678542', '2004-6-23', N'Quận 5', N'Điện lạnh', N'Sửa tủ lạnh', N'Trên 3 năm', 280000, 3.5)
Insert into Tho Values (N'Lê Thị Diệu Linh', '01390201343', '08765678542', '2002-12-3', N'Quận 6', N'Gia Sư', N'Dạy kèm cấp 2', N'2 - 3 năm', 500000, 2.5)
Insert into Tho Values (N'Bùi Thị Anh Tuyên', '011290013433', '08765678542', '2003-4-2', N'Thủ Đức', N'Điện nước', N'Sửa đèn/quạt', N'1 năm', 110000, 5)
Insert into Tho Values (N'Nguyễn Văn Chuyển', '085700134313', '08765678542', '1998-3-9', N'Bình Thạnh', N'Điện nước', N'Sửa đường điện', N'2 năm', 450000, 4)

Insert into Tho Values (N'Trần Ngọc Nguyệt Nga', '099900134386', '08765678542', '2016-10-23', N'Quận 1', N'Điện lạnh', N'Sửa máy lạnh', N'1 năm', 500000, 4)
Insert into Tho Values (N'Đặng Xuân Nhi', '071200134386', '08765678542', '2005-11-20', N'Quận 2', N'Điện tử', N'Sửa tivi', N'1 - 2 năm', 552000, 4.5)
Insert into Tho Values (N'Ngô Công Huy', '020934623391', '08765678542', '2002-01-5', N'Quận 3', N'Điện lạnh', N'Sửa máy giặt', N'3 năm', 580000, 5)
Insert into Tho Values (N'Lê Quang Anh', '087514705223', '08765678542', '1999-9-8', N'Quận 4', N'Sửa nhà', N'Sơn tường', N'2 năm', 500000, 3)
Insert into Tho Values (N'Ngô Văn Tư', '034725622094', '08765678542', '2001-8-13', N'Quận 5', N'Điện nước', N'Sửa ống nước', N'Dưới 1 năm', 100000, 1)
Insert into Tho Values (N'Nguyễn Đình Huynh', '011249001343', '08765678542', '2004-7-26', N'Quận ', N'Điện tử', N'Sửa máy tính', N'2 năm', 150000, 2)
Insert into Tho Values (N'Lê Hoàng Kim Uyên', '099870013431', '08765678542', '2004-6-23', N'Quận 5', N'Điện lạnh', N'Sửa tủ lạnh', N'Trên 3 năm', 280000, 3.5)
Insert into Tho Values (N'Ngô Minh An', '01390201343', '08765678542', '2002-12-3', N'Quận 6', N'Gia Sư', N'Dạy kèm cấp 2', N'2 - 3 năm', 500000, 2.5)
Insert into Tho Values (N'Phan Anh Nhất', '011290013433', '08765678542', '2003-4-2', N'Thủ Đức', N'Điện nước', N'Sửa đèn/quạt', N'1 năm', 110000, 5)
Insert into Tho Values (N'Đoàn Đại Dương', '085700134313', '08765678542', '1998-3-9', N'Quận 6', N'Điện nước', N'Sửa đường điện', N'1 - 2 năm', 450000, 4)

Insert into Tho Values (N'Lê Hoàng Kim Uyên', '099900134386', '08765678542', '2016-10-23', N'Quận 6', N'Điện lạnh', N'Sửa máy lạnh', N'1 - 2 năm', 500000, 4)
Insert into Tho Values (N'Trần Đình Mạnh', '071200134386', '08765678542', '2005-11-20', N'Thủ Đức', N'Điện tử', N'Sửa tivi', N'1 - 2 năm', 552000, 4.5)
Insert into Tho Values (N'Trần Tố Trinh', '020934623391', '08765678542', '2002-01-5', N'Quận 3', N'Điện lạnh', N'Sửa máy giặt', N'3 năm', 580000, 5)
Insert into Tho Values (N'Võ Thị Thùy An', '087514705223', '08765678542', '1999-9-8', N'Quận 2', N'Sửa nhà', N'Sơn tường', N'2 năm', 500000, 3)
Insert into Tho Values (N'Sầm Hữu Thắng', '034725622094', '08765678542', '2001-8-13', N'Quận 4', N'Điện nước', N'Sửa ống nước', N'Dưới 1 năm', 100000, 1)
Insert into Tho Values (N'Lê Thị Thuý Kiều', '011249001343', '08765678542', '2004-7-26', N'Quận ', N'Điện tử', N'Sửa máy tính', N'2 năm', 150000, 2)
Insert into Tho Values (N'Doãn Khắc Quân', '099870013431', '08765678542', '2004-6-23', N'Quận 5', N'Điện lạnh', N'Sửa tủ lạnh', N'Trên 3 năm', 280000, 3.5)
Insert into Tho Values (N'Nguyễn Lê Thùy Duyên', '01390201343', '08765678542', '2002-12-3', N'Quận 6', N'Gia Sư', N'Dạy kèm cấp 2', N'2 - 3 năm', 500000, 2.5)
Insert into Tho Values (N'Phạm Thị Thanh Bình', '011290013433', '08765678542', '2003-4-2', N'Bình Thạnh', N'Điện nước', N'Sửa đèn/quạt', N'1 năm', 110000, 5)
Insert into Tho Values (N'Đỗ Thị Thảo Nguyên', '085700134313', '08765678542', '1998-3-9', N'Quận 6', N'Điện nước', N'Sửa đường điện', N'1 - 2 năm', 450000, 4)

