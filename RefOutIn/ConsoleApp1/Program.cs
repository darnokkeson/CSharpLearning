using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // REF
            // REQUIRED STEP - INITIALIZE the value
            int x = 5;

            // Put the initialized value
            // !pitting value directly to method will give the error!
            RefMethod(ref x);
            Console.WriteLine(x);


            // OUT
            // VARIABLE DOESNT REQUIRE the value (but can have!)
            int c;
            OutMethod(3, out c);
            Console.WriteLine(c);

            Point p = new Point();
            p.X = 1;
            p.Y = 2;

            Console.WriteLine(p.Y);

            Draft draft = new Draft();

            draft.a 
        }

        // REF - READ and WRITE(change)
        // 1. VARIABLE must be initialized before calling
        // 2. METHOD can READ and WRITE(change) the value.
        static void RefMethod(ref int number) // READ value
        {
            number += 5; // WRITE(change) value
        }

        // OUT - WRITE only
        // 1. VARIABLE DOESNT REQUIRE a value before calling
        // 2. Method must assign a value to 'out variable' before returning
        static void OutMethod(int a, out int cube)
        {
            cube = a * a;
        }

        // IN - READ only

    }
}