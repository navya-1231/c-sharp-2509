using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1: To demonstrate Polymorphism and its Advantages
            //Shape shape = new Shape();
            //Circle shape1 = new Circle();
            //Rectangle shape2 = new Rectangle();

            //shape.Draw();
            //shape1.Draw();
            //shape2.Draw();

            //Console.ReadLine();

            //------------------------------------------------------------------------------

            //Assignment 2. Method Overloading and its uses 

            //MultiplyOperations multiplyOperations = new MultiplyOperations();
            //multiplyOperations.Multiply(2, 3);
            //multiplyOperations.Multiply(2, 3, 4);
            //multiplyOperations.Multiply(1.4, 1.5);
            //multiplyOperations.Multiply(1.6, 1);

            //Console.ReadLine();

            ////------------------------------------------------------------------------------

            //Assignment 3. Method Overriding 

            //Vehicle vehicle = new Vehicle();
            //vehicle.Drive();

            //Car car = new Car();
            //car.Drive();

            //Console.ReadLine();

            //------------------------------------------------------------------------------

            //Assignment 4

            //Payment payment = new Payment();
            //payment.ProcessPayment();

            //CreditCardPayment creditCardPayment = new CreditCardPayment();
            //creditCardPayment.ProcessPayment();

            //PayPalPayment payPalPayment = new PayPalPayment();
            //payPalPayment.ProcessPayment();

            //Console.ReadLine();

            //------------------------------------------------------------------------------

            //Assignment 5.Polymorphism with Static Data and Methods.

            //Employee employee = new Employee();
            //Manager manager = new Manager();
            //Developer developer = new Developer();

            //employee.Work();
            //manager.Work();
            //developer.Work();

            //Employee.DisplayEmployeeCount();

            //Console.ReadLine();


            //------------------------------------------------------------------------------

            //Assignment 6. Polymorphism with Arrays as Properties in a Class

            //Employees employees = new Employees(new String[] { "Task1", "Task2" });
            //employees.ShowTask();

            //Managers managers = new Managers(new string[] { "Task3", "Task4" });
            //managers.ShowTask();

            //Developers developers = new Developers(new string[] { "Task5", "Task6" });
            //developers.ShowTask();

            //Console.ReadLine();

            //------------------------------------------------------------------------------

            //Assignment 7: Understanding Early Binding and Late Binding in C#

            //Calculation calculation = new Calculation();
            //calculation.Add(3, 4);
            //calculation.Add(3, 4, 5);

            //Animal animal = new Animal();
            //animal.Sound();
            //Dog dog= new Dog();
            //dog.Sound();

            //Console.ReadLine(); 


            //------------------------------------------------------------------------------

            //Assignment 8. Achieving Runtime Polymorphism with Abstract Classes and  Interfaces in C#

            //Define an abstract class Shape and an interface IShape, implementing these in derived classes to showcase polymorphism.

            //Triangle triangle = new Triangle();
            //triangle.Draw();
            //triangle.Display();

            //Square square = new Square();
            //square.Draw();
            //square.Display();

            //Console.ReadLine();

            //------------------------------------------------------------------------------

            //Assignment 9. Demonstrating the Need for Multiple Inheritance of Interfaces 

            //Cars cars = new Cars();
            //cars.Draw();
            //cars.Move();

            //Console.ReadLine(); 

            //------------------------------------------------------------------------------

            //Assignment 10. Polymorphism in C# with Readonly Property 

            //Define a base class and derived classes where each class provides specific behavior for a method, while using a 
            //readonly property to ensure that certain values cannot be modified after initialization.

            Animals animals = new Animals("Canis");
            animals.Sound();

            Dogs dogs = new Dogs("Dog");
            dogs.Sound();


            Cats cats = new Cats("Cat");
            cats.Sound();   


            Console.ReadLine();
        }
    }
}
