--Assignment 1: Create a Database and Table

create database companyDB

use companyDB

Create Table Employees(
	EmployeeID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	FirstName varchar(50),
	LastName varchar(50),
	Department varchar(50),
	Salary decimal(10,2)
);

--Assignment 2: Insert Data into a Table

Insert into Employees(FirstName,LastName,Department,Salary)
Values('John','Deo','HR','50000'),
	('Jane','Smith','IT','60000'),
	('David','Lee','Marketing',55000);


--Assignment 3: Select and Query Data

--1. Retrieve all employee records from the Employees table.
Select * from Employees

--2. Retrieve the FirstName, LastName,LastName, and Salary of employees in the IT department andsalary greater than 5000
Select FirstName,LastName,Salary from Employees Where Department='IT' AND Salary>5000

--3. Find the highest salary from the Employees table.
Select max(Salary) AS MaxSalary from Employees

--Assignment 4: Update Data in a Table

--1. Update the salary of John Doe to 55000.
Update Employees
set Salary=55000
where FirstName='John'

--2. Change the department of Jane Smith to Marketing.
Update Employees
set Department='Marketing'
where FirstName='Jane'

select * from Employees

--Assignment 5: Delete Data from a Table

--1. Delete the record of David Lee from the Employees table.
delete from Employees
where FirstName='David'

--2. Delete all employees in the Marketing department.
delete from Employees
where Department='Marketing'

select * from Employees

--Assignment 6: Product Management

--1. Create a tabled named Products and insert below records in the table.
Create Table Products(
	ProductID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	ProductName varchar(50),
	Category varchar(50),
	Price int,
	Stock int
);
insert into Products(ProductName,Category,Price,Stock)
values ('Laptop','Electronics',1000,50),
	('Mouse','Electronics',20,200),
	('Keyboard','Electronics',30,150),
	('Printer','Electronics',150,75);

--2. Select all columns from the Products table
select * from Products

--3.Select products, sorted by their price in descending order.
select * from Products
Order BY Price DESC

--Assignment 7: Library Management

--4. Update the price of the "Mouse" to 25.
Update Products
set Price=25
where  ProductName='Mouse'

select * from Products

--5. Delete the product with ProductID 2 (Mouse).
delete from Products
where ProductID=2

select * from Products

--6. Select products sorted by ProductName in alphabetical order.
select * from Products
Order BY ProductName 

--Assignment 7: Library Management

--1. Create a tabled named Books with the below structure and insert below records in thetable.
Create table Book(
	BookID int not null primary key identity(1,1),
	Title varchar(50),
	Author varchar(50),
	PublishedYear int,
	AvailableCopies int
);
insert into Book(Title,Author,PublishedYear,AvailableCopies)
values('The Great Gatsby','F. Scott Fitzgerald',1925,3),
('1984','George Orwell',1949,2),
('To Kill a Mockingbird','Harper Lee',1960,5),
('Brave New World','Aldous Huxley',1932,4);

select * from Book

--2. Update the available copies of "1984" to 5.
update Book
set AvailableCopies=5
where Title='1984'

select * from Book

--3. Delete the book with BookID 1 (The Great Gatsby).
delete from Book
where BookID=1

select * from Book

--4. Write a query to Select books published after 1950.
select * from Book
where PublishedYear > 1950


--Assignment 8: Customer Management

--1. Create a Customers table containing details about customers with the below details.
Create table Customer(
	CustomerID int primary key identity(201,1),
	CustomerName varchar(50),
	Email varchar(50),
	PhoneNumber varchar(50)
);
insert into Customer(CustomerName,Email,PhoneNumber)
values('Alice Johnson','alice@example.com','555-1234'),
('Bob Smith','bob@example.com','555-5658'),
('Charlie Brown','charlie@example.com','555-8765');

select * from Customer

--2. Insert a new customer into the Customers table with the following details:
insert into Customer(CustomerName,Email,PhoneNumber)
values('David Wilson','david@example.com','555-4321')

select * from Customer

--3. Update the phone number of "Alice Johnson" to "555-9999".
update Customer
set PhoneNumber='555-9999'
where CustomerName='Alice Johnson'

select * from Customer

--4. Delete the customer with CustomerID 202 (Bob Smith).
delete from Customer
where CustomerID=202

select * from Customer

--drop table Customer

--Assignment 9: Orders Management

--1. Create an Orders table that contains information about customer orders with the belowdetails:
create table Orders(
	OrderID int primary key identity(301,1),
	CustomerID int ,
	OrderDate date,
	TotalAmount decimal(10,2)
);
insert into Orders(CustomerID,OrderDate,TotalAmount)
values (201,'2024-09-01',250),
(202,'2024-09-02',150),
(203,'2024-09-03',200);

select * from Orders

--2. Insert a new order into the Orders table with the following details:
insert into Orders(CustomerID,OrderDate,TotalAmount)
values (204,'2024-09-04',300)

select * from Orders

--3. Update the TotalAmount for OrderID 301 to 275.00.
update Orders
set TotalAmount=275
where OrderID=301

select * from Orders

--4. Delete the order with OrderID 302.
delete from Orders
where OrderID=302

select * from Orders

--5. Select orders with a total amount greater than 200.
select * from Orders
where TotalAmount>200

--6. Select only the OrderID and TotalAmount for all orders.
select OrderID,TotalAmount from Orders 

--drop table Orders


--Assignment 10: Primary Key

create table Student(
	StudentID int primary key,
	FirstName varchar(50),
	LastName varchar(50),
	Email varchar(50)
);
insert into Student(StudentID,FirstName,LastName,Email)
values (1,'John','Doe','john.doe@example.com'),
(2,'Jane','Smith','jane.smith@example.com'),
(3,'Mike','Johnson','mike.johnson@example.com');

select * from Student

--Assignment 11: Foreign Key

create table Course(
	CourseID int primary key,
	courseName varchar(50)
);
insert into Course(CourseID,CourseName)
values (11,'python'),
	(12,'java'),
	(13,'c#');
select * from Course

create table Enrollments(
	EnrollmentID int primary key identity(101,1),
	StudentID int,
	CourseID int,
	foreign key (StudentID) references Student(StudentID),
	foreign key (CourseID) references Course(CourseID),
);

insert into Enrollments(StudentID,CourseID)
values (1,11)

--insert into Enrollments(StudentID,CourseID)
--values (1,17)

select * from Enrollments

--Assignment 12: Composite Key

create table OrderDetails(
	OrderID INT ,
	ProductID INT,
	Quantity INT ,
	PRIMARY KEY (OrderID,ProductID)
);

insert into OrderDetails(OrderID,ProductID,Quantity)
values (1,11,100)
select * from OrderDetails


--Assignment 13: Candidate Key and Alternate Key

create table Users (
    UserID INT PRIMARY KEY,
    Email VARCHAR(255) UNIQUE, -- Unique key as candidate key
    Username VARCHAR(255) NOT NULL
);

--Assignment 14: Surrogate Key

create table Products (
    AutoID INT PRIMARY KEY IDENTITY(1,1), -- Surrogate key
    ProductName VARCHAR(255),
    Price DECIMAL(10, 2)
);

--Assignment 15: Natural Key 
create table Employees (
    SSN VARCHAR(9) PRIMARY KEY, -- Natural key
    FirstName VARCHAR(255),
    LastName VARCHAR(255),
    Position VARCHAR(255)
);

--Assignment 16: Unique Key
create table Customers (
    CustomerID INT PRIMARY KEY,
    PhoneNumber VARCHAR(15) UNIQUE -- Unique key
);

