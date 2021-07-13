# Drawings

## Context Map

This context map contains the two business domains and a represents a third 
party order fulfillment that is outside of our business.

``` mermaid
graph TD;
    CB(Computer Blueprint)==Defines Computer==>CF(Computer Fulfillment)
    CF==Computer Available==>T[[Third Party Order Fulfillment]]
```
![Context Map](context_map.png)

## Computer Blueprint

The computer blueprint context provides the definition of the parts to assemble
a computer product.

``` mermaid
graph LR;
    CB(Computer Blueprint)==Computer Blueprint Available==>B( )
    A( )==Get Existing Computer Blueprints==>CB
    A( )==Create New Blueprint==>CB
```

![Computer Blueprint](computer_blueprint.png)

## Computer Fulfillment

The computer fulfillment assembles a computer product to sell from a predefined
blueprint. Computer fulfillment tests completed computers before they are
available for ordering. When vendor parts fail, computer fulfillment is responsible
for interacting with the vendor.

``` mermaid
graph LR;
    CF(Computer Fulfillment)==Computer Available==>B( )
    A( )==Build Computer==>CF
    A==Get Available Computers==>CF
    A==Get Return Part status==>CF
    CF==Return Part==>B
```

![Computer Fulfillment](computer_fulfillment.png)


## Third Party Order Fulfillment

Wrapper for Order Fulfillment COTS solution such as Amazon that can handle
warehousing, orders and payments for the business.