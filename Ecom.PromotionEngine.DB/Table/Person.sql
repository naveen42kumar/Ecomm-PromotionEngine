CREATE TABLE [Customer].[Person]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[FirstName] NVARCHAR(100) not null,
	[LasstName] NVARCHAR(100) not null,
	[MobileNo] Nvarchar(50) not null,
	[Address] Nvarchar(50) not null
)
