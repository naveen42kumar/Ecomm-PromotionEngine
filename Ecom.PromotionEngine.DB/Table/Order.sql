CREATE TABLE [Sales].[Order]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[productId] int not null,
	[PersonId] int not null,
	[Quantity] int not null,
	CONSTRAINT [FK_ORDER_Product] FOREIGN KEY ([productId]) REFERENCES [Sales].[Order](Id) ,
	CONSTRAINT [FK_ORDER_Person] FOREIGN KEY ([PersonId]) REFERENCES [Sales].[Order](Id) 

)
