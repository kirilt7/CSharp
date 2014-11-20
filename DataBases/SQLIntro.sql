--Task1----------------------------------------------------------------------

SQL is declarative language for query and manipulation of relational data.
DML (Data manipulation language)  is a family of syntax elements used for 
selecting, inserting, deleting and updating data in a database.
DDL (Data definition language) is a syntax for defining data structures, 
especially database schemas.
The most important SQL commands are SELECT, INSERT, UPDATE, DELETE; 
CREATE, DROP, ALTER, GRANT, REVOKE

--Task2----------------------------------------------------------------------

T-SQL (Transact SQL) is an extension to the standard SQL language. Supports
if statements, loops, exceptions.

--Task4----------------------------------------------------------------------

SELECT *
FROM Departments

--Task5----------------------------------------------------------------------

SELECT Name
FROM Departments

--Task6----------------------------------------------------------------------

SELECT Salary
FROM Employees

--Task7----------------------------------------------------------------------

SELECT FirstName + ' ' + LastName AS [Fullname]
FROM Employees

--Task8----------------------------------------------------------------------

SELECT FirstName + '.' + LastName  + '@telerik.com' AS [Full Email Addresses]
FROM Employees

--Task9----------------------------------------------------------------------

SELECT DISTINCT Salary
FROM Employees

--Task10---------------------------------------------------------------------

SELECT *
FROM Employees
WHERE JobTitle = 'Sales Representative'

--Task11---------------------------------------------------------------------

SELECT FirstName
FROM Employees
WHERE FirstName LIKE 'SA%'

--Task12---------------------------------------------------------------------

SELECT LastName
FROM Employees
WHERE LastName LIKE '%ei%'

--Task13---------------------------------------------------------------------

SELECT LastName, Salary
FROM Employees
WHERE Salary >= 20000 AND Salary <= 30000

--Task14---------------------------------------------------------------------

SELECT LastName, Salary
FROM Employees
WHERE Salary IN (25000, 14000, 12500, 23600)
ORDER BY Salary

--Task15---------------------------------------------------------------------

SELECT LastName
FROM Employees
WHERE ManagerID IS NULL

--Task16---------------------------------------------------------------------

SELECT LastName, Salary
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC

--Task17---------------------------------------------------------------------

SELECT TOP 5 LastName, Salary
FROM Employees
ORDER BY Salary DESC

--Task18---------------------------------------------------------------------

SELECT e.LastName, a.AddressText
FROM Employees e
INNER JOIN Addresses a 
ON e.AddressID = a.AddressID

--Task19---------------------------------------------------------------------

SELECT e.LastName, a.AddressText
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID

--Task20---------------------------------------------------------------------

SELECT e.LastName + 'is managed by ' + m.LastName
FROM Employees e
INNER JOIN Employees m
ON e.ManagerID = m.EmployeeID

--Task21---------------------------------------------------------------------

SELECT e.LastName + 'is managed by ' + m.LastName + ', ' + a.AddressText
FROM Employees e
INNER JOIN Employees m
	ON e.ManagerID = m.EmployeeID
INNER JOIN Addresses a 
	ON e.AddressID = a.AddressID

--Task22---------------------------------------------------------------------

SELECT Name AS [Departments Towns List]
FROM Departments
UNION 
SELECT Name AS [Departments Towns List]
FROM Towns

--Task23---------------------------------------------------------------------

SELECT e.LastName EmpLastName, m.LastName MgrLastName
FROM Employees m  RIGHT OUTER JOIN Employees e
  ON m.EmployeeID = e.ManagerID

-----OR-WITH-LEFT-OUTER-JOIN

SELECT e.LastName EmpLastName, m.LastName MgrLastName
FROM Employees e LEFT OUTER JOIN Employees m
  ON e.ManagerID = m.EmployeeID

--Task24---------------------------------------------------------------------

SELECT e.LastName, e.HireDate
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN ('Sales', 'Finance')
	AND e.HireDate> CAST('1995-01-01' AS smalldatetime)
	AND e. HireDate < CAST('2005-01-01' AS smalldatetime)
