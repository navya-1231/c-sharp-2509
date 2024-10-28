using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Engine
    {
        public int HorsePower;
        public Engine(int horsePower)
        {
            HorsePower = horsePower;
        }
        public void ShowEngineDetails() {
            Console.WriteLine($"Engine HorsePower: {HorsePower}");
        }
    }
    public class Carss
    { 
        public string Model;
        private Engine engine;//HAS-A Relationship

        public Carss(string model,int horsePower) {
            Model = model;
            engine = new Engine(horsePower);
        }

        public void ShowCarDetails()
        {
            Console.WriteLine($"Car Model: {Model}");
            engine.ShowEngineDetails();

        }
    }
}


