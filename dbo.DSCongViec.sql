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
    [TrangThai ] NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


DBCC CHECKIDENT ('[DSCongViec]', RESEED, 0);

Insert into DSCongViec Values (1, 2, N'Cần thuê thợ điện tử chuyên nghiệp cho dự án mới',N'Thợ biết sửa các linh kiện điện tử, sửa chửa tủ lạnh', N'Điện tử', N'Thủ Đức', N'2024-3-4', N'Đang thực hiện')
Insert into DSCongViec Values (1, 1, N'Tìm kiếm thợ điện lạnh có kinh nghiệm tại khu vực đô thị mới',N'Thợ biết sửa các linh kiện điện tử, sửa chửa tủ lạnh', N'Điện lạnh', N'Quận 1', N'2024-3-20', N'Đã hoàn thành')
Insert into DSCongViec Values (1, 1, N'Gấp! Tuyển dụng thợ sửa máy tính tại nhà',N'Sửa các linh kiện điện tử, sửa chửa máy tính', N'Điện tử', N'Quận 2', N'2024-3-10', N'Đang thực hiện')
Insert into DSCongViec Values (1, 5, N'Cần thợ gia sư dạy kèm môn Toán lớp 10',N'Dạy cho bé nhỏ lớp 10, có học lực trung bình yếu', N'Gia sư', N'Quận 3', N'2024-3-13', N'Đang thực hiện')
Insert into DSCongViec Values (1, 2, N'Tìm thợ sửa nhà uy tín để cải thiện không gian sống',N'Thiết kế thêm không gian tròng cây xanh', N'Sửa nhà', N'Quận 4', N'2024-3-8', N'Đã hoàn thành')
Insert into DSCongViec Values (1, 2, N'Cần thuê thợ điện nước lành nghề cho công trình xây dựng',N'Thợ biết sửa các linh kiện điện tử, sửa chửa tủ lạnh', N'Điện nước', N'Quận 5', N'2024-3-25', N'Đang thực hiện')
