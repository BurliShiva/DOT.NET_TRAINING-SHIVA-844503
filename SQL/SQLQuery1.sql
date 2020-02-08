Use Northwind
Create Procedure GetCustomersByCountrys
(@Country VarChar (30))
As
select CustomerID,ContactName,CompanyName,Address,Country from customers where country = @Country;
Go

execute GetCustomersByCountrys'USA';


Create Procedure GetProductsByCategoryID
(@CategoryID int)
As
Select p.ProductID,p.ProductName,p.UnitPrice,p.QuantityPerUnit,c.CategoryID,c.CategoryName from 
Products p INNER JOIN Categories c ON p.CategoryID =  c.CategoryID AND c.CategoryID = @CategoryID;
Go
Execute GetProductsByCategoryID 2;

--Declering local variables

Declare @country as varchar(30);
Set @country = 'France';
Select *from Customers where Country = @country;



Alter Procedure GetTotalOrdersByDates
(@date1 date, @date2 date,@countOrder int output)
As
Select @countorder =count(OrderID) from Orders where OrderDate between @date1 AND @date2;
Go

Declare @count as int ;

Declare @date1 As date,@date2 As date;

set @date1 = '01/01/1990';
set @date2 = '12/31/1998';

execute GetTotalOrdersByDates @date1,@date2,@count output;

print 'Total number of orders placed :'+ convert (varchar(10),@count);

print getdate();

Select * from Orders

--Creating Functions

create function Multiply(@n1 int , @n2 int)
Returns bigint
As
Begin
Declare @prod As bigint;
Set @prod = @n1*@n2;
Return @prod;
End

Select dbo.Multiply (50,80) as Product;


--Table valued function

CREATE FUNCTION GetCustmors(@country varchar(30)) Returns Table
As
Return Select * from Customers where Country = @country;
Go

select *from dbo.GetCustmors('Germany');

---Creating functions and performing joins 

create function GetProductsByCategory(@CategoryID int ) Returns Table
As
Return Select p.ProductID,p.ProductName,p.UnitPrice,p.QuantityPerUnit,c.CategoryID,c.CategoryName from 
Products p INNER JOIN Categories c ON p.CategoryID =  c.CategoryID AND c.CategoryID = @CategoryID;
Go
Execute GetProductsByCategoryID 5;


--Subquries
--1.A subquery is used as a part of a main query,and the value returned from the subquery will be used by
   -- the main query for its execution
   
--2.sometimes a subquery is used in the place of JOIN operation to combine two tables,but joins are preffered 
--  over subqueries because of their efficiency

Select ProductID,productname,UnitPrice,QuantityPerUnit,CategoryID from Products
where UnitPrice > (select avg(unitprice) from Products)  order by UnitPrice

select *from Customers

select CompanyName,customerID,Country from Customers where (Country IN  ('UK','USA')) 


select OrderID,CustomerID,EmployeeID,OrderDate,ShippedDate from orders where OrderID = (select
OrderID from Orders where EmployeeID =5 AND customerID = 'VINET');
 

--correlated subqueries

--a correlated subquery doesn't return any data back

select CustomerID,CompanyName,Address,Country from Customers
 where exists(select ContactName from Customers where Country='UK')

 select CustomerID,CompanyName,Address,Country from Customers
 where exists(select ContactName from Customers where Country='RUSSIA')--IF NO DATA SHOWS NULL