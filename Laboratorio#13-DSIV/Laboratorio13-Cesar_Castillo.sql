SELECT *
FROM Products

GO
SELECT ProductID, ProductName, UnitPrice
FROM Products

GO
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE UnitPrice > 15

GO
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE UnitPrice >= 15 AND UnitPrice <= 50

GO
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE UnitPrice BETWEEN 15 AND 50

GO
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE NOT UnitPrice > 15

GO
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE ProductID > 15 OR UnitPrice < 10

GO
SELECT EmployeeID, LastName
FROM Employees
WHERE LastName LIKE 'D%'

GO
SELECT EmployeeID, LastName
FROM Employees
WHERE LastName LIKE '%N'

GO
SELECT EmployeeID, LastName, Title
FROM Employees
WHERE Title LIKE '%SALES%'

GO
SELECT EmployeeID, LastName
FROM Employees
WHERE LastName NOT LIKE 'D%'

GO
SELECT ProductID, ProductName, UnitPrice
FROM Products
ORDER BY ProductID ASC

GO
SELECT ProductID, ProductName, UnitPrice
FROM Products
ORDER BY ProductID DESC

GO
SELECT DISTINCT OrderID
FROM [Order Details]

GO
SELECT TOP 5 OrderID, ProductID, Quantity
FROM [Order Details]

GO
SELECT TOP 10 PERCENT OrderID, ProductID, Quantity
FROM [Order Details]

GO
SELECT CategoryName AS [NOMBRE DE CATEGORIA]
FROM Categories

GO
SELECT OrderID, OrderDate, ShippedDate, ShippedDate + 5 AS RETRASOENVIO
FROM Orders

GO
SELECT OrderID, P.ProductID, ProductName
FROM Products P
INNER JOIN [Order Details] OD
ON P.ProductID = OD.ProductID

GO
SELECT ProductName, CompanyName, ContactName
FROM Products P
FULL JOIN Suppliers S
ON P.SupplierID = S.SupplierID