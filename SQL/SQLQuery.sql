CREATE DATABASE EmployeeDB;

Use EmployeeDB;

CREATE TABLE Dept
(depID int not null primary key,
 depName varchar(50) not null);
 

 Insert Into Employee values(1,'shiva',426,25000.00,1);
 Insert Into Employee values(2,'nani',425,25300.00,2);
 Insert Into Employee values(3,'sai',424,25200.00,3);
 Insert Into Employee values(1,'shankar',426,25000.00,1);
 

SELECT *from Dept;
 DELETE FROM Employee
WHERE SSN = 424;
ALTER table Employee add email varchar(30);
update Employee set email='shiav@gmail.com' where EmpID=1;
update Employee set email='shankar@gmail.com' where EmpID=3;
DROP TABLE Employee;
Insert Into Dept values(1,'admin');
Insert Into Dept values(2,'stores');
Insert Into Dept values(3,'marketing');	

CREATE TABLE Employee(
   empID   INT              NOT NULL,
   empNAME VARCHAR (20)     NOT NULL,
    
   SALARY  float not null,       
   deptid int not null PRIMARY KEY
);	
 Insert Into Employee values(1,'shiva',25000.00,1);
 Insert Into Employee values(2,'nani',25300.00,2);
 Insert Into Employee values(4,'sri',25220.00,4);
 
select *from Employee
select *from Dept
select *from Employee where SALARY > 25000;
select * from Dept where depID=3;
select empID,EMPNAME,Salary, depName from Employee,Dept
where Employee.empID=Dept.depID;

SELECT * FROM Employee
   ORDER BY empID, deptid;

   ALTER table Dept add  empNAME varchar(30);

   update Dept set empNAME='Sri' where depID = 3;
 
   select *from Employee
   update Employee set dob = '01.01.1999' where empID = 4;
   update Employee set dob = '12.30.1996';
   alter table Employee 
   ADD dob date

   alter table employee
   add constraint chk_dob check (dob between '01.01.1993' and '01.01.1997');

   select max(SALARY) 'MAX SAL' FROM Employee;

   SELECT DEPTID,SUM(SALARY)'TOTAL SALARY' FROM Employee
   GROUP BY deptid
   HAVING SUM(SALARY)>25000
   ORDER BY DEPTID; 

   SELECT TOP(3) SALARY FROM Employee
   ORDER BY SALARY DESC ;

   select *from Employee

   INSERT INTO EMPLOYEE VALUES (5,'ANU',28000,5,NULL); 

   SELECT e.EMPID, e.empname, e.salary, e.deptid, d.depname, e.dob 
    from Employee as e full join dept as d on e.empid = d.depid;

--7/1/2020
	select empname, datediff(yy,dob,getdate()) as age from Employee;
	
	select empname, len(empname) as 'length' from Employee;
	
	select empname,SUBSTRING(empname,1,3) as 'partname' from Employee;
	
	select substring ('good morning all',6,16) as 'note';
	
	select empname, reverse (empname) as 'r name' from Employee;
	
	SELECT REPLACE ('GOOD MORNING','MORNING','EVENING')AS 'GREATINGS';
	
	SELECT UPPER(EMPNAME)AS 'UPPERCASE',LOWER(EMPNAME)AS 'LOWERCASE' FROM Employee;

	SELECT EMPID,EMPNAME,SALARY FROM EMPLOYEE WHERE SALARY > (SELECT AVG(SALARY) FROM Employee);

	SELECT EMPID,EMPNAME,SALARY, deptid  FROM EMPLOYEE WHERE deptid = (SELECT DEPID FROM Dept WHERE depName='ADMIN');
