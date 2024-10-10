use companyDB

--Assignment 17: Basic View Creation

--1. Create a simple view named EmployeeView that displays the FirstName, LastName, and Department columns from the Employees table. 
create view EmployeeView
as
select FirstName,LastName,Department from Employees

--2. Query the view to display the details 
select * from EmployeeView
select * from Employees

--Assignment 18: Updating Data Through a View

--1. Create a view named EditableEmployeeView that shows EmployeeID, FirstName, LastName, and Salary. 
create view EditableEmployeeView 
as
select EmployeeID,FirstName,LastName,Salary from Employees

select * from EditableEmployeeView
select * from Employees 

--2. Update the salary of an employee using the view.
update EditableEmployeeView
set Salary=70000
where EmployeeID=1

--3. Verify the update
select * from EditableEmployeeView
select * from Employees


--Assignment 19: View with Calculated Columns

create view EmployeeSalaryBonusView
as 
select FirstName,LastName, salary, salary*.10 as Bonus 
from Employees

select * from EmployeeSalaryBonusView
select * from Employees

--Assignment 20: Altering a View
Alter view EmployeeView
as
select FirstName,LastName,Department,Salary from Employees

select * from EmployeeView

--Assignment 21: View with Parameters (Simulated via Filters) 
create view FilteredEmployeeView
as 
select EmployeeID,FirstName,LastName,Department from Employees

select * from FilteredEmployeeView

select * from FilteredEmployeeView where Department='HR'

--Assignment 22: Dropping a View
drop view EmployeeView
select * from EmployeeView

