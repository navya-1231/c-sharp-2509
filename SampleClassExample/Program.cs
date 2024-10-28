using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Assignment 1: Circle Class

            //try
            //{
            //    Circle circle1 = new Circle();
            //    circle1.Radius = 10;
            //    Console.WriteLine("Radius: " + circle1.Radius);

            //    Circle circle2 = new Circle();
            //    circle2.Radius = -10;
            //    Console.WriteLine("Radius: " + circle2.Radius);
            //    Console.ReadLine();
            //}

            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.ReadLine();
            //}

            //------------------------------------------------------------

            //Assignment 2: Employee Class

            //try
            //{
            //    Employee employee1 = new Employee();
            //    employee1.name = "Ammu";
            //    employee1.salary = 30000;
            //    Console.WriteLine("Name " + employee1.name);
            //    Console.WriteLine("salary " + employee1.salary);

            //    Employee employee2 = new Employee();
            //    employee2.name = "Sachin";
            //    employee2.salary = -30000;
            //    Console.WriteLine("Name " + employee2.name);
            //    Console.WriteLine("salary " + employee2.salary);

            //    Console.ReadLine();

            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.ReadLine();
            //}

            ////------------------------------------------------------------

            ////Assignment 3: Library Management System
            //try
            //{
            //    Library library = new Library();

            //    Book book1 = new Book("The Secret Garden", "Jane Doe", "t456");
            //    Book book2 = new Book("Wallace-Wells", "David", "t457");

            //    library.AddBook(book1);
            //    library.AddBook(book2);

            //    library.DisplayBook();

            //    Console.WriteLine();

            //    library.RemoveBook("t456");
            //    Console.WriteLine("After deleting");
            //    library.DisplayBook();

            //    Console.ReadLine();

            //}
            //catch (Exception)
            //{
            //     Console.WriteLine(ex.Message);
            //    Console.ReadLine();

            //}

            //------------------------------------------------------------

            //Assignment 4: Banking System
            //try
            //{
            //    Account account1 = new Account(45789, "Ram");
            //    account1.Deposit(5000);
            //    account1.Withdraw(3000);


            //    Console.WriteLine();
            //    Account account2 = new Account(65789, "Sachin");
            //    account2.Deposit(3000);
            //    account2.Withdraw(3000);


            //    Console.ReadLine();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.ReadLine();

            //}

            //------------------------------------------------------------

            //Assignment 5: Student Management System

            //Student student1 = new Student("Navya", 101);

            //student1.AddGrade(80);
            //student1.AddGrade(90);
            //student1.AddGrade(70);

            //student1.DisplayStudentInfo();
            //Console.ReadLine();

            //------------------------------------------------------------

            //Assignment 6: Inventory System

            //try
            //{
            //    InventorySystem inventorySystem = new InventorySystem();
            //    Item item1 = new Item("Laptop", 10, 100000);
            //    Item item2 = new Item("Mobile", 15, 40000);
            //    Item item3 = new Item("Headphones", 50, 100);

            //    inventorySystem.AddItem(item1);
            //    inventorySystem.AddItem(item2);
            //    inventorySystem.AddItem(item3);

            //    inventorySystem.DisplayInventory();

            //    inventorySystem.RemoveItem("Laptop");
            //    Console.WriteLine("After removing one item ");
            //    inventorySystem.DisplayInventory();

            //    inventorySystem.UpdateStock("Mobile", 20);
            //    inventorySystem.UpdatePrice("Mobile", 500000);
            //    Console.WriteLine("After updating list");
            //    inventorySystem.DisplayInventory();

            //    //Item item4 = new Item("Mouse", 0, 1000);
            //    Item item5 = new Item("KeyBoard", 10, 0);

            //    Console.ReadLine();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.ReadLine();
            //}

            //------------------------------------------------------------

            //Assignment 7: E - commerce System

            //try
            //{
            //    Product product1 = new Product("Laptop", 1500, 10);
            //    Product product2 = new Product("Smartphone", 800, 20);
            //    product1.PrintProductDetails();
            //    product2.PrintProductDetails();
            //    Console.WriteLine();

            //    Order order = new Order();
            //    Console.WriteLine("Order Details");
            //    order.AddOrder(product1, 2);
            //    order.PrintOrderDetails();
            //    Console.WriteLine();
            //    Console.WriteLine("After Order");
            //    product1.PrintProductDetails();
            //    Console.WriteLine();

            //    Console.ReadLine();


            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //    Console.ReadLine();
            //}

            //------------------------------------------------------------

            //Assignment 8: Print Class

            //PrintClass print = new PrintClass();
            //print.Display("Navya");
            //print.Display(23);
            //int[] array1 = {1,2,3,4,5};
            //print.Display(array1);

            //Console.ReadLine();


            //------------------------------------------------------------

            //Assignment 9: Rectangle Class

            //Rectangle rectangle = new Rectangle();
            //rectangle.CalculateArea(3, 4);
            //rectangle.CalculateArea(5);

            //Console.ReadLine();

            //------------------------------------------------------------

            //Assignment 10:Time Class
            //Time time = new Time();
            //time.CalculateTime(1,60);
            //time.CalculateTime(60);
            //Console.ReadLine();

            //------------------------------------------------------------

            //Assignment 11: Initializing a Static Field 

            //Bank account1 = new Bank(1000);
            //account1.DisplayInfo();

            //Bank account2 = new Bank(5000);
            //account2.DisplayInfo();

            //Console.ReadLine();

            //------------------------------------------------------------

            //Assignment 12: Counting Objects with Static and Instance Fields 

            //Console.WriteLine("Initial count of car: " + Car.ShowCount());

            //Car car1 = new Car();
            //Car car2 = new Car();
            //Car car3 = new Car();

            //Console.WriteLine("Count of car: " + Car.ShowCount());


            //Console.ReadLine();

            //------------------------------------------------------------

            //Assignment 13: Initializing Constants with Static Block


            //Console.WriteLine("PI Value " + MathOperations.Pi);
            //Console.ReadLine();

            //------------------------------------------------------------

            //Assignment 14: Initializing Configuration with Static Constructor 

            //Configuration configuration = new Configuration("Preference 1");

            //Configuration configuration1 = new Configuration("Preference 2");

            //Console.ReadLine();


            //------------------------------------------------------------

            //Assignment15: Implementing and Understanding Copy Constructor 

            //Person person = new Person("Kevin",24);
            //person.Display();

            //Person copyPerson = new Person(person);//copy the values from person
            //copyPerson.Display();

            //Person person1 = person;
            //person1.Display();

            //person1.Name = "Mathew";
            //person1.Age = 25;
            //person1.Display();

            //Person person2 = new Person(person);//copy the values from person
            //person2.Display();

            //person2.Name = "navya";
            //person2.Age = 23;
            //person2.Display();

            //person.Display();

            //Console.ReadLine();

            //------------------------------------------------------------

            //Assignment 16: Identifying the Need for Chained Constructors 

            //CarClass car1 = new CarClass("Toyota");
            //car1.DisplayDetails();

            //CarClass car2 = new CarClass("Toyota", "XYZ");
            //car2.DisplayDetails();

            //CarClass car3 = new CarClass("Toyota", "XYZ",2019);
            //car3.DisplayDetails();

            //CarClass car4 = new CarClass("Toyota", "XYZ", 2010,200000);
            //car4.DisplayDetails();

            //Console.ReadLine();

            //------------------------------------------------------------

            //Assignment 17: Understanding the Need for Constructor Overloading 


            //Products product1 = new Products("Laptop");
            //Products product2 = new Products("Smartphone", 500);
            //Products product3 = new Products("Tablet", 300, 10);

            //product1.DisplayProductInfo();
            //product2.DisplayProductInfo();
            //product3.DisplayProductInfo();

            //Console.ReadLine();


            //------------------------------------------------------------

            //Assignment 18: Exploring Different Ways to Initialize Objects 

            // 1. Constructor initialization
            //Productss product1 = new Productss("Laptop", 1200.99, "Electronics");
            //Console.WriteLine("Constructor initialization:");
            //product1.DisplayProduct();

            //// 2. Object initializer syntax
            //Productss product2 = new Productss { Name = "Smartphone", Price = 699.99, Category = "Electronics" };
            //Console.WriteLine("\nObject initializer syntax:");
            //product2.DisplayProduct();

            //// 3. Static factory method
            //Productss product3 = Productss.CreateProduct("Tablet", 299.99, "Electronics");
            //Console.WriteLine("\nStatic factory method:");
            //product3.DisplayProduct();

            //// 4. Anonymous types
            //var product4 = new { Name = "Headphones", Price = 99.99, Category = "Accessories" };
            //Console.WriteLine("\nAnonymous type:");
            //Console.WriteLine($"Name: {product4.Name}, Price: {product4.Price:C}, Category: {product4.Category}");

            //// 5. Reflection
            //Type productType = typeof(Productss);
            //Productss product5 = (Productss)Activator.CreateInstance(productType, "Camera", 499.99, "Electronics");
            //Console.WriteLine("\nReflection:");
            //product5.DisplayProduct();

            //// 6. Default values in constructors
            //Productss product6 = new Productss();
            //Console.WriteLine("\nDefault values in constructor:");
            //product6.DisplayProduct();

            //Console.ReadLine();

            //------------------------------------------------------------

            //Assignment 19: Exploring Initialization Using Tuples and Records 

            // Method that accepts a tuple and returns a Student record
            //static Student CreateStudentFromTuple((string Name, int Age, char Grade) studentTuple)
            //{
            //    return new Student(studentTuple.Name, studentTuple.Age, studentTuple.Grade);
            //}

            //static void Main()
            //{
            //    // Initialize tuples with student details
            //    var studentTuple1 = ("Alice", 20, 'A');
            //    var studentTuple2 = ("Bob", 22, 'B');

            //    // Create Student records from tuples
            //    Student student1 = CreateStudentFromTuple(studentTuple1);
            //    Student student2 = CreateStudentFromTuple(studentTuple2);

            //    // Display details of each student
            //    Console.WriteLine("Student Details:");
            //    Console.WriteLine($"Name: {student1.Name}, Age: {student1.Age}, Grade: {student1.Grade}");
            //    Console.WriteLine($"Name: {student2.Name}, Age: {student2.Age}, Grade: {student2.Grade}");

            //Console.ReadLine();

            //------------------------------------------------------------

            //Assignment 20: Shopping Cart 


            //ShoppingCart cart = new ShoppingCart();
            //cart.AddProduct("Laptop", 1000, 1);
            //cart.AddProduct("Phone", 500, 2);

            //Console.WriteLine("Total Price: " + cart.CalculateTotal());

            //Console.ReadLine();

            //------------------------------------------------------------

            //Assignment 21: Banking System 

            //    Banks bank = new Banks();
            //    bank.AddCustomer("Navya");
            //    bank.AddAccount("Navya", 2001, 7000);
            //    bank.AddCustomer("Saju");
            //    bank.AddAccount("Saju", 2002, 3000);

            //    bank.DisplayCustomerDetails();

            //    Console.ReadLine();

            //------------------------------------------------------------

            //Assignment 22: University System

            //University university = new University();
            //university.AddDepartment("Computer Science");
            //university.AddCourse("Computer Science", "Data Structures", "CS101", 4);
            //university.AddCourse("Computer Science", "DBMS", "CS102", 4);

            //university.DisplayCourseInformation();

            //Console.ReadLine();
        }
    }
}
