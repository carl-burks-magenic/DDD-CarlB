CREATE TABLE [Geolocation].[City]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] varchar(255) NOT NULL,
	[StateId] int NOT NULL,
	CONSTRAINT [FK_City_ToState] FOREIGN KEY ([StateId]) REFERENCES [Geolocation].[State]([Id]),
)
