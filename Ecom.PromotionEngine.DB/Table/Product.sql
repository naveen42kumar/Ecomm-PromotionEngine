CREATE TABLE [Production].[Product]
(
	[Id] INT identity(1,1) NOT NULL PRIMARY KEY,
	[Name] Nvarchar (500) Not null,
	[SKU] varchar(1) not null, 
    [Price] MONEY NOT NULL, 
    [Product Info] NVARCHAR(MAX) NULL, 
    [IsAvailable] BIT DEFAULT 1 NOT NULL,
	[OrderId] INT not null,
)
