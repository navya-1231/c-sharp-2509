using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignments_On_Abstract_Class_Interface_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1

            //Create an abstract class Vehicle that has an abstract method StartEngine() and a concrete method
            //StopEngine(). Create derived classes Car and Motorcycle that implement the StartEngine()
            //method and override it to show specific behavior for each type of vehicle.

            //Car car = new Car();
            //car.StartEngine();
            //car.StopEngine();

            //Motorcycle motorcycle = new Motorcycle();
            //motorcycle.StartEngine();
            //motorcycle.StopEngine();

            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------------

            //Assignment 2.Virtual Functions

            //Create a base class Animal with a virtual method MakeSound(). Derive classes Dog and Cat that
            //override the MakeSound() method to provide their specific implementation.

            //Animal animal = new Animal();
            //animal.MakeSound();

            //Dog dog = new Dog();
            //dog.MakeSound();

            //Cat cat = new Cat();
            //cat.MakeSound();

            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------------

            //Assignment 3.Interface
            // Create an interface IDrive with a method Drive(). Implement this interface in a Car and Truck
            //class, with each class having its own implementation of Drive(). 


            //Cars cars = new Cars();
            //cars.Drive();

            //Truck truck = new Truck();
            //truck.Drive();

            //Console.ReadLine(); 


            //------------------------------------------------------------------------------------------------------

            // Assignment 4.Interface vs.Abstract Class

            //Write a program that demonstrates the difference between an abstract class and an interface by
            //creating an abstract class Bird with an abstract method Fly(), and an interface ISwim with a method Swim().

            //Parrot parrot = new Parrot();
            //parrot.Fly();
            //parrot.Swim();
            //parrot.Eat();

            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------------

            // Assignment 5.Static Class

            //Create a static class MathOperations with a static method Add() and Multiply(). Demonstrate
            //calling these methods without creating an instance of the class.

            //MathOperations.Add(1,2);
            //MathOperations.Multiply(1,2);
            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------------

            // Assignment 6.Extension Methods

            //Create an extension method IsEven() for the int type that returns true if the number is even and
            //false if it is odd.

            //Console.WriteLine("Enter number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //bool result = number.IsEven();// Extension method usage

            //Console.WriteLine(result);

            //Console.ReadLine();


            //------------------------------------------------------------------------------------------------------

            //Assignment 7.Partial Class
            //Create a partial class Person that is defined in two files.One file should have the property Name,
            //and the other file should have the method ShowDetails(). 


            //PartialClass partialClass=new PartialClass("Navya");
            //partialClass.ShowDetails();

            //Console.ReadLine();



            //------------------------------------------------------------------------------------------------------

            //Assignment 8.Partial Methods
            //Create a partial class Employee with a partial method CalculateSalary(). Implement the partial
            //method in another part of the class and demonstrate its usage.

            //Employee employee = new Employee();
            //employee.salaryPerHour = 100;
            //employee.TotalHour = 100;
            //employee.Display();

            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------------


            //Assignment 9.Indexer

            //Create a Library class that contains an array of Book objects.Implement an indexer that allows
            //accessing the books by index.Write a method to display all the books in the library. 


            //Library library = new Library();

            ////Initialize books using the indexer
            //library[0] = new Book("Book1", "Author1");
            //library[1] = new Book("Book2", "Author2");
            //library[2] = new Book("Book3", "Author3");
            //library[3] = new Book("Book4", "Author4");
            //library[4] = new Book("Book5", "Author5");

            //library.DisplayBooks();

            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------------

            // Assignment 10.Exception Handling

            //Write a method Divide that takes two integers as input and returns their division. If a division by
            //zero occurs, catch the exception and display a custom error message. Demonstrate exception
            //handling with a try-catch-finally block.

            //try
            //{
            //    Console.Write("Enter first number ");
            //    int number1=Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter second number ");
            //    int number2 = Convert.ToInt32(Console.ReadLine());

            //    int result=number1/number2;

            //    Console.WriteLine("Result"+result);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error "+ex.Message);
            //}
            //finally 
            //{ 
            //    Console.WriteLine("Inside finally block");
            //}

            //Console.ReadLine(); 


            //------------------------------------------------------------------------------------------------------

            // Assignment 11.Enum
            //Create an enum CarType with values Sedan, SUV, Truck, and Coupe.Write a Car class with a
            //property Type of type CarType.Write a method that takes a CarType value and displays a
            //message specific to that type of car.

            //Carss carss = new Carss(CarType.Coupe);
            //carss.Display(carss.Type);

            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------------

            //Assignment 12.Attributes

            //Define a custom attribute DeveloperAttribute that takes the name of the developer and the date
            //when the code was last modified.Apply this attribute to a class Calculator and its method Add.
            //Retrieve and display the attribute information at runtime.

            //Class level Attribute Retrieving and Display

            //Type type = typeof(Calculator);//gets the type information for the Calculator class.
            //object[] classAttributes = type.GetCustomAttributes(false);

            //foreach (DeveloperAttributes attri in classAttributes)
            //{
            //    Console.WriteLine($"class developed by: {attri.Name}, last modified by: {attri.Date}");
            //}

            ////Class level Attribute Retrieving and Display

            //var methodInfo = type.GetMethod("Add");//Retrieves the Add method information.
            //object[] methodAttributes = methodInfo.GetCustomAttributes(false);

            //foreach (DeveloperAttributes attr in methodAttributes)
            //{
            //    Console.WriteLine($"Method developed by: {attr.Name}, last modified on: {attr.Date}");
            //}

            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------------
        }
    }
}
