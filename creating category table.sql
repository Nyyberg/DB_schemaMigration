CREATE TABLE Categories(
Id int IDENTITY(1,1),
CategoryName varchar(255),
PRIMARY KEY(Id)
)

ALTER TABLE Products
ADD CategoryID int

ALTER TABLE Products
ADD CONSTRAINT FK_CategoryID_Categories
FOREIGN KEY (CategoryID) REFERENCES Categories(Id)