June ‘10 Question Paper – Question 6

A company manages subscriptions to thirty different magazines. Customers can subscribe to receive one or more of the magazines.

l Each magazine has a category such as Gardening or Current Affairs.

l Each magazine has a subscription rate, which is the cost of subscribing to receive the magazine for 12 months.

Details of the subscriptions are to be stored in a database using the following three relations:

Magazine(MagazineID, MagazineName, Category, SubscriptionRate)

Subscription(SubscriptionID, MagazineID, CustomerID, StartDate, EndDate)

Customer(CustomerID, CustomerName, Address, Postcode, TelephoneNumber)

1. Complete the following Data Definition Language (DDL) statement to create the Magazine relation, including the key field.

CREATE TABLE Magazine (
MagazineID int,
MagazineName varchar(25),
Category varchar(25),
SubscriptionRate decimal,

PRIMARY KEY (MagazineID))

(2 marks)

2. The company wants to send letters to customers with expired subscriptions to the magazine ‘AQA Computing Now’ to encourage them to subscribe again. The letters must be sent to all customers for this magazine whose subscription ended before 01/06/2010. A customer’s name, address and postcode must be included in each letter.

Write an SQL query that will find the data needed to produce the letters.

SELECT CustomerName, Address, Postcode FROM Customer WHERE (
    CustomerID = SELECT CustomerID FROM Subscription WHERE EndDate <= 01/06/2010
)

(5 marks)

3. The magazine named ‘AQA Gardening Monthly’ is to be renamed ‘AQA Garden News’.

Complete this SQL statement to update the data in the Magazine table to reflect this change.

UPDATE Magazine

SET MagazineName = "AQA Garden News"

WHERE MagazineName = "AQA Gardening Monthly"

2 marks