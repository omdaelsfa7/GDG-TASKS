----------------------------------- 
--creating database and its tabels ;)
-----------------------------------

create database RetailStoreDB ; 

CREATE TABLE CUSTOMERS (
	CustomersID INT PRIMARY KEY IDENTITY(1,1),
	FirstName varchar(255) ,
	LastName varchar(255) ,
	Email varchar(255) , 
	RegistrationDate date ,
	
)

CREATE TABLE Products(
	ProductID int PRIMARY KEY IDENTITY(1,1) , 
	ProductName varchar(255) , 
	Category varchar(255) ,
	Price decimal , 
	StockQuantity int 
)

CREATE TABLE Orders(
	OrderID int PRIMARY KEY IDENTITY(1,1) ,
	CustomersID int FOREIGN KEY REFERENCES  Customers(CustomersID) , 
	ProductID int FOREIGN KEY REFERENCES Products(ProductID) , 
	OrderDate date , 
	Quantity int 
)

-----------------------------------
--inserting 5 records to each table 
------------------------------------

INSERT INTO CUSTOMERS(FirstName , LastName , Email , RegistrationDate)
VALUES 
	('Omar' , 'sholkamy' , 'omaremad11113@gmail.com' , '2006-1-1'),
	('ahmad' , 'gaith' , 'Awessam@gmail.com' , '2005-2-2' ),
	('Eyad' , 'abdelkareem' , 'eabdelkareem@gmail.com' , '2005-3-3' ),
	('ali' , 'sholkamy' , 'ailsholkamy2013@gmail.com' , '2013-11-1' ) ,
	('Abdelrahman' , 'Ashraf' , 'budyashraf99@gmail.com' , '2005-11-26' )
	

INSERT INTO Products(ProductName , Category , Price , StockQuantity)
VALUES 
	('vcola' , 'soda' , 25 , 200),
	('tuna' , 'canned' , 50 , 150 ),
	('chips' , 'snacks' , 10 , 400 ),
	('ketchup' , 'tomato' , 35 , 175 ) ,
	('mrclean' , 'cleaners' , 70 , 350 )

INSERT INTO Orders(CustomersID , ProductID , OrderDate , Quantity)
VALUES 
	(10 , 1 , '2025-1-1', 3),
	(10 , 4 , '2025-1-2', 1 ),
	(11 , 2 , '2025-2-1', 10 ),
	(12 , 3 , '2025-2-2', 120 ) ,
	(11 , 5 , '2025-1-1', 12 )

---------------------------
--preform queries 
------------------------
--1

SELECT *FROM CUSTOMERS 
SELECT *FROM Products 
SELECT *FROM Orders 

--2

SELECT * FROM CUSTOMERS WHERE (RegistrationDate > '2005-10-1' )

--3 

SELECT TOP 3 * FROM Products ORDER BY PRICE DESC 

-------------
--join tabels
-------------

--1 

SELECT	

    CUSTOMERS.FirstName, 
    CUSTOMERS.LastName,
	Products.ProductName ,
	Products.Category , 
	Products.Price

FROM CUSTOMERS
JOIN Orders ON CUSTOMERS.CustomersID = Orders.CustomersID
JOIN Products ON Products.ProductID = Orders.ProductID

--2

SELECT 
	
	CUSTOMERS.FirstName , 
	CUSTOMERS.LastName , 
	SUM(Products.Price *Orders.Quantity) AS AmountSpent

FROM Orders
join CUSTOMERS ON CUSTOMERS.CustomersID = Orders.CustomersID
join Products ON Products.ProductID = Orders.ProductID
GROUP BY CUSTOMERS.CustomersID, CUSTOMERS.FirstName, CUSTOMERS.LastName;

-------------
--use groupby
-------------

--1


SELECT 
	CUSTOMERS.FirstName , 
	CUSTOMERS.LastName , 
	COUNT(Orders.OrderID) AS totalOrders
FROM Orders
join CUSTOMERS ON CUSTOMERS.CustomersID = Orders.CustomersID
GROUP BY CUSTOMERS.FirstName , CUSTOMERS.LastName , CUSTOMERS.CustomersID

--2

SELECT
	Products.ProductName , 
	SUM(Orders.Quantity) AS TotalSales
FROM Orders
join Products ON Products.ProductID = Orders.ProductID
GROUP BY ProductName