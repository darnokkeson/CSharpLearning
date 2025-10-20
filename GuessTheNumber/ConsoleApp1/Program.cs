using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            Guess();
        }

        // guess the number - GAME
        // generating random number and statement for guessing this number 
        // with counting of moves
        static void Guess()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int moves = 0;

            // debug look
            // Console.WriteLine(randomNumber);

            while (true)
            {
                int userNumber = UserOut();

                if (randomNumber == userNumber)
                {
                    moves++;
                    Console.WriteLine($"it's exactly {randomNumber}. You did {moves} moves.");
                    break;
                }
                else if (randomNumber > userNumber)
                {
                    moves++;
                    Console.WriteLine("Too low");
                }
                else
                {
                    moves++;
                    Console.WriteLine("Too High");
                }
            }
        }

        // return only int of user input and ask agan when not int
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
                }
                else
                {
                    Console.WriteLine("That's not a valid number!");
                }
            }
        }

        static void Welcome()
        {
            Console.WriteLine("We’re gonna play 'Guess The Number' game.");
            Console.WriteLine("Guess the number from scope 1 - 100.");
        }  
    }
}