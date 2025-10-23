using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog : AAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine("woof");
        }
    }
}
