CREATE TABLE [Configuration].[ConfigurationEntry]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Key] Varchar(256) NOT NULL,
	[Value] varchar(7000) NOT NULL
)
