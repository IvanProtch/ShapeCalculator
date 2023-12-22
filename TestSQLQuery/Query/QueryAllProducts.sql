SELECT
    P.ProductName AS 'Имя продукта',
    COALESCE(C.CategoryName, 'Без категории') AS 'Имя категории'
FROM
    dbo.Products P
LEFT JOIN
    dbo.ProductCategory PC ON P.ProductID = PC.ProductID
LEFT JOIN
    dbo.Categories C ON PC.CategoryID = C.CategoryID;