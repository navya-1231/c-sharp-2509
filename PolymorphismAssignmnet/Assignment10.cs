using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignmnet
{
    public class Animals
    {
        public readonly string Species;

        public Animals(string species)
        {
            Species = species;
        }
        public virtual void Sound()
        {
            Console.WriteLine($"The {Species} makes sound.");
        }
    }
    public class Dogs : Animals
    {
        public Dogs(string species) :base(species)  { }
        public override void Sound()
        {
            Console.WriteLine($"The {Species} barks.");
        }
    }

    public class Cats : Animals
    {
        public Cats(string species) : base(species) { }
        public override void Sound()
        {
            Console.WriteLine($"The {Species} meows.");
        }
    }
}
