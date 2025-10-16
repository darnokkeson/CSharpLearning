namespace ConsoleApp1
{
    internal class Program
    {
        // Main - method for call other methods
        static void Main(string[] args)
        {
            // calling methods (created above)
            SayHi("noise", 29);
            SayHi("Ti", 25);

            int cubeReturn = cube(5);
            Console.WriteLine(cubeReturn);
        }

        // creating new method
         
        static void SayHi(string name, int age)
        {
            Console.WriteLine($"Hello {name} you are {age}");
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
