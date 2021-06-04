CREATE TABLE [StoreOrder].[Order]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[CustomerId] INT NOT NULL,
	[AddressId] INT NOT NULL,
	[OrderedOn] DateTime2 NOT NULL,
	[DeactivatedOn] DateTime2,
	CONSTRAINT [FK_Order_ToEntity] FOREIGN KEY ([CustomerId]) REFERENCES [Customer].[Entity]([Id]),
	CONSTRAINT [FK_Order_ToAddress] FOREIGN KEY ([AddressId]) REFERENCES [Geolocation].[Address]([Id])
)
