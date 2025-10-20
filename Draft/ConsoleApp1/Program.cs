namespace ConsoleApp1
{
    internal class Program
    {

        // DRAFT
        static void Main(string[] args)
        {
            TestProgram(3, 4);
        }

        static void TestProgram(int floor, int power)
        {
            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result = result * floor;

                Console.WriteLine(result);
            }
        }
    }
}
