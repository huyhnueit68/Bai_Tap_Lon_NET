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
    Qty_Device int,
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
	Qty_Device int,
    Id_Customer int FOREIGN KEY REFERENCES Customer_Detail(Id_Customer),
    Status_Rent nvarchar(255)
);

/*
    Group Manage Liquidate
*/

CREATE TABLE Liquidate (
    Id_Liqui int IDENTITY(1,1) PRIMARY KEY,
    Name_Liqui nvarchar(255),
    Date_Liqui date    
);

CREATE TABLE Liquidate_Detail(
    Id_Liqui int FOREIGN KEY REFERENCES Liquidate(Id_Liqui),
    Id_Device int FOREIGN KEY REFERENCES Device(Id_Device),
    Qty_Device int
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
(N'Phạm Quang Huy', N'136 Xuân Thủy, Cầu Giấy, Hà Nội', N'Nam', '2000-12-14', N'122364952', 2);

INSERT INTO Account(Id_Customer, User_Name_Customer, Password_Customer)
VALUES
(1, N'admin', 'admin'),
(2, N'HuyHnueIT', 'HuyHnueIT');

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

INSERT INTO Device(Name_Device, Qty_Device, Price, Function_Device, Room, Id_Type, Status_Device)
VALUES
(N'HP P17A 17.0Inch LED', 5, 2550000, N'Hiển thị hình ảnh', N'K501', 2, N'Chưa sử dụng');

INSERT INTO Rent_Device(Date_Rent, Date_Pay, Id_Device, Qty_Device, Id_Customer, Status_Rent)
VALUES
('2018-11-05', '2018-11-07',1, 5, 1, N'Đang sử dụng'), 
('2019-11-05', '2020-11-07',2, 4, 1, N'Không sử dụng');

INSERT INTO Liquidate(Name_Liqui, Date_Liqui)
VALUES
(N'Thanh lý màn hình hỏng', '2018-12-10');

INSERT INTO Liquidate_Detail(Id_Liqui, Id_Device, Qty_Device)
VALUES
(1, 1, 9);