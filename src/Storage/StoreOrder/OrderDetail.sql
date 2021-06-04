CREATE TABLE [dbo].[OrderDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[OrderId] INT NOT NULL,
	[ProductPriceId] INT NOT NULL,
	[Quantity] INT NOT NULL,
	CONSTRAINT [FK_OrderDetail_ToOrder] FOREIGN KEY ([OrderId]) REFERENCES [StoreOrder].[Order]([Id]),
    CONSTRAINT [FK_OrderDetail_ToProductPriceHistory] FOREIGN KEY ([ProductPriceId]) REFERENCES [ProductLine].[ProductPriceHistory]([Id])


)
