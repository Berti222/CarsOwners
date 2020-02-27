	/* Runn Firstly */
CREATE DATABASE CarsesOwner;

	/* Runn Secondly */
--USE CarsesOwner;

--CREATE TABLE Owners(
--	Id INT NOT NULL IDENTITY(1,1),
--	FirstName VARCHAR(100),
--	LastName VARCHAR(100),
--	DateOfBirth DATE,
--	PRIMARY KEY (Id)
--);

--CREATE TABLE Cars(
--	Id INT NOT NULL IDENTITY(1,1),
--	CarBrand VARCHAR(255),
--	CarType VARCHAR(255),
--	LicensePlateNumber VARCHAR(255),
--	DateOfProduction DATE,
--	PRIMARY KEY (Id)
--);

--CREATE TABLE SwitchTable(
--	Id INT NOT NULL IDENTITY(1,1),
--	OwnersId INT,
--	CarsId INT,
--	 PRIMARY KEY (Id),
--	FOREIGN KEY(OwnersId) REFERENCES Owners(Id),
--	FOREIGN KEY(CarsId) REFERENCES Cars(Id)
--);

--	/* Createing Some Dummy Data */
--INSERT INTO Owners(FirstName, LastName, DateOfBirth) 
--	VALUES	('Kiss','Béla','1984-05-11'),
--			('Kovács','Sára','1973-04-21'),
--			('Nagy', 'Péter', '1993-03-11')

--INSERT INTO Cars(CarBrand, CarType, LicensePlateNumber, DateOfProduction) 
--	VALUES	('Opel','Astra','KHD-352','1998-03-1'),
--			('Toyota','Corolla','KPP-553','2004-07-2'),
--			('Kia','Ceed','MMP-368','2010-06-22'),
--			('VW','Golf','HDR-351','2005-06-12')

--INSERT INTO SwitchTable(OwnersId, CarsId)
--	VALUES	(1,1),
--			(1,2),
--			(2,3)

--	/* Owners Cars Query */
--SELECT	Cars.Id,
--		Cars.CarBrand,
--		Cars.CarType,
--		Cars.LicensePlateNumber, 
--		Cars.DateOfProduction 
--FROM SwitchTable
--INNER JOIN Cars ON Cars.Id = SwitchTable.CarsId
--INNER JOIN Owners ON Owners.Id = SwitchTable.OwnersId
--WHERE Owners.Id = 1;
