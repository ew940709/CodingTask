CREATE TABLE Clients(
	client_id INTEGER,
  	client_name NVARCHAR(50),
  	PRIMARY KEY (client_id)
 )
 
 CREATE TABLE Orders(
   order_id INTEGER,
   client_id Integer,
   order_sum DEcimal,
   order_date DATETIME,
   PRIMARY KEY (order_id),
   FOREIGN KEY (client_id) References Clients(client_id)
 )
   
   
Insert into Clients (client_id, client_name)
VALUES (2, "test2")

Insert into Clients (client_id, client_name)
VALUES (3, "test3")

Insert into Clients (client_id, client_name)
VALUES (4, "test4")
   
Insert into Orders (order_id, client_id, order_sum, order_date)
VALUES (1, 1, 50, '2008-11-11')

Insert into Orders (order_id, client_id, order_sum, order_date)
VALUES (2, 2, 25, '2008-11-11')   

Insert into Orders (order_id, client_id, order_sum, order_date)
VALUES (3, 2, 20, '2008-11-11')   

Insert into Orders (order_id, client_id, order_sum, order_date)
VALUES (4, 3, 20, '2008-11-11') 

Insert into Orders (order_id, client_id, order_sum, order_date)
VALUES (5, 4, 150, '2008-11-11')

Insert into Orders (order_id, client_id, order_sum, order_date)
VALUES (5, 1, 80, '2008-11-11')


--a list of clients, which have an order with order_sum > 50

select DISTINCT C.client_id, C.client_name
from Clients as C
join Orders as O on O.client_id = C.client_id
Group BY O.order_sum
HAVING O.order_sum > 50


--b clients, whose total sum of orders exceeds 100

select C.client_id, C.client_name
from Clients as C
join Orders as O on O.client_id = C.client_id
Group BY O.client_id
HAVING SUM(O.order_sum) > 100