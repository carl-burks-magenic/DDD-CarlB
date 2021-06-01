CREATE TABLE [Geolocation].[State]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] varchar(255) NOT NULL,
	[CountryId] int NOT NULL,
	CONSTRAINT [FK_State_ToCountry] FOREIGN KEY ([CountryId]) REFERENCES [Geolocation].[Country]([Id]),
)
