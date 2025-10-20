namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Tolkien", 700);

            Console.WriteLine(book1.title);

            Console.WriteLine(book1.IsHuge());
        }
    }
}
