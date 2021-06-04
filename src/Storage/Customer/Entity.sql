CREATE TABLE [Customer].[Entity]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Name] varchar(255) NOT NULL,
    [PrimaryEMailId] int,
	[PrimaryPhoneId] int, 
    [PrimaryBillingAddressId] INT NULL, 
    [PrimaryShippingAddressId] INT NULL, 
    [DeactivatedOn] DATETIME2 NULL, 
    CONSTRAINT [FK_Entity_ToAddress1] FOREIGN KEY ([PrimaryBillingAddressId]) REFERENCES [Geolocation].[Address]([Id]),
    CONSTRAINT [FK_Entity_ToAddress2] FOREIGN KEY ([PrimaryShippingAddressId]) REFERENCES [Geolocation].[Address]([Id]),
    CONSTRAINT [FK_Entity_ToGeolocationPhone] FOREIGN KEY ([PrimaryPhoneId]) REFERENCES [Geolocation].[Phone]([Id]),
    CONSTRAINT [FK_Entity_ToCustomerEmail] FOREIGN KEY ([PrimaryEMailId]) REFERENCES [Customer].[Email]([Id])
)
