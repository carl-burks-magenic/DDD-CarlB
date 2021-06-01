CREATE TABLE [ProductLine].[ProductPriceHistory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ProductId] INT NOT NULL,
	[Price] MONEY NOT NULL,
	[ExpiredOn] DateTime2,
	CONSTRAINT [FK_ProductPriceHistory_ToPrice] FOREIGN KEY ([ProductId]) REFERENCES [ProductLine].[Product]([Id])
)
