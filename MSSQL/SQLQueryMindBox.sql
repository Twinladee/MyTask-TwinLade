SELECT p.productName, c.categoryName as Result
FROM Products p
LEFT JOIN ProductCategories pc
ON p.ProductId = pc.ProductId
LEFT JOIN Categories c
ON pc.CategoryId = c.CategoryId;
