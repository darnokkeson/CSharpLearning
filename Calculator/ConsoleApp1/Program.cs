namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"outcome: {Calculator()}");
        }

        static double Calculator()
        {
            Console.WriteLine("choose number for action: \n" +
                "1. add (+)\n" +
                "2. subtract (-)\n" +
                "3. multiply (*)\n" +
                "4. division (/)");
            int numAction = int.Parse(Console.ReadLine());

            Console.WriteLine("Put first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Put second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"numAction {numAction} num1 {num1} num2 {num2}");

            double outcome = 0;

            switch (numAction)
            {
                case 1:
                    outcome = num1 + num2;
                    break;
                case 2:
                    outcome = num1 - num2;
                    break;
                case 3:
                    outcome = num1 * num2;
                    break;
                case 4:
                    outcome = num1 / num2;
                    break;
                default:
                    Console.WriteLine("invalid choose.");
                    break;
            }
            return outcome;
        }

        static void Test()
        {
            float n = 2f;
            Console.WriteLine(n.GetType());
        }
    }
}
