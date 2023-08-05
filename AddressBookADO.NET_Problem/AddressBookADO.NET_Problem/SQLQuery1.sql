CREATE PROCEDURE SPAdiingNewData(
@FirstName VARCHAR(30), 
@LastName VARCHAR(30),
@Address VARCHAR(100),
@City VARCHAR(30),
@State VARCHAR(30),
@Zip INT,
@PhoneNumber BIGINT, 
@Email VARCHAR(50))
AS BEGIN
INSERT INTO AddressBook(FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email)
VALUES(@FirstName,@LastName,@Address,@City,@State,@Zip,@PhoneNumber,@Email)
END
select * from AddressBook;