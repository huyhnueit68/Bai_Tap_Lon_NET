

/*
	Delete database
*/
DROP DATABASE QuanLyThietBi
DROP TABLE Account;
DROP TABLE Customer_Detail;
DROP TABLE Customer_Group;
DROP TABLE Device;
DROP TABLE Liquidate;
DROP TABLE Liquidate_Detail;
DROP TABLE Rent_Detail;
DROP TABLE Rent_Device;
DROP TABLE Type_Device;

/*
	Select database
*/

SELECT * FROM Account;
SELECT * FROM Customer_Detail;
SELECT * FROM Customer_Group;
SELECT * FROM Device;
SELECT * FROM Liquidate;
SELECT * FROM Rent_Device;
SELECT * FROM Type_Device;

/*
	Query login application
*/

SELECT Customer_Detail.Id_Group, Customer_Detail.Name_Customer
FROM Account
INNER JOIN Customer_Detail ON Account.Id_Customer=Customer_Detail.Id_Customer
WHERE Account.User_Name_Customer = 'HuyHnueIT' AND Account.PassWord_Customer = 'HuyHnueIT';

/*
	Query account
*/

SELECT Id_Customer FROM Account
WHERE User_Name_Customer = 'admin' 
AND PassWord_Customer = 'admin'

SELECT Id_Customer FROM Account
WHERE User_Name_Customer = 'admin' 
AND PassWord_Customer = 'admin'

UPDATE Account
SET User_Name_Customer = 'admin', PassWord_Customer= 'admin'
WHERE Id_Customer = 1;


/*
	Query delete
*/

DELETE FROM Account WHERE Id_Customer= 3 AND User_Name_Customer = N'huy' AND PassWord_Customer = 'huy';

/*
	Query insert
*/
SELECT * FROM Customer_Detail WHERE Id_Customer = 11
INSERT INTO Account
VALUES
(5, N'admin', 'admin')

/*
	Query for customer_detail
*/

SELECT * FROM Customer_Detail WHERE Id_Customer  = 1

DELETE FROM Customer_Detail WHERE Id_Customer = 2

/*
	update
*/

UPDATE Customer_Detail 
SET Name_Customer = N'Pham Quang Minh', 
Address_Customer = N'199 Tran Quoc Hoan, Xuan Thuy, Cau Giay',
Grender_Customer = N'Nam',
Birthday_Customer = '2000/12/14 12:00:00 AM',
Identity_Card = '4654316874',
Id_Group = 2
WHERE Id_Customer = 2; 

/*
	insert cusotomer detail
*/

SELECT * FROM Customer_Group WHERE Id_Group  = 1

INSERT INTO Customer_Detail(Name_Customer, Address_Customer, Grender_Customer, Birthday_Customer, Identity_Card, Id_Group)
VALUES
(N'Administration', N'136 Xuân Thủy, Cầu Giấy, Hà Nội', N'Nam', '2000-12-14', N'123456789', 1)


/*
	query for customer group
*/

INSERT INTO Customer_Group (Name_Group)
VALUES
(N'Quản Trị Viên')

/*
	query for device
*/


UPDATE Device
SET Name_Device = N'HP P17A 17.0Inch LED',
Price = 2550000,
Function_Device = N'Hiển thị hình ảnh',
Room = 'K506',
Id_Type = 2,
Status_Device = N'Không sử dụng'
WHERE Id_Device = 1;

UPDATE Device
SET Status_Device = N'Không sử dụng'
WHERE Id_Device = 2;
/*
	query for Type_Device
*/

UPDATE Type_Device 
SET Name_Device = N'HIHIH'
WHERE Id_Type = 1

/*
	 query for rent device
*/

UPDATE Rent_Device
SET Date_Rent = '2019-11-11',
Date_Pay= '2020-11-11',
Id_Device = 1,
Id_Customer = 1,
Status_Rent = N'Không sử dụng'
WHERE Id_Rent = 5;

UPDATE Rent_Device
SET Status_Rent = N'Không sử dụng'
WHERE Id_Rent = 5;


UPDATE Device
SET Status_Device = N'Đang sử dụng'
WHERE Id_Device = 1;

/*
	query liqui
*/

UPDATE Liquidate
SET Name_Liqui  = N'Thanh lý màn hình hỏng',
Id_Device = 1,
Qty_Device = 3,
Date_Liqui = '2020-12-14'
WHERE Id_Liqui = 1

SELECT * FROM Device WHERE Status_Device = N'Không sử dụng'

SELECT * FROM Liquidate WHERE Id_Liqui = 2

INSERT INTO Liquidate(Name_Liqui, Id_Device, Qty_Device, Date_Liqui)
VALUES
(N'Thanh lý màn hình hỏng', 2, 3, '2018-12-10')

/* Tinh Tong so thiet bi dang su dung */
SELECT COUNT(*) AS Total_Device

FROM Device
WHERE Status_Device = N'Đang sử dụng'


/* Tinh Tong so thiet bi thanh ly */
SELECT COUNT(*) AS Total_Liqui
FROM Liquidate

/* thong ke thiet bi theo ngay thue gom (Id_Device, Name_Device, Qty_Device, Id_Rent, Date_Liqui, Name_Customer)*/

SELECT D.Id_Device as 'MÃ THIẾT BỊ', D.Name_Device as 'TÊN THIẾT BỊ', RD.Qty_Device as 'SỐ LƯỢNG MƯỢN', RD.Id_Rent as 'MÃ MƯỢN', RD.Date_Rent as 'NGÀY MƯỢN', CD.Name_Customer as 'TÊN NGƯỜI MƯỢN'
FROM Rent_Device as RD, Device as D, Customer_Detail as CD
WHERE Date_Rent >= '1999-12-12' AND Date_Rent <= '2020-12-12'
AND RD.Id_Device = D.Id_Device
AND RD.Id_Customer = CD.Id_Customer

/* thong ke thiet bi theo ten (Id_Device, Name_Device, Qty_Device, Date_Liqui, Name_Customer)*/
SELECT D.Id_Device as 'MÃ THIẾT BỊ', D.Name_Device as 'TÊN THIẾT BỊ', RD.Qty_Device as 'SỐ LƯỢNG MƯỢN', RD.Date_Rent as 'NGÀY MƯỢN', CD.Name_Customer AS 'TÊN NGƯỜI DÙNG'
FROM Rent_Device as RD, Device as D, Customer_Detail as CD
WHERE CD.Name_Customer LIKE '%a%'
AND RD.Id_Device = D.Id_Device
AND RD.Id_Customer = CD.Id_Customer
/*update cai nay group by ma khach hang*/

/* thong ke thiet bi hang nam (Year, Qty_Device)*/
SELECT DATEPART(yyyy, Date_Liqui) AS 'Year', SUM(Qty_Device) AS 'Total'
FROM Liquidate
GROUP BY DATEPART(yyyy, Date_Liqui)