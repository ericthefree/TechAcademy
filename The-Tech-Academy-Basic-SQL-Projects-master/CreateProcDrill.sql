CREATE PROC 
	dbo.uspGetMetQuotaSalesByStateByAmount @salesYTD INT, @state nvarchar(20)
AS
BEGIN
	SELECT a1.FirstName AS 'First Name:', 
		a1.LastName AS 'Last Name:', 
		a5.City AS 'City:',
		a6.Name AS 'State:',
		a2.SalesQuota AS 'Sales Quota:', 
		a2.SalesYTD AS 'Sales YTD:', 
		a2.SalesLastYear AS 'Sales Last Year:'

	FROM [AdventureWorks2014].[Person].[Person] a1
		INNER JOIN Sales.SalesPerson a2 ON a2.BusinessEntityID = a1.BusinessEntityID
		INNER JOIN HumanResources.Employee a3 ON a3.BusinessEntityID = a1.BusinessEntityID
		INNER JOIN Person.BusinessEntityAddress a4 ON a4.BusinessEntityID = a1.BusinessEntityID
		INNER JOIN Person.Address a5 ON a5.AddressID = a4.AddressID
		INNER JOIN Person.StateProvince a6 ON a6.StateProvinceID = a5.StateProvinceID
	WHERE Name LIKE @state AND SalesYTD >= @salesYTD
	;
END

EXEC dbo.uspGetMetQuotaSalesByStateByAmount @salesYTD = 500000, @state = 'Wa'