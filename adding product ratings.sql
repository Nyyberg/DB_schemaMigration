CREATE TABLE ProductRatings(
RatingsId int IDENTITY(1,1) PRIMARY KEY,
ProductID Int,
Rating DECIMAL(1,1),
CONSTRAINT FK_Rating_Products FOREIGN KEY (ProductId) REFERENCES Products(Id)
)