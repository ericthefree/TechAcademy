USE [db_zooTest1]
GO

DECLARE @totalHab MONEY;
DECLARE @totalNut MONEY;
DECLARE @results MONEY;
SET @totalHab = (SELECT SUM(habitat_cost) FROM tbl_habitat;
SET @totalNut = (SELECT SUM(nutrition_cost) FROM tbl_nutrition;
SET @results = (@totalHab + @totalNut);

PRINT (CONVERT(varchar(50), @totalHab) + char(9) + ' - The total Habitat Cost' + char(13) + 
	CONVERT(varchar(50), @totalNut) + char(9) + char(9) + ' - The total Nutrition Cost' + char(13) + '---------' + char(13) + 
	CONVERT(varchar(50), @results)
);




SELECT * FROM table_A
SELECT * FROM table_A INNER JOIN table_B ON table_B.id = table_A.id;


SELECT table_A.username, table_A.fullname, table_B.zipcodes
FROM table_A 
FULL OUTER JOIN table_B
WHERE table_B.id = table_A.id;

SELECT table_A.id, table_A.username, table_B.id, table_B.phoneNumber 
FROM table_A
LEFT JOIN table_B ON table_B.id = table_A.id;

SELECT table_A.wholesale, table_A.products, table_B.vendor, table_B.contact 
FROM table_A
RIGHT JOIN table_B ON table_B.id = table_A.id;
WHERE table_A.id LIKE 'de%';