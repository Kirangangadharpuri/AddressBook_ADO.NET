--UC1
--CREATE PROCEDURE SPAdiingNewData(
--@FirstName VARCHAR(30), 
--@LastName VARCHAR(30),
--@Address VARCHAR(100),
--@City VARCHAR(30),
--@State VARCHAR(30),
--@Zip INT,
--@PhoneNumber BIGINT, 
--@Email VARCHAR(50))
--AS BEGIN
--INSERT INTO AddressBook(FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email)
--VALUES(@FirstName,@LastName,@Address,@City,@State,@Zip,@PhoneNumber,@Email)
--END

--USE AddressBookServiceDB;

--UC2
--CREATE PROCEDURE SPGetAllData
--AS BEGIN
--SELECT * FROM AddressBook
--END

--UC3
--CREATE PROCEDURE SPUpdateData_inDataBase
--@FirstName VARCHAR(30),
--@LastName VARCHAR(30),
--@City VARCHAR(30)
--AS BEGIN
--UPDATE AddressBook SET LastName=@LastName,City=@City WHERE FirstName=@FirstName
--END
--Select * from AddressBook;

--UC4
CREATE PROCEDURE SPDeleteData_FromDB
(@FirstName VARCHAR(30))
AS BEGIN
DELETE FROM AddressBook WHERE FirstName=@FirstName
END