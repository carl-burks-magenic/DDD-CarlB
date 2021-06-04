CREATE TABLE [dbo].[CustomerCompanyRelationship]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[CustomerId] INT NOT NULL,
	[CompanyId] INT NOT NULL,
	[ExpiresOnDate] DateTime2 NULL,
    CONSTRAINT [FK_CustomerCompanyRelationship_ToEntity1] FOREIGN KEY ([CustomerId]) REFERENCES [Customer].[Entity]([Id]),
    CONSTRAINT [FK_CustomerCompanyRelationship_ToEntity2] FOREIGN KEY ([CompanyId]) REFERENCES [Customer].[Entity]([Id])
)
