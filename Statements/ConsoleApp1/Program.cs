namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IfTest();
            StateTest();
            Console.WriteLine(GetMax(50, 10));
            Console.WriteLine(GetDaySwitch(0));
        }

        static void IfTest()
        {
            bool isMale = false;

            if (isMale)
            {
                Console.WriteLine("you are male");
            }
            else
            {
                Console.WriteLine("you are not male");
            }
        }

        static void StateTest()
        {
            int num1 = 1;

            if (num1 == 1)
            {
                Console.WriteLine("cycle");
                num1++;
            }
        }

        static int GetMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }

        static string GetDaySwitch(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Monday";
                    break;
                case 1:
                    dayName = "Tuesday";
                    break;
                case 2:
                    dayName = "Wednesday";
                    break;
                case 3:
                    dayName = "Thursday";
                    break;
                case 4:
                    dayName = "Friday";
                    break;
                case 5:
                    dayName = "Saturday";
                    break;
                case 6:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }



    }
}
