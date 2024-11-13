using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_part7
{
    internal class Program
    {

        //assignment 5
        delegate void GreetDelegate(string message);

        //assignment 8 delegate that accepts a string parameter and returns a string
        public delegate string StringOperationDelegate(string input);

        // assignment 10 Define delegate that takes two integers and returns an integer
        public delegate int CalculationDelegate(int x, int y);

        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //Assignment 1.Anonymous Types

            // Create an anonymous type to represent a book with properties for Title, Author, and Price.
            //Display the details of the book

            //var book = new { Title = "Book1", Author = "author1", Price = 400 };

            //Console.WriteLine($"Title:{book.Title}\nAuthor:{book.Author}\nPrice:{book.Price}");

            //Console.ReadLine();


            //-------------------------------------------------------------------------------------

            //Assignment 2. Var and Dynamic

            //1. Declare a var variable to hold a list of integers, add some numbers to it, and print them. 

            // Declare a var variable to hold a list of integers
            //var numbers = new List<int>();

            //// Add some numbers to the list
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);

            //// Print the numbers
            //Console.WriteLine("List of numbers:");
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.ReadLine();

            //2. Declare a dynamic variable, assign different types of values to it, and observe the  behavior.

            //// Declare a dynamic variable
            //dynamic value;

            //value = 100;
            //Console.WriteLine(value.GetType());

            //value = "navya";
            //Console.WriteLine(value.GetType());

            //value = false;
            //Console.WriteLine(value.GetType());

            //Console.ReadLine();


            //-------------------------------------------------------------------------------------

            //Assignment 3.Delegates

            //Create a simple calculator using delegates.Define a delegate OperationDelegate that can
            //represent different arithmetic operations(addition, subtraction, multiplication, division).
            //Implement methods for each operation and allow the user to select an operation to perform on
            //two input numbers.

            //Console.WriteLine("Choose an operation:");
            //Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the first number:");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the second number:");
            //double number2 = Convert.ToDouble(Console.ReadLine());

            ////Declare a delegate variable to hold the selected operation method
            //Calculator.CalculatorDelegate operation = null;

            //switch (choice)
            //{
            //    case 1:
            //        operation = Calculator.Addition;// Assign Addition method
            //        break;
            //    case 2:
            //        operation = Calculator.Substraction;
            //        break;
            //    case 3:
            //        operation = Calculator.Multiplication;
            //        break;
            //    case 4:
            //        operation = Calculator.Division;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice.");
            //        break;
            //}

            //if (operation != null)
            //{
            //    operation(number1, number2);
            //}

            //Console.ReadLine();



            //--------------------------------------------------------------------------------------

            //Assignment 4 Events 

            ////Create an event called OnCompleted in a class Process. Raise the event when a process is 
            ////completed.Subscribe to the event from the main program to display a message.

            //Process process = new Process();
            //// Subscribe to the event
            //process.ProcessCompleted += () => Console.WriteLine("Process Completed!");
            //// Start the process which triggers the event
            //process.StartProcess();

            //Console.ReadLine();


            //--------------------------------------------------------------------------------------

            //Assignment 5 Anonymous Methods

            ////Write a delegate GreetDelegate that takes a string parameter.
            ////Assign an anonymous method to the delegate that prints a greeting message.

            //// Assign an anonymous method to the delegate
            //GreetDelegate print = delegate (string message)
            //{
            //    Console.WriteLine(message);
            //};
            //// Call the delegate with a message
            //print("Hello");

            //Console.ReadLine();


            //--------------------------------------------------------------------------------------

            //Assignment 6.Lambda Expressions

            // Write a lambda expression that takes two integers and returns their product. Use Func<int, int,
            //int> for the delegate type.


            //Func<int, int, int> product = (x, y) => x * y;// Lambda expression to calculate product of two integers
            //Console.WriteLine(product(3, 4)); // Calling the lambda expression 

            //Console.ReadLine();

            //--------------------------------------------------------------------------------------

            //Assignment 7.Expression Tree

            //Create an expression tree for a lambda expression that adds two integers.Compile and execute the expression.



            //Console.ReadLine();

            //--------------------------------------------------------------------------------------

            //Assignment 8. Using Delegates to Hold Methods with the Same Signature

            //Create a delegate called StringOperationDelegate that accepts a string parameter and returns a
            //string.Write three different methods that modify the string in different ways(e.g., convert to
            //uppercase, reverse, add a prefix). Use the delegate to call each method. 


            //// Create an instance of the StringOperation class
            //StringOperation stringOps = new StringOperation();

            //// Assign the ToUpperCase method to the delegate
            //StringOperationDelegate stringOperation = stringOps.ToUpperCase;

            //// Call the delegate
            //string result1 = stringOperation("Navya");
            //Console.WriteLine("In upper case: " + result1);


            //stringOperation = stringOps.ReverseString;
            //string result2 = stringOperation("Navya");
            //Console.WriteLine("Reversed: " + result2);

            //stringOperation = stringOps.AddPrefix;
            //string result3 = stringOperation("Navya");
            //Console.WriteLine("With prefix: " + result3);

            //Console.ReadLine();


            //--------------------------------------------------------------------------------------


            // Assignment 9.Lambda Expressions to Filter and Process Lists


            // Given a list of products with properties Name and Price, use lambda expressions to:
            // 1.Filter the list to find products that cost more than $50.
            //2.Sort the list by price in descending order. 
            //3.Select and display only the names of products from the filtered list.

            //// Initializing an empty list of products
            //List<Product> products = new List<Product>();


            //// Adding products individually using the Add method
            //products.Add(new Product("Laptop", 120000));
            //products.Add(new Product("Headphones", 500));
            //products.Add(new Product("Smartphone", 90000));
            //products.Add(new Product("Keyboard", 60));
            //products.Add(new Product("Monitor", 150000));
            //products.Add(new Product("Mouse", 20));
            //products.Add(new Product("Tablet", 400000));

            //Console.WriteLine("Product list");
            //foreach (Product product in products)
            //{
            //    Console.WriteLine($"{product.Name}:{product.Price}");
            //}


            //// Filter the list to find products that cost more than $50
            //var filteredProducts = products.Where(p => p.Price > 50);

            ////Sort the filtered list by price in descending order
            //var sortedProducts = filteredProducts.OrderByDescending(p => p.Price);

            ////display only the names of products from the sorted, filtered list
            //var productNames = sortedProducts.Select(p => p.Name);

            //Console.WriteLine("\nNames of products from the sorted,filtered list");
            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadLine();


            //--------------------------------------------------------------------------------------

            //  Assignment 10.Delegate as a Callback Mechanism(not complete)

            // Create a delegate called CalculationDelegate that takes two integers and returns an integer. 
            //Implement methods for addition and subtraction, and write a method Calculate that accepts two
            //integers and a delegate as parameters.Use the delegate to perform addition and subtraction
            //operations by passing different methods.


            //// Create an instance of Calculation
            //Calculations calc = new Calculations();

            //// Perform addition using the Calculate method with the delegate
            //int addResult = calc.Calculate(100, 50, calc.Addition);
            //Console.WriteLine("Addition Result: " + addResult);

            //// Perform subtraction using the Calculate method with the delegate
            //int subtractResult = calc.Calculate(100, 50, calc.Subtraction);
            //Console.WriteLine("Subtraction Result: " + subtractResult);

            //Console.ReadLine();

            //--------------------------------------------------------------------------------------

            // Assignment 11. 

            // Write a C# program that simulates a long-running operation using Task.Delay() and runs 
            //asynchronously. Display a message before and after the operation completes.


            //// Display a message before the long-running operation starts
            //Console.WriteLine("Starting the long-running operation");

            //Async.AsyncMethod();//calling asynchronous method

            //// Display a message after the operation completes
            //Console.WriteLine("Long-running operation completed.");
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------

            // Assignment 12.Async and Await Keywords

            //Create a method that downloads data from a sample URL asynchronously.Use HttpClient to
            //fetch the data and print the length of the content.The method should use async and await keywords.


            //try 
            //{
            //    string url = "https://www.javatpoint.com/";
            //    Download.Call(url);


            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //--------------------------------------------------------------------------------------

            //  Assignment 13.Task and Task<T>

            //Write a C# program that calculates the sum of an array of integers asynchronously using 
            //Task<int>.Return the result from the asynchronous method and display it.

            //int[] numbers = { 1, 2, 3, 4, 5 };


            //// Call the asynchronous method to calculate the sum
            //int sum = await CalculatorTask.Sum(numbers);

            //// Display the result
            //Console.WriteLine($"The sum of the array is: {sum}");


            //Console.ReadLine(); 

            //--------------------------------------------------------------------------------------

            //Assignment 14. Handling Exceptions in Asynchronous Methods 

            //Modify the previous example to handle exceptions that might occur during the sum calculation. 
            //Catch the exception in the Main method and display an error message

            //try
            //{
            //    int[] numbers = { 1, 2, 3, 4, 5 };

            //     // Call the asynchronous method to calculate the sum
            //    int sum = await CalculatorTask.Sum(numbers);

            //    // Display the result
            //    Console.WriteLine($"The sum of the array is: {sum}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine(); 

            //--------------------------------------------------------------------------------------


            //Assignment 15.Parallel Programming with Task Parallel Library(TPL)

            //Create a program that runs multiple tasks in parallel to simulate multiple operations, such as
            //calculating the factorial of different numbers.Print the result of each task when completed


            //int[] numbers = { 3, 6, 9 };
            //// Run factorial calculation tasks in parallel
            //Parallel.ForEach(numbers, number => 
            //{
            //    long result=ParallelClass.Factorial(number);    
            //    Console.WriteLine("factorial of "+number+" is "+result);

            //});
            //Console.ReadLine(); 

            //--------------------------------------------------------------------------------------

            //Assignment 16. LINQ Query Syntax and Method Syntax

            // Write a LINQ query using both query syntax and method syntax to retrieve all
            //numbers greater than 5 from a list of integers

            //List<int> numbers = new List<int> { 2,4,6,8,10 };

            //// Query syntax
            //var querySyntaxResult = from number in numbers
            //                        where number > 5
            //                        select number;

            //// Method syntax
            //var methodSyntaxResult = numbers.Where(number => number > 5);

            //// Display results from query syntax
            //Console.WriteLine("Numbers greater than 5 using Query Syntax");
            //foreach (var number in querySyntaxResult)
            //{
            //    Console.WriteLine(number);
            //}

            //// Display results from method syntax
            //Console.WriteLine("Numbers greater than 5 using Method Syntax");
            //foreach (var number in methodSyntaxResult)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------

            //Assignment 17.LINQ Operators(Select, Where, GroupBy, Join, etc.)

            // Given a list of strings representing student names, write a LINQ query that selects
            //the names starting with the letter 'A' and orders them alphabetically

            //List<string> studentNames = new List<string> { "Navya", "Kishna", "Anu", "Lakshmi", "Sara", "Alice" };


            //var Result = studentNames
            //                    .Where(name => name.StartsWith("A"))
            //                    .OrderBy(name => name);

            //foreach (var result in Result)
            //{ 
            //    Console.WriteLine(result);
            //}
            //Console.ReadLine(); 


            //--------------------------------------------------------------------------------------

            //Assignment 18.LINQ to Objects

            //Write a LINQ query to find the sum of all even numbers in an array of integers. 

            //// Array of integers
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var sum = numbers.Where(number => number % 2 == 0).Sum();

            //Console.WriteLine("sum: " + sum);

            //Console.ReadLine();

            //--------------------------------------------------------------------------------------

            //Assignment 19.LINQ to XML

            //Create an XML document representing a list of books, and use LINQ to XML to
            //query the titles of books published after 2015.

            //// Load the XML document
            //try
            //{
            //    XDocument doc = XDocument.Load("file.xml");

            //    // LINQ to XML query to find books published after 2015
            //    var recentBooks = from book in doc.Descendants("book")
            //                      where (int)book.Element("year") > 2015
            //                      select book.Element("title").Value; //retrieves the title of each filtered book.

            //    foreach (var title in recentBooks)
            //    {
            //        Console.WriteLine(title);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();


            //--------------------------------------------------------------------------------------

            //Assignment 20. LINQ to SQL

            //Given a database table Employees with columns ID, Name, and Department, write a 
            //LINQ to SQL query to select all employees from the "IT" department


        //    using (var db = new DataContext())
        //    {
        //        var itEmployees = from emp in db.Employees
        //                        where emp.Department == "IT"
        //                        select emp;

        //        foreach (var employee in itEmployees)
        //        {
        //            Console.WriteLine($"ID: {employee.Id},Name: {employee.Name},Department: {employee.DEpartment}");
        //        }
        //    }
        //    Console.ReadLine(); 
            
        //}


    }
}
