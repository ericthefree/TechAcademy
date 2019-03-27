/* I used the test db we were setting up during the video's for drill's 1-6 */
USE db_zooTest1
GO

/*  Compose a SELECT statement that queries for the following information */

/* DRILL 1 */
/* All information from the habitat table. */

SELECT * FROM tbl_habitat;

/* DRILL 2 */
/* Retrieve all names from the species_name column that have a species_order value of 3. */

SELECT species_name FROM tbl_species WHERE species_order = '3';

/* DRILL 3 */
/* Retrieve only the nutrition_type from the nutrition table that have a nutrition_cost of 600.00 or less. */

SELECT nutrition_type FROM tbl_nutrition WHERE nutrition_cost >= '600';

/* DRILL 4 */
/* Retrieve all species_names with the nutrition_id between 2202 and 2206 from the nutrition table. */

SELECT a1.species_name FROM tbl_species a1 
	INNER JOIN tbl_nutrition a2 ON a2.nutrition_id = a1.species_nutrition
	WHERE nutrition_id < '2206' AND nutrition_id > '2202';

/* DRILL 5 */
/* Retrieve all names within the species_name column using the alias "Species Name:" from the species table and 
their corresponding nutrition_type under the alias "Nutrition Type:" from the nutrition table. */

SELECT a1.species_name AS 'Species Name:',
	a2.nutrition_type AS 'Nutrition Type:'
FROM
	tbl_species a1
	INNER JOIN tbl_nutrition a2 ON a2.nutrition_id = a1.species_nutrition;

/* DRILL 6 */
/* From the specialist table, retrieve the first and last name and contact number of those that provide care for 
the penguins from the species table. */

SELECT a1.specialist_fname, a1.specialist_lname, a1.specialist_contact
FROM
	tbl_specialist a1
	INNER JOIN tbl_care a2 ON a2.care_specialist = a1.specialist_id
	INNER JOIN tbl_species a3 ON a3.species_care = a2.care_id
	
WHERE species_name = 'penguin';

/* Creating your own tables: Build a select statement that queries for the following information: */

/* DRILL 7 */
/* Create a database with two tables. Assign a foreign key constraint on one table that shares related data with 
the primary key on the second table. Finally, create a statement that queries data from both tables. */

CREATE DATABASE db_drill7;
GO

USE db_drill7;
GO

/* DROP TABLE tbl_carSpecs, tbl_cars; */ /* For dropping tables and re-adding them during testing*/

CREATE TABLE tbl_cars (
	car_id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	car_make VARCHAR(30) NOT NULL,
	car_model VARCHAR(40) NOT NULL,
	car_trim VARCHAR(20) NOT NULL,
	car_type VARCHAR(40) NOT NULL
);

CREATE TABLE tbl_carSpecs (
	spec_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	spec_engineType VARCHAR (30) NOT NULL,
	spec_horsePower INT NOT NULL,
	spec_type INT NOT NULL CONSTRAINT fk_car_id FOREIGN KEY REFERENCES tbl_cars(car_id) ON UPDATE CASCADE ON DELETE CASCADE
);

INSERT INTO tbl_cars
	(car_make, car_model, car_trim, car_type)
	VALUES
	('Ford', 'Mustang', 'GT350 (Shelby)', 'Muscle'),
	('Subaru', 'WRX', 'STi', 'Rally Sport'),
	('Chevrolet', 'Camaro', 'Couple ZL1', 'Muscle'),
	('Porsche', '911', 'GT2 RS', 'Hypercar'),
	('Dodge', 'Challenger', 'SRT Demon', 'Muscle'),
	('BMW', 'M5', 'Competition', 'Luxury Performance'),
	('Cadillac', 'CTS-V', 'Sedan', 'Luxury Performance')
;

INSERT INTO tbl_carSpecs
	(spec_engineType, spec_horsePower, spec_type)
	VALUES
	('5.2L Twin Turbo V8','1100','1'),
	('2.5L Turbo FLat 4','305','2'),
	('6.2L Supercharged V8','650','1'),
	('3.8L Twin Turbo Flat 6','690','3'),
	('6.2L HEMI Demon V8','808','1'),
	('4.4L Twin Turbo V8','617','4'),
	('6.2L Supercharged V8','640','4')
;

SELECT a1.car_make, a1.car_model, a1.car_trim
FROM
	tbl_cars a1
	INNER JOIN tbl_carSpecs a2 ON a2.spec_id = a1.car_id

WHERE car_type = 'Muscle';