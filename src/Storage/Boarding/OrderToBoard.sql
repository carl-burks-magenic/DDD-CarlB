CREATE TABLE [Boarding].[OrderToBoard]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[FileToBoardId] INT NOT NULL,
	[EmailAddress] Varchar(255) NOT NULL,
	[ProductId] int NOT NULL,
	[Quantity] int NOT NULL,
	[DateTime] datetime2 NOT NULL
)
