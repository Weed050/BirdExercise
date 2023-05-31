using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdExercise
{
    public class Bird
    {
        public string Name { get; set; }
        public virtual void Fly() {
            Console.WriteLine("fry ... fry ...");
        }
        public override string ToString()
        {
            return "Ptak "+Name;
        }
    }
    class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Pingwin "+Name);
        }
        public override string ToString()
        {
            return "Pingwin "+base.Name;
        }
    }
}
