namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Paradise", "Hozho", 200);

            Console.WriteLine(song1.artist);
            // access to static variable
            Console.WriteLine(Song.songCount);
        }
    }
}
