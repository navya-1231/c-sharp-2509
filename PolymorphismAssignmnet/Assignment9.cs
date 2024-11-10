using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmnet
{
    interface IMovable 
    {
        void Move();
    }
    interface IDrawable
    {
        void Draw();
    }
    public class Cars : IMovable, IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing the Car");
        }

        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
}
