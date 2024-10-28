using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Lab 1.Single Inheritance
           
            
            Student student = new Student("Navya", 23, "A");

            student.ShowStudentInfo();
            Console.ReadLine();

            //--------------------------------------------------------------

            //Lab 2. Multilevel Inheritance 


            //Animal animal = new Animal();
            //animal.Eat();


            //Dog dog = new Dog();
            //dog.Eat();
            //dog.Bark();

            //Puppy puppy = new Puppy();
            //puppy.Eat();   
            //puppy.Bark(); 
            //puppy.Weep();

            //Console.ReadLine();

            //--------------------------------------------------------------

            //Lab 3. Multiple Inheritance (via Interfaces) 

            //PrinterScanner printerScanner = new PrinterScanner();

            //printerScanner.Print();
            //printerScanner.Scan();
            //Console.ReadLine();


            //--------------------------------------------------------------

            //Lab 4. Hierarchical Inheritance 

            //Shape shape = new Shape();
            //Circle circle = new Circle();
            //Rectangle rectangle = new Rectangle();

            //shape.Draw();       
            //circle.Draw();    
            //rectangle.Draw();
            //Console.ReadLine();

            //--------------------------------------------------------------

            //Lab 5. Hybrid Inheritance (Using Interfaces)

            //ElectricCar electricCar = new ElectricCar();
            //electricCar.Move();      
            //electricCar.Recharge();

            //Console.ReadLine();

            //--------------------------------------------------------------

            //Lab 6. Overriding Methods in Inheritance


            //Employee employee = new Employee();
            //employee.Work();

            //Manager manager = new Manager();
            //manager.Work();

            //Console.ReadLine();


            //--------------------------------------------------------------

            //Lab 7. Abstract Classes

            //Vehicles car = new Car();
            //car.Drive();

            //Bike bike = new Bike();
            //bike.Drive();

            //Console.ReadLine();

            //--------------------------------------------------------------

            //Lab 8. Sealed Classes

            //MathOperations mathOps = new MathOperations();
            //int result = mathOps.Add(5, 7);
            //Console.WriteLine(result);

            //Console.ReadLine();

            //--------------------------------------------------------------

            //Lab 9. Constructor Chaining

            //Employees employee = new Employees("Navya", 101);
            //Console.ReadLine();


            //--------------------------------------------------------------

            //Lab 10. Interface Inheritance 

            //Cars cars = new Cars();
            //cars.Drive();
            //cars.Race();

            //Console.ReadLine();



            //--------------------------------------------------------------

            //Lab 11. IS-A Relationship (Inheritance) 

            //Dogs dog = new Dogs("puppy");
            //dog.Eat();
            //dog.Bark();

            //Console.ReadLine();

            //--------------------------------------------------------------

            //Lab 12.HAS-A Relationship (Composition) 

            //Carss car = new Carss("Honda", 550);
            //car.ShowCarDetails();

            //Console.ReadLine();

            //--------------------------------------------------------------

            //Lab 13. Calling Base Class Method Using base

            //Employeess employee = new Employeess("Navya", 23);
            //employee.DisplayInfo();

            //Console.ReadLine();

            //--------------------------------------------------------------

            ////Lab 14. Accessing Base Class Variable Using base 
            //Personn person = new Personn ("navya");
            //Students student = new Students("saju");
            //student.ShowNames();

            //Console.ReadLine();


            ////--------------------------------------------------------------

            ////Lab 15. Calling Base Class Constructor Using base

            //Carsss car = new Carsss("Toyota");
            //car.DisplayBrand();
            //Console.ReadLine();
        }
    }
}





















