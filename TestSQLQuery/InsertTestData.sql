INSERT INTO Categories (CategoryID, CategoryName)
VALUES
    (1, 'Одежда'),
    (2, 'Книги');

INSERT INTO Products (ProductID, ProductName, Price)
VALUES
    (1, 'Трусы', 19.99),
    (2, 'Защита Лужина', 29.99),
	(3, 'Инженер', 19.99)

INSERT INTO ProductCategory (ProductID, CategoryID)
VALUES
    (1, 1),
    (2, 2)