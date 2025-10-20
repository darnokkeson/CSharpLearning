using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestUserOut();
            //Console.WriteLine(UserOut());
            //Welcome();
            //Game();
        }

        static void TestUserOut()
        {
            int readValue = UserOut();
            Console.WriteLine(readValue);
        }

        // guess the number - GAME
        static void Game()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int userNumber;
            string userInput;

            Console.WriteLine(randomNumber);

            // I have to make this loop like as a seperated function with
            // return of userNumber
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out userNumber))
                {
                    Console.WriteLine($"You entered a number: {userNumber}");
                    break;
                }
                else
                {
                    Console.WriteLine("That's not a valid number!");
                }
            }


            while (true)
            {

                // I have to put here function with return of userNumber

                if (randomNumber == userNumber)
                {
                    Console.WriteLine($"is exactly {randomNumber}");
                    break;
                }
                else if (randomNumber > userNumber)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Too High");
                }
            }
        }

        static void Welcome()
        {
            Console.WriteLine("We’re gonna play 'Guess The Number' game.");
            Console.WriteLine("Guess the number from scope 1 - 100.");
        }

        static int UserOut()
        {
            int userNumber;
            string userInput;

            while (true)
            {
                Console.WriteLine("Enter a number: ");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out userNumber))
                {
                    Console.WriteLine($"You entered a number: {userNumber}");
                    return userNumber;
                    //break;
                }
                else
                {
                    Console.WriteLine("That's not a valid number!");
                }
            }
        }
    }
}