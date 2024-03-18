# Bank Management System

A bank account management system that allows you to manage the queues of customers, view customer details, and perform various operations on them.

## Entities
- Queues
- Officials
- Customers

## Mapping Routes to Queues
- Retrieving the list of all queues: GET https://bank.co.il/queues
- Queue retrieval by queue ID: GET https://bank.co.il/queues/5874
- Creating a new queue: POST https://bank.co.il/queues
- Queue update: PUT https://bank.co.il/queues/5874
- Queue deletion by ID: DELETE https://bank.co.il/queues/5874
- Update queue owner name: PUT https://bank.co.il/queues/5874/ownersName

## Routes Mapping for Officials
- Retrieving the list of officials: GET https://bank.co.il/officials
- Retrieving the list of officials by branch: GET https://bank.co.il/officials/branch
- Official retrieval by ID: GET https://bank.co.il/officials/1
- Adding an official: POST https://bank.co.il/officials
- Official details update: PUT https://bank.co.il/officials/1
- Deletion of an official by ID: DELETE https://bank.co.il/officials/1

## Mapping Routes to Customers
- Retrieving the customer list: GET https://bank.co.il/customers
- Retrieving a list of customers by address: GET https://bank.co.il/customers/address
- Customer retrieval by ID: GET https://bank.co.il/customers/1
- Adding a customer: POST https://bank.co.il/customers
- Updating customer details: PUT https://bank.co.il/customers/1
- Deleting a customer by ID: DELETE https://bank.co.il/customers/1
