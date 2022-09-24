CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" VARCHAR(50)
);

INSERT INTO Products
VALUES
	(1, 'Milk'),
	(2, 'Baloon'),
	(3, 'Table'),
	(4,'Pen');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" VARCHAR(50)
);

INSERT INTO Categories
VALUES
	(1, 'Grocery'),
	(2, 'Toy'),
	(3, 'Furniture');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(2, 2),
	(3, 3), 
	(2, 1),
	(2, 3);

SELECT p.Name, c.Name
FROM Products p
LEFT JOIN ProductCategories t
	ON p.Id = t.ProductId
LEFT JOIN Categories c
	ON c.Id = t.CategoryId;