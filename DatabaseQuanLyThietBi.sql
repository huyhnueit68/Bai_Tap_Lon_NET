CREATE DATABASE QuanLyThietBi;
GO
USE QuanLyThietBi;

/*
    Group Manage Customer
*/
CREATE TABLE Customer_Group (
    Id_Group int IDENTITY(1,1) PRIMARY KEY,
    Name_Group varchar(255)
);

CREATE TABLE Customer_Detail(
    Id_Customer int IDENTITY(1,1) PRIMARY KEY,
    Name_Customer varchar(255),
    Address_Customer varchar(255),
    Grender_Customer varchar(255),
    Birthday_Customer date,
    Identity_Card varchar(255),
    Id_Group int FOREIGN KEY REFERENCES Customer_Group(Id_Group)
);

CREATE TABLE Account(
    Id_Customer int FOREIGN KEY REFERENCES Customer_Detail(Id_Customer),
    User_Name_Customer varchar(255),
    Password_Customer varchar(255)
);

/*
    Group Manage Device
*/
CREATE TABLE Type_Device (
    Id_Type int IDENTITY(1,1) PRIMARY KEY,
    Name_Device varchar(255)
);

CREATE TABLE Device (
    Id_Device int IDENTITY(1,1) PRIMARY KEY,
    Name_Device varchar(255),
    Qty_Device int,
    Price float,
    Function_Device varchar(255),
    Room varchar(255),
    Id_Type int FOREIGN KEY REFERENCES Type_Device(Id_Type),
    Status_Device varchar(255)
);

/*
    Group Manage Rent Device
*/
CREATE TABLE Rent_Device (
    Id_Rent int IDENTITY(1,1) PRIMARY KEY,
    Date_Rent date,
    Date_Pay date,
    Id_Customer int FOREIGN KEY REFERENCES Customer_Detail(Id_Customer),
    Status_Device varchar(255)
);

CREATE TABLE Rent_Detail (
    Id_Rent int FOREIGN KEY REFERENCES Rent_Device(Id_Rent),
    Id_Device int FOREIGN KEY REFERENCES Device(Id_Device),
    Qty_Device int
);

/*
    Group Manage Liquidate
*/

CREATE TABLE Liquidate (
    Id_Liqui int IDENTITY(1,1) PRIMARY KEY,
    Name_Liqui varchar(255),
    Date_Liqui date    
);

CREATE TABLE Liquidate_Detail(
    Id_Liqui int FOREIGN KEY REFERENCES Liquidate(Id_Liqui),
    Id_Detail int FOREIGN KEY REFERENCES Device(Id_Device),
    Qty_Device int
);

GO