CREATE TABLE [Geolocation].[Address]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Street] varchar(255) NOT NULL,
	[StreetAdditional] varchar(255) NULL,
	[CountryId] int NULL,
	[StateId] int NULL,
	[CityId] int NULL,
	[PostalId] int NULL,
	CONSTRAINT [FK_Address_ToCountry] FOREIGN KEY ([CountryId]) REFERENCES [Geolocation].[Country]([Id]),
	CONSTRAINT [FK_Address_ToState] FOREIGN KEY ([StateId]) REFERENCES [Geolocation].[State]([Id]),
	CONSTRAINT [FK_Address_ToCity] FOREIGN KEY ([CityId]) REFERENCES [Geolocation].[City]([Id]),
	CONSTRAINT [FK_Address_ToPostal] FOREIGN KEY ([PostalId]) REFERENCES [Geolocation].[Postal]([Id])
)
