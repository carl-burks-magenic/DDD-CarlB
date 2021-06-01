CREATE TABLE [ProductLine].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	Name varchar(255) NOT NULL,
	Description varchar(7000) NOT NULL,
	DeactivatedOn Datetime2 NULL
)
