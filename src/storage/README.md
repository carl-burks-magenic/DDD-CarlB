# Tables

Questions:

International support?

### Customer.Entity
id: int
name: varchar(255)
primaryPhone: id/fk to Phone
deactivatedOn: DateTime2
primaryMailingAddress: id/fk to Address
primaryShippingAddress: id/fk to Address

### Customer.Customer
id: int pk/fk Entity

### Customer.Company
id: int pkfk Entity

### GeoLocation.Country
id: int pk
ISO3166Code: char(3)

### GeoLocation.State
id: int pk
countryId: int fk to Country

### GeoLocation.City
id: int pk
name: string
state: int fk State

### GeoLocation.PostalCode
id: int pk
countryId: fk Country

### GeoLocation.Address
street: varchar(255)
additionalStreetInformation: varchar(255)
country: id fk to Country
city: id fk to city
state: id fk to state
postalcode: id

### GeoLocation.Phone
id: int
number: varchar(15)

### StoreProductLine.Product
id: bigint
name: varchar(255)
description: varchar(max)?
deactivatedOn: datetime2?

### StoreProductLine.ProductPriceHistory
id: bigint
productId: id fk to Product
price: money
priceExpirationDate: DateTime2?

### StoreOrders.Order
id: bigint
customerId: id fk to entity
orderDate: datetime2
addressId: fk to address
deactivatedOn: datetime2

### StoreOrders.OrderDetails
id: bigint
orderid: bigint fk to order
price: bigint fk to productpricehistory
quantity: int

### Boarding.FilesToBoard
path

### Boarding.OrderToBoard
email
productId
quantity
datetime

### Common.Configuration
key
value

### Common.Logging
id
correlationId
type
detail

