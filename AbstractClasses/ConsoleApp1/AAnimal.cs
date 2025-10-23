using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class AAnimal
    {
        // Abstract method - subclasses MUST implement this
        public abstract void MakeSound();

        // Regular method - subclasses can use or ovveride
        public void Eat()
        {
            Console.WriteLine("This animal is eating.");
        }
    }
}
