using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Vehicless
    {
        public string Brand { get; set; }

        public Vehicless(string brand)
        {
            Brand = brand;
        }
    }
    public class Carsss : Vehicless
    {
        public Carsss(string brand) : base(brand) { }

        public void DisplayBrand()
        {
            Console.WriteLine("Car brand: " + Brand);
        }
    }
}
