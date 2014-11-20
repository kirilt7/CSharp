---1. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), 
---PersonId(FK), Balance). Insert few records for testing. Write a stored procedure that selects 
---the full names of all persons.

CREATE TABLE Persons (
  PersonID int IDENTITY,
  FirstName nvarchar(50) NOT NULL,
  LastName nvarchar(50) NOT NULL, 
  SSN nvarchar(50) NOT NULL,
  CONSTRAINT PK_Persons PRIMARY KEY(PersonID),
)
GO

CREATE TABLE Accounts (
  AccountID int IDENTITY,
  Balance money,
  PersonID int NOT NULL,
  CONSTRAINT PK_Accounts PRIMARY KEY(AccountID),
  CONSTRAINT FK_Persons_Accounts
	FOREIGN KEY (PersonID) 
	REFERENCES Persons(PersonID)
)
GO

INSERT INTO Persons 
VALUES ('Maria', 'Ivanova', '8910200018')

INSERT INTO Persons 
VALUES ('Maria', 'Petrova', '8910200012')

INSERT INTO Persons 
VALUES ('Desa', 'Goshova', '5910200014')

INSERT INTO Persons 
VALUES ('Pesho', 'Goshev', '8910200015')

INSERT INTO Persons 
VALUES ('Gosho', 'Peshev', '8910230091')
GO

INSERT INTO Accounts 
VALUES (300, 1)

INSERT INTO Accounts 
VALUES (500, 2)

INSERT INTO Accounts 
VALUES (1000, 3)

INSERT INTO Accounts 
VALUES (300, 4)

INSERT INTO Accounts 
VALUES (1500, 5)

---2. Create a stored procedure that accepts a number as a parameter and returns all persons
---who have more money in their accounts than the supplied number.

CREATE PROC usp_HaveMoreMoney(
  @balance int = 500)
AS
  SELECT * 
  FROM Persons p
  INNER JOIN Accounts a
    ON p.PersonID = a.PersonID
  WHERE a.Balance > @balance
  ORDER BY a.Balance
GO
EXEC usp_HaveMoreMoney

---3. Create a function that accepts as parameters – sum, yearly interest rate and number of months. 
---It should calculate and return the new sum. Write a SELECT to test whether the function works as expected.

CREATE FUNCTION ufn_InterestIncrease(@sum money, @yearlyRate float, @numOfMounths float)
  RETURNS money
AS
BEGIN
DECLARE @newSum money
SET @newSum = @sum + @sum*(@yearlyRate/100)*(@numOfMounths/12)
RETURN @newSum
END
GO

SELECT dbo.ufn_InterestIncrease(500, 10, 12)
GO

---4. Create a stored procedure that uses the function from the previous example to give an interest 
---to a person's account for one month. It should take the AccountId and the interest rate as parameters.

CREATE PROCEDURE usp_UpdateBalanceWithInterest(@AccountID INT, @interestRate FLOAT) 

AS 

	BEGIN 

		DECLARE @sum MONEY 

		SET @sum = ( 
	
		SELECT Balance

			FROM Accounts

			WHERE AccountId = @AccountID

		)
 
	DECLARE @newSum MONEY

		SET @newSum = dbo.ufn_InterestIncrease(@sum, @interestRate, 1)


	UPDATE Accounts

		SET Balance = CAST(@newSum AS MONEY)

		WHERE AccountID = @AccountID

	END 

GO

EXECUTE usp_UpdateBalanceWithInterest 1, 7

---5. Add two more stored procedures WithdrawMoney( AccountId, money) and DepositMoney (AccountId, money)
---that operate in transactions.

CREATE PROC usp_DepositMoney(@accountID int, @sum money)
AS
BEGIN
	DECLARE @balance money
	SET @balance = (
		SELECT Balance FROM dbo.Accounts
		WHERE AccountID = @accountID
		)
	DECLARE @newBalance money
	SET @newBalance = @balance + @sum
	UPDATE dbo.Accounts
	SET Balance = @newBalance
	WHERE AccountID = @accountID
END
GO

CREATE PROC usp_WithdrawMoney(@accountID int, @sum money)
AS
BEGIN
	DECLARE @balance money
	SET @balance = (
		SELECT Balance FROM dbo.Accounts
		WHERE AccountID = @accountID
		)
	DECLARE @newBalance money
	SET @newBalance = @balance - @sum
		
	UPDATE dbo.Accounts
	SET Balance = @newBalance
	WHERE AccountID = @accountID
END
GO

---6. Create another table – Logs(LogID, AccountID, OldSum, NewSum). Add a trigger to the Accounts table
---that enters a new entry into the Logs table every time the sum on an account changes.

CREATE TABLE Logs (
  LogID int IDENTITY,
  OldSum money NOT NULL,
  NewSum money NOT NUll,
  AccountID int NOT NULL,
  CONSTRAINT PK_Logs PRIMARY KEY(LogID),
  CONSTRAINT FK_Logs_Accounts
	FOREIGN KEY (AccountID) 
	REFERENCES Accounts(AccountID)
)
GO

CREATE TRIGGER tr_LogBalanceChanges ON Accounts FOR UPDATE

AS

	BEGIN

		INSERT INTO Logs

			SELECT i.AccountId, d.Balance, i.Balance

			FROM inserted i JOIN deleted d

				ON d.AccountId = i.AccountId

	END
GO

EXEC usp_DepositMoney 1, 200

---7. Define a function in the database TelerikAcademy that returns all Employee's names
---(first or middle or last name) and all town's names that are comprised of given set of letters. 
---Example 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.

USE TelerikAcademy
GO

CREATE FUNCTION CheckLetters(@word NVARCHAR(100), @letters NVARCHAR(100))
RETURNS BIT
AS
	BEGIN
		DECLARE @lettersCount INT = LEN(@letters), @matches INT = 0, @current NVARCHAR(1)
		WHILE(@lettersCount > 0)
		BEGIN
			SET @current = SUBSTRING(@letters, @lettersCount, 1)
			IF(CHARINDEX(@current, @word, 0) > 0)
			BEGIN
				SET @matches += 1
				SET @lettersCount -= 1
			END
			ELSE
				SET @lettersCount -= 1
			END

			IF(@matches >= LEN(@word) OR @matches >= LEN(@letters))
				RETURN 1
			RETURN 0
		END
GO

CREATE FUNCTION NamesAndTowns(@letters nvarchar(20))
RETURNS @ResultTable TABLE (Name NVARCHAR(100) NOT NULL)
AS
BEGIN
	INSERT INTO @ResultTable
		SELECT LastName FROM Employees
	INSERT INTO @ResultTable
		SELECT FirstName FROM Employees
	INSERT INTO @ResultTable
		SELECT t.Name FROM Towns t

	DELETE FROM @ResultTable
		WHERE dbo.CheckLetters(Name, @letters) = 0
	RETURN
END
GO

SELECT * FROM NamesAndTowns('svetlin') 
ORDER BY Name
SELECT * FROM NamesAndTowns('nakov') 
ORDER BY Name
SELECT * FROM NamesAndTowns('oistmiahf') 
ORDER BY Name

---8. Using database cursor write a T-SQL script that scans all employees and their addresses 
---and prints all pairs of employees that live in the same town.

DECLARE employeeCursor CURSOR READ_ONLY
FOR
	SELECT e1.FirstName, e1.LastName, e2.FirstName, e2.LastName, t1.Name
	FROM Employees e1 JOIN Addresses a1
		ON a1.AddressID = e1.AddressID
		JOIN Towns t1
			ON t1.TownID = a1.TownID, 
		Employees e2 JOIN Addresses a2
			ON e2.AddressID = a2.AddressID
			JOIN Towns t2
				ON a2.TownID = t2.TownID
	WHERE t1.Name = t2.Name AND e1.EmployeeID <> e2.EmployeeID
	ORDER BY e1.FirstName, e2.FirstName

OPEN employeeCursor

DECLARE @firstName NVARCHAR(100), @lastName NVARCHAR(100), @otherFirstName NVARCHAR(100), @otherLastName NVARCHAR(100), @town NVARCHAR(100)
FETCH NEXT FROM employeeCursor INTO @firstName, @lastName, @otherFirstName, @otherLastName, @town

WHILE @@FETCH_STATUS = 0
  BEGIN
	PRINT @firstName + ' ' + @lastName + ' | ' + @otherFirstName + ' ' + @otherLastName + ' -> ' + @town
    FETCH NEXT FROM employeeCursor
    INTO @firstName, @lastName, @otherFirstName, @otherLastName, @town
  END

CLOSE employeeCursor
DEALLOCATE employeeCursor
GO
