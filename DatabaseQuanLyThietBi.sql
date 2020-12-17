CREATE DATABASE QuanLyThietBi;
GO
USE QuanLyThietBi;

/*
    Group Manage Customer
*/
CREATE TABLE Customer_Group (
    Id_Group int IDENTITY(1,1) PRIMARY KEY,
    Name_Group nvarchar(255)
);

CREATE TABLE Customer_Detail(
    Id_Customer int IDENTITY(1,1) PRIMARY KEY,
    Name_Customer nvarchar(255),
    Address_Customer nvarchar(255),
    Grender_Customer nvarchar(255),
    Birthday_Customer date,
    Identity_Card nvarchar(255),
    Id_Group int FOREIGN KEY REFERENCES Customer_Group(Id_Group)
);

CREATE TABLE Account(
    Id_Customer int FOREIGN KEY REFERENCES Customer_Detail(Id_Customer),
    User_Name_Customer nvarchar(255),
    Password_Customer nvarchar(255)
);

/*
    Group Manage Device
*/
CREATE TABLE Type_Device (
    Id_Type int IDENTITY(1,1) PRIMARY KEY,
    Name_Device nvarchar(255)
);

CREATE TABLE Device (
    Id_Device int IDENTITY(1,1) PRIMARY KEY,
    Name_Device nvarchar(255),
    Price float,
    Function_Device nvarchar(255),
    Room nvarchar(255),
    Id_Type int FOREIGN KEY REFERENCES Type_Device(Id_Type),
    Status_Device nvarchar(255)
);

/*
    Group Manage Rent Device
*/
CREATE TABLE Rent_Device (
    Id_Rent int IDENTITY(1,1) PRIMARY KEY,
    Date_Rent date,
    Date_Pay date,
	Id_Device int FOREIGN KEY REFERENCES Device(Id_Device),
    Id_Customer int FOREIGN KEY REFERENCES Customer_Detail(Id_Customer),
    Status_Rent nvarchar(255)
);

/*
    Group Manage Liquidate
*/

CREATE TABLE Liquidate (
    Id_Liqui int IDENTITY(1,1) PRIMARY KEY,
    Name_Liqui nvarchar(255),
	Id_Device int FOREIGN KEY REFERENCES Device(Id_Device),
    Date_Liqui date    
);

GO

/*
    INSERT INTO DATABASE FOR TABLE
*/

INSERT INTO Customer_Group (Name_Group)
VALUES
(N'Quản Trị Viên'),
(N'Giáo Viên'),
(N'Sinh Viên'),
(N'Kỹ Thuật Viên'),
(N'Giáo Viên');

INSERT INTO Customer_Detail(Name_Customer, Address_Customer, Grender_Customer, Birthday_Customer, Identity_Card, Id_Group)
VALUES
(N'Administration', N'136 Xuân Thủy, Cầu Giấy, Hà Nội', N'Nam', '2000-12-14', N'123456789', 1),
(N'Phạm Quang Huy', N'136 Xuân Thủy, Cầu Giấy, Hà Nội', N'Nam', '2000-12-14', N'122364952', 2),
(N'Vũ Thái Dương', N'136 Xuân Thủy, Cầu Giấy, Hà Nội', N'Nam', '2000-04-16', N'122364961', 2),
(N'Hoàng Khánh Linh', N'199 Trần Quốc Hoàn, Cầu Giấy, Hà Nội', N'Nữ', '2001-10-20', N'122364962', 3),
(N'Trần Hoàng Long', N'512 Nguyễn Trãi, Thanh Xuân, Hà Nội', N'Nam', '2000-01-13', N'122364963', 2),
(N'Nguyễn Minh Nguyệt', N'31 Thượng Đình, Thanh Xuân, Hà Nội', N'Nữ', '1999-02-14', N'122364964', 4),
(N'Trần Hà Vy', N'56 Nguyễn Lương Bằng, Đống Đa, Hà Nội', N'Nữ', '2002-03-14', N'122364965', 3),
(N'Trần Nguyễn Mạnh Toàn', N'321 Nguyễn Lương Bằng, Đống Đa, Hà Nội', N'Nam', '2001-04-04', N'122364966', 3),
(N'Phạm Thanh Thảo', N'98 Hoàng Cầu, Đống Đa, Hà Nội', N'Nữ', '2002-05-22', N'122364967', 3),
(N'Trịnh Xuân Nam', N'15 Phố Yên Sở, Hoàng Mai, Hà Nội', N'Nam', '1998-12-04', N'122364968', 5),
(N'Mai Thạch Hiên', N'27 Yên Duyên, Hoàng Mai, Hà Nội', N'Nữ', '2001-11-14', N'122364969', 3),
(N'Trịnh Xuân Thức', N'42 Nguyễn Trãi, Thanh Xuân, Hà Nội', N'Nữ', '2001-11-24', N'122364970', 3),
(N'Lưu Ánh Ngọc', N'32 Nguyễn Lương Bằng, Đống Đa, Hà Nội', N'Nữ', '2001-11-14', N'122364971', 3),
(N'Vũ Linh Ngọc', N'159 Phố Yên Sở, Hoàng Mai, Hà Nội', N'Nữ', '2001-11-14', N'122364972', 3),
(N'Trần Linh Trang', N'27 Yên Duyên, Hoàng Mai, Hà Nội', N'Nữ', '2001-11-14', N'122364973', 3),
(N'Ngọc Mai Trang', N'153 Hoàng Cầu, Đống Đa, Hà Nội', N'Nữ', '2001-11-14', N'122364974', 3),
(N'Võ Huy Hoàng', N'526 Xuân Thủy, Cầu Giấy, Hà Nội', N'Nam', '2002-10-27', N'122364975', 3);


INSERT INTO Account(Id_Customer, User_Name_Customer, Password_Customer)
VALUES
(1, N'admin', 'admin'),
(2, N'HuyHnueIT', 'HuyHnueIT'),
(3, N'VuDuong1604', 'VuDuong1604'),
(4, N'LinhHoang01', 'LinhHoang01'),
(5, N'Long1301', 'Long1301'),
(6, N'MinhNguyetIT', 'MinhNguyetIT'),
(7, N'VyTran1234', 'VyTran1234'),
(8, N'ToanProVjp1102', 'ToanProVjp1102'),
(9, N'CongChuaBongBong', 'CongChuaBongBong'),
(10, N'NamITPro', 'NamITPro'),
(11, N'HienXinh', 'HienXinh'),
(12, N'ThucNo1', 'ThucNo1'),
(13, N'Ngockana', 'Ngockana'),
(14, N'Ngocvu', 'Ngocvu'),
(15, N'Trangkk12', 'Trangkk12'),
(16, N'TrangCute', 'TrangCute'),
(17, N'HoangVo2710', 'HoangVo2710');


INSERT INTO Type_Device(Name_Device)
VALUES
(N'WebCam'),
(N'Màn Hình'),
(N'Cây Máy Tính'),
(N'Bàn Phím'),
(N'Chuột'),
(N'Máy In'),
(N'Màn Chiếu'),
(N'Máy Chiếu');

INSERT INTO Device(Name_Device, Price, Function_Device, Room, Id_Type, Status_Device)
VALUES
(N'HP P17A 17.0Inch LED', 2550000, N'Hiển thị hình ảnh', N'K501', 2, N'Đang sử dụng'),
(N'DEL XPS 15', 4500000, N'Hiển thị hình ảnh', N'K501', 2, N'Đang sử dụng'),
(N'Webcam LOGITECH C270 HD', 950000, N'Quay hình ảnh', N'K503', 1, N'Đang sử dụng'),
(N'Webcam Dahua Z2 HD 720P', 550000, N'Quay hình ảnh', N'K503', 1, N'Đang sử dụng'),
(N'Webcam Dahua Z2 HD 720P', 550000, N'Quay hình ảnh', N'K503', 1, N'Đang sử dụng'),
(N'Dell Optiplex 3030 core i3 màn 19.5 inch HD', 4480000, N'Cây máy tính', N'K504', 3, N'Đang sử dụng'),
(N'Dell Optiplex 3030 core i3 màn 19.5 inch HD', 4480000, N'Cây máy tính', N'K504', 3, N'Đang sử dụng'),
(N'Dell Optiplex 3040 SFF intel Pentium G4400', 2900000, N'Cây máy tính', N'K504', 3, N'Đang sử dụng'),
(N'Bàn phím vi tính không dây Rapoo K2600', 349000, N'Bàn phím', N'K502', 4, N'Đang sử dụng'),
(N'Bàn phím không dây Logitech K400 Plus Đen', 649000, N'Bàn phím', N'K502', 4, N'Thanh lý'),
(N'Genius NX 7005 Đen', 200000, N'Chuột không dây', N'K506', 5, N'Thanh lý'),
(N'Microsoft Arc', 2450000, N'Chuột không dây', N'K506', 5, N'Thanh lý'),
(N'Sony VPL-EX435', 13490000, N'Máy chiếu', N'K504', 7, N'Thanh lý'),
(N'Epson EB-X400', 9980000, N'Máy chiếu', N'K504', 7, N'Thanh lý'),
(N'Dalite P70TS 100 Inch', 796000, N'Màn chiếu', N'K503', 7, N'Thanh lý'),
(N'Dalite P70WS 100 Inch', 690000, N'Màn chiếu', N'K503', 7, N'Thanh lý'),
(N'HP LaserJet Pro M12a', 1790000, N'Màn chiếu', N'K503', 7, N'Thanh lý'),
(N'Canon PIXMA G1010', 1990000, N'Màn chiếu', N'K503', 7, N'Không sử dụng'),
(N'HP Neverstop Laser 1000w', 3190000, N'Màn chiếu', N'K503', 7, N'Không sử dụng'),
(N'Acer Nitro 5', 1500000, N'Hiển thị hình ảnh', N'K501', 2, N'Không sử dụng');


INSERT INTO Rent_Device(Date_Rent, Date_Pay, Id_Device, Id_Customer, Status_Rent)
VALUES
('05-11-2018', '07-11-2020', 2, 3, N'Đang sử dụng'),
('2018-10-05', '2019-10-05', 9, 5, N'Đang sử dụng'),
('2017-08-05', '2020-08-07', 3, 3, N'Đang sử dụng'),
('2018-11-05', '2019-02-12', 5, 7, N'Đang sử dụng'),
('2018-11-05', '2020-11-07', 4, 10, N'Đang sử dụng'),
('2018-12-20', '2019-11-07', 1, 4, N'Đang sử dụng'),
('2018-04-16', '2019-11-07', 6, 8, N'Đang sử dụng'),
('2018-11-12', '2019-11-07', 7, 5, N'Đang sử dụng'),
('2018-11-05', '2018-11-07', 8, 6, N'Đang sử dụng');

INSERT INTO Liquidate(Name_Liqui, Id_Device, Date_Liqui)
VALUES
(N'Thanh lý màn hình hỏng', 17, '2018-12-10'),
(N'Thanh lý webcam hỏng', 10, '2018-12-11'),
(N'Thanh lý chuột hỏng', 11, '2020-12-10'),
(N'Thanh lý cây cháy', 12, '2020-12-10'),
(N'Thanh lý bàn phím liệt', 13, '2018-12-10'),
(N'Thanh lý bàn phím mất nút',14, '2019-12-10'),
(N'Thanh lý máy chiếu hỏng đèn', 15, '2019-12-10'),
(N'Thanh lý màn hình hỏng', 16, '2018-02-10');