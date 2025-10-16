namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestWhileLoop(6);
            DoWhileLoop(6);
        }

        static void TestWhileLoop(int input)
        {
            int index = input;
            while (index <= 5)
            {
                Console.WriteLine($"While {input}");
                index++;
            }
        }

        static void DoWhileLoop(int input)
        {
            int index = input;
            do
            {
                Console.WriteLine($"DoWhile {input}");
                index++;
            } while (index <= 5);
        }
    }
}
