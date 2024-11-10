using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignments_Part_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Assignment 1.

            //Question : Create a Library class to store and manage books in a single-dimensional array where
            //each element represents a book title.Also, use a two-dimensional array in a Classroom class
            //where each element represents the seat of a student based on rows and columns.

            //Library library = new Library(new string[] { "Book1", "Book2", "Book3", "Book4", "Book5" });
            //library.DisplayBooks();
            //Console.WriteLine();
            //Console.WriteLine();

            //Classroom classroom = new Classroom(new string[,] { { "seat1", "seat2", "seat3" }, { "seat4", "seat5", "seat6" } });

            //classroom.DisplaySeatingArrangement();

            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------

            // Assignment 2.

            //Question: Define a Movie class with properties like Title and Year.Create a MovieLibrary class
            //that stores an array of Movie objects and displays each movie’s information.

            //Movie movie1 = new Movie("ARM", 2024);
            //Movie movie2 = new Movie("Kondal", 2024);
            //Movie movie3 = new Movie("AMARAN", 2024);
            //Movie movie4 = new Movie("Neram", 2015);



            //MovieLibrary library = new MovieLibrary();
            //library.AddMovie(movie1);
            //library.AddMovie(movie2);
            //library.AddMovie(movie3);
            //library.AddMovie(movie4);

            //library.DisplayMovies();
            //Console.ReadLine();


            //-----------------------------------------------------------------------------------------


            // Assignment 3.

            //Question: Create an enumeration OrderStatus with values Pending, Shipped, and Delivered.
            //Define an Order class with an OrderStatus property to manage the status of each order.


            //Orders order1 = new Orders(101, OrderStatus.Delivered);
            //Orders order2 = new Orders(102, OrderStatus.Shipped);
            //Orders order3 = new Orders(103, OrderStatus.Pending);

            //Orders.Display(order1);
            //Orders.Display(order2);
            //Orders.Display(order3);


            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------

            // Assignment 4.

            //Question: Create a Circle struct to represent a circle as a value type, and a Shape class to
            //represent a reference type.Show how changing values affects each.

            //Circle circle1 = new Circle(5);
            //Circle circle2 = circle1;

            //Console.WriteLine($"Circle1 Radius: {circle1.Radius}");
            //Console.WriteLine($"Circle2 Radius: {circle2.Radius}");

            //// Changing the radius of circle2 (does not affect circle1)
            //circle2.Radius = 10;

            //Console.WriteLine("\nAfter modifying circle2:");
            //Console.WriteLine($"Circle1 Radius: {circle1.Radius}");
            //Console.WriteLine($"Circle2 Radius: {circle2.Radius}");


            //// Working with the Shape class (reference type)
            //Shape shape1 = new Shape(4);
            //Shape shape2 = shape1;

            //Console.WriteLine($"\nShape1 NoOfSides: {shape1.NoOfSides}");
            //Console.WriteLine($"Shape2 NoOfSides: {shape2.NoOfSides}");

            //// Changing the NoOfSides of shape2 (affects shape1 as well)
            //shape2.NoOfSides = 5;

            //Console.WriteLine("\nAfter modifying shape2:");
            //Console.WriteLine($"Shape1 NoOfSides: {shape1.NoOfSides}");
            //Console.WriteLine($"Shape2 NoOfSides: {shape2.NoOfSides}");


            //Console.ReadLine();


            //-----------------------------------------------------------------------------------------


            // Assignment 5.
            //Question: Create a method IncreaseScore that takes a ref integer parameter representing a
            //player’s score and increases it by 10.


            //int playerScore = 50; // Initial score
            //Console.WriteLine("Initial Score: " + playerScore);

            //IncreaseScore(ref playerScore); // Increase the score

            //Console.WriteLine("New Score: " + playerScore);

            //void IncreaseScore(ref int score)
            //{
            //    score += 10;
            //}

            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------


            //  Assignment 6

            //Question: Create a method Divide that takes two integers, calculates their quotient and
            //remainder, and returns both values using the out keyword.


            //int number1=7;
            //int number2=2;

            //int quotient;
            //int remainder;

            //Divide(number1, number2, out quotient, out remainder);

            //Console.WriteLine($"Quotient: {quotient}");
            //Console.WriteLine($"Remainder: {remainder}");


            //void Divide(int dividend, int divisor, out int quotients, out int remainders)
            //{
            //    quotients = 0;
            //    remainders = 0;
            //    if (divisor == 0)
            //    {
            //        Console.WriteLine("Divisor cannot be zero.");

            //    }
            //    else
            //    {
            //        quotients = dividend / divisor;   
            //        remainders = dividend % divisor; 
            //    }
            //}

            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------

            // Assignment 7

            //Question: Write a C# program that demonstrates a FileNotFoundException and an 
            //IndexOutOfRangeException. Explain what causes these exceptions.

            ////FileNotFoundException
            //try
            //{
            //    StreamReader reader1 = new StreamReader("samplefile.txt");
            //    Console.WriteLine(reader1.ReadToEnd());
            //    StreamReader reader = new StreamReader("abcdef.txt");
            //    Console.WriteLine(reader.ReadToEnd());

            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("error: " + ex.Message);
            //}

            //Console.WriteLine();
            ////IndexOutOfRangeException
            //try
            //{
            //    int[] numberArray = { 1, 2, 3, 4, 5, 6, 7 };
            //    Console.WriteLine(numberArray[3]);
            //    Console.WriteLine(numberArray[9]);

            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Error " + ex.Message);
            //}
            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------

            //Assignment 8

            //Question: Create a method GetUserInput that prompts the user to enter an integer. If the input is
            //invalid, catch the exception and prompt the user again until they enter a valid integer.

            //GetUserInput();
            //void GetUserInput()
            //{
            //    bool validInput = false;
            //    while (!validInput)
            //    {
            //        try
            //        {
            //            Console.WriteLine("Enter an integer: ");
            //            int number = Convert.ToInt32(Console.ReadLine());

            //            validInput = true; // Set validInput to true to exit the loop
            //            Console.WriteLine($"You entered: {number}"); // Display the valid input
            //            Console.ReadLine();
            //        }
            //        catch (FormatException ex) 
            //        {
            //            Console.Write(ex.Message);
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //            Console.ReadLine();

            //        }
            //    }
            //}



            //-----------------------------------------------------------------------------------------

            //Assignment 9: Multiple Catch Blocks 

            //  Create a method that calculates the division of two integers. Use multiple catch blocks
            //to handle DivideByZeroException and FormatException. 



            //Divide divide = new Divide();
            //divide.PerformDivision();
            //Console.ReadLine();


            //-----------------------------------------------------------------------------------------

            //Assignmnet10

            //  Write a method ReadFile that opens a file, reads its contents, and closes it. Use a 
            //finally block to ensure the file is closed, even if an exception occurs. 


            //string filePath = "sample.txt";

            //FileReader fileReader = new FileReader();
            //fileReader.ReadFile(filePath);

            //Console.ReadLine();


            //-----------------------------------------------------------------------------------------

            //Assignmnet 11

            //  Explain the purpose of the throw keyword in C#. Create a method ValidateAge that 
            //throws an exception if the age is below 18, and handle it in the calling method.



            //try
            //{
            //    Console.WriteLine("Enter your age:");
            //    int age = Convert.ToInt32(Console.ReadLine());


            //    Validator.ValidateAge(age);

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error: Please enter a valid number for age.");
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            //}
            //Console.ReadLine();


            //-----------------------------------------------------------------------------------------

            //Assignmnet 12 . Custom Exception 

            // Create a custom exception class NegativeNumberException to handle negative inputs. 
            //Write a method CheckNumber that throws this exception if the number is negative.

            //NumberChecker checker = new NumberChecker();

            //try
            //{
            //    Console.WriteLine("entre a number");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    checker.CheckNumber(number);
            //}
            //catch (CustomNumberException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}
            //Console.ReadLine();


            //-----------------------------------------------------------------------------------------

            //Assignmnet 13

            // Logging Exceptions 

            //another file


            //-----------------------------------------------------------------------------------------

            //Assignment 14

            //same as 12

            //-----------------------------------------------------------------------------------------

            //Assignments 15

            // Test FileProcessor
            FileProcessor fileProcessor = new FileProcessor();
            fileProcessor.ReadFileContent("nonexistentfile.txt"); // Trigger FileNotFoundException

            // Test MathOperations
            MathOperations mathOperations = new MathOperations();
            mathOperations.Divide(10, 0); // Trigger DivideByZeroException

            // Test Person Age Validation
            Person person = new Person();
            try
            {
                person.SetAge(-5); // Trigger InvalidAgeException
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                person.SetAge(130); // Trigger InvalidAgeException
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine(); 




        }


    }
}
