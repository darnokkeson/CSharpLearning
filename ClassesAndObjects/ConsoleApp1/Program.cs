namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Tolkien", 700);

            EBook eBook1 = new EBook("Test1", "Test2", 250, "PDF");

            Console.WriteLine(book1.title);

            Console.WriteLine(book1.IsHuge());

            Console.WriteLine(eBook1.format);

            Console.WriteLine(eBook1.IsDigital());

        }
    }
}
