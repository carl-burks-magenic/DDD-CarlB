CREATE TABLE [Logging].[LogEntry]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[CorrelationId] varchar(256),
	[Type] varchar(256),
	[Detail] varchar(max)
)
