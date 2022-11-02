select * from Customers c
inner join Orders o
	on o.CustomerId=c.Id
inner join OrdersRows orr
	on orr.OrderId=o.Id
inner join Products p
	on p.Id= orr.ProductId
