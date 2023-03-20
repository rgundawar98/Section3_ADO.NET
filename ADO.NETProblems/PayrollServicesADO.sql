Create Database Payroll_Service_Database
Use Payroll_Service_Database
Create table EmployeeDetails
(
   EmployeeId int identity primary key, 
   EmpName varchar(250),
   Salary float,
   StartDate DateTime,
   Phone varchar(250) NOT NULL,
   Address varchar(250) NOT NULL,
   Gender varchar(1),
   Department varchar(250)NOT NULL,
   BasicPay float,
   Deduction float,
   TaxablePay float,
   IncomeTax float,
   NetPay float,
   City varchar(250),
   Country varchar(250)
)
drop table EmployeeDetails

/*UC3 Insert into*/
Insert into EmployeeDetails values('Rajesh',400000.00,GetDate(),'456456465','12th street','M','IT',10000.00,4500.00,5000.00,2580.00,300000,'Hyderabad','India')
Insert into EmployeeDetails values('Harish',450000.00,GetDate(),'446456465','Th street','M','IT',50000.00,4500.00,5800.00,8580.00,650000,'Delhi','India')
Insert into EmployeeDetails values('Neha',500000.00,GetDate(),'450456465','14th street','F','NGO',20000.00,6500.00,2000.00,2580.00,200000,'Pune','India')
Insert into EmployeeDetails values('Hari',550000.00,GetDate(),'400056465','16th street','M','Banking',40000.00,8500.00,8000.00,2580.00,500000,'Chennai','India')
Insert into EmployeeDetails values('Sagar',600000.00,GetDate(),'451156465','17th street','M','CEO',100000.00,45020.00,50100.00,258080.00,4000000,'Boston','USA')
Insert into EmployeeDetails values('Shivani',650000.00,GetDate(),'444456465','19th street','F','CTO',500000.00,45000.00,50000.00,255800.00,3000000,'Bangalore','India')
Insert into EmployeeDetails values('Om',85555.44,'2023-01-23','456455465','The street','M','HR',20000.00,4500.00,8000.00,1580.00,350000,'Coimbature','India')
Insert into EmployeeDetails values('Terissa',85555.44,'2018-01-23','456411165','Holy street','F','Sales&Marketing',20000.00,4500.00,8000.00,1580.00,350000,'Mumbai','India')