

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