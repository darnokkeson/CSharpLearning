using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListTest();
            // ModuloTest();
        }

        static void TestFor(int numList)
        {
            // for (initialization; condition; increment)
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

        }

        // count even numbers from list
        static void ListTest()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            int count = 0;

            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    count = count + i;
                }
            }
            Console.WriteLine(count);
        }

        static void ModuloTest()
        {
            if (2 % 2 == 0)
            {
                Console.WriteLine("works");
            }
        }
    }
}
