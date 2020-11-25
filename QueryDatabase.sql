

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
SELECT * FROM Liquidate_Detail;
SELECT * FROM Rent_Detail;
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