using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmnet
{
    public abstract class Shapes
    {
        public abstract void Draw();
    }
    interface Ishape
    {
        void Display();
    }
    public class Triangle : Shapes, Ishape
    {
        public override void Draw()
        {
            Console.WriteLine("Triangle is Drawing");
        }
        public void Display()
        {
            Console.WriteLine("Triangle is Displaying");
        } 
    }
    public class Square : Shapes, Ishape
    {
        public override void Draw()
        {
            Console.WriteLine("Square is Drawing");
        }
        public void Display()
        {
            Console.WriteLine("Square is Displaying");
        }
    }
}
