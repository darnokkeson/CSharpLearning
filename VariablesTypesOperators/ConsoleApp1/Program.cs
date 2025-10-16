namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STRING - if in ""
            string name = "John";

            // CHAR - if in '', must be one character
            char firstChar = 'J';



            // INT - small number (none symbol) 32bit
            int age = 30;
            age++;

            // UINT - only positive numbers (u symbol) 32bit
            uint positive = 42u;

            // LONG - big number (L symbol) 64 bit
            // liczby można zapisywać po podłodze dla lepszej czytelności
            long big = 4_294_967_296L;



            // FLOAT - floating number (F or f symbol) 32bit
            float temperature = 28.5F;

            // DOUBLE - floating number (D symbol) 64bit
            double income = 9543.65D;

            // DECIMAL - floating number (M symbol) 128bit
            decimal money = 1_300_500.65M;



            // BOOLean - boolean state (true or false)
            bool isMale = true;



            // ARRAY of int 32bit
            int[] oneDimensional = { 2, 4, 6, 8 };
            Console.WriteLine(oneDimensional[0]);

            int[,] twoDimensional = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine(twoDimensional[0,0]);


            // JAGGED - collection of rows with DIFFERENT numbers of columns
            // define amount of rows (in first [] bracket)
            int[][] jaggedArray = new int[3][];

            // define amount of columns and contents
            jaggedArray[0] = new int[] { 1, 2, 4 };
            jaggedArray[1] = new int[] { 3, 4 };
            jaggedArray[2] = new int[] { 5, 6, 9 };
            // jaggedArray[3] = it will doesnt work

            Console.WriteLine(jaggedArray[0][1]);

            // WriteLine Tips

            // print in new line
/*            Console.WriteLine("new \nline \n");

            Console.WriteLine(age);

            Console.WriteLine("Write whatever");
            string test = Console.ReadLine();
            Console.WriteLine($"input test here: {test}");
            Console.WriteLine(test.GetType());

            Console.WriteLine("put the umber:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"your number is {num1}");
            Console.WriteLine($"age + num1 is: {age +  num1}");*/
        }
    }
}
