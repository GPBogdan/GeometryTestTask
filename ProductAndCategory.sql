
--create table Product(
--	ProductId INT PRIMARY KEY IDENTITY (1, 1),
--	ProductName NVARCHAR (150)
--);

--create table Category(
--	CategoryId INT PRIMARY KEY IDENTITY (1, 1),
--	CategoryName NVARCHAR (150)
--);

--CREATE TABLE ProductCategories (
--	ProductId INT FOREIGN KEY REFERENCES Product(ProductId),
--	CategoryId INT FOREIGN KEY REFERENCES Category(CategoryId),
--	PRIMARY KEY (ProductId, CategoryId)
--);

--INSERT INTO Product
--VALUES
--	('Air Jordan 13'),
--	('Mercedes-Benz S500'),
--	('Lenovo Legion 5'),
--  ('Popcorn')

--INSERT INTO Category
--VALUES
--	('Shoes'),
--	('Car'),
--	('Labtop'),
--  ('Electronics');


--INSERT INTO ProductCategories
--VALUES
--	(1, 1),
--	(2, 2),
--	(3, 3),
--	(3, 4);

SELECT product.ProductName, category.CategoryName
FROM Product product
LEFT JOIN ProductCategories pc
	ON product.ProductId = pc.ProductId
LEFT JOIN Category category
	ON PC.CategoryId = category.CategoryId;