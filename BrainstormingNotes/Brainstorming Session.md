	• Service Contracts
		○ Service Center (Call Center/IM Center)
			§ Call Center
		
	• Purchasing
		○ Vendors MSI, AMD, Etc

• Purchase hardware from vendors
• Package, version [Linux: Fedora LTS]

We package, create product and sell from a product line:

Budget, Gaming, Business 3 models of computer

Ordering parts -> supporting with a customer

Command CreateProductForProductLine

Event ProductCreated
           * Parts List
	
All Events:

CorrelationId
TimeStamp
OriginationContext (where did the event come from)

OrderedPart 
• Vendor
• Upper Limit Price
(Quantity is done by adding same part multiple times)
• SKU

SourcingContext

Budget PC 1.0.0 - 
500  Intel 10700k units
 
## Discussion of types:

### Contexts

ComputerBlueprint:Draft
    * getting parts listed and organized
ComputerFullfilment:Draft
    * actually ordering parts from vendors
    * computer assembly
VendorReturns:Draft
    * RMAs
Order
    * determining how many computers and what kind
    * where to ship
        * only USD
        * only lower 48
OrderPayment
    * wraps calls to Paypal
OrderFulfillment
    * When PaymentReceived, Pick and Ship to Customer
CustomerService
    * returns
    * questions
