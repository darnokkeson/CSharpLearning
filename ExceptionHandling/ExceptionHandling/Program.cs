namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcHandling();
        }

        static void ExcHandling()
        {
            string input = Console.ReadLine();

            try
            {
                int conInput = Convert.ToInt32(input);
            }
            catch (Exception e) 
            {
                // technical info about error
                Console.WriteLine($"Error e: {e}");

                // error in simple words
                Console.WriteLine($"Error e.Message: {e.Message}");
            }
            // overall is for closing file after saving exception from 'catch'
            finally
            {
                Console.WriteLine("code for close the file");
            }
        }
    }
}
