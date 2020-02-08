Create Database EmployeeEFDB

Create Table Employee
(EmpID int Primary Key,Name varchar(30)not null,SSN Bigint not null,Salary float not null,DepID int not null);

Create Table Department(DepID int Primary key,Name varchar(30) not null);

Alter table Employeect  
Add Constraint FK_DepID FOREIGN KEY (DepID) references Department(DepID); 

insert into Department Values (1,'admin');
insert into Department Values (2,'Stores');
insert into Department Values (3,'packing');

select *from Department
select *from Employee

insert into Employee Values (4,'shiva',85,45000,1);