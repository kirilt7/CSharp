--Task1----------------------------------------------------------------------

SELECT FirstName + ' ' + LastName AS Name, Salary
FROM Employees
WHERE Salary = 
  (SELECT MIN(Salary)
   FROM Employees)

--Task2----------------------------------------------------------------------

SELECT FirstName + ' ' + LastName AS Name, Salary
FROM Employees
WHERE Salary < 
  (SELECT MIN(Salary)*1.1
   FROM Employees)

--Task3----------------------------------------------------------------------

SELECT e.LastName, e.Salary, d.Name
FROM Employees e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE Salary = 
	(SELECT MIN(Salary)
	 FROM Employees
	 WHERE DepartmentID = d.DepartmentID)

--Task4----------------------------------------------------------------------

SELECT AVG(Salary) AS [Averrage Salary]
FROM Employees
WHERE DepartmentID = 1

--Task5----------------------------------------------------------------------

SELECT AVG(Salary) AS [Averrage Salary]
FROM Employees
WHERE DepartmentID = 
	(SELECT DepartmentID FROM Departments
   WHERE Name='Sales')

--Task6----------------------------------------------------------------------

SELECT COUNT(FirstName) AS [Number of employees]
FROM Employees
WHERE DepartmentID = 
	(SELECT DepartmentID FROM Departments
   WHERE Name='Sales')

--Task7----------------------------------------------------------------------

SELECT COUNT(FirstName) AS [Number of employees]
FROM Employees
WHERE ManagerID IS NOT NULL

--Task8----------------------------------------------------------------------

SELECT COUNT(FirstName) AS [Number of employees]
FROM Employees
WHERE ManagerID IS NULL

--Task9----------------------------------------------------------------------

SELECT D.Name, AVG(E.Salary) AS [Averrage Salary]
FROM Employees E
INNER JOIN Departments D
ON E.DepartmentID = D.DepartmentID
GROUP BY D.Name

--Task10---------------------------------------------------------------------

SELECT D.Name AS [Department], T.Name AS [Town], COUNT(E.EmployeeID) AS [Number of employees]
FROM Employees E
INNER JOIN Departments D
	ON E.DepartmentID = D.DepartmentID
INNER JOIN Addresses A
	ON E.AddressID = A.AddressID
	INNER JOIN Towns T
		ON A.TownID = T.TownID
GROUP BY D.Name, T.Name

--Task11---------------------------------------------------------------------

SELECT M.FirstName, M.LastName
FROM Employees E
INNER JOIN Employees M
	ON M.EmployeeID = E.ManagerID
GROUP BY M.FirstName, M.LastName
HAVING COUNT(E.EmployeeID) IN (5)

--Task12---------------------------------------------------------------------

SELECT E.LastName, ISNULL(M.LastName, '(no manager)') AS [Manager LastName] 
FROM Employees E
LEFT OUTER JOIN Employees M
	ON E.ManagerID = M.EmployeeID

--Task13---------------------------------------------------------------------

SELECT LastName
FROM Employees
WHERE LEN(LastName) = 5

--Task14---------------------------------------------------------------------

SELECT CONVERT(nvarchar, GETDATE(), 104) + ' ' + (SELECT CONVERT(nvarchar, GETDATE(), 114)) as [Current time]

--Task15---------------------------------------------------------------------

CREATE TABLE Users (
  UserID int IDENTITY,
  UserName nvarchar(50) UNIQUE,
  Password nvarchar(50) NOT NULL,
  FullName nvarchar(50)	NOT NULL, 
  LastLogin date,
  CONSTRAINT PK_Users PRIMARY KEY(UserID),
  CHECK (LEN(Password) > 5)
)

--Task16---------------------------------------------------------------------

CREATE VIEW [UsersLoggedInToday] AS 

SELECT * 
FROM Users 
WHERE DATEPART(YEAR, LastLogin) = DATEPART(YEAR, GETDATE()) AND
 
	DATEPART(MONTH, LastLogin) = DATEPART(MONTH, GETDATE()) AND 
	DATEPART(DAY, LastLogin) = DATEPART(DAY, GETDATE())

--Task17---------------------------------------------------------------------

CREATE TABLE Groups (
	GroupId int IDENTITY,
	Name nvarchar(50) UNIQUE,
	CONSTRAINT PK_Groups PRIMARY KEY(GroupID)
)

--Task18---------------------------------------------------------------------

ALTER TABLE Users 

ADD GroupID int 

ALTER TABLE Users 

ADD CONSTRAINT FK_Users_Groups 

	FOREIGN KEY (GroupID) 

	REFERENCES Groups(GroupID)

--Task19---------------------------------------------------------------------

INSERT INTO Users (UserName, Password, FullName) 
VALUES ('MaryJane', 'kakamara', 'Maria Ivanova')

INSERT INTO Users (UserName, Password, FullName) 
VALUES ('vankata-picha', '1234567', 'Vankata Ivanov')

INSERT INTO Users (UserName, Password, FullName) 
VALUES ('pesho-dzvera', '1234567', 'Peshkata Peshev')

INSERT INTO Groups(Name)
VALUES('Qkite batki')

INSERT INTO Groups(Name)
VALUES('Qkite kaki')

INSERT INTO Groups(Name)
VALUES('Qkite kifli')

--Task20---------------------------------------------------------------------

UPDATE Users
SET GroupId = 1 

WHERE UserName = 'pesho-dzvera'



UPDATE Users
SET UserName = 'vankata-kiflata'
 
WHERE Username = 'vankata-picha'

 

UPDATE Groups
SET Name = 'Pichagite' 

WHERE GroupID = 1

--Task21---------------------------------------------------------------------

DELETE FROM Users
WHERE FullName = 'Pesho Peshev'

DELETE FROM Groups
WHERE GroupId = 3

--Task22---------------------------------------------------------------------

INSERT INTO Users(FullName, UserName, Password) 

SELECT
	FirstName + ' ' + LastName AS FullName,
	
SUBSTRING(FirstName, 0, 1) + '' + LOWER(LastName) + CAST(EmployeeID AS varchar) AS UserName, 

SUBSTRING(FirstName, 0, 1) + '' + LOWER(LastName) + '1234' AS Password 

FROM Employees

--Task23---------------------------------------------------------------------

UPDATE Users
SET Password = NULL 

WHERE LastLogin IS NULL 

	OR DATEDIFF(day, '2010-03-10 23:59:59.9999999', LastLogin) < 0

--Task24---------------------------------------------------------------------

DELETE FROM Users

WHERE Password IS NULL

--Task25---------------------------------------------------------------------

SELECT D.Name, E.JobTitle, AVG(E.Salary) AS [Averrage Salary]
FROM Employees E
INNER JOIN Departments D
	ON E.DepartmentID = D.DepartmentID
GROUP BY D.Name, E.JobTitle
ORDER BY D.Name

--Task26---------------------------------------------------------------------

SELECT D.Name, E.JobTitle, MIN(E.Salary) AS [Min Salary], MIN(E.LastName) AS [LastName]
FROM Employees E
INNER JOIN Departments D
	ON E.DepartmentID = D.DepartmentID
GROUP BY D.Name, E.JobTitle
ORDER BY D.Name

--Task27---------------------------------------------------------------------

SELECT TOP 1 T.Name as [Town name], COUNT(*) as [Employees]
FROM Employees E
INNER JOIN Addresses A
	ON E.AddressID = A.AddressID
	INNER JOIN Towns T
		ON A.TownID = T.TownID
GROUP BY T.Name

--Task28---------------------------------------------------------------------

SELECT T.Name AS [Town name], COUNT(*) as [Managers]
FROM Employees E
INNER JOIN Employees M
	ON E.ManagerID = M.EmployeeID
INNER JOIN Addresses A
	ON M.AddressID = A.AddressID
	INNER JOIN Towns T
		ON A.TownID = T.TownID
GROUP BY T.Name

--Task29---------------------------------------------------------------------



--Task30---------------------------------------------------------------------



--Task31---------------------------------------------------------------------



--Task32---------------------------------------------------------------------

